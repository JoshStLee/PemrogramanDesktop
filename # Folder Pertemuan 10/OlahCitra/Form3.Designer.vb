<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpsiBorder
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbWarna = New System.Windows.Forms.ComboBox()
        Me.Batal = New System.Windows.Forms.Button()
        Me.Simpan = New System.Windows.Forms.Button()
        Me.cbTebal = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Warna"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tebal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(241, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "px"
        '
        'cbWarna
        '
        Me.cbWarna.FormattingEnabled = True
        Me.cbWarna.Items.AddRange(New Object() {"Merah", "Hijau", "Biru"})
        Me.cbWarna.Location = New System.Drawing.Point(149, 44)
        Me.cbWarna.Name = "cbWarna"
        Me.cbWarna.Size = New System.Drawing.Size(85, 21)
        Me.cbWarna.TabIndex = 4
        '
        'Batal
        '
        Me.Batal.Location = New System.Drawing.Point(112, 154)
        Me.Batal.Name = "Batal"
        Me.Batal.Size = New System.Drawing.Size(75, 23)
        Me.Batal.TabIndex = 5
        Me.Batal.Text = "Batal"
        Me.Batal.UseVisualStyleBackColor = True
        '
        'Simpan
        '
        Me.Simpan.Location = New System.Drawing.Point(112, 125)
        Me.Simpan.Name = "Simpan"
        Me.Simpan.Size = New System.Drawing.Size(75, 23)
        Me.Simpan.TabIndex = 6
        Me.Simpan.Text = "Ok"
        Me.Simpan.UseVisualStyleBackColor = True
        '
        'cbTebal
        '
        Me.cbTebal.FormattingEnabled = True
        Me.cbTebal.Items.AddRange(New Object() {"2", "4", "6", "8", "10"})
        Me.cbTebal.Location = New System.Drawing.Point(149, 83)
        Me.cbTebal.Name = "cbTebal"
        Me.cbTebal.Size = New System.Drawing.Size(85, 21)
        Me.cbTebal.TabIndex = 7
        '
        'OpsiBorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 195)
        Me.Controls.Add(Me.cbTebal)
        Me.Controls.Add(Me.Simpan)
        Me.Controls.Add(Me.Batal)
        Me.Controls.Add(Me.cbWarna)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OpsiBorder"
        Me.Text = "Opsi Border"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbWarna As ComboBox
    Friend WithEvents Batal As Button
    Friend WithEvents Simpan As Button
    Friend WithEvents cbTebal As ComboBox
End Class
