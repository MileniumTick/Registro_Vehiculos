Public Class Vehiculo
    Private _Clase As String
    Private _Codigo_Clase As Integer
    Private _Numero_Placa As Integer
    Private _Tipo_Identificacion As Integer
    Private _Identificacion As String
    Private _Numero_Chasis As String
    Private _Numero_Motor As String
    Private _Color As String
    Private _Estilo As String
    Private _Anho As Integer = Now.Year
    Private _Cilindraje As Integer
    Private _Capacidad As Integer
    Private _Combustible As String
    Private _Marca As String
    Private _Categoria As String
    Private _Valor_Fiscal As Double
    Private _Serie As String

    Public Property Clase As String
        Get
            Return _Clase
        End Get
        Set(value As String)
            _Clase = value
        End Set
    End Property

    Public Property Numero_Placa As Integer
        Get
            Return _Numero_Placa
        End Get
        Set(value As Integer)
            _Numero_Placa = value
        End Set
    End Property

    Public Property Tipo_Identificacion As Integer
        Get
            Return _Tipo_Identificacion
        End Get
        Set(value As Integer)
            _Tipo_Identificacion = value
        End Set
    End Property

    Public Property Identificacion As String
        Get
            Return _Identificacion
        End Get
        Set(value As String)
            _Identificacion = value
        End Set
    End Property

    Public Property Numero_Chasis As String
        Get
            Return _Numero_Chasis
        End Get
        Set(value As String)
            _Numero_Chasis = value
        End Set
    End Property

    Public Property Numero_Motor As String
        Get
            Return _Numero_Motor
        End Get
        Set(value As String)
            _Numero_Motor = value
        End Set
    End Property

    Public Property Color As String
        Get
            Return _Color
        End Get
        Set(value As String)
            _Color = value
        End Set
    End Property

    Public Property Estilo As String
        Get
            Return _Estilo
        End Get
        Set(value As String)
            _Estilo = value
        End Set
    End Property

    Public Property Anho As Integer
        Get
            Return _Anho
        End Get
        Set(value As Integer)
            _Anho = value
        End Set
    End Property

    Public Property Cilindraje As Integer
        Get
            Return _Cilindraje
        End Get
        Set(value As Integer)
            _Cilindraje = value
        End Set
    End Property

    Public Property Capacidad As Integer
        Get
            Return _Capacidad
        End Get
        Set(value As Integer)
            _Capacidad = value
        End Set
    End Property

    Public Property Combustible As String
        Get
            Return _Combustible
        End Get
        Set(value As String)
            _Combustible = value
        End Set
    End Property

    Public Property Marca As String
        Get
            Return _Marca
        End Get
        Set(value As String)
            _Marca = value
        End Set
    End Property

    Public Property Categoria As String
        Get
            Return _Categoria
        End Get
        Set(value As String)
            _Categoria = value
        End Set
    End Property

    Public Property Valor_Fiscal As Double
        Get
            Return _Valor_Fiscal
        End Get
        Set(value As Double)
            _Valor_Fiscal = value
        End Set
    End Property

    Public Property Serie As String
        Get
            Return _Serie
        End Get
        Set(value As String)
            _Serie = value
        End Set
    End Property

    Public Property Codigo_Clase As Integer
        Get
            Return _Codigo_Clase
        End Get
        Set(value As Integer)
            _Codigo_Clase = value
        End Set
    End Property

    Public Sub Limpiar()
        Clase = ""
        Numero_Placa = 0
        Tipo_Identificacion = 0
        Identificacion = ""
        Numero_Chasis = ""
        Numero_Motor = ""
        Color = ""
        Estilo = ""
        Anho = Now.Year
        Cilindraje = 0
        Capacidad = 0
        Combustible = ""
        Marca = ""
        Categoria = ""
        Valor_Fiscal = 0
        Serie = ""
    End Sub

    Public Function Validar() As Boolean
        Try
            If IsNothing(Clase) Or IsNothing(Color) Or IsNothing(Combustible) Or IsNothing(Categoria) Then
                Return False
            End If
            Return _Clase.Length > 0 And _Numero_Placa > 0 And _Tipo_Identificacion >= 0 And _Identificacion.Length > 0 And _Numero_Chasis.Length > 0 And _Color.Length > 0 And _Estilo.Length > 0 And _Anho > 0 And _Cilindraje > 0 And _Capacidad >= 0 And _Combustible.Length > 0 And _Marca.Length > 0 And _Categoria.Length > 0 And _Valor_Fiscal > 0 And _Serie.Length > 0
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return False
        End Try
    End Function
End Class
