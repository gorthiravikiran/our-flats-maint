Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.OleDb
Imports Microsoft.VisualBasic.PowerPacks.Printing

Public Class incSumGraph

    Private Sub incMonGraph_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        setWinState("incSumGraphClose")
    End Sub

    Private Sub incMonGraph_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Flats_Income_Sum_TableAdapter.ClearBeforeFill = True
        If getSelectedPeriod() = "MONTHLY" Then
            incomeHdg.Text = "INCOME SUMMARY OF '" & fetchMonthExpand(getSelectedMonth()) & " " & extractYearFromInput(getSelectedMonth) & "'"
        ElseIf getSelectedPeriod() = "QUARTERLY" Then
            incomeHdg.Text = "INCOME SUMMARY OF THE QUARTER '" & getSelectedQtr() & "'"
        ElseIf getSelectedPeriod() = "ANNUAL" Then
            incomeHdg.Text = "INCOME SUMMARY OF THE YEAR '" & getSelectedYear() & "'"
        End If
        Chart1.DataSource = getIncomeSumTotals4Chart()
        Dim total As Integer = 0
        Dim dt As DataTable = getIncomeSumTotals4ChartPercentage()
        For i As Integer = 0 To dt.Rows.Count - 1
            total = total + Integer.Parse(dt.Rows(i)("SAMOUNT").ToString)
        Next
    End Sub

    Private Sub printBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printBtn.Click
        Dim pf As New PrintForm
        pf.Form = Me
        pf.PrintAction = Printing.PrintAction.PrintToPreview
        pf.Print()
    End Sub
End Class