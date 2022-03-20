Public Class Form1
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿ESTÁ SEGURO QUE QUIERE SALIR?", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub LIMPIARLISTBOXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARLISTBOXToolStripMenuItem.Click
        LIMPIAR1()
    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        LIMPIAR2()
    End Sub

    Private Sub ACEPTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACEPTARToolStripMenuItem.Click

        If (Posicion <= 6) Then
            CASA(Posicion, 0) = TxtNombre.Text
            CASA(Posicion, 1) = Val(TxtCUI.Text)
            CASA(Posicion, 2) = TxtDirección.Text
            CASA(Posicion, 3) = Val(TxtCosto.Text)
            PAGOPARCIA1()
            DESCUENTO()
            TOTAL()
            MOSTRAR()

            Posicion = Posicion + 1

        End If
        If (Posicion = 7) Then
            MsgBox("MATRIZ LLENA")
        End If


    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIAR3()

    End Sub
End Class
