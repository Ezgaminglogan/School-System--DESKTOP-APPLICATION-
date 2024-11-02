Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Public Class AttendanceSheet
    Dim conn As MySqlConnection = Connect.cons
    Private Sub AttendanceSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchSectionsByTeacher(cbSectionIdentifier, FullName)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveAttendanceChanges()
    End Sub

    Private Sub cbSectionIdentifier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSectionIdentifier.SelectedIndexChanged
        If cbSectionIdentifier.SelectedIndex <> -1 Then
            Dim selectedSection As String = cbSectionIdentifier.SelectedItem.ToString()
            LoadAttendance(selectedSection)
        End If
    End Sub


    ' Event handler for DateTimePicker value change


    Public Sub LoadAttendance(ByVal sectionID As String)
        ' Define the query to get attendance records with student information
        Dim query As String = "SELECT a.Attendance_ID, s.Student_number, u.full_name AS Student_Name, a.Section_identifier, a.Attendance_date, " &
                          "COALESCE(a.Status, 'Present') AS Status " & ' Use COALESCE to provide a default value if Status is NULL
                          "FROM attendance a " &
                          "JOIN student s ON a.Student_number = s.Student_number " &
                          "JOIN `user` u ON s.u_ID = u.u_ID " &
                          "WHERE a.Section_identifier = @SectionID"

        Dim columnHeaders As String() = {"Attendance Number", "Student Number", "Full Name", "Section ID", "Attendance Date", "Status"}

        BindDataToGridsSec(dgTables, query, columnHeaders, sectionID)
    End Sub

    Private Sub BindDataToGridsSec(dg As Guna2DataGridView, query As String, columnHeaders As String(), sectionID As String)
        Try
            ' Ensure the connection is open
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                ' Add the parameters to the query
                cmd.Parameters.AddWithValue("@SectionID", sectionID)

                ' Use a data adapter to fetch the results
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                ' Fill the table with data from the query
                adapter.Fill(table)

                ' Check if the table has rows
                If table.Rows.Count = 0 Then
                    MessageBox.Show("No attendance records found for the selected section.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dg.DataSource = Nothing ' Clear the DataGridView
                    Return
                End If

                ' Bind the table to the DataGridView
                dg.DataSource = table

                ' Set the header text for the columns
                For i As Integer = 0 To Math.Min(columnHeaders.Length - 1, table.Columns.Count - 1)
                    dg.Columns(i).HeaderText = columnHeaders(i)
                Next

                ' Add a ComboBox column for status
                If Not dg.Columns.Contains("Status") Then
                    ' If it doesn't exist, you might want to create it as a ComboBox column
                    Dim statusColumn As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn()
                    statusColumn.HeaderText = "Status"
                    statusColumn.Name = "Status"
                    statusColumn.Items.AddRange("Present", "Absent", "Late")

                    ' Add the ComboBox column at the specified index (adjust as necessary)
                    dg.Columns.Insert(5, statusColumn) ' Adjust index as necessary
                End If

                ' Set cell formatting for attendance status
                For Each row As DataGridViewRow In dg.Rows
                    Try
                        ' Get the status value from the existing "Status" column
                        Dim status As String = If(row.Cells("Status").Value?.ToString(), "Present") ' Default to 'Present' if null
                        Select Case status
                            Case "Present"
                                row.DefaultCellStyle.BackColor = Color.Green
                            Case "Absent"
                                row.DefaultCellStyle.BackColor = Color.Red
                            Case "Late"
                                row.DefaultCellStyle.BackColor = Color.Orange
                            Case Else
                                row.DefaultCellStyle.BackColor = Color.Gray ' For unexpected values
                        End Select
                    Catch ex As Exception
                        ' Handle exceptions if needed
                    End Try
                Next

            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    ' Handle the date selection
    Private Sub SaveAttendanceChanges()
        Try
            ' Ensure the connection is open
            conn.Open()

            For Each row As DataGridViewRow In dgTables.Rows
                If Not row.IsNewRow Then
                    Dim attendanceID As Integer = Convert.ToInt32(row.Cells("Attendance_ID").Value)
                    Dim status As String = row.Cells("Status").Value.ToString()


                    ' Define an update query
                    Dim updateQuery As String = "UPDATE attendance SET Status = @Status WHERE Attendance_ID = @AttendanceID"

                    Using cmd As New MySqlCommand(updateQuery, conn)
                        cmd.Parameters.AddWithValue("@Status", status)
                        cmd.Parameters.AddWithValue("@AttendanceID", attendanceID)

                        ' Execute the update command
                        cmd.ExecuteNonQuery()
                    End Using
                End If
            Next

            MessageBox.Show("Attendance records updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving attendance changes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
        LoadAttendance(cbSectionIdentifier.SelectedItem)
    End Sub

    Private Sub btnInsertDate_Click(sender As Object, e As EventArgs) Handles btnInsertDate.Click
        Dim selectedDate As Date = DatePicker.Value.Date ' Assuming you have a DatePicker control

        Try
            ' Ensure the connection is open
            conn.Open()

            ' Loop through the rows of the DataGridView
            For Each row As DataGridViewRow In dgTables.Rows
                If Not row.IsNewRow Then
                    ' Get the Attendance_ID and other necessary fields
                    Dim attendanceID As Integer = Convert.ToInt32(row.Cells("Attendance_ID").Value)

                    ' Update the Attendance_date in the database for this attendance record
                    Dim updateQuery As String = "UPDATE attendance SET Attendance_date = @AttendanceDate WHERE Attendance_ID = @AttendanceID"

                    Using cmd As New MySqlCommand(updateQuery, conn)
                        cmd.Parameters.AddWithValue("@AttendanceDate", selectedDate)
                        cmd.Parameters.AddWithValue("@AttendanceID", attendanceID)

                        ' Execute the update command
                        cmd.ExecuteNonQuery()
                    End Using
                End If
            Next

            MessageBox.Show("Attendance dates updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error updating attendance dates: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        LoadAttendance(cbSectionIdentifier.SelectedItem)
    End Sub

    Private Sub DatePicker_ValueChanged(sender As Object, e As EventArgs) Handles DatePicker.ValueChanged
        Dim selectedDate As Date = DatePicker.Value.Date ' Assuming you have a DatePicker control

        Try
            ' Ensure the connection is open
            conn.Open()

            ' Loop through the rows of the DataGridView
            For Each row As DataGridViewRow In dgTables.Rows
                If Not row.IsNewRow Then
                    ' Get the Attendance_ID and other necessary fields
                    Dim attendanceID As Integer = Convert.ToInt32(row.Cells("Attendance_ID").Value)

                    ' Update the Attendance_date in the database for this attendance record
                    Dim updateQuery As String = "UPDATE attendance SET Attendance_date = @AttendanceDate WHERE Attendance_ID = @AttendanceID"

                    Using cmd As New MySqlCommand(updateQuery, conn)
                        cmd.Parameters.AddWithValue("@AttendanceDate", selectedDate)
                        cmd.Parameters.AddWithValue("@AttendanceID", attendanceID)

                        ' Execute the update command
                        cmd.ExecuteNonQuery()
                    End Using
                End If
            Next

            MessageBox.Show("Attendance dates updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error updating attendance dates: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        LoadAttendance(cbSectionIdentifier.SelectedItem)
    End Sub
End Class