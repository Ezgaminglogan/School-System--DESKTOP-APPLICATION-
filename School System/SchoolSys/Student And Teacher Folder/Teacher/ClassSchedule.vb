Imports MySql.Data.MySqlClient

Public Class ClassSchedule
    Dim conn As MySqlConnection = Connect.cons ' Assuming you have a connection setup in Connect.cons

    Private Sub ClassSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Replace with the actual instructor's name or ID when available
        Dim instructorName As String = FullName ' Placeholder. This should come from the logged-in teacher's info.
        LoadClassSchedule(dgTables, instructorName)
    End Sub
End Class
