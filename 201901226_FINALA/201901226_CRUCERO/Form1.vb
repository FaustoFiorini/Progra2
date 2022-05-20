Imports System.Math
Public Class Form1
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿ESTÁ SEGURO QUE QUIERE SALIR?", vbQuestion + vbYesNo, "Salir") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub ENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENTRADASToolStripMenuItem.Click
        TxtNit.Clear()
        TxtNombre.Clear()
        TxtPersonas.Clear()
        ComboBoxCabina.SelectedIndex = -1
        ComboBoxClase.SelectedIndex = -1

    End Sub

    Private Sub VECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VECTORESToolStripMenuItem.Click
        LIMPIAR1()

    End Sub

    Private Sub OPERARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPERARToolStripMenuItem.Click
        If (Crucero <= 5) Then
            Nombre(Crucero) = TxtNombre.Text
            NIT(Crucero) = Val(TxtNit.Text)
            NoPersonas(Crucero) = Val(TxtPersonas.Text)
            PrecioIndividual(Crucero) = Round(PrimeraClase() + SegundaClase(), 2)
            Total(Crucero) = Round((NoPersonas(Crucero) * PrecioIndividual(Crucero)), 2)
            Crucero = Crucero + 1

        End If
        If (Crucero = 6) Then
            MsgBox("VECTORES LLENOS")
        End If
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        MOSTRAR1()

    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Dim existe As Boolean = False
        I = 0
        While (I <= 6) And Not (existe)
            If (NIT(I) = Val(TxtConsulta.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            MsgBox("REGISTRO ENCONTRADO EXITOSAMENTE")
            TxtNombre.Text = Nombre(I)
            TxtNit.Text = Str(NIT(I))
            TxtPersonas.Text = Str(NoPersonas(I))
            ComboBoxCabina.Text = TipoCabina(I)
            ComboBoxClase.Text = TipoClase(I)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Nombre(I), NIT(I), TipoCabina(I), TipoClase(I), Str(NoPersonas(I)), Str(PrecioIndividual(I)), Str(Total(I)))
            Crucero = I
        Else
            MsgBox("NIT NO ENCONTRADO")
            TxtConsulta.Focus()
        End If
    End Sub
End Class
