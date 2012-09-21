dim ErrorCountConfig
dim ErrorFileLoc

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

msgbox ErrorFileLoc
