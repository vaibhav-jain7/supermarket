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

End Class