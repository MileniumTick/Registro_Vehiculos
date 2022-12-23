Public Class frmRegistro
    Private conexion As New ConexionLogin

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not validarEmail(TxtCorreo.Text) Then
            MessageBox.Show("Correo incorrecto por favor ingrese un correo permitido")
            Exit Sub
        End If

        If Not validarClave(TxtClave.Text) Then
            MessageBox.Show("Clave incorrecta por favor ingrese una clave on mas de 8 caracteres")
            Exit Sub
        End If

        If Not conexion.Guardar(TxtNombre.Text, TxtCorreo.Text, TxtClave.Text) Then
            MessageBox.Show("No se pudo guardar el usuario en la base de datos")
            Exit Sub
        End If

        MessageBox.Show("Usuario registrado con exito proceda a loguearse")
        Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub frmRegistro_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmLogin.Show()
    End Sub
End Class