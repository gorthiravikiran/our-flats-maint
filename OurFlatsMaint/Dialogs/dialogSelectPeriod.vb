Imports System.Windows.Forms

Public Class dialogSelectPeriod

    Private Sub OK_Button_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If getSelectedPeriod() = "MONTHLY" Then
            If Me.selMonth.SelectedItem.ToString = "-Month-" Or Me.selYear.SelectedItem.ToString = "-Year-" Then
                If selMonth.SelectedItem.ToString = "-Month-" Then
                    MsgBox("Oops! You forgot to Select a Month")
                ElseIf selYear.SelectedItem.ToString = "-Year-" Then
                    MsgBox("Oops! You forgot to Select an Year")
                End If
            Else
                setSelectedMonth(fetchMonthAcro(selMonth.SelectedItem.ToString), selYear.SelectedItem.ToString)
                redirectMe()
            End If
        ElseIf getSelectedPeriod() = "QUARTERLY" Then
            If Me.selQtr.SelectedItem.ToString = "-Quarter-" Or Me.qtrYear.SelectedItem.ToString = "-Year-" Then
                If selQtr.SelectedItem.ToString = "-Quarter-" Then
                    MsgBox("Oops! You forgot to Select an Year")
                ElseIf qtrYear.SelectedItem.ToString = "-Year-" Then
                    MsgBox("Oops! You forgot to Select an Year")
                End If
            Else
                setSelectedQtr(selQtr.SelectedItem.ToString, qtrYear.SelectedItem.ToString)
                redirectMe()
            End If
        ElseIf getSelectedPeriod() = "ANNUAL" Then
            If yearOnly.SelectedItem.ToString = "-Year-" Then
                MsgBox("Oops! You forgot to Select an Year")
            Else
                setSelectedYear(yearOnly.SelectedItem.ToString)
                redirectMe()
            End If
        End If
    End Sub

    Private Sub redirectMe()
        Dim child1 As New incSummary
        child1.MdiParent = flatHome
        child1.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent

        If myWinStatus.getWinState("incomeSum") = False Then
            child1.Show()
            myWinStatus.setWinState("incomeSumOpen")
        Else
            Dim child2 As New dialogMultiInst
            child2.MdiParent = flatHome
            child2.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            child2.Show()
        End If
        Me.Close()
    End Sub


    Private Sub dialogSelectPeriod_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        setWinState("selPeriodClose")
    End Sub

    Private Sub dialogSelectMonth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If getSelectedPeriod() = "MONTHLY" Then
            monthPanel.Visible = True
            qtrPanel.Visible = False
            YearPanel.Visible = False
            selMonth.SelectedItem = "-Month-"
            selMonth.SelectedIndex = 1
            selYear.SelectedItem = "-Year-"
            Dim currentYear = Year(Now)
            For i As Integer = 1950 To currentYear
                selYear.Items.Add(Integer.Parse(i))
            Next
            Dim c = selYear.Items.Count
            selYear.SelectedIndex = c - 1
            Label3.Text = "SELECT MONTH"
        ElseIf getSelectedPeriod() = "QUARTERLY" Then
            monthPanel.Visible = False
            qtrPanel.Visible = True
            YearPanel.Visible = False
            selQtr.SelectedItem = "-Quarter-"
            selQtr.SelectedIndex = 1
            qtrYear.SelectedItem = "-Year-"
            Dim currentYear = Year(Now)
            For i As Integer = 1950 To currentYear
                qtrYear.Items.Add(Integer.Parse(i))
            Next
            Dim c = qtrYear.Items.Count
            qtrYear.SelectedIndex = c - 1
            Label3.Text = "SELECT QUARTER"
        ElseIf getSelectedPeriod() = "ANNUAL" Then
            monthPanel.Visible = False
            qtrPanel.Visible = False
            YearPanel.Visible = True
            yearOnly.SelectedItem = "-Year-"
            Dim currentYear = Year(Now)
            For i As Integer = 1950 To currentYear
                yearOnly.Items.Add(Integer.Parse(i))
            Next
            Dim c = yearOnly.Items.Count
            yearOnly.SelectedIndex = c - 1
            Label3.Text = "SELECT YEAR"
        End If
    End Sub
End Class
