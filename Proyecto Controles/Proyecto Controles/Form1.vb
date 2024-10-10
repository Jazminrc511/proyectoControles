Imports MySql.Data.MySqlClient
Public Class Form1
    Public connection As MySqlConnection
    Dim comandos As MySqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection
        connection.ConnectionString = "server = localhost; userId = root; password= ''; database = controles"
        Try
            connection.Open()
            MsgBox("Se ha establecido conexión a la base de datos con éxito")
            connection.Close()
        Catch ex As Exception
            MsgBox("Error al establecer conexión")
        End Try
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim resultado = MessageBox.Show("¿Desea salir del programa?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            Close
        Else

        End If
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Me.Hide()
        registro.Show()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If txtUsuario.Text = "" Or txtContra.Text = "" Then
            MessageBox.Show("Por favor, ingrese usuario y contraseña.")
            Exit Sub
        End If

        ' Intentar abrir la conexión
        Try
            connection.Open()

            ' Consulta SQL para verificar las credenciales
            Dim query As String = "SELECT COUNT(*) FROM empleado WHERE usuario = @usuario AND contrasenia = @contrasenia"
            comandos = New MySqlCommand(query, connection)

            ' Agregar parámetros a la consulta
            comandos.Parameters.AddWithValue("@usuario", txtUsuario.Text)
            comandos.Parameters.AddWithValue("@contrasenia", txtContra.Text)

            ' Ejecutar la consulta
            Dim result As Integer = Convert.ToInt32(comandos.ExecuteScalar())

            ' Verificar el resultado
            If result > 0 Then
                ' Si las credenciales son correctas, mostrar el menú de administrador
                MessageBox.Show("Inicio de sesión exitoso")
                Me.Hide()
                menuEmpleado.Show()
            ElseIf txtContra.Text = "123" And txtUsuario.Text = "GRUPO1" Then
                Me.Hide()
                menuAdmin.Show()
            Else
                ' Si las credenciales no coinciden
                MessageBox.Show("Usuario o contraseña incorrectos")
            End If

            ' Cerrar la conexión
            connection.Close()
            txtContra.Clear()
            txtUsuario.Clear()

        Catch ex As Exception
            ' Manejo de errores
            MessageBox.Show("Error durante la conexión: " & ex.Message)
        Finally
            ' Asegurarse de que la conexión se cierre
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
End Class
