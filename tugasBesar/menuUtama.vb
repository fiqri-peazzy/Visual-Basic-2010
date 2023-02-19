
Public Class menuUtama
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
        loginForm.Show()
        loginForm.kosong()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Visible = False
        registrasiForm.Show()
        loginForm.kosong()

    End Sub
End Class
