Imports System.Math
Module Module1
    Public CantAlgodon As Double
    Public CantSeda As Double
    Public CantLona As Double
    Public PVAlg As Double
    Public PVseda As Double
    Public PVlona As Double
    Public PCAlg As Double
    Public PCSeda As Double
    Public PClona As Double
    Public CostoTotal As Double
    Public Const Palgodon = 15
    Public Const Pseda = 23.99
    Public Const Plona = 30.99
    Public Const ydS = 2
    Public Const ydM = 2.5
    Public Const ydL = 3
    Public Const MOS = 65.5
    Public Const MOM = 85.99
    Public Const MOL = 99.99

    Sub LIMPIAR()
        Form1.TxtAlgodon.Clear()
        Form1.TxtLona.Clear()
        Form1.TxtSeda.Clear()
        Form2.TxtPVA.Clear()
        Form2.TxtPVL.Clear()
        Form2.TxtPVS.Clear()
        Form2.TxtPCA.Clear()
        Form2.TxtPCL.Clear()
        Form2.TxtPCS.Clear()
        Form2.TxtTotalF.Clear()
        Form1.RBotonL.Checked = 0
        Form1.RBotonM.Checked = 0
        Form1.RBotonS.Checked = 0
        Form1.RBotonAlg.Checked = 0
        Form1.RBotonSeda.Checked = 0
        Form1.RBotonLona.Checked = 0
        PVAlg = 0
        PVlona = 0
        PVseda = 0
        PCAlg = 0
        PClona = 0
        PCSeda = 0
        CostoTotal = 0
    End Sub
    Sub RESULTADOS()
        Form2.TxtPCA.Text = Str(Round(PCAlg, 2))
        Form2.TxtPCL.Text = Str(Round(PClona, 2))
        Form2.TxtPCS.Text = Str(Round(PCSeda, 2))
        Form2.TxtPVA.Text = Str(Round(PVAlg, 2))
        Form2.TxtPVL.Text = Str(Round(PVlona, 2))
        Form2.TxtPVS.Text = Str(Round(PVseda, 2))
        Form2.TxtTotalF.Text = Str(Round(CostoTotal, 2))

    End Sub

End Module
