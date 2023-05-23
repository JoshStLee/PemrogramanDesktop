Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim modegambar As String
    Dim warnatepi As Color = Color.Black
    Dim warnaisian As Color = Color.White
    Dim tepi As New System.Drawing.Pen(warnatepi, 3)
    Dim isian As New System.Drawing.SolidBrush(warnaisian)
    Dim titik As Point = Nothing
    Dim dipencet As Boolean = False
    Dim bmp As Bitmap
    Dim namafile As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnBersihkan.PerformClick()
        tepi.EndCap = LineCap.Round
    End Sub
    Private Sub CBoxUkuran_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxUkuran.SelectedIndexChanged
        tepi.Width = CBoxUkuran.SelectedItem
    End Sub

    Private Sub CBoxMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxMode.SelectedIndexChanged
        modegambar = CBoxMode.SelectedItem
    End Sub
    Private Sub Warna1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna1.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna1.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna1.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub
    Private Sub Warna2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna2.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna2.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna2.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub
    Private Sub Warna3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna3.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna3.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna3.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub
    Private Sub Warna4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna4.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna4.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna4.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub
    Private Sub Warna5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna5.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna5.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna5.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub
    Private Sub Warna6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna6.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna6.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna6.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub
    Private Sub Warna7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna7.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna7.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna7.BackColor
            ShapeIsian.BackColor = warnaisian
        End If

    End Sub
    Private Sub Warna8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna8.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna8.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna8.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        tepi.Color = warnatepi
        isian.Color = warnaisian
        titik = e.Location
        dipencet = True
    End Sub
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Select Case modegambar
            Case "BrushBebas"
                If dipencet Then
                    Dim pt1, pt2, pt3, pt4 As Point
                    pt1.X = e.X - (tepi.Width)
                    pt2.X = e.X + (tepi.Width)
                    pt1.Y = e.Y
                    pt2.Y = e.Y
                    pt3.X = e.X
                    pt4.X = e.X
                    pt3.Y = e.Y - (tepi.Width)
                    pt4.Y = e.Y + (tepi.Width)
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawLine(tepi, pt1, pt2)
                        g.DrawLine(tepi, pt3, pt4)
                    End Using
                    titik = e.Location
                End If
            Case "HatchForwardDiagonal"
                If dipencet Then
                    Dim hBrush As New HatchBrush(HatchStyle.ForwardDiagonal, warnatepi, warnaisian)
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.FillRectangle(hBrush, e.X, e.Y, tepi.Width, tepi.Width)
                    End Using
                End If
            Case "HatchDottedGrid"
                If dipencet Then
                    Dim hBrush As New HatchBrush(HatchStyle.DottedGrid, warnatepi, warnaisian)
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.FillRectangle(hBrush, e.X, e.Y, tepi.Width, tepi.Width)
                    End Using
                End If
        End Select
        PictureBox1.Invalidate()
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        Select Case modegambar
            Case "Polygon"
                Dim polygonPoints(5) As Point
                Dim x As Integer = e.X - titik.X
                Dim y As Integer = e.Y - titik.Y
                polygonPoints(0) = New Point(2 / 8 * x + titik.X, e.Y)
                polygonPoints(1) = New Point(titik.X, 1 / 3 * y + titik.Y)
                polygonPoints(2) = New Point(4 / 8 * x + titik.X, titik.Y)
                polygonPoints(3) = New Point(e.X, 1 / 3 * y + titik.Y)
                polygonPoints(4) = New Point(6 / 8 * x + titik.X, e.Y)
                polygonPoints(5) = New Point(2 / 8 * x + titik.X, e.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawPolygon(tepi, polygonPoints)
                End Using
            Case "PolygonFill"
                Dim polygonPoints(5) As Point
                Dim x As Integer = e.X - titik.X
                Dim y As Integer = e.Y - titik.Y
                polygonPoints(0) = New Point(2 / 8 * x + titik.X, e.Y)
                polygonPoints(1) = New Point(titik.X, 1 / 3 * y + titik.Y)
                polygonPoints(2) = New Point(4 / 8 * x + titik.X, titik.Y)
                polygonPoints(3) = New Point(e.X, 1 / 3 * y + titik.Y)
                polygonPoints(4) = New Point(6 / 8 * x + titik.X, e.Y)
                polygonPoints(5) = New Point(2 / 8 * x + titik.X, e.Y)
                Dim b = New Drawing2D.HatchBrush(Drawing2D.HatchStyle.BackwardDiagonal, warnatepi, warnaisian)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillPolygon(isian, polygonPoints)
                    g.FillPolygon(b, polygonPoints)
                    g.DrawPolygon(tepi, polygonPoints)
                End Using
            Case "BrushBebas"
                Dim hBrush As New HatchBrush(HatchStyle.OutlinedDiamond, warnatepi, warnaisian)
                Using g As Graphics = PictureBox1.CreateGraphics()
                    g.FillEllipse(hBrush, e.X, e.Y, tepi.Width, tepi.Width)
                End Using
            Case "HatchForwardDiagonal"
                Dim hBrush As New HatchBrush(HatchStyle.ForwardDiagonal, warnatepi, warnaisian)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillRectangle(hBrush, e.X, e.Y, tepi.Width, tepi.Width)
                End Using
            Case "HatchDottedGrid"
                Dim hBrush As New HatchBrush(HatchStyle.DottedGrid, warnatepi, warnaisian)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillRectangle(hBrush, e.X, e.Y, tepi.Width, tepi.Width)
                End Using
        End Select
        PictureBox1.Invalidate()
        dipencet = False
    End Sub
    Private Sub btnBersihkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBersihkan.Click
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using
        PictureBox1.Image = bmp
    End Sub


End Class
