Imports MySql.Data.MySqlClient

Public Class Login
    Dim conn As MySqlConnection = Connect.cons

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validate input fields
        If tbUsername.Text.Trim() = "" Then
            MessageBox.Show("Username is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbUsername.Focus()
            Exit Sub
        End If

        If tbPassword.Text.Trim() = "" Then
            MessageBox.Show("Password is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbPassword.Focus()
            Exit Sub
        End If

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Query to check for user in both user and admin tables
            Dim userQuery As String = "SELECT u_ID, full_name, user_type FROM `user` WHERE user_name = @user_name AND password = MD5(@password)"
            Dim adminQuery As String = "SELECT id, full_name FROM `admin` WHERE user_name = @user_name AND password = MD5(@password)"

            ' First, check if the user is in the 'user' table
            Dim cmd As MySqlCommand = New MySqlCommand(userQuery, conn)
            cmd.Parameters.AddWithValue("@user_name", tbUsername.Text)
            cmd.Parameters.AddWithValue("@password", tbPassword.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                UserID = reader("u_ID").ToString()
                FullName = reader("full_name").ToString()
                UserType = reader("user_type").ToString()
                reader.Close()

                ' Personalized message based on user type
                Select Case UserType
                    Case "Student"
                        ' Fetch Student_number from student table
                        Dim studentQuery As String = "SELECT Student_number FROM `student` WHERE u_ID = @u_ID"
                        Dim studentCmd As MySqlCommand = New MySqlCommand(studentQuery, conn)
                        studentCmd.Parameters.AddWithValue("@u_ID", UserID)

                        Dim studentReader As MySqlDataReader = studentCmd.ExecuteReader()

                        If studentReader.HasRows Then
                            studentReader.Read()
                            StudentID = studentReader("Student_number").ToString()
                            studentReader.Close()
                            MessageBox.Show("Welcome, Student " & FullName & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ' Navigate to student dashboard
                            Dim studentForm As New Student()
                            studentForm.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Student record not found!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    Case "Teacher"
                        MessageBox.Show("Welcome, Teacher " & FullName & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Navigate to teacher dashboard
                        Teacher.Show()
                        Me.Hide()

                    Case Else
                        MessageBox.Show("Unknown user type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select

            Else
                reader.Close()
                ' If the user is not found in the 'user' table, check the 'admin' table
                cmd = New MySqlCommand(adminQuery, conn)
                cmd.Parameters.AddWithValue("@user_name", tbUsername.Text)
                cmd.Parameters.AddWithValue("@password", tbPassword.Text)

                Dim adminReader As MySqlDataReader = cmd.ExecuteReader()

                If adminReader.HasRows Then
                    adminReader.Read()
                    Dim AdminID As String = adminReader("id").ToString()
                    FullName = adminReader("full_name").ToString()

                    UserID = AdminID


                    adminReader.Close()

                    MessageBox.Show("Welcome, Admin " & FullName & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Navigate to admin dashboard
                    Admin.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub tbPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles tbPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Validate input fields
            If tbUsername.Text.Trim() = "" Then
                MessageBox.Show("Username is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tbUsername.Focus()
                Exit Sub
            End If

            If tbPassword.Text.Trim() = "" Then
                MessageBox.Show("Password is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tbPassword.Focus()
                Exit Sub
            End If

            Try
                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                End If

                ' Query to check for user in both user and admin tables
                Dim userQuery As String = "SELECT u_ID, full_name, user_type FROM `user` WHERE user_name = @user_name AND password = MD5(@password)"
                Dim adminQuery As String = "SELECT id, full_name FROM `admin` WHERE user_name = @user_name AND password = MD5(@password)"

                ' First, check if the user is in the 'user' table
                Dim cmd As MySqlCommand = New MySqlCommand(userQuery, conn)
                cmd.Parameters.AddWithValue("@user_name", tbUsername.Text)
                cmd.Parameters.AddWithValue("@password", tbPassword.Text)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    reader.Read()
                    UserID = reader("u_ID").ToString()
                    FullName = reader("full_name").ToString()
                    UserType = reader("user_type").ToString()
                    reader.Close()

                    ' Personalized message based on user type
                    Select Case UserType
                        Case "Student"
                            ' Fetch Student_number from student table
                            Dim studentQuery As String = "SELECT Student_number FROM `student` WHERE u_ID = @u_ID"
                            Dim studentCmd As MySqlCommand = New MySqlCommand(studentQuery, conn)
                            studentCmd.Parameters.AddWithValue("@u_ID", UserID)

                            Dim studentReader As MySqlDataReader = studentCmd.ExecuteReader()

                            If studentReader.HasRows Then
                                studentReader.Read()
                                StudentID = studentReader("Student_number").ToString()
                                studentReader.Close()
                                MessageBox.Show("Welcome, Student " & FullName & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ' Navigate to student dashboard
                                Dim studentForm As New Student()
                                studentForm.Show()
                                Me.Hide()
                            Else
                                MessageBox.Show("Student record not found!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If

                        Case "Teacher"
                            MessageBox.Show("Welcome, Teacher " & FullName & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ' Navigate to teacher dashboard
                            Teacher.Show()
                            Me.Hide()

                        Case Else
                            MessageBox.Show("Unknown user type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Select

                Else
                    reader.Close()
                    ' If the user is not found in the 'user' table, check the 'admin' table
                    cmd = New MySqlCommand(adminQuery, conn)
                    cmd.Parameters.AddWithValue("@user_name", tbUsername.Text)
                    cmd.Parameters.AddWithValue("@password", tbPassword.Text)

                    Dim adminReader As MySqlDataReader = cmd.ExecuteReader()

                    If adminReader.HasRows Then
                        adminReader.Read()
                        Dim AdminID As String = adminReader("id").ToString()
                        FullName = adminReader("full_name").ToString()

                        UserID = AdminID


                        adminReader.Close()

                        MessageBox.Show("Welcome, Admin " & FullName & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Navigate to admin dashboard
                        Admin.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State <> ConnectionState.Closed Then
                    conn.Close()
                End If
            End Try
        End If
    End Sub
End Class
