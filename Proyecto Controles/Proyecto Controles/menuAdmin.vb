Public Class menuAdmin

    Private Sub btnVerEmpleados_Click(sender As Object, e As EventArgs) Handles btnVerEmpleados.Click
        Me.Hide()
        verEmpleados.Show()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnControl_Click(sender As Object, e As EventArgs)
        Me.Hide()
        controlEmpleados.Show
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Me.Hide()
        Soldador.Show()

    End Sub

    Private Sub btnAgricultura_Click(sender As Object, e As EventArgs) Handles btnAgricultura.Click
        Me.Hide()
        agricolaAdmin.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        excavacionAdmin.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        alturaAdmin.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        electricidadAdmin.Show()

    End Sub
End Class