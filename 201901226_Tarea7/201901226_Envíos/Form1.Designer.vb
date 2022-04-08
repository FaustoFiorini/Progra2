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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ACEPTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARESTADÍSTICASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARESTADÍSTICASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtPaquete = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxPaquete = New System.Windows.Forms.ComboBox()
        Me.ComboBoxEnvio = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBoxNombre = New System.Windows.Forms.ListBox()
        Me.ListBoxPaquete = New System.Windows.Forms.ListBox()
        Me.ListBoxPeso = New System.Windows.Forms.ListBox()
        Me.ListBoxPrecio = New System.Windows.Forms.ListBox()
        Me.ListBoxEnvio = New System.Windows.Forms.ListBox()
        Me.ListBoxImpuesto = New System.Windows.Forms.ListBox()
        Me.ListBoxPP = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ListBoxPT = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtTotalLociones = New System.Windows.Forms.TextBox()
        Me.TxtPaquetesPlastico = New System.Windows.Forms.TextBox()
        Me.TxtPaqueteDocumento = New System.Windows.Forms.TextBox()
        Me.TxtPaqueteRopa = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACEPTARToolStripMenuItem, Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.LIMPIARESTADÍSTICASToolStripMenuItem, Me.MOSTRARVECTORESToolStripMenuItem, Me.MOSTRARESTADÍSTICASToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1177, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ACEPTARToolStripMenuItem
        '
        Me.ACEPTARToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ACEPTARToolStripMenuItem.Name = "ACEPTARToolStripMenuItem"
        Me.ACEPTARToolStripMenuItem.Size = New System.Drawing.Size(92, 25)
        Me.ACEPTARToolStripMenuItem.Text = "ACEPTAR"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(181, 25)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(176, 25)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'LIMPIARESTADÍSTICASToolStripMenuItem
        '
        Me.LIMPIARESTADÍSTICASToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro
        Me.LIMPIARESTADÍSTICASToolStripMenuItem.Name = "LIMPIARESTADÍSTICASToolStripMenuItem"
        Me.LIMPIARESTADÍSTICASToolStripMenuItem.Size = New System.Drawing.Size(214, 25)
        Me.LIMPIARESTADÍSTICASToolStripMenuItem.Text = "LIMPIAR ESTADÍSTICAS"
        '
        'MOSTRARVECTORESToolStripMenuItem
        '
        Me.MOSTRARVECTORESToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.MOSTRARVECTORESToolStripMenuItem.Name = "MOSTRARVECTORESToolStripMenuItem"
        Me.MOSTRARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(186, 25)
        Me.MOSTRARVECTORESToolStripMenuItem.Text = "MOSTRAR VECTORES"
        '
        'MOSTRARESTADÍSTICASToolStripMenuItem
        '
        Me.MOSTRARESTADÍSTICASToolStripMenuItem.BackColor = System.Drawing.Color.LightCoral
        Me.MOSTRARESTADÍSTICASToolStripMenuItem.Name = "MOSTRARESTADÍSTICASToolStripMenuItem"
        Me.MOSTRARESTADÍSTICASToolStripMenuItem.Size = New System.Drawing.Size(224, 25)
        Me.MOSTRARESTADÍSTICASToolStripMenuItem.Text = "MOSTRAR ESTADÍSTICAS"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(71, 25)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.MistyRose
        Me.TxtNombre.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(206, 44)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(260, 26)
        Me.TxtNombre.TabIndex = 1
        '
        'TxtPaquete
        '
        Me.TxtPaquete.BackColor = System.Drawing.Color.MistyRose
        Me.TxtPaquete.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPaquete.Location = New System.Drawing.Point(206, 90)
        Me.TxtPaquete.Name = "TxtPaquete"
        Me.TxtPaquete.Size = New System.Drawing.Size(124, 26)
        Me.TxtPaquete.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NOMBRE DEL CLIENTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PRECIO DEL PAQUETE"
        '
        'ComboBoxPaquete
        '
        Me.ComboBoxPaquete.BackColor = System.Drawing.Color.Bisque
        Me.ComboBoxPaquete.FormattingEnabled = True
        Me.ComboBoxPaquete.Items.AddRange(New Object() {"DOCUMENTOS", "ROPA", "ARTÍCULOS PEDECEDEROS", "ARTÍCULOS DE PLÁSTICO", "LOCIONES"})
        Me.ComboBoxPaquete.Location = New System.Drawing.Point(17, 175)
        Me.ComboBoxPaquete.Name = "ComboBoxPaquete"
        Me.ComboBoxPaquete.Size = New System.Drawing.Size(168, 24)
        Me.ComboBoxPaquete.TabIndex = 5
        '
        'ComboBoxEnvio
        '
        Me.ComboBoxEnvio.BackColor = System.Drawing.Color.Bisque
        Me.ComboBoxEnvio.FormattingEnabled = True
        Me.ComboBoxEnvio.Items.AddRange(New Object() {"CAMIÓN", "MOTOCICLETA"})
        Me.ComboBoxEnvio.Location = New System.Drawing.Point(17, 237)
        Me.ComboBoxEnvio.Name = "ComboBoxEnvio"
        Me.ComboBoxEnvio.Size = New System.Drawing.Size(162, 24)
        Me.ComboBoxEnvio.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "TIPO DE PAQUETE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "FORMA DE ENVÍO"
        '
        'ListBoxNombre
        '
        Me.ListBoxNombre.BackColor = System.Drawing.Color.DarkSalmon
        Me.ListBoxNombre.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxNombre.FormattingEnabled = True
        Me.ListBoxNombre.ItemHeight = 19
        Me.ListBoxNombre.Location = New System.Drawing.Point(14, 57)
        Me.ListBoxNombre.Name = "ListBoxNombre"
        Me.ListBoxNombre.Size = New System.Drawing.Size(212, 156)
        Me.ListBoxNombre.TabIndex = 9
        '
        'ListBoxPaquete
        '
        Me.ListBoxPaquete.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ListBoxPaquete.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPaquete.FormattingEnabled = True
        Me.ListBoxPaquete.ItemHeight = 19
        Me.ListBoxPaquete.Location = New System.Drawing.Point(232, 57)
        Me.ListBoxPaquete.Name = "ListBoxPaquete"
        Me.ListBoxPaquete.Size = New System.Drawing.Size(188, 156)
        Me.ListBoxPaquete.TabIndex = 10
        '
        'ListBoxPeso
        '
        Me.ListBoxPeso.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxPeso.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPeso.FormattingEnabled = True
        Me.ListBoxPeso.ItemHeight = 19
        Me.ListBoxPeso.Location = New System.Drawing.Point(426, 57)
        Me.ListBoxPeso.Name = "ListBoxPeso"
        Me.ListBoxPeso.Size = New System.Drawing.Size(84, 156)
        Me.ListBoxPeso.TabIndex = 11
        '
        'ListBoxPrecio
        '
        Me.ListBoxPrecio.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ListBoxPrecio.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPrecio.FormattingEnabled = True
        Me.ListBoxPrecio.ItemHeight = 19
        Me.ListBoxPrecio.Location = New System.Drawing.Point(516, 57)
        Me.ListBoxPrecio.Name = "ListBoxPrecio"
        Me.ListBoxPrecio.Size = New System.Drawing.Size(88, 156)
        Me.ListBoxPrecio.TabIndex = 12
        '
        'ListBoxEnvio
        '
        Me.ListBoxEnvio.BackColor = System.Drawing.Color.Salmon
        Me.ListBoxEnvio.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxEnvio.FormattingEnabled = True
        Me.ListBoxEnvio.ItemHeight = 19
        Me.ListBoxEnvio.Location = New System.Drawing.Point(610, 57)
        Me.ListBoxEnvio.Name = "ListBoxEnvio"
        Me.ListBoxEnvio.Size = New System.Drawing.Size(120, 156)
        Me.ListBoxEnvio.TabIndex = 13
        '
        'ListBoxImpuesto
        '
        Me.ListBoxImpuesto.BackColor = System.Drawing.SystemColors.Control
        Me.ListBoxImpuesto.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxImpuesto.FormattingEnabled = True
        Me.ListBoxImpuesto.ItemHeight = 19
        Me.ListBoxImpuesto.Location = New System.Drawing.Point(736, 57)
        Me.ListBoxImpuesto.Name = "ListBoxImpuesto"
        Me.ListBoxImpuesto.Size = New System.Drawing.Size(120, 156)
        Me.ListBoxImpuesto.TabIndex = 14
        '
        'ListBoxPP
        '
        Me.ListBoxPP.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ListBoxPP.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPP.FormattingEnabled = True
        Me.ListBoxPP.ItemHeight = 19
        Me.ListBoxPP.Location = New System.Drawing.Point(862, 57)
        Me.ListBoxPP.Name = "ListBoxPP"
        Me.ListBoxPP.Size = New System.Drawing.Size(120, 156)
        Me.ListBoxPP.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "NOMBRE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(422, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "PESO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(229, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 19)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "PAQUETE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(512, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "PRECIO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(607, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 19)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "ENVÍO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(733, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 19)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "IMPUESTO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(859, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 19)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "PAGO PARCIAL"
        '
        'ListBoxPT
        '
        Me.ListBoxPT.BackColor = System.Drawing.Color.DarkSalmon
        Me.ListBoxPT.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPT.FormattingEnabled = True
        Me.ListBoxPT.ItemHeight = 19
        Me.ListBoxPT.Location = New System.Drawing.Point(988, 57)
        Me.ListBoxPT.Name = "ListBoxPT"
        Me.ListBoxPT.Size = New System.Drawing.Size(120, 156)
        Me.ListBoxPT.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(985, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 19)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "PAGO TOTAL"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(28, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(370, 19)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Total (Q) de lo que se envió de los paquetes de lociones"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(28, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(363, 19)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "¿Cuántos paquetes de artículos de plástico se enviaron?"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(28, 139)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(393, 19)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Total (Q) de lo que se envió de los paquetes de documentos"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(28, 194)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(307, 19)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Total (Q) de paquetes de ropa que se enviaron"
        '
        'TxtTotalLociones
        '
        Me.TxtTotalLociones.BackColor = System.Drawing.Color.MistyRose
        Me.TxtTotalLociones.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalLociones.Location = New System.Drawing.Point(464, 22)
        Me.TxtTotalLociones.Name = "TxtTotalLociones"
        Me.TxtTotalLociones.Size = New System.Drawing.Size(124, 26)
        Me.TxtTotalLociones.TabIndex = 29
        '
        'TxtPaquetesPlastico
        '
        Me.TxtPaquetesPlastico.BackColor = System.Drawing.Color.MistyRose
        Me.TxtPaquetesPlastico.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPaquetesPlastico.Location = New System.Drawing.Point(464, 75)
        Me.TxtPaquetesPlastico.Name = "TxtPaquetesPlastico"
        Me.TxtPaquetesPlastico.Size = New System.Drawing.Size(124, 26)
        Me.TxtPaquetesPlastico.TabIndex = 30
        '
        'TxtPaqueteDocumento
        '
        Me.TxtPaqueteDocumento.BackColor = System.Drawing.Color.MistyRose
        Me.TxtPaqueteDocumento.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPaqueteDocumento.Location = New System.Drawing.Point(464, 132)
        Me.TxtPaqueteDocumento.Name = "TxtPaqueteDocumento"
        Me.TxtPaqueteDocumento.Size = New System.Drawing.Size(124, 26)
        Me.TxtPaqueteDocumento.TabIndex = 31
        '
        'TxtPaqueteRopa
        '
        Me.TxtPaqueteRopa.BackColor = System.Drawing.Color.MistyRose
        Me.TxtPaqueteRopa.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPaqueteRopa.Location = New System.Drawing.Point(464, 191)
        Me.TxtPaqueteRopa.Name = "TxtPaqueteRopa"
        Me.TxtPaqueteRopa.Size = New System.Drawing.Size(124, 26)
        Me.TxtPaqueteRopa.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox1.Controls.Add(Me.TxtPaqueteRopa)
        Me.GroupBox1.Controls.Add(Me.TxtPaqueteDocumento)
        Me.GroupBox1.Controls.Add(Me.TxtPaquetesPlastico)
        Me.GroupBox1.Controls.Add(Me.TxtTotalLociones)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(579, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 229)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ESTADÍSTICAS"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.ListBoxPT)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ListBoxPP)
        Me.GroupBox2.Controls.Add(Me.ListBoxImpuesto)
        Me.GroupBox2.Controls.Add(Me.ListBoxEnvio)
        Me.GroupBox2.Controls.Add(Me.ListBoxPrecio)
        Me.GroupBox2.Controls.Add(Me.ListBoxPeso)
        Me.GroupBox2.Controls.Add(Me.ListBoxPaquete)
        Me.GroupBox2.Controls.Add(Me.ListBoxNombre)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 284)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1134, 224)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESULTADOS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1177, 509)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxEnvio)
        Me.Controls.Add(Me.ComboBoxPaquete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPaquete)
        Me.Controls.Add(Me.TxtNombre)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ACEPTARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOSTRARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtPaquete As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxPaquete As ComboBox
    Friend WithEvents ComboBoxEnvio As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBoxNombre As ListBox
    Friend WithEvents ListBoxPaquete As ListBox
    Friend WithEvents ListBoxPeso As ListBox
    Friend WithEvents ListBoxPrecio As ListBox
    Friend WithEvents ListBoxEnvio As ListBox
    Friend WithEvents ListBoxImpuesto As ListBox
    Friend WithEvents ListBoxPP As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ListBoxPT As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtTotalLociones As TextBox
    Friend WithEvents TxtPaquetesPlastico As TextBox
    Friend WithEvents TxtPaqueteDocumento As TextBox
    Friend WithEvents TxtPaqueteRopa As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MOSTRARESTADÍSTICASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARESTADÍSTICASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
End Class
