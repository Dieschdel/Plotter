Option Explicit On

Public Class zeroDivision
    Dim rnd As New System.Random
    Dim newMousePosX = rnd.Next(0, 100)
    Dim newMousePosY = rnd.Next(0, 100)

    Private Sub zeroDivision_Load(sender As Object, e As EventArgs) Handles Me.Load
        My.Computer.Audio.Play(
        My.Resources.xpError, AudioPlayMode.Background)
        zeroBox.Image = My.Resources.animated_time_paradox
    End Sub

    Private Sub zeroDivision_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(
        My.Resources.xpError, AudioPlayMode.Background)
    End Sub

    Private Sub zeroDivision_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        newMousePosX = rnd.Next(0, 500) - 250
        newMousePosY = rnd.Next(0, 500) - 250

        Cursor.Position = New Point(
                    Control.MousePosition.X + newMousePosX,
                   Control.MousePosition.Y + newMousePosY)
    End Sub
End Class




