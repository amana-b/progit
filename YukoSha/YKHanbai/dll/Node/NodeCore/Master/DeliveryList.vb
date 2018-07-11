Namespace Frame.Master
    Partial Public Class DeliveryList
        Inherits NodeCore.Common.Frame

#Region "ﾌｨｰﾙﾄﾞ定義"
        Public Class Header
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 得意先CDF As BaseCore.Common.Field.ItemData
            Public 得意先CDT As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0出荷先DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.得意先CDF = New BaseCore.Common.Field.ItemData(tbl.得意先CDColumn)
                Me.得意先CDT = New BaseCore.Common.Field.ItemData(tbl.得意先CDColumn)
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
                Me.Fields.Header.得意先CDF.Value = Nothing
                Me.Fields.Header.得意先CDT.Value = Nothing
            End If

            '----------------------------------------------------------------------
            ' ﾃﾞｰﾀ部ｸﾘｱ
            '----------------------------------------------------------------------
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
            Dim tbl As New NodeDatabase.DataSetView.V0出荷先DataTable
            tbl = Me.SelectTable()

            If tbl.Count = 0 Then
                Me.LastError = "指定された条件に合致するデータはありません。"
                Return False
            End If

            '----------------------------------------------------------------------
            ' ﾚﾎﾟｰﾄ生成
            '----------------------------------------------------------------------
            Dim Report As New NodeReport.DeliveryList

            Report.Document.Name = "出荷先リスト"
            Report.Document.Printer.PrinterName = ""
            Report.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
            Report.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
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
            '----------------------------------------------------------------------
            ' 印刷ﾃﾞｰﾀ
            '----------------------------------------------------------------------
            Dim tbl As New NodeDatabase.DataSetView.V0出荷先DataTable
            tbl = Me.SelectTable()

            If tbl.Count = 0 Then
                Me.LastError = "指定された条件に合致するデータはありません。"
                Return False
            End If

            '----------------------------------------------------------------------
            ' ﾚﾎﾟｰﾄ生成
            '----------------------------------------------------------------------
            Dim Report As New NodeReport.DeliveryList

            Report.Document.Name = "出荷先リスト"
            Report.Document.Printer.PrinterName = ""
            Report.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
            Report.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
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
        Private Function SelectTable() As NodeDatabase.DataSetView.V0出荷先DataTable
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0出荷先TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0出荷先DataTable
            Dim qry As New Collection

            Dim strSort As String = ""
            Dim strDelim As String = ""

            Dim strKeyNew As String = ""
            Dim strKeyOld As String = ""

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Me.Fields.Header.得意先CDF.Value, BaseDatabase.Contents.Compare.GreaterEqual, BaseDatabase.Contents.EmptyHandle.Skip))
            qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Me.Fields.Header.得意先CDT.Value, BaseDatabase.Contents.Compare.LessEqual, BaseDatabase.Contents.EmptyHandle.Skip))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            strSort &= strDelim & tbl.得意先CDColumn.ColumnName & "  ASC" : strDelim = ","
            strSort &= strDelim & tbl.出荷先CDColumn.ColumnName & " DESC" : strDelim = ","
            tbl = ada.SelectByCommon(qry, strSort)

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return tbl
        End Function
#End Region
    End Class
End Namespace
