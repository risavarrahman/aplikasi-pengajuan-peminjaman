Imports System.Data.Odbc
Module modKoneksi
    Public conn As New OdbcConnection
    Public Da As New OdbcDataAdapter
    Public Ds As New DataSet
    Public Dt As New DataTable
    Public Dr As OdbcDataReader
    Public Cmd As OdbcCommand
    Public MyDB As String

    Sub koneksi()
        conn = New OdbcConnection("dsn=pengajuan; server=localhost; uid=root; password=; database=pengajuan_bank; port=3306;")


    End Sub

End Module
