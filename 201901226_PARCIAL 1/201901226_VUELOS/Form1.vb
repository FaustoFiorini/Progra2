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

        If (CheckCosta.Checked) Or (CheckIzabal.Checked) Or (CheckPeten.Checked) Then

            If (CheckCosta.Checked) Then


                If (IsNumeric(TxtCosta.Text) And Val(TxtCosta.Text) > 0) Then
                    CantCosta = Val(TxtCosta.Text)
                Else
                    MsgBox("ERROR, CANTIDAD INVÁLIDA")
                    TxtCosta.Focus()
                    Exit Sub

                End If
            Else
                CantCosta = 0
            End If


            If (CheckPeten.Checked) Then
                If (IsNumeric(TxtPeten.Text) And Val(TxtPeten.Text) > 0) Then
                    CantPeten = Val(TxtPeten.Text)
                Else
                    MsgBox("ERROR, CANTIDAD INVÁLIDA")
                    TxtPeten.Focus()
                    Exit Sub
                End If
            Else
                CantPeten = 0

            End If

            If (CheckIzabal.Checked) Then
                If (IsNumeric(TxtIzabal.Text) And Val(TxtIzabal.Text) > 0) Then
                    CantIzabal = Val(TxtIzabal.Text)
                Else
                    MsgBox("ERROR, CANTIDAD INVÁLIDA")
                    TxtIzabal.Focus()
                    Exit Sub
                End If
            Else
                CantIzabal = 0

            End If


        Else
            MsgBox("ERROR, NO SELECCIONÓ SERVICIO")
            Exit Sub
        End If

        If (RBotonA.Checked) Then

            If (RBotonA.Checked) And (CheckCosta.Checked) Then
                Precio = CantCosta * PrecioACosta

            ElseIf (RBotonA.Checked) And (CheckIzabal.Checked) Then
                Precio = CantIzabal * PrecioAIz

            ElseIf (RBotonA.Checked) And (CheckPeten.Checked) Then
                Precio = CantPeten * PrecioAPeten

            Else

                MsgBox("ERROR, NO SELCCIONÓ SERVICIO")
                Exit Sub

            End If

        End If

        If (RBotonH.Checked) Then

            If (RBotonH.Checked) And (CheckCosta.Checked) Then
                Precio = CantCosta * PrecioHCosta

            ElseIf (RBotonH.Checked) And (CheckIzabal.Checked) Then
                Precio = CantIzabal * PrecioHIz

            ElseIf (RBotonH.Checked) And (CheckPeten.Checked) Then
                Precio = CantPeten * PrecioHPeten

            Else

                MsgBox("ERROR, NO SELCCIONÓ SERVICIO")
                Exit Sub

            End If

        End If

        If (RBotonJet.Checked) Then

            If (RBotonJet.Checked) And (CheckCosta.Checked) Then
                Precio = CantCosta * PrecioJCosta

            ElseIf (RBotonJet.Checked) And (CheckIzabal.Checked) Then
                Precio = CantIzabal * PrecioJIz

            ElseIf (RBotonJet.Checked) And (CheckPeten.Checked) Then
                Precio = CantPeten * PrecioJPeten
            Else

                MsgBox("ERROR, NO SELCCIONÓ SERVICIO")
                Exit Sub

            End If


        End If

        If (RBotonJet.Checked) And (CheckPeten.Checked) And (CheckIzabal.Checked) Then
            Precio = (CantPeten * PrecioJPeten) + (CantIzabal * PrecioJIz)
            Desc1 = Precio - (0.02 * Precio)
        End If

        If (RBotonA.Checked) And (CheckIzabal.Checked) And (CheckPeten.Checked) And (CheckCosta.Checked) Then
            Precio = (CantIzabal * PrecioAIz) + (CantCosta * PrecioACosta) + (CantPeten * PrecioAPeten)
            Desc1 = Precio - (0.1 * Precio)

        End If





        Subtot = Precio
        CostoTotal = Precio + Desc1
        Desc = Desc1


        Me.Hide()
        Form2.Show()
        RESULTADOS()





    End Sub
End Class
