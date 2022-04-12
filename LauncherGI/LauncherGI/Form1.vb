Imports Microsoft.Win32
Imports System.IO
Imports System.Diagnostics
Imports System.Net
Imports System.Text
Imports System.Web.Script.Serialization
Imports System.Text.Encoding.Unicode
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Imports LauncherGI.GenshinAccount

Public Class Form1
    Private SystemFolderList As New List(Of String)
    Private _SelectedPath As String
    Dim FilePathInI As String = Application.StartupPath & "\config.ini"
    '=========================[Get Data]=================================
    Dim get_h As String
    Dim get_g As String
    Dim get_grapihc As String
    Dim get_fullscreen As String
    Dim get_locationgame As String
    Dim get_value As Byte()
    '===========================[info]===================================
    Dim versi As String = "1.8"
    Dim appname As String = "LauncherGI " + ".v" + versi
    '==========================[Set Parm]=================================
    Dim boder As String
    Dim Fscreen As String
    Dim Sw As String
    Dim Sh As String
    Dim GQ As String
    '==========================[regedit]=================================
    Dim Key As RegistryKey
    Dim screen_h As String = "Screenmanager Resolution Height_h2627697771"
    Dim screen_w As String = "Screenmanager Resolution Width_h182942802"
    Dim graphicQ As String = "UnityGraphicsQuality_h1669003810"
    Dim fullscreen As String = "Screenmanager Is Fullscreen mode_h3981298716"
    '==========================[UserData]=================================
    Private ReadOnly UserDataPath As String = Path.Combine(Application.StartupPath, "UserData")
    Private thisVersion As String
    Private acctMenuItemList As List(Of ToolStripMenuItem) = New List(Of ToolStripMenuItem)()

#Region "BrowseForFolder"
    Private Function BrowseForFolder() As Boolean
        Dim FBD As New FolderBrowserDialog
        FBD.Description = "Select Genshin Impact Game folder"
        FBD.ShowNewFolderButton = False

        If FBD.ShowDialog = DialogResult.OK Then

            If FBD.SelectedPath.Length <= 3 Then : MessageBox.Show("You cannot Choose drives.") : Return False : End If
            'If SystemFolderList.Contains(FBD.SelectedPath) Or FBD.SelectedPath.Contains(Environment.GetFolderPath(Environment.SpecialFolder.Windows)) Then : MessageBox.Show("You cannot lock system folders.") : Return False : End If

            Try
                Dim DirectoryInfo As New DirectoryInfo(FBD.SelectedPath)
            Catch ex As Exception
                MessageBox.Show("Unable to analyse folder.")
                Return False
            End Try



            If FBD.SelectedPath.EndsWith("\\") Then : FBD.SelectedPath = FBD.SelectedPath.Substring(0, FBD.SelectedPath.Length - 1) : End If

            Tx_Game.Text = FBD.SelectedPath
            writeini(FilePathInI, "Setting Config", "Game", Tx_Game.Text)
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub btn_FolderGame_Click(sender As Object, e As EventArgs) Handles btn_FolderGame.Click
        BrowseForFolder()
    End Sub



#End Region

    Sub getDATA()
        Key = Registry.CurrentUser.OpenSubKey("Software\miHoYo\Genshin Impact", True)
        get_h = Key.GetValue("Screenmanager Resolution Height_h2627697771")
        get_g = Key.GetValue("Screenmanager Resolution Width_h182942802")
        get_grapihc = Key.GetValue("UnityGraphicsQuality_h1669003810")
        get_fullscreen = Key.GetValue("Screenmanager Is Fullscreen mode_h3981298716")
        get_value = Key.GetValue("GENERAL_DATA_h2389025596")

        'Key = Registry.LocalMachine.OpenSubKey("SOFTWARE\launcher", True)
        ' get_locationgame = Key.GetValue("InstPath", "").ToString

        Key.Close()
        Key.Dispose()
        Dim TS__x64 As Microsoft.Win32.RegistryKey = Microsoft.Win32.RegistryKey.OpenBaseKey _
                                            (Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry64)
        get_locationgame = TS__x64.OpenSubKey("SOFTWARE\launcher").GetValue("InstPath")

    End Sub
    Sub setDATA()
        IO.File.WriteAllText(FilePathInI, My.Resources.config)
        Dim aa As Boolean
        If get_fullscreen = 1 Then
            aa = False
        Else
            aa = True
        End If
        Dim setlocalgame As String
        setlocalgame = get_locationgame & "\Genshin Impact Game"
        writeini(FilePathInI, "Setting Config", "Width", get_g)
        writeini(FilePathInI, "Setting Config", "Height", get_h)
        writeini(FilePathInI, "Setting Config", "GraphicsQuality", get_grapihc)
        writeini(FilePathInI, "Setting Config", "Windowed", aa)
        writeini(FilePathInI, "Setting Config", "Custom", True)
        writeini(FilePathInI, "Setting Config", "Border", True)
        writeini(FilePathInI, "Setting Config", "LowSetting", False)
        writeini(FilePathInI, "Setting Config", "Game", setlocalgame)
        writeini(FilePathInI, "Setting Config", "Multi", False)
        writeini(FilePathInI, "Setting Config", "CheckUpdate", True)
    End Sub

    Sub LoadDATA()
        Dim config1 As String = readini(FilePathInI, "Setting Config", "Width", "")
        Dim config2 As String = readini(FilePathInI, "Setting Config", "Height", "")
        Dim config3 As String = readini(FilePathInI, "Setting Config", "GraphicsQuality", "")
        Dim config4 As String = readini(FilePathInI, "Setting Config", "Windowed", "")
        Dim config5 As String = readini(FilePathInI, "Setting Config", "Custom", "")
        Dim config6 As String = readini(FilePathInI, "Setting Config", "border", "")
        Dim config7 As String = readini(FilePathInI, "Setting Config", "LowSetting", "")
        Dim config8 As String = readini(FilePathInI, "Setting Config", "Game", "")
        Dim config9 As String = readini(FilePathInI, "Setting Config", "Multi", "")
        Dim config10 As String = readini(FilePathInI, "Setting Config", "CheckUpdate", "")

        Tx_W.Text = config1
        Tx_H.Text = config2
        CB_Graphics.SelectedIndex = config3
        Tx_Game.Text = config8

        cb_Window.Checked = config4
        cb_Resolusi.Checked = config5
        cb_Border.Checked = config6
        cb_lowset.Checked = config7

        cb_MultiAcc.Checked = config9
        MultiAcc()

        If config10 = True Then
            TSSL_ver.Text = "Check Update..."
            TSSL_ver.ForeColor = Color.Orange
            Threading.Thread.Sleep(1000)
            cekupdate()
        Else

        End If

    End Sub
    Sub saveDATA()

        writeini(FilePathInI, "Setting Config", "Width", Tx_W.Text)
        writeini(FilePathInI, "Setting Config", "Height", Tx_H.Text)
        writeini(FilePathInI, "Setting Config", "GraphicsQuality", CB_Graphics.SelectedIndex)
        writeini(FilePathInI, "Setting Config", "Windowed", cb_Window.Checked)
        writeini(FilePathInI, "Setting Config", "Custom", cb_Resolusi.Checked)
        writeini(FilePathInI, "Setting Config", "border", cb_Border.Checked)
        writeini(FilePathInI, "Setting Config", "Game", Tx_Game.Text)
        writeini(FilePathInI, "Setting Config", "Multi", cb_MultiAcc.Checked)
    End Sub

#Region "Update"

    Public Function IsInternetConnected() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
        End Try
        Return False
    End Function
    Sub cekupdate()
        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        If IsInternetConnected() = True Then
            '===========================[Server]==================================
            Dim request As HttpWebRequest
            Dim response As HttpWebResponse = Nothing
            Dim reader As StreamReader
            Dim json As String
            Try

                request = DirectCast(WebRequest.Create("https://raw.githubusercontent.com/4kumano/LauncherGI/main/Status.json"), HttpWebRequest)
                response = DirectCast(request.GetResponse(), HttpWebResponse)
                reader = New StreamReader(response.GetResponseStream())


                json = reader.ReadToEnd()


            Catch ex As Exception
                Console.WriteLine(ex.ToString)
                MsgBox(ex.ToString)
            Finally
                If Not response Is Nothing Then response.Close()
            End Try

            Dim Asw As JObject = JObject.Parse(json)
            Dim ver As String = Asw.Item("LGI")("Versi").ToString
            Dim link As String = Asw.Item("LGI")("Update").ToString

            Dim msg As String = "LauncherGI version has been updated!" + vbCrLf + "New Update : " + ver + vbCrLf + "do you want to update?"
            If versi = ver Then
                TSSL_ver.ForeColor = Color.Green
                TSSL_ver.Text = "Last Update!"
                Threading.Thread.Sleep(1000)

            Else
                If MsgBox(msg, MsgBoxStyle.YesNo, "Ask!") = MsgBoxResult.Yes Then
                    Process.Start(link)
                    Me.Close()
                End If
                TSSL_ver.ForeColor = Color.Orange
                TSSL_ver.Text = "Out of date!"
                Threading.Thread.Sleep(1000)

            End If
        Else
            TSSL_ver.Text = ""
        End If
    End Sub
#End Region

    'Sub info()
    '    Dim keyname As String = "HKEY_CURRENT_USER\Software\miHoYo\Genshin Impact"

    '    Dim valueName As String = "GENERAL_DATA_h2389025596"

    '    Dim s As String = ""

    '    Dim readValue As Byte() = My.Computer.Registry.GetValue(keyname, valueName, Nothing)

    '    For i = 0 To readValue.Count - 1

    '        s &= Format(readValue(i), "X2") & " "

    '    Next

    '    RTB1.Select()
    '    RTB1.AppendText(s)
    '    Debug.Print(s)

    '    RTB2.Text = HexToString(s)

    '    Dim val As String
    '    val = RTB2.Text
    '    Dim location As String = Application.StartupPath & "\hasil.json"
    '    IO.File.WriteAllText(location, RTB2.Text)

    '    RTB3.Text = GetHexString(val)
    '    Dim hextobin As String = RTB3.Text
    '    Dim length As Integer = hextobin.Length
    '    Dim upperBound As Integer = length \ 2
    '    If length Mod 2 = 0 Then
    '        upperBound -= 1
    '    Else
    '        hextobin = "0" & hextobin
    '    End If
    '    Dim bytes(upperBound) As Byte
    '    For i As Integer = 0 To upperBound
    '        bytes(i) = Convert.ToByte(hextobin.Substring(i * 2, 2), 16)
    '    Next

    '    Dim s2 As String = ""
    '    For i2 = 0 To bytes.Count - 1

    '        s2 &= Format(bytes(i2), "X2") & " "

    '    Next

    '    RTB4.AppendText(s2)

    '    Dim asd As JObject = JObject.Parse(val)

    '    Dim adf As JToken = asd.SelectToken("volumeGlobal")
    '    adf.Replace(7)
    '    TextBox1.Text = asd.Item("volumeGlobal").ToString
    '    RTB5.Text = asd.ToString
    '    Dim ag As String = JsonConvert.SerializeObject(asd)

    '    RTB6.Text = ag.ToString
    '    RTB7.Text = GetHexString(RTB6.Text)
    '    Dim a1 As String = RTB7.Text
    '    Dim a2 As Integer = a1.Length
    '    Dim a3 As Integer = a2 \ 2
    '    If a2 Mod 2 = 0 Then
    '        a3 -= 1
    '    Else
    '        a1 = "0" & a1
    '    End If
    '    Dim bytesa3(a3) As Byte
    '    For c1 As Integer = 0 To a3
    '        bytesa3(c1) = Convert.ToByte(a1.Substring(c1 * 2, 2), 16)
    '    Next

    '    Dim b1 As String = ""
    '    For b2 = 0 To bytesa3.Count - 1

    '        b1 &= Format(bytesa3(b2), "X2") & " "

    '    Next

    '    RTB8.AppendText(b1)
    '    RTB9.Text = HexToString(b1)
    '    'Key = Registry.CurrentUser.OpenSubKey("Software\miHoYo\Genshin Impact", True)
    '    'Key.SetValue(valueName, bytesa3, RegistryValueKind.Binary)


    'End Sub
    Sub MultiAcc()
        If cb_MultiAcc.Checked = True Then
            Me.Size = New Size(653, 319)
        Else
            Me.Size = New Size(327, 319)
        End If
    End Sub
    Sub setParm()
        Sw = Tx_W.Text
        Sh = Tx_H.Text
        If cb_Border.Checked = True Then
            boder = " -popupwindow "
        Else
            boder = ""
        End If

        If cb_Window.Checked = True Then
            Fscreen = "0"
        Else
            Fscreen = "1"
        End If

        If cb_lowset.Checked = True Then
            GQ = "-screen-quality Fastest"
        Else
            Dim nomor As Integer
            nomor = CB_Graphics.SelectedIndex
            Select Case nomor

                Case 1
                    GQ = "-screen-quality Fastest"
                Case 2
                    GQ = "-screen-quality Fast"
                Case 3
                    GQ = "-screen-quality Simple"
                Case 4
                    GQ = "-screen-quality Good"
                Case 5
                    GQ = "-screen-quality Beautiful"
                Case 6
                    GQ = "-screen-quality Fantastic"
                Case 7
                    GQ = "-screen-quality Console"
                Case Else
                    GQ = ""
            End Select
        End If
    End Sub
    Sub OpenGame(gameloc As String, param As String)
        Dim p As New ProcessStartInfo
        p.FileName = gameloc
        p.Arguments = param
        p.UseShellExecute = True
        p.WindowStyle = ProcessWindowStyle.Normal
        Process.Start(p)

    End Sub
    Private Function GenshinIsRunning() As Boolean
        Dim pros = Process.GetProcessesByName("YuanShen")

        If pros.Any() Then
            Return True
        Else
            pros = Process.GetProcessesByName("GenshinImpact")
            Return pros.Any()
        End If
    End Function
    Sub killGI()
        Dim pros = Process.GetProcessesByName("GenshinImpact")

        If pros.Any() Then
            pros(0).Kill()
        End If
    End Sub

    Private Sub Switch(ByVal name As String, ByVal autoRestart As Boolean, ByVal param As String)
        If String.IsNullOrEmpty(name) Then
            MessageBox.Show("Please select an account to switch", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If Not autoRestart Then
            If GenshinIsRunning() Then
                MessageBox.Show("Genshin Impact is running, please close the game process before switching accounts!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If
        If cb_NoPop.Checked OrElse MessageBox.Show($"Do you want to switch to[{name}]", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            If autoRestart Then
                Call killGI()
            End If

            Dim acct As GIAcc = GIAcc.ReadFromDisk(name)
            acct.WriteToRegedit()

            If autoRestart Then

                If String.IsNullOrEmpty(Tx_Game.Text) Then
                    MessageBox.Show("Please select the Genshin installation path before you can use the automatic restart function", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cb_autoRestart.Checked = False
                Else

                    Try
                        Dim startInfo As ProcessStartInfo = New ProcessStartInfo()
                        startInfo.UseShellExecute = True
                        startInfo.WorkingDirectory = Environment.CurrentDirectory
                        startInfo.FileName = Path.Combine(Tx_Game.Text, "GenshinImpact.exe")
                        startInfo.Verb = "runas"
                        startInfo.Arguments = param
                        Process.Start(startInfo)
                    Catch
                    End Try
                End If
            End If

            If Not cb_NoPop.Checked Then
                MessageBox.Show($"account[{name}]switch successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub
    Sub RefrestList()
        If Not Directory.Exists(UserDataPath) Then
            Directory.CreateDirectory(UserDataPath)
        End If

        lv_AccList.Items.Clear()
        acctMenuItemList.Clear()
        Dim root As DirectoryInfo = New DirectoryInfo(UserDataPath)
        Dim files As FileInfo() = root.GetFiles()

        For Each file As FileInfo In files
            lv_AccList.Items.Add(New ListViewItem() With {
                .Text = file.Name
            })
            Dim m As ToolStripMenuItem = New ToolStripMenuItem() With {
                .Name = file.Name,
                .Text = file.Name
            }
            acctMenuItemList.Add(m)

        Next

        If lv_AccList.Items.Count > 0 Then
            btnDeleteAcc.Enabled = True
            BtnSwitchAcc.Enabled = True
        Else
            btnDeleteAcc.Enabled = False
            BtnSwitchAcc.Enabled = False
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = appname
        TSSL_ver.ForeColor = Color.Green
        TSSL_ver.Text = "Last Update!"
        Threading.Thread.Sleep(1000)
        'cekupdate()
        'Tx_Game.Text = get_location
        'info()

        If Not IO.File.Exists(FilePathInI) Then

            getDATA()
            setDATA()
            LoadDATA()
        Else
            LoadDATA()
        End If

        lv_AccList.Columns(0).Width = lv_AccList.Width
        Dim imageList As ImageList = New ImageList()
        imageList.ImageSize = New Size(10, 20)
        lv_AccList.SmallImageList = imageList
        RefrestList()
    End Sub
    Private Sub btn_StartGame_Click(sender As Object, e As EventArgs) Handles btn_StartGame.Click
        setParm()
        Dim param As String = " -screen-width " & Sw & " -screen-height " & Sh & " -screen-fullscreen " & Fscreen & boder & GQ
        saveDATA()
        Dim gameGI As String
        gameGI = Tx_Game.Text & "\" + "GenshinImpact.exe"
        If Not IO.File.Exists(gameGI) Then
            MsgBox("Something Wrong! " + vbCrLf + " I'm can't not find GenshinImpact.exe!", vbCritical)
            End
        Else
            OpenGame(gameGI, param)
        End If


    End Sub


    Private Sub cb_Resolusi_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Resolusi.CheckedChanged
        If cb_Resolusi.Checked = True Then
            Tx_W.Enabled = True
            Tx_H.Enabled = True
            CB_Presets.Enabled = False
        Else
            Tx_W.Enabled = False
            Tx_H.Enabled = False
            CB_Presets.Enabled = True
        End If
    End Sub

    Private Sub CB_Presets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Presets.SelectedIndexChanged
        Dim nomor As Integer
        nomor = CB_Presets.SelectedIndex
        Select Case nomor
            Case 0
                Tx_W.Text = "3840"
                Tx_H.Text = "2160"
            Case 1
                Tx_W.Text = "2560"
                Tx_H.Text = "1440"
            Case 2
                Tx_W.Text = "1920"
                Tx_H.Text = "1080"
            Case 3
                Tx_W.Text = "1366"
                Tx_H.Text = "768"
            Case 4
                Tx_W.Text = "1280"
                Tx_H.Text = "720"
            Case 5
                Tx_W.Text = "1024"
                Tx_H.Text = "576"
            Case 6
                Tx_W.Text = "960"
                Tx_H.Text = "540"
            Case 7
                Tx_W.Text = "854"
                Tx_H.Text = "480"
            Case Else

        End Select
    End Sub

    Private Sub cb_lowset_CheckedChanged(sender As Object, e As EventArgs) Handles cb_lowset.CheckedChanged
        If cb_lowset.Checked = True Then
            CB_Graphics.Enabled = False
            Tx_W.Text = "800"
            Tx_H.Text = "600"
            Tx_H.Enabled = False
            Tx_W.Enabled = False
            cb_Window.Checked = True
            cb_Window.Enabled = False
            cb_Resolusi.Enabled = False
            CB_Presets.Enabled = False
            writeini(FilePathInI, "Setting Config", "LowSetting", True)
        Else
            CB_Graphics.Enabled = True
            cb_Resolusi.Enabled = True
            cb_Window.Enabled = True
            If cb_Resolusi.Checked = True Then
                Tx_H.Enabled = True
                Tx_W.Enabled = True
            Else
                CB_Presets.Enabled = True
            End If
            writeini(FilePathInI, "Setting Config", "LowSetting", False)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.ShowDialog()
    End Sub

    Private Sub btnDeleteAcc_Click(sender As Object, e As EventArgs) Handles btnDeleteAcc.Click
        If lv_AccList.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select an account to switch", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim name As String = lv_AccList.SelectedItems(0)?.Text

        If String.IsNullOrEmpty(name) Then
            MessageBox.Show("Please select an account to switch", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim acct As GIAcc
        acct.DeleteFromDisk(name)
        RefrestList()
    End Sub

    Private Sub BtnSwitchAcc_Click(sender As Object, e As EventArgs) Handles BtnSwitchAcc.Click
        setParm()
        Dim param As String = " -screen-width " & Sw & " -screen-height " & Sh & " -screen-fullscreen " & Fscreen & boder & GQ
        saveDATA()

        If lv_AccList.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select an account to switch", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim name As String = lv_AccList.SelectedItems(0)?.Text
        Switch(name, cb_autoRestart.Checked, param)
    End Sub

    Private Sub btnSaveAcc_Click(sender As Object, e As EventArgs) Handles btnSaveAcc.Click
        Dim form As Form3 = New Form3()
        form.ShowDialog()
        RefrestList()
    End Sub

    Private Sub cb_MultiAcc_CheckedChanged(sender As Object, e As EventArgs) Handles cb_MultiAcc.CheckedChanged
        MultiAcc()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        saveDATA()
    End Sub

    Private Sub BtnKill_Click(sender As Object, e As EventArgs) Handles BtnKill.Click
        Call killGI()
    End Sub
End Class
