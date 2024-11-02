Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class Grades
    Dim conn As MySqlConnection = Connect.cons
    Private editedRows As New HashSet(Of Integer)
    Private Sub Grades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Automatically fetch students who are in the grade reports on form load
        FetchSectionsByTeacher(cbSectionIdentifier, FullName)


        AddHandler dgGrade.CellValueChanged, AddressOf dgGrade_CellValueChanged
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        ''
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        '
    End Sub

    ' Clear fields after an operation
    Public Sub ClearFields()
        cbSectionIdentifier.SelectedIndex = -1
    End Sub

    ' Validate fields before performing any database operations
    Private Function ValidateFields() As Boolean


        If cbSectionIdentifier.SelectedIndex = -1 Then
            MessageBox.Show("Please select a section.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function




    Private Sub LoadStudentsBySection(sectionID As String)
        ' Define the query to get students enrolled in the selected section
        Dim query As String = "SELECT s.Student_number, u.full_name, gr.Grade " &
                              "FROM grade_report gr " &
                              "JOIN student s ON gr.Student_number = s.Student_number " &
                              "JOIN `user` u ON s.u_ID = u.u_ID " &
                              "WHERE gr.Section_identifier = @SectionID"

        ' Define the column headers for the DataGridView
        Dim columnHeaders As String() = {"Student Number", "Full Name", "Grade"}

        ' Bind the data to the DataGridView
        BindDataToGridss(dgGrade, query, columnHeaders, sectionID)
    End Sub

    Private Sub BindDataToGridss(dg As Guna2DataGridView, query As String, columnHeaders As String(), sectionID As String)
        Try
            ' Ensure the connection is open
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                ' Add the SectionID parameter to the query
                cmd.Parameters.AddWithValue("@SectionID", sectionID)

                ' Use a data adapter to fetch the results
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                ' Fill the table with data from the query
                adapter.Fill(table)

                ' Bind the table to the DataGridView
                dg.DataSource = table

                ' Set the header text for the columns
                For i As Integer = 0 To Math.Min(columnHeaders.Length - 1, table.Columns.Count - 1)
                    dg.Columns(i).HeaderText = columnHeaders(i)
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub


    Private Sub cbSectionIdentifier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSectionIdentifier.SelectedIndexChanged
        If cbSectionIdentifier.SelectedIndex <> -1 Then
            Dim selectedSection As String = cbSectionIdentifier.SelectedItem.ToString()

            ' Load the students enrolled in this section into the DataGridView
            LoadStudentsBySection(selectedSection)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Make sure the connection is open
        Try
            conn.Open()

            ' Loop through the edited rows to save changes to the database
            For Each rowIndex As Integer In editedRows
                ' Get the data from the edited row
                Dim studentNumber As String = dgGrade.Rows(rowIndex).Cells("Student_number").Value.ToString()
                Dim grade As Char = dgGrade.Rows(rowIndex).Cells("Grade").Value.ToString()(0) ' Convert to Char (first character)

                ' Update the record in the database using a parameterized query
                Dim query As String = "UPDATE grade_report SET Grade = @Grade WHERE Student_number = @StudentNumber AND Section_identifier = @SectionID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Grade", grade)
                    cmd.Parameters.AddWithValue("@StudentNumber", studentNumber)
                    cmd.Parameters.AddWithValue("@SectionID", cbSectionIdentifier.SelectedItem.ToString())

                    ' Execute the update query
                    cmd.ExecuteNonQuery()
                End Using
            Next

            ' Clear the edited rows after saving
            editedRows.Clear()

            ' Confirmation message
            MessageBox.Show("Grades updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error saving grades: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub dgGrade_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgGrade.CellValueChanged
        If e.RowIndex >= 0 Then
            editedRows.Add(e.RowIndex)
        End If
    End Sub
End Class
