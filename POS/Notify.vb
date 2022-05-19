Public Class Notify
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Home.Delete("Notifications", TextBox1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form1.datagridShow()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Home.Search("Notifications", TextBox1, lvNotify)
    End Sub
End Class