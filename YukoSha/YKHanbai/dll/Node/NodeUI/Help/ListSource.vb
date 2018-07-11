Namespace List
    Public Class Source
        Public COLNAME_LIST_DISPLAY As String = "Display"
        Public COLNAME_LIST_VALUE As String = "Value"

#Region "実行"
        Public Function Execute(ByVal ListType As NodeUI.List.Type) As DataTable
            Select Case ListType
                'ｺｰﾄﾞﾏｽﾀ
                Case NodeUI.List.Type.M区分_紙種別 : Return C区分_共通部品(NodeContents.Constant.CodeType.紙種別)
                Case NodeUI.List.Type.M区分_機械区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.機械区分)
                Case NodeUI.List.Type.M区分_機械種別区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.機械種別区分)
                Case NodeUI.List.Type.M区分_再利用区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.再利用区分)
                    'Case NodeUI.List.Type.M区分_売上日計表対象 : Return C区分_共通部品(NodeContents.Constant.CodeType.売上日計表対象)
                Case NodeUI.List.Type.M区分_場所区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.場所区分)
                Case NodeUI.List.Type.M区分_単価区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.単価区分)
                Case NodeUI.List.Type.M区分_消費税区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.消費税区分)
                Case NodeUI.List.Type.M区分_請求書発行区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.請求書発行区分)
                Case NodeUI.List.Type.M区分_回収方法 : Return C区分_共通部品(NodeContents.Constant.CodeType.回収方法)
                Case NodeUI.List.Type.M区分_定番品区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.定番品区分)
                Case NodeUI.List.Type.M区分_在庫区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.在庫区分)
                Case NodeUI.List.Type.M区分_買掛金未払金区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.買掛金未払金区分)
                Case NodeUI.List.Type.M区分_種別内訳区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.種別内訳区分)
                Case NodeUI.List.Type.M区分_帳票区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.帳票区分)
                Case NodeUI.List.Type.M区分_工程区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.工程区分, False)
                Case NodeUI.List.Type.M区分_発注単位区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.発注単位区分, False)
                Case NodeUI.List.Type.M区分_取引先区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.取引先区分)
                Case NodeUI.List.Type.M区分_社内外区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.社内外区分)
                Case NodeUI.List.Type.M区分_確約区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.確約区分, False)
                Case NodeUI.List.Type.M区分_刃型区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.刃型区分)
                Case NodeUI.List.Type.M区分_受注区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.受注区分, False)
                Case NodeUI.List.Type.M区分_フレキ機械種別区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.フレキ機械種別区分)
                Case NodeUI.List.Type.M区分_刃型形状区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.刃型形状区分)
                Case NodeUI.List.Type.M区分_新再版区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.新再版区分)
                Case NodeUI.List.Type.M区分_単位区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.単位区分, False)
                Case NodeUI.List.Type.M区分_仕入先指定区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.仕入先指定区分, False)
                Case NodeUI.List.Type.M区分_納入区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.納入区分)
                Case NodeUI.List.Type.M区分_支給区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.支給区分, False)
                Case NodeUI.List.Type.M区分_希望時間帯区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.希望時間帯区分)
                Case NodeUI.List.Type.M区分_完納区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.完納区分)
                Case NodeUI.List.Type.M区分_売上指示区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.売上指示区分, False)
                Case NodeUI.List.Type.M区分_売上指示区分運賃 : Return C区分_共通部品(NodeContents.Constant.CodeType.売上指示区分運賃, False)
                Case NodeUI.List.Type.M区分_巻取区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.巻取区分)
                Case NodeUI.List.Type.M区分_出し方向区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.出し方向区分)
                Case NodeUI.List.Type.M区分_スリッター区分 : Return C区分_共通部品(NodeContents.Constant.CodeType.スリッター区分)

                    'ｼｽﾃﾑ

                    'ﾏｽﾀ

                    'ﾄﾗﾝｻﾞｸｼｮﾝ

                    'その他

                Case Else : Return Nothing
            End Select
        End Function
#End Region

#Region "ｺﾝｽﾀﾝﾄ"
#Region "共通部品"
        '''========================================================================================
        ''' <summary>共通部品</summary>
        ''' <param name="TypeClass">
        ''' </param>
        ''' <returns>
        ''' </returns>
        '''========================================================================================
        Private Function C区分_共通部品(ByVal TypeClass As String, Optional ByVal InCode As Boolean = True) As DataTable
            '----------------------------------------------------------------------
            ' 返却 ﾃﾞｰﾀﾃｰﾌﾞﾙ
            '----------------------------------------------------------------------
            Dim dat As New DataTable

            '----------------------------------------------------------------------
            ' ｷｰが空白なら即終了
            '----------------------------------------------------------------------
            Select Case True
                Case TypeClass = ""
                    Return dat
            End Select

            '----------------------------------------------------------------------
            ' 事前準備
            '----------------------------------------------------------------------
            dat.Columns.Add(COLNAME_LIST_DISPLAY)
            dat.Columns.Add(COLNAME_LIST_VALUE)

            '----------------------------------------------------------------------
            ' 名称類 取得
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M区分TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M区分DataTable
            Dim qry As New Collection

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.区分種別Column.ColumnName, TypeClass, BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            For Each row As DataRow In tbl.Rows
                Dim row追加 As DataRow = dat.NewRow

                If InCode Then
                    row追加(COLNAME_LIST_DISPLAY) = row.Item(tbl.区分CDColumn.ColumnName) & ":" & row.Item(tbl.区分名Column.ColumnName)
                Else
                    row追加(COLNAME_LIST_DISPLAY) = row.Item(tbl.区分名Column.ColumnName)
                End If
                row追加(COLNAME_LIST_VALUE) = row.Item(tbl.区分CDColumn.ColumnName)

                dat.Rows.Add(row追加)
            Next

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return dat
        End Function
#End Region
#End Region
    End Class
End Namespace
