Public Class Form1

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckCompra.CheckedChanged
        If (CheckCompra.Checked) Then
            TxtCOMPRA.Visible = True
            TxtCOMPRA.Focus()
            GrpCompra.Visible = True

        Else
            TxtCOMPRA.Visible = False
            GrpCompra.Visible = False


        End If
    End Sub
    Private Sub BotonCalcular_Click(sender As Object, e As EventArgs) Handles BotonCalcular.Click

        If (TxtCLIENTE.Text = "") Then
            MsgBox("ERROR,NO INGRESÓ NOMBRE DEL CLIENTE")
            TxtCLIENTE.Focus()
            Exit Sub

        End If

        If (CheckCompra.Checked) Or (CheckVenta.Checked) Then
            If (CheckCompra.Checked) Then


                If (IsNumeric(TxtCOMPRA.Text) And Val(TxtCOMPRA.Text) > 0) Then
                    CantCompra = Val(TxtCOMPRA.Text)
                Else
                    MsgBox("ERROR, DATO DE COMPRA INVÁLIDO")
                    TxtCOMPRA.Focus()
                    Exit Sub

                End If
            Else
                CantCompra = 0
            End If


            If (CheckVenta.Checked) Then
                If (IsNumeric(TxtVENTA.Text) And Val(TxtVENTA.Text) > 0) Then
                    CantVenta = Val(TxtVENTA.Text)
                Else
                    MsgBox("ERROR, DATO DE VENTA INVÁLIDO")
                    TxtVENTA.Focus()
                    Exit Sub
                End If
            Else
                CantVenta = 0

            End If
        Else
            MsgBox("ERROR, NO SELECCIONÓ SERVICIO")
            Exit Sub
        End If

        If (CheckCompra.Checked) Then

            If (CheckCompra.Checked) And (RBotonDolarC.Checked) Then
                dolar = CantCompra / Dl
                CmsCompra = dolar * ComisionC
                TotCompra = dolar + CmsCompra
            ElseIf (CheckCompra.Checked) And (RBotonPesoC.Checked) Then
                peso = CantCompra / PMx
                CmsCompra = peso * ComisionC
                TotCompra = peso + CmsCompra
            ElseIf (CheckCompra.Checked) And (RBotonEuroC.Checked) Then
                euro = CantCompra / Eur
                CmsCompra = euro * ComisionC
                TotCompra = euro + CmsCompra
            ElseIf (CheckCompra.Checked) And (RBotonColonC.Checked) Then
                Colon = CantCompra / Cl
                CmsCompra = Colon * ComisionC
                TotCompra = Colon + CmsCompra
            Else

                MsgBox("ERROR, NO SELCCIONÓ TIPO DE MONEDA")
                Exit Sub

            End If


        End If

        If (CheckVenta.Checked) Then
            If (CheckVenta.Checked) And (RBotonDolarV.Checked) Then
                dolar = CantVenta * Dl
                CmsVenta = dolar * ComisionV
                TotVenta = dolar + CmsVenta
            ElseIf (CheckVenta.Checked) And (RBotonPesoV.Checked) Then
                peso = CantVenta * PMx
                CmsVenta = peso * ComisionV
                TotVenta = peso + CmsVenta
            ElseIf (CheckVenta.Checked) And (RBotonEuroV.Checked) Then
                euro = CantVenta * Eur
                CmsVenta = euro * ComisionV
                TotVenta = euro + CmsVenta
            ElseIf (CheckVenta.Checked) And (RBotonColonV.Checked) Then
                Colon = CantVenta * Cl
                CmsVenta = Colon * ComisionV
                TotVenta = Colon + CmsVenta
            Else
                MsgBox("ERROR, NO SELCCIONÓ TIPO DE MONEDA")
                Exit Sub
            End If
        End If

        TotFinal = TotCompra + TotVenta

        Me.Hide()
        Form2.Show()
        RESULTADOS()
    End Sub

    Private Sub CheckVenta_CheckedChanged(sender As Object, e As EventArgs) Handles CheckVenta.CheckedChanged
        If (CheckVenta.Checked) Then
            TxtVENTA.Visible = True
            TxtVENTA.Focus()
            GrpVenta.Visible = True

        Else
            TxtVENTA.Visible = False
            GrpVenta.Visible = False

        End If

    End Sub

    Private Sub BotonLimpiar_Click(sender As Object, e As EventArgs) Handles BotonLimpiar.Click
        LIMPIAR()
    End Sub


    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        If (MsgBox("¿ESTÁ SEGURO QUE QUIERE SALIR?", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            Me.Close()
        End If
    End Sub
End Class
