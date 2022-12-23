Imports Registro_Vehiculos_App.Registro_VehiculoDataSetTableAdapters

Public Class frmLogin
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            UsuarioTableAdapter.Fill(Registro_VehiculoDataSet.Usuario)

            Dim Usuario As Registro_VehiculoDataSet.UsuarioRow
            Dim Usuarios As EnumerableRowCollection(Of Registro_VehiculoDataSet.UsuarioRow)

            Dim clave As String = Encrypt(txtClave.Text, txtClave.Text.Length)

            Usuarios = From u In Registro_VehiculoDataSet.Usuario
                       Where (u.Correo.ToLower = txtCorreoElec.Text.ToLower Or u.Nombre.ToLower = txtCorreoElec.Text.ToLower) And u.Clave = clave

            If Usuarios.Count = 0 Then
                MessageBox.Show("No existe ningun usuario en la base de datos digite el usuario o contraseña de forma correcta")
                Return
            End If

            Usuario = Usuarios.First

            If Not Usuario.IsNull(0) Then
                MessageBox.Show($"Se realizo el login con el usuario: {Usuario.Nombre}", "Login")
                frmMenu.Execute(Usuario)
                Hide()
                txtClave.Text = ""
                txtCorreoElec.Text = ""
            Else
                MessageBox.Show("Datos incorrectos, favor verifique")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub LblRegistrar_Click(sender As Object, e As EventArgs) Handles LblRegistrar.Click
        Hide()
        frmRegistro.ShowDialog()
    End Sub
End Class