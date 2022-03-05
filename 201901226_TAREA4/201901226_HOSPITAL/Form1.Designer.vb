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
        Me.TxtNIT = New System.Windows.Forms.TextBox()
        Me.TxtNoDias = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckEncamamiento = New System.Windows.Forms.CheckBox()
        Me.CheckOperación = New System.Windows.Forms.CheckBox()
        Me.CheckMaternidad = New System.Windows.Forms.CheckBox()
        Me.RBotonCheque = New System.Windows.Forms.RadioButton()
        Me.RBotonTarjetaC = New System.Windows.Forms.RadioButton()
        Me.RBotonTarjetaD = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RBotonEfectivo = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARDATOSToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBoxName = New System.Windows.Forms.ListBox()
        Me.ListBoxNit = New System.Windows.Forms.ListBox()
        Me.ListBoxDr = New System.Windows.Forms.ListBox()
        Me.ListBoxDias = New System.Windows.Forms.ListBox()
        Me.ListBoxServicio = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListBoxHabi = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ListBoxPago = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ListBoxTotal = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ListBoxDesc = New System.Windows.Forms.ListBox()
        Me.ListBoxSubtot = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(124, 29)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(203, 26)
        Me.TxtNombre.TabIndex = 0
        '
        'TxtNIT
        '
        Me.TxtNIT.Location = New System.Drawing.Point(124, 69)
        Me.TxtNIT.Name = "TxtNIT"
        Me.TxtNIT.Size = New System.Drawing.Size(140, 26)
        Me.TxtNIT.TabIndex = 1
        '
        'TxtNoDias
        '
        Me.TxtNoDias.Location = New System.Drawing.Point(124, 108)
        Me.TxtNoDias.Name = "TxtNoDias"
        Me.TxtNoDias.Size = New System.Drawing.Size(77, 26)
        Me.TxtNoDias.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NIT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "NO. DÍAS "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"PRIVADA", "SEMIPRIVADA", "NO PRIVADA"})
        Me.ComboBox1.Location = New System.Drawing.Point(637, 73)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(157, 24)
        Me.ComboBox1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(633, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "TIPO DE HABITACIÓN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtNoDias)
        Me.GroupBox1.Controls.Add(Me.TxtNIT)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 150)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESOS"
        '
        'CheckEncamamiento
        '
        Me.CheckEncamamiento.AutoSize = True
        Me.CheckEncamamiento.Location = New System.Drawing.Point(40, 33)
        Me.CheckEncamamiento.Name = "CheckEncamamiento"
        Me.CheckEncamamiento.Size = New System.Drawing.Size(145, 23)
        Me.CheckEncamamiento.TabIndex = 11
        Me.CheckEncamamiento.Text = "ENCAMAMIENTO"
        Me.CheckEncamamiento.UseVisualStyleBackColor = True
        '
        'CheckOperación
        '
        Me.CheckOperación.AutoSize = True
        Me.CheckOperación.Location = New System.Drawing.Point(39, 70)
        Me.CheckOperación.Name = "CheckOperación"
        Me.CheckOperación.Size = New System.Drawing.Size(110, 23)
        Me.CheckOperación.TabIndex = 12
        Me.CheckOperación.Text = "OPERACIÓN"
        Me.CheckOperación.UseVisualStyleBackColor = True
        '
        'CheckMaternidad
        '
        Me.CheckMaternidad.AutoSize = True
        Me.CheckMaternidad.Location = New System.Drawing.Point(39, 108)
        Me.CheckMaternidad.Name = "CheckMaternidad"
        Me.CheckMaternidad.Size = New System.Drawing.Size(129, 23)
        Me.CheckMaternidad.TabIndex = 13
        Me.CheckMaternidad.Text = "MATERNIDAD "
        Me.CheckMaternidad.UseVisualStyleBackColor = True
        '
        'RBotonCheque
        '
        Me.RBotonCheque.AutoSize = True
        Me.RBotonCheque.Location = New System.Drawing.Point(64, 57)
        Me.RBotonCheque.Name = "RBotonCheque"
        Me.RBotonCheque.Size = New System.Drawing.Size(85, 23)
        Me.RBotonCheque.TabIndex = 15
        Me.RBotonCheque.Text = "CHEQUE"
        Me.RBotonCheque.UseVisualStyleBackColor = True
        '
        'RBotonTarjetaC
        '
        Me.RBotonTarjetaC.AutoSize = True
        Me.RBotonTarjetaC.Location = New System.Drawing.Point(64, 95)
        Me.RBotonTarjetaC.Name = "RBotonTarjetaC"
        Me.RBotonTarjetaC.Size = New System.Drawing.Size(181, 23)
        Me.RBotonTarjetaC.TabIndex = 16
        Me.RBotonTarjetaC.Text = "TARJETA DE CRÉDITO"
        Me.RBotonTarjetaC.UseVisualStyleBackColor = True
        '
        'RBotonTarjetaD
        '
        Me.RBotonTarjetaD.AutoSize = True
        Me.RBotonTarjetaD.Location = New System.Drawing.Point(64, 131)
        Me.RBotonTarjetaD.Name = "RBotonTarjetaD"
        Me.RBotonTarjetaD.Size = New System.Drawing.Size(173, 23)
        Me.RBotonTarjetaD.TabIndex = 17
        Me.RBotonTarjetaD.Text = "TARJETA DE DÉBITO"
        Me.RBotonTarjetaD.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox2.Controls.Add(Me.CheckMaternidad)
        Me.GroupBox2.Controls.Add(Me.CheckOperación)
        Me.GroupBox2.Controls.Add(Me.CheckEncamamiento)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(478, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(213, 162)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TIPO DE SERVICIO"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RBotonEfectivo)
        Me.GroupBox3.Controls.Add(Me.RBotonTarjetaD)
        Me.GroupBox3.Controls.Add(Me.RBotonTarjetaC)
        Me.GroupBox3.Controls.Add(Me.RBotonCheque)
        Me.GroupBox3.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(727, 106)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(275, 162)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TIPO DE PAGO"
        '
        'RBotonEfectivo
        '
        Me.RBotonEfectivo.AutoSize = True
        Me.RBotonEfectivo.Location = New System.Drawing.Point(64, 25)
        Me.RBotonEfectivo.Name = "RBotonEfectivo"
        Me.RBotonEfectivo.Size = New System.Drawing.Size(97, 23)
        Me.RBotonEfectivo.TabIndex = 18
        Me.RBotonEfectivo.Text = "EFECTIVO"
        Me.RBotonEfectivo.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.LIMPIARDATOSToolStripMenuItem1, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1202, 29)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.CALCULARToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(101, 25)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LIMPIARVECTORESToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(176, 25)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'LIMPIARDATOSToolStripMenuItem1
        '
        Me.LIMPIARDATOSToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Info
        Me.LIMPIARDATOSToolStripMenuItem1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIMPIARDATOSToolStripMenuItem1.Name = "LIMPIARDATOSToolStripMenuItem1"
        Me.LIMPIARDATOSToolStripMenuItem1.Size = New System.Drawing.Size(158, 25)
        Me.LIMPIARDATOSToolStripMenuItem1.Text = "LIMPIAR DATOS "
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.BackColor = System.Drawing.Color.Red
        Me.SALIRToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(78, 25)
        Me.SALIRToolStripMenuItem.Text = "SALIR "
        '
        'ListBoxName
        '
        Me.ListBoxName.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxName.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxName.FormattingEnabled = True
        Me.ListBoxName.ItemHeight = 19
        Me.ListBoxName.Location = New System.Drawing.Point(6, 64)
        Me.ListBoxName.Name = "ListBoxName"
        Me.ListBoxName.Size = New System.Drawing.Size(112, 156)
        Me.ListBoxName.TabIndex = 21
        '
        'ListBoxNit
        '
        Me.ListBoxNit.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ListBoxNit.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxNit.FormattingEnabled = True
        Me.ListBoxNit.ItemHeight = 19
        Me.ListBoxNit.Location = New System.Drawing.Point(128, 64)
        Me.ListBoxNit.Name = "ListBoxNit"
        Me.ListBoxNit.Size = New System.Drawing.Size(83, 156)
        Me.ListBoxNit.TabIndex = 22
        '
        'ListBoxDr
        '
        Me.ListBoxDr.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxDr.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxDr.FormattingEnabled = True
        Me.ListBoxDr.ItemHeight = 19
        Me.ListBoxDr.Location = New System.Drawing.Point(222, 64)
        Me.ListBoxDr.Name = "ListBoxDr"
        Me.ListBoxDr.Size = New System.Drawing.Size(107, 156)
        Me.ListBoxDr.TabIndex = 23
        '
        'ListBoxDias
        '
        Me.ListBoxDias.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ListBoxDias.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxDias.FormattingEnabled = True
        Me.ListBoxDias.ItemHeight = 19
        Me.ListBoxDias.Location = New System.Drawing.Point(337, 64)
        Me.ListBoxDias.Name = "ListBoxDias"
        Me.ListBoxDias.Size = New System.Drawing.Size(77, 156)
        Me.ListBoxDias.TabIndex = 24
        '
        'ListBoxServicio
        '
        Me.ListBoxServicio.BackColor = System.Drawing.Color.LightGray
        Me.ListBoxServicio.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxServicio.FormattingEnabled = True
        Me.ListBoxServicio.ItemHeight = 19
        Me.ListBoxServicio.Location = New System.Drawing.Point(426, 64)
        Me.ListBoxServicio.Name = "ListBoxServicio"
        Me.ListBoxServicio.Size = New System.Drawing.Size(143, 156)
        Me.ListBoxServicio.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 19)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "NOMBRE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(145, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 19)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "NIT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(218, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 19)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "HONORARIOS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(337, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 19)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "NO. DÍAS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(950, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 19)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "DESCUENTO (-)"
        '
        'ListBoxHabi
        '
        Me.ListBoxHabi.BackColor = System.Drawing.Color.Wheat
        Me.ListBoxHabi.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxHabi.FormattingEnabled = True
        Me.ListBoxHabi.ItemHeight = 19
        Me.ListBoxHabi.Location = New System.Drawing.Point(590, 64)
        Me.ListBoxHabi.Name = "ListBoxHabi"
        Me.ListBoxHabi.Size = New System.Drawing.Size(112, 156)
        Me.ListBoxHabi.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(871, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 19)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "SUBTOTAL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1090, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 19)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "TOTAL"
        '
        'ListBoxPago
        '
        Me.ListBoxPago.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ListBoxPago.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPago.FormattingEnabled = True
        Me.ListBoxPago.ItemHeight = 19
        Me.ListBoxPago.Location = New System.Drawing.Point(708, 64)
        Me.ListBoxPago.Name = "ListBoxPago"
        Me.ListBoxPago.Size = New System.Drawing.Size(156, 156)
        Me.ListBoxPago.TabIndex = 34
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.ListBoxTotal)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.ListBoxDesc)
        Me.GroupBox4.Controls.Add(Me.ListBoxSubtot)
        Me.GroupBox4.Controls.Add(Me.ListBoxPago)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.ListBoxHabi)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.ListBoxServicio)
        Me.GroupBox4.Controls.Add(Me.ListBoxDias)
        Me.GroupBox4.Controls.Add(Me.ListBoxDr)
        Me.GroupBox4.Controls.Add(Me.ListBoxNit)
        Me.GroupBox4.Controls.Add(Me.ListBoxName)
        Me.GroupBox4.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 300)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1190, 267)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "RESULTADOS"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(959, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 19)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "RECARGO (+)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(589, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 19)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "HABITACIÓN"
        '
        'ListBoxTotal
        '
        Me.ListBoxTotal.BackColor = System.Drawing.Color.DeepPink
        Me.ListBoxTotal.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxTotal.FormattingEnabled = True
        Me.ListBoxTotal.ItemHeight = 19
        Me.ListBoxTotal.Location = New System.Drawing.Point(1071, 64)
        Me.ListBoxTotal.Name = "ListBoxTotal"
        Me.ListBoxTotal.Size = New System.Drawing.Size(92, 156)
        Me.ListBoxTotal.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(727, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 19)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "TIPO DE PAGO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(438, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 19)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "SERVICIO"
        '
        'ListBoxDesc
        '
        Me.ListBoxDesc.BackColor = System.Drawing.Color.Cyan
        Me.ListBoxDesc.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxDesc.FormattingEnabled = True
        Me.ListBoxDesc.ItemHeight = 19
        Me.ListBoxDesc.Location = New System.Drawing.Point(963, 64)
        Me.ListBoxDesc.Name = "ListBoxDesc"
        Me.ListBoxDesc.Size = New System.Drawing.Size(87, 156)
        Me.ListBoxDesc.TabIndex = 36
        '
        'ListBoxSubtot
        '
        Me.ListBoxSubtot.BackColor = System.Drawing.Color.LightBlue
        Me.ListBoxSubtot.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxSubtot.FormattingEnabled = True
        Me.ListBoxSubtot.ItemHeight = 19
        Me.ListBoxSubtot.Location = New System.Drawing.Point(875, 64)
        Me.ListBoxSubtot.Name = "ListBoxSubtot"
        Me.ListBoxSubtot.Size = New System.Drawing.Size(71, 156)
        Me.ListBoxSubtot.TabIndex = 35
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1202, 605)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtNIT As TextBox
    Friend WithEvents TxtNoDias As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckEncamamiento As CheckBox
    Friend WithEvents CheckOperación As CheckBox
    Friend WithEvents CheckMaternidad As CheckBox
    Friend WithEvents RBotonCheque As RadioButton
    Friend WithEvents RBotonTarjetaC As RadioButton
    Friend WithEvents RBotonTarjetaD As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARDATOSToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBoxName As ListBox
    Friend WithEvents ListBoxNit As ListBox
    Friend WithEvents ListBoxDr As ListBox
    Friend WithEvents ListBoxDias As ListBox
    Friend WithEvents ListBoxServicio As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ListBoxHabi As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ListBoxPago As ListBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RBotonEfectivo As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ListBoxDesc As ListBox
    Friend WithEvents ListBoxSubtot As ListBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ListBoxTotal As ListBox
    Friend WithEvents Label15 As Label
End Class
