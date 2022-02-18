Public Class Form1
    Private Sub BotonLimpiar_Click(sender As Object, e As EventArgs) Handles BotonLimpiar.Click
        LIMPIAR()
    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        If (MsgBox("¿ESTÁ SEGURO QUE QUIERE SALIR?", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub BotonCalcular_Click(sender As Object, e As EventArgs) Handles BotonCalcular.Click
        If (RBotonAlg.Checked) Or (RBotonLona.Checked) Or (RBotonSeda.Checked) Then

            If (RBotonAlg.Checked) Then


                If (IsNumeric(TxtAlgodon.Text) And Val(TxtAlgodon.Text) > 0) Then
                    CantAlgodon = Val(TxtAlgodon.Text)
                Else
                    MsgBox("ERROR, CANTIDAD INVALIDA")
                    TxtAlgodon.Focus()
                    Exit Sub

                End If
            Else
                CantAlgodon = 0
            End If

            If (RBotonLona.Checked) Then


                If (IsNumeric(TxtLona.Text) And Val(TxtLona.Text) > 0) Then
                    CantLona = Val(TxtLona.Text)
                Else
                    MsgBox("ERROR, CANTIDAD INVALIDA")
                    TxtLona.Focus()
                    Exit Sub

                End If
            Else
                CantLona = 0
            End If

            If (RBotonSeda.Checked) Then


                If (IsNumeric(TxtSeda.Text) And Val(TxtSeda.Text) > 0) Then
                    CantSeda = Val(TxtSeda.Text)
                Else
                    MsgBox("ERROR, CANTIDAD INVALIDA")
                    TxtSeda.Focus()
                    Exit Sub

                End If
            Else
                CantSeda = 0
            End If
        Else
            MsgBox("ERROR, NO SELECCIONÓ TAMAÑO O MATERIAL")
            Exit Sub

        End If

        If (RBotonS.Checked) Then
            If (RBotonS.Checked) And (RBotonAlg.Checked) Then
                PCAlg = (CantAlgodon * Palgodon * ydS) + (MOS * CantAlgodon)
                PVAlg = PCAlg + (0.65 * PCAlg)

            ElseIf (RBotonS.Checked) And (RBotonSeda.Checked) Then
                PCSeda = (CantSeda * Pseda * ydS) + (MOS * CantSeda)
                PVseda = PCSeda + (0.65 * PCSeda)

            ElseIf (RBotonS.Checked) And (RBotonLona.Checked) Then
                PClona = (CantLona * Plona * ydS) + (MOS * CantLona)
                PVlona = PClona + (0.65 * PClona)
            Else
                MsgBox("ERROR,NO SELECCIONÓ TIPO DE MATERIAL")
                Exit Sub
            End If
        End If

        If (RBotonM.Checked) Then
            If (RBotonM.Checked) And (RBotonAlg.Checked) Then
                PCAlg = (CantAlgodon * Palgodon * ydM) + (MOM * CantAlgodon)
                PVAlg = PCAlg + (0.65 * PCAlg)
            ElseIf (RBotonM.Checked) And (RBotonSeda.Checked) Then
                PCSeda = (CantSeda * Pseda * ydM) + (MOM * CantSeda)
                PVseda = PCSeda + (0.65 * PCSeda)
            ElseIf (RBotonM.Checked) And (RBotonLona.Checked) Then
                PClona = (CantLona * Plona * ydM) + (MOM * CantLona)
                PVlona = PClona + (0.65 * PClona)
            Else
                MsgBox("ERROR,NO SELECCIONÓ TIPO DE MATERIAL")
                Exit Sub
            End If
        End If

        If (RBotonL.Checked) Then
            If (RBotonL.Checked) And (RBotonAlg.Checked) Then
                PCAlg = (CantAlgodon * Palgodon * ydL) + (MOL * CantAlgodon)
                PVAlg = PCAlg + (0.65 * PCAlg)
            ElseIf (RBotonL.Checked) And (RBotonSeda.Checked) Then
                PCSeda = (CantSeda * Pseda * ydL) + (MOL * CantSeda)
                PVseda = PCSeda + (0.65 * PCSeda)
            ElseIf (RBotonL.Checked) And (RBotonLona.Checked) Then
                PClona = (CantLona * Plona * ydL) + (MOL * CantLona)
                PVlona = PClona + (0.65 * PClona)
            Else
                MsgBox("ERROR,NO SELECCIONÓ TIPO DE MATERIAL")
                Exit Sub
            End If
        End If

        CostoTotal = PVAlg + PVlona + PVseda

        Me.Hide()
        Form2.Show()
        RESULTADOS()

    End Sub
End Class
