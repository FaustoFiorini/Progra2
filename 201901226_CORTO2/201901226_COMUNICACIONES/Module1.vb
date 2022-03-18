Imports System.Math
Module Module1
    Public posicion As Byte = 0
    Public Nombre(7) As String
    Public SUELDO(7) As Integer
    Public CANTIDAD(7) As Integer
    Public ARTICULO(7) As String
    Public COMISIÓN(7) As Double
    Public BONO(7) As Double
    Public SUELDOFINAL(7) As Double
    Public VENTA(7) As Double
    Public Const tablet = 375
    Public Const drone = 560
    Public Const celular = 1450
    Public Const televisor = 3250


    Sub LIMPIAR1()
        posicion = 0
        Form1.ListBoxName.Items.Clear()
        Form1.ListBoxSueldo.Items.Clear()
        Form1.ListBoxCant.Items.Clear()
        Form1.ListBoxArt.Items.Clear()
        Form1.ListBoxArt.Items.Clear()
        Form1.ListBoxBono.Items.Clear()
        Form1.ListBoxSueldoF.Items.Clear()
    End Sub
    Sub LIMPIAR2()
        Form1.TxtNombre.Clear()
        Form1.TxtSueldo.Clear()
        Form1.TxtCantidad.Clear()
        Form1.RBotonCel.Checked = 0
        Form1.RBotonDrone.Checked = 0
        Form1.RBotonTablet.Checked = 0
        Form1.RBotonTV.Checked = 0
    End Sub

    Sub VENTA1()
        If (Form1.RBotonTablet.Checked) Then
            ARTICULO(posicion) = Form1.RBotonTablet.Text
            VENTA(posicion) = Round((tablet * CANTIDAD(posicion)), 2)
        ElseIf (Form1.RBotonDrone.Checked) Then
            ARTICULO(posicion) = Form1.RBotonDrone.Text
            VENTA(posicion) = Round((drone * CANTIDAD(posicion)), 2)
        ElseIf (Form1.RBotonCel.Checked) Then
            ARTICULO(posicion) = Form1.RBotonCel.Text
            VENTA(posicion) = Round((celular * CANTIDAD(posicion)), 2)
        ElseIf (Form1.RBotonTV.Checked) Then
            ARTICULO(posicion) = Form1.RBotonTV.Text
            VENTA(posicion) = Round((televisor * CANTIDAD(posicion)), 2)

        End If


    End Sub

    Sub Mostrar()
        Form1.ListBoxName.Items.Add(Nombre(posicion))
        Form1.ListBoxSueldo.Items.Add(SUELDO(posicion))
        Form1.ListBoxCant.Items.Add(CANTIDAD(posicion))
        Form1.ListBoxArt.Items.Add(ARTICULO(posicion))
        Form1.ListBoxComi.Items.Add(Str(COMISIÓN(posicion)))
        Form1.ListBoxBono.Items.Add(Str(BONO(posicion)))
        Form1.ListBoxSueldoF.Items.Add(Str(SUELDOFINAL(posicion)))

    End Sub

    Sub BONO1()
        If (SUELDO(posicion) > 1 And SUELDO(posicion) <= 200) Then
            BONO(posicion) = Round((SUELDO(posicion) * 0.03), 2)

        End If
    End Sub



End Module
