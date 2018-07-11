Namespace Frame.Master
    Partial Public Class PaperPriList
        Inherits NodeCore.Common.Frame

#Region "ﾌｨｰﾙﾄﾞ定義"
        Public Class Header
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 仕入先CDF As BaseCore.Common.Field.ItemData
            Public 仕入先CDT As BaseCore.Common.Field.ItemData
            Public 社内用紙CDF As BaseCore.Common.Field.ItemData
            Public 社内用紙CDT As BaseCore.Common.Field.ItemData
            Public 社内用糊CDF As BaseCore.Common.Field.ItemData
            Public 社内用糊CDT As BaseCore.Common.Field.ItemData
            Public 社内用台紙CDF As BaseCore.Common.Field.ItemData
            Public 社内用台紙CDT As BaseCore.Common.Field.ItemData

            Public 平米単価 As BaseCore.Common.Field.ItemData
            Public m単価 As BaseCore.Common.Field.ItemData
            Public 両方 As BaseCore.Common.Field.ItemData
            Public 発注単価 As BaseCore.Common.Field.ItemData
            Public 社内単価 As BaseCore.Common.Field.ItemData
            Public 仕入先ｺｰﾄﾞ順 As BaseCore.Common.Field.ItemData
            Public 紙・糊・台紙・ｺｰﾄﾞ順 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0紙価格DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.仕入先CDF = New BaseCore.Common.Field.ItemData(tbl.仕入先CDColumn)
                Me.仕入先CDT = New BaseCore.Common.Field.ItemData(tbl.仕入先CDColumn)
                Me.社内用紙CDF = New BaseCore.Common.Field.ItemData(tbl.社内用紙CDColumn)
                Me.社内用紙CDT = New BaseCore.Common.Field.ItemData(tbl.社内用紙CDColumn)
                Me.社内用糊CDF = New BaseCore.Common.Field.ItemData(tbl.社内用糊CDColumn)
                Me.社内用糊CDT = New BaseCore.Common.Field.ItemData(tbl.社内用糊CDColumn)
                Me.社内用台紙CDF = New BaseCore.Common.Field.ItemData(tbl.社内用台紙CDColumn)
                Me.社内用台紙CDT = New BaseCore.Common.Field.ItemData(tbl.社内用台紙CDColumn)

                Me.平米単価 = New BaseCore.Common.Field.ItemData("㎡単価", TypeCode.String, 1)
                Me.m単価 = New BaseCore.Common.Field.ItemData("m単価", TypeCode.String, 1)
                Me.両方 = New BaseCore.Common.Field.ItemData("両方", TypeCode.String, 1)
                Me.発注単価 = New BaseCore.Common.Field.ItemData("発注単価", TypeCode.String, 1)
                Me.社内単価 = New BaseCore.Common.Field.ItemData("社内単価", TypeCode.String, 1)
                Me.仕入先ｺｰﾄﾞ順 = New BaseCore.Common.Field.ItemData("仕入先ｺｰﾄﾞ順", TypeCode.String, 1)
                Me.紙・糊・台紙・ｺｰﾄﾞ順 = New BaseCore.Common.Field.ItemData("紙・糊・台紙・ｺｰﾄﾞ順", TypeCode.String, 1)
            End Sub
        End Class

        Public Class Paramater
            Public Header As Header
        End Class

        '''========================================================================================
        ''' <summary>ﾍｯﾀﾞ</summary>
        '''========================================================================================
        Private _Fields As New Paramater
        Public Property Fields() As Paramater
            Get
                Return _Fields
            End Get

            Set(ByVal value As Paramater)
                _Fields = value
            End Set
        End Property
#End Region

#Region "ｺﾝｽﾄﾗｸﾀ"
        '''========================================================================================
        ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
        ''' <PARAM name="Security">ｾｷｭﾘﾃｨ ｸﾗｽ</PARAM>
        ''' <PARAM name="Config">ｺﾝﾌｨｸﾞ ｸﾗｽ</PARAM>
        '''========================================================================================
        Public Sub New(ByVal Security As NodeCore.Common.Security, ByVal Config As NodeCore.Common.Config)
            '----------------------------------------------------------------------
            ' ｾｷｭﾘﾃｨ 設定
            '----------------------------------------------------------------------
            MyBase.New(Security, Config)

            Me.Fields.Header = New Header(Config)
        End Sub
#End Region

#Region "Clear"
        '''========================================================================================
        ''' <SUMMARY>ｸﾘｱ</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Clear_Header(Optional ByVal KeyClear As Boolean = True) As Boolean
            '----------------------------------------------------------------------
            ' ｷｰ部ｸﾘｱ
            '----------------------------------------------------------------------
            If KeyClear Then
                Me.Fields.Header.仕入先CDF.Value = Nothing
                Me.Fields.Header.仕入先CDT.Value = Nothing
                Me.Fields.Header.社内用紙CDF.Value = Nothing
                Me.Fields.Header.社内用紙CDT.Value = Nothing
                Me.Fields.Header.社内用糊CDF.Value = Nothing
                Me.Fields.Header.社内用糊CDT.Value = Nothing
                Me.Fields.Header.社内用台紙CDF.Value = Nothing
                Me.Fields.Header.社内用台紙CDT.Value = Nothing
            End If

            '----------------------------------------------------------------------
            ' ﾃﾞｰﾀ部ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Fields.Header.平米単価.Value = NodeContents.Constant.CodeValue.フラグ.オン
            Me.Fields.Header.m単価.Value = NodeContents.Constant.CodeValue.フラグ.オフ
            Me.Fields.Header.両方.Value = NodeContents.Constant.CodeValue.フラグ.オフ

            Me.Fields.Header.発注単価.Value = NodeContents.Constant.CodeValue.フラグ.オン
            Me.Fields.Header.社内単価.Value = NodeContents.Constant.CodeValue.フラグ.オフ

            Me.Fields.Header.仕入先ｺｰﾄﾞ順.Value = NodeContents.Constant.CodeValue.フラグ.オン
            Me.Fields.Header.紙・糊・台紙・ｺｰﾄﾞ順.Value = NodeContents.Constant.CodeValue.フラグ.オフ

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "Execute(ﾌﾟﾚﾋﾞｭｰ)"
        '''========================================================================================
        ''' <SUMMARY>印刷</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Execute_Header() As Boolean
            '----------------------------------------------------------------------
            ' 印刷ﾃﾞｰﾀ
            '----------------------------------------------------------------------
            Dim tbl As New NodeDatabase.DataSetFunc.F0紙価格DataTable
            tbl = Me.SelectTable()

            If tbl.Count = 0 Then
                Me.LastError = "指定された条件に合致するデータはありません。"
                Return False
            End If

            '----------------------------------------------------------------------
            ' ﾚﾎﾟｰﾄ生成
            '----------------------------------------------------------------------
            Dim Report As New NodeReport.PaperPriList

            Report.Document.Printer.PrinterName = ""
            Report.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
            Report.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
            Report.DataSource = tbl
            Report.Run()

            Me.Report1 = Report    ' 画面側へ渡す

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "Execute1(直接印刷)"
        '''========================================================================================
        ''' <SUMMARY>印刷</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Execute1_Header() As Boolean
            ''----------------------------------------------------------------------
            '' 印刷ﾃﾞｰﾀ
            ''----------------------------------------------------------------------
            Dim tbl As New NodeDatabase.DataSetFunc.F0紙価格DataTable
            tbl = Me.SelectTable()

            If tbl.Count = 0 Then
                Me.LastError = "指定された条件に合致するデータはありません。"
                Return False
            End If

            '----------------------------------------------------------------------
            ' ﾚﾎﾟｰﾄ生成
            '----------------------------------------------------------------------
            Dim Report As New NodeReport.PaperPriList

            Report.Document.Printer.PrinterName = ""
            Report.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
            Report.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
            Report.DataSource = tbl
            Report.Run()
            Report.Document.Print(False, False, False)   ' 直接印刷

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "印刷ﾃﾞｰﾀ作成"
        '''========================================================================================
        ''' <SUMMARY>印刷ﾃﾞｰﾀ</SUMMARY>
        ''' <RETURNS>ﾃﾞｰﾀﾃｰﾌﾞﾙ</RETURNS>
        '''========================================================================================
        Private Function SelectTable() As NodeDatabase.DataSetFunc.F0紙価格DataTable
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetFuncTableAdapters.F0紙価格TableAdapter
            Dim tbl As New NodeDatabase.DataSetFunc.F0紙価格DataTable
            Dim qry As New Collection

            Dim strSort As String = ""
            Dim strDelim As String = ""

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.仕入先CDColumn.ColumnName, Me.Fields.Header.仕入先CDF.Value, BaseDatabase.Contents.Compare.GreaterEqual, BaseDatabase.Contents.EmptyHandle.Skip))
            qry.Add(New BaseDatabase.Condition(tbl.仕入先CDColumn.ColumnName, Me.Fields.Header.仕入先CDT.Value, BaseDatabase.Contents.Compare.LessEqual, BaseDatabase.Contents.EmptyHandle.Skip))
            qry.Add(New BaseDatabase.Condition(tbl.社内用紙CDColumn.ColumnName, Me.Fields.Header.社内用紙CDF.Value, BaseDatabase.Contents.Compare.GreaterEqual, BaseDatabase.Contents.EmptyHandle.Skip))
            qry.Add(New BaseDatabase.Condition(tbl.社内用紙CDColumn.ColumnName, Me.Fields.Header.社内用紙CDT.Value, BaseDatabase.Contents.Compare.LessEqual, BaseDatabase.Contents.EmptyHandle.Skip))
            qry.Add(New BaseDatabase.Condition(tbl.社内用糊CDColumn.ColumnName, Me.Fields.Header.社内用糊CDF.Value, BaseDatabase.Contents.Compare.GreaterEqual, BaseDatabase.Contents.EmptyHandle.Skip))
            qry.Add(New BaseDatabase.Condition(tbl.社内用糊CDColumn.ColumnName, Me.Fields.Header.社内用糊CDT.Value, BaseDatabase.Contents.Compare.LessEqual, BaseDatabase.Contents.EmptyHandle.Skip))
            qry.Add(New BaseDatabase.Condition(tbl.社内用台紙CDColumn.ColumnName, Me.Fields.Header.社内用台紙CDF.Value, BaseDatabase.Contents.Compare.GreaterEqual, BaseDatabase.Contents.EmptyHandle.Skip))
            qry.Add(New BaseDatabase.Condition(tbl.社内用台紙CDColumn.ColumnName, Me.Fields.Header.社内用台紙CDT.Value, BaseDatabase.Contents.Compare.LessEqual, BaseDatabase.Contents.EmptyHandle.Skip))

            'ﾍｯﾀﾞに表示する単価
            Select Case True
                Case Me.Fields.Header.発注単価.Value = NodeContents.Constant.CodeValue.フラグ.オン
                    qry.Add(New BaseDatabase.Condition(NodeDatabase.DataSetFuncTableAdapters.F0紙価格TableAdapter.Contents.価格単価, 0, BaseDatabase.Contents.Compare.Parameter))
                Case Me.Fields.Header.社内単価.Value = NodeContents.Constant.CodeValue.フラグ.オン
                    qry.Add(New BaseDatabase.Condition(NodeDatabase.DataSetFuncTableAdapters.F0紙価格TableAdapter.Contents.価格単価, 1, BaseDatabase.Contents.Compare.Parameter))
            End Select

            '㎡かｍか
            Select Case True
                Case Me.Fields.Header.平米単価.Value = NodeContents.Constant.CodeValue.フラグ.オン
                    qry.Add(New BaseDatabase.Condition(tbl.単位区分Column.ColumnName, 0, BaseDatabase.Contents.Compare.Equal, BaseDatabase.Contents.EmptyHandle.Skip))
                Case Me.Fields.Header.m単価.Value = NodeContents.Constant.CodeValue.フラグ.オン
                    qry.Add(New BaseDatabase.Condition(tbl.単位区分Column.ColumnName, 1, BaseDatabase.Contents.Compare.Equal, BaseDatabase.Contents.EmptyHandle.Skip))
            End Select

            'ｿｰﾄ
            Select Case True
                Case Me.Fields.Header.仕入先ｺｰﾄﾞ順.Value = NodeContents.Constant.CodeValue.フラグ.オン
                    strSort &= strDelim & tbl.仕入先CDColumn.ColumnName & " ASC" : strDelim = ","
                    tbl = ada.SelectByCommon(qry, strSort)
                Case Me.Fields.Header.紙・糊・台紙・ｺｰﾄﾞ順.Value = NodeContents.Constant.CodeValue.フラグ.オン
                    strSort &= strDelim & tbl.社内用紙CDColumn.ColumnName & " ASC" : strDelim = ","
                    strSort &= strDelim & tbl.社内用糊CDColumn.ColumnName & " ASC" : strDelim = ","
                    strSort &= strDelim & tbl.社内用台紙CDColumn.ColumnName & " ASC" : strDelim = ","
                    strSort &= strDelim & tbl.仕入先CDColumn.ColumnName & " ASC" : strDelim = ","
                    tbl = ada.SelectByCommon(qry, strSort)
            End Select

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return tbl
        End Function
#End Region
    End Class
End Namespace
