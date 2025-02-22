Imports MySql.Data.MySqlClient

Public Class Form5
    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label8.Text = Today
        Call connect()
        query = "select * from admin where ad_id = '" & admin & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        While READER.Read
            AD_NAME.Text = READER.GetString("ad_name")
        End While
        conn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim form11 As New Form11()
        form11.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim form13 As New Form13()
        form13.Show()
        Me.Close()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        User = ""
        Dim form4 As New Form4()
        form4.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        Form8.Show()
    End Sub

    'Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    'End Sub
End Class