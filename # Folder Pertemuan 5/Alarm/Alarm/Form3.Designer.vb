<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lblAlarm = New System.Windows.Forms.Label()
        Me.lblWaktuAlarm = New System.Windows.Forms.Label()
        Me.lblDeskripsi = New System.Windows.Forms.Label()
        Me.BtnMatikan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAlarm
        '
        Me.lblAlarm.AutoSize = True
        Me.lblAlarm.Location = New System.Drawing.Point(38, 31)
        Me.lblAlarm.Name = "lblAlarm"
        Me.lblAlarm.Size = New System.Drawing.Size(45, 13)
        Me.lblAlarm.TabIndex = 0
        Me.lblAlarm.Text = "Alarmku"
        '
        'lblWaktuAlarm
        '
        Me.lblWaktuAlarm.AutoSize = True
        Me.lblWaktuAlarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaktuAlarm.Location = New System.Drawing.Point(34, 44)
        Me.lblWaktuAlarm.Name = "lblWaktuAlarm"
        Me.lblWaktuAlarm.Size = New System.Drawing.Size(163, 39)
        Me.lblWaktuAlarm.TabIndex = 1
        Me.lblWaktuAlarm.Text = "hh:mm:ss"
        '
        'lblDeskripsi
        '
        Me.lblDeskripsi.AutoSize = True
        Me.lblDeskripsi.Location = New System.Drawing.Point(38, 98)
        Me.lblDeskripsi.Name = "lblDeskripsi"
        Me.lblDeskripsi.Size = New System.Drawing.Size(50, 13)
        Me.lblDeskripsi.TabIndex = 2
        Me.lblDeskripsi.Text = "Deskripsi"
        '
        'BtnMatikan
        '
        Me.BtnMatikan.Location = New System.Drawing.Point(313, 98)
        Me.BtnMatikan.Name = "BtnMatikan"
        Me.BtnMatikan.Size = New System.Drawing.Size(75, 23)
        Me.BtnMatikan.TabIndex = 3
        Me.BtnMatikan.Text = "Matikan"
        Me.BtnMatikan.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 142)
        Me.Controls.Add(Me.BtnMatikan)
        Me.Controls.Add(Me.lblDeskripsi)
        Me.Controls.Add(Me.lblWaktuAlarm)
        Me.Controls.Add(Me.lblAlarm)
        Me.Location = New System.Drawing.Point(900, 560)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAlarm As Label
    Friend WithEvents lblWaktuAlarm As Label
    Friend WithEvents lblDeskripsi As Label
    Friend WithEvents BtnMatikan As Button
End Class
