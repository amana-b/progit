Imports System

<Serializable()> _
Public Class Condition
    Private _name As String
    Private _value As String
    Private _compare As Contents.Compare
    Private _EmptyHandle As Contents.EmptyHandle

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Property Value() As String
        Get
            If _value Is Nothing Then
                Return ""
            Else
                Return _value
            End If
        End Get
        Set(ByVal value As String)
            _value = value
        End Set
    End Property

    Public Property Compare() As String
        Get
            Return _compare
        End Get
        Set(ByVal value As String)
            _compare = value
        End Set
    End Property

    Public Property EmptyHandle() As String
        Get
            Return _EmptyHandle
        End Get
        Set(ByVal value As String)
            _EmptyHandle = value
        End Set
    End Property

    Public Sub New(ByVal Name As String, ByVal Value As String, ByVal Compare As Contents.Compare, Optional ByVal EmptyHandle As Contents.EmptyHandle = Contents.EmptyHandle.Where)
        _name = Name
        _value = Value
        _compare = Compare
        _EmptyHandle = EmptyHandle
    End Sub
End Class
