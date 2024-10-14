Imports MySql.Data.MySqlClient

Module Database_Connection

    'FROM CONTROLS
    Public User As String
    Public admin As String
    Public emp As String

    Public conn As MySqlConnection
    Public Sub connect()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user=root;password='rohitdev';database=super_market"
        conn.Open()
        If conn.State <> ConnectionState.Open Then
            MessageBox.Show("No Connection")
        End If
    End Sub

End Module
