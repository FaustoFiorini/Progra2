<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RBotonS = New System.Windows.Forms.RadioButton()
        Me.RBotonM = New System.Windows.Forms.RadioButton()
        Me.RBotonL = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAlgodon = New System.Windows.Forms.TextBox()
        Me.TxtSeda = New System.Windows.Forms.TextBox()
        Me.TxtLona = New System.Windows.Forms.TextBox()
        Me.BotonCalcular = New System.Windows.Forms.Button()
        Me.BotonLimpiar = New System.Windows.Forms.Button()
        Me.BotonSalir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBotonAlg = New System.Windows.Forms.RadioButton()
        Me.RBotonSeda = New System.Windows.Forms.RadioButton()
        Me.RBotonLona = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RBotonS
        '
        Me.RBotonS.AutoSize = True
        Me.RBotonS.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.RBotonS.Location = New System.Drawing.Point(19, 37)
        Me.RBotonS.Name = "RBotonS"
        Me.RBotonS.Size = New System.Drawing.Size(81, 25)
        Me.RBotonS.TabIndex = 0
        Me.RBotonS.TabStop = True
        Me.RBotonS.Text = "SMALL"
        Me.RBotonS.UseVisualStyleBackColor = False
        '
        'RBotonM
        '
        Me.RBotonM.AutoSize = True
        Me.RBotonM.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.RBotonM.Location = New System.Drawing.Point(19, 74)
        Me.RBotonM.Name = "RBotonM"
        Me.RBotonM.Size = New System.Drawing.Size(96, 25)
        Me.RBotonM.TabIndex = 1
        Me.RBotonM.TabStop = True
        Me.RBotonM.Text = "MEDIUM"
        Me.RBotonM.UseVisualStyleBackColor = False
        '
        'RBotonL
        '
        Me.RBotonL.AutoSize = True
        Me.RBotonL.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBotonL.Location = New System.Drawing.Point(19, 108)
        Me.RBotonL.Name = "RBotonL"
        Me.RBotonL.Size = New System.Drawing.Size(79, 25)
        Me.RBotonL.TabIndex = 2
        Me.RBotonL.TabStop = True
        Me.RBotonL.Text = "LARGE"
        Me.RBotonL.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBotonL)
        Me.GroupBox1.Controls.Add(Me.RBotonM)
        Me.GroupBox1.Controls.Add(Me.RBotonS)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 171)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAMAÑO CHUMPA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(302, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MATERIAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(462, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "CANTIDAD"
        '
        'TxtAlgodon
        '
        Me.TxtAlgodon.Location = New System.Drawing.Point(465, 66)
        Me.TxtAlgodon.Name = "TxtAlgodon"
        Me.TxtAlgodon.Size = New System.Drawing.Size(82, 28)
        Me.TxtAlgodon.TabIndex = 8
        '
        'TxtSeda
        '
        Me.TxtSeda.Location = New System.Drawing.Point(465, 101)
        Me.TxtSeda.Name = "TxtSeda"
        Me.TxtSeda.Size = New System.Drawing.Size(82, 28)
        Me.TxtSeda.TabIndex = 9
        '
        'TxtLona
        '
        Me.TxtLona.Location = New System.Drawing.Point(465, 137)
        Me.TxtLona.Name = "TxtLona"
        Me.TxtLona.Size = New System.Drawing.Size(82, 28)
        Me.TxtLona.TabIndex = 10
        '
        'BotonCalcular
        '
        Me.BotonCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BotonCalcular.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCalcular.Location = New System.Drawing.Point(244, 335)
        Me.BotonCalcular.Name = "BotonCalcular"
        Me.BotonCalcular.Size = New System.Drawing.Size(116, 36)
        Me.BotonCalcular.TabIndex = 11
        Me.BotonCalcular.Text = "CALCULAR"
        Me.BotonCalcular.UseVisualStyleBackColor = False
        '
        'BotonLimpiar
        '
        Me.BotonLimpiar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BotonLimpiar.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonLimpiar.Location = New System.Drawing.Point(412, 335)
        Me.BotonLimpiar.Name = "BotonLimpiar"
        Me.BotonLimpiar.Size = New System.Drawing.Size(103, 36)
        Me.BotonLimpiar.TabIndex = 12
        Me.BotonLimpiar.Text = "LIMPIAR"
        Me.BotonLimpiar.UseVisualStyleBackColor = False
        '
        'BotonSalir
        '
        Me.BotonSalir.BackColor = System.Drawing.Color.Red
        Me.BotonSalir.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonSalir.Location = New System.Drawing.Point(573, 335)
        Me.BotonSalir.Name = "BotonSalir"
        Me.BotonSalir.Size = New System.Drawing.Size(103, 36)
        Me.BotonSalir.TabIndex = 13
        Me.BotonSalir.Text = "SALIR"
        Me.BotonSalir.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtLona)
        Me.GroupBox2.Controls.Add(Me.RBotonLona)
        Me.GroupBox2.Controls.Add(Me.RBotonSeda)
        Me.GroupBox2.Controls.Add(Me.RBotonAlg)
        Me.GroupBox2.Controls.Add(Me.TxtSeda)
        Me.GroupBox2.Controls.Add(Me.TxtAlgodon)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(107, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(599, 206)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS"
        '
        'RBotonAlg
        '
        Me.RBotonAlg.AutoSize = True
        Me.RBotonAlg.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.RBotonAlg.Location = New System.Drawing.Point(305, 70)
        Me.RBotonAlg.Name = "RBotonAlg"
        Me.RBotonAlg.Size = New System.Drawing.Size(107, 25)
        Me.RBotonAlg.TabIndex = 14
        Me.RBotonAlg.TabStop = True
        Me.RBotonAlg.Text = "ALGODÓN"
        Me.RBotonAlg.UseVisualStyleBackColor = False
        '
        'RBotonSeda
        '
        Me.RBotonSeda.AutoSize = True
        Me.RBotonSeda.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.RBotonSeda.Location = New System.Drawing.Point(305, 103)
        Me.RBotonSeda.Name = "RBotonSeda"
        Me.RBotonSeda.Size = New System.Drawing.Size(72, 25)
        Me.RBotonSeda.TabIndex = 14
        Me.RBotonSeda.TabStop = True
        Me.RBotonSeda.Text = "SEDA"
        Me.RBotonSeda.UseVisualStyleBackColor = False
        '
        'RBotonLona
        '
        Me.RBotonLona.AutoSize = True
        Me.RBotonLona.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.RBotonLona.Location = New System.Drawing.Point(306, 137)
        Me.RBotonLona.Name = "RBotonLona"
        Me.RBotonLona.Size = New System.Drawing.Size(74, 25)
        Me.RBotonLona.TabIndex = 15
        Me.RBotonLona.TabStop = True
        Me.RBotonLona.Text = "LONA"
        Me.RBotonLona.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(902, 491)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BotonSalir)
        Me.Controls.Add(Me.BotonLimpiar)
        Me.Controls.Add(Me.BotonCalcular)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RBotonS As RadioButton
    Friend WithEvents RBotonM As RadioButton
    Friend WithEvents RBotonL As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAlgodon As TextBox
    Friend WithEvents TxtSeda As TextBox
    Friend WithEvents TxtLona As TextBox
    Friend WithEvents BotonCalcular As Button
    Friend WithEvents BotonLimpiar As Button
    Friend WithEvents BotonSalir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RBotonLona As RadioButton
    Friend WithEvents RBotonSeda As RadioButton
    Friend WithEvents RBotonAlg As RadioButton
End Class
