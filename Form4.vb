Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        User = "ADMIN"
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        User = "MANAGER"
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        User = "EMPLOYEE"
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class