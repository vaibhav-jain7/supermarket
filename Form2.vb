Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Agreement
Imports Org.BouncyCastle.Pqc.Crypto.Lms

Public Class Form2

    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call connect()
        ' QUERY TO ADD CATEGORY NAME TO COMBBOX1(C_NAME)
        C_NAME.Items.Clear()
        query = "select * from pro_categories"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        ShowProductTable()
        conn.Close()
    End Sub
    Public Sub ShowProductTable()
        Call connect()
        'DataGridView1.DataSource.cl= READER(0)
        ' QUERY TO FETCH PRODUCT TABLE AND DISPLAY ON FORM LOAD
        query = "select * from products"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        While READER.Read
            Dim PRO As DataGridView
            PRO = DataGridView1.DataSource.Add(READER(0))
            PRO.DataSource.Add(READER(1))
            PRO.DataSource.Add(READER(2))
            PRO.DataSource.Add(READER(3))
            PRO.DataSource.Add(READER(4))
            PRO.DataSource.Add(READER(5))
            PRO.DataSource.Add(READER(6))
            PRO.DataSource.Add(READER(7))
            PRO.DataSource.Add(READER(8))
            PRO.DataSource.Add(READER(9))
        End While
        conn.Close()
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
                'AutoIncrementId()
                'CLEAR ALL FORM FEILDS AFTER ADDINF PRODUCT
                'cleartextboxes()
                conn.Close()
            Else
                MessageBox.Show("Fill All Fields")
            End If
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles P_NAME.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Brand.TextChanged

    End Sub
End Class