Public Class frmRegistrasi
    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        Call koneksi()
        conn.Open()
        MyDB = "INSERT INTO nasabah VALUES ('" & txtNoRek.Text & "','" & txtNama.Text & "','" &
            cbGender.Text & "','" &
            txtUsername.Text & "','" &
            txtAlamat.Text & "','" &
            txtNoHP.Text & "','" &
            txtPassword.Text & "')"
        Cmd = New Odbc.OdbcCommand(MyDB, conn)
        Cmd.ExecuteNonQuery()

        txtNama.Clear()
        cbGender.ResetText()
        txtNoRek.Clear()
        txtUsername.Clear()
        txtAlamat.Clear()
        txtNoHP.Clear()
        txtPassword.Clear()

        Me.Close()

        MsgBox("Registrasi Berhasil, Silakan Login")
    End Sub
    Sub AutonumberNoRek()
        Call koneksi()
        conn.Open()
        MyDB = "SELECT max(Nomor_Rekening) FROM nasabah"
        Cmd = New Odbc.OdbcCommand(MyDB, conn)
        Dr = Cmd.ExecuteReader()
        Dr.Read()
        On Error GoTo Err
        If Dr.HasRows Then
            txtNoRek.Text = Format(Val(Dr.Item(0)) + 1, "0000000")
        End If
        Exit Sub
Err:
        txtNoRek.Text = "0000001"

    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "" Then
            txtPassword.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub frmRegistrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load, txtNama.Enter
        Call AutonumberNoRek()

    End Sub


End Class