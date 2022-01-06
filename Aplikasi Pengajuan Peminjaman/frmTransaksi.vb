Public Class frmTransaksi
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim tanggalpinjam As String
        tanggalpinjam = Format(dtpTanggal.Value, "yyyy-MM-dd")

        Dim jumlahpinjam, angsur As Double
        jumlahpinjam = CDbl(cbJumlahPinjaman.Text)

        angsur = (jumlahpinjam * 1.05) / cbLamaAngsuran.Text
        lblAngsur.Text = angsur.ToString("Rp. ")

        Call koneksi()
        conn.Open()
        MyDB = "INSERT INTO transaksi VALUES ('" & txtKode.Text & "','" &
            tanggalpinjam & "','" &
            txtNoRek.Text & "','" &
            cbJumlahPinjaman.Text & "','" &
            cbLamaAngsuran.Text & "','" &
            lblAngsur.Text & "')"
        Cmd = New Odbc.OdbcCommand("SELECT * from nasabah where Nomor_Rekening = '" & txtNoRek.Text & "'", conn)
        Dr = Cmd.ExecuteReader
        Dr.Read()
        If Dr.HasRows Then
            Cmd = New Odbc.OdbcCommand(MyDB, conn)
            Cmd.ExecuteNonQuery()

            MsgBox("Terima Kasih Telah Mempercayai Aplikasi Layanan Peminjaman Uang")


            Me.Close()
            End

        Else

            MsgBox("Nomor Rekening Anda Salah ! ")

        End If

        dtpTanggal.ResetText()
        txtNoRek.Clear()
        cbJumlahPinjaman.ResetText()
        cbLamaAngsuran.ResetText()
        lblAngsur.ResetText()

    End Sub


    Private Sub btnCek_Click(sender As Object, e As EventArgs) Handles btnCek.Click
        Dim jumlahpinjam, angsur As Double
        jumlahpinjam = CDbl(cbJumlahPinjaman.Text)

        angsur = (jumlahpinjam * 1.05) / cbLamaAngsuran.Text
        lblAngsur.Text = angsur.ToString("Rp. ")


    End Sub

    Sub Autonumberkode()
        Call koneksi()
        conn.Open()
        MyDB = "SELECT max(Kode_Transaksi) FROM transaksi"
        Cmd = New Odbc.OdbcCommand(MyDB, conn)
        Dr = Cmd.ExecuteReader()
        Dr.Read()
        On Error GoTo Err
        If Dr.HasRows Then
            txtKode.Text = Format(Val(Dr.Item(0)) + 1, "000000")
        End If
        Exit Sub
Err:
        txtKode.Text = "1110000001"

    End Sub

    Private Sub frmTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Autonumberkode()

        If txtNoRek.Text = "" Then
            Call koneksi()
            conn.Open()
            Cmd = New Odbc.OdbcCommand("SELECT * from nasabah WHERE Username = '" & frmLogin.txtUsername.Text & "' AND Password = '" & frmLogin.txtPassword.Text & "'", conn)
            Dr = Cmd.ExecuteReader
            Dr.Read()
            txtNoRek.Text = Dr.Item("Nomor_Rekening")
        End If


    End Sub


End Class