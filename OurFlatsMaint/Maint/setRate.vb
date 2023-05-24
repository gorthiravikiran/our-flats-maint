Public Class setRate

    Private Sub setRate_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        myWinStatus.setWinState("setRateClose")
    End Sub

    Private Sub setRate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim varLabel As String = ""
        If getRateCategory() = "MAINT_CHARGES" Then
            heading.Text = "APPARTMENT MAINTENANCE CHARGES"
            varLabel = "Meeting Held On"
            Me.miscText.Visible = False
            Me.mtgDate.Visible = True
            PictureBox2.Image = Global.OurFlatsMaint.My.Resources.Resources.income2
        ElseIf getRateCategory() = "LIFT_MAINTENANCE" Then
            heading.Text = "LIFT MAINTENANCE CHARGES"
            varLabel = "Name of Lift Vendor"
            PictureBox2.Image = Global.OurFlatsMaint.My.Resources.Resources.liftmaint1
            Me.miscText.Visible = True
            Me.mtgDate.Visible = False
        ElseIf getRateCategory() = "SPECIAL_FUNDS" Then
            heading.Text = "SPECIAL FUNDS RAISED ON PURPOSE"
            varLabel = "Fund Raised For"
            PictureBox2.Image = Global.OurFlatsMaint.My.Resources.Resources.special
            Me.miscText.Visible = True
            Me.mtgDate.Visible = False
        ElseIf getRateCategory() = "WATCHMAN_SALARY" Then
            heading.Text = "RATE OF WATCHMAN SALARY"
            varLabel = "Name of Watchman"
            PictureBox2.Image = Global.OurFlatsMaint.My.Resources.Resources.watchman
            Me.miscText.Visible = True
            Me.mtgDate.Visible = False
        ElseIf getRateCategory() = "GARBAGE" Then
            heading.Text = "RATE OF GARBAGE COLLECTION"
            varLabel = "Garbage Collection Agent"
            PictureBox2.Image = Global.OurFlatsMaint.My.Resources.Resources.garbage
            Me.miscText.Visible = True
            Me.mtgDate.Visible = False
        ElseIf getRateCategory() = "WATER_BILL" Then
            heading.Text = "RATE OF WATER BILL"
            varLabel = "Water Board/ Area"
            PictureBox2.Image = Global.OurFlatsMaint.My.Resources.Resources.water_blue_wave
            Me.miscText.Visible = True
            Me.mtgDate.Visible = False
            Me.miscText.Text = "GHMC, NTR Nagar"
        End If
        Dim alist As ArrayList = fetchRateData()
        oldRateDate.Text = alist.Item(0).ToString
        oldRate.Text = "Rs. " & alist.Item(1).ToString & "/-"
        miscLabel.Text = alist.Item(2).ToString
        miscLabel1.Text = varLabel
        miscLabel2.Text = varLabel
        amtPaid.Focus()
    End Sub

    Private Sub payBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdBtn.Click
        Dim varArrayList As New ArrayList
        Dim dateStr As String = dateFormat.customizeDate(Me.dated.Value)
        varArrayList.Add(dateStr)
        varArrayList.Add(amtPaid.Text)

        If getRateCategory() = "MAINT_CHARGES" Then
            Dim dateStr1 As String = dateFormat.customizeDate(Me.mtgDate.Value)
            varArrayList.Add(dateStr1)
        Else
            varArrayList.Add(miscText.Text)
            If amtPaid.Text = "" Or amtPaid.Text = "0" Then
                MsgBox("Amount field cannot be Blank or 0")
            ElseIf miscText.Text = "" Then
                MsgBox(miscLabel2.Text & "cannot be Blank")
            End If
        End If
        If Not amtPaid.Text = "Enter Amount" Or amtPaid.Text = "" Then
            If setRateData(varArrayList) = True Then
                setRoutedFrom("setRate")
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
        Else
            Dim child1 As New dialogSorry
            child1.MdiParent = flatHome
            child1.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            child1.Show()
        End If
        Me.Close()
    End Sub

    Private Sub miscText_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles miscText.GotFocus
        If miscText.Text = "Enter Text" Then
            miscText.Text = ""
        End If
    End Sub

    Private Sub miscText_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles miscText.LostFocus
        If miscText.Text = "" Then
            miscText.Text = "Enter Text"
        End If
    End Sub

    Private Sub miscText_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles miscText.MouseHover
        If miscLabel1.Text = "Meeting Held On" Then
            ToolTip1.SetToolTip(miscText, "Enter the Date on which Meeting was held")
        ElseIf miscLabel1.Text = "Fund Raised For" Then
            ToolTip1.SetToolTip(miscText, "Enter the Purpose of Raising this Fund")
        ElseIf miscLabel1.Text = "Name of Watchman" Then
            ToolTip1.SetToolTip(miscText, "Enter the Name of the Watch Man")
        ElseIf miscLabel1.Text = "Name of Lift Vendor" Then
            ToolTip1.SetToolTip(miscText, "Enter the Name of the Lift Vendor")
        ElseIf miscLabel1.Text = "Garbage Collection Agent" Then
            ToolTip1.SetToolTip(miscText, "Enter the Name of the Garbage Collection Agent")
        ElseIf miscLabel1.Text = "Water Board/ Area" Then
            ToolTip1.SetToolTip(miscText, "Enter the Name/ Location of your Municipal Water Board")
        End If
    End Sub

    Private Sub amtPaid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles amtPaid.GotFocus
        If amtPaid.Text = "0" Then
            amtPaid.Text = ""
        End If
    End Sub

    Private Sub amtPaid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles amtPaid.LostFocus
        If amtPaid.Text = "" Then
            amtPaid.Text = "0"
        End If
    End Sub

    Private Sub AmdBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmdBtn.Click

    End Sub
End Class