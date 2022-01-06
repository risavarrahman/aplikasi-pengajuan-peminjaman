Public Class frmMenuUtama
    Public Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmLogin.Show()
        frmLogin.MdiParent = Me


    End Sub

    Public Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click
        frmRegistrasi.Show()
        frmRegistrasi.MdiParent = Me


    End Sub

    Public Sub btnPeminjaman_Click(sender As Object, e As EventArgs) Handles btnPeminjaman.Click
        frmTransaksi.Show()
        frmTransaksi.MdiParent = Me

    End Sub

    Public Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        frmAdmin.Show()
        frmAdmin.MdiParent = Me

    End Sub

    Public Sub btnNasabah_Click(sender As Object, e As EventArgs) Handles btnNasabah.Click
        frmNasabah.Show()
        frmNasabah.MdiParent = Me

    End Sub
    Public Sub btnListPinjaman_Click(sender As Object, e As EventArgs) Handles btnListPinjaman.Click
        frmTampil.Show()
        frmTampil.MdiParent = Me

    End Sub

    Public Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Anda Yakin ingin Logout?" & vbCrLf, "Validasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            frmLogin.txtUsername.Text = ""
            frmLogin.txtPassword.Text = ""
            frmLogin.Show()

            btnPeminjaman.Enabled = False
            btnListPinjaman.Enabled = False
            btnLogout.Enabled = False
            btnNasabah.Enabled = False

            btnAdmin.Visible = True
            btnLogin.Enabled = True
            btnRegis.Enabled = True


        End If


    End Sub
End Class