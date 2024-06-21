Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text


Public Class FormViewSubmissions
    Private currentIndex As Integer = 0
    Private submissions As List(Of Form1.Submission)

    ' Load the first submission when the form loads
    Private Async Sub FormViewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmissions()
        DisplaySubmission()
        ' Ensure the form can capture keydown events
        Me.KeyPreview = True
    End Sub

    ' Load submissions from the backend
    Private Async Function LoadSubmissions() As Task
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/read?index=" & currentIndex)
            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                submissions = JsonConvert.DeserializeObject(Of List(Of Form1.Submission))(jsonResponse)
            Else
                MessageBox.Show("Error retrieving submissions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                submissions = New List(Of Form1.Submission)
            End If
        End Using
    End Function

    ' Display the current submission
    Private Sub DisplaySubmission()
        If submissions.Count > 0 Then
            Dim submission = submissions(currentIndex)
            lblSubmission.Text = $"Name: {submission.Name}" & Environment.NewLine &
                                 $"Email: {submission.Email}" & Environment.NewLine &
                                 $"Phone: {submission.Phone}" & Environment.NewLine &
                                 $"GitHub: {submission.GitHub}" & Environment.NewLine &
                                 $"Stopwatch Time: {submission.StopwatchTime}"
        Else
            lblSubmission.Text = "No submissions available."
        End If
    End Sub

    ' Navigate to the previous submission
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    ' Navigate to the next submission
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
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
