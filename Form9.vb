Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class Form9

    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String

    Dim cust_id As String
    Dim sale As String
    Dim time As String


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

        PrintDoc.DefaultPageSettings.PaperSize = New PaperSize("MySize", 800, ListView1.Items.Count * 100)
        'PPD.PrintPreviewControl.Zoom = 0.5
        PPD.Document = PrintDoc
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

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage

        'Dim f8 As New Font("Arial", 15, FontStyle.Bold)
        'Dim f8b As New Font("Verdana", 12, FontStyle.Bold)

        'Dim left As New StringFormat
        'Dim center As New StringFormat
        'Dim right As New StringFormat

        'left.Alignment = StringAlignment.Near
        'center.Alignment = StringAlignment.Center
        'right.Alignment = StringAlignment.Far

        'Dim Rect1 As New Rectangle(5, 5, 600, 25)
        'e.Graphics.DrawString("EZ MARKET", f8, Brushes.Black, Rect1, center)

        'Dim Rect2 As New Rectangle(5, 30, 600, 25)
        'e.Graphics.DrawString("Dezyne E'cole College, Ajmer", f8b, Brushes.Black, Rect2, center)

        'Dim Rect3 As New Rectangle(5, 55, 600, 25)
        'e.Graphics.DrawString("Telephone: +91 9999999999", f8b, Brushes.Black, Rect3, center)

        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PrintDoc.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PrintDoc.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PrintDoc.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "****************************************************************"

        'range from top
        'logo
        'Dim logoImage As Image = My.Resources.ResourceManager.GetObject("logo")
        'e.Graphics.DrawImage(logoImage, CInt((e.PageBounds.Width - 150) / 2), 5, 150, 35)

        'e.Graphics.DrawImage(logoImage, 0, 250, 150, 50)
        'e.Graphics.DrawImage(logoImage, CInt((e.PageBounds.Width - logoImage.Width) / 2), CInt((e.PageBounds.Height - logoImage.Height) / 2), logoImage.Width, logoImage.Height)

        'e.Graphics.DrawString("Store :", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("EZ MARKET", f10, Brushes.Black, centermargin, 40, center)
        e.Graphics.DrawString("Tel +91 9999999999", f10, Brushes.Black, centermargin, 55, center)

        e.Graphics.DrawString("Invoice ID", f8, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 75)
        e.Graphics.DrawString(CurrentBill, f8, Brushes.Black, 70, 75)

        e.Graphics.DrawString("Cashier", f8, Brushes.Black, 0, 85)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 85)
        e.Graphics.DrawString("Steve Jobs", f8, Brushes.Black, 70, 85)

        e.Graphics.DrawString("" & DateString & " | " & time & "", f8, Brushes.Black, 0, 95)
        'DetailHeader
        e.Graphics.DrawString("Qty", f8, Brushes.Black, 0, 110)
        e.Graphics.DrawString("Item", f8, Brushes.Black, 25, 110)
        e.Graphics.DrawString("Price", f8, Brushes.Black, 180, 110, right)
        e.Graphics.DrawString("Total", f8, Brushes.Black, rightmargin, 110, right)
        '
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 120)

        Dim height As Integer 'DGV Position
        'Dim i As Long
        'DataGridView1.AllowUserToAddRows = False
        ''If DataGridView1.CurrentCell.Value Is Nothing Then
        ''    Exit Sub
        ''Else
        'For row As Integer = 0 To ListView1.Items.Count - 1
        '    height += 15
        '    e.Graphics.DrawString(ListView1..Rows(row).Cells(1).Value.ToString, f8, Brushes.Black, 0, 115 + height)
        '    e.Graphics.DrawString(DataGridView1.Rows(row).Cells(0).Value.ToString, f8, Brushes.Black, 25, 115 + height)
        '    i = DataGridView1.Rows(row).Cells(2).Value
        '    DataGridView1.Rows(row).Cells(2).Value = Format(i, "##,##0")
        '    e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString, f8, Brushes.Black, 180, 115 + height, right)

        '    'totalprice
        '    Dim totalprice As Long
        '    totalprice = Val(DataGridView1.Rows(row).Cells(1).Value * DataGridView1.Rows(row).Cells(2).Value)
        '    e.Graphics.DrawString(totalprice.ToString("##,##0"), f8, Brushes.Black, rightmargin, 115 + height, right)
        '    '

        'Next
        'End If

        Dim height2 As Integer
        height2 = 145 + height

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("Total: " & TOTALAMT.Text & "", f10b, Brushes.Black, rightmargin, 10 + height2, right)
        'e.Graphics.DrawString(t_qty, f10b, Brushes.Black, 0, 10 + height2)

        e.Graphics.DrawString("~ Thanks for shopping ~", f10, Brushes.Black, centermargin, 70 + height2, center)
        e.Graphics.DrawString("~ Nosware Store ~", f10, Brushes.Black, centermargin, 85 + height2, center)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time = TimeString
    End Sub
End Class