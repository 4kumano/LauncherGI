Imports Microsoft.Win32
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form2

    'CN simplified :  deviceLanguageType: 2, deviceVoiceLanguageType: 0
    'EN: deviceLanguageType: 1, deviceVoiceLanguageType: 1
    'JP: deviceLanguageType: 9, deviceVoiceLanguageType: 2
    'KR: deviceLanguageType: 10, deviceVoiceLanguageType: 3
    'ID: deviceLanguageType: 13, 
    Dim language As Integer
    Dim Key As RegistryKey
    Dim keyname As String = "HKEY_CURRENT_USER\Software\miHoYo\Genshin Impact"
    Dim valueName As String = "GENERAL_DATA_h2389025596"
    Sub info()

        Dim s As String = ""

        Dim readValue As Byte() = My.Computer.Registry.GetValue(keyname, valueName, Nothing)

        For i = 0 To readValue.Count - 1

            s &= Format(readValue(i), "X2") & " "

        Next

        'RTB1.Select()
        'RTB1.AppendText(s)
        'Debug.Print(s)

        RTB_getdata.Text = HexToString(s)

        'Dim val As String
        'val = RTB2.Text
        'Dim location As String = Application.StartupPath & "\hasil.json"
        'IO.File.WriteAllText(location, RTB2.Text)

        Dim asd As JObject = JObject.Parse(RTB_getdata.Text)
        'RTB_JDeSerial.Text = asd.ToString

        TB_GV.Value = asd.Item("volumeGlobal")
        LB_ValueGV.Text = TB_GV.Value

        TB_SFXV.Value = asd.Item("volumeSFX")
        LB_ValueSFX.Text = TB_SFXV.Value

        TB_MV.Value = asd.Item("volumeMusic")
        LB_ValueMV.Text = TB_MV.Value

        TB_VV.Value = asd.Item("volumeVoice")
        LB_ValueVV.Text = TB_VV.Value

        Dim VoiceLanguage As Integer
        VoiceLanguage = asd.Item("deviceVoiceLanguageType")
        CB_Voice.SelectedIndex = VoiceLanguage

        Dim LanguageIG As Integer
        LanguageIG = asd.Item("deviceLanguageType")
        Select Case LanguageIG
            Case 1
                CB_Language.SelectedIndex = 0
                language = LanguageIG
            Case 2
                CB_Language.SelectedIndex = 1
                language = LanguageIG
            Case 9
                CB_Language.SelectedIndex = 2
                language = LanguageIG
            Case 10
                CB_Language.SelectedIndex = 3
                language = LanguageIG
            Case 13
                CB_Language.SelectedIndex = 4
                language = LanguageIG
        End Select


        CB_MB.Checked = asd.Item("motionBlur")


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        info()
    End Sub

    Private Sub Bt_savesettings_Click(sender As Object, e As EventArgs) Handles Bt_savesettings.Click
        Dim asd As JObject = JObject.Parse(RTB_getdata.Text)
        'RTB_JDeSerial.Text = asd.ToString
        Dim EditGV As JToken = asd.SelectToken("volumeGlobal")
        EditGV.Replace(TB_GV.Value)
        Dim EditSFX As JToken = asd.SelectToken("volumeSFX")
        EditSFX.Replace(TB_SFXV.Value)
        Dim EditMV As JToken = asd.SelectToken("volumeMusic")
        EditMV.Replace(TB_MV.Value)
        Dim EditVV As JToken = asd.SelectToken("volumeVoice")
        EditVV.Replace(TB_VV.Value)
        Dim EditMB As JToken = asd.SelectToken("motionBlur")
        If CB_MB.Checked = True Then
            EditMB.Replace(True)
        Else
            EditMB.Replace(False)
        End If
        Dim EditVoiceL As JToken = asd.SelectToken("deviceVoiceLanguageType")
        EditVoiceL.Replace(CB_Voice.SelectedIndex)
        Dim EditLanguage As JToken = asd.SelectToken("deviceLanguageType")
        EditLanguage.Replace(language)
        RTB_JDeSerial.Text = asd.ToString
        Dim ag As String = JsonConvert.SerializeObject(asd)
        RTB_JSerial.Text = ag


        RTB_HexText.Text = GetHexString(RTB_JSerial.Text)
        Dim hextobin As String = RTB_HexText.Text
        Dim length As Integer = hextobin.Length
        Dim upperBound As Integer = length \ 2
        If length Mod 2 = 0 Then
            upperBound -= 1
        Else
            hextobin = "0" & hextobin
        End If
        Dim bytes(upperBound) As Byte
        For i As Integer = 0 To upperBound
            bytes(i) = Convert.ToByte(hextobin.Substring(i * 2, 2), 16)
        Next

        Dim s2 As String = ""
        For i2 = 0 To bytes.Count - 1

            s2 &= Format(bytes(i2), "X2") & " "

        Next

        RTB_HexFinal.AppendText(s2)

        Key = Registry.CurrentUser.OpenSubKey("Software\miHoYo\Genshin Impact", True)
        Key.SetValue(valueName, bytes, RegistryValueKind.Binary)
        MsgBox("Success!")
        Key.Close()
        Key.Dispose()
    End Sub

    Private Sub TB_GV_Scroll(sender As Object, e As EventArgs) Handles TB_GV.Scroll
        LB_ValueGV.Text = TB_GV.Value
    End Sub

    Private Sub TB_SFXV_Scroll(sender As Object, e As EventArgs) Handles TB_SFXV.Scroll
        LB_ValueSFX.Text = TB_SFXV.Value
    End Sub

    Private Sub TB_MV_Scroll(sender As Object, e As EventArgs) Handles TB_MV.Scroll
        LB_ValueMV.Text = TB_MV.Value
    End Sub

    Private Sub TB_VV_Scroll(sender As Object, e As EventArgs) Handles TB_VV.Scroll
        LB_ValueVV.Text = TB_VV.Value
    End Sub

    Private Sub CB_Language_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Language.SelectedIndexChanged
        Dim nomor As Integer
        nomor = CB_Language.SelectedIndex
        Select Case nomor

            Case 0
                'en
                language = 1
            Case 1
                'ch
                language = 2
            Case 2
                'jp
                language = 9
            Case 3
                'kr
                language = 10
            Case 4
                'id
                language = 13

        End Select
    End Sub
End Class