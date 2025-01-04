Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        User = "ADMIN"
        Dim form3 As New Form3()
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        User = "EMPLOYEE"
        Dim form3 As New Form3()
        form3.Show()
        Me.Hide()
    End Sub

End Class