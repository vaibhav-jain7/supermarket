Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Label2.Text = 0.ToString Then
            Label2.Text = 2024001.ToString
        Else
            Label2.Text = Label2.Text + 1.ToString
        End If
        Label5.Text = User
    End Sub
End Class