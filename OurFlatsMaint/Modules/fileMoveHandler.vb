Imports System.Data.OleDb

Module fileMoveHandler
    Dim dc As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim conn As OleDbConnection
    Dim dt As DataTable
    Dim sql, ownstatus As String
    Dim count As Integer
    Public Sub setFileOwner(ByVal owner As String)
        ownstatus = owner
    End Sub

    Public Function getFileOwner() As String
        Return ownstatus
    End Function

    Public Function bookFileOut(ByVal dtArray As ArrayList) As Boolean
        Dim saveStatus As Boolean = False
        conn = flatsConn.getConnection
        Dim a1, a2, a3, a4, a5, a6, a7, a8, a9, a10 As String
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

        Try
            If Not a1 = "" Or a2 = "" Or a3 = "" Or a4 = "" Or a5 = "" Or a6 = "" Or a7 = "" Or a8 = "" Or a9 = "" Or a10 = "" Then
                conn.Open()
                sql = "INSERT INTO FILEOUT (FILE_NO, REFERENCE, PART, SCLASS, SUBJECT, FWD_TO, DATE_OUT, PURPOSE, REMARKS_BY, REMARKS) VALUES ('" & a1 & "', '" & a2 & "', '" & a3 & "', '" & a4 & "', '" & a5 & "', '" & a6 & "', '" & a7 & "', '" & a8 & "', '" & a9 & "', '" & a10 & "')"
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
        Return saveStatus
    End Function

    Public Function fetchCuFilesById(ByVal fileid As String) As DataTable
        conn = flatsConn.getConnection
        conn.Open()

        Try
            Dim dt As New DataTable
            sql = "SELECT FILE_ID, FILE_NO, REFERENCE, PART, SCLASS, SUBJECT FROM CUFILES WHERE FILE_ID = " & fileid
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sql, conn)

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
