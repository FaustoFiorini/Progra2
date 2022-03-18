Public Class Form1
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿ESTÁ SEGURO QUE QUIERE SALIR?", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub LIMPIARDATOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARDATOSToolStripMenuItem.Click
        LIMPIAR2()

    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        LIMPIAR1()

    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (posicion <= 7) Then
            Nombre(posicion) = TxtNombre.Text
            SUELDO(posicion) = Val(TxtSueldo.Text)
            CANTIDAD(posicion) = Val(TxtCantidad.Text)
            VENTA1()
            BONO1()
            Mostrar()
            posicion = posicion + 1
        End If

        If (posicion = 7) Then
            MsgBox("VECTORES LLENOS")
        End If
    End Sub
End Class
