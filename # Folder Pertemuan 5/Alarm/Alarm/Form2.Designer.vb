<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxHour = New System.Windows.Forms.TextBox()
        Me.txtBoxMin = New System.Windows.Forms.TextBox()
        Me.txtBoxSec = New System.Windows.Forms.TextBox()
        Me.BtnAddHour = New System.Windows.Forms.Button()
        Me.BtnSubHour = New System.Windows.Forms.Button()
        Me.BtnSubMin = New System.Windows.Forms.Button()
        Me.BtnAddMin = New System.Windows.Forms.Button()
        Me.BtnMinSec = New System.Windows.Forms.Button()
        Me.BtnAddSec = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.lblTimeNow = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(178, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tambah Alarm Baru"
        '
        'txtBoxHour
        '
        Me.txtBoxHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxHour.Location = New System.Drawing.Point(91, 98)
        Me.txtBoxHour.Multiline = True
        Me.txtBoxHour.Name = "txtBoxHour"
        Me.txtBoxHour.Size = New System.Drawing.Size(50, 50)
        Me.txtBoxHour.TabIndex = 1
        Me.txtBoxHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxMin
        '
        Me.txtBoxMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxMin.Location = New System.Drawing.Point(199, 98)
        Me.txtBoxMin.Multiline = True
        Me.txtBoxMin.Name = "txtBoxMin"
        Me.txtBoxMin.Size = New System.Drawing.Size(50, 50)
        Me.txtBoxMin.TabIndex = 2
        Me.txtBoxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxSec
        '
        Me.txtBoxSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxSec.Location = New System.Drawing.Point(302, 98)
        Me.txtBoxSec.Multiline = True
        Me.txtBoxSec.Name = "txtBoxSec"
        Me.txtBoxSec.Size = New System.Drawing.Size(50, 50)
        Me.txtBoxSec.TabIndex = 3
        Me.txtBoxSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAddHour
        '
        Me.BtnAddHour.Location = New System.Drawing.Point(103, 64)
        Me.BtnAddHour.Name = "BtnAddHour"
        Me.BtnAddHour.Size = New System.Drawing.Size(28, 28)
        Me.BtnAddHour.TabIndex = 4
        Me.BtnAddHour.Text = "+"
        Me.BtnAddHour.UseVisualStyleBackColor = True
        '
        'BtnSubHour
        '
        Me.BtnSubHour.Location = New System.Drawing.Point(103, 154)
        Me.BtnSubHour.Name = "BtnSubHour"
        Me.BtnSubHour.Size = New System.Drawing.Size(28, 28)
        Me.BtnSubHour.TabIndex = 5
        Me.BtnSubHour.Text = "-"
        Me.BtnSubHour.UseVisualStyleBackColor = True
        '
        'BtnSubMin
        '
        Me.BtnSubMin.Location = New System.Drawing.Point(210, 154)
        Me.BtnSubMin.Name = "BtnSubMin"
        Me.BtnSubMin.Size = New System.Drawing.Size(28, 28)
        Me.BtnSubMin.TabIndex = 7
        Me.BtnSubMin.Text = "-"
        Me.BtnSubMin.UseVisualStyleBackColor = True
        '
        'BtnAddMin
        '
        Me.BtnAddMin.Location = New System.Drawing.Point(210, 64)
        Me.BtnAddMin.Name = "BtnAddMin"
        Me.BtnAddMin.Size = New System.Drawing.Size(28, 28)
        Me.BtnAddMin.TabIndex = 6
        Me.BtnAddMin.Text = "+"
        Me.BtnAddMin.UseVisualStyleBackColor = True
        '
        'BtnMinSec
        '
        Me.BtnMinSec.Location = New System.Drawing.Point(313, 154)
        Me.BtnMinSec.Name = "BtnMinSec"
        Me.BtnMinSec.Size = New System.Drawing.Size(28, 28)
        Me.BtnMinSec.TabIndex = 9
        Me.BtnMinSec.Text = "-"
        Me.BtnMinSec.UseVisualStyleBackColor = True
        '
        'BtnAddSec
        '
        Me.BtnAddSec.Location = New System.Drawing.Point(313, 64)
        Me.BtnAddSec.Name = "BtnAddSec"
        Me.BtnAddSec.Size = New System.Drawing.Size(28, 28)
        Me.BtnAddSec.TabIndex = 8
        Me.BtnAddSec.Text = "+"
        Me.BtnAddSec.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Deskripsi"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(127, 246)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(200, 20)
        Me.txtDesc.TabIndex = 11
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.LightCoral
        Me.BtnBatal.Location = New System.Drawing.Point(252, 318)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(75, 23)
        Me.BtnBatal.TabIndex = 12
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.LightGreen
        Me.BtnSimpan.Location = New System.Drawing.Point(127, 318)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpan.TabIndex = 13
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'lblTimeNow
        '
        Me.lblTimeNow.AutoSize = True
        Me.lblTimeNow.Location = New System.Drawing.Point(250, 384)
        Me.lblTimeNow.Name = "lblTimeNow"
        Me.lblTimeNow.Size = New System.Drawing.Size(91, 13)
        Me.lblTimeNow.TabIndex = 14
        Me.lblTimeNow.Text = "Waktu Sekarang:"
        '
        'Timer1
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 431)
        Me.Controls.Add(Me.lblTimeNow)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnMinSec)
        Me.Controls.Add(Me.BtnAddSec)
        Me.Controls.Add(Me.BtnSubMin)
        Me.Controls.Add(Me.BtnAddMin)
        Me.Controls.Add(Me.BtnSubHour)
        Me.Controls.Add(Me.BtnAddHour)
        Me.Controls.Add(Me.txtBoxSec)
        Me.Controls.Add(Me.txtBoxMin)
        Me.Controls.Add(Me.txtBoxHour)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Alarm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxHour As TextBox
    Friend WithEvents txtBoxMin As TextBox
    Friend WithEvents txtBoxSec As TextBox
    Friend WithEvents BtnAddHour As Button
    Friend WithEvents BtnSubHour As Button
    Friend WithEvents BtnSubMin As Button
    Friend WithEvents BtnAddMin As Button
    Friend WithEvents BtnMinSec As Button
    Friend WithEvents BtnAddSec As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents lblTimeNow As Label
    Friend WithEvents Timer1 As Timer
End Class
