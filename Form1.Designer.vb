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
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.HideSelection = False
        Me.ListView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ListView1.Location = New System.Drawing.Point(12, 145)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1164, 380)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1058, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'P_ID
        '
        Me.P_ID.Location = New System.Drawing.Point(12, 108)
        Me.P_ID.Name = "P_ID"
        Me.P_ID.Size = New System.Drawing.Size(95, 20)
        Me.P_ID.TabIndex = 2
        '
        'P_NAME
        '
        Me.P_NAME.Location = New System.Drawing.Point(113, 109)
        Me.P_NAME.Name = "P_NAME"
        Me.P_NAME.Size = New System.Drawing.Size(171, 20)
        Me.P_NAME.TabIndex = 3
        '
        'Brand
        '
        Me.Brand.Location = New System.Drawing.Point(290, 109)
        Me.Brand.Name = "Brand"
        Me.Brand.Size = New System.Drawing.Size(86, 20)
        Me.Brand.TabIndex = 4
        '
        'C_ID
        '
        Me.C_ID.Location = New System.Drawing.Point(382, 109)
        Me.C_ID.Name = "C_ID"
        Me.C_ID.Size = New System.Drawing.Size(78, 20)
        Me.C_ID.TabIndex = 5
        '
        'PUR_PRICE
        '
        Me.PUR_PRICE.Location = New System.Drawing.Point(466, 109)
        Me.PUR_PRICE.Name = "PUR_PRICE"
        Me.PUR_PRICE.Size = New System.Drawing.Size(82, 20)
        Me.PUR_PRICE.TabIndex = 6
        '
        'MRP
        '
        Me.MRP.Location = New System.Drawing.Point(554, 109)
        Me.MRP.Name = "MRP"
        Me.MRP.Size = New System.Drawing.Size(79, 20)
        Me.MRP.TabIndex = 7
        '
        'STK_QTY
        '
        Me.STK_QTY.Location = New System.Drawing.Point(639, 109)
        Me.STK_QTY.Name = "STK_QTY"
        Me.STK_QTY.Size = New System.Drawing.Size(171, 20)
        Me.STK_QTY.TabIndex = 8
        '
        'HSN
        '
        Me.HSN.Location = New System.Drawing.Point(816, 109)
        Me.HSN.Name = "HSN"
        Me.HSN.Size = New System.Drawing.Size(99, 20)
        Me.HSN.TabIndex = 9
        '
        'DIS
        '
        Me.DIS.Location = New System.Drawing.Point(921, 109)
        Me.DIS.Name = "DIS"
        Me.DIS.Size = New System.Drawing.Size(102, 20)
        Me.DIS.TabIndex = 10
        '
        'IVY_DATE
        '
        Me.IVY_DATE.Location = New System.Drawing.Point(1029, 109)
        Me.IVY_DATE.Name = "IVY_DATE"
        Me.IVY_DATE.Size = New System.Drawing.Size(147, 20)
        Me.IVY_DATE.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 537)
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
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
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
End Class
