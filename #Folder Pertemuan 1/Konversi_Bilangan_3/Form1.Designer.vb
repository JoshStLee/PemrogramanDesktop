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
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnKonversi = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.txtF = New System.Windows.Forms.TextBox()
        Me.txtR = New System.Windows.Forms.TextBox()
        Me.txtK = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(31, 25)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(84, 15)
        Me.lblInput.TabIndex = 0
        Me.lblInput.Text = "Input (Celcius)"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(121, 22)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 23)
        Me.txtInput.TabIndex = 1
        '
        'btnKonversi
        '
        Me.btnKonversi.Location = New System.Drawing.Point(227, 21)
        Me.btnKonversi.Name = "btnKonversi"
        Me.btnKonversi.Size = New System.Drawing.Size(75, 23)
        Me.btnKonversi.TabIndex = 2
        Me.btnKonversi.Text = "Konversi"
        Me.btnKonversi.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(308, 21)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 3
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'txtF
        '
        Me.txtF.Location = New System.Drawing.Point(31, 100)
        Me.txtF.Name = "txtF"
        Me.txtF.ReadOnly = True
        Me.txtF.Size = New System.Drawing.Size(100, 23)
        Me.txtF.TabIndex = 4
        '
        'txtR
        '
        Me.txtR.Location = New System.Drawing.Point(161, 100)
        Me.txtR.Name = "txtR"
        Me.txtR.ReadOnly = True
        Me.txtR.Size = New System.Drawing.Size(100, 23)
        Me.txtR.TabIndex = 5
        '
        'txtK
        '
        Me.txtK.Location = New System.Drawing.Point(283, 100)
        Me.txtK.Name = "txtK"
        Me.txtK.ReadOnly = True
        Me.txtK.Size = New System.Drawing.Size(100, 23)
        Me.txtK.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(330, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "K"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "°R"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "°F"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 171)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtK)
        Me.Controls.Add(Me.txtR)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnKonversi)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInput As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnKonversi As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents txtF As TextBox
    Friend WithEvents txtR As TextBox
    Friend WithEvents txtK As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
