Imports Microsoft.VisualBasic.PowerPacks.Printing

Public Class incSummary

    Private Sub incSumMon_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        myWinStatus.setWinState("incomeSumClose")
        PrintDialog1.Dispose()
    End Sub

    Private Sub incomeSumFig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dTable As New DataTable

        If getSelectedPeriod() = "MONTHLY" Then
            dTable = fetchIncomeSumByMonth()
            incomeHdg.Text = "INCOME SUMMARY : " & fetchMonthExpand(getSelectedMonth())
        ElseIf getSelectedPeriod() = "QUARTERLY" Then
            dTable = fetchIncomeSumByQtr()
            incomeHdg.Text = "INCOME SUMMARY : " & getSelectedQtr() & " QUARTER"
        ElseIf getSelectedPeriod() = "ANNUAL" Then
            dTable = fetchIncomeSumByYear()
            incomeHdg.Text = "INCOME SUMMARY OF THE YEAR : " & getSelectedYear()
        End If

        ' First Block '

        'Add new Row
        For i As Integer = 0 To dTable.Rows.Count - 1
            For j As Integer = 0 To dTable.Columns.Count - 7

                'Add Data labels
                Dim lbldata As System.Windows.Forms.Label
                lbldata = New System.Windows.Forms.Label
                lbldata.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                lbldata.AutoSize = True
                lbldata.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                lbldata.ForeColor = System.Drawing.SystemColors.ControlText
                lbldata.Location = New System.Drawing.Point(4, 7)
                lbldata.Name = "data" & i + 1
                lbldata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

                'Add data to label
                If j = 0 Then
                    lbldata.Text = i + 1 & "."
                ElseIf j = 1 Then
                    lbldata.Text = dTable.Rows(i)("flat_no").ToString
                ElseIf j = 2 Then
                    lbldata.Text = "Rs. " & dTable.Rows(i)("amount").ToString & "/-"
                ElseIf j = 3 Then
                    If dTable.Rows(i)("category").ToString = "MAINT_CHARGES" Then
                        lbldata.Text = "MAINTENANCE CHARGES"
                    ElseIf dTable.Rows(i)("category").ToString = "OLD_DUES" Then
                        lbldata.Text = "OLD DUES"
                    ElseIf dTable.Rows(i)("category").ToString = "SPECIAL_FUNDS" Then
                        lbldata.Text = "SPECIAL FUNDS"
                    Else
                        lbldata.Text = dTable.Rows(i)("category").ToString
                    End If
                ElseIf j = 4 Then
                    lbldata.Text = dTable.Rows(i)("receipt_no").ToString
                ElseIf j = 5 Then
                    lbldata.Text = dTable.Rows(i)("receipt_dated").ToString
                ElseIf j = 6 Then
                    lbldata.Text = dTable.Rows(i)("remarks").ToString
                End If
                monthIncDataTablePanel.Controls.Add(lbldata, j, i)
            Next
            monthIncDataTablePanel.Height += 28
            monthIncDataTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Next

        ' Second Block '

        'Add TData labels
        Dim aList As ArrayList = fetchIncomeSumByMonthTotals()
        Dim y As Integer = 0
        For k As Integer = 0 To aList.Count - 1
            Dim lbldata1 As System.Windows.Forms.Label
            lbldata1 = New System.Windows.Forms.Label
            lbldata1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            lbldata1.AutoSize = True
            lbldata1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lbldata1.ForeColor = System.Drawing.SystemColors.ControlText
            lbldata1.BackColor = System.Drawing.Color.Transparent
            lbldata1.Location = New System.Drawing.Point(4, 7)
            lbldata1.Name = "data" & k + 1
            lbldata1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

            Dim pic1 As New System.Windows.Forms.PictureBox()
            pic1.BackgroundImage = Global.OurFlatsMaint.My.Resources.Resources.air
            pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            pic1.BackColor = System.Drawing.Color.Transparent
            pic1.Location = New System.Drawing.Point(4, 4)
            pic1.Name = "PictureBox" & k + 1
            pic1.Size = New System.Drawing.Size(30, 24)
            pic1.TabIndex = 0
            pic1.TabStop = False

            Dim lbldata2 As System.Windows.Forms.Label
            lbldata2 = New System.Windows.Forms.Label
            lbldata2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            lbldata2.AutoSize = True
            lbldata2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lbldata2.ForeColor = System.Drawing.SystemColors.ControlText
            lbldata2.BackColor = System.Drawing.Color.Transparent
            lbldata2.Location = New System.Drawing.Point(4, 7)
            lbldata2.Name = "data" & k + 1
            lbldata2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

            'Add data to labels

            If Not aList.Item(k).ToString = "0" Then
                If k = 0 Then
                    lbldata1.Text = "   Towards Maintenance Charges"
                ElseIf k = 1 Then
                    lbldata1.Text = "   Towards Old Dues"
                ElseIf k = 2 Then
                    lbldata1.Text = "   Towards Advances"
                ElseIf k = 3 Then
                    lbldata1.Text = "   Towards Special Funds"
                ElseIf k = 4 Then
                    lbldata1.Text = "   Towards Donations -"
                End If
                lbldata2.Text = aList.Item(k).ToString
                y += 1
                TotalsTablePanel.Controls.Add(lbldata1, 0, y - 1)
                TotalsTablePanel.Controls.Add(pic1, 1, y - 1)
                TotalsTablePanel.Controls.Add(lbldata2, 2, y - 1)

                TotalsTablePanel.Height += 28
                TotalsTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            End If

        Next

        ' Third Block '

        Dim lbldata3 As System.Windows.Forms.Label
        lbldata3 = New System.Windows.Forms.Label
        lbldata3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        lbldata3.AutoSize = True
        lbldata3.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbldata3.ForeColor = System.Drawing.SystemColors.ControlText
        lbldata3.Location = New System.Drawing.Point(4, 7)
        lbldata3.Name = "data"
        lbldata3.Text = "Grand Total"
        lbldata3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        Dim pic2 As New System.Windows.Forms.PictureBox()
        pic2.BackgroundImage = Global.OurFlatsMaint.My.Resources.Resources.goldstar
        pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        pic2.Location = New System.Drawing.Point(4, 4)
        pic2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right Or System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        pic2.Name = "PictureBox"
        'pic2.Size = New System.Drawing.Size(30, 20)
        pic2.TabIndex = 0
        pic2.TabStop = False

        Dim lbldata4 As System.Windows.Forms.Label
        lbldata4 = New System.Windows.Forms.Label
        lbldata4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        lbldata4.AutoSize = True
        lbldata4.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbldata4.ForeColor = System.Drawing.SystemColors.ControlText
        lbldata4.Location = New System.Drawing.Point(4, 7)
        lbldata4.Name = "data"
        lbldata4.Text = "Rs. " & fetchTotalIncomeSum() & "/-"
        lbldata4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        GrandTotalTablePanel.Controls.Add(lbldata3, 0, 0)
        GrandTotalTablePanel.Controls.Add(pic2, 1, 0)
        GrandTotalTablePanel.Controls.Add(lbldata4, 2, 0)

        ' Fourth Block '

        totalAmtWords.Text = totalAmtWords.Text & " 'Rupees " & cNumToWord(fetchTotalIncomeSum) & " Only'"

        ' Location Block '

        Dim a, b, c, d, f As Integer
        a = monthIncDataTablePanel.Location.Y + monthIncDataTablePanel.Height + 20
        totalsHdg.Location = New System.Drawing.Point(totalsHdg.Location.X, a)
        b = totalsHdg.Location.Y + totalsHdg.Height + 20
        TotalsTablePanel.Location = New System.Drawing.Point(TotalsTablePanel.Location.X, b)
        c = TotalsTablePanel.Location.Y + TotalsTablePanel.Height + 10
        GrandTotalTablePanel.Location = New System.Drawing.Point(GrandTotalTablePanel.Location.X, c)
        d = GrandTotalTablePanel.Location.Y + GrandTotalTablePanel.Height + 10
        TableLayoutPanel8.Location = New System.Drawing.Point(TableLayoutPanel8.Location.X, d)
        f = TableLayoutPanel8.Location.Y + TableLayoutPanel8.Height + 10
        printBtn.Location = New System.Drawing.Point(printBtn.Location.X, f)

    End Sub

    Private Sub graphBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graphBtn.Click
        Dim child1 As New incSumGraph
        child1.MdiParent = flatHome
        child1.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        If myWinStatus.getWinState("incSumGraph") = False Then
            child1.Show()
            myWinStatus.setWinState("incSumGraphOpen")
        Else
            Dim child2 As New dialogMultiInst
            child2.MdiParent = Me
            child2.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            child2.Show()
        End If
    End Sub

    Private Sub printBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printBtn.Click
        'PrintDialog1.Document.Container.Add(Me.Container)
        'PrintDialog1.ShowDialog()
        Dim pf As New PrintForm
        pf.Form = Me.Container
        pf.PrintAction = Printing.PrintAction.PrintToPreview
        pf.Print()
    End Sub
End Class