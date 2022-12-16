Public Class frmVehiculoFormulario

    Private _RegistroVehiculo As New Vehiculo
    Private _PlacaGenerada As Boolean
    Private _Propietario As Boolean
    Private _Editando As Boolean
    Private ReadOnly _Conexion As New VehiculoConexion

    Public Shared PropietarioIdentificacion As String
    Public Shared PropietarioTipoIdentificacion As Integer

    Public Sub Execute(Accion As String, EditarVehiculo As Vehiculo)
        Try
            _Conexion.Vehiculo_Conectar()
            LlenarCombos()
            ValidaCamposTimer.Start()
            Select Case Accion
                Case "Nuevo"
                    _Editando = Nuevo_Registro()
                Case "Editar"
                    _Editando = Editar_Registro(EditarVehiculo)
                Case Else
                    Throw New Exception("La accion seleccionada no existe")
            End Select
            If Not Visible Then
                ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            BtnCancelar.PerformClick()
        End Try

    End Sub

    Private Sub VehiculoFormulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtpAnno.Format = DateTimePickerFormat.Custom
        DtpAnno.CustomFormat = "yyyy"
        DtpAnno.ShowUpDown = True
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        _RegistroVehiculo.Limpiar()
        Close()
    End Sub

    Private Function Nuevo_Registro() As Boolean
        Try
            Text = "Nuevo registro de vehiculo"
            _RegistroVehiculo.Limpiar()
            LlenarCampos()
            BtnGenerarPlaca.Show()
            BtnBuscarIdentificacion.Show()
            BtnGenerarPlaca.Enabled = True
            BtnBuscarIdentificacion.Enabled = True
            CbxClase.Enabled = True
            TxtNumeroIdentificacion.Enabled = True
            CbxTipoIdentificacion.Enabled = True
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
            BtnCancelar.PerformClick()
        End Try
    End Function

    Private Function Editar_Registro(EditarVehiculo As Vehiculo) As Boolean
        Try
            Text = "Editar registro de vehiculo"
            _RegistroVehiculo = EditarVehiculo
            LlenarCampos()
            BtnGenerarPlaca.Hide()
            BtnBuscarIdentificacion.Hide()
            BtnGenerarPlaca.Enabled = False
            BtnBuscarIdentificacion.Enabled = False
            CbxClase.Enabled = False
            TxtNumeroIdentificacion.Enabled = False
            CbxTipoIdentificacion.Enabled = False
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Private Sub LlenarCampos()
        TxtNumeroPlaca.Text = _RegistroVehiculo.Numero_Placa
        CbxClase.SelectedIndex = CbxClase.Items.IndexOf(_RegistroVehiculo.Clase)
        TxtNumeroIdentificacion.Text = _RegistroVehiculo.Identificacion
        CbxTipoIdentificacion.SelectedIndex = _RegistroVehiculo.Tipo_Identificacion
        TxtNumeroChasis.Text = _RegistroVehiculo.Numero_Chasis
        TxtNumeroMotor.Text = _RegistroVehiculo.Numero_Motor
        CbxColor.SelectedIndex = CbxColor.Items.IndexOf(_RegistroVehiculo.Color)
        CbxEstilo.SelectedIndex = CbxEstilo.Items.IndexOf(_RegistroVehiculo.Estilo)
        DtpAnno.Value = DateValue($"01/01/{_RegistroVehiculo.Anho}")
        TxtCilindraje.Text = _RegistroVehiculo.Cilindraje
        CbxCapacidad.SelectedIndex = _RegistroVehiculo.Capacidad
        CbxCombustible.SelectedIndex = CbxCombustible.Items.IndexOf(_RegistroVehiculo.Combustible)
        TxtMarca.Text = _RegistroVehiculo.Marca
        CbxCategoria.SelectedIndex = CbxCategoria.Items.IndexOf(_RegistroVehiculo.Categoria)
        TxtValorFiscal.Text = _RegistroVehiculo.Valor_Fiscal
        TxtSerie.Text = _RegistroVehiculo.Serie
    End Sub

    Private Sub BtnGenerarPlaca_Click(sender As Object, e As EventArgs) Handles BtnGenerarPlaca.Click
        Dim NumeroPlaca As Integer = _Conexion.Generar_Clase(CbxClase.SelectedIndex, CbxClase.SelectedItem)

        If NumeroPlaca > 0 Then
            MessageBox.Show($"Placa generada con exito su consecutivo es: {NumeroPlaca}")
            TxtNumeroPlaca.Text = NumeroPlaca
            _RegistroVehiculo.Numero_Placa = NumeroPlaca
            CbxClase.Enabled = False
            BtnGenerarPlaca.Enabled = False
            BtnCancelar.Enabled = False
            _PlacaGenerada = True
            Return

        End If

        MessageBox.Show("Error al generar el numero de placa")
        Return

    End Sub

    Private Sub CbxClase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxClase.SelectedIndexChanged
        BtnGenerarPlaca.Enabled = CbxClase.SelectedIndex >= 0
    End Sub

    Private Sub BtnBuscarIdentificacion_Click(sender As Object, e As EventArgs) Handles BtnBuscarIdentificacion.Click
        If Not BuscarPropietario() Then
            CbxTipoIdentificacion.Enabled = True
            _Propietario = False
            Return
        End If

        _Propietario = True
        TxtNumeroIdentificacion.Enabled = False
        CbxTipoIdentificacion.Enabled = False
        TxtNumeroIdentificacion.Text = PropietarioIdentificacion
        CbxTipoIdentificacion.SelectedIndex = PropietarioTipoIdentificacion
    End Sub

    Private Sub LlenarCombos()
        Dim TipoIdentificacionLista As New List(Of TipoIdentificacion) From {
            New TipoIdentificacion() With {.Valor = 0, .Titulo = "Fisico"},
            New TipoIdentificacion() With {.Valor = 1, .Titulo = "Juridico"}
        }

        CbxTipoIdentificacion.DataSource = (TipoIdentificacionLista)
        CbxTipoIdentificacion.DisplayMember = "Titulo"
        CbxTipoIdentificacion.ValueMember = "Valor"

        Dim CapacidadLista As New List(Of Capacidad) From {
            New Capacidad() With {.Valor = 0, .Titulo = "Dos personas"},
            New Capacidad() With {.Valor = 1, .Titulo = "Tres personas"},
            New Capacidad() With {.Valor = 2, .Titulo = "Cuatro personas"},
            New Capacidad() With {.Valor = 3, .Titulo = "Cinco personas"},
            New Capacidad() With {.Valor = 4, .Titulo = "Seis personas"},
            New Capacidad() With {.Valor = 5, .Titulo = "Siete personas"}
        }

        CbxCapacidad.DataSource = (CapacidadLista)
        CbxCapacidad.DisplayMember = "Titulo"
        CbxCapacidad.ValueMember = "Valor"
    End Sub

    Private Function BuscarPropietario() As Boolean
        Dim frmBuscarPropietario As New BuscarPropietario

        Return frmBuscarPropietario.Execute(CbxTipoIdentificacion.SelectedIndex, TxtNumeroIdentificacion.Text.Trim, True)
    End Function

    Private Function ValidarCampos() As Boolean
        Try
            _RegistroVehiculo.Numero_Placa = CInt(TxtNumeroPlaca.Text)
            _RegistroVehiculo.Clase = CbxClase.SelectedItem
            _RegistroVehiculo.Codigo_Clase = CbxClase.SelectedIndex
            _RegistroVehiculo.Identificacion = TxtNumeroIdentificacion.Text
            _RegistroVehiculo.Tipo_Identificacion = CbxTipoIdentificacion.SelectedIndex
            _RegistroVehiculo.Numero_Chasis = TxtNumeroChasis.Text.Trim
            _RegistroVehiculo.Numero_Motor = TxtNumeroMotor.Text.Trim
            _RegistroVehiculo.Color = CbxColor.SelectedItem
            _RegistroVehiculo.Estilo = CbxEstilo.SelectedItem
            _RegistroVehiculo.Anho = DtpAnno.Value.Year
            _RegistroVehiculo.Cilindraje = CInt(TxtCilindraje.Text)
            _RegistroVehiculo.Capacidad = CbxCapacidad.SelectedIndex
            _RegistroVehiculo.Combustible = CbxCombustible.SelectedItem
            _RegistroVehiculo.Marca = TxtMarca.Text.Trim
            _RegistroVehiculo.Categoria = CbxCategoria.SelectedItem
            _RegistroVehiculo.Valor_Fiscal = CDbl(TxtValorFiscal.Text)
            _RegistroVehiculo.Serie = TxtSerie.Text.Trim

            Return _RegistroVehiculo.Validar
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Private Sub ValidaCamposTimer_Tick(sender As Object, e As EventArgs) Handles ValidaCamposTimer.Tick
        LblFechaActual.Text = Now
        BtnGuardar.Enabled = ValidarCampos() And ((_Propietario And _PlacaGenerada) Or _Editando)
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If Not _Conexion.Guardar_Vehiculo(_RegistroVehiculo, _Editando) Then
                MessageBox.Show("Error al guardar el registro verigique la información")
                Return
            End If
            MessageBox.Show("Exito al guardar el registro!")
            Execute("Editar", _RegistroVehiculo)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub VehiculoFormulario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ValidaCamposTimer.Stop()
    End Sub
End Class