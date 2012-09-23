Imports System.Net.Mail
Module Functions
    Function SendEmail()
        Try
            Dim Server As New SmtpClient
            Dim NewMessage As New MailMessage
            'set the server credentials
            Server.Credentials = New Net.NetworkCredential(InputBox("Enter GMail Login"), InputBox("Enter GMail Password (will not be saved)"))
            'required in order to create a secure SSL. must set gmail to "Don't always use https"
            Server.EnableSsl = True
            Server.Port = 587
            Server.Host = "smtp.gmail.com"
            NewMessage = New MailMessage
            NewMessage.From = New MailAddress("casperpage@gmail.com")
            NewMessage.To.Add("gapagett@cox.net")
            NewMessage.Subject = "CSG FileScan Errors"
            NewMessage.Body = "This is the body"
            NewMessage.Priority = MailPriority.High
            Server.Send(NewMessage)
            MsgBox("Sent")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function
End Module
