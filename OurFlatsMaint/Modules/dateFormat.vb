Module dateFormat

    Public Function customizeDate(ByVal dateStr As Date) As String
        Dim myDate As String
        Dim dt, mon, month, yr As String
        dt = dateStr.Day.ToString
        mon = dateStr.Month.ToString
        month = ""
        If mon = 1 Then
            month = "JAN"
        ElseIf mon = 2 Then
            month = "FEB"
        ElseIf mon = 3 Then
            month = "MAR"
        ElseIf mon = 4 Then
            month = "APR"
        ElseIf mon = 5 Then
            month = "MAY"
        ElseIf mon = 6 Then
            month = "JUN"
        ElseIf mon = 7 Then
            month = "JUL"
        ElseIf mon = 8 Then
            month = "AUG"
        ElseIf mon = 9 Then
            month = "SEP"
        ElseIf mon = 10 Then
            month = "OCT"
        ElseIf mon = 11 Then
            month = "NOV"
        ElseIf mon = 12 Then
            month = "DEC"
        End If
        yr = dateStr.Year.ToString
        myDate = dt & "-" & month & "-" & yr
        Return myDate
    End Function

    Public Function customizeDateRounded(ByVal dateStr As Date) As String
        Dim myDate As String
        Dim dt, mon, month, yr As String
        If dateStr.Day.ToString < 10 Then
            dt = "0" & dateStr.Day.ToString
        Else
            dt = dateStr.Day.ToString
        End If
        mon = dateStr.Month.ToString
        month = ""
        If mon = 1 Then
            month = "JAN"
        ElseIf mon = 2 Then
            month = "FEB"
        ElseIf mon = 3 Then
            month = "MAR"
        ElseIf mon = 4 Then
            month = "APR"
        ElseIf mon = 5 Then
            month = "MAY"
        ElseIf mon = 6 Then
            month = "JUN"
        ElseIf mon = 7 Then
            month = "JUL"
        ElseIf mon = 8 Then
            month = "AUG"
        ElseIf mon = 9 Then
            month = "SEP"
        ElseIf mon = 10 Then
            month = "OCT"
        ElseIf mon = 11 Then
            month = "NOV"
        ElseIf mon = 12 Then
            month = "DEC"
        End If
        yr = dateStr.Year.ToString
        myDate = dt & "-" & month & "-" & yr
        Return myDate
    End Function

    Public Function fetchMonthYear(ByVal dateStr As Date) As String
        Dim monthYear As String
        Dim str As Date = dateStr
        Dim mon, month, yr As String
        mon = str.Month.ToString
        month = ""
        If mon = 1 Then
            month = "JAN"
        ElseIf mon = 2 Then
            month = "FEB"
        ElseIf mon = 3 Then
            month = "MAR"
        ElseIf mon = 4 Then
            month = "APR"
        ElseIf mon = 5 Then
            month = "MAY"
        ElseIf mon = 6 Then
            month = "JUN"
        ElseIf mon = 7 Then
            month = "JUL"
        ElseIf mon = 8 Then
            month = "AUG"
        ElseIf mon = 9 Then
            month = "SEP"
        ElseIf mon = 10 Then
            month = "OCT"
        ElseIf mon = 11 Then
            month = "NOV"
        ElseIf mon = 12 Then
            month = "DEC"
        End If
        yr = str.Year.ToString
        monthYear = month & "-" & yr
        Return monthYear
    End Function

    Public Function fetchPreviousMonthYear(ByVal dateStr As Date) As String
        Dim monthYear As String
        Dim str As Date = dateStr
        Dim mon, month, yr As String
        mon = Double.Parse(str.Month.ToString) - 1
        month = ""
        If mon = 1 Then
            month = "JAN"
        ElseIf mon = 2 Then
            month = "FEB"
        ElseIf mon = 3 Then
            month = "MAR"
        ElseIf mon = 4 Then
            month = "APR"
        ElseIf mon = 5 Then
            month = "MAY"
        ElseIf mon = 6 Then
            month = "JUN"
        ElseIf mon = 7 Then
            month = "JUL"
        ElseIf mon = 8 Then
            month = "AUG"
        ElseIf mon = 9 Then
            month = "SEP"
        ElseIf mon = 10 Then
            month = "OCT"
        ElseIf mon = 11 Then
            month = "NOV"
        ElseIf mon = 12 Or mon = 0 Then
            month = "DEC"
        End If
        yr = str.Year.ToString
        monthYear = month & "-" & yr
        Return monthYear
    End Function

    Public Function fetchMonthAcro(ByVal mon As String) As String
        Dim monAcro As String = mon.Substring(0, 3)
        Return monAcro
    End Function

    Public Function fetchMonthExpand(ByVal monyy As String) As String
        Dim monExp As String = ""
        Dim extMon As String = monyy.Substring(0, 3)
        Console.Write("Month: " & monyy)

        Dim yr As String = monyy.Substring(3, 5)
        If extMon = "JAN" Then
            monExp = "JANUARY"
        ElseIf extMon = "FEB" Then
            monExp = "FEBRUARY"
        ElseIf extMon = "MAR" Then
            monExp = "MARCH"
        ElseIf extMon = "APR" Then
            monExp = "APRIL"
        ElseIf extMon = "MAY" Then
            monExp = "MAY"
        ElseIf extMon = "JUN" Then
            monExp = "JUNE"
        ElseIf extMon = "JUL" Then
            monExp = "JULY"
        ElseIf extMon = "AUG" Then
            monExp = "AUGUST"
        ElseIf extMon = "SEP" Then
            monExp = "SEPTEMBER"
        ElseIf extMon = "OCT" Then
            monExp = "OCTOBER"
        ElseIf extMon = "NOV" Then
            monExp = "NOVEMBER"
        ElseIf extMon = "DEC" Then
            monExp = "DECEMBER"
        End If
        Return monExp & yr
    End Function

    Public Function extractYearFromInput(ByVal monyy As String) As String
        Dim year As String = monyy.Substring(4, 4)
        Return year
    End Function

    Private Function extractMonthFromInput(ByVal dtstr As String)
        Dim month As String = dtstr.Substring(3, 3)
        month = month.ToUpper
        Dim mon As Integer = 0
        If month = "JAN" Then
            mon = 1
        ElseIf month = "FEB" Then
            mon = 2
        ElseIf month = "MAR" Then
            mon = 3
        ElseIf month = "APR" Then
            mon = 4
        ElseIf month = "MAY" Then
            mon = 5
        ElseIf month = "JUN" Then
            mon = 6
        ElseIf month = "JUL" Then
            mon = 7
        ElseIf month = "AUG" Then
            mon = 8
        ElseIf month = "SEP" Then
            mon = 9
        ElseIf month = "OCT" Then
            mon = 10
        ElseIf month = "NOV" Then
            mon = 11
        ElseIf month = "DEC" Then
            mon = 12
        End If
        Return mon
    End Function

    Public Function getQuarterYearFromInput(ByVal dtstr As String) As String()
        Dim mon As Integer = extractMonthFromInput(dtstr)
        Dim yr As String = dtstr.Substring(7, 4)
        Dim qtr As String = ""
        Dim output(2) As String
        If mon > 0 And mon < 4 Then
            qtr = "JAN-MAR " & yr
        ElseIf mon > 3 And mon < 7 Then
            qtr = "APR-JUN " & yr
        ElseIf mon > 6 And mon < 10 Then
            qtr = "JUL-SEP " & yr
        ElseIf mon > 9 And mon < 13 Then
            qtr = "OCT-DEC " & yr
        End If
        output(0) = qtr
        output(1) = yr
        Return output
    End Function

End Module
