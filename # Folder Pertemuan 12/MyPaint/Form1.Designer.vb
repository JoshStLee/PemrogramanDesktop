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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBoxMode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBoxUkuran = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnBersihkan = New System.Windows.Forms.Button()
        Me.Warna1 = New System.Windows.Forms.Panel()
        Me.Warna2 = New System.Windows.Forms.Panel()
        Me.Warna3 = New System.Windows.Forms.Panel()
        Me.Warna4 = New System.Windows.Forms.Panel()
        Me.Warna5 = New System.Windows.Forms.Panel()
        Me.Warna6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ShapeTepi = New System.Windows.Forms.Panel()
        Me.ShapeIsian = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Warna7 = New System.Windows.Forms.Panel()
        Me.Warna8 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pilih Mode Gambar"
        '
        'CBoxMode
        '
        Me.CBoxMode.FormattingEnabled = True
        Me.CBoxMode.Items.AddRange(New Object() {"Polygon", "PolygonFill", "BrushBebas", "HatchForwardDiagonal", "HatchDottedGrid"})
        Me.CBoxMode.Location = New System.Drawing.Point(139, 24)
        Me.CBoxMode.Name = "CBoxMode"
        Me.CBoxMode.Size = New System.Drawing.Size(103, 21)
        Me.CBoxMode.TabIndex = 1
        Me.CBoxMode.Text = "Polygon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ukuran Paint"
        '
        'CBoxUkuran
        '
        Me.CBoxUkuran.FormattingEnabled = True
        Me.CBoxUkuran.IntegralHeight = False
        Me.CBoxUkuran.Items.AddRange(New Object() {"3", "9", "15", "27"})
        Me.CBoxUkuran.Location = New System.Drawing.Point(382, 24)
        Me.CBoxUkuran.Name = "CBoxUkuran"
        Me.CBoxUkuran.Size = New System.Drawing.Size(38, 21)
        Me.CBoxUkuran.TabIndex = 3
        Me.CBoxUkuran.Text = "3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(426, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "px"
        '
        'BtnBersihkan
        '
        Me.BtnBersihkan.Location = New System.Drawing.Point(671, 73)
        Me.BtnBersihkan.Name = "BtnBersihkan"
        Me.BtnBersihkan.Size = New System.Drawing.Size(75, 23)
        Me.BtnBersihkan.TabIndex = 5
        Me.BtnBersihkan.Text = "Bersihkan"
        Me.BtnBersihkan.UseVisualStyleBackColor = True
        '
        'Warna1
        '
        Me.Warna1.BackColor = System.Drawing.Color.Red
        Me.Warna1.Location = New System.Drawing.Point(425, 368)
        Me.Warna1.Name = "Warna1"
        Me.Warna1.Size = New System.Drawing.Size(32, 32)
        Me.Warna1.TabIndex = 7
        '
        'Warna2
        '
        Me.Warna2.BackColor = System.Drawing.Color.Yellow
        Me.Warna2.Location = New System.Drawing.Point(463, 368)
        Me.Warna2.Name = "Warna2"
        Me.Warna2.Size = New System.Drawing.Size(32, 32)
        Me.Warna2.TabIndex = 8
        '
        'Warna3
        '
        Me.Warna3.BackColor = System.Drawing.Color.Lime
        Me.Warna3.Location = New System.Drawing.Point(503, 368)
        Me.Warna3.Name = "Warna3"
        Me.Warna3.Size = New System.Drawing.Size(32, 32)
        Me.Warna3.TabIndex = 9
        '
        'Warna4
        '
        Me.Warna4.BackColor = System.Drawing.Color.Blue
        Me.Warna4.Location = New System.Drawing.Point(541, 368)
        Me.Warna4.Name = "Warna4"
        Me.Warna4.Size = New System.Drawing.Size(32, 32)
        Me.Warna4.TabIndex = 10
        '
        'Warna5
        '
        Me.Warna5.BackColor = System.Drawing.Color.Fuchsia
        Me.Warna5.Location = New System.Drawing.Point(579, 368)
        Me.Warna5.Name = "Warna5"
        Me.Warna5.Size = New System.Drawing.Size(32, 32)
        Me.Warna5.TabIndex = 11
        '
        'Warna6
        '
        Me.Warna6.BackColor = System.Drawing.Color.Cyan
        Me.Warna6.Location = New System.Drawing.Point(617, 368)
        Me.Warna6.Name = "Warna6"
        Me.Warna6.Size = New System.Drawing.Size(32, 32)
        Me.Warna6.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 377)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Warna Tepi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 416)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Warna Isi"
        '
        'ShapeTepi
        '
        Me.ShapeTepi.BackColor = System.Drawing.Color.Black
        Me.ShapeTepi.Location = New System.Drawing.Point(114, 368)
        Me.ShapeTepi.Name = "ShapeTepi"
        Me.ShapeTepi.Size = New System.Drawing.Size(32, 32)
        Me.ShapeTepi.TabIndex = 8
        '
        'ShapeIsian
        '
        Me.ShapeIsian.BackColor = System.Drawing.Color.White
        Me.ShapeIsian.Location = New System.Drawing.Point(114, 406)
        Me.ShapeIsian.Name = "ShapeIsian"
        Me.ShapeIsian.Size = New System.Drawing.Size(32, 32)
        Me.ShapeIsian.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(28, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(621, 308)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Warna7
        '
        Me.Warna7.BackColor = System.Drawing.Color.Black
        Me.Warna7.Location = New System.Drawing.Point(425, 406)
        Me.Warna7.Name = "Warna7"
        Me.Warna7.Size = New System.Drawing.Size(32, 32)
        Me.Warna7.TabIndex = 9
        '
        'Warna8
        '
        Me.Warna8.BackColor = System.Drawing.Color.White
        Me.Warna8.Location = New System.Drawing.Point(463, 406)
        Me.Warna8.Name = "Warna8"
        Me.Warna8.Size = New System.Drawing.Size(32, 32)
        Me.Warna8.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 450)
        Me.Controls.Add(Me.Warna8)
        Me.Controls.Add(Me.Warna7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeIsian)
        Me.Controls.Add(Me.ShapeTepi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Warna6)
        Me.Controls.Add(Me.Warna5)
        Me.Controls.Add(Me.Warna4)
        Me.Controls.Add(Me.Warna3)
        Me.Controls.Add(Me.Warna2)
        Me.Controls.Add(Me.Warna1)
        Me.Controls.Add(Me.BtnBersihkan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBoxUkuran)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBoxMode)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "MyPaint"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CBoxMode As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CBoxUkuran As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnBersihkan As Button
    Friend WithEvents Warna1 As Panel
    Friend WithEvents Warna2 As Panel
    Friend WithEvents Warna3 As Panel
    Friend WithEvents Warna4 As Panel
    Friend WithEvents Warna5 As Panel
    Friend WithEvents Warna6 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ShapeTepi As Panel
    Friend WithEvents ShapeIsian As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Warna7 As Panel
    Friend WithEvents Warna8 As Panel
End Class
