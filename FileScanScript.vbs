dim ErrorCountConfig
dim ErrorFileLoc
dim continue

ErrorCountConfig = 3

on error resume next
ErrorCountConfig = cint(inputbox("Enter the number of errors before email is sent, default is 3.","Error Count COnfiguration"))
if ErrorCountConfig = 0 then
	ErrorCountConfig = 3
end if


on error resume next
ErrorFileLoc = InputBox("Enter the location of the file to be scanned: ", "Log File Location")
if errorFileLoc = "" then
	ErrorFileLoc = "C:\Logs"	
end if


continue = msgbox "Are you sure you want to run the Scan with the following settings. " & vbcrlf & "Error Count: " & ErrorCountConfig & vbcrlf & "Error FIle Location: " & ErrorFileLoc & "?" , 4, "Confirmation"

if continue = vbok then
	msgbox "Continue"
else
