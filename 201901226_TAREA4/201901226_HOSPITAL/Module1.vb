Imports System.Math
Module Module1
    Public posicion As Byte = 0
    Public Nombre(6) As String
    Public NIT(6) As Integer
    Public Honorarios(6) As Double
    Public Días(6) As Integer
    Public Servicio(6) As String
    Public Habitación(6) As String
    Public Pago(6) As String
    Public Subtotal(6) As Double
    Public Descuento(6) As Double
    Public Total(6) As Double
    Public Const desc1 = 0.15
    Public Const desc2 = 0.08
    Public Const recargo1 = 0.05
    Public Const PrivE = 350
    Public Const PrivO = 550
    Public Const PrivM = 450
    Public Const SemiprivE = 250
    Public Const SemiprivO = 400
    Public Const SemiprivM = 350
    Public Const NoprivE = 150
    Public Const NoprivO = 300
    Public Const NoprivM = 250

    Sub LIMPIAR1()
        Posicion = 0
        Form1.ListBoxName.Items.Clear()
        Form1.ListBoxNit.Items.Clear()
        Form1.ListBoxDr.Items.Clear()
        Form1.ListBoxDias.Items.Clear()
        Form1.ListBoxServicio.Items.Clear()
        Form1.ListBoxHabi.Items.Clear()
        Form1.ListBoxPago.Items.Clear()
        Form1.ListBoxSubtot.Items.Clear()
        Form1.ListBoxTotal.Items.Clear()
        Form1.ListBoxDesc.Items.Clear()
    End Sub
    Sub LIMPIAR2()

        Form1.ComboBox1.SelectedIndex = -1
        Form1.TxtNombre.Clear()
        Form1.TxtNoDias.Clear()
        Form1.TxtNIT.Clear()
        Form1.RBotonCheque.Checked = 0
        Form1.RBotonEfectivo.Checked = 0
        Form1.RBotonTarjetaC.Checked = 0
        Form1.RBotonTarjetaD.Checked = 0
        Form1.CheckEncamamiento.Checked = 0
        Form1.CheckMaternidad.Checked = 0
        Form1.CheckOperación.Checked = 0

    End Sub
    Function Calculardescuentorecargo() As Double
        Dim desc As Double
        Dim recargo As Double



        If (Form1.RBotonEfectivo.Checked) Then
            Pago(posicion) = Form1.RBotonEfectivo.Text
            desc = Subtotal(posicion) * desc1
            Return desc * -1
        ElseIf (Form1.RBotonCheque.Checked) Then
            Pago(posicion) = Form1.RBotonCheque.Text
            desc = Subtotal(posicion) * desc1
            Return desc * -1
        ElseIf (Form1.RBotonTarjetaD.Checked) Then
            Pago(posicion) = Form1.RBotonTarjetaD.Text
            desc = Subtotal(posicion) * desc2
            Return desc * -1
        ElseIf (Form1.RBotonTarjetaC.Checked) Then
            Pago(posicion) = Form1.RBotonTarjetaC.Text
            recargo = Subtotal(posicion) * recargo1
            Return recargo
        End If

    End Function
    Sub SubTot()

        Select Case (Form1.ComboBox1.SelectedIndex)
            Case 0
                Habitación(posicion) = "PRIVADA"
                If (Form1.CheckEncamamiento.Checked Or Form1.CheckOperación.Checked Or Form1.CheckMaternidad.Checked) Then
                    If (Form1.CheckEncamamiento.Checked) Then
                        Subtotal(posicion) = PrivE * Días(posicion)
                        Servicio(posicion) = "ENCAMAMIENTO"
                    End If
                    If (Form1.CheckOperación.Checked) Then
                        Subtotal(posicion) = PrivO * Días(posicion)
                        Servicio(posicion) = "OPERACIÓN"
                    End If
                    If (Form1.CheckMaternidad.Checked) Then
                        Subtotal(posicion) = PrivM * Días(posicion)
                        Servicio(posicion) = "MATERNIDAD"
                    End If
                    If (Form1.CheckEncamamiento.Checked And Form1.CheckOperación.Checked) Then
                        Subtotal(posicion) = (PrivE + PrivO) * Días(posicion)
                        Servicio(posicion) = "ENCAMAMIENTO Y OPERACIÓN"
                    End If
                    If (Form1.CheckEncamamiento.Checked And Form1.CheckMaternidad.Checked) Then
                        Subtotal(posicion) = (PrivE + PrivM) * Días(posicion)
                        Servicio(posicion) = "ENCAMAMIENTO Y MATERNIDAD"
                    End If
                    If (Form1.CheckMaternidad.Checked And Form1.CheckOperación.Checked) Then
                        Subtotal(posicion) = (PrivM + PrivO) * Días(posicion)
                        Servicio(posicion) = "MATERNIDAD Y OPERACIÓN"
                    End If
                    If (Form1.CheckMaternidad.Checked And Form1.CheckOperación.Checked And Form1.CheckEncamamiento.Checked) Then
                        Subtotal(posicion) = (PrivE + PrivM + PrivO) * Días(posicion)
                        Servicio(posicion) = "TODOS"
                    End If
                Else
                    MsgBox("NO SELECCIONÓ SERVICIO")
                    Exit Sub

                End If


            Case 1
                Habitación(posicion) = "SEMIPRIVADA"
                If (Form1.CheckEncamamiento.Checked Or Form1.CheckOperación.Checked Or Form1.CheckMaternidad.Checked) Then
                    If (Form1.CheckEncamamiento.Checked) Then
                        Subtotal(posicion) = SemiprivE * Días(posicion)
                        Servicio(posicion) = "ENCAMAMIENTO"
                    End If
                    If (Form1.CheckOperación.Checked) Then
                        Subtotal(posicion) = SemiprivO * Días(posicion)
                        Servicio(posicion) = "OPERACIÓN"
                    End If
                    If (Form1.CheckMaternidad.Checked) Then
                        Subtotal(posicion) = SemiprivM * Días(posicion)
                        Servicio(posicion) = "MATERNIDAD"
                    End If
                    If (Form1.CheckEncamamiento.Checked And Form1.CheckOperación.Checked) Then
                        Subtotal(posicion) = (SemiprivE + SemiprivO) * Días(posicion)
                        Servicio(posicion) = "ENCAMAMIENTO Y OPERACIÓN"
                    End If
                    If (Form1.CheckEncamamiento.Checked And Form1.CheckMaternidad.Checked) Then
                        Subtotal(posicion) = (SemiprivE + SemiprivM) * Días(posicion)
                        Servicio(posicion) = "ENCAMAMIENTO Y MATERNIDAD"
                    End If
                    If (Form1.CheckMaternidad.Checked And Form1.CheckOperación.Checked) Then
                        Subtotal(posicion) = (SemiprivM + SemiprivO) * Días(posicion)
                        Servicio(posicion) = "MATERNIDAD Y OPERACIÓN"
                    End If
                    If (Form1.CheckMaternidad.Checked And Form1.CheckOperación.Checked And Form1.CheckEncamamiento.Checked) Then
                        Subtotal(posicion) = (PrivE + PrivM + PrivO) * Días(posicion)
                        Servicio(posicion) = "TODOS LOS SERVICIOS"
                    End If
                Else
                    MsgBox("NO SELECCIONÓ SERVICIO")
                    Exit Sub
                End If

            Case 2
                Habitación(posicion) = "NO PRIVADA"
                If (Form1.CheckEncamamiento.Checked Or Form1.CheckOperación.Checked Or Form1.CheckMaternidad.Checked) Then
                    If (Form1.CheckEncamamiento.Checked) Then
                        Subtotal(posicion) = NoprivE * Días(posicion)
                        Servicio(posicion) = "ENCAMAMIENTO"
                    End If
                    If (Form1.CheckOperación.Checked) Then
                        Subtotal(posicion) = NoprivO * Días(posicion)
                        Servicio(posicion) = "OPERACIÓN"
                    End If
                    If (Form1.CheckMaternidad.Checked) Then
                        Subtotal(posicion) = NoprivM * Días(posicion)
                        Servicio(posicion) = "MATERNIDAD"
                    End If
                    If (Form1.CheckEncamamiento.Checked And Form1.CheckOperación.Checked) Then
                        Subtotal(posicion) = (NoprivE + NoprivO) * Días(posicion)
                        Servicio(posicion) = "ENCAMAMIENTO Y OPERACIÓN"
                    End If
                    If (Form1.CheckEncamamiento.Checked And Form1.CheckMaternidad.Checked) Then
                        Subtotal(posicion) = (NoprivE + NoprivM) * Días(posicion)
                        Servicio(posicion) = "ENCAMAMIENTO Y MATERNIDAD"
                    End If
                    If (Form1.CheckMaternidad.Checked And Form1.CheckOperación.Checked) Then
                        Subtotal(posicion) = (NoprivM + NoprivO) * Días(posicion)
                        Servicio(posicion) = "MATERNIDAD Y OPERACIÓN"
                    End If
                    If (Form1.CheckMaternidad.Checked And Form1.CheckOperación.Checked And Form1.CheckEncamamiento.Checked) Then
                        Subtotal(posicion) = (NoprivE + NoprivM + NoprivO) * Días(posicion)
                        Servicio(posicion) = "TODOS LOS SERVICIOS"
                    End If
                Else
                    MsgBox("NO SELECCIONÓ SERVICIO")
                    Exit Sub
                End If

        End Select
    End Sub
    Function Tot() As Double
        Tot = Subtotal(posicion) + Descuento(posicion)
        Return Tot

    End Function
    Sub Mostrar()
        Form1.ListBoxName.Items.Add(Nombre(posicion))
        Form1.ListBoxNit.Items.Add(NIT(posicion))
        Form1.ListBoxDr.Items.Add(Str(Round(Honorarios(posicion), 2)))
        Form1.ListBoxDias.Items.Add(Str(Días(posicion)))
        Form1.ListBoxServicio.Items.Add(Servicio(posicion))
        Form1.ListBoxPago.Items.Add(Pago(posicion))
        Form1.ListBoxHabi.Items.Add(Habitación(posicion))
        Form1.ListBoxSubtot.Items.Add(Str(Round(Subtotal(posicion), 2)))
        Form1.ListBoxDesc.Items.Add(Str(Round(Descuento(posicion), 2)))
        Form1.ListBoxTotal.Items.Add(Str(Round(Total(posicion), 2)))

    End Sub
End Module
