Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Module Functions
    Dim conn As MySqlConnection = Connect.cons

    'Session

    Public UserID As String
    Public StudentID As String
    Public FullName As String
    Public UserType As String


    Public Sub SetupAttendanceDataGridView(ByRef dgTables As DataGridView)
        ' Clear existing columns
        dgTables.Columns.Clear()

        ' Add a column for Student Number
        Dim studentColumn As New DataGridViewTextBoxColumn()
        studentColumn.HeaderText = "Student Number"
        studentColumn.Name = "Student_number"
        dgTables.Columns.Add(studentColumn)

        ' Add a column for Student Name
        Dim nameColumn As New DataGridViewTextBoxColumn()
        nameColumn.HeaderText = "Student Name"
        nameColumn.Name = "Student_name"
        dgTables.Columns.Add(nameColumn)

        ' Add a ComboBox column for Attendance Status
        Dim statusColumn As New DataGridViewComboBoxColumn()
        statusColumn.HeaderText = "Attendance Status"
        statusColumn.Name = "Status"
        statusColumn.Items.AddRange("Present", "Absent", "Late")
        dgTables.Columns.Add(statusColumn)

        ' Set default value for attendance status
        statusColumn.DefaultCellStyle.NullValue = "Present"
    End Sub




    ' Function to save attendance data from the DataGridView to the database













    ' Check for time conflicts based on instructor, class day, and time
    Public Function CheckTimeConflict(startTime As String, endTime As String, roomNumber As String, classDay As String, instructor As String) As Boolean
        Dim isConflict As Boolean = False
        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            Dim query As String = "SELECT COUNT(*) FROM `section` WHERE Instructor = @Instructor AND Class_day = @ClassDay " &
                              "AND ((Start_time < @EndTime AND End_time > @StartTime))" ' Overlap condition
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Instructor", instructor)
                cmd.Parameters.AddWithValue("@ClassDay", classDay)
                cmd.Parameters.AddWithValue("@StartTime", startTime)
                cmd.Parameters.AddWithValue("@EndTime", endTime)

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                isConflict = (count > 0) ' If any records exist, there is a conflict
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking for time conflicts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        Return isConflict
    End Function




    'Grade Report
    ' Fetch students who have grade reports, which means they are enrolled in sections
    Public Sub FetchStudentNumber(ByRef cbStudentNumber As Guna2ComboBox)
        Try
            ' Ensure connection is open
            If conn.State <> ConnectionState.Open Then conn.Open()

            ' Query to fetch unique student numbers from the grade_report table
            Dim query As String = "SELECT DISTINCT s.Student_number " &
                              "FROM grade_report gr " &
                              "JOIN student s ON gr.Student_number = s.Student_number"

            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    cbStudentNumber.Items.Clear()
                    While reader.Read()
                        cbStudentNumber.Items.Add(reader("Student_number").ToString())
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching students: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    Public Sub FetchSectionsByTeacher(ByRef cbSectionIdentifier As Guna2ComboBox, ByVal teacherName As String)
        Try
            ' Ensure connection is open
            If conn.State <> ConnectionState.Open Then conn.Open()

            ' Query to fetch sections based on the selected teacher
            Dim query As String = "SELECT DISTINCT s.Section_identifier " &
                              "FROM section s " &
                              "WHERE s.Instructor = @TeacherName"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@TeacherName", teacherName)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    cbSectionIdentifier.Items.Clear()
                    While reader.Read()
                        cbSectionIdentifier.Items.Add(reader("Section_identifier").ToString())
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching sections: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    Public Sub FetchSectionIdentifier(ByRef cbSectionIdentifier As Guna2ComboBox, ByVal studentNumber As String)
        Try
            ' Ensure connection is open
            If conn.State <> ConnectionState.Open Then conn.Open()

            ' Query to fetch section identifiers from the grade_report table for the selected student
            Dim query As String = "SELECT DISTINCT gr.Section_identifier " &
                              "FROM grade_report gr " &
                              "WHERE gr.Student_number = @StudentNumber"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@StudentNumber", studentNumber)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    cbSectionIdentifier.Items.Clear()
                    While reader.Read()
                        cbSectionIdentifier.Items.Add(reader("Section_identifier").ToString())
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching sections: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub




    'Teacher
    Public Sub FetchInstructor(ByRef cbTeacher As Guna2ComboBox)
        Try
            ' Check if the connection is open, open it if it's not
            If conn.State <> ConnectionState.Open Then conn.Open()

            ' Correct SQL query to fetch teachers' full names
            Dim query As String = "SELECT full_name FROM `user` WHERE user_type = 'Teacher'"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    cbTeacher.Items.Clear()  ' Clear existing items
                    While reader.Read()
                        cbTeacher.Items.Add(reader("full_name").ToString())  ' Add teacher's name to the ComboBox
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching instructors: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Always close the connection in the Finally block
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub




    ' Fetch Course Numbers
    Public Sub FetchCourseNumbersForEnrollment(ByRef cbCourseNumber As ComboBox)
        Try
            If conn.State <> ConnectionState.Open Then conn.Open()

            Dim query As String = "SELECT Course_number FROM `course`"
            Using cmd As New MySqlCommand(query, conn)
                Dim reader = cmd.ExecuteReader()
                cbCourseNumber.Items.Clear()
                While reader.Read()
                    cbCourseNumber.Items.Add(reader("Course_number").ToString())
                End While
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching course numbers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Fetch Section Identifiers based on selected Course Number
    Public Sub FetchSections(ByVal courseNumber As String, ByRef cbSectionIdentifier As ComboBox)
        Try
            If conn.State <> ConnectionState.Open Then conn.Open()

            Dim query As String = "SELECT Section_identifier FROM `section` WHERE Course_number = @CourseNumber"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CourseNumber", courseNumber)
                Dim reader = cmd.ExecuteReader()
                cbSectionIdentifier.Items.Clear()
                While reader.Read()
                    cbSectionIdentifier.Items.Add(reader("Section_identifier").ToString())
                End While
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching sections: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Check if the student can enroll based on prerequisites
    Public Function CheckPrerequisites(ByVal studentNumber As Integer, ByVal courseNumber As String) As Boolean
        Try
            If conn.State <> ConnectionState.Open Then conn.Open()

            ' Check if course has prerequisites
            Dim queryPrereq As String = "SELECT Prerequisite_number FROM `prerequisite` WHERE Course_number = @CourseNumber"
            Using cmd As New MySqlCommand(queryPrereq, conn)
                cmd.Parameters.AddWithValue("@CourseNumber", courseNumber)

                ' Use a list to store prerequisites
                Dim prerequisites As New List(Of String)()

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        prerequisites.Add(reader("Prerequisite_number").ToString())
                    End While
                End Using

                ' Now check if the student has completed each prerequisite
                For Each prereqCourse In prerequisites
                    Dim gradeCheckQuery As String = "SELECT Grade FROM `grade_report` 
                                                  WHERE Student_number = @StudentNumber AND 
                                                  Section_identifier IN (SELECT Section_identifier FROM `section` 
                                                  WHERE Course_number = @Prerequisite)"
                    Using gradeCmd As New MySqlCommand(gradeCheckQuery, conn)
                        gradeCmd.Parameters.AddWithValue("@StudentNumber", studentNumber)
                        gradeCmd.Parameters.AddWithValue("@Prerequisite", prereqCourse)

                        ' ExecuteScalar for grade check
                        Dim grade As Object = gradeCmd.ExecuteScalar()

                        If grade Is Nothing OrElse grade.ToString() = "" Then
                            MessageBox.Show("Prerequisite course not completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                    End Using
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking prerequisites: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
        End Try

        Return True
    End Function


    ' Enroll Student
    Public Sub EnrollStudent(ByVal studentNumber As Integer, ByVal courseNumber As String, ByVal sectionIdentifier As Integer)
        Try
            If conn.State <> ConnectionState.Open Then conn.Open()

            ' Check if section has vacancies
            Dim queryVacancy As String = "SELECT vacant FROM `vacancy` WHERE Section_identifier = @SectionIdentifier"
            Using cmdVacancy As New MySqlCommand(queryVacancy, conn)
                cmdVacancy.Parameters.AddWithValue("@SectionIdentifier", sectionIdentifier)
                Dim vacancy As Integer = Convert.ToInt32(cmdVacancy.ExecuteScalar())

                If vacancy > 0 Then
                    ' Enroll student
                    Dim queryEnroll As String = "INSERT INTO `grade_report` (Student_number, Section_identifier, Grade) 
                                                 VALUES (@StudentNumber, @SectionIdentifier, '')"
                    Using cmdEnroll As New MySqlCommand(queryEnroll, conn)
                        cmdEnroll.Parameters.AddWithValue("@StudentNumber", studentNumber)
                        cmdEnroll.Parameters.AddWithValue("@SectionIdentifier", sectionIdentifier)
                        cmdEnroll.ExecuteNonQuery()
                    End Using

                    ' Insert attendance record for the newly enrolled student with the specified attendance date
                    Dim queryAttendance As String = "INSERT INTO `attendance` (Student_number, Section_identifier, Status) 
                                                  VALUES (@StudentNumber, @SectionIdentifier , '')"
                    Using cmdAttendance As New MySqlCommand(queryAttendance, conn)
                        cmdAttendance.Parameters.AddWithValue("@StudentNumber", studentNumber)
                        cmdAttendance.Parameters.AddWithValue("@SectionIdentifier", sectionIdentifier)
                        cmdAttendance.ExecuteNonQuery()
                    End Using



                    ' Decrease vacancy
                    Dim updateVacancy As String = "UPDATE `vacancy` SET vacant = vacant - 1 WHERE Section_identifier = @SectionIdentifier"
                    Using cmdUpdate As New MySqlCommand(updateVacancy, conn)
                        cmdUpdate.Parameters.AddWithValue("@SectionIdentifier", sectionIdentifier)
                        cmdUpdate.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Enrollment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No more vacancies for this section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error enrolling student: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub






    'Teacher Count

    Public Sub LoadTeacherCount(ByRef lblTeacherCount As Label)
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Dim TeacherCount As Integer
        Dim query = "SELECT COUNT(*) FROM `user` WHERE user_type = 'Teacher'"
        Using cmd As New MySqlCommand(query, conn)
            TeacherCount = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        lblTeacherCount.Text = TeacherCount.ToString()
        If conn.State <> ConnectionState.Closed Then
            conn.Close()
        End If
    End Sub


    'StudentCount
    Public Sub LoadStudentCount(ByRef lblStudentCount As Label)
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Dim studentCount As Integer
        Dim query = "SELECT COUNT(*) FROM `student`"
        Using cmd As New MySqlCommand(query, conn)
            studentCount = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        lblStudentCount.Text = studentCount.ToString()
        If conn.State <> ConnectionState.Closed Then
            conn.Close()
        End If
    End Sub

    'StudentCount
    Public Sub LoadCourseCount(ByRef lblCourseCount As Label)
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Dim CourseCount As Integer
        Dim query = "SELECT COUNT(*) FROM `course`"
        Using cmd As New MySqlCommand(query, conn)
            CourseCount = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        lblCourseCount.Text = CourseCount.ToString()
        If conn.State <> ConnectionState.Closed Then
            conn.Close()
        End If
    End Sub


    'StudentCount
    Public Sub LoadSectionCount(ByRef lblSectionCount As Label)
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Dim sectionCount As Integer
        Dim query = "SELECT COUNT(*) FROM `section`"
        Using cmd As New MySqlCommand(query, conn)
            sectionCount = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        lblSectionCount.Text = sectionCount.ToString()
        If conn.State <> ConnectionState.Closed Then
            conn.Close()
        End If
    End Sub


    'StudentCount
    Public Sub LoadUserCount(ByRef lblUserCount As Label)
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Dim UserCount As Integer
        Dim query = "SELECT COUNT(*) FROM `user`"
        Using cmd As New MySqlCommand(query, conn)
            UserCount = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        lblUserCount.Text = UserCount.ToString()
        If conn.State <> ConnectionState.Closed Then
            conn.Close()
        End If
    End Sub







    'Fetch Course Number
    Public Sub FetchCourseNumbers(ByRef cbCourseN As ComboBox)
        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            Dim Query As String = "SELECT Course_number FROM `course`"
            Using cmd As New MySqlCommand(Query, conn)
                Dim reader = cmd.ExecuteReader()
                While reader.Read()
                    cbCourseN.Items.Add(reader("Course_number").ToString())
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching course numbers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub



End Module
