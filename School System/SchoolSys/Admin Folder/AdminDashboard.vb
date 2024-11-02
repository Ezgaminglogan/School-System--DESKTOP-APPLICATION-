Public Class AdminDashboard
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentCount(lblStudent)
        LoadCourseCount(lblCourse)
        LoadSectionCount(lblSections)
        LoadUserCount(lblUsers)
        LoadTeacherCount(lblTeacherC)
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
End Class