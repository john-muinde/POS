Public Class Users
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Home.Delete("Users", TextBox1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form1.datagridShow()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Home.Search("Users", TextBox1, lvUsers)
    End Sub
End Class