Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.alarm, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub BtnMatikan_Click(sender As Object, e As EventArgs) Handles BtnMatikan.Click
        My.Computer.Audio.Stop()
        Me.Close()
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Computer.Audio.Stop()
    End Sub
End Class