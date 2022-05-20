Imports System.Math
Module Module1
    Public Crucero As Byte = 0
    Public Nombre(6) As String
    Public NIT(6) As Integer
    Public TipoCabina(6) As String
    Public TipoClase(6) As String
    Public NoPersonas(6) As Integer
    Public PrecioIndividual(6) As Double
    Public Total(6) As Double
    Public Const SencillaPC = 400
    Public Const DoblePC = 700
    Public Const CompartidaPC = 350
    Public Const SencillaSC = 375
    Public Const DobleSC = 600
    Public Const CompartidaSC = 300
    Public I As Byte

    Function PrimeraClase() As Double
        Select Case (Form1.ComboBoxCabina.SelectedIndex And Form1.ComboBoxClase.SelectedIndex)
            Case 0
                TipoCabina(Crucero) = Form1.ComboBoxCabina.Text
                TipoClase(Crucero) = Form1.ComboBoxClase.Text
                PrimeraClase = SencillaPC
            Case 1
                TipoCabina(Crucero) = Form1.ComboBoxCabina.Text
                TipoClase(Crucero) = Form1.ComboBoxClase.Text
                PrimeraClase = DoblePC
            Case 2
                TipoCabina(Crucero) = Form1.ComboBoxCabina.Text
                TipoClase(Crucero) = Form1.ComboBoxClase.Text
                PrimeraClase = CompartidaPC
        End Select
        Return PrimeraClase
    End Function

    Function SegundaClase() As Double
        Select Case (Form1.ComboBoxCabina.SelectedIndex And Form1.ComboBoxClase.SelectedIndex)
            Case 0
                TipoCabina(Crucero) = Form1.ComboBoxCabina.Text
                TipoClase(Crucero) = Form1.ComboBoxClase.Text
                SegundaClase = SencillaSC
            Case 1
                TipoCabina(Crucero) = Form1.ComboBoxCabina.Text
                TipoClase(Crucero) = Form1.ComboBoxClase.Text
                SegundaClase = DobleSC
            Case 2
                TipoCabina(Crucero) = Form1.ComboBoxCabina.Text
                TipoClase(Crucero) = Form1.ComboBoxClase.Text
                SegundaClase = CompartidaSC
        End Select
        Return SegundaClase()
    End Function

    Sub LIMPIAR1()
        Form1.DataGridView1.Rows.Clear()
        Form1.TxtNombre.Clear()
        Form1.TxtNit.Clear()
        Form1.TxtPersonas.Clear()
        Form1.TxtConsulta.Clear()
        Crucero = 0
        For I = 0 To 5

            Nombre(I) = Nothing
            NIT(I) = Nothing
            TipoCabina(I) = Nothing
            TipoClase(I) = Nothing
            NoPersonas(I) = Nothing
            PrecioIndividual(I) = Nothing
            Total(I) = Nothing
        Next I
    End Sub

    Sub MOSTRAR1()
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 6
            If NIT(I) <> Nothing Then
                Form1.DataGridView1.Rows.Add(Nombre(I), NIT(I), TipoCabina(I), TipoClase(I), Str(NoPersonas(I)), Str(PrecioIndividual(I)), Str(Total(I)))

            Else
                Exit For
            End If
        Next I

    End Sub

End Module
