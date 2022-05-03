Imports System.Math
Module Module1
    Public Vuelta As Byte = 0
    Public Etapa(12) As Integer
    Public Equipo(12) As String
    Public KMRecorrido(12) As Double
    Public Tiempo(12) As Integer
    Public Nacionalidad(12) As String
    Public Penalizacion(12) As Integer
    Public TiempoTOTAL(12) As Integer
    Public Const Penalizacion1 = 30
    Public Const Penalizacion2 = 40
    Public Const Penalizacion3 = 50
    Public Const Recompensa1 = 15
    Public Const Recompensa2 = 10
    Public I As Byte

    Sub PenalizacionRecompensa()
        If (Tiempo(Vuelta) > 120) Then
            Penalizacion(Vuelta) = Penalizacion1
            TiempoTOTAL(Vuelta) = Tiempo(Vuelta) + Penalizacion(Vuelta)
        ElseIf (Tiempo(Vuelta) > 140) Then
            Penalizacion(Vuelta) = Penalizacion2
            TiempoTOTAL(Vuelta) = Tiempo(Vuelta) + Penalizacion(Vuelta)
        ElseIf (Tiempo(Vuelta) > 160) Then
            Penalizacion(Vuelta) = Penalizacion3
            TiempoTOTAL(Vuelta) = Tiempo(Vuelta) + Penalizacion(Vuelta)
        ElseIf (Tiempo(Vuelta) < 85 And Equipo(Vuelta) = "MOVISTAR") Then
            Penalizacion(Vuelta) = Recompensa1
            TiempoTOTAL(Vuelta) = Tiempo(Vuelta) - Penalizacion(Vuelta)
        ElseIf (Tiempo(Vuelta) < 85 And Equipo(Vuelta) = "PRO TEAM") Then
            Penalizacion(Vuelta) = Recompensa2
            TiempoTOTAL(Vuelta) = Tiempo(Vuelta) - Penalizacion(Vuelta)
        Else
            Penalizacion(Vuelta) = 0
            TiempoTOTAL(Vuelta) = Tiempo(Vuelta) - Penalizacion(Vuelta)
        End If
    End Sub

    Sub LIMPIAR1()
        Form1.ComboEquipo.SelectedIndex = -1
        Form1.ComboBoxNacionalidad.SelectedIndex = -1
        Form1.TxtEtapa.Clear()
        Form1.TxtKmRecorridos.Clear()
        Form1.TxtTiempo.Clear()
        Form1.Txtconsulta.Clear()
    End Sub

    Sub MOSTRAR()
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 11
            If (Etapa(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(Etapa(I)), Equipo(I), Str(KMRecorrido(I)), Nacionalidad(I), Str(Tiempo(I)), Str(Penalizacion(I)), Str(TiempoTOTAL(I)))
            Else
                Exit For

            End If
        Next I
    End Sub
    Sub LIMPIAR2()
        Form1.DataGridView1.Rows.Clear()
        Form1.TxtCorredoresNacionales.Clear()
        Form1.TxtSky.Clear()
        Form1.TxtMov.Clear()
        Form1.TxtProC.Clear()
        Form1.TxtPROT.Clear()
        Form1.TxtGT.Clear()
        Form1.TxtEXT.Clear()
        Form1.Txtconsulta.Clear()
        Vuelta = 0
        For I = 0 To 11

            Etapa(I) = Nothing
            Equipo(I) = Nothing
            KMRecorrido(I) = Nothing
            Tiempo(I) = Nothing
            TiempoTOTAL(I) = Nothing
            Nacionalidad(I) = Nothing
            Penalizacion(I) = Nothing
        Next I
    End Sub
End Module
