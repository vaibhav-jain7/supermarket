Imports System.Data.SqlClient
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

        'Modify And Delete Buttons Will Be False on Start
        Button3.Enabled = False
        Button4.Enabled = False
    End Sub

    Public Sub ClearTextBoxes()
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

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        ' QUERY TO FETCH PRODUCT TABLE AND DISPLAY ON FORM LOAD
        query = "select * from products"
        CMD = New MySqlCommand(query, conn)
        SDA.SelectCommand = CMD
        SDA.Fill(dbDataSet)
        bSource.DataSource = dbDataSet
        DataGridView1.DataSource = bSource
        SDA.Update(dbDataSet)

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
            ClearTextBoxes()
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
                ClearTextBoxes()
                conn.Close()
            Else
                MessageBox.Show("Fill All Fields")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearTextBoxes()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim r As DataGridViewRow
            r = Me.DataGridView1.Rows(e.RowIndex)
            P_ID.Text = r.Cells("product_id").Value.ToString
            P_NAME.Text = r.Cells("product_name").Value.ToString
            Brand.Text = r.Cells("product_brand").Value.ToString
            C_NAME.Text = r.Cells("category_name").Value.ToString
            STK_QTY.Text = r.Cells("stock_qty").Value.ToString
            PUR_PRICE.Text = r.Cells("purchase_p").Value.ToString
            MRP.Text = r.Cells("mrp").Value.ToString
            HSN.Text = r.Cells("hsn_code").Value.ToString
            DIS.Text = r.Cells("discount").Value.ToString
            Button3.Enabled = True
            Button4.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call connect()
        query = "update super_market.products set product_name='" & P_NAME.Text & "',product_brand='" & Brand.Text & "',category_name= '" & C_NAME.Text & "',stock_qty='" & STK_QTY.Text & "',purchase_p='" & PUR_PRICE.Text & "',mrp='" & MRP.Text & "',hsn_code=" & Val(HSN.Text) & ",discount=" & Val(DIS.Text) & " where product_id='" & P_ID.Text & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        'SHOW PRODUCT TABLE AFTER ADDING NEW PRODUCT
        ShowProductTable()
        'CALL AUTOINCREMENT FUNCTION TO SET PRODUCT_ID 
        AutoIncrementId()
        'CLEAR ALL FORM FEILDS AFTER ADDINF PRODUCT
        ClearTextBoxes()
        'Modify And Delete Buttons
        Button3.Enabled = False
        Button4.Enabled = False
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call connect()
        query = "delete from super_market.products where product_id='" & P_ID.Text & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        'SHOW PRODUCT TABLE AFTER ADDING NEW PRODUCT
        ShowProductTable()
        'CALL AUTOINCREMENT FUNCTION TO SET PRODUCT_ID 
        AutoIncrementId()
        'CLEAR ALL FORM FEILDS AFTER ADDINF PRODUCT
        ClearTextBoxes()
        'Modify And Delete Buttons
        Button3.Enabled = False
        Button4.Enabled = False
    End Sub
End Class
