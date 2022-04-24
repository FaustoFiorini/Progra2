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
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BUSCARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACTUALIZARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ELIMINARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtIdentificación = New System.Windows.Forms.TextBox()
        Me.TxtDías = New System.Windows.Forms.TextBox()
        Me.TxtPersonas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxViajes = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtConsulta = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Info
        Me.MenuStrip1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.MOSTRARToolStripMenuItem, Me.BUSCARToolStripMenuItem, Me.ACTUALIZARToolStripMenuItem, Me.ELIMINARToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.LIMPIARENTRADASToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(997, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(92, 25)
        Me.CALCULARToolStripMenuItem.Text = "ACEPTAR"
        '
        'MOSTRARToolStripMenuItem
        '
        Me.MOSTRARToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MOSTRARToolStripMenuItem.Name = "MOSTRARToolStripMenuItem"
        Me.MOSTRARToolStripMenuItem.Size = New System.Drawing.Size(100, 25)
        Me.MOSTRARToolStripMenuItem.Text = "MOSTRAR"
        '
        'BUSCARToolStripMenuItem
        '
        Me.BUSCARToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BUSCARToolStripMenuItem.Name = "BUSCARToolStripMenuItem"
        Me.BUSCARToolStripMenuItem.Size = New System.Drawing.Size(84, 25)
        Me.BUSCARToolStripMenuItem.Text = "BUSCAR"
        '
        'ACTUALIZARToolStripMenuItem
        '
        Me.ACTUALIZARToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.ACTUALIZARToolStripMenuItem.Name = "ACTUALIZARToolStripMenuItem"
        Me.ACTUALIZARToolStripMenuItem.Size = New System.Drawing.Size(123, 25)
        Me.ACTUALIZARToolStripMenuItem.Text = "ACTUALIZAR"
        '
        'ELIMINARToolStripMenuItem
        '
        Me.ELIMINARToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ELIMINARToolStripMenuItem.Name = "ELIMINARToolStripMenuItem"
        Me.ELIMINARToolStripMenuItem.Size = New System.Drawing.Size(103, 25)
        Me.ELIMINARToolStripMenuItem.Text = "ELIMINAR"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(176, 25)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(181, 25)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.BackColor = System.Drawing.Color.Red
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(71, 25)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'TxtIdentificación
        '
        Me.TxtIdentificación.Location = New System.Drawing.Point(262, 45)
        Me.TxtIdentificación.Name = "TxtIdentificación"
        Me.TxtIdentificación.Size = New System.Drawing.Size(205, 26)
        Me.TxtIdentificación.TabIndex = 1
        '
        'TxtDías
        '
        Me.TxtDías.Location = New System.Drawing.Point(262, 87)
        Me.TxtDías.Name = "TxtDías"
        Me.TxtDías.Size = New System.Drawing.Size(205, 26)
        Me.TxtDías.TabIndex = 2
        '
        'TxtPersonas
        '
        Me.TxtPersonas.Location = New System.Drawing.Point(262, 129)
        Me.TxtPersonas.Name = "TxtPersonas"
        Me.TxtPersonas.Size = New System.Drawing.Size(205, 26)
        Me.TxtPersonas.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NO. DE IDENTIFICACIÓN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NO. DE DÍAS "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "NO. DE PERSONAS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBoxViajes)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtPersonas)
        Me.GroupBox1.Controls.Add(Me.TxtDías)
        Me.GroupBox1.Controls.Add(Me.TxtIdentificación)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 220)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "TIPO DE VIAJE"
        '
        'ComboBoxViajes
        '
        Me.ComboBoxViajes.FormattingEnabled = True
        Me.ComboBoxViajes.Items.AddRange(New Object() {"BIOTOPO DEL QUETZAL", "LAGUNA BRAVA", "MIRADOR"})
        Me.ComboBoxViajes.Location = New System.Drawing.Point(262, 172)
        Me.ComboBoxViajes.Name = "ComboBoxViajes"
        Me.ComboBoxViajes.Size = New System.Drawing.Size(205, 27)
        Me.ComboBoxViajes.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(Me.TxtConsulta)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(613, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 109)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BUSQUEDA POR NO. DE IDENTIFICACIÓN"
        '
        'TxtConsulta
        '
        Me.TxtConsulta.Location = New System.Drawing.Point(55, 48)
        Me.TxtConsulta.Name = "TxtConsulta"
        Me.TxtConsulta.Size = New System.Drawing.Size(208, 26)
        Me.TxtConsulta.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(28, 350)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(673, 150)
        Me.DataGridView1.TabIndex = 9
        '
        'Column1
        '
        Me.Column1.HeaderText = "NO. IDENTIFICACIÓN"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "NO. DE DÍAS"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "NO. DE PERSONAS"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "TIPO DE VIAJE"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "TOTAL A PAGAR"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(997, 578)
        Me.Controls.Add(Me.DataGridView1)
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOSTRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BUSCARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ELIMINARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtIdentificación As TextBox
    Friend WithEvents TxtDías As TextBox
    Friend WithEvents TxtPersonas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxViajes As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtConsulta As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents ACTUALIZARToolStripMenuItem As ToolStripMenuItem
End Class
