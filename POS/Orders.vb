Public Class Orders
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Home.Delete("Orders", TextBox1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form1.datagridShow()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Home.Search("Orders", TextBox1, lvOrders)
    End Sub
End Class