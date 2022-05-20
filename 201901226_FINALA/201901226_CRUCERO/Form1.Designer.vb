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
        Me.OPERARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ORDENARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxCabina = New System.Windows.Forms.ComboBox()
        Me.ComboBoxClase = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPersonas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TxtConsulta = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPERARToolStripMenuItem, Me.MOSTRARToolStripMenuItem, Me.CONSULTARToolStripMenuItem, Me.ORDENARToolStripMenuItem, Me.LIMPIARToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1085, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OPERARToolStripMenuItem
        '
        Me.OPERARToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.OPERARToolStripMenuItem.Name = "OPERARToolStripMenuItem"
        Me.OPERARToolStripMenuItem.Size = New System.Drawing.Size(84, 25)
        Me.OPERARToolStripMenuItem.Text = "OPERAR"
        '
        'MOSTRARToolStripMenuItem
        '
        Me.MOSTRARToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.MOSTRARToolStripMenuItem.Name = "MOSTRARToolStripMenuItem"
        Me.MOSTRARToolStripMenuItem.Size = New System.Drawing.Size(100, 25)
        Me.MOSTRARToolStripMenuItem.Text = "MOSTRAR"
        '
        'CONSULTARToolStripMenuItem
        '
        Me.CONSULTARToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CONSULTARToolStripMenuItem.Name = "CONSULTARToolStripMenuItem"
        Me.CONSULTARToolStripMenuItem.Size = New System.Drawing.Size(117, 25)
        Me.CONSULTARToolStripMenuItem.Text = "CONSULTAR"
        '
        'ORDENARToolStripMenuItem
        '
        Me.ORDENARToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.ORDENARToolStripMenuItem.Name = "ORDENARToolStripMenuItem"
        Me.ORDENARToolStripMenuItem.Size = New System.Drawing.Size(99, 25)
        Me.ORDENARToolStripMenuItem.Text = "ORDENAR"
        '
        'LIMPIARToolStripMenuItem
        '
        Me.LIMPIARToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown
        Me.LIMPIARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ENTRADASToolStripMenuItem, Me.VECTORESToolStripMenuItem})
        Me.LIMPIARToolStripMenuItem.Name = "LIMPIARToolStripMenuItem"
        Me.LIMPIARToolStripMenuItem.Size = New System.Drawing.Size(90, 25)
        Me.LIMPIARToolStripMenuItem.Text = "LIMPIAR"
        '
        'ENTRADASToolStripMenuItem
        '
        Me.ENTRADASToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ENTRADASToolStripMenuItem.Name = "ENTRADASToolStripMenuItem"
        Me.ENTRADASToolStripMenuItem.Size = New System.Drawing.Size(178, 26)
        Me.ENTRADASToolStripMenuItem.Text = "ENTRADAS"
        '
        'VECTORESToolStripMenuItem
        '
        Me.VECTORESToolStripMenuItem.BackColor = System.Drawing.Color.Peru
        Me.VECTORESToolStripMenuItem.Name = "VECTORESToolStripMenuItem"
        Me.VECTORESToolStripMenuItem.Size = New System.Drawing.Size(178, 26)
        Me.VECTORESToolStripMenuItem.Text = "VECTORES"
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
        Me.TxtNombre.Location = New System.Drawing.Point(172, 39)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(155, 26)
        Me.TxtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NIT"
        '
        'TxtNit
        '
        Me.TxtNit.Location = New System.Drawing.Point(172, 76)
        Me.TxtNit.Name = "TxtNit"
        Me.TxtNit.Size = New System.Drawing.Size(155, 26)
        Me.TxtNit.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TIPO DE CABINA"
        '
        'ComboBoxCabina
        '
        Me.ComboBoxCabina.FormattingEnabled = True
        Me.ComboBoxCabina.Items.AddRange(New Object() {"SENCILLA", "DOBLE", "COMPARTIDA"})
        Me.ComboBoxCabina.Location = New System.Drawing.Point(156, 48)
        Me.ComboBoxCabina.Name = "ComboBoxCabina"
        Me.ComboBoxCabina.Size = New System.Drawing.Size(155, 27)
        Me.ComboBoxCabina.TabIndex = 6
        '
        'ComboBoxClase
        '
        Me.ComboBoxClase.FormattingEnabled = True
        Me.ComboBoxClase.Items.AddRange(New Object() {"PRIMERA CLASE ", "SEGUNDA CLASE"})
        Me.ComboBoxClase.Location = New System.Drawing.Point(156, 92)
        Me.ComboBoxClase.Name = "ComboBoxClase"
        Me.ComboBoxClase.Size = New System.Drawing.Size(155, 27)
        Me.ComboBoxClase.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "TIPO DE CLASE"
        '
        'TxtPersonas
        '
        Me.TxtPersonas.Location = New System.Drawing.Point(172, 116)
        Me.TxtPersonas.Name = "TxtPersonas"
        Me.TxtPersonas.Size = New System.Drawing.Size(155, 26)
        Me.TxtPersonas.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "NO. DE PERSONAS"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(111, 321)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(905, 148)
        Me.DataGridView1.TabIndex = 11
        '
        'TxtConsulta
        '
        Me.TxtConsulta.Location = New System.Drawing.Point(41, 45)
        Me.TxtConsulta.Name = "TxtConsulta"
        Me.TxtConsulta.Size = New System.Drawing.Size(157, 26)
        Me.TxtConsulta.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.TxtPersonas)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtNit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 176)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkSalmon
        Me.GroupBox2.Controls.Add(Me.ComboBoxClase)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ComboBoxCabina)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(446, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(324, 176)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SERVICIO"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox3.Controls.Add(Me.TxtConsulta)
        Me.GroupBox3.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(818, 73)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(235, 106)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CONSULTAR NIT"
        '
        'Column1
        '
        Me.Column1.HeaderText = "NOMBRE"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "NIT"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "TIPO DE CABINA"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "TIPO DE CLASE"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "NO. DE PERSONAS"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "PRECIO INDIVIDUAL "
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "TOTAL"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1085, 573)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OPERARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOSTRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ORDENARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNit As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxCabina As ComboBox
    Friend WithEvents ComboBoxClase As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPersonas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TxtConsulta As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
