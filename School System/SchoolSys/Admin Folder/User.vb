Imports MySql.Data.MySqlClient

Public Class User
    Dim conn As MySqlConnection = Connect.cons

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserTable(dgTables)
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' Check if any required fields are empty
        If String.IsNullOrEmpty(tbFname.Text) OrElse
           String.IsNullOrEmpty(tbEmail.Text) OrElse
           String.IsNullOrEmpty(tbUsername.Text) OrElse
           String.IsNullOrEmpty(tbPassword.Text) OrElse
           cbUser.SelectedIndex = -1 Then

            MessageBox.Show("All fields except password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' SQL query to insert the new user (without u_ID and date)
            Dim Query As String = "INSERT INTO `user` (full_name, email, user_name, password, user_type) " &
                                  "VALUES (@FullName, @Email, @Username, MD5(@Password), @UserType)"

            Using cmd As New MySqlCommand(Query, conn)
                cmd.Parameters.AddWithValue("@FullName", tbFname.Text)
                cmd.Parameters.AddWithValue("@Email", tbEmail.Text)
                cmd.Parameters.AddWithValue("@Username", tbUsername.Text)
                cmd.Parameters.AddWithValue("@Password", tbPassword.Text)
                cmd.Parameters.AddWithValue("@UserType", cbUser.SelectedItem.ToString())

                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Clearfields()
                Else
                    MessageBox.Show("Failed to create user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
        LoadUserTable(dgTables)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Check if any required fields are empty
        If String.IsNullOrEmpty(tbFname.Text) OrElse
           String.IsNullOrEmpty(tbEmail.Text) OrElse
           String.IsNullOrEmpty(tbUsername.Text) OrElse
           cbUser.SelectedIndex = -1 Then

            MessageBox.Show("All fields except password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' Prepare the SQL query to update the user (without u_ID and date)
            Dim Query As String = "UPDATE `user` SET full_name=@FullName, email=@Email, user_name=@Username, user_type=@UserType"

            ' Only update password if it's provided
            If Not String.IsNullOrEmpty(tbPassword.Text) Then
                Query &= ", password=MD5(@Password)"
            End If

            Query &= " WHERE user_name=@Username"

            Using cmd As New MySqlCommand(Query, conn)
                cmd.Parameters.AddWithValue("@FullName", tbFname.Text)
                cmd.Parameters.AddWithValue("@Email", tbEmail.Text)
                cmd.Parameters.AddWithValue("@Username", tbUsername.Text)
                cmd.Parameters.AddWithValue("@UserType", cbUser.SelectedItem.ToString())

                If Not String.IsNullOrEmpty(tbPassword.Text) Then
                    cmd.Parameters.AddWithValue("@Password", tbPassword.Text)
                End If

                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Clearfields()
                Else
                    MessageBox.Show("Failed to update user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
        LoadUserTable(dgTables)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Ensure that the username field is not empty
        If String.IsNullOrEmpty(tbUsername.Text) Then
            MessageBox.Show("Please enter the username of the user you want to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' SQL query to delete the user based on the username
            Dim Query As String = "DELETE FROM `user` WHERE user_name=@Username"

            Using cmd As New MySqlCommand(Query, conn)
                cmd.Parameters.AddWithValue("@Username", tbUsername.Text)

                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Clearfields()
                Else
                    MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
        LoadUserTable(dgTables)
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Dim searchText As String = tbSearch.Text.Trim()

        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' SQL query to filter users based on the search input
            Dim Query As String = "SELECT * FROM `user` WHERE user_name LIKE @SearchText OR full_name LIKE @SearchText"

            Using cmd As New MySqlCommand(Query, conn)
                cmd.Parameters.AddWithValue("@SearchText", "%" & searchText & "%")

                Dim dt As New DataTable()
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using

                ' Bind the DataGridView to the filtered data
                dgTables.DataSource = dt
            End Using

            ' Optionally, clear the textboxes if there's no search input
            If String.IsNullOrEmpty(searchText) Then
                Clearfields()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub dgTables_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTables.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgTables.Rows(e.RowIndex)

            ' Populate the textboxes and ComboBoxes with the selected row data
            tbFname.Text = selectedRow.Cells("full_name").Value.ToString()
            tbEmail.Text = selectedRow.Cells("email").Value.ToString()
            tbUsername.Text = selectedRow.Cells("user_name").Value.ToString()
            tbPassword.Clear() ' Optionally clear the password field
            cbUser.SelectedItem = selectedRow.Cells("user_type").Value.ToString()
        End If
    End Sub




    Public Sub Clearfields()
        tbEmail.Clear()
        tbFname.Clear()
        tbPassword.Clear() ' This will be cleared on search or after creation/update
        tbSearch.Clear()
        tbUsername.Clear()
        cbUser.SelectedIndex = -1
    End Sub
End Class
