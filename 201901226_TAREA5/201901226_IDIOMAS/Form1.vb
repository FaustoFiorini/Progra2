Public Class Form1
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿ESTÁ SEGURO QUE QUIERE SALIR?", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIAR1()
        TxtNombre.Focus()


    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        LIMPIAR2()

    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (Posicion <= 7) Then
            Estudiante(Posicion, 0) = TxtNombre.Text
            Estudiante(Posicion, 1) = Val(TxtCarnet.Text)
            Estudiante(Posicion, 2) = DateValue(TxtInscripción.Text)
            Estudiante(Posicion, 3) = ComboBox1.Text
            Estudiante(Posicion, 5) = Val(InputBox("HORAS A CURSAR POR DÍA"))
            PAGOPARCIAL()
            Estudiante(Posicion, 8) = DESC1()


            If (CheckViernes.Checked) Then
                Estudiante(Posicion, 4) = CheckViernes.Text
                Estudiante(Posicion, 9) = ""
            End If


            If (CheckSábado.Checked) Then
                Estudiante(Posicion, 4) = CheckSábado.Text
                Estudiante(Posicion, 9) = ""
            End If


            If (CheckViernes.Checked And CheckSábado.Checked) Then
                Estudiante(Posicion, 4) = "AMBOS DÍAS"
                Estudiante(Posicion, 9) = Str(Estudiante(Posicion, 7) * descdias)

            End If



            PAGOFINAL()
            MOSTRAR()
            Posicion = Posicion + 1




        End If
            If (Posicion = 8) Then
            MsgBox("MATRIZ LLENA")
        End If


    End Sub
End Class
