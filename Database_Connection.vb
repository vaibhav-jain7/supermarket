Imports MySql.Data.MySqlClient

Module Database_Connection
    Public conn As MySqlConnection
    Public Sub connect()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user=root;password='qwerty123';database=super_market"
        conn.Open()
        If conn.State <> ConnectionState.Open Then
            MessageBox.Show("No Connection")
        End If
    End Sub

End Module
