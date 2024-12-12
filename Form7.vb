Imports System.IO
Imports System.Data.SQLite

Public Class Form7
    Private connectionString As String = "Data Source=bicycle_rental.db;Version=3;"
    Private profilePicturePath As String = "prof\"

    Private Sub uploadstaffprofile_Click(sender As Object, e As EventArgs) Handles uploadstaffprofile.Click
        Try
            Using openFileDialog As New OpenFileDialog()
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif"
                openFileDialog.Title = "Select Staff Profile Picture"

                If openFileDialog.ShowDialog() = DialogResult.OK Then
                    ' Generate unique filename using timestamp
                    Dim fileName As String = $"{DateTime.Now.ToString("yyyyMMddHHmmss")}{Path.GetExtension(openFileDialog.FileName)}"

                    ' Create prof directory if it doesn't exist
                    Dim profDirectory As String = Path.Combine(Application.StartupPath, "prof")
                    If Not Directory.Exists(profDirectory) Then
                        Directory.CreateDirectory(profDirectory)
                    End If

                    ' Set the profile picture path
                    profilePicturePath = Path.Combine(profDirectory, fileName)

                    ' Copy the selected image to prof folder
                    File.Copy(openFileDialog.FileName, profilePicturePath)

                    ' Display image in PictureBox (assuming you have one named staffprofile)
                    staffprofile.Image = Image.FromFile(profilePicturePath)
                    staffprofile.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error uploading profile picture: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub addstaff_Click(sender As Object, e As EventArgs) Handles addstaff.Click
        Try
            ' Validate inputs
            If String.IsNullOrEmpty(staffname.Text) OrElse String.IsNullOrEmpty(staffpassword.Text) Then
                MessageBox.Show("Please enter staff name and password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Ensure a profile picture has been selected
            If String.IsNullOrEmpty(profilePicturePath) Then
                MessageBox.Show("Please upload a profile picture.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using connection As New SQLiteConnection(connectionString)
                connection.Open()

                ' Insert new staff record with profile picture path
                Dim query As String = "INSERT INTO staff (username, password, staff_contact, profile_picture_path) VALUES (@username, @password, @contact, @profile_picture_path)"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@username", staffname.Text)
                    command.Parameters.AddWithValue("@password", staffpassword.Text)
                    command.Parameters.AddWithValue("@contact", staffcontact.Text)
                    command.Parameters.AddWithValue("@profile_picture_path", profilePicturePath) ' Save the profile picture path
                    command.ExecuteNonQuery()
                End Using

                ' Clear the form
                ClearForm()

                MessageBox.Show("Staff added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

        Catch ex As Exception
            MessageBox.Show("Error adding staff: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearForm()
        staffname.Clear()
        staffpassword.Clear()
        staffcontact.Clear()
        staffprofile.Image = Nothing
        profilePicturePath = ""
    End Sub

    ' Optional: Add validation for text changed events
    Private Sub staffname_TextChanged_1(sender As Object, e As EventArgs) Handles staffname.TextChanged
        ' Add any validation logic here if needed
    End Sub

    Private Sub staffcontact_TextChanged(sender As Object, e As EventArgs) Handles staffcontact.TextChanged
        ' Add any validation logic here if needed
    End Sub

    Private Sub staffpassword_TextChanged(sender As Object, e As EventArgs) Handles staffpassword.TextChanged
        ' Add any validation logic here if needed
    End Sub

    Private Sub staffprofile_Click(sender As Object, e As EventArgs) Handles staffprofile.Click
        ' Add any click handling logic for the profile picture if needed
    End Sub

    Private Sub btnOpenForm2_Click(sender As Object, e As EventArgs) Handles btnOpenForm2.Click
        Dim form11 As New Form11
        form11.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form10 As New Form10()
        form10.Show()
        Me.Hide()
    End Sub
End Class