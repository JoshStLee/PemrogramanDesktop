Public Class Form1

    Private Sub btnKonversi_Click(sender As Object, e As EventArgs) Handles btnKonversi.Click
        Dim celcius, fahrenheit, reamur, kelvin As Double
        celcius = Val(txtInput.Text)
        fahrenheit = 9 / 5 * celcius + 32
        reamur = 4 / 5 * celcius
        kelvin = celcius + 273

        txtF.Text = CStr(fahrenheit)
        txtR.Text = CStr(reamur)
        txtK.Text = CStr(kelvin)
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class
