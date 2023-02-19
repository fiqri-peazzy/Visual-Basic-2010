Imports System.Data.Odbc
Public Class HomeAdmin

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub HomeAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call jmladmin()
        Call jmluser()
        Call jmlmobil()
        Call jmlt()
        Call tampil()
    End Sub
    Sub jmladmin()
        Call koneksi()
        cmd = New OdbcCommand("select count(*) as jumlah from tbl_pelanggan where status='admin'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        lbla.Text = rd("jumlah").ToString
    End Sub

    Sub jmluser()
        Call koneksi()
        cmd = New OdbcCommand("select count(*) as jumlah from tbl_pelanggan where status='user'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        lblu.Text = rd("jumlah").ToString
    End Sub

    Sub jmlmobil()
        Call koneksi()
        cmd = New OdbcCommand("select count(*) as jumlah from tbl_mobil", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        lblm.Text = rd("jumlah").ToString
    End Sub
    Sub jmlt()
        Call koneksi()
        cmd = New OdbcCommand("select count(*) as jumlah from tb_sewa", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        lblt.Text = rd("jumlah").ToString
    End Sub
    Sub tampil()
        da = New OdbcDataAdapter("select * from tb_sewa", conn)
        ds = New DataSet
        da.Fill(ds, "tb_sewa")
        DataGridView1.DataSource = ds.Tables("tb_sewa")
    End Sub

End Class