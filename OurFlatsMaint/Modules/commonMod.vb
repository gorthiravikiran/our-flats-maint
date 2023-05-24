Imports System.Data.OleDb

Module commonMod
    Dim conn As OleDbConnection
    Dim sql, sql1, sql2 As String
    Dim da As OleDbDataAdapter
    Dim cmd, dc As OleDbCommand
    Dim dt, dt1, dt2 As DataTable
    Dim ds, ds1, ds2 As DataSet
    Dim count As Integer
    'Execute Non Query
    Dim result As Boolean
    Dim graph, routedFrom As String
    Public Function ExecNonQuery(ByVal strSQL As String)
        conn = flatsConn.getConnection
        Try
            With conn
                If .State = ConnectionState.Open Then .Close()
                .Open()
            End With

            cmd = New OleDbCommand(strSQL, conn)
            cmd.ExecuteNonQuery()

            Return True
        Catch ex As OleDbException
            Return ex
        Finally
            conn.Close()
        End Try
    End Function

    Public Sub setSelectedPeriod(ByVal gmode As String)
        graph = gmode
    End Sub

    Public Function getSelectedPeriod()
        Return graph
    End Function

    Public Sub setRoutedFrom(ByVal rtdFrom As String)
        routedFrom = rtdFrom
    End Sub

    Public Function getRoutedFrom()
        Return graph
    End Function

    Public Function checkOldPwd(ByVal str As String) As Boolean
        sql = "SELECT PASSWORD FROM USERS WHERE USERNAME = 'Master'"
        Dim oldpwd As String = ""
        conn = flatsConn.getConnection
        da = New OleDbDataAdapter(sql, conn)
        dt = New DataTable
        Try
            da.Fill(dt)
            oldpwd = dt.Rows(0)("PASSWORD").ToString
            If oldpwd = str Then
                result = True
            Else
                result = False
            End If
        Catch ex As Exception
            MsgBox("Ooops! Error occurred while accessing Database")
            result = False
        Finally
            conn.Close()
            conn.Dispose()
            da.Dispose()
        End Try
        Return result
    End Function
    Public Function fetchPassword() As DataSet
        Dim conn As OleDbConnection
        conn = flatsConn.getConnection
        conn.Open()

        Try
            ds = New DataSet
            sql = "SELECT * FROM USERS"
            da = New OleDb.OleDbDataAdapter(sql, conn)

            Try
                da.Fill(ds)
                setUserid(ds.Tables(0).Rows(0)("USER_ID").ToString)
            Finally
                da.Dispose()
            End Try
            Return ds
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Function
    Friend userid As String
    Private Sub setUserid(ByVal uid As String)
        userid = uid
    End Sub

    Private Function getUserid() As String
        Return userid
    End Function

    Public Function updPassword(ByVal dset As DataSet) As Boolean
        Dim saveStatus As Boolean = False
        conn = flatsConn.getConnection
        Try
            sql = "SELECT * FROM USERS WHERE USER_ID = " & getUserid()
            da = New OleDbDataAdapter(sql, conn)

            Try
                Dim cb As OleDbCommandBuilder = New OleDbCommandBuilder(da)
                If dset.HasChanges Then
                    da.Update(dset)
                    dset.AcceptChanges()
                    saveStatus = True
                End If
            Finally
                da.Dispose()
            End Try
        Catch ex As Exception
            saveStatus = False
        Finally
            conn.Close()
            conn.Dispose()
        End Try
        Return saveStatus
    End Function

    Public Function formatBytes(ByVal num_bytes As Double) As String
        Const ONE_KB As Double = 1024
        Const ONE_MB As Double = ONE_KB * 1024
        Const ONE_GB As Double = ONE_MB * 1024
        Const ONE_TB As Double = ONE_GB * 1024
        Const ONE_PB As Double = ONE_TB * 1024
        Const ONE_EB As Double = ONE_PB * 1024
        Const ONE_ZB As Double = ONE_EB * 1024
        Const ONE_YB As Double = ONE_ZB * 1024
        Dim result As String = ""
        'See how big the value is
        If num_bytes <= 999 Then
            'format in bytes
            result = Format$(num_bytes, "0") & " bytes"
        ElseIf num_bytes <= ONE_KB * 999 Then
            'format in Kilo Byte
            result = ThreeNonZerodigits(num_bytes / ONE_KB) & " " & "KB"
        ElseIf num_bytes <= ONE_MB * 999 Then
            'format in Mega Byte
            result = ThreeNonZerodigits(num_bytes / ONE_MB) & " " & "MB"
        ElseIf num_bytes <= ONE_GB * 999 Then
            'format in Gega Byte
            result = ThreeNonZerodigits(num_bytes / ONE_GB) & " " & "GB"
        ElseIf num_bytes <= ONE_TB * 999 Then
            'format in Tera Byte
            result = ThreeNonZerodigits(num_bytes / ONE_TB) & " " & "TB"
        ElseIf num_bytes <= ONE_PB * 999 Then
            'format in Peta Byte
            result = ThreeNonZerodigits(num_bytes / ONE_PB) & " " & "PB"
        ElseIf num_bytes <= ONE_EB * 999 Then
            'format in Exa Byte
            result = ThreeNonZerodigits(num_bytes / ONE_EB) & " " & "EB"
        ElseIf num_bytes <= ONE_ZB * 999 Then
            'format in Zetta Byte
            result = ThreeNonZerodigits(num_bytes / ONE_ZB) & " " & "ZB"
        ElseIf num_bytes <= ONE_YB * 999 Then
            'format in Yotta Byte
            result = ThreeNonZerodigits(num_bytes / ONE_YB) & " " & "YB"
        End If
        ' Return the value formatted to include at most three non-zero digits and at most two digits after the decial point.
        ' Examples: -
        '      1
        '    123
        '     12.3
        '      1.23
        '      0.12
        Return result
    End Function

    Private Function ThreeNonZerodigits(ByVal value As Double) As String
        If value >= 100 Then
            ' No digits after the decimal.
            Return Format$(CInt(value))
        ElseIf value >= 10 Then
            ' One digit after the decimal.
            Return Format$(value, "0.0")
        Else
            ' Two digits after the decimal.
            Return Format$(value, "0.00")
        End If
    End Function
    Public category, rateCategory As String
    Public Sub setPayCategory(ByVal cat As String)
        category = cat
    End Sub

    Public Function getPayCategory()
        Return category
    End Function

    Public Sub setRateCategory(ByVal ratCat As String)
        rateCategory = ratCat
    End Sub

    Public Function getRateCategory()
        Return rateCategory
    End Function

    Private Function getSqlClauses(ByVal input As String)
        Dim clauseArrayList As New ArrayList
        Dim typeClause As String = ""
        Dim rateClause As String = ""
        Dim thirdClause As String = ""
        Dim fromClause As String = ""
        If getRateCategory() Is Nothing Then
            fromClause = getPayCategory()
        Else
            fromClause = getRateCategory()
        End If

        If fromClause = "MAINT_CHARGES" Then
            typeClause = "MAINT_DATE"
            rateClause = "MAINT_RATE"
            thirdClause = "MEETING_DATE"
        ElseIf fromClause = "WATCHMAN_SALARY" Then
            typeClause = "SALARY_DATE"
            rateClause = "SALARY_RATE"
            thirdClause = "WATCHMAN_NAME"
        ElseIf fromClause = "LIFT_MAINTENANCE" Then
            typeClause = "LIFT_DATE"
            rateClause = "LIFT_RATE"
            thirdClause = "VENDOR_NAME"
        ElseIf fromClause = "SPECIAL_FUNDS" Then
            typeClause = "FUND_DATE"
            rateClause = "FUND_RATE"
            thirdClause = "FUND_CAUSE"
        ElseIf fromClause = "GARBAGE" Then
            typeClause = "GARBAGE_DATE"
            rateClause = "GARBAGE_RATE"
            thirdClause = "GARBAGE_AGENT"
        ElseIf fromClause = "WATER_BILL" Then
            typeClause = "WATER_DATE"
            rateClause = "WATER_RATE"
            thirdClause = "WATER_BOARD"
        End If
        clauseArrayList.Add(typeClause)
        clauseArrayList.Add(rateClause)
        clauseArrayList.Add(thirdClause)
        Return clauseArrayList
    End Function

    Public Function fetchRateData() As ArrayList
        Dim oldRate, oldRateDate, misc As String
        Dim lastID As Integer
        Dim rateArray As New ArrayList
        dt = New DataTable
        dt1 = New DataTable
        conn = flatsConn.getConnection
        conn.Open()
        Dim sqlClauses As ArrayList = getSqlClauses(getRateCategory)
        Dim typeClause1 As String = sqlClauses.Item(0).ToString
        Dim rateClause1 As String = sqlClauses.Item(1).ToString
        Dim thirdClause1 As String = sqlClauses.Item(2).ToString
        Dim fromClause As String = ""
        If getRateCategory() Is Nothing Then
            fromClause = getPayCategory()
        Else
            fromClause = getRateCategory()
        End If
        sql = "SELECT MAX(ID) AS Expr1 FROM " & fromClause
        'Clipboard.SetText(sql)
        da = New OleDbDataAdapter(sql, conn)

        Try
            da.Fill(dt)
            lastID = Integer.Parse(dt.Rows(0)("Expr1").ToString())
            sql1 = "SELECT " & typeClause1 & ", " & rateClause1 & ", " & thirdClause1 & " FROM " & fromClause & " WHERE ID = " & lastID
            Clipboard.SetText(sql1)
            Dim da1 As OleDbDataAdapter = New OleDbDataAdapter(sql1, conn)
            Try
                da1.Fill(dt1)
                oldRate = dt1.Rows(0)(rateClause1).ToString
                oldRateDate = dt1.Rows(0)(typeClause1).ToString
                misc = dt1.Rows(0)(thirdClause1).ToString
                rateArray.Add(oldRateDate)
                rateArray.Add(oldRate)
                rateArray.Add(misc)
                rateArray.Add(thirdClause1)
            Finally
                da1.Dispose()
                dt1.Dispose()
            End Try
        Finally
            da.Dispose()
            dt.Dispose()
        End Try
        conn.Close()
        conn.Dispose()
        Return rateArray
    End Function

    Public Function fetchDuesData() As ArrayList
        Dim oldRate, oldRateDate, misc As String
        Dim lastID As Integer
        Dim rateArray As New ArrayList
        dt = New DataTable
        dt1 = New DataTable
        conn = flatsConn.getConnection
        conn.Open()
        Dim sqlClauses As ArrayList = getSqlClauses(getRateCategory)
        Dim typeClause1 As String = sqlClauses.Item(0).ToString
        Dim rateClause1 As String = sqlClauses.Item(1).ToString
        Dim thirdClause1 As String = sqlClauses.Item(2).ToString
        Dim fromClause As String = ""
        If getRateCategory() Is Nothing Then
            fromClause = getPayCategory()
        Else
            fromClause = getRateCategory()
        End If
        sql = "SELECT MAX(ID) AS Expr1 FROM " & fromClause
        'Clipboard.SetText(sql)
        da = New OleDbDataAdapter(sql, conn)

        Try
            da.Fill(dt)
            lastID = Integer.Parse(dt.Rows(0)("Expr1").ToString())
            sql1 = "SELECT " & typeClause1 & ", " & rateClause1 & ", " & thirdClause1 & " FROM " & fromClause & " WHERE ID = " & lastID
            Clipboard.SetText(sql1)
            Dim da1 As OleDbDataAdapter = New OleDbDataAdapter(sql1, conn)
            Try
                da1.Fill(dt1)
                oldRate = dt1.Rows(0)(rateClause1).ToString
                oldRateDate = dt1.Rows(0)(typeClause1).ToString
                misc = dt1.Rows(0)(thirdClause1).ToString
                rateArray.Add(oldRateDate)
                rateArray.Add(oldRate)
                rateArray.Add(misc)
                rateArray.Add(thirdClause1)
            Finally
                da1.Dispose()
                dt1.Dispose()
            End Try
        Finally
            da.Dispose()
            dt.Dispose()
        End Try
        conn.Close()
        conn.Dispose()
        Return rateArray
    End Function

    Public Function fetchOldDuesByFlatNo(ByVal flatno As String)
        dt = New DataTable
        conn = flatsConn.getConnection
        conn.Open()
        sql = "SELECT DUE_DATE, CATEGORY, DUE_AMOUNT FROM OLD_DUES WHERE FLAT_NO = '" & flatno & "'"
        da = New OleDbDataAdapter(sql, conn)
        Try
            da.Fill(dt)
            If Not dt.Rows.Count = 0 Then
                dt.Rows.Add(0)
            End If
        Finally
            da.Dispose()
            dt.Dispose()
        End Try
        conn.Close()
        conn.Dispose()
        Return dt
    End Function

    Public Function fetchOldDuesTotalByFlatNo(ByVal flatno As String)
        dt = New DataTable
        conn = flatsConn.getConnection
        conn.Open()
        sql = "SELECT SUM(DUE_AMOUNT) AS AMOUNT FROM OLD_DUES WHERE FLAT_NO = '" & flatno & "'"
        da = New OleDbDataAdapter(sql, conn)
        Try
            da.Fill(dt)
            If Not dt.Rows.Count = 0 Then
                dt.Rows.Add(0)
            End If
        Finally
            da.Dispose()
            dt.Dispose()
        End Try
        conn.Close()
        conn.Dispose()
        Return dt
    End Function

    Public Function setRateData(ByVal dtArray As ArrayList) As Boolean
        Dim saveStatus As Boolean = False
        conn = flatsConn.getConnection
        Dim a1, a2, a3 As String
        a1 = dtArray.Item(0)
        a2 = dtArray.Item(1)
        a3 = dtArray.Item(2)
        If getRateCategory() = "MAINT_CHARGES" Then
            sql = "INSERT INTO " & getRateCategory() & " (MAINT_DATE, MAINT_RATE, MEETING_DATE) VALUES ('" & a1 & "', '" & a2 & "', '" & a3 & "')"
        ElseIf getRateCategory() = "WATCHMAN_SALARY" Then
            sql = "INSERT INTO " & getRateCategory() & " (SALARY_DATE, SALARY_RATE, WATCHMAN_NAME) VALUES ('" & a1 & "', '" & a2 & "', '" & a3 & "')"
        ElseIf getRateCategory() = "LIFT_MAINTENANCE" Then
            sql = "INSERT INTO " & getRateCategory() & " (LIFT_DATE, LIFT_RATE, VENDOR_NAME) VALUES ('" & a1 & "', '" & a2 & "', '" & a3 & "')"
        ElseIf getRateCategory() = "SPECIAL_FUNDS" Then
            sql = "INSERT INTO " & getRateCategory() & " (FUND_DATE, FUND_RATE, FUND_CAUSE) VALUES ('" & a1 & "', '" & a2 & "', '" & a3 & "')"
        ElseIf getRateCategory() = "GARBAGE" Then
            sql = "INSERT INTO " & getRateCategory() & " (GARBAGE_DATE, GARBAGE_RATE, GARBAGE_AGENT) VALUES ('" & a1 & "', '" & a2 & "', '" & a3 & "')"
        End If

        Try
            If Not a1 = "" Or a2 = "" Or a2 = "Enter Amount" Or a3 = "" Then
                conn.Open()
                dc = New OleDbCommand(sql, conn)
                count = dc.ExecuteNonQuery()
                saveStatus = True
            Else
                saveStatus = False
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            saveStatus = False
        Finally
            dc.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
        Application.DoEvents()
        Return saveStatus
    End Function

End Module
