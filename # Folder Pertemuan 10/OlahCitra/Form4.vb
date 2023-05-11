Public Class OpsiWatermark
    Dim input As String = ""
    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles Simpan.Click
        input = txtInput.Text
        If input = "" Then
            MsgBox("try again")
        Else
            frmUtama.BuatWatermark(input)
            Me.Close()
        End If
    End Sub
End Class