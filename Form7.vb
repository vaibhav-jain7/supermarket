Imports System.IO.Pipelines
Imports MySql.Data.MySqlClient

Public Class Form7

    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'INCREMENT CUSTOMER ID
        AutoCustomerIncrementId()
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
    End Sub

    Public Sub AutoProductIncrementId()
        Call connect()
        query = "select max(product_id) from products"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        While READER.Read
            P_ID.Text = Val(READER(0) + 1)
        End While
        conn.Close()
    End Sub

    Public Sub AutoCustomerIncrementId()
        Call connect()
        query = "select max(customer_id) from customers"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        While READER.Read
            C_ID.Text = Val(READER(0) + 1)
        End While
        conn.Close()
    End Sub

    Public Sub ClearTextBoxes()
        C_NAME.Clear()
        C_EMAIL.Clear()
        C_ADD.Clear()
        C_PH.Clear()

        'CALL AUTOINCREMENT FUNCTION TO INCREMENT C_ID 
        AutoCustomerIncrementId()
    End Sub

End Class