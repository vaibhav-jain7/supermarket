Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        User = "ADMIN"
        Dim form3 As New Form3()
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        User = "EMPLOYEE"
        Dim form3 As New Form3()
        form3.Show()
        Me.Hide()
    End Sub

    'Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    'End Sub

    'Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    'Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    'End Sub
End Class