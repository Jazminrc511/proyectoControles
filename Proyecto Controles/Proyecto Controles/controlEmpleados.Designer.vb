<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class controlEmpleados
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
        DataGridView1 = New DataGridView()
        cbUsuario = New ComboBox()
        Label7 = New Label()
        txtTrabajo = New TextBox()
        txtApellido = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        txtNombre = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        cbCumple = New ComboBox()
        MenuStrip2 = New MenuStrip()
        btnObtenerDatos = New ToolStripMenuItem()
        btnRegistrar = New ToolStripMenuItem()
        btnEditar = New ToolStripMenuItem()
        btnRegresar = New ToolStripMenuItem()
        Label1 = New Label()
        fecha = New DateTimePicker()
        Label6 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top
        DataGridView1.BackgroundColor = SystemColors.ActiveCaption
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(881, 229)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(665, 288)
        DataGridView1.TabIndex = 48
        ' 
        ' cbUsuario
        ' 
        cbUsuario.Anchor = AnchorStyles.Top
        cbUsuario.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbUsuario.FormattingEnabled = True
        cbUsuario.Location = New Point(275, 200)
        cbUsuario.Name = "cbUsuario"
        cbUsuario.Size = New Size(468, 39)
        cbUsuario.TabIndex = 47
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label7.Location = New Point(81, 552)
        Label7.Name = "Label7"
        Label7.Size = New Size(169, 39)
        Label7.TabIndex = 45
        Label7.Text = "Cumple EPP"
        ' 
        ' txtTrabajo
        ' 
        txtTrabajo.Anchor = AnchorStyles.Top
        txtTrabajo.Font = New Font("Times New Roman", 16.2F)
        txtTrabajo.Location = New Point(275, 406)
        txtTrabajo.Name = "txtTrabajo"
        txtTrabajo.Size = New Size(468, 39)
        txtTrabajo.TabIndex = 44
        ' 
        ' txtApellido
        ' 
        txtApellido.Anchor = AnchorStyles.Top
        txtApellido.Font = New Font("Times New Roman", 16.2F)
        txtApellido.Location = New Point(275, 339)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(468, 39)
        txtApellido.TabIndex = 43
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label4.Location = New Point(130, 406)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 39)
        Label4.TabIndex = 42
        Label4.Text = "Trabajo"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label5.Location = New Point(135, 339)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 39)
        Label5.TabIndex = 41
        Label5.Text = "Apellido"
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top
        txtNombre.Font = New Font("Times New Roman", 16.2F)
        txtNombre.Location = New Point(275, 272)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(468, 39)
        txtNombre.TabIndex = 40
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label3.Location = New Point(131, 272)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 39)
        Label3.TabIndex = 39
        Label3.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label2.Location = New Point(131, 197)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 39)
        Label2.TabIndex = 38
        Label2.Text = "Usuario"
        ' 
        ' cbCumple
        ' 
        cbCumple.Anchor = AnchorStyles.Top
        cbCumple.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbCumple.FormattingEnabled = True
        cbCumple.Items.AddRange(New Object() {"Si", "No"})
        cbCumple.Location = New Point(275, 555)
        cbCumple.Name = "cbCumple"
        cbCumple.Size = New Size(468, 39)
        cbCumple.TabIndex = 49
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        MenuStrip2.Font = New Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Items.AddRange(New ToolStripItem() {btnObtenerDatos, btnRegistrar, btnEditar, btnRegresar})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(1603, 39)
        MenuStrip2.TabIndex = 51
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' btnObtenerDatos
        ' 
        btnObtenerDatos.Name = "btnObtenerDatos"
        btnObtenerDatos.Size = New Size(200, 35)
        btnObtenerDatos.Text = "Obtener Datos"
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(132, 35)
        btnRegistrar.Text = "Registrar"
        ' 
        ' btnEditar
        ' 
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(100, 35)
        btnEditar.Text = "Editar"
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(130, 35)
        btnRegresar.Text = "Regresar"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label1.Location = New Point(154, 481)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 39)
        Label1.TabIndex = 52
        Label1.Text = "Fecha"
        ' 
        ' fecha
        ' 
        fecha.Anchor = AnchorStyles.Top
        fecha.CalendarFont = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fecha.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fecha.Location = New Point(275, 490)
        fecha.Name = "fecha"
        fecha.Size = New Size(468, 39)
        fecha.TabIndex = 54
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Hello Valentica", 47.9999962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(426, 69)
        Label6.Name = "Label6"
        Label6.Size = New Size(380, 92)
        Label6.TabIndex = 55
        Label6.Text = "Control EPP"
        ' 
        ' controlEmpleados
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        ClientSize = New Size(1603, 646)
        Controls.Add(Label6)
        Controls.Add(fecha)
        Controls.Add(Label1)
        Controls.Add(cbCumple)
        Controls.Add(DataGridView1)
        Controls.Add(cbUsuario)
        Controls.Add(Label7)
        Controls.Add(txtTrabajo)
        Controls.Add(txtApellido)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(txtNombre)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(MenuStrip2)
        Name = "controlEmpleados"
        Text = "controlEmpleados"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cbUsuario As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTrabajo As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbCumple As ComboBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents btnObtenerDatos As ToolStripMenuItem
    Friend WithEvents btnRegistrar As ToolStripMenuItem
    Friend WithEvents btnEditar As ToolStripMenuItem
    Friend WithEvents btnRegresar As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents Label6 As Label
End Class
