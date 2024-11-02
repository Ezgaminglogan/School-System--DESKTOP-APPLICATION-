Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Module Tables
    Dim conn As MySqlConnection = Connect.cons
    Public Sub BindDataToGrid(dg As Guna2DataGridView, query As String, columnHeaders As String())
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                ' Fill the table with data from the query
                adapter.Fill(table)

                ' Bind the table to the DataGridView
                dg.DataSource = table

                ' Set header text for columns
                For i As Integer = 0 To Math.Min(columnHeaders.Length - 1, table.Columns.Count - 1)
                    dg.Columns(i).HeaderText = columnHeaders(i)

                Next
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub







    Public Sub LoadGrades(ByRef GradesTable As Guna2DataGridView)
        ' Define the query with a parameter for StudentID
        Dim query As String = "SELECT Student_number, Section_identifier, Grade FROM `grade_report` WHERE Section_Identifier = @SectionID"

        ' Define the column headers for the DataGridView
        Dim columnHeaders As String() = {"Student Number", "Section Identifier", "Grade"}

        ' Call BindDataToGrid to bind the query result to the DataGridView
        BindDataToGrids(GradesTable, query, columnHeaders)
    End Sub


    Public Sub LoadEnrolledCourses(ByRef EnrolledTable As Guna2DataGridView, ByVal StudentID As Integer)
        ' Ensure that the StudentID is valid (greater than 0)
        If StudentID <= 0 Then
            MessageBox.Show("Invalid Student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim Query As String = "
        SELECT st.Student_number, s.Section_identifier, c.Course_name, s.Semester, s.Year, gr.Grade 
        FROM grade_report gr 
        JOIN student st ON gr.Student_number = st.Student_number
        JOIN section s ON gr.Section_identifier = s.Section_identifier 
        JOIN course c ON s.Course_number = c.Course_number
        WHERE st.Student_number = @StudentID"

        Dim columnHeaders As String() = {"Student Number", "Section Identifier", "Course Name", "Semester", "Year", "Grade"}

        Try
            conn.Open()
            Using cmd As New MySqlCommand(Query, conn)
                cmd.Parameters.AddWithValue("@StudentID", StudentID) ' Use the Student ID as parameter

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()

                    ' Fill the table with data from the query
                    adapter.Fill(table)

                    ' Check if the table has data before binding
                    If table.Rows.Count > 0 Then
                        EnrolledTable.DataSource = table

                        ' Set header text for columns
                        For i As Integer = 0 To Math.Min(columnHeaders.Length - 1, table.Columns.Count - 1)
                            EnrolledTable.Columns(i).HeaderText = columnHeaders(i)
                        Next
                    Else
                        MessageBox.Show("No enrolled courses found for this student.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        EnrolledTable.DataSource = Nothing ' Clear the DataGridView if no data
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error loading enrolled courses: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub


    Public Sub LoadVacancyTable(ByRef VacancyTable As Guna2DataGridView)
        Dim Query = "Select * FROM `vacancy`"
        Dim columnHeaders = {"Course Number", "Section Identifier", "Vacant"}
        BindDataToGrid(VacancyTable, Query, columnHeaders)
    End Sub

    Public Sub LoadPrequisiteTable(ByRef PrerequisiteTable As Guna2DataGridView)
        Dim Query = "Select * FROM `prerequisite`"
        Dim columnHeaders = {"Course Number", "Prerequisite Number"}
        BindDataToGrid(PrerequisiteTable, Query, columnHeaders)
    End Sub

    Public Sub LoadTeacherTable(ByRef StudentTable As Guna2DataGridView)
        Dim Query = "Select * FROM `user` Where user_type = 'Teacher'"
        Dim columnHeaders = {"User ID", "Full Name", "Email", "Username", "Password", "User Type", "Date"}
        BindDataToGrid(StudentTable, Query, columnHeaders)
    End Sub

    Public Sub LoadStudentTable(ByRef StudentTable As Guna2DataGridView)
        Dim Query = "SELECT * FROM `user` WHERE user_type = 'Student'"
        Dim columnHeaders = {"User ID", "Full Name", "Email", "Username", "Password", "User Type", "Date"}
        BindDataToGrid(StudentTable, Query, columnHeaders)
    End Sub

    Public Sub LoadCourseTable(ByRef CourseTable As Guna2DataGridView)
        Dim Query = "SELECT * FROM `course`"
        Dim columnHeaders = {"Course Name", "Course Number", "Credit Hours", "Department"}
        BindDataToGrid(CourseTable, Query, columnHeaders)
    End Sub

    Public Sub LoadSectionTable(ByRef SectionTable As Guna2DataGridView)
        Dim Query = "SELECT * FROM `section`"
        Dim columnHeader = {"Section Identifier", "Course Number", "Semester", "Year", "Instructor", "Room Number", "Class Day", "Start Time", "End Time", "Units"}
        BindDataToGrid(SectionTable, Query, columnHeader)
    End Sub

    Public Sub LoadUserTable(ByRef UserTable As Guna2DataGridView)
        Dim Query = "SELECT * FROM `user`"
        Dim columnHeader = {"User ID", "Full Name", "Email", "Username", "Password", "User Type", "Date"}
        BindDataToGrid(UserTable, Query, columnHeader)
    End Sub




    Public Sub LoadClassSchedule(ByRef dgTables As Guna2DataGridView, ByVal instructorName As String)
        Dim query As String = "
        SELECT 
            s.Section_identifier,
            c.Course_name,
            s.Semester,
            s.Year,
            s.Class_day,
            s.Start_time,
            s.End_time,
            r.Room_number
        FROM section s
        JOIN course c ON s.Course_number = c.Course_number
        JOIN room r ON s.Room_number = r.Room_number
        WHERE s.Instructor = @InstructorName
        ORDER BY s.Year, s.Semester, s.Class_day, s.Start_time"

        ' Column headers
        Dim columnHeaders As String() = {
            "Section Identifier", "Course Name", "Semester", "Year", "Class Day",
            "Start Time", "End Time", "Room Number"
        }

        ' Bind data to DataGridView
        BindDataToGrids(dgTables, query, columnHeaders, instructorName)
    End Sub

    ' Reuse your BindDataToGrid method, adding the parameter for instructor name
    Public Sub BindDataToGrids(dg As Guna2DataGridView, query As String, columnHeaders As String(), instructorName As String)
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                ' Adding parameter for the instructor
                cmd.Parameters.AddWithValue("@InstructorName", instructorName)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                ' Fill the table with data from the query
                adapter.Fill(table)

                ' Bind the table to the DataGridView
                dg.DataSource = table

                ' Set header text for columns
                For i As Integer = 0 To Math.Min(columnHeaders.Length - 1, table.Columns.Count - 1)
                    dg.Columns(i).HeaderText = columnHeaders(i)
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading class schedule: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub






    Public Sub LoadStudyLoad(ByRef dgView As DataGridView)

        Dim query As String = "
                SELECT 
                    course.Course_number, 
                    course.Course_name, 
                    section.Section_identifier, 
                    section.Semester, 
                    section.Year, 
                    section.Instructor, 
                    section.Class_day, 
                    section.Start_time, 
                    section.End_time, 
                    grade_report.Grade 
                FROM 
                    grade_report 
                JOIN 
                    section ON grade_report.Section_identifier = section.Section_identifier 
                JOIN 
                    course ON section.Course_number = course.Course_number 
                WHERE 
                    grade_report.Student_number = @StudentNumber;
            "
        Dim columnHeaders As String() = {
            "Course Number",
            "Course Name",
            "Section ID",
            "Semester",
            "Year",
            "Instructor",
            "Class Days",
            "Start Time",
            "End Time",
            "Grade"
        }
        BindDataToGrids(dgView, query, columnHeaders)
    End Sub
    Private Sub BindDataToGrids(dg As Guna2DataGridView, query As String, columnHeaders As String())
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                ' Add the parameter for StudentNumber
                cmd.Parameters.AddWithValue("@StudentNumber", StudentID)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                ' Fill the table with data from the query
                adapter.Fill(table)

                ' Bind the table to the DataGridView
                dg.DataSource = table

                ' Set header text for columns
                For i As Integer = 0 To Math.Min(columnHeaders.Length - 1, table.Columns.Count - 1)
                    dg.Columns(i).HeaderText = columnHeaders(i)
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub BindDataToGridGrade(dg As Guna2DataGridView, query As String, columnHeaders As String())
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                ' Add the parameter for StudentNumber
                cmd.Parameters.AddWithValue("@StudentNumber", StudentID)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                ' Fill the table with data from the query
                adapter.Fill(table)

                ' Bind the table to the DataGridView
                dg.DataSource = table

                ' Set header text for columns
                For i As Integer = 0 To Math.Min(columnHeaders.Length - 1, table.Columns.Count - 1)
                    dg.Columns(i).HeaderText = columnHeaders(i)
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub



End Module



