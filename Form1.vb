Imports System.Windows.Forms.VisualStyles.VisualStyleElement
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
    End Sub
    Public Sub cleartextboxes()
        P_ID.Clear()
        P_NAME.Clear()
        Brand.Clear()
        PUR_PRICE.Clear()
        STK_QTY.Clear()
        C_NAME.Text = ""
        MRP.Clear()
        HSN.Clear()
        DIS.Clear()
        P_ID.Focus()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call connect()
        MessageBox.Show("Server Response 200 Connection is Nice")
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListView1.Items.Count > 0 Then
            If Len(P_NAME.Text) <> 0 And Len(Brand.Text) <> 0 And Len(C_NAME.Text) <> 0 And Len(STK_QTY.Text) <> 0 And Len(PUR_PRICE.Text) <> 0 And Len(MRP.Text) <> 0 And Len(HSN.Text) <> 0 And Len(DIS.Text) <> 0 Then
                Call connect()
                query = "insert into products values ('" & P_ID.Text & "','" & P_NAME.Text & "','" & Brand.Text & "', '" & C_NAME.Text & "','" & STK_QTY.Text & "','" & PUR_PRICE.Text & "','" & MRP.Text & "'," & Val(HSN.Text) & "," & Val(DIS.Text) & ",curdate())"
                CMD = New MySqlCommand(query, conn)
                READER = CMD.ExecuteReader
                ShowProductTable()
                conn.Close()
            Else
                MessageBox.Show("Fill All Fields")
            End If
        End If
        cleartextboxes()
    End Sub

    Private Sub DIS_KeyUp(sender As Object, e As KeyEventArgs) Handles DIS.KeyUp
        If e.KeyValue = Keys.Enter Then
            If Len(P_NAME.Text) <> 0 And Len(Brand.Text) <> 0 And Len(C_NAME.Text) <> 0 And Len(STK_QTY.Text) <> 0 And Len(PUR_PRICE.Text) <> 0 And Len(MRP.Text) <> 0 And Len(HSN.Text) <> 0 And Len(DIS.Text) <> 0 Then
                Call connect()
                query = "insert into products values ('" & P_ID.Text & "','" & P_NAME.Text & "','" & Brand.Text & "', '" & C_NAME.Text & "','" & STK_QTY.Text & "','" & PUR_PRICE.Text & "','" & MRP.Text & "'," & Val(HSN.Text) & "," & Val(DIS.Text) & ",curdate())"
                CMD = New MySqlCommand(query, conn)
                READER = CMD.ExecuteReader
                ShowProductTable()
                conn.Close()
            Else
                MessageBox.Show("Fill All Fields")
            End If
        End If
        cleartextboxes()
    End Sub
End Class
