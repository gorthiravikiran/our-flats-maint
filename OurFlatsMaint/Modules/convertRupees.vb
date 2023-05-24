Option Explicit On
Module convertRupees
    Public Function cNumToWord(ByVal src_num As String) As String
        Dim SNUM As Double
        SNUM = Val(src_num)
        If SNUM > 999999999999999.0# Then
            cNumToWord = "Error: Too much Number."
            Exit Function
        End If
        Dim WHOLE As String
        Dim EXTRA As String
        Dim WORD As String
        Dim NWHOLE As Double

        If InStr(1, Str$(SNUM), ",", vbTextCompare) <> 0 Then
            WHOLE = Split(src_num, ",")(0)
            EXTRA = Split(src_num, ",")(1)
        Else
            WHOLE = SNUM
        End If

        If SNUM < 1 Then
            WORD = "Zero"
        End If
        NWHOLE = Val(WHOLE)

        'Check for Ones
        If NWHOLE > 9 Then
            If (Right(NWHOLE, 1)) <> "0" Then
                WORD = WordTens(Val(Right(NWHOLE, 1)))
            End If
        End If

        'Check for Tens
        If Val(Right(NWHOLE, 2)) > 0 And Val(Right(NWHOLE, 2)) < 21 Or Val(Right(NWHOLE, 2)) = 30 Or Val(Right(NWHOLE, 2)) = 40 Or Val(Right(NWHOLE, 2)) = 50 Or Val(Right(NWHOLE, 2)) = 60 Or Val(Right(NWHOLE, 2)) = 70 Or Val(Right(NWHOLE, 2)) = 80 Or Val(Right(NWHOLE, 2)) = 90 Then
            WORD = "and " & WordTens(Val(Right(NWHOLE, 2))) & WORD
        ElseIf Val(Right(NWHOLE, 2)) > 20 Then
            WORD = "and " & WordTens(Left(Right(NWHOLE, 2), 1) & "0") & WORD
        End If

        ' Check for Hundred
        If NWHOLE > 99 Then
            If Left(Right(NWHOLE, 3), 1) <> "0" Then
                WORD = WordTens(Left(Right(NWHOLE, 3), 1)) & " Hundred" & WORD
            End If

            'Check for Thousand
            If NWHOLE > 999 Then
                If Val(Left(NWHOLE, Len("" & NWHOLE) - 3)) > 0 And Val(Left(NWHOLE, Len("" & NWHOLE) - 3)) < 21 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 3)) = 30 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 3)) = 40 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 3)) = 50 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 3)) = 60 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 3)) = 70 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 3)) = 80 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 3)) = 90 Then
                    WORD = WordTens(Val(Left(NWHOLE, Len("" & NWHOLE) - 3))) & " Thousand" & WORD
                ElseIf Val(Left(NWHOLE, Len("" & NWHOLE) - 3)) > 20 And Right(Left(NWHOLE, Len("" & NWHOLE) - 3), 3) <> "000" Then
                    WORD = WordTens(Mid(Right(Val(Left(NWHOLE, Len("" & NWHOLE) - 3)), 2), 2, 1)) & " Thousand" & WORD
                    WORD = WordTens(Mid(Right(Val(Left(NWHOLE, Len("" & NWHOLE) - 3)), 2), 1, 1) & "0") & WORD
                    If Val(Left(NWHOLE, Len("" & NWHOLE) - 3)) > 99 Then
                        If Left(Right(NWHOLE, 6), 1) <> "0" Then
                            WORD = WordTens(Left(Right(NWHOLE, 6), 1)) & " Hundred" & WORD
                        End If
                    End If
                End If

                ' Check for Lakh
                If NWHOLE > 99999 Then
                    If Val(Left(NWHOLE, Len("" & NWHOLE) - 5)) > 0 And Val(Left(NWHOLE, Len("" & NWHOLE) - 5)) < 21 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 5)) = 30 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 5)) = 40 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 5)) = 50 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 5)) = 60 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 5)) = 70 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 5)) = 80 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 5)) = 90 Then
                        WORD = WordTens(Val(Left(NWHOLE, Len("" & NWHOLE) - 5))) & " Lakh" & WORD
                    ElseIf Val(Left(NWHOLE, Len("" & NWHOLE) - 5)) > 20 And Right(Left(NWHOLE, Len("" & NWHOLE) - 5), 3) <> "000" Then
                        WORD = WordTens(Mid(Right(Val(Left(NWHOLE, Len("" & NWHOLE) - 5)), 2), 2, 1)) & " Lakh" & WORD
                        WORD = WordTens(Mid(Right(Val(Left(NWHOLE, Len("" & NWHOLE) - 5)), 2), 1, 1)) & "0" & WORD
                        If Val(Left(NWHOLE, Len("" & NWHOLE) - 5)) > 99 Then
                            If Left(Right(NWHOLE, 9), 1) <> "0" Then
                                WORD = WordTens(Left(Right(NWHOLE, 9), 1)) & " Hundred" & WORD
                            End If
                        End If
                    End If

                    ' Check for Crore
                    If NWHOLE > 9999999 Then
                        If Val(Left(NWHOLE, Len("" & NWHOLE) - 7)) > 0 And Val(Left(NWHOLE, Len("" & NWHOLE) - 7)) < 21 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 7)) = 30 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 7)) = 40 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 7)) = 50 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 7)) = 60 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 7)) = 70 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 7)) = 80 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 7)) = 90 Then
                            WORD = WordTens(Val(Left(NWHOLE, Len("" & NWHOLE) - 7))) & " Crore" & WORD
                        ElseIf Val(Left(NWHOLE, Len("" & NWHOLE) - 7)) > 20 And Right(Left(NWHOLE, Len("" & NWHOLE) - 7), 3) <> "000" Then
                            WORD = WordTens(Mid(Right(Val(Left(NWHOLE, Len("" & NWHOLE) - 7)), 2), 2, 1)) & " Crore" & WORD
                            WORD = WordTens(Mid(Right(Val(Left(NWHOLE, Len("" & NWHOLE) - 7)), 2), 1, 1)) & "0" & WORD
                            If Val(Left(NWHOLE, Len("" & NWHOLE) - 5)) > 99 Then
                                If Left(Right(NWHOLE, 9), 1) <> "0" Then
                                    WORD = WordTens(Left(Right(NWHOLE, 9), 1)) & " Hundred" & WORD
                                End If
                            End If
                        End If

                        ' Check for Billion
                        If NWHOLE > 999999999 Then
                            If Val(Left(NWHOLE, Len("" & NWHOLE) - 9)) > 0 And Val(Left(NWHOLE, Len("" & NWHOLE) - 9)) < 21 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 9)) = 30 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 9)) = 40 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 9)) = 50 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 9)) = 60 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 9)) = 70 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 9)) = 80 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 9)) = 90 Then
                                WORD = WordTens(Val(Left(NWHOLE, Len("" & NWHOLE) - 9))) & " Billion" & WORD
                            ElseIf Val(Left(NWHOLE, Len("" & NWHOLE) - 9)) > 20 And Right(Left(NWHOLE, Len("" & NWHOLE) - 9), 3) <> "000" Then
                                WORD = WordTens(Mid(Right(Val(Left(NWHOLE, Len("" & NWHOLE) - 9)), 2), 2, 1)) & " Billion" & WORD
                                WORD = WordTens(Mid(Right(Val(Left(NWHOLE, Len("" & NWHOLE) - 9)), 2), 1, 1)) & "0" & WORD
                                If Val(Left(NWHOLE, Len("" & NWHOLE) - 5)) > 99 Then
                                    If Left(Right(NWHOLE, 9), 1) <> "0" Then
                                        WORD = WordTens(Left(Right(NWHOLE, 9), 1)) & " Hundred" & WORD
                                    End If
                                End If
                            End If

                            ' Check for Trillion
                            If NWHOLE > 99999999999.0# Then
                                If Val(Left(NWHOLE, Len("" & NWHOLE) - 11)) > 0 And Val(Left(NWHOLE, Len("" & NWHOLE) - 11)) < 21 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 11)) = 30 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 11)) = 40 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 11)) = 50 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 11)) = 60 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 11)) = 70 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 11)) = 80 Or Val(Left(NWHOLE, Len("" & NWHOLE) - 11)) = 110 Then
                                    WORD = WordTens(Val(Left(NWHOLE, Len("" & NWHOLE) - 11))) & " Trillion" & WORD
                                ElseIf Val(Left(NWHOLE, Len("" & NWHOLE) - 11)) > 20 And Right(Left(NWHOLE, Len("" & NWHOLE) - 11), 3) <> "000" Then
                                    WORD = WordTens(Mid(Right(Val(Left(NWHOLE, Len("" & NWHOLE) - 11)), 2), 2, 1)) & " Trillion" & WORD
                                    WORD = WordTens(Mid(Right(Val(Left(NWHOLE, Len("" & NWHOLE) - 11)), 2), 1, 1)) & "0" & WORD
                                    If Val(Left(NWHOLE, Len("" & NWHOLE) - 5)) > 99 Then
                                        If Left(Right(NWHOLE, 9), 1) <> "0" Then
                                            WORD = WordTens(Left(Right(NWHOLE, 9), 1)) & " Hundred" & WORD
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If


        cNumToWord = WORD
        NWHOLE = 0
        WORD = ""
        EXTRA = ""
        WHOLE = ""
    End Function

    Private Function WordTens(ByVal SNUM As String) As String
        Select Case Val(SNUM)
            Case 1 : WordTens = " One"
            Case 2 : WordTens = " Two"
            Case 3 : WordTens = " Three"
            Case 4 : WordTens = " Four"
            Case 5 : WordTens = " Five"
            Case 6 : WordTens = " Six"
            Case 7 : WordTens = " Seven"
            Case 8 : WordTens = " Eight"
            Case 9 : WordTens = " Nine"
            Case 10 : WordTens = " Ten"
            Case 11 : WordTens = " Eleven"
            Case 12 : WordTens = " Twelve"
            Case 13 : WordTens = " Thirteen"
            Case 14 : WordTens = " Fourteen"
            Case 15 : WordTens = " Fifteen"
            Case 16 : WordTens = " Sixteen"
            Case 17 : WordTens = " Seventeen"
            Case 18 : WordTens = " Eighteen"
            Case 19 : WordTens = " Nineteen"
            Case 20 : WordTens = " Twenty"
            Case 30 : WordTens = " Thirty"
            Case 40 : WordTens = " Forty"
            Case 50 : WordTens = " Fifty"
            Case 60 : WordTens = " Sixty"
            Case 70 : WordTens = " Seventy"
            Case 80 : WordTens = " Eighty"
            Case 90 : WordTens = " Ninety"
            Case Else
        End Select
    End Function

    Public Function cDecToWords(ByVal src_num As String) As String
        Dim SNUM As Double
        SNUM = Val(src_num)
        If SNUM > 999999999999999.0# Then
            cDecToWords = "Error: Too much number."
            Exit Function
        End If

        Dim WHOLE As String
        Dim EXTRA As String
        Dim WORD As String
        Dim NWHOLE As Double

        If InStr(1, Str$(SNUM), ".", vbTextCompare) <> 0 Then
            WHOLE = Split(Str$(SNUM), ".")(0)
            EXTRA = Split(src_num, ".")(1)
        Else
            WHOLE = SNUM
        End If

        If SNUM < 1 Then
            WORD = "Zero"
        End If
        NWHOLE = Val(WHOLE)

        ' Check for One and Tens
        If Val(Right(NWHOLE, 2)) > 0 And Val(Right(NWHOLE, 2)) < 21 Or Val(Right(NWHOLE, 2)) = 30 Or Val(Right(NWHOLE, 2)) = 40 Or Val(Right(NWHOLE, 2)) = 50 Or Val(Right(NWHOLE, 2)) = 60 Or Val(Right(NWHOLE, 2)) = 70 Or Val(Right(NWHOLE, 2)) = 80 Or Val(Right(NWHOLE, 2)) = 90 Then
            WORD = WORD & WordTens(Left(Right(NWHOLE, 2), 1) & "0")
            WORD = WORD & WordTens(Right(NWHOLE, 1))
        End If
        cDecToWords = WORD
    End Function

    Public Sub num(ByVal key As Integer)
        Dim strval As String
        strval = "0123456789"

        If key = 46 Then
            SendKeys.Send("{RIGHT}{TAB}")
        End If
        If key > 26 Then
            If InStr(strval, Chr(key)) = 0 Then
                key = 0
            End If
        End If
    End Sub

    Public Sub Text1_KeyPress(ByVal KeyAscii As Integer)
        If KeyAscii = 13 Then
            SendKeys.Send("{TAB}")
            SendKeys.Send("{ENTER}")
        End If
    End Sub

End Module
