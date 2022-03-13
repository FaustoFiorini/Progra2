Imports System.Math
Module Module1
    Public Posicion As Byte = 0
    Public Estudiante(7, 10)
    Public Const idiomaingles = 150
    Public Const idiomaportuges = 80
    Public Const idiomafrances = 125
    Public Const descefec = 0.02
    Public Const desccheque = 0.015
    Public Const descdias = 0.05

    Sub LIMPIAR1()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.TxtNombre.Clear()
        Form1.TxtCarnet.Clear()
        Form1.TxtInscripción.Clear()
        Form1.RBotonCheque.Checked = 0
        Form1.RBotonEfectivo.Checked = 0
        Form1.CheckSábado.Checked = 0
        Form1.CheckViernes.Checked = 0

    End Sub
    Sub LIMPIAR2()
        Posicion = 0
        Form1.DataGridView1.Rows.Clear()

    End Sub

    Sub PAGOPARCIAL()
        Select Case (Form1.ComboBox1.SelectedIndex)
            Case 0
                Estudiante(Posicion, 7) = Str(Round(idiomaingles * Estudiante(Posicion, 5), 2))
            Case 1
                Estudiante(Posicion, 7) = Str(Round(idiomaportuges * Estudiante(Posicion, 5), 2))
            Case 2
                Estudiante(Posicion, 7) = Str(Round(idiomafrances * Estudiante(Posicion, 5), 2))
            Case Else
                MsgBox("SELECCIONE IDIOMA")
                Form1.ComboBox1.Focus()
                Exit Sub
        End Select
    End Sub
    Function DESC1() As String


        If (Form1.RBotonEfectivo.Checked) Then
            Estudiante(Posicion, 6) = Form1.RBotonEfectivo.Text
            DESC1 = Str(Estudiante(Posicion, 7) * descefec)
        ElseIf (Form1.RBotonCheque.Checked) Then
            Estudiante(Posicion, 6) = Form1.RBotonCheque.Text
            DESC1 = Str(Estudiante(Posicion, 7) * desccheque)

        Else
            MsgBox("NO SELECCIONÓ TIPO DE PAGO")

        End If
        Return DESC1
    End Function

    Sub PAGOFINAL()
        Estudiante(Posicion, 10) = Str(Val(Estudiante(Posicion, 7)) - (Val(Estudiante(Posicion, 8)) + Val(Estudiante(Posicion, 9))))

    End Sub

    Sub MOSTRAR()
        Form1.DataGridView1.Rows.Add(Estudiante(Posicion, 0), Estudiante(Posicion, 1), Estudiante(Posicion, 2), Estudiante(Posicion, 3), Estudiante(Posicion, 4), Estudiante(Posicion, 5), Estudiante(Posicion, 6), Estudiante(Posicion, 7), Estudiante(Posicion, 8), Estudiante(Posicion, 9), Estudiante(Posicion, 10))
    End Sub


End Module
