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
        Me.btnKonversi = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblCelcius = New System.Windows.Forms.Label()
        Me.lblF = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblR = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblK = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnKonversi
        '
        Me.btnKonversi.Location = New System.Drawing.Point(238, 47)
        Me.btnKonversi.Name = "btnKonversi"
        Me.btnKonversi.Size = New System.Drawing.Size(75, 23)
        Me.btnKonversi.TabIndex = 0
        Me.btnKonversi.Text = "Konversi"
        Me.btnKonversi.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(319, 47)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 1
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(122, 48)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 23)
        Me.txtInput.TabIndex = 2
        '
        'lblCelcius
        '
        Me.lblCelcius.AutoSize = True
        Me.lblCelcius.Location = New System.Drawing.Point(23, 51)
        Me.lblCelcius.Name = "lblCelcius"
        Me.lblCelcius.Size = New System.Drawing.Size(84, 15)
        Me.lblCelcius.TabIndex = 3
        Me.lblCelcius.Text = "Input (Celcius)"
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.Location = New System.Drawing.Point(23, 95)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(63, 15)
        Me.lblF.TabIndex = 4
        Me.lblF.Text = "Fahrenheit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "° F"
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Location = New System.Drawing.Point(181, 95)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(48, 15)
        Me.lblR.TabIndex = 6
        Me.lblR.Text = "Reamur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "° R"
        '
        'lblK
        '
        Me.lblK.AutoSize = True
        Me.lblK.Location = New System.Drawing.Point(319, 95)
        Me.lblK.Name = "lblK"
        Me.lblK.Size = New System.Drawing.Size(39, 15)
        Me.lblK.TabIndex = 8
        Me.lblK.Text = "Kelvin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(366, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "K"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 136)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblK)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblF)
        Me.Controls.Add(Me.lblCelcius)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnKonversi)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnKonversi As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblCelcius As Label
    Friend WithEvents lblF As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblR As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblK As Label
    Friend WithEvents Label6 As Label
End Class
