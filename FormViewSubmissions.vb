Imports System.Net.Http
Imports Newtonsoft.Json

Public Class FormViewSubmissions
    Private currentIndex As Integer = 0

    Private Async Sub FormViewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure the form can capture keydown events
        Me.KeyPreview = True
        Await LoadSubmission()
    End Sub

    Private Async Function LoadSubmission() As Task
        Using client As New HttpClient()
            Dim response = Await client.GetStringAsync($"http://localhost:3000/read?index={currentIndex}")
            Dim submission = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(response)

            txtName.ReadOnly = True
            txtName.Text = submission("Name")

            txtEmail.ReadOnly = True
            txtEmail.Text = submission("Email")

            txtPhone.ReadOnly = True
            txtPhone.Text = submission("Phone")

            txtGitHub.ReadOnly = True
            txtGitHub.Text = submission("GitHub")

            txtStopwatchTime.ReadOnly = True
            txtStopwatchTime.Text = submission("StopwatchTime")
        End Using
    End Function

    ' Navigate to the previous submission
    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await LoadSubmission()
        End If
    End Sub

    ' Navigate to the next submission
    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Assuming there is a way to check if there is a next submission
        ' For example, if you know the total number of submissions, you can check against it
        currentIndex += 1
        Await LoadSubmission()
    End Sub

    ' Handle keydown events for shortcuts
    Private Sub FormViewSubmissions_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub
End Class
