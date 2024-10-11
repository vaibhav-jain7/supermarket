'Imports System.IO.Pipelines
'Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
'Imports Mysqlx.Crud
'Imports Mysqlx.Prepare

Public Class Form7

    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String
    Dim one As Integer = 0

    'GLOBAL VARIABLES 
    Dim ITM_CNT, QTY_CNT, TOT_AMT, ITM_DIS, ITM_SGST, ITM_CGST, ITM_GST As Double

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

        ListView1.Columns.Add("Name", 190, HorizontalAlignment.Center)
        ListView1.Columns.Add("Category", 190, HorizontalAlignment.Center)
        ListView1.Columns.Add("Quantity", 190, HorizontalAlignment.Center)
        ListView1.Columns.Add("Discount", 190, HorizontalAlignment.Center)
        ListView1.Columns.Add("GST", 180, HorizontalAlignment.Center)
        ListView1.Columns.Add("MRP", 180, HorizontalAlignment.Center)
        ListView1.Columns.Add("Total Amount", 190, HorizontalAlignment.Center)
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
                PRO.SubItems.Add(QTY.Text)

                Dim amt As Double = Val(MRP.Text) * Val(QTY.Text)
                amt = amt - (amt * Val((DISCOUNT.Text) / 100))
                'amt = (amt + (amt * (Val(GST.Text) / 100)))
                PRO.SubItems.Add(DISCOUNT.Text)
                PRO.SubItems.Add(GST.Text)
                PRO.SubItems.Add(Val(MRP.Text))
                PRO.SubItems.Add(amt)

                Call connect()
                'ADDING PRODUCT INTO BILL DATA TABLE
                query = "insert into bill_data_details values ( '" & BILL_NO.Text & "','" & C_ID.Text & "','" & Label6.Text & "','" & P_NAME.Text & "','" & QTY.Text & "','" & MRP.Text & "'," & Val(GST.Text) & "," & Val(GST.Text) & "," & Val(DIS.Text) & ",curdate(),curdate())"
                CMD = New MySqlCommand(query, conn)
                READER = CMD.ExecuteReader
                'INCREMENT CUSTOMER ID
                AutoCustomerIncrementId()
                conn.Close()

                'CLEAR AFTER EACH PRODUCT ENTRY
                ClearProducts()

                P_NAME.Focus()
                countdata()

            End If
        Else
            MessageBox.Show("Fill All Fields")
            QTY.Focus()
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MessageBox.Show("Under Develop.")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MessageBox.Show("Under Develop.")

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MessageBox.Show("Under Develop.")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox.Show("Under Develop.")

    End Sub

    Public Sub ClearProducts()
        P_NAME.Clear()
        QTY.Clear()
        CATEGORY.Text = ""
        MRP.Clear()
        GST.Clear()
        DISCOUNT.Clear()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            P_NAME.Text = ListView1.SelectedItems(0).SubItems(0).Text
            QTY.Text = ListView1.SelectedItems(0).SubItems(2).Text
            CATEGORY.Text = ListView1.SelectedItems(0).SubItems(1).Text
            MRP.Text = ListView1.SelectedItems(0).SubItems(5).Text
            GST.Text = ListView1.SelectedItems(0).SubItems(4).Text
            DISCOUNT.Text = ListView1.SelectedItems(0).SubItems(3).Text
        End If
        MODIFY.Enabled = True
        DELETE.Enabled = True
    End Sub

    Private Sub MODIFY_Click(sender As Object, e As EventArgs) Handles MODIFY.Click
        Call connect()
        query = "update super_market.bill_data_details set bill_id ='" & BILL_NO.Text & "',c_id='" & C_ID.Text & "',emp_id= '" & Label6.Text & "',p_name='" & P_NAME.Text & "',p_qty='" & QTY.Text & "',mrp='" & MRP.Text & "',p_gst=" & Val(GST.Text) & ",p_amt=" & Val(GST.Text) & ",p_dis=" & Val(DIS.Text) & " where p_name='" & P_NAME.Text & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        'Modify And Delete Buttons
        MODIFY.Enabled = False
        DELETE.Enabled = False
        conn.Close()
        ListView1.FocusedItem.SubItems(2).Text = QTY.Text
        ListView1.Refresh()
        ClearProducts()
        P_NAME.Focus()
    End Sub

    Private Sub DELETE_Click(sender As Object, e As EventArgs) Handles DELETE.Click
        Call connect()
        query = "delete from super_market.bill_data_details where p_name='" & P_NAME.Text & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        Dim m As Integer
        m = MsgBox("Do you want to Delete item..", MsgBoxStyle.YesNo)
        If m = 6 Then
            ListView1.FocusedItem.Remove()
        End If
        MODIFY.Enabled = False
        DELETE.Enabled = False
        conn.Close()
        ClearProducts()
        P_NAME.Focus()
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
        ListView1.Refresh()
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

    Public Sub countdata()
        Label33.Text = ListView1.Items.Count
        Dim i As Integer
        Dim itm As ListViewItem
        QTY_CNT = 0
        ITM_DIS = 0
        TOT_AMT = 0
        ITM_CGST = 0
        ITM_SGST = 0
        ITM_GST = 0
        Dim total_mrp As Double = 0

        For i = 0 To ListView1.Items.Count - 1
            itm = ListView1.Items(i)
            QTY_CNT = QTY_CNT + Val(itm.SubItems(2).Text)
            Dim tot_dis As Double = (Val(itm.SubItems(5).Text) * (Val(itm.SubItems(3).Text) / 100)) * Val(itm.SubItems(2).Text)
            ITM_DIS = ITM_DIS + tot_dis
            total_mrp += Val(itm.SubItems(5).Text) * Val(itm.SubItems(2).Text)
            'TOT_AMT = TOT_AMT + Val(itm.SubItems(6).Text)
            ITM_GST = ITM_GST + (Val(itm.SubItems(5).Text) * (Val(itm.SubItems(4).Text) / 100)) * Val(itm.SubItems(2).Text)
            'ITM_SGST = ITM_SGST + Val(itm.SubItems(6).Text)
            'ITM_CGST = ITM_CGST + Val(itm.SubItems(7).Text)
        Next
        Label23.Text = QTY_CNT
        Label24.Text = "Rs. " & ITM_DIS.ToString()
        'TextBox5.Text = TOT_AMT - (ITM_CGST + ITM_SGST)
        'TextBox6.Text = ITM_SGST
        'TextBox7.Text = ITM_CGST
        Label25.Text = "Rs. " & total_mrp
        Label26.Text = "Rs. " & ITM_GST
        Label22.Text = "Rs. " & TOT_AMT.ToString()
        Label28.Text = "Rs. " & ITM_GST / 2
        Label30.Text = "Rs. " & ITM_GST / 2
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TIME.Text = TimeString
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClearProducts()
        ClearTextBoxes()
        MODIFY.Enabled = False
        DELETE.Enabled = False
    End Sub
End Class