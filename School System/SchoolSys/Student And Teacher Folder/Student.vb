Public Class Student
    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")

        lblStudentName.Text = FullName
        lblStudentID.Text = StudentID

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
    End Sub

    Private Sub cbForms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbForms.SelectedIndexChanged
        Select Case cbForms.SelectedItem
            Case "ENROLLMENT SECTION"
                With Enrollment
                    .TopLevel = False
                    panelForms.Controls.Add(Enrollment)
                    .BringToFront()
                    .Show()
                End With
        End Select
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

    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox2.SelectedIndexChanged
        Select Case Guna2ComboBox2.SelectedItem
            Case "STUDY LOAD"
                With StudyLoad
                    .TopLevel = False
                    panelForms.Controls.Add(StudyLoad)
                    .BringToFront()
                    .Show()
                End With
            Case "VIEW GRADES"
                With ViewGrades
                    .TopLevel = False
                    panelForms.Controls.Add(ViewGrades)
                    .BringToFront()
                    .Show()
                End With
        End Select
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs)

    End Sub
End Class