<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblMerk = New System.Windows.Forms.Label()
        Me.lblTarif = New System.Windows.Forms.Label()
        Me.lbljml = New System.Windows.Forms.Label()
        Me.lblNmrPol = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.imgmobil = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.imgmobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(741, 572)
        Me.Panel3.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.lbljml)
        Me.Panel5.Controls.Add(Me.lblNmrPol)
        Me.Panel5.Controls.Add(Me.lblTarif)
        Me.Panel5.Controls.Add(Me.lblMerk)
        Me.Panel5.Controls.Add(Me.imgmobil)
        Me.Panel5.Controls.Add(Me.ComboBox1)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 44)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(741, 528)
        Me.Panel5.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Navy
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(741, 44)
        Me.Panel4.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(741, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pilih Mobil Yang anda suka "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(39, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pilih Mobil Berdasarkan Kode Mobil"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(42, 68)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(215, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'lblMerk
        '
        Me.lblMerk.BackColor = System.Drawing.Color.Navy
        Me.lblMerk.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMerk.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMerk.Location = New System.Drawing.Point(369, 110)
        Me.lblMerk.Name = "lblMerk"
        Me.lblMerk.Size = New System.Drawing.Size(205, 36)
        Me.lblMerk.TabIndex = 3
        Me.lblMerk.Text = "-"
        Me.lblMerk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTarif
        '
        Me.lblTarif.BackColor = System.Drawing.Color.Blue
        Me.lblTarif.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTarif.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTarif.Location = New System.Drawing.Point(369, 158)
        Me.lblTarif.Name = "lblTarif"
        Me.lblTarif.Size = New System.Drawing.Size(205, 36)
        Me.lblTarif.TabIndex = 4
        Me.lblTarif.Text = "-"
        Me.lblTarif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbljml
        '
        Me.lbljml.BackColor = System.Drawing.Color.Blue
        Me.lbljml.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljml.ForeColor = System.Drawing.SystemColors.Control
        Me.lbljml.Location = New System.Drawing.Point(369, 258)
        Me.lbljml.Name = "lbljml"
        Me.lbljml.Size = New System.Drawing.Size(205, 36)
        Me.lbljml.TabIndex = 6
        Me.lbljml.Text = "-"
        Me.lbljml.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNmrPol
        '
        Me.lblNmrPol.BackColor = System.Drawing.Color.Navy
        Me.lblNmrPol.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNmrPol.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNmrPol.Location = New System.Drawing.Point(369, 210)
        Me.lblNmrPol.Name = "lblNmrPol"
        Me.lblNmrPol.Size = New System.Drawing.Size(205, 36)
        Me.lblNmrPol.TabIndex = 5
        Me.lblNmrPol.Text = "-"
        Me.lblNmrPol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Navy
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightYellow
        Me.Button1.Location = New System.Drawing.Point(372, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 39)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Pilih Mobil"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(121, 44)
        Me.Panel1.TabIndex = 2
        '
        'imgmobil
        '
        Me.imgmobil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imgmobil.Location = New System.Drawing.Point(42, 110)
        Me.imgmobil.Name = "imgmobil"
        Me.imgmobil.Size = New System.Drawing.Size(313, 252)
        Me.imgmobil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgmobil.TabIndex = 2
        Me.imgmobil.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_back_arrow_30__1_
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 32)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Kembali"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 572)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FormHome"
        Me.Text = "FormHome"
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.imgmobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbljml As System.Windows.Forms.Label
    Friend WithEvents lblNmrPol As System.Windows.Forms.Label
    Friend WithEvents lblTarif As System.Windows.Forms.Label
    Friend WithEvents lblMerk As System.Windows.Forms.Label
    Friend WithEvents imgmobil As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
