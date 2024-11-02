Imports MySql.Data.MySqlClient

Public Class Course

    Dim conn As MySqlConnection = Connect.cons

    Private Sub Course_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourseTable(dgTables)
    End Sub

    ' Button for creating a new course record
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' Validation
        If String.IsNullOrEmpty(tbCname.Text) OrElse String.IsNullOrEmpty(tbCnumber.Text) OrElse
            String.IsNullOrEmpty(tbChours.Text) OrElse String.IsNullOrEmpty(tbCdept.Text) Then
            MessageBox.Show("All fields must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if Credit_hours is a valid integer
        Dim creditHours As Integer
        If Not Integer.TryParse(tbChours.Text, creditHours) Then
            MessageBox.Show("Credit hours must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            Dim query As String = "INSERT INTO `course` (Course_name, Course_number, Credit_hours, Department) VALUES (@Cname, @Cnumber, @Chours, @Cdept)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Cname", tbCname.Text)
                cmd.Parameters.AddWithValue("@Cnumber", tbCnumber.Text)
                cmd.Parameters.AddWithValue("@Chours", creditHours)
                cmd.Parameters.AddWithValue("@Cdept", tbCdept.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Course created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
                LoadCourseTable(dgTables)
            End Using

        Catch ex As Exception
            MessageBox.Show("Error while creating the course: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Button for updating an existing course record
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Validation (same as in Create)
        If String.IsNullOrEmpty(tbCname.Text) OrElse String.IsNullOrEmpty(tbCnumber.Text) OrElse
            String.IsNullOrEmpty(tbChours.Text) OrElse String.IsNullOrEmpty(tbCdept.Text) Then
            MessageBox.Show("All fields must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if Credit_hours is a valid integer
        Dim creditHours As Integer
        If Not Integer.TryParse(tbChours.Text, creditHours) Then
            MessageBox.Show("Credit hours must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            Dim query As String = "UPDATE `course` SET Course_name = @Cname, Credit_hours = @Chours, Department = @Cdept WHERE Course_number = @Cnumber"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Cname", tbCname.Text)
                cmd.Parameters.AddWithValue("@Chours", creditHours)
                cmd.Parameters.AddWithValue("@Cdept", tbCdept.Text)
                cmd.Parameters.AddWithValue("@Cnumber", tbCnumber.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Course updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
                LoadCourseTable(dgTables)
            End Using

        Catch ex As Exception
            MessageBox.Show("Error while updating the course: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Button for deleting a course record
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrEmpty(tbCnumber.Text) Then
            MessageBox.Show("Please enter the course number to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            Dim query As String = "DELETE FROM `course` WHERE Course_number = @Cnumber"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Cnumber", tbCnumber.Text)

                Dim result = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Course deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearFields()
                    LoadCourseTable(dgTables)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error while deleting the course: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Search function using LIKE to auto-fill text boxes
    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        If String.IsNullOrEmpty(tbSearch.Text) Then
            ClearFields()
            Return
        End If

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            Dim query As String = "SELECT * FROM `course` WHERE Course_name LIKE @Search OR Course_number LIKE @Search"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Search", "%" & tbSearch.Text & "%")

                Dim reader = cmd.ExecuteReader()
                If reader.Read() Then
                    tbCname.Text = reader("Course_name").ToString()
                    tbCnumber.Text = reader("Course_number").ToString()
                    tbChours.Text = reader("Credit_hours").ToString()
                    tbCdept.Text = reader("Department").ToString()
                Else
                    ClearFields() ' Clear if no results found
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error during search: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Function to clear text fields
    Public Sub ClearFields()
        tbCdept.Clear()
        tbChours.Clear()
        tbCname.Clear()
        tbCnumber.Clear()
        tbSearch.Clear()
    End Sub
End Class
