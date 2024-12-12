Imports System.Data.SQLite

Public Class txtDescription
    ' Connection string for SQLite database
    Dim connString As String = "Data Source=" & System.IO.Path.Combine(Application.StartupPath, "bicycle_rental.db") & ";Version=3;"

    ' Method to load data into the DataGrid
    Private Sub LoadDataGrid(Optional searchText As String = "")
        Dim query As String
        If String.IsNullOrEmpty(searchText) Then
            ' If no search term is provided, load all records
            query = "SELECT * FROM maintenance"
        Else
            ' If search term is provided, filter the data by bicycle_id
            query = "SELECT * FROM maintenance WHERE bicycle_id LIKE @searchText"
        End If

        ' Using block for the connection and command
        Using con As New SQLiteConnection(connString)
            Using cmd As New SQLiteCommand(query, con)
                ' If searching, add the parameter for the search text
                If Not String.IsNullOrEmpty(searchText) Then
                    cmd.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
                End If

                ' Data adapter to fill the DataGrid
                Using adapter As New SQLiteDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    ' Bind the result to the DataGridView (table_record)
                    table_record.DataSource = dt

                    ' Check if any records were found
                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("No records found.")
                    End If
                End Using
            End Using
        End Using
    End Sub

    ' Event handler for the Search button or TextChanged event of txtSearchID
    Private Sub txtSearchID_TextChanged(sender As Object, e As EventArgs) Handles txtSearchID.TextChanged
        ' Call LoadDataGrid method to filter based on the search text
        LoadDataGrid(txtSearchID.Text)
    End Sub

    ' Event handler for the Save button
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate required fields before saving
        If String.IsNullOrEmpty(txtBicycleID.Text) OrElse comboStatus.SelectedItem Is Nothing OrElse String.IsNullOrEmpty(txtDescript.Text) OrElse String.IsNullOrEmpty(txtTechName.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        ' First, check if the bicycle ID exists in the bicycles table
        Dim bicycleExists As Boolean = False
        Dim checkQuery As String = "SELECT COUNT(*) FROM bicycles WHERE bicycle_id = @bicycle_id"

        Using con As New SQLiteConnection(connString)
            Using cmd As New SQLiteCommand(checkQuery, con)
                cmd.Parameters.AddWithValue("@bicycle_id", txtBicycleID.Text)
                Try
                    con.Open()
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    bicycleExists = (count > 0)
                Catch ex As Exception
                    MessageBox.Show("Error checking bicycle ID: " & ex.Message)
                    Return
                End Try
            End Using
        End Using

        ' If bicycle doesn't exist, show error and return
        If Not bicycleExists Then
            MessageBox.Show("Error: Bicycle ID " & txtBicycleID.Text & " does not exist in the inventory. Please enter a valid bicycle ID.")
            Return
        End If

        ' If we get here, the bicycle exists, so proceed with saving the maintenance record
        Dim query As String = "INSERT INTO maintenance (bicycle_id, maintenance_date, expected_completion_date, status, description, technician_name) " &
                          "VALUES (@bicycle_id, @maintenance_date, @expected_completion_date, @status, @description, @technician_name)"

        Using con As New SQLiteConnection(connString)
            Using cmd As New SQLiteCommand(query, con)
                ' Assign parameter values from the form controls
                cmd.Parameters.AddWithValue("@bicycle_id", txtBicycleID.Text)
                cmd.Parameters.AddWithValue("@maintenance_date", maintinanceDate.Value)
                cmd.Parameters.AddWithValue("@expected_completion_date", completionDatepicker.Value)
                cmd.Parameters.AddWithValue("@status", comboStatus.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@description", txtDescript.Text)
                cmd.Parameters.AddWithValue("@technician_name", txtTechName.Text)

                Try
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Maintenance record saved successfully.")

                    ' Reload the DataGrid after saving
                    LoadDataGrid(txtSearchID.Text)

                Catch ex As Exception
                    MessageBox.Show("Error saving record: " & ex.Message & vbCrLf & "Details: " & ex.StackTrace)
                End Try
            End Using
        End Using
    End Sub

    ' Form load event to initially load data in the DataGrid
    Private Sub txtDescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initially load all records into the DataGrid
        LoadDataGrid()
    End Sub

    Private Sub btnOpenForm2_Click(sender As Object, e As EventArgs) Handles btnOpenForm2.Click
        Dim form11 As New Form11()
        Me.Hide()
        form11.Show()
    End Sub

    Private Sub maintinanceDate_ValueChanged(sender As Object, e As EventArgs) Handles maintinanceDate.ValueChanged

    End Sub
End Class