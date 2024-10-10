<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class verEmpleados
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
        Label7 = New Label()
        txtContra = New TextBox()
        txtApellido = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        txtNombre = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        cbUsuario = New ComboBox()
        MenuStrip1 = New MenuStrip()
        btnEditar = New ToolStripMenuItem()
        btnLimpiar = New ToolStripMenuItem()
        btbCargar = New ToolStripMenuItem()
        btnEliminar = New ToolStripMenuItem()
        btnRegresar = New ToolStripMenuItem()
        DataGridView1 = New DataGridView()
        cbTrabajo = New ComboBox()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label7.Location = New Point(99, 475)
        Label7.Name = "Label7"
        Label7.Size = New Size(124, 39)
        Label7.TabIndex = 30
        Label7.Text = "Trabajo"
        ' 
        ' txtContra
        ' 
        txtContra.Font = New Font("Times New Roman", 16.2F)
        txtContra.Location = New Point(244, 405)
        txtContra.Name = "txtContra"
        txtContra.Size = New Size(417, 39)
        txtContra.TabIndex = 29
        ' 
        ' txtApellido
        ' 
        txtApellido.Font = New Font("Times New Roman", 16.2F)
        txtApellido.Location = New Point(244, 338)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(417, 39)
        txtApellido.TabIndex = 28
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label4.Location = New Point(56, 405)
        Label4.Name = "Label4"
        Label4.Size = New Size(167, 39)
        Label4.TabIndex = 27
        Label4.Text = "Contraseña"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label5.Location = New Point(104, 338)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 39)
        Label5.TabIndex = 26
        Label5.Text = "Apellido"
        ' 
        ' txtNombre
        ' 
        txtNombre.Font = New Font("Times New Roman", 16.2F)
        txtNombre.Location = New Point(244, 271)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(417, 39)
        txtNombre.TabIndex = 25
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label3.Location = New Point(100, 271)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 39)
        Label3.TabIndex = 23
        Label3.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label2.Location = New Point(100, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 39)
        Label2.TabIndex = 22
        Label2.Text = "Usuario"
        ' 
        ' cbUsuario
        ' 
        cbUsuario.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbUsuario.FormattingEnabled = True
        cbUsuario.Location = New Point(244, 199)
        cbUsuario.Name = "cbUsuario"
        cbUsuario.Size = New Size(417, 39)
        cbUsuario.TabIndex = 35
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        MenuStrip1.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {btnEditar, btnLimpiar, btbCargar, btnEliminar, btnRegresar})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1461, 47)
        MenuStrip1.TabIndex = 36
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' btnEditar
        ' 
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(114, 43)
        btnEditar.Text = "Editar"
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(128, 43)
        btnLimpiar.Text = "Limpiar"
        ' 
        ' btbCargar
        ' 
        btbCargar.Name = "btbCargar"
        btbCargar.Size = New Size(207, 43)
        btbCargar.Text = "Cargar datos"
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(138, 43)
        btnEliminar.Text = "Eliminar"
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(152, 43)
        btnRegresar.Text = "Regresar"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DataGridView1.BackgroundColor = Color.LemonChiffon
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(732, 196)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(717, 288)
        DataGridView1.TabIndex = 37
        ' 
        ' cbTrabajo
        ' 
        cbTrabajo.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbTrabajo.FormattingEnabled = True
        cbTrabajo.Items.AddRange(New Object() {"Trabajo en alturas", "Trabajo en electricidad", "Trabajo en soldaduras", "Trabajo en excavación", "Trabajo en agricultura"})
        cbTrabajo.Location = New Point(244, 478)
        cbTrabajo.Name = "cbTrabajo"
        cbTrabajo.Size = New Size(417, 39)
        cbTrabajo.TabIndex = 38
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Hello Valentica", 47.9999962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(318, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(600, 92)
        Label1.TabIndex = 39
        Label1.Text = "Empleados registrados"
        ' 
        ' verEmpleados
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOrange
        ClientSize = New Size(1461, 599)
        Controls.Add(Label1)
        Controls.Add(cbTrabajo)
        Controls.Add(DataGridView1)
        Controls.Add(cbUsuario)
        Controls.Add(Label7)
        Controls.Add(txtContra)
        Controls.Add(txtApellido)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(txtNombre)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "verEmpleados"
        Text = "verEmpleados"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents txtContra As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbUsuario As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnEditar As ToolStripMenuItem
    Friend WithEvents btnEliminar As ToolStripMenuItem
    Friend WithEvents btnRegresar As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnLimpiar As ToolStripMenuItem
    Friend WithEvents btbCargar As ToolStripMenuItem
    Friend WithEvents cbTrabajo As ComboBox
    Friend WithEvents Label1 As Label
End Class
