Public Class Form1
    Dim LIBRAS_DE_ARROZ As Integer
    Dim LIBRAS_DE_FRIJOL As Integer
    Dim LIBRAS_DE_AZÚCAR As Integer
    Dim NOMBRE_DEL_CLIENTE As String
    Dim PAGO_A_REALIZAR As Double
    Dim IVA As Double
    Dim PAGO_CON_IVA As Double
    Dim DESCUENTO As Double
    Dim PAGO_FINAL As Double
    Const ivaa = 12 / 100
    Const desc = 0.025
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LIBRAS_DE_ARROZ = TextBox2.Text
        LIBRAS_DE_FRIJOL = TextBox3.Text
        LIBRAS_DE_AZÚCAR = TextBox4.Text
        NOMBRE_DEL_CLIENTE = TextBox1.Text


        PAGO_A_REALIZAR = System.Math.Round(((LIBRAS_DE_ARROZ * 2) + (LIBRAS_DE_FRIJOL * 1.75) + (LIBRAS_DE_AZÚCAR * 2.5)), 2)
        IVA = System.Math.Round((PAGO_A_REALIZAR * ivaa), 2)
        PAGO_CON_IVA = System.Math.Round((PAGO_A_REALIZAR + IVA), 2)
        DESCUENTO = System.Math.Round((PAGO_CON_IVA * desc), 2)
        PAGO_FINAL = System.Math.Round((PAGO_CON_IVA - DESCUENTO), 2)

        TextBox5.Text = PAGO_A_REALIZAR.ToString
        TextBox6.Text = IVA.ToString
        TextBox7.Text = PAGO_CON_IVA.ToString
        TextBox8.Text = DESCUENTO.ToString
        TextBox9.Text = PAGO_FINAL.ToString

        GroupBox2.Visible = True


    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Clear()
        TextBox2.Focus()
        GroupBox2.Visible = False


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
