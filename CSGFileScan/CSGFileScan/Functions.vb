Imports System.Net.Mail
Module Functions
    Function SendEmail()
        Try
            Dim Server As New SmtpClient
            Dim NewMessage As New MailMessage
            Server.Credentials = New Net.NetworkCredential("Casperpage", "Lily4_Frost")
            Server.Port = 587
            Server.Host = "smtp.gmail.com"
            Server.EnableSsl = True
            NewMessage = New MailMessage
            NewMessage.From = New MailAddress("casperpage@gmail.com")
            NewMessage.To.Add("gapagett@cox.net")
            NewMessage.Subject = "CSG FileScan Errors"
            NewMessage.Body = "This is the body"
            Server.Send(NewMessage)
            MsgBox("Sent")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function
End Module
