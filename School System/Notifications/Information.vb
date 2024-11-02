Public Class Information
    Public Sub PositionAlert()
        Dim xPos As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim yPos As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Me.Location = New Point(xPos - Me.Width, yPos - Me.Height)
    End Sub

    Private Sub Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PositionAlert()
        timerAnimation.Interval = 3000
        timerAnimation.Start()
    End Sub


    Private Sub timerAnimation_Tick(sender As Object, e As EventArgs) Handles timerAnimation.Tick
        timerAnimation.Stop() ' Stop the timer
        Me.Close() ' Close the form
    End Sub
End Class