Imports System.Text.RegularExpressions
Public Class frmPropietarioVehiculo

    Dim CONEXION As New Conexion_Propietario
    Private Sub Captura_Datos_del_propietario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Registro_VehiculoDataSet.Propietario' Puede moverla o quitarla según sea necesario.
        Me.PropietarioTableAdapter.Fill(Me.Registro_VehiculoDataSet.Propietario)
        'TODO: esta línea de código carga datos en la tabla 'REGISTRO_VEHICULODataSet.Propietario' Puede moverla o quitarla según sea necesario.
        Me.PropietarioTableAdapter.Fill(Me.Registro_VehiculoDataSet.Propietario)
        CONEXION.conectar()
        ' cargando provincia y va a llenar el combox con los datos de la provincia
        Dim dt = CONEXION.cargar_provincia()
        cmbprovincia.DataSource = dt
        cmbprovincia.DisplayMember = "DESCRIPCION_PROVINCIA"
        cmbprovincia.ValueMember = "CODIGO_PROV"
        cmbprovincia.SelectedIndex = 1
        'TODO: esta línea de código carga datos en la tabla 'DIVISION_TERRITORIASDataSet.CIUDADANO' Puede moverla o quitarla según sea necesario.
        'Me.PROPIETARIOTableAdapter.Fill(Me.REGISTRO_VEHICULODataSet.PROPIETARIO)

    End Sub
    'Cargamos los combobox con los datos de provincia, canton, distrito
    Private Sub cmbprovincia_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbprovincia.SelectionChangeCommitted
        ' cuando seleccione el combro de pronvia, me carga los cantones
        Dim dt = CONEXION.cargar_canton(cmbprovincia.SelectedValue.ToString)
        cmbcanton.DataSource = dt
        cmbcanton.DisplayMember = "DESCRIPCION_CANTON"
        cmbcanton.ValueMember = "CODIGO_CANTON"
        cmbdistrito.DataSource = Nothing
        cmbcanton.SelectedIndex = 0
    End Sub

    Private Sub cmbcanton_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbcanton.SelectionChangeCommitted
        ' cuando seleccione el combro de canton, me carga los distritos pensando tsmbien en las provincias
        Dim dt = CONEXION.cargar_distrito(cmbcanton.SelectedValue.ToString(), cmbprovincia.SelectedValue.ToString())
        cmbdistrito.DataSource = dt
        cmbdistrito.DisplayMember = "DESCRIPCION_DISTRITO"
        cmbdistrito.ValueMember = "CODIGO_DISTRITO"
    End Sub

    Private Sub cmbestadocivil_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbestadocivil.SelectionChangeCommitted
        Dim dt = CONEXION.Cargar_estado()
        cmbestadocivil.DataSource = dt
        cmbestadocivil.DisplayMember = "DESCRIPCION_ESTADO"
        cmbestadocivil.ValueMember = "CODIGO_ESTADO"
    End Sub

    'Funcion para solo poner letras en los txt correspondientes
    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        solo_letras(e)
    End Sub

    Private Sub txtapellido1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido1.KeyPress
        solo_letras(e)
    End Sub

    Private Sub txtapellido2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido2.KeyPress
        solo_letras(e)
    End Sub

    Private Function validar_campos() As Boolean
        'validando que los campos esten llenos
        If cmbtipoid.Text = "" Or txtnombre.Text = "" Or txtapellido1.Text = "" Or txtapellido2.Text = "" Or txtdireccion.Text = "" Or txtidentificacion.Text = "" Or txtcorreo.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub txtcorreo_LostFocus(sender As Object, e As EventArgs) Handles txtcorreo.LostFocus
        If CONEXION.validar_correo(sender.text) Then
            Return
        Else
            MsgBox("FORMATO DEL CORREO INCORRECTO,REVISAR")
            txtcorreo.Focus()

        End If
    End Sub

    Private Sub botconsultar_Click(sender As Object, e As EventArgs) Handles botconsultar.Click
        Try
            Dim vtipoid As Integer
            f = 0
            Dim valorformateado, valorsinformato, videntificacion As String
            'quitamos los guiones
            valorformateado = txtidentificacion.Text
            'Va a remplasar los guiones por nada, lo de parentesis es nothing
            valorsinformato = valorformateado.Replace("-", "")
            videntificacion = valorsinformato
            vtipoid = cmbtipoid.SelectedIndex
            Dim dt = CONEXION.buscar_propietario(vtipoid, videntificacion)
            'Me va a retornar si lo encontro o no lo encontro, tenemos condicionado el metodo con variable f
            'Si F es 0 existe almenos un registro, si f es 1, no coincide
            If dt.Rows.Count = 0 Then
                MessageBox.Show("El usuario buscado no fue encontrado")
                Return
            End If

            '---cargar canton
            Dim cantones = CONEXION.Cargar_canton(dt.Rows(0)!provincia)
            cmbcanton.DataSource = cantones
            cmbcanton.DisplayMember = "descripcion_canton"
            cmbcanton.ValueMember = "codigo_canton"
            cmbcanton.SelectedIndex = -1
            '---cargar distrito
            Dim distritos = CONEXION.Cargar_distrito(dt.Rows(0)!canton, dt.Rows(0)!provincia)
            cmbdistrito.DataSource = distritos
            cmbdistrito.DisplayMember = "descripcion_distrito"
            cmbdistrito.ValueMember = "codigo_distrito"
            cmbdistrito.SelectedIndex = -1

            '---cargar estado civil
            Dim estado = CONEXION.Cargar_estado()
            cmbestadocivil.DataSource = estado
            cmbestadocivil.DisplayMember = "descripcion_estado"
            cmbestadocivil.ValueMember = "codigo_estado"
            cmbestadocivil.SelectedIndex = -1

            If f = 0 Then
                txtnombre.Text = dt.Rows(0)!Nombre
                txtapellido1.Text = dt.Rows(0)!Primer_Apellido
                txtapellido2.Text = dt.Rows(0)!Segundo_Apellido
                txtombrej.Text = dt.Rows(0)!Nombre_Juridico
                txtdireccion.Text = dt.Rows(0)!Direccion
                txtcorreo.Text = dt.Rows(0)!Correo_Electronico
                cmbprovincia.SelectedValue = dt.Rows(0)!provincia
                cmbcanton.SelectedValue = dt.Rows(0)!canton
                cmbdistrito.SelectedValue = dt.Rows(0)!distrito
                cmbestadocivil.SelectedValue = dt.Rows(0)!estado_civil
                K = 1
            Else
                'inicializamos de una en 0 para el proximo registro
                f = 0
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub botguardar_Click(sender As Object, e As EventArgs) Handles botguardar.Click
        'DECLARAR VARIABLES
        Dim strsql As String
        Dim valorformateado As String
        Dim valorsinformato As String
        strsql = ""
        Dim vtipoid, videntificacion, vnombre, vapellido1, vapellido2, vnombrej, vcorreo, vdireccion, vestadocivil As String
        Dim vprovincia, vcanton, vdistrito As Integer
        'inicializamos las variables
        vtipoid = ""
        videntificacion = ""
        vnombre = ""
        vapellido1 = ""
        vapellido2 = ""
        vnombrej = ""
        vcorreo = ""
        vdireccion = ""
        vestadocivil = ""
        'inicializamos las integer con 0
        vprovincia = 0
        vcanton = 0
        vdistrito = 0

        Try
            If validar_campos() = False Then
                MsgBox("DATOS INCOMPLETOS, FAVOR COMPLETAR")
                Return
            End If
            'Si todo esta ok
            If MessageBox.Show("¿Esta seguro de insertar el registro en la base de datos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                'quitamos los guiones
                valorformateado = txtidentificacion.Text
                'Va a remplasar los guiones por nada, lo de parentesis es nothing
                valorsinformato = valorformateado.Replace("-", "")
                videntificacion = valorsinformato
                vtipoid = cmbtipoid.SelectedIndex
                'Realizamos consulta del cuidadano por (tipo_id, numero_id)
                Dim dt = CONEXION.buscar_propietario(vtipoid, videntificacion)

                'Me va a retornar si lo encontro o no lo encontro, tenemos condicionado el metodo con variable f
                'Si F es 0 existe almenos un registro, si f es 1, no coincide

                If f = 0 Then
                    MsgBox("IDENTIFICACION YA FUE REGISTRADA")
                    Return
                Else
                    'inicializamos de una en 0 para el proximo registro
                    f = 0
                End If

                'movemos todas las cajas de texto a las varables 
                vnombre = txtnombre.Text
                vapellido1 = txtapellido1.Text
                vapellido2 = txtapellido2.Text
                vprovincia = cmbprovincia.SelectedValue
                vcanton = cmbcanton.SelectedValue
                vdistrito = cmbdistrito.SelectedValue
                vnombrej = txtombrej.Text
                vcorreo = txtcorreo.Text
                vdireccion = txtdireccion.Text
                vestadocivil = cmbestadocivil.SelectedValue
                'insertamos
                strsql = "INSERT PROPIETARIO (TIPO_IDENTIFICACION,NUMERO_IDENTIFICACION,NOMBRE,PRIMER_APELLIDO,SEGUNDO_APELLIDO,NOMBRE_JURIDICO,PROVINCIA,CANTON,DISTRITO,DIRECCION,ESTADO_CIVIL,CORREO_ELECTRONICO)"
                strsql += vbCrLf + "VALUES ('" & vtipoid & "','" & videntificacion & "','" & vnombre & "','" & vapellido1 & "','" & vapellido2 & "','" & vnombrej & "','" & vprovincia & "','" & vcanton & "','" & vdistrito & "','" & vdireccion & "','" & vestadocivil & "','" & vcorreo & "')"
                MsgBox(strsql)
                CONEXION.inserta_propietario(strsql)
                'evaluamos si se inserto correctamente
                If f = 0 Then
                    MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
                Else
                    MessageBox.Show("ERRO AL GUARDAR LOS DATOS, POR FAVOR REVISE")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("ERRO AL GUARDAR LOS DATOS, POR FAVOR REVISE")
        End Try

    End Sub

    Private Sub botlimpiar_Click(sender As Object, e As EventArgs) Handles botlimpiar.Click
        txtapellido1.Clear()
        txtapellido2.Clear()
        txtcorreo.Clear()
        txtdireccion.Clear()
        txtidentificacion.Clear()
        txtnombre.Clear()
        txtombrej.Clear()
    End Sub

    Private Sub botmodificar_Click(sender As Object, e As EventArgs) Handles botmodificar.Click
        Dim sql As String
        Dim vtipoid As Integer
        vtipoid = 0
        Dim videntificacion, vnombre, vapellido1, vapellido2, vnombrej, vcorreo, vdireccion As String
        videntificacion = ""
        vnombre = ""
        vapellido1 = ""
        vapellido2 = ""
        vnombrej = ""
        vcorreo = ""
        vdireccion = ""
        Try

            If K = 0 Then
                MsgBox("Debe presionar, el boto de consultar antes de Modificar")
                Return
            Else
                If validar_campos() = True Then
                    vtipoid = cmbtipoid.SelectedIndex
                    videntificacion = txtidentificacion.Text
                    vnombre = txtnombre.Text
                    vapellido1 = txtapellido1.Text
                    vapellido2 = txtapellido2.Text
                    vcorreo = txtcorreo.Text
                    vdireccion = txtdireccion.Text
                    If MessageBox.Show("Esta seguro de modificar el registro en la base de datos?", "Confimacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        sql = "UPDATE PROPIETARIO SET TIPO_IDENTIFICACION = '" & vtipoid & "', NUMERO_IDENTIFICACION= '" & videntificacion & "' , NOMBRE= '" & vnombre & "' , PRIMER_APELLIDO= '" & vapellido1 & "' , SEGUNDO_APELLIDO= '" & vapellido2 & "' , CORREO_ELECTRONICO= '" & vcorreo & "' , DIRECCION='" & vdireccion & "'"
                        MsgBox(sql)
                        CONEXION.actualizar(sql)
                        If f = 0 Then
                            MessageBox.Show(" Datos Almacenados correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show(" Error al insertar", "Datos no guardados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString())

        Finally

        End Try

    End Sub

End Class