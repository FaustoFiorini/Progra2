Public Class Form1
    Private Sub SALIRToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem1.Click
        If (MsgBox("¿ESTÁ SEGURO QUE QUIERE SALIR?", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (posicion < 8) Then
            VENTA(posicion) = Val(TxtNVenta.Text)
            CANTIDAD(posicion) = Val(TxtCantidad.Text)
            Tamaño1()
            TELA1()
            PRECIOCOSTO1()
            PRECIOVENTA1()
            MOSTRAR()
            posicion = posicion + 1
        End If

        If (posicion = 8) Then
            MsgBox("VECTORES LLENOS")
        End If
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        LIMPIAR1()

    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIAR2()

    End Sub
End Class
