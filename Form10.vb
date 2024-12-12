Imports System.IO
Imports System.Data.SQLite

Public Class Form10
    Private connectionString As String = "Data Source=bicycle_rental.db;Version=3;"
    Private staffIds As New Dictionary(Of Integer, Integer)  ' To store index -> staff_id mapping
    Private currentStaffId As Integer = -1

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStaffList()
    End Sub

    Private Sub LoadStaffList()
        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT staff_id, username FROM staff ORDER BY username"
                Using command As New SQLiteCommand(query, connection)
                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        stafflist.Items.Clear()
                        staffIds.Clear()
                        While reader.Read()
                            Dim index As Integer = stafflist.Items.Add(reader("username").ToString())
                            staffIds(index) = reader("staff_id")  ' Store the mapping
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading staff list: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub stafflist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles stafflist.SelectedIndexChanged
        If stafflist.SelectedIndex >= 0 Then
            Dim staffId As Integer = staffIds(stafflist.SelectedIndex)
            LoadStaffDetails(staffId)
        End If
    End Sub

    Private Sub LoadStaffDetails(staffId As Integer)
        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM staff WHERE staff_id = @staff_id"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@staff_id", staffId)
                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            currentStaffId = staffId
                            staffname.Text = reader("username").ToString()
                            staffnumber.Text = reader("staff_contact").ToString()
                            staffpassword.Text = reader("password").ToString()

                            ' Load profile picture if it exists
                            Dim profilePicturePath As String = reader("profile_picture_path").ToString()
                            If Not String.IsNullOrEmpty(profilePicturePath) AndAlso File.Exists(profilePicturePath) Then
                                If profile.Image IsNot Nothing Then
                                    profile.Image.Dispose()
                                End If
                                profile.Image = Image.FromFile(profilePicturePath)
                                profile.SizeMode = PictureBoxSizeMode.StretchImage
                            Else
                                If profile.Image IsNot Nothing Then
                                    profile.Image.Dispose()
                                End If
                                profile.Image = Nothing
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading staff details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub satffeditsave_Click(sender As Object, e As EventArgs) Handles satffeditsave.Click
        If currentStaffId = -1 Then
            MessageBox.Show("Please select a staff member to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE staff SET username = @username, password = @password, staff_contact = @contact WHERE staff_id = @staff_id"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@username", staffname.Text)
                    command.Parameters.AddWithValue("@password", staffpassword.Text)
                    command.Parameters.AddWithValue("@contact", staffnumber.Text)
                    command.Parameters.AddWithValue("@staff_id", currentStaffId)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Staff information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadStaffList() ' Refresh the list
        Catch ex As Exception
            MessageBox.Show("Error updating staff information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub staffdelete_Click(sender As Object, e As EventArgs) Handles staffdelete.Click
        If currentStaffId = -1 Then
            MessageBox.Show("Please select a staff member to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this staff member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Using connection As New SQLiteConnection(connectionString)
                    connection.Open()
                    ' Get the profile picture path before deleting
                    Dim profilePicturePath As String = ""
                    Dim queryGetPath As String = "SELECT profile_picture_path FROM staff WHERE staff_id = @staff_id"
                    Using cmdGetPath As New SQLiteCommand(queryGetPath, connection)
                        cmdGetPath.Parameters.AddWithValue("@staff_id", currentStaffId)
                        profilePicturePath = Convert.ToString(cmdGetPath.ExecuteScalar())
                    End Using

                    ' Delete the staff record
                    Dim queryDelete As String = "DELETE FROM staff WHERE staff_id = @staff_id"
                    Using command As New SQLiteCommand(queryDelete, connection)
                        command.Parameters.AddWithValue("@staff_id", currentStaffId)
                        command.ExecuteNonQuery()
                    End Using

                    ' Delete the profile picture if it exists
                    If Not String.IsNullOrEmpty(profilePicturePath) AndAlso File.Exists(profilePicturePath) Then
                        File.Delete(profilePicturePath)
                    End If
                End Using

                MessageBox.Show("Staff member deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
                LoadStaffList()
            Catch ex As Exception
                MessageBox.Show("Error deleting staff member: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ClearForm()
        currentStaffId = -1
        staffname.Clear()
        staffnumber.Clear()
        staffpassword.Clear()
        If profile.Image IsNot Nothing Then
            profile.Image.Dispose()
        End If
        profile.Image = Nothing
    End Sub

    ' Optional: Add navigation button to go back to Form7


    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If profile.Image IsNot Nothing Then
            profile.Image.Dispose()
        End If
    End Sub

    Private Sub btnOpenForm2_Click(sender As Object, e As EventArgs) Handles btnOpenForm2.Click
        Dim form11 As New Form11()
        form11.Show()
        Me.Hide()
    End Sub


End Class