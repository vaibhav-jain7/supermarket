Imports MySql.Data.MySqlClient

Public Class Form5
    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
        query = "select * from admin where ad_id = '" & admin & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        While READER.Read
            AD_NAME.Text = READER.GetString("ad_name")
        End While

        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Under Development")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Under Development")

    End Sub

    Private Sub AD_NAME_Click(sender As Object, e As EventArgs) Handles AD_NAME.Click

    End Sub
End Class