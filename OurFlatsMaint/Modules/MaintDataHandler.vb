Imports System.Data.OleDb
Module MaintDataHandler
    Dim ds, dtSet As DataSet
    Dim dc As OleDbCommand
    Dim cb As OleDbCommandBuilder
    Dim da, da1, da2, da3, da4, da5 As OleDbDataAdapter
    Dim conn As OleDbConnection
    Dim dt, dt1, dt2, dt3, dt4, dt5 As DataTable
    Dim sql, sql1, sql2, sql3, sql4, sql5, err, fileid, selMonth, selQtr, selYear, searchFileCategory, searchFileOption, searchFileInput As String
    Dim count As Integer

    Public Function fetchAllFlatNumbers() As DataTable
        conn = flatsConn.getConnection
        conn.Open()

        dt = New DataTable
        sql = "SELECT FLAT_NO FROM FLATS_BASIC"
        da = New OleDb.OleDbDataAdapter(sql, conn)

        Try
            da.Fill(dt)
            Dim alist As New ArrayList
            For j As Integer = 0 To dt.Rows.Count - 1
                alist.Add(dt.Rows(j)("FLAT_NO").ToString)
            Next
        Finally
            da.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
        Return dt
    End Function

    Public Function fetchFlatNoMaintDue() As DataTable
        conn = flatsConn.getConnection
        conn.Open()
        Dim smonth As String = dateFormat.fetchMonthYear(Date.Today)
        Try
            Dim dt2 As New DataTable
            dt = New DataTable
            dt1 = New DataTable
            dt2.Columns.Add("FLAT_NO")
            sql = "SELECT FLAT_NO FROM FLATS_BASIC"
            sql1 = "SELECT FLAT_NO FROM FLATS_INCOME WHERE FOR_MONTH = '" & smonth & "'"
            da = New OleDb.OleDbDataAdapter(sql, conn)
            da1 = New OleDb.OleDbDataAdapter(sql1, conn)
            Try
                da.Fill(dt)
                da1.Fill(dt1)
                Dim alist As New ArrayList
                For j As Integer = 0 To dt1.Rows.Count - 1
                    alist.Add(dt1.Rows(j)("FLAT_NO").ToString)
                Next
                For i As Integer = 0 To dt.Rows.Count - 1
                    If Not alist.Contains(dt.Rows(i)("FLAT_NO").ToString) Then
                        dt2.Rows.Add(dt.Rows(i)("FLAT_NO").ToString)
                    End If
                Next
            Finally
                da.Dispose()
            End Try
            Return dt2
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Function

    Public Function fetchFlatNoOldDues() As DataTable
        conn = flatsConn.getConnection
        conn.Open()
        Dim smonth As String = dateFormat.fetchMonthYear(Date.Today)
        Try
            dt = New DataTable
            sql = "SELECT DISTINCT(FLAT_NO) FROM OLD_DUES"
            da = New OleDb.OleDbDataAdapter(sql, conn)
            Try
                da.Fill(dt)
            Finally
                da.Dispose()
            End Try
            Return dt
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Function

    Public Function fetchOwnerNameByFlatNo(ByVal flatno As String) As String

        Dim ownerName As String = ""
        conn = flatsConn.getConnection
        conn.Open()
        dt = New DataTable
        sql = "SELECT OWNER_NAME FROM CONTACTS WHERE FLAT_NO = '" & flatno & "'"
        Try
            da = New OleDb.OleDbDataAdapter(sql, conn)
            da.Fill(dt)
            ownerName = dt.Rows(0)("OWNER_NAME").ToString
        Finally
            da.Dispose()
            dt.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
        Return ownerName
    End Function


    Public Function fetchIncomeSumByMonth() As DataTable

        conn = flatsConn.getConnection
        conn.Open()
        dt = New DataTable
        sql = "SELECT * FROM FLATS_INCOME WHERE FOR_MONTH = '" & getSelectedMonth() & "' ORDER BY FLAT_ID"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        Try
            da.Fill(dt)
        Finally
            da.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
        Return dt
    End Function

    Public Function fetchIncomeSumByQtr() As DataTable

        conn = flatsConn.getConnection
        conn.Open()
        dt = New DataTable
        sql = "SELECT * FROM FLATS_INCOME WHERE FOR_QUARTER = '" & getSelectedQtr() & "' ORDER BY FLAT_ID"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        Try
            da.Fill(dt)
        Finally
            da.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
        Return dt
    End Function

    Public Function fetchIncomeSumByYear() As DataTable

        conn = flatsConn.getConnection
        conn.Open()
        dt = New DataTable
        sql = "SELECT * FROM FLATS_INCOME WHERE FOR_YEAR = '" & getSelectedYear() & "' ORDER BY FLAT_ID"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        Try
            da.Fill(dt)
        Finally
            da.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
        Return dt
    End Function

    Public Function fetchIncomeSumByMonthTotals() As ArrayList

        Dim alist As New ArrayList

        alist.Add(fetchMaintIncomeSum)
        alist.Add(fetchOldDuesIncomeSum)
        alist.Add(fetchAdvancesIncomeSum)
        alist.Add(fetchSpecialIncomeSum)
        alist.Add(fetchDonationsIncomeSum)

        Return alist
    End Function

    Public Function fetchMaintIncomeSum() As String

        Dim maint As String = ""
        conn = flatsConn.getConnection
        conn.Open()
        Try
            ' Get Sum of Amount Collected towards Maintenance Charges
            dt = New DataTable
            If getSelectedPeriod() = "MONTHLY" Then
                sql = "SELECT SUM(AMOUNT) AS MAINT FROM FLATS_INCOME WHERE FOR_MONTH = '" & getSelectedMonth() & "' AND CATEGORY = 'MAINT_CHARGES' GROUP BY CATEGORY"
            ElseIf getSelectedPeriod() = "QUARTERLY" Then
                sql = "SELECT SUM(AMOUNT) AS MAINT FROM FLATS_INCOME WHERE FOR_QUARTER = '" & getSelectedQtr() & "' AND CATEGORY = 'MAINT_CHARGES' GROUP BY CATEGORY"
            ElseIf getSelectedPeriod() = "ANNUAL" Then
                sql = "SELECT SUM(AMOUNT) AS MAINT FROM FLATS_INCOME WHERE FOR_YEAR = '" & getSelectedYear() & "' AND CATEGORY = 'MAINT_CHARGES' GROUP BY CATEGORY"
            End If

            da = New OleDb.OleDbDataAdapter(sql, conn)
            da.Fill(dt)
            If Not dt.Columns.Contains("MAINT") Then
                dt.Columns.Add("MAINT")
            End If
            If dt.Rows.Count = 0 Then
                dt.Rows.Add(0)
            End If
            maint = dt.Rows(0)("MAINT").ToString
            ' Catch ex As Exception
        Finally
            da.Dispose()
            dt.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
        Return maint
    End Function

    Public Function getIncomeSumTotals4Chart()
        ds = New DataSet
        conn = flatsConn.getConnection
        conn.Open()
        ' Get Sum of Amount Collected towards Maintenance Charges
        dt = New DataTable
        If getSelectedPeriod() = "MONTHLY" Then
            sql = "SELECT DISTINCTROW CATEGORY, Sum(AMOUNT) AS [SAMOUNT] FROM FLATS_INCOME WHERE FOR_MONTH = '" & getSelectedMonth() & "' GROUP BY CATEGORY"
        ElseIf getSelectedPeriod() = "QUARTERLY" Then
            sql = "SELECT DISTINCTROW CATEGORY, Sum(AMOUNT) AS [SAMOUNT] FROM FLATS_INCOME WHERE FOR_QUARTER = '" & getSelectedQtr() & "' GROUP BY CATEGORY"
        ElseIf getSelectedPeriod() = "ANNUAL" Then
            sql = "SELECT DISTINCTROW CATEGORY, Sum(AMOUNT) AS [SAMOUNT] FROM FLATS_INCOME WHERE FOR_YEAR = '" & getSelectedYear() & "' GROUP BY CATEGORY"
        End If
        da = New OleDb.OleDbDataAdapter(sql, conn)
        Try
            da.Fill(dt)
            ds.Tables.Add(dt)
        Finally
            da.Dispose()
            dt.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
        Return ds
    End Function

    Public Function getIncomeSumTotals4ChartPercentage()
        conn = flatsConn.getConnection
        conn.Open()
        ' Get Sum of Amount Collected towards Maintenance Charges
        dt = New DataTable
        If getSelectedPeriod() = "MONTHLY" Then
            sql = "SELECT DISTINCTROW CATEGORY, Sum(AMOUNT) AS [SAMOUNT] FROM FLATS_INCOME WHERE FOR_MONTH = '" & getSelectedMonth() & "' GROUP BY CATEGORY"
        ElseIf getSelectedPeriod() = "QUARTERLY" Then
            sql = "SELECT DISTINCTROW CATEGORY, Sum(AMOUNT) AS [SAMOUNT] FROM FLATS_INCOME WHERE FOR_QUARTER = '" & getSelectedQtr() & "' GROUP BY CATEGORY"
        ElseIf getSelectedPeriod() = "ANNUAL" Then
            sql = "SELECT DISTINCTROW CATEGORY, Sum(AMOUNT) AS [SAMOUNT] FROM FLATS_INCOME WHERE FOR_YEAR = '" & getSelectedYear() & "' GROUP BY CATEGORY"
        End If
        da = New OleDb.OleDbDataAdapter(sql, conn)
        Try
            da.Fill(dt)
            dt.Columns.Add("PERCENT")
            Dim total As Integer = 0
            For i As Integer = 0 To dt.Rows.Count - 1
                total = total + Integer.Parse(dt.Rows(i)("SAMOUNT").ToString)
            Next
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("PERCENT") = Integer.Parse(dt.Rows(i)("SAMOUNT").ToString) * 100 / total
            Next
        Finally
            da.Dispose()
            dt.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
        Return dt
    End Function

    Public Function fetchOldDuesIncomeSum() As String

        Dim oldDues As String = ""
        conn = flatsConn.getConnection
        conn.Open()
        Try
            ' Get Sum of Amount Collected towards Old Dues
            dt = New DataTable
            If getSelectedPeriod() = "MONTHLY" Then
                sql = "SELECT SUM(AMOUNT) AS OLD FROM FLATS_INCOME WHERE FOR_MONTH = '" & getSelectedMonth() & "' AND CATEGORY = 'OLD_DUES' GROUP BY CATEGORY"
            ElseIf getSelectedPeriod() = "QUARTERLY" Then
                sql = "SELECT SUM(AMOUNT) AS OLD FROM FLATS_INCOME WHERE FOR_QUARTER = '" & getSelectedQtr() & "' AND CATEGORY = 'OLD_DUES' GROUP BY CATEGORY"
            ElseIf getSelectedPeriod() = "ANNUAL" Then
                sql = "SELECT SUM(AMOUNT) AS OLD FROM FLATS_INCOME WHERE FOR_YEAR = '" & getSelectedYear() & "' AND CATEGORY = 'OLD_DUES' GROUP BY CATEGORY"
            End If

            da = New OleDb.OleDbDataAdapter(sql, conn)
            da.Fill(dt)
            If Not dt.Columns.Contains("OLD") Then
                dt.Columns.Add("OLD")
            End If
            If dt.Rows.Count = 0 Then
                dt.Rows.Add(0)
            End If
            oldDues = dt.Rows(0)("OLD").ToString
        Finally
            da.Dispose()
            dt.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
        Return oldDues
    End Function

    Public Function fetchAdvancesIncomeSum() As String

        Dim advance As String = ""
        conn = flatsConn.getConnection
        conn.Open()
        Try
            ' Get Sum of Amount Collected towards Advances
            dt = New DataTable
            If getSelectedPeriod() = "MONTHLY" Then
                sql = "SELECT SUM(AMOUNT) AS ADVANCE FROM FLATS_INCOME WHERE FOR_MONTH = '" & getSelectedMonth() & "' AND CATEGORY = 'ADVANCES' GROUP BY CATEGORY"
            ElseIf getSelectedPeriod() = "QUARTERLY" Then
                sql = "SELECT SUM(AMOUNT) AS ADVANCE FROM FLATS_INCOME WHERE FOR_QUARTER = '" & getSelectedQtr() & "' AND CATEGORY = 'ADVANCES' GROUP BY CATEGORY"
            ElseIf getSelectedPeriod() = "ANNUAL" Then
                sql = "SELECT SUM(AMOUNT) AS ADVANCE FROM FLATS_INCOME WHERE FOR_YEAR = '" & getSelectedYear() & "' AND CATEGORY = 'ADVANCES' GROUP BY CATEGORY"
            End If
            da = New OleDb.OleDbDataAdapter(sql, conn)
            da.Fill(dt)
            If Not dt.Columns.Contains("ADVANCE") Then
                dt.Columns.Add("ADVANCE")
            End If
            If dt.Rows.Count = 0 Then
                dt.Rows.Add(0)
            End If
            advance = dt.Rows(0)("ADVANCE").ToString
        Finally
            da.Dispose()
            dt.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
        Return advance
    End Function

    Public Function fetchSpecialIncomeSum() As String

        Dim special As String = ""
        conn = flatsConn.getConnection
        conn.Open()
        Try
            ' Get Sum of Amount Collected towards Special
            dt = New DataTable
            If getSelectedPeriod() = "MONTHLY" Then
                sql = "SELECT SUM(AMOUNT) AS SPECIAL FROM FLATS_INCOME WHERE FOR_MONTH = '" & getSelectedMonth() & "' AND CATEGORY = 'SPECIAL_FUNDS' GROUP BY CATEGORY"
            ElseIf getSelectedPeriod() = "QUARTERLY" Then
                sql = "SELECT SUM(AMOUNT) AS SPECIAL FROM FLATS_INCOME WHERE FOR_QUARTER = '" & getSelectedQtr() & "' AND CATEGORY = 'SPECIAL_FUNDS' GROUP BY CATEGORY"
            ElseIf getSelectedPeriod() = "ANNUAL" Then
                sql = "SELECT SUM(AMOUNT) AS SPECIAL FROM FLATS_INCOME WHERE FOR_YEAR = '" & getSelectedYear() & "' AND CATEGORY = 'SPECIAL_FUNDS' GROUP BY CATEGORY"
            End If
            da = New OleDb.OleDbDataAdapter(sql, conn)
            da.Fill(dt)
            If Not dt.Columns.Contains("SPECIAL") Then
                dt.Columns.Add("SPECIAL")
            End If
            If dt.Rows.Count = 0 Then
                dt.Rows.Add(0)
            End If
            special = dt.Rows(0)("SPECIAL").ToString
        Finally
            da.Dispose()
            dt.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
        Return special
    End Function

    Public Function fetchDonationsIncomeSum() As String

        Dim donation As String = ""
        conn = flatsConn.getConnection
        conn.Open()
        Try
            ' Get Sum of Amount Collected towards Donations
            dt = New DataTable
            If getSelectedPeriod() = "MONTHLY" Then
                sql = "SELECT SUM(AMOUNT) AS DONATION FROM FLATS_INCOME WHERE FOR_MONTH = '" & getSelectedMonth() & "' AND CATEGORY = 'DONATIONS' GROUP BY CATEGORY"
            ElseIf getSelectedPeriod() = "QUARTERLY" Then
                sql = "SELECT SUM(AMOUNT) AS DONATION FROM FLATS_INCOME WHERE FOR_QUARTER = '" & getSelectedQtr() & "' AND CATEGORY = 'DONATIONS' GROUP BY CATEGORY"
            ElseIf getSelectedPeriod() = "ANNUAL" Then
                sql = "SELECT SUM(AMOUNT) AS DONATION FROM FLATS_INCOME WHERE FOR_YEAR = '" & getSelectedYear() & "' AND CATEGORY = 'DONATIONS' GROUP BY CATEGORY"
            End If
            da = New OleDb.OleDbDataAdapter(sql, conn)
            da.Fill(dt)
            If Not dt.Columns.Contains("DONATION") Then
                dt.Columns.Add("DONATION")
            End If
            If dt.Rows.Count = 0 Then
                dt.Rows.Add(0)
            End If
            donation = dt.Rows(0)("DONATION").ToString
        Finally
            da.Dispose()
            dt.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
        Return donation
    End Function

    Public Function fetchTotalIncomeSum() As String

        Dim total As String = ""
        conn = flatsConn.getConnection
        conn.Open()
        Try
            ' Get Sum of Amount Collected towards Advances
            dt = New DataTable
            If getSelectedPeriod() = "MONTHLY" Then
                sql = "SELECT SUM(AMOUNT) AS [TOTAL] FROM FLATS_INCOME WHERE FOR_MONTH = '" & getSelectedMonth() & "'  GROUP BY FOR_MONTH"
            ElseIf getSelectedPeriod() = "QUARTERLY" Then
                sql = "SELECT SUM(AMOUNT) AS [TOTAL] FROM FLATS_INCOME WHERE FOR_QUARTER = '" & getSelectedQtr() & "' GROUP BY FOR_QUARTER"
            ElseIf getSelectedPeriod() = "ANNUAL" Then
                sql = "SELECT SUM(AMOUNT) AS [TOTAL] FROM FLATS_INCOME WHERE FOR_YEAR = '" & getSelectedYear() & "' GROUP BY FOR_YEAR"
            End If
            da = New OleDb.OleDbDataAdapter(sql, conn)
            da.Fill(dt)
            If Not dt.Columns.Contains("TOTAL") Then
                dt.Columns.Add("TOTAL")
            End If
            If dt.Rows.Count = 0 Then
                dt.Rows.Add(0)
            End If
            total = dt.Rows(0)("TOTAL").ToString
        Finally
            da.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
        Return total
    End Function

    Public Function fetchData4CashReceipt() As DataSet
        conn = flatsConn.getConnection
        conn.Open()
        ds = New DataSet
        sql = "SELECT * FROM FLATS_INCOME WHERE ID = " & getID()
        da = New OleDb.OleDbDataAdapter(sql, conn)
        Try
            da.Fill(ds)
        Finally
            da.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
        Return ds
    End Function

    Public Function addIncomeData(ByVal dtArray As ArrayList) As Boolean
        Dim saveStatus As Boolean = False
        conn = flatsConn.getConnection
        Dim a1, a2, a3, a4, a5, a6, a7 As String
        a1 = dtArray.Item(0)
        a2 = dtArray.Item(1)
        a3 = dtArray.Item(2)
        a4 = dtArray.Item(3)
        a5 = dtArray.Item(4)
        a6 = dtArray.Item(5)
        a7 = dtArray.Item(6)
        Try
            conn.Open()
            dt = New DataTable()
            sql = "SELECT MAX(RECEIPT_NO) AS MAX_NO FROM FLATS_INCOME"
            da = New OleDb.OleDbDataAdapter(sql, conn)
            Try
                da.Fill(dt)
                Dim receiptNo As String = dt.Rows(0)("MAX_NO").ToString
                Dim maxReceiptNo As Integer = Int32.Parse(receiptNo) + 1
                Try
                    sql1 = "INSERT INTO FLATS_INCOME (FLAT_NO, FOR_MONTH, ON_DATE, AMOUNT, CATEGORY, PAYER_NAME, RECEIPT_NO, RECEIPT_DATED, REMARKS) VALUES ('" & a1 & "', '" & a2 & "', '" & a3 & "', '" & a4 & "', '" & a5 & "', '" & a6 & "', " & maxReceiptNo & ", '" & a3 & "', '" & a7 & "')"
                    Clipboard.SetText(sql1)
                    dc = New OleDbCommand(sql1, conn)
                    count = dc.ExecuteNonQuery()
                    If Not count = 0 Then
                        dt1 = New DataTable
                        sql2 = "SELECT ID FROM FLATS_INCOME WHERE RECEIPT_NO = " & maxReceiptNo
                        da1 = New OleDb.OleDbDataAdapter(sql2, conn)
                        da1.Fill(dt1)
                        Dim rowid As Integer = Integer.Parse(dt1.Rows(0)("ID").ToString)
                        setID(rowid)
                        saveStatus = True
                    Else
                        saveStatus = False
                    End If
                Finally
                    dc.Dispose()
                End Try
            Finally
                da.Dispose()
            End Try
        Catch ex As Exception
            MsgBox(ex.ToString)
            saveStatus = False
        Finally
            conn.Close()
            conn.Dispose()
        End Try
        Return saveStatus
    End Function

    Public Function addExpenseData(ByVal dtArray As ArrayList) As Boolean
        Dim saveStatus As Boolean = False
        conn = flatsConn.getConnection
        Dim a1, a2, a3, a4, a5, a6, a7 As String
        a1 = dtArray.Item(0)
        a2 = dtArray.Item(1)
        a3 = dtArray.Item(2)
        a4 = dtArray.Item(3)
        a5 = dtArray.Item(4)
        a6 = dtArray.Item(5)
        a7 = dtArray.Item(6)
        Try
            conn.Open()
            dt = New DataTable()
            sql = "SELECT MAX(RECEIPT_NO) AS MAX_NO FROM FLATS_INCOME"
            da = New OleDb.OleDbDataAdapter(sql, conn)
            Try
                da.Fill(dt)
                Dim receiptNo As String = dt.Rows(0)("MAX_NO").ToString
                Dim maxReceiptNo As Integer = Int32.Parse(receiptNo) + 1
                Try
                    sql1 = "INSERT INTO FLATS_INCOME (FLAT_NO, FOR_MONTH, ON_DATE, AMOUNT, CATEGORY, PAYER_NAME, RECEIPT_NO, RECEIPT_DATED, REMARKS) VALUES ('" & a1 & "', '" & a2 & "', '" & a3 & "', '" & a4 & "', '" & a5 & "', '" & a6 & "', " & maxReceiptNo & ", '" & a3 & "', '" & a7 & "')"
                    Clipboard.SetText(sql1)
                    dc = New OleDbCommand(sql1, conn)
                    count = dc.ExecuteNonQuery()
                    If Not count = 0 Then
                        dt1 = New DataTable
                        sql2 = "SELECT ID FROM FLATS_INCOME WHERE RECEIPT_NO = " & maxReceiptNo
                        da1 = New OleDb.OleDbDataAdapter(sql2, conn)
                        da1.Fill(dt1)
                        Dim rowid As Integer = Integer.Parse(dt1.Rows(0)("ID").ToString)
                        setID(rowid)
                        saveStatus = True
                    Else
                        saveStatus = False
                    End If
                Finally
                    dc.Dispose()
                End Try
            Finally
                da.Dispose()
            End Try
        Finally
            conn.Close()
            conn.Dispose()
        End Try
        Return saveStatus
    End Function

    Public Function updCuFileData(ByVal dset As DataSet) As Boolean
        Dim saveStatus As Boolean = False
        conn = flatsConn.getConnection
        Dim cl As String = ""
        Try
            sql = "SELECT * FROM CUFILES WHERE FILE_ID = " & cl
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sql, conn)

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

    Private rowID As Integer

    Private Sub setID(ByVal rid As Integer)
        rowID = rid
    End Sub

    Private Function getID()
        Return rowID
    End Function

    Public Sub setSelectedMonth(ByVal mon As String, ByVal yr As String)
        selMonth = mon & " " & yr
    End Sub

    Public Function getSelectedMonth() As String
        Return selMonth
    End Function

    Public Sub setSelectedQtr(ByVal qtr As String, ByVal yr As String)
        selQtr = qtr & " " & yr
    End Sub

    Public Function getSelectedQtr() As String
        Return selQtr
    End Function

    Public Sub setSelectedYear(ByVal yr As String)
        selYear = yr
    End Sub

    Public Function getSelectedYear() As String
        Return selYear
    End Function

    Private Sub setErrorCode(ByVal ex As String)
        err = ex
    End Sub

    Public Function getErrorcode() As String
        Return err
    End Function

    Public Function fetchAmtDue() As String
        Dim dueWaterBill As String
        conn = flatsConn.getConnection
        conn.Open()
        Dim preMonth As String = fetchPreviousMonthYear(Date.Today.ToString)
        dt = New DataTable
        sql = "SELECT AMOUNT_DUE FROM FLATS_EXPENSE WHERE FOR_MONTH = '" & preMonth & "' AND CATEGORY = '" & getPayCategory() & "'"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        Try
            da.Fill(dt)
            dueWaterBill = dt.Rows("AMOUNT_DUE").ToString
        Finally
            da.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
        Return dueWaterBill
    End Function
    Public Function fetchSearchFilesResult() As DataTable
        conn = flatsConn.getConnection
        conn.Open()
        Dim srchCat, srchOpt, srchOpt2, srchIpt As String
        srchOpt2 = ""
        '        srchCat = getFileSearchCategory()
        '       srchOpt = getFileSearchOption()
        If srchOpt = "ref" Then
            srchOpt2 = "REFERENCE"
        ElseIf srchOpt = "subject" Then
            srchOpt2 = "SUBJECT"
        ElseIf srchOpt = "dtOpen" Then
            srchOpt2 = "DATE_OPENED"
        ElseIf srchOpt = "dtClose" Then
            srchOpt2 = "DATE_CLOSED"
        End If
        '      srchIpt = getFileSearchInput()

        Try
            Dim dt As New DataTable
            sql = "SELECT * FROM " & srchCat.ToUpper & " WHERE " & srchOpt2 & " LIKE '%" & srchIpt & "%' ORDER BY FILE_ID"
            da = New OleDbDataAdapter(sql, conn)

            Try
                da.Fill(dt)
            Finally
                da.Dispose()
            End Try
            Return dt
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Function

End Module
