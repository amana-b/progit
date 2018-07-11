Namespace Common
    Public Class Logic
#Region "ｺｰﾄﾞ→名称"
        Public Class CodeToName
#Region "得意先ｺｰﾄﾞ"
            '''========================================================================================
            ''' <SUMMARY>得意先ｺｰﾄﾞ</SUMMARY>
            ''' <RETURNS>True:あり, False:なし</RETURNS>
            '''========================================================================================
            Public Shared Function 得意先(ByVal 得意先CD As String) As String
                '----------------------------------------------------------------------
                ' 変数定義
                '----------------------------------------------------------------------
                Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0得意先TableAdapter
                Dim tbl As New NodeDatabase.DataSetView.V0得意先DataTable
                Dim qry As New Collection

                '----------------------------------------------------------------------
                ' 条件設定
                '----------------------------------------------------------------------
                qry.Clear()
                qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, 得意先CD, BaseDatabase.Contents.Compare.Equal))

                '----------------------------------------------------------------------
                ' 読込
                '----------------------------------------------------------------------
                tbl = ada.SelectByCommon(qry)
                If tbl.Count = 0 Then
                    Return ""
                Else
                    Return tbl(0).Item(tbl.得意先名Column.ColumnName)
                End If
            End Function
#End Region

#Region "仕入先ｺｰﾄﾞ"
            '''========================================================================================
            ''' <SUMMARY>仕入先ｺｰﾄﾞ</SUMMARY>
            ''' <RETURNS>True:あり, False:なし</RETURNS>
            '''========================================================================================
            Public Shared Function 仕入先(ByVal 仕入先CD As String) As String
                '----------------------------------------------------------------------
                ' 変数定義
                '----------------------------------------------------------------------
                Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0仕入先TableAdapter
                Dim tbl As New NodeDatabase.DataSetView.V0仕入先DataTable
                Dim qry As New Collection

                '----------------------------------------------------------------------
                ' 条件設定
                '----------------------------------------------------------------------
                qry.Clear()
                qry.Add(New BaseDatabase.Condition(tbl.仕入先CDColumn.ColumnName, 仕入先CD, BaseDatabase.Contents.Compare.Equal))

                '----------------------------------------------------------------------
                ' 読込
                '----------------------------------------------------------------------
                tbl = ada.SelectByCommon(qry)
                If tbl.Count = 0 Then
                    Return ""
                Else
                    Return tbl(0).Item(tbl.仕入先名Column.ColumnName)
                End If
            End Function
#End Region

#Region "ヤマト区分"
            '''========================================================================================
            ''' <SUMMARY>ﾔﾏﾄ区分</SUMMARY>
            ''' <RETURNS>True:あり, False:なし</RETURNS>
            '''========================================================================================
            Public Shared Function ヤマト区分(ByVal ヤマト区分CD As String) As String
                '----------------------------------------------------------------------
                ' 変数定義
                '----------------------------------------------------------------------
                Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0ヤマト区分TableAdapter
                Dim tbl As New NodeDatabase.DataSetView.V0ヤマト区分DataTable
                Dim qry As New Collection

                '----------------------------------------------------------------------
                ' 条件設定
                '----------------------------------------------------------------------
                qry.Clear()
                qry.Add(New BaseDatabase.Condition(tbl.ヤマト区分Column.ColumnName, ヤマト区分CD, BaseDatabase.Contents.Compare.Equal))

                '----------------------------------------------------------------------
                ' 読込
                '----------------------------------------------------------------------
                tbl = ada.SelectByCommon(qry)
                If tbl.Count = 0 Then
                    Return ""
                Else
                    Return tbl(0).Item(tbl.ヤマト区分名Column.ColumnName)
                End If
            End Function
#End Region
        End Class
#End Region
    End Class
End Namespace
