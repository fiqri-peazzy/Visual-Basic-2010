Imports System.Data.Odbc
Imports System.Security.Cryptography
Imports System.Text
Public Class registrasiForm
    Sub kosong()
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtKota.Text = ""
        txtEmail.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtConfPass.Text = ""
    End Sub
    Private Sub registrasiForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNama.Focus()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        menuUtama.Show()

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

    Private Sub btnDaftar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDaftar.Click
        Call koneksi()
        Dim kode As String
        Dim status As String
        status = "user"
        kode = "U-" & GetUnikId(5)
        txtimage.Text = txtimage.Text.Replace("\", "\\")
        txtKtp.Text = txtKtp.Text.Replace("\", "\\")
        If txtNama.Text = "" Or txtAlamat.Text = "" Or txtKota.Text = "" Or txtEmail.Text = "" Or txtTelepon.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or txtConfPass.Text = "" Or txtKtp.Text = "" Then
            MsgBox("Pastikan anda mengisi semua data", MsgBoxStyle.Information)
        ElseIf txtPassword.Text = txtConfPass.Text Then
            Dim simpandata As String = "insert into tbl_pelanggan values('" + kode + "', '" + txtNama.Text + "', '" + txtAlamat.Text + "', '" + txtKota.Text + "', '" + txtEmail.Text + "', '" + txtTelepon.Text + "' , '" + txtUsername.Text + "', '" + txtConfPass.Text + "', '" + txtimage.Text + "','" + status + "','" & txtKtp.Text & "')"
            cmd = New OdbcCommand(simpandata, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Membuat Akun", MsgBoxStyle.Information)
            Call kosong()
            Me.Close()
            loginForm.Show()
        Else
            MsgBox("password tidak sama", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next
        ofdimgUser.Filter = "JPG|*.jpg|Bitmap|*.bmp"
        ofdimgUser.RestoreDirectory = True
        ofdimgUser.ShowDialog()
        If ofdimgUser.FileName = "" Then
            Exit Sub
        Else
            txtimage.Text = ofdimgUser.FileName
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next
        ofdimgUser.Filter = "JPG|*.jpg|Bitmap|*.bmp"
        ofdimgUser.RestoreDirectory = True
        ofdimgUser.ShowDialog()
        If ofdimgUser.FileName = "" Then
            Exit Sub
        Else
            txtKtp.Text = ofdimgUser.FileName
        End If


    End Sub
End Class