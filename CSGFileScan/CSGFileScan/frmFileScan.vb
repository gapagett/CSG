Public Class frmFileScan

    Private Sub frmFileScan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'default values for file scan
        Me.txtErrorCount.Text = 5
        Me.txtFileLoc.Text = "C:\Logs\ErrorLog.txt"
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim FileDialog As New OpenFileDialog
        'opens the folder dialog in order to allowe user to select the folder which contains the error log
        FileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        FileDialog.InitialDirectory = "C:\"
        FileDialog.FilterIndex = 2
        FileDialog.RestoreDirectory = True
        FileDialog.ShowDialog()
        txtFileLoc.Text = FileDialog.FileName
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub btnRunScan_Click(sender As Object, e As EventArgs) Handles btnRunScan.Click
        If Me.txtErrorCount.Text < 0 Or Me.txtErrorCount.Text > 9 Or Not IsNumeric(Me.txtErrorCount.Text) Then
            MsgBox("Error Count must be between 1 and 9, please reenter.")
        ElseIf Me.txtGmailLogin.Text = "" Or Me.txtPassword.Text = "" Then
            MsgBox("Must enter Gmail Login and Password.")
        Else

            Call ScanLogFile(CInt(Me.txtErrorCount.Text), Me.txtFileLoc.Text)
            Call SendEmail(Me.txtGmailLogin.Text, Me.txtPassword.Text)
        End If
    End Sub

End Class
