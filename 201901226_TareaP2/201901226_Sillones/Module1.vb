Imports System.Math
Module Module1
    Public posicion As Byte = 0
    Public VENTA(8) As Integer
    Public CANTIDAD(8) As Integer
    Public TELA(8) As String
    Public TAMAÑO(8) As String
    Public PRECIOCOSTO(8) As Double
    Public PRECIOVENTA(8) As Double
    Public MANOOBRA(8) As Double
    Public YARDA(8) As Double
    Public MATERIAL(8) As Double
    Public Const yrdsofa = 8
    Public Const yrdindividual = 3.5
    Public Const yrddoble = 6
    Public Const Preciosofa = 250.99
    Public Const Precioindi = 150.99
    Public Const Preciodoble = 200.99
    Public Const cuero = 75
    Public Const cuerina = 45.99

    Sub Tamaño1()
        Select Case (Form1.ComboBox1.SelectedIndex)
            Case 0
                TAMAÑO(posicion) = Form1.ComboBox1.Text
                MANOOBRA(posicion) = Round((CANTIDAD(posicion) * Preciosofa), 2)
                YARDA(posicion) = yrdsofa
            Case 1
                TAMAÑO(posicion) = Form1.ComboBox1.Text
                MANOOBRA(posicion) = Round((CANTIDAD(posicion) * Precioindi), 2)
                YARDA(posicion) = yrdindividual
            Case 2
                TAMAÑO(posicion) = Form1.ComboBox1.Text
                MANOOBRA(posicion) = Round((CANTIDAD(posicion) * Preciodoble), 2)
                YARDA(posicion) = yrddoble

        End Select

    End Sub

    Sub TELA1()
        If (Form1.RBotonCuero.Checked) Then
            TELA(posicion) = Form1.RBotonCuero.Text
            MATERIAL(posicion) = Round(YARDA(posicion) * cuero * CANTIDAD(posicion), 2)
        ElseIf (Form1.RBotonCuerina.Checked) Then
            TELA(posicion) = Form1.RBotonCuerina.Text
            MATERIAL(posicion) = Round(YARDA(posicion) * cuerina * CANTIDAD(posicion), 2)
        Else
            MsgBox("SELECCIONE TIPO DE TELA")
            Exit Sub
            Form1.RBotonCuero.Focus()

        End If
    End Sub
    Sub PRECIOCOSTO1()
        PRECIOCOSTO(posicion) = MANOOBRA(posicion) + MATERIAL(posicion)
    End Sub

    Sub PRECIOVENTA1()
        PRECIOVENTA(posicion) = Round((PRECIOCOSTO(posicion) * 0.65) + PRECIOCOSTO(posicion), 2)
    End Sub

    Sub MOSTRAR()
        Form1.DataGridView1.Rows.Add(Str(VENTA(posicion)), Str(CANTIDAD(posicion)), TAMAÑO(posicion), TELA(posicion), Str(MANOOBRA(posicion)), Str(PRECIOCOSTO(posicion)), Str(PRECIOVENTA(posicion)))
    End Sub

    Sub LIMPIAR1()
        Dim v As Byte
        For v = 0 To 7
            VENTA(v) = Nothing
            CANTIDAD(v) = Nothing
            TELA(v) = Nothing
            TAMAÑO(v) = Nothing
            PRECIOCOSTO(v) = Nothing
            PRECIOVENTA(v) = Nothing
            MANOOBRA(v) = Nothing
            YARDA(v) = Nothing
            MATERIAL(v) = Nothing
        Next v
        posicion = 0
    End Sub
    Sub LIMPIAR2()
        Form1.TxtCantidad.Clear()
        Form1.TxtNVenta.Clear()
        Form1.RBotonCuero.Checked = 0
        Form1.RBotonCuerina.Checked = 0
        Form1.ComboBox1.SelectedIndex = -1

    End Sub


End Module

