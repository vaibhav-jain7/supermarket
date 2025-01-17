Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class Form9

    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String

    Dim cust_id As String
    Dim sale As String
    Dim time As String
    Dim E_Name As String = "NAME SIRNAME"



    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'PRODUCT DETAILS
        Call connect()
        query = "select * from bill_data where bill_id = '" & CurrentBill & "'"
        'query = "select * from bill_data where bill_id = '20250001'"
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
        query = "select * from bill_data_details where bill_id = '" & CurrentBill & "'"
        'query = "select * from bill_data_details where bill_id = '20250001'"
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
        'query = "select * from customers where customer_id = '20251'"
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

    Private Sub CASHBYCUSTOMER_TextChanged(sender As Object, e As EventArgs) Handles CASHBYCUSTOMER.TextChanged
        CHANGEAMT.Text = Val(FINALAMT.Text) - Val(CASHBYCUSTOMER.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (PAYMENTMODE.Text = "CASH") Then
            MaxSaleID()
            Call connect()
            query = "insert into sales (sale_id,bill_id ,cust_id,emp_id ,tot_amt, payment,sales_date) values ('" & Val(sale) & "'," & CurrentBill & ", '" & cust_id & "', '" & emp & "','" & FINALAMT.Text & "', 'CASH',curdate())"
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
            query = "insert into sales (sale_id,bill_id ,cust_id,emp_id ,tot_amt, payment,sales_date) values ('" & Val(sale) & "'," & CurrentBill & ", '" & cust_id & "', '" & emp & "','" & FINALAMT.Text & "', 'UPI',curdate())"
            CMD = New MySqlCommand(query, conn)
            READER = CMD.ExecuteReader
            conn.Close()
            TOTALAMT.Enabled = False

        ElseIf (PAYMENTMODE.Text = "CARD") Then
            MaxSaleID()
            Call connect()
            query = "insert into sales (sale_id,bill_id ,cust_id,emp_id ,tot_amt, payment,sales_date) values ('" & Val(sale) & "'," & CurrentBill & ", '" & cust_id & "', '" & emp & "','" & FINALAMT.Text & "', 'CARD',curdate())"
            CMD = New MySqlCommand(query, conn)
            READER = CMD.ExecuteReader
            conn.Close()
            TOTALAMT.Enabled = False

        End If

        MessageBox.Show("Payment Done...", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim itemHeight As Integer = 20
        Dim itemCount As Integer = ListView1.Items.Count
        Dim columnCount As Integer = ListView1.Columns.Count

        Dim totalHeight As Integer = (itemHeight * itemCount + 150) * 2

        Dim columnWidth As Integer = 100
        Dim totalWidth As Integer = columnWidth * columnCount

        Call connect()
        query = "select emp_name from employee where emp_id = '" & emp & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        While READER.Read
            E_Name = READER(0)
        End While


        PD.DefaultPageSettings.PaperSize = New PaperSize("EZ BILL", totalWidth, totalHeight)
        PPD.Document = PD
        PPD.ShowDialog()

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form7 As New Form7()
        form7.Show()
        Me.Close()
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage

        Dim f8 As New Font("Calibri", 12, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 16, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 13, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String = " ********************************************************************** "

        ' Store details
        e.Graphics.DrawString("EZ STORE", f10, Brushes.Black, centermargin, 36, center)
        e.Graphics.DrawString("Tel +91-5544557788", f10, Brushes.Black, centermargin, 55, center)

        e.Graphics.DrawString("Invoice ID: EZ" & CurrentBill & "", f8, Brushes.Black, 0, 75)
        e.Graphics.DrawString("Cashier: " & E_Name & "", f8, Brushes.Black, 0, 90)
        e.Graphics.DrawString("TIME: " & DateString & " | " & TimeString & "", f8, Brushes.Black, 0, 105)

        ' --- Calculate column positions ---
        Dim pageWidth As Integer = e.PageBounds.Width
        Dim nameColumnWidth As Integer = CInt(pageWidth * 0.5) ' 50% width for Name column 
        Dim qtyColumnX As Integer = nameColumnWidth
        Dim discountColumnX As Integer = qtyColumnX + 50
        Dim totalColumnX As Integer = discountColumnX + 100 ' Total column after Discount

        ' --- Draw headers ---
        e.Graphics.DrawString("Name", f14, Brushes.Black, 0, 125)
        e.Graphics.DrawString("Qty", f14, Brushes.Black, qtyColumnX, 125)
        e.Graphics.DrawString("Discount", f14, Brushes.Black, discountColumnX, 125)
        e.Graphics.DrawString("TOTAL", f14, Brushes.Black, totalColumnX, 125)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 145)

        ' --- Variables for calculations ---
        Dim totalprice As Decimal = 0
        Dim totalGST As Decimal = 0
        Dim height As Integer = 0

        ' --- Listview Items ---
        For Each item As ListViewItem In ListView1.Items
            height += 15

            Dim discountVal As Double = 0
            ' --- Draw item details ---
            e.Graphics.DrawString(item.SubItems(0).Text, f8, Brushes.Black, 0, 140 + height)
            e.Graphics.DrawString(item.SubItems(1).Text, f8, Brushes.Black, qtyColumnX, 140 + height)
            discountVal = (((Val(item.SubItems(4).Text) * Val(item.SubItems(2).Text)) / 100) * Val(item.SubItems(1).Text))
            e.Graphics.DrawString(Math.Round(discountVal, 2), f8, Brushes.Black, discountColumnX, 140 + height)
            e.Graphics.DrawString(item.SubItems(5).Text, f8, Brushes.Black, totalColumnX, 140 + height)

            ' --- Calculate totals ---
            totalprice += Decimal.Parse(item.SubItems(5).Text)
        Next

        ' --- Draw line above totals ---
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 155 + height)

        ' --- Display total amount ---
        e.Graphics.DrawString("TOTAL : Rs. " & totalprice.ToString("F2") & "", f8, Brushes.Black, discountColumnX + 20, 165 + height)

        ' --- GST Table ---
        Dim gstTableStartY As Integer = 180 + height ' Adjust vertical position as needed
        e.Graphics.DrawString("-------------------- GST Details --------------------", f10b, Brushes.Black, centermargin - 148, gstTableStartY + 10)
        'e.Graphics.DrawString("--------------------", f8, Brushes.Black, 0, gstTableStartY + 15)

        e.Graphics.DrawString("Name", f14, Brushes.Black, 0, gstTableStartY + 30)
        e.Graphics.DrawString("Qty", f14, Brushes.Black, qtyColumnX, gstTableStartY + 30)
        e.Graphics.DrawString("GST", f14, Brushes.Black, discountColumnX, gstTableStartY + 30)
        e.Graphics.DrawString("TOTAL", f14, Brushes.Black, totalColumnX, gstTableStartY + 30)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, gstTableStartY + 50)


        '... Add logic to display GST details for each product ...
        ' ... Example
        For Each item As ListViewItem In ListView1.Items
            gstTableStartY += 15
            Dim GSTval As Double = 0
            ' --- Draw item details ---
            e.Graphics.DrawString(item.SubItems(0).Text, f8, Brushes.Black, 0, 45 + gstTableStartY)
            e.Graphics.DrawString(item.SubItems(1).Text, f8, Brushes.Black, qtyColumnX, 45 + gstTableStartY)
            GSTval = (Val(item.SubItems(4).Text) * (Val(item.SubItems(3).Text))) / 100
            e.Graphics.DrawString(Math.Round(GSTval, 2), f8, Brushes.Black, discountColumnX, 45 + gstTableStartY)
            GSTval = (GSTval * Val(item.SubItems(1).Text))
            e.Graphics.DrawString(Math.Round(GSTval, 2), f8, Brushes.Black, totalColumnX, 45 + gstTableStartY)
            totalGST += GSTval
        Next

        ' --- Draw line above totals ---
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 65 + gstTableStartY)

        ' --- Display Total GST ---
        e.Graphics.DrawString("Total GST: " & totalGST.ToString("F2"), f8, Brushes.Black, discountColumnX + 27, gstTableStartY + 80) ' Adjust vertical position as needed

        ' --- Thank You message ---
        e.Graphics.DrawString("Thank you for shopping with us!", f8, Brushes.Black, centermargin, gstTableStartY + 120, center)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time = TimeString
    End Sub

    Private Sub PPD_Closed(sender As Object, e As EventArgs) Handles PPD.Closed

        Call connect()
        query = "select min(draft_id) from draft_bill"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        While READER.Read
            If READER(0).ToString = "" Then
                CurrentBillState = True
                PendingBill = False
            Else
                CurrentBillState = False
                PendingBill = True
            End If
        End While
        conn.Close()

        If PendingBill And CurrentBillState = False Then
            Dim form7 As New Form7()
            form7.Show()
        Else
            Dim form8 As New Form8()
            form8.Show()
        End If
        Me.Close()
    End Sub
End Class