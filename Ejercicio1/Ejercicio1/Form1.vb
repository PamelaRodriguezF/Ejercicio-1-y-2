Public Class Form1
    Private Sub CambiarColorFondo(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Select Case sender.Text
            Case "1"
                Me.BackColor = Color.Black
            Case "2"
                Me.BackColor = Color.Yellow
            Case "3"
                Me.BackColor = Color.Blue
            Case "4"
                Me.BackColor = Color.Red
            Case "5"
                Me.BackColor = Color.Green
            Case Else
                Me.BackColor = Color.White
        End Select

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
