<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class oldDuesDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(oldDuesDetails))
        Me.FlatS_INCOMETableAdapter1 = New OurFlatsMaint.FlatsDataSetTableAdapters.FLATS_INCOMETableAdapter()
        Me.hdg1 = New System.Windows.Forms.Label()
        Me.graphBtn = New System.Windows.Forms.Button()
        Me.hdg2 = New System.Windows.Forms.Label()
        Me.GrandTotalTablePanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TotalsTablePanel = New System.Windows.Forms.TableLayoutPanel()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.monthHdgTablePanel = New System.Windows.Forms.TableLayoutPanel()
        Me.hdg3 = New System.Windows.Forms.Label()
        Me.hdg4 = New System.Windows.Forms.Label()
        Me.hdg6 = New System.Windows.Forms.Label()
        Me.hdg5 = New System.Windows.Forms.Label()
        Me.hdg8 = New System.Windows.Forms.Label()
        Me.monthIncDataTablePanel = New System.Windows.Forms.TableLayoutPanel()
        Me.incomeHdg = New System.Windows.Forms.Label()
        Me.printBtn = New System.Windows.Forms.Button()
        Me.totalAmtWords = New System.Windows.Forms.Label()
        Me.totalsHdg = New System.Windows.Forms.Label()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.monthHdgTablePanel.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlatS_INCOMETableAdapter1
        '
        Me.FlatS_INCOMETableAdapter1.ClearBeforeFill = True
        '
        'hdg1
        '
        Me.hdg1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hdg1.AutoSize = True
        Me.hdg1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdg1.Location = New System.Drawing.Point(4, 1)
        Me.hdg1.Name = "hdg1"
        Me.hdg1.Size = New System.Drawing.Size(30, 40)
        Me.hdg1.TabIndex = 0
        Me.hdg1.Text = "Sl. No"
        Me.hdg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'graphBtn
        '
        Me.graphBtn.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graphBtn.Location = New System.Drawing.Point(796, 18)
        Me.graphBtn.Name = "graphBtn"
        Me.graphBtn.Size = New System.Drawing.Size(99, 26)
        Me.graphBtn.TabIndex = 55
        Me.graphBtn.Text = "Show Graph"
        Me.graphBtn.UseVisualStyleBackColor = True
        '
        'hdg2
        '
        Me.hdg2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hdg2.AutoSize = True
        Me.hdg2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdg2.Location = New System.Drawing.Point(41, 1)
        Me.hdg2.Name = "hdg2"
        Me.hdg2.Size = New System.Drawing.Size(51, 40)
        Me.hdg2.TabIndex = 0
        Me.hdg2.Text = "Flat No."
        Me.hdg2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrandTotalTablePanel
        '
        Me.GrandTotalTablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GrandTotalTablePanel.BackColor = System.Drawing.Color.Transparent
        Me.GrandTotalTablePanel.BackgroundImage = CType(resources.GetObject("GrandTotalTablePanel.BackgroundImage"), System.Drawing.Image)
        Me.GrandTotalTablePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GrandTotalTablePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.GrandTotalTablePanel.ColumnCount = 3
        Me.GrandTotalTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 288.0!))
        Me.GrandTotalTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.GrandTotalTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.GrandTotalTablePanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GrandTotalTablePanel.Location = New System.Drawing.Point(206, 235)
        Me.GrandTotalTablePanel.Name = "GrandTotalTablePanel"
        Me.GrandTotalTablePanel.RowCount = 1
        Me.GrandTotalTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.GrandTotalTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.GrandTotalTablePanel.Size = New System.Drawing.Size(503, 33)
        Me.GrandTotalTablePanel.TabIndex = 54
        '
        'TotalsTablePanel
        '
        Me.TotalsTablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TotalsTablePanel.BackColor = System.Drawing.Color.White
        Me.TotalsTablePanel.BackgroundImage = Global.OurFlatsMaint.My.Resources.Resources.btn1
        Me.TotalsTablePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TotalsTablePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TotalsTablePanel.ColumnCount = 3
        Me.TotalsTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 288.0!))
        Me.TotalsTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TotalsTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197.0!))
        Me.TotalsTablePanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TotalsTablePanel.Location = New System.Drawing.Point(206, 203)
        Me.TotalsTablePanel.Name = "TotalsTablePanel"
        Me.TotalsTablePanel.RowCount = 1
        Me.TotalsTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TotalsTablePanel.Size = New System.Drawing.Size(503, 33)
        Me.TotalsTablePanel.TabIndex = 50
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'monthHdgTablePanel
        '
        Me.monthHdgTablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.monthHdgTablePanel.BackColor = System.Drawing.Color.Transparent
        Me.monthHdgTablePanel.BackgroundImage = CType(resources.GetObject("monthHdgTablePanel.BackgroundImage"), System.Drawing.Image)
        Me.monthHdgTablePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.monthHdgTablePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.monthHdgTablePanel.ColumnCount = 7
        Me.monthHdgTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.monthHdgTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.monthHdgTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.monthHdgTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214.0!))
        Me.monthHdgTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.monthHdgTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127.0!))
        Me.monthHdgTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 253.0!))
        Me.monthHdgTablePanel.Controls.Add(Me.hdg1, 0, 0)
        Me.monthHdgTablePanel.Controls.Add(Me.hdg2, 1, 0)
        Me.monthHdgTablePanel.Controls.Add(Me.hdg3, 2, 0)
        Me.monthHdgTablePanel.Controls.Add(Me.hdg4, 3, 0)
        Me.monthHdgTablePanel.Controls.Add(Me.hdg6, 5, 0)
        Me.monthHdgTablePanel.Controls.Add(Me.hdg5, 4, 0)
        Me.monthHdgTablePanel.Controls.Add(Me.hdg8, 6, 0)
        Me.monthHdgTablePanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.monthHdgTablePanel.Location = New System.Drawing.Point(17, 69)
        Me.monthHdgTablePanel.Name = "monthHdgTablePanel"
        Me.monthHdgTablePanel.RowCount = 1
        Me.monthHdgTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.monthHdgTablePanel.Size = New System.Drawing.Size(879, 42)
        Me.monthHdgTablePanel.TabIndex = 48
        '
        'hdg3
        '
        Me.hdg3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hdg3.AutoSize = True
        Me.hdg3.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdg3.Location = New System.Drawing.Point(99, 11)
        Me.hdg3.Name = "hdg3"
        Me.hdg3.Size = New System.Drawing.Size(100, 20)
        Me.hdg3.TabIndex = 0
        Me.hdg3.Text = "Amount Paid"
        Me.hdg3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdg4
        '
        Me.hdg4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hdg4.AutoSize = True
        Me.hdg4.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdg4.Location = New System.Drawing.Point(206, 11)
        Me.hdg4.Name = "hdg4"
        Me.hdg4.Size = New System.Drawing.Size(208, 20)
        Me.hdg4.TabIndex = 0
        Me.hdg4.Text = "Payment Category"
        Me.hdg4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdg6
        '
        Me.hdg6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hdg6.AutoSize = True
        Me.hdg6.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdg6.Location = New System.Drawing.Point(515, 11)
        Me.hdg6.Name = "hdg6"
        Me.hdg6.Size = New System.Drawing.Size(121, 20)
        Me.hdg6.TabIndex = 0
        Me.hdg6.Text = "Receipt Dated"
        Me.hdg6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdg5
        '
        Me.hdg5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hdg5.AutoSize = True
        Me.hdg5.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdg5.Location = New System.Drawing.Point(421, 1)
        Me.hdg5.Name = "hdg5"
        Me.hdg5.Size = New System.Drawing.Size(87, 40)
        Me.hdg5.TabIndex = 0
        Me.hdg5.Text = "Receipt No."
        Me.hdg5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdg8
        '
        Me.hdg8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.hdg8.AutoSize = True
        Me.hdg8.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdg8.Location = New System.Drawing.Point(732, 1)
        Me.hdg8.Name = "hdg8"
        Me.hdg8.Size = New System.Drawing.Size(68, 40)
        Me.hdg8.TabIndex = 0
        Me.hdg8.Text = "Remarks"
        Me.hdg8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'monthIncDataTablePanel
        '
        Me.monthIncDataTablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.monthIncDataTablePanel.BackColor = System.Drawing.Color.White
        Me.monthIncDataTablePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.monthIncDataTablePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.monthIncDataTablePanel.ColumnCount = 7
        Me.monthIncDataTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.monthIncDataTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.monthIncDataTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.monthIncDataTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214.0!))
        Me.monthIncDataTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.monthIncDataTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127.0!))
        Me.monthIncDataTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 253.0!))
        Me.monthIncDataTablePanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.monthIncDataTablePanel.Location = New System.Drawing.Point(17, 110)
        Me.monthIncDataTablePanel.Name = "monthIncDataTablePanel"
        Me.monthIncDataTablePanel.RowCount = 1
        Me.monthIncDataTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.monthIncDataTablePanel.Size = New System.Drawing.Size(879, 33)
        Me.monthIncDataTablePanel.TabIndex = 49
        '
        'incomeHdg
        '
        Me.incomeHdg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.incomeHdg.AutoSize = True
        Me.incomeHdg.BackColor = System.Drawing.Color.Transparent
        Me.incomeHdg.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incomeHdg.Location = New System.Drawing.Point(3, 0)
        Me.incomeHdg.Name = "incomeHdg"
        Me.incomeHdg.Size = New System.Drawing.Size(872, 36)
        Me.incomeHdg.TabIndex = 16
        Me.incomeHdg.Text = "INCOME SUMMARY HEADING"
        Me.incomeHdg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'printBtn
        '
        Me.printBtn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printBtn.Location = New System.Drawing.Point(400, 338)
        Me.printBtn.Name = "printBtn"
        Me.printBtn.Size = New System.Drawing.Size(112, 31)
        Me.printBtn.TabIndex = 56
        Me.printBtn.Text = "Print"
        Me.printBtn.UseVisualStyleBackColor = True
        '
        'totalAmtWords
        '
        Me.totalAmtWords.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totalAmtWords.AutoSize = True
        Me.totalAmtWords.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalAmtWords.Location = New System.Drawing.Point(4, 1)
        Me.totalAmtWords.Name = "totalAmtWords"
        Me.totalAmtWords.Size = New System.Drawing.Size(871, 29)
        Me.totalAmtWords.TabIndex = 1
        Me.totalAmtWords.Text = "Total Amount Collected was - "
        Me.totalAmtWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalsHdg
        '
        Me.totalsHdg.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.totalsHdg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totalsHdg.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalsHdg.Location = New System.Drawing.Point(271, 161)
        Me.totalsHdg.Name = "totalsHdg"
        Me.totalsHdg.Size = New System.Drawing.Size(372, 18)
        Me.totalsHdg.TabIndex = 53
        Me.totalsHdg.Text = "TOTAL AMOUNT COLLECTED IN THIS QUARTER"
        Me.totalsHdg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel8.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 877.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.totalAmtWords, 0, 0)
        Me.TableLayoutPanel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(17, 295)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(876, 31)
        Me.TableLayoutPanel8.TabIndex = 52
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.incomeHdg, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(18, 13)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(878, 36)
        Me.TableLayoutPanel4.TabIndex = 51
        '
        'oldDuesList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 645)
        Me.Controls.Add(Me.graphBtn)
        Me.Controls.Add(Me.GrandTotalTablePanel)
        Me.Controls.Add(Me.TotalsTablePanel)
        Me.Controls.Add(Me.monthHdgTablePanel)
        Me.Controls.Add(Me.monthIncDataTablePanel)
        Me.Controls.Add(Me.printBtn)
        Me.Controls.Add(Me.totalsHdg)
        Me.Controls.Add(Me.TableLayoutPanel8)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Name = "oldDuesList"
        Me.Text = "oldDuesList"
        Me.monthHdgTablePanel.ResumeLayout(False)
        Me.monthHdgTablePanel.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlatS_INCOMETableAdapter1 As OurFlatsMaint.FlatsDataSetTableAdapters.FLATS_INCOMETableAdapter
    Friend WithEvents hdg1 As System.Windows.Forms.Label
    Friend WithEvents graphBtn As System.Windows.Forms.Button
    Friend WithEvents hdg2 As System.Windows.Forms.Label
    Friend WithEvents GrandTotalTablePanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TotalsTablePanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents monthHdgTablePanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents hdg3 As System.Windows.Forms.Label
    Friend WithEvents hdg4 As System.Windows.Forms.Label
    Friend WithEvents hdg6 As System.Windows.Forms.Label
    Friend WithEvents hdg5 As System.Windows.Forms.Label
    Friend WithEvents hdg8 As System.Windows.Forms.Label
    Friend WithEvents monthIncDataTablePanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents incomeHdg As System.Windows.Forms.Label
    Friend WithEvents printBtn As System.Windows.Forms.Button
    Friend WithEvents totalAmtWords As System.Windows.Forms.Label
    Friend WithEvents totalsHdg As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
End Class
