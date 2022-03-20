Imports System.Math
Module Module1
    Public Posicion As Byte = 0
    Public CASA(6, 9)
    Public Const Tvcorto = 250
    Public Const TELcorto = 550
    Public Const Laptopcorto = 770
    Public Const Refricorto = 1000
    Public Const Tvlargo = 300
    Public Const TELlargo = 600
    Public Const Laptoplargo = 800
    Public Const Refrilargo = 1200

    Sub LIMPIAR1()
        Form1.ListBoxName.Items.Clear()
        Form1.ListBoxCui.Items.Clear()
        Form1.ListBoxDirecc.Items.Clear()
        Form1.ListBoxcosto.Items.Clear()
        Form1.ListBoxAparato.Items.Clear()
        Form1.ListBoxPlazo.Items.Clear()
        Form1.ListBoxPParcial.Items.Clear()
        Form1.ListBoxDesc.Items.Clear()
        Form1.ListBoxPfinal.Items.Clear()
    End Sub

    Sub LIMPIAR2()
        Posicion = 0
        Form1.ListBoxName.Items.Clear()
        Form1.ListBoxCui.Items.Clear()
        Form1.ListBoxDirecc.Items.Clear()
        Form1.ListBoxcosto.Items.Clear()
        Form1.ListBoxAparato.Items.Clear()
        Form1.ListBoxPlazo.Items.Clear()
        Form1.ListBoxPParcial.Items.Clear()
        Form1.ListBoxDesc.Items.Clear()
        Form1.ListBoxPfinal.Items.Clear()
    End Sub
    Sub LIMPIAR3()
        Form1.TxtNombre.Clear()
        Form1.TxtCUI.Clear()
        Form1.TxtDirección.Clear()
        Form1.TxtCosto.Clear()
        Form1.RBotonCorto.Checked = 0
        Form1.RBotonLargo.Checked = 0
        Form1.CheckLaptop.Checked = 0
        Form1.CheckRefri.Checked = 0
        Form1.CheckTEL.Checked = 0
        Form1.CheckTV.Checked = 0
    End Sub
    Sub PAGOPARCIA1()

        If (Form1.CheckTV.Checked) Then
            CASA(Posicion, 4) = Form1.CheckTV.Text
            CASA(Posicion, 6) = Str(CASA(Posicion, 3) + Tvcorto)
        End If

        If (Form1.CheckTEL.Checked) Then
            CASA(Posicion, 4) = Form1.CheckTEL.Text
            CASA(Posicion, 6) = Str(CASA(Posicion, 3) + TELcorto)
        End If

        If (Form1.CheckLaptop.Checked) Then
            CASA(Posicion, 4) = Form1.CheckLaptop.Text
            CASA(Posicion, 6) = Str(CASA(Posicion, 3) + Laptopcorto)
        End If

        If (Form1.CheckRefri.Checked) Then
            CASA(Posicion, 4) = Form1.CheckRefri.Text
            CASA(Posicion, 6) = Str(CASA(Posicion, 3) + Refricorto)
        End If
        If (Form1.CheckRefri.Checked) Then
            CASA(Posicion, 4) = Form1.CheckRefri.Text
            CASA(Posicion, 6) = Str(CASA(Posicion, 3) + Refrilargo)
        End If

        If (Form1.CheckTV.Checked) Then
            CASA(Posicion, 4) = Form1.CheckTV.Text
            CASA(Posicion, 6) = Str(CASA(Posicion, 3) + Tvlargo)
        End If

        If (Form1.CheckTEL.Checked) Then
            CASA(Posicion, 4) = Form1.CheckTEL.Text
            CASA(Posicion, 6) = Str(CASA(Posicion, 3) + TELlargo)
        End If

        If (Form1.CheckLaptop.Checked) Then
            CASA(Posicion, 4) = Form1.CheckLaptop.Text
            CASA(Posicion, 6) = Str(CASA(Posicion, 3) + Laptoplargo)
        End If

        If (Form1.CheckRefri.Checked) Then
            CASA(Posicion, 4) = Form1.CheckRefri.Text
            CASA(Posicion, 6) = Str(CASA(Posicion, 3) + Refrilargo)
        End If

        If (Form1.CheckTV.Checked And Form1.CheckRefri.Checked) Then
            CASA(Posicion, 4) = "TV Y REFI"
            CASA(Posicion, 6) = Str((CASA(Posicion, 3) + Tvcorto) + (CASA(Posicion, 3) + Refricorto))
        End If

        If (Form1.CheckTV.Checked And Form1.CheckRefri.Checked) Then
            CASA(Posicion, 4) = "TV Y REFI"
            CASA(Posicion, 6) = Str((CASA(Posicion, 3) + Tvlargo) + (CASA(Posicion, 3) + Refrilargo))
        End If

        If (Form1.CheckTEL.Checked And Form1.CheckLaptop.Checked) Then
            CASA(Posicion, 4) = "TELEFONO Y LAPTOP"
            CASA(Posicion, 6) = Str((CASA(Posicion, 3) + TELcorto) + (CASA(Posicion, 3) + Laptopcorto))
        End If

        If (Form1.CheckTEL.Checked And Form1.CheckLaptop.Checked) Then
            CASA(Posicion, 4) = "TELEFONO Y LAPTOP"
            CASA(Posicion, 6) = Str((CASA(Posicion, 3) + TELlargo) + (CASA(Posicion, 3) + Laptoplargo))
        End If

    End Sub
    Sub DESCUENTO()
        If (Form1.CheckTV.Checked And Form1.CheckRefri.Checked And Form1.RBotonCorto.Checked) Then
            CASA(Posicion, 7) = Str(Round((CASA(Posicion, 6) * 0.15), 2))
            CASA(Posicion, 5) = Form1.RBotonCorto.Text
        End If
        If (Form1.CheckTV.Checked And Form1.CheckRefri.Checked And Form1.RBotonLargo.Checked) Then
            CASA(Posicion, 7) = Str(Round((CASA(Posicion, 6) * 0.05), 2))
            CASA(Posicion, 5) = Form1.RBotonLargo.Text
        End If

        If (Form1.CheckTEL.Checked And Form1.CheckLaptop.Checked And Form1.RBotonCorto.Checked) Then
            CASA(Posicion, 7) = Str(Round((CASA(Posicion, 6) * 0.05), 2))
            CASA(Posicion, 5) = Form1.RBotonCorto.Text
        End If

        If (Form1.CheckTEL.Checked And Form1.CheckLaptop.Checked And Form1.RBotonLargo.Checked) Then
            CASA(Posicion, 7) = Str(Round((CASA(Posicion, 6) * 0.05), 2))
            CASA(Posicion, 5) = Form1.RBotonLargo.Text
        End If

    End Sub
    Sub TOTAL()
        CASA(Posicion, 8) = Str(CASA(Posicion, 6) - CASA(Posicion, 7))

    End Sub

    Sub MOSTRAR()
        Form1.ListBoxName.Items.Add(CASA(Posicion, 0))
        Form1.ListBoxCui.Items.Add(CASA(Posicion, 1))
        Form1.ListBoxDirecc.Items.Add(CASA(Posicion, 2))
        Form1.ListBoxcosto.Items.Add(CASA(Posicion, 3))
        Form1.ListBoxAparato.Items.Add(CASA(Posicion, 4))
        Form1.ListBoxPlazo.Items.Add(CASA(Posicion, 5))
        Form1.ListBoxPParcial.Items.Add(CASA(Posicion, 6))
        Form1.ListBoxDesc.Items.Add(CASA(Posicion, 7))
        Form1.ListBoxPfinal.Items.Add(CASA(Posicion, 8))
    End Sub

End Module
