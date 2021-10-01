<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_pembayaran
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
        Me.grid1 = New System.Windows.Forms.DataGridView()
        Me.btn_tambahdata = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_jumlahbayar = New System.Windows.Forms.TextBox()
        Me.cmb_idspp = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_tahunbayar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_bulanbayar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_tanggalbayar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_nisn = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_idpetugas = New System.Windows.Forms.ComboBox()
        Me.txt_idpembayaran = New System.Windows.Forms.TextBox()
        Me.btn_close = New System.Windows.Forms.Button()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid1
        '
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Location = New System.Drawing.Point(12, 147)
        Me.grid1.Name = "grid1"
        Me.grid1.Size = New System.Drawing.Size(513, 157)
        Me.grid1.TabIndex = 39
        '
        'btn_tambahdata
        '
        Me.btn_tambahdata.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_tambahdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tambahdata.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_tambahdata.Location = New System.Drawing.Point(12, 310)
        Me.btn_tambahdata.Name = "btn_tambahdata"
        Me.btn_tambahdata.Size = New System.Drawing.Size(148, 50)
        Me.btn_tambahdata.TabIndex = 38
        Me.btn_tambahdata.Text = "Tambah Data"
        Me.btn_tambahdata.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(306, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Jumlah Bayar"
        '
        'txt_jumlahbayar
        '
        Me.txt_jumlahbayar.Location = New System.Drawing.Point(420, 114)
        Me.txt_jumlahbayar.Name = "txt_jumlahbayar"
        Me.txt_jumlahbayar.Size = New System.Drawing.Size(105, 20)
        Me.txt_jumlahbayar.TabIndex = 36
        '
        'cmb_idspp
        '
        Me.cmb_idspp.FormattingEnabled = True
        Me.cmb_idspp.Location = New System.Drawing.Point(420, 83)
        Me.cmb_idspp.Name = "cmb_idspp"
        Me.cmb_idspp.Size = New System.Drawing.Size(105, 21)
        Me.cmb_idspp.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(306, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "ID SPP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Tahun Bayar"
        '
        'txt_tahunbayar
        '
        Me.txt_tahunbayar.Location = New System.Drawing.Point(123, 115)
        Me.txt_tahunbayar.Name = "txt_tahunbayar"
        Me.txt_tahunbayar.Size = New System.Drawing.Size(105, 20)
        Me.txt_tahunbayar.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Bulan Bayar"
        '
        'txt_bulanbayar
        '
        Me.txt_bulanbayar.Location = New System.Drawing.Point(123, 83)
        Me.txt_bulanbayar.Name = "txt_bulanbayar"
        Me.txt_bulanbayar.Size = New System.Drawing.Size(105, 20)
        Me.txt_bulanbayar.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Tanggal Bayar"
        '
        'txt_tanggalbayar
        '
        Me.txt_tanggalbayar.Location = New System.Drawing.Point(123, 51)
        Me.txt_tanggalbayar.Name = "txt_tanggalbayar"
        Me.txt_tanggalbayar.Size = New System.Drawing.Size(105, 20)
        Me.txt_tanggalbayar.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(306, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "NISN"
        '
        'cmb_nisn
        '
        Me.cmb_nisn.FormattingEnabled = True
        Me.cmb_nisn.Location = New System.Drawing.Point(420, 50)
        Me.cmb_nisn.Name = "cmb_nisn"
        Me.cmb_nisn.Size = New System.Drawing.Size(105, 21)
        Me.cmb_nisn.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "ID Petugas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "ID Pembayaran"
        '
        'cmb_idpetugas
        '
        Me.cmb_idpetugas.FormattingEnabled = True
        Me.cmb_idpetugas.Location = New System.Drawing.Point(420, 18)
        Me.cmb_idpetugas.Name = "cmb_idpetugas"
        Me.cmb_idpetugas.Size = New System.Drawing.Size(105, 21)
        Me.cmb_idpetugas.TabIndex = 23
        '
        'txt_idpembayaran
        '
        Me.txt_idpembayaran.Location = New System.Drawing.Point(123, 18)
        Me.txt_idpembayaran.Name = "txt_idpembayaran"
        Me.txt_idpembayaran.Size = New System.Drawing.Size(105, 20)
        Me.txt_idpembayaran.TabIndex = 22
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_close.Location = New System.Drawing.Point(385, 310)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(148, 50)
        Me.btn_close.TabIndex = 40
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'Form_pembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 372)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.btn_tambahdata)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_jumlahbayar)
        Me.Controls.Add(Me.cmb_idspp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_tahunbayar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_bulanbayar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_tanggalbayar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_nisn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_idpetugas)
        Me.Controls.Add(Me.txt_idpembayaran)
        Me.Name = "Form_pembayaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Pembayaran"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid1 As DataGridView
    Friend WithEvents btn_tambahdata As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_jumlahbayar As TextBox
    Friend WithEvents cmb_idspp As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_tahunbayar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_bulanbayar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_tanggalbayar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_nisn As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_idpetugas As ComboBox
    Friend WithEvents txt_idpembayaran As TextBox
    Friend WithEvents btn_close As Button
End Class
