Imports System.Data
Imports System.Data.SqlClient

Namespace DataSetViewTableAdapters
    Partial Public Class V0得意先詳細TableAdapter

#Region "変数"
        Private datTable As New DataSetView.V0得意先詳細DataTable
#End Region

#Region "ﾚｺｰﾄﾞの検索"
        '''========================================================================================
        ''' <SUMMARY>ﾚｺｰﾄﾞの検索</SUMMARY>
        ''' <PARAM name="Conditions">条件</PARAM>
        ''' <PARAM name="sortExpression">gridViewでﾍｯﾀﾞをｸﾘｯｸした時に設定される</PARAM>
        ''' <PARAM name="sortDefault">並べ替え条件(sortExpressionに指定があれば、sortExpressionが優先)</PARAM>
        ''' <PARAM name="startRowIndex">表示する頁数(0～)</PARAM>
        ''' <PARAM name="maximumRows">1頁に表示する行数</PARAM>
        ''' <PARAM name="TopCount">件数</PARAM>
        ''' <RETURNS>検索したﾚｺｰﾄﾞｾｯﾄ</RETURNS>
        '''========================================================================================
        Public Function SelectByCommon _
                       (ByVal Conditions As Collection _
                      , Optional ByVal sortExpression As String = "" _
                      , Optional ByVal TopCount As Integer = -1 _
                       ) As DataSetView.V0得意先詳細DataTable
            Return SelectByCommon(Conditions, sortExpression, "", -1, -1, TopCount)
        End Function

        Public Function SelectByCommon _
                       (ByVal Conditions As Collection _
                      , ByVal sortExpression As String _
                      , ByVal sortDefault As String _
                       ) As DataSetView.V0得意先詳細DataTable
            Return SelectByCommon(Conditions, sortExpression, sortDefault, -1, -1, -1)
        End Function

        Public Function SelectByCommon _
                       (ByVal Conditions As Collection _
                      , ByVal sortExpression As String _
                      , ByVal sortDefault As String _
                      , ByVal startRowIndex As Integer _
                      , ByVal maximumRows As Integer _
                       ) As DataSetView.V0得意先詳細DataTable
            Return SelectByCommon(Conditions, sortExpression, sortDefault, startRowIndex, maximumRows, -1)
        End Function

        Public Function SelectByCommon _
                       (ByVal Conditions As Collection _
                      , ByVal sortExpression As String _
                      , ByVal sortDefault As String _
                      , ByVal startRowIndex As Integer _
                      , ByVal maximumRows As Integer _
                      , ByVal TopCount As Integer _
                       ) As DataSetView.V0得意先詳細DataTable
            Return BaseDatabase.Adapter.RecordSelect(Conditions, startRowIndex, maximumRows, sortExpression, Me.Connection, Me.CommandCollection(0), datTable, sortDefault, TopCount)
        End Function
#End Region

#Region "ﾚｺｰﾄﾞの件数"
        '''========================================================================================
        ''' <SUMMARY>ﾚｺｰﾄﾞの件数(GridView.ascxで利用)</SUMMARY>
        ''' <PARAM name="Conditions">条件</PARAM>
        ''' <PARAM name="sortExpression">gridViewでﾍｯﾀﾞをｸﾘｯｸした時に設定される</PARAM>
        ''' <PARAM name="sortDefault">並べ替え条件(sortExpressionに指定があれば、sortExpressionが優先)</PARAM>
        ''' <PARAM name="startRowIndex">表示する頁数(0～)</PARAM>
        ''' <PARAM name="maximumRows">1頁に表示する行数</PARAM>
        ''' <RETURNS>検索したﾚｺｰﾄﾞ数</RETURNS>
        '''========================================================================================
        Public Function CountByCommon _
                       (ByVal Conditions As Collection _
                      , ByVal sortExpression As String _
                      , ByVal sortDefault As String _
                      , ByVal startRowIndex As Integer _
                      , ByVal maximumRows As Integer _
                       ) As Integer
            Return BaseDatabase.Adapter.RecordCount(Conditions, startRowIndex, maximumRows, sortExpression, Me.Connection, Me.CommandCollection(0), datTable)
        End Function
#End Region
    End Class
End Namespace
