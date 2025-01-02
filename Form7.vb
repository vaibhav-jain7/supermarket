Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class Form7

    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String
    Dim one As Integer = 0

    'GLOBAL VARIABLES 
    Dim ITM_CNT, QTY_CNT, TOT_AMT, ITM_DIS, ITM_SGST, ITM_CGST, ITM_GST As Double

    'DRAFT BILL NO.
    Dim Draft_id As Integer


    Public Sub MaxDraftId()
        Call connect()
        query = "select max(draft_id) from draft_bill"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        While READER.Read
            If READER(0).ToString = "" Then
                Draft_id = 201
            Else
                Draft_id = Val(READER(0) + 1)
            End If
        End While
        conn.Close()
    End Sub
    Public Sub MaxBillingID()
        Call connect()
        query = "select max(bill_id) from bill_data_details"
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
        CurrentBill = BILL_NO.Text
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'EMP_ID
        Label6.Text = emp

        'FORM CREATION DATE & TIME
        TODY_DATE.Text = Today

        'DISABLE MODIFY AND DELETE OPTION
        MODIFY.Enabled = False
        DELETE.Enabled = False

        'LOAD CUSTOMER INFO
        LoadCustomer()

        MaxBillingID()

        'LOAD DRAFT CUSTOMERS
        Call connect()
        query = "select c_name,c_phone from draft_bill_details"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        While READER.Read
            Dim value As String = READER(0) + "  " + READER(1)
            ComboBox1.Items.Add(value)
        End While
        conn.Close()

    End Sub

    Public Sub LoadCustomer()

        Call connect()
        query = "select * from customers where customer_id = '" & cust_id & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        While READER.Read

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
                query = "select p_qty,p_amt,p_dis,p_gst,p_mrp from bill_data where bill_id = '" & BILL_NO.Text & "' and p_id = '" & P_ID.Text & "'"
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
                    query = "update bill_data set p_qty = '" & quantity + Val(QTY.Text) & "', p_amt = '" & amt + newAmt & "' where bill_id = '" & BILL_NO.Text & "' and p_id = '" & P_ID.Text & "'"
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
                Countdata()

            End If
        Else
            MessageBox.Show("Fill All Fields")
            QTY.Focus()
        End If

    End Sub

    Public Sub LoadData()

        Call connect()
        query = "select * from bill_data where bill_id = '" & BILL_NO.Text & "'"
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
        '
        MaxDraftId()

        Call connect()
        query = "insert into draft_bill (draft_id, p_id, p_name, p_qty, p_mrp, p_dis, p_amt, p_gst) " &
                      "select '" & Draft_id & "' as draft_id, p_id, p_name, p_qty, p_mrp, p_dis, p_amt, p_gst " &
                      "from bill_data where bill_id = '" & BILL_NO.Text & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        conn.Close()


        Call connect()
        query = "insert into draft_bill_details values ('" & Draft_id & "','" & C_NAME.Text & "','" & C_EMAIL.Text & "','" & C_PH.Text & "','" & emp & "','" & cust_id & "')"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        conn.Close()

        'Delete From Original Table
        Call connect()
        query = "START TRANSACTION;" &
                            "DELETE FROM bill_data WHERE bill_id = '" & BILL_NO.Text & "';" &
                            "DELETE FROM bill_data_details WHERE bill_id = '" & BILL_NO.Text & "';" &
                            "COMMIT;"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        conn.Close()

        Dim form8 As New Form8()
        form8.Show()
        Me.Close()

    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox.Show("Under Develop.")

    End Sub

    Public Sub ClearProducts()
        P_ID.Clear()
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
            QTY.Text = ListView1.SelectedItems(0).SubItems(1).Text
            DISCOUNT.Text = ListView1.SelectedItems(0).SubItems(2).Text
            GST.Text = ListView1.SelectedItems(0).SubItems(3).Text
            MRP.Text = ListView1.SelectedItems(0).SubItems(4).Text
        End If

        QTY.Focus()

        Button1.Enabled = False
        MODIFY.Enabled = True
        DELETE.Enabled = True
    End Sub

    Private Sub MODIFY_Click(sender As Object, e As EventArgs) Handles MODIFY.Click

        Call connect()
        Dim newAmt As Double = (Val(MRP.Text) * (100 - Val(DISCOUNT.Text))) / 100
        newAmt = (newAmt * (100 + Val(GST.Text))) / 100

        query = "update bill_data set p_qty='" & QTY.Text & "',p_mrp='" & MRP.Text & "',p_gst=" & Val(GST.Text) & ",p_dis=" & Val(DISCOUNT.Text) & ",p_amt = " & Val(QTY.Text) * newAmt & " where p_name='" & P_NAME.Text & "' and bill_id ='" & BILL_NO.Text & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        conn.Close()

        MODIFY.Enabled = False
        DELETE.Enabled = False
        Button1.Enabled = True

        ClearProducts()
        LoadData()
        Countdata()
        P_ID.Focus()
    End Sub

    Private Sub DELETE_Click(sender As Object, e As EventArgs) Handles DELETE.Click
        Dim msg As Integer
        msg = MsgBox("Do you want to Delete item..", MsgBoxStyle.YesNo)

        Dim id As Integer

        Call connect()
        query = "select p_id from bill_data where p_name = '" & P_NAME.Text & "' and bill_id = '" & BILL_NO.Text & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        While READER.Read
            id = Val(READER(0))
        End While
        conn.Close()

        If msg = 6 Then 'If Yes msg bill be equal to 6 and If No it will be equal to 7
            Call connect()
            query = "delete from bill_data where p_id = '" & id & "' and bill_id = ' " & BILL_NO.Text & " '"
            CMD = New MySqlCommand(query, conn)
            READER = CMD.ExecuteReader
            conn.Close()

            LoadData()
            Countdata()
            ClearProducts()

            Button1.Enabled = True
            MODIFY.Enabled = False
            DELETE.Enabled = False

            P_ID.Focus()
        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form6 As New Form6()
        form6.Show()
        Me.Close()
    End Sub

    Public Sub LoadDraftData(number)

        Dim draftId As String
        Call connect()
        query = "select * from draft_bill_details"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader

        While READER.Read
            draftId = READER.GetInt32("draft_id")
            C_NAME.Text = READER.GetString("c_name")
            C_EMAIL.Text = READER.GetString("c_email")
            C_PH.Text = READER.GetString("c_phone")
            cust_id = READER.GetString("cust_id")
        End While
        conn.Close()

        '
        Call connect()
        query = "select * from draft_bill where draft_id = '" & draftId & "'"
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

        MaxBillingID()
        Countdata()

        Call connect()
        query = "insert into bill_data (bill_id, p_id, p_name, p_qty, p_mrp, p_dis, p_amt, p_gst) " &
                      "select '" & BILL_NO.Text & "' as bill_id, p_id, p_name, p_qty, p_mrp, p_dis, p_amt, p_gst " &
                      "from draft_bill where draft_id = '" & draftId & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        conn.Close()

        Call connect()
        query = "insert into bill_data_details values ('" & BILL_NO.Text & "', '" & cust_id & "', '" & emp & "','" & ITM_GST & "','" & ITM_DIS & "','" & TOT_AMT & "',curdate())"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        conn.Close()

        'Delete From Original Table
        Call connect()
        query = "START TRANSACTION;" &
                            "DELETE FROM draft_bill_details WHERE draft_id = '" & draftId & "';" &
                            "DELETE FROM draft_bill WHERE draft_id = '" & draftId & "';" &
                            "COMMIT;"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        conn.Close()

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim text As String = ComboBox1.Text
        Dim words As String() = text.Split(" "c)
        Dim number = words(words.Length - 1)

        LoadDraftData(number)



    End Sub

    Private Sub BILL_Click(sender As Object, e As EventArgs) Handles BILL.Click

        Call connect()
        query = "insert into bill_data_details values ('" & BILL_NO.Text & "','" & cust_id & "','" & emp & "','" & Label26.Text & "','" & Label24.Text & "','" & Label22.Text & "',current_date())"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        CurrentBill = BILL_NO.Text
        conn.Close()

        Dim form9 As New Form9()
        form9.Show()

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
            query = "select p_qty,p_amt,p_dis,p_gst,p_mrp from bill_data where bill_id = '" & BILL_NO.Text & "' and p_id = '" & P_ID.Text & "'"
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
                'newAmt = (newAmt * (100 + gst_)) / 100

                Call connect()
                query = "update bill_data set p_qty = '" & quantity + 1 & "', p_amt = '" & amt + newAmt & "' where bill_id = '" & BILL_NO.Text & "' and p_id = '" & P_ID.Text & "'"
                CMD = New MySqlCommand(query, conn)
                READER = CMD.ExecuteReader
                conn.Close()

            Else
                Dim newAmt As Double = (Val(MRP.Text) * (100 - Val(DISCOUNT.Text))) / 100
                'newAmt = (newAmt * (100 + Val(GST.Text))) / 100

                Call connect()
                query = "insert into bill_data values ( '" & BILL_NO.Text & "','" & P_ID.Text & "','" & P_NAME.Text & "','1','" & MRP.Text & "'," & Val(DISCOUNT.Text) & "," & newAmt & "," & Val(GST.Text) & ")"
                CMD = New MySqlCommand(query, conn)
                READER = CMD.ExecuteReader
                conn.Close()

            End If

            P_ID.Focus()
            LoadData()
            Countdata()

        End If

    End Sub

    Public Sub Countdata()
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
            QTY_CNT = QTY_CNT + Val(itm.SubItems(1).Text)

            Dim tot_dis As Double = (Val(itm.SubItems(4).Text) * (Val(itm.SubItems(2).Text) / 100)) * Val(itm.SubItems(1).Text)
            ITM_DIS = ITM_DIS + tot_dis

            'GST CALCULATION START
            j = (Val(itm.SubItems(4).Text) - (Val(itm.SubItems(4).Text) * (Val(itm.SubItems(2).Text) / 100)))
            ITM_GST = ITM_GST + ((j * (Val(itm.SubItems(3).Text) / 100)) * Val(itm.SubItems(1).Text))

            total_mrp += Val(itm.SubItems(4).Text) * Val(itm.SubItems(1).Text)
            TOT_AMT = (TOT_AMT + Val(itm.SubItems(5).Text))
        Next

        Label23.Text = QTY_CNT
        Label24.Text = Math.Round(ITM_DIS, 2)
        Label22.Text = Math.Round(TOT_AMT, 2)
        Label25.Text = "Rs. " & Math.Round(total_mrp, 2)
        Label26.Text = Math.Round(ITM_GST, 2)
        Label28.Text = "Rs. " & Math.Round(ITM_GST / 2, 2)
        Label30.Text = "Rs. " & Math.Round(ITM_GST / 2, 2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClearProducts()
        Button1.Enabled = True
        MODIFY.Enabled = False
        DELETE.Enabled = False
    End Sub

    Private Sub QTY_KeyUp(sender As Object, e As KeyEventArgs) Handles QTY.KeyUp
        If e.KeyValue = Keys.Enter Then

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
                    query = "select p_qty,p_amt,p_dis,p_gst,p_mrp from bill_data where bill_id = '" & BILL_NO.Text & "' and p_id = '" & P_ID.Text & "'"
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
                        query = "update bill_data set p_qty = '" & quantity + Val(QTY.Text) & "', p_amt = '" & amt + newAmt & "' where bill_id = '" & BILL_NO.Text & "' and p_id = '" & P_ID.Text & "'"
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
                    Countdata()

                End If
            Else
                MessageBox.Show("Fill All Fields")
                QTY.Focus()
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TIME.Text = TimeString
    End Sub
End Class