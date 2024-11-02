Imports MySql.Data.MySqlClient
Public Class ViewGrades
    Dim conn As MySqlConnection = Connect.cons

    Private Sub ViewGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEnrolledCourses(dgTables, StudentID)
    End Sub
End Class