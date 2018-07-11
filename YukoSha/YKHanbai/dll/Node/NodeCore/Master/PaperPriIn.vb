Namespace Frame.Master
    Partial Public Class PaperPriIn
        Inherits NodeCore.Common.Frame

#Region "ﾌｨｰﾙﾄﾞ定義"
        Public Class Header
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 仕入先CD As BaseCore.Common.Field.ItemData
            Public 社内用紙CD As BaseCore.Common.Field.ItemData
            Public 社内用糊CD As BaseCore.Common.Field.ItemData
            Public 社内用台紙CD As BaseCore.Common.Field.ItemData
            Public 単位区分 As BaseCore.Common.Field.ItemData
            Public 発注用紙CD As BaseCore.Common.Field.ItemData
            Public 発注用糊CD As BaseCore.Common.Field.ItemData
            Public 発注用台紙CD As BaseCore.Common.Field.ItemData
            Public 社内単価 As BaseCore.Common.Field.ItemData
            Public 発注単価 As BaseCore.Common.Field.ItemData

            Public 処理登録 As BaseCore.Common.Field.ItemData
            Public 処理修正 As BaseCore.Common.Field.ItemData
            Public 処理削除 As BaseCore.Common.Field.ItemData

            Public 仕入先名 As BaseCore.Common.Field.ItemData
            Public 社内用紙名 As BaseCore.Common.Field.ItemData
            Public 社内用糊名 As BaseCore.Common.Field.ItemData
            Public 社内用台紙名 As BaseCore.Common.Field.ItemData
            Public 発注用紙名 As BaseCore.Common.Field.ItemData
            Public 発注用糊名 As BaseCore.Common.Field.ItemData
            Public 発注用台紙名 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0紙価格DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.仕入先CD = New BaseCore.Common.Field.ItemData(tbl.仕入先CDColumn)
                Me.社内用紙CD = New BaseCore.Common.Field.ItemData(tbl.社内用紙CDColumn)
                Me.社内用糊CD = New BaseCore.Common.Field.ItemData(tbl.社内用糊CDColumn)
                Me.社内用台紙CD = New BaseCore.Common.Field.ItemData(tbl.社内用台紙CDColumn)
                Me.単位区分 = New BaseCore.Common.Field.ItemData(tbl.単位区分Column)
                Me.発注用紙CD = New BaseCore.Common.Field.ItemData(tbl.発注用紙CDColumn)
                Me.発注用糊CD = New BaseCore.Common.Field.ItemData(tbl.発注用糊CDColumn)
                Me.発注用台紙CD = New BaseCore.Common.Field.ItemData(tbl.発注用台紙CDColumn)
                Me.社内単価 = New BaseCore.Common.Field.ItemData(tbl.社内単価Column, NodeContents.Constant.桁数.単価.整数, NodeContents.Constant.桁数.単価.小数)
                Me.発注単価 = New BaseCore.Common.Field.ItemData(tbl.発注単価Column, NodeContents.Constant.桁数.単価.整数, NodeContents.Constant.桁数.単価.小数)

                Me.処理登録 = New BaseCore.Common.Field.ItemData("処理登録", TypeCode.String, 1)
                Me.処理修正 = New BaseCore.Common.Field.ItemData("処理修正", TypeCode.String, 1)
                Me.処理削除 = New BaseCore.Common.Field.ItemData("処理削除", TypeCode.String, 1)

                Me.仕入先名 = New BaseCore.Common.Field.ItemData("仕入先名", TypeCode.String, 1)
                Me.社内用紙名 = New BaseCore.Common.Field.ItemData("社内用紙名", TypeCode.String, 1)
                Me.社内用糊名 = New BaseCore.Common.Field.ItemData("社内用糊名", TypeCode.String, 1)
                Me.社内用台紙名 = New BaseCore.Common.Field.ItemData("社内用台紙名", TypeCode.String, 1)
                Me.発注用紙名 = New BaseCore.Common.Field.ItemData("発注用紙名", TypeCode.String, 1)
                Me.発注用糊名 = New BaseCore.Common.Field.ItemData("発注用糊名", TypeCode.String, 1)
                Me.発注用台紙名 = New BaseCore.Common.Field.ItemData("発注用台紙名", TypeCode.String, 1)
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
            If KeyClear = True Then
                Me.Fields.Header.処理登録.Value = NodeContents.Constant.CodeValue.フラグ.オン
                Me.Fields.Header.処理修正.Value = NodeContents.Constant.CodeValue.フラグ.オフ
                Me.Fields.Header.処理削除.Value = NodeContents.Constant.CodeValue.フラグ.オフ
            End If
            '----------------------------------------------------------------------
            ' ﾃﾞｰﾀ部ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Fields.Header.仕入先CD.Value = Nothing
            Me.Fields.Header.仕入先名.Value = Nothing
            Me.Fields.Header.社内用紙CD.Value = Nothing
            Me.Fields.Header.社内用糊CD.Value = Nothing
            Me.Fields.Header.社内用台紙CD.Value = Nothing
            Me.Fields.Header.社内用紙名.Value = Nothing
            Me.Fields.Header.社内用糊名.Value = Nothing
            Me.Fields.Header.社内用台紙名.Value = Nothing
            Me.Fields.Header.単位区分.Value = Nothing
            Me.Fields.Header.発注用紙CD.Value = Nothing
            Me.Fields.Header.発注用糊CD.Value = Nothing
            Me.Fields.Header.発注用台紙CD.Value = Nothing
            Me.Fields.Header.社内単価.Value = Nothing
            Me.Fields.Header.発注単価.Value = Nothing

            Me.Fields.Header.発注用紙名.Value = Nothing
            Me.Fields.Header.発注用糊名.Value = Nothing
            Me.Fields.Header.発注用台紙名.Value = Nothing

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

        '#Region "Exist"
        '        '''========================================================================================
        '        ''' <SUMMARY>ﾍｯﾀﾞ</SUMMARY>
        '        ''' <RETURNS>True:あり, False:なし</RETURNS>
        '        '''========================================================================================
        '        Protected Overrides Function Exist_Header() As Boolean
        '            '----------------------------------------------------------------------
        '            ' 変数定義
        '            '----------------------------------------------------------------------
        '            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0紙価格TableAdapter
        '            Dim tbl As New NodeDatabase.DataSetView.V0紙価格DataTable
        '            Dim qry As New Collection

        '            '----------------------------------------------------------------------
        '            ' 条件設定
        '            '----------------------------------------------------------------------
        '            qry.Clear()
        '            qry.Add(New BaseDatabase.Condition(tbl.仕入先CDColumn.ColumnName, Me.Fields.Header.仕入先CD.Value, BaseDatabase.Contents.Compare.Equal))
        '            qry.Add(New BaseDatabase.Condition(tbl.社内用紙CDColumn.ColumnName, Me.Fields.Header.社内用紙CD.Value, BaseDatabase.Contents.Compare.Equal))
        '            qry.Add(New BaseDatabase.Condition(tbl.社内用糊CDColumn.ColumnName, Me.Fields.Header.社内用糊CD.Value, BaseDatabase.Contents.Compare.Equal))
        '            qry.Add(New BaseDatabase.Condition(tbl.社内用台紙CDColumn.ColumnName, Me.Fields.Header.社内用台紙CD.Value, BaseDatabase.Contents.Compare.Equal))
        '            qry.Add(New BaseDatabase.Condition(tbl.単位区分Column.ColumnName, Me.Fields.Header.単位区分.Value, BaseDatabase.Contents.Compare.Equal))

        '            '----------------------------------------------------------------------
        '            ' 読込
        '            '----------------------------------------------------------------------
        '            tbl = ada.SelectByCommon(qry)
        '            If tbl.Count = 0 Then
        '                Return False
        '            End If

        '            '----------------------------------------------------------------------
        '            ' 正常終了
        '            '----------------------------------------------------------------------
        '            Return True
        '        End Function
        '#End Region

#Region "Read"
        '''========================================================================================
        ''' <SUMMARY>読込</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Read_Header() As Boolean
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0紙価格TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0紙価格DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.仕入先CDColumn.ColumnName, Me.Fields.Header.仕入先CD.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.社内用紙CDColumn.ColumnName, Me.Fields.Header.社内用紙CD.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.社内用糊CDColumn.ColumnName, Me.Fields.Header.社内用糊CD.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.社内用台紙CDColumn.ColumnName, Me.Fields.Header.社内用台紙CD.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.単位区分Column.ColumnName, Me.Fields.Header.単位区分.Value, BaseDatabase.Contents.Compare.Equal))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            tbl = ada.SelectByCommon(qry)
            If tbl.Count = 0 Then
                Return False
            End If

            Me.Fields.Header.仕入先CD.Value = tbl(0).Item(tbl.仕入先CDColumn.ColumnName)
            Me.Fields.Header.社内用紙CD.Value = tbl(0).Item(tbl.社内用紙CDColumn.ColumnName)
            Me.Fields.Header.社内用糊CD.Value = tbl(0).Item(tbl.社内用糊CDColumn.ColumnName)
            Me.Fields.Header.社内用台紙CD.Value = tbl(0).Item(tbl.社内用台紙CDColumn.ColumnName)
            Me.Fields.Header.単位区分.Value = tbl(0).Item(tbl.単位区分Column.ColumnName)
            Me.Fields.Header.発注用紙CD.Value = tbl(0).Item(tbl.発注用紙CDColumn.ColumnName)
            Me.Fields.Header.発注用糊CD.Value = tbl(0).Item(tbl.発注用糊CDColumn.ColumnName)
            Me.Fields.Header.発注用台紙CD.Value = tbl(0).Item(tbl.発注用台紙CDColumn.ColumnName)
            Me.Fields.Header.社内単価.Value = tbl(0).Item(tbl.社内単価Column.ColumnName)
            Me.Fields.Header.発注単価.Value = tbl(0).Item(tbl.発注単価Column.ColumnName)

            Me.Fields.Header.発注用紙名.Value = tbl(0).Item(tbl.発注用紙名Column.ColumnName)
            Me.Fields.Header.発注用糊名.Value = tbl(0).Item(tbl.発注用糊名Column.ColumnName)
            Me.Fields.Header.発注用台紙名.Value = tbl(0).Item(tbl.発注用台紙名Column.ColumnName)

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "Write"
        '''========================================================================================
        ''' <SUMMARY>書込</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Write_Header() As Boolean
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim strNow As String = Format(Now, "yyyy/MM/dd HH:mm:ss")

            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M紙価格TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M紙価格DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.仕入先CDColumn.ColumnName, Me.Fields.Header.仕入先CD.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.社内用紙CDColumn.ColumnName, Me.Fields.Header.社内用紙CD.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.社内用糊CDColumn.ColumnName, Me.Fields.Header.社内用糊CD.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.社内用台紙CDColumn.ColumnName, Me.Fields.Header.社内用台紙CD.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.単位区分Column.ColumnName, Me.Fields.Header.単位区分.Value, BaseDatabase.Contents.Compare.Equal))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            tbl = ada.SelectByCommon(qry)

            '----------------------------------------------------------------------
            ' 保存
            '----------------------------------------------------------------------
            Using scope As New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, TimeSpan.Zero)
                If tbl.Count = 0 Then
                    '-------------------------------------
                    ' 新規
                    '-------------------------------------
                    ada.Insert(Me.Fields.Header.仕入先CD.Value _
                             , Me.Fields.Header.社内用紙CD.Value _
                             , Me.Fields.Header.社内用糊CD.Value _
                             , Me.Fields.Header.社内用台紙CD.Value _
                             , Me.Fields.Header.単位区分.Value _
                             , Me.Fields.Header.発注用紙CD.Value _
                             , Me.Fields.Header.発注用糊CD.Value _
                             , Me.Fields.Header.発注用台紙CD.Value _
                             , BaseCore.Common.Text.CVal(Me.Fields.Header.社内単価.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.Header.発注単価.Value) _
                              )
                Else
                    '-------------------------------------
                    ' 訂正
                    '-------------------------------------
                    tbl(0).Item(tbl.仕入先CDColumn.ColumnName) = Me.Fields.Header.仕入先CD.Value
                    tbl(0).Item(tbl.社内用紙CDColumn.ColumnName) = Me.Fields.Header.社内用紙CD.Value
                    tbl(0).Item(tbl.社内用糊CDColumn.ColumnName) = Me.Fields.Header.社内用糊CD.Value
                    tbl(0).Item(tbl.社内用台紙CDColumn.ColumnName) = Me.Fields.Header.社内用台紙CD.Value
                    tbl(0).Item(tbl.単位区分Column.ColumnName) = Me.Fields.Header.単位区分.Value
                    tbl(0).Item(tbl.発注用紙CDColumn.ColumnName) = Me.Fields.Header.発注用紙CD.Value
                    tbl(0).Item(tbl.発注用糊CDColumn.ColumnName) = Me.Fields.Header.発注用糊CD.Value
                    tbl(0).Item(tbl.発注用台紙CDColumn.ColumnName) = Me.Fields.Header.発注用台紙CD.Value
                    tbl(0).Item(tbl.社内単価Column.ColumnName) = BaseCore.Common.Text.CVal(Me.Fields.Header.社内単価.Value)
                    tbl(0).Item(tbl.発注単価Column.ColumnName) = BaseCore.Common.Text.CVal(Me.Fields.Header.発注単価.Value)
                    ada.Update(tbl)
                End If

                '-------------------------------------
                ' COMMIT
                '-------------------------------------
                scope.Complete()
            End Using

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "Delete"
        '''========================================================================================
        ''' <SUMMARY>削除</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Delete_Header() As Boolean
            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ
            '----------------------------------------------------------------------
            '------------------------------------
            ' 変数定義
            '------------------------------------
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M紙価格TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M紙価格DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.仕入先CDColumn.ColumnName, Me.Fields.Header.仕入先CD.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.社内用紙CDColumn.ColumnName, Me.Fields.Header.社内用紙CD.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.社内用糊CDColumn.ColumnName, Me.Fields.Header.社内用糊CD.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.社内用台紙CDColumn.ColumnName, Me.Fields.Header.社内用台紙CD.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.単位区分Column.ColumnName, Me.Fields.Header.単位区分.Value, BaseDatabase.Contents.Compare.Equal))

            '------------------------------------
            ' 削除
            '------------------------------------
            Try
                Using scope As New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, TimeSpan.Zero)
                    ada.DeleteByCommon(qry)

                    '-------------------------------------
                    ' COMMIT
                    '-------------------------------------
                    scope.Complete()
                End Using

            Catch ex As Exception
                MyBase.LastError = "以下のエラーのため、削除できませんでした。" & vbCrLf & ex.Message
                Return False
            End Try

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "Valid_Write"
        '''========================================================================================
        ''' <SUMMARY>検査(共通)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Protected Overrides Function Valid_Write_Header_Common() As NodeContents.ActionButton.ErrorLevel
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim strMsg As String = ""
            Dim Validator As New BaseCore.Common.Validator

            '------------------------------------------------------------------
            ' ｴﾗｰｸﾘｱ
            '------------------------------------------------------------------
            Me.Fields.Header.仕入先CD.IsError = False
            Me.Fields.Header.社内用紙CD.IsError = False
            Me.Fields.Header.社内用糊CD.IsError = False
            Me.Fields.Header.社内用台紙CD.IsError = False
            Me.Fields.Header.単位区分.IsError = False
            Me.Fields.Header.発注用紙CD.IsError = False
            Me.Fields.Header.発注用糊CD.IsError = False
            Me.Fields.Header.発注用台紙CD.IsError = False
            Me.Fields.Header.社内単価.IsError = False
            Me.Fields.Header.発注単価.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            Validator.BaseChecker(Me.Fields.Header.仕入先CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.社内用紙CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.社内用糊CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.社内用台紙CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.単位区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.発注用紙CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.発注用糊CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.発注用台紙CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.社内単価, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.発注単価, strMsg, Me.ControlError)

            '------------------------------------------------------------------
            ' 返却
            '------------------------------------------------------------------
            MyBase.LastError = strMsg
            Select Case True
                Case strMsg = ""
                    Return NodeContents.ActionButton.ErrorLevel.None
                Case Else
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select
        End Function
#End Region

#Region "Valid_Delete"
        '''========================================================================================
        ''' <SUMMARY>検査(共通)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Protected Overrides Function Valid_Delete_Header_Common() As NodeContents.ActionButton.ErrorLevel
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim strMsg As String = ""
            Dim Validator As New BaseCore.Common.Validator

            '------------------------------------------------------------------
            ' ｴﾗｰｸﾘｱ
            '------------------------------------------------------------------
            Me.Fields.Header.仕入先CD.IsError = False
            Me.Fields.Header.社内用紙CD.IsError = False
            Me.Fields.Header.社内用糊CD.IsError = False
            Me.Fields.Header.社内用台紙CD.IsError = False
            Me.Fields.Header.単位区分.IsError = False
            Me.Fields.Header.発注用紙CD.IsError = False
            Me.Fields.Header.発注用糊CD.IsError = False
            Me.Fields.Header.発注用台紙CD.IsError = False
            Me.Fields.Header.社内単価.IsError = False
            Me.Fields.Header.発注単価.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            Validator.BaseChecker(Me.Fields.Header.仕入先CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.社内用紙CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.社内用糊CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.社内用台紙CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.単位区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.発注用紙CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.発注用糊CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.発注用台紙CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.社内単価, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.発注単価, strMsg, Me.ControlError)

            '------------------------------------------------------------------
            ' 返却
            '------------------------------------------------------------------
            MyBase.LastError = strMsg
            Select Case True
                Case strMsg = ""
                    Return NodeContents.ActionButton.ErrorLevel.None
                Case Else
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select
        End Function

        '''========================================================================================
        ''' <SUMMARY>検査(個別)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Protected Overrides Function Valid_Delete_Header_Another() As NodeContents.ActionButton.ErrorLevel
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim strMsg As String = ""
            Dim Validator As New BaseCore.Common.Validator

            '----------------------------------------------------------------------
            ' 存在検査
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M紙価格TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M紙価格DataTable
            Dim qry As New Collection

            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.仕入先CDColumn.ColumnName, Me.Fields.Header.仕入先CD.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.社内用紙CDColumn.ColumnName, Me.Fields.Header.社内用紙CD.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.社内用糊CDColumn.ColumnName, Me.Fields.Header.社内用糊CD.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.社内用台紙CDColumn.ColumnName, Me.Fields.Header.社内用台紙CD.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.単位区分Column.ColumnName, Me.Fields.Header.単位区分.Value, BaseDatabase.Contents.Compare.Equal))

            tbl = ada.SelectByCommon(qry)
            If tbl.Rows.Count = 0 Then
                Me.Fields.Header.仕入先CD.IsError = True
                Me.Fields.Header.社内用紙名.IsError = True
                Me.Fields.Header.社内用糊CD.IsError = True
                Me.Fields.Header.社内用台紙CD.IsError = True

                Me.ControlError = Me.Fields.Header.仕入先CD.Control
                Me.ControlError = Me.Fields.Header.社内用紙名.Control
                Me.ControlError = Me.Fields.Header.社内用糊CD.Control
                Me.ControlError = Me.Fields.Header.社内用台紙CD.Control
                strMsg = "マスタに登録がありません"
            End If

            '------------------------------------------------------------------
            ' 返却
            '------------------------------------------------------------------
            MyBase.LastError = strMsg
            Select Case True
                Case strMsg = ""
                    Return NodeContents.ActionButton.ErrorLevel.None
                Case Else
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select
        End Function
#End Region

        '#Region "ﾏｽﾀｰﾁｪｯｸ仕入れ"
        '        '''========================================================================================
        '        ''' <SUMMARY>ﾏｽﾀｰﾁｪｯｸ</SUMMARY>
        '        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '        '''========================================================================================
        '        Public Function Mcheck仕入れ(ByVal SupplierCD) As Boolean
        '            '----------------------------------------------------------------------
        '            ' 変数定義
        '            '----------------------------------------------------------------------
        '            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M仕入先TableAdapter
        '            Dim tbl As New NodeDatabase.DataSetMaster.M仕入先DataTable
        '            Dim qry As New Collection

        '            '----------------------------------------------------------------------
        '            ' 条件設定
        '            '----------------------------------------------------------------------
        '            qry.Clear()
        '            qry.Add(New BaseDatabase.Condition(tbl.仕入先CDColumn.ColumnName, SupplierCD, BaseDatabase.Contents.Compare.Equal))

        '            '----------------------------------------------------------------------
        '            ' 読込
        '            '----------------------------------------------------------------------
        '            tbl = ada.SelectByCommon(qry)
        '            If tbl.Count = 0 Then
        '                MsgBox("仕入先マスタに該当がありません", , "エラー")
        '                Return False
        '                Exit Function
        '            End If

        '            '----------------------------------------------------------------------
        '            ' 正常終了
        '            '----------------------------------------------------------------------
        '            Return True
        '        End Function
        '#End Region

        '#Region "ﾏｽﾀｰﾁｪｯｸ紙"
        '        '''========================================================================================
        '        ''' <SUMMARY>ﾏｽﾀｰﾁｪｯｸ</SUMMARY>
        '        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '        '''========================================================================================
        '        Public Function Mcheck紙(ByVal paperCD) As Boolean
        '            '----------------------------------------------------------------------
        '            ' 変数定義
        '            '----------------------------------------------------------------------

        '            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M紙TableAdapter
        '            Dim tbl As New NodeDatabase.DataSetMaster.M紙DataTable
        '            Dim qry As New Collection

        '            '----------------------------------------------------------------------
        '            ' 条件設定
        '            '----------------------------------------------------------------------
        '            qry.Clear()
        '            qry.Add(New BaseDatabase.Condition(tbl.紙CDColumn.ColumnName, paperCD, BaseDatabase.Contents.Compare.Equal))

        '            '----------------------------------------------------------------------
        '            ' 読込
        '            '----------------------------------------------------------------------
        '            tbl = ada.SelectByCommon(qry)
        '            If tbl.Count = 0 Then
        '                MsgBox("紙マスタに該当がありません", , "エラー")
        '                Return False
        '                Exit Function
        '            End If

        '            '----------------------------------------------------------------------
        '            ' 正常終了
        '            '----------------------------------------------------------------------
        '            Return True
        '        End Function
        '#End Region

        '#Region "ﾏｽﾀｰﾁｪｯｸ糊"
        '        '''========================================================================================
        '        ''' <SUMMARY>ﾏｽﾀｰﾁｪｯｸ</SUMMARY>
        '        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '        '''========================================================================================
        '        Public Function Mcheck糊(ByVal pasteCD) As Boolean
        '            '----------------------------------------------------------------------
        '            ' 変数定義
        '            '----------------------------------------------------------------------
        '            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M糊TableAdapter
        '            Dim tbl As New NodeDatabase.DataSetMaster.M糊DataTable
        '            Dim qry As New Collection

        '            '----------------------------------------------------------------------
        '            ' 条件設定
        '            '----------------------------------------------------------------------
        '            qry.Clear()
        '            qry.Add(New BaseDatabase.Condition(tbl.糊CDColumn.ColumnName, pasteCD, BaseDatabase.Contents.Compare.Equal))

        '            '----------------------------------------------------------------------
        '            ' 読込
        '            '----------------------------------------------------------------------
        '            tbl = ada.SelectByCommon(qry)
        '            If tbl.Count = 0 Then
        '                MsgBox("糊マスタに該当がありません", , "エラー")
        '                Return False
        '                Exit Function
        '            End If

        '            '----------------------------------------------------------------------
        '            ' 正常終了
        '            '----------------------------------------------------------------------
        '            Return True
        '        End Function
        '#End Region

        '#Region "ﾏｽﾀｰﾁｪｯｸ台紙"
        '        '''========================================================================================
        '        ''' <SUMMARY>ﾏｽﾀｰﾁｪｯｸ</SUMMARY>
        '        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '        '''========================================================================================
        '        Public Function Mcheck台紙(ByVal mountCD) As Boolean
        '            '----------------------------------------------------------------------
        '            ' 変数定義
        '            '----------------------------------------------------------------------
        '            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M台紙TableAdapter
        '            Dim tbl As New NodeDatabase.DataSetMaster.M台紙DataTable
        '            Dim qry As New Collection

        '            '----------------------------------------------------------------------
        '            ' 条件設定
        '            '----------------------------------------------------------------------
        '            qry.Clear()
        '            qry.Add(New BaseDatabase.Condition(tbl.台紙CDColumn.ColumnName, mountCD, BaseDatabase.Contents.Compare.Equal))

        '            '----------------------------------------------------------------------
        '            ' 読込
        '            '----------------------------------------------------------------------
        '            tbl = ada.SelectByCommon(qry)
        '            If tbl.Count = 0 Then
        '                MsgBox("台紙マスタに該当がありません", , "エラー")
        '                Return False
        '                Exit Function
        '            End If

        '            '----------------------------------------------------------------------
        '            ' 正常終了
        '            '----------------------------------------------------------------------
        '            Return True
        '        End Function
        '#End Region
    End Class
End Namespace
