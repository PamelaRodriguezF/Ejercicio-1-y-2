Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NuevoValorBoton.Click
        If NuevoValorCampo.Text.Length > 0 And NuevoValorCampo.Text.Length <= 3 Then
            Dim nuevoValor As Integer = Convert.ToInt32(NuevoValorCampo.Text)
            If nuevoValor < 100 Then
                NuevoValorCampo.Text = ""

                ValoresLista.Items.Add(nuevoValor)
            Else
                MsgBox("El valor debe de ser menor a cien")
            End If
        Else
            MsgBox("Ingrese un numero entero, por favor y maximo 3 digitos")
        End If
    End Sub

    Private Sub NuevoValorCampo_TextChanged(sender As Object, e As EventArgs) Handles NuevoValorCampo.TextChanged
        Dim soloDigitos As Regex = New Regex("[^\d]")
        sender.Text = soloDigitos.Replace(sender.Text, "")
    End Sub

    Private Sub PromedioBoton_Click(sender As Object, e As EventArgs) Handles PromedioBoton.Click
        Dim Suma, Cantidad As Integer
        For Each Item In ValoresLista.Items
            Suma += Convert.ToInt32(Item)
            Cantidad += 1
        Next

        PromedioCampo.Text = Suma / Cantidad
    End Sub
End Class
