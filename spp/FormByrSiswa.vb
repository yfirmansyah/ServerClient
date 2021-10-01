Imports System.Data.Odbc
Public Class Form_byr_sis

    Sub TampilByr()
        da = New OdbcDataAdapter("SELECT * FROM pembayaran", kon)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        dgv_list_byr.DataSource = ds.Tables("pembayaran")
    End Sub
    Private Sub Form_list_byr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiPetugas()
        Call TampilByr()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

End Class