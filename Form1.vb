Imports MySql.Data.MySqlClient

Public Class Form1

    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call connect()
        ' QUERY TO ADD CATEGORY NAME TO COMBBOX1(C_NAME)
        C_NAME.Items.Clear()
        query = "select * from pro_categories"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        While READER.Read
            C_NAME.Items.Add(READER.GetString("category_name"))
        End While
        conn.Close()

        'FUNCTION TO GET PRODUCT TABLE AND CATEGORY TO THE FORM ON LOAD
        ShowProductTable()

        'SET INVENTORY LABEL TO TODAY'S DATE
        IVY_DATE.Text = Today

        'CALL AUTOINCREMENT FUNCTION TO SET PRODUCT_ID WHEN FORM LOAD
        AutoIncrementId()
    End Sub
    Public Sub cleartextboxes()
        P_NAME.Clear()
        Brand.Clear()
        PUR_PRICE.Clear()
        STK_QTY.Clear()
        C_NAME.Text = ""
        MRP.Clear()
        HSN.Clear()
        DIS.Clear()
        P_NAME.Focus()
    End Sub

    Public Sub AutoIncrementId()
        Call connect()
        query = "select max(product_id) from products"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        While READER.Read
            P_ID.Text = Val(READER(0) + 1)
        End While
        conn.Close()
    End Sub

    Public Sub ShowProductTable()
        Call connect()
        ListView1.Items.Clear()
        ' QUERY TO FETCH PRODUCT TABLE AND DISPLAY ON FORM LOAD
        query = "select * from products"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        While READER.Read
            Dim PRO As ListViewItem
            PRO = ListView1.Items.Add(READER(0))
            PRO.SubItems.Add(READER(1))
            PRO.SubItems.Add(READER(2))
            PRO.SubItems.Add(READER(3))
            PRO.SubItems.Add(READER(4))
            PRO.SubItems.Add(READER(5))
            PRO.SubItems.Add(READER(6))
            PRO.SubItems.Add(READER(7))
            PRO.SubItems.Add(READER(8))
            PRO.SubItems.Add(READER(9))
        End While
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Len(P_NAME.Text) <> 0 And Len(Brand.Text) <> 0 And Len(C_NAME.Text) <> 0 And Len(STK_QTY.Text) <> 0 And Len(PUR_PRICE.Text) <> 0 And Len(MRP.Text) <> 0 And Len(HSN.Text) <> 0 And Len(DIS.Text) <> 0 Then
            Call connect()
            query = "insert into products values ('" & P_ID.Text & "','" & P_NAME.Text & "','" & Brand.Text & "', '" & C_NAME.Text & "','" & STK_QTY.Text & "','" & PUR_PRICE.Text & "','" & MRP.Text & "'," & Val(HSN.Text) & "," & Val(DIS.Text) & ",curdate())"
            CMD = New MySqlCommand(query, conn)
            READER = CMD.ExecuteReader
            'SHOW PRODUCT TABLE AFTER ADDING NEW PRODUCT
            ShowProductTable()
            'CALL AUTOINCREMENT FUNCTION TO SET PRODUCT_ID 
            AutoIncrementId()
            'CLEAR ALL FORM FEILDS AFTER ADDINF PRODUCT
            cleartextboxes()
            conn.Close()
        Else
            MessageBox.Show("Fill All Fields")
        End If
    End Sub

    Private Sub DIS_KeyUp(sender As Object, e As KeyEventArgs) Handles DIS.KeyUp
        If e.KeyValue = Keys.Enter Then
            If Len(P_NAME.Text) <> 0 And Len(Brand.Text) <> 0 And Len(C_NAME.Text) <> 0 And Len(STK_QTY.Text) <> 0 And Len(PUR_PRICE.Text) <> 0 And Len(MRP.Text) <> 0 And Len(HSN.Text) <> 0 And Len(DIS.Text) <> 0 Then
                Call connect()
                query = "insert into products values ('" & P_ID.Text & "','" & P_NAME.Text & "','" & Brand.Text & "', '" & C_NAME.Text & "','" & STK_QTY.Text & "','" & PUR_PRICE.Text & "','" & MRP.Text & "'," & Val(HSN.Text) & "," & Val(DIS.Text) & ",curdate())"
                CMD = New MySqlCommand(query, conn)
                READER = CMD.ExecuteReader
                'SHOW PRODUCT TABLE AFTER ADDING NEW PRODUCT
                ShowProductTable()
                'CALL AUTOINCREMENT FUNCTION TO SET PRODUCT_ID 
                AutoIncrementId()
                'CLEAR ALL FORM FEILDS AFTER ADDINF PRODUCT
                cleartextboxes()
                conn.Close()
            Else
                MessageBox.Show("Fill All Fields")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        cleartextboxes()
    End Sub
End Class
