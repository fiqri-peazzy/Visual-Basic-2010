Imports System.Data.Odbc
Imports System.Security.Cryptography
Imports System.Text
Public Class FormSewa
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
    Private Sub FormSewa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtidp.ReadOnly = True
        txtidp.Text = home.lbl_id.Text
        txtids.ReadOnly = True
        lama.ReadOnly = True
        Call koneksi()
        Dim query As String
        query = "select * from tbl_mobil"
        cmd = New OdbcCommand(query, conn)
        rd = cmd.ExecuteReader
        While rd.Read
            ComboBox1.Items.Add(rd("kode_mobil").ToString)
        End While

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lama.TextChanged
        tglkembali.Value = DateAdd(DateInterval.Day, Val(lama.Text), tglsewa.Value.Date)

    End Sub

    Private Sub tglkembali_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglkembali.ValueChanged
        If tglsewa.Value < tglkembali.Value Then
            lama.Text = DateDiff(DateInterval.Day, CDate(tglsewa.Text), CDate(tglkembali.Text))
            Call koneksi()
            Dim query As String = "select * from tbl_mobil where kode_mobil='" & ComboBox1.Text & "'"
            cmd = New OdbcCommand(query, conn)
            rd = cmd.ExecuteReader
            While rd.Read
                Dim kode As String = rd.Item(0)
                Dim harga As String = rd("tarif").ToString
                TotalBayar.Text = lama.Text * harga
                If ComboBox1.Text = kode Then
                    TotalBayar.Text = lama.Text * harga
                End If
            End While
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
                imgmobil.ImageLocation = rd("img_mobil")
                lblMerk.Text = "merk Mobil : " + rd("merk")
                lblTarif.Text = "Tarif / hari : " + rd("tarif").ToString
                lblNmrPol.Text = "nomor Polisi : " + rd("nomor_polisi")
                lbljml.Text = "Jumlah Kursi : " + rd("jumlah_kursi")
                If lama.Text = "" Then
                    TotalBayar.Text = "0"
                Else
                    Dim harga As String = rd("tarif").ToString
                    Dim tb As String
                    TotalBayar.Text = lama.Text * harga
                End If
            End If
        End While
    End Sub

    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MsgBox("Pastikan Form terisi dengan lengkap", MsgBoxStyle.Information)
        ElseIf lama.Text = "" Then
            MsgBox("Lengkapi Form terlebih dahulu", MsgBoxStyle.Information)
        Else

            Dim kode As String
            kode = Format(Now, "yyMMdd") + GetUnikId(4)
            txtids.Text = kode
            If RadioButton1.Checked = True Then
                Dim js As String = "yes"
                Call koneksi()
                Dim query As String = "insert into tb_sewa values('" + kode + "','" & txtidp.Text & "','" & ComboBox1.Text & "','" & lama.Text & "','" & tglsewa.Value.ToString & "','" & tglkembali.Value.ToString & "','" + js + "','" & TotalBayar.Text & "')"
                cmd = New OdbcCommand(query, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data penyewaan telah terkirim", MsgBoxStyle.Information)
                Me.Close()
            Else
                Call koneksi()
                Dim js As String = "No"
                Dim query As String = "insert into tb_sewa values('" + kode + "','" & txtidp.Text & "','" & ComboBox1.Text & "','" & lama.Text & "','" & tglsewa.Value.ToString & "','" & tglkembali.Value.ToString & "','" + js + "','" & TotalBayar.Text & "')"
                cmd = New OdbcCommand(query, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data penyewaan telah terkirim", MsgBoxStyle.Information)
                Me.Close()
            End If
            

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            RadioButton2.Checked = False
            lblRp.Text = "Rp."
            lbljasSupir.Text = "150000"
            TotalBayar.Text = Val(lbljasSupir.Text) + Val(TotalBayar.Text)
        Else
            lblRp.Text = ""
            lbljasSupir.Text = ""
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            RadioButton1.Checked = False
            lblRp.Text = ""
            lbljasSupir.Text = ""
        End If

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub lbljasSupir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbljasSupir.Click

    End Sub

    Private Sub lbljasSupir_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbljasSupir.TextChanged

    End Sub
End Class