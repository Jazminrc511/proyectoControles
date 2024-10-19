<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Soldador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Soldador))
        DataGridView1 = New DataGridView()
        cbUsuario = New ComboBox()
        Label2 = New Label()
        fecha = New DateTimePicker()
        Label1 = New Label()
        cbCumple = New ComboBox()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        cbLentes = New ComboBox()
        PictureBox2 = New PictureBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        cbGuantes = New ComboBox()
        PictureBox3 = New PictureBox()
        Label11 = New Label()
        cbCasco = New ComboBox()
        PictureBox4 = New PictureBox()
        cbMandil = New ComboBox()
        PictureBox5 = New PictureBox()
        cbCalzado = New ComboBox()
        btnRegresar = New Button()
        btnRegistrar = New Button()
        Label4 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(39, 702)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1449, 254)
        DataGridView1.TabIndex = 38
        ' 
        ' cbUsuario
        ' 
        cbUsuario.Anchor = AnchorStyles.Top
        cbUsuario.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbUsuario.FormattingEnabled = True
        cbUsuario.Location = New Point(184, 140)
        cbUsuario.Name = "cbUsuario"
        cbUsuario.Size = New Size(268, 39)
        cbUsuario.TabIndex = 40
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label2.Location = New Point(40, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 39)
        Label2.TabIndex = 39
        Label2.Text = "Usuario"
        ' 
        ' fecha
        ' 
        fecha.Anchor = AnchorStyles.Top
        fecha.CalendarFont = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fecha.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fecha.Location = New Point(597, 140)
        fecha.Name = "fecha"
        fecha.Size = New Size(446, 39)
        fecha.TabIndex = 56
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label1.Location = New Point(476, 131)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 39)
        Label1.TabIndex = 55
        Label1.Text = "Fecha"
        ' 
        ' cbCumple
        ' 
        cbCumple.Anchor = AnchorStyles.Top
        cbCumple.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbCumple.FormattingEnabled = True
        cbCumple.Items.AddRange(New Object() {"Completo ", "Incompleto"})
        cbCumple.Location = New Point(1001, 474)
        cbCumple.Name = "cbCumple"
        cbCumple.Size = New Size(255, 39)
        cbCumple.TabIndex = 58
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label7.Location = New Point(917, 471)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 39)
        Label7.TabIndex = 57
        Label7.Text = "EPP"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(50, 220)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(155, 120)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 59
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(50, 378)
        Label3.Name = "Label3"
        Label3.Size = New Size(192, 29)
        Label3.TabIndex = 60
        Label3.Text = "Gafas de soldador"
        ' 
        ' cbLentes
        ' 
        cbLentes.Anchor = AnchorStyles.Top
        cbLentes.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbLentes.FormattingEnabled = True
        cbLentes.Items.AddRange(New Object() {"Si", "No"})
        cbLentes.Location = New Point(235, 236)
        cbLentes.Name = "cbLentes"
        cbLentes.Size = New Size(90, 30)
        cbLentes.TabIndex = 61
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(403, 220)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(141, 134)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 62
        PictureBox2.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(451, 609)
        Label8.Name = "Label8"
        Label8.Size = New Size(220, 29)
        Label8.TabIndex = 66
        Label8.Text = "Calzado de seguridad"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(90, 620)
        Label9.Name = "Label9"
        Label9.Size = New Size(168, 29)
        Label9.TabIndex = 67
        Label9.Text = "Mandil de cuero"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top
        Label10.AutoSize = True
        Label10.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(393, 378)
        Label10.Name = "Label10"
        Label10.Size = New Size(315, 29)
        Label10.TabIndex = 68
        Label10.Text = "Guantes de cuero manga larga "
        ' 
        ' cbGuantes
        ' 
        cbGuantes.Anchor = AnchorStyles.Top
        cbGuantes.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbGuantes.FormattingEnabled = True
        cbGuantes.Items.AddRange(New Object() {"Si", "No"})
        cbGuantes.Location = New Point(571, 236)
        cbGuantes.Name = "cbGuantes"
        cbGuantes.Size = New Size(90, 30)
        cbGuantes.TabIndex = 69
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.Top
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(792, 226)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(126, 128)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 70
        PictureBox3.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(792, 378)
        Label11.Name = "Label11"
        Label11.Size = New Size(190, 29)
        Label11.TabIndex = 71
        Label11.Text = "Casco de soldador"
        ' 
        ' cbCasco
        ' 
        cbCasco.Anchor = AnchorStyles.Top
        cbCasco.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbCasco.FormattingEnabled = True
        cbCasco.Items.AddRange(New Object() {"Si", "No"})
        cbCasco.Location = New Point(960, 226)
        cbCasco.Name = "cbCasco"
        cbCasco.Size = New Size(90, 30)
        cbCasco.TabIndex = 72
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.Top
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(90, 468)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(115, 128)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 73
        PictureBox4.TabStop = False
        ' 
        ' cbMandil
        ' 
        cbMandil.Anchor = AnchorStyles.Top
        cbMandil.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbMandil.FormattingEnabled = True
        cbMandil.Items.AddRange(New Object() {"Si", "No"})
        cbMandil.Location = New Point(258, 468)
        cbMandil.Name = "cbMandil"
        cbMandil.Size = New Size(90, 30)
        cbMandil.TabIndex = 74
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.Top
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(415, 471)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(286, 125)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 75
        PictureBox5.TabStop = False
        ' 
        ' cbCalzado
        ' 
        cbCalzado.Anchor = AnchorStyles.Top
        cbCalzado.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbCalzado.FormattingEnabled = True
        cbCalzado.Items.AddRange(New Object() {"Si", "No"})
        cbCalzado.Location = New Point(737, 471)
        cbCalzado.Name = "cbCalzado"
        cbCalzado.Size = New Size(90, 30)
        cbCalzado.TabIndex = 76
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Anchor = AnchorStyles.Top
        btnRegresar.BackColor = Color.Blue
        btnRegresar.Font = New Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegresar.ForeColor = Color.White
        btnRegresar.Location = New Point(830, 609)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(194, 63)
        btnRegresar.TabIndex = 77
        btnRegresar.Text = "Regresar"
        btnRegresar.UseVisualStyleBackColor = False
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Anchor = AnchorStyles.Top
        btnRegistrar.BackColor = Color.Blue
        btnRegistrar.Font = New Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegistrar.ForeColor = Color.White
        btnRegistrar.Location = New Point(1062, 609)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(194, 63)
        btnRegistrar.TabIndex = 78
        btnRegistrar.Text = "Registrar"
        btnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(165, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(1027, 65)
        Label4.TabIndex = 97
        Label4.Text = "Equipo de protección Trabajos de soldadura"
        ' 
        ' Soldador
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1605, 1055)
        Controls.Add(Label4)
        Controls.Add(btnRegistrar)
        Controls.Add(btnRegresar)
        Controls.Add(cbCalzado)
        Controls.Add(PictureBox5)
        Controls.Add(cbMandil)
        Controls.Add(PictureBox4)
        Controls.Add(cbCasco)
        Controls.Add(Label11)
        Controls.Add(PictureBox3)
        Controls.Add(cbGuantes)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(PictureBox2)
        Controls.Add(cbLentes)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(cbCumple)
        Controls.Add(Label7)
        Controls.Add(fecha)
        Controls.Add(Label1)
        Controls.Add(cbUsuario)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Name = "Soldador"
        Text = "Soldador"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cbUsuario As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents cbCumple As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbLentes As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbGuantes As ComboBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbCasco As ComboBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents cbMandil As ComboBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents cbCalzado As ComboBox
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label4 As Label
End Class
