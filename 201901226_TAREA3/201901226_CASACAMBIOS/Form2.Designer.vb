<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.TxtComisionC = New System.Windows.Forms.TextBox()
        Me.TxtComisionV = New System.Windows.Forms.TextBox()
        Me.TxtTotalFinal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GrpResultados = New System.Windows.Forms.GroupBox()
        Me.BotonRegresar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.GrpResultados.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtComisionC
        '
        Me.TxtComisionC.Enabled = False
        Me.TxtComisionC.Location = New System.Drawing.Point(223, 33)
        Me.TxtComisionC.Name = "TxtComisionC"
        Me.TxtComisionC.Size = New System.Drawing.Size(178, 31)
        Me.TxtComisionC.TabIndex = 0
        '
        'TxtComisionV
        '
        Me.TxtComisionV.Enabled = False
        Me.TxtComisionV.Location = New System.Drawing.Point(223, 80)
        Me.TxtComisionV.Name = "TxtComisionV"
        Me.TxtComisionV.Size = New System.Drawing.Size(178, 31)
        Me.TxtComisionV.TabIndex = 1
        '
        'TxtTotalFinal
        '
        Me.TxtTotalFinal.Enabled = False
        Me.TxtTotalFinal.Location = New System.Drawing.Point(223, 127)
        Me.TxtTotalFinal.Name = "TxtTotalFinal"
        Me.TxtTotalFinal.Size = New System.Drawing.Size(178, 31)
        Me.TxtTotalFinal.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(16, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "COMISIÓN POR COMPRA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(16, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "COMISIÓN POR VENTA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(16, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TOTAL FINAL"
        '
        'GrpResultados
        '
        Me.GrpResultados.Controls.Add(Me.Label3)
        Me.GrpResultados.Controls.Add(Me.Label2)
        Me.GrpResultados.Controls.Add(Me.Label1)
        Me.GrpResultados.Controls.Add(Me.TxtTotalFinal)
        Me.GrpResultados.Controls.Add(Me.TxtComisionV)
        Me.GrpResultados.Controls.Add(Me.TxtComisionC)
        Me.GrpResultados.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GrpResultados.Location = New System.Drawing.Point(14, 22)
        Me.GrpResultados.Name = "GrpResultados"
        Me.GrpResultados.Size = New System.Drawing.Size(444, 190)
        Me.GrpResultados.TabIndex = 6
        Me.GrpResultados.TabStop = False
        Me.GrpResultados.Text = "RESULTADOS"
        '
        'BotonRegresar
        '
        Me.BotonRegresar.BackColor = System.Drawing.SystemColors.Info
        Me.BotonRegresar.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BotonRegresar.Location = New System.Drawing.Point(62, 255)
        Me.BotonRegresar.Name = "BotonRegresar"
        Me.BotonRegresar.Size = New System.Drawing.Size(120, 29)
        Me.BotonRegresar.TabIndex = 7
        Me.BotonRegresar.Text = "REGRESAR"
        Me.BotonRegresar.UseVisualStyleBackColor = False
        '
        'ButtonSalir
        '
        Me.ButtonSalir.BackColor = System.Drawing.Color.Red
        Me.ButtonSalir.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonSalir.Location = New System.Drawing.Point(364, 255)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(94, 29)
        Me.ButtonSalir.TabIndex = 9
        Me.ButtonSalir.Text = "SALIR"
        Me.ButtonSalir.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(572, 347)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.BotonRegresar)
        Me.Controls.Add(Me.GrpResultados)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GrpResultados.ResumeLayout(False)
        Me.GrpResultados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtComisionC As TextBox
    Friend WithEvents TxtComisionV As TextBox
    Friend WithEvents TxtTotalFinal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GrpResultados As GroupBox
    Friend WithEvents BotonRegresar As Button
    Friend WithEvents ButtonSalir As Button
End Class
