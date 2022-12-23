Imports System.Text.RegularExpressions

Module Funciones
    Public f, K As Integer

    Public Sub solo_letras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Function validarEmail(ByRef correo As String) As Boolean
        Try
            Return Regex.IsMatch(correo.Trim, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
        Return False
    End Function

    Function validarClave(ByRef clave As String) As Boolean
        Try
            Return clave.Length > 8
        Catch ex As Exception

        End Try
        Return False
    End Function

    Function Encrypt(password As String, passwordLong As Integer) As String
        Dim cifrado As String = ""

        For i = 1 To passwordLong
            Dim caracter As Integer = Asc(Mid(password, i)) + 64
            If caracter > 255 Then
                caracter = caracter - 256
            End If
            cifrado = cifrado + Chr(caracter)
        Next

        Return cifrado

    End Function

    Function DesEncrypt(password As String, passwordLong As Integer) As String
        Dim cifrado As String = ""

        For i = 1 To passwordLong
            Dim caracter As Integer = Asc(Mid(password, i)) - 64
            If caracter > 255 Then
                caracter = caracter + 256
            End If
            cifrado = cifrado + Chr(caracter)
        Next

        Return cifrado
    End Function
End Module
