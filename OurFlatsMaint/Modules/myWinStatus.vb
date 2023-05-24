Module myWinStatus
    Public winState1, winState2, winState3, winState4, winState5, winState6, winState7, winState8, winState9, winState10, winState11, winState12, winState13, winState14, winState15, winState16, winState17, winState18, winState19, winState20, winState21, winState22, winState23, winState24, winState25, winState26, winState27, winState28, winState29 As Boolean

    Public Sub setWinState(ByVal myWinState As String)
        If (myWinState = "inMoneyOpen") Then
            winState1 = True
        ElseIf myWinState = "inMoneyClose" Then
            winState1 = False
        ElseIf (myWinState = "setRateOpen") Then
            winState2 = True
        ElseIf myWinState = "setRateClose" Then
            winState2 = False
        ElseIf (myWinState = "incomeSumOpen") Then
            winState3 = True
        ElseIf myWinState = "incomeSumClose" Then
            winState3 = False
        ElseIf (myWinState = "inMoney2Open") Then
            winState4 = True
        ElseIf myWinState = "inMoney2Close" Then
            winState4 = False
        ElseIf (myWinState = "incSumGraphOpen") Then
            winState5 = True
        ElseIf myWinState = "incSumGraphClose" Then
            winState5 = False
        ElseIf (myWinState = "selPeriodOpen") Then
            winState6 = True
        ElseIf myWinState = "selPeriodClose" Then
            winState6 = False
        ElseIf (myWinState = "outMoneyOpen") Then
            winState7 = True
        ElseIf myWinState = "outMoneyClose" Then
            winState7 = False
        End If
    End Sub

    Public Function getWinState(ByVal myWindow As String)
        Dim wstate As Boolean
        If (myWindow = "inMoney") Then
            wstate = winState1
        ElseIf (myWindow = "setRate") Then
            wstate = winState2
        ElseIf (myWindow = "incomeSum") Then
            wstate = winState3
        ElseIf (myWindow = "inMoney2") Then
            wstate = winState4
        ElseIf (myWindow = "incSumGraph") Then
            wstate = winState5
        ElseIf (myWindow = "selPeriod") Then
            wstate = winState6
        ElseIf (myWindow = "outMoney") Then
            wstate = winState7
        End If
        Return wstate
    End Function
End Module
