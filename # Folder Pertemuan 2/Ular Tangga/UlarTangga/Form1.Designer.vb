<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnMulai = New System.Windows.Forms.Button()
        Me.BtnDadu = New System.Windows.Forms.Button()
        Me.LabelLokasi = New System.Windows.Forms.Label()
        Me.LabelMenang = New System.Windows.Forms.Label()
        Me.LabelTanggaUlar = New System.Windows.Forms.Label()
        Me.TextBoxDadu = New System.Windows.Forms.TextBox()
        Me.PBPlayer = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(35, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(600, 600)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnMulai
        '
        Me.BtnMulai.Location = New System.Drawing.Point(649, 12)
        Me.BtnMulai.Name = "BtnMulai"
        Me.BtnMulai.Size = New System.Drawing.Size(101, 36)
        Me.BtnMulai.TabIndex = 1
        Me.BtnMulai.Text = "Mulai"
        Me.BtnMulai.UseVisualStyleBackColor = True
        '
        'BtnDadu
        '
        Me.BtnDadu.Enabled = False
        Me.BtnDadu.Location = New System.Drawing.Point(649, 86)
        Me.BtnDadu.Name = "BtnDadu"
        Me.BtnDadu.Size = New System.Drawing.Size(101, 50)
        Me.BtnDadu.TabIndex = 2
        Me.BtnDadu.Text = "Roll Dadu"
        Me.BtnDadu.UseVisualStyleBackColor = True
        '
        'LabelLokasi
        '
        Me.LabelLokasi.AutoSize = True
        Me.LabelLokasi.Enabled = False
        Me.LabelLokasi.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelLokasi.Location = New System.Drawing.Point(649, 170)
        Me.LabelLokasi.Name = "LabelLokasi"
        Me.LabelLokasi.Size = New System.Drawing.Size(141, 20)
        Me.LabelLokasi.TabIndex = 3
        Me.LabelLokasi.Text = "Lokasi Sekarang = 1"
        '
        'LabelMenang
        '
        Me.LabelMenang.AutoSize = True
        Me.LabelMenang.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelMenang.Location = New System.Drawing.Point(649, 281)
        Me.LabelMenang.Name = "LabelMenang"
        Me.LabelMenang.Size = New System.Drawing.Size(158, 20)
        Me.LabelMenang.TabIndex = 5
        Me.LabelMenang.Text = "Selamat anda menang"
        Me.LabelMenang.Visible = False
        '
        'LabelTanggaUlar
        '
        Me.LabelTanggaUlar.AutoSize = True
        Me.LabelTanggaUlar.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelTanggaUlar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LabelTanggaUlar.Location = New System.Drawing.Point(649, 222)
        Me.LabelTanggaUlar.Name = "LabelTanggaUlar"
        Me.LabelTanggaUlar.Size = New System.Drawing.Size(0, 20)
        Me.LabelTanggaUlar.TabIndex = 6
        '
        'TextBoxDadu
        '
        Me.TextBoxDadu.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxDadu.Location = New System.Drawing.Point(757, 97)
        Me.TextBoxDadu.Name = "TextBoxDadu"
        Me.TextBoxDadu.ReadOnly = True
        Me.TextBoxDadu.Size = New System.Drawing.Size(56, 27)
        Me.TextBoxDadu.TabIndex = 7
        '
        'PBPlayer
        '
        Me.PBPlayer.BackColor = System.Drawing.Color.Black
        Me.PBPlayer.Image = CType(resources.GetObject("PBPlayer.Image"), System.Drawing.Image)
        Me.PBPlayer.Location = New System.Drawing.Point(649, 319)
        Me.PBPlayer.Name = "PBPlayer"
        Me.PBPlayer.Size = New System.Drawing.Size(59, 56)
        Me.PBPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBPlayer.TabIndex = 8
        Me.PBPlayer.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 729)
        Me.Controls.Add(Me.PBPlayer)
        Me.Controls.Add(Me.TextBoxDadu)
        Me.Controls.Add(Me.LabelTanggaUlar)
        Me.Controls.Add(Me.LabelMenang)
        Me.Controls.Add(Me.LabelLokasi)
        Me.Controls.Add(Me.BtnDadu)
        Me.Controls.Add(Me.BtnMulai)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Ular Tangga 70"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnMulai As Button
    Friend WithEvents BtnDadu As Button
    Friend WithEvents LabelLokasi As Label
    Friend WithEvents LabelMenang As Label
    Friend WithEvents LabelTanggaUlar As Label
    Friend WithEvents TextBoxDadu As TextBox
    Friend WithEvents PBPlayer As PictureBox
End Class
