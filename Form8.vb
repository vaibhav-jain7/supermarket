Imports MySql.Data.MySqlClient

Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'INCREMENT CUSTOMER ID
        AutoCustomerIncrementId()

        'EMP_ID
        Label6.Text = emp

        'FORM CREATION DATE & TIME
        TODY_DATE.Text = Today
    End Sub
    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String

    Public Sub AutoCustomerIncrementId()
        Call connect()
        query = "select max(customer_id) from customers"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        While READER.Read
            If READER(0).ToString = "" Then
                C_ID.Text = 20251
            Else
                C_ID.Text = Val(READER(0) + 1)
            End If
        End While
        conn.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call connect()
        'ADDING CUSTOMER INTO CUSTOMER TABLE
        query = "insert into customers values ('" & C_ID.Text & "','" & C_NAME.Text & "','" & C_EMAIL.Text & "','" & C_PH.Text & "','" & C_ADD.Text & "',current_date())"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        'INCREMENT CUSTOMER ID
        AutoCustomerIncrementId()
        conn.Close()
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        C_NAME.Clear()
        C_EMAIL.Clear()
        C_ADD.Clear()
        C_PH.Clear()
    End Sub
End Class