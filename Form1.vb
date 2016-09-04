Public Class Form1

    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim SePresionaOperador As Boolean


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "5"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "9"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "7"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "1"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "4"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btn8.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "8"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btn6.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "6"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btn0.Click
        EvaluaRestriccionesParaConcatenar()
        TxtResultado.Text &= "0"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles btnpunto.Click

        If InStr(TxtResultado.Text, ".", CompareMethod.Text) = 0 Then
            TxtResultado.Text &= "."
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles ButtonSuma.Click
        EvaluayHazOperacion()
        Operacion = "+"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles ButtonResta.Click
        EvaluayHazOperacion()
        Operacion = "-"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles ButtonMultiplicacion.Click
        EvaluayHazOperacion()
        Operacion = "*"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ButtonDivision.Click
        EvaluayHazOperacion()
        Operacion = "/"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles ButtonIgual.Click

        EvaluayHazOperacion()
        Operacion = ""
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        TxtResultado.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Public Sub EvaluayHazOperacion()
        SePresionaOperador = True
        Valor2 = Val(TxtResultado.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2

            End Select
            TxtResultado.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub

    Public Sub EvaluaRestriccionesParaConcatenar()
        If SePresionaOperador = True Then
            TxtResultado.Text = ""
            SePresionaOperador = False
        ElseIf TxtResultado.Text = "0" Then
            TxtResultado.Text = ""

        End If

    End Sub

End Class
