<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrasi
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
        Me.btnDaftar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNoHP = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtNoRek = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDaftar
        '
        Me.btnDaftar.Location = New System.Drawing.Point(271, 202)
        Me.btnDaftar.Name = "btnDaftar"
        Me.btnDaftar.Size = New System.Drawing.Size(75, 23)
        Me.btnDaftar.TabIndex = 0
        Me.btnDaftar.Text = "Daftar"
        Me.btnDaftar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Lengkap"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nomor Rekening"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "No HP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Password"
        '
        'txtNama
        '
        Me.txtNama.AcceptsTab = True
        Me.txtNama.Location = New System.Drawing.Point(161, 42)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(185, 20)
        Me.txtNama.TabIndex = 7
        '
        'txtNoHP
        '
        Me.txtNoHP.AcceptsTab = True
        Me.txtNoHP.Location = New System.Drawing.Point(161, 147)
        Me.txtNoHP.Name = "txtNoHP"
        Me.txtNoHP.Size = New System.Drawing.Size(185, 20)
        Me.txtNoHP.TabIndex = 8
        '
        'txtAlamat
        '
        Me.txtAlamat.AcceptsTab = True
        Me.txtAlamat.Location = New System.Drawing.Point(161, 121)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(185, 20)
        Me.txtAlamat.TabIndex = 9
        '
        'txtUsername
        '
        Me.txtUsername.AcceptsTab = True
        Me.txtUsername.Location = New System.Drawing.Point(161, 95)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(185, 20)
        Me.txtUsername.TabIndex = 10
        '
        'txtNoRek
        '
        Me.txtNoRek.AcceptsTab = True
        Me.txtNoRek.Enabled = False
        Me.txtNoRek.Location = New System.Drawing.Point(161, 16)
        Me.txtNoRek.Name = "txtNoRek"
        Me.txtNoRek.ReadOnly = True
        Me.txtNoRek.Size = New System.Drawing.Size(185, 20)
        Me.txtNoRek.TabIndex = 11
        '
        'txtPassword
        '
        Me.txtPassword.AcceptsTab = True
        Me.txtPassword.Location = New System.Drawing.Point(161, 173)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(185, 20)
        Me.txtPassword.TabIndex = 12
        '
        'cbGender
        '
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cbGender.Location = New System.Drawing.Point(161, 68)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(185, 21)
        Me.cbGender.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Jenis Kelamin"
        '
        'frmRegistrasi
        '
        Me.AcceptButton = Me.btnDaftar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 236)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbGender)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtNoRek)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNoHP)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDaftar)
        Me.Name = "frmRegistrasi"
        Me.Text = "frmRegistrasi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDaftar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNoHP As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtNoRek As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents Label7 As Label
End Class
