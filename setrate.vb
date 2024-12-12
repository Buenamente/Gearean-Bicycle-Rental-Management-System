Imports System.Data.SQLite

Public Class setrate
    Private connString As String = "Data Source=bicycle_rental.db;Version=3;Busy Timeout=5000;"
    Private Shared defaultRate As Decimal = 20 ' Default rate if no rate is set in database

    Private Sub setrate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load current rate when form loads
        LoadCurrentRate()
    End Sub

    Private Sub LoadCurrentRate()
        Try
            Using conn As New SQLiteConnection(connString)
                conn.Open()
                Dim cmd As New SQLiteCommand("SELECT rate FROM rental_rates ORDER BY created_at DESC LIMIT 1", conn)
                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    currentrate.Text = $"Current Rate: PHP {Convert.ToDecimal(result):F2} per hour"
                Else
                    currentrate.Text = $"Current Rate: PHP {defaultRate:F2} per hour (Default)"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading current rate: " & ex.Message)
            currentrate.Text = $"Current Rate: PHP {defaultRate:F2} per hour (Default)"
        End Try
    End Sub

    Private Sub savechanges_Click(sender As Object, e As EventArgs) Handles savechanges.Click
        ' Validate input
        Dim newRate As Decimal
        If Not Decimal.TryParse(changerate.Text, newRate) OrElse newRate <= 0 Then
            MessageBox.Show("Please enter a valid positive number for the rental rate.")
            Return
        End If

        Try
            Using conn As New SQLiteConnection(connString)
                conn.Open()
                Using transaction As SQLiteTransaction = conn.BeginTransaction()
                    Try
                        ' Insert new rate into rental_rates table
                        Dim cmd As New SQLiteCommand("INSERT INTO rental_rates (rate, created_at) VALUES (@rate, @created_at)", conn)
                        cmd.Parameters.AddWithValue("@rate", newRate)
                        cmd.Parameters.AddWithValue("@created_at", DateTime.Now)
                        cmd.ExecuteNonQuery()

                        transaction.Commit()
                        MessageBox.Show($"Rental rate updated to PHP {newRate:F2} per hour.")

                        ' Refresh current rate display
                        LoadCurrentRate()
                        changerate.Clear()
                    Catch ex As Exception
                        transaction.Rollback()
                        MessageBox.Show("Error saving new rate: " & ex.Message)
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        Try
            Using conn As New SQLiteConnection(connString)
                conn.Open()
                Using transaction As SQLiteTransaction = conn.BeginTransaction()
                    Try
                        ' Insert default rate into rental_rates table
                        Dim cmd As New SQLiteCommand("INSERT INTO rental_rates (rate, created_at) VALUES (@rate, @created_at)", conn)
                        cmd.Parameters.AddWithValue("@rate", defaultRate)
                        cmd.Parameters.AddWithValue("@created_at", DateTime.Now)
                        cmd.ExecuteNonQuery()

                        transaction.Commit()
                        MessageBox.Show($"Rental rate reset to default PHP {defaultRate:F2} per hour.")

                        ' Refresh current rate display
                        LoadCurrentRate()
                        changerate.Clear()
                    Catch ex As Exception
                        transaction.Rollback()
                        MessageBox.Show("Error resetting rate: " & ex.Message)
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form11 As New Form11()
        form11.Show()
        Me.Hide()
    End Sub
End Class