<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro
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
        Label1 = New Label()
        txtApellido = New TextBox()
        txtNombre = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        txtContra = New TextBox()
        txtUsuario = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        btnRegistro = New Button()
        btnRegresar = New Button()
        cbTrabajo = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(267, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 54)
        Label1.TabIndex = 3
        Label1.Text = "Registro"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtApellido
        ' 
        txtApellido.Anchor = AnchorStyles.Top
        txtApellido.Font = New Font("Times New Roman", 16.2F)
        txtApellido.Location = New Point(245, 208)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(353, 39)
        txtApellido.TabIndex = 10
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top
        txtNombre.Font = New Font("Times New Roman", 16.2F)
        txtNombre.Location = New Point(245, 136)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(353, 39)
        txtNombre.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label3.Location = New Point(101, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 39)
        Label3.TabIndex = 8
        Label3.Text = "Apellido"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label2.Location = New Point(101, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 39)
        Label2.TabIndex = 7
        Label2.Text = "Nombre"
        ' 
        ' txtContra
        ' 
        txtContra.Anchor = AnchorStyles.Top
        txtContra.Font = New Font("Times New Roman", 16.2F)
        txtContra.Location = New Point(245, 342)
        txtContra.Name = "txtContra"
        txtContra.Size = New Size(353, 39)
        txtContra.TabIndex = 14
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Anchor = AnchorStyles.Top
        txtUsuario.Font = New Font("Times New Roman", 16.2F)
        txtUsuario.Location = New Point(245, 275)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(353, 39)
        txtUsuario.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label4.Location = New Point(57, 342)
        Label4.Name = "Label4"
        Label4.Size = New Size(167, 39)
        Label4.TabIndex = 12
        Label4.Text = "Contraseña"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label5.Location = New Point(105, 275)
        Label5.Name = "Label5"
        Label5.Size = New Size(119, 39)
        Label5.TabIndex = 11
        Label5.Text = "Usuario"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label7.Location = New Point(100, 412)
        Label7.Name = "Label7"
        Label7.Size = New Size(124, 39)
        Label7.TabIndex = 15
        Label7.Text = "Trabajo"
        ' 
        ' btnRegistro
        ' 
        btnRegistro.Anchor = AnchorStyles.Top
        btnRegistro.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnRegistro.Font = New Font("MV Boli", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegistro.Location = New Point(105, 565)
        btnRegistro.Name = "btnRegistro"
        btnRegistro.Size = New Size(216, 55)
        btnRegistro.TabIndex = 19
        btnRegistro.Text = "Registrarse"
        btnRegistro.UseVisualStyleBackColor = False
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Anchor = AnchorStyles.Top
        btnRegresar.BackColor = Color.Cyan
        btnRegresar.Font = New Font("MV Boli", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegresar.Location = New Point(460, 565)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(174, 55)
        btnRegresar.TabIndex = 20
        btnRegresar.Text = "Regresar"
        btnRegresar.UseVisualStyleBackColor = False
        ' 
        ' cbTrabajo
        ' 
        cbTrabajo.Anchor = AnchorStyles.Top
        cbTrabajo.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbTrabajo.FormattingEnabled = True
        cbTrabajo.Items.AddRange(New Object() {"Trabajo en alturas", "Trabajo en electricidad", "Trabajo en soldaduras", "Trabajo en excavación", "Trabajo en agricultura"})
        cbTrabajo.Location = New Point(245, 412)
        cbTrabajo.Name = "cbTrabajo"
        cbTrabajo.Size = New Size(353, 39)
        cbTrabajo.TabIndex = 21
        ' 
        ' registro
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 641)
        Controls.Add(cbTrabajo)
        Controls.Add(btnRegresar)
        Controls.Add(btnRegistro)
        Controls.Add(Label7)
        Controls.Add(txtContra)
        Controls.Add(txtUsuario)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "registro"
        Text = "registro"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtContra As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRegistro As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents cbTrabajo As ComboBox
End Class
