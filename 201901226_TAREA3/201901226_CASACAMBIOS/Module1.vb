Imports System.Math
Module Module1
    Public Cliente As String
    Public CantCompra As Double
    Public CantVenta As Double
    Public CmsCompra As Double
    Public CmsVenta As Double
    Public TotFinal As Double
    Public TotCompra As Double
    Public TotVenta As Double
    Public quetzales As Double
    Public dolar As Double
    Public peso As Double
    Public euro As Double
    Public Colon As Double
    Public Const Dl = 7.69
    Public Const PMx = 0.38
    Public Const Eur = 8.79
    Public Const Cl = 0.012
    Public Const ComisionC = 0.025
    Public Const ComisionV = 0.03

    Sub LIMPIAR()
        Form1.TxtCLIENTE.Clear()
        Form1.TxtCOMPRA.Visible = False
        Form1.TxtCOMPRA.Clear()
        Form1.TxtVENTA.Visible = False
        Form1.TxtVENTA.Clear()
        Form1.CheckCompra.Checked = False
        Form1.CheckVenta.Checked = False
        Form1.RBotonDolarC.Checked = False
        Form1.RBotonPesoC.Checked = False
        Form1.RBotonEuroC.Checked = False
        Form1.RBotonColonC.Checked = False
        Form1.RBotonDolarV.Checked = False
        Form1.RBotonPesoV.Checked = False
        Form1.RBotonEuroV.Checked = False
        Form1.RBotonColonV.Checked = False
        Form2.TxtComisionC.Clear()
        Form2.TxtComisionV.Clear()
        Form2.TxtTotalFinal.Clear()
        CmsCompra = 0
        CmsVenta = 0
        TotFinal = 0
    End Sub
    Sub RESULTADOS()
        Form2.TxtComisionC.Text = Str(Round(CmsCompra, 2))
        Form2.TxtComisionV.Text = Str(Round(CmsVenta, 2))
        Form2.TxtTotalFinal.Text = Str(Round(TotFinal, 2))
    End Sub


End Module

