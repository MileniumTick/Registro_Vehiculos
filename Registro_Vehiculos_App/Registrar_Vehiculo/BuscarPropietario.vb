Public Class BuscarPropietario
    Private RegistroPropietario As EnumerableRowCollection(Of Registro_VehiculoDataSet.PropietarioRow)
    Private ContarRegistroPropietario As Integer
    Private PropietarioEncontrado As Boolean

    Public Function Execute(TipoIdentificacion As Integer, Identificacion As String, Primero As Boolean) As Boolean
        Try
            If Primero Then
                PropietarioTableAdapter.Fill(Me.Registro_VehiculoDataSet.Propietario)
            End If

            RegistroPropietario = From propietario In Registro_VehiculoDataSet.Propietario
                                  Where propietario.Numero_Identificacion.Contains(Identificacion) And propietario.Tipo_Identificacion = TipoIdentificacion

            ContarRegistroPropietario = RegistroPropietario.Count

            If ContarRegistroPropietario = 0 Then
                MessageBox.Show($"No se encontro el propietario con la identificacion {Identificacion} y el tipo {TipoIdentificacion}")
                frmVehiculoFormulario.Enabled = True
                Close()
                Return False
            End If

            If ContarRegistroPropietario = 1 Then
                frmVehiculoFormulario.PropietarioIdentificacion = RegistroPropietario.First.Numero_Identificacion
                frmVehiculoFormulario.PropietarioTipoIdentificacion = RegistroPropietario.First.Tipo_Identificacion

                MessageBox.Show($"Se encontro el propietario con la identificacion {RegistroPropietario.First.Numero_Identificacion} y el tipo {RegistroPropietario.First.Tipo_Identificacion}")
                frmVehiculoFormulario.Enabled = True
                Close()
                Return True
            End If

            If ContarRegistroPropietario > 1 Then
                DgvPropietario.DataSource = RegistroPropietario.ToList
                ShowDialog()
                Return PropietarioEncontrado
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try

        Return False
    End Function

    Private Sub DgvPropietario_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPropietario.CellDoubleClick
        PropietarioEncontrado = Execute(DgvPropietario.Rows(e.RowIndex).Cells(1).Value, DgvPropietario.Rows(e.RowIndex).Cells(0).Value, False)
    End Sub
End Class