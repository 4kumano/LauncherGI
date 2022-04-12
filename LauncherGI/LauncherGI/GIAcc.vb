Imports Microsoft.Win32
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Web.Script.Serialization
Imports System.Windows.Forms

Namespace GenshinAccount
    <Serializable>
    Public Class GIAcc
        Public Property Name As String
        Public Property MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810 As String
        Public Property GENERAL_DATA_h2389025596 As String

        Public Shared Function ReadFromDisk(ByVal name As String) As GIAcc
            Dim p As String = Path.Combine(Application.StartupPath, "UserData", name)
            Dim json As String = File.ReadAllText(p)
            Dim acct As GIAcc = New JavaScriptSerializer().Deserialize(Of GIAcc)(json)
            Return acct
        End Function

        Public Sub WriteToDisk()
            File.WriteAllText(Path.Combine(Application.StartupPath, "UserData", Name), New JavaScriptSerializer().Serialize(Me))
        End Sub

        Public Shared Sub DeleteFromDisk(ByVal name As String)
            File.Delete(Path.Combine(Application.StartupPath, "UserData", name))
        End Sub

        Public Shared Function ReadFromRegedit(ByVal needSettings As Boolean) As GIAcc
            Dim acct As GIAcc = New GIAcc()
            acct.MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810 = GetStringFromRegedit("MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810")

            If needSettings Then
                acct.GENERAL_DATA_h2389025596 = GetStringFromRegedit("GENERAL_DATA_h2389025596")
            End If

            Return acct
        End Function

        Public Sub WriteToRegedit()
            If String.IsNullOrWhiteSpace(MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810) Then
                MessageBox.Show("Save account content is empty ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Else
                SetStringToRegedit("MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810", MIHOYOSDK_ADL_PROD_OVERSEA_h1158948810)

                If Not String.IsNullOrWhiteSpace(GENERAL_DATA_h2389025596) Then
                    SetStringToRegedit("GENERAL_DATA_h2389025596", GENERAL_DATA_h2389025596)
                End If
            End If
        End Sub

        Private Shared Function GetStringFromRegedit(ByVal key As String) As String
            Dim value As Object = Registry.GetValue("HKEY_CURRENT_USER\Software\miHoYo\Genshin Impact", key, "")
            Return Encoding.UTF8.GetString(CType(value, Byte()))
        End Function

        Private Shared Sub SetStringToRegedit(ByVal key As String, ByVal value As String)
            Registry.SetValue("HKEY_CURRENT_USER\Software\miHoYo\Genshin Impact", key, Encoding.UTF8.GetBytes(value))
        End Sub
    End Class
End Namespace
