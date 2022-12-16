Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class VehiculoConexion
    Private ReadOnly _Conexion As New SqlConnection(My.Resources.ConexionSQL)
    Private _Comando As SqlCommand
    Private _Adapter As SqlDataAdapter
    Private ReadOnly _Data As New DataSet()
    Private _Builder As SqlCommandBuilder

    Public Sub Vehiculo_Conectar()
        Try
            _Conexion.Open()
            Console.WriteLine("Conexion exitosa")
        Catch ex As Exception
            MessageBox.Show("Error:" + ex.ToString)
        Finally
            _Conexion.Close()
        End Try
    End Sub

    Public Sub Buscar_Vehiculo(VehiculoBuscado As Vehiculo)
        Try
            If VehiculoBuscado Is Nothing Then
                Throw New ArgumentNullException(NameOf(VehiculoBuscado))
            End If

            Consultar($"SELECT TOP 1 *  FROM Vehiculo WHERE Tipo_Identificacion = '{VehiculoBuscado.Tipo_Identificacion}' AND Numero_Identificacion = '{VehiculoBuscado.Identificacion}' AND Clase = '{VehiculoBuscado.Clase}' AND Numero_Placa = '{VehiculoBuscado.Numero_Placa}' ORDER BY Numero_Placa DESC", "Vehiculo")

            If _Data.Tables("Vehiculo").Rows.Count <= 0 Then
                Throw New Exception("No se encontro el registro en la base de datos")
            End If

            VehiculoBuscado.Cilindraje = _Data.Tables("Vehiculo").Rows(0).Item("Cilindraje")
            VehiculoBuscado.Anho = _Data.Tables("Vehiculo").Rows(0).Item("Anho")
            VehiculoBuscado.Serie = _Data.Tables("Vehiculo").Rows(0).Item("Serie")
            VehiculoBuscado.Combustible = _Data.Tables("Vehiculo").Rows(0).Item("Combustible")
            VehiculoBuscado.Capacidad = _Data.Tables("Vehiculo").Rows(0).Item("Capacidad")
            VehiculoBuscado.Categoria = _Data.Tables("Vehiculo").Rows(0).Item("Categoria")
            VehiculoBuscado.Color = _Data.Tables("Vehiculo").Rows(0).Item("Color")
            VehiculoBuscado.Estilo = _Data.Tables("Vehiculo").Rows(0).Item("Estilo")
            VehiculoBuscado.Marca = _Data.Tables("Vehiculo").Rows(0).Item("Marca")
            VehiculoBuscado.Numero_Chasis = _Data.Tables("Vehiculo").Rows(0).Item("Numero_Chasis")
            VehiculoBuscado.Numero_Motor = _Data.Tables("Vehiculo").Rows(0).Item("Numero_Motor")
            VehiculoBuscado.Valor_Fiscal = _Data.Tables("Vehiculo").Rows(0).Item("Valor_Fiscal")

            Return

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try

    End Sub

    Public Function Guardar_Vehiculo(VehiculoGuardado As Vehiculo, Editando As Boolean) As Boolean
        Try
            If Not Editando Then
                Return Interactuar($"INSERT INTO Vehiculo 
                                    VALUES({VehiculoGuardado.Tipo_Identificacion},
                                          '{VehiculoGuardado.Identificacion}',
                                          '{VehiculoGuardado.Clase}',
                                          {VehiculoGuardado.Numero_Placa},
                                          '{VehiculoGuardado.Numero_Chasis}',
                                          '{VehiculoGuardado.Numero_Motor}',
                                          '{VehiculoGuardado.Color}',
                                          '{VehiculoGuardado.Estilo}',
                                          {VehiculoGuardado.Anho},
                                          {VehiculoGuardado.Cilindraje},
                                          {VehiculoGuardado.Capacidad},
                                          '{VehiculoGuardado.Combustible}',
                                          '{VehiculoGuardado.Marca}',
                                          '{VehiculoGuardado.Categoria}',
                                          {VehiculoGuardado.Valor_Fiscal},
                                          '{VehiculoGuardado.Serie}',
                                          {VehiculoGuardado.Codigo_Clase})")
            End If
            Return Interactuar($"UPDATE Vehiculo
                               SET [Tipo_Identificacion] = {VehiculoGuardado.Tipo_Identificacion}
                                  ,[Numero_Identificacion] = '{VehiculoGuardado.Identificacion}'
                                  ,[Clase] = '{VehiculoGuardado.Clase}'
                                  ,[Numero_Placa] = {VehiculoGuardado.Numero_Placa}
                                  ,[Numero_Chasis] = '{VehiculoGuardado.Numero_Chasis}'
                                  ,[Numero_Motor] = '{VehiculoGuardado.Numero_Motor}'
                                  ,[Color] = '{VehiculoGuardado.Color}'
                                  ,[Estilo] = '{VehiculoGuardado.Estilo}'
                                  ,[Anho] = {VehiculoGuardado.Anho}
                                  ,[Cilindraje] = {VehiculoGuardado.Cilindraje}
                                  ,[Capacidad] = {VehiculoGuardado.Capacidad}
                                  ,[Combustible] = '{VehiculoGuardado.Combustible}'
                                  ,[Marca] = '{VehiculoGuardado.Marca}'
                                  ,[Categoria] = '{VehiculoGuardado.Categoria}'
                                  ,[Valor_Fiscal] = {VehiculoGuardado.Valor_Fiscal}
                                  ,[Serie] = '{VehiculoGuardado.Serie}'
                                  ,[Codigo_Clase] = {VehiculoGuardado.Codigo_Clase}
                              WHERE Tipo_Identificacion = {VehiculoGuardado.Tipo_Identificacion} AND 
                                    Numero_Identificacion = '{VehiculoGuardado.Identificacion}' AND 
                                    CLASE = '{VehiculoGuardado.Clase}' AND 
                                    Numero_Placa = {VehiculoGuardado.Numero_Placa}")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Sub Borrar_Vehiculo(VehiculoBorrar As Vehiculo)
        Try
            If Interactuar($"DELETE Vehiculo WHERE Tipo_Identificacion = {VehiculoBorrar.Tipo_Identificacion} AND Numero_Identificacion = '{VehiculoBorrar.Identificacion}' AND Clase = '{VehiculoBorrar.Clase}' AND Numero_Placa = {VehiculoBorrar.Numero_Placa}") Then
                MessageBox.Show("Registro borrado con exito!")
                Return
            End If
            MessageBox.Show("Ocurrio un error al borrar el registro")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub BuscarVehiculoLista(Identificacion As String, NumeroPlaca As String, VehiculoLista As DataGridView)
        Try
            Consultar($"SELECT * FROM Vehiculo WHERE Numero_Identificacion LIKE '%{Identificacion}%' AND Numero_Placa LIKE '%{NumeroPlaca}%' ORDER BY Numero_Placa ASC, Numero_Identificacion ASC", "Vehiculos")

            If _Data.Tables("Vehiculos").Rows.Count <= 0 Then
                Throw New Exception("No se encontro ningun registro en la tabla")
            End If

            VehiculoLista.DataSource = _Data.Tables("Vehiculos")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Function Generar_Clase(Codigo_Clase As Integer, Clase As String) As Integer

        If IsNothing(Clase) Then
            Return 0
        End If

        If Clase.Length = 0 Then
            Return 0
        End If

        Dim Consecutivo As Integer = Obtener_Siguiente_Clase(Codigo_Clase, Clase)

        If Consecutivo > 0 Then
            Return Consecutivo
        End If
        Return 0
    End Function

    Private Function Obtener_Siguiente_Clase(Codigo_Clase As Integer, Clase As String) As String
        Consultar($"SELECT TOP 1 *  FROM Clase WHERE Codigo_Clase =  {Codigo_Clase} AND Clase = '{Clase}'  ORDER BY Consecutivo DESC", "Clase")

        If _Data.Tables("Clase").Rows.Count = 0 Then
            If Interactuar($"INSERT INTO Clase VALUES({Codigo_Clase},'{Clase}',{1})") Then
                Return 1
            End If
            Return 0
        End If

        If _Data.Tables("Clase").Rows.Count > 0 Then

            Dim Consecutivo As Integer = _Data.Tables("Clase").Rows(0).Item(2)
            Consecutivo += 1

            If Interactuar($"INSERT INTO Clase VALUES({Codigo_Clase},'{Clase}',{Consecutivo})") Then
                Return Consecutivo
            End If
            Return 0
        End If

        Return 0
    End Function

    Private Sub Consultar(ByVal SQL As String, ByVal Tabla As String)
        _Data.Tables.Clear()
        _Adapter = New SqlDataAdapter(SQL, _Conexion)
        _Builder = New SqlCommandBuilder(_Adapter)
        _Adapter.Fill(_Data, Tabla)
    End Sub

    Private Function Interactuar(ByVal SQL As String) As Boolean
        Try
            _Conexion.Open()
            _Comando = New SqlCommand(SQL, _Conexion)
            Dim Insertado As Integer = _Comando.ExecuteNonQuery() 'no es un query, es un insert
            _Conexion.Close()
            Return Insertado > 0
        Catch ex As Exception
            MessageBox.Show("Error:" + ex.ToString)
            _Conexion.Close()
            Return False
        End Try
    End Function
End Class
