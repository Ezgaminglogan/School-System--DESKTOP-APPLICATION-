Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient



Public Class Admin

    Dim conn As MySqlConnection = Connect.cons


    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCdate.Text = "Date : " + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
        timers.Start()


        LoadStudentCount(lblStudent)
        LoadCourseCount(lblCourse)
        LoadSectionCount(lblSections)
        LoadUserCount(lblUsers)
        LoadTeacherCount(lblTeacherC)




        If String.IsNullOrEmpty(UserID) Then
            ' Use BeginInvoke to delay the form closing until after Load event is complete
            BeginInvoke(New MethodInvoker(AddressOf CloseForm))

        End If




    End Sub

    Private Sub timers_Tick(sender As Object, e As EventArgs) Handles timers.Tick
        lblCdate.Text = "Date : " + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
    End Sub


    Private Sub btnCourse_Click(sender As Object, e As EventArgs) Handles btnCourse.Click
        With Course
            .TopLevel = False
            panelForms.Controls.Add(Course)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        With AdminDashboard
            .TopLevel = False
            panelForms.Controls.Add(AdminDashboard)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub cbTables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTables.SelectedIndexChanged
        Select Case cbTables.SelectedItem
            Case "STUDENT TABLE"
                LoadStudentTable(dgTables)
            Case "COURSE TABLE"
                LoadCourseTable(dgTables)
            Case "SECTION TABLE"
                LoadSectionTable(dgTables)
            Case "USER TABLE"
                LoadUserTable(dgTables)
            Case "TEACHER TABLE"
                LoadTeacherTable(dgTables)
            Case "PREREQUISITE TABLE"
                LoadPrequisiteTable(dgTables)
        End Select
    End Sub

    Private Sub btnSection_Click(sender As Object, e As EventArgs) Handles btnSection.Click
        With Section
            .TopLevel = False
            panelForms.Controls.Add(Section)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        With User
            .TopLevel = False
            panelForms.Controls.Add(User)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Clear the session variables
            UserID = String.Empty
            FullName = String.Empty

            ' Show the login form again
            Dim loginForm As New Login()
            loginForm.Show()

            ' Close the current form
            Me.Close()
        End If
    End Sub


    Private Sub CloseForm()
        MessageBox.Show("You need to log in as an Admin before continuing.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Me.Close()
    End Sub

    Private Sub btnPreq_Click(sender As Object, e As EventArgs) Handles btnPreq.Click
        With Prerequisite
            .TopLevel = False
            panelForms.Controls.Add(Prerequisite)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Vacancy.Show()
    End Sub
End Class
