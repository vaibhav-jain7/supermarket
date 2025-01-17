Imports MySql.Data.MySqlClient
Public Class Form11

    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String

    Public Sub AllSales()

        Dim count As Integer = 0

        Call connect()
        query = "select * from sales"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        While READER.Read()
            count = count + 1
        End While
        conn.Close()


        Dim CustomersID(count) As Integer
        Dim CustomersName(count) As String

        Dim EMP_ID(count) As Integer
        Dim EMP_NAME(count) As String


        'CUSTOMER DETAILS
        Call connect()
        query = "select cust_id from sales"
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
        query = "select emp_id from sales"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        i = 0

        While READER.Read
            EMP_ID(i) = READER(0)
            i += 1
        End While
        conn.Close()

        For i = 0 To EMP_ID.Count - 1
            Call connect()
            query = "select emp_name from employee where emp_id = " & EMP_ID.ElementAt(i) & ""
            CMD = New MySqlCommand(query, conn)
            READER = CMD.ExecuteReader
            While READER.Read
                EMP_NAME(i) = READER(0)
                i += 1
            End While
            conn.Close()
        Next

        Call connect()
        query = "select * from sales"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        Dim LIST As New ListViewItem
        ListView1.Items.Clear()
        i = 0
        While READER.Read
            LIST = ListView1.Items.Add(READER.GetString("bill_id"))
            LIST.SubItems.Add(CustomersName.ElementAt(i))
            LIST.SubItems.Add(EMP_NAME.ElementAt(i))
            LIST.SubItems.Add(READER.GetString("tot_amt"))
            LIST.SubItems.Add(READER.GetString("payment"))
            LIST.SubItems.Add(READER.GetDateTime("sales_date"))
            i = i + 1
        End While

        conn.Close()
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AllSales()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If TextBox1.Text = "" Then

            Dim count As Integer = 0

            Call connect()
            query = "select * from sales"
            CMD = New MySqlCommand(query, conn)
            READER = CMD.ExecuteReader

            While READER.Read()
                count = count + 1
            End While
            conn.Close()

            If count = 0 = "" Then
                ListView1.Items.Clear()
                MsgBox("Sales Didn't Exists")
                Exit Sub
            End If

            Dim CustomersID(count) As Integer
            Dim CustomersName(count) As String

            Dim EMP_ID(count) As Integer
            Dim EMP_NAME(count) As String


            Call connect()
            query = "Select cust_id from sales where sales_date between @date1 and @date2"
            CMD = New MySqlCommand(query, conn)
            CMD.Parameters.Add("date1", MySqlDbType.Date).Value = DateTimePicker1.Value
            CMD.Parameters.Add("date2", MySqlDbType.Date).Value = DateTimePicker2.Value
            READER = CMD.ExecuteReader

            Dim i As Integer = 0

            While READER.Read
                CustomersID(i) = READER(0)
                i += 1
            End While
            conn.Close()

            Call connect()
            query = "Select emp_id from sales where sales_date between @date1 and @date2"
            CMD = New MySqlCommand(query, conn)
            CMD.Parameters.Add("date1", MySqlDbType.Date).Value = DateTimePicker1.Value
            CMD.Parameters.Add("date2", MySqlDbType.Date).Value = DateTimePicker2.Value
            READER = CMD.ExecuteReader

            i = 0
            While READER.Read
                EMP_ID(i) = READER(1)
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

            For i = 0 To EMP_ID.Count - 1
                Call connect()
                query = "select emp_name from employee where emp_id = " & EMP_ID.ElementAt(i) & ""
                CMD = New MySqlCommand(query, conn)
                READER = CMD.ExecuteReader
                While READER.Read
                    EMP_NAME(i) = READER(0)
                    i += 1
                End While
                conn.Close()
            Next


            Call connect()
            query = "Select * from sales where sales_date between @date1 and @date2"
            CMD = New MySqlCommand(query, conn)
            CMD.Parameters.Add("date1", MySqlDbType.Date).Value = DateTimePicker1.Value
            CMD.Parameters.Add("date2", MySqlDbType.Date).Value = DateTimePicker2.Value
            READER = CMD.ExecuteReader


            Dim LIST As New ListViewItem
            ListView1.Items.Clear()
            i = 0

            While READER.Read
                LIST = ListView1.Items.Add(READER.GetString("bill_id"))
                LIST.SubItems.Add(CustomersName.ElementAt(i))
                LIST.SubItems.Add(EMP_NAME.ElementAt(i))
                LIST.SubItems.Add(READER.GetString("tot_amt"))
                LIST.SubItems.Add(READER.GetString("payment"))
                LIST.SubItems.Add(READER.GetDateTime("sales_date"))
                i = i + 1
            End While
            conn.Close()

        Else
            Dim CustomersID(1) As Integer
            Dim CustomersName(1) As String


            Call connect()
            query = "select * from customers where ph_no = '" & TextBox1.Text & "'"
            CMD = New MySqlCommand(query, conn)
            READER = CMD.ExecuteReader

            Dim c_id As Integer = 0
            Dim i As Integer = 0

            While READER.Read
                c_id = READER.GetString("customer_id")
                CustomersName(i) = READER.GetString("customer_name")
            End While
            conn.Close()

            Dim count As Integer = 0

            Call connect()
            query = "SELECT * FROM sales WHERE cust_id = @cust_id AND sales_date BETWEEN @date1 AND @date2"
            CMD = New MySqlCommand(query, conn)
            CMD.Parameters.Add("@cust_id", MySqlDbType.Int32).Value = c_id
            CMD.Parameters.Add("@date1", MySqlDbType.Date).Value = DateTimePicker1.Value
            CMD.Parameters.Add("@date2", MySqlDbType.Date).Value = DateTimePicker2.Value
            READER = CMD.ExecuteReader()

            While READER.Read()
                count = count + 1
            End While
            conn.Close()

            Dim EMP_ID(count) As Integer
            Dim EMP_NAME(count) As String


            Call connect()
            query = "SELECT emp_id FROM sales WHERE cust_id = @cust_id AND sales_date BETWEEN @date1 AND @date2"
            CMD = New MySqlCommand(query, conn)
            CMD.Parameters.Add("@cust_id", MySqlDbType.Int32).Value = c_id
            CMD.Parameters.Add("@date1", MySqlDbType.Date).Value = DateTimePicker1.Value
            CMD.Parameters.Add("@date2", MySqlDbType.Date).Value = DateTimePicker2.Value
            READER = CMD.ExecuteReader()

            i = 0

            While READER.Read
                EMP_ID(i) = READER(0)
                i += 1
            End While
            conn.Close()

            For i = 0 To EMP_ID.Count - 1
                Call connect()
                query = "select emp_name from employee where emp_id = " & EMP_ID.ElementAt(0) & ""
                CMD = New MySqlCommand(query, conn)
                READER = CMD.ExecuteReader
                While READER.Read
                    EMP_NAME(i) = READER(0)
                    i += 1
                End While
                conn.Close()
            Next

            Call connect()
            query = "Select * from sales where cust_id = @cust_id and sales_date between @date1 and @date2"
            CMD = New MySqlCommand(query, conn)
            CMD.Parameters.Add("@cust_id", MySqlDbType.Int32).Value = c_id
            CMD.Parameters.Add("@date1", MySqlDbType.Date).Value = DateTimePicker1.Value
            CMD.Parameters.Add("@date2", MySqlDbType.Date).Value = DateTimePicker2.Value
            READER = CMD.ExecuteReader()

            Dim LIST As New ListViewItem
            ListView1.Items.Clear()
            i = 0
            While READER.Read
                LIST = ListView1.Items.Add(READER.GetString("bill_id"))
                LIST.SubItems.Add(CustomersName.ElementAt(i))
                LIST.SubItems.Add(EMP_NAME.ElementAt(i))
                LIST.SubItems.Add(READER.GetString("tot_amt"))
                LIST.SubItems.Add(READER.GetString("payment"))
                LIST.SubItems.Add(READER.GetDateTime("sales_date"))
                i = i + 1
            End While
            conn.Close()
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form5 As New Form5()
        form5.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AllSales()
    End Sub
End Class