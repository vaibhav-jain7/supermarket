Imports MySql.Data.MySqlClient

Public Class Form9

    Dim CMD As MySqlCommand
    Dim READER As MySqlDataReader
    Dim query As String

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
        query = "select * from bill_data where bill_no = '" & CurrentBill & "'"
        'query = "select * from bill_data where bill_no = '20250004'"
        CMD = New MySqlCommand(query, conn)
        READER = CMD.ExecuteReader
        MessageBox.Show(CurrentBill)

        Dim PRO As ListViewItem
        ListView1.Items.Clear()

        While READER.Read
            PRO = ListView1.Items.Add(READER.GetString("p_name"))
            PRO.SubItems.Add((READER.GetString("p_qty")))
            PRO.SubItems.Add((READER.GetString("p_dis")))
            PRO.SubItems.Add((READER.GetString("p_gst")))
            PRO.SubItems.Add((READER.GetString("p_mrp")))
            PRO.SubItems.Add((READER.GetString("p_amt")))
        End While
        conn.Close()

        Countdata()

    End Sub

    Public Sub Countdata()

        Dim i As Integer
        Dim itm As ListViewItem
        Dim QTY_CNT As Double = 0.00
        Dim ITM_DIS As Double = 0.00
        Dim TOT_AMT As Double = 0.00
        Dim ITM_CGST As Double = 0.00
        Dim ITM_SGST As Double = 0.00
        Dim ITM_GST As Double = 0.00

        Dim total_mrp As Double = 0
        Dim j As Double = 0


        For i = 0 To ListView1.Items.Count - 1
            itm = ListView1.Items(i)
            QTY_CNT = QTY_CNT + Val(itm.SubItems(1).Text)

            Dim tot_dis As Double = (Val(itm.SubItems(4).Text) * (Val(itm.SubItems(2).Text) / 100)) * Val(itm.SubItems(1).Text)
            ITM_DIS = ITM_DIS + tot_dis

            'GST CALCULATION START
            j = (Val(itm.SubItems(4).Text) - (Val(itm.SubItems(4).Text) * (Val(itm.SubItems(2).Text) / 100))) * Val(itm.SubItems(3).Text) / 100
            ITM_GST = ITM_GST + (j * (Val(itm.SubItems(1).Text)))

            total_mrp += Val(itm.SubItems(4).Text) * Val(itm.SubItems(1).Text)
            TOT_AMT = (TOT_AMT + Val(itm.SubItems(5).Text))

        Next

        MRP.Text = Math.Round(TOT_AMT, 2)
        DIS.Text = "- " & Math.Round(ITM_DIS, 2)
        GST.Text = "+ " & Math.Round(ITM_GST, 2)
        FINALAMT.Text = Math.Round(total_mrp, 2)
    End Sub

    Private Sub ADD_Click(sender As Object, e As EventArgs) Handles ADD.Click
        Me.Hide()
        Form7.Show()
    End Sub

End Class