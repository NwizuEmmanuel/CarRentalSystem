Public Class ReturnCarProperty
    Private _returnID As Integer
    Private _carID As Integer
    Private _customerID As Integer
    Private _customerName As String
    Private _returnedDate As DateTime
    Private _elapsedDays As Integer
    Private _feee As Integer

    Public Property ReturnID() As Integer
        Get
            Return _returnID
        End Get
        Set(value As Integer)
            _returnID = value
        End Set
    End Property

    Public Property CarID() As Integer
        Get
            Return _carID
        End Get
        Set(value As Integer)
            _carID = value
        End Set
    End Property

    Public Property CustomerID() As Integer
        Get
            Return _customerID
        End Get
        Set(value As Integer)
            _customerID = value
        End Set
    End Property

    Public Property CustomerName() As String
        Get
            Return _customerName
        End Get
        Set(value As String)
            _customerName = value
        End Set
    End Property

    Public Property ReturnedDate() As DateTime
        Get
            Return _returnedDate
        End Get
        Set(value As DateTime)
            _returnedDate = value
        End Set
    End Property

    Public Property ElapsedDays() As Integer
        Get
            Return _elapsedDays
        End Get
        Set(value As Integer)
            _elapsedDays = value
        End Set
    End Property

    Public Property Fee() As Integer
        Get
            Return _feee
        End Get
        Set(value As Integer)
            _feee = value
        End Set
    End Property

End Class
