Imports System.Net.Mail
Imports System
Imports System.IO
Module Functions
    Function ScanLogFile(ErrorCount As Integer, FileLocation As String)
        Dim iMinutes As Integer = 0
        Dim ArrayLocation As Integer = 0
        Dim FinalLocation As Integer = 0
        Dim ErrorLocation As Integer = 0
        Dim returnCount As Integer = 1

        Dim ReturnString As String

        Dim Reader As StreamReader = New StreamReader(FileLocation)

        Dim tempArray As String()
        Dim Time As String()
        Dim Key1 As String()
        Dim Key2 As String()
        Dim Description As String()

        'number of minutes between errors
        iMinutes = 5

        Do While Reader.Peek <> -1
            'makes each of the arrays one large to hold more data
            ReDim Preserve Time(ArrayLocation)
            ReDim Preserve Key1(ArrayLocation)
            ReDim Preserve Key2(ArrayLocation)
            ReDim Preserve Description(ArrayLocation)

            'sets each new row to a value from the text file
            tempArray = Split(Reader.ReadLine, "|")
            Time(ArrayLocation) = tempArray(0)
            Key1(ArrayLocation) = tempArray(1)
            Key2(ArrayLocation) = tempArray(2)
            Description(ArrayLocation) = tempArray(3)

            'adds one more to location counter to allow for the addition, if needed, of rows to the arrays
            ArrayLocation += 1
        Loop

        'creates the final array based on the number of insertions done to the above. we subtract one because it adds one extraneous count. 
        Dim FinalArray(ArrayLocation - 1, 3)
        'combines the 4 arrays into one array for faster processing.
        For FinalLocation = 0 To (ArrayLocation - 1)
            FinalArray(FinalLocation, 0) = CDate(Time(FinalLocation))
            FinalArray(FinalLocation, 1) = Key1(FinalLocation)
            FinalArray(FinalLocation, 2) = Key2(FinalLocation)
            FinalArray(FinalLocation, 3) = Description(FinalLocation)
        Next FinalLocation

        'spins through the array to find duplicates in the timeframe.
        Dim ErrorArray(ArrayLocation - 1, 4)
        For FinalLocation = 0 To (ArrayLocation - 1)
            For ErrorLocation = 0 To (ArrayLocation - 1)
                If FinalArray(FinalLocation, 0) >= ErrorArray(ErrorLocation, 0) And FinalArray(FinalLocation, 0) <= DateAdd(DateInterval.Minute, 5, ErrorArray(ErrorLocation, 0)) _
                        And FinalArray(FinalLocation, 1) = ErrorArray(ErrorLocation, 1) And FinalArray(FinalLocation, 2) = ErrorArray(ErrorLocation, 2) And (ErrorArray(ErrorLocation, 4)) < ErrorCount Then
                    ErrorArray(ErrorLocation, 4) += 1
                    ErrorArray(ErrorLocation, 0) = FinalArray(FinalLocation, 0)
                    ErrorLocation = ArrayLocation + 1
                ElseIf IsNothing(ErrorArray(ErrorLocation, 0)) Then
                    ErrorArray(ErrorLocation, 0) = FinalArray(FinalLocation, 0)
                    ErrorArray(ErrorLocation, 1) = FinalArray(FinalLocation, 1)
                    ErrorArray(ErrorLocation, 2) = FinalArray(FinalLocation, 2)
                    ErrorArray(ErrorLocation, 3) = FinalArray(FinalLocation, 3)
                    ErrorArray(ErrorLocation, 4) = 1
                    ErrorLocation = ArrayLocation + 1
                End If
            Next ErrorLocation
        Next FinalLocation

        'creates the body of the email by concatenating the information where the errors are over the threshold
        ReturnString = ""
        For ErrorLocation = 0 To ArrayLocation - 1
            If ErrorArray(ErrorLocation, 4) = ErrorCount Then
                ReturnString = ReturnString & "Notification " & returnCount & ": " & _
                                ErrorArray(ErrorLocation, 0) & "|" & ErrorArray(ErrorLocation, 1) & "|" & ErrorArray(ErrorLocation, 2) & _
                                "|" & ErrorArray(ErrorLocation, 3) & vbCrLf
                returnCount += 1
            End If
        Next ErrorLocation
        ScanLogFile = ReturnString
    End Function
    Sub SendEmail(UserName As String, Password As String, EmailBody As String)
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
            NewMessage.Subject = "CSG FileScan Errors - Greg Pagett"
            NewMessage.Body = EmailBody
            NewMessage.Priority = MailPriority.High
            Server.Send(NewMessage)
            MsgBox("Sent")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
