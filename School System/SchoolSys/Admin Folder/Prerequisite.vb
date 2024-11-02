Imports MySql.Data.MySqlClient

Public Class Prerequisite
    Dim conn As MySqlConnection = Connect.cons

    Private Sub Prerequisite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load prerequisite data into DataGridView
        LoadPrequisiteTable(dgTables)

        ' Fetch course numbers to populate ComboBoxes
        LoadCourseNumbers(cbCourseNumber)
        LoadCourseNumbers(cbPrerequisiteNumber)
    End Sub

    ' Load course numbers into ComboBox
    Private Sub LoadCourseNumbers(cb As ComboBox)
        Try
            If conn.State <> ConnectionState.Open Then conn.Open()

            Dim Query As String = "SELECT Course_number FROM course"
            Using cmd As New MySqlCommand(Query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cb.Items.Add(reader("Course_number").ToString())
                End While
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading courses: " & ex.Message)
        Finally
            If conn.State <> ConnectionState.Closed Then conn.Close()
        End Try
    End Sub

    ' Button Create Click
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If cbCourseNumber.SelectedItem Is Nothing OrElse cbPrerequisiteNumber.SelectedItem Is Nothing Then
            MessageBox.Show("Both Course and Prerequisite must be selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If conn.State <> ConnectionState.Open Then conn.Open()

            Dim Query As String = "INSERT INTO prerequisite (Course_number, Prerequisite_number) VALUES (@Course, @Prerequisite)"
            Using cmd As New MySqlCommand(Query, conn)
                cmd.Parameters.AddWithValue("@Course", cbCourseNumber.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Prerequisite", cbPrerequisiteNumber.SelectedItem.ToString())

                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Prerequisite added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding prerequisite: " & ex.Message)
        Finally
            If conn.State <> ConnectionState.Closed Then conn.Close()
        End Try
        LoadPrequisiteTable(dgTables)
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If cbCourseNumber.SelectedItem Is Nothing OrElse cbPrerequisiteNumber.SelectedItem Is Nothing Then
            MessageBox.Show("Both Course and Prerequisite must be selected to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If conn.State <> ConnectionState.Open Then conn.Open()

            Dim Query As String = "UPDATE prerequisite SET Prerequisite_number = @Prerequisite WHERE Course_number = @Course"
            Using cmd As New MySqlCommand(Query, conn)
                cmd.Parameters.AddWithValue("@Course", cbCourseNumber.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Prerequisite", cbPrerequisiteNumber.SelectedItem.ToString())

                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Prerequisite updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Update failed. Please check your selection.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating prerequisite: " & ex.Message)
        Finally
            If conn.State <> ConnectionState.Closed Then conn.Close()
        End Try
        LoadPrequisiteTable(dgTables)
    End Sub

    ' Button Delete Click
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If cbCourseNumber.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a course to delete the prerequisite for.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If conn.State <> ConnectionState.Open Then conn.Open()

            Dim Query As String = "DELETE FROM prerequisite WHERE Course_number = @Course AND Prerequisite_number = @Prerequisite"
            Using cmd As New MySqlCommand(Query, conn)
                cmd.Parameters.AddWithValue("@Course", cbCourseNumber.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Prerequisite", cbPrerequisiteNumber.SelectedItem.ToString())

                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Prerequisite deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Delete failed. Please check your selection.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting prerequisite: " & ex.Message)
        Finally
            If conn.State <> ConnectionState.Closed Then conn.Close()
        End Try
        LoadPrequisiteTable(dgTables)
    End Sub


    ' Button Search Click
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cbSearch.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a course to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If conn.State <> ConnectionState.Open Then conn.Open()

            Dim Query As String = "SELECT Prerequisite_number FROM prerequisite WHERE Course_number = @Course"
            Using cmd As New MySqlCommand(Query, conn)
                cmd.Parameters.AddWithValue("@Course", cbSearch.SelectedItem.ToString())
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    cbCourseNumber.SelectedItem = cbSearch.SelectedItem.ToString()
                    cbPrerequisiteNumber.SelectedItem = reader("Prerequisite_number").ToString()
                Else
                    MessageBox.Show("No prerequisite found for the selected course.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error during search: " & ex.Message)
        Finally
            If conn.State <> ConnectionState.Closed Then conn.Close()
        End Try
    End Sub

    ' Clear fields method
    Public Sub ClearFields()
        cbSearch.SelectedItem = -1
        cbCourseNumber.SelectedItem = -1
        cbPrerequisiteNumber.SelectedItem = -1
    End Sub

End Class
