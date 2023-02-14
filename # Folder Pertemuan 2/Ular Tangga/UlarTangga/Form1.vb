Public Class Form1
    Dim myrandom As Random
    Dim playerpos As Integer
    Dim newX As Double
    Dim newY As Double
    Private Sub BtnMulai_Click(sender As Object, e As EventArgs) Handles BtnMulai.Click
        BtnDadu.Enabled = True
        LabelLokasi.Enabled = True
        LabelTanggaUlar.Visible = False
        Randomize()
        myrandom = New Random()
        playerpos = 1
        newX = 35
        newY = 556
        PBPlayer.Location = New Point(newX, newY)
    End Sub

    Private Sub BtnDadu_Click(sender As Object, e As EventArgs) Handles BtnDadu.Click
        Dim angka As Integer = myrandom.Next(1, 7)
        Dim sisa As Integer
        LabelTanggaUlar.Visible = False
        TextBoxDadu.Text = angka.ToString()

        If playerpos + angka <= 70 Then
            playerpos += angka
            newX += angka * 60
            If newX > 577 Then
                newX = 35
                newY -= 60
            End If
        Else
            playerpos += angka
            sisa = playerpos Mod 70
            playerpos = 70 - sisa
            newY = 196
            newX = 35 + (((playerpos Mod 10) - 1) * 60)
        End If



        Select Case playerpos
            Case 19
                playerpos = 66
                newX = 335
                newY = 196
                LabelTanggaUlar.Visible = True
                LabelTanggaUlar.Text = "Kena Tangga naik ke 66"
            Case 25
                playerpos = 6
                newX = 336
                newY = 556
                LabelTanggaUlar.Visible = True
                LabelTanggaUlar.Text = "Kena Ekor Turun ke 6"
            Case 32
                playerpos = 53
                newX = 155
                newY = 256
                LabelTanggaUlar.Visible = True
                LabelTanggaUlar.Text = "Kena Tangga naik ke 53"
            Case 46
                playerpos = 12
                newX = 95
                newY = 496
                LabelTanggaUlar.Visible = True
                LabelTanggaUlar.Text = "Kena Ekor turun ke 12"
            Case 70
                playerpos = 70
                LabelMenang.Visible = True
                LabelMenang.Text = "Congratulations, you've won!"
                BtnDadu.Enabled = False
        End Select

        LabelLokasi.Text = "Lokasi Sekarang: " & playerpos
        PBPlayer.Location = New Point(newX, newY)
    End Sub
End Class
