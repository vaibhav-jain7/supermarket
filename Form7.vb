Imports System.IO.Pipelines
Imports MySql.Data.MySqlClient

Public Class Form7

    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String
    Dim one As Integer = 0

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'INCREMENT CUSTOMER ID
        AutoCustomerIncrementId()

        'FORM CREATION DATE & TIME
        TODY_DATE.Text = Today

        'DISABLE MODIFY AND DELETE OPTION
        MODIFY.Enabled = False
        DELETE.Enabled = False

        'GENERATE BILL NUMBER
        Call connect()

        query = "select max(bill_id) from bill_data_details"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        While READER.Read
            If READER(0).ToString = "" Then
                BILL_NO.Text = 25010001
            Else
                BILL_NO.Text = READER(0) + 1
            End If

        End While

        conn.Close()

        Dim PRO As ListViewItem
        PRO = ListView1.Items.Add("Tata Salt")
        PRO.SubItems.Add(CATEGORY.Text)
        PRO.SubItems.Add(10)
        PRO.SubItems.Add(50)
        PRO.SubItems.Add(20)
        PRO.SubItems.Add(10)

        PRO = ListView1.Items.Add("Tata Salt")
        PRO.SubItems.Add(CATEGORY.Text)
        PRO.SubItems.Add(5)
        PRO.SubItems.Add(50)
        PRO.SubItems.Add(20)
        PRO.SubItems.Add(1)

        For 

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If one = 0 Then
            Call connect()
            'ADDING CUSTOMER INTO CUSTOMER TABLE
            query = "insert into customers values ('" & C_ID.Text & "','" & C_NAME.Text & "','" & C_EMAIL.Text & "','" & C_PH.Text & "','" & C_ADD.Text & "',current_date())"
            CMD = New MySqlCommand(query, conn)
            READER = CMD.ExecuteReader
            'INCREMENT CUSTOMER ID
            AutoCustomerIncrementId()
            conn.Close()
        End If
        one += 1

        If QTY.Text <> "" Then
            If Val(QTY.Text) = 0 Or Val(MRP.Text) = 0 Or Val(GST.Text) = 0 Or Val(DISCOUNT.Text) = 0 Then
                MessageBox.Show("Value Can't be Zero")
            Else
                Dim PRO As ListViewItem
                PRO = ListView1.Items.Add(P_NAME.Text.ToUpper)
                PRO.SubItems.Add(CATEGORY.Text)
                PRO.SubItems.Add(MRP.Text)
                PRO.SubItems.Add(GST.Text)
                PRO.SubItems.Add(DISCOUNT.Text)
                PRO.SubItems.Add(QTY.Text)

                'CLEAR AFTER EACH PRODUCT ENTRY
                ClearProducts()

                P_NAME.Focus()
            End If
        Else
            MessageBox.Show("Fill All Fields")
            QTY.Focus()
        End If

    End Sub

    Public Sub ClearProducts()
        P_NAME.Clear()
        QTY.Clear()
        CATEGORY.Text = ""
        MRP.Clear()
        GST.Clear()
        DISCOUNT.Clear()
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

    Private Sub P_NAME_TextChanged(sender As Object, e As EventArgs) Handles P_NAME.TextChanged
        Call connect()
        query = "select * from products where product_name = '" & P_NAME.Text & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        While READER.Read
            CATEGORY.Text = READER.GetString("category_name")
            MRP.Text = READER.GetDouble("mrp")
            GST.Text = READER.GetDouble("gst")
            DISCOUNT.Text = READER.GetDouble("discount").ToString
        End While

        conn.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TIME.Text = TimeString
    End Sub
End Class