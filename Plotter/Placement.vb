Option Explicit On

Public Class Placement
    Private Sub Placement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reportedError As String, solveHint As String

        reportedError = "An unknown error occured."
        solveHint = "We are working really really really hard to find a solution for you."

        errorBox.Text = reportedError & vbCrLf & solveHint

        Dim rnd As New System.Random
        Dim rndAd = rnd.Next(1, 100)
        If rndAd < 30 Then
            adBox.Image = (My.Resources.Sponsor1)
        ElseIf rndAd >= 30 Then
            adBox.Image = (My.Resources.Sponsor2)
        End If
    End Sub
End Class