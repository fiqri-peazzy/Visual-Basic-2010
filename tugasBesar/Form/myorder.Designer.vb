<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myorder
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel3.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.OldLace
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.Panel2)
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(121, 44)
        Me.Panel1.TabIndex = 2
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
        Me.Label1.Text = "My Order"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(39, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(584, 306)
        Me.Panel2.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(27, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(530, 197)
        Me.DataGridView1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(27, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(530, 44)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Riwayat Transaksi"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'myorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 572)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "myorder"
        Me.Text = "myorder"
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
