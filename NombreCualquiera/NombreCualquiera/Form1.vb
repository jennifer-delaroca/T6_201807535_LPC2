Public Class Form1
    Dim Numero1 As Integer = 0
    Dim Numero2 As Integer = 0
    Dim Resultado As Integer = 0
    Private Sub num_menos1_Click(sender As Object, e As EventArgs) Handles num_menos1.Click
        Numero1 = Numero1 - 1
        num1.Text = Numero1

    End Sub

    Private Sub num_mas1_Click(sender As Object, e As EventArgs) Handles num_mas1.Click
        Numero1 = Numero1 + 1
        num1.Text = Numero1
    End Sub

    Private Sub num_menos2_Click(sender As Object, e As EventArgs) Handles num_menos2.Click
        Numero2 = Numero2 - 1
        num2.Text = Numero2
    End Sub

    Private Sub num_mas2_Click(sender As Object, e As EventArgs) Handles num_mas2.Click
        Numero2 = Numero2 + 1
        num2.Text = Numero2
    End Sub

    Private Sub Sumar_Click(sender As Object, e As EventArgs) Handles Sumar.Click
        Resultado = Numero1 + Numero2
        Respuesta.Text = Resultado
    End Sub

    Private Sub Restar_Click(sender As Object, e As EventArgs) Handles Restar.Click
        Resultado = Numero1 - Numero2
        Respuesta.Text = Resultado
    End Sub

    Private Sub Multiplicar_Click(sender As Object, e As EventArgs) Handles Multiplicar.Click
        Resultado = Numero1 * Numero2
        Respuesta.Text = Resultado
    End Sub

    Private Sub Dividir_Click(sender As Object, e As EventArgs) Handles Dividir.Click
        Dim Division As Double = Numero1 / Numero2
        Respuesta.Text = Division
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Numero1 = 0
        Numero2 = 0
        Resultado = 0
        Respuesta.Text = Resultado
        num1.Text = Numero1
        num2.Text = Numero2
    End Sub
End Class
