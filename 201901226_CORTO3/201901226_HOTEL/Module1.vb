Imports System.Math
Module Module1
    Public Huesped As Byte = 0
    Public Nombre(7) As String
    Public Nit(7) As Integer
    Public Impuesto(7) As Double
    Public Dias(7) As Integer
    Public Habitacion(7) As String
    Public Pago(7) As String
    Public TotParcial(7) As Double
    Public Desc(7) As Double
    Public TotFinal(7) As Double
    Public I As Byte
    Public Const Sencilla = 250
    Public Const Doble = 400
    Public Const Cabaña = 650
    Public Const descefectivo = 0.15
    Public Const recargo = 0.03

    Function Descuento1() As Double
        Select Case (Form1.ComboBox2.SelectedIndex)
            Case 0
                Pago(Huesped) = Form1.ComboBox2.Text
                Descuento1 = TotParcial(Huesped) * descefectivo * -1
            Case 1
                Pago(Huesped) = Form1.ComboBox2.Text
                Descuento1 = TotParcial(Huesped) * recargo * -1
            Case Else
                MsgBox("NO SELECCIONÓ TIPO DE PAGO")
                Form1.ComboBox2.Focus()
                Exit Function

        End Select
        Return Descuento1
    End Function
    Function TOTAL1() As Double
        TOTAL1 = TotParcial(Huesped) + Desc(Huesped)
        Return TOTAL1
    End Function

    Sub MOSTRAR1()
        Form1.DataGridView1.Rows.Clear()

        For I = 0 To 6
            If (Nit(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Nombre(I), Str(Nit(I)), Str(Dias(I)), Str(Impuesto(I)), Habitacion(I), Pago(I), Str(TotParcial(I)), Str(Desc(I)), Str(TotFinal(I)))
            Else
                Exit For
            End If

        Next I
    End Sub
    Sub CONSULTAR1()
        Dim existe As Boolean = True
        A = 0
        While (I <= 7) And (existe)
            If (Nit(A, 0) <> Nothing) Then
                If (Val(Nit(A, 0)) = Val(Form1.TextBox1.Text)) Then
                    existe = False
                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While
        If (existe) Then
            MsgBox("Carnet no encontrado")

    End Sub
End Module
