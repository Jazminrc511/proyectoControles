<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agricolaAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(agricolaAdmin))
        cbCalzado = New ComboBox()
        cbDelantal = New ComboBox()
        cbVisera = New ComboBox()
        Label11 = New Label()
        cbMascarilla = New ComboBox()
        Label10 = New Label()
        cbLentes = New ComboBox()
        Label3 = New Label()
        cbCumple = New ComboBox()
        Label7 = New Label()
        fecha = New DateTimePicker()
        Label1 = New Label()
        cbUsuario = New ComboBox()
        Label2 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Label9 = New Label()
        PictureBox5 = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox6 = New PictureBox()
        Label8 = New Label()
        cbGuantes = New ComboBox()
        btnRegistrar = New Button()
        btnRegresar = New Button()
        DataGridView1 = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbCalzado
        ' 
        cbCalzado.Anchor = AnchorStyles.Top
        cbCalzado.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbCalzado.FormattingEnabled = True
        cbCalzado.Items.AddRange(New Object() {"Si", "No"})
        cbCalzado.Location = New Point(542, 462)
        cbCalzado.Name = "cbCalzado"
        cbCalzado.Size = New Size(90, 30)
        cbCalzado.TabIndex = 95
        ' 
        ' cbDelantal
        ' 
        cbDelantal.Anchor = AnchorStyles.Top
        cbDelantal.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbDelantal.FormattingEnabled = True
        cbDelantal.Items.AddRange(New Object() {"Si", "No"})
        cbDelantal.Location = New Point(210, 462)
        cbDelantal.Name = "cbDelantal"
        cbDelantal.Size = New Size(90, 30)
        cbDelantal.TabIndex = 93
        ' 
        ' cbVisera
        ' 
        cbVisera.Anchor = AnchorStyles.Top
        cbVisera.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbVisera.FormattingEnabled = True
        cbVisera.Items.AddRange(New Object() {"Si", "No"})
        cbVisera.Location = New Point(974, 220)
        cbVisera.Name = "cbVisera"
        cbVisera.Size = New Size(90, 30)
        cbVisera.TabIndex = 91
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(846, 372)
        Label11.Name = "Label11"
        Label11.Size = New Size(75, 29)
        Label11.TabIndex = 90
        Label11.Text = "Visera"
        ' 
        ' cbMascarilla
        ' 
        cbMascarilla.Anchor = AnchorStyles.Top
        cbMascarilla.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbMascarilla.FormattingEnabled = True
        cbMascarilla.Items.AddRange(New Object() {"Si", "No"})
        cbMascarilla.Location = New Point(585, 230)
        cbMascarilla.Name = "cbMascarilla"
        cbMascarilla.Size = New Size(90, 30)
        cbMascarilla.TabIndex = 88
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top
        Label10.AutoSize = True
        Label10.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(457, 372)
        Label10.Name = "Label10"
        Label10.Size = New Size(110, 29)
        Label10.TabIndex = 87
        Label10.Text = "Mascarilla"
        ' 
        ' cbLentes
        ' 
        cbLentes.Anchor = AnchorStyles.Top
        cbLentes.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbLentes.FormattingEnabled = True
        cbLentes.Items.AddRange(New Object() {"Si", "No"})
        cbLentes.Location = New Point(249, 230)
        cbLentes.Name = "cbLentes"
        cbLentes.Size = New Size(90, 30)
        cbLentes.TabIndex = 85
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(64, 372)
        Label3.Name = "Label3"
        Label3.Size = New Size(215, 29)
        Label3.TabIndex = 84
        Label3.Text = "Lentes de protección"
        ' 
        ' cbCumple
        ' 
        cbCumple.Anchor = AnchorStyles.Top
        cbCumple.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbCumple.FormattingEnabled = True
        cbCumple.Items.AddRange(New Object() {"Completo ", "Incompleto"})
        cbCumple.Location = New Point(1154, 462)
        cbCumple.Name = "cbCumple"
        cbCumple.Size = New Size(255, 39)
        cbCumple.TabIndex = 82
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label7.Location = New Point(1070, 459)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 39)
        Label7.TabIndex = 81
        Label7.Text = "EPP"
        ' 
        ' fecha
        ' 
        fecha.Anchor = AnchorStyles.Top
        fecha.CalendarFont = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fecha.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fecha.Location = New Point(611, 134)
        fecha.Name = "fecha"
        fecha.Size = New Size(446, 39)
        fecha.TabIndex = 80
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label1.Location = New Point(490, 125)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 39)
        Label1.TabIndex = 79
        Label1.Text = "Fecha"
        ' 
        ' cbUsuario
        ' 
        cbUsuario.Anchor = AnchorStyles.Top
        cbUsuario.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbUsuario.FormattingEnabled = True
        cbUsuario.Location = New Point(198, 134)
        cbUsuario.Name = "cbUsuario"
        cbUsuario.Size = New Size(268, 39)
        cbUsuario.TabIndex = 78
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold)
        Label2.Location = New Point(54, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 39)
        Label2.TabIndex = 77
        Label2.Text = "Usuario"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(150, 32)
        Label4.Name = "Label4"
        Label4.Size = New Size(897, 65)
        Label4.TabIndex = 96
        Label4.Text = "Equipo de protección Trabajo Agrícola"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(79, 205)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(154, 143)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 97
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(407, 205)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(160, 143)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 98
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.Top
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(792, 205)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(161, 143)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 99
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.Top
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(54, 439)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(97, 151)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 100
        PictureBox4.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(62, 625)
        Label9.Name = "Label9"
        Label9.Size = New Size(89, 29)
        Label9.TabIndex = 101
        Label9.Text = "Delantal"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.Top
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(381, 439)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(117, 135)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 102
        PictureBox5.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(1057, 507)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 29)
        Label5.TabIndex = 103
        Label5.Text = "Delantal"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(338, 613)
        Label6.Name = "Label6"
        Label6.Size = New Size(311, 29)
        Label6.TabIndex = 104
        Label6.Text = "Botas impermeables de caucho"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Anchor = AnchorStyles.Top
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(731, 445)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(137, 129)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 105
        PictureBox6.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(731, 613)
        Label8.Name = "Label8"
        Label8.Size = New Size(186, 29)
        Label8.TabIndex = 107
        Label8.Text = "Guantes de nitrilo"
        ' 
        ' cbGuantes
        ' 
        cbGuantes.Anchor = AnchorStyles.Top
        cbGuantes.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbGuantes.FormattingEnabled = True
        cbGuantes.Items.AddRange(New Object() {"Si", "No"})
        cbGuantes.Location = New Point(893, 459)
        cbGuantes.Name = "cbGuantes"
        cbGuantes.Size = New Size(90, 30)
        cbGuantes.TabIndex = 106
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Anchor = AnchorStyles.Top
        btnRegistrar.BackColor = Color.Blue
        btnRegistrar.Font = New Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegistrar.ForeColor = Color.White
        btnRegistrar.Location = New Point(1195, 590)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(194, 63)
        btnRegistrar.TabIndex = 110
        btnRegistrar.Text = "Registrar"
        btnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Anchor = AnchorStyles.Top
        btnRegresar.BackColor = Color.Blue
        btnRegresar.Font = New Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegresar.ForeColor = Color.White
        btnRegresar.Location = New Point(963, 590)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(194, 63)
        btnRegresar.TabIndex = 109
        btnRegresar.Text = "Regresar"
        btnRegresar.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(54, 684)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1449, 254)
        DataGridView1.TabIndex = 108
        ' 
        ' agricolaAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1924, 1055)
        Controls.Add(btnRegistrar)
        Controls.Add(btnRegresar)
        Controls.Add(DataGridView1)
        Controls.Add(Label8)
        Controls.Add(cbGuantes)
        Controls.Add(PictureBox6)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(PictureBox5)
        Controls.Add(Label9)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(cbCalzado)
        Controls.Add(cbDelantal)
        Controls.Add(cbVisera)
        Controls.Add(Label11)
        Controls.Add(cbMascarilla)
        Controls.Add(Label10)
        Controls.Add(cbLentes)
        Controls.Add(Label3)
        Controls.Add(cbCumple)
        Controls.Add(Label7)
        Controls.Add(fecha)
        Controls.Add(Label1)
        Controls.Add(cbUsuario)
        Controls.Add(Label2)
        Name = "agricolaAdmin"
        Text = "agricolaAdmin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbCalzado As ComboBox
    Friend WithEvents cbDelantal As ComboBox
    Friend WithEvents cbVisera As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbMascarilla As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbLentes As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbCumple As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents cbUsuario As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbGuantes As ComboBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
