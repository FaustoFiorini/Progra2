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
        Me.RBotonA = New System.Windows.Forms.RadioButton()
        Me.RBotonJet = New System.Windows.Forms.RadioButton()
        Me.RBotonH = New System.Windows.Forms.RadioButton()
        Me.CheckCosta = New System.Windows.Forms.CheckBox()
        Me.CheckIzabal = New System.Windows.Forms.CheckBox()
        Me.CheckPeten = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCosta = New System.Windows.Forms.TextBox()
        Me.TxtIzabal = New System.Windows.Forms.TextBox()
        Me.TxtPeten = New System.Windows.Forms.TextBox()
        Me.BotonCalcular = New System.Windows.Forms.Button()
        Me.BotonLimpiar = New System.Windows.Forms.Button()
        Me.BotonSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RBotonA
        '
        Me.RBotonA.AutoSize = True
        Me.RBotonA.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RBotonA.Location = New System.Drawing.Point(35, 33)
        Me.RBotonA.Name = "RBotonA"
        Me.RBotonA.Size = New System.Drawing.Size(104, 23)
        Me.RBotonA.TabIndex = 0
        Me.RBotonA.TabStop = True
        Me.RBotonA.Text = "AVIONETA"
        Me.RBotonA.UseVisualStyleBackColor = False
        '
        'RBotonJet
        '
        Me.RBotonJet.AutoSize = True
        Me.RBotonJet.BackColor = System.Drawing.SystemColors.ControlDark
        Me.RBotonJet.Location = New System.Drawing.Point(35, 74)
        Me.RBotonJet.Name = "RBotonJet"
        Me.RBotonJet.Size = New System.Drawing.Size(56, 23)
        Me.RBotonJet.TabIndex = 1
        Me.RBotonJet.TabStop = True
        Me.RBotonJet.Text = "JET"
        Me.RBotonJet.UseVisualStyleBackColor = False
        '
        'RBotonH
        '
        Me.RBotonH.AutoSize = True
        Me.RBotonH.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.RBotonH.Location = New System.Drawing.Point(35, 118)
        Me.RBotonH.Name = "RBotonH"
        Me.RBotonH.Size = New System.Drawing.Size(122, 23)
        Me.RBotonH.TabIndex = 2
        Me.RBotonH.TabStop = True
        Me.RBotonH.Text = "HELICOPTERO"
        Me.RBotonH.UseVisualStyleBackColor = False
        '
        'CheckCosta
        '
        Me.CheckCosta.AutoSize = True
        Me.CheckCosta.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CheckCosta.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckCosta.Location = New System.Drawing.Point(337, 86)
        Me.CheckCosta.Name = "CheckCosta"
        Me.CheckCosta.Size = New System.Drawing.Size(110, 23)
        Me.CheckCosta.TabIndex = 3
        Me.CheckCosta.Text = "COSTA SUR"
        Me.CheckCosta.UseVisualStyleBackColor = False
        '
        'CheckIzabal
        '
        Me.CheckIzabal.AutoSize = True
        Me.CheckIzabal.BackColor = System.Drawing.SystemColors.GrayText
        Me.CheckIzabal.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIzabal.Location = New System.Drawing.Point(337, 126)
        Me.CheckIzabal.Name = "CheckIzabal"
        Me.CheckIzabal.Size = New System.Drawing.Size(82, 23)
        Me.CheckIzabal.TabIndex = 4
        Me.CheckIzabal.Text = "IZABAL"
        Me.CheckIzabal.UseVisualStyleBackColor = False
        '
        'CheckPeten
        '
        Me.CheckPeten.AutoSize = True
        Me.CheckPeten.BackColor = System.Drawing.SystemColors.Info
        Me.CheckPeten.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckPeten.Location = New System.Drawing.Point(337, 172)
        Me.CheckPeten.Name = "CheckPeten"
        Me.CheckPeten.Size = New System.Drawing.Size(74, 23)
        Me.CheckPeten.TabIndex = 5
        Me.CheckPeten.Text = "PETÉN"
        Me.CheckPeten.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.RBotonH)
        Me.GroupBox1.Controls.Add(Me.RBotonJet)
        Me.GroupBox1.Controls.Add(Me.RBotonA)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 177)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AERONAVE"
        '
        'TxtCosta
        '
        Me.TxtCosta.Location = New System.Drawing.Point(496, 83)
        Me.TxtCosta.Name = "TxtCosta"
        Me.TxtCosta.Size = New System.Drawing.Size(100, 22)
        Me.TxtCosta.TabIndex = 8
        '
        'TxtIzabal
        '
        Me.TxtIzabal.Location = New System.Drawing.Point(496, 124)
        Me.TxtIzabal.Name = "TxtIzabal"
        Me.TxtIzabal.Size = New System.Drawing.Size(100, 22)
        Me.TxtIzabal.TabIndex = 9
        '
        'TxtPeten
        '
        Me.TxtPeten.Location = New System.Drawing.Point(496, 170)
        Me.TxtPeten.Name = "TxtPeten"
        Me.TxtPeten.Size = New System.Drawing.Size(100, 22)
        Me.TxtPeten.TabIndex = 10
        '
        'BotonCalcular
        '
        Me.BotonCalcular.BackColor = System.Drawing.SystemColors.Highlight
        Me.BotonCalcular.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCalcular.Location = New System.Drawing.Point(95, 268)
        Me.BotonCalcular.Name = "BotonCalcular"
        Me.BotonCalcular.Size = New System.Drawing.Size(101, 31)
        Me.BotonCalcular.TabIndex = 11
        Me.BotonCalcular.Text = "CALCULAR"
        Me.BotonCalcular.UseVisualStyleBackColor = False
        '
        'BotonLimpiar
        '
        Me.BotonLimpiar.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BotonLimpiar.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonLimpiar.Location = New System.Drawing.Point(222, 268)
        Me.BotonLimpiar.Name = "BotonLimpiar"
        Me.BotonLimpiar.Size = New System.Drawing.Size(109, 31)
        Me.BotonLimpiar.TabIndex = 12
        Me.BotonLimpiar.Text = "LIMPIAR"
        Me.BotonLimpiar.UseVisualStyleBackColor = False
        '
        'BotonSalir
        '
        Me.BotonSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonSalir.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonSalir.Location = New System.Drawing.Point(350, 268)
        Me.BotonSalir.Name = "BotonSalir"
        Me.BotonSalir.Size = New System.Drawing.Size(110, 31)
        Me.BotonSalir.TabIndex = 13
        Me.BotonSalir.Text = "SALIR"
        Me.BotonSalir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(503, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "CANTIDAD "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(334, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "DESTINO"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(693, 380)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BotonSalir)
        Me.Controls.Add(Me.BotonLimpiar)
        Me.Controls.Add(Me.BotonCalcular)
        Me.Controls.Add(Me.TxtPeten)
        Me.Controls.Add(Me.TxtIzabal)
        Me.Controls.Add(Me.TxtCosta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckPeten)
        Me.Controls.Add(Me.CheckIzabal)
        Me.Controls.Add(Me.CheckCosta)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RBotonA As RadioButton
    Friend WithEvents RBotonJet As RadioButton
    Friend WithEvents RBotonH As RadioButton
    Friend WithEvents CheckCosta As CheckBox
    Friend WithEvents CheckIzabal As CheckBox
    Friend WithEvents CheckPeten As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCosta As TextBox
    Friend WithEvents TxtIzabal As TextBox
    Friend WithEvents TxtPeten As TextBox
    Friend WithEvents BotonCalcular As Button
    Friend WithEvents BotonLimpiar As Button
    Friend WithEvents BotonSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
