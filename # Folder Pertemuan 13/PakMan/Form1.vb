Public Class Form1
    'map (peta papan permainan)
    Dim map = {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0},
        {0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0},
        {0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0},
        {0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}}
    'kumpulan variabel
    Dim tsz = 40 'tile size (ukuran grid/tilenya)
    Dim pacx = 1 'pakman itu di petak x mana sekarang
    Dim pacy = 1 ' petak y
    Dim enmx = 9 'musuh itu di petak x berapa
    Dim enmy = 7 ' petak y
    Dim enm1x = 9
    Dim enm1y = 1
    Dim enm2x = 3
    Dim enm2y = 5
    Dim goalx = 1 'goal (pintu keluar pakman di petak x brp
    Dim goaly = 7 'goal di petak y berapa
    Dim bmp As Bitmap
    Dim oldpacx = 0
    Dim oldpacy = 0

    'deklarasi sprite citra yang digunakan
    Dim wall As Image = Image.FromFile("bata.png")
    Dim way As Image = Image.FromFile("rumput.png")
    Dim packiri As Image = Image.FromFile("pakman3.png")
    Dim packanan As Image = Image.FromFile("pakman.png")
    Dim pacatas As Image = Image.FromFile("pakman4.png")
    Dim pacbawah As Image = Image.FromFile("pakman2.png")
    Dim enm As Image = Image.FromFile("hantu3.png")
    Dim enm1 As Image = Image.FromFile("hantu2.png")
    Dim enm2 As Image = Image.FromFile("hantu1.png")
    Dim goal As Image = Image.FromFile("omah.jpg")
    Dim arahpac As Integer = 4
    Dim nyawa As Integer = 3
    Private Sub DrawPac()
        'gambarkan pacman
        Dim g As Graphics = Graphics.FromImage(PictureBox1.Image)
        Select Case arahpac
            Case 0
                g.DrawImage(packanan, pacx * tsz, pacy * tsz, tsz, tsz)
            Case 1
                g.DrawImage(pacbawah, pacx * tsz, pacy * tsz, tsz, tsz)
            Case 2
                g.DrawImage(packiri, pacx * tsz, pacy * tsz, tsz, tsz)
            Case 3
                g.DrawImage(pacatas, pacx * tsz, pacy * tsz, tsz, tsz)
            Case 4
                g.DrawImage(packanan, pacx * tsz, pacy * tsz, tsz, tsz)
        End Select

    End Sub
    Private Sub ResetGame()
        tsz = 40 'tile size (ukuran grid/tilenya)
        pacx = 1 'pakman itu di petak x mana sekarang
        pacy = 1 ' petak y
        enmx = 9 'musuh itu di petak x berapa
        enmy = 7 ' petak y
        enm1x = 9
        enm1y = 1
        enm2x = 3
        enm2y = 5
        goalx = 1 'goal (pintu keluar pakman di petak x brp
        goaly = 7 'goal di petak y berapa
        oldpacx = 0
        oldpacy = 0
        lblNyawa.Text = "Nyawa:" & nyawa
        Redraw()
    End Sub
    Private Sub Redraw()
        Dim g As Graphics = Graphics.FromImage(PictureBox1.Image)
        'gambarkan background (jalan dan tembok)
        For y = 0 To map.GetUpperBound(0) '0 to 8 yaitu tinggi map - 1
            For x = 0 To map.GetUpperBound(1) '0 to 10 yaitu lebar map - 1
                If map(y, x) = 0 Then
                    g.DrawImage(wall, x * tsz, y * tsz, tsz, tsz)
                Else
                    g.DrawImage(way, x * tsz, y * tsz, tsz, tsz)
                End If
            Next
        Next

        DrawPac()
        'gambarkan musuh
        g.DrawImage(enm, enmx * tsz, enmy * tsz, tsz, tsz)
        g.DrawImage(enm1, enm1x * tsz, enm1y * tsz, tsz, tsz)
        g.DrawImage(enm2, enm2x * tsz, enm2y * tsz, tsz, tsz)
        'gambarkan goal
        g.DrawImage(goal, goalx * tsz, goaly * tsz, tsz, tsz)
        'gambarkan goal
        PictureBox1.Refresh()
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim g As Graphics = Graphics.FromImage(PictureBox1.Image)
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Select Case e.KeyCode
            Case Keys.Up
                If map(pacy - 1, pacx) = 1 Then
                    pacy = pacy - 1
                    arahpac = 3
                End If
            Case Keys.Down
                If map(pacy + 1, pacx) = 1 Then
                    pacy = pacy + 1
                    arahpac = 1
                End If
            Case Keys.Right
                If map(pacy, pacx + 1) = 1 Then
                    pacx = pacx + 1
                    arahpac = 0
                End If
            Case Keys.Left
                If map(pacy, pacx - 1) = 1 Then
                    pacx = pacx - 1
                    arahpac = 2
                End If
        End Select
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'sesuaikan dulu ukuran picturebox dan form
        PictureBox1.Width = (map.length / (map.GetUpperBound(0) + 1)) * tsz
        PictureBox1.Height = (map.GetUpperBound(0) + 1) * tsz
        Me.Width = PictureBox1.Width + tsz
        Me.Height = PictureBox1.Height + tsz + 50
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = bmp
        lblNyawa.Text = "Nyawa:" & nyawa
        lblNyawa.Location = New System.Drawing.Point(10, Me.Height - 80)
        Redraw()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'engine untuk musuh
        Dim jarakx, jaraky As Integer
        Dim arah As Integer 'arah musuh, 0 atas, 1 kanan, 2 bawah, 3 kiri
        'cek jarak pakman dg musuh. kalau lebih jauh di sb x, kejar di x dulu
        'kalau lebih dekat di sb y, kejar ke sb y dulu
        jarakx = Math.Abs(pacx - enmx)
        jaraky = Math.Abs(pacy - enmy)
        If jarakx > jaraky Then 'jika lebih jauh jarak kejar di x
            If (pacx - enmx > 0) Then 'jika pakman di kanan
                arah = 1 'arah kanan
            Else 'jika tidak
                arah = 3 'arah kiri
            End If
        End If
        If jarakx < jaraky Then
            If (pacy - enmy > 0) Then 'jika pakman di bawah
                arah = 2 'arah bawah
            Else 'jika tidak
                arah = 0 'arah atas
            End If
        End If
        If (oldpacx = pacx) And (oldpacy = pacy) Then 'jika stop
            arah = Math.Floor(Rnd() * 4)
        End If
        Select Case arah
            Case 0
                If map(enmy - 1, enmx) = 1 Then
                    enmy = enmy - 1
                End If
            Case 2
                If map(enmy + 1, enmx) = 1 Then
                    enmy = enmy + 1
                End If
            Case 1
                If map(enmy, enmx + 1) = 1 Then
                    enmx = enmx + 1
                End If
            Case 3
                If map(enmy, enmx - 1) = 1 Then
                    enmx = enmx - 1
                End If
        End Select
        oldpacx = pacx
        oldpacy = pacy
        Redraw()
        'cek apakah posisi pakman sama dg musuh
        If (pacx = enmx) And (pacy = enmy) Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False

            MsgBox("Pakman Dies!")
            nyawa = nyawa - 1
            ResetGame()
            lblNyawa.Text = nyawa
        End If
        'cek apakah posisi pakman sama dg rumah
        If (pacx = goalx) And (pacy = goaly) Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            MsgBox("Pakman safe at Home!")
            nyawa = 3
            ResetGame()
            lblNyawa.Text = nyawa
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim jarakx, jaraky As Integer
        Dim arah As Integer 'arah musuh, 0 atas, 1 kanan, 2 bawah, 3 kiri
        'cek jarak pakman dg musuh. kalau lebih jauh di sb x, kejar di x dulu
        'kalau lebih dekat di sb y, kejar ke sb y dulu
        jarakx = Math.Abs(pacx - enm1x)
        jaraky = Math.Abs(pacy - enm1y)
        If jarakx > jaraky Then 'jika lebih jauh jarak kejar di x
            If (pacx - enm1x > 0) Then 'jika pakman di kanan
                arah = 1 'arah kanan
            Else 'jika tidak
                arah = 3 'arah kiri
            End If
        End If
        If jarakx < jaraky Then
            If (pacy - enm1y > 0) Then 'jika pakman di bawah
                arah = 2 'arah bawah
            Else 'jika tidak
                arah = 0 'arah atas
            End If
        End If
        If (oldpacx = pacx) And (oldpacy = pacy) Then 'jika stop
            arah = Math.Floor(Rnd() * 4)
        End If
        Select Case arah
            Case 0
                If map(enm1y - 1, enm1x) = 1 Then
                    enm1y = enm1y - 1
                End If
            Case 2
                If map(enm1y + 1, enm1x) = 1 Then
                    enm1y = enm1y + 1
                End If
            Case 1
                If map(enm1y, enm1x + 1) = 1 Then
                    enm1x = enm1x + 1
                End If
            Case 3
                If map(enm1y, enm1x - 1) = 1 Then
                    enm1x = enm1x - 1
                End If
        End Select
        oldpacx = pacx
        oldpacy = pacy
        Redraw()

        'cek apakah posisi pakman sama dg musuh
        If (pacx = enm1x) And (pacy = enm1y) Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            MsgBox("Pakman Dies!")
            ResetGame()
            nyawa = nyawa - 1
            lblNyawa.Text = nyawa
            Redraw()
        End If
        If nyawa = 0 Then
            Timer2.Enabled = False
            Timer1.Enabled = False
            Timer3.Enabled = False
            MsgBox("Game Over!")
            ResetGame()
            nyawa = nyawa - 1
            lblNyawa.Text = "Nyawa:" & nyawa
            Redraw()

        End If
        'cek apakah posisi pakman sama dg rumah
        If (pacx = goalx) And (pacy = goaly) Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            MsgBox("Pakman safe at Home!")
            ResetGame()
            nyawa = 3
            lblNyawa.Text = "Nyawa:" & nyawa
            Redraw()
        End If
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim jarakx, jaraky As Integer
        Dim arah As Integer 'arah musuh, 0 atas, 1 kanan, 2 bawah, 3 kiri
        'cek jarak pakman dg musuh. kalau lebih jauh di sb x, kejar di x dulu
        'kalau lebih dekat di sb y, kejar ke sb y dulu
        jarakx = Math.Abs(pacx - enm2x)
        jaraky = Math.Abs(pacy - enm2y)
        If jarakx > jaraky Then 'jika lebih jauh jarak kejar di x
            If (pacx - enm2x > 0) Then 'jika pakman di kanan
                arah = 1 'arah kanan
            Else 'jika tidak
                arah = 3 'arah kiri
            End If
        End If
        If jarakx < jaraky Then
            If (pacy - enm2y > 0) Then 'jika pakman di bawah
                arah = 2 'arah bawah
            Else 'jika tidak
                arah = 0 'arah atas
            End If
        End If
        If (oldpacx = pacx) And (oldpacy = pacy) Then 'jika stop
            arah = Math.Floor(Rnd() * 4)
        End If
        Select Case arah
            Case 0
                If map(enm2y - 1, enm2x) = 1 Then
                    enm2y = enm2y - 1
                End If
            Case 2
                If map(enm2y + 1, enm2x) = 1 Then
                    enm2y = enm2y + 1
                End If
            Case 1
                If map(enm2y, enm2x + 1) = 1 Then
                    enm2x = enm2x + 1
                End If
            Case 3
                If map(enm2y, enm2x - 1) = 1 Then
                    enm2x = enm2x - 1
                End If
        End Select
        oldpacx = pacx
        oldpacy = pacy
        Redraw()

        'cek apakah posisi pakman sama dg musuh
        If (pacx = enm2x) And (pacy = enm2y) Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            MsgBox("Pakman Dies!")
            ResetGame()
            nyawa = nyawa - 1
            lblNyawa.Text = "Nyawa:" & nyawa
            Redraw()
        End If
        If nyawa = 0 Then
            Timer2.Enabled = False
            Timer1.Enabled = False
            Timer3.Enabled = False
            MsgBox("Game Over!")
            ResetGame()
            nyawa = 3
            lblNyawa.Text = "Nyawa:" & nyawa
            Redraw()

        End If
        'cek apakah posisi pakman sama dg rumah
        If (pacx = goalx) And (pacy = goaly) Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            MsgBox("Pakman safe at Home!")
            ResetGame()
            nyawa = 3
            lblNyawa.Text = "Nyawa:" & nyawa
            Redraw()
        End If
    End Sub
End Class
