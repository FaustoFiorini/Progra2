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
        Me.TxtSueldo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RBotonTablet = New System.Windows.Forms.RadioButton()
        Me.RBotonDrone = New System.Windows.Forms.RadioButton()
        Me.RBotonCel = New System.Windows.Forms.RadioButton()
        Me.RBotonTV = New System.Windows.Forms.RadioButton()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBoxName = New System.Windows.Forms.ListBox()
        Me.ListBoxSueldo = New System.Windows.Forms.ListBox()
        Me.ListBoxCant = New System.Windows.Forms.ListBox()
        Me.ListBoxArt = New System.Windows.Forms.ListBox()
        Me.ListBoxComi = New System.Windows.Forms.ListBox()
        Me.ListBoxBono = New System.Windows.Forms.ListBox()
        Me.ListBoxSueldoF = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARDATOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(132, 40)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(162, 26)
        Me.TxtNombre.TabIndex = 0
        '
        'TxtSueldo
        '
        Me.TxtSueldo.Location = New System.Drawing.Point(132, 88)
        Me.TxtSueldo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtSueldo.Name = "TxtSueldo"
        Me.TxtSueldo.Size = New System.Drawing.Size(162, 26)
        Me.TxtSueldo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SUELDO"
        '
        'RBotonTablet
        '
        Me.RBotonTablet.AutoSize = True
        Me.RBotonTablet.Location = New System.Drawing.Point(35, 39)
        Me.RBotonTablet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RBotonTablet.Name = "RBotonTablet"
        Me.RBotonTablet.Size = New System.Drawing.Size(81, 23)
        Me.RBotonTablet.TabIndex = 4
        Me.RBotonTablet.TabStop = True
        Me.RBotonTablet.Text = "TABLET"
        Me.RBotonTablet.UseVisualStyleBackColor = True
        '
        'RBotonDrone
        '
        Me.RBotonDrone.AutoSize = True
        Me.RBotonDrone.Location = New System.Drawing.Point(35, 74)
        Me.RBotonDrone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RBotonDrone.Name = "RBotonDrone"
        Me.RBotonDrone.Size = New System.Drawing.Size(76, 23)
        Me.RBotonDrone.TabIndex = 5
        Me.RBotonDrone.TabStop = True
        Me.RBotonDrone.Text = "DRONE"
        Me.RBotonDrone.UseVisualStyleBackColor = True
        '
        'RBotonCel
        '
        Me.RBotonCel.AutoSize = True
        Me.RBotonCel.Location = New System.Drawing.Point(35, 108)
        Me.RBotonCel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RBotonCel.Name = "RBotonCel"
        Me.RBotonCel.Size = New System.Drawing.Size(88, 23)
        Me.RBotonCel.TabIndex = 6
        Me.RBotonCel.TabStop = True
        Me.RBotonCel.Text = "CELULAR"
        Me.RBotonCel.UseVisualStyleBackColor = True
        '
        'RBotonTV
        '
        Me.RBotonTV.AutoSize = True
        Me.RBotonTV.Location = New System.Drawing.Point(35, 142)
        Me.RBotonTV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RBotonTV.Name = "RBotonTV"
        Me.RBotonTV.Size = New System.Drawing.Size(105, 23)
        Me.RBotonTV.TabIndex = 7
        Me.RBotonTV.TabStop = True
        Me.RBotonTV.Text = "TELEVISOR"
        Me.RBotonTV.UseVisualStyleBackColor = True
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(132, 134)
        Me.TxtCantidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(162, 26)
        Me.TxtCantidad.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "CANTIDAD"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtCantidad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtSueldo)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(335, 215)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox2.Controls.Add(Me.RBotonTV)
        Me.GroupBox2.Controls.Add(Me.RBotonCel)
        Me.GroupBox2.Controls.Add(Me.RBotonDrone)
        Me.GroupBox2.Controls.Add(Me.RBotonTablet)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(379, 56)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(171, 215)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ARTÍCULOS"
        '
        'ListBoxName
        '
        Me.ListBoxName.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxName.FormattingEnabled = True
        Me.ListBoxName.ItemHeight = 19
        Me.ListBoxName.Location = New System.Drawing.Point(23, 51)
        Me.ListBoxName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBoxName.Name = "ListBoxName"
        Me.ListBoxName.Size = New System.Drawing.Size(120, 175)
        Me.ListBoxName.TabIndex = 12
        '
        'ListBoxSueldo
        '
        Me.ListBoxSueldo.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBoxSueldo.FormattingEnabled = True
        Me.ListBoxSueldo.ItemHeight = 19
        Me.ListBoxSueldo.Location = New System.Drawing.Point(149, 51)
        Me.ListBoxSueldo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBoxSueldo.Name = "ListBoxSueldo"
        Me.ListBoxSueldo.Size = New System.Drawing.Size(120, 175)
        Me.ListBoxSueldo.TabIndex = 13
        '
        'ListBoxCant
        '
        Me.ListBoxCant.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ListBoxCant.FormattingEnabled = True
        Me.ListBoxCant.ItemHeight = 19
        Me.ListBoxCant.Location = New System.Drawing.Point(275, 51)
        Me.ListBoxCant.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBoxCant.Name = "ListBoxCant"
        Me.ListBoxCant.Size = New System.Drawing.Size(120, 175)
        Me.ListBoxCant.TabIndex = 14
        '
        'ListBoxArt
        '
        Me.ListBoxArt.BackColor = System.Drawing.Color.Silver
        Me.ListBoxArt.FormattingEnabled = True
        Me.ListBoxArt.ItemHeight = 19
        Me.ListBoxArt.Location = New System.Drawing.Point(401, 51)
        Me.ListBoxArt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBoxArt.Name = "ListBoxArt"
        Me.ListBoxArt.Size = New System.Drawing.Size(120, 175)
        Me.ListBoxArt.TabIndex = 15
        '
        'ListBoxComi
        '
        Me.ListBoxComi.BackColor = System.Drawing.SystemColors.Menu
        Me.ListBoxComi.FormattingEnabled = True
        Me.ListBoxComi.ItemHeight = 19
        Me.ListBoxComi.Location = New System.Drawing.Point(527, 51)
        Me.ListBoxComi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBoxComi.Name = "ListBoxComi"
        Me.ListBoxComi.Size = New System.Drawing.Size(120, 175)
        Me.ListBoxComi.TabIndex = 16
        '
        'ListBoxBono
        '
        Me.ListBoxBono.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListBoxBono.FormattingEnabled = True
        Me.ListBoxBono.ItemHeight = 19
        Me.ListBoxBono.Location = New System.Drawing.Point(653, 51)
        Me.ListBoxBono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBoxBono.Name = "ListBoxBono"
        Me.ListBoxBono.Size = New System.Drawing.Size(120, 175)
        Me.ListBoxBono.TabIndex = 17
        '
        'ListBoxSueldoF
        '
        Me.ListBoxSueldoF.BackColor = System.Drawing.Color.Cyan
        Me.ListBoxSueldoF.FormattingEnabled = True
        Me.ListBoxSueldoF.ItemHeight = 19
        Me.ListBoxSueldoF.Location = New System.Drawing.Point(779, 51)
        Me.ListBoxSueldoF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBoxSueldoF.Name = "ListBoxSueldoF"
        Me.ListBoxSueldoF.Size = New System.Drawing.Size(120, 175)
        Me.ListBoxSueldoF.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 19)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "NOMBRE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(146, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 19)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "SUELDO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(272, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 19)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "CANTIDAD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(398, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 19)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "ARTÍCULO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(524, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 19)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "COMISIÓN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(650, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 19)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "BONO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(776, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 19)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "SUELDO FINAL"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.ListBoxSueldoF)
        Me.GroupBox3.Controls.Add(Me.ListBoxBono)
        Me.GroupBox3.Controls.Add(Me.ListBoxComi)
        Me.GroupBox3.Controls.Add(Me.ListBoxArt)
        Me.GroupBox3.Controls.Add(Me.ListBoxCant)
        Me.GroupBox3.Controls.Add(Me.ListBoxSueldo)
        Me.GroupBox3.Controls.Add(Me.ListBoxName)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 279)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(950, 242)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RESULTADOS"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.LIMPIARDATOSToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1138, 29)
        Me.MenuStrip2.TabIndex = 28
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(101, 25)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(176, 25)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.BackColor = System.Drawing.Color.Red
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(71, 25)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'LIMPIARDATOSToolStripMenuItem
        '
        Me.LIMPIARDATOSToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LIMPIARDATOSToolStripMenuItem.Name = "LIMPIARDATOSToolStripMenuItem"
        Me.LIMPIARDATOSToolStripMenuItem.Size = New System.Drawing.Size(151, 25)
        Me.LIMPIARDATOSToolStripMenuItem.Text = "LIMPIAR DATOS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1138, 680)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtSueldo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RBotonTablet As RadioButton
    Friend WithEvents RBotonDrone As RadioButton
    Friend WithEvents RBotonCel As RadioButton
    Friend WithEvents RBotonTV As RadioButton
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListBoxName As ListBox
    Friend WithEvents ListBoxSueldo As ListBox
    Friend WithEvents ListBoxCant As ListBox
    Friend WithEvents ListBoxArt As ListBox
    Friend WithEvents ListBoxComi As ListBox
    Friend WithEvents ListBoxBono As ListBox
    Friend WithEvents ListBoxSueldoF As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARDATOSToolStripMenuItem As ToolStripMenuItem
End Class
