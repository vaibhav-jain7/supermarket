Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If User = "ADMIN" Then
            Label1.Text = "ADMINISTRATOR LOGIN"
        ElseIf User = "MANAGER" Then
            Label1.Text = "MANAGER LOGIN"
        ElseIf User = "EMPLOYEE" Then
            Label1.Text = "EMPLOYEE LOGIN"
        End If

        'Center Label According to the User
        Label1.Left = (Me.ClientSize.Width - Label1.Width) / 2

        'Current Date
        Label5.Text = Today
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        userid.Text = ""
        pass.Text = ""
    End Sub
End Class