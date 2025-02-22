Imports MySql.Data.MySqlClient

Public Class Form6

    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label6.Text = Today
        Call connect()
        query = "select * from employee where emp_id = " & emp & ""
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        While READER.Read
            E_NAME.Text = READER.GetString("emp_name")
        End While

        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        User = ""
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim form12 As New Form12()
        form12.Show()
        Me.Close()
    End Sub

    Private Sub Form6_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Call connect()
        'query = "select min(draft_id) from draft_bill"
        'CMD = New MySqlCommand(query, conn)
        'READER = CMD.ExecuteReader
        'While READER.Read
        '    If READER(0).ToString = "" Then
        '        CurrentBillState = True
        '        PendingBill = False
        '    Else
        '        CurrentBillState = False
        '        PendingBill = True
        '    End If
        'End While
        'conn.Close()
        Call connect()
        query = "START TRANSACTION;" &
                            "DELETE FROM draft_bill;" &
                            "DELETE FROM draft_bill_details;" &
                            "COMMIT;"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        conn.Close()
    End Sub

    'Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    'End Sub
End Class