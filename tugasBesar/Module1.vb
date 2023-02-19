Imports System.Data.Odbc
Module Module1
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public conn As OdbcConnection
    Public cmd As OdbcCommand
    Public rd As OdbcDataReader

    Sub koneksi()
        conn = New OdbcConnection("dsn=rental_mobil")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
