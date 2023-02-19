Imports System.Data.Odbc
Imports System.IO

Public Class home
    Private Sub home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Dim id As String
        Dim foto As String
        lblUsername.Text = loginForm.txtUsername.Text
        cmd = New OdbcCommand("select id_pelanggan, img_profile from tbl_pelanggan where username='" & lblUsername.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            id = rd.Item("id_pelanggan")
            lbl_id.Text = id

            foto = rd.Item("img_profile")
            If foto = "" Then
                user_img.ImageLocation = ""
            Else
                user_img.Load(foto)
            End If
        End If
        ConFormPanel(New FormHome)
        lblhome.Visible = True
        lbldshbrd.Visible = False
        lbledit.Visible = False
        lblorder.Visible = False
        lblsewa.Visible = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        End
    End Sub
    Dim max As Boolean
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If (max) Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub
    Private Sub ConFormPanel(ByVal FormCon As Object)
        If Me.pnlHome.Controls.Count > 0 Then Me.pnlHome.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(FormCon, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.pnlHome.Controls.Add(fh)
        Me.pnlHome.Tag = fh
        fh.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        ConFormPanel(New FormHome)
        lblhome.Visible = True
        lbldshbrd.Visible = False
        lbledit.Visible = False
        lblorder.Visible = False
        lblsewa.Visible = False
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim responses As Integer

        responses = MessageBox.Show("apakah yakin anda ingin keluar ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If responses = vbYes Then
            Me.Close()
            menuUtama.Show()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnSewa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSewa.Click
        ConFormPanel(New FormSewa)
        lblhome.Visible = False
        lbldshbrd.Visible = False
        lbledit.Visible = False
        lblorder.Visible = False
        lblsewa.Visible = True
    End Sub
    Private Sub btnProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProfile.Click
        ConFormPanel(New FormEditProf)
        lblhome.Visible = False
        lbldshbrd.Visible = False
        lbledit.Visible = True
        lblorder.Visible = False
        lblsewa.Visible = False
    End Sub

    Private Sub btnDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDashboard.Click
        ConFormPanel(New dashboard)
        lblhome.Visible = False
        lbldshbrd.Visible = True
        lbledit.Visible = False
        lblorder.Visible = False
        lblsewa.Visible = False
    End Sub

    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        ConFormPanel(New myorder)
        lblhome.Visible = False
        lbldshbrd.Visible = False
        lbledit.Visible = False
        lblorder.Visible = True
        lblsewa.Visible = False
    End Sub
End Class