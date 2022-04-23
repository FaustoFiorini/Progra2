Imports System.Math
Public Class Form1
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿ESTÁ SEGURO QUE QUIERE SALIR?", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (Auto <= 6) Then
            KMI(Auto) = Val(TxtKMinicial.Text)
            KMF(Auto) = Val(TxtKMFinal.Text)
            Placa(Auto) = Val(TxtNoPlaca.Text)
            CobroBase(Auto) = BASE()
            Kilometraje(Auto) = Round((KMF(Auto) - KMI(Auto)), 2)

            If (Kilometraje(Auto) > 0 And Kilometraje(Auto) < 50) Then
                CobroporKM(Auto) = Round((Kilometraje(Auto) * 3), 2)
            ElseIf (Kilometraje(Auto) > 50 And Kilometraje(Auto) <= 70) Then
                CobroporKM(Auto) = Round((Kilometraje(Auto) * 4), 2)
            ElseIf (Kilometraje(Auto) > 70) Then
                CobroporKM(Auto) = Round((Kilometraje(Auto) * 5), 2)
            Else
                MsgBox("REVISE EL KILOMETRAJE")
                TxtKMinicial.Focus()
            End If
            PagoFinal(Auto) = Round((CobroBase(Auto) + CobroporKM(Auto)), 2)

            Auto = Auto + 1

            End If
            If (Auto = 7) Then
            MsgBox("VECTORES LLENOS")
        End If

    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Dim existe As Boolean = False
        I = 0
        While (I <= 6) And Not (existe)
            If (Placa(I) = Val(TxtConsultaPlaca.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            MsgBox("REGISTRO ENCONTRADO EXITOSAMENTE")
            TxtNoPlaca.Text = Str(Placa(I))
            TxtKMinicial.Text = Str(KMI(I))
            TxtKMFinal.Text = Str(KMF(I))
            ComboBoxTipoCarro.Text = Carro(I)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(Placa(I)), Carro(I), Str(CobroBase(I)), Str(KMI(I)), Str(KMF(I)), Str(CobroporKM(I)), Str(PagoFinal(I)))
            Auto = I
        Else
            MsgBox("PLACA NO ENCONTRADA")
            TxtConsultaPlaca.Focus()
        End If

    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click
        KMI(Auto) = Val(TxtKMinicial.Text)
        KMF(Auto) = Val(TxtKMFinal.Text)
        Placa(Auto) = Val(TxtNoPlaca.Text)
        CobroBase(Auto) = BASE()
        Kilometraje(Auto) = Round((KMF(Auto) - KMI(Auto)), 2)

        If (Kilometraje(Auto) > 0 And Kilometraje(Auto) <= 50) Then
            CobroporKM(Auto) = Round((Kilometraje(Auto) * 3), 2)
        ElseIf (Kilometraje(Auto) > 50 And Kilometraje(Auto) <= 70) Then
            CobroporKM(Auto) = Round((Kilometraje(Auto) * 4), 2)
        ElseIf (Kilometraje(Auto) > 70) Then
            CobroporKM(Auto) = Round((Kilometraje(Auto) * 5), 2)
        Else
            MsgBox("REVISE EL KILOMETRAJE")
            TxtKMinicial.Focus()
        End If
        PagoFinal(Auto) = Round((CobroBase(Auto) + CobroporKM(Auto)), 2)
        MsgBox("REGISTRO ACTUALIZADO CON ÉXITO")
        Auto = 7
    End Sub
    Private Sub LIMPIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem.Click
        LIMPIAR1()

    End Sub
    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        MOSTRAR1()

    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        Carro(Auto) = Nothing
        KMI(Auto) = Nothing
        KMF(Auto) = Nothing
        Placa(Auto) = Nothing
        CobroBase(Auto) = Nothing
        PagoFinal(Auto) = Nothing
        CobroporKM(Auto) = Nothing
        Kilometraje(Auto) = Nothing

        For I = Auto To 5
            Carro(I) = Carro(I + 1)
            KMI(I) = KMI(I + 1)
            KMF(I) = KMF(I + 1)
            Placa(I) = Placa(I + 1)
            CobroBase(I) = CobroBase(I + 1)
            PagoFinal(I) = PagoFinal(I + 1)
            CobroporKM(I) = CobroporKM(I + 1)
            Kilometraje(I) = Kilometraje(I + 1)
        Next I
        MsgBox("Registro Eliminado exitosamente")
        Carro(I) = Nothing
        KMI(I) = Nothing
        KMF(I) = Nothing
        Placa(I) = Nothing
        CobroBase(I) = Nothing
        PagoFinal(I) = Nothing
        CobroporKM(I) = Nothing
        Kilometraje(I) = Nothing
        Auto = I
        TxtNoPlaca.Clear()
        TxtKMinicial.Clear()
        TxtKMFinal.Clear()
        ComboBoxTipoCarro.SelectedIndex = -1
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        TxtNoPlaca.Clear()
        TxtKMinicial.Clear()
        TxtKMFinal.Clear()
        ComboBoxTipoCarro.SelectedIndex = -1

    End Sub
End Class
