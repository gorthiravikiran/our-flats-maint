<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class incSumGraph
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(incSumGraph))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.FlatsIncomeSumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlatsDataSet = New OurFlatsMaint.FlatsDataSet()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.incomeHdg = New System.Windows.Forms.Label()
        Me.Flats_Income_Sum_TableAdapter = New OurFlatsMaint.FlatsDataSetTableAdapters.Monthly_Income_SumTableAdapter()
        Me.printBtn = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlatsIncomeSumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlatsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BackSecondaryColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.FlatsIncomeSumBindingSource
        Legend1.AutoFitMinFontSize = 9
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Legend1.Title = "Legend"
        Legend1.TitleFont = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.TitleForeColor = System.Drawing.Color.DarkRed
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(7, 55)
        Me.Chart1.Name = "Chart1"
        Series1.BackImage = "None"
        Series1.BackImageTransparentColor = System.Drawing.Color.Transparent
        Series1.BackSecondaryColor = System.Drawing.Color.Transparent
        Series1.BorderColor = System.Drawing.Color.Transparent
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.Color = System.Drawing.Color.Transparent
        Series1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.LabelBackColor = System.Drawing.Color.Gainsboro
        Series1.LabelBorderColor = System.Drawing.Color.Transparent
        Series1.LabelForeColor = System.Drawing.Color.Blue
        Series1.Legend = "Legend1"
        Series1.Name = "Series2"
        Series1.XValueMember = "CATEGORY"
        Series1.YValueMembers = "SAMOUNT"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(609, 436)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title1.Name = "Title1"
        Me.Chart1.Titles.Add(Title1)
        '
        'FlatsIncomeSumBindingSource
        '
        Me.FlatsIncomeSumBindingSource.DataMember = "Monthly_Income_Sum"
        Me.FlatsIncomeSumBindingSource.DataSource = Me.FlatsDataSet
        '
        'FlatsDataSet
        '
        Me.FlatsDataSet.DataSetName = "FlatsDataSet"
        Me.FlatsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.incomeHdg, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(2, 13)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(619, 36)
        Me.TableLayoutPanel4.TabIndex = 22
        '
        'incomeHdg
        '
        Me.incomeHdg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.incomeHdg.AutoSize = True
        Me.incomeHdg.BackColor = System.Drawing.Color.Transparent
        Me.incomeHdg.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incomeHdg.Location = New System.Drawing.Point(3, 0)
        Me.incomeHdg.Name = "incomeHdg"
        Me.incomeHdg.Size = New System.Drawing.Size(613, 36)
        Me.incomeHdg.TabIndex = 16
        Me.incomeHdg.Text = "INCOME SUMMARY HEADING"
        Me.incomeHdg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Flats_Income_Sum_TableAdapter
        '
        Me.Flats_Income_Sum_TableAdapter.ClearBeforeFill = True
        '
        'printBtn
        '
        Me.printBtn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printBtn.Location = New System.Drawing.Point(496, 481)
        Me.printBtn.Name = "printBtn"
        Me.printBtn.Size = New System.Drawing.Size(96, 31)
        Me.printBtn.TabIndex = 23
        Me.printBtn.Text = "Print"
        Me.printBtn.UseVisualStyleBackColor = True
        '
        'incSumGraph
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(623, 545)
        Me.Controls.Add(Me.printBtn)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.Chart1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "incSumGraph"
        Me.Text = "Graphical Representation"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlatsIncomeSumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlatsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents incomeHdg As System.Windows.Forms.Label
    Friend WithEvents FlatsDataSet As OurFlatsMaint.FlatsDataSet
    Friend WithEvents FlatsIncomeSumBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Flats_Income_Sum_TableAdapter As OurFlatsMaint.FlatsDataSetTableAdapters.Monthly_Income_SumTableAdapter
    Friend WithEvents printBtn As System.Windows.Forms.Button
End Class
