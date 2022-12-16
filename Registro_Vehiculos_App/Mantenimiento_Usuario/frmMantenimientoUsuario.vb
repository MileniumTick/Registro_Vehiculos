Public Class frmMantenimientoUsuario
    Dim conexion As New Conexion_Usuario

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Registro_VehiculoDataSet.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.Registro_VehiculoDataSet.Usuario)
        conexion.conectar()
        MostrarDatos()
    End Sub

    Public Sub MostrarDatos()
        conexion.consultar("Select * from Usuario", "Usuario")
        dgvDatos.DataSource = conexion.ds.Tables("Usuario")
    End Sub

    Private Sub dgvDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellContentClick
        Dim dgv As DataGridViewRow = dgvDatos.Rows(e.RowIndex)
        txtCorreo.Text = dgv.Cells(0).Value.ToString()
        txtClave.Text = dgv.Cells(1).Value.ToString()
        txtNombre.Text = dgv.Cells(2).Value.ToString()
        cmbTipo_usuario.Text = dgv.Cells(3).Value.ToString()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        conexion.consultarNombre(txtNombre1.Text, dgvDatos)
    End Sub

    Private Sub txtNombre1_TextChanged(sender As Object, e As EventArgs)
        txtNombre1.Text = txtNombre.Text
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim actualizar As String = " Tipo_Usuario = '" + cmbTipo_usuario.Text + "'"
        Dim condicion As String = " Correo = '" + txtCorreo.Text + "'"
        If (conexion.Actualizar("Usuario", actualizar, condicion)) Then
            MessageBox.Show("Datos actualizados")
            MostrarDatos()
        Else
            MessageBox.Show("Error al modificar los datos")
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim Eliminar As String = " Tipo_Usuario = '" + cmbTipo_usuario.Text + "'"
        Dim condicion As String = " Correo = '" + txtCorreo.Text + "'"
        If (conexion.Eliminar("Usuario", $" Nombre = '{ txtNombre.Text }'")) Then
            MessageBox.Show("Datos eliminados correctamente")
            MostrarDatos()
        Else
            MessageBox.Show("Error al eliminar")
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        conexion.limpiarCampos(Me)
    End Sub

    Private Sub cmbTipo_usuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo_usuario.SelectedIndexChanged
        Select Case cmbTipo_usuario.SelectedIndex
            Case 0
                cmbTipo_usuario.Text = "Admin"
            Case 2
                cmbTipo_usuario.Text = "Clien"
        End Select
    End Sub
End Class