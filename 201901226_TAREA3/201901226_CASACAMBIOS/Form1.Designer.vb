<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TxtCLIENTE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckCompra = New System.Windows.Forms.CheckBox()
        Me.CheckVenta = New System.Windows.Forms.CheckBox()
        Me.TxtCOMPRA = New System.Windows.Forms.TextBox()
        Me.TxtVENTA = New System.Windows.Forms.TextBox()
        Me.RBotonDolarC = New System.Windows.Forms.RadioButton()
        Me.RBotonPesoC = New System.Windows.Forms.RadioButton()
        Me.RBotonEuroC = New System.Windows.Forms.RadioButton()
        Me.RBotonColonC = New System.Windows.Forms.RadioButton()
        Me.RBotonDolarV = New System.Windows.Forms.RadioButton()
        Me.RBotonPesoV = New System.Windows.Forms.RadioButton()
        Me.RBotonEuroV = New System.Windows.Forms.RadioButton()
        Me.RBotonColonV = New System.Windows.Forms.RadioButton()
        Me.GrpCompra = New System.Windows.Forms.GroupBox()
        Me.GrpVenta = New System.Windows.Forms.GroupBox()
        Me.GrpDatos = New System.Windows.Forms.GroupBox()
        Me.BotonCalcular = New System.Windows.Forms.Button()
        Me.BotonLimpiar = New System.Windows.Forms.Button()
        Me.BotonSalir = New System.Windows.Forms.Button()
        Me.GrpCompra.SuspendLayout()
        Me.GrpVenta.SuspendLayout()
        Me.GrpDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCLIENTE
        '
        Me.TxtCLIENTE.Location = New System.Drawing.Point(120, 24)
        Me.TxtCLIENTE.Name = "TxtCLIENTE"
        Me.TxtCLIENTE.Size = New System.Drawing.Size(241, 31)
        Me.TxtCLIENTE.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(5, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CLIENTE"
        '
        'CheckCompra
        '
        Me.CheckCompra.AutoSize = True
        Me.CheckCompra.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckCompra.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CheckCompra.Location = New System.Drawing.Point(11, 99)
        Me.CheckCompra.Name = "CheckCompra"
        Me.CheckCompra.Size = New System.Drawing.Size(95, 25)
        Me.CheckCompra.TabIndex = 2
        Me.CheckCompra.Text = "COMPRA"
        Me.CheckCompra.UseVisualStyleBackColor = False
        '
        'CheckVenta
        '
        Me.CheckVenta.AutoSize = True
        Me.CheckVenta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckVenta.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CheckVenta.Location = New System.Drawing.Point(11, 139)
        Me.CheckVenta.Name = "CheckVenta"
        Me.CheckVenta.Size = New System.Drawing.Size(84, 25)
        Me.CheckVenta.TabIndex = 3
        Me.CheckVenta.Text = "VENTA"
        Me.CheckVenta.UseVisualStyleBackColor = False
        '
        'TxtCOMPRA
        '
        Me.TxtCOMPRA.Location = New System.Drawing.Point(120, 96)
        Me.TxtCOMPRA.Name = "TxtCOMPRA"
        Me.TxtCOMPRA.Size = New System.Drawing.Size(100, 31)
        Me.TxtCOMPRA.TabIndex = 4
        Me.TxtCOMPRA.Visible = False
        '
        'TxtVENTA
        '
        Me.TxtVENTA.Location = New System.Drawing.Point(120, 136)
        Me.TxtVENTA.Name = "TxtVENTA"
        Me.TxtVENTA.Size = New System.Drawing.Size(100, 31)
        Me.TxtVENTA.TabIndex = 5
        Me.TxtVENTA.Visible = False
        '
        'RBotonDolarC
        '
        Me.RBotonDolarC.AutoSize = True
        Me.RBotonDolarC.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RBotonDolarC.Location = New System.Drawing.Point(71, 39)
        Me.RBotonDolarC.Name = "RBotonDolarC"
        Me.RBotonDolarC.Size = New System.Drawing.Size(83, 25)
        Me.RBotonDolarC.TabIndex = 6
        Me.RBotonDolarC.TabStop = True
        Me.RBotonDolarC.Text = "DOLAR"
        Me.RBotonDolarC.UseVisualStyleBackColor = True
        '
        'RBotonPesoC
        '
        Me.RBotonPesoC.AutoSize = True
        Me.RBotonPesoC.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RBotonPesoC.Location = New System.Drawing.Point(71, 69)
        Me.RBotonPesoC.Name = "RBotonPesoC"
        Me.RBotonPesoC.Size = New System.Drawing.Size(182, 25)
        Me.RBotonPesoC.TabIndex = 7
        Me.RBotonPesoC.TabStop = True
        Me.RBotonPesoC.Text = "PESOS MEXICANOS"
        Me.RBotonPesoC.UseVisualStyleBackColor = True
        '
        'RBotonEuroC
        '
        Me.RBotonEuroC.AutoSize = True
        Me.RBotonEuroC.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RBotonEuroC.Location = New System.Drawing.Point(71, 99)
        Me.RBotonEuroC.Name = "RBotonEuroC"
        Me.RBotonEuroC.Size = New System.Drawing.Size(83, 25)
        Me.RBotonEuroC.TabIndex = 8
        Me.RBotonEuroC.TabStop = True
        Me.RBotonEuroC.Text = "EUROS"
        Me.RBotonEuroC.UseVisualStyleBackColor = True
        '
        'RBotonColonC
        '
        Me.RBotonColonC.AutoSize = True
        Me.RBotonColonC.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RBotonColonC.Location = New System.Drawing.Point(71, 129)
        Me.RBotonColonC.Name = "RBotonColonC"
        Me.RBotonColonC.Size = New System.Drawing.Size(249, 25)
        Me.RBotonColonC.TabIndex = 9
        Me.RBotonColonC.TabStop = True
        Me.RBotonColonC.Text = "COLONES COSTARRICENSES"
        Me.RBotonColonC.UseVisualStyleBackColor = True
        '
        'RBotonDolarV
        '
        Me.RBotonDolarV.AutoSize = True
        Me.RBotonDolarV.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RBotonDolarV.Location = New System.Drawing.Point(55, 22)
        Me.RBotonDolarV.Name = "RBotonDolarV"
        Me.RBotonDolarV.Size = New System.Drawing.Size(83, 25)
        Me.RBotonDolarV.TabIndex = 10
        Me.RBotonDolarV.TabStop = True
        Me.RBotonDolarV.Text = "DOLAR"
        Me.RBotonDolarV.UseVisualStyleBackColor = True
        '
        'RBotonPesoV
        '
        Me.RBotonPesoV.AutoSize = True
        Me.RBotonPesoV.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RBotonPesoV.Location = New System.Drawing.Point(55, 52)
        Me.RBotonPesoV.Name = "RBotonPesoV"
        Me.RBotonPesoV.Size = New System.Drawing.Size(182, 25)
        Me.RBotonPesoV.TabIndex = 11
        Me.RBotonPesoV.TabStop = True
        Me.RBotonPesoV.Text = "PESOS MEXICANOS"
        Me.RBotonPesoV.UseVisualStyleBackColor = True
        '
        'RBotonEuroV
        '
        Me.RBotonEuroV.AutoSize = True
        Me.RBotonEuroV.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RBotonEuroV.Location = New System.Drawing.Point(55, 82)
        Me.RBotonEuroV.Name = "RBotonEuroV"
        Me.RBotonEuroV.Size = New System.Drawing.Size(83, 25)
        Me.RBotonEuroV.TabIndex = 12
        Me.RBotonEuroV.TabStop = True
        Me.RBotonEuroV.Text = "EUROS"
        Me.RBotonEuroV.UseVisualStyleBackColor = True
        '
        'RBotonColonV
        '
        Me.RBotonColonV.AutoSize = True
        Me.RBotonColonV.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RBotonColonV.Location = New System.Drawing.Point(55, 112)
        Me.RBotonColonV.Name = "RBotonColonV"
        Me.RBotonColonV.Size = New System.Drawing.Size(249, 25)
        Me.RBotonColonV.TabIndex = 13
        Me.RBotonColonV.TabStop = True
        Me.RBotonColonV.Text = "COLONES COSTARRICENSES"
        Me.RBotonColonV.UseVisualStyleBackColor = True
        '
        'GrpCompra
        '
        Me.GrpCompra.BackColor = System.Drawing.SystemColors.MenuBar
        Me.GrpCompra.Controls.Add(Me.RBotonColonC)
        Me.GrpCompra.Controls.Add(Me.RBotonEuroC)
        Me.GrpCompra.Controls.Add(Me.RBotonPesoC)
        Me.GrpCompra.Controls.Add(Me.RBotonDolarC)
        Me.GrpCompra.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GrpCompra.Location = New System.Drawing.Point(468, 217)
        Me.GrpCompra.Name = "GrpCompra"
        Me.GrpCompra.Size = New System.Drawing.Size(335, 181)
        Me.GrpCompra.TabIndex = 14
        Me.GrpCompra.TabStop = False
        Me.GrpCompra.Text = "COMPRA"
        Me.GrpCompra.Visible = False
        '
        'GrpVenta
        '
        Me.GrpVenta.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GrpVenta.Controls.Add(Me.RBotonColonV)
        Me.GrpVenta.Controls.Add(Me.RBotonEuroV)
        Me.GrpVenta.Controls.Add(Me.RBotonPesoV)
        Me.GrpVenta.Controls.Add(Me.RBotonDolarV)
        Me.GrpVenta.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GrpVenta.Location = New System.Drawing.Point(468, 13)
        Me.GrpVenta.Name = "GrpVenta"
        Me.GrpVenta.Size = New System.Drawing.Size(335, 181)
        Me.GrpVenta.TabIndex = 15
        Me.GrpVenta.TabStop = False
        Me.GrpVenta.Text = "VENTA"
        Me.GrpVenta.Visible = False
        '
        'GrpDatos
        '
        Me.GrpDatos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GrpDatos.Controls.Add(Me.TxtVENTA)
        Me.GrpDatos.Controls.Add(Me.TxtCOMPRA)
        Me.GrpDatos.Controls.Add(Me.CheckVenta)
        Me.GrpDatos.Controls.Add(Me.CheckCompra)
        Me.GrpDatos.Controls.Add(Me.Label1)
        Me.GrpDatos.Controls.Add(Me.TxtCLIENTE)
        Me.GrpDatos.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GrpDatos.Location = New System.Drawing.Point(25, 169)
        Me.GrpDatos.Name = "GrpDatos"
        Me.GrpDatos.Size = New System.Drawing.Size(387, 182)
        Me.GrpDatos.TabIndex = 16
        Me.GrpDatos.TabStop = False
        Me.GrpDatos.Text = "DATOS"
        '
        'BotonCalcular
        '
        Me.BotonCalcular.BackColor = System.Drawing.SystemColors.Info
        Me.BotonCalcular.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BotonCalcular.Location = New System.Drawing.Point(450, 443)
        Me.BotonCalcular.Name = "BotonCalcular"
        Me.BotonCalcular.Size = New System.Drawing.Size(123, 38)
        Me.BotonCalcular.TabIndex = 17
        Me.BotonCalcular.Text = "CALCULAR"
        Me.BotonCalcular.UseVisualStyleBackColor = False
        '
        'BotonLimpiar
        '
        Me.BotonLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BotonLimpiar.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BotonLimpiar.Location = New System.Drawing.Point(579, 443)
        Me.BotonLimpiar.Name = "BotonLimpiar"
        Me.BotonLimpiar.Size = New System.Drawing.Size(109, 38)
        Me.BotonLimpiar.TabIndex = 18
        Me.BotonLimpiar.Text = "LIMPIAR"
        Me.BotonLimpiar.UseVisualStyleBackColor = False
        '
        'BotonSalir
        '
        Me.BotonSalir.BackColor = System.Drawing.Color.Red
        Me.BotonSalir.Font = New System.Drawing.Font("Arial Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BotonSalir.Location = New System.Drawing.Point(694, 443)
        Me.BotonSalir.Name = "BotonSalir"
        Me.BotonSalir.Size = New System.Drawing.Size(94, 38)
        Me.BotonSalir.TabIndex = 19
        Me.BotonSalir.Text = "SALIR"
        Me.BotonSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(823, 508)
        Me.Controls.Add(Me.BotonSalir)
        Me.Controls.Add(Me.BotonLimpiar)
        Me.Controls.Add(Me.BotonCalcular)
        Me.Controls.Add(Me.GrpDatos)
        Me.Controls.Add(Me.GrpVenta)
        Me.Controls.Add(Me.GrpCompra)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GrpCompra.ResumeLayout(False)
        Me.GrpCompra.PerformLayout()
        Me.GrpVenta.ResumeLayout(False)
        Me.GrpVenta.PerformLayout()
        Me.GrpDatos.ResumeLayout(False)
        Me.GrpDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtCLIENTE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckCompra As CheckBox
    Friend WithEvents CheckVenta As CheckBox
    Friend WithEvents TxtCOMPRA As TextBox
    Friend WithEvents TxtVENTA As TextBox
    Friend WithEvents RBotonDolarC As RadioButton
    Friend WithEvents RBotonPesoC As RadioButton
    Friend WithEvents RBotonEuroC As RadioButton
    Friend WithEvents RBotonColonC As RadioButton
    Friend WithEvents RBotonDolarV As RadioButton
    Friend WithEvents RBotonPesoV As RadioButton
    Friend WithEvents RBotonEuroV As RadioButton
    Friend WithEvents RBotonColonV As RadioButton
    Friend WithEvents GrpCompra As GroupBox
    Friend WithEvents GrpVenta As GroupBox
    Friend WithEvents GrpDatos As GroupBox
    Friend WithEvents BotonCalcular As Button
    Friend WithEvents BotonLimpiar As Button
    Friend WithEvents BotonSalir As Button
End Class
