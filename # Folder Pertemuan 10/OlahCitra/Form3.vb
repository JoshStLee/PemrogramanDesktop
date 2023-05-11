Public Class OpsiBorder
    Dim warna As String = ""
    Dim tebal As Integer = 0
    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles Simpan.Click
        warna = cbWarna.Text
        tebal = cbTebal.Text
        frmUtama.BuatBorder(warna, tebal)
        Me.Close()
    End Sub

    Private Sub Batal_Click(sender As Object, e As EventArgs) Handles Batal.Click
        Me.Close()
    End Sub
End Class