<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.C_NAME = New System.Windows.Forms.ComboBox()
        Me.P_ID = New System.Windows.Forms.TextBox()
        Me.MRP = New System.Windows.Forms.TextBox()
        Me.Brand = New System.Windows.Forms.TextBox()
        Me.STK_QTY = New System.Windows.Forms.TextBox()
        Me.PUR_PRICE = New System.Windows.Forms.TextBox()
        Me.P_NAME = New System.Windows.Forms.TextBox()
        Me.HSN = New System.Windows.Forms.TextBox()
        Me.DIS = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 216)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1175, 285)
        Me.DataGridView1.TabIndex = 0
        '
        'C_NAME
        '
        Me.C_NAME.FormattingEnabled = True
        Me.C_NAME.Location = New System.Drawing.Point(895, 41)
        Me.C_NAME.Name = "C_NAME"
        Me.C_NAME.Size = New System.Drawing.Size(121, 21)
        Me.C_NAME.TabIndex = 1
        '
        'P_ID
        '
        Me.P_ID.Location = New System.Drawing.Point(153, 42)
        Me.P_ID.Name = "P_ID"
        Me.P_ID.Size = New System.Drawing.Size(121, 20)
        Me.P_ID.TabIndex = 2
        '
        'MRP
        '
        Me.MRP.Location = New System.Drawing.Point(895, 78)
        Me.MRP.Name = "MRP"
        Me.MRP.Size = New System.Drawing.Size(121, 20)
        Me.MRP.TabIndex = 3
        '
        'Brand
        '
        Me.Brand.Location = New System.Drawing.Point(153, 117)
        Me.Brand.Name = "Brand"
        Me.Brand.Size = New System.Drawing.Size(121, 20)
        Me.Brand.TabIndex = 4
        '
        'STK_QTY
        '
        Me.STK_QTY.Location = New System.Drawing.Point(153, 152)
        Me.STK_QTY.Name = "STK_QTY"
        Me.STK_QTY.Size = New System.Drawing.Size(121, 20)
        Me.STK_QTY.TabIndex = 5
        '
        'PUR_PRICE
        '
        Me.PUR_PRICE.Location = New System.Drawing.Point(153, 190)
        Me.PUR_PRICE.Name = "PUR_PRICE"
        Me.PUR_PRICE.Size = New System.Drawing.Size(121, 20)
        Me.PUR_PRICE.TabIndex = 6
        '
        'P_NAME
        '
        Me.P_NAME.Location = New System.Drawing.Point(153, 78)
        Me.P_NAME.Name = "P_NAME"
        Me.P_NAME.Size = New System.Drawing.Size(121, 20)
        Me.P_NAME.TabIndex = 7
        '
        'HSN
        '
        Me.HSN.Location = New System.Drawing.Point(895, 117)
        Me.HSN.Name = "HSN"
        Me.HSN.Size = New System.Drawing.Size(121, 20)
        Me.HSN.TabIndex = 8
        '
        'DIS
        '
        Me.DIS.Location = New System.Drawing.Point(895, 152)
        Me.DIS.Name = "DIS"
        Me.DIS.Size = New System.Drawing.Size(121, 20)
        Me.DIS.TabIndex = 9
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(895, 187)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1199, 513)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DIS)
        Me.Controls.Add(Me.HSN)
        Me.Controls.Add(Me.P_NAME)
        Me.Controls.Add(Me.PUR_PRICE)
        Me.Controls.Add(Me.STK_QTY)
        Me.Controls.Add(Me.Brand)
        Me.Controls.Add(Me.MRP)
        Me.Controls.Add(Me.P_ID)
        Me.Controls.Add(Me.C_NAME)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents C_NAME As ComboBox
    Friend WithEvents P_ID As TextBox
    Friend WithEvents MRP As TextBox
    Friend WithEvents Brand As TextBox
    Friend WithEvents STK_QTY As TextBox
    Friend WithEvents PUR_PRICE As TextBox
    Friend WithEvents P_NAME As TextBox
    Friend WithEvents HSN As TextBox
    Friend WithEvents DIS As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
