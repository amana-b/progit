Imports Microsoft.VisualBasic

Namespace Common
    Public Class Exist
        '''========================================================================================
        ''' <SUMMARY>区分</SUMMARY>   
        ''' <RETURNS>True:正常, False:異常</RETURNS>
        '''========================================================================================
        Public Shared Function 区分(ByVal 区分種別 As String, ByVal 区分CD As String) As Boolean
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M区分TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M区分DataTable
            Dim qry As New Collection

            If 区分CD = "" Then
                Return True
            End If

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.区分種別Column.ColumnName, 区分種別, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.区分CDColumn.ColumnName, 区分CD, BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            Return tbl.Count > 0
        End Function

        '''========================================================================================
        ''' <SUMMARY>得意先</SUMMARY>   
        ''' <RETURNS>True:正常, False:異常</RETURNS>
        '''========================================================================================
        Public Shared Function 得意先(ByVal 得意先CD As String) As Boolean
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M得意先TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M得意先DataTable
            Dim qry As New Collection

            If 得意先CD = "" Then
                Return True
            End If

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, 得意先CD, BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            Return tbl.Count > 0
        End Function

        '''========================================================================================
        ''' <SUMMARY>仕入先</SUMMARY>   
        ''' <RETURNS>True:正常, False:異常</RETURNS>
        '''========================================================================================
        Public Shared Function 仕入先(ByVal 仕入先CD As String) As Boolean
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M仕入先TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M仕入先DataTable
            Dim qry As New Collection

            If 仕入先CD = "" Then
                Return True
            End If

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.仕入先CDColumn.ColumnName, 仕入先CD, BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            Return tbl.Count > 0
        End Function
    End Class
End Namespace
