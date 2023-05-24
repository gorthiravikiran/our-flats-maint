Imports System.Windows.Forms

Public Class cashReceipt

    Private Sub cashReceipt_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        PrintDialog1.Document.Container.Remove(Me)
    End Sub

    Private Sub cashReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As DataSet = fetchData4CashReceipt()

        'Add Data Bindings

        receiptNo.Text = Integer.Parse(ds.Tables(0).Rows(0)("RECEIPT_NO"))
        dated.Text = ds.Tables(0).Rows(0)("RECEIPT_DATED")
        flatNoName.Text = ds.Tables(0).Rows(0)("FLAT_NO") & " (" & ds.Tables(0).Rows(0)("PAYER_NAME") & ")"
        paidMonth.Text = ds.Tables(0).Rows(0)("FOR_MONTH")
        If (ds.Tables(0).Rows(0)("CATEGORY")) = "MAINT_CHARGES" Then
            paycategory.Text = "Monthly Maintenance Charges"
        ElseIf (ds.Tables(0).Rows(0)("CATEGORY")) = "SPECIAL_FUNDS" Then
            paycategory.Text = "Special Funds"
        ElseIf (ds.Tables(0).Rows(0)("CATEGORY")) = "DONATIONS" Then
            paycategory.Text = "Donations"
        ElseIf (ds.Tables(0).Rows(0)("CATEGORY")) = "OLD_DUES" Then
            paycategory.Text = "Settlement of Old Dues"
        ElseIf (ds.Tables(0).Rows(0)("CATEGORY")) = "LOANS" Then
            paycategory.Text = "Obtaining Amount as Loan"
        End If
        remarks.Text = ds.Tables(0).Rows(0)("REMARKS")
        amtPaid.Text = ds.Tables(0).Rows(0)("AMOUNT") & "/-"
        rupeesLabel.Text = cNumToWord(ds.Tables(0).Rows(0)("AMOUNT")) & " Only"
    End Sub

    Private Sub printBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printBtn.Click
        PrintDialog1.Document.Container.Add(Me)
        PrintDialog1.ShowDialog()
    End Sub

End Class
