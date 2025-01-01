Imports MySql.Data.MySqlClient

Public Class Form9

    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String
    Dim cust_id As String
    Dim sale As String

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'PRODUCT DETAILS
        Call connect()
        'query = "select * from bill_data where bill_id = '" & CurrentBill & "'"
        query = "select * from bill_data where bill_id = '20250001'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        Dim PRO As ListViewItem
        ListView1.Items.Clear()

        While READER.Read
            PRO = ListView1.Items.Add(READER.GetString("p_name"))
            PRO.SubItems.Add((READER.GetString("p_qty")))
            PRO.SubItems.Add((READER.GetString("p_dis")))
            PRO.SubItems.Add((READER.GetString("p_gst")))
            PRO.SubItems.Add((READER.GetString("p_mrp")))
            PRO.SubItems.Add((READER.GetString("p_amt")))
        End While
        conn.Close()

        'PRODUCT AMT DETAILS
        Call connect()
        'query = "select * from bill_data where bill_id = '" & CurrentBill & "'"
        query = "select * from bill_data_details where bill_id = '20250001'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        While READER.Read
            cust_id = READER.GetString("c_id")
            DIS.Text = READER.GetInt32("dis")
            GST.Text = READER.GetInt32("gst")
            FINALAMT.Text = READER.GetInt32("tot_amt")
            TOTALAMT.Text = READER.GetInt32("tot_amt")
        End While
        conn.Close()

        'CUSTOMER DEATILS
        Call connect()
        query = "select * from customers where customer_id = '" & cust_id & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        While READER.Read
            TextBox1.Text = READER.GetString("customer_name")
            TextBox2.Text = READER.GetString("email")
            TextBox3.Text = READER.GetString("ph_no")
        End While
        conn.Close()

    End Sub

    Public Sub MaxSaleID()
        Call connect()
        query = "select max(sale_id) from sales"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        While READER.Read
            If READER(0).ToString = "" Then
                sale = 21001
            Else
                sale = Val(READER(0) + 1)
            End If
        End While
        conn.Close()
    End Sub

    Private Sub ADD_Click(sender As Object, e As EventArgs)
        Dim form7 As New Form7()
        form7.Show()
        Me.Close()
    End Sub

    Private Sub CASHBYCUSTOMER_TextChanged(sender As Object, e As EventArgs) Handles CASHBYCUSTOMER.TextChanged
        CHANGEAMT.Text = Val(FINALAMT.Text) - Val(CASHBYCUSTOMER.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (PAYMENTMODE.Text = "CASH") Then
            MaxSaleID()
            Call connect()
            query = "insert into sales (sale_id,bill_id ,cust_id,emp_id ,tot_amt, payment) values ('" & Val(sale) & "','20250001', '" & cust_id & "', '" & emp & "','" & FINALAMT.Text & "', 'CASH')"
            CMD = New MySqlCommand(query, conn)
            READER = CMD.ExecuteReader
            conn.Close()

            PAYMENTMODE.Enabled = False
            CASHBYCUSTOMER.Enabled = False
            CHANGEAMT.Enabled = False
            TOTALAMT.Enabled = False

        ElseIf (PAYMENTMODE.Text = "UPI") Then
            MaxSaleID()
            Call connect()
            query = "insert into sales (sale_id,bill_id ,cust_id,emp_id ,tot_amt, payment) values ('" & Val(sale) & "','20250001', '" & cust_id & "', '" & emp & "','" & FINALAMT.Text & "', 'UPI')"
            CMD = New MySqlCommand(query, conn)
            READER = CMD.ExecuteReader
            conn.Close()
            TOTALAMT.Enabled = False

        ElseIf (PAYMENTMODE.Text = "CARD") Then
            MaxSaleID()
            Call connect()
            query = "insert into sales (sale_id,bill_id ,cust_id,emp_id ,tot_amt, payment) values ('" & Val(sale) & "','20250001', '" & cust_id & "', '" & emp & "','" & FINALAMT.Text & "', 'CARD')"
            CMD = New MySqlCommand(query, conn)
            READER = CMD.ExecuteReader
            conn.Close()
            TOTALAMT.Enabled = False

        End If

        MessageBox.Show("Payment Done...", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)



    End Sub

    Private Sub PAYMENTMODE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PAYMENTMODE.SelectedIndexChanged
        If (PAYMENTMODE.Text = "CASH") Then
            PictureBox1.Visible = False
            PIN.Visible = False
            PINNO.Visible = False
            CARDNO.Visible = False
            CARDNUMBER.Visible = False

            Label11.Visible = True
            Label13.Visible = True
            CASHBYCUSTOMER.Visible = True
            CHANGEAMT.Visible = True
        ElseIf (PAYMENTMODE.Text = "UPI") Then
            PictureBox1.Visible = True

            PIN.Visible = False
            PINNO.Visible = False
            CARDNO.Visible = False
            CARDNUMBER.Visible = False
            Label11.Visible = False
            Label13.Visible = False
            CASHBYCUSTOMER.Visible = False
            CHANGEAMT.Visible = False
        ElseIf (PAYMENTMODE.Text = "CARD") Then
            PictureBox1.Visible = False
            CASHBYCUSTOMER.Visible = False
            CHANGEAMT.Visible = False
            Label11.Visible = False
            Label13.Visible = False

            PIN.Visible = True
            PINNO.Visible = True
            CARDNO.Visible = True
            CARDNUMBER.Visible = True

        End If
    End Sub
End Class