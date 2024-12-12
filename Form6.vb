Imports MySql.Data.MySqlClient

Public Class Form6

    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
        query = "select * from employee where emp_id = " & emp & ""
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        While READER.Read
            E_NAME.Text = READER.GetString("emp_name")
        End While

        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        User = ""
        Form4.Show()
        Me.Hide()
    End Sub
End Class