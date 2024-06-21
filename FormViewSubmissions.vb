Imports System.Net.Http
Imports Newtonsoft.Json

Public Class FormViewSubmissions
    Private currentIndex As Integer = 0
    Private totalSubmissions As Integer = 0

    Private Async Sub FormViewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure the form can capture keydown events
        Me.KeyPreview = True
        Await LoadTotalSubmissions()
        Await LoadSubmission()
    End Sub

    Private Async Function LoadTotalSubmissions() As Task
        Using client As New HttpClient()
            Try
                Dim response = Await client.GetStringAsync("http://localhost:3000/total")
                Dim result = JsonConvert.DeserializeObject(Of Dictionary(Of String, Integer))(response)
                totalSubmissions = result("total")
            Catch ex As Exception
                MessageBox.Show($"Error loading total submissions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Function

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

        UpdateNavigationButtons()
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
        If currentIndex < totalSubmissions - 1 Then
            currentIndex += 1
            Await LoadSubmission()
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

    ' Update navigation buttons state
    Private Sub UpdateNavigationButtons()
        btnPrevious.Enabled = currentIndex > 0
        btnNext.Enabled = currentIndex < totalSubmissions - 1

        ' Disable buttons and show label when at the limits
        If currentIndex <= 0 Then
            btnPrevious.Enabled = False
        End If

        If currentIndex >= totalSubmissions - 1 Then
            btnNext.Enabled = False
        End If

        ' Update label visibility based on button states
        lblLimitReached.Visible = Not btnPrevious.Enabled AndAlso Not btnNext.Enabled
    End Sub
End Class
