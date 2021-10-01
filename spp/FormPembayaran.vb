Imports System.Data.Odbc
Public Class Form_pembayaran
    Private Sub tatausaha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KoneksiPetugas()
        Call TampilDataPembayaran()
        Call TampilPetugasCombobox()
        Call TampilSiswaCombobox()
        Call TampilSPP()
    End Sub

    Public Sub TampilDataPembayaran()
        da = New OdbcDataAdapter("SELECT * FROM pembayaran", kon)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        grid1.DataSource = ds.Tables("pembayaran")
    End Sub

    Public Sub TampilPetugasCombobox()
        cmd = New OdbcCommand("select * from petugas", kon)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                cmb_idpetugas.Items.Add(dr("id_petugas"))
            Loop

        End If
    End Sub

    Public Sub TampilSiswaCombobox()
        cmd = New OdbcCommand("select * from siswa", kon)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                cmb_nisn.Items.Add(dr("nisn"))
            Loop

        End If
    End Sub

    Public Sub TampilSPP()
        cmd = New OdbcCommand("select * from spp", kon)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                cmb_idspp.Items.Add(dr("id_spp"))
            Loop

        End If
    End Sub

    Private Sub btn_tambahdata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tambahdata.Click
        cmd = New OdbcCommand("insert into pembayaran values('" & Me.txt_idpembayaran.Text & "','" & Me.cmb_idpetugas.Text & "','" & Me.cmb_nisn.Text & "','" & Me.txt_tanggalbayar.Text & "','" & Me.txt_bulanbayar.Text & "','" & Me.txt_tahunbayar.Text & "','" & Me.cmb_idspp.Text & "','" & Me.txt_jumlahbayar.Text & "')", kon)
        cmd.ExecuteNonQuery()
        MessageBox.Show("sukses")
        Call TampilDataPembayaran()
        Me.txt_idpembayaran.Text = ""
        Me.cmb_idpetugas.Text = ""
        Me.cmb_nisn.Text = ""
        Me.txt_tanggalbayar.Text = ""
        Me.txt_bulanbayar.Text = ""
        Me.txt_tahunbayar.Text = ""
        Me.cmb_idspp.Text = ""
        Me.txt_jumlahbayar.Text = ""
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class