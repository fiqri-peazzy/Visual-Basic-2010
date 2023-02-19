<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dataUser
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(749, 543)
        Me.Panel1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(749, 543)
        Me.Panel4.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lavender
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(749, 499)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.txtcari)
        Me.Panel3.Location = New System.Drawing.Point(31, 52)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(265, 49)
        Me.Panel3.TabIndex = 0
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(6, 13)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(181, 22)
        Me.txtcari.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Navy
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(749, 44)
        Me.Panel5.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(749, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data User"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Navy
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Controls.Add(Me.DataGridView1)
        Me.Panel9.Location = New System.Drawing.Point(31, 126)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(618, 245)
        Me.Panel9.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(618, 50)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tabel User"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(570, 168)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel6.Controls.Add(Me.ComboBox1)
        Me.Panel6.Controls.Add(Me.Button2)
        Me.Panel6.Location = New System.Drawing.Point(384, 52)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(265, 49)
        Me.Panel6.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 13)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(163, 24)
        Me.ComboBox1.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_close_24__1_2
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(181, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 49)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Hapus"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_search_24
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(193, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 49)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = " Cari "
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dataUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 543)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "dataUser"
        Me.Text = "dataUser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
