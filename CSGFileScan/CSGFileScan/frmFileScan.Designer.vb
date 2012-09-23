<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileScan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtErrorCount = New System.Windows.Forms.TextBox()
        Me.txtFileLoc = New System.Windows.Forms.TextBox()
        Me.lblErrorCount = New System.Windows.Forms.Label()
        Me.lblFileLoc = New System.Windows.Forms.Label()
        Me.btnRunScan = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtGmailLogin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtErrorCount
        '
        Me.txtErrorCount.Location = New System.Drawing.Point(15, 35)
        Me.txtErrorCount.Name = "txtErrorCount"
        Me.txtErrorCount.Size = New System.Drawing.Size(224, 20)
        Me.txtErrorCount.TabIndex = 0
        '
        'txtFileLoc
        '
        Me.txtFileLoc.Location = New System.Drawing.Point(15, 81)
        Me.txtFileLoc.Name = "txtFileLoc"
        Me.txtFileLoc.Size = New System.Drawing.Size(224, 20)
        Me.txtFileLoc.TabIndex = 1
        '
        'lblErrorCount
        '
        Me.lblErrorCount.AutoSize = True
        Me.lblErrorCount.Enabled = False
        Me.lblErrorCount.Location = New System.Drawing.Point(12, 19)
        Me.lblErrorCount.Name = "lblErrorCount"
        Me.lblErrorCount.Size = New System.Drawing.Size(175, 13)
        Me.lblErrorCount.TabIndex = 2
        Me.lblErrorCount.Text = "Number of Errors before email sent?"
        '
        'lblFileLoc
        '
        Me.lblFileLoc.AutoSize = True
        Me.lblFileLoc.Enabled = False
        Me.lblFileLoc.Location = New System.Drawing.Point(15, 62)
        Me.lblFileLoc.Name = "lblFileLoc"
        Me.lblFileLoc.Size = New System.Drawing.Size(76, 13)
        Me.lblFileLoc.TabIndex = 3
        Me.lblFileLoc.Text = "File Location? "
        '
        'btnRunScan
        '
        Me.btnRunScan.Location = New System.Drawing.Point(19, 238)
        Me.btnRunScan.Name = "btnRunScan"
        Me.btnRunScan.Size = New System.Drawing.Size(75, 23)
        Me.btnRunScan.TabIndex = 4
        Me.btnRunScan.Text = "Scan File"
        Me.btnRunScan.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(112, 238)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(18, 97)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(101, 23)
        Me.btnBrowse.TabIndex = 6
        Me.btnBrowse.Text = "Browse for folder"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtGmailLogin
        '
        Me.txtGmailLogin.Location = New System.Drawing.Point(15, 142)
        Me.txtGmailLogin.Name = "txtGmailLogin"
        Me.txtGmailLogin.Size = New System.Drawing.Size(100, 20)
        Me.txtGmailLogin.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(15, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Gmail Login? (required to send email)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(18, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Gmail Password? (will not be saved)"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(15, 196)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'frmFileScan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 296)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGmailLogin)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRunScan)
        Me.Controls.Add(Me.lblFileLoc)
        Me.Controls.Add(Me.lblErrorCount)
        Me.Controls.Add(Me.txtFileLoc)
        Me.Controls.Add(Me.txtErrorCount)
        Me.Name = "frmFileScan"
        Me.Text = "File Scan Configuration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtErrorCount As System.Windows.Forms.TextBox
    Friend WithEvents txtFileLoc As System.Windows.Forms.TextBox
    Friend WithEvents lblErrorCount As System.Windows.Forms.Label
    Friend WithEvents lblFileLoc As System.Windows.Forms.Label
    Friend WithEvents btnRunScan As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtGmailLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox

End Class
