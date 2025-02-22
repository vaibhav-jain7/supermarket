<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DIS = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GST = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FINALAMT = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PINNO = New System.Windows.Forms.TextBox()
        Me.PIN = New System.Windows.Forms.Label()
        Me.CARDNUMBER = New System.Windows.Forms.TextBox()
        Me.CARDNO = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CHANGEAMT = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TOTALAMT = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CASHBYCUSTOMER = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PAYMENTMODE = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PD = New System.Drawing.Printing.PrintDocument()
        Me.PPD = New System.Windows.Forms.PrintPreviewDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Silver
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.LabelEdit = True
        Me.ListView1.Location = New System.Drawing.Point(354, 53)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(630, 689)
        Me.ListView1.TabIndex = 103
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NAME"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "QTY"
        Me.ColumnHeader2.Width = 74
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DISCOUNT"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "GST"
        Me.ColumnHeader4.Width = 89
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "MRP"
        Me.ColumnHeader5.Width = 97
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "TOTAL AMT"
        Me.ColumnHeader6.Width = 115
        '
        'DIS
        '
        Me.DIS.AutoSize = True
        Me.DIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DIS.ForeColor = System.Drawing.Color.Lime
        Me.DIS.Location = New System.Drawing.Point(379, 763)
        Me.DIS.Name = "DIS"
        Me.DIS.Size = New System.Drawing.Size(18, 20)
        Me.DIS.TabIndex = 106
        Me.DIS.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(351, 763)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 20)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Rs. "
        '
        'GST
        '
        Me.GST.AutoSize = True
        Me.GST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GST.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GST.Location = New System.Drawing.Point(573, 763)
        Me.GST.Name = "GST"
        Me.GST.Size = New System.Drawing.Size(18, 20)
        Me.GST.TabIndex = 108
        Me.GST.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(544, 763)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 20)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Rs. "
        '
        'FINALAMT
        '
        Me.FINALAMT.AutoSize = True
        Me.FINALAMT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FINALAMT.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FINALAMT.Location = New System.Drawing.Point(131, 763)
        Me.FINALAMT.Name = "FINALAMT"
        Me.FINALAMT.Size = New System.Drawing.Size(18, 20)
        Me.FINALAMT.TabIndex = 110
        Me.FINALAMT.Text = "0"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(950, 746)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 37)
        Me.Button2.TabIndex = 112
        Me.Button2.Text = "<-"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(987, 745)
        Me.Panel1.TabIndex = 113
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(3, 741)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(980, 2)
        Me.Label17.TabIndex = 115
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PINNO)
        Me.Panel2.Controls.Add(Me.PIN)
        Me.Panel2.Controls.Add(Me.CARDNUMBER)
        Me.Panel2.Controls.Add(Me.CARDNO)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.CHANGEAMT)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.TOTALAMT)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.CASHBYCUSTOMER)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.PAYMENTMODE)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(354, 689)
        Me.Panel2.TabIndex = 114
        '
        'PINNO
        '
        Me.PINNO.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PINNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PINNO.Location = New System.Drawing.Point(45, 504)
        Me.PINNO.Name = "PINNO"
        Me.PINNO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PINNO.Size = New System.Drawing.Size(259, 26)
        Me.PINNO.TabIndex = 125
        '
        'PIN
        '
        Me.PIN.AutoSize = True
        Me.PIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.PIN.Location = New System.Drawing.Point(45, 483)
        Me.PIN.Name = "PIN"
        Me.PIN.Size = New System.Drawing.Size(32, 18)
        Me.PIN.TabIndex = 124
        Me.PIN.Text = "PIN"
        '
        'CARDNUMBER
        '
        Me.CARDNUMBER.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CARDNUMBER.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CARDNUMBER.Location = New System.Drawing.Point(48, 442)
        Me.CARDNUMBER.Name = "CARDNUMBER"
        Me.CARDNUMBER.Size = New System.Drawing.Size(259, 26)
        Me.CARDNUMBER.TabIndex = 123
        '
        'CARDNO
        '
        Me.CARDNO.AutoSize = True
        Me.CARDNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.CARDNO.Location = New System.Drawing.Point(48, 421)
        Me.CARDNO.Name = "CARDNO"
        Me.CARDNO.Size = New System.Drawing.Size(120, 18)
        Me.CARDNO.TabIndex = 122
        Me.CARDNO.Text = "CARD NUMBER"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(0, 279)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(354, 2)
        Me.Label18.TabIndex = 116
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(115, 639)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 44)
        Me.Button1.TabIndex = 114
        Me.Button1.Text = "CONFIRM"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CHANGEAMT
        '
        Me.CHANGEAMT.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CHANGEAMT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHANGEAMT.Location = New System.Drawing.Point(48, 504)
        Me.CHANGEAMT.Name = "CHANGEAMT"
        Me.CHANGEAMT.ReadOnly = True
        Me.CHANGEAMT.Size = New System.Drawing.Size(259, 26)
        Me.CHANGEAMT.TabIndex = 120
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label13.Location = New System.Drawing.Point(48, 483)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 18)
        Me.Label13.TabIndex = 119
        Me.Label13.Text = "CHANGE"
        '
        'TOTALAMT
        '
        Me.TOTALAMT.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TOTALAMT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTALAMT.Location = New System.Drawing.Point(48, 608)
        Me.TOTALAMT.Name = "TOTALAMT"
        Me.TOTALAMT.ReadOnly = True
        Me.TOTALAMT.Size = New System.Drawing.Size(253, 26)
        Me.TOTALAMT.TabIndex = 118
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label12.Location = New System.Drawing.Point(48, 587)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 18)
        Me.Label12.TabIndex = 117
        Me.Label12.Text = "AMOUNT"
        '
        'CASHBYCUSTOMER
        '
        Me.CASHBYCUSTOMER.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CASHBYCUSTOMER.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CASHBYCUSTOMER.Location = New System.Drawing.Point(48, 442)
        Me.CASHBYCUSTOMER.Name = "CASHBYCUSTOMER"
        Me.CASHBYCUSTOMER.Size = New System.Drawing.Size(259, 26)
        Me.CASHBYCUSTOMER.TabIndex = 116
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label11.Location = New System.Drawing.Point(48, 421)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(163, 18)
        Me.Label11.TabIndex = 115
        Me.Label11.Text = "CASH BY CUSTOMER"
        '
        'PAYMENTMODE
        '
        Me.PAYMENTMODE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PAYMENTMODE.FormattingEnabled = True
        Me.PAYMENTMODE.Items.AddRange(New Object() {"CASH", "UPI", "CARD"})
        Me.PAYMENTMODE.Location = New System.Drawing.Point(45, 357)
        Me.PAYMENTMODE.Name = "PAYMENTMODE"
        Me.PAYMENTMODE.Size = New System.Drawing.Size(256, 28)
        Me.PAYMENTMODE.TabIndex = 114
        Me.PAYMENTMODE.Text = "CASH"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(70, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 24)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "CUSTOMER DETAILS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(75, 309)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(204, 24)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "PAYMENT METHOD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(48, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 18)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "NAME"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(48, 222)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(259, 26)
        Me.TextBox3.TabIndex = 112
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label9.Location = New System.Drawing.Point(48, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 18)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "PHONE"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(48, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(259, 26)
        Me.TextBox1.TabIndex = 110
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(48, 152)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(259, 26)
        Me.TextBox2.TabIndex = 111
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label8.Location = New System.Drawing.Point(48, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 18)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "EMAIL"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.supermarket.My.Resources.Resources.orcode
        Me.PictureBox1.Location = New System.Drawing.Point(39, 398)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 121
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(391, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 29)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "ORDER DETAILS"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(3, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(980, 2)
        Me.Label1.TabIndex = 104
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label14.Location = New System.Drawing.Point(19, 761)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 22)
        Me.Label14.TabIndex = 114
        Me.Label14.Text = "TOTAL :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(99, 763)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 20)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "Rs. "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label6.Location = New System.Drawing.Point(234, 761)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 22)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "DISCOUNT :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label16.Location = New System.Drawing.Point(482, 761)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 22)
        Me.Label16.TabIndex = 117
        Me.Label16.Text = "GST :"
        '
        'PD
        '
        '
        'PPD
        '
        Me.PPD.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PPD.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PPD.ClientSize = New System.Drawing.Size(400, 300)
        Me.PPD.Enabled = True
        Me.PPD.Icon = CType(resources.GetObject("PPD.Icon"), System.Drawing.Icon)
        Me.PPD.Name = "PPD"
        Me.PPD.Visible = False
        '
        'Timer1
        '
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 788)
        Me.Controls.Add(Me.GST)
        Me.Controls.Add(Me.DIS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.FINALAMT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label16)
        Me.Name = "Form9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form9"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As ListView
    Friend WithEvents DIS As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GST As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FINALAMT As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents PAYMENTMODE As ComboBox
    Friend WithEvents CHANGEAMT As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TOTALAMT As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CASHBYCUSTOMER As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label18 As Label
    Friend WithEvents PINNO As TextBox
    Friend WithEvents PIN As Label
    Friend WithEvents CARDNUMBER As TextBox
    Friend WithEvents CARDNO As Label
    Friend WithEvents PD As Printing.PrintDocument
    Friend WithEvents PPD As PrintPreviewDialog
    Friend WithEvents Timer1 As Timer
End Class
