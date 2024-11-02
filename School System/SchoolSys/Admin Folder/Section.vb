Imports MySql.Data.MySqlClient
Public Class Section

    Dim conn As MySqlConnection = Connect.cons

    ' Load section data and auto-fill Course_number on form load
    Private Sub Section_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSectionTable(dgTables)
        FetchCourseNumbers(cbCourseN) ' Auto-fill Course Numbers from Course table
    End Sub

    ' Button for creating a new section
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' Validate inputs
        If ValidateSectionFields() Then
            ' Check for time conflicts
            If CheckTimeConflict(tbStartTime.Text, tbEndTime.Text, tbRoomNumber.Text, tbClassD.Text, tbInstructor.Text) Then
                MessageBox.Show("The selected time conflicts with an existing section for the same instructor.", "Conflict Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                End If

                Dim Query As String = "INSERT INTO `section` (Section_identifier, Course_number, Semester, Year, Instructor, Room_number, Class_day, Start_time, End_time) VALUES (@SectionID, @CourseNumber, @Semester, @Year, @Instructor, @RoomNumber, @ClassDay, @StartTime, @EndTime)"
                Using cmd As New MySqlCommand(Query, conn)
                    cmd.Parameters.AddWithValue("@SectionID", tbSectionID.Text)
                    cmd.Parameters.AddWithValue("@CourseNumber", cbCourseN.SelectedItem)
                    cmd.Parameters.AddWithValue("@Semester", cbSemester.SelectedItem)
                    cmd.Parameters.AddWithValue("@Year", tbYear.Text)
                    cmd.Parameters.AddWithValue("@Instructor", tbInstructor.Text)
                    cmd.Parameters.AddWithValue("@RoomNumber", tbRoomNumber.Text)
                    cmd.Parameters.AddWithValue("@ClassDay", tbClassD.Text)
                    cmd.Parameters.AddWithValue("@StartTime", tbStartTime.Text)
                    cmd.Parameters.AddWithValue("@EndTime", tbEndTime.Text)

                    Dim row = cmd.ExecuteNonQuery()
                    If row > 0 Then
                        MessageBox.Show("Section created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Clearfields()
                    Else
                        MessageBox.Show("Failed to create section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
            LoadSectionTable(dgTables)
        End If
    End Sub


    ' Button for updating an existing section
    ' Button for updating an existing section
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If ValidateSectionFields() Then
            If CheckTimeConflict(tbStartTime.Text, tbEndTime.Text, tbRoomNumber.Text, tbClassD.Text, tbInstructor.Text) Then
                MessageBox.Show("The selected time conflicts with an existing section for the same instructor.", "Conflict Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                End If

                Dim Query As String = "UPDATE `section` SET Course_number = @CourseNumber, Semester = @Semester, Year = @Year, Instructor = @Instructor, Room_number = @RoomNumber, Class_day = @ClassDay, Start_time = @StartTime, End_time = @EndTime WHERE Section_identifier = @SectionID"
                Using cmd As New MySqlCommand(Query, conn)
                    cmd.Parameters.AddWithValue("@SectionID", tbSectionID.Text)
                    cmd.Parameters.AddWithValue("@CourseNumber", cbCourseN.SelectedItem)
                    cmd.Parameters.AddWithValue("@Semester", cbSemester.SelectedItem)
                    cmd.Parameters.AddWithValue("@Year", tbYear.Text)
                    cmd.Parameters.AddWithValue("@Instructor", tbInstructor.Text)
                    cmd.Parameters.AddWithValue("@RoomNumber", tbRoomNumber.Text)
                    cmd.Parameters.AddWithValue("@ClassDay", tbClassD.Text)
                    cmd.Parameters.AddWithValue("@StartTime", tbStartTime.Text)
                    cmd.Parameters.AddWithValue("@EndTime", tbEndTime.Text)

                    Dim row = cmd.ExecuteNonQuery()
                    If row > 0 Then
                        MessageBox.Show("Section updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Clearfields()
                    Else
                        MessageBox.Show("Failed to update section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
            LoadSectionTable(dgTables)
        End If
    End Sub

    ' Button for deleting a section
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrEmpty(tbSectionID.Text) Then
            MessageBox.Show("Please select a section to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Temporarily disable foreign key checks
            Dim disableFKChecksQuery As String = "SET FOREIGN_KEY_CHECKS=0;"
            Using disableFKCmd As New MySqlCommand(disableFKChecksQuery, conn)
                disableFKCmd.ExecuteNonQuery()
            End Using

            ' Now delete the section
            Dim deleteSectionQuery As String = "DELETE FROM `section` WHERE Section_identifier = @SectionID"
            Using deleteSectionCmd As New MySqlCommand(deleteSectionQuery, conn)
                deleteSectionCmd.Parameters.AddWithValue("@SectionID", tbSectionID.Text)

                Dim row = deleteSectionCmd.ExecuteNonQuery()
                If row > 0 Then
                    MessageBox.Show("Section deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Clearfields()
                Else
                    MessageBox.Show("Failed to delete section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

            ' Re-enable foreign key checks
            Dim enableFKChecksQuery As String = "SET FOREIGN_KEY_CHECKS=1;"
            Using enableFKCmd As New MySqlCommand(enableFKChecksQuery, conn)
                enableFKCmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        ' Refresh the table view
        LoadSectionTable(dgTables)
    End Sub




    ' Validate required section fields before proceeding
    Private Function ValidateSectionFields() As Boolean
        If String.IsNullOrEmpty(cbCourseN.SelectedItem) OrElse String.IsNullOrEmpty(cbSemester.SelectedItem) OrElse
           String.IsNullOrEmpty(tbYear.Text) OrElse String.IsNullOrEmpty(tbInstructor.Text) OrElse
           String.IsNullOrEmpty(tbRoomNumber.Text) OrElse String.IsNullOrEmpty(tbClassD.Text) OrElse
           String.IsNullOrEmpty(tbStartTime.Text) OrElse String.IsNullOrEmpty(tbEndTime.Text) Then

            MessageBox.Show("All fields are required. Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    ' Clear the input fields
    Public Sub Clearfields()
        tbSectionID.Clear()
        cbCourseN.SelectedIndex = -1
        cbSemester.SelectedIndex = -1
        tbYear.Clear()
        tbInstructor.Clear()
        tbRoomNumber.Clear()
        tbClassD.Clear()
        tbStartTime.Clear()
        tbEndTime.Clear()
    End Sub
End Class
