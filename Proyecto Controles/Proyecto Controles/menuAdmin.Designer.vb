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
        btnCerrar = New Button()
        Label1 = New Label()
        btnRegistrar = New Button()
        btnAgricultura = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' btnVerEmpleados
        ' 
        btnVerEmpleados.Anchor = AnchorStyles.Top
        btnVerEmpleados.BackColor = Color.Blue
        btnVerEmpleados.Font = New Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnVerEmpleados.ForeColor = Color.White
        btnVerEmpleados.Location = New Point(124, 179)
        btnVerEmpleados.Name = "btnVerEmpleados"
        btnVerEmpleados.Size = New Size(233, 86)
        btnVerEmpleados.TabIndex = 0
        btnVerEmpleados.Text = "Ver empleados"
        btnVerEmpleados.UseVisualStyleBackColor = False
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
        ' btnRegistrar
        ' 
        btnRegistrar.Anchor = AnchorStyles.Top
        btnRegistrar.BackColor = Color.Blue
        btnRegistrar.Font = New Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegistrar.ForeColor = Color.White
        btnRegistrar.Location = New Point(461, 179)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(218, 86)
        btnRegistrar.TabIndex = 79
        btnRegistrar.Text = "Trabajo de soldadura"
        btnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' btnAgricultura
        ' 
        btnAgricultura.Anchor = AnchorStyles.Top
        btnAgricultura.BackColor = Color.Blue
        btnAgricultura.Font = New Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAgricultura.ForeColor = Color.White
        btnAgricultura.Location = New Point(770, 179)
        btnAgricultura.Name = "btnAgricultura"
        btnAgricultura.Size = New Size(218, 86)
        btnAgricultura.TabIndex = 80
        btnAgricultura.Text = "Trabajo de agricultor"
        btnAgricultura.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.BackColor = Color.Blue
        Button1.Font = New Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(124, 321)
        Button1.Name = "Button1"
        Button1.Size = New Size(233, 86)
        Button1.TabIndex = 81
        Button1.Text = "Trabajo de excavación"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top
        Button2.BackColor = Color.Blue
        Button2.Font = New Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(461, 321)
        Button2.Name = "Button2"
        Button2.Size = New Size(218, 86)
        Button2.TabIndex = 82
        Button2.Text = "Trabajo en alturas"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top
        Button3.BackColor = Color.Blue
        Button3.Font = New Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(770, 321)
        Button3.Name = "Button3"
        Button3.Size = New Size(218, 86)
        Button3.TabIndex = 83
        Button3.Text = "Trabajo con electricidad"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' menuAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1051, 543)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btnAgricultura)
        Controls.Add(btnRegistrar)
        Controls.Add(btnCerrar)
        Controls.Add(btnVerEmpleados)
        Controls.Add(Label1)
        Name = "menuAdmin"
        Text = "menuAdmin"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnVerEmpleados As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnAgricultura As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
