Imports System
Imports System.Configuration
Imports System.Collections.Specialized

Namespace Common
    Public Class Provider

#Region "ﾌﾟﾛﾊﾟﾃｨ"
        Private _Provider As NodeDatabase.Provider

        '''========================================================================================
        ''' <SUMMARY>ｺﾈｸｼｮﾝｽﾄﾘﾝｸﾞ</SUMMARY>
        '''========================================================================================
        Public ReadOnly Property ConnectionStringBase() As String
            Get
                Return _Provider.ConnectionStringBase
            End Get
        End Property
#End Region

#Region "ｺﾝｽﾄﾗｸﾀ"
        '''========================================================================================
        ''' <SUMMARY>ﾃﾞｰﾀﾍﾞｰｽｸﾗｽのｺﾈｸｼｮﾝｽﾄﾘﾝｸﾞを書き換え</SUMMARY>
        '''========================================================================================
        Public Sub New()
            '------------------------------------
            ' 本体
            '------------------------------------
            _Provider = New NodeDatabase.Provider

            _Provider.ConnectionStringBase = CType(ConfigurationManager.GetSection("DBSettings"), NameValueCollection).Item("ConnectionStringBase")
        End Sub
#End Region
    End Class
End Namespace
