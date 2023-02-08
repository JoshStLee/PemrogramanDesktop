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
        Me.lblCelcius = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnKonversi = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCelcius
        '
        Me.lblCelcius.AutoSize = True
        Me.lblCelcius.Location = New System.Drawing.Point(24, 67)
        Me.lblCelcius.Name = "lblCelcius"
        Me.lblCelcius.Size = New System.Drawing.Size(84, 15)
        Me.lblCelcius.TabIndex = 0
        Me.lblCelcius.Text = "Input (Celcius)"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(160, 63)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(205, 23)
        Me.txtInput.TabIndex = 1
        '
        'btnKonversi
        '
        Me.btnKonversi.Location = New System.Drawing.Point(371, 63)
        Me.btnKonversi.Name = "btnKonversi"
        Me.btnKonversi.Size = New System.Drawing.Size(75, 23)
        Me.btnKonversi.TabIndex = 2
        Me.btnKonversi.Text = "Konversi"
        Me.btnKonversi.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(452, 63)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 3
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 161)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnKonversi)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblCelcius)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCelcius As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnKonversi As Button
    Friend WithEvents btnKeluar As Button
End Class
