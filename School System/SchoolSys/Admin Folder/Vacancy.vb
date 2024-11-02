Imports MySql.Data.MySqlClient

Public Class Vacancy
    Dim conn As MySqlConnection = Connect.cons
    Dim command As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim ds As DataSet

    Private Sub Vacancy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourseNumbers() ' Load Course Numbers into cbCourseNumber
        LoadSectionIdentifiers() ' Load Section Identifiers into cbSectionID
        LoadVacancyTable(dgTables) ' Load existing vacancies into the DataGridView
    End Sub

    Private Sub LoadCourseNumbers()
        Try
            conn.Open()
            Dim query As String = "SELECT Course_number FROM course"
            command = New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            cbCourseNumber.Items.Clear()

            While reader.Read()
                cbCourseNumber.Items.Add(reader("Course_number").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading course numbers: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadSectionIdentifiers()
        Try
            conn.Open()
            Dim query As String = "SELECT Section_identifier FROM section"
            command = New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            cbSectionID.Items.Clear()

            While reader.Read()
                cbSectionID.Items.Add(reader("Section_identifier").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading section identifiers: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' Validate fields
        If String.IsNullOrWhiteSpace(cbCourseNumber.Text) OrElse String.IsNullOrWhiteSpace(cbSectionID.Text) Then
            MessageBox.Show("Please select both a Course Number and a Section Identifier.")
            Return
        End If

        Dim vacant As Integer = CInt(numUPDVacancy.Value)

        Try
            conn.Open()
            Dim query As String = "INSERT INTO vacancy (Course_number, Section_identifier, vacant) VALUES (@Course_number, @Section_identifier, @Vacant)"
            command = New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@Course_number", cbCourseNumber.Text)
            command.Parameters.AddWithValue("@Section_identifier", cbSectionID.Text)
            command.Parameters.AddWithValue("@Vacant", vacant)

            Dim result As Integer = command.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Vacancy created successfully.")
                LoadVacancyTable(dgTables) ' Refresh the table
                ClearFields() ' Clear the fields after successful creation
            End If
        Catch ex As Exception
            MessageBox.Show("Error creating vacancy: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Validate that a row is selected in the DataGridView
        If dgTables.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a vacancy to delete.")
            Return
        End If

        Dim courseNumber As String = dgTables.SelectedRows(0).Cells("Course_number").Value.ToString()
        Dim sectionIdentifier As String = dgTables.SelectedRows(0).Cells("Section_identifier").Value.ToString()

        Try
            conn.Open()
            Dim query As String = "DELETE FROM vacancy WHERE Course_number = @Course_number AND Section_identifier = @Section_identifier"
            command = New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@Course_number", courseNumber)
            command.Parameters.AddWithValue("@Section_identifier", sectionIdentifier)

            Dim result As Integer = command.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Vacancy deleted successfully.")
                LoadVacancyTable(dgTables) ' Refresh the table
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting vacancy: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Validate fields
        If String.IsNullOrWhiteSpace(cbCourseNumber.Text) OrElse String.IsNullOrWhiteSpace(cbSectionID.Text) Then
            MessageBox.Show("Please select both a Course Number and a Section Identifier.")
            Return
        End If

        Dim vacant As Integer = CInt(numUPDVacancy.Value)

        Try
            conn.Open()
            Dim query As String = "UPDATE vacancy SET vacant = @Vacant WHERE Course_number = @Course_number AND Section_identifier = @Section_identifier"
            command = New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@Course_number", cbCourseNumber.Text)
            command.Parameters.AddWithValue("@Section_identifier", cbSectionID.Text)
            command.Parameters.AddWithValue("@Vacant", vacant)

            Dim result As Integer = command.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Vacancy updated successfully.")
                LoadVacancyTable(dgTables) ' Refresh the table
                ClearFields() ' Clear the fields after successful update
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating vacancy: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub ClearFields()
        cbSectionID.SelectedIndex = -1
        cbCourseNumber.SelectedIndex = -1
        numUPDVacancy.Value = 0
    End Sub

End Class
