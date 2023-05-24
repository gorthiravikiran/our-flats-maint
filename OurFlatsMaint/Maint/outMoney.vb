Public Class outMoney

    Private Sub outMoney_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        setWinState("outMoneyClose")
    End Sub

    Private Sub outMoney_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.expPurpose.Focus()
        Dim amtDue As String = fetchAmtDue()

        If getPayCategory() = "WATER_BILL" Then
            Me.Text = "Payment of Water Bill"
            varLabel.Text = "Bill Amount"
            Me.expPurpose.Text = "Water Bill"
            preDue.Text = fetchDuesData().Item(1).ToString
            nowPayable.Text = fetchRateData().Item(1).ToString
            Me.totalPayable.Text = Integer.Parse(Me.preDue.Text) + Integer.Parse(Me.nowPayable.Text)
            PictureBox2.Image = Global.OurFlatsMaint.My.Resources.water_drop
        ElseIf getPayCategory() = "ELECT_BILL" Then
            Me.Text = "Payment of Electricity Bill"
            varLabel.Text = "Bill Amount"
            Me.expPurpose.Text = "Electricity Bill"
            PictureBox2.Image = Global.OurFlatsMaint.My.Resources.electricity1
        ElseIf getPayCategory() = "WATCHMAN_SALARY" Then
            varLabel.Text = "Current Rate"
            Me.Text = "Payment of Watchman Salary"
            Me.expPurpose.Text = "Watchman Salary"
            nowPayable.Text = fetchRateData().Item(1).ToString
            PictureBox2.Image = Global.OurFlatsMaint.My.Resources.watchman
        ElseIf getPayCategory() = "GARBAGE" Then
            varLabel.Text = "Current Rate"
            Me.Text = "Payment of Garbage Collection Charges"
            Me.expPurpose.Text = "Garbage Collection Charges"
            nowPayable.Text = fetchRateData().Item(1).ToString
            PictureBox2.Image = Global.OurFlatsMaint.My.Resources.shredder
        ElseIf getPayCategory() = "Lift_Maint" Then
            varLabel.Text = "Current Rate"
            Me.Text = "Payment for Lift Maintenance"
            Me.expPurpose.Text = "Lift Maintenance"
            nowPayable.Text = fetchRateData().Item(1).ToString
            PictureBox2.Image = Global.OurFlatsMaint.My.Resources.liftmaint2
        End If

        preDue.Text = amtDue
        Me.formHdg.Text = Me.Text.ToUpper
        Me.monthLabel.Text = fetchMonthYear(Date.Today.ToString)

        Me.dated.Text = customizeDate(Date.Today.ToString)
        Me.qtrYearFill(dated.Text)


        Dim dt As DataTable = fetchOldDuesByFlatNo(getPayCategory)
        For i As Integer = 0 To dt.Rows.Count - 1
            remarks.AppendText(dt.Rows(i)("DUE_DATE").ToString & " : " & dt.Rows(i)("CATEGORY").ToString & " = " & dt.Rows(i)("DUE_AMOUNT").ToString & vbCrLf)
        Next

    End Sub

    Private Sub amtPaid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles amtPaid.GotFocus, expPurpose.GotFocus
        If amtPaid.Text = "0" Then
            amtPaid.Text = ""
        End If
    End Sub

    Private Sub amtPaid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles amtPaid.KeyUp, expPurpose.KeyUp
        If Me.amtPaid.Text = "" Then
            Me.balDue.Text = Me.totalPayable.Text
        Else
            Me.balDue.Text = Me.totalPayable.Text - Me.amtPaid.Text
        End If
    End Sub

    Private Sub amtPaid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles amtPaid.LostFocus, expPurpose.LostFocus
        If Me.amtPaid.Text = "" Then
            Me.amtPaid.Text = "0"
        End If
    End Sub

    Private Sub expPurpose_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        ToolTip1.SetToolTip(expPurpose, "You can Select a Nature of Expense here")
    End Sub

    Private Sub dated_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles dated.MouseHover
        ToolTip1.SetToolTip(dated, "You can select a Date here.  By default Today's Date is displayed")
    End Sub

    Private Sub amtPaid_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles amtPaid.MouseHover, expPurpose.MouseHover
        ToolTip1.SetToolTip(amtPaid, "Enter the Amount Paid.  By default Current Maintenance Rate is displayed here")
    End Sub

    Private Sub payBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If amtPaid.Text = Nothing Or amtPaid.Text = "0" Then
            MsgBox("Sorry! Amount field cannot be Blank or 0")
        Else
            Dim varArrayList As New ArrayList
            varArrayList.Add(expPurpose.Text)
            varArrayList.Add(monthLabel.Text)
            varArrayList.Add(dated.Text.ToUpper.ToString)
            varArrayList.Add(totalPayable.Text)
            varArrayList.Add(getPayCategory)
            varArrayList.Add(remarks.Text)
            If addExpenseData(varArrayList) = True Then
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

    'Private Sub dated_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dated.ValueChanged
    '    qtrYearFill(dated.Text)
    'End Sub

    Private Sub qtrYearFill(ByVal myDate As String)
        Dim qtryrfill() As String = getQuarterYearFromInput(myDate)
        qtrLabel.Text = "Qtr: " & qtryrfill(0).ToString
        yearLabel.Text = "Year: " & qtryrfill(1).ToString
    End Sub

    Private Sub nowPayable_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nowPayable.KeyUp
        If Me.nowPayable.Text = "" Then
            Me.totalPayable.Text = Me.preDue.Text
        Else
            Me.totalPayable.Text = Me.preDue.Text + Me.nowPayable.Text
        End If
    End Sub
End Class