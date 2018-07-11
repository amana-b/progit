Public Class Provider
    '''========================================================================================
    ''' <summary>ConnectionStringデータベースに接続するための接続文字列</summary>
    '''========================================================================================
    Private _ConnectionStringBase As String = ""
    Public Property ConnectionStringBase() As String
        Get
            Return _ConnectionStringBase
        End Get
        Set(ByVal value As String)
            _ConnectionStringBase = value
            My.Settings.Item("ConnectionStringBase") = value
        End Set
    End Property
End Class
