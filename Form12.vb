Imports MySql.Data.MySqlClient

Public Class Form12
    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String

    Dim EMP_NAME As String


    Public Sub AllSales()

        Dim count As Integer = 0

        Call connect()
        query = "select * from sales where emp_id = " & emp & " and sales_date = curdate()"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        While READER.Read()
            count = count + 1
        End While
        conn.Close()

        Dim CustomersID(count) As Integer
        Dim CustomersName(count) As String


        'CUSTOMER DETAILS
        Call connect()
        query = "select cust_id from sales where sales_date = curdate()"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        Dim i As Integer = 0

        While READER.Read
            CustomersID(i) = READER(0)
            i += 1
        End While
        conn.Close()


        For i = 0 To CustomersID.Count - 1
            Call connect()
            query = "select customer_name from customers where customer_id = " & CustomersID.ElementAt(i) & ""
            CMD = New MySqlCommand(query, conn)
            READER = CMD.ExecuteReader
            While READER.Read
                CustomersName(i) = READER(0)
            End While
            conn.Close()
        Next

        'EMP DETAILS
        Call connect()
        query = "select emp_name from employee where emp_id = " & emp & ""
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        While READER.Read
            EMP_NAME = READER(0)
        End While
        conn.Close()

        Call connect()
        query = "select * from sales where sales_date = curdate()"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        Dim totoalAmt As Integer = 0
        Dim LIST As New ListViewItem
        ListView1.Items.Clear()
        i = 0
        While READER.Read
            LIST = ListView1.Items.Add(READER.GetString("bill_id"))
            LIST.SubItems.Add(CustomersName.ElementAt(i))
            LIST.SubItems.Add(EMP_NAME)
            LIST.SubItems.Add(READER.GetString("tot_amt"))
            totoalAmt = totoalAmt + Val(READER.GetString("tot_amt"))

            LIST.SubItems.Add(READER.GetString("payment"))
            LIST.SubItems.Add(READER.GetDateTime("sales_date"))
            i = i + 1
        End While
        conn.Close()
        Label4.Text = "Rs. " & totoalAmt
    End Sub


    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TODY_DATE.Text = DateString
        AllSales()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form6 As New Form6()
        form6.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TIME.Text = TimeString
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If TextBox1.Text = "" Then
            MsgBox("Enter Phone Number")
            Exit Sub
        End If

        Dim count As Integer = 0

        Call connect()
        query = "select * from sales where emp_id = " & emp & " and sales_date = curdate()"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        While READER.Read()
            count = count + 1
        End While
        conn.Close()

        If count = 0 Then
            ListView1.Items.Clear()
            MsgBox("Sales Didn't Exists")
            Exit Sub
        End If

        Dim CustomersID As Integer
        Dim CustomersName As String


        'CUSTOMER DETAILS
        Call connect()
        query = "select customer_id, customer_name from customers where ph_no = " & TextBox1.Text & ""
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        While READER.Read
            CustomersID = READER(0)
            CustomersName = READER(1)
        End While
        conn.Close()

        Call connect()
        query = "Select * from sales where cust_id = " & CustomersID & " and sales_date = curdate() and emp_id = " & emp & ""
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        Dim totoalAmt As Integer = 0
        Dim LIST As New ListViewItem
        ListView1.Items.Clear()
        While READER.Read
            LIST = ListView1.Items.Add(READER.GetString("bill_id"))
            LIST.SubItems.Add(CustomersName)
            LIST.SubItems.Add(EMP_NAME)
            LIST.SubItems.Add(READER.GetString("tot_amt"))
            totoalAmt = totoalAmt + Val(READER.GetString("tot_amt"))
            LIST.SubItems.Add(READER.GetString("payment"))
            LIST.SubItems.Add(READER.GetDateTime("sales_date"))
        End While
        conn.Close()
        Label4.Text = "Rs. " & totoalAmt
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AllSales()
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub
End Class