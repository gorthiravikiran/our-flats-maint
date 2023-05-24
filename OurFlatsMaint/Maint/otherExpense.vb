Public Class otherExpense

    Private Sub outMoney_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
        setWinState("outMoneyClose")
    End Sub

    Private Sub otherExpense_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.expPurpose.Focus()
        Dim amtDue As String = MaintDataHandler.fetchAmtDue()

        If getPayCategory() = "FESTIVAL" Then
            Me.Text = "Expenditure Incurred during Festival"
            Me.expPurpose.Text = "Festival Expenses"
            PictureBox2.Image = Global.OurFlatsMaint.My.Resources.ganesh
        ElseIf getPayCategory() = "LIFT_REPAIR" Then
            Me.Text = "Payment made for Lift Repair"
            Me.expPurpose.Text = "Lift Repair"
            PictureBox2.Image = Global.OurFlatsMaint.My.Resources.liftmaint1
        ElseIf getPayCategory() = "BORE_REPAIR" Then
            Me.Text = "Payment made for Bore Repair"
            Me.expPurpose.Text = "Bore Repair"
            PictureBox2.Image = Global.OurFlatsMaint.My.Resources.vendor_admin
        ElseIf getPayCategory() = "MISC_EXPENSE" Then
            Me.Text = "Expenditure Incurred for Block Maintenance & Miscellaneous Expenses"
            Me.expPurpose.Text = "Block Maintenance & Miscellaneous Expenses"
            PictureBox2.Image = Global.OurFlatsMaint.My.Resources.repair
        ElseIf getPayCategory() = "CA_FUND" Then
            Me.Text = "Payment made against Central Association Subscription"
            Me.expPurpose.Text = "Central Association Subscription"
            PictureBox2.Image = Global.OurFlatsMaint.My.Resources.issue_tracker
        End If

        Me.formHdg.Text = Me.Text.ToUpper
        Me.monthLabel.Text = dateFormat.fetchMonthYear(Date.Today.ToString())
        Me.dated.Text = customizeDate(Date.Today)
        Me.qtrYearFill(dated.Text)

    End Sub

    Private Sub amtPaid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If amtPaid.Text = "0" Then
            amtPaid.Text = ""
        End If
    End Sub

    Private Sub amtPaid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.amtPaid.Text = "" Then
            Me.amtPaid.Text = "0"
        End If
    End Sub

    Private Sub expPurpose_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        ToolTip1.SetToolTip(expPurpose, "Enter the Nature of Expense here")
    End Sub

    Private Sub dated_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        ToolTip1.SetToolTip(dated, "You can select a Date here.  By default Today's Date is displayed")
    End Sub

    Private Sub amtPaid_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        ToolTip1.SetToolTip(amtPaid, "Enter the Amount Paid")
    End Sub

    Private Sub payBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim varArrayList As New ArrayList
        varArrayList.Add(expPurpose.Text)
        varArrayList.Add(monthLabel.Text)
        varArrayList.Add(dated.Text.ToUpper.ToString)
        varArrayList.Add(getPayCategory)
        varArrayList.Add(remarks.Text)
        If addIncomeData(varArrayList) = True Then
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
    End Sub

    'Private Sub dated_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    qtrYearFill(dated.Text)
    'End Sub

    Private Sub qtrYearFill(ByVal myDate As String)
        Dim qtryrfill() As String = getQuarterYearFromInput(myDate)
        qtrLabel.Text = "Qtr: " & qtryrfill(0).ToString
        yearLabel.Text = "Year: " & qtryrfill(1).ToString
    End Sub

    Private Sub dated_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dated.ValueChanged
        qtrYearFill(dated.Text)
    End Sub
End Class