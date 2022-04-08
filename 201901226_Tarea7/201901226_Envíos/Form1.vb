Imports System.Math
Public Class Form1
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿ESTÁ SEGURO QUE QUIERE SALIR?", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIAR3()

    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        LIMPIAR1()

    End Sub

    Private Sub LIMPIARESTADÍSTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARESTADÍSTICASToolStripMenuItem.Click
        LIMPIAR2()

    End Sub

    Private Sub MOSTRARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARVECTORESToolStripMenuItem.Click
        MOSTRAR1()
    End Sub

    Private Sub ACEPTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACEPTARToolStripMenuItem.Click
        If (Posicion <= 9) Then
            Nombre(Posicion) = TxtNombre.Text
            Valor(Posicion) = TxtPaquete.Text
            Paquete(Posicion) = ComboBoxPaquete.Text
            Envio(Posicion) = ComboBoxEnvio.Text
            Peso(Posicion) = Val(InputBox("INGRESE EL PESO EN LIBRAS DEL PAQUETE"))
            If (Peso(Posicion) > 0 And Peso(Posicion) <= 5) Then
                Select Case (ComboBoxPaquete.SelectedIndex)
                    Case 0
                        Impuesto(Posicion) = Peso(Posicion) * Documento
                    Case 1
                        Impuesto(Posicion) = Peso(Posicion) * Ropa
                    Case 2
                        Impuesto(Posicion) = Peso(Posicion) * Predecederos
                    Case 3
                        Impuesto(Posicion) = Peso(Posicion) * Plastico
                    Case 4
                        Impuesto(Posicion) = Peso(Posicion) * Lociones
                    Case -1
                        MsgBox("DEBE SELECCIONAR TIPO DE PAQUETE")
                End Select
            Else
                Impuesto(Posicion) = Peso(Posicion) * 0
            End If

            Pparcial(Posicion) = Valor(Posicion) + Impuesto(Posicion)

            Select Case (ComboBoxEnvio.SelectedIndex)
                Case 0
                    Ptotal(Posicion) = EnvioCamion + Pparcial(Posicion)
                Case 1
                    Ptotal(Posicion) = EnvioMoto + Pparcial(Posicion)
                Case -1
                    MsgBox("DEBE SELECCIONAR METODO DE ENVÍO")
            End Select

            Posicion = Posicion + 1

        End If
        If (Posicion = 10) Then
            MsgBox("VECTORES LLENOS")
        End If
    End Sub

    Private Sub MOSTRARESTADÍSTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARESTADÍSTICASToolStripMenuItem.Click
        Dim y As Byte
        Dim TotLociones As Double = 0
        Dim ArticulosPlastico As Byte = 0
        Dim TotDocs As Double = 0
        Dim TotRopa As Byte = 0
        For y = 0 To 9
            If (Paquete(y) <> Nothing) Then
                If (Paquete(y) = "LOCIONES") Then
                    TotLociones = TotLociones + Valor(y)
                End If
                If (Paquete(y) = "ARTÍCULOS DE PLÁSTICO") Then
                    ArticulosPlastico = ArticulosPlastico + 1
                End If
                If (Paquete(y) = "DOCUMENTOS") Then
                    TotDocs = TotDocs + Valor(y)
                End If
                If (Paquete(y) = "ROPA") Then
                    TotRopa = TotRopa + 1
                End If
            Else
                Exit For
            End If
        Next y
        TxtTotalLociones.Text = Str(Round(TotLociones, 2))
        TxtPaquetesPlastico.Text = Str(Round(ArticulosPlastico, 2))
        TxtPaqueteDocumento.Text = Str(Round(TotDocs, 2))
        TxtPaqueteRopa.Text = Str(Round(TotRopa, 2))
    End Sub
End Class
