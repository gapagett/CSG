Imports System.Net.Mail
Imports System
Imports System.IO
Module Functions
    Function ScanLogFile(ErrorCount As Integer, FileLocation As String)
        Dim iMinutes As Integer
        Dim Reader As StreamReader = New StreamReader(FileLocation)
        Dim tempArray As String()
        Dim i As Integer

        Dim Time As String()
        Dim Key1 As String()
        Dim Key2 As String()
        Dim Description As String()

        Dim ArrayLocation As Integer = 0

        Do While Reader.Peek <> -1
            'makes each of the arrays one large to hold more data
            ReDim Preserve Time(ArrayLocation)
            ReDim Preserve Key1(ArrayLocation)
            ReDim Preserve Key2(ArrayLocation)
            ReDim Preserve Description(ArrayLocation)

            'sets each new row to a value from the text file
            temparray = Split(Reader.ReadLine, "|")
            Time(ArrayLocation) = temparray(0)
            Key1(ArrayLocation) = temparray(1)
            Key2(ArrayLocation) = temparray(2)
            Description(ArrayLocation) = temparray(3)

            'adds one more to location counter to allow for the addition, if needed, of rows to the arrays
            ArrayLocation += 1
        Loop
        'creates the final array based on the number of insertions done to the above. we subtract one because it adds one extraneous count. 
        Dim FinalArray(ArrayLocation - 1, 3)
        'combines the 4 arrays into one array for faster processing.
        For i = 0 To (ArrayLocation - 1)
            FinalArray(i, 0) = Time(i)
            FinalArray(i, 1) = Key1(i)
            FinalArray(i, 2) = Key2(i)
            FinalArray(i, 3) = Description(i)
        Next i

        'number of minutes between errors
        iMinutes = 5



    End Function
    Sub SendEmail(UserName As String, Password As String)
        Try
            Dim Server As New SmtpClient
            Dim NewMessage As New MailMessage
            'set the server credentials
            Server.Credentials = New Net.NetworkCredential(UserName, Password)
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
    End Sub
End Module
