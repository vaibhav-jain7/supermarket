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
        Me.components = New System.ComponentModel.Container()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.P_ID = New System.Windows.Forms.TextBox()
        Me.P_NAME = New System.Windows.Forms.TextBox()
        Me.Brand = New System.Windows.Forms.TextBox()
        Me.C_ID = New System.Windows.Forms.TextBox()
        Me.PUR_PRICE = New System.Windows.Forms.TextBox()
        Me.MRP = New System.Windows.Forms.TextBox()
        Me.STK_QTY = New System.Windows.Forms.TextBox()
        Me.HSN = New System.Windows.Forms.TextBox()
        Me.DIS = New System.Windows.Forms.TextBox()
        Me.IVY_DATE = New System.Windows.Forms.TextBox()
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.BackColor = System.Drawing.SystemColors.Window
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView1.HideSelection = False
        Me.ListView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ListView1.Location = New System.Drawing.Point(0, 362)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1262, 458)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'P_ID
        '
        Me.P_ID.Location = New System.Drawing.Point(206, 104)
        Me.P_ID.Name = "P_ID"
        Me.P_ID.Size = New System.Drawing.Size(100, 20)
        Me.P_ID.TabIndex = 2
        '
        'P_NAME
        '
        Me.P_NAME.Location = New System.Drawing.Point(206, 140)
        Me.P_NAME.Name = "P_NAME"
        Me.P_NAME.Size = New System.Drawing.Size(171, 20)
        Me.P_NAME.TabIndex = 3
        '
        'Brand
        '
        Me.Brand.Location = New System.Drawing.Point(206, 176)
        Me.Brand.Name = "Brand"
        Me.Brand.Size = New System.Drawing.Size(86, 20)
        Me.Brand.TabIndex = 4
        '
        'C_ID
        '
        Me.C_ID.Location = New System.Drawing.Point(585, 104)
        Me.C_ID.Name = "C_ID"
        Me.C_ID.Size = New System.Drawing.Size(78, 20)
        Me.C_ID.TabIndex = 5
        '
        'PUR_PRICE
        '
        Me.PUR_PRICE.Location = New System.Drawing.Point(206, 212)
        Me.PUR_PRICE.Name = "PUR_PRICE"
        Me.PUR_PRICE.Size = New System.Drawing.Size(82, 20)
        Me.PUR_PRICE.TabIndex = 6
        '
        'MRP
        '
        Me.MRP.Location = New System.Drawing.Point(585, 142)
        Me.MRP.Name = "MRP"
        Me.MRP.Size = New System.Drawing.Size(79, 20)
        Me.MRP.TabIndex = 7
        '
        'STK_QTY
        '
        Me.STK_QTY.Location = New System.Drawing.Point(206, 248)
        Me.STK_QTY.Name = "STK_QTY"
        Me.STK_QTY.Size = New System.Drawing.Size(171, 20)
        Me.STK_QTY.TabIndex = 8
        '
        'HSN
        '
        Me.HSN.Location = New System.Drawing.Point(585, 179)
        Me.HSN.Name = "HSN"
        Me.HSN.Size = New System.Drawing.Size(99, 20)
        Me.HSN.TabIndex = 9
        '
        'DIS
        '
        Me.DIS.Location = New System.Drawing.Point(585, 216)
        Me.DIS.Name = "DIS"
        Me.DIS.Size = New System.Drawing.Size(102, 20)
        Me.DIS.TabIndex = 10
        '
        'IVY_DATE
        '
        Me.IVY_DATE.Location = New System.Drawing.Point(585, 253)
        Me.IVY_DATE.Name = "IVY_DATE"
        Me.IVY_DATE.Size = New System.Drawing.Size(147, 20)
        Me.IVY_DATE.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "P_ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "P_NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "BRAND"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(457, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "C_ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 24)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "PUR_PRICE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(457, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 24)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "MRP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 24)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "STOCK QUANTITY"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(457, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 24)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "HSN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(457, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 24)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "DIS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(457, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 24)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "INY DATE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Minion Pro", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(467, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(15, 10, 15, 10)
        Me.Label11.Size = New System.Drawing.Size(265, 71)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Add Products"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "P_ID"
        Me.ColumnHeader1.Width = 87
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "P_NAME"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 218
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "BRAND"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 158
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "C_ID"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 158
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "PUR_PRICE"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 93
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "MRP"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 75
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "STK QTY"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 95
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "HSN"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 76
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "DIS"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 105
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "INY DATE"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 192
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1011, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(15, 10, 15, 10)
        Me.Button1.Size = New System.Drawing.Size(171, 56)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Add Product"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1259, 818)
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
        Me.Controls.Add(Me.IVY_DATE)
        Me.Controls.Add(Me.DIS)
        Me.Controls.Add(Me.HSN)
        Me.Controls.Add(Me.STK_QTY)
        Me.Controls.Add(Me.MRP)
        Me.Controls.Add(Me.PUR_PRICE)
        Me.Controls.Add(Me.C_ID)
        Me.Controls.Add(Me.Brand)
        Me.Controls.Add(Me.P_NAME)
        Me.Controls.Add(Me.P_ID)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents P_ID As TextBox
    Friend WithEvents P_NAME As TextBox
    Friend WithEvents Brand As TextBox
    Friend WithEvents C_ID As TextBox
    Friend WithEvents PUR_PRICE As TextBox
    Friend WithEvents MRP As TextBox
    Friend WithEvents STK_QTY As TextBox
    Friend WithEvents HSN As TextBox
    Friend WithEvents DIS As TextBox
    Friend WithEvents IVY_DATE As TextBox
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
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button1 As Button
End Class
