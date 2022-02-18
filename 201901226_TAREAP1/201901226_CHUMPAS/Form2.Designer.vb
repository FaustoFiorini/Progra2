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
        Me.TxtPCA = New System.Windows.Forms.TextBox()
        Me.TxtPCS = New System.Windows.Forms.TextBox()
        Me.TxtPCL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtPVA = New System.Windows.Forms.TextBox()
        Me.TxtPVS = New System.Windows.Forms.TextBox()
        Me.TxtPVL = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTotalF = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BotonRegresar = New System.Windows.Forms.Button()
        Me.BotonSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtPCA
        '
        Me.TxtPCA.Enabled = False
        Me.TxtPCA.Location = New System.Drawing.Point(246, 38)
        Me.TxtPCA.Name = "TxtPCA"
        Me.TxtPCA.Size = New System.Drawing.Size(114, 28)
        Me.TxtPCA.TabIndex = 0
        '
        'TxtPCS
        '
        Me.TxtPCS.Enabled = False
        Me.TxtPCS.Location = New System.Drawing.Point(246, 69)
        Me.TxtPCS.Name = "TxtPCS"
        Me.TxtPCS.Size = New System.Drawing.Size(114, 28)
        Me.TxtPCS.TabIndex = 1
        '
        'TxtPCL
        '
        Me.TxtPCL.Enabled = False
        Me.TxtPCL.Location = New System.Drawing.Point(246, 100)
        Me.TxtPCL.Name = "TxtPCL"
        Me.TxtPCL.Size = New System.Drawing.Size(114, 28)
        Me.TxtPCL.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label1.Location = New System.Drawing.Point(14, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CHUMPA DE ALGODON"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Location = New System.Drawing.Point(14, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CHUMPA DE SEDA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(14, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CHUMPA DE LONA"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtPCL)
        Me.GroupBox1.Controls.Add(Me.TxtPCS)
        Me.GroupBox1.Controls.Add(Me.TxtPCA)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 149)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRECIO COSTO"
        '
        'TxtPVA
        '
        Me.TxtPVA.Enabled = False
        Me.TxtPVA.Location = New System.Drawing.Point(245, 31)
        Me.TxtPVA.Name = "TxtPVA"
        Me.TxtPVA.Size = New System.Drawing.Size(114, 28)
        Me.TxtPVA.TabIndex = 7
        '
        'TxtPVS
        '
        Me.TxtPVS.Enabled = False
        Me.TxtPVS.Location = New System.Drawing.Point(245, 63)
        Me.TxtPVS.Name = "TxtPVS"
        Me.TxtPVS.Size = New System.Drawing.Size(114, 28)
        Me.TxtPVS.TabIndex = 8
        '
        'TxtPVL
        '
        Me.TxtPVL.Enabled = False
        Me.TxtPVL.Location = New System.Drawing.Point(245, 97)
        Me.TxtPVL.Name = "TxtPVL"
        Me.TxtPVL.Size = New System.Drawing.Size(114, 28)
        Me.TxtPVL.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Menu
        Me.Label4.Location = New System.Drawing.Point(6, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "CHUMPA DE ALGODÓN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label5.Location = New System.Drawing.Point(6, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "CHUMPA DE SEDA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(6, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "CHUMPA DE LONA"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtPVL)
        Me.GroupBox2.Controls.Add(Me.TxtPVS)
        Me.GroupBox2.Controls.Add(Me.TxtPVA)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 164)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PRECIO DE VENTA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label7.Location = New System.Drawing.Point(14, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 21)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "TOTAL A PAGAR"
        '
        'TxtTotalF
        '
        Me.TxtTotalF.Enabled = False
        Me.TxtTotalF.Location = New System.Drawing.Point(176, 30)
        Me.TxtTotalF.Name = "TxtTotalF"
        Me.TxtTotalF.Size = New System.Drawing.Size(114, 28)
        Me.TxtTotalF.TabIndex = 15
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtTotalF)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(473, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(316, 84)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PRECIO FINAL"
        '
        'BotonRegresar
        '
        Me.BotonRegresar.BackColor = System.Drawing.SystemColors.Info
        Me.BotonRegresar.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonRegresar.Location = New System.Drawing.Point(482, 234)
        Me.BotonRegresar.Name = "BotonRegresar"
        Me.BotonRegresar.Size = New System.Drawing.Size(113, 39)
        Me.BotonRegresar.TabIndex = 17
        Me.BotonRegresar.Text = "REGRESAR"
        Me.BotonRegresar.UseVisualStyleBackColor = False
        '
        'BotonSalir
        '
        Me.BotonSalir.BackColor = System.Drawing.Color.Red
        Me.BotonSalir.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonSalir.Location = New System.Drawing.Point(621, 234)
        Me.BotonSalir.Name = "BotonSalir"
        Me.BotonSalir.Size = New System.Drawing.Size(120, 39)
        Me.BotonSalir.TabIndex = 18
        Me.BotonSalir.Text = "SALIR"
        Me.BotonSalir.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.BotonSalir)
        Me.Controls.Add(Me.BotonRegresar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtPCA As TextBox
    Friend WithEvents TxtPCS As TextBox
    Friend WithEvents TxtPCL As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtPVA As TextBox
    Friend WithEvents TxtPVS As TextBox
    Friend WithEvents TxtPVL As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTotalF As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BotonRegresar As Button
    Friend WithEvents BotonSalir As Button
End Class
