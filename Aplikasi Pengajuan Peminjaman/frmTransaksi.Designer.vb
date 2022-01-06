<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransaksi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNoRek = New System.Windows.Forms.TextBox()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbJumlahPinjaman = New System.Windows.Forms.ComboBox()
        Me.cbLamaAngsuran = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCek = New System.Windows.Forms.Button()
        Me.lblAngsur = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Transaksi"
        '
        'txtKode
        '
        Me.txtKode.Enabled = False
        Me.txtKode.Location = New System.Drawing.Point(135, 15)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.ReadOnly = True
        Me.txtKode.Size = New System.Drawing.Size(200, 20)
        Me.txtKode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tanggal Pinjam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nomor Rekening"
        '
        'txtNoRek
        '
        Me.txtNoRek.Enabled = False
        Me.txtNoRek.Location = New System.Drawing.Point(135, 67)
        Me.txtNoRek.Name = "txtNoRek"
        Me.txtNoRek.ReadOnly = True
        Me.txtNoRek.Size = New System.Drawing.Size(200, 20)
        Me.txtNoRek.TabIndex = 8
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Location = New System.Drawing.Point(135, 41)
        Me.dtpTanggal.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtpTanggal.MinDate = New Date(1900, 12, 31, 0, 0, 0, 0)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(200, 20)
        Me.dtpTanggal.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Jumlah Pinjaman (Rp. )"
        '
        'cbJumlahPinjaman
        '
        Me.cbJumlahPinjaman.AllowDrop = True
        Me.cbJumlahPinjaman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJumlahPinjaman.FormattingEnabled = True
        Me.cbJumlahPinjaman.Items.AddRange(New Object() {"1,000,000", "2,500,000", "5,000,000", "10,000,000", "20,000,000"})
        Me.cbJumlahPinjaman.Location = New System.Drawing.Point(135, 93)
        Me.cbJumlahPinjaman.Name = "cbJumlahPinjaman"
        Me.cbJumlahPinjaman.Size = New System.Drawing.Size(200, 21)
        Me.cbJumlahPinjaman.TabIndex = 13
        '
        'cbLamaAngsuran
        '
        Me.cbLamaAngsuran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLamaAngsuran.FormattingEnabled = True
        Me.cbLamaAngsuran.Items.AddRange(New Object() {"6", "12", "18", "24"})
        Me.cbLamaAngsuran.Location = New System.Drawing.Point(135, 120)
        Me.cbLamaAngsuran.Name = "cbLamaAngsuran"
        Me.cbLamaAngsuran.Size = New System.Drawing.Size(201, 21)
        Me.cbLamaAngsuran.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Lama Angsuran (Bulan)"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.Location = New System.Drawing.Point(19, 151)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 3)
        Me.Panel1.TabIndex = 16
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(261, 199)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 17
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Angsuran per Bulan"
        '
        'btnCek
        '
        Me.btnCek.Location = New System.Drawing.Point(180, 199)
        Me.btnCek.Name = "btnCek"
        Me.btnCek.Size = New System.Drawing.Size(75, 23)
        Me.btnCek.TabIndex = 20
        Me.btnCek.Text = "Cek"
        Me.btnCek.UseVisualStyleBackColor = True
        '
        'lblAngsur
        '
        Me.lblAngsur.AutoSize = True
        Me.lblAngsur.Location = New System.Drawing.Point(132, 168)
        Me.lblAngsur.Name = "lblAngsur"
        Me.lblAngsur.Size = New System.Drawing.Size(7, 13)
        Me.lblAngsur.TabIndex = 21
        Me.lblAngsur.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmTransaksi
        '
        Me.AcceptButton = Me.btnCek
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 234)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.lblAngsur)
        Me.Controls.Add(Me.btnCek)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbLamaAngsuran)
        Me.Controls.Add(Me.cbJumlahPinjaman)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.txtNoRek)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTransaksi"
        Me.Text = "frmTransaksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents cbJumlahPinjaman As ComboBox
    Friend WithEvents cbLamaAngsuran As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCek As Button
    Friend WithEvents lblAngsur As Label
    Friend WithEvents txtNoRek As TextBox
End Class
