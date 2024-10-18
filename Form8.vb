Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Agreement

Public Class Form8
    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'INCREMENT CUSTOMER ID
        AutoCustomerIncrementId()

        'EMP_ID
        Label6.Text = emp

        'FORM CREATION DATE & TIME
        TODY_DATE.Text = Today
    End Sub

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
        query = "insert into customers values ('" & C_ID.Text & "','" & C_NAME.Text & "','" & C_EMAIL.Text & "','" & C_PH.Text & "',' ',current_date())"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        cust_id = Val(C_ID.Text)
        conn.Close()
        Me.Hide()
        Form7.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'INCREMENT CUSTOMER ID
        AutoCustomerIncrementId()
        C_NAME.Clear()
        C_EMAIL.Clear()
        C_PH.Clear()
    End Sub

    Private Sub C_PH_TextChanged(sender As Object, e As EventArgs) Handles C_PH.TextChanged

        Call connect()
        query = "select * from customers where ph_no = '" & C_PH.Text & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        While READER.Read
            C_ID.Text = READER.GetString("customer_id")
            C_NAME.Text = READER.GetString("customer_name")
            C_EMAIL.Text = READER.GetString("email")
            C_PH.Text = READER.GetString("ph_no")
            cust_id = Val(READER.GetString("customer_id"))
            EXISTS.Enabled = True
        End While
        conn.Close()

    End Sub

    Private Sub EXISTS_Click(sender As Object, e As EventArgs) Handles EXISTS.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TIME.Text = TimeString
    End Sub
End Class