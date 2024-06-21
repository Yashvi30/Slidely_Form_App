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
        lblSubmission = New Label()
        Label2 = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' lblSubmission
        ' 
        lblSubmission.AutoSize = True
        lblSubmission.Location = New Point(222, 97)
        lblSubmission.Name = "lblSubmission"
        lblSubmission.Size = New Size(53, 20)
        lblSubmission.TabIndex = 0
        lblSubmission.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(216, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(300, 20)
        Label2.TabIndex = 1
        Label2.Text = "Yashvi Garg, Slidely Task 2, Slidely Form App"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Moccasin
        btnPrevious.Location = New Point(222, 346)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(133, 45)
        btnPrevious.TabIndex = 2
        btnPrevious.Text = "Previous (Ctrl+ P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.LightSkyBlue
        btnNext.Location = New Point(372, 346)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(125, 45)
        btnNext.TabIndex = 3
        btnNext.Text = "Next (Ctrl+ N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' FormViewSubmissions
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Label2)
        Controls.Add(lblSubmission)
        Name = "FormViewSubmissions"
        Text = "FormViewSubmissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSubmission As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
