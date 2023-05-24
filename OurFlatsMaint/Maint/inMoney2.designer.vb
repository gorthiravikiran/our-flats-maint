<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inMoney2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inMoney2))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.monthLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.formHdg = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.payBtn = New System.Windows.Forms.Button()
        Me.remarks = New System.Windows.Forms.RichTextBox()
        Me.dated = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.flatNo = New System.Windows.Forms.ComboBox()
        Me.dName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.amtPaid = New System.Windows.Forms.TextBox()
        Me.rsLabel = New System.Windows.Forms.Label()
        Me.varLabel2 = New System.Windows.Forms.Label()
        Me.varLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.purpose = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.OurFlatsMaint.My.Resources.Resources.flats
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(8, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 104)
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
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
        Me.Panel1.TabIndex = 65
        '
        'monthLabel
        '
        Me.monthLabel.AutoSize = True
        Me.monthLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthLabel.ForeColor = System.Drawing.Color.Red
        Me.monthLabel.Location = New System.Drawing.Point(380, 167)
        Me.monthLabel.Name = "monthLabel"
        Me.monthLabel.Size = New System.Drawing.Size(65, 22)
        Me.monthLabel.TabIndex = 63
        Me.monthLabel.Text = "MONTH"
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
        Me.TableLayoutPanel1.TabIndex = 66
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(232, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 22)
        Me.Label12.TabIndex = 64
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
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Mohan Nagar, Kothapet, Hyderabad - 500035"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(229, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 22)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "PRAJAY NIVASA - PHASE II"
        '
        'payBtn
        '
        Me.payBtn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payBtn.Location = New System.Drawing.Point(286, 398)
        Me.payBtn.Name = "payBtn"
        Me.payBtn.Size = New System.Drawing.Size(146, 31)
        Me.payBtn.TabIndex = 80
        Me.payBtn.Text = "Deposit"
        Me.payBtn.UseVisualStyleBackColor = True
        '
        'remarks
        '
        Me.remarks.Location = New System.Drawing.Point(184, 333)
        Me.remarks.Name = "remarks"
        Me.remarks.Size = New System.Drawing.Size(472, 45)
        Me.remarks.TabIndex = 79
        Me.remarks.Text = ""
        '
        'dated
        '
        Me.dated.CustomFormat = "dd-MMM-yyyy"
        Me.dated.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dated.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dated.Location = New System.Drawing.Point(184, 234)
        Me.dated.Name = "dated"
        Me.dated.Size = New System.Drawing.Size(114, 26)
        Me.dated.TabIndex = 78
        Me.dated.Value = New Date(2012, 6, 26, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 22)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Date of Payment"
        '
        'flatNo
        '
        Me.flatNo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flatNo.FormattingEnabled = True
        Me.flatNo.Items.AddRange(New Object() {"-Select Flat No-", "Others"})
        Me.flatNo.Location = New System.Drawing.Point(513, 228)
        Me.flatNo.Name = "flatNo"
        Me.flatNo.Size = New System.Drawing.Size(143, 30)
        Me.flatNo.TabIndex = 68
        '
        'dName
        '
        Me.dName.BackColor = System.Drawing.Color.White
        Me.dName.Enabled = False
        Me.dName.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dName.ForeColor = System.Drawing.Color.Black
        Me.dName.Location = New System.Drawing.Point(184, 285)
        Me.dName.Name = "dName"
        Me.dName.Size = New System.Drawing.Size(151, 26)
        Me.dName.TabIndex = 69
        Me.dName.Text = "Enter Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(509, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 22)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Rs."
        '
        'amtPaid
        '
        Me.amtPaid.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amtPaid.Location = New System.Drawing.Point(546, 285)
        Me.amtPaid.Name = "amtPaid"
        Me.amtPaid.Size = New System.Drawing.Size(110, 26)
        Me.amtPaid.TabIndex = 70
        Me.amtPaid.Text = "Enter Amount"
        '
        'rsLabel
        '
        Me.rsLabel.AutoSize = True
        Me.rsLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rsLabel.Location = New System.Drawing.Point(152, 287)
        Me.rsLabel.Name = "rsLabel"
        Me.rsLabel.Size = New System.Drawing.Size(33, 22)
        Me.rsLabel.TabIndex = 73
        Me.rsLabel.Text = "Mr."
        '
        'varLabel2
        '
        Me.varLabel2.AutoSize = True
        Me.varLabel2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.varLabel2.Location = New System.Drawing.Point(17, 342)
        Me.varLabel2.Name = "varLabel2"
        Me.varLabel2.Size = New System.Drawing.Size(75, 22)
        Me.varLabel2.TabIndex = 75
        Me.varLabel2.Text = "Remarks"
        '
        'varLabel
        '
        Me.varLabel.AutoSize = True
        Me.varLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.varLabel.Location = New System.Drawing.Point(17, 287)
        Me.varLabel.Name = "varLabel"
        Me.varLabel.Size = New System.Drawing.Size(95, 22)
        Me.varLabel.TabIndex = 74
        Me.varLabel.Text = "Donated By"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(361, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 22)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Amount Received"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(401, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 22)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Flat Number"
        '
        'purpose
        '
        Me.purpose.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purpose.FormattingEnabled = True
        Me.purpose.Items.AddRange(New Object() {"-Select Purpose-", "Bore Repair", "New Sump", "Lift Repair", "Pipelines Repair", "Repainting"})
        Me.purpose.Location = New System.Drawing.Point(184, 334)
        Me.purpose.Name = "purpose"
        Me.purpose.Size = New System.Drawing.Size(248, 30)
        Me.purpose.TabIndex = 81
        Me.purpose.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 27)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "FLAT  OWNERS ASSOCIATION, BLOCK-VI"
        '
        'inMoney2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(679, 461)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.purpose)
        Me.Controls.Add(Me.payBtn)
        Me.Controls.Add(Me.remarks)
        Me.Controls.Add(Me.dated)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.flatNo)
        Me.Controls.Add(Me.dName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.amtPaid)
        Me.Controls.Add(Me.rsLabel)
        Me.Controls.Add(Me.varLabel2)
        Me.Controls.Add(Me.varLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.monthLabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "inMoney2"
        Me.Text = "donations"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents monthLabel As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents formHdg As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents payBtn As System.Windows.Forms.Button
    Friend WithEvents remarks As System.Windows.Forms.RichTextBox
    Friend WithEvents dated As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents flatNo As System.Windows.Forms.ComboBox
    Friend WithEvents dName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents amtPaid As System.Windows.Forms.TextBox
    Friend WithEvents rsLabel As System.Windows.Forms.Label
    Friend WithEvents varLabel2 As System.Windows.Forms.Label
    Friend WithEvents varLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents purpose As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
