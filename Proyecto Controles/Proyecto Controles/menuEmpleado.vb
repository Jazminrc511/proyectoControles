Public Class menuEmpleado
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Hide
        Form1.Show
    End Sub

    Private Sub VerAcuerdo_Click(sender As Object, e As EventArgs) Handles VerAcuerdo.Click

        Try
            Dim url As String = "https://www.igssgt.org/wp-content/uploads/sites/5/2024/05/Normativas-legales-en-salud-y-seguridad-ocupacional-en-Guatemala-IGSS.pdf"
            Dim psi As New ProcessStartInfo()
            psi.UseShellExecute = True
            psi.FileName = url
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir el enlace.")
        End Try
    End Sub

    Private Sub usoYLimpieza_Click(sender As Object, e As EventArgs) Handles usoYLimpieza.Click
        Try
            Dim url As String = "https://www.igssgt.org/wp-content/uploads/2020/08/Guia-uso-y-limpieza-de-equipo-de-proteccion-personal-epp-IGSS-2020.pdf"
            Dim psi As New ProcessStartInfo()
            psi.UseShellExecute = True
            psi.FileName = url
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir el enlace.")
        End Try
    End Sub


    Private Sub btnlAlturas_Click(sender As Object, e As EventArgs) Handles btnlAlturas.Click
        Me.Hide()
        EPPAlturas.Show()

    End Sub

    Private Sub btnElectricidad_Click(sender As Object, e As EventArgs) Handles btnElectricidad.Click
        Me.Hide()
        electricidad.Show()

    End Sub

    Private Sub btnSoldadura_Click(sender As Object, e As EventArgs) Handles btnSoldadura.Click
        Me.Hide()
        Soldadura.Show()

    End Sub

    Private Sub btnExcava_Click(sender As Object, e As EventArgs) Handles btnExcava.Click
        Me.Hide()
        excavacion.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        agricola.Show()
    End Sub
End Class