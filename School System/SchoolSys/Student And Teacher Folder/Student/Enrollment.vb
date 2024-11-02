Imports MySql.Data.MySqlClient

Public Class Enrollment
    Dim conn As MySqlConnection = Connect.cons

    Private Sub Enrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchCourseNumbersForEnrollment(cbCourseNumber)

        LoadEnrolledCourses(dgTables, StudentID)

    End Sub

    Private Sub cbCourseNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCourseNumber.SelectedIndexChanged
        FetchSections(cbCourseNumber.SelectedItem.ToString(), cbSectionIdentifier)
    End Sub

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click

        Dim studentNumber As Integer = Integer.Parse(tbStudentNumber.Text)
        Dim courseNumber As String = cbCourseNumber.SelectedItem.ToString()
        Dim sectionIdentifier As Integer = Integer.Parse(cbSectionIdentifier.SelectedItem.ToString())

        ' Check prerequisites before enrolling
        If CheckPrerequisites(studentNumber, courseNumber) Then
            EnrollStudent(studentNumber, courseNumber, sectionIdentifier)
        End If
        LoadEnrolledCourses(dgTables, studentNumber)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadEnrolledCourses(dgTables, StudentID)
    End Sub
End Class
