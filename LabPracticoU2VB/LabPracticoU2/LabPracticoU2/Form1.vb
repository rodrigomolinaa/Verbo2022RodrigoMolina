Public Class Form1
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim SePresionaOperador As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "9"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "0"
    End Sub

    Private Sub ButtonPunto_Click(sender As Object, e As EventArgs) Handles ButtonPunto.Click
        EvaluaRestriccionesParaConcatenar()
        If InStr(TextBox1.Text, ".", CompareMethod.Text) = 0 Then
            TextBox1.Text &= "."
        End If
    End Sub

    Private Sub ButtonSuma_Click(sender As Object, e As EventArgs) Handles ButtonSuma.Click
        EvaluaYHazOperacion()
        Operacion = "+"
    End Sub

    Private Sub ButtonRest_Click(sender As Object, e As EventArgs) Handles ButtonRest.Click
        EvaluaYHazOperacion()
        Operacion = "-"
    End Sub

    Private Sub ButtonMult_Click(sender As Object, e As EventArgs) Handles ButtonMult.Click
        EvaluaYHazOperacion()
        Operacion = "*"
    End Sub

    Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click
        EvaluaYHazOperacion()
        Operacion = "/"
    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        TextBox1.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Private Sub ButtonIgual_Click(sender As Object, e As EventArgs) Handles ButtonIgual.Click
        EvaluaYHazOperacion()
        Operacion = ""
    End Sub

    Public Sub EvaluaYHazOperacion()
        SePresionaOperador = True
        Valor2 = Val(TextBox1.Text)
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
            TextBox1.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub

    Public Sub EvaluaRestriccionesParaConcatenar()
        If SePresionaOperador = True Then
            TextBox1.Text = ""
            SePresionaOperador = False
        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
    End Sub
End Class