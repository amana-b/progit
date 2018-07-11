Imports System.Data
Imports System.Data.SqlClient

Public Class SqlParameter
    Public Shared Function SetValue(ByVal Name As String, ByVal Value As String) As System.Data.SqlClient.SqlParameter
        Dim prmReturn As New System.Data.SqlClient.SqlParameter

        prmReturn.ParameterName = Name
        prmReturn.Value = Value

        Return prmReturn
    End Function

    Public Shared Function SetSourceColumn(ByVal Name As String, ByVal ColName As String) As System.Data.SqlClient.SqlParameter
        Dim prmReturn As New System.Data.SqlClient.SqlParameter

        prmReturn.ParameterName = Name
        prmReturn.SourceColumn = ColName

        Return prmReturn
    End Function

    Public Shared Function SetSourceColumn(ByVal Name As String) As System.Data.SqlClient.SqlParameter
        Dim prmReturn As New System.Data.SqlClient.SqlParameter

        prmReturn.ParameterName = Name
        prmReturn.SourceColumn = Name

        Return prmReturn
    End Function
End Class
