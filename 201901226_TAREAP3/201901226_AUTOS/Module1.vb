Imports System.Math
Module Module1
    Public Auto As Byte = 0
    Public Carro(7) As String
    Public KMI(7) As Double
    Public KMF(7) As Double
    Public Placa(7) As Integer
    Public CobroBase(7) As Double
    Public PagoFinal(7) As Double
    Public CobroporKM(7) As Double
    Public Kilometraje(7) As Double
    Public Const Tipo1 = 500
    Public Const Tipo2 = 400
    Public Const Tipo3 = 300
    Public Const Tipo4 = 200
    Public I As Byte

    Function BASE() As Double
        Select Case (Form1.ComboBoxTipoCarro.SelectedIndex)
            Case 0
                Carro(Auto) = Form1.ComboBoxTipoCarro.Text
                BASE = Tipo1
            Case 1
                Carro(Auto) = Form1.ComboBoxTipoCarro.Text
                BASE = Tipo2
            Case 2
                Carro(Auto) = Form1.ComboBoxTipoCarro.Text
                BASE = Tipo3
            Case 3
                Carro(Auto) = Form1.ComboBoxTipoCarro.Text
                BASE = Tipo4
            Case Else
                MsgBox("ERROR NO SLECCIONÓ TIPO DE AUTO")
                Form1.ComboBoxTipoCarro.Focus()
                Exit Function
        End Select
        Return BASE
    End Function

    Sub LIMPIAR1()


        Form1.DataGridView1.Rows.Clear()

        Auto = 0

        For I = 0 To 6
            Carro(I) = Nothing
            KMI(I) = Nothing
            KMF(I) = Nothing
            Placa(I) = Nothing
            CobroBase(I) = Nothing
            PagoFinal(I) = Nothing
            CobroporKM(I) = Nothing
            Kilometraje(I) = Nothing
        Next I

    End Sub

    Sub MOSTRAR1()
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 6
            If Placa(I) <> Nothing Then
                Form1.DataGridView1.Rows.Add(Str(Placa(I)), Carro(I), Str(CobroBase(I)), Str(KMI(I)), Str(KMF(I)), Str(CobroporKM(I)), Str(PagoFinal(I)))

            Else
                Exit For
            End If
        Next I

    End Sub

End Module
