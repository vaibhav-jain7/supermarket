Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(135, 162, 255)
        ListView1.Columns.Add("P_ID", 90, HorizontalAlignment.Center)
        ListView1.Columns.Add("P_NAME", 180, HorizontalAlignment.Center)
        ListView1.Columns.Add("BRAND", 90, HorizontalAlignment.Center)
        ListView1.Columns.Add("C_ID", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("PUR_PRICE", 90, HorizontalAlignment.Center)
        ListView1.Columns.Add("MRP", 90, HorizontalAlignment.Center)
        ListView1.Columns.Add("STK_QNT", 90, HorizontalAlignment.Center)
        ListView1.Columns.Add("HSN", 110, HorizontalAlignment.Center)
        ListView1.Columns.Add("DIS", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("IVT_DATE", 150, HorizontalAlignment.Center)
    End Sub
    Private Sub IVY_DATE_KeyUp(sender As Object, e As KeyEventArgs) Handles IVY_DATE.KeyUp
        Dim PRO As ListViewItem
        Dim cntr As Integer
        Dim i As Integer
        If e.KeyValue = Keys.Enter Then
            If ListView1.Items.Count > 0 Then
                For i = 0 To ListView1.Items.Count - 1
                    If ListView1.Items(i).SubItems(0).Text = P_ID.Text Then
                        ListView1.Items(i).SubItems(6).Text = Val(ListView1.Items(i).SubItems(6).Text) + Val(STK_QTY.Text)
                        cntr = 1
                        Exit For
                    End If
                Next
            End If
            If (cntr = 0) Then

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
            P_ID.Focus()
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
