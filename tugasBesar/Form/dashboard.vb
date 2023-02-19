Imports System.Data.Odbc
Public Class dashboard


    Private Sub dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call jmlt()
        Call profil()
    End Sub
    Sub jmlt()
        Call koneksi()
        Dim id As String = home.lbl_id.Text
        cmd = New OdbcCommand("select count(*) as jumlah from tb_sewa where id_pelanggan='" + id + "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        lblo.Text = rd("jumlah").ToString
    End Sub

    Sub profil()
        Call koneksi()
        Dim id As String = home.lbl_id.Text
        cmd = New OdbcCommand("select * from tbl_pelanggan where id_pelanggan='" + id + "'", conn)
        rd = cmd.ExecuteReader
        While rd.Read
            lblnama.Text = rd("nama")
            lblemail.Text = rd("email")
            lbltelp.Text = rd("telepon")
            lblkota.Text = rd("kota")

        End While
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class