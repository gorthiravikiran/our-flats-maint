Imports System.Data.OleDb
Module flatsConn
    Dim conn As OleDbConnection

    Public Function getConnection() As OleDbConnection

        'return a new connection to the office database
        Return New OleDbConnection(My.Settings.flatsDataConn)

    End Function

End Module
