<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCreateSubmission
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
        btnStopwatch = New Button()
        btnSubmit = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHub = New TextBox()
        lblStopwatch = New Label()
        SuspendLayout()
        ' 
        ' btnStopwatch
        ' 
        btnStopwatch.BackColor = Color.Moccasin
        btnStopwatch.Location = New Point(121, 320)
        btnStopwatch.Name = "btnStopwatch"
        btnStopwatch.Size = New Size(209, 34)
        btnStopwatch.TabIndex = 1
        btnStopwatch.Text = "Toggle Stopwatch (Ctrl + T)"
        btnStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.LightSkyBlue
        btnSubmit.Location = New Point(121, 370)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(369, 41)
        btnSubmit.TabIndex = 2
        btnSubmit.Text = "Submit (Ctrl + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(121, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 3
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(121, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 4
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(121, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 5
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(121, 260)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 40)
        Label5.TabIndex = 6
        Label5.Text = "GitHub Link " & vbCrLf & "Task 2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(146, 43)
        Label6.Name = "Label6"
        Label6.Size = New Size(300, 20)
        Label6.TabIndex = 7
        Label6.Text = "Yashvi Garg, Slidely Task 2, Slidely Form App"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(278, 106)
        txtName.Name = "txtName"
        txtName.Size = New Size(212, 27)
        txtName.TabIndex = 8
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(278, 154)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(212, 27)
        txtEmail.TabIndex = 9
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(278, 209)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(212, 27)
        txtPhone.TabIndex = 10
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Location = New Point(278, 260)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.Size = New Size(212, 27)
        txtGitHub.TabIndex = 11
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.BackColor = SystemColors.InactiveCaption
        lblStopwatch.BorderStyle = BorderStyle.Fixed3D
        lblStopwatch.Location = New Point(379, 326)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(55, 22)
        lblStopwatch.TabIndex = 12
        lblStopwatch.Text = "Label1"
        ' 
        ' FormCreateSubmission
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblStopwatch)
        Controls.Add(txtGitHub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnSubmit)
        Controls.Add(btnStopwatch)
        Name = "FormCreateSubmission"
        Text = "FormCreateSubmission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHub As TextBox
End Class
