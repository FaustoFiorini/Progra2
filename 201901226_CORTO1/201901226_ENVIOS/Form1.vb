Public Class Form1
    Private Sub BotonCalcular_Click(sender As Object, e As EventArgs) Handles BotonCalcular.Click
        Mensajero = Val(TxtNombre.Text)
        Monto = Val(TxtMontoEnvio)


        If (RBotonN.Checked = True) And (RBotonSA.Checked = True) Then
            SeguroCalculado = Base + SeguroA
            SueldoFinal = Base + Nort
        ElseIf (RBotonN.Checked = True) And (RBotonSV.Checked = True) Then
            SeguroCalculado = Base + SeguroV
            SueldoFinal = Base + Nort
        End If

        If (RBotonS.Checked = True) And (RBotonSA.Checked = True) Then
            SeguroCalculado = Base + SeguroA
            SueldoFinal = Base + Sr
        ElseIf (RBotonS.Checked = True) And (RBotonSV.Checked = True) Then
            SeguroCalculado = Base + SeguroV
            SueldoFinal = Base + Sr
        End If

        If (RBotonOC.Checked = True) And (RBotonSA.Checked = True) Then
            SeguroCalculado = Base + SeguroA
            SueldoFinal = Base + Occi
        ElseIf (RBotonOC.Checked = True) And (RBotonSV.Checked = True) Then
            SeguroCalculado = Base + SeguroV
            SueldoFinal = Base + Occi
        End If

        If (RBotonOR.Checked = True) And (RBotonSA.Checked = True) Then
            SeguroCalculado = Base + SeguroA
            SueldoFinal = Base + Ori
        ElseIf (RBotonOR.Checked = True) And (RBotonSV.Checked = True) Then
            SeguroCalculado = Base + SeguroV
            SueldoFinal = Base + Ori
        End If

        TxtMontoSeguro = Str(SeguroCalculado)
        TxtSueldoFinal = Str(SueldoFinal)


    End Sub

    Private Sub BotonLimpiar_Click(sender As Object, e As EventArgs) Handles BotonLimpiar.Click


    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        If (MsgBox("¿ESTÁ SEGURO QUE QUIERE SALIR?", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
