Imports MySql.Data.MySqlClient

Public Class Form3

    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If User = "ADMIN" Then
            Label1.Text = "ADMINISTRATOR LOGIN"
        ElseIf User = "MANAGER" Then
            Label1.Text = "MANAGER LOGIN"
        ElseIf User = "EMPLOYEE" Then
            Label1.Text = "EMPLOYEE LOGIN"
        End If

        TextBox1.Text = ""
        TextBox2.Text = ""

        'Center Label According to the User
        Label1.Left = (Me.ClientSize.Width - Label1.Width) / 2

        'Current Date
        Label5.Text = Today
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

        Dim form4 As New Form4()
        form4.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call connect()
        If User = "ADMIN" Then
            query = "select * from admin"
            CMD = New MySqlCommand(query, conn)
            READER = CMD.ExecuteReader
            Dim userId As String
            Dim password As String
            Dim i As Integer = 0
            While READER.Read
                userId = READER.GetString("ad_id")
                password = READER.GetString("ad_pass")
                If TextBox1.Text = userId Then
                    If TextBox2.Text = password Then
                        MessageBox.Show("Login Successfully")
                        admin = userId
                        i += 1
                    End If
                End If
            End While

            If i = 0 Then
                MessageBox.Show("Invalid Admin Credentials")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox1.Focus()
            ElseIf i = 1 Then
                Dim form5 As New Form5()
                form5.Show()
                Me.Close()
            End If

        ElseIf User = "MANAGER" Then
            MessageBox.Show("Under Development")
        ElseIf User = "EMPLOYEE" Then

            query = "select * from employee"
            CMD = New MySqlCommand(query, conn)
            READER = CMD.ExecuteReader
            Dim userId As Integer
            Dim password As String
            Dim i As Integer = 0
            While READER.Read
                userId = READER.GetInt64("emp_id")
                password = READER.GetString("emp_pass")
                If TextBox1.Text = userId Then
                    If TextBox2.Text = password Then
                        MessageBox.Show("Login Successfully")
                        emp = userId
                        i += 1
                    End If
                End If
            End While

            If i = 0 Then
                MessageBox.Show("Invalid Employee Credentials")
            ElseIf i = 1 Then
                Dim form6 As New Form6()
                form6.Show()
                Me.Close()
            End If

        End If
        conn.Close()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox2.UseSystemPasswordChar = True
        Else
            TextBox2.UseSystemPasswordChar = False
        End If
    End Sub
End Class