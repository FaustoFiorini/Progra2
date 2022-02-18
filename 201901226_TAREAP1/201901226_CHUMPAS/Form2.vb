Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        If (MsgBox("¿ESTÁ SEGURO QUE QUIERE SALIR?", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub BotonRegresar_Click(sender As Object, e As EventArgs) Handles BotonRegresar.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class