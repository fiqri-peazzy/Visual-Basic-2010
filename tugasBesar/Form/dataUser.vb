Imports System.Data.Odbc
Public Class dataUser


    Private Sub dataUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampildt()
        Call cmb()


    End Sub
    Sub tampildt()
        Call koneksi()
        da = New OdbcDataAdapter("select * from tbl_pelanggan where status='user'", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_pelanggan")
        DataGridView1.DataSource = ds.Tables("tbl_pelanggan")


    End Sub
    Sub cari()
        If txtcari.Text = "" Then
            MsgBox("masukan keywoard pencarian", MsgBoxStyle.Information)
            Call tampildt()
        Else
            Call koneksi()
            da = New OdbcDataAdapter("select * from tbl_pelanggan where nama like '%" & txtcari.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "tbl_pelanggan")
            DataGridView1.DataSource = ds.Tables("tbl_pelanggan")

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call cari()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        
    End Sub
    Sub cmb()
        Call koneksi()
        cmd = New OdbcCommand("select id_pelanggan from tbl_pelanggan", conn)
        rd = cmd.ExecuteReader
        While rd.Read
            ComboBox1.Items.Add(rd(0))
        End While
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox1.Text = "" Then
            MsgBox("pilih id user yang ingin dihapus", MsgBoxStyle.Information)
        Else
            Dim responses As Integer = MessageBox.Show("Yakin ingin hapus '" + ComboBox1.Text + "' ini ?", "Hapus user", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If responses = vbYes Then
                Call koneksi()
                cmd = New OdbcCommand("delete from tbl_pelanggan where id_pelanggan='" & ComboBox1.Text & "'", conn)
                cmd.ExecuteReader()
                MsgBox("User berhasil dihapus", MsgBoxStyle.Information)
                Call tampildt()
                ComboBox1.Text = ""
                Call cmb()
            Else
                Exit Sub
            End If
            
        End If
    End Sub
End Class