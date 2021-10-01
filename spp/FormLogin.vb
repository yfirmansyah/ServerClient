Imports System.Data.Odbc
Public Class Form_login
    Sub Tampil()
        Form_menu_utama.menu_petugas.Visible = True
        Form_menu_utama.menu_siswa.Visible = False
    End Sub
    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        da = New OdbcDataAdapter
        cmd = New OdbcCommand("select * from petugas where username='" & txt_username.Text & "' and password='" & txt_password.Text & "'", kon)
        da.SelectCommand = cmd
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Call Tampil()

        ElseIf txt_username.Text = "bb" And txt_password.Text = "cc" Then
            Form_menu_utama.menu_petugas.Visible = False
            Form_menu_utama.menu_siswa.Visible = True

        Else
            MsgBox("Login Berhasil", MsgBoxStyle.Information, "Success")
        End If
        Me.Hide()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If txt_password.UseSystemPasswordChar = True Then
            'hide password
            txt_password.UseSystemPasswordChar = False

        Else
            'show password
            txt_password.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiPetugas()
    End Sub
End Class