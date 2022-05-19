Public Class Products
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Home.Delete("Products", TextBox1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form1.datagridShow()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Home.Search("Products", TextBox1, lvProducts)
    End Sub
End Class