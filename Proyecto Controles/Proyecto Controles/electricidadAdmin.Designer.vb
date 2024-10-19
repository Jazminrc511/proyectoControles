<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class electricidadAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(electricidadAdmin))
        Label4 = New Label()
        btnRegistrar = New Button()
        btnRegresar = New Button()
        cbCalzado = New ComboBox()
        cbDetectores = New ComboBox()
        cbGuantes = New ComboBox()
        Label11 = New Label()
        cbCasco = New ComboBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        cbRopa = New ComboBox()
        Label3 = New Label()
        cbCumple = New ComboBox()
        Label7 = New Label()
        fecha = New DateTimePicker()
        Label1 = New Label()
        cbUsuario = New ComboBox()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox6 = New PictureBox()
        cbPertigas = New ComboBox()
        Label5 = New Label()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox7 = New PictureBox()
        cbPantalla = New ComboBox()
        Label6 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(208, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(1074, 65)
        Label4.TabIndex = 122
        Label4.Text = "Equipo de protección Trabajo con electricidad"
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Anchor = AnchorStyles.Top
        btnRegistrar.BackColor = Color.Blue
        btnRegistrar.Font = New Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegistrar.ForeColor = Color.White
        btnRegistrar.Location = New Point(1491, 612)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(194, 63)
        btnRegistrar.TabIndex = 121
        btnRegistrar.Text = "Registrar"
        btnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Anchor = AnchorStyles.Top
        btnRegresar.BackColor = Color.Blue
        btnRegresar.Font = New Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegresar.ForeColor = Color.White
        btnRegresar.Location = New Point(1259, 612)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(194, 63)
        btnRegresar.TabIndex = 120
        btnRegresar.Text = "Regresar"
        btnRegresar.UseVisualStyleBackColor = False
        ' 
        ' cbCalzado
        ' 
        cbCalzado.Anchor = AnchorStyles.Top
        cbCalzado.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbCalzado.FormattingEnabled = True
        cbCalzado.Items.AddRange(New Object() {"Si", "No"})
        cbCalzado.Location = New Point(780, 484)
        cbCalzado.Name = "cbCalzado"
        cbCalzado.Size = New Size(90, 30)
        cbCalzado.TabIndex = 119
        ' 
        ' cbDetectores
        ' 
        cbDetectores.Anchor = AnchorStyles.Top
        cbDetectores.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbDetectores.FormattingEnabled = True
        cbDetectores.Items.AddRange(New Object() {"Si", "No"})
        cbDetectores.Location = New Point(301, 481)
        cbDetectores.Name = "cbDetectores"
        cbDetectores.Size = New Size(90, 30)
        cbDetectores.TabIndex = 117
        ' 
        ' cbGuantes
        ' 
        cbGuantes.Anchor = AnchorStyles.Top
        cbGuantes.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbGuantes.FormattingEnabled = True
        cbGuantes.Items.AddRange(New Object() {"Si", "No"})
        cbGuantes.Location = New Point(1003, 239)
        cbGuantes.Name = "cbGuantes"
        cbGuantes.Size = New Size(90, 30)
        cbGuantes.TabIndex = 115
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(809, 391)
        Label11.Name = "Label11"
        Label11.Size = New Size(208, 29)
        Label11.TabIndex = 114
        Label11.Text = "Guantes dieléctricos"
        ' 
        ' cbCasco
        ' 
        cbCasco.Anchor = AnchorStyles.Top
        cbCasco.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbCasco.FormattingEnabled = True
        cbCasco.Items.AddRange(New Object() {"Si", "No"})
        cbCasco.Location = New Point(614, 249)
        cbCasco.Name = "cbCasco"
        cbCasco.Size = New Size(90, 30)
        cbCasco.TabIndex = 112
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top
        Label10.AutoSize = True
        Label10.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(436, 391)
        Label10.Name = "Label10"
        Label10.Size = New Size(321, 29)
        Label10.TabIndex = 111
        Label10.Text = "Cascos de seguridad dieléctrico"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(63, 622)
        Label9.Name = "Label9"
        Label9.Size = New Size(319, 29)
        Label9.TabIndex = 110
        Label9.Text = "Detectores de tensión eléctrica"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(494, 622)
        Label8.Name = "Label8"
        Label8.Size = New Size(220, 29)
        Label8.TabIndex = 109
        Label8.Text = "Calzado de seguridad"
        ' 
        ' cbRopa
        ' 
        cbRopa.Anchor = AnchorStyles.Top
        cbRopa.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbRopa.FormattingEnabled = True
        cbRopa.Items.AddRange(New Object() {"Si", "No"})
        cbRopa.Location = New Point(278, 249)
        cbRopa.Name = "cbRopa"
        cbRopa.Size = New Size(90, 30)
        cbRopa.TabIndex = 107
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(93, 391)
        Label3.Name = "Label3"
        Label3.Size = New Size(265, 29)
        Label3.TabIndex = 106
        Label3.Text = "Ropa ignifuga antiestática"
        ' 
        ' cbCumple
        ' 
        cbCumple.Anchor = AnchorStyles.Top
        cbCumple.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbCumple.FormattingEnabled = True
        cbCumple.Items.AddRange(New Object() {"Completo ", "Incompleto"})
        cbCumple.Location = New Point(1430, 477)
        cbCumple.Name = "cbCumple"
        cbCumple.Size = New Size(255, 39)
        cbCumple.TabIndex = 104
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label7.Location = New Point(1346, 474)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 39)
        Label7.TabIndex = 103
        Label7.Text = "EPP"
        ' 
        ' fecha
        ' 
        fecha.Anchor = AnchorStyles.Top
        fecha.CalendarFont = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fecha.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fecha.Location = New Point(640, 153)
        fecha.Name = "fecha"
        fecha.Size = New Size(446, 39)
        fecha.TabIndex = 102
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label1.Location = New Point(519, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 39)
        Label1.TabIndex = 101
        Label1.Text = "Fecha"
        ' 
        ' cbUsuario
        ' 
        cbUsuario.Anchor = AnchorStyles.Top
        cbUsuario.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbUsuario.FormattingEnabled = True
        cbUsuario.Location = New Point(227, 153)
        cbUsuario.Name = "cbUsuario"
        cbUsuario.Size = New Size(268, 39)
        cbUsuario.TabIndex = 100
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label2.Location = New Point(83, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 39)
        Label2.TabIndex = 99
        Label2.Text = "Usuario"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(82, 715)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1449, 254)
        DataGridView1.TabIndex = 98
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(110, 233)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(145, 155)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 123
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(436, 224)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(163, 143)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 124
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.Top
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(809, 224)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(148, 143)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 125
        PictureBox3.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Anchor = AnchorStyles.Top
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(1129, 224)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(153, 134)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 126
        PictureBox6.TabStop = False
        ' 
        ' cbPertigas
        ' 
        cbPertigas.Anchor = AnchorStyles.Top
        cbPertigas.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbPertigas.FormattingEnabled = True
        cbPertigas.Items.AddRange(New Object() {"Si", "No"})
        cbPertigas.Location = New Point(1318, 239)
        cbPertigas.Name = "cbPertigas"
        cbPertigas.Size = New Size(90, 30)
        cbPertigas.TabIndex = 128
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(1124, 391)
        Label5.Name = "Label5"
        Label5.Size = New Size(214, 29)
        Label5.TabIndex = 127
        Label5.Text = "Pértigas Dieléctricas"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.Top
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(43, 463)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(225, 137)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 129
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.Top
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(458, 484)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(286, 125)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 118
        PictureBox5.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.Top
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(927, 463)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(144, 150)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 130
        PictureBox7.TabStop = False
        ' 
        ' cbPantalla
        ' 
        cbPantalla.Anchor = AnchorStyles.Top
        cbPantalla.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbPantalla.FormattingEnabled = True
        cbPantalla.Items.AddRange(New Object() {"Si", "No"})
        cbPantalla.Location = New Point(1099, 481)
        cbPantalla.Name = "cbPantalla"
        cbPantalla.Size = New Size(90, 30)
        cbPantalla.TabIndex = 132
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(927, 630)
        Label6.Name = "Label6"
        Label6.Size = New Size(271, 29)
        Label6.TabIndex = 131
        Label6.Text = "Pantallas faciales aislantes"
        ' 
        ' electricidadAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1924, 1055)
        Controls.Add(cbPantalla)
        Controls.Add(Label6)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox4)
        Controls.Add(cbPertigas)
        Controls.Add(Label5)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(btnRegistrar)
        Controls.Add(btnRegresar)
        Controls.Add(cbCalzado)
        Controls.Add(PictureBox5)
        Controls.Add(cbDetectores)
        Controls.Add(cbGuantes)
        Controls.Add(Label11)
        Controls.Add(cbCasco)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(cbRopa)
        Controls.Add(Label3)
        Controls.Add(cbCumple)
        Controls.Add(Label7)
        Controls.Add(fecha)
        Controls.Add(Label1)
        Controls.Add(cbUsuario)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Name = "electricidadAdmin"
        Text = "Trabajo en electricidad"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents cbCalzado As ComboBox
    Friend WithEvents cbDetectores As ComboBox
    Friend WithEvents cbGuantes As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbCasco As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbRopa As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbCumple As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents cbUsuario As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents cbPertigas As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents cbPantalla As ComboBox
    Friend WithEvents Label6 As Label
End Class
