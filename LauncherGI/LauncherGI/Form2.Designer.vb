<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.CB_Language = New System.Windows.Forms.ComboBox()
        Me.CB_Voice = New System.Windows.Forms.ComboBox()
        Me.Bt_savesettings = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LB_ValueVV = New System.Windows.Forms.Label()
        Me.LB_ValueMV = New System.Windows.Forms.Label()
        Me.LB_ValueSFX = New System.Windows.Forms.Label()
        Me.LB_ValueGV = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_VV = New System.Windows.Forms.TrackBar()
        Me.TB_MV = New System.Windows.Forms.TrackBar()
        Me.TB_SFXV = New System.Windows.Forms.TrackBar()
        Me.TB_GV = New System.Windows.Forms.TrackBar()
        Me.CB_MB = New System.Windows.Forms.CheckBox()
        Me.RTB_getdata = New System.Windows.Forms.RichTextBox()
        Me.RTB_JDeSerial = New System.Windows.Forms.RichTextBox()
        Me.RTB_JSerial = New System.Windows.Forms.RichTextBox()
        Me.RTB_HexText = New System.Windows.Forms.RichTextBox()
        Me.RTB_HexFinal = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TB_VV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_MV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_SFXV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_GV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CB_Language
        '
        Me.CB_Language.FormattingEnabled = True
        Me.CB_Language.Items.AddRange(New Object() {"English", "Chinese", "Japanese", "Korean", "Indonesia"})
        Me.CB_Language.Location = New System.Drawing.Point(79, 12)
        Me.CB_Language.Name = "CB_Language"
        Me.CB_Language.Size = New System.Drawing.Size(140, 21)
        Me.CB_Language.TabIndex = 0
        '
        'CB_Voice
        '
        Me.CB_Voice.FormattingEnabled = True
        Me.CB_Voice.Items.AddRange(New Object() {"Chinese", "English", "Japanese", "Korean"})
        Me.CB_Voice.Location = New System.Drawing.Point(271, 12)
        Me.CB_Voice.Name = "CB_Voice"
        Me.CB_Voice.Size = New System.Drawing.Size(132, 21)
        Me.CB_Voice.TabIndex = 1
        '
        'Bt_savesettings
        '
        Me.Bt_savesettings.Location = New System.Drawing.Point(189, 293)
        Me.Bt_savesettings.Name = "Bt_savesettings"
        Me.Bt_savesettings.Size = New System.Drawing.Size(185, 40)
        Me.Bt_savesettings.TabIndex = 7
        Me.Bt_savesettings.Text = "Save"
        Me.Bt_savesettings.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Language :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(225, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Voice :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LB_ValueVV)
        Me.GroupBox1.Controls.Add(Me.LB_ValueMV)
        Me.GroupBox1.Controls.Add(Me.LB_ValueSFX)
        Me.GroupBox1.Controls.Add(Me.LB_ValueGV)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TB_VV)
        Me.GroupBox1.Controls.Add(Me.TB_MV)
        Me.GroupBox1.Controls.Add(Me.TB_SFXV)
        Me.GroupBox1.Controls.Add(Me.TB_GV)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 234)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Volume Settings"
        '
        'LB_ValueVV
        '
        Me.LB_ValueVV.AutoSize = True
        Me.LB_ValueVV.Location = New System.Drawing.Point(360, 185)
        Me.LB_ValueVV.Name = "LB_ValueVV"
        Me.LB_ValueVV.Size = New System.Drawing.Size(19, 13)
        Me.LB_ValueVV.TabIndex = 11
        Me.LB_ValueVV.Text = "00"
        '
        'LB_ValueMV
        '
        Me.LB_ValueMV.AutoSize = True
        Me.LB_ValueMV.Location = New System.Drawing.Point(360, 132)
        Me.LB_ValueMV.Name = "LB_ValueMV"
        Me.LB_ValueMV.Size = New System.Drawing.Size(19, 13)
        Me.LB_ValueMV.TabIndex = 10
        Me.LB_ValueMV.Text = "00"
        '
        'LB_ValueSFX
        '
        Me.LB_ValueSFX.AutoSize = True
        Me.LB_ValueSFX.Location = New System.Drawing.Point(360, 82)
        Me.LB_ValueSFX.Name = "LB_ValueSFX"
        Me.LB_ValueSFX.Size = New System.Drawing.Size(19, 13)
        Me.LB_ValueSFX.TabIndex = 9
        Me.LB_ValueSFX.Text = "00"
        '
        'LB_ValueGV
        '
        Me.LB_ValueGV.AutoSize = True
        Me.LB_ValueGV.Location = New System.Drawing.Point(360, 31)
        Me.LB_ValueGV.Name = "LB_ValueGV"
        Me.LB_ValueGV.Size = New System.Drawing.Size(19, 13)
        Me.LB_ValueGV.TabIndex = 8
        Me.LB_ValueGV.Text = "00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Voice Volume :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Music Volume :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "SFX Volume :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Global Volume :"
        '
        'TB_VV
        '
        Me.TB_VV.Location = New System.Drawing.Point(104, 181)
        Me.TB_VV.Name = "TB_VV"
        Me.TB_VV.Size = New System.Drawing.Size(250, 45)
        Me.TB_VV.TabIndex = 3
        '
        'TB_MV
        '
        Me.TB_MV.Location = New System.Drawing.Point(104, 130)
        Me.TB_MV.Name = "TB_MV"
        Me.TB_MV.Size = New System.Drawing.Size(250, 45)
        Me.TB_MV.TabIndex = 2
        '
        'TB_SFXV
        '
        Me.TB_SFXV.Location = New System.Drawing.Point(104, 79)
        Me.TB_SFXV.Name = "TB_SFXV"
        Me.TB_SFXV.Size = New System.Drawing.Size(250, 45)
        Me.TB_SFXV.TabIndex = 1
        '
        'TB_GV
        '
        Me.TB_GV.Location = New System.Drawing.Point(104, 28)
        Me.TB_GV.Name = "TB_GV"
        Me.TB_GV.Size = New System.Drawing.Size(250, 45)
        Me.TB_GV.TabIndex = 0
        '
        'CB_MB
        '
        Me.CB_MB.AutoSize = True
        Me.CB_MB.Location = New System.Drawing.Point(12, 306)
        Me.CB_MB.Name = "CB_MB"
        Me.CB_MB.Size = New System.Drawing.Size(79, 17)
        Me.CB_MB.TabIndex = 11
        Me.CB_MB.Text = "Motion Blur"
        Me.CB_MB.UseVisualStyleBackColor = True
        '
        'RTB_getdata
        '
        Me.RTB_getdata.Location = New System.Drawing.Point(429, 12)
        Me.RTB_getdata.Name = "RTB_getdata"
        Me.RTB_getdata.Size = New System.Drawing.Size(224, 114)
        Me.RTB_getdata.TabIndex = 12
        Me.RTB_getdata.Text = ""
        '
        'RTB_JDeSerial
        '
        Me.RTB_JDeSerial.Location = New System.Drawing.Point(429, 149)
        Me.RTB_JDeSerial.Name = "RTB_JDeSerial"
        Me.RTB_JDeSerial.Size = New System.Drawing.Size(224, 130)
        Me.RTB_JDeSerial.TabIndex = 13
        Me.RTB_JDeSerial.Text = ""
        '
        'RTB_JSerial
        '
        Me.RTB_JSerial.Location = New System.Drawing.Point(683, 149)
        Me.RTB_JSerial.Name = "RTB_JSerial"
        Me.RTB_JSerial.Size = New System.Drawing.Size(205, 138)
        Me.RTB_JSerial.TabIndex = 14
        Me.RTB_JSerial.Text = ""
        '
        'RTB_HexText
        '
        Me.RTB_HexText.Location = New System.Drawing.Point(429, 306)
        Me.RTB_HexText.Name = "RTB_HexText"
        Me.RTB_HexText.Size = New System.Drawing.Size(224, 137)
        Me.RTB_HexText.TabIndex = 15
        Me.RTB_HexText.Text = ""
        '
        'RTB_HexFinal
        '
        Me.RTB_HexFinal.Location = New System.Drawing.Point(684, 320)
        Me.RTB_HexFinal.Name = "RTB_HexFinal"
        Me.RTB_HexFinal.Size = New System.Drawing.Size(204, 121)
        Me.RTB_HexFinal.TabIndex = 16
        Me.RTB_HexFinal.Text = ""
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 341)
        Me.Controls.Add(Me.RTB_HexFinal)
        Me.Controls.Add(Me.RTB_HexText)
        Me.Controls.Add(Me.RTB_JSerial)
        Me.Controls.Add(Me.RTB_JDeSerial)
        Me.Controls.Add(Me.RTB_getdata)
        Me.Controls.Add(Me.CB_MB)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bt_savesettings)
        Me.Controls.Add(Me.CB_Voice)
        Me.Controls.Add(Me.CB_Language)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "InGame Config"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TB_VV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_MV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_SFXV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_GV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB_Language As ComboBox
    Friend WithEvents CB_Voice As ComboBox
    Friend WithEvents Bt_savesettings As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_VV As TrackBar
    Friend WithEvents TB_MV As TrackBar
    Friend WithEvents TB_SFXV As TrackBar
    Friend WithEvents TB_GV As TrackBar
    Friend WithEvents CB_MB As CheckBox
    Friend WithEvents RTB_getdata As RichTextBox
    Friend WithEvents RTB_JDeSerial As RichTextBox
    Friend WithEvents LB_ValueVV As Label
    Friend WithEvents LB_ValueMV As Label
    Friend WithEvents LB_ValueSFX As Label
    Friend WithEvents LB_ValueGV As Label
    Friend WithEvents RTB_JSerial As RichTextBox
    Friend WithEvents RTB_HexText As RichTextBox
    Friend WithEvents RTB_HexFinal As RichTextBox
End Class
