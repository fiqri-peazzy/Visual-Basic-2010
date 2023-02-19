Imports System.Data.Odbc
Public Class formAdmin

    Private Sub formAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblhome.Visible = True
        lbledit.Visible = False
        lblim.Visible = False
        lblmu.Visible = False
        Call koneksi()
        Dim id As String
        Dim foto As String
        Dim status As String
        lblUsername.Text = loginForm.txtUsername.Text
        cmd = New OdbcCommand("select id_pelanggan, img_profile, status from tbl_pelanggan where username='" & lblUsername.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            id = rd.Item("id_pelanggan")
            lbl_id.Text = "ID :" + id
            foto = rd.Item("img_profile")
            user_img.Load(foto)
            status = rd.Item("status")
            lblStatus.Text = "status : " + status
        End If
        ConFormPanel(New HomeAdmin)
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
    
    Private Sub btndtMobil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndtMobil.Click
        ConFormPanel(New dataMobil)
        lblhome.Visible = False
        lbledit.Visible = False
        lblim.Visible = True
        lblmu.Visible = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        End

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ConFormPanel(New dataUser)
        lblhome.Visible = False
        lbledit.Visible = False
        lblim.Visible = False
        lblmu.Visible = True
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        ConFormPanel(New HomeAdmin)
        lblhome.Visible = True
        lbledit.Visible = False
        lblim.Visible = False
        lblmu.Visible = False
    End Sub

    Private Sub btnProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProfile.Click
        ConFormPanel(New FormEPA)
        lblhome.Visible = False
        lbledit.Visible = True
        lblim.Visible = False
        lblmu.Visible = False
    End Sub
End Class