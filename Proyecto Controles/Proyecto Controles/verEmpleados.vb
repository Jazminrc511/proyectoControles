Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class verEmpleados
    Dim connectionString As String = "server=localhost;userid=root;password=;database=controles"
    Private Sub verEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosDataGridView()
        CargarUsuariosComboBox()
    End Sub
    Private Sub CargarDatosDataGridView()
        Dim query As String = "SELECT * FROM empleado"

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

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()

    End Sub

    Private Sub Limpiar()
        cbUsuario.Text = ""
        txtNombre.Clear()
        txtApellido.Clear()
        txtContra.Clear()
        cbTrabajo.Text = ""
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

    Private Sub btbCargar_Click(sender As Object, e As EventArgs) Handles btbCargar.Click
        Dim selectedEmpleado As String = cbUsuario.SelectedItem?.ToString()

        If Not String.IsNullOrEmpty(selectedEmpleado) Then
            Using connection As New MySqlConnection(connectionString)
                Dim query As String = "SELECT nombre, apellido, contrasenia, trabajo FROM empleado WHERE usuario = @usuario"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@usuario", selectedEmpleado)

                    Try
                        connection.Open()
                        Using reader As MySqlDataReader = command.ExecuteReader()
                            If reader.Read() Then
                                txtNombre.Text = reader.GetString("nombre")
                                txtApellido.Text = reader.GetString("apellido")
                                txtContra.Text = reader.GetString("contrasenia")
                                cbTrabajo.Text = reader.GetString("trabajo")
                            End If
                        End Using
                    Catch ex As Exception
                        MsgBox("Error al obtener los datos del empleado: " & ex.Message)
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim selectedEmpleado As String = cbUsuario.SelectedItem?.ToString()

        If Not String.IsNullOrEmpty(selectedEmpleado) Then
            Using connection As New MySqlConnection(connectionString)
                Dim query As String = "UPDATE empleado SET nombre = @nombre, apellido = @apellido, contrasenia = @contrasenia, trabajo = @trabajo WHERE usuario = @usuario"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@nombre", txtNombre.Text)
                    command.Parameters.AddWithValue("@apellido", txtApellido.Text)
                    command.Parameters.AddWithValue("@contrasenia", txtContra.Text)
                    command.Parameters.AddWithValue("@trabajo", cbTrabajo.Text)
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim selectedEmpleado As String = cbUsuario.SelectedItem?.ToString()

        If Not String.IsNullOrEmpty(selectedEmpleado) Then
            Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Using connection As New MySqlConnection(connectionString)
                    Dim query As String = "DELETE FROM empleado WHERE usuario = @usuario"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@usuario", selectedEmpleado)

                        Try
                            connection.Open()
                            command.ExecuteNonQuery()
                            MessageBox.Show("Registro eliminado exitosamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            CargarUsuariosComboBox()
                            CargarDatosDataGridView()
                            Limpiar()
                        Catch ex As Exception
                            MsgBox("Error al eliminar el registro: " & ex.Message)
                        End Try
                    End Using
                End Using
            End If
        Else
            MessageBox.Show("Por favor, seleccione un usuario antes de intentar eliminar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        menuAdmin.Show()
    End Sub
End Class