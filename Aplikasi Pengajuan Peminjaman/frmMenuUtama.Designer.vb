<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuUtama
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnLogin = New System.Windows.Forms.ToolStripButton()
        Me.btnRegis = New System.Windows.Forms.ToolStripButton()
        Me.btnPeminjaman = New System.Windows.Forms.ToolStripButton()
        Me.btnAdmin = New System.Windows.Forms.ToolStripButton()
        Me.btnNasabah = New System.Windows.Forms.ToolStripButton()
        Me.btnLogout = New System.Windows.Forms.ToolStripButton()
        Me.btnListPinjaman = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 82)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnLogin, Me.btnRegis, Me.ToolStripSeparator1, Me.btnPeminjaman, Me.btnAdmin, Me.btnNasabah, Me.btnLogout, Me.btnListPinjaman})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(991, 82)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnLogin
        '
        Me.btnLogin.Image = Global.Aplikasi_Pengajuan_Peminjaman.My.Resources.Resources.login3
        Me.btnLogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnLogin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(64, 79)
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnRegis
        '
        Me.btnRegis.Image = Global.Aplikasi_Pengajuan_Peminjaman.My.Resources.Resources.regis2
        Me.btnRegis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnRegis.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRegis.Name = "btnRegis"
        Me.btnRegis.Size = New System.Drawing.Size(90, 79)
        Me.btnRegis.Text = "Registrasi"
        Me.btnRegis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnPeminjaman
        '
        Me.btnPeminjaman.Enabled = False
        Me.btnPeminjaman.Image = Global.Aplikasi_Pengajuan_Peminjaman.My.Resources.Resources.pinjam
        Me.btnPeminjaman.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPeminjaman.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPeminjaman.Name = "btnPeminjaman"
        Me.btnPeminjaman.Size = New System.Drawing.Size(78, 79)
        Me.btnPeminjaman.Text = "Peminjaman"
        Me.btnPeminjaman.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnAdmin
        '
        Me.btnAdmin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAdmin.Image = Global.Aplikasi_Pengajuan_Peminjaman.My.Resources.Resources.admin
        Me.btnAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAdmin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(64, 79)
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnNasabah
        '
        Me.btnNasabah.Enabled = False
        Me.btnNasabah.Image = Global.Aplikasi_Pengajuan_Peminjaman.My.Resources.Resources.nasabah2
        Me.btnNasabah.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNasabah.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNasabah.Name = "btnNasabah"
        Me.btnNasabah.Size = New System.Drawing.Size(67, 79)
        Me.btnNasabah.Text = "Nasabah"
        Me.btnNasabah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnLogout
        '
        Me.btnLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnLogout.Enabled = False
        Me.btnLogout.Image = Global.Aplikasi_Pengajuan_Peminjaman.My.Resources.Resources.log_out1
        Me.btnLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnLogout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(64, 79)
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLogout.ToolTipText = "Logout"
        '
        'btnListPinjaman
        '
        Me.btnListPinjaman.AutoSize = False
        Me.btnListPinjaman.Enabled = False
        Me.btnListPinjaman.Image = Global.Aplikasi_Pengajuan_Peminjaman.My.Resources.Resources.list
        Me.btnListPinjaman.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnListPinjaman.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnListPinjaman.Name = "btnListPinjaman"
        Me.btnListPinjaman.Size = New System.Drawing.Size(90, 79)
        Me.btnListPinjaman.Text = "Data Pinjaman"
        Me.btnListPinjaman.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 524)
        Me.Controls.Add(Me.ToolStrip1)
        Me.IsMdiContainer = True
        Me.Name = "frmMenuUtama"
        Me.Text = "frmMenuUtama"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents btnLogin As ToolStripButton
    Public WithEvents btnRegis As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Public WithEvents btnPeminjaman As ToolStripButton
    Public WithEvents btnAdmin As ToolStripButton
    Public WithEvents btnNasabah As ToolStripButton
    Public WithEvents btnLogout As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnListPinjaman As ToolStripButton
End Class
