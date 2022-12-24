Imports System.Data.SqlClient

Public Class Conexion_Usuario
    Public conexion As SqlConnection = New SqlConnection(My.Resources.ConexionSQL)
    Public comando As SqlCommand
    Public da As SqlDataAdapter
    Public ds As DataSet = New DataSet()
    Public builder As SqlCommandBuilder
    Public dt As DataTable


    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("CONEXION EXITOSA")
        Catch ex As Exception
            MessageBox.Show("Error:" + ex.ToString)
        Finally
            conexion.Close()
        End Try
    End Sub

    Sub consultarNombre(ByVal nombre As String, ByVal dgv As DataGridView)
        Try
            da = New SqlDataAdapter("select * from Usuario where Nombre like '" & nombre + "%" & "'", conexion)
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt

        Catch ex As Exception

        End Try
    End Sub

    Public Sub consultar(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        builder = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    Function Actualizar(tabla, campos, condicion) As Boolean
        conexion.Open()
        Dim actualiza As String = " update " + tabla + " set " + campos + " where " + condicion
        comando = New SqlCommand(actualiza, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function


    Function Eliminar(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim elimina As String = "delete from " + tabla + " where " + condicion
        comando = New SqlCommand(elimina, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function


    Sub limpiarCampos(ByVal formulario As Form)
        Dim text As Object
        For Each text In formulario.Controls
            If TypeOf text Is TextBox Then
                Dim txttemp As TextBox = CType(text, TextBox)
                txttemp.Clear()
            End If
        Next
    End Sub
End Class
