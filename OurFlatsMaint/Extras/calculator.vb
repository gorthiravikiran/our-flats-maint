Public Class calculator

    Dim firstnumber As Double = 0
    Dim secondNumber As Double = 0
    Dim result As Double = 0
    Dim firstNumberEntered As Boolean
    Dim secondNumberEntered As Boolean
    Dim operationJustEntered As Boolean 'used to keep old value immediately
    'after an operation is pressed
    Dim OldOperation As String = "equals" 'everything starts good
    Dim currentButton As String
    Dim newOperation As String


    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        'firstNumEntered = False
        If operationJustEntered = True Then 'mechanism allows old digit
            lblDisplay.Text = "0"           'from first number
            operationJustEntered = False    'to be displayed without
            Exit Sub
        ElseIf (lblDisplay.Text.Contains(".")) Then
            lblDisplay.Text = lblDisplay.Text & "0"
        ElseIf Val(lblDisplay.Text) = 0 Then
            lblDisplay.Text = "0"
        Else
            lblDisplay.Text = lblDisplay.Text & "0"
        End If
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        'enter 1
        If operationJustEntered = True Then 'mechanism allows old digit
            lblDisplay.Text = "1"           'from first number
            operationJustEntered = False    'to be displayed without
            Exit Sub                        'clearing
        End If

        If (lblDisplay.Text.Contains(".")) Then
            lblDisplay.Text = lblDisplay.Text & "1"
        ElseIf Val(lblDisplay.Text) = 0 Then
            lblDisplay.Text = "1"
        Else
            lblDisplay.Text = lblDisplay.Text & "1"
        End If

    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        'enter 2
        If operationJustEntered = True Then
            lblDisplay.Text = "2"
            operationJustEntered = False
            Exit Sub
        End If
        If (lblDisplay.Text.Contains(".")) Then
            lblDisplay.Text = lblDisplay.Text & "2"
        ElseIf Val(lblDisplay.Text) = 0 Then
            lblDisplay.Text = "2"
        Else
            lblDisplay.Text = lblDisplay.Text & "2"
        End If
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        'enter 3
        If operationJustEntered = True Then
            lblDisplay.Text = "3"
            operationJustEntered = False
            Exit Sub
        End If
        If (lblDisplay.Text.Contains(".")) Then
            lblDisplay.Text = lblDisplay.Text & "3"
        ElseIf Val(lblDisplay.Text) = 0 Then
            lblDisplay.Text = "3"
        Else
            lblDisplay.Text = lblDisplay.Text & "3"
        End If
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        'enter 4
        If operationJustEntered = True Then
            lblDisplay.Text = "4"
            operationJustEntered = False
            Exit Sub
        End If
        If (lblDisplay.Text.Contains(".")) Then
            lblDisplay.Text = lblDisplay.Text & "4"
        ElseIf Val(lblDisplay.Text) = 0 Then
            lblDisplay.Text = "4"
        Else
            lblDisplay.Text = lblDisplay.Text & "4"
        End If
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        'enter 5
        If operationJustEntered = True Then
            lblDisplay.Text = "5"
            operationJustEntered = False
            Exit Sub
        End If
        If (lblDisplay.Text.Contains(".")) Then
            lblDisplay.Text = lblDisplay.Text & "5"
        ElseIf Val(lblDisplay.Text) = 0 Then
            lblDisplay.Text = "5"
        Else
            lblDisplay.Text = lblDisplay.Text & "5"
        End If
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        'enter 6
        If operationJustEntered = True Then
            lblDisplay.Text = "6"
            operationJustEntered = False
            Exit Sub
        End If
        If (lblDisplay.Text.Contains(".")) Then
            lblDisplay.Text = lblDisplay.Text & "6"
        ElseIf Val(lblDisplay.Text) = 0 Then
            lblDisplay.Text = "6"
        Else
            lblDisplay.Text = lblDisplay.Text & "6"
        End If
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        'enter 7
        If operationJustEntered = True Then
            lblDisplay.Text = "7"
            operationJustEntered = False
            Exit Sub
        End If
        If (lblDisplay.Text.Contains(".")) Then
            lblDisplay.Text = lblDisplay.Text & "7"
        ElseIf Val(lblDisplay.Text) = 0 Then
            lblDisplay.Text = "7"
        Else
            lblDisplay.Text = lblDisplay.Text & "7"
        End If
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        'enter 8
        If operationJustEntered = True Then 'mechanism allows old digit
            lblDisplay.Text = "8"           'from first number
            operationJustEntered = False    'to be displayed without
            Exit Sub                        'clearing
        End If
        If (lblDisplay.Text.Contains(".")) Then
            lblDisplay.Text = lblDisplay.Text & "8"
        ElseIf Val(lblDisplay.Text) = 0 Then
            lblDisplay.Text = "8"
        Else
            lblDisplay.Text = lblDisplay.Text & "8"
        End If
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        'enter 9
        If operationJustEntered = True Then 'mechanism allows old digit
            lblDisplay.Text = "9"           'from first number
            operationJustEntered = False    'to be displayed without
            Exit Sub                        'clearing
        End If
        If (lblDisplay.Text.Contains(".")) Then
            lblDisplay.Text = lblDisplay.Text & "9"
        ElseIf Val(lblDisplay.Text) = 0 Then
            lblDisplay.Text = "9"
        Else
            lblDisplay.Text = lblDisplay.Text & "9"
        End If
    End Sub

    Private Sub btnDec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDec.Click
        If operationJustEntered = True Then
            lblDisplay.Text = "."
            operationJustEntered = False
            Exit Sub
        End If
        If (lblDisplay.Text).Contains(".") Then
            Exit Sub
        Else
            lblDisplay.Text = lblDisplay.Text & "."
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        reset()
    End Sub

    Sub reset()
        lblDisplay.Text = ""
        OldOperation = "equals"
        firstnumber = 0
        secondNumber = 0
        firstNumberEntered = False
        secondNumberEntered = False
        operationJustEntered = False
        currentButton = False
    End Sub

    Private Sub btnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivide.Click
        'currentButton = "division"
        newOperation = "division"
        If OldOperation = "equals" Then 'last button hit was the equal button
            firstnumber = Val(lblDisplay.Text)
            OldOperation = "division"
        Else 'need to calculate result as it says last operation was a + or - or * or /
            calculateResult()
            firstnumber = result
            OldOperation = "division"
        End If
        operationJustEntered = True
    End Sub

    Private Sub btnMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiply.Click
        newOperation = "multiplication"
        If OldOperation = "equals" Then 'last button hit was the equal button
            firstnumber = Val(lblDisplay.Text)
            OldOperation = "multiplication"
        Else 'need to calculate result as it says last operation was a + or - or * or /
            calculateResult()
            firstnumber = result
            OldOperation = "multiplication"
        End If
        operationJustEntered = True
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        newOperation = "addition"
        If OldOperation = "equals" Then 'last button hit was the equal button
            firstnumber = Val(lblDisplay.Text)
            OldOperation = "addition"
        Else 'need to calculate result as it says last operation was a + or - or * or /
            calculateResult()
            firstnumber = result
            OldOperation = "addition"
        End If
        operationJustEntered = True
    End Sub

    Private Sub btnSubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubtract.Click
        newOperation = "subtraction"
        If OldOperation = "equals" Then 'last button hit was the equal button
            firstnumber = Val(lblDisplay.Text)
            OldOperation = "subtraction"
        Else 'need to calculate result as it says last operation was a + or - or * or /
            calculateResult()
            firstnumber = result
            OldOperation = "subtraction"
        End If
        operationJustEntered = True
    End Sub

    Private Sub btnEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEqual.Click
        currentButton = "equals"
        calculateResult()
        operationJustEntered = True
        OldOperation = "equals"
    End Sub
    Sub calculateResult()
        Dim answer As Double

        If OldOperation = "division" Then
            If Val(lblDisplay.Text) = 0 Then 'division by 0 error
                reset()
                lblDisplay.Text = "Error"
                Exit Sub
            End If
            secondNumber = Val(lblDisplay.Text)
            answer = Math.Round((firstnumber / secondNumber), 12)
            result = answer
            firstNumberEntered = True
            firstnumber = True
            firstnumber = Val(lblDisplay.Text) 'record answer for next operation
            OldOperation = currentButton
        End If
        If OldOperation = "multiplication" Then
            secondNumber = Val(lblDisplay.Text)
            answer = Math.Round((firstnumber * secondNumber), 12)
            result = answer
            firstNumberEntered = True
            firstnumber = True
            firstnumber = Val(lblDisplay.Text) 'record answer for next operation
            OldOperation = currentButton

        End If
        If OldOperation = "addition" Then
            secondNumber = Val(lblDisplay.Text)
            answer = Math.Round((firstnumber + secondNumber), 12)
            result = answer
            firstNumberEntered = True
            firstnumber = True
            firstnumber = Val(lblDisplay.Text) 'record answer for next operation
            OldOperation = currentButton
        End If
        If OldOperation = "subtraction" Then
            secondNumber = Val(lblDisplay.Text)
            answer = Math.Round((firstnumber - secondNumber), 12)
            result = answer
            firstNumberEntered = True
            firstnumber = True
            firstnumber = Val(lblDisplay.Text) 'record answer for next operation
            OldOperation = currentButton
        End If
        answer = Math.Round(answer, 12) 'first round the answer
        If answer > 999999999999 Then   'then check for size
            lblDisplay.Text = "Error"
        Else
            lblDisplay.Text = CStr(answer)
        End If
    End Sub

    Private Sub btnNegate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNegate.Click
        Dim answer As Double = Val(lblDisplay.Text)
        answer = -1.0 * answer
        lblDisplay.Text = answer.ToString()
    End Sub

    Private Sub calculator_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        flatHome.CalculatorTool.Checked = False
    End Sub

    Private Sub calculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = flatHome
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
    End Sub
End Class
