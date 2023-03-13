Public Class Form2
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTimeNow.Text = "Waktu Sekarang: " + DateTime.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub BtnAddHour_Click(sender As Object, e As EventArgs) Handles BtnAddHour.Click
        txtBoxHour.Text = txtBoxHour.Text + 1
        If txtBoxHour.Text > 23 Then
            txtBoxHour.Text = 0
        End If
    End Sub

    Private Sub BtnSubHour_Click(sender As Object, e As EventArgs) Handles BtnSubHour.Click
        txtBoxHour.Text = txtBoxHour.Text - 1
        If txtBoxHour.Text < 1 Then
            txtBoxHour.Text = 23
        End If
    End Sub

    Private Sub BtnAddMin_Click(sender As Object, e As EventArgs) Handles BtnAddMin.Click
        txtBoxMin.Text = txtBoxMin.Text + 1
        If txtBoxMin.Text > 59 Then
            txtBoxMin.Text = 0
            txtBoxHour.Text = txtBoxHour.Text + 1
        End If
        If txtBoxHour.Text > 23 Then
            txtBoxHour.Text = 0
        End If
    End Sub

    Private Sub BtnSubMin_Click(sender As Object, e As EventArgs) Handles BtnSubMin.Click
        txtBoxMin.Text = txtBoxMin.Text - 1
        If txtBoxMin.Text < 1 Then
            txtBoxMin.Text = 59
            txtBoxHour.Text = txtBoxHour.Text - 1
        End If
        If txtBoxHour.Text < 1 Then
            txtBoxHour.Text = 23
        End If
    End Sub

    Private Sub BtnAddSec_Click(sender As Object, e As EventArgs) Handles BtnAddSec.Click
        txtBoxSec.Text = txtBoxSec.Text + 1
        If txtBoxSec.Text > 59 Then
            txtBoxSec.Text = 0
            txtBoxMin.Text = txtBoxMin.Text + 1
        End If
        If txtBoxMin.Text > 59 Then
            txtBoxMin.Text = 0
            txtBoxHour.Text = txtBoxHour.Text + 1
        End If
        If txtBoxHour.Text > 23 Then
            txtBoxHour.Text = 0
        End If
    End Sub

    Private Sub BtnMinSec_Click(sender As Object, e As EventArgs) Handles BtnMinSec.Click
        txtBoxSec.Text = txtBoxSec.Text - 1
        If txtBoxSec.Text < 1 Then
            txtBoxSec.Text = 59
            txtBoxMin.Text = txtBoxMin.Text - 1
        End If
        If txtBoxMin.Text < 1 Then
            txtBoxMin.Text = 59
            txtBoxHour.Text = txtBoxHour.Text - 1
        End If
        If txtBoxHour.Text < 1 Then
            txtBoxHour.Text = 23
        End If
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If txtBoxSec.Text < 10 Then
            txtBoxSec.Text = "0" & txtBoxSec.Text
        End If
        If txtBoxMin.Text < 10 Then
            txtBoxMin.Text = "0" & txtBoxMin.Text
        End If
        If txtBoxHour.Text < 10 Then
            txtBoxHour.Text = "0" & txtBoxHour.Text
        End If
        Form1.TambahAlarm(txtBoxHour.Text + ":" + txtBoxMin.Text + ":" + txtBoxSec.Text, txtDesc.Text)
        Me.Close()
    End Sub
End Class