Imports MySql.Data.MySqlClient

Public Class Form12
    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call connect()
        query = "Select * from sales where sales_date = @date1 Order By sales_date"
        CMD = New MySqlCommand(query, conn)
        CMD.Parameters.AddWithValue("date1", DateTimePicker1.Value.Date)
        Dim da As New MySqlDataAdapter(CMD)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class