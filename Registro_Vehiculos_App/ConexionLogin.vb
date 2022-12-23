Imports System.Data.SqlClient

Public Class ConexionLogin
    Private ReadOnly _Conexion As New SqlConnection(My.Resources.ConexionSQL)
    Private _Comando As SqlCommand
    Private _Adapter As SqlDataAdapter
    Private ReadOnly _Data As New DataSet()
    Private _Builder As SqlCommandBuilder

    Public Sub Login_Conectar()
        Try
            _Conexion.Open()
            Console.WriteLine("Conexion exitosa")
        Catch ex As Exception
            MessageBox.Show("Error:" + ex.ToString)
        Finally
            _Conexion.Close()
        End Try
    End Sub

    Public Function Guardar(Nombre As String, correo As String, clave As String) As Boolean
        Try
            _Conexion.Open()
            _Comando = New SqlCommand($"INSERT INTO Usuario VALUES('{correo}','{Encrypt(clave, clave.Length)}','{Nombre}','Clien')", _Conexion)
            Dim Insertado As Integer = _Comando.ExecuteNonQuery() 'no es un query, es un insert
            _Conexion.Close()
            Return Insertado > 0
        Catch ex As Exception
            MessageBox.Show($"Ocurrio un error en guardar el registro {ex.Message}")
            _Conexion.Close()
            Return False
        End Try
        Return False
    End Function
End Class
