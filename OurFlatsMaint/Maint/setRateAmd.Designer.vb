<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setRateAmd
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.heading = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UpdBtn = New System.Windows.Forms.Button()
        Me.mtgDate = New System.Windows.Forms.DateTimePicker()
        Me.dated = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.miscLabel2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.miscText = New System.Windows.Forms.TextBox()
        Me.amtPaid = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.heading, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(110, 129)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(315, 27)
        Me.TableLayoutPanel1.TabIndex = 110
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label6.Location = New System.Drawing.Point(101, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(333, 22)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Mohan Nagar, Kothapet, Hyderabad - 500035"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 24)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "FLAT OWNERS' ASSOCIATION - BLOCK-VI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(165, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 22)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "PRAJAY NIVASA - PHASE II"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.OurFlatsMaint.My.Resources.Resources.flats
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(464, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(58, 90)
        Me.PictureBox2.TabIndex = 105
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.OurFlatsMaint.My.Resources.Resources.flats
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(13, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 90)
        Me.PictureBox1.TabIndex = 106
        Me.PictureBox1.TabStop = False
        '
        'UpdBtn
        '
        Me.UpdBtn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdBtn.Location = New System.Drawing.Point(219, 315)
        Me.UpdBtn.Name = "UpdBtn"
        Me.UpdBtn.Size = New System.Drawing.Size(89, 31)
        Me.UpdBtn.TabIndex = 101
        Me.UpdBtn.Text = "Update"
        Me.UpdBtn.UseVisualStyleBackColor = True
        '
        'mtgDate
        '
        Me.mtgDate.CustomFormat = "dd-MMM-yyyy"
        Me.mtgDate.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtgDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mtgDate.Location = New System.Drawing.Point(249, 252)
        Me.mtgDate.Name = "mtgDate"
        Me.mtgDate.Size = New System.Drawing.Size(123, 26)
        Me.mtgDate.TabIndex = 99
        '
        'dated
        '
        Me.dated.CustomFormat = "dd-MMM-yyyy"
        Me.dated.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dated.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dated.Location = New System.Drawing.Point(249, 184)
        Me.dated.Name = "dated"
        Me.dated.Size = New System.Drawing.Size(123, 26)
        Me.dated.TabIndex = 94
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(86, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 22)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "With Effect From :"
        '
        'miscLabel2
        '
        Me.miscLabel2.AutoSize = True
        Me.miscLabel2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miscLabel2.Location = New System.Drawing.Point(86, 255)
        Me.miscLabel2.Name = "miscLabel2"
        Me.miscLabel2.Size = New System.Drawing.Size(93, 22)
        Me.miscLabel2.TabIndex = 87
        Me.miscLabel2.Text = "Misc New :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(215, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 22)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Rs."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(86, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 22)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "New Rate :"
        '
        'miscText
        '
        Me.miscText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miscText.Location = New System.Drawing.Point(249, 252)
        Me.miscText.Name = "miscText"
        Me.miscText.Size = New System.Drawing.Size(185, 26)
        Me.miscText.TabIndex = 98
        Me.miscText.Text = "Enter Text"
        '
        'amtPaid
        '
        Me.amtPaid.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amtPaid.Location = New System.Drawing.Point(249, 218)
        Me.amtPaid.Name = "amtPaid"
        Me.amtPaid.Size = New System.Drawing.Size(123, 26)
        Me.amtPaid.TabIndex = 95
        Me.amtPaid.Text = "0"
        '
        'setRateAmd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 366)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.UpdBtn)
        Me.Controls.Add(Me.mtgDate)
        Me.Controls.Add(Me.dated)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.miscLabel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.miscText)
        Me.Controls.Add(Me.amtPaid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "setRateAmd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "setRateAmd"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents heading As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents UpdBtn As System.Windows.Forms.Button
    Friend WithEvents mtgDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dated As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents miscLabel2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents miscText As System.Windows.Forms.TextBox
    Friend WithEvents amtPaid As System.Windows.Forms.TextBox

End Class
