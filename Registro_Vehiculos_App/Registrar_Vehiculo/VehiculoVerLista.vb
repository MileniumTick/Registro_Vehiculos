Public Class VehiculoVerLista
    Private ReadOnly _Conexion As New VehiculoConexion
    Private ReadOnly _VehiculoRegistro As New Vehiculo

    Private Sub VehiculoLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Registro_VehiculoDataSet.Vehiculo' Puede moverla o quitarla según sea necesario.
        Me.VehiculoTableAdapter.Fill(Me.Registro_VehiculoDataSet.Vehiculo)

    End Sub

    Private Sub DgvRegistroVehiculo_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRegistroVehiculo.CellDoubleClick
        Try
            EditarRegistro(e.RowIndex)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TxtNumeroIdentificacion_KeyPress(sender As Object, e As KeyEventArgs) Handles TxtNumeroIdentificacion.KeyUp
        If e.KeyValue = "13" Then
            _Conexion.BuscarVehiculoLista(TxtNumeroIdentificacion.Text, TxtNumeroPlaca.Text, DgvRegistroVehiculo)
        End If
    End Sub

    Private Sub TxtNumeroPlaca_KeyPress(sender As Object, e As KeyEventArgs) Handles TxtNumeroPlaca.KeyUp
        If e.KeyValue = "13" Then
            _Conexion.BuscarVehiculoLista(TxtNumeroIdentificacion.Text, TxtNumeroPlaca.Text, DgvRegistroVehiculo)
        End If
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Try
            LlenarVehiculoBusqueda(DgvRegistroVehiculo.SelectedCells(0).RowIndex)

            Dim resultadoMensaje = MessageBox.Show($"El regsitro con cedula {_VehiculoRegistro.Identificacion} y numero de placa {_VehiculoRegistro.Numero_Placa}", "Desea borrar el registro?", MessageBoxButtons.OKCancel)

            If resultadoMensaje = 1 Then
                _Conexion.Borrar_Vehiculo(_VehiculoRegistro)

                _Conexion.BuscarVehiculoLista(TxtNumeroIdentificacion.Text, TxtNumeroPlaca.Text, DgvRegistroVehiculo)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LlenarVehiculoBusqueda(Indice As Integer)
        Try
            _VehiculoRegistro.Tipo_Identificacion = DgvRegistroVehiculo.Rows(Indice).Cells(0).Value
            _VehiculoRegistro.Identificacion = DgvRegistroVehiculo.Rows(Indice).Cells(1).Value
            _VehiculoRegistro.Clase = DgvRegistroVehiculo.Rows(Indice).Cells(2).Value
            _VehiculoRegistro.Numero_Placa = DgvRegistroVehiculo.Rows(Indice).Cells(3).Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            EditarRegistro(DgvRegistroVehiculo.SelectedCells(0).RowIndex)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EditarRegistro(Indice As Integer)

        LlenarVehiculoBusqueda(Indice)

        _Conexion.Buscar_Vehiculo(_VehiculoRegistro)

        Dim frmVehiculoFormulario As New VehiculoFormulario
        frmVehiculoFormulario.Execute("Editar", _VehiculoRegistro)

        _Conexion.BuscarVehiculoLista(TxtNumeroIdentificacion.Text, TxtNumeroPlaca.Text, DgvRegistroVehiculo)
    End Sub
End Class