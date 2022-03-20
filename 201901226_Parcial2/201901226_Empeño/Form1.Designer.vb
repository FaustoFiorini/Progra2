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
        Me.TxtCUI = New System.Windows.Forms.TextBox()
        Me.TxtDirección = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckTV = New System.Windows.Forms.CheckBox()
        Me.CheckTEL = New System.Windows.Forms.CheckBox()
        Me.CheckLaptop = New System.Windows.Forms.CheckBox()
        Me.CheckRefri = New System.Windows.Forms.CheckBox()
        Me.RBotonCorto = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ACEPTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARLISTBOXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARMATRIZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCosto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBotonLargo = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListBoxName = New System.Windows.Forms.ListBox()
        Me.ListBoxCui = New System.Windows.Forms.ListBox()
        Me.ListBoxDirecc = New System.Windows.Forms.ListBox()
        Me.ListBoxcosto = New System.Windows.Forms.ListBox()
        Me.ListBoxAparato = New System.Windows.Forms.ListBox()
        Me.ListBoxPlazo = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListBoxPParcial = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ListBoxDesc = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ListBoxPfinal = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(131, 33)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(167, 26)
        Me.TxtNombre.TabIndex = 0
        '
        'TxtCUI
        '
        Me.TxtCUI.Location = New System.Drawing.Point(131, 73)
        Me.TxtCUI.Name = "TxtCUI"
        Me.TxtCUI.Size = New System.Drawing.Size(167, 26)
        Me.TxtCUI.TabIndex = 1
        '
        'TxtDirección
        '
        Me.TxtDirección.Location = New System.Drawing.Point(131, 116)
        Me.TxtDirección.Name = "TxtDirección"
        Me.TxtDirección.Size = New System.Drawing.Size(167, 26)
        Me.TxtDirección.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CUI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DIRECCIÓN"
        '
        'CheckTV
        '
        Me.CheckTV.AutoSize = True
        Me.CheckTV.Location = New System.Drawing.Point(47, 38)
        Me.CheckTV.Name = "CheckTV"
        Me.CheckTV.Size = New System.Drawing.Size(49, 23)
        Me.CheckTV.TabIndex = 6
        Me.CheckTV.Text = "TV"
        Me.CheckTV.UseVisualStyleBackColor = True
        '
        'CheckTEL
        '
        Me.CheckTEL.AutoSize = True
        Me.CheckTEL.Location = New System.Drawing.Point(47, 64)
        Me.CheckTEL.Name = "CheckTEL"
        Me.CheckTEL.Size = New System.Drawing.Size(102, 23)
        Me.CheckTEL.TabIndex = 7
        Me.CheckTEL.Text = "TELÉFONO"
        Me.CheckTEL.UseVisualStyleBackColor = True
        '
        'CheckLaptop
        '
        Me.CheckLaptop.AutoSize = True
        Me.CheckLaptop.Location = New System.Drawing.Point(47, 90)
        Me.CheckLaptop.Name = "CheckLaptop"
        Me.CheckLaptop.Size = New System.Drawing.Size(81, 23)
        Me.CheckLaptop.TabIndex = 8
        Me.CheckLaptop.Text = "LAPTOP"
        Me.CheckLaptop.UseVisualStyleBackColor = True
        '
        'CheckRefri
        '
        Me.CheckRefri.AutoSize = True
        Me.CheckRefri.Location = New System.Drawing.Point(47, 116)
        Me.CheckRefri.Name = "CheckRefri"
        Me.CheckRefri.Size = New System.Drawing.Size(142, 23)
        Me.CheckRefri.TabIndex = 9
        Me.CheckRefri.Text = "REFRIGERADORA"
        Me.CheckRefri.UseVisualStyleBackColor = True
        '
        'RBotonCorto
        '
        Me.RBotonCorto.AutoSize = True
        Me.RBotonCorto.Location = New System.Drawing.Point(30, 89)
        Me.RBotonCorto.Name = "RBotonCorto"
        Me.RBotonCorto.Size = New System.Drawing.Size(75, 23)
        Me.RBotonCorto.TabIndex = 11
        Me.RBotonCorto.Text = "CORTO"
        Me.RBotonCorto.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACEPTARToolStripMenuItem, Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARLISTBOXToolStripMenuItem, Me.LIMPIARMATRIZToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1123, 29)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ACEPTARToolStripMenuItem
        '
        Me.ACEPTARToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ACEPTARToolStripMenuItem.Name = "ACEPTARToolStripMenuItem"
        Me.ACEPTARToolStripMenuItem.Size = New System.Drawing.Size(92, 25)
        Me.ACEPTARToolStripMenuItem.Text = "ACEPTAR"
        '
        'LIMPIARLISTBOXToolStripMenuItem
        '
        Me.LIMPIARLISTBOXToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LIMPIARLISTBOXToolStripMenuItem.Name = "LIMPIARLISTBOXToolStripMenuItem"
        Me.LIMPIARLISTBOXToolStripMenuItem.Size = New System.Drawing.Size(165, 25)
        Me.LIMPIARLISTBOXToolStripMenuItem.Text = "LIMPIAR LISTBOX"
        '
        'LIMPIARMATRIZToolStripMenuItem
        '
        Me.LIMPIARMATRIZToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LIMPIARMATRIZToolStripMenuItem.Name = "LIMPIARMATRIZToolStripMenuItem"
        Me.LIMPIARMATRIZToolStripMenuItem.Size = New System.Drawing.Size(159, 25)
        Me.LIMPIARMATRIZToolStripMenuItem.Text = "LIMPIAR MATRIZ"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.BackColor = System.Drawing.Color.Red
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(71, 25)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Controls.Add(Me.TxtCosto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtDirección)
        Me.GroupBox1.Controls.Add(Me.TxtCUI)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 200)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS "
        '
        'TxtCosto
        '
        Me.TxtCosto.Location = New System.Drawing.Point(131, 156)
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(167, 26)
        Me.TxtCosto.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "COSTO"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.Controls.Add(Me.CheckRefri)
        Me.GroupBox2.Controls.Add(Me.CheckLaptop)
        Me.GroupBox2.Controls.Add(Me.CheckTEL)
        Me.GroupBox2.Controls.Add(Me.CheckTV)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(381, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(221, 160)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "APARATOS"
        '
        'RBotonLargo
        '
        Me.RBotonLargo.AutoSize = True
        Me.RBotonLargo.Location = New System.Drawing.Point(30, 63)
        Me.RBotonLargo.Name = "RBotonLargo"
        Me.RBotonLargo.Size = New System.Drawing.Size(74, 23)
        Me.RBotonLargo.TabIndex = 15
        Me.RBotonLargo.Text = "LARGO"
        Me.RBotonLargo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox3.Controls.Add(Me.RBotonLargo)
        Me.GroupBox3.Controls.Add(Me.RBotonCorto)
        Me.GroupBox3.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(647, 79)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(131, 160)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PLAZO"
        '
        'ListBoxName
        '
        Me.ListBoxName.BackColor = System.Drawing.Color.DarkGray
        Me.ListBoxName.FormattingEnabled = True
        Me.ListBoxName.ItemHeight = 19
        Me.ListBoxName.Location = New System.Drawing.Point(12, 52)
        Me.ListBoxName.Name = "ListBoxName"
        Me.ListBoxName.Size = New System.Drawing.Size(125, 156)
        Me.ListBoxName.TabIndex = 17
        '
        'ListBoxCui
        '
        Me.ListBoxCui.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxCui.FormattingEnabled = True
        Me.ListBoxCui.ItemHeight = 19
        Me.ListBoxCui.Location = New System.Drawing.Point(143, 52)
        Me.ListBoxCui.Name = "ListBoxCui"
        Me.ListBoxCui.Size = New System.Drawing.Size(85, 156)
        Me.ListBoxCui.TabIndex = 18
        '
        'ListBoxDirecc
        '
        Me.ListBoxDirecc.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ListBoxDirecc.FormattingEnabled = True
        Me.ListBoxDirecc.ItemHeight = 19
        Me.ListBoxDirecc.Location = New System.Drawing.Point(234, 52)
        Me.ListBoxDirecc.Name = "ListBoxDirecc"
        Me.ListBoxDirecc.Size = New System.Drawing.Size(96, 156)
        Me.ListBoxDirecc.TabIndex = 19
        '
        'ListBoxcosto
        '
        Me.ListBoxcosto.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ListBoxcosto.FormattingEnabled = True
        Me.ListBoxcosto.ItemHeight = 19
        Me.ListBoxcosto.Location = New System.Drawing.Point(336, 52)
        Me.ListBoxcosto.Name = "ListBoxcosto"
        Me.ListBoxcosto.Size = New System.Drawing.Size(101, 156)
        Me.ListBoxcosto.TabIndex = 20
        '
        'ListBoxAparato
        '
        Me.ListBoxAparato.BackColor = System.Drawing.Color.MistyRose
        Me.ListBoxAparato.FormattingEnabled = True
        Me.ListBoxAparato.ItemHeight = 19
        Me.ListBoxAparato.Location = New System.Drawing.Point(443, 52)
        Me.ListBoxAparato.Name = "ListBoxAparato"
        Me.ListBoxAparato.Size = New System.Drawing.Size(125, 156)
        Me.ListBoxAparato.TabIndex = 21
        '
        'ListBoxPlazo
        '
        Me.ListBoxPlazo.BackColor = System.Drawing.Color.LightSalmon
        Me.ListBoxPlazo.FormattingEnabled = True
        Me.ListBoxPlazo.ItemHeight = 19
        Me.ListBoxPlazo.Location = New System.Drawing.Point(574, 52)
        Me.ListBoxPlazo.Name = "ListBoxPlazo"
        Me.ListBoxPlazo.Size = New System.Drawing.Size(91, 156)
        Me.ListBoxPlazo.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "NOMBRE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(140, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 19)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "CUI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(231, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 19)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "DIRECCIÓN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(333, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 19)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "COSTO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(440, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 19)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "APARATO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(571, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 19)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "PLAZO"
        '
        'ListBoxPParcial
        '
        Me.ListBoxPParcial.BackColor = System.Drawing.SystemColors.Menu
        Me.ListBoxPParcial.FormattingEnabled = True
        Me.ListBoxPParcial.ItemHeight = 19
        Me.ListBoxPParcial.Location = New System.Drawing.Point(677, 52)
        Me.ListBoxPParcial.Name = "ListBoxPParcial"
        Me.ListBoxPParcial.Size = New System.Drawing.Size(112, 156)
        Me.ListBoxPParcial.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(674, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 19)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "PAGO PARCIAL"
        '
        'ListBoxDesc
        '
        Me.ListBoxDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ListBoxDesc.FormattingEnabled = True
        Me.ListBoxDesc.ItemHeight = 19
        Me.ListBoxDesc.Location = New System.Drawing.Point(795, 52)
        Me.ListBoxDesc.Name = "ListBoxDesc"
        Me.ListBoxDesc.Size = New System.Drawing.Size(112, 156)
        Me.ListBoxDesc.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(792, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 19)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "DESCUENTO"
        '
        'ListBoxPfinal
        '
        Me.ListBoxPfinal.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxPfinal.FormattingEnabled = True
        Me.ListBoxPfinal.ItemHeight = 19
        Me.ListBoxPfinal.Location = New System.Drawing.Point(913, 52)
        Me.ListBoxPfinal.Name = "ListBoxPfinal"
        Me.ListBoxPfinal.Size = New System.Drawing.Size(112, 156)
        Me.ListBoxPfinal.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(910, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 19)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "PAGO FINAL"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.ListBoxPfinal)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.ListBoxDesc)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.ListBoxPParcial)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.ListBoxPlazo)
        Me.GroupBox4.Controls.Add(Me.ListBoxAparato)
        Me.GroupBox4.Controls.Add(Me.ListBoxcosto)
        Me.GroupBox4.Controls.Add(Me.ListBoxDirecc)
        Me.GroupBox4.Controls.Add(Me.ListBoxCui)
        Me.GroupBox4.Controls.Add(Me.ListBoxName)
        Me.GroupBox4.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 288)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1087, 241)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "RESULTADOS"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(181, 25)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1123, 575)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtCUI As TextBox
    Friend WithEvents TxtDirección As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckTV As CheckBox
    Friend WithEvents CheckTEL As CheckBox
    Friend WithEvents CheckLaptop As CheckBox
    Friend WithEvents CheckRefri As CheckBox
    Friend WithEvents RBotonCorto As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ACEPTARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARLISTBOXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARMATRIZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCosto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RBotonLargo As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ListBoxName As ListBox
    Friend WithEvents ListBoxCui As ListBox
    Friend WithEvents ListBoxDirecc As ListBox
    Friend WithEvents ListBoxcosto As ListBox
    Friend WithEvents ListBoxAparato As ListBox
    Friend WithEvents ListBoxPlazo As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ListBoxPParcial As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ListBoxDesc As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ListBoxPfinal As ListBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
End Class
