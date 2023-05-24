<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setRate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(setRate))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.mtgDate = New System.Windows.Forms.DateTimePicker()
        Me.miscLabel = New System.Windows.Forms.Label()
        Me.miscLabel1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dated = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.oldRate = New System.Windows.Forms.Label()
        Me.oldRateDate = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.miscLabel2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.miscText = New System.Windows.Forms.TextBox()
        Me.amtPaid = New System.Windows.Forms.TextBox()
        Me.UpdBtn = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.AmdBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.heading = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mtgDate
        '
        Me.mtgDate.CustomFormat = "dd-MMM-yyyy"
        Me.mtgDate.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtgDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mtgDate.Location = New System.Drawing.Point(191, 361)
        Me.mtgDate.Name = "mtgDate"
        Me.mtgDate.Size = New System.Drawing.Size(123, 26)
        Me.mtgDate.TabIndex = 67
        '
        'miscLabel
        '
        Me.miscLabel.AutoSize = True
        Me.miscLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miscLabel.ForeColor = System.Drawing.Color.Red
        Me.miscLabel.Location = New System.Drawing.Point(214, 236)
        Me.miscLabel.Name = "miscLabel"
        Me.miscLabel.Size = New System.Drawing.Size(43, 22)
        Me.miscLabel.TabIndex = 68
        Me.miscLabel.Text = "Misc"
        '
        'miscLabel1
        '
        Me.miscLabel1.AutoSize = True
        Me.miscLabel1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miscLabel1.Location = New System.Drawing.Point(28, 236)
        Me.miscLabel1.Name = "miscLabel1"
        Me.miscLabel1.Size = New System.Drawing.Size(83, 22)
        Me.miscLabel1.TabIndex = 67
        Me.miscLabel1.Text = "Misc Old :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 22)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "With Effect From :"
        '
        'dated
        '
        Me.dated.CustomFormat = "dd-MMM-yyyy"
        Me.dated.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dated.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dated.Location = New System.Drawing.Point(191, 293)
        Me.dated.Name = "dated"
        Me.dated.Size = New System.Drawing.Size(123, 26)
        Me.dated.TabIndex = 65
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 22)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "With Effect From :"
        '
        'oldRate
        '
        Me.oldRate.AutoSize = True
        Me.oldRate.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oldRate.ForeColor = System.Drawing.Color.Red
        Me.oldRate.Location = New System.Drawing.Point(214, 206)
        Me.oldRate.Name = "oldRate"
        Me.oldRate.Size = New System.Drawing.Size(73, 22)
        Me.oldRate.TabIndex = 63
        Me.oldRate.Text = "Old Rate"
        '
        'oldRateDate
        '
        Me.oldRateDate.AutoSize = True
        Me.oldRateDate.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oldRateDate.ForeColor = System.Drawing.Color.Red
        Me.oldRateDate.Location = New System.Drawing.Point(214, 175)
        Me.oldRateDate.Name = "oldRateDate"
        Me.oldRateDate.Size = New System.Drawing.Size(112, 22)
        Me.oldRateDate.TabIndex = 62
        Me.oldRateDate.Text = "Old Rate Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 22)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Old Rate :"
        '
        'miscLabel2
        '
        Me.miscLabel2.AutoSize = True
        Me.miscLabel2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miscLabel2.Location = New System.Drawing.Point(28, 364)
        Me.miscLabel2.Name = "miscLabel2"
        Me.miscLabel2.Size = New System.Drawing.Size(93, 22)
        Me.miscLabel2.TabIndex = 58
        Me.miscLabel2.Text = "Misc New :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(157, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 22)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Rs."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 22)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "New Rate :"
        '
        'miscText
        '
        Me.miscText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miscText.Location = New System.Drawing.Point(191, 361)
        Me.miscText.Name = "miscText"
        Me.miscText.Size = New System.Drawing.Size(185, 26)
        Me.miscText.TabIndex = 67
        Me.miscText.Text = "Enter Text"
        '
        'amtPaid
        '
        Me.amtPaid.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amtPaid.Location = New System.Drawing.Point(191, 327)
        Me.amtPaid.Name = "amtPaid"
        Me.amtPaid.Size = New System.Drawing.Size(123, 26)
        Me.amtPaid.TabIndex = 66
        Me.amtPaid.Text = "0"
        '
        'UpdBtn
        '
        Me.UpdBtn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdBtn.Location = New System.Drawing.Point(422, 323)
        Me.UpdBtn.Name = "UpdBtn"
        Me.UpdBtn.Size = New System.Drawing.Size(89, 31)
        Me.UpdBtn.TabIndex = 74
        Me.UpdBtn.Text = "Update"
        Me.UpdBtn.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.OurFlatsMaint.My.Resources.Resources.curlybClose
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(392, 175)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(18, 82)
        Me.PictureBox3.TabIndex = 75
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.OurFlatsMaint.My.Resources.Resources.curlybClose
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(392, 293)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(18, 93)
        Me.PictureBox4.TabIndex = 75
        Me.PictureBox4.TabStop = False
        '
        'AmdBtn
        '
        Me.AmdBtn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmdBtn.Location = New System.Drawing.Point(422, 199)
        Me.AmdBtn.Name = "AmdBtn"
        Me.AmdBtn.Size = New System.Drawing.Size(89, 31)
        Me.AmdBtn.TabIndex = 74
        Me.AmdBtn.Text = "Amend"
        Me.AmdBtn.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.OurFlatsMaint.My.Resources.Resources.flats
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(463, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(58, 90)
        Me.PictureBox2.TabIndex = 76
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.OurFlatsMaint.My.Resources.Resources.flats
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 90)
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label6.Location = New System.Drawing.Point(100, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(333, 22)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Mohan Nagar, Kothapet, Hyderabad - 500035"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 24)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "FLAT OWNERS' ASSOCIATION - BLOCK-VI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(164, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 22)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "PRAJAY NIVASA - PHASE II"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.heading, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(109, 112)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(315, 27)
        Me.TableLayoutPanel1.TabIndex = 86
        '
        'heading
        '
        Me.heading.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.heading.AutoEllipsis = True
        Me.heading.AutoSize = True
        Me.heading.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heading.ForeColor = System.Drawing.Color.Blue
        Me.heading.Location = New System.Drawing.Point(3, 0)
        Me.heading.Name = "heading"
        Me.heading.Size = New System.Drawing.Size(309, 27)
        Me.heading.TabIndex = 47
        Me.heading.Text = "HEADING"
        Me.heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'setRate
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(533, 425)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.AmdBtn)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.UpdBtn)
        Me.Controls.Add(Me.mtgDate)
        Me.Controls.Add(Me.miscLabel)
        Me.Controls.Add(Me.miscLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dated)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.oldRate)
        Me.Controls.Add(Me.oldRateDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.miscLabel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.miscText)
        Me.Controls.Add(Me.amtPaid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "setRate"
        Me.Text = "setRate"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents mtgDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents miscLabel As System.Windows.Forms.Label
    Friend WithEvents miscLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dated As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents oldRate As System.Windows.Forms.Label
    Friend WithEvents oldRateDate As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents miscLabel2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents miscText As System.Windows.Forms.TextBox
    Friend WithEvents amtPaid As System.Windows.Forms.TextBox
    Friend WithEvents UpdBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents AmdBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents heading As System.Windows.Forms.Label
End Class
