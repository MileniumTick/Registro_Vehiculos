Public Class Capacidad
    Dim _Titulo As String
    Dim _Valor As Integer

    Public Property Titulo As String
        Get
            Return _Titulo
        End Get
        Set(value As String)
            _Titulo = value
        End Set
    End Property

    Public Property Valor As Integer
        Get
            Return _Valor
        End Get
        Set(value As Integer)
            _Valor = value
        End Set
    End Property
End Class
