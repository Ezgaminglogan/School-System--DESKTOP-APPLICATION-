Public Class Teacher
    Private Sub Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
        lblTeach.Text = FullName
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
    End Sub

    Private Sub btnGrades_Click(sender As Object, e As EventArgs) Handles btnGrades.Click
        With Grades
            .TopLevel = False
            panelForms.Controls.Add(Grades)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        With ClassSchedule
            .TopLevel = False
            panelForms.Controls.Add(ClassSchedule)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Clear the session variables
            UserID = String.Empty
            FullName = String.Empty
            UserType = String.Empty

            ' Show the login form again
            Dim loginForm As New Login()
            loginForm.Show()

            ' Close the current form
            Me.Close()
        End If
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        With AttendanceSheet
            .TopLevel = False
            panelForms.Controls.Add(AttendanceSheet)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class