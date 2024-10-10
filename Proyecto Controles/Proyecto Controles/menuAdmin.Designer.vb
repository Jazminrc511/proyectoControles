<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuAdmin
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
        btnVerEmpleados = New Button()
        btnControl = New Button()
        btnCerrar = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnVerEmpleados
        ' 
        btnVerEmpleados.Anchor = AnchorStyles.Top
        btnVerEmpleados.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnVerEmpleados.Font = New Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnVerEmpleados.Location = New Point(349, 172)
        btnVerEmpleados.Name = "btnVerEmpleados"
        btnVerEmpleados.Size = New Size(268, 58)
        btnVerEmpleados.TabIndex = 0
        btnVerEmpleados.Text = "Ver empleados"
        btnVerEmpleados.UseVisualStyleBackColor = False
        ' 
        ' btnControl
        ' 
        btnControl.Anchor = AnchorStyles.Top
        btnControl.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        btnControl.Font = New Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnControl.Location = New Point(349, 286)
        btnControl.Name = "btnControl"
        btnControl.Size = New Size(268, 95)
        btnControl.TabIndex = 1
        btnControl.Text = "Control de empleados"
        btnControl.UseVisualStyleBackColor = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Anchor = AnchorStyles.Top
        btnCerrar.BackColor = Color.Red
        btnCerrar.Font = New Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCerrar.Location = New Point(349, 469)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(268, 58)
        btnCerrar.TabIndex = 2
        btnCerrar.Text = "Cerrar sesión"
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Hello Valentica", 47.9999962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(213, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(595, 92)
        Label1.TabIndex = 40
        Label1.Text = "Menu Administrador"
        ' 
        ' menuAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        ClientSize = New Size(1051, 543)
        Controls.Add(btnCerrar)
        Controls.Add(btnControl)
        Controls.Add(btnVerEmpleados)
        Controls.Add(Label1)
        Name = "menuAdmin"
        Text = "menuAdmin"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnVerEmpleados As Button
    Friend WithEvents btnControl As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label1 As Label
End Class
