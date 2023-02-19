Imports System.Data.Odbc
Public Class loginForm

    Sub kosong()
        txtPassword.Text = ""
        txtUsername.Text = ""

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        menuUtama.Show()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub loginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUsername.Focus()
        Call kosong()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtPassword.Text = "" Or txtUsername.Text = "" Then
            MsgBox("pastikan anda mengisi username dan password")
        Else
            Call koneksi()
            cmd = New OdbcCommand("select * from tbl_pelanggan where username='" & txtUsername.Text & "' and password='" & txtPassword.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                MsgBox("berhasil login")
                If rd("status").ToString = "admin" Then
                    Me.Visible = False
                    formAdmin.Show()
                Else
                    Me.Visible = False
                    home.Show()
                    Call kosong()
                End If
            Else
                MsgBox("user tidak di temukan")
                Call kosong()
            End If
        End If
    End Sub
End Class