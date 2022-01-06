Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles txtUsername.Enter
        txtUsername.Text = ""
        txtPassword.Text = ""



    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Data belum lengkap, Silakan Isi Kolom Kosong ! ")
        Else
            Call koneksi()
            conn.Open()
            Cmd = New Odbc.OdbcCommand("SELECT * from nasabah WHERE Username = '" & txtUsername.Text & "' AND Password = '" & txtPassword.Text & "'", conn)
            Dr = Cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Me.Hide()
                frmTransaksi.txtNoRek.Text = Dr.Item("Nomor_Rekening")
                frmMenuUtama.btnPeminjaman.Enabled = True
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "" Then
            txtPassword.UseSystemPasswordChar = True

        End If
    End Sub


End Class
