Public Class menuAdmin

    Private Sub btnVerEmpleados_Click(sender As Object, e As EventArgs) Handles btnVerEmpleados.Click
        Me.Hide()
        verEmpleados.Show()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnControl_Click(sender As Object, e As EventArgs) Handles btnControl.Click
        Me.Hide()
        controlEmpleados.Show()
    End Sub
End Class