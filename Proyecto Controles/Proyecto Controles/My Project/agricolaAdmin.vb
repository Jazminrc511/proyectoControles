Imports MySql.Data.MySqlClient

Public Class agricolaAdmin
    Dim connectionString As String = "server=localhost;userid=root;password=;database=controles"
    Private Sub agricolaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosDataGridView()
        CargarUsuariosComboBox()
    End Sub
    Private Sub CargarDatosDataGridView()
        Dim query As String = "SELECT * FROM agricola"

        Using connection As New MySqlConnection(connectionString)
            Using adapter As New MySqlDataAdapter(query, connection)
                Dim table As New DataTable()

                Try
                    connection.Open()
                    adapter.Fill(table)

                    ' Establecer la tabla como origen de datos del DataGridView
                    Me.DataGridView1.DataSource = table

                Catch ex As Exception
                    MsgBox("Error al cargar los datos en el DataGridView: " & ex.Message)

                End Try
            End Using
        End Using
    End Sub

    Private Sub CargarUsuariosComboBox()
        cbUsuario.Items.Clear()
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT usuario FROM empleado"
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            cbUsuario.Items.Add(reader.GetString("usuario"))
                        End While
                    End Using
                Catch ex As Exception
                    MsgBox("Error al cargar los usuarios: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        menuAdmin.Show()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim mensajeError As String = ValidarEntrada()

        If mensajeError = "" Then
            Dim query As String = "INSERT INTO agricola (Usuario, Fecha, Lentes, Mascarilla, Visera, Delantal, Botas,Guantes, EPP) VALUES (@usuario, @fecha, @lentes, @mascarilla, @visera, @delantal, @botas,@guantes, @epp)"

            Using connection As New MySqlConnection(connectionString)
                Using comando As New MySqlCommand(query, connection)
                    comando.Parameters.AddWithValue("@usuario", cbUsuario.Text)
                    comando.Parameters.AddWithValue("@fecha", fecha.Value)
                    comando.Parameters.AddWithValue("@lentes", cbLentes.Text)
                    comando.Parameters.AddWithValue("@mascarillas", cbMascarilla.Text)
                    comando.Parameters.AddWithValue("@viseras", cbVisera.Text)
                    comando.Parameters.AddWithValue("@delantal", cbDelantal.Text)
                    comando.Parameters.AddWithValue("@botas", cbCalzado.Text)
                    comando.Parameters.AddWithValue("@guantes", cbGuantes.Text)
                    comando.Parameters.AddWithValue("@epp", cbCumple.Text)

                    Try
                        connection.Open()
                        comando.ExecuteNonQuery()
                        MsgBox("Registro insertado con éxito")
                        CargarDatosDataGridView()
                        Limpiar()

                    Catch ex As Exception
                        MsgBox("Error al insertar el registro: " & ex.Message)

                    End Try
                End Using
            End Using
        Else
            MessageBox.Show(mensajeError)
        End If

        Limpiar()
    End Sub

    Private Sub Limpiar()
        cbUsuario.Text = ""
        cbCalzado.Text = ""
        cbDelantal.Text = ""
        cbCumple.Text = ""
        cbGuantes.Text = ""
        cbLentes.Text = ""
        cbMascarilla.Text = ""
        cbCumple.Text = ""
        cbVisera.Text = ""
    End Sub

    Private Function ValidarEntrada() As String
        Dim mensajeError As String = ""

        If cbUsuario.Text = "" Then
            mensajeError &= "Por favor seleccione el usuario" & vbCrLf
        End If

        If cbGuantes.Text = "" Then
            mensajeError &= "Por favor selecciones una opción para los guantes" & vbCrLf
        End If

        If cbCalzado.Text = "" Then
            mensajeError &= "Por favor selecciones una opción para el calzado" & vbCrLf
        End If

        If cbMascarilla.Text = "" Then
            mensajeError &= "Por favor selecciones una opción para la mascarilla" & vbCrLf
        End If

        If cbCumple.Text = "" Then
            mensajeError &= "Por favor selecciones si el empleado cumple con el EPP" & vbCrLf
        End If

        If cbLentes.Text = "" Then
            mensajeError &= "Por favor selecciones una opción para los lentes" & vbCrLf
        End If

        If cbDelantal.Text = "" Then
            mensajeError &= "Por favor selecciones una opción para el delantal" & vbCrLf
        End If

        If cbVisera.Text = "" Then
            mensajeError &= "Por favor selecciones una opción para la visera" & vbCrLf
        End If

        Return mensajeError
    End Function

End Class