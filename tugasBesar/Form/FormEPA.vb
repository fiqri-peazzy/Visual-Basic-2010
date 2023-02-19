Imports System.Data.Odbc
Public Class FormEPA
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        OpenFileDialog1.Filter = "JPG|*.jpg|Bitmap|*.bmp"
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then
            Exit Sub
        Else
            txtfoto.Text = txtfoto.Text.Replace("\", "\\")
            txtfoto.Text = OpenFileDialog1.FileName
            PictureBox1.ImageLocation = txtfoto.Text
        End If
    End Sub

    Private Sub FormEPA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Dim kode As String = formAdmin.lblUsername.Text
        Dim query As String = "select * from tbl_pelanggan where username='" + kode + "'"

        cmd = New OdbcCommand(query, conn)
        rd = cmd.ExecuteReader
        While rd.Read
            txtNama.Text = rd.Item("nama")
            txtalamat.Text = rd.Item("alamat")
            txtKota.Text = rd.Item("kota")
            txtEmail.Text = rd.Item("email")
            txttelp.Text = rd.Item("telepon")
            txtuser.Text = rd.Item("username")
            txtpass.Text = rd.Item("password")
            PictureBox1.ImageLocation = rd.Item("img_profile")
            txtfoto.Text = rd.Item("img_profile")
        End While
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If txtNama.Text = "" Or txtalamat.Text = "" Or txtKota.Text = "" Or txtEmail.Text = "" Or txttelp.Text = "" Or txtuser.Text = "" Or txtpass.Text = "" Or txtpass2.Text = "" Then
            MsgBox("Pastikan Semua field terisi", MsgBoxStyle.Information)
        ElseIf txtpass.Text = txtpass2.Text Then
            txtfoto.Text = txtfoto.Text.Replace("\", "\\")
            Call koneksi()
            Dim kode As String = formAdmin.lblUsername.Text
            Dim status As String = "admin"
            Dim query As String = "update tbl_pelanggan set nama='" & txtNama.Text & "',alamat='" & txtalamat.Text & "',kota='" & txtKota.Text & "',email='" & txtEmail.Text & "', telepon='" & txttelp.Text & "', username='" & txtuser.Text & "',password='" & txtpass2.Text & "',img_profile='" & txtfoto.Text & "',status='" + status + "' where username='" + kode + "'"
            cmd = New OdbcCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("berhasil ubah data", MsgBoxStyle.Information)

        Else
            MsgBox("Password Tidak Sama", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lihatpw.CheckedChanged, lihatpw.CheckedChanged
        If lihatpw.Checked Then
            txtpass.UseSystemPasswordChar = False
            txtpass2.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
            txtpass2.UseSystemPasswordChar = True
        End If
    End Sub
End Class