Public Class frmTampil
    Public Sub frmTampil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Call koneksi()
            Da = New Odbc.OdbcDataAdapter("SELECT * from transaksi", conn)
            Da.Fill(Ds, "yyy")
            DataGridView1.DataSource = Ds.Tables("yyy")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class