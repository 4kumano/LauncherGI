Imports Microsoft.Win32
Module HexConvert
    Public Function GetHexString(Source As String) As String
        Dim b As Byte() = System.Text.Encoding.UTF8.GetBytes(Source)
        Return BitConverter.ToString(b).Replace("-", "")
    End Function

    Public Function HexToString(ByVal HexData As String) As String
        Dim Buffer As String
        Dim i As Long

        Do While InStr(HexData, " ")
            HexData = Replace(HexData, " ", vbNullString)
        Loop

        If Len(HexData) Mod 2 <> 0 Then
            HexToString = vbNullString
        Else
            For i = 1 To Len(HexData) - 1 Step 2
                Buffer = Buffer & Chr("&H" & Mid(HexData, i, 2))
            Next i
            HexToString = Buffer
        End If
    End Function
End Module
