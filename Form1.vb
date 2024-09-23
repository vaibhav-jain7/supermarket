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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
