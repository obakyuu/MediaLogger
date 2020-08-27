Imports System.IO
Imports System.Net
Imports System.Text

Partial Public Class config

    'プログラム終了判定(True:終了/False:終了しない)
    Private ExitFlag As Boolean = False
    '監視開始フラグ(0:監視していない/1:監視/2:検知後)
    Private StartFlag As Integer = 0
    'サウンドプレイヤー
    Private mediaPlayer As New WMPLib.WindowsMediaPlayer
    'ストップウォッチ
    Private sw As New Stopwatch()
    'ターゲットファイル(作成/更新を検知する対象ファイル)
    Private TargetFile As String
    'ログファイル(出力ファイルの名前を格納)
    Private LogFileName As String
    'カウンタ(テキストファイル左側のカウンタ)
    Private count As Integer = 1
    'ロックファイル(監視ディレクトリごと削除されるのを防ぐ目的。隠しファイルで生成され、拡張子は.Lock)
    Private lockFile As StreamWriter
    'キー監視
    WithEvents KeyboardHooker1 As New KeyboardHooker

    Public Sub New()
        ' The Me.InitializeComponent call is required for Windows Forms designer support.
        Me.InitializeComponent()
    End Sub

    Private Sub config_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '最新バージョン確認
        Call UpdateToolStripMenuItem_Click(sender, e)

        '更新しない場合は実行
        If ExitFlag = False Then

            'タスクトレイに格納
            NotifyIcon1.Visible = True
            'FileSystemWacherを無効化(なぜか勝手に有効化されてる時があるため)
            FileSystemWatcher1.EnableRaisingEvents = False
            '前回の設定項目の読み込み
            KeyComboBox.Text = My.Settings.KeySet
            MonitorTextBox.Text = My.Settings.MovieRef
            SoundTextBox.Text = My.Settings.SoundRef
            VolumeBar.Value = My.Settings.Volume
            '監視ディレクトリ存在確認
            If MonitorTextBox.Text <> "" AndAlso Directory.Exists(MonitorTextBox.Text) = False Then
                MessageBox.Show _
                ("監視ディレクトリの指定先が存在しませんでした。",
                My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                '初期化
                MonitorTextBox.Text = ""
            End If
            '音声ファイル存在確認
            If SoundTextBox.Text <> "" AndAlso File.Exists(SoundTextBox.Text) = False Then
                MessageBox.Show _
                ("指定した音声ファイルが存在しませんでした。",
                My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                '初期化
                SoundTextBox.Text = ""
            End If
            '再生判定
            If SoundTextBox.Text = "" Then
                SoundPlayButton.Enabled = False
            End If
            '音量判定
            If VolumeBar.Value = 0 Then
                SoundPlayButton.Enabled = False
            End If
            '音量調整
            mediaPlayer.settings.volume = VolumeBar.Value
            'スタート判定
            GetStartState()

        End If

    End Sub

    Private Sub KeyComboBox_TextChanged(sender As Object, e As EventArgs) _
        Handles KeyComboBox.TextChanged

        '保存
        My.Settings.KeySet = KeyComboBox.Text
        'スタート判定
        GetStartState()

    End Sub

    Private Sub MonitorTextBox_TextChanged(sender As Object, e As EventArgs) _
        Handles MonitorTextBox.TextChanged

        '保存
        My.Settings.MovieRef = MonitorTextBox.Text
        'スタート判定
        GetStartState()

    End Sub

    Private Sub MonitorButton_Click(sender As Object, e As EventArgs) _
        Handles MonitorButton.Click

        With FolderBrowserDialog1
            '上部に表示する説明テキストを指定する
            .Description = "監視対象ディレクトリを指定してください。"
            'ルートフォルダを指定する
            'デフォルトでDesktop
            .RootFolder = Environment.SpecialFolder.Desktop
            '最初に選択するフォルダを指定する
            'RootFolder以下にあるフォルダである必要がある
            .SelectedPath = ""
            'ユーザーが新しいフォルダを作成できるようにする(デフォルト:True)
            .ShowNewFolderButton = False
            'ダイアログを表示する
            If .ShowDialog(Me) = DialogResult.OK Then
                '選択されたフォルダを表示する
                MonitorTextBox.Text = .SelectedPath
            End If
        End With

    End Sub

    Private Sub SoundTextBox_TextChanged(sender As Object, e As EventArgs) _
        Handles SoundTextBox.TextChanged

        '保存
        My.Settings.SoundRef = SoundTextBox.Text
        '再生判定
        If SoundTextBox.Text <> "" Then
            If VolumeBar.Value <> 0 Then
                SoundPlayButton.Enabled = True
            Else
                SoundPlayButton.Enabled = False
            End If
        End If
        'スタート判定
        GetStartState()

    End Sub

    Private Sub SoundButton_Click(sender As Object, e As EventArgs) _
        Handles SoundButton.Click

        '音声ファイル指定
        GetWavFilePath()

    End Sub

    Private Sub SoundPlayButton_Click(sender As Object, e As EventArgs) _
        Handles SoundPlayButton.Click

        '再生
        Soundplay()

    End Sub

    Private Sub VolumeBar_ValueChanged(sender As Object, e As EventArgs) _
        Handles VolumeBar.ValueChanged

        '音量調整
        mediaPlayer.settings.volume = VolumeBar.Value
        '保存
        My.Settings.Volume = VolumeBar.Value
        '音量表示
        If VolumeBar.Value = 0 Then
            ToolTip1.SetToolTip(VolumeBar, "無音")
            SoundPlayButton.Enabled = False
        Else
            ToolTip1.SetToolTip(VolumeBar, VolumeBar.Value & "%")
            If SoundTextBox.Text <> "" Then
                SoundPlayButton.Enabled = True
            End If
        End If
        'スタート判定
        GetStartState()

    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) _
        Handles ResetButton.Click

        '全ての設定を初期化
        KeyComboBox.Text = "F12"
        MonitorTextBox.Text = ""
        SoundTextBox.Text = ""
        SoundPlayButton.Enabled = False
        VolumeBar.Value = 100

    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) _
        Handles StartButton.Click

        If StartFlag = 0 Then

            '監視開始
            Try
                'Lockファイル作成
                lockFile = New StreamWriter(MonitorTextBox.Text & "\.lock", True,
                    System.Text.Encoding.GetEncoding("utf-8"))
                '属性追加(隠しファイル)
                File.SetAttributes(MonitorTextBox.Text & "\.lock", FileAttribute.Hidden)

                'FileSystemWatcher起動
                With FileSystemWatcher1
                    .Path = MonitorTextBox.Text
                    .EnableRaisingEvents = True
                End With

                '再生中なら停止
                mediaPlayer.controls.stop()
                'バルーン表示
                With NotifyIcon1
                    .BalloonTipTitle = My.Application.Info.Title
                    .BalloonTipText = """" & FileSystemWatcher1.Path & """の監視を開始しました"
                    .ShowBalloonTip(3000)
                End With
                'TimeGroupのEnabledをTrue
                TimeGroupBox.Enabled = True
                '各所設定項目を無効化(実行中に変更を阻止)                
                KeyGroupBox.Enabled = False
                MonitorGroupBox.Enabled = False
                SoundGroupBox.Enabled = False
                ResetButton.Enabled = False
                'ボタン表示を変える
                StartButton.Text = "停止(&T)"
                'タスクアイコンを監視モードへ変更する
                NotifyIcon1.Icon = My.Resources.surveillance_icon
                'スタートフラグ
                StartFlag = 1
                '閉じる
                Me.Close()

            Catch ex As ArgumentException
                MessageBox.Show _
                    ("監視ディレクトリの指定先が存在しませんでした。",
                    My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                'MonitorTextBoxの初期化
                MonitorTextBox.Text = ""
                'ディレクトリ再指定
                Call MonitorButton_Click(sender, e)

            Catch ex As FileNotFoundException
                MessageBox.Show _
                    ("監視ディレクトリの指定先が存在しませんでした。",
                    My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                'MonitorTextBoxの初期化
                MonitorTextBox.Text = ""
                'ディレクトリ再指定
                Call MonitorButton_Click(sender, e)

            Catch ex As DirectoryNotFoundException
                MessageBox.Show _
                    ("監視ディレクトリの指定先が存在しませんでした。",
                    My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                'MonitorTextBoxの初期化
                MonitorTextBox.Text = ""
                'ディレクトリ再指定
                Call MonitorButton_Click(sender, e)

            End Try

        Else

            '監視を停止
            FileSystemWatcher1.EnableRaisingEvents = False
            'Lockファイル削除
            lockFile.Close()
            File.Delete(FileSystemWatcher1.Path & "\.lock")
            'タイマーを停止
            sw.Stop()
            sw.Reset()
            '時間ラベル関係を初期化
            TimeLabel.Text = "00:00:00.000"
            TimeGroupBox.Enabled = False
            'カウンタをリセット
            count = 1
            '各所設定項目を無効化(実行中に変更を阻止)
            KeyGroupBox.Enabled = True
            MonitorGroupBox.Enabled = True
            SoundGroupBox.Enabled = True
            ResetButton.Enabled = True
            'フラグ変更
            StartFlag = 0
            'ターゲット初期化
            TargetFile = ""
            'ボタン表示を戻す
            StartButton.Text = "開始(&T)"
            'タスクアイコンを待機モードへ変更する
            NotifyIcon1.Icon = My.Resources.stand_icon
            'バルーン表示
            With NotifyIcon1
                .BalloonTipTitle = My.Application.Info.Title
                .BalloonTipIcon = ToolTipIcon.None
                .BalloonTipText = "記録を停止しました。"
                .ShowBalloonTip(3000)
            End With

        End If

    End Sub

    Private Sub FileSystemWatcher1_Created(sender As Object, e As IO.FileSystemEventArgs) _
        Handles FileSystemWatcher1.Created

        If StartFlag = 1 Then

            '計測開始
            sw.Start()
            Timer1.Enabled = True
            StartFlag = 2
            'Lockファイル削除
            lockFile.Close()
            File.Delete(FileSystemWatcher1.Path & "\.lock")
            'ターゲット補足
            TargetFile = e.FullPath
            '名前を決定(フルパス)
            LogFileName = e.FullPath.Substring(0, e.FullPath.LastIndexOf("\") + 1) &
                DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")
            'タスクアイコンをログ取得モードへ変更する
            NotifyIcon1.Icon = My.Resources.start_icon
            'バルーン表示
            With NotifyIcon1
                .BalloonTipTitle = My.Application.Info.Title
                .BalloonTipText = """" & TargetFile & "の記録を開始しました。"
                .ShowBalloonTip(3000)
            End With

        End If

    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As FileSystemEventArgs) _
        Handles FileSystemWatcher1.Changed

        '動画収録終了判定
        If StartFlag = 2 AndAlso TargetFile = e.FullPath Then
            '終了
            StartButton.PerformClick()

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '時間反映
        TimeLabel.Text =
            sw.Elapsed.Hours.ToString("00") & ":" &
            sw.Elapsed.Minutes.ToString("00") & ":" &
            sw.Elapsed.Seconds.ToString("00") & ":" &
            sw.Elapsed.Milliseconds.ToString("000")

    End Sub

    Private Sub ConfigToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles ConfigToolStripMenuItem.Click, NotifyIcon1.MouseDoubleClick

        '設定画面表示
        Me.WindowState = FormWindowState.Normal
        ShowInTaskbar = True

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles UpdateToolStripMenuItem.Click

        '同じボタンを二度押されない処理
        UpdateToolStripMenuItem.Enabled = False

        Try
            'URL先のHTMLを取得(UTF-8)
            Dim enc As Encoding = Encoding.GetEncoding("UTF-8")
            Dim url As String = "https://github.com/obakyuu/MediaLogger/releases"

            Dim req As WebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()

            Dim st As Stream = res.GetResponseStream()
            Dim sr As StreamReader = New StreamReader(st, enc)
            Dim html As String = sr.ReadToEnd()
            sr.Close()
            st.Close()

            '最新バージョン取得
            Dim Nver As Double = Double.Parse(html.Substring(html.IndexOf("【v") + 2, 4))
            '現在バージョンと最新バージョンを比較
            If Nver = My.Settings.Version Then
                '既に最新バージョン
                MessageBox.Show _
                ("最新バージョンを使用しています。(v." & My.Settings.Version.ToString("F2") & ")",
                 "更新確認", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf Nver > My.Settings.Version Then
                '新しいバージョンが公開されている
                If MessageBox.Show _
                ("最新バージョンが公開されています。(v." & Nver.ToString("F2") & ")" & vbNewLine &
                "ダウンロードしますか？", "更新確認", MessageBoxButtons.OKCancel,
                               MessageBoxIcon.Information) = DialogResult.OK Then
                    '公開ページへ飛ぶ
                    Process.Start _
                    ("https://github.com/obakyuu/MediaLogger/releases/latest")
                    'アプリを終了
                    ExitFlag = True
                    Me.Close()

                End If

            ElseIf Nver < My.Settings.Version Then
                '公開されているバージョンより最新バージョンのソフトを使っている場合
                MessageBox.Show _
                ("GitHubに最新バージョンを適用できていません。" & vbNewLine &
                "公開バージョン(v." & Nver.ToString("F2") & ")" & vbNewLine &
                "開発バージョン(v." & My.Settings.Version.ToString("F2") & ")",
                "更新確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                'エラーの場合
                If MessageBox.Show _
                ("バージョン情報を正常に読み込めませんでした。公開サイトへアクセスしますか？", "更新確認",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                    '公開ページへ飛ぶ
                    Process.Start _
                    ("https://github.com/obakyuu/MediaLogger/releases/latest")
                    'アプリを終了
                    ExitFlag = True
                    Me.Close()
                End If

            End If

        Catch ex As WebException
            MessageBox.Show _
                ("ネットワークに接続出来ない為、バージョン確認ができませんでした。" & vbNewLine &
                "タスクトレイ上のアイコンを右クリック後、更新を押すことで再度確認できます。",
                "更新確認", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'プロシージャ終了
            Exit Sub

        Catch ex As Exception
            MessageBox.Show _
                ("想定外のエラーが発生しました。",
                 "更新確認", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'プロシージャ終了
            Exit Sub

        Finally
            '再度実行可能に戻す
            UpdateToolStripMenuItem.Enabled = True

        End Try

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles ExitToolStripMenuItem.Click

        '監視中に終了した場合はLockファイルを消す必要がある
        If StartFlag = 1 Then

            '監視中に関する警告
            If MessageBox.Show _
                ("""" & MonitorTextBox.Text & """ を監視中ですが、終了してもよろしいですか？",
                  "警告", MessageBoxButtons.OKCancel,
                               MessageBoxIcon.Warning) = DialogResult.OK Then
                'Lockファイル削除
                lockFile.Close()
                File.Delete(MonitorTextBox.Text & "\.lock")
                '終了判定
                ExitFlag = True
                Me.Close()

            End If

        ElseIf StartFlag = 2 Then

            '記録中に関する警告
            If MessageBox.Show _
                ("記録中ですが、終了してもよろしいですか？",
                  "警告", MessageBoxButtons.OKCancel,
                               MessageBoxIcon.Warning) = DialogResult.OK Then
                '終了判定
                ExitFlag = True
                Me.Close()

            End If

        Else
            '終了判定
            ExitFlag = True
            Me.Close()

        End If

    End Sub

    Private Sub config_FormClosing(sender As Object, e As FormClosingEventArgs) _
        Handles MyBase.FormClosing

        'プログラム終了判定(真:終了しない/偽:終了する)
        If ExitFlag = False Then
            '最小化
            Me.WindowState = FormWindowState.Minimized
            'タスクバーから削除
            ShowInTaskbar = False
            'アプリを終了する方法をバルーンで通知する
            If StartFlag = 0 Then
                '開始ボタンを押した際は強制的にウィンドウが閉じられるので、その時はバルーン通知はしない
                With NotifyIcon1
                    .BalloonTipIcon = ToolTipIcon.Info
                    .BalloonTipText = "アプリを終了するには、" + My.Application.Info.Title +
                        "のタスクアイコンを右クリックし、終了を選択してください。"
                    .ShowBalloonTip(7000)
                End With
            End If
            'イベントをキャンセルします。
            e.Cancel = True

        Else

            'タスクトレイから削除
            NotifyIcon1.Visible = False
            '再生停止
            mediaPlayer.controls.stop()
            '----------
            'アプリ終了
            '----------

        End If

    End Sub


    '==========================================================================
    'プロシージャ/関数
    '==========================================================================

    '開始判定
    Sub GetStartState()

        '全ての値が空か確認
        If VolumeBar.Value = 0 Then
            If KeyComboBox.Text <> "" AndAlso MonitorTextBox.Text <> "" Then
                StartButton.Enabled = True
            Else
                StartButton.Enabled = False
            End If
        Else
            If KeyComboBox.Text <> "" AndAlso MonitorTextBox.Text <> "" AndAlso
                SoundTextBox.Text <> "" Then
                StartButton.Enabled = True
            Else
                StartButton.Enabled = False
            End If
        End If

    End Sub

    '音声ファイル取得
    Sub GetWavFilePath()

        With OpenFileDialog1
            'ファイル名のクリア
            .FileName = ""
            'ディレクトリ
            .InitialDirectory = ""
            'タイトル
            .Title = "音声ファイルを選択してください"
            'フィルター
            .Filter =
                "音声ファイル(*.wav;*.mp3;*.m4a;*.aac;*.flac)|*.wav;*.mp3;*.m4a;*.aac;*.flac|" &
                "Waveファイル(*.wav)|*.wav|" &
                "MP3ファイル(*.mp3)|*.wav|" &
                "MP4オーディオファイル(*.m4a)|*.m4a|" &
                "AACファイル(*.aac)|*.aac|" &
                "FLACファイル(*.flac)|*.flac|" &
                "すべてのファイル(*.*)|*.*"
            '既存フィルタリング
            .FilterIndex = 1
            '前のディレクトリの保存
            .RestoreDirectory = True
            'キャンセル時は終了
            If .ShowDialog = DialogResult.OK Then
                SoundTextBox.Text = .FileName
            End If

        End With

    End Sub

    Sub Soundplay()

        '再生判定
        If File.Exists(SoundTextBox.Text) Then
            '再生可能
            mediaPlayer.URL = SoundTextBox.Text
        Else
            '再生不可能
            MessageBox.Show _
                    ("音声ファイルを確認できませんでした。", My.Application.Info.Title,
                     MessageBoxButtons.OK, MessageBoxIcon.Error)
            '初期化
            SoundTextBox.Text = ""
            '指定
            GetWavFilePath()
        End If

    End Sub

    'キー監視
    Sub KeybordHooker1_KeyDown(sender As Object, e As KeyBoardHookerEventArgs) _
        Handles KeyboardHooker1.KeyDown
        'キーが押下判定
        If CStr(e.vkCode) = GetKeyCombo(KeyComboBox.Text) Then
            '監視判定
            If StartFlag = 0 Then

                'バルーン表示
                With NotifyIcon1
                    .BalloonTipIcon = ToolTipIcon.Warning
                    .BalloonTipText = "開始を押してください。"
                    .ShowBalloonTip(3000)
                End With

            ElseIf StartFlag = 1 Then

                'バルーン表示
                With NotifyIcon1
                    .BalloonTipIcon = ToolTipIcon.Warning
                    .BalloonTipText = """" & FileSystemWatcher1.Path &
                        """ディレクトリ内でファイル生成を検知していません。"
                    .ShowBalloonTip(3000)
                End With

            ElseIf StartFlag = 2 Then

                'Shift JISで書き込む
                '書き込むファイルが既に存在している場合は、ファイルの末尾に追加する
                Dim lw As New StreamWriter _
                    (LogFileName & ".txt", True,
                     Encoding.GetEncoding("shift_jis"))
                'TextBox1.Textの内容を書き込む
                lw.WriteLine(
                    "[" & String.Format("{0:000}", count) & "] " &
                    sw.Elapsed.Hours.ToString("00") & ":" &
                    sw.Elapsed.Minutes.ToString("00") & ":" &
                    sw.Elapsed.Seconds.ToString("00"))
                'インクリメント
                count += 1
                '閉じる
                lw.Close()
                '無音判定
                If VolumeBar.Value <> 0 Then
                    '再生
                    Soundplay()
                End If
                'ログを記録した時のみ別のスレッドを生成
                LogAsync()

            End If

        End If

    End Sub

    'タスク(ログを記録した瞬間にのみ生成する非同期タスク)
    Public Async Function LogAsync() As Task
        Dim task As Task = Task.Run(
        Sub()
            'アイコンが一瞬赤くなる
            NotifyIcon1.Icon = My.Resources.record_icon
            System.Threading.Thread.Sleep(50)
            NotifyIcon1.Icon = My.Resources.start_icon
        End Sub
    )
        Await task
    End Function


    'キーコード取得関数
    Function GetKeyCombo(ByVal CombText As String) As Integer

        Select Case CombText
            Case "A"
                Return 65
            Case "B"
                Return 66
            Case "C"
                Return 67
            Case "D"
                Return 68
            Case "E"
                Return 69
            Case "F"
                Return 70
            Case "G"
                Return 71
            Case "H"
                Return 72
            Case "I"
                Return 73
            Case "J"
                Return 74
            Case "K"
                Return 75
            Case "L"
                Return 76
            Case "M"
                Return 77
            Case "N"
                Return 78
            Case "O"
                Return 79
            Case "P"
                Return 80
            Case "Q"
                Return 81
            Case "R"
                Return 82
            Case "S"
                Return 83
            Case "T"
                Return 84
            Case "U"
                Return 85
            Case "V"
                Return 86
            Case "W"
                Return 87
            Case "X"
                Return 88
            Case "Y"
                Return 89
            Case "Z"
                Return 90
            Case "0"
                Return 48
            Case "1"
                Return 49
            Case "2"
                Return 50
            Case "3"
                Return 51
            Case "4"
                Return 52
            Case "5"
                Return 53
            Case "6"
                Return 54
            Case "7"
                Return 55
            Case "8"
                Return 56
            Case "9"
                Return 57
            Case "F1"
                Return 112
            Case "F2"
                Return 113
            Case "F3"
                Return 114
            Case "F4"
                Return 115
            Case "F5"
                Return 116
            Case "F6"
                Return 117
            Case "F7"
                Return 118
            Case "F8"
                Return 119
            Case "F9"
                Return 120
            Case "F10"
                Return 121
            Case "F11"
                Return 122
            Case "F12"
                Return 123
            Case "BackSpace"
                Return 8
            Case "Enter"
                Return 13
            Case "Pause"
                Return 19
            Case "変換"
                Return 28
            Case "無変換"
                Return 29
            Case "Space"
                Return 32
            Case "PageUp"
                Return 33
            Case "PageDown"
                Return 34
            Case "End"
                Return 35
            Case "Home"
                Return 36
            Case "←"
                Return 37
            Case "↑"
                Return 38
            Case "→"
                Return 39
            Case "↓"
                Return 40
            Case "Insert"
                Return 45
            Case "Delete"
                Return 46
            Case "NumLock"
                Return 144
            Case "ScrollLock"
                Return 145
            Case "英数"
                Return 240
            Case "カタ/ひら"
                Return 242
            Case "Tab"
                Return 9
            Case Else
                'デフォルト(F12)
                Return 123
        End Select

    End Function

End Class
