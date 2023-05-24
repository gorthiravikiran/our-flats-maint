<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inMoney
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.flatNo = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dated = New System.Windows.Forms.DateTimePicker()
        Me.varLabel = New System.Windows.Forms.Label()
        Me.rsLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.remarks = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.amtPaid = New System.Windows.Forms.TextBox()
        Me.payBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.balDue = New System.Windows.Forms.TextBox()
        Me.yearLabel = New System.Windows.Forms.Label()
        Me.qtrLabel = New System.Windows.Forms.Label()
        Me.payAmt = New System.Windows.Forms.TextBox()
        Me.formHdg = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.monthLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(390, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Flat Number"
        '
        'flatNo
        '
        Me.flatNo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flatNo.FormattingEnabled = True
        Me.flatNo.Items.AddRange(New Object() {"-Select Flat No-"})
        Me.flatNo.Location = New System.Drawing.Point(502, 226)
        Me.flatNo.Name = "flatNo"
        Me.flatNo.Size = New System.Drawing.Size(143, 30)
        Me.flatNo.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 22)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Date of Payment"
        '
        'dated
        '
        Me.dated.CustomFormat = "dd-MMM-yyyy"
        Me.dated.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dated.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dated.Location = New System.Drawing.Point(193, 232)
        Me.dated.Name = "dated"
        Me.dated.Size = New System.Drawing.Size(114, 26)
        Me.dated.TabIndex = 1
        Me.dated.Value = New Date(2012, 6, 26, 0, 0, 0, 0)
        '
        'varLabel
        '
        Me.varLabel.AutoSize = True
        Me.varLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.varLabel.Location = New System.Drawing.Point(27, 285)
        Me.varLabel.Name = "varLabel"
        Me.varLabel.Size = New System.Drawing.Size(131, 22)
        Me.varLabel.TabIndex = 9
        Me.varLabel.Text = "Amount Payable"
        '
        'rsLabel
        '
        Me.rsLabel.AutoSize = True
        Me.rsLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rsLabel.Location = New System.Drawing.Point(160, 285)
        Me.rsLabel.Name = "rsLabel"
        Me.rsLabel.Size = New System.Drawing.Size(31, 22)
        Me.rsLabel.TabIndex = 9
        Me.rsLabel.Text = "Rs."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 387)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 22)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Remarks"
        '
        'remarks
        '
        Me.remarks.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.remarks.Location = New System.Drawing.Point(108, 378)
        Me.remarks.Name = "remarks"
        Me.remarks.Size = New System.Drawing.Size(537, 45)
        Me.remarks.TabIndex = 6
        Me.remarks.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(350, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 22)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Amount Received"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(498, 284)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 22)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Rs."
        '
        'amtPaid
        '
        Me.amtPaid.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amtPaid.Location = New System.Drawing.Point(535, 281)
        Me.amtPaid.Name = "amtPaid"
        Me.amtPaid.Size = New System.Drawing.Size(110, 26)
        Me.amtPaid.TabIndex = 4
        Me.amtPaid.Text = "Enter Amount"
        '
        'payBtn
        '
        Me.payBtn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payBtn.Location = New System.Drawing.Point(266, 449)
        Me.payBtn.Name = "payBtn"
        Me.payBtn.Size = New System.Drawing.Size(146, 31)
        Me.payBtn.TabIndex = 7
        Me.payBtn.Text = "Deposit"
        Me.payBtn.UseVisualStyleBackColor = True
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
        Me.Panel1.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label6.Location = New System.Drawing.Point(172, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(333, 22)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Mohan Nagar, Kothapet, Hyderabad - 500035"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(229, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 22)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "PRAJAY NIVASA - PHASE II"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 27)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "FLAT  OWNERS ASSOCIATION, BLOCK-VI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Balance Due"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(160, 335)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 22)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Rs."
        '
        'balDue
        '
        Me.balDue.BackColor = System.Drawing.Color.White
        Me.balDue.Enabled = False
        Me.balDue.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balDue.Location = New System.Drawing.Point(193, 333)
        Me.balDue.Name = "balDue"
        Me.balDue.Size = New System.Drawing.Size(114, 26)
        Me.balDue.TabIndex = 5
        Me.balDue.Text = "Balance Amount"
        '
        'yearLabel
        '
        Me.yearLabel.AutoSize = True
        Me.yearLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearLabel.Location = New System.Drawing.Point(531, 335)
        Me.yearLabel.Name = "yearLabel"
        Me.yearLabel.Size = New System.Drawing.Size(56, 22)
        Me.yearLabel.TabIndex = 9
        Me.yearLabel.Text = "Year -"
        Me.yearLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'qtrLabel
        '
        Me.qtrLabel.AutoSize = True
        Me.qtrLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtrLabel.Location = New System.Drawing.Point(350, 337)
        Me.qtrLabel.Name = "qtrLabel"
        Me.qtrLabel.Size = New System.Drawing.Size(50, 22)
        Me.qtrLabel.TabIndex = 9
        Me.qtrLabel.Text = "Qtr - "
        '
        'payAmt
        '
        Me.payAmt.BackColor = System.Drawing.Color.White
        Me.payAmt.Enabled = False
        Me.payAmt.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payAmt.ForeColor = System.Drawing.Color.Black
        Me.payAmt.Location = New System.Drawing.Point(193, 282)
        Me.payAmt.Name = "payAmt"
        Me.payAmt.Size = New System.Drawing.Size(114, 26)
        Me.payAmt.TabIndex = 3
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.formHdg, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(179, 107)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(327, 37)
        Me.TableLayoutPanel1.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(232, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 22)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "CURRENT MONTH :"
        '
        'monthLabel
        '
        Me.monthLabel.AutoSize = True
        Me.monthLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthLabel.ForeColor = System.Drawing.Color.Red
        Me.monthLabel.Location = New System.Drawing.Point(380, 167)
        Me.monthLabel.Name = "monthLabel"
        Me.monthLabel.Size = New System.Drawing.Size(65, 22)
        Me.monthLabel.TabIndex = 34
        Me.monthLabel.Text = "MONTH"
        '
        'inMoney
        '
        Me.AcceptButton = Me.payBtn
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(679, 511)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.monthLabel)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.payBtn)
        Me.Controls.Add(Me.remarks)
        Me.Controls.Add(Me.dated)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.flatNo)
        Me.Controls.Add(Me.payAmt)
        Me.Controls.Add(Me.balDue)
        Me.Controls.Add(Me.amtPaid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.rsLabel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.varLabel)
        Me.Controls.Add(Me.yearLabel)
        Me.Controls.Add(Me.qtrLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "inMoney"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MaintCharges"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents flatNo As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dated As System.Windows.Forms.DateTimePicker
    Friend WithEvents varLabel As System.Windows.Forms.Label
    Friend WithEvents rsLabel As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents remarks As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents amtPaid As System.Windows.Forms.TextBox
    Friend WithEvents payBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents balDue As System.Windows.Forms.TextBox
    Friend WithEvents yearLabel As System.Windows.Forms.Label
    Friend WithEvents qtrLabel As System.Windows.Forms.Label
    Friend WithEvents payAmt As System.Windows.Forms.TextBox
    Friend WithEvents formHdg As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents monthLabel As System.Windows.Forms.Label
End Class
