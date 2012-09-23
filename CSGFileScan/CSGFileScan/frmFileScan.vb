Public Class frmFileScan

    Private Sub frmFileScan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'default values for file scan
        Me.txtErrorCount.Text = 3
        Me.txtFileLoc.Text = "C:\Logs"
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim FolderDialog As New FolderBrowserDialog
        'opens the folder dialog in order to allowe user to select the folder which contains the error log
        FolderDialog.ShowDialog()
        txtFileLoc.Text = FolderDialog.SelectedPath
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class
