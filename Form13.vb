Imports MySql.Data.MySqlClient
Public Class Form13

    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String

    Public Sub AllCustomers()
        Call connect()
        query = "select * from customers"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        Dim LIST As New ListViewItem
        ListView1.Items.Clear()

        While READER.Read
            LIST = ListView1.Items.Add(READER.GetString("customer_id"))
            LIST.SubItems.Add(READER.GetString("customer_name"))
            LIST.SubItems.Add(READER.GetString("email"))
            LIST.SubItems.Add(READER.GetString("ph_no"))
            LIST.SubItems.Add(READER.GetDateTime("date"))
        End While
        conn.Close()
        C_PH.Focus()
    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AllCustomers()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form5 As New Form5()
        form5.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Call connect()
        query = "select * from customers where ph_no = " & C_PH.Text & ""
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        Dim LIST As New ListViewItem
        ListView1.Items.Clear()
        While READER.Read
            LIST = ListView1.Items.Add(READER.GetString("customer_id"))
            LIST.SubItems.Add(READER.GetString("customer_name"))
            LIST.SubItems.Add(READER.GetString("email"))
            LIST.SubItems.Add(READER.GetString("ph_no"))
            LIST.SubItems.Add(READER.GetDateTime("date"))
        End While
        conn.Close()

        C_PH.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AllCustomers()
    End Sub
End Class