Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

'Creamos la clase conexion con SQL
Public Class Conexion_Propietario

    Public conexion As New SqlConnection(My.Resources.ConexionSQL)
    Public comando As SqlCommand
    Public da As SqlDataAdapter
    Public ds As New DataSet()
    Public builder As SqlCommandBuilder

    'Al conectar que nos salga un enunciado de que la conexion fue exitosa
    Public Sub Conectar()
        Try
            conexion.Open()
            MessageBox.Show("CONEXION EXITOSA")
        Catch ex As Exception
            MessageBox.Show("Error:" + ex.ToString)
        Finally
            conexion.Close()
        End Try
    End Sub

    'Creamos consultar, insertar y actualizar
    Public Sub Consultar(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        builder = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    Public Sub Insertar(ByVal sql As String)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub
    Public Function Actualizar(ByVal datos As String) As Boolean
        Try
            conexion.Open()
            comando = New SqlCommand(datos, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            f = 0
            Return True
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString())
            f = 1
            conexion.Close()
            Return False
        Finally
            conexion.Close()
        End Try

    End Function

    'Llena el da con la info del dt
    Public Function Cargar_provincia() As DataTable
        Dim dt = New DataTable
        Consultar("SELECT CODIGO_PROV,DESCRIPCION_PROVINCIA FROM PROVINCIA", "PROVINCIA")
        da.Fill(dt)
        Return (dt)

    End Function

    Public Function Cargar_canton(ByVal idprovincia As String) As DataTable
        Dim dt = New DataTable
        Consultar("SELECT CODIGO_CANTON,DESCRIPCION_CANTON FROM CANTON WHERE CODIGO_PROV=" + idprovincia, "CANTON")
        da.Fill(dt)
        Return (dt)
    End Function

    Public Function Cargar_distrito(ByVal idcanton As String, ByVal idprovincia As String) As DataTable
        Dim dt = New DataTable
        Consultar("SELECT CODIGO_DISTRITO,DESCRIPCION_DISTRITO FROM DISTRITO WHERE CODIGO_PROV=" + idprovincia.ToString() + "And CODIGO_CANTON=" + idcanton, "DISTRITO")
        da.Fill(dt)
        Return (dt)
    End Function

    Public Function Cargar_estado() As DataTable
        Dim dt = New DataTable
        Consultar("SELECT CODIGO_ESTADO,DESCRIPCION_ESTADO FROM ESTADO_CIVIL", "ESTADOCIVIL")
        da.Fill(dt)
        Return (dt)
    End Function

    Public Function Validar_correo(ByRef e As String) As Boolean
        'Validar que escriban bien el correo
        Try
            Return Regex.IsMatch(e.Trim, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")

            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function
    'Propietarios
    Public Function Inserta_propietario(ByVal datos As String) As Boolean
        Try
            conexion.Open()
            comando = New SqlCommand(datos, conexion)
            'indicamos que va a insertar
            comando.ExecuteNonQuery()
            conexion.Close()
            f = 0
            Return True
        Catch ex As Exception
            MessageBox.Show("ERROR:" + ex.ToString)
            f = 1
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function Buscar_propietario(ByVal vtipo As String, ByVal idcedula As String) As DataTable
        'instanciamos la variable para poder usarla
        Dim dt = New DataTable()
        Consultar("SELECT * FROM PROPIETARIO WHERE TIPO_IDENTIFICACION= " + vtipo.ToString() + "AND NUMERO_IDENTIFICACION= '" + idcedula + "'", "PROPIETARIO")
        'Si es mayor a 0, entonces hay datos
        If ds.Tables("PROPIETARIO").Rows.Count > 0 Then
            f = 0
        Else
            f = 1
        End If
        da.Fill(dt)
        Return dt
    End Function
End Class
