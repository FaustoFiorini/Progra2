Imports System.Math
Public Class Form1
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿ESTÁ SEGURO QUE QUIERE SALIR?", vbQuestion + vbYesNo, "Salir") = vbYes) Then
            Me.Close()
        End If

    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIAR1()

    End Sub

    Private Sub ORDENARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARToolStripMenuItem.Click
        Dim a As Byte
        Dim b As Byte
        Dim N1 As Integer
        Dim N2 As String
        Dim N3 As Double
        Dim N4 As String
        Dim N5 As Integer
        Dim N6 As Integer
        Dim N7 As Integer
        For a = 0 To 10
            For b = a + 1 To 11
                If (Etapa(b) <> Nothing) Then
                    If (Etapa(a) > Etapa(b)) Then
                        N1 = Etapa(a)
                        Etapa(a) = Etapa(b)
                        Etapa(b) = N1
                        N2 = Equipo(a)
                        Equipo(a) = Equipo(b)
                        Equipo(b) = N2
                        N3 = KMRecorrido(a)
                        KMRecorrido(a) = KMRecorrido(b)
                        KMRecorrido(b) = N3
                        N4 = Nacionalidad(a)
                        Nacionalidad(a) = Nacionalidad(b)
                        Nacionalidad(b) = N4
                        N5 = Tiempo(a)
                        Tiempo(a) = Tiempo(b)
                        Tiempo(b) = N5
                        N6 = Penalizacion(a)
                        Penalizacion(a) = Penalizacion(b)
                        Penalizacion(b) = N6
                        N7 = TiempoTOTAL(a)
                        TiempoTOTAL(a) = TiempoTOTAL(b)
                        TiempoTOTAL(b) = N7
                    End If
                End If
            Next b
        Next a
    End Sub

    Private Sub GUARDARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDARToolStripMenuItem.Click
        If (Vuelta <= 11) Then
            Nacionalidad(Vuelta) = ComboBoxNacionalidad.Text
            Equipo(Vuelta) = ComboEquipo.Text
            Etapa(Vuelta) = Val(TxtEtapa.Text)
            KMRecorrido(Vuelta) = Val(TxtKmRecorridos.Text)
            Tiempo(Vuelta) = Val(TxtTiempo.Text)
            PenalizacionRecompensa()

            Vuelta = Vuelta + 1

        End If
        If (Vuelta = 12) Then
            MsgBox("VECTORES LLENOS")
        End If
    End Sub

    Private Sub VERESTADÍSTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERESTADÍSTICASToolStripMenuItem.Click
        Dim j As Byte
        Dim Corredores As Byte = 0
        Dim kmeq1 As Double = 0
        Dim kmeq2 As Double = 0
        Dim kmeq3 As Double = 0
        Dim kmeq4 As Double = 0
        Dim Tiempotot1 As Integer = 0
        Dim Tiempotot2 As Integer = 0
        For j = 0 To 11
            If (KMRecorrido(j) <> Nothing) Then
                If (KMRecorrido(j) > 45 And Nacionalidad(j) = "GUATEMALTECO") Then
                    Corredores = Corredores + 1
                End If
                If (Equipo(j) = "SKY") Then
                    kmeq1 = kmeq1 + KMRecorrido(j)
                End If
                If (Equipo(j) = "MOVISTAR") Then
                    kmeq2 = kmeq2 + KMRecorrido(j)
                End If
                If (Equipo(j) = "PRO CYCLING") Then
                    kmeq3 = kmeq3 + KMRecorrido(j)
                End If
                If (Equipo(j) = "PRO TEAM") Then
                    kmeq4 = kmeq4 + KMRecorrido(j)
                End If
                If (Nacionalidad(j) = "GUATEMALTECO") Then
                    Tiempotot1 = Tiempotot1 + TiempoTOTAL(j)
                End If
                If (Nacionalidad(j) = "EXTRANJERO") Then
                    Tiempotot2 = Tiempotot2 + TiempoTOTAL(j)
                End If
            Else
                Exit For
            End If
        Next j
        If (tiempotot1 > 60) Then
            Dim hora As Integer = 60
            Dim conversionhora As Integer
            Dim conversionmin As Integer
            conversionhora = Tiempotot1 / hora
            conversionmin = Tiempotot1 - conversionhora * hora
            TxtGT.Text = conversionhora.ToString + " horas " + conversionmin.ToString + " min."
        Else
            TxtGT.Text = Str(Tiempotot1) + " min."
        End If
        If (tiempotot2 > 60) Then
            Dim hora As Integer = 60
            Dim conversion_hora As Integer
            Dim conversion_min As Integer
            conversion_hora = tiempotot2 / hora
            conversion_min = tiempotot2 - conversion_hora * hora
            TxtEXT.Text = conversion_hora.ToString + " horas " + conversion_min.ToString + " min."
        Else
            TxtEXT.Text = Str(Tiempotot2) + " min."
        End If
        TxtCorredoresNacionales.Text = Str(Corredores)
        TxtSky.Text = Str(Round(kmeq1, 2))
        TxtMov.Text = Str(Round(kmeq2, 2))
        TxtProC.Text = Str(Round(kmeq3, 2))
        TxtPROT.Text = Str(Round(kmeq4, 2))
    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click
        Nacionalidad(Vuelta) = ComboBoxNacionalidad.Text
        Equipo(Vuelta) = ComboEquipo.Text
        Etapa(Vuelta) = Val(TxtEtapa.Text)
        KMRecorrido(Vuelta) = Val(TxtKmRecorridos.Text)
        Tiempo(Vuelta) = Val(TxtTiempo.Text)

        PenalizacionRecompensa()
        MsgBox("REGISTRO CORRECTAMENTE ACTUALIZADO")
        Vuelta = I
    End Sub

    Private Sub ONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ONSULTARToolStripMenuItem.Click
        Dim existe As Boolean = False
        I = 0
        While (I <= 11) And Not (existe)
            If (Etapa(I) = Val(Txtconsulta.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            MsgBox("REGISTRO ENCONTRADO EXITOSAMENTE")
            TxtEtapa.Text = Str(Etapa(I))
            TxtKmRecorridos.Text = Str(KMRecorrido(I))
            TxtTiempo.Text = Str(Tiempo(I))
            ComboEquipo.Text = Equipo(I)
            ComboBoxNacionalidad.Text = Nacionalidad(I)
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(Etapa(I)), Equipo(I), Str(KMRecorrido(I)), Nacionalidad(I), Str(Tiempo(I)), Str(Penalizacion(I)), Str(TiempoTOTAL(I)))
            Vuelta = I
        Else
            MsgBox("Etapa no encontrada")
            Txtconsulta.Focus()
        End If

    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        LIMPIAR2()

    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        MOSTRAR()

    End Sub
End Class
