Imports System.Math
Module Module1
    Public Posicion As Byte = 0
    Public Nombre(10) As String
    Public Paquete(10) As String
    Public Envio(10) As String
    Public Peso(10) As Double
    Public Valor(10) As Double
    Public Impuesto(10) As Double
    Public Pparcial(10) As Double
    Public Ptotal(10) As Double
    Public Const EnvioCamion = 50
    Public Const EnvioMoto = 15
    Public Const Documento = 0.015
    Public Const Ropa = 0.6
    Public Const Predecederos = 0.055
    Public Const Plastico = 0.045
    Public Const Lociones = 0.02

    Sub LIMPIAR1()

        Dim x As Byte
        For x = 0 To 9
            Nombre(x) = Nothing
            Paquete(x) = Nothing
            Envio(x) = Nothing
            Peso(x) = Nothing
            Valor(x) = Nothing
            Impuesto(x) = Nothing
            Pparcial(x) = Nothing
            Ptotal(x) = Nothing
        Next x

        Posicion = 0
        Form1.ListBoxNombre.Items.Clear()
        Form1.ListBoxPaquete.Items.Clear()
        Form1.ListBoxPeso.Items.Clear()
        Form1.ListBoxPrecio.Items.Clear()
        Form1.ListBoxEnvio.Items.Clear()
        Form1.ListBoxImpuesto.Items.Clear()
        Form1.ListBoxPP.Items.Clear()
        Form1.ListBoxPT.Items.Clear()

    End Sub

    Sub LIMPIAR2()
        Form1.TxtPaqueteDocumento.Clear()
        Form1.TxtPaqueteDocumento.Clear()
        Form1.TxtPaqueteRopa.Clear()
        Form1.TxtPaquetesPlastico.Clear()
    End Sub

    Sub LIMPIAR3()
        Form1.TxtNombre.Clear()
        Form1.TxtPaquete.Clear()
        Form1.ComboBoxEnvio.SelectedIndex = -1
        Form1.ComboBoxPaquete.SelectedIndex = -1
    End Sub
    Sub MOSTRAR1()
        Dim z As Byte
        For z = 0 To 9
            If Ptotal(z) <> Nothing Then
                Form1.ListBoxNombre.Items.Add(Nombre(z))
                Form1.ListBoxPaquete.Items.Add(Paquete(z))
                Form1.ListBoxPeso.Items.Add(Str(Round(Peso(z), 2)))
                Form1.ListBoxPrecio.Items.Add(Str(Round(Valor(z), 2)))
                Form1.ListBoxEnvio.Items.Add(Envio(z))
                Form1.ListBoxImpuesto.Items.Add(Str(Round(Impuesto(z), 2)))
                Form1.ListBoxPP.Items.Add(Str(Round(Pparcial(z), 2)))
                Form1.ListBoxPT.Items.Add(Str(Round(Ptotal(z), 2)))
            Else
                Exit For
            End If
        Next z
    End Sub
End Module
