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
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMontoEnvio = New System.Windows.Forms.TextBox()
        Me.RBotonN = New System.Windows.Forms.RadioButton()
        Me.RBotonS = New System.Windows.Forms.RadioButton()
        Me.RBotonOR = New System.Windows.Forms.RadioButton()
        Me.RBotonOC = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBotonSV = New System.Windows.Forms.RadioButton()
        Me.RBotonSA = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BotonCalcular = New System.Windows.Forms.Button()
        Me.BotonLimpiar = New System.Windows.Forms.Button()
        Me.BotonSalir = New System.Windows.Forms.Button()
        Me.TxtMontoSeguro = New System.Windows.Forms.TextBox()
        Me.TxtSueldoFinal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(162, 28)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(259, 22)
        Me.TxtNombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(14, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Info
        Me.Label2.Location = New System.Drawing.Point(14, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MONTO DE ENVÍO"
        '
        'TxtMontoEnvio
        '
        Me.TxtMontoEnvio.Location = New System.Drawing.Point(162, 56)
        Me.TxtMontoEnvio.Name = "TxtMontoEnvio"
        Me.TxtMontoEnvio.Size = New System.Drawing.Size(140, 22)
        Me.TxtMontoEnvio.TabIndex = 3
        '
        'RBotonN
        '
        Me.RBotonN.AutoSize = True
        Me.RBotonN.Location = New System.Drawing.Point(25, 26)
        Me.RBotonN.Name = "RBotonN"
        Me.RBotonN.Size = New System.Drawing.Size(76, 20)
        Me.RBotonN.TabIndex = 4
        Me.RBotonN.TabStop = True
        Me.RBotonN.Text = "NORTE"
        Me.RBotonN.UseVisualStyleBackColor = True
        '
        'RBotonS
        '
        Me.RBotonS.AutoSize = True
        Me.RBotonS.Location = New System.Drawing.Point(25, 52)
        Me.RBotonS.Name = "RBotonS"
        Me.RBotonS.Size = New System.Drawing.Size(57, 20)
        Me.RBotonS.TabIndex = 5
        Me.RBotonS.TabStop = True
        Me.RBotonS.Text = "SUR"
        Me.RBotonS.UseVisualStyleBackColor = True
        '
        'RBotonOR
        '
        Me.RBotonOR.AutoSize = True
        Me.RBotonOR.Location = New System.Drawing.Point(25, 78)
        Me.RBotonOR.Name = "RBotonOR"
        Me.RBotonOR.Size = New System.Drawing.Size(88, 20)
        Me.RBotonOR.TabIndex = 6
        Me.RBotonOR.TabStop = True
        Me.RBotonOR.Text = "ORIENTE"
        Me.RBotonOR.UseVisualStyleBackColor = True
        '
        'RBotonOC
        '
        Me.RBotonOC.AutoSize = True
        Me.RBotonOC.Location = New System.Drawing.Point(25, 104)
        Me.RBotonOC.Name = "RBotonOC"
        Me.RBotonOC.Size = New System.Drawing.Size(106, 20)
        Me.RBotonOC.TabIndex = 7
        Me.RBotonOC.TabStop = True
        Me.RBotonOC.Text = "OCCIDENTE"
        Me.RBotonOC.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBotonOC)
        Me.GroupBox1.Controls.Add(Me.RBotonOR)
        Me.GroupBox1.Controls.Add(Me.RBotonS)
        Me.GroupBox1.Controls.Add(Me.RBotonN)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 151)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGIÓN"
        '
        'RBotonSV
        '
        Me.RBotonSV.AutoSize = True
        Me.RBotonSV.Location = New System.Drawing.Point(29, 39)
        Me.RBotonSV.Name = "RBotonSV"
        Me.RBotonSV.Size = New System.Drawing.Size(145, 20)
        Me.RBotonSV.TabIndex = 9
        Me.RBotonSV.TabStop = True
        Me.RBotonSV.Text = "SOBRE VEHICULO"
        Me.RBotonSV.UseVisualStyleBackColor = True
        '
        'RBotonSA
        '
        Me.RBotonSA.AutoSize = True
        Me.RBotonSA.Location = New System.Drawing.Point(29, 65)
        Me.RBotonSA.Name = "RBotonSA"
        Me.RBotonSA.Size = New System.Drawing.Size(155, 20)
        Me.RBotonSA.TabIndex = 10
        Me.RBotonSA.TabStop = True
        Me.RBotonSA.Text = "SOBRE ACCIDENTE"
        Me.RBotonSA.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBotonSA)
        Me.GroupBox2.Controls.Add(Me.RBotonSV)
        Me.GroupBox2.Location = New System.Drawing.Point(256, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(198, 150)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SEGURO"
        '
        'BotonCalcular
        '
        Me.BotonCalcular.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BotonCalcular.Location = New System.Drawing.Point(525, 120)
        Me.BotonCalcular.Name = "BotonCalcular"
        Me.BotonCalcular.Size = New System.Drawing.Size(88, 23)
        Me.BotonCalcular.TabIndex = 12
        Me.BotonCalcular.Text = "CALCULAR"
        Me.BotonCalcular.UseVisualStyleBackColor = False
        '
        'BotonLimpiar
        '
        Me.BotonLimpiar.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BotonLimpiar.Location = New System.Drawing.Point(525, 158)
        Me.BotonLimpiar.Name = "BotonLimpiar"
        Me.BotonLimpiar.Size = New System.Drawing.Size(88, 23)
        Me.BotonLimpiar.TabIndex = 13
        Me.BotonLimpiar.Text = "LIMPIAR"
        Me.BotonLimpiar.UseVisualStyleBackColor = False
        '
        'BotonSalir
        '
        Me.BotonSalir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BotonSalir.Location = New System.Drawing.Point(525, 197)
        Me.BotonSalir.Name = "BotonSalir"
        Me.BotonSalir.Size = New System.Drawing.Size(88, 23)
        Me.BotonSalir.TabIndex = 14
        Me.BotonSalir.Text = "SALIR"
        Me.BotonSalir.UseVisualStyleBackColor = False
        '
        'TxtMontoSeguro
        '
        Me.TxtMontoSeguro.Location = New System.Drawing.Point(171, 40)
        Me.TxtMontoSeguro.Name = "TxtMontoSeguro"
        Me.TxtMontoSeguro.Size = New System.Drawing.Size(187, 22)
        Me.TxtMontoSeguro.TabIndex = 15
        '
        'TxtSueldoFinal
        '
        Me.TxtSueldoFinal.Location = New System.Drawing.Point(171, 77)
        Me.TxtSueldoFinal.Name = "TxtSueldoFinal"
        Me.TxtSueldoFinal.Size = New System.Drawing.Size(187, 22)
        Me.TxtSueldoFinal.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Menu
        Me.Label3.Location = New System.Drawing.Point(18, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "MONTO DEL SEGURO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Menu
        Me.Label4.Location = New System.Drawing.Point(18, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "SUELDO FINAL"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TxtSueldoFinal)
        Me.GroupBox3.Controls.Add(Me.TxtMontoSeguro)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 302)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(391, 124)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RESULTADOS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(669, 464)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BotonSalir)
        Me.Controls.Add(Me.BotonLimpiar)
        Me.Controls.Add(Me.BotonCalcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtMontoEnvio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNombre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtMontoEnvio As TextBox
    Friend WithEvents RBotonN As RadioButton
    Friend WithEvents RBotonS As RadioButton
    Friend WithEvents RBotonOR As RadioButton
    Friend WithEvents RBotonOC As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBotonSV As RadioButton
    Friend WithEvents RBotonSA As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BotonCalcular As Button
    Friend WithEvents BotonLimpiar As Button
    Friend WithEvents BotonSalir As Button
    Friend WithEvents TxtMontoSeguro As TextBox
    Friend WithEvents TxtSueldoFinal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
End Class
