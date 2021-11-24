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
        Me.TSSL_ver = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RTB1 = New System.Windows.Forms.RichTextBox()
        Me.RTB2 = New System.Windows.Forms.RichTextBox()
        Me.RTB3 = New System.Windows.Forms.RichTextBox()
        Me.RTB4 = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RTB5 = New System.Windows.Forms.RichTextBox()
        Me.RTB6 = New System.Windows.Forms.RichTextBox()
        Me.RTB7 = New System.Windows.Forms.RichTextBox()
        Me.RTB8 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RTB9 = New System.Windows.Forms.RichTextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tx_W
        '
        Me.Tx_W.Location = New System.Drawing.Point(65, 42)
        Me.Tx_W.Name = "Tx_W"
        Me.Tx_W.Size = New System.Drawing.Size(126, 20)
        Me.Tx_W.TabIndex = 0
        '
        'Tx_H
        '
        Me.Tx_H.Location = New System.Drawing.Point(65, 69)
        Me.Tx_H.Name = "Tx_H"
        Me.Tx_H.Size = New System.Drawing.Size(126, 20)
        Me.Tx_H.TabIndex = 1
        '
        'CB_Graphics
        '
        Me.CB_Graphics.FormattingEnabled = True
        Me.CB_Graphics.ItemHeight = 13
        Me.CB_Graphics.Items.AddRange(New Object() {"Default", "Fastest", "Fast", "Simple", "Good", "Beautiful", "Fantastic", "Console"})
        Me.CB_Graphics.Location = New System.Drawing.Point(98, 123)
        Me.CB_Graphics.Name = "CB_Graphics"
        Me.CB_Graphics.Size = New System.Drawing.Size(126, 21)
        Me.CB_Graphics.TabIndex = 2
        '
        'Tx_Game
        '
        Me.Tx_Game.Location = New System.Drawing.Point(54, 151)
        Me.Tx_Game.Name = "Tx_Game"
        Me.Tx_Game.Size = New System.Drawing.Size(170, 20)
        Me.Tx_Game.TabIndex = 3
        '
        'btn_StartGame
        '
        Me.btn_StartGame.Location = New System.Drawing.Point(15, 179)
        Me.btn_StartGame.Name = "btn_StartGame"
        Me.btn_StartGame.Size = New System.Drawing.Size(283, 48)
        Me.btn_StartGame.TabIndex = 4
        Me.btn_StartGame.Text = "Start"
        Me.btn_StartGame.UseVisualStyleBackColor = True
        '
        'btn_FolderGame
        '
        Me.btn_FolderGame.Location = New System.Drawing.Point(230, 151)
        Me.btn_FolderGame.Name = "btn_FolderGame"
        Me.btn_FolderGame.Size = New System.Drawing.Size(68, 22)
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
        Me.cb_Resolusi.Location = New System.Drawing.Point(197, 15)
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
        Me.CB_Presets.Size = New System.Drawing.Size(126, 21)
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
        Me.Label4.Location = New System.Drawing.Point(6, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Graphics Quality :"
        '
        'cb_Window
        '
        Me.cb_Window.AutoSize = True
        Me.cb_Window.Location = New System.Drawing.Point(7, 95)
        Me.cb_Window.Name = "cb_Window"
        Me.cb_Window.Size = New System.Drawing.Size(77, 17)
        Me.cb_Window.TabIndex = 12
        Me.cb_Window.Text = "Windowed"
        Me.cb_Window.UseVisualStyleBackColor = True
        '
        'cb_Border
        '
        Me.cb_Border.AutoSize = True
        Me.cb_Border.Location = New System.Drawing.Point(108, 95)
        Me.cb_Border.Name = "cb_Border"
        Me.cb_Border.Size = New System.Drawing.Size(75, 17)
        Me.cb_Border.TabIndex = 13
        Me.cb_Border.Text = "Borderless"
        Me.cb_Border.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Game :"
        '
        'cb_lowset
        '
        Me.cb_lowset.AutoSize = True
        Me.cb_lowset.Location = New System.Drawing.Point(230, 125)
        Me.cb_lowset.Name = "cb_lowset"
        Me.cb_lowset.Size = New System.Drawing.Size(65, 17)
        Me.cb_lowset.TabIndex = 15
        Me.cb_lowset.Text = "Low Set"
        Me.cb_lowset.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSL_ver})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 232)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(308, 22)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TSSL_ver
        '
        Me.TSSL_ver.Name = "TSSL_ver"
        Me.TSSL_ver.Size = New System.Drawing.Size(25, 17)
        Me.TSSL_ver.Text = "aaa"
        '
        'RTB1
        '
        Me.RTB1.Location = New System.Drawing.Point(360, 13)
        Me.RTB1.Name = "RTB1"
        Me.RTB1.Size = New System.Drawing.Size(175, 89)
        Me.RTB1.TabIndex = 17
        Me.RTB1.Text = ""
        '
        'RTB2
        '
        Me.RTB2.Location = New System.Drawing.Point(541, 13)
        Me.RTB2.Name = "RTB2"
        Me.RTB2.Size = New System.Drawing.Size(218, 83)
        Me.RTB2.TabIndex = 18
        Me.RTB2.Text = ""
        '
        'RTB3
        '
        Me.RTB3.Location = New System.Drawing.Point(360, 110)
        Me.RTB3.Name = "RTB3"
        Me.RTB3.Size = New System.Drawing.Size(191, 93)
        Me.RTB3.TabIndex = 19
        Me.RTB3.Text = ""
        '
        'RTB4
        '
        Me.RTB4.Location = New System.Drawing.Point(557, 111)
        Me.RTB4.Name = "RTB4"
        Me.RTB4.Size = New System.Drawing.Size(198, 92)
        Me.RTB4.TabIndex = 20
        Me.RTB4.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(360, 219)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 20)
        Me.TextBox1.TabIndex = 21
        '
        'RTB5
        '
        Me.RTB5.Location = New System.Drawing.Point(12, 258)
        Me.RTB5.Name = "RTB5"
        Me.RTB5.Size = New System.Drawing.Size(187, 81)
        Me.RTB5.TabIndex = 22
        Me.RTB5.Text = ""
        '
        'RTB6
        '
        Me.RTB6.Location = New System.Drawing.Point(205, 258)
        Me.RTB6.Name = "RTB6"
        Me.RTB6.Size = New System.Drawing.Size(164, 81)
        Me.RTB6.TabIndex = 23
        Me.RTB6.Text = ""
        '
        'RTB7
        '
        Me.RTB7.Location = New System.Drawing.Point(375, 254)
        Me.RTB7.Name = "RTB7"
        Me.RTB7.Size = New System.Drawing.Size(187, 85)
        Me.RTB7.TabIndex = 24
        Me.RTB7.Text = ""
        '
        'RTB8
        '
        Me.RTB8.Location = New System.Drawing.Point(568, 254)
        Me.RTB8.Name = "RTB8"
        Me.RTB8.Size = New System.Drawing.Size(164, 85)
        Me.RTB8.TabIndex = 25
        Me.RTB8.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(227, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 43)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "InGame Config"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RTB9
        '
        Me.RTB9.Location = New System.Drawing.Point(348, 496)
        Me.RTB9.Name = "RTB9"
        Me.RTB9.Size = New System.Drawing.Size(203, 98)
        Me.RTB9.TabIndex = 27
        Me.RTB9.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 254)
        Me.Controls.Add(Me.RTB9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RTB8)
        Me.Controls.Add(Me.RTB7)
        Me.Controls.Add(Me.RTB6)
        Me.Controls.Add(Me.RTB5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RTB4)
        Me.Controls.Add(Me.RTB3)
        Me.Controls.Add(Me.RTB2)
        Me.Controls.Add(Me.RTB1)
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
    Friend WithEvents RTB1 As RichTextBox
    Friend WithEvents RTB2 As RichTextBox
    Friend WithEvents RTB3 As RichTextBox
    Friend WithEvents RTB4 As RichTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RTB5 As RichTextBox
    Friend WithEvents RTB6 As RichTextBox
    Friend WithEvents RTB7 As RichTextBox
    Friend WithEvents RTB8 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RTB9 As RichTextBox
End Class
