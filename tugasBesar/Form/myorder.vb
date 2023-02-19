Imports System.Data.Odbc
Public Class myorder

    Private Sub myorder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Dim id As String = home.lbl_id.Text
        da = New OdbcDataAdapter("select * from tb_sewa where id_pelanggan='" + id + "'", conn)
        ds = New DataSet
        da.Fill(ds, "tb_sewa")
        DataGridView1.DataSource = ds.Tables("tb_sewa")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class