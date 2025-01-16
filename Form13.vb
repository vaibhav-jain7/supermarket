Imports MySql.Data.MySqlClient
Public Class Form13
    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call connect()

        'Dim SDA As New MySqlDataAdapter
        'Dim dbDataSet As New DataTable
        'Dim bSource As New BindingSource

        '' QUERY TO FETCH PRODUCT TABLE AND DISPLAY ON FORM LOAD
        'query = "select * from customers"
        'CMD = New MySqlCommand(query, conn)
        'SDA.SelectCommand = CMD
        'SDA.Fill(dbDataSet)
        'bSource.DataSource = dbDataSet
        'DataGridView1.DataSource = bSource
        'SDA.Update(dbDataSet)

        'conn.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Call connect()

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        ' QUERY TO FETCH PRODUCT TABLE AND DISPLAY ON FORM LOAD
        query = "select * from customers where ph_no = '" & C_PH.Text & "'"
        CMD = New MySqlCommand(query, conn)
        SDA.SelectCommand = CMD
        SDA.Fill(dbDataSet)
        bSource.DataSource = dbDataSet
        DataGridView1.DataSource = bSource
        SDA.Update(dbDataSet)

        conn.Close()
    End Sub
End Class