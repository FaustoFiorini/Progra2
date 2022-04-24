Imports System.Math
Public Class Form1
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿ESTÁ SEGURO QUE QUIERE SALIR?", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (Turismo <= 6) Then
            Identificacion(Turismo) = Val(TxtIdentificación.Text)
            Dias(Turismo) = Val(TxtDías.Text)
            Personas(Turismo) = Val(TxtDías.Text)
            PagoFinal(Turismo) = TOTAL()

            Turismo = Turismo + 1
        End If
        If (Turismo = 7) Then
            MsgBox("VECTORES LLENOS")
        End If
    End Sub

    Private Sub BUSCARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BUSCARToolStripMenuItem.Click
        Dim existe As Boolean = False
        I = 0
        While (I <= 6) And Not (existe)
            If (Identificacion(I) = Val(TxtConsulta.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            MsgBox("REGISTRO ENCONTRADO EXITOSAMENTE")
            TxtIdentificación.Text = Str(Identificacion(I))
            TxtDías.Text = Str(Dias(I))
            TxtPersonas.Text = Str(Personas(I))
            ComboBoxViajes.Text = TipoViaje(I)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(Identificacion(I)), Str(Dias(I)), Str(Personas(I)), TipoViaje(I), Str(PagoFinal(I)))
            Turismo = I
        Else
            MsgBox("NO. DE IDENTIFICACIÓN NO ENCONTRADO")
            TxtConsulta.Focus()
        End If
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        Identificacion(Turismo) = Nothing
        Dias(Turismo) = Nothing
        Personas(Turismo) = Nothing
        TipoViaje(Turismo) = Nothing
        PagoFinal(Turismo) = Nothing


        For I = Turismo To 5
            Identificacion(I) = Identificacion(I + 1)
            Dias(I) = Dias(I + 1)
            Personas(I) = Personas(I + 1)
            TipoViaje(I) = TipoViaje(I + 1)
            PagoFinal(I) = PagoFinal(I + 1)

        Next I
        MsgBox("REGISTRO ELIMINADO EXITOSAMENTE")

        Identificacion(I) = Nothing
        Dias(I) = Nothing
        Personas(I) = Nothing
        TipoViaje(I) = Nothing
        PagoFinal(I) = Nothing
        Turismo = I
        TxtIdentificación.Clear()
        TxtDías.Clear()
        TxtPersonas.Clear()
        ComboBoxViajes.SelectedIndex = -1
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        LIMPIAR1()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        TxtIdentificación.Clear()
        TxtDías.Clear()
        TxtPersonas.Clear()
        ComboBoxViajes.SelectedIndex = -1
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        MOSTRAR1()

    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click
        Identificacion(Turismo) = Val(TxtIdentificación.Text)
        Dias(Turismo) = Val(TxtDías.Text)
        Personas(Turismo) = Val(TxtDías.Text)
        PagoFinal(Turismo) = TOTAL()
        MsgBox("REGISTRO ACTUALIZADO CON ÉXITO")
        Turismo = 7
    End Sub

End Class
