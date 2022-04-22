Imports System.Math
Public Class Form1
    Private Sub SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SToolStripMenuItem.Click
        If (MsgBox("¿ESTÁ SEGURO QUE QUIERE SALIR?", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (Huesped <= 6) Then
            Nombre(Huesped) = TextNombre.Text
            Nit(Huesped) = Val(TextNit.Text)
            Impuesto(Huesped) = Val(TextImpuesto.Text)
            Dias(Huesped) = (TextDías.Text)
            Select Case (ComboBox1.SelectedIndex)
                Case 0
                    Habitacion(Huesped) = ComboBox1.Text
                    TotParcial(Huesped) = Str(Round(Sencilla * Dias(Huesped), 2))
                Case 1
                    Habitacion(Huesped) = ComboBox1.Text
                    TotParcial(Huesped) = Str(Round(Doble * Dias(Huesped), 2))
                Case 2
                    Habitacion(Huesped) = ComboBox1.Text
                    TotParcial(Huesped) = Str(Round(Cabaña * Dias(Huesped), 2))

            End Select

            Desc(Huesped) = Descuento1()
            TotFinal(Huesped) = TOTAL1()



        End If
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        MOSTRAR1()

    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        CONSULTAR1()
    End Sub
End Class
