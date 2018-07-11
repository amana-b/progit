Imports System
Imports System.Configuration
Imports System.Collections.Specialized

Namespace Common
    Public Class WebConfig

        Public Shared Function GetConfigData(ByVal strSection As String, ByVal strKey As String)
            Return CType(ConfigurationManager.GetSection(strSection), NameValueCollection).Item(strKey)
        End Function
    End Class
End Namespace
