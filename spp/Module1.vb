Imports System.Data.Odbc
Module Module1
    Public kon As OdbcConnection
    Public cmd As OdbcCommand
    Public dr As OdbcDataReader
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public dt As DataTable

    Public Sub KoneksiPetugas()
        Try
            kon = New OdbcConnection("DSN=client")
            If kon.State = ConnectionState.Closed Then
                kon.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi gagal!!!", vbExclamation, "Error Connection")
        End Try
    End Sub


End Module
