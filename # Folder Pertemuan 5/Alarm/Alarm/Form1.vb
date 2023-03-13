Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class Form1
    Dim x_count As Integer = 0
    Dim y_count As Integer = 0
    Dim labels As New List(Of String)
    Dim times As New List(Of String)
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblTimeNow.Text = "Waktu Sekarang: " + DateTime.Now.ToString("hh:mm:ss")
        For a As Integer = 0 To labels.Count - 1
            If String.Equals(times(a), DateTime.Now.ToString("hh:mm:ss")) Then
                Dim notif = New Form3
                With notif
                    .lblWaktuAlarm.Text = times(a)
                    .lblDeskripsi.Text = labels(a)
                End With
                notif.Show()
                labels.RemoveAt(a)
                times.RemoveAt(a)
            End If
        Next
    End Sub

    Private Sub TambahkanAlarmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahkanAlarmToolStripMenuItem.Click
        Dim alarm = New Form2
        With alarm
            .txtBoxHour.Text = DateTime.Now.ToString("hh")
            .txtBoxMin.Text = DateTime.Now.ToString("mm")
            .txtBoxSec.Text = DateTime.Now.ToString("ss")
        End With
        alarm.Timer1.Start()
        alarm.Show()
    End Sub

    Public Sub TambahAlarm(time As String, desc As String)
        labels.Add(desc)
        times.Add(time)
        Dim color As New Color
        color = Color.Violet
        Dim lblTime As New Label
        With lblTime
            .Location = New System.Drawing.Point(23, 20)
            .Size = New System.Drawing.Size(51, 18)
            .Text = time
        End With

        Dim lblDesc As New Label
        With lblDesc
            .Location = New System.Drawing.Point(23, 54)
            .Text = desc
        End With
        If x_count > 5 Then
            x_count = 0
            y_count += 1
        End If
        Dim pnl As New Panel
        With pnl
            .Location = New System.Drawing.Point(x_count * 186 + 15, y_count * 106 + 60)
            .Size = New System.Drawing.Size(180, 100)
            .BackColor = color
            .Controls.Add(lblDesc)
            .Controls.Add(lblTime)
        End With
        Panel1.Controls.Add(pnl)
        x_count += 1
    End Sub

    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("D:\save.txt", True)
        For Each alarm As String In times
            file.WriteLine(alarm)
            file.WriteLine(labels(times.IndexOf(alarm)))
        Next
        file.Close()
        MsgBox("Alarm di save")
    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        Dim line, time, desc As String
        Using reader As New StreamReader("D:\save.txt")
            Do
                line = reader.ReadLine
                If (line) Is Nothing Then Exit Do
                time = line
                desc = reader.ReadLine()
                TambahAlarm(time, desc)
            Loop
        End Using
        MsgBox("Alarm di load")
    End Sub
End Class
