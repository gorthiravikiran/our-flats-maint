Imports System.Data.OleDb
Module maildataHandler
    Dim ds, dtSet As DataSet
    Dim dc As OleDbCommand
    Dim cb As OleDbCommandBuilder
    Dim da As OleDbDataAdapter
    Dim conn As OleDbConnection
    Dim dt, dtable As DataTable
    Dim sql, err, mailCategory, mailid, searchMailCategory, searchMailOption, searchMailInput, remarkID, sendMe As String
    Dim viewMailOption, date1, date2, mailCount As String
    Dim count As Integer
    Dim dates As ArrayList
    Dim result As Boolean

    Public Sub setUpdMailRedirect(ByVal strMe As String)
        sendMe = strMe
    End Sub

    Public Function getUpdMailRedirect() As String
        Return sendMe
    End Function

    Public Sub setMailCat(ByVal mailCat As String)
        mailCategory = mailCat
    End Sub

    Public Function getMailCat() As String
        Return mailCategory
    End Function

    Public Sub setMailId(ByVal mailidStr As String)
        mailid = mailidStr
    End Sub

    Public Function getMailId() As String
        Return mailid
    End Function

    Public Function fetchNewMailNo(ByVal dateStr As String) As Integer
        Dim newNo As Integer
        Dim tem As String = ""
        conn = flatsConn.getConnection()
        If maildataHandler.getMailCat() = "MAILIN" Then
            sql = "SELECT MAX(MAIL_NO) AS NEWMAILNO FROM MAILIN WHERE DATE_RECD = '" & dateStr & "'"
        ElseIf maildataHandler.getMailCat() = "MAILOUT" Then
            sql = "SELECT MAX(MAIL_NO) AS NEWMAILNO FROM MAILOUT WHERE DATE_SENT = '" & dateStr & "'"
        End If
        Clipboard.SetText(sql)
        conn.Open()
        Try
            da = New OleDbDataAdapter(sql, conn)
            dt = New DataTable()
            da.Fill(dt)
            tem = dt.Rows(0)("NEWMAILNO").ToString
            If (tem = Nothing) Then
                tem = 0
            End If
            newNo = Integer.Parse(tem) + 1
        Catch ex As Exception
            MsgBox("Error Occurred")
        Finally
            da.Dispose()
            conn.Close()
            conn.Dispose()
        End Try
        Return newNo
    End Function

    Private Sub setFetchMailResult(ByVal result1 As Boolean)
        result = result1
    End Sub

    Public Function getFetchMailResult() As Boolean
        Return result
    End Function

    Public Function fetchMails() As DataTable
        conn = flatsConn.getConnection
        conn.Open()
        dt = New DataTable
        If getViewMailOption() = "allMails" Then
            dt = fetchAllMails()
        ElseIf getViewMailOption() = "todaysMail" Then
            dt = fetchMailsByDate(dateFormat.customizeDate(Date.Today))
        ElseIf getViewMailOption() = "byDate" Then
            dt = fetchMailsByDate(dateFormat.customizeDate(getDate()))
        ElseIf getViewMailOption() = "betDates" Then
            dt = fetchMailsBetweenDates(getDates())
        End If
        Return dt
    End Function

    Private Function fetchAllMails() As DataTable
        conn = flatsConn.getConnection
        conn.Open()

        Try
            dt = New DataTable
            sql = "SELECT * FROM " & getMailCat() & " ORDER BY MAIL_ID"
            da = New OleDb.OleDbDataAdapter(sql, conn)

            Try
                da.Fill(dt)
                setFetchMailResult(True)
            Finally
                da.Dispose()
            End Try
        Catch ex As Exception
            setFetchMailResult(False)
        Finally
            conn.Close()
            conn.Dispose()
        End Try
        Return dt
    End Function

    Private Function fetchMailsByDate(ByVal datestr As String) As DataTable
        conn = flatsConn.getConnection
        conn.Open()

        Try
            dt = New DataTable
            sql = "SELECT * FROM " & getMailCat() & " WHERE DATED = '" & datestr & "' ORDER BY MAIL_ID"
            da = New OleDb.OleDbDataAdapter(sql, conn)

            Try
                da.Fill(dt)
                setFetchMailResult(True)
            Finally
                da.Dispose()
            End Try
        Catch ex As Exception
            setFetchMailResult(False)
        Finally
            conn.Close()
            conn.Dispose()
        End Try
        Return dt
    End Function

    Private Function fetchMailsBetweenDates(ByVal dates As ArrayList) As DataTable
        conn = flatsConn.getConnection
        conn.Open()

        Try
            dt = New DataTable
            sql = "SELECT * FROM " & getMailCat() & " WHERE DATED BETWEEN #" & dates.Item(0) & "# AND #" & dates.Item(1) & "# ORDER BY MAIL_ID"
            Clipboard.SetText(sql)
            da = New OleDb.OleDbDataAdapter(sql, conn)
            Try
                da.Fill(dt)
                setFetchMailResult(True)
            Finally
                da.Dispose()
            End Try
        Catch ex As Exception
            setFetchMailResult(False)
        Finally
            conn.Close()
            conn.Dispose()
        End Try
        Return dt
    End Function

    Public Function fetchMailsById(ByVal mailid1 As String) As DataSet
        conn = flatsConn.getConnection
        conn.Open()
        Try
            ds = New DataSet()
            sql = "SELECT * FROM " & getMailCat() & " WHERE MAIL_ID = " & mailid1
            da = New OleDb.OleDbDataAdapter(sql, conn)

            Try
                da.Fill(ds)
            Finally
                da.Dispose()
            End Try
            Return ds
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Function

    Public Function fetchFilingDetails() As DataSet
        conn = flatsConn.getConnection
        conn.Open()

        Try
            ds = New DataSet()
            sql = "SELECT * FROM FILING WHERE MAIL_CAT = '" & getMailCat() & "' AND MAIL_ID = " & getMailId()
            da = New OleDb.OleDbDataAdapter(sql, conn)

            Try
                da.Fill(ds)
                setFetchMailResult(True)
            Finally
                da.Dispose()
            End Try
        Catch ex As Exception
            setFetchMailResult(False)
        Finally
            conn.Close()
            conn.Dispose()
        End Try
        Return ds
    End Function

    Public Function fetchMailRemarksByIdCat() As DataTable
        conn = flatsConn.getConnection
        conn.Open()

        Try
            dt = New DataTable()
            Dim sql As String = "SELECT REMARKS_BY, REMARKS, RMK_ID FROM MAIL_RMKS WHERE MAIL_ID = '" & getMailId() & "' AND MAIL_CAT = '" & getMailCat() & "'"
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

    Public Function addNewMail(ByVal dtArray As ArrayList) As Boolean
        Dim saveStatus As Boolean = False
        conn = flatsConn.getConnection
        Dim a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14 As String

        a1 = dtArray.Item(0)
        a2 = dtArray.Item(1)
        a3 = dtArray.Item(2)
        a4 = dtArray.Item(3)
        a5 = dtArray.Item(4)
        a6 = dtArray.Item(5)
        a7 = dtArray.Item(6)
        a8 = dtArray.Item(7)
        a9 = dtArray.Item(8)
        a10 = dtArray.Item(9)
        a11 = dtArray.Item(10)
        a12 = dtArray.Item(11)
        a13 = dtArray.Item(12)
        a14 = dtArray.Item(13)

        Dim mailid1, sql1 As String
        sql = ""
        If getMailCat() = "MAILIN" Then
            sql = "INSERT INTO MAILIN (MAIL_NO, REFERENCE, PAGES, DATED, SUBJECT, SCLASS, COPY_TO, RECD_FROM, DATE_RECD) VALUES (" & a1 & ", '" & a2 & "', " & a3 & ", '" & a4 & "', '" & a5 & "', '" & a6 & "', '" & a7 & "', '" & a8 & "', '" & a9 & "')"
        ElseIf getMailCat() = "MAILOUT" Then
            sql = "INSERT INTO MAILOUT (MAIL_NO, REFERENCE, PAGES, DATED, SUBJECT, SCLASS, COPY_TO, SENT_TO, DATE_SENT) VALUES (" & a1 & ", '" & a2 & "', " & a3 & ", '" & a4 & "', '" & a5 & "', '" & a6 & "', '" & a7 & "', '" & a8 & "', '" & a9 & "')"
        End If

        Try

            conn.Open()
            dc = New OleDbCommand(sql, conn)
            count = dc.ExecuteNonQuery()
            conn.Close()
            dc.Dispose()

            If Not count = 0 Then
                saveStatus = True
            End If
            Try
                dt = New DataTable()
                sql1 = "SELECT MAIL_ID FROM " & getMailCat() & " WHERE MAIL_NO = " & a1 & " AND REFERENCE = '" & a2 & "' AND DATED = '" & a4 & "' AND SUBJECT = '" & a5 & "' AND DATE_RECD = '" & a9 & "'"

                conn.Close()
                da = New OleDbDataAdapter(sql1, conn)
                da.Fill(dt)
                da.Dispose()
                conn.Close()

                mailid1 = dt.Rows(0)("MAIL_ID").ToString
                setMailId(mailid1)
                If a10 = "--Select a File Name--" And a12 = "0" Then
                    addFilingDetails(mailid1, a10, "", a12)
                    MsgBox("Filing not Done")
                Else
                    addFilingDetails(mailid1, a10, a11, a12)
                End If
                If a13 = "NONE" And a14 = "NIL" Then
                    addMailRemarks(mailid1, "--Select--", a14)
                    MsgBox("Remarks not Added")
                Else
                    addMailRemarks(mailid1, a13, a14)
                End If
                saveStatus = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            MsgBox("Status2 = " & saveStatus)
        Catch ex As Exception
            MsgBox(ex.ToString)
            saveStatus = False
        End Try
        MsgBox("FinalStatus = " & saveStatus)

        Return saveStatus
    End Function

    Public Function addMailRemarks(ByVal mail_id As String, ByVal remksby As String, ByVal remks As String) As Boolean
        Dim saveStatus As Boolean
        conn = flatsConn.getConnection()
        Try
            sql = "INSERT INTO MAIL_RMKS (MAIL_ID, REMARKS_BY, REMARKS, MAIL_CAT) VALUES ('" & mail_id & "', '" & remksby & "', '" & remks & "', '" & getMailCat() & "')"
            dc = New OleDbCommand(sql, conn)
            conn.Open()
            count = dc.ExecuteNonQuery()
            conn.Close()
            dc.Dispose()
            If Not count = 0 Then
                saveStatus = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            saveStatus = False
        Finally
            conn.Dispose()
        End Try
        Return saveStatus
    End Function

    Public Function addFilingDetails(ByVal mailId1 As String, ByVal fName As String, ByVal fPart As String, ByVal encl As String) As Boolean
        Dim saveStatus As Boolean
        conn = flatsConn.getConnection()
        Try
            sql = "INSERT INTO FILING (MAIL_ID, MAIL_CAT, FILE_NAME, FILE_PART, ENCL_NO) VALUES ('" & mailId1 & "', '" & getMailCat() & "', '" & fName & "', '" & fPart & "', '" & encl & "')"
            dc = New OleDbCommand(sql, conn)
            conn.Open()
            count = dc.ExecuteNonQuery()
            conn.Close()
            dc.Dispose()
            If Not count = 0 Then
                saveStatus = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            saveStatus = False
        Finally
            conn.Dispose()
        End Try
        Return saveStatus
    End Function

    Public Function delMailRemarks(ByVal rmkId As String) As Boolean
        Dim saveStatus As Boolean
        conn = flatsConn.getConnection()
        Try
            sql = "DELETE FROM MAIL_RMKS WHERE RMK_ID = " & rmkId
            Dim dc As OleDbCommand
            conn.Open()
            dc = New OleDbCommand(sql, conn)
            count = dc.ExecuteNonQuery()
            conn.Close()
            dc.Dispose()
            If Not count = 0 Then
                saveStatus = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            saveStatus = False
        Finally
            conn.Dispose()
        End Try
        Return saveStatus
    End Function

    Public Function updMailData(ByVal dset As DataSet) As Boolean
        Dim saveStatus As Boolean = False
        conn = flatsConn.getConnection

        Try
            sql = "SELECT * FROM " & getMailCat() & " WHERE MAIL_ID = " & getMailId()
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
    Public Function updFilingDetails(ByVal dset As DataSet) As Boolean
        Dim saveStatus As Boolean = False
        conn = flatsConn.getConnection
        Try
            sql = "SELECT * FROM FILING WHERE MAIL_ID = " & getMailId() & " AND MAIL_CAT = '" & getMailCat() & "'"
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sql, conn)
            Dim cb As OleDbCommandBuilder = New OleDbCommandBuilder(da)
            If dset.HasChanges Then
                da.Update(dset)
                dset.AcceptChanges()
                saveStatus = True
            End If
        Catch ex As Exception
            saveStatus = False
        Finally
            conn.Close()
            conn.Dispose()
        End Try
        Return saveStatus
    End Function

    Private Sub setErrorCode(ByVal ex As String)
        err = ex
    End Sub

    Public Function getErrorcode() As String
        Return err
    End Function

    Public Sub setMailSearchOption(ByVal srchmailOpt As String)
        searchMailOption = srchmailOpt
    End Sub

    Public Function getMailSearchOption() As String
        Return searchMailOption
    End Function

    Public Sub setMailSearchInput(ByVal srchmailInpt As String)
        searchMailInput = srchmailInpt
    End Sub

    Public Function getMailSearchInput() As String
        Return searchMailInput
    End Function

    Public Function fetchSearchMailsResult() As DataTable
        conn = flatsConn.getConnection
        conn.Open()
        Dim srchCat, srchOpt, srchOpt2, srchIpt As String
        srchCat = getMailCat()
        srchOpt = getMailSearchOption()
        srchOpt2 = ""
        If srchOpt = "ref" Then
            srchOpt2 = "REFERENCE"
        ElseIf srchOpt = "subject" Then
            srchOpt2 = "SUBJECT"
        ElseIf srchOpt = "dated" Then
            srchOpt2 = "DATED"
        ElseIf srchOpt = "dateRecd" Then
            srchOpt2 = "DATE_RECD"
        ElseIf srchOpt = "dateSent" Then
            srchOpt2 = "DATE_SENT"
        ElseIf srchOpt = "recdFrom" Then
            srchOpt2 = "RECD_FROM"
        ElseIf srchOpt = "sentTo" Then
            srchOpt2 = "SENT_TO"
        End If
        srchIpt = getMailSearchInput()
        Dim clause As String = ""
        Try
            dt = New DataTable()
            sql = "SELECT * FROM " & srchCat.ToUpper & " WHERE " & srchOpt2 & " LIKE '%" & srchIpt & "%' ORDER BY MAIL_ID"
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

    Public Sub setRmkId(ByVal rmkId As String)
        remarkID = rmkId
    End Sub

    Private Function getRmkId() As String
        Return remarkID
    End Function

    Public Function fetchMailIdbyMailCat() As DataTable
        conn = flatsConn.getConnection
        conn.Open()

        Try
            Dim dt As New DataTable
            Dim sql As String = "SELECT MAIL_ID FROM " & getMailCat()
            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, conn)
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

    Public Sub setViewMailOption(ByVal viewMailOpt As String)
        viewMailOption = viewMailOpt
    End Sub

    Public Function getViewMailOption() As String
        Return viewMailOption
    End Function

    Public Sub setDate(ByVal datestr As String)
        date1 = datestr
    End Sub

    Public Function getDate() As String
        Return date1
    End Function

    Public Sub setDates(ByVal date1 As String, ByVal date2 As String)
        dates = New ArrayList
        dates.Add(date1)
        dates.Add(date2)
    End Sub

    Public Function getDates() As ArrayList
        Return dates
    End Function
    Public Sub setDataTable(ByVal datatable1 As DataTable)
        dt = datatable1
    End Sub

    Public Function getDataTable() As DataTable
        Return dt
    End Function
End Module