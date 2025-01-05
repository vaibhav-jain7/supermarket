Imports MySql.Data.MySqlClient
Public Class Form11
    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call connect()
        query = "Select * from sales where sales_date between @date1 and @date2"
        CMD = New MySqlCommand(query, conn)
        CMD.Parameters.Add("date1", MySqlDbType.DateTime).Value = DateTimePicker1.Value
        CMD.Parameters.Add("date2", MySqlDbType.DateTime).Value = DateTimePicker2.Value
        Dim da As New MySqlDataAdapter
        da.SelectCommand = CMD
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub
End Class