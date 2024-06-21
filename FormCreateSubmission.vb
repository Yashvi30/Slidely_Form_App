Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class FormCreateSubmission
    ' Variables for the stopwatch functionality
    Private stopwatchRunning As Boolean = False
    Private stopwatchStartTime As DateTime
    Private stopwatchElapsed As TimeSpan = TimeSpan.Zero

    ' Timer to update the stopwatch display
    Private WithEvents updateTimer As New Timer()

    ' Initialize the form and timer
    Private Sub FormCreateSubmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the interval to 1000ms (1 second)
        updateTimer.Interval = 1000
        ' Start the timer
        updateTimer.Start()
        ' Initialize the stopwatch label
        lblStopwatch.Text = "00:00:00"
        ' Ensure the form can capture keydown events
        Me.KeyPreview = True
    End Sub

    ' Event handler for the stopwatch button click
    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs) Handles btnStopwatch.Click
        If stopwatchRunning Then
            ' If the stopwatch is running, pause it
            stopwatchElapsed += DateTime.Now - stopwatchStartTime
            btnStopwatch.Text = "Resume Stopwatch"
        Else
            ' If the stopwatch is paused, start it
            stopwatchStartTime = DateTime.Now
            btnStopwatch.Text = "Pause Stopwatch"
        End If
        stopwatchRunning = Not stopwatchRunning
    End Sub

    ' Event handler for the timer tick event
    Private Sub updateTimer_Tick(sender As Object, e As EventArgs) Handles updateTimer.Tick
        If stopwatchRunning Then
            ' Calculate the elapsed time and update the label
            Dim elapsed = stopwatchElapsed + (DateTime.Now - stopwatchStartTime)
            lblStopwatch.Text = elapsed.ToString("hh\:mm\:ss")
        Else
            ' If the stopwatch is paused, show the paused time
            lblStopwatch.Text = stopwatchElapsed.ToString("hh\:mm\:ss")
        End If
    End Sub

    ' Event handler for the submit button click
    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Calculate the final stopwatch time
        Dim finalStopwatchTime As String = lblStopwatch.Text

        ' Create a new submission
        Dim newSubmission As New Form1.Submission With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .GitHub = txtGitHub.Text,
            .StopwatchTime = finalStopwatchTime
        }

        ' Convert the submission to JSON
        Dim jsonSubmission As String = JsonConvert.SerializeObject(newSubmission)

        ' Send the submission to the backend
        Using client As New HttpClient()
            Dim content As New StringContent(jsonSubmission, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error creating submission", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using

        ' Close the form
        Me.Close()
    End Sub

    ' Handle keydown events for shortcuts
    Private Sub FormCreateSubmission_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub
End Class
