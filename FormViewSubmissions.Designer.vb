<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViewSubmissions
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
        Label2 = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHub = New TextBox()
        txtStopwatchTime = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(235, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(300, 20)
        Label2.TabIndex = 1
        Label2.Text = "Yashvi Garg, Slidely Task 2, Slidely Form App"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Moccasin
        btnPrevious.Location = New Point(235, 368)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(133, 52)
        btnPrevious.TabIndex = 2
        btnPrevious.Text = "Previous (Ctrl+ P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.LightSkyBlue
        btnNext.Location = New Point(413, 368)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(125, 52)
        btnNext.TabIndex = 3
        btnNext.Text = "Next (Ctrl+ N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.InactiveCaption
        txtName.Location = New Point(335, 94)
        txtName.Name = "txtName"
        txtName.Size = New Size(202, 27)
        txtName.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.InactiveCaption
        txtEmail.Location = New Point(335, 145)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(202, 27)
        txtEmail.TabIndex = 5
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = SystemColors.InactiveCaption
        txtPhone.Location = New Point(333, 204)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(204, 27)
        txtPhone.TabIndex = 6
        ' 
        ' txtGitHub
        ' 
        txtGitHub.BackColor = SystemColors.InactiveCaption
        txtGitHub.Location = New Point(334, 255)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.Size = New Size(203, 27)
        txtGitHub.TabIndex = 7
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.BackColor = SystemColors.InactiveCaption
        txtStopwatchTime.Location = New Point(335, 308)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.Size = New Size(202, 27)
        txtStopwatchTime.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(233, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 9
        Label1.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(233, 152)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 10
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(233, 211)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 20)
        Label4.TabIndex = 11
        Label4.Text = "Phone"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(232, 251)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 40)
        Label5.TabIndex = 12
        Label5.Text = "Github link" & vbCrLf & "Task 2" & vbCrLf
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(233, 305)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 40)
        Label6.TabIndex = 13
        Label6.Text = "Stopwatch " & vbCrLf & "Time"
        ' 
        ' FormViewSubmissions
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGitHub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Label2)
        Name = "FormViewSubmissions"
        Text = "FormViewSubmissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
