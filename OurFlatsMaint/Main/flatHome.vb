Imports System.Windows.Forms
Imports System.Drawing.Printing

Public Class flatHome
    Dim Lastx As Short
    Dim Lasty As Short
    Private m_ChildFormNumber As Integer
    Dim winState As Boolean
    Private WithEvents document As New System.Drawing.Printing.PrintDocument

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewWindowToolStrip.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me
        ChildForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
        My.Computer.Clipboard.GetText()
        My.Computer.Clipboard.Clear()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
        My.Computer.Clipboard.GetText()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
        My.Computer.Clipboard.GetText()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStrip.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStrip.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStrip.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStrip.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStrip.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        flatAboutBox.Show()
    End Sub

    Private Sub flatHome_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        My.Application.ApplicationContext.ExitThread()
    End Sub

    Private Sub flatHome_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.Size.Width < 1020 Then
            Panel1.Hide()
        Else
            Panel1.Show()
        End If
    End Sub

    Private Sub LogoutApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutMenuItem.Click
        Me.Hide()
        flatLogin.Show()
    End Sub

    Private Sub ExitApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        My.Application.ApplicationContext.ExitThread()
    End Sub

    Private Sub income_Hover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles incomeSources.MouseHover
        showHideThings("income")
    End Sub

    Private Sub expenditure_Hover(sender As System.Object, e As System.EventArgs) Handles expenditure.MouseHover
        showHideThings("exp")
    End Sub

    Private Sub showHideThings(ByVal str As String)
        If str = "income" Then
            If MaintCharges.Visible And SpecialFunds.Visible And OldDues.Visible And Donations.Visible And Loans.Visible And IncomeSum.Visible Then
                MaintCharges.Visible = False
                SpecialFunds.Visible = False
                OldDues.Visible = False
                Donations.Visible = False
                Loans.Visible = False
                IncomeSum.Visible = False
            Else
                MaintCharges.Visible = True
                SpecialFunds.Visible = True
                OldDues.Visible = True
                Donations.Visible = True
                Loans.Visible = True
                IncomeSum.Visible = True
                waterBill.Visible = False
                watchmanSalary.Visible = False
                electricityBill.Visible = False
                garbageCollection.Visible = False
                liftMaintenance.Visible = False
                repairsRenovations.Visible = False
                purchaseOfFurniture.Visible = False
                festival.Visible = False
                miscExpenses.Visible = False
                centralAssociation.Visible = False
                expenditureSummary.Visible = False
            End If
        Else
            If waterBill.Visible And watchmanSalary.Visible And electricityBill.Visible And garbageCollection.Visible And liftMaintenance.Visible And repairsRenovations.Visible And purchaseOfFurniture.Visible And festival.Visible And miscExpenses.Visible And centralAssociation.Visible And expenditureSummary.Visible Then
                waterBill.Visible = False
                watchmanSalary.Visible = False
                electricityBill.Visible = False
                garbageCollection.Visible = False
                liftMaintenance.Visible = False
                repairsRenovations.Visible = False
                purchaseOfFurniture.Visible = False
                festival.Visible = False
                miscExpenses.Visible = False
                centralAssociation.Visible = False
                expenditureSummary.Visible = False

            Else
                waterBill.Visible = True
                watchmanSalary.Visible = True
                electricityBill.Visible = True
                garbageCollection.Visible = True
                liftMaintenance.Visible = True
                repairsRenovations.Visible = True
                purchaseOfFurniture.Visible = True
                festival.Visible = True
                miscExpenses.Visible = True
                centralAssociation.Visible = True
                expenditureSummary.Visible = True
                MaintCharges.Visible = False
                SpecialFunds.Visible = False
                OldDues.Visible = False
                Donations.Visible = False
                Loans.Visible = False
                IncomeSum.Visible = False
            End If
        End If
    End Sub
    Private WithEvents mPrintDocument As New PrintDocument()
    Dim mPrintBitMap As Bitmap
    Private documentContents As String
    Private stringToPrint As String

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub mPrintDocument_PrintPage(ByVal sender As Object, _
    ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
        Handles mPrintDocument.PrintPage

        ' Insert code to render the page here.
        Dim lWidth As Integer = e.MarginBounds.X + (e.MarginBounds.Width - mPrintBitMap.Width) \ 2
        Dim lHeight As Integer = e.MarginBounds.Y + (e.MarginBounds.Height - mPrintBitMap.Height) \ 2
        e.Graphics.DrawImage(mPrintBitMap, lWidth, lHeight)

        ' If there's only one page.
        e.HasMorePages = True
    End Sub
    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        ' Copy the form's image into a bitmap
        If (getPrintScreen() Is Nothing) Then
            MsgBox("You have not opened any Form")
        Else
            mPrintBitMap = New Bitmap(getPrintScreen().Width, getPrintScreen().Height)
            Dim lRect As System.Drawing.Rectangle
            lRect.Width = getPrintScreen().Width
            lRect.Height = getPrintScreen().Height
            getPrintScreen().DrawToBitmap(mPrintBitMap, lRect)

            'Make a PrintDocument and print.
            mPrintDocument = New PrintDocument
            'mPrintDocument.Print()

            PrintPreviewDialog1.Document = mPrintDocument
            PrintPreviewDialog1.ShowDialog()
        End If

    End Sub
    Dim printScreen As System.Windows.Forms.Form
    Public Sub setPrintScreen(ByVal pscreen As System.Windows.Forms.Form)
        printScreen = pscreen
    End Sub

    Public Function getPrintScreen() As System.Windows.Forms.Form
        Return printScreen
    End Function

    Private Sub ChngPwdMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChngPwdMenuItem.Click
        Dim child1 As New flatChgPwd
        child1.MdiParent = Me
        child1.StartPosition = System.Windows.Forms.FormStartPosition.Manual

        If myWinStatus.getWinState("chgpwd") = False Then
            child1.Show()
            myWinStatus.setWinState("chgpwdopen")
        Else
            Dim child2 As New dialogMultiInst
            child2.MdiParent = Me
            child2.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            child2.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim h, m, s As String
        h = ""
        m = ""
        s = ""
        If TimeOfDay.Hour < 10 Then
            h = "0" & TimeOfDay.Hour
        Else
            h = TimeOfDay.Hour
        End If
        If TimeOfDay.Minute < 10 Then
            m = "0" & TimeOfDay.Minute
        Else
            m = TimeOfDay.Minute
        End If
        If TimeOfDay.Second < 10 Then
            s = "0" & TimeOfDay.Second
        Else
            s = TimeOfDay.Second
        End If
        timeLabel.Text = h & ":" & m & ":" & s
        dateLabel.Text = customizeDateRounded(Date.Today)
    End Sub

    Private Sub CalculatorTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorTool.Click
        calculator.Visible = Me.CalculatorTool.Checked
        If CalculatorTool.Checked = False Then
            calculator.Hide()
        ElseIf CalculatorTool.Checked = True Then
            calculator.Show()
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click

    End Sub

    Private Sub DateTimeTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimeTool.Click
        If DateTimeTool.Checked = True Then
            Panel1.Visible = True
        Else
            Panel1.Visible = False
        End If
    End Sub

    Private Sub flatHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub maintRateItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maintRateItem.Click
        setRateCategory("MAINT_CHARGES")
        rateRedirect()
    End Sub

    Private Sub specialFundsItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles specialFundsItem.Click
        setRateCategory("SPECIAL_FUNDS")
        rateRedirect()
    End Sub

    Private Sub liftMaintItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles liftMaintItem.Click
        setRateCategory("LIFT_MAINTENANCE")
        rateRedirect()
    End Sub

    Private Sub watchmanSalaryItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles watchmanSalaryItem.Click
        setRateCategory("WATCHMAN_SALARY")
        rateRedirect()
    End Sub

    Private Sub waterBillItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles waterBillItem.Click
        setRateCategory("WATER_BILL")
        rateRedirect()
    End Sub

    Private Sub garbageCollectionItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles garbageCollectionItem.Click
        setRateCategory("GARBAGE")
        rateRedirect()
    End Sub

    Private Sub OldDues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OldDues.Click
        setPayCategory("OLD_DUES")
        payRedirect()
    End Sub

    Private Sub MaintCharges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaintCharges.Click
        setPayCategory("MAINT_CHARGES")
        payRedirect()
    End Sub

    Private Sub SpecialFunds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecialFunds.Click
        setPayCategory("SPECIAL_FUNDS")
        payRedirect1()
    End Sub

    Private Sub Donations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Donations.Click
        setPayCategory("DONATIONS")
        payRedirect1()
    End Sub

    Private Sub Loans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Loans.Click
        setPayCategory("LOANS")
        payRedirect1()
    End Sub

    Private Sub payRedirect()
        Dim child1 As New inMoney
        child1.MdiParent = Me
        child1.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        child1.Show()
        If myWinStatus.getWinState("inMoney") = False Then
            child1.Show()
            myWinStatus.setWinState("inMoneyOpen")
        Else
            Dim child2 As New dialogMultiInst
            child2.MdiParent = Me
            child2.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            child2.Show()
        End If
    End Sub
    Private Sub payRedirect1()
        Dim child1 As New inMoney2
        child1.MdiParent = Me
        child1.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        child1.Show()
        If myWinStatus.getWinState("inMoney2") = False Then
            child1.Show()
            myWinStatus.setWinState("inMoney2Open")
        Else
            Dim child2 As New dialogMultiInst
            child2.MdiParent = Me
            child2.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            child2.Show()
        End If
    End Sub

    Private Sub rateRedirect()
        Dim child1 As New setRate
        child1.MdiParent = Me
        child1.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent

        If myWinStatus.getWinState("setRate") = False Then
            child1.Show()
            myWinStatus.setWinState("setRateOpen")
        Else
            Dim child2 As New dialogMultiInst
            child2.MdiParent = Me
            child2.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            child2.Show()
        End If
    End Sub

    Private Sub monthlyInc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles monthlyInc.Click
        setSelectedPeriod("MONTHLY")
        redirectMonthSelect()
    End Sub

    Private Sub qtrlyInc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qtrlyInc.Click
        setSelectedPeriod("QUARTERLY")
        redirectMonthSelect()
    End Sub

    Private Sub redirectMonthSelect()
        Dim child1 As New dialogSelectPeriod
        child1.MdiParent = Me
        child1.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        If myWinStatus.getWinState("selPeriod") = False Then
            child1.Show()
            myWinStatus.setWinState("selPeriodOpen")
        Else
            Dim child2 As New dialogMultiInst
            child2.MdiParent = Me
            child2.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            child2.Show()
        End If
    End Sub

    Private Sub annualInc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles annualInc.Click
        setSelectedPeriod("ANNUAL")
        redirectMonthSelect()
    End Sub

    Private Sub waterBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles waterBill.Click
        setPayCategory("WATER_BILL")
        expRedirect()
    End Sub

    Private Sub electricityBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles electricityBill.Click
        setPayCategory("ELECT_BILL")
        expRedirect()
    End Sub

    Private Sub watchmanSalary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles watchmanSalary.Click
        setPayCategory("WATCHMAN_SALARY")
        expRedirect()
    End Sub

    Private Sub garbageCollection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles garbageCollection.Click
        setPayCategory("GARBAGE")
        expRedirect()
    End Sub

    Private Sub liftMaintenance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles liftMaintenance.Click
        setPayCategory("LIFT_MAINT")
        expRedirect()
    End Sub

    Private Sub BoreRepairs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoreRepairs.Click
        setPayCategory("BORE_REPAIR")
        expRedirect1()
    End Sub

    Private Sub LiftRepairs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiftRepairs.Click
        setPayCategory("LIFT_REPAIR")
        expRedirect1()
    End Sub

    Private Sub festival_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles festival.Click
        setPayCategory("FESTIVAL")
        expRedirect1()
    End Sub

    Private Sub miscExpenses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miscExpenses.Click
        setPayCategory("MISC_EXPENSE")
        expRedirect1()
    End Sub

    Private Sub centralAssociation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles centralAssociation.Click
        setPayCategory("CA_FUND")
        expRedirect1()
    End Sub
    Private Sub expRedirect()
        Dim child1 As New outMoney
        child1.MdiParent = Me
        child1.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        child1.Show()
        If myWinStatus.getWinState("outMoney") = False Then
            child1.Show()
            myWinStatus.setWinState("outMoneyOpen")
        Else
            Dim child2 As New dialogMultiInst
            child2.MdiParent = Me
            child2.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            child2.Show()
        End If
    End Sub

    Private Sub expRedirect1()
        Dim child1 As New otherExpense
        child1.MdiParent = Me
        child1.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        child1.Show()
        If myWinStatus.getWinState("outMoney") = False Then
            child1.Show()
            myWinStatus.setWinState("outMoneyOpen")
        Else
            Dim child2 As New dialogMultiInst
            child2.MdiParent = Me
            child2.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            child2.Show()
        End If
    End Sub

End Class
