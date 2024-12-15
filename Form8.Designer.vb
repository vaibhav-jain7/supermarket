<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.C_PH = New System.Windows.Forms.TextBox()
        Me.C_EMAIL = New System.Windows.Forms.TextBox()
        Me.C_NAME = New System.Windows.Forms.TextBox()
        Me.C_ID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TODY_DATE = New System.Windows.Forms.Label()
        Me.TIME = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.EXISTS = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'C_PH
        '
        Me.C_PH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_PH.Location = New System.Drawing.Point(607, 152)
        Me.C_PH.Name = "C_PH"
        Me.C_PH.Size = New System.Drawing.Size(208, 26)
        Me.C_PH.TabIndex = 64
        '
        'C_EMAIL
        '
        Me.C_EMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_EMAIL.Location = New System.Drawing.Point(607, 115)
        Me.C_EMAIL.Name = "C_EMAIL"
        Me.C_EMAIL.Size = New System.Drawing.Size(208, 26)
        Me.C_EMAIL.TabIndex = 63
        '
        'C_NAME
        '
        Me.C_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_NAME.Location = New System.Drawing.Point(186, 153)
        Me.C_NAME.Name = "C_NAME"
        Me.C_NAME.Size = New System.Drawing.Size(208, 26)
        Me.C_NAME.TabIndex = 61
        '
        'C_ID
        '
        Me.C_ID.Enabled = False
        Me.C_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_ID.Location = New System.Drawing.Point(186, 114)
        Me.C_ID.Name = "C_ID"
        Me.C_ID.Size = New System.Drawing.Size(208, 26)
        Me.C_ID.TabIndex = 60
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 24)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "CUSTOMER ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(435, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 24)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "EMAIL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(435, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 24)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "PHONE NO."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 24)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "NAME"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(12, 29)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(60, 20)
        Me.Label27.TabIndex = 76
        Me.Label27.Text = "DATE :"
        '
        'TODY_DATE
        '
        Me.TODY_DATE.AutoSize = True
        Me.TODY_DATE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TODY_DATE.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.TODY_DATE.Location = New System.Drawing.Point(83, 29)
        Me.TODY_DATE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TODY_DATE.Name = "TODY_DATE"
        Me.TODY_DATE.Size = New System.Drawing.Size(42, 21)
        Me.TODY_DATE.TabIndex = 75
        Me.TODY_DATE.Text = "Date"
        '
        'TIME
        '
        Me.TIME.AutoSize = True
        Me.TIME.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIME.Location = New System.Drawing.Point(750, 26)
        Me.TIME.Name = "TIME"
        Me.TIME.Size = New System.Drawing.Size(60, 20)
        Me.TIME.TabIndex = 97
        Me.TIME.Text = "label33"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(756, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(666, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "EMP ID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(666, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Time : "
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(151, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 35)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "NEW CUSTOMER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(552, 280)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 35)
        Me.Button2.TabIndex = 99
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'EXISTS
        '
        Me.EXISTS.Enabled = False
        Me.EXISTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXISTS.Location = New System.Drawing.Point(349, 280)
        Me.EXISTS.Name = "EXISTS"
        Me.EXISTS.Size = New System.Drawing.Size(120, 35)
        Me.EXISTS.TabIndex = 100
        Me.EXISTS.Text = "EXISTS"
        Me.EXISTS.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 327)
        Me.Controls.Add(Me.EXISTS)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TIME)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.TODY_DATE)
        Me.Controls.Add(Me.C_PH)
        Me.Controls.Add(Me.C_EMAIL)
        Me.Controls.Add(Me.C_NAME)
        Me.Controls.Add(Me.C_ID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Form8"
        Me.Text = "Form8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents C_PH As TextBox
    Friend WithEvents C_EMAIL As TextBox
    Friend WithEvents C_NAME As TextBox
    Friend WithEvents C_ID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents TODY_DATE As Label
    Friend WithEvents TIME As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents EXISTS As Button
    Friend WithEvents Timer1 As Timer
End Class
