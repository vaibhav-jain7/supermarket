Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("P_ID", 90, HorizontalAlignment.Center)
        ListView1.Columns.Add("P_NAME", 180, HorizontalAlignment.Center)
        ListView1.Columns.Add("BRAND", 90, HorizontalAlignment.Center)
        ListView1.Columns.Add("C_ID", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("PUR_PRICE", 90, HorizontalAlignment.Center)
        ListView1.Columns.Add("MRP", 90, HorizontalAlignment.Center)
        ListView1.Columns.Add("STK_QNT", 180, HorizontalAlignment.Center)
        ListView1.Columns.Add("HSN", 110, HorizontalAlignment.Center)
        ListView1.Columns.Add("DIS", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("IVT_DATE", 150, HorizontalAlignment.Center)
        Button1.Text = "NEW"
    End Sub
    Private Sub IVY_DATE_KeyUp(sender As Object, e As KeyEventArgs) Handles IVY_DATE.KeyUp
        Dim PRO As ListViewItem
        If e.KeyValue = Keys.Enter Then
            PRO = ListView1.Items.Add(P_ID.Text)
            PRO.SubItems.Add(P_NAME.Text)
            PRO.SubItems.Add(Brand.Text)
            PRO.SubItems.Add(C_ID.Text)
            PRO.SubItems.Add(PUR_PRICE.Text)
            PRO.SubItems.Add(MRP.Text)
            PRO.SubItems.Add(STK_QTY.Text)
            PRO.SubItems.Add(HSN.Text)
            PRO.SubItems.Add(DIS.Text)
            PRO.SubItems.Add(IVY_DATE.Text)
        End If
        P_ID.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        P_ID.Text = ""
        P_NAME.Text = ""
        Brand.Text = ""
        C_ID.Text = ""
        PUR_PRICE.Text = ""
        MRP.Text = ""
        STK_QTY.Text = ""
        HSN.Text = ""
        DIS.Text = ""
        IVY_DATE.Text = ""
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
