Imports MySql.Data.MySqlClient

Public Class Form7

    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String
    Dim one As Integer = 0

    'GLOBAL VARIABLES 
    Dim ITM_CNT, QTY_CNT, TOT_AMT, ITM_DIS, ITM_SGST, ITM_CGST, ITM_GST As Double

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'EMP_ID
        Label6.Text = emp

        'INCREMENT CUSTOMER ID
        'AutoCustomerIncrementId()

        'FORM CREATION DATE & TIME
        TODY_DATE.Text = Today

        'DISABLE MODIFY AND DELETE OPTION
        MODIFY.Enabled = False
        DELETE.Enabled = False

        'LOAD CUSTOMER INFO
        LoadCustomer()

        Call connect()

        query = "select max(bill_id) from biling_details"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        While READER.Read
            If READER(0).ToString = "" Then
                BILL_NO.Text = 20250001
            Else
                BILL_NO.Text = Val(READER(0) + 1)
            End If
        End While
        conn.Close()


    End Sub

    Public Sub LoadCustomer()
        Call connect()

        query = "select * from customers where customer_id = '" & cust_id & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        While READER.Read

            C_ID.Text = READER.GetString("customer_id")
            C_NAME.Text = READER.GetString("customer_name")
            C_EMAIL.Text = READER.GetString("email")
            C_PH.Text = READER.GetString("ph_no")

        End While


        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If QTY.Text <> "" Then
            If Val(QTY.Text) = 0 Then
                MessageBox.Show("Value Can't be Zero")
            Else

                Dim check As Boolean = False
                Dim quantity As Integer = 1
                Dim amt As Double
                Dim dis As Double
                Dim mrp_ As Double
                Dim gst_ As Double

                Call connect()
                query = "select p_qty,p_amt,p_dis,p_gst,p_mrp from bill_data where bill_no = '" & BILL_NO.Text & "' and p_id = '" & P_ID.Text & "'"
                CMD = New MySqlCommand(query, conn)
                READER = CMD.ExecuteReader

                While READER.Read
                    check = True
                    quantity = Val(READER(0))
                    amt = Val(READER(1))
                    dis = Val(READER(2))
                    gst_ = Val(READER(3))
                    mrp_ = Val(READER(4))
                End While
                conn.Close()

                If check Then

                    Dim newAmt As Double = (mrp_ * (100 - dis)) / 100
                    newAmt = (Val(QTY.Text) * (newAmt * (100 + gst_)) / 100)

                    Call connect()
                    query = "update bill_data set p_qty = '" & quantity + Val(QTY.Text) & "', p_amt = '" & amt + newAmt & "' where bill_no = '" & BILL_NO.Text & "' and p_id = '" & P_ID.Text & "'"
                    CMD = New MySqlCommand(query, conn)
                    READER = CMD.ExecuteReader
                    conn.Close()

                Else
                    Dim newAmt As Double = (Val(MRP.Text) * (100 - Val(DISCOUNT.Text))) / 100
                    newAmt = (newAmt * (100 + Val(GST.Text))) / 100

                    Call connect()
                    query = "insert into bill_data values ( '" & BILL_NO.Text & "','" & P_ID.Text & "','" & P_NAME.Text & "','1','" & MRP.Text & "'," & Val(DISCOUNT.Text) & "," & newAmt & "," & Val(GST.Text) & ")"
                    CMD = New MySqlCommand(query, conn)
                    READER = CMD.ExecuteReader
                    conn.Close()

                End If

                P_ID.Focus()
                LoadData()
                countdata()

            End If
        Else
            MessageBox.Show("Fill All Fields")
            QTY.Focus()
        End If

    End Sub

    Public Sub LoadData()

        Call connect()
        query = "select * from bill_data where bill_no = '" & BILL_NO.Text & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        Dim PRO As ListViewItem
        ListView1.Items.Clear()

        While READER.Read
            PRO = ListView1.Items.Add(READER.GetString("p_name"))
            PRO.SubItems.Add(READER.GetString("p_qty"))

            PRO.SubItems.Add(READER.GetString("p_dis"))
            PRO.SubItems.Add(READER.GetString("p_gst"))
            PRO.SubItems.Add(READER.GetString("p_mrp"))
            PRO.SubItems.Add(READER.GetString("p_amt"))

        End While

        conn.Close()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MessageBox.Show("Under Develop.")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MessageBox.Show("Under Develop.")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox.Show("Under Develop.")

    End Sub

    Public Sub ClearProducts()
        P_NAME.Text = ""
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
            MRP.Text = ListView1.SelectedItems(0).SubItems(5).Text
            GST.Text = ListView1.SelectedItems(0).SubItems(4).Text
            DISCOUNT.Text = ListView1.SelectedItems(0).SubItems(3).Text
        End If
        MODIFY.Enabled = True
        DELETE.Enabled = True
    End Sub

    Private Sub MODIFY_Click(sender As Object, e As EventArgs) Handles MODIFY.Click
        Call connect()

        query = "update super_market.biling_details set bill_id ='" & BILL_NO.Text & "',c_id='" & C_ID.Text & "',emp_id= '" & Label6.Text & "',p_name='" & P_NAME.Text & "',p_qty='" & QTY.Text & "',mrp='" & MRP.Text & "',p_gst=" & Val(GST.Text) & ",p_amt=" & Val(GST.Text) & ",p_dis=" & Val(DIS.Text) & " where p_name='" & P_NAME.Text & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        'Modify And Delete Buttons
        MODIFY.Enabled = False
        DELETE.Enabled = False

        conn.Close()

        ListView1.FocusedItem.SubItems(2).Text = QTY.Text
        ListView1.Refresh()

        ClearProducts()
        countdata()
        P_NAME.Focus()
    End Sub

    Private Sub DELETE_Click(sender As Object, e As EventArgs) Handles DELETE.Click
        Call connect()
        query = "delete from super_market.biling_details where p_name= '" & P_NAME.Text & "'"
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
        countdata()
        P_NAME.Focus()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub BILL_Click(sender As Object, e As EventArgs) Handles BILL.Click

        Call connect()

        query = "insert into biling_details values ('" & BILL_NO.Text & "','" & C_ID.Text & "','" & emp & "','" & Label22.Text & "','" & Label26.Text & "','" & Label24.Text & "',current_date(), TIME_FORMAT(current_time(), '%h %i %s %p'))"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        conn.Close()

    End Sub

    Private Sub P_ID_TextChanged(sender As Object, e As EventArgs) Handles P_ID.TextChanged

        Call connect()
        query = "select * from products where product_id = " & Val(P_ID.Text) & ""
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        Dim count As Integer = 0
        While READER.Read
            P_NAME.Text = READER.GetString("product_name")
            CATEGORY.Text = READER.GetString("category_name")
            MRP.Text = READER.GetDouble("mrp")
            GST.Text = READER.GetDouble("gst")
            DISCOUNT.Text = READER.GetDouble("discount").ToString
            QTY.Text = 1
            count = count + 1
        End While
        conn.Close()

        If count = 1 Then
            Dim check As Boolean = False
            Dim quantity As Integer = 1
            Dim amt As Double
            Dim dis As Double
            Dim mrp_ As Double
            Dim gst_ As Double

            Call connect()
            query = "select p_qty,p_amt,p_dis,p_gst,p_mrp from bill_data where bill_no = '" & BILL_NO.Text & "' and p_id = '" & P_ID.Text & "'"
            CMD = New MySqlCommand(query, conn)
            READER = CMD.ExecuteReader

            While READER.Read
                check = True
                quantity = Val(READER(0))
                amt = Val(READER(1))
                dis = Val(READER(2))
                gst_ = Val(READER(3))
                mrp_ = Val(READER(4))
            End While
            conn.Close()

            If check Then

                Dim newAmt As Double = (mrp_ * (100 - dis)) / 100
                newAmt = (newAmt * (100 + gst_)) / 100

                Call connect()
                query = "update bill_data set p_qty = '" & quantity + 1 & "', p_amt = '" & amt + newAmt & "' where bill_no = '" & BILL_NO.Text & "' and p_id = '" & P_ID.Text & "'"
                CMD = New MySqlCommand(query, conn)
                READER = CMD.ExecuteReader
                conn.Close()

            Else
                Dim newAmt As Double = (Val(MRP.Text) * (100 - Val(DISCOUNT.Text))) / 100
                newAmt = (newAmt * (100 + Val(GST.Text))) / 100

                Call connect()
                query = "insert into bill_data values ( '" & BILL_NO.Text & "','" & P_ID.Text & "','" & P_NAME.Text & "','1','" & MRP.Text & "'," & Val(DISCOUNT.Text) & "," & newAmt & "," & Val(GST.Text) & ")"
                CMD = New MySqlCommand(query, conn)
                READER = CMD.ExecuteReader
                conn.Close()

            End If

            P_ID.Focus()
            LoadData()

        End If

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
        Dim j As Double = 0


        For i = 0 To ListView1.Items.Count - 1
            itm = ListView1.Items(i)
            QTY_CNT = QTY_CNT + Val(itm.SubItems(2).Text)
            Dim tot_dis As Double = (Val(itm.SubItems(5).Text) * (Val(itm.SubItems(3).Text) / 100)) * Val(itm.SubItems(2).Text)
            ITM_DIS = ITM_DIS + tot_dis

            'GST CALCULATION START
            j = Val(itm.SubItems(5).Text) - ((Val(itm.SubItems(5).Text) * (Val(itm.SubItems(3).Text) / 100)))
            'itm.SubItems(5).Text = j

            total_mrp += Val(itm.SubItems(5).Text) * Val(itm.SubItems(2).Text)
            TOT_AMT = (TOT_AMT + (j * Val(itm.SubItems(2).Text)))
            ITM_GST = ITM_GST + (j * (Val(itm.SubItems(4).Text) / 100)) * Val(itm.SubItems(2).Text)
        Next

        Label23.Text = QTY_CNT
        Label24.Text = ITM_DIS.ToString()
        Label22.Text = TOT_AMT
        Label25.Text = "Rs. " & total_mrp
        Label26.Text = ITM_GST
        Label28.Text = "Rs. " & ITM_GST / 2
        Label30.Text = "Rs. " & ITM_GST / 2
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TIME.Text = TimeString
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClearProducts()
        MODIFY.Enabled = False
        DELETE.Enabled = False
    End Sub

    Private Sub QTY_KeyUp(sender As Object, e As KeyEventArgs) Handles QTY.KeyUp
        If e.KeyValue = Keys.Enter Then

            If QTY.Text <> "" Then
                If Val(QTY.Text) = 0 Or Val(MRP.Text) = 0 Or Val(GST.Text) = 0 Or Val(DISCOUNT.Text) = 0 Then
                    MessageBox.Show("Value Can't be Zero")
                Else
                    Dim j As Double = 0
                    Dim PRO As ListViewItem
                    PRO = ListView1.Items.Add(P_NAME.Text.ToUpper)
                    PRO.SubItems.Add(CATEGORY.Text)
                    PRO.SubItems.Add(QTY.Text)

                    Dim amt As Double '= Val(MRP.Text) * Val(QTY.Text)

                    'amt = amt - (amt * Val((DISCOUNT.Text) / 100))
                    'amt = (amt + (amt * (Val(GST.Text) / 100)))

                    PRO.SubItems.Add(DISCOUNT.Text)
                    PRO.SubItems.Add(GST.Text)
                    PRO.SubItems.Add(Val(MRP.Text))
                    j = Val(PRO.SubItems(5).Text) - ((Val(PRO.SubItems(5).Text) * (Val(PRO.SubItems(3).Text) / 100)))
                    amt = j * Val(PRO.SubItems(2).Text)
                    PRO.SubItems.Add(amt)

                    Call connect()
                    'ADDING PRODUCT INTO BILL DATA TABLE
                    query = "insert into biling_details values ( '" & BILL_NO.Text & "','" & C_ID.Text & "','" & Label6.Text & "','" & P_NAME.Text & "','" & QTY.Text & "','" & MRP.Text & "'," & Val(GST.Text) & "," & Val(GST.Text) & "," & Val(DIS.Text) & ",curdate(),curdate())"
                    CMD = New MySqlCommand(query, conn)
                    READER = CMD.ExecuteReader

                    'INCREMENT CUSTOMER ID
                    'AutoCustomerIncrementId()

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
        End If
    End Sub
End Class