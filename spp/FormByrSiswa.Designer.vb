<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_byr_sis
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.dgv_list_byr = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv_list_byr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_close.Location = New System.Drawing.Point(364, 255)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(148, 50)
        Me.btn_close.TabIndex = 43
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'dgv_list_byr
        '
        Me.dgv_list_byr.AllowUserToOrderColumns = True
        Me.dgv_list_byr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_list_byr.Location = New System.Drawing.Point(23, 75)
        Me.dgv_list_byr.Name = "dgv_list_byr"
        Me.dgv_list_byr.Size = New System.Drawing.Size(836, 150)
        Me.dgv_list_byr.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 31)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "LIST PEMBAYARAN SISWA"
        '
        'Form_byr_sis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 317)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.dgv_list_byr)
        Me.Name = "Form_byr_sis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form List Bayar Siswa"
        CType(Me.dgv_list_byr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_close As Button
    Friend WithEvents dgv_list_byr As DataGridView
    Friend WithEvents Label1 As Label
End Class
