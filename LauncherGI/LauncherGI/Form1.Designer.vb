<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Tx_W = New System.Windows.Forms.TextBox()
        Me.Tx_H = New System.Windows.Forms.TextBox()
        Me.CB_Graphics = New System.Windows.Forms.ComboBox()
        Me.Tx_Game = New System.Windows.Forms.TextBox()
        Me.btn_StartGame = New System.Windows.Forms.Button()
        Me.btn_FolderGame = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_Resolusi = New System.Windows.Forms.CheckBox()
        Me.CB_Presets = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_Window = New System.Windows.Forms.CheckBox()
        Me.cb_Border = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_lowset = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_ver = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lv_AccList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSaveAcc = New System.Windows.Forms.Button()
        Me.BtnSwitchAcc = New System.Windows.Forms.Button()
        Me.btnDeleteAcc = New System.Windows.Forms.Button()
        Me.BtnKill = New System.Windows.Forms.Button()
        Me.cb_autoRestart = New System.Windows.Forms.CheckBox()
        Me.cb_NoPop = New System.Windows.Forms.CheckBox()
        Me.cb_MultiAcc = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tx_W
        '
        Me.Tx_W.Location = New System.Drawing.Point(65, 42)
        Me.Tx_W.Name = "Tx_W"
        Me.Tx_W.Size = New System.Drawing.Size(156, 20)
        Me.Tx_W.TabIndex = 0
        '
        'Tx_H
        '
        Me.Tx_H.Location = New System.Drawing.Point(65, 69)
        Me.Tx_H.Name = "Tx_H"
        Me.Tx_H.Size = New System.Drawing.Size(156, 20)
        Me.Tx_H.TabIndex = 1
        '
        'CB_Graphics
        '
        Me.CB_Graphics.FormattingEnabled = True
        Me.CB_Graphics.ItemHeight = 13
        Me.CB_Graphics.Items.AddRange(New Object() {"Default", "Fastest", "Fast", "Simple", "Good", "Beautiful", "Fantastic", "Console"})
        Me.CB_Graphics.Location = New System.Drawing.Point(98, 129)
        Me.CB_Graphics.Name = "CB_Graphics"
        Me.CB_Graphics.Size = New System.Drawing.Size(126, 21)
        Me.CB_Graphics.TabIndex = 2
        '
        'Tx_Game
        '
        Me.Tx_Game.Location = New System.Drawing.Point(65, 162)
        Me.Tx_Game.Name = "Tx_Game"
        Me.Tx_Game.Size = New System.Drawing.Size(159, 20)
        Me.Tx_Game.TabIndex = 3
        '
        'btn_StartGame
        '
        Me.btn_StartGame.Location = New System.Drawing.Point(15, 199)
        Me.btn_StartGame.Name = "btn_StartGame"
        Me.btn_StartGame.Size = New System.Drawing.Size(283, 48)
        Me.btn_StartGame.TabIndex = 4
        Me.btn_StartGame.Text = "Start"
        Me.btn_StartGame.UseVisualStyleBackColor = True
        '
        'btn_FolderGame
        '
        Me.btn_FolderGame.Location = New System.Drawing.Point(227, 161)
        Me.btn_FolderGame.Name = "btn_FolderGame"
        Me.btn_FolderGame.Size = New System.Drawing.Size(68, 20)
        Me.btn_FolderGame.TabIndex = 5
        Me.btn_FolderGame.Text = "..."
        Me.btn_FolderGame.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Width :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Height : "
        '
        'cb_Resolusi
        '
        Me.cb_Resolusi.AutoSize = True
        Me.cb_Resolusi.Location = New System.Drawing.Point(227, 15)
        Me.cb_Resolusi.Name = "cb_Resolusi"
        Me.cb_Resolusi.Size = New System.Drawing.Size(61, 17)
        Me.cb_Resolusi.TabIndex = 8
        Me.cb_Resolusi.Text = "Custom"
        Me.cb_Resolusi.UseVisualStyleBackColor = True
        '
        'CB_Presets
        '
        Me.CB_Presets.FormattingEnabled = True
        Me.CB_Presets.Items.AddRange(New Object() {"3840 x 2160 (16:9)", "2560 x 1440 (16:9)", "1920 x 1080 (16:9)", "1366 x 768 (16:9)", "1280 x 720 (16:9)", "1024 x 576 (16:9)", "960 x 540 (16:9)", "854 x 480 (16:9)"})
        Me.CB_Presets.Location = New System.Drawing.Point(65, 13)
        Me.CB_Presets.Name = "CB_Presets"
        Me.CB_Presets.Size = New System.Drawing.Size(156, 21)
        Me.CB_Presets.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Presets : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Graphics Quality :"
        '
        'cb_Window
        '
        Me.cb_Window.AutoSize = True
        Me.cb_Window.Location = New System.Drawing.Point(9, 101)
        Me.cb_Window.Name = "cb_Window"
        Me.cb_Window.Size = New System.Drawing.Size(77, 17)
        Me.cb_Window.TabIndex = 12
        Me.cb_Window.Text = "Windowed"
        Me.cb_Window.UseVisualStyleBackColor = True
        '
        'cb_Border
        '
        Me.cb_Border.AutoSize = True
        Me.cb_Border.Location = New System.Drawing.Point(92, 101)
        Me.cb_Border.Name = "cb_Border"
        Me.cb_Border.Size = New System.Drawing.Size(75, 17)
        Me.cb_Border.TabIndex = 13
        Me.cb_Border.Text = "Borderless"
        Me.cb_Border.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Game :"
        '
        'cb_lowset
        '
        Me.cb_lowset.AutoSize = True
        Me.cb_lowset.Location = New System.Drawing.Point(230, 129)
        Me.cb_lowset.Name = "cb_lowset"
        Me.cb_lowset.Size = New System.Drawing.Size(65, 17)
        Me.cb_lowset.TabIndex = 15
        Me.cb_lowset.Text = "Low Set"
        Me.cb_lowset.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.TSSL_ver})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 258)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(637, 22)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.IsLink = True
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(40, 17)
        Me.ToolStripStatusLabel1.Text = "About"
        '
        'TSSL_ver
        '
        Me.TSSL_ver.Name = "TSSL_ver"
        Me.TSSL_ver.Size = New System.Drawing.Size(25, 17)
        Me.TSSL_ver.Text = "aaa"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(227, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 47)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "InGame Config"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lv_AccList
        '
        Me.lv_AccList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lv_AccList.HideSelection = False
        Me.lv_AccList.Location = New System.Drawing.Point(340, 12)
        Me.lv_AccList.Name = "lv_AccList"
        Me.lv_AccList.Size = New System.Drawing.Size(176, 236)
        Me.lv_AccList.TabIndex = 28
        Me.lv_AccList.UseCompatibleStateImageBehavior = False
        Me.lv_AccList.View = System.Windows.Forms.View.List
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "name"
        Me.ColumnHeader1.Width = 273
        '
        'btnSaveAcc
        '
        Me.btnSaveAcc.Location = New System.Drawing.Point(522, 12)
        Me.btnSaveAcc.Name = "btnSaveAcc"
        Me.btnSaveAcc.Size = New System.Drawing.Size(98, 23)
        Me.btnSaveAcc.TabIndex = 29
        Me.btnSaveAcc.Text = "Save Account"
        Me.btnSaveAcc.UseVisualStyleBackColor = True
        '
        'BtnSwitchAcc
        '
        Me.BtnSwitchAcc.Location = New System.Drawing.Point(522, 41)
        Me.BtnSwitchAcc.Name = "BtnSwitchAcc"
        Me.BtnSwitchAcc.Size = New System.Drawing.Size(98, 23)
        Me.BtnSwitchAcc.TabIndex = 30
        Me.BtnSwitchAcc.Text = "Switch Account"
        Me.BtnSwitchAcc.UseVisualStyleBackColor = True
        '
        'btnDeleteAcc
        '
        Me.btnDeleteAcc.Location = New System.Drawing.Point(522, 70)
        Me.btnDeleteAcc.Name = "btnDeleteAcc"
        Me.btnDeleteAcc.Size = New System.Drawing.Size(98, 23)
        Me.btnDeleteAcc.TabIndex = 31
        Me.btnDeleteAcc.Text = "Delete Account"
        Me.btnDeleteAcc.UseVisualStyleBackColor = True
        '
        'BtnKill
        '
        Me.BtnKill.Location = New System.Drawing.Point(522, 212)
        Me.BtnKill.Name = "BtnKill"
        Me.BtnKill.Size = New System.Drawing.Size(98, 23)
        Me.BtnKill.TabIndex = 32
        Me.BtnKill.Text = "Kill Genshin"
        Me.BtnKill.UseVisualStyleBackColor = True
        '
        'cb_autoRestart
        '
        Me.cb_autoRestart.AutoSize = True
        Me.cb_autoRestart.Location = New System.Drawing.Point(522, 110)
        Me.cb_autoRestart.Name = "cb_autoRestart"
        Me.cb_autoRestart.Size = New System.Drawing.Size(85, 17)
        Me.cb_autoRestart.TabIndex = 33
        Me.cb_autoRestart.Text = "Auto Restart"
        Me.cb_autoRestart.UseVisualStyleBackColor = True
        '
        'cb_NoPop
        '
        Me.cb_NoPop.AutoSize = True
        Me.cb_NoPop.Location = New System.Drawing.Point(522, 133)
        Me.cb_NoPop.Name = "cb_NoPop"
        Me.cb_NoPop.Size = New System.Drawing.Size(84, 17)
        Me.cb_NoPop.TabIndex = 34
        Me.cb_NoPop.Text = "No Pops Up"
        Me.cb_NoPop.UseVisualStyleBackColor = True
        '
        'cb_MultiAcc
        '
        Me.cb_MultiAcc.AutoSize = True
        Me.cb_MultiAcc.Location = New System.Drawing.Point(173, 101)
        Me.cb_MultiAcc.Name = "cb_MultiAcc"
        Me.cb_MultiAcc.Size = New System.Drawing.Size(91, 17)
        Me.cb_MultiAcc.TabIndex = 35
        Me.cb_MultiAcc.Text = "Multi Account"
        Me.cb_MultiAcc.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 280)
        Me.Controls.Add(Me.cb_MultiAcc)
        Me.Controls.Add(Me.cb_NoPop)
        Me.Controls.Add(Me.cb_autoRestart)
        Me.Controls.Add(Me.BtnKill)
        Me.Controls.Add(Me.btnDeleteAcc)
        Me.Controls.Add(Me.BtnSwitchAcc)
        Me.Controls.Add(Me.btnSaveAcc)
        Me.Controls.Add(Me.lv_AccList)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cb_lowset)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cb_Border)
        Me.Controls.Add(Me.cb_Window)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CB_Presets)
        Me.Controls.Add(Me.cb_Resolusi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_FolderGame)
        Me.Controls.Add(Me.btn_StartGame)
        Me.Controls.Add(Me.Tx_Game)
        Me.Controls.Add(Me.CB_Graphics)
        Me.Controls.Add(Me.Tx_H)
        Me.Controls.Add(Me.Tx_W)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tx_W As TextBox
    Friend WithEvents Tx_H As TextBox
    Friend WithEvents CB_Graphics As ComboBox
    Friend WithEvents Tx_Game As TextBox
    Friend WithEvents btn_StartGame As Button
    Friend WithEvents btn_FolderGame As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_Resolusi As CheckBox
    Friend WithEvents CB_Presets As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_Window As CheckBox
    Friend WithEvents cb_Border As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_lowset As CheckBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TSSL_ver As ToolStripStatusLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents lv_AccList As ListView
    Friend WithEvents btnSaveAcc As Button
    Friend WithEvents BtnSwitchAcc As Button
    Friend WithEvents btnDeleteAcc As Button
    Friend WithEvents BtnKill As Button
    Friend WithEvents cb_autoRestart As CheckBox
    Friend WithEvents cb_NoPop As CheckBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents cb_MultiAcc As CheckBox
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
