Public Class frmAdmin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Isi dengan Lengkap !")
        Else
            Call koneksi()
            Cmd = New Odbc.OdbcCommand("select * from nasabah where Username = '" & txtUsername.Text & "' AND Password = '" & txtPassword.Text & "'", conn)
            conn.Open()
            Dr = Cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Me.Hide()
                frmMenuUtama.btnNasabah.Enabled = True
                frmMenuUtama.btnPeminjaman.Enabled = False
                frmMenuUtama.btnListPinjaman.Enabled = True
                frmMenuUtama.btnLogout.Enabled = True
                frmMenuUtama.btnAdmin.Visible = False
                frmMenuUtama.btnLogin.Enabled = False
                frmMenuUtama.btnRegis.Enabled = False
            Else
                MsgBox("Username atau Password Salah !")
                txtUsername.Clear()
                txtPassword.Clear()
            End If
        End If

    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "" Then
            txtPassword.UseSystemPasswordChar = True

        End If
    End Sub

End Class