<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class config
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(config))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Separator = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.KeyGroupBox = New System.Windows.Forms.GroupBox()
        Me.KeyBindButton = New System.Windows.Forms.Button()
        Me.TimeGroupBox = New System.Windows.Forms.GroupBox()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.MonitorGroupBox = New System.Windows.Forms.GroupBox()
        Me.MonitorTextBox = New System.Windows.Forms.TextBox()
        Me.MonitorButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SoundGroupBox = New System.Windows.Forms.GroupBox()
        Me.VolumeBar = New System.Windows.Forms.TrackBar()
        Me.SoundPlayButton = New System.Windows.Forms.Button()
        Me.SoundButton = New System.Windows.Forms.Button()
        Me.SoundTextBox = New System.Windows.Forms.TextBox()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSeparatorToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpReadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpSeparatorToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpGitHubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KeyGroupBox.SuspendLayout()
        Me.TimeGroupBox.SuspendLayout()
        Me.MonitorGroupBox.SuspendLayout()
        Me.SoundGroupBox.SuspendLayout()
        CType(Me.VolumeBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "MediaLogger"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.Separator, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(99, 76)
        '
        'ConfigToolStripMenuItem
        '
        Me.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem"
        Me.ConfigToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.ConfigToolStripMenuItem.Text = "設定"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.UpdateToolStripMenuItem.Text = "更新"
        '
        'Separator
        '
        Me.Separator.Name = "Separator"
        Me.Separator.Size = New System.Drawing.Size(95, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.ExitToolStripMenuItem.Text = "終了"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.IncludeSubdirectories = True
        Me.FileSystemWatcher1.NotifyFilter = CType((System.IO.NotifyFilters.FileName Or System.IO.NotifyFilters.LastWrite), System.IO.NotifyFilters)
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'KeyGroupBox
        '
        Me.KeyGroupBox.Controls.Add(Me.KeyBindButton)
        Me.KeyGroupBox.Location = New System.Drawing.Point(12, 27)
        Me.KeyGroupBox.Name = "KeyGroupBox"
        Me.KeyGroupBox.Size = New System.Drawing.Size(95, 54)
        Me.KeyGroupBox.TabIndex = 1
        Me.KeyGroupBox.TabStop = False
        Me.KeyGroupBox.Text = "キー設定"
        '
        'KeyBindButton
        '
        Me.KeyBindButton.Location = New System.Drawing.Point(6, 19)
        Me.KeyBindButton.Name = "KeyBindButton"
        Me.KeyBindButton.Size = New System.Drawing.Size(83, 23)
        Me.KeyBindButton.TabIndex = 0
        Me.KeyBindButton.Text = "None"
        Me.ToolTip1.SetToolTip(Me.KeyBindButton, "ログ指定キーを設定します")
        Me.KeyBindButton.UseVisualStyleBackColor = True
        '
        'TimeGroupBox
        '
        Me.TimeGroupBox.Controls.Add(Me.TimeLabel)
        Me.TimeGroupBox.Enabled = False
        Me.TimeGroupBox.Location = New System.Drawing.Point(113, 27)
        Me.TimeGroupBox.Name = "TimeGroupBox"
        Me.TimeGroupBox.Size = New System.Drawing.Size(169, 54)
        Me.TimeGroupBox.TabIndex = 2
        Me.TimeGroupBox.TabStop = False
        Me.TimeGroupBox.Text = "計測経過時間"
        '
        'TimeLabel
        '
        Me.TimeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimeLabel.Font = New System.Drawing.Font("メイリオ", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(3, 15)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(163, 36)
        Me.TimeLabel.TabIndex = 0
        Me.TimeLabel.Text = "00:00:00.000"
        Me.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonitorGroupBox
        '
        Me.MonitorGroupBox.Controls.Add(Me.MonitorTextBox)
        Me.MonitorGroupBox.Controls.Add(Me.MonitorButton)
        Me.MonitorGroupBox.Location = New System.Drawing.Point(12, 87)
        Me.MonitorGroupBox.Name = "MonitorGroupBox"
        Me.MonitorGroupBox.Size = New System.Drawing.Size(270, 49)
        Me.MonitorGroupBox.TabIndex = 3
        Me.MonitorGroupBox.TabStop = False
        Me.MonitorGroupBox.Text = "監視ディレクトリ"
        '
        'MonitorTextBox
        '
        Me.MonitorTextBox.Location = New System.Drawing.Point(6, 19)
        Me.MonitorTextBox.Name = "MonitorTextBox"
        Me.MonitorTextBox.ReadOnly = True
        Me.MonitorTextBox.Size = New System.Drawing.Size(177, 19)
        Me.MonitorTextBox.TabIndex = 0
        '
        'MonitorButton
        '
        Me.MonitorButton.Location = New System.Drawing.Point(189, 17)
        Me.MonitorButton.Name = "MonitorButton"
        Me.MonitorButton.Size = New System.Drawing.Size(75, 23)
        Me.MonitorButton.TabIndex = 1
        Me.MonitorButton.Text = "参照(&D)"
        Me.ToolTip1.SetToolTip(Me.MonitorButton, "ファイルの生成を感知するディレクトリを指定します")
        Me.MonitorButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'SoundGroupBox
        '
        Me.SoundGroupBox.Controls.Add(Me.VolumeBar)
        Me.SoundGroupBox.Controls.Add(Me.SoundPlayButton)
        Me.SoundGroupBox.Controls.Add(Me.SoundButton)
        Me.SoundGroupBox.Controls.Add(Me.SoundTextBox)
        Me.SoundGroupBox.Location = New System.Drawing.Point(12, 142)
        Me.SoundGroupBox.Name = "SoundGroupBox"
        Me.SoundGroupBox.Size = New System.Drawing.Size(270, 74)
        Me.SoundGroupBox.TabIndex = 4
        Me.SoundGroupBox.TabStop = False
        Me.SoundGroupBox.Text = "サウンド"
        '
        'VolumeBar
        '
        Me.VolumeBar.AutoSize = False
        Me.VolumeBar.LargeChange = 10
        Me.VolumeBar.Location = New System.Drawing.Point(6, 44)
        Me.VolumeBar.Maximum = 100
        Me.VolumeBar.Name = "VolumeBar"
        Me.VolumeBar.Size = New System.Drawing.Size(177, 23)
        Me.VolumeBar.TabIndex = 2
        Me.VolumeBar.TickFrequency = 10
        '
        'SoundPlayButton
        '
        Me.SoundPlayButton.Enabled = False
        Me.SoundPlayButton.Location = New System.Drawing.Point(189, 44)
        Me.SoundPlayButton.Name = "SoundPlayButton"
        Me.SoundPlayButton.Size = New System.Drawing.Size(75, 23)
        Me.SoundPlayButton.TabIndex = 3
        Me.SoundPlayButton.Text = "再生(&P)"
        Me.ToolTip1.SetToolTip(Me.SoundPlayButton, "再生します")
        Me.SoundPlayButton.UseVisualStyleBackColor = True
        '
        'SoundButton
        '
        Me.SoundButton.Location = New System.Drawing.Point(189, 17)
        Me.SoundButton.Name = "SoundButton"
        Me.SoundButton.Size = New System.Drawing.Size(75, 23)
        Me.SoundButton.TabIndex = 1
        Me.SoundButton.Text = "参照(&S)"
        Me.ToolTip1.SetToolTip(Me.SoundButton, "記録の際に鳴らす効果音を指定します")
        Me.SoundButton.UseVisualStyleBackColor = True
        '
        'SoundTextBox
        '
        Me.SoundTextBox.Location = New System.Drawing.Point(6, 19)
        Me.SoundTextBox.Name = "SoundTextBox"
        Me.SoundTextBox.ReadOnly = True
        Me.SoundTextBox.Size = New System.Drawing.Size(177, 19)
        Me.SoundTextBox.TabIndex = 0
        '
        'StartButton
        '
        Me.StartButton.Enabled = False
        Me.StartButton.Location = New System.Drawing.Point(12, 222)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(270, 23)
        Me.StartButton.TabIndex = 5
        Me.StartButton.Text = "開始(&T)"
        Me.ToolTip1.SetToolTip(Me.StartButton, "監視を開始します")
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(297, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuResetToolStripMenuItem, Me.MenuSeparatorToolStripMenuItem, Me.MenuExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.MenuToolStripMenuItem.Text = "メニュー(&M)"
        '
        'MenuResetToolStripMenuItem
        '
        Me.MenuResetToolStripMenuItem.Name = "MenuResetToolStripMenuItem"
        Me.MenuResetToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MenuResetToolStripMenuItem.Text = "初期化(&R)"
        '
        'MenuSeparatorToolStripMenuItem
        '
        Me.MenuSeparatorToolStripMenuItem.Name = "MenuSeparatorToolStripMenuItem"
        Me.MenuSeparatorToolStripMenuItem.Size = New System.Drawing.Size(177, 6)
        '
        'MenuExitToolStripMenuItem
        '
        Me.MenuExitToolStripMenuItem.Name = "MenuExitToolStripMenuItem"
        Me.MenuExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MenuExitToolStripMenuItem.Text = "終了(&E)"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpReadToolStripMenuItem, Me.HelpUpdateToolStripMenuItem, Me.HelpSeparatorToolStripMenuItem, Me.HelpGitHubToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.HelpToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'HelpReadToolStripMenuItem
        '
        Me.HelpReadToolStripMenuItem.Name = "HelpReadToolStripMenuItem"
        Me.HelpReadToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HelpReadToolStripMenuItem.Text = "使い方(&R)"
        '
        'HelpUpdateToolStripMenuItem
        '
        Me.HelpUpdateToolStripMenuItem.Name = "HelpUpdateToolStripMenuItem"
        Me.HelpUpdateToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HelpUpdateToolStripMenuItem.Text = "更新(&U)"
        '
        'HelpSeparatorToolStripMenuItem
        '
        Me.HelpSeparatorToolStripMenuItem.Name = "HelpSeparatorToolStripMenuItem"
        Me.HelpSeparatorToolStripMenuItem.Size = New System.Drawing.Size(177, 6)
        '
        'HelpGitHubToolStripMenuItem
        '
        Me.HelpGitHubToolStripMenuItem.Name = "HelpGitHubToolStripMenuItem"
        Me.HelpGitHubToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HelpGitHubToolStripMenuItem.Text = "GitHub(&G)"
        '
        'BindTimer
        '
        Me.BindTimer.Interval = 1000
        '
        'config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 256)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.KeyGroupBox)
        Me.Controls.Add(Me.TimeGroupBox)
        Me.Controls.Add(Me.MonitorGroupBox)
        Me.Controls.Add(Me.SoundGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "config"
        Me.Text = "設定"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KeyGroupBox.ResumeLayout(False)
        Me.TimeGroupBox.ResumeLayout(False)
        Me.MonitorGroupBox.ResumeLayout(False)
        Me.MonitorGroupBox.PerformLayout()
        Me.SoundGroupBox.ResumeLayout(False)
        Me.SoundGroupBox.PerformLayout()
        CType(Me.VolumeBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents MonitorGroupBox As GroupBox
    Friend WithEvents TimeGroupBox As GroupBox
    Friend WithEvents KeyGroupBox As GroupBox
    Friend WithEvents TimeLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MonitorTextBox As TextBox
    Friend WithEvents MonitorButton As Button
    Friend WithEvents SoundGroupBox As GroupBox
    Friend WithEvents SoundButton As Button
    Friend WithEvents SoundTextBox As TextBox
    Friend WithEvents SoundPlayButton As Button
    Friend WithEvents StartButton As Button
    Friend WithEvents ConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Separator As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolumeBar As TrackBar
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuSeparatorToolStripMenuItem As ToolStripSeparator
    Friend WithEvents MenuExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpReadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpUpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpSeparatorToolStripMenuItem As ToolStripSeparator
    Friend WithEvents HelpGitHubToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeyBindButton As Button
    Friend WithEvents BindTimer As Timer
End Class
