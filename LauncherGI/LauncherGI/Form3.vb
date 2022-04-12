Imports LauncherGI.GenshinAccount

Public Class Form3
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If String.IsNullOrWhiteSpace(Tx_NameAcc.Text) Then
            MessageBox.Show("Please enter account remarks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim acct As GIAcc = GIAcc.ReadFromRegedit(False)
        acct.Name = Tx_NameAcc.Text
        acct.WriteToDisk()
        Me.Close()
    End Sub
End Class