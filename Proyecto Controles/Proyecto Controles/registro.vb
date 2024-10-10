Imports MySql.Data.MySqlClient

Public Class registro

    Private Function ValidarEntrada() As String
        Dim mensajeError As String = ""

        If txtNombre.Text = "" Then
            mensajeError &= "Por favor ingrese su Nit" & vbCrLf
        End If

        If txtApellido.Text = "" Then
            mensajeError &= "Por favor ingrese su nombre" & vbCrLf
        End If

        If txtUsuario.Text = "" Then
            mensajeError &= "Por favor ingrese su Dirección" & vbCrLf
        End If

        If txtContra.Text = "" Then
            mensajeError &= "Por favor ingrese su teléfono" & vbCrLf
        End If

        If cbTrabajo.SelectedItem Is Nothing Then
            mensajeError &= "Por favor seleccione el trabajo que realiza" & vbCrLf
        End If


        Return mensajeError
    End Function

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Dim mensajeError As String = ValidarEntrada()

        If mensajeError = "" Then
            Dim query As String = "INSERT INTO empleado (nombre, apellido, usuario, contrasenia, trabajo) VALUES (@nombre, @apellido, @usuario, @contrasenia, @trabajo)"

            Using connection As New MySqlConnection(Form1.connection.ConnectionString)
                Using comando As New MySqlCommand(query, connection)
                    ' Parámetros de la consulta preparada
                    comando.Parameters.AddWithValue("@nombre", txtNombre.Text)
                    comando.Parameters.AddWithValue("@apellido", txtApellido.Text)
                    comando.Parameters.AddWithValue("@usuario", txtUsuario.Text)
                    comando.Parameters.AddWithValue("@contrasenia", txtContra.Text)
                    comando.Parameters.AddWithValue("@trabajo", cbTrabajo.Text)

                    Try
                        connection.Open()
                        comando.ExecuteNonQuery()
                        MsgBox("Registro insertado con éxito")
                        LimpiarCamposEntrada()

                    Catch ex As Exception
                        MsgBox("Error al insertar el registro: " & ex.Message)

                    End Try
                End Using
            End Using
        Else
            MessageBox.Show(mensajeError)
        End If


    End Sub
    Private Sub LimpiarCamposEntrada()
        txtNombre.Clear()
        txtApellido.Clear()
        txtUsuario.Clear()
        txtContra.Clear()
        cbTrabajo.SelectedItem = ""
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class