Public Class Form1
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿ESTÁ SEGURO QUE QUIERE SALIR?", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (posicion <= 5) Then
            Nombre(posicion) = TxtNombre.Text
            NIT(posicion) = Val(TxtNIT.Text)
            Días(posicion) = Val(TxtNoDias.Text)
            Honorarios(posicion) = Val(InputBox("INGRESE HONORARIOS MÉDICOS"))
            SubTot()
            Descuento(posicion) = Calculardescuentorecargo()
            Total(posicion) = Tot()
            Mostrar()
            posicion = posicion + 1
        End If

        If (posicion = 6) Then
            MsgBox("VECTORES LLENOS")
        End If
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        LIMPIAR1()

    End Sub

    Private Sub LIMPIARDATOSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LIMPIARDATOSToolStripMenuItem1.Click
        LIMPIAR2()

    End Sub


End Class
