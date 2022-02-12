Public Class Form2
    
    Private Sub TxtComisionC_TextChanged(sender As Object, e As EventArgs) Handles TxtComisionC.TextChanged

    End Sub


    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        If (MsgBox("¿ESTÁ SEGURO QUE QUIERE SALIR?", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub BotonRegresar_Click(sender As Object, e As EventArgs) Handles BotonRegresar.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class