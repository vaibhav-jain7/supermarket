Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Agreement

Public Class Form8
    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label8.Top = 144
        Label8.Left = 233

        C_PH.Top = 144
        C_PH.Left = 405

        'EMP_ID
        Label6.Text = emp
        C_PH.Focus()

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TIME.Text = TimeString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim check As Boolean = False

        Call connect()
        query = "select * from customers where ph_no = '" & C_PH.Text & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        While READER.Read
            check = True
            C_ID.Text = READER.GetInt32("customer_id")
            C_NAME.Text = READER.GetString("customer_name")
            C_EMAIL.Text = READER.GetString("email")
            C_PH.Text = READER.GetString("ph_no")
            cust_id = READER.GetInt32("customer_id")

            Label8.Top = 155
            Label8.Left = 435

            C_PH.Top = 152
            C_PH.Left = 605

            Label9.Visible = True
            Label10.Visible = True
            Label4.Visible = True
            C_EMAIL.Visible = True
            C_ID.Visible = True
            C_NAME.Visible = True

            Button1.Visible = True
            Button3.Visible = False
        End While
        conn.Close()

        If check = False Then

            'INCREMENT CUSTOMER ID
            AutoCustomerIncrementId()

            Label8.Top = 155
            Label8.Left = 435

            C_PH.Top = 152
            C_PH.Left = 605

            C_NAME.Focus()

            Label9.Visible = True
            Label10.Visible = True
            Label4.Visible = True

            C_ID.Visible = True
            C_NAME.Visible = True
            C_EMAIL.Visible = True

            cust_id = C_ID.Text

            Button1.Visible = True
            Button3.Visible = False
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim check As Boolean = False

        Call connect()
        query = "select * from customers where ph_no = '" & C_PH.Text & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        While READER.Read
            check = True
        End While
        conn.Close()

        If check <> True Then
            Call connect()
            'ADDING CUSTOMER INTO CUSTOMER TABLE
            query = "insert into customers values ('" & C_ID.Text & "','" & C_NAME.Text & "','" & C_EMAIL.Text & "','" & C_PH.Text & "',current_date())"
            CMD = New MySqlCommand(query, conn)
            READER = CMD.ExecuteReader
            cust_id = Val(C_ID.Text)
            conn.Close()

        End If

        Me.Hide()
        Form7.Show()
    End Sub

End Class