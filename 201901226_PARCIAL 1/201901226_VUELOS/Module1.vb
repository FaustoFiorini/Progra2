Imports System.Math
Module Module1
    Public CantCosta As Double
    Public CantIzabal As Double
    Public CantPeten As Double
    Public CostoTotal As Double
    Public Subtot As Double
    Public Desc As Double
    Public Desc1 As Double
    Public Precio As Double
    Public Const PrecioACosta = 150
    Public Const PrecioAIz = 175.99
    Public Const PrecioAPeten = 250.99
    Public Const PrecioJCosta = 250.99
    Public Const PrecioJIz = 325.99
    Public Const PrecioJPeten = 450.99
    Public Const PrecioHCosta = 125.99
    Public Const PrecioHIz = 175.99
    Public Const PrecioHPeten = 275.99

    Sub LIMPIAR()
        Form1.TxtCosta.Clear()
        Form1.TxtIzabal.Clear()
        Form1.TxtPeten.Clear()
        Form1.RBotonA.Checked = 0
        Form1.RBotonH.Checked = 0
        Form1.RBotonJet.Checked = 0
        Form1.CheckCosta.Checked = 0
        Form1.CheckIzabal.Checked = 0
        Form1.CheckPeten.Checked = 0
        Form2.TxtDescuento.Clear()
        Form2.TxtSubtotal.Clear()
        Form2.TxtTotal.Clear()
        Desc = 0
        Subtot = 0
        CostoTotal = 0

    End Sub

    Sub RESULTADOS()
        Form2.TxtDescuento.Text = Str(Round(Desc, 2))
        Form2.TxtSubtotal.Text = Str(Round(Subtot, 2))
        Form2.TxtTotal.Text = Str(Round(CostoTotal, 2))
    End Sub



End Module
