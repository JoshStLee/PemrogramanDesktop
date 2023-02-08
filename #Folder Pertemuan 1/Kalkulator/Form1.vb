Imports System.Reflection.Metadata

Public Class Form1
    Private valHolder1 As Double
    Private valHolder2 As Double
    Private tmpValue As Double
    Private tmpValue2 As Double
    Private hasDecimal As Double
    Private inputStatus As Boolean = True
    Private clearText As Boolean
    Private calcFunc As String

    Private Sub cmd1_Click(sender As Object, e As EventArgs) Handles cmd1.Click
        If inputStatus = False Then
            TxtInput.Text &= cmd1.Text
        Else
            TxtInput.Text = cmd1.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd2_Click(sender As Object, e As EventArgs) Handles cmd2.Click
        If inputStatus = False Then
            TxtInput.Text &= cmd2.Text
        Else
            TxtInput.Text = cmd2.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd3_Click(sender As Object, e As EventArgs) Handles cmd3.Click
        If inputStatus = False Then
            TxtInput.Text &= cmd3.Text
        Else
            TxtInput.Text = cmd3.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd4_Click(sender As Object, e As EventArgs) Handles cmd4.Click
        If inputStatus = False Then
            TxtInput.Text += cmd4.Text
        Else
            TxtInput.Text = cmd4.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd5_Click(sender As Object, e As EventArgs) Handles cmd5.Click
        If inputStatus = False Then
            TxtInput.Text &= cmd5.Text
        Else
            TxtInput.Text = cmd5.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd6_Click(sender As Object, e As EventArgs) Handles cmd6.Click
        If inputStatus = False Then
            TxtInput.Text += cmd6.Text
        Else
            TxtInput.Text = cmd6.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd7_Click(sender As Object, e As EventArgs) Handles cmd7.Click
        If inputStatus = False Then
            TxtInput.Text &= cmd7.Text
        Else
            TxtInput.Text = cmd7.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd8_Click(sender As Object, e As EventArgs) Handles cmd8.Click
        If inputStatus = False Then
            TxtInput.Text &= cmd8.Text
        Else
            TxtInput.Text = cmd8.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd9_Click(sender As Object, e As EventArgs) Handles cmd9.Click
        If inputStatus = False Then
            TxtInput.Text &= cmd9.Text
        Else
            TxtInput.Text = cmd9.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd0_Click(sender As Object, e As EventArgs) Handles cmd0.Click
        If inputStatus = False Then
            If TxtInput.Text.Length >= 1 Then
                TxtInput.Text &= cmd0.Text
            End If
        End If
    End Sub

    Private Sub cmdDecimal_Click(sender As Object, e As EventArgs) Handles cmdDecimal.Click
        If inputStatus Then
            If Not hasDecimal Then
                If TxtInput.Text.Length > 1 Then
                    If Not TxtInput.Text = "0" Then
                        TxtInput.Text &= cmdDecimal.Text
                        hasDecimal = True
                    End If
                Else
                    TxtInput.Text = "0."
                End If
            End If
        End If
    End Sub

    Private Sub CalculateTotals()
        valHolder2 = CType(TxtInput.Text, Double)
        Select Case calcFunc
            Case "add"
                valHolder1 = valHolder1 + valHolder2
            Case "subtract"
                valHolder1 = valHolder1 - valHolder2
            Case "divide"
                valHolder1 = valHolder1 / valHolder2
            Case "multiply"
                valHolder1 = valHolder1 * valHolder2
            Case "powerOf"
                valHolder1 = System.Math.Pow(valHolder1, valHolder2)
        End Select
        TxtInput.Text = CType(valHolder1, String)
        inputStatus = True
    End Sub

    Private Sub cmdC_Click(sender As Object, e As EventArgs) Handles cmdC.Click
        TxtInput.Text = String.Empty
        valHolder1 = 0
        valHolder2 = 0
        calcFunc = String.Empty
        hasDecimal = False
    End Sub

    Private Sub cmdCE_Click(sender As Object, e As EventArgs) Handles cmdCE.Click
        TxtInput.Text = String.Empty
        hasDecimal = False
    End Sub

    Private Sub cmdBackspace_Click(sender As Object, e As EventArgs) Handles cmdBackspace.Click
        Dim str As String
        Dim loc As Integer
        If TxtInput.Text.Length > 0 Then
            str = TxtInput.Text.Chars(TxtInput.Text.Length - 1)
            If str = "." Then
                hasDecimal = False
            End If
            loc = TxtInput.Text.Length
            TxtInput.Text = TxtInput.Text.Remove(loc - 1, 1)
        End If
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        If TxtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CDbl(TxtInput.Text)
                TxtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "add"
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdSubtract_Click(sender As Object, e As EventArgs) Handles cmdSubtract.Click
        If TxtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CType(TxtInput.Text, Double)
                TxtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "subtract"
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        If TxtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CDbl(TxtInput.Text)
                TxtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "multiply"
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdDivision_Click(sender As Object, e As EventArgs) Handles cmdDivision.Click
        If TxtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CType(TxtInput.Text, Double)
                TxtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "divide"
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdSqrt_Click(sender As Object, e As EventArgs) Handles cmdSqrt.Click
        If TxtInput.Text.Length <> 0 Then
            tmpValue = CType(TxtInput.Text, Double)
            tmpValue = System.Math.Sqrt(tmpValue)
            TxtInput.Text = CType(tmpValue, String)
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdPowerOf_Click(sender As Object, e As EventArgs) Handles cmdPowerOf.Click
        If TxtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CType(TxtInput.Text, Double)
                TxtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "powerOf"
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdEqual_Click(sender As Object, e As EventArgs) Handles cmdEqual.Click
        If TxtInput.Text.Length <> 0 AndAlso valHolder1 <> 0 Then
            CalculateTotals()
            calcFunc = ""
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdSign_Click(sender As Object, e As EventArgs) Handles cmdSign.Click
        If inputStatus = False Then
            If TxtInput.Text.Length > 0 Then
                valHolder1 = -1 * CDbl(TxtInput.Text)
                TxtInput.Text = CStr(valHolder1)
            End If
        End If
    End Sub

    Private Sub cmdInverse_Click(sender As Object, e As EventArgs) Handles cmdInverse.Click
        If TxtInput.Text.Length <> 0 Then
            tmpValue = CDbl(TxtInput.Text)
            tmpValue = 1 / tmpValue
            TxtInput.Text = CStr(tmpValue)
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdfacto_Click(sender As Object, e As EventArgs) Handles cmdfacto.Click
        If TxtInput.Text.Length <> 0 Then
            tmpValue = CInt(TxtInput.Text)
            tmpValue2 = 1
            For i = 1 To tmpValue
                tmpValue2 = tmpValue2 * i
            Next
            TxtInput.Text = CStr(tmpValue2)
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdCbrt_Click(sender As Object, e As EventArgs) Handles cmdCbrt.Click
        If TxtInput.Text.Length <> 0 Then
            tmpValue = CType(TxtInput.Text, Double)
            tmpValue = System.Math.Cbrt(tmpValue)
            TxtInput.Text = CType(tmpValue, String)
            hasDecimal = False
        End If
    End Sub
End Class
