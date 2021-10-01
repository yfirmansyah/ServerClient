Public Class Form_menu_utama
    Sub Tampil()
        menu_login.Visible = True
        menu_logout.Visible = False
        menu_petugas.Visible = False
        menu_siswa.Visible = False
    End Sub

    Private Sub Form_menu_utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampil()
    End Sub

    Private Sub Menu_login_Click(sender As Object, e As EventArgs) Handles menu_login.Click
        Form_login.ShowDialog()
        menu_logout.Visible = True
    End Sub

    Private Sub Menu_logout_Click(sender As Object, e As EventArgs) Handles menu_logout.Click
        Call Tampil()
    End Sub

    Private Sub Menu_keluar_Click(sender As Object, e As EventArgs) Handles menu_keluar.Click
        End
    End Sub

    Private Sub Menu_pembayaran_Click(sender As Object, e As EventArgs) Handles menu_pembayaran.Click
        Form_pembayaran.ShowDialog()
    End Sub

    Private Sub Menu_list_byr_Click(sender As Object, e As EventArgs) Handles menu_list_byr.Click
        Form_list_byr.ShowDialog()
    End Sub

    Private Sub Menu_list_byr_siswa_Click(sender As Object, e As EventArgs) Handles menu_list_byr_siswa.Click
        Form_byr_sis.ShowDialog()
    End Sub

End Class
