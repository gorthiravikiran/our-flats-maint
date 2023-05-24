<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class outMoney
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.monthLabel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.remarks = New System.Windows.Forms.RichTextBox()
        Me.dated = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nowPayable = New System.Windows.Forms.TextBox()
        Me.amtPaid = New System.Windows.Forms.TextBox()
        Me.totalPayable = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.varLabel = New System.Windows.Forms.Label()
        Me.yearLabel = New System.Windows.Forms.Label()
        Me.qtrLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rsLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.preDue = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.balDue = New System.Windows.Forms.TextBox()
        Me.payBtn = New System.Windows.Forms.Button()
        Me.expPurpose = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.formHdg = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.OurFlatsMaint.My.Resources.Resources.flats
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(14, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 104)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 27)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "FLAT  OWNERS ASSOCIATION, BLOCK-VI"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Location = New System.Drawing.Point(273, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 0)
        Me.Panel1.TabIndex = 94
        '
        'monthLabel
        '
        Me.monthLabel.AutoSize = True
        Me.monthLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthLabel.ForeColor = System.Drawing.Color.Red
        Me.monthLabel.Location = New System.Drawing.Point(380, 167)
        Me.monthLabel.Name = "monthLabel"
        Me.monthLabel.Size = New System.Drawing.Size(65, 22)
        Me.monthLabel.TabIndex = 92
        Me.monthLabel.Text = "MONTH"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(232, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 22)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "CURRENT MONTH :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label6.Location = New System.Drawing.Point(172, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(333, 22)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Mohan Nagar, Kothapet, Hyderabad - 500035"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(229, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 22)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "PRAJAY NIVASA - PHASE II"
        '
        'remarks
        '
        Me.remarks.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.remarks.Location = New System.Drawing.Point(108, 419)
        Me.remarks.Name = "remarks"
        Me.remarks.Size = New System.Drawing.Size(537, 45)
        Me.remarks.TabIndex = 8
        Me.remarks.Text = ""
        '
        'dated
        '
        Me.dated.CustomFormat = "dd-MMM-yyyy"
        Me.dated.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dated.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dated.Location = New System.Drawing.Point(193, 234)
        Me.dated.Name = "dated"
        Me.dated.Size = New System.Drawing.Size(114, 26)
        Me.dated.TabIndex = 1
        Me.dated.Value = New Date(2013, 1, 11, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 22)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "Date of Payment"
        '
        'nowPayable
        '
        Me.nowPayable.BackColor = System.Drawing.Color.White
        Me.nowPayable.Enabled = False
        Me.nowPayable.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nowPayable.ForeColor = System.Drawing.Color.Black
        Me.nowPayable.Location = New System.Drawing.Point(193, 279)
        Me.nowPayable.Name = "nowPayable"
        Me.nowPayable.Size = New System.Drawing.Size(114, 26)
        Me.nowPayable.TabIndex = 3
        Me.nowPayable.Text = "0"
        '
        'amtPaid
        '
        Me.amtPaid.BackColor = System.Drawing.Color.White
        Me.amtPaid.Enabled = False
        Me.amtPaid.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amtPaid.Location = New System.Drawing.Point(193, 326)
        Me.amtPaid.Name = "amtPaid"
        Me.amtPaid.Size = New System.Drawing.Size(114, 26)
        Me.amtPaid.TabIndex = 5
        Me.amtPaid.Text = "0"
        '
        'totalPayable
        '
        Me.totalPayable.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPayable.Location = New System.Drawing.Point(531, 279)
        Me.totalPayable.Name = "totalPayable"
        Me.totalPayable.Size = New System.Drawing.Size(114, 26)
        Me.totalPayable.TabIndex = 4
        Me.totalPayable.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(160, 328)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 22)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "Rs."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(494, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 22)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Rs."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 428)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 22)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Remarks"
        '
        'varLabel
        '
        Me.varLabel.AutoSize = True
        Me.varLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.varLabel.Location = New System.Drawing.Point(27, 282)
        Me.varLabel.Name = "varLabel"
        Me.varLabel.Size = New System.Drawing.Size(107, 22)
        Me.varLabel.TabIndex = 105
        Me.varLabel.Text = "Now Payable"
        '
        'yearLabel
        '
        Me.yearLabel.AutoSize = True
        Me.yearLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearLabel.Location = New System.Drawing.Point(531, 375)
        Me.yearLabel.Name = "yearLabel"
        Me.yearLabel.Size = New System.Drawing.Size(56, 22)
        Me.yearLabel.TabIndex = 104
        Me.yearLabel.Text = "Year -"
        Me.yearLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'qtrLabel
        '
        Me.qtrLabel.AutoSize = True
        Me.qtrLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtrLabel.Location = New System.Drawing.Point(350, 377)
        Me.qtrLabel.Name = "qtrLabel"
        Me.qtrLabel.Size = New System.Drawing.Size(50, 22)
        Me.qtrLabel.TabIndex = 108
        Me.qtrLabel.Text = "Qtr - "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 22)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Amount Paid"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(350, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 22)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "Total to be Paid"
        '
        'rsLabel
        '
        Me.rsLabel.AutoSize = True
        Me.rsLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rsLabel.Location = New System.Drawing.Point(160, 282)
        Me.rsLabel.Name = "rsLabel"
        Me.rsLabel.Size = New System.Drawing.Size(31, 22)
        Me.rsLabel.TabIndex = 107
        Me.rsLabel.Text = "Rs."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 377)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 22)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Purpose"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(350, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 22)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "Previous Dues"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(494, 236)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 22)
        Me.Label13.TabIndex = 107
        Me.Label13.Text = "Rs."
        '
        'preDue
        '
        Me.preDue.BackColor = System.Drawing.Color.White
        Me.preDue.Enabled = False
        Me.preDue.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preDue.ForeColor = System.Drawing.Color.Black
        Me.preDue.Location = New System.Drawing.Point(531, 233)
        Me.preDue.Name = "preDue"
        Me.preDue.Size = New System.Drawing.Size(114, 26)
        Me.preDue.TabIndex = 2
        Me.preDue.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(350, 328)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 22)
        Me.Label14.TabIndex = 111
        Me.Label14.Text = "Balance Due"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(494, 328)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 22)
        Me.Label15.TabIndex = 103
        Me.Label15.Text = "Rs."
        '
        'balDue
        '
        Me.balDue.BackColor = System.Drawing.Color.White
        Me.balDue.Enabled = False
        Me.balDue.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balDue.Location = New System.Drawing.Point(531, 326)
        Me.balDue.Name = "balDue"
        Me.balDue.Size = New System.Drawing.Size(114, 26)
        Me.balDue.TabIndex = 6
        Me.balDue.Text = "0"
        '
        'payBtn
        '
        Me.payBtn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payBtn.Location = New System.Drawing.Point(266, 487)
        Me.payBtn.Name = "payBtn"
        Me.payBtn.Size = New System.Drawing.Size(146, 31)
        Me.payBtn.TabIndex = 9
        Me.payBtn.Text = "Make Payment"
        Me.payBtn.UseVisualStyleBackColor = True
        '
        'expPurpose
        '
        Me.expPurpose.BackColor = System.Drawing.Color.White
        Me.expPurpose.Enabled = False
        Me.expPurpose.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expPurpose.Location = New System.Drawing.Point(108, 374)
        Me.expPurpose.Name = "expPurpose"
        Me.expPurpose.Size = New System.Drawing.Size(223, 26)
        Me.expPurpose.TabIndex = 7
        Me.expPurpose.Text = "0"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.OurFlatsMaint.My.Resources.Resources.flats
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(569, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(91, 104)
        Me.PictureBox2.TabIndex = 46
        Me.PictureBox2.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.formHdg, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(173, 107)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(327, 37)
        Me.TableLayoutPanel1.TabIndex = 114
        '
        'formHdg
        '
        Me.formHdg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.formHdg.AutoSize = True
        Me.formHdg.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formHdg.Location = New System.Drawing.Point(3, 0)
        Me.formHdg.Name = "formHdg"
        Me.formHdg.Size = New System.Drawing.Size(321, 37)
        Me.formHdg.TabIndex = 25
        Me.formHdg.Text = "HEADING"
        Me.formHdg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'outMoney
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(672, 542)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.payBtn)
        Me.Controls.Add(Me.remarks)
        Me.Controls.Add(Me.dated)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.preDue)
        Me.Controls.Add(Me.nowPayable)
        Me.Controls.Add(Me.balDue)
        Me.Controls.Add(Me.expPurpose)
        Me.Controls.Add(Me.amtPaid)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.totalPayable)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.rsLabel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.varLabel)
        Me.Controls.Add(Me.yearLabel)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.qtrLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.monthLabel)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "outMoney"
        Me.Text = "oldDues"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents monthLabel As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents remarks As System.Windows.Forms.RichTextBox
    Friend WithEvents dated As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nowPayable As System.Windows.Forms.TextBox
    Friend WithEvents amtPaid As System.Windows.Forms.TextBox
    Friend WithEvents totalPayable As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents varLabel As System.Windows.Forms.Label
    Friend WithEvents yearLabel As System.Windows.Forms.Label
    Friend WithEvents qtrLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rsLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents preDue As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents balDue As System.Windows.Forms.TextBox
    Friend WithEvents payBtn As System.Windows.Forms.Button
    Friend WithEvents expPurpose As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents formHdg As System.Windows.Forms.Label
End Class
