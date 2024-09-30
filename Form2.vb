Imports MySql.Data.MySqlClient

Public Class Form2

    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String
    Dim Gender As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call connect()

        AutoIncrementId()

        ShowProductTable()

        conn.Close()

        DOJ.Text = Today
    End Sub

    Public Sub AutoIncrementId()
        Call connect()
        query = "select max(emp_id) from employee"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        While READER.Read
            E_ID.Text = Val(READER(0) + 1)
        End While
        conn.Close()
    End Sub

    Public Sub ShowProductTable()
        Call connect()

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        ' QUERY TO FETCH PRODUCT TABLE AND DISPLAY ON FORM LOAD
        query = "select * from employee"
        CMD = New MySqlCommand(query, conn)
        SDA.SelectCommand = CMD
        SDA.Fill(dbDataSet)
        bSource.DataSource = dbDataSet
        DataGridView1.DataSource = bSource
        SDA.Update(dbDataSet)

        conn.Close()
    End Sub
    Public Sub ClearTextBoxes()
        E_NAME.Clear()
        E_ADDHAR.Clear()
        E_PHONO.Clear()
        E_ADD.Clear()
        E_EMAIL.Clear()
        Gender = ""
        STATE.Clear()
        CITY.Clear()
        PIN.Clear()
        PASS.Clear()
        E_NAME.Focus()
    End Sub

    Private Sub PASS_KeyUp(sender As Object, e As KeyEventArgs) Handles PASS.KeyUp
        If e.KeyValue = Keys.Enter Then
            If Len(E_NAME.Text) <> 0 And Len(E_ADDHAR.Text) <> 0 And Len(E_PHONO.Text) <> 0 And Len(E_ADD.Text) <> 0 And Len(Gender) <> 0 And Len(E_EMAIL.Text) <> 0 And Len(STATE.Text) <> 0 And Len(CITY.Text) <> 0 And Len(PIN.Text) <> 0 And Len(PASS.Text) <> 0 Then
                Call connect()
                query = "insert into employee values ('" & E_ID.Text & "','" & E_NAME.Text & "','" & E_ADDHAR.Text & "', '" & Gender & "','" & PIN.Text & "','" & E_PHONO.Text & "','" & E_EMAIL.Text & "','" & E_ADD.Text & "','" & STATE.Text & "','" & CITY.Text & "','" & PASS.Text & "',curdate())"
                CMD = New MySqlCommand(query, conn)
                READER = CMD.ExecuteReader
                'SHOW PRODUCT TABLE AFTER ADDING NEW PRODUCT
                ShowProductTable()
                'CALL AUTOINCREMENT FUNCTION TO SET PRODUCT_ID 
                AutoIncrementId()
                'CLEAR ALL FORM FEILDS AFTER ADDINF PRODUCT
                ClearTextBoxes()
                'GENDER UNCHECK
                GENDER1.Checked = False
                GENDER2.Checked = False

                conn.Close()
            Else
                MessageBox.Show("Fill All Fields")
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim r As DataGridViewRow
            r = Me.DataGridView1.Rows(e.RowIndex)
            E_ID.Text = r.Cells("emp_id").Value.ToString
            E_NAME.Text = r.Cells("emp_name").Value.ToString
            E_ADDHAR.Text = r.Cells("emp_aadhar").Value.ToString
            Gender = r.Cells("emp_gender").Value.ToString
            E_PHONO.Text = r.Cells("emp_phone").Value.ToString
            E_ADD.Text = r.Cells("emp_address").Value.ToString
            E_EMAIL.Text = r.Cells("emp_email").Value.ToString
            STATE.Text = r.Cells("emp_state").Value.ToString
            CITY.Text = r.Cells("emp_city").Value.ToString
            PIN.Text = r.Cells("Pincode").Value.ToString
            PASS.Text = r.Cells("emp_pass").Value.ToString
            Button2.Enabled = True
            Button3.Enabled = True
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call connect()
        query = "update super_market.employee set emp_name='" & E_NAME.Text & "',emp_aadhar='" & E_ADDHAR.Text & "',emp_gender= '" & Gender & "',emp_phone='" & E_PHONO.Text & "',emp_address='" & E_ADD.Text & "',emp_email='" & E_EMAIL.Text & "',emp_state='" & STATE.Text & "',emp_city='" & CITY.Text & "', Pincode=" & Val(PIN.Text) & ",emp_pass=" & Val(PASS.Text) & " where emp_id='" & E_ID.Text & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        'SHOW PRODUCT TABLE AFTER ADDING NEW PRODUCT
        ShowProductTable()
        'CALL AUTOINCREMENT FUNCTION TO SET PRODUCT_ID 
        AutoIncrementId()
        'CLEAR ALL FORM FEILDS AFTER ADDINF PRODUCT
        ClearTextBoxes()
        'Modify And Delete Buttons
        Button2.Enabled = False
        Button3.Enabled = False
        'GENDER UNCHECK
        GENDER1.Checked = False
        GENDER2.Checked = False

        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call connect()
        query = "delete from super_market.employee where emp_id='" & E_ID.Text & "'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        'SHOW PRODUCT TABLE AFTER ADDING NEW PRODUCT
        ShowProductTable()
        'CALL AUTOINCREMENT FUNCTION TO SET PRODUCT_ID 
        AutoIncrementId()
        'CLEAR ALL FORM FEILDS AFTER ADDINF PRODUCT
        ClearTextBoxes()
        'Modify And Delete Buttons
        Button2.Enabled = False
        Button3.Enabled = False
        'GENDER UNCHECK
        GENDER1.Checked = False
        GENDER2.Checked = False

    End Sub

    Private Sub GENDER1_CheckedChanged(sender As Object, e As EventArgs) Handles GENDER1.CheckedChanged
        Gender = "Male"
    End Sub

    Private Sub GENDER2_CheckedChanged(sender As Object, e As EventArgs) Handles GENDER2.CheckedChanged
        Gender = "Female"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Len(E_NAME.Text) <> 0 And Len(E_ADDHAR.Text) <> 0 And Len(E_PHONO.Text) <> 0 And Len(E_ADD.Text) <> 0 And Len(Gender) <> 0 And Len(E_EMAIL.Text) <> 0 And Len(STATE.Text) <> 0 And Len(CITY.Text) <> 0 And Len(PIN.Text) <> 0 And Len(PASS.Text) <> 0 Then
            Call connect()
            query = "insert into employee values ('" & E_ID.Text & "','" & E_NAME.Text & "','" & E_ADDHAR.Text & "', '" & Gender & "','" & PIN.Text & "','" & E_PHONO.Text & "','" & E_EMAIL.Text & "','" & E_ADD.Text & "','" & STATE.Text & "','" & CITY.Text & "','" & PASS.Text & "',curdate())"
            CMD = New MySqlCommand(query, conn)
            READER = CMD.ExecuteReader
            'SHOW PRODUCT TABLE AFTER ADDING NEW PRODUCT
            ShowProductTable()
            'CALL AUTOINCREMENT FUNCTION TO SET PRODUCT_ID 
            AutoIncrementId()
            'CLEAR ALL FORM FEILDS AFTER ADDINF PRODUCT
            ClearTextBoxes()
            'GENDER UNCHECK
            GENDER1.Checked = False
            GENDER2.Checked = False

            conn.Close()
        Else
            MessageBox.Show("Fill All Fields")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClearTextBoxes()
    End Sub

    Private Sub E_ID_TextChanged(sender As Object, e As EventArgs) Handles E_ID.TextChanged

    End Sub
End Class