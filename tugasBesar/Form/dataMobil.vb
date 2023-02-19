Imports System.Data.Odbc
Imports System.Security.Cryptography
Imports System.Text
Public Class dataMobil

    Private Sub dataMobil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kondisiAwal()
        Call aturdgv()
        Call koneksi()
        Dim query As String = "select * from tbl_mobil"
        cmd = New OdbcCommand(query, conn)
        rd = cmd.ExecuteReader
        While rd.Read
            ComboBox1.Items.Add(rd(0).ToString)
        End While

    End Sub
    Public Shared Function GetUnikId(ByVal maxSize As Integer) As String
        Dim chars As Char() = New Char(61) {}
        chars = "123456789".ToCharArray
        Dim data As Byte() = New Byte(0) {}
        Dim crypto As New RNGCryptoServiceProvider()
        crypto.GetNonZeroBytes(data)
        data = New Byte(maxSize - 1) {}
        crypto.GetNonZeroBytes(data)
        Dim result As New StringBuilder(maxSize)
        For Each b As Byte In data
            result.Append(chars(b Mod (chars.Length)))
        Next
        Return result.ToString()
    End Function


    Private Sub btninput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Sub kondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        Call koneksi()
        da = New OdbcDataAdapter("select * from tbl_mobil", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_mobil")
        DataGridView1.DataSource = ds.Tables("tbl_mobil")


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        OpenFileDialog1.Filter = "JPG|*.jpg|Bitmap|*.bmp"
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then
            Exit Sub
        Else
            TextBox5.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Sub aturdgv()
        DataGridView1.Columns(0).Width = 150
        DataGridView1.Columns(1).Width = 170
        DataGridView1.Columns(2).Width = 140
        DataGridView1.Columns(3).Width = 170
        DataGridView1.Columns(4).Width = 170
        DataGridView1.Columns(5).Width = 170

        DataGridView1.Columns(0).HeaderText = "KODE_MOBIL"
        DataGridView1.Columns(1).HeaderText = "MERK MOBIL"
        DataGridView1.Columns(2).HeaderText = "TARIF"
        DataGridView1.Columns(3).HeaderText = "NOMOR POLISI"
        DataGridView1.Columns(4).HeaderText = "JUMLAH KURSI"
        DataGridView1.Columns(5).HeaderText = "IMAGE"

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btninput_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninput.Click
        Dim kode As String
        kode = "MBL" & GetUnikId(4)
        TextBox5.Text = TextBox5.Text.Replace("\", "\\")
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("pastikan semua field terisi!!")
        Else
            Dim inputData As String = "insert into tbl_mobil values('" + kode + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')"
            cmd = New OdbcCommand(inputData, conn)
            cmd.ExecuteNonQuery()
            MsgBox("data berhasil di input")
            Call kondisiAwal()
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        

        If ComboBox1.Text = "" Then
            MsgBox("Pilih Kode Mobil Terlebih dahulu", MsgBoxStyle.Information)
        Else
            Call koneksi()
            TextBox5.Text = TextBox5.Text.Replace("\", "\\")
            Dim Editdata As String = "update tbl_mobil set merk='" + TextBox1.Text + "',tarif='" + TextBox2.Text + "',nomor_polisi='" + TextBox3.Text + "',jumlah_kursi='" + TextBox4.Text + "',img_mobil='" + TextBox5.Text + "' where kode_mobil='" & ComboBox1.Text & "'"
            cmd = New OdbcCommand(Editdata, conn)
            cmd.ExecuteNonQuery()
            MsgBox("data berhasil di ubah", MsgBoxStyle.Information)
            Call kondisiAwal()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call koneksi()
        Dim query As String = "select * from tbl_mobil where kode_mobil='" & ComboBox1.Text & "'"
        cmd = New OdbcCommand(query, conn)
        rd = cmd.ExecuteReader
        While rd.Read
            Dim kode As String = rd.Item(0)
            If ComboBox1.Text = kode Then
                TextBox1.Text = rd.Item("merk")
                TextBox2.Text = rd.Item("tarif")
                TextBox3.Text = rd.Item("nomor_polisi")
                TextBox4.Text = rd.Item("jumlah_kursi")
                TextBox5.Text = rd.Item("img_mobil")

            End If
        End While
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        
        If ComboBox1.Text = "" Then
            MsgBox("Pilih Kode Mobil Terlebih dahulu", MsgBoxStyle.Information)
        Else
            Dim res As Integer
            res = MessageBox.Show("yakin ingin menghapus mobil dengan kode '" & ComboBox1.Text & "' ?", "Hapus Data Mobil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If res = vbYes Then
                Call koneksi()
                Dim Hapusdata As String = "Delete from tbl_mobil where kode_mobil='" & ComboBox1.Text & "'"
                cmd = New OdbcCommand(Hapusdata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("berhasil hapus data Mobil", MsgBoxStyle.Information)
                ComboBox1.Text = ""
                Call kondisiAwal()

            Else
                Exit Sub
            End If
            Call kondisiAwal()
        End If
    End Sub
End Class