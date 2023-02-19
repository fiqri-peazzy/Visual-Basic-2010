Imports System.Data.Odbc
Imports System.IO
Imports System.Drawing
Public Class FormHome
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub FormHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Dim query As String
        query = "select * from tbl_mobil"
        cmd = New OdbcCommand(query, conn)
        rd = cmd.ExecuteReader
        While rd.Read
            ComboBox1.Items.Add(rd("kode_mobil").ToString)
        End While

        
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call koneksi()
        Dim query As String = "select * from tbl_mobil where kode_mobil='" & ComboBox1.Text & "'"
        cmd = New OdbcCommand(query, conn)
        rd = cmd.ExecuteReader
        While rd.Read
            Dim kode As String = rd.Item(0)

            If ComboBox1.Text = kode Then
                imgmobil.ImageLocation = rd("img_mobil")
                lblMerk.Text = "merk Mobil : " + rd("merk")
                lblTarif.Text = "Tarif / hari : " + rd("tarif").ToString
                lblNmrPol.Text = "nomor Polisi : " + rd("nomor_polisi")
                lbljml.Text = "Jumlah Kursi : " + rd("jumlah_kursi")
            End If
        End While
        If ComboBox1.Text = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        FormSewa.ComboBox1.Text = ComboBox1.Text
        If ComboBox1.Text = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
            Me.Hide()

            FormSewa.Show()
            FormSewa.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class