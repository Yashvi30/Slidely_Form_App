Public Class Form1
    ' Define the structure to store submissions
    Public Structure Submission
        Public Name As String
        Public Email As String
        Public Phone As String
        Public GitHub As String
        Public StopwatchTime As String
    End Structure

    ' List to store submissions
    Public Shared Submissions As New List(Of Submission)

    ' Event handler for View Submissions button
    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New FormViewSubmissions()
        viewForm.ShowDialog()
    End Sub

    ' Event handler for Create Submission button
    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New FormCreateSubmission()
        createForm.ShowDialog()
    End Sub

    ' Handle keydown events for shortcuts
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateSubmission.PerformClick()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure the form can capture keydown events
        Me.KeyPreview = True
    End Sub
End Class
