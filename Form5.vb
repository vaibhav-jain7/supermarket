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
        Dim form1 As New Form1()
        form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form2 As New Form2()
        form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form11.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form13.Show()
        Me.Hide()

    End Sub

    Private Sub AD_NAME_Click(sender As Object, e As EventArgs) Handles AD_NAME.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        User = ""
        Dim form4 As New Form4()
        form4.Show()
        Me.Close()

    End Sub
End Class