<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrasiForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ofdimgUser = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txtimage = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnDaftar = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtConfPass = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.txtKtp = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'ofdimgUser
        '
        Me.ofdimgUser.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._1014
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(841, 635)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Panel11)
        Me.Panel3.Controls.Add(Me.Panel10)
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(122, 129)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(592, 494)
        Me.Panel3.TabIndex = 2
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.txtimage)
        Me.Panel10.Controls.Add(Me.Button2)
        Me.Panel10.Controls.Add(Me.Label11)
        Me.Panel10.Location = New System.Drawing.Point(29, 271)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(546, 61)
        Me.Panel10.TabIndex = 5
        '
        'txtimage
        '
        Me.txtimage.Location = New System.Drawing.Point(242, 19)
        Me.txtimage.Name = "txtimage"
        Me.txtimage.Size = New System.Drawing.Size(150, 20)
        Me.txtimage.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(140, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Upload Foto"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(3, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(138, 23)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Profile Picture :"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Panel9.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.download__1__removebg_preview
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel9.Controls.Add(Me.Button1)
        Me.Panel9.Location = New System.Drawing.Point(314, 416)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(200, 75)
        Me.Panel9.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(39, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 38)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.download__1__removebg_preview
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel8.Controls.Add(Me.btnDaftar)
        Me.Panel8.Location = New System.Drawing.Point(85, 416)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(200, 75)
        Me.Panel8.TabIndex = 3
        '
        'btnDaftar
        '
        Me.btnDaftar.FlatAppearance.BorderSize = 0
        Me.btnDaftar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.btnDaftar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDaftar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDaftar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDaftar.Location = New System.Drawing.Point(39, 18)
        Me.btnDaftar.Name = "btnDaftar"
        Me.btnDaftar.Size = New System.Drawing.Size(127, 38)
        Me.btnDaftar.TabIndex = 10
        Me.btnDaftar.Text = "Daftar"
        Me.btnDaftar.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txtConfPass)
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Controls.Add(Me.txtPassword)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Location = New System.Drawing.Point(29, 207)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(546, 61)
        Me.Panel7.TabIndex = 2
        '
        'txtConfPass
        '
        Me.txtConfPass.Location = New System.Drawing.Point(372, 20)
        Me.txtConfPass.Name = "txtConfPass"
        Me.txtConfPass.Size = New System.Drawing.Size(150, 20)
        Me.txtConfPass.TabIndex = 8
        Me.txtConfPass.UseSystemPasswordChar = True
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(262, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 41)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Confirm " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password  :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(106, 21)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(150, 20)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Password :"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txtUsername)
        Me.Panel6.Controls.Add(Me.txtTelepon)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Location = New System.Drawing.Point(29, 140)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(546, 61)
        Me.Panel6.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(372, 25)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(150, 22)
        Me.txtUsername.TabIndex = 6
        '
        'txtTelepon
        '
        Me.txtTelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelepon.Location = New System.Drawing.Point(106, 26)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(150, 22)
        Me.txtTelepon.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(282, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 23)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Username :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "No. HP :"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtEmail)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.txtKota)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(29, 73)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(546, 61)
        Me.Panel5.TabIndex = 0
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(372, 22)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(150, 22)
        Me.txtEmail.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(303, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 23)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Email :"
        '
        'txtKota
        '
        Me.txtKota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKota.Location = New System.Drawing.Point(106, 21)
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(150, 22)
        Me.txtKota.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(30, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Kota :"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtAlamat)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.txtNama)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(29, 15)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(546, 61)
        Me.Panel4.TabIndex = 0
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(372, 22)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(150, 22)
        Me.txtAlamat.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(296, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 23)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Alamat :"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(106, 21)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(150, 22)
        Me.txtNama.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(30, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(841, 126)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Sitka Heading", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(161, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(518, 126)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Registrasi User Account" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.images__1__removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(679, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(162, 126)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.images__1__removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.txtKtp)
        Me.Panel11.Controls.Add(Me.Button3)
        Me.Panel11.Controls.Add(Me.Label6)
        Me.Panel11.Location = New System.Drawing.Point(29, 338)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(546, 61)
        Me.Panel11.TabIndex = 6
        '
        'txtKtp
        '
        Me.txtKtp.Location = New System.Drawing.Point(242, 19)
        Me.txtKtp.Name = "txtKtp"
        Me.txtKtp.Size = New System.Drawing.Size(150, 20)
        Me.txtKtp.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(140, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Upload File"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 61)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Kartu identitas : (*ktp/)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'registrasiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 635)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "registrasiForm"
        Me.Text = "registrasiForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtKota As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtConfPass As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtTelepon As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnDaftar As System.Windows.Forms.Button
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ofdimgUser As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtimage As System.Windows.Forms.TextBox
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents txtKtp As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
