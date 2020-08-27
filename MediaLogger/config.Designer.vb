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
        Me.KeyComboBox = New System.Windows.Forms.ComboBox()
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
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KeyGroupBox.SuspendLayout()
        Me.TimeGroupBox.SuspendLayout()
        Me.MonitorGroupBox.SuspendLayout()
        Me.SoundGroupBox.SuspendLayout()
        CType(Me.VolumeBar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.KeyGroupBox.Controls.Add(Me.KeyComboBox)
        Me.KeyGroupBox.Location = New System.Drawing.Point(12, 13)
        Me.KeyGroupBox.Name = "KeyGroupBox"
        Me.KeyGroupBox.Size = New System.Drawing.Size(85, 54)
        Me.KeyGroupBox.TabIndex = 0
        Me.KeyGroupBox.TabStop = False
        Me.KeyGroupBox.Text = "キー設定"
        '
        'KeyComboBox
        '
        Me.KeyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.KeyComboBox.FormattingEnabled = True
        Me.KeyComboBox.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "BackSpace", "Enter", "Pause", "変換", "無変換", "Space", "PageUp", "PageDown", "End", "Home", "←", "↑", "→", "↓", "Insert", "Delete", "NumLock", "ScrollLock", "英数", "カタ/ひら", "Tab"})
        Me.KeyComboBox.Location = New System.Drawing.Point(6, 19)
        Me.KeyComboBox.Name = "KeyComboBox"
        Me.KeyComboBox.Size = New System.Drawing.Size(73, 20)
        Me.KeyComboBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.KeyComboBox, "記録をするキーを指定してください。他のアプリのショートカットキーと被らないキーにしましょう")
        '
        'TimeGroupBox
        '
        Me.TimeGroupBox.Controls.Add(Me.TimeLabel)
        Me.TimeGroupBox.Enabled = False
        Me.TimeGroupBox.Location = New System.Drawing.Point(103, 13)
        Me.TimeGroupBox.Name = "TimeGroupBox"
        Me.TimeGroupBox.Size = New System.Drawing.Size(169, 54)
        Me.TimeGroupBox.TabIndex = 1
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
        Me.MonitorGroupBox.Location = New System.Drawing.Point(12, 73)
        Me.MonitorGroupBox.Name = "MonitorGroupBox"
        Me.MonitorGroupBox.Size = New System.Drawing.Size(260, 49)
        Me.MonitorGroupBox.TabIndex = 2
        Me.MonitorGroupBox.TabStop = False
        Me.MonitorGroupBox.Text = "監視ディレクトリ"
        '
        'MonitorTextBox
        '
        Me.MonitorTextBox.Location = New System.Drawing.Point(6, 19)
        Me.MonitorTextBox.Name = "MonitorTextBox"
        Me.MonitorTextBox.ReadOnly = True
        Me.MonitorTextBox.Size = New System.Drawing.Size(167, 19)
        Me.MonitorTextBox.TabIndex = 0
        '
        'MonitorButton
        '
        Me.MonitorButton.Location = New System.Drawing.Point(179, 17)
        Me.MonitorButton.Name = "MonitorButton"
        Me.MonitorButton.Size = New System.Drawing.Size(75, 23)
        Me.MonitorButton.TabIndex = 1
        Me.MonitorButton.Text = "参照(&M)"
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
        Me.SoundGroupBox.Location = New System.Drawing.Point(12, 128)
        Me.SoundGroupBox.Name = "SoundGroupBox"
        Me.SoundGroupBox.Size = New System.Drawing.Size(260, 74)
        Me.SoundGroupBox.TabIndex = 3
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
        Me.VolumeBar.Size = New System.Drawing.Size(167, 23)
        Me.VolumeBar.TabIndex = 2
        Me.VolumeBar.TickFrequency = 10
        '
        'SoundPlayButton
        '
        Me.SoundPlayButton.Enabled = False
        Me.SoundPlayButton.Location = New System.Drawing.Point(179, 44)
        Me.SoundPlayButton.Name = "SoundPlayButton"
        Me.SoundPlayButton.Size = New System.Drawing.Size(75, 23)
        Me.SoundPlayButton.TabIndex = 3
        Me.SoundPlayButton.Text = "再生(&P)"
        Me.ToolTip1.SetToolTip(Me.SoundPlayButton, "再生します")
        Me.SoundPlayButton.UseVisualStyleBackColor = True
        '
        'SoundButton
        '
        Me.SoundButton.Location = New System.Drawing.Point(179, 17)
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
        Me.SoundTextBox.Size = New System.Drawing.Size(167, 19)
        Me.SoundTextBox.TabIndex = 0
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(12, 208)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(125, 23)
        Me.ResetButton.TabIndex = 4
        Me.ResetButton.Text = "初期化(&R)"
        Me.ToolTip1.SetToolTip(Me.ResetButton, "キー指定、監視ディレクトリ、サウンド、ボリュームが初期化されます")
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.Enabled = False
        Me.StartButton.Location = New System.Drawing.Point(147, 208)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(125, 23)
        Me.StartButton.TabIndex = 5
        Me.StartButton.Text = "開始(&T)"
        Me.ToolTip1.SetToolTip(Me.StartButton, "監視を開始します")
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 241)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.KeyGroupBox)
        Me.Controls.Add(Me.TimeGroupBox)
        Me.Controls.Add(Me.MonitorGroupBox)
        Me.Controls.Add(Me.SoundGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents MonitorGroupBox As GroupBox
    Friend WithEvents TimeGroupBox As GroupBox
    Friend WithEvents KeyGroupBox As GroupBox
    Friend WithEvents KeyComboBox As ComboBox
    Friend WithEvents TimeLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MonitorTextBox As TextBox
    Friend WithEvents MonitorButton As Button
    Friend WithEvents SoundGroupBox As GroupBox
    Friend WithEvents SoundButton As Button
    Friend WithEvents SoundTextBox As TextBox
    Friend WithEvents SoundPlayButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents StartButton As Button
    Friend WithEvents ConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Separator As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolumeBar As TrackBar
    Friend WithEvents ToolTip1 As ToolTip
End Class
