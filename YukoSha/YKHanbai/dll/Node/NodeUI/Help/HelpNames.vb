Namespace Help
    Public Class Names
#Region "実行"
        Public Function Execute(ByVal HelpType As NodeUI.Help.Type, ByVal Value As String) As String
            Select Case HelpType
                'ｺｰﾄﾞﾏｽﾀ
                Case NodeUI.Help.Type.M区分_フラグ : Return C区分_共通部品(Value, NodeContents.Constant.CodeType.フラグ)
                Case NodeUI.Help.Type.M区分_重要度 : Return C区分_共通部品(Value, NodeContents.Constant.CodeType.重要度)
                Case NodeUI.Help.Type.M区分_消費税区分 : Return C区分_共通部品(Value, NodeContents.Constant.CodeType.消費税区分)
                Case NodeUI.Help.Type.M区分_請求書発行区分 : Return C区分_共通部品(Value, NodeContents.Constant.CodeType.請求書発行区分)
                Case NodeUI.Help.Type.M区分_回収方法 : Return C区分_共通部品(Value, NodeContents.Constant.CodeType.回収方法)
                Case NodeUI.Help.Type.M区分_定番品区分 : Return C区分_共通部品(Value, NodeContents.Constant.CodeType.定番品区分)
                Case NodeUI.Help.Type.M区分_在庫区分 : Return C区分_共通部品(Value, NodeContents.Constant.CodeType.在庫区分)
                Case NodeUI.Help.Type.M区分_取引先区分 : Return C区分_共通部品(Value, NodeContents.Constant.CodeType.取引先区分)
                Case NodeUI.Help.Type.M区分_新再版区分 : Return C区分_共通部品(Value, NodeContents.Constant.CodeType.新再版区分)
                Case NodeUI.Help.Type.M区分_単位区分 : Return C区分_共通部品(Value, NodeContents.Constant.CodeType.単位区分)
                Case NodeUI.Help.Type.M区分_仕入先指定区分 : Return C区分_共通部品(Value, NodeContents.Constant.CodeType.仕入先指定区分)
                Case NodeUI.Help.Type.M区分_納入区分 : Return C区分_共通部品(Value, NodeContents.Constant.CodeType.納入区分)
                Case NodeUI.Help.Type.M区分_支給区分 : Return C区分_共通部品(Value, NodeContents.Constant.CodeType.支給区分)
                Case NodeUI.Help.Type.M区分_希望時間帯区分 : Return C区分_共通部品(Value, NodeContents.Constant.CodeType.希望時間帯区分)
                Case NodeUI.Help.Type.M区分_完納区分 : Return C区分_共通部品(Value, NodeContents.Constant.CodeType.完納区分)
                Case NodeUI.Help.Type.M区分_売上指示区分 : Return C区分_共通部品(Value, NodeContents.Constant.CodeType.売上指示区分)
                Case NodeUI.Help.Type.M区分_売上指示区分運賃 : Return C区分_共通部品(Value, NodeContents.Constant.CodeType.売上指示区分運賃)

                    'ｼｽﾃﾑ

                    'ﾏｽﾀ
                Case NodeUI.Help.Type.M糊 : Return M糊(Value)
                Case NodeUI.Help.Type.M紙 : Return M紙(Value)
                Case NodeUI.Help.Type.M得意先 : Return M得意先(Value)
                Case NodeUI.Help.Type.M得意先個人 : Return M得意先個人(Value)
                Case NodeUI.Help.Type.M出荷先 : Return M出荷先(Value)
                Case NodeUI.Help.Type.M仕入先 : Return M仕入先(Value)
                Case NodeUI.Help.Type.M取引先 : Return M取引先(Value)
                Case NodeUI.Help.Type.M機械 : Return M機械(Value)
                Case NodeUI.Help.Type.M担当者 : Return M担当者(Value)
                Case NodeUI.Help.Type.M印刷場所 : Return M印刷場所(Value)
                Case NodeUI.Help.Type.M印刷機械種別 : Return M印刷機械種別(Value)
                Case NodeUI.Help.Type.M締日情報 : Return M締日情報(Value)
                Case NodeUI.Help.Type.M売伝パターン : Return M売伝パターン(Value)
                Case NodeUI.Help.Type.M台紙 : Return M台紙(Value)
                Case NodeUI.Help.Type.M品名 : Return M品名(Value)
                Case NodeUI.Help.Type.Mヤマト区分 : Return Mヤマト区分(Value)
                Case NodeUI.Help.Type.Mヤマト種別 : Return Mヤマト種別(Value)

                    'ﾄﾗﾝｻﾞｸｼｮﾝ

                    'その他

                Case Else : Return Nothing
            End Select
        End Function
#End Region

#Region "返却"
        Private Shared Function ReturnValue(ByVal value() As String) As String
            Dim strReturn As String = ""
            Dim strDelim As String = ""

            For i As Integer = 0 To value.Length - 1
                strReturn &= strDelim & value(i)
                strDelim = vbTab
            Next

            Return strReturn
        End Function
#End Region

#Region "ｺﾝｽﾀﾝﾄ"
#Region "共通部品"
        '''========================================================================================
        ''' <summary>共通部品</summary>
        ''' <param name="Value">
        '''  0(区分種別)
        ''' </param>
        ''' <returns>
        '''  0(区分名)
        ''' </returns>
        '''========================================================================================
        Private Function C区分_共通部品(ByVal Value As String, ByVal TypeClass As String) As String
            '----------------------------------------------------------------------
            ' 返却 配列
            '----------------------------------------------------------------------
            Dim strReturn(0) As String

            '----------------------------------------------------------------------
            ' ｷｰが空白なら即終了
            '----------------------------------------------------------------------
            Select Case True
                Case Value.Split(vbTab)(0) = ""
                    Return ReturnValue(strReturn)
            End Select

            '----------------------------------------------------------------------
            ' 事前準備
            '----------------------------------------------------------------------
            Dim strCodeValue As String = BaseCore.Common.Text.Nz(Value.Split(vbTab)(0).ToString, "")

            '----------------------------------------------------------------------
            ' 名称類 取得
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M区分TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M区分DataTable
            Dim qry As New Collection

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.区分種別Column.ColumnName, TypeClass, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.区分CDColumn.ColumnName, strCodeValue, BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            If tbl.Count > 0 Then
                strReturn(0) = tbl(0).Item(tbl.区分名Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return ReturnValue(strReturn)
        End Function
#End Region
#End Region

#Region "ﾏｽﾀ"
#Region "M糊"
        '''========================================================================================
        ''' <summary>M糊</summary>
        ''' <param name="Value">
        '''  0(糊CD)
        ''' </param>
        ''' <returns>
        '''  0(糊名)
        ''' </returns>
        '''========================================================================================
        Private Shared Function M糊(ByVal Value As String) As String
            '----------------------------------------------------------------------
            ' 返却 配列
            '----------------------------------------------------------------------
            Dim strReturn(0) As String

            '----------------------------------------------------------------------
            ' ｷｰが空白なら即終了
            '----------------------------------------------------------------------
            Select Case True
                Case Value.Split(vbTab)(0) = ""
                    Return ReturnValue(strReturn)
            End Select

            '----------------------------------------------------------------------
            ' 名称類 取得
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0糊TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0糊DataTable
            Dim qry As New Collection

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.糊CDColumn.ColumnName, Value.Split(vbTab)(0), BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            If tbl.Count > 0 Then
                strReturn(0) = tbl(0).Item(tbl.糊名Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return ReturnValue(strReturn)
        End Function
#End Region

#Region "M紙"
        '''========================================================================================
        ''' <summary>M紙</summary>
        ''' <param name="Value">
        '''  0(紙CD)
        ''' </param>
        ''' <returns>
        '''  0(紙名)
        ''' </returns>
        '''========================================================================================
        Private Shared Function M紙(ByVal Value As String) As String
            '----------------------------------------------------------------------
            ' 返却 配列
            '----------------------------------------------------------------------
            Dim strReturn(0) As String

            '----------------------------------------------------------------------
            ' ｷｰが空白なら即終了
            '----------------------------------------------------------------------
            Select Case True
                Case Value.Split(vbTab)(0) = ""
                    Return ReturnValue(strReturn)
            End Select

            '----------------------------------------------------------------------
            ' 名称類 取得
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0紙TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0紙DataTable
            Dim qry As New Collection

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.紙CDColumn.ColumnName, Value.Split(vbTab)(0), BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            If tbl.Count > 0 Then
                strReturn(0) = tbl(0).Item(tbl.紙名Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return ReturnValue(strReturn)
        End Function
#End Region

#Region "M得意先"
        '''========================================================================================
        ''' <summary>M得意先</summary>
        ''' <param name="Value">
        '''  0(得意先CD)
        ''' </param>
        ''' <returns>
        '''  0(得意先名)
        ''' </returns>
        '''========================================================================================
        Private Shared Function M得意先(ByVal Value As String) As String
            '----------------------------------------------------------------------
            ' 返却 配列
            '----------------------------------------------------------------------
            Dim strReturn(0) As String

            '----------------------------------------------------------------------
            ' ｷｰが空白なら即終了
            '----------------------------------------------------------------------
            Select Case True
                Case Value.Split(vbTab)(0) = ""
                    Return ReturnValue(strReturn)
            End Select

            '----------------------------------------------------------------------
            ' 名称類 取得
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0得意先TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0得意先DataTable
            Dim qry As New Collection

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Value.Split(vbTab)(0), BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            If tbl.Count > 0 Then
                strReturn(0) = tbl(0).Item(tbl.得意先名Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return ReturnValue(strReturn)
        End Function
#End Region

#Region "M得意先個人"
        '''========================================================================================
        ''' <summary>M得意先個人</summary>
        ''' <param name="Value">
        '''  0(得意先CD)
        ''' </param>
        ''' <returns>
        '''  0(得意先名)
        ''' </returns>
        '''========================================================================================
        Private Shared Function M得意先個人(ByVal Value As String) As String
            '----------------------------------------------------------------------
            ' 返却 配列
            '----------------------------------------------------------------------
            Dim strReturn(0) As String

            '----------------------------------------------------------------------
            ' ｷｰが空白なら即終了
            '----------------------------------------------------------------------
            Select Case True
                Case Value.Split(vbTab)(0) = ""
                    Return ReturnValue(strReturn)
            End Select

            '----------------------------------------------------------------------
            ' 名称類 取得
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0得意先個人TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0得意先個人DataTable
            Dim qry As New Collection

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Value.Split(vbTab)(0), BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            If tbl.Count > 0 Then
                strReturn(0) = tbl(0).Item(tbl.得意先名Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return ReturnValue(strReturn)
        End Function
#End Region

#Region "M出荷先"
        '''========================================================================================
        ''' <summary>M出荷先</summary>
        ''' <param name="Value">
        '''  0(得意先CD)
        '''  1(出荷先CD)
        ''' </param>
        ''' <returns>
        '''  0(出荷先名)
        ''' </returns>
        '''========================================================================================
        Private Shared Function M出荷先(ByVal Value As String) As String
            '----------------------------------------------------------------------
            ' 返却 配列
            '----------------------------------------------------------------------
            Dim strReturn(0) As String

            '----------------------------------------------------------------------
            ' ｷｰが空白なら即終了
            '----------------------------------------------------------------------
            Select Case True
                Case Value.Split(vbTab)(0) = "", Value.Split(vbTab)(1) = ""
                    Return ReturnValue(strReturn)
            End Select

            '----------------------------------------------------------------------
            ' 名称類 取得
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0出荷先TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0出荷先DataTable
            Dim qry As New Collection

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Value.Split(vbTab)(0), BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.出荷先CDColumn.ColumnName, Value.Split(vbTab)(1), BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            If tbl.Count > 0 Then
                strReturn(0) = tbl(0).Item(tbl.出荷先名Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return ReturnValue(strReturn)
        End Function
#End Region

#Region "M機械"
        '''========================================================================================
        ''' <summary>M機械</summary>
        ''' <param name="Value">
        '''  0(機械CD)
        ''' </param>
        ''' <returns>
        '''  0(機械名)
        ''' </returns>
        '''========================================================================================
        Private Shared Function M機械(ByVal Value As String) As String
            '----------------------------------------------------------------------
            ' 返却 配列
            '----------------------------------------------------------------------
            Dim strReturn(0) As String

            '----------------------------------------------------------------------
            ' ｷｰが空白なら即終了
            '----------------------------------------------------------------------
            Select Case True
                Case Value.Split(vbTab)(0) = ""
                    Return ReturnValue(strReturn)
            End Select

            '----------------------------------------------------------------------
            ' 名称類 取得
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0機械TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0機械DataTable
            Dim qry As New Collection

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.機械CDColumn.ColumnName, Value.Split(vbTab)(0), BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            If tbl.Count > 0 Then
                strReturn(0) = tbl(0).Item(tbl.機械名Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return ReturnValue(strReturn)
        End Function
#End Region

#Region "M担当者"
        '''========================================================================================
        ''' <summary>M担当者</summary>
        ''' <param name="Value">
        '''  0(担当者CD)
        ''' </param>
        ''' <returns>
        '''  0(担当者名)
        ''' </returns>
        '''========================================================================================
        Private Shared Function M担当者(ByVal Value As String) As String
            '----------------------------------------------------------------------
            ' 返却 配列
            '----------------------------------------------------------------------
            Dim strReturn(0) As String

            '----------------------------------------------------------------------
            ' ｷｰが空白なら即終了
            '----------------------------------------------------------------------
            Select Case True
                Case Value.Split(vbTab)(0) = ""
                    Return ReturnValue(strReturn)
            End Select

            '----------------------------------------------------------------------
            ' 名称類 取得
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0担当者TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0担当者DataTable
            Dim qry As New Collection

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.担当者CDColumn.ColumnName, Value.Split(vbTab)(0), BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            If tbl.Count > 0 Then
                strReturn(0) = tbl(0).Item(tbl.担当者名Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return ReturnValue(strReturn)
        End Function
#End Region

#Region "M印刷場所"
        '''========================================================================================
        ''' <summary>M印刷場所</summary>
        ''' <param name="Value">
        '''  0(印刷場所CD)
        ''' </param>
        ''' <returns>
        '''  0(印刷場所名)
        ''' </returns>
        '''========================================================================================
        Private Shared Function M印刷場所(ByVal Value As String) As String
            '----------------------------------------------------------------------
            ' 返却 配列
            '----------------------------------------------------------------------
            Dim strReturn(0) As String

            '----------------------------------------------------------------------
            ' ｷｰが空白なら即終了
            '----------------------------------------------------------------------
            Select Case True
                Case Value.Split(vbTab)(0) = ""
                    Return ReturnValue(strReturn)
            End Select

            '----------------------------------------------------------------------
            ' 名称類 取得
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0印刷場所TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0印刷場所DataTable
            Dim qry As New Collection

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.印刷場所CDColumn.ColumnName, Value.Split(vbTab)(0), BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            If tbl.Count > 0 Then
                strReturn(0) = tbl(0).Item(tbl.印刷場所名Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return ReturnValue(strReturn)
        End Function
#End Region

#Region "M印刷機械種別"
        '''========================================================================================
        ''' <summary>M印刷機械種別</summary>
        ''' <param name="Value">
        '''  0(印刷機械種別CD)
        ''' </param>
        ''' <returns>
        '''  0(印刷機械種別名)
        ''' </returns>
        '''========================================================================================
        Private Shared Function M印刷機械種別(ByVal Value As String) As String
            '----------------------------------------------------------------------
            ' 返却 配列
            '----------------------------------------------------------------------
            Dim strReturn(0) As String

            '----------------------------------------------------------------------
            ' ｷｰが空白なら即終了
            '----------------------------------------------------------------------
            Select Case True
                Case Value.Split(vbTab)(0) = ""
                    Return ReturnValue(strReturn)
            End Select

            '----------------------------------------------------------------------
            ' 名称類 取得
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0印刷機械種別TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0印刷機械種別DataTable
            Dim qry As New Collection

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.印刷機械種別CDColumn.ColumnName, Value.Split(vbTab)(0), BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            If tbl.Count > 0 Then
                strReturn(0) = tbl(0).Item(tbl.印刷機械種別名Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return ReturnValue(strReturn)
        End Function
#End Region

#Region "M締日情報"
        '''========================================================================================
        ''' <summary>M締日情報</summary>
        ''' <param name="Value">
        '''  0(締日)
        ''' </param>
        ''' <returns>
        '''  0(今回請求年月日)
        ''' </returns>
        '''========================================================================================
        Private Shared Function M締日情報(ByVal Value As String) As String
            '----------------------------------------------------------------------
            ' 返却 配列
            '----------------------------------------------------------------------
            Dim strReturn(0) As String

            '----------------------------------------------------------------------
            ' ｷｰが空白なら即終了
            '----------------------------------------------------------------------
            Select Case True
                Case Value.Split(vbTab)(0) = ""
                    Return ReturnValue(strReturn)
            End Select

            '----------------------------------------------------------------------
            ' 名称類 取得
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0締日情報TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0締日情報DataTable
            Dim qry As New Collection

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.締日Column.ColumnName, Value.Split(vbTab)(0), BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            If tbl.Count > 0 Then
                strReturn(0) = tbl(0).Item(tbl.請求日付Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return ReturnValue(strReturn)
        End Function
#End Region

#Region "M売伝ﾊﾟﾀｰﾝ"
        '''========================================================================================
        ''' <summary>M売伝ﾊﾟﾀｰﾝ</summary>
        ''' <param name="Value">
        '''  0(パターンCD)
        ''' </param>
        ''' <returns>
        '''  0(売伝パターン名)
        ''' </returns>
        '''========================================================================================
        Private Shared Function M売伝パターン(ByVal Value As String) As String
            '----------------------------------------------------------------------
            ' 返却 配列
            '----------------------------------------------------------------------
            Dim strReturn(0) As String

            '----------------------------------------------------------------------
            ' ｷｰが空白なら即終了
            '----------------------------------------------------------------------
            Select Case True
                Case Value.Split(vbTab)(0) = ""
                    Return ReturnValue(strReturn)
            End Select

            '----------------------------------------------------------------------
            ' 名称類 取得
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M売伝パターンTableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M売伝パターンDataTable
            Dim qry As New Collection

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.パターンCDColumn.ColumnName, Value.Split(vbTab)(0), BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            If tbl.Count > 0 Then
                strReturn(0) = tbl(0).Item(tbl.売伝パターン名Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return ReturnValue(strReturn)
        End Function
#End Region

#Region "M台紙"
        '''========================================================================================
        ''' <summary>M台紙</summary>
        ''' <param name="Value">
        '''  0(台紙CD)
        ''' </param>
        ''' <returns>
        '''  0(台紙名)
        ''' </returns>
        '''========================================================================================
        Private Shared Function M台紙(ByVal Value As String) As String
            '----------------------------------------------------------------------
            ' 返却 配列
            '----------------------------------------------------------------------
            Dim strReturn(0) As String

            '----------------------------------------------------------------------
            ' ｷｰが空白なら即終了
            '----------------------------------------------------------------------
            Select Case True
                Case Value.Split(vbTab)(0) = ""
                    Return ReturnValue(strReturn)
            End Select

            '----------------------------------------------------------------------
            ' 名称類 取得
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0台紙TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0台紙DataTable
            Dim qry As New Collection

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.台紙CDColumn.ColumnName, Value.Split(vbTab)(0), BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            If tbl.Count > 0 Then
                strReturn(0) = tbl(0).Item(tbl.台紙名Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return ReturnValue(strReturn)
        End Function
#End Region

#Region "M仕入先"
        '''========================================================================================
        ''' <summary>M仕入先</summary>
        ''' <param name="Value">
        '''  0(仕入先CD)
        ''' </param>
        ''' <returns>
        '''  0(仕入先名)
        ''' </returns>
        '''========================================================================================
        Private Shared Function M仕入先(ByVal Value As String) As String
            '----------------------------------------------------------------------
            ' 返却 配列
            '----------------------------------------------------------------------
            Dim strReturn(0) As String

            '----------------------------------------------------------------------
            ' ｷｰが空白なら即終了
            '----------------------------------------------------------------------
            Select Case True
                Case Value.Split(vbTab)(0) = ""
                    Return ReturnValue(strReturn)
            End Select

            '----------------------------------------------------------------------
            ' 名称類 取得
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0仕入先TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0仕入先DataTable
            Dim qry As New Collection

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.仕入先CDColumn.ColumnName, Value.Split(vbTab)(0), BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            If tbl.Count > 0 Then
                strReturn(0) = tbl(0).Item(tbl.仕入先名Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return ReturnValue(strReturn)
        End Function
#End Region

#Region "M取引先"
        '''========================================================================================
        ''' <summary>M取引先</summary>
        ''' <param name="Value">
        '''  0(取引先CD)
        '''  1(取引先区分)
        ''' </param>
        ''' <returns>
        '''  0(取引先名)
        ''' </returns>
        '''========================================================================================
        Private Shared Function M取引先(ByVal Value As String) As String
            '----------------------------------------------------------------------
            ' 返却 配列
            '----------------------------------------------------------------------
            Dim strReturn(0) As String

            '----------------------------------------------------------------------
            ' ｷｰが空白なら即終了
            '----------------------------------------------------------------------
            Select Case True
                Case Value.Split(vbTab)(0) = "", Value.Split(vbTab)(1) = ""
                    Return ReturnValue(strReturn)
            End Select

            '----------------------------------------------------------------------
            ' 名称類 取得
            '----------------------------------------------------------------------
            Select Case Value.Split(vbTab)(1)
                Case NodeContents.Constant.CodeValue.取引先区分.得意先
                    Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0得意先TableAdapter
                    Dim tbl As New NodeDatabase.DataSetView.V0得意先DataTable
                    Dim qry As New Collection

                    qry.Clear()
                    qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Value.Split(vbTab)(0), BaseDatabase.Contents.Compare.Equal))
                    tbl = ada.SelectByCommon(qry)

                    If tbl.Count > 0 Then
                        strReturn(0) = tbl(0).Item(tbl.得意先名Column.ColumnName)
                    End If

                Case NodeContents.Constant.CodeValue.取引先区分.仕入先
                    Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0仕入先TableAdapter
                    Dim tbl As New NodeDatabase.DataSetView.V0仕入先DataTable
                    Dim qry As New Collection

                    qry.Clear()
                    qry.Add(New BaseDatabase.Condition(tbl.仕入先CDColumn.ColumnName, Value.Split(vbTab)(0), BaseDatabase.Contents.Compare.Equal))
                    tbl = ada.SelectByCommon(qry)

                    If tbl.Count > 0 Then
                        strReturn(0) = tbl(0).Item(tbl.仕入先名Column.ColumnName)
                    End If
            End Select

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return ReturnValue(strReturn)
        End Function
#End Region

#Region "M品名"
        '''========================================================================================
        ''' <summary>M品名</summary>
        ''' <param name="Value">
        '''  0(品名CD)
        ''' </param>
        ''' <returns>
        '''  0(品名)
        ''' </returns>
        '''========================================================================================
        Private Shared Function M品名(ByVal Value As String) As String
            '----------------------------------------------------------------------
            ' 返却 配列
            '----------------------------------------------------------------------
            Dim strReturn(0) As String

            '----------------------------------------------------------------------
            ' ｷｰが空白なら即終了
            '----------------------------------------------------------------------
            Select Case True
                Case Value.Split(vbTab)(0) = ""
                    Return ReturnValue(strReturn)
            End Select

            '----------------------------------------------------------------------
            ' 名称類 取得
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0品名TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0品名DataTable
            Dim qry As New Collection

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.品名CDColumn.ColumnName, Value.Split(vbTab)(0), BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            If tbl.Count > 0 Then
                strReturn(0) = tbl(0).Item(tbl.品名Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return ReturnValue(strReturn)
        End Function
#End Region

#Region "Mヤマト区分"
        '''========================================================================================
        ''' <summary>Mヤマト区分</summary>
        ''' <param name="Value">
        '''  0(ヤマトデータ区分CD)
        ''' </param>
        ''' <returns>
        '''  0(ヤマトデータ区分名)
        ''' </returns>
        '''========================================================================================
        Private Shared Function Mヤマト区分(ByVal Value As String) As String
            '----------------------------------------------------------------------
            ' 返却 配列
            '----------------------------------------------------------------------
            Dim strReturn(0) As String

            '----------------------------------------------------------------------
            ' ｷｰが空白なら即終了
            '----------------------------------------------------------------------
            Select Case True
                Case Value.Split(vbTab)(0) = ""
                    Return ReturnValue(strReturn)
            End Select

            '----------------------------------------------------------------------
            ' 名称類 取得
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0ヤマト区分TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0ヤマト区分DataTable
            Dim qry As New Collection

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.ヤマト区分Column.ColumnName, Value.Split(vbTab)(0), BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            If tbl.Count > 0 Then
                strReturn(0) = tbl(0).Item(tbl.ヤマト区分名Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return ReturnValue(strReturn)
        End Function
#End Region


#Region "Mヤマト種別"
        '''========================================================================================
        ''' <summary>Mヤマト種別</summary>
        ''' <param name="Value">
        '''  0(ﾃﾞｰﾀ区分)
        '''  1(種別区分)
        ''' </param>
        ''' <returns>
        '''  0(種別名)
        ''' </returns>
        '''========================================================================================
        Private Shared Function Mヤマト種別(ByVal Value As String) As String
            '----------------------------------------------------------------------
            ' 返却 配列
            '----------------------------------------------------------------------
            Dim strReturn(0) As String

            '----------------------------------------------------------------------
            ' ｷｰが空白なら即終了
            '----------------------------------------------------------------------
            Select Case True
                Case Value.Split(vbTab)(0) = "", Value.Split(vbTab)(1) = ""
                    Return ReturnValue(strReturn)
            End Select

            '----------------------------------------------------------------------
            ' 名称類 取得
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0ヤマト種別TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0ヤマト種別DataTable
            Dim qry As New Collection

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.ヤマト区分Column.ColumnName, Value.Split(vbTab)(0), BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.ヤマト種別Column.ColumnName, Value.Split(vbTab)(1), BaseDatabase.Contents.Compare.Equal))
            tbl = ada.SelectByCommon(qry)

            If tbl.Count > 0 Then
                strReturn(0) = tbl(0).Item(tbl.ヤマト種別名Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return ReturnValue(strReturn)
        End Function
#End Region

#End Region
    End Class
End Namespace
