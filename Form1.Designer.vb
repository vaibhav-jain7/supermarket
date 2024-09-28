<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.P_ID = New System.Windows.Forms.TextBox()
        Me.P_NAME = New System.Windows.Forms.TextBox()
        Me.Brand = New System.Windows.Forms.TextBox()
        Me.PUR_PRICE = New System.Windows.Forms.TextBox()
        Me.MRP = New System.Windows.Forms.TextBox()
        Me.STK_QTY = New System.Windows.Forms.TextBox()
        Me.HSN = New System.Windows.Forms.TextBox()
        Me.DIS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IVY_DATE = New System.Windows.Forms.Label()
        Me.C_NAME = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.BackColor = System.Drawing.SystemColors.Window
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView1.HideSelection = False
        Me.ListView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ListView1.Location = New System.Drawing.Point(1, 404)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1255, 425)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "P_ID"
        Me.ColumnHeader1.Width = 91
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "P_NAME"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 208
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "BRAND"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 140
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "C_NAME"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 184
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "STK_QTY"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 91
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "PUR_PRICE"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 128
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "MRP"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 110
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "HSN"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 95
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "DIS"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 76
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "INY_DATE"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 127
        '
        'P_ID
        '
        Me.P_ID.Enabled = False
        Me.P_ID.Location = New System.Drawing.Point(239, 177)
        Me.P_ID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.P_ID.Name = "P_ID"
        Me.P_ID.Size = New System.Drawing.Size(254, 29)
        Me.P_ID.TabIndex = 2
        '
        'P_NAME
        '
        Me.P_NAME.Location = New System.Drawing.Point(239, 222)
        Me.P_NAME.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.P_NAME.Name = "P_NAME"
        Me.P_NAME.Size = New System.Drawing.Size(254, 29)
        Me.P_NAME.TabIndex = 3
        '
        'Brand
        '
        Me.Brand.Location = New System.Drawing.Point(238, 267)
        Me.Brand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Brand.Name = "Brand"
        Me.Brand.Size = New System.Drawing.Size(254, 29)
        Me.Brand.TabIndex = 4
        '
        'PUR_PRICE
        '
        Me.PUR_PRICE.Location = New System.Drawing.Point(239, 314)
        Me.PUR_PRICE.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PUR_PRICE.Name = "PUR_PRICE"
        Me.PUR_PRICE.Size = New System.Drawing.Size(254, 29)
        Me.PUR_PRICE.TabIndex = 5
        '
        'MRP
        '
        Me.MRP.Location = New System.Drawing.Point(803, 222)
        Me.MRP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MRP.Name = "MRP"
        Me.MRP.Size = New System.Drawing.Size(191, 29)
        Me.MRP.TabIndex = 8
        '
        'STK_QTY
        '
        Me.STK_QTY.Location = New System.Drawing.Point(239, 360)
        Me.STK_QTY.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.STK_QTY.Name = "STK_QTY"
        Me.STK_QTY.Size = New System.Drawing.Size(254, 29)
        Me.STK_QTY.TabIndex = 6
        '
        'HSN
        '
        Me.HSN.Location = New System.Drawing.Point(803, 267)
        Me.HSN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.HSN.Name = "HSN"
        Me.HSN.Size = New System.Drawing.Size(191, 29)
        Me.HSN.TabIndex = 9
        '
        'DIS
        '
        Me.DIS.Location = New System.Drawing.Point(803, 314)
        Me.DIS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DIS.Name = "DIS"
        Me.DIS.Size = New System.Drawing.Size(191, 29)
        Me.DIS.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 181)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "PRODUCT ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 226)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "PRODUCT NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 271)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "BRAND"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(575, 181)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "PRODUCT CATEGORY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(60, 318)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 24)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "PURCHASE PRICE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(575, 226)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 24)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "MRP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(60, 364)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 24)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "STOCK QUANTITY"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(575, 271)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 24)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "HSN CODE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(575, 318)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 24)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "DISCOUNT(%)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(575, 364)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 24)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "INVENTORY DATE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(474, 96)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(5)
        Me.Label11.Size = New System.Drawing.Size(265, 52)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Add Products"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1111, 294)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Button1.Size = New System.Drawing.Size(136, 46)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IVY_DATE
        '
        Me.IVY_DATE.AutoSize = True
        Me.IVY_DATE.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IVY_DATE.Location = New System.Drawing.Point(803, 364)
        Me.IVY_DATE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IVY_DATE.Name = "IVY_DATE"
        Me.IVY_DATE.Size = New System.Drawing.Size(46, 23)
        Me.IVY_DATE.TabIndex = 24
        Me.IVY_DATE.Text = "Date"
        '
        'C_NAME
        '
        Me.C_NAME.FormattingEnabled = True
        Me.C_NAME.Location = New System.Drawing.Point(803, 181)
        Me.C_NAME.Name = "C_NAME"
        Me.C_NAME.Size = New System.Drawing.Size(191, 32)
        Me.C_NAME.TabIndex = 26
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1111, 351)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Button2.Size = New System.Drawing.Size(136, 46)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(474, 19)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Padding = New System.Windows.Forms.Padding(5)
        Me.Label12.Size = New System.Drawing.Size(263, 52)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Super market"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1256, 749)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.C_NAME)
        Me.Controls.Add(Me.IVY_DATE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DIS)
        Me.Controls.Add(Me.HSN)
        Me.Controls.Add(Me.STK_QTY)
        Me.Controls.Add(Me.MRP)
        Me.Controls.Add(Me.PUR_PRICE)
        Me.Controls.Add(Me.Brand)
        Me.Controls.Add(Me.P_NAME)
        Me.Controls.Add(Me.P_ID)
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents P_ID As TextBox
    Friend WithEvents P_NAME As TextBox
    Friend WithEvents Brand As TextBox
    Friend WithEvents PUR_PRICE As TextBox
    Friend WithEvents MRP As TextBox
    Friend WithEvents STK_QTY As TextBox
    Friend WithEvents HSN As TextBox
    Friend WithEvents DIS As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents IVY_DATE As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents C_NAME As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label12 As Label
End Class
