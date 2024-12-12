Public Class Form11
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form10 As New Form10()
        form10.Show()
        Me.Hide()
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim setrate As New setrate()
        setrate.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form7 As New Form7
        form7.Show()
        Hide()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dim maintenance As New txtDescription
        txtDescription.Show()
        Me.Hide()
    End Sub
End Class