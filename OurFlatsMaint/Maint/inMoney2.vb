Public Class inMoney2

    Private Sub donations_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        setWinState("inMoney2Close")
    End Sub
    Private Sub donations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.flatNo.Focus()
        flatNo.Items.Clear()
        flatNo.Items.Add("-Select Flat No-")
        flatNo.Items.Add("OTHERS")
        flatNo.SelectedItem = "-Select Flat No-"
        dName.Visible = True
        dName.Enabled = True
        rsLabel.Visible = True
        varLabel.Visible = True
        rsLabel.Text = "Mr."
        If getPayCategory() = "SPECIAL_FUNDS" Then
            varLabel.Text = "Paid By"
            Me.Text = "Collection of Special Funds"
            varLabel2.Text = "Fund Purpose"
            remarks.Visible = False
            purpose.Visible = True
            dName.Text = "Enter Payer's Name"
            purpose.SelectedItem = "-Select a Purpose-"
        ElseIf getPayCategory() = "LOANS" Then
            varLabel.Text = "Obtained From"
            Me.Text = "Obtaining of Loans"
            dName.Text = "Enter Loaner's Name"
        ElseIf getPayCategory() = "DONATIONS" Then
            varLabel.Text = "Donated By"
            Me.Text = "Collection of Donations"
            dName.Text = "Enter Donor's Name"
        End If
        rsLabel.Location = New System.Drawing.Point(135, 285)
        dName.Location = New System.Drawing.Point(167, 282)
        formHdg.Text = Me.Text.ToUpper
        Me.monthLabel.Text = dateFormat.fetchMonthYear(Date.Today.ToString())

        Dim datatable1 As DataTable = MaintDataHandler.fetchAllFlatNumbers()
        For i As Integer = 0 To datatable1.Rows.Count - 1
            Me.flatNo.Items.Add(datatable1.Rows(i)("FLAT_NO").ToString)
        Next
        dated.Text = Date.Today
    End Sub

    Private Sub amtPaid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles amtPaid.GotFocus
        If (amtPaid.Text = "Enter Amount") Then
            amtPaid.Text = ""
        End If
    End Sub

    Private Sub amtPaid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles amtPaid.LostFocus
        If (amtPaid.Text = "") Then
            amtPaid.Text = "Enter Amount"
        End If
    End Sub

    Private Sub flatNo_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        ToolTip1.SetToolTip(flatNo, "You can select a Flat No. here")
    End Sub

    Private Sub dated_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        ToolTip1.SetToolTip(dated, "You can select a Date here.  By default Today's Date is displayed")
    End Sub

    Private Sub amtPaid_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        ToolTip1.SetToolTip(amtPaid, "Enter the Amount Paid.  By default Current Maintenance Rate is displayed here")
    End Sub

    Private Sub payBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles payBtn.Click
        Dim varArrayList As New ArrayList
        varArrayList.Add(flatNo.SelectedItem.ToString)
        varArrayList.Add(monthLabel.Text)
        varArrayList.Add(dated.Text.ToUpper.ToString)
        varArrayList.Add(amtPaid.Text)
        varArrayList.Add(getPayCategory)
        varArrayList.Add(dName.Text)
        If getPayCategory() = "LOANS" Or getPayCategory() = "DONATIONS" Then
            varArrayList.Add(remarks.Text)
        ElseIf getPayCategory() = "SPECIAL_FUNDS" Then
            varArrayList.Add(purpose.SelectedItem.ToString)
        End If

        If amtPaid.Text = "Enter Amount" Or amtPaid.Text = "" Or flatNo.SelectedItem.ToString = "-Select Flat No-" Or dName.Text = "Enter Donor's Name" Or dName.Text = "Enter Payer's Name" Or dName.Text = "Enter Loaner's Name" Or purpose.SelectedItem = "-Select a Purpose-" Then
            If amtPaid.Text = "" Or amtPaid.Text = "Enter Amount" Then
                MsgBox("Sorry! Amount field cannot be Blank")
            ElseIf flatNo.SelectedItem.ToString = "-Select Flat No-" Then
                MsgBox("Oops! You forgot to Select a Flat No.")
            ElseIf dName.Text = "Enter Donor's Name" Then
                MsgBox("Oops! You forgot to Enter the Donor's Name")
            ElseIf dName.Text = "Enter Loaner's Name" Then
                MsgBox("Oops! You forgot to Enter the Loaner's Name")
            ElseIf dName.Text = "Enter Payer's Name" Then
                MsgBox("Oops! You forgot to Enter the Payer's Name")
            ElseIf purpose.SelectedItem = "-Select a Purpose-" Then
                MsgBox("Oops! You forgot to Select a Fund's Purpose")
            End If
        Else
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

    Private Sub donorName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If (dName.Text = "Enter Donor's Name") Then
            dName.Text = ""
        End If
    End Sub

    Private Sub donorName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If (dName.Text = "") Then
            dName.Text = "Enter Donor's Name"
        End If
    End Sub

    Private Sub flatNo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles flatNo.SelectedIndexChanged
        If flatNo.SelectedItem = "OTHERS" Then
            dName.Text = ""
        ElseIf flatNo.SelectedItem = "-Select Flat No-" Then
            dName.Text = "Select Flat No"
        Else
            dName.Text = fetchOwnerNameByFlatNo(flatNo.SelectedItem.ToString)
            'write code here to load Owners Name from Owners Biodata
        End If
        dName.Focus()
    End Sub

End Class