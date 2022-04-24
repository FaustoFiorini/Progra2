Imports System.Math
Module Module1
    Public Turismo As Byte = 0
    Public Identificacion(7) As Integer
    Public Dias(7) As Integer
    Public Personas(7) As Integer
    Public TipoViaje(7) As String
    Public PagoFinal(7) As Double
    Public Const Biotopo1 = 255
    Public Const Laguna2 = 440
    Public Const Mirador3 = 1190
    Public I As Byte

    Function TOTAL() As Double
        Select Case (Form1.ComboBoxViajes.SelectedIndex)
            Case 0
                TipoViaje(Turismo) = Form1.ComboBoxViajes.Text
                TOTAL = Round(Biotopo1 * Personas(Turismo) * Dias(Turismo), 2)

            Case 1
                TipoViaje(Turismo) = Form1.ComboBoxViajes.Text
                TOTAL = Round(Laguna2 * Personas(Turismo) * Dias(Turismo), 2)
            Case 2
                TipoViaje(Turismo) = Form1.ComboBoxViajes.Text
                TOTAL = Round(Mirador3 * Personas(Turismo) * Dias(Turismo), 2)
            Case Else
                MsgBox("ERROR NO SLECCIONÓ TIPO DE VIAJE")
                Form1.ComboBoxViajes.Focus()
                Exit Function
        End Select
        Return TOTAL
    End Function
    Sub LIMPIAR1()


        Form1.DataGridView1.Rows.Clear()

        Turismo = 0

        For I = 0 To 6
            Identificacion(I) = Nothing
            Dias(I) = Nothing
            Personas(I) = Nothing
            TipoViaje(I) = Nothing
            PagoFinal(I) = Nothing
        Next I
    End Sub
    Sub MOSTRAR1()
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 6
            If Identificacion(I) <> Nothing Then
                Form1.DataGridView1.Rows.Add(Str(Identificacion(I)), Str(Dias(I)), Str(Personas(I)), TipoViaje(I), Str(PagoFinal(I)))

            Else
                Exit For
            End If
        Next I

    End Sub


End Module
