Public Class frmNasabah
    Public Sub frmNasabah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Da = New Odbc.OdbcDataAdapter("SELECT Nomor_Rekening, Nama_Nasabah, Jenis_Kelamin, Username from nasabah", conn)
        Da.Fill(Ds, "xxx")
        DataGridView1.DataSource = Ds.Tables("xxx")
    End Sub


End Class