Imports MySql.Data.MySqlClient

Public Class controlEmpleados
    Dim connectionString As String = "server=localhost;userid=root;password=;database=controles"

    Private Sub CargarDatosDataGridView()
        Dim query As String = "SELECT * FROM control"

        Using connection As New MySqlConnection(connectionString)
            Using adapter As New MySqlDataAdapter(query, connection)
                Dim table As New DataTable()

                Try
                    connection.Open()
                    adapter.Fill(table)
                    Me.DataGridView1.DataSource = table

                Catch ex As Exception
                    MsgBox("Error al cargar los datos en el DataGridView: " & ex.Message)

                End Try
            End Using
        End Using
    End Sub

    Private Sub controlEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosDataGridView()
        CargarUsuariosComboBox()
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


    Private Function ValidarEntrada() As String
        Dim mensajeError As String = ""

        If txtNombre.Text = "" Then
            mensajeError &= "Por favor ingrese el Nombre" & vbCrLf
        End If

        If txtApellido.Text = "" Then
            mensajeError &= "Por favor ingrese el Apellido" & vbCrLf
        End If

        If cbUsuario.Text = "" Then
            mensajeError &= "Por favor ingrese el usuario" & vbCrLf
        End If

        If txtTrabajo.Text = "" Then
            mensajeError &= "Por favor ingrese el usuario" & vbCrLf
        End If

        If cbCumple.Text = "" Then
            mensajeError &= "Por favor ingrese si el empleado cumple o no" & vbCrLf
        End If

        Return mensajeError
    End Function
    Private Sub Limpiar()
        cbUsuario.Text = ""
        txtNombre.Clear()
        txtApellido.Clear()
        txtTrabajo.Clear()
        cbCumple.Text = ""
    End Sub


    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        menuAdmin.Show()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim selectedEmpleado As String = cbUsuario.SelectedItem?.ToString()

        If Not String.IsNullOrEmpty(selectedEmpleado) Then
            Using connection As New MySqlConnection(connectionString)
                Dim query As String = "UPDATE control SET Nombre = @nombre, Apellido = @apellido, Trabajo = @trabajo, Fecha = @fecha,Cumple = @cumple WHERE usuario = @usuario"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@nombre", txtNombre.Text)
                    command.Parameters.AddWithValue("@apellido", txtApellido.Text)
                    command.Parameters.AddWithValue("@trabajo", txtTrabajo.Text)
                    command.Parameters.AddWithValue("@fecha", fecha.Value)
                    command.Parameters.AddWithValue("@cumple", cbCumple.Text)
                    command.Parameters.AddWithValue("@usuario", selectedEmpleado)

                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Registro actualizado exitosamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CargarUsuariosComboBox()
                        CargarDatosDataGridView()
                        Limpiar()

                    Catch ex As Exception
                        MsgBox("Error al actualizar el registro: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Por favor, seleccione un usuario antes de intentar actualizar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnRegistrar_Click_1(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim mensajeError As String = ValidarEntrada()

        If mensajeError = "" Then
            Dim query As String = "INSERT INTO control (Usuario, Nombre, Apellido, Trabajo, Fecha, Cumple) VALUES (@usuario, @nombre, @apellido, @trabajo, @fecha, @cumple)"

            Using connection As New MySqlConnection(connectionString)
                Using comando As New MySqlCommand(query, connection)
                    comando.Parameters.AddWithValue("@usuario", cbUsuario.Text)
                    comando.Parameters.AddWithValue("@nombre", txtNombre.Text)
                    comando.Parameters.AddWithValue("@apellido", txtApellido.Text)
                    comando.Parameters.AddWithValue("@trabajo", txtTrabajo.Text)
                    comando.Parameters.AddWithValue("@fecha", fecha.Value)
                    comando.Parameters.AddWithValue("@cumple", cbCumple.Text)

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


    Private Sub btnObtenerDatos_Click(sender As Object, e As EventArgs) Handles btnObtenerDatos.Click
        Dim selectedEmpleado As String = cbUsuario.SelectedItem?.ToString()

        If Not String.IsNullOrEmpty(selectedEmpleado) Then
            Using connection As New MySqlConnection(connectionString)
                Dim query As String = "SELECT nombre, apellido, trabajo FROM empleado WHERE usuario = @usuario"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@usuario", selectedEmpleado)

                    Try
                        connection.Open()
                        Using reader As MySqlDataReader = command.ExecuteReader()
                            If reader.Read() Then
                                txtNombre.Text = reader.GetString("nombre")
                                txtApellido.Text = reader.GetString("apellido")
                                txtTrabajo.Text = reader.GetString("trabajo")
                            End If
                        End Using
                    Catch ex As Exception
                        MsgBox("Error al obtener los datos del empleado: " & ex.Message)
                    End Try
                End Using
            End Using
        End If
    End Sub

End Class