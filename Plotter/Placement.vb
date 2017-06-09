Option Explicit On

Public Class Placement
    Private Sub Placement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reportedError As String, solveHint As String, Code As String



        My.Computer.Audio.PlaySystemSound(
                System.Media.SystemSounds.Asterisk)

        reportedError = "An error occured."
        solveHint = "We are working really really really hard to find a solution for you."
        Code = "Error Code: " & Module1._errrorCode

        If Module1._errrorCode = "" Then
            Code = Code & "000 //Unknown Error"
        ElseIf Module1._errrorCode = "001" Then
            Code = Code & " //Stack OVERFLOW"
        End If
        Module1._errrorCode = ""

        errorBox.Text = reportedError & vbCrLf & solveHint & vbCrLf & Code

        Dim rnd As New System.Random
        Dim rndAd = rnd.Next(1, 100)
        If rndAd < 30 Then
            adBox.Image = (My.Resources.Sponsor1)
        ElseIf rndAd >= 30 Then
            adBox.Image = (My.Resources.Sponsor2)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class