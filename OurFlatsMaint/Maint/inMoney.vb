Public Class inMoney

    Private Sub inMoney_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        setWinState("inMoneyClose")
    End Sub
    Private Sub addMaint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.flatNo.Focus()
        Me.flatNo.SelectedItem = "-Select Flat No-"
        Dim datatable1 As DataTable

        If getPayCategory() = "MAINT_CHARGES" Then
            Me.Text = "Maintenance Charges Payment"
            datatable1 = MaintDataHandler.fetchFlatNoMaintDue()
            Dim alist As ArrayList = fetchRateData()
            Me.amtPaid.Text = alist.Item(1).ToString
            Me.payAmt.Text = alist.Item(1).ToString
            Me.balDue.Text = Me.payAmt.Text - Me.amtPaid.Text
        ElseIf getPayCategory() = "SPECIAL_FUNDS" Then
            datatable1 = MaintDataHandler.fetchAllFlatNumbers()
            Me.Text = "Special Funds Collection"
            varLabel.Text = "Fund Purpose"
            Dim alist As ArrayList = fetchRateData()
            Me.amtPaid.Text = alist.Item(1).ToString
            Me.payAmt.Text = alist.Item(1).ToString
            Me.balDue.Text = Me.payAmt.Text - Me.amtPaid.Text
        ElseIf getPayCategory() = "LOANS" Then
            datatable1 = MaintDataHandler.fetchAllFlatNumbers()
            Me.Text = "Obtaining Loan"
            Me.balDue.Visible = False
            Me.flatNo.Items.Add("Others")
        ElseIf getPayCategory() = "OLD_DUES" Then
            datatable1 = MaintDataHandler.fetchFlatNoOldDues()
            Me.Text = "Settlement of Old Dues"
            Me.amtPaid.Text = "0"
            Me.payAmt.Text = "0"
            Me.balDue.Text = "0"
        End If
        Me.formHdg.Text = Me.Text.ToUpper
        Me.monthLabel.Text = dateFormat.fetchMonthYear(Date.Today.ToString())
        For i As Integer = 0 To datatable1.Rows.Count - 1
            Me.flatNo.Items.Add(datatable1.Rows(i)("FLAT_NO").ToString)
        Next
        Me.dated.Text = customizeDate(Date.Today)
        Me.qtrYearFill(dated.Text)

    End Sub

    Private Sub amtPaid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles amtPaid.GotFocus
        If amtPaid.Text = "Enter Amount" Then
            amtPaid.Text = ""
        End If
    End Sub

    Private Sub amtPaid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles amtPaid.KeyUp
        If Me.amtPaid.Text = "" Then
            Me.balDue.Text = payAmt.Text
        Else
            Me.balDue.Text = Me.payAmt.Text - Me.amtPaid.Text
        End If
    End Sub

    Private Sub amtPaid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles amtPaid.LostFocus
        If Me.amtPaid.Text = "" Then
            Me.amtPaid.Text = "Enter Amount"
        End If
    End Sub

    Private Sub flatNo_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles flatNo.MouseHover
        ToolTip1.SetToolTip(flatNo, "You can select a Flat No. here")
    End Sub

    Private Sub flatNo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles flatNo.SelectedValueChanged
        If Not flatNo.SelectedItem.ToString = "-Select Flat No-" Then
            remarks.Text = ""
            Dim dt As DataTable = fetchOldDuesByFlatNo(flatNo.SelectedItem.ToString)
            For i As Integer = 0 To dt.Rows.Count - 1
                remarks.AppendText(dt.Rows(i)("DUE_DATE").ToString & " : " & dt.Rows(i)("CATEGORY").ToString & " = " & dt.Rows(i)("DUE_AMOUNT").ToString & vbCrLf)
            Next
            If getPayCategory() = "MAINT_CHARGES" Then
                Dim alist As ArrayList = fetchRateData()
                payAmt.Text = alist.Item(1).ToString
            ElseIf getPayCategory() = "SPECIAL_FUNDS" Then
                Dim alist As ArrayList = fetchRateData()
                payAmt.Text = alist.Item(1).ToString
            ElseIf getPayCategory() = "LOANS" Then
                payAmt.Text = "0"
            ElseIf getPayCategory() = "OLD_DUES" Then
                payAmt.Text = fetchOldDuesTotalByFlatNo(flatNo.SelectedItem.ToString).Rows(0)("AMOUNT").ToString
                amtPaid.Text = payAmt.Text
                balDue.Text = payAmt.Text - amtPaid.Text
            End If
            amtPaid.Focus()
        Else
            remarks.Text = "NIL"
        End If

    End Sub

    Private Sub dated_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles dated.MouseHover
        ToolTip1.SetToolTip(dated, "You can select a Date here.  By default Today's Date is displayed")
    End Sub

    Private Sub amtPaid_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles payAmt.MouseHover, amtPaid.MouseHover, balDue.MouseHover
        ToolTip1.SetToolTip(amtPaid, "Enter the Amount Paid.  By default Current Maintenance Rate is displayed here")
    End Sub

    Private Sub payBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles payBtn.Click


        If amtPaid.Text = "Enter Amount" Or amtPaid.Text = "" Or flatNo.SelectedItem.ToString = "-Select Flat No-" Then
            If amtPaid.Text = Nothing Or amtPaid.Text = "0" Or amtPaid.Text = "Enter Amount" Then
                MsgBox("Sorry! Amount field cannot be Blank or '0'")
            ElseIf flatNo.SelectedItem.ToString = "-Select Flat No-" Then
                MsgBox("Oops! You forgot to Select a Flat No.")
            End If
        Else
            Dim varArrayList As New ArrayList
            varArrayList.Add(flatNo.SelectedItem.ToString)
            varArrayList.Add(monthLabel.Text)
            varArrayList.Add(dated.Text.ToUpper.ToString)
            varArrayList.Add(amtPaid.Text)
            varArrayList.Add(getPayCategory)
            varArrayList.Add(fetchOwnerNameByFlatNo(flatNo.SelectedItem.ToString))
            varArrayList.Add(remarks.Text)
            If addIncomeData(varArrayList) = True Then
                setRoutedFrom("income")
                Dim child1 As New dialogDone
                child1.MdiParent = flatHome
                child1.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
                child1.Show()
                Me.Close()
            Else
                Dim child1 As New dialogSorry
                child1.MdiParent = flatHome
                child1.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
                child1.Show()
            End If
        End If
    End Sub

    Private Sub dated_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dated.LostFocus
        qtrYearFill(dated.Text)
    End Sub

    Private Sub qtrYearFill(ByVal myDate As String)
        Dim qtryrfill() As String = getQuarterYearFromInput(myDate)
        qtrLabel.Text = "Qtr: " & qtryrfill(0).ToString
        yearLabel.Text = "Year: " & qtryrfill(1).ToString
    End Sub

End Class