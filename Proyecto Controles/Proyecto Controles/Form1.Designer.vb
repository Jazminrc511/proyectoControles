<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtUsuario = New TextBox()
        txtContra = New TextBox()
        btnIngresar = New Button()
        btnRegistro = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(311, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(260, 54)
        Label1.TabIndex = 2
        Label1.Text = "¡Bienvenido!"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label2.Location = New Point(174, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 39)
        Label2.TabIndex = 3
        Label2.Text = "Usuario"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label3.Location = New Point(126, 223)
        Label3.Name = "Label3"
        Label3.Size = New Size(167, 39)
        Label3.TabIndex = 4
        Label3.Text = "Contraseña"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Anchor = AnchorStyles.Top
        txtUsuario.Font = New Font("Times New Roman", 16.2F)
        txtUsuario.Location = New Point(311, 171)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(353, 39)
        txtUsuario.TabIndex = 5
        ' 
        ' txtContra
        ' 
        txtContra.Anchor = AnchorStyles.Top
        txtContra.Font = New Font("Times New Roman", 16.2F)
        txtContra.Location = New Point(311, 226)
        txtContra.Name = "txtContra"
        txtContra.PasswordChar = "*"c
        txtContra.Size = New Size(353, 39)
        txtContra.TabIndex = 6
        ' 
        ' btnIngresar
        ' 
        btnIngresar.Anchor = AnchorStyles.Top
        btnIngresar.BackColor = Color.Lime
        btnIngresar.Font = New Font("MV Boli", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnIngresar.Location = New Point(174, 333)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(177, 69)
        btnIngresar.TabIndex = 7
        btnIngresar.Text = "Ingresar"
        btnIngresar.UseVisualStyleBackColor = False
        ' 
        ' btnRegistro
        ' 
        btnRegistro.Anchor = AnchorStyles.Top
        btnRegistro.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnRegistro.Font = New Font("MV Boli", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegistro.Location = New Point(448, 333)
        btnRegistro.Name = "btnRegistro"
        btnRegistro.Size = New Size(216, 69)
        btnRegistro.TabIndex = 8
        btnRegistro.Text = "Registrarse"
        btnRegistro.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top
        Button3.BackColor = Color.Red
        Button3.Font = New Font("MV Boli", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(335, 456)
        Button3.Name = "Button3"
        Button3.Size = New Size(125, 55)
        Button3.TabIndex = 9
        Button3.Text = "Salir"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(893, 729)
        Controls.Add(Button3)
        Controls.Add(btnRegistro)
        Controls.Add(btnIngresar)
        Controls.Add(txtContra)
        Controls.Add(txtUsuario)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Inicio"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContra As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnRegistro As Button
    Friend WithEvents Button3 As Button

End Class
