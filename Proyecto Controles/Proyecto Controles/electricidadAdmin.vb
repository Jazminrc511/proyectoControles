Imports MySql.Data.MySqlClient

Public Class electricidadAdmin
    Dim connectionString As String = "server=localhost;userid=root;password=;database=controles"
    Private Sub electricidadAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosDataGridView()
        CargarUsuariosComboBox()
    End Sub
    Private Sub CargarDatosDataGridView()
        Dim query As String = "SELECT * FROM electricidad"

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
            Dim query As String = "INSERT INTO electricidad (Usuario, Fecha, Traje, Casco, Guantes, Pertigas, Detectores, Calzado, Pantalla, EPP) VALUES (@usuario, @fecha, @traje, @casco, @guantes, @pertigas, @detectores, @calzado, @pantalla, @epp)"

            Using connection As New MySqlConnection(connectionString)
                Using comando As New MySqlCommand(query, connection)
                    comando.Parameters.AddWithValue("@usuario", cbUsuario.Text)
                    comando.Parameters.AddWithValue("@fecha", fecha.Value)
                    comando.Parameters.AddWithValue("@traje", cbRopa.Text)
                    comando.Parameters.AddWithValue("@casco", cbCasco.Text)
                    comando.Parameters.AddWithValue("@guantes", cbGuantes.Text)
                    comando.Parameters.AddWithValue("@pertigas", cbPertigas.Text)
                    comando.Parameters.AddWithValue("@detectores", cbDetectores.Text)
                    comando.Parameters.AddWithValue("@calzado", cbCalzado.Text)
                    comando.Parameters.AddWithValue("@pantalla", cbPantalla.Text)
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
        cbCasco.Text = ""
        cbCumple.Text = ""
        cbGuantes.Text = ""
        cbDetectores.Text = ""
        cbPantalla.Text = ""
        cbCumple.Text = ""
        cbRopa.Text = ""
        cbPertigas.Text = ""
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

        If cbCasco.Text = "" Then
            mensajeError &= "Por favor selecciones una opción para el casco" & vbCrLf
        End If

        If cbCumple.Text = "" Then
            mensajeError &= "Por favor selecciones si el empleado cumple con el EPP" & vbCrLf
        End If

        If cbRopa.Text = "" Then
            mensajeError &= "Por favor selecciones una opción para la ropa" & vbCrLf
        End If

        If cbPantalla.Text = "" Then
            mensajeError &= "Por favor selecciones una opción para la pantalla" & vbCrLf
        End If
        If cbPertigas.Text = "" Then
            mensajeError &= "Por favor selecciones una opción para la pertigas" & vbCrLf
        End If

        If cbDetectores.Text = "" Then
            mensajeError &= "Por favor selecciones una opción para los detectores" & vbCrLf
        End If

        Return mensajeError
    End Function
End Class