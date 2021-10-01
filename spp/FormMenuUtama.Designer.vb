<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_menu_utama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_login = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_keluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_petugas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_pembayaran = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_list_byr = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_siswa = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_list_byr_siswa = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.menu_petugas, Me.menu_siswa})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(592, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_login, Me.menu_logout, Me.menu_keluar})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'menu_login
        '
        Me.menu_login.Name = "menu_login"
        Me.menu_login.Size = New System.Drawing.Size(180, 22)
        Me.menu_login.Text = "Login"
        '
        'menu_logout
        '
        Me.menu_logout.Name = "menu_logout"
        Me.menu_logout.Size = New System.Drawing.Size(180, 22)
        Me.menu_logout.Text = "Logout"
        '
        'menu_keluar
        '
        Me.menu_keluar.Name = "menu_keluar"
        Me.menu_keluar.Size = New System.Drawing.Size(180, 22)
        Me.menu_keluar.Text = "Keluar App"
        '
        'menu_petugas
        '
        Me.menu_petugas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_pembayaran, Me.menu_list_byr})
        Me.menu_petugas.Name = "menu_petugas"
        Me.menu_petugas.Size = New System.Drawing.Size(61, 20)
        Me.menu_petugas.Text = "Petugas"
        '
        'menu_pembayaran
        '
        Me.menu_pembayaran.Name = "menu_pembayaran"
        Me.menu_pembayaran.Size = New System.Drawing.Size(180, 22)
        Me.menu_pembayaran.Text = "Pembayaran"
        '
        'menu_list_byr
        '
        Me.menu_list_byr.Name = "menu_list_byr"
        Me.menu_list_byr.Size = New System.Drawing.Size(180, 22)
        Me.menu_list_byr.Text = "List Bayar"
        '
        'menu_siswa
        '
        Me.menu_siswa.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_list_byr_siswa})
        Me.menu_siswa.Name = "menu_siswa"
        Me.menu_siswa.Size = New System.Drawing.Size(48, 20)
        Me.menu_siswa.Text = "Siswa"
        '
        'menu_list_byr_siswa
        '
        Me.menu_list_byr_siswa.Name = "menu_list_byr_siswa"
        Me.menu_list_byr_siswa.Size = New System.Drawing.Size(180, 22)
        Me.menu_list_byr_siswa.Text = "List Bayar Siswa"
        '
        'Form_menu_utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 284)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_menu_utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Menu Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menu_login As ToolStripMenuItem
    Friend WithEvents menu_logout As ToolStripMenuItem
    Friend WithEvents menu_keluar As ToolStripMenuItem
    Friend WithEvents menu_petugas As ToolStripMenuItem
    Friend WithEvents menu_pembayaran As ToolStripMenuItem
    Friend WithEvents menu_list_byr As ToolStripMenuItem
    Friend WithEvents menu_siswa As ToolStripMenuItem
    Friend WithEvents menu_list_byr_siswa As ToolStripMenuItem
End Class
