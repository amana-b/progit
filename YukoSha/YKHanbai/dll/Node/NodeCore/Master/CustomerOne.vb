Namespace Frame.Master
    Partial Public Class CustomerOne
        Inherits NodeCore.Common.Frame

#Region "ﾌｨｰﾙﾄﾞ定義"
        Public Class Header
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 得意先CD As BaseCore.Common.Field.ItemData
            Public 得意先名 As BaseCore.Common.Field.ItemData
            Public カナ名 As BaseCore.Common.Field.ItemData
            Public 郵便番号 As BaseCore.Common.Field.ItemData
            Public 住所1 As BaseCore.Common.Field.ItemData
            Public 住所2 As BaseCore.Common.Field.ItemData
            Public TEL As BaseCore.Common.Field.ItemData
            Public 役職_担当者名 As BaseCore.Common.Field.ItemData
            Public 代表者役職_代表者名 As BaseCore.Common.Field.ItemData
            Public 担当者CD As BaseCore.Common.Field.ItemData
            Public 仮伝パターンCD As BaseCore.Common.Field.ItemData
            Public 売伝パターンCD As BaseCore.Common.Field.ItemData
            Public 消費税区分 As BaseCore.Common.Field.ItemData
            Public 締日 As BaseCore.Common.Field.ItemData
            Public 回収条件設定金額 As BaseCore.Common.Field.ItemData
            Public 回収条件以上回収月 As BaseCore.Common.Field.ItemData
            Public 回収条件以上回収日 As BaseCore.Common.Field.ItemData
            Public 回収条件以上回収方法 As BaseCore.Common.Field.ItemData
            Public 回収条件未満回収月 As BaseCore.Common.Field.ItemData
            Public 回収条件未満回収日 As BaseCore.Common.Field.ItemData
            Public 回収条件未満回収方法 As BaseCore.Common.Field.ItemData
            Public 請求書発行区分 As BaseCore.Common.Field.ItemData

            Public 処理登録 As BaseCore.Common.Field.ItemData
            Public 処理修正 As BaseCore.Common.Field.ItemData
            Public 処理削除 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0得意先個人DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.得意先CD = New BaseCore.Common.Field.ItemData(tbl.得意先CDColumn)
                Me.得意先名 = New BaseCore.Common.Field.ItemData(tbl.得意先名Column)
                Me.カナ名 = New BaseCore.Common.Field.ItemData(tbl.カナ名Column)
                Me.郵便番号 = New BaseCore.Common.Field.ItemData(tbl.郵便番号Column)
                Me.住所1 = New BaseCore.Common.Field.ItemData(tbl.住所1Column)
                Me.住所2 = New BaseCore.Common.Field.ItemData(tbl.住所2Column)
                Me.TEL = New BaseCore.Common.Field.ItemData(tbl.TELColumn)
                Me.役職_担当者名 = New BaseCore.Common.Field.ItemData(tbl.役職_担当者名Column)
                Me.代表者役職_代表者名 = New BaseCore.Common.Field.ItemData(tbl.代表者役職_代表者名Column)
                Me.担当者CD = New BaseCore.Common.Field.ItemData(tbl.担当者CDColumn)
                Me.仮伝パターンCD = New BaseCore.Common.Field.ItemData(tbl.仮伝パターンCDColumn)
                Me.売伝パターンCD = New BaseCore.Common.Field.ItemData(tbl.売伝パターンCDColumn)
                Me.消費税区分 = New BaseCore.Common.Field.ItemData(tbl.消費税区分Column)
                Me.締日 = New BaseCore.Common.Field.ItemData(tbl.締日Column)
                Me.回収条件設定金額 = New BaseCore.Common.Field.ItemData(tbl.回収条件設定金額Column)
                Me.回収条件以上回収月 = New BaseCore.Common.Field.ItemData(tbl.回収条件以上回収月Column)
                Me.回収条件以上回収日 = New BaseCore.Common.Field.ItemData(tbl.回収条件以上回収日Column)
                Me.回収条件以上回収方法 = New BaseCore.Common.Field.ItemData(tbl.回収条件以上回収方法Column)
                Me.回収条件未満回収月 = New BaseCore.Common.Field.ItemData(tbl.回収条件未満回収月Column)
                Me.回収条件未満回収日 = New BaseCore.Common.Field.ItemData(tbl.回収条件未満回収日Column)
                Me.回収条件未満回収方法 = New BaseCore.Common.Field.ItemData(tbl.回収条件未満回収方法Column)
                Me.請求書発行区分 = New BaseCore.Common.Field.ItemData(tbl.請求書発行区分Column)

                Me.処理登録 = New BaseCore.Common.Field.ItemData("処理登録", TypeCode.String, 1)
                Me.処理修正 = New BaseCore.Common.Field.ItemData("処理修正", TypeCode.String, 1)
                Me.処理削除 = New BaseCore.Common.Field.ItemData("処理削除", TypeCode.String, 1)
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
                Me.Fields.Header.得意先CD.Value = Nothing
                Me.Fields.Header.処理登録.Value = NodeContents.Constant.CodeValue.フラグ.オン
                Me.Fields.Header.処理修正.Value = NodeContents.Constant.CodeValue.フラグ.オフ
                Me.Fields.Header.処理削除.Value = NodeContents.Constant.CodeValue.フラグ.オフ
            End If

            '----------------------------------------------------------------------
            ' ﾃﾞｰﾀ部ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Fields.Header.得意先名.Value = Nothing
            Me.Fields.Header.カナ名.Value = Nothing
            Me.Fields.Header.郵便番号.Value = Nothing
            Me.Fields.Header.住所1.Value = Nothing
            Me.Fields.Header.住所2.Value = Nothing
            Me.Fields.Header.TEL.Value = Nothing
            Me.Fields.Header.役職_担当者名.Value = Nothing
            Me.Fields.Header.代表者役職_代表者名.Value = Nothing
            Me.Fields.Header.担当者CD.Value = Nothing
            Me.Fields.Header.仮伝パターンCD.Value = Nothing
            Me.Fields.Header.売伝パターンCD.Value = Nothing
            Me.Fields.Header.消費税区分.Value = Nothing
            Me.Fields.Header.締日.Value = Nothing
            Me.Fields.Header.回収条件設定金額.Value = Nothing
            Me.Fields.Header.回収条件以上回収月.Value = Nothing
            Me.Fields.Header.回収条件以上回収日.Value = Nothing
            Me.Fields.Header.回収条件以上回収方法.Value = Nothing
            Me.Fields.Header.回収条件未満回収月.Value = Nothing
            Me.Fields.Header.回収条件未満回収日.Value = Nothing
            Me.Fields.Header.回収条件未満回収方法.Value = Nothing
            Me.Fields.Header.請求書発行区分.Value = Nothing

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "Exist"
        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ</SUMMARY>
        ''' <RETURNS>True:あり, False:なし</RETURNS>
        '''========================================================================================
        Protected Overrides Function Exist_Header() As Boolean
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M得意先個人TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M得意先個人DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Me.Fields.Header.得意先CD.Value, BaseDatabase.Contents.Compare.Equal))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            tbl = ada.SelectByCommon(qry)

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return (tbl.Rows.Count > 0)
        End Function
#End Region

#Region "Read"
        '''========================================================================================
        ''' <SUMMARY>読込</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Read_Header() As Boolean
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0得意先個人TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0得意先個人DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Me.Fields.Header.得意先CD.Value, BaseDatabase.Contents.Compare.Equal))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            tbl = ada.SelectByCommon(qry)
            If tbl.Count = 0 Then
                Return False
            End If

            Me.Fields.Header.得意先CD.Value = tbl(0).Item(tbl.得意先CDColumn.ColumnName)
            Me.Fields.Header.得意先名.Value = tbl(0).Item(tbl.得意先名Column.ColumnName)
            Me.Fields.Header.カナ名.Value = tbl(0).Item(tbl.カナ名Column.ColumnName)
            Me.Fields.Header.郵便番号.Value = tbl(0).Item(tbl.郵便番号Column.ColumnName)
            Me.Fields.Header.住所1.Value = tbl(0).Item(tbl.住所1Column.ColumnName)
            Me.Fields.Header.住所2.Value = tbl(0).Item(tbl.住所2Column.ColumnName)
            Me.Fields.Header.TEL.Value = tbl(0).Item(tbl.TELColumn.ColumnName)
            Me.Fields.Header.役職_担当者名.Value = tbl(0).Item(tbl.役職_担当者名Column.ColumnName)
            Me.Fields.Header.代表者役職_代表者名.Value = tbl(0).Item(tbl.代表者役職_代表者名Column.ColumnName)
            Me.Fields.Header.担当者CD.Value = tbl(0).Item(tbl.担当者CDColumn.ColumnName)
            Me.Fields.Header.仮伝パターンCD.Value = tbl(0).Item(tbl.仮伝パターンCDColumn.ColumnName)
            Me.Fields.Header.売伝パターンCD.Value = tbl(0).Item(tbl.売伝パターンCDColumn.ColumnName)
            Me.Fields.Header.消費税区分.Value = tbl(0).Item(tbl.消費税区分Column.ColumnName)
            Me.Fields.Header.締日.Value = tbl(0).Item(tbl.締日Column.ColumnName)
            Me.Fields.Header.回収条件設定金額.Value = tbl(0).Item(tbl.回収条件設定金額Column.ColumnName)
            Me.Fields.Header.回収条件以上回収月.Value = tbl(0).Item(tbl.回収条件以上回収月Column.ColumnName)
            Me.Fields.Header.回収条件以上回収日.Value = tbl(0).Item(tbl.回収条件以上回収日Column.ColumnName)
            Me.Fields.Header.回収条件以上回収方法.Value = tbl(0).Item(tbl.回収条件以上回収方法Column.ColumnName)
            Me.Fields.Header.回収条件未満回収月.Value = tbl(0).Item(tbl.回収条件未満回収月Column.ColumnName)
            Me.Fields.Header.回収条件未満回収日.Value = tbl(0).Item(tbl.回収条件未満回収日Column.ColumnName)
            Me.Fields.Header.回収条件未満回収方法.Value = tbl(0).Item(tbl.回収条件未満回収方法Column.ColumnName)
            Me.Fields.Header.請求書発行区分.Value = tbl(0).Item(tbl.請求書発行区分Column.ColumnName)

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

            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M得意先個人TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M得意先個人DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Me.Fields.Header.得意先CD.Value, BaseDatabase.Contents.Compare.Equal))
            
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
                    ada.Insert( _
                               Me.Fields.Header.得意先CD.Value _
                             , Me.Fields.Header.得意先名.Value _
                             , Me.Fields.Header.カナ名.Value _
                             , Me.Fields.Header.郵便番号.Value _
                             , Me.Fields.Header.住所1.Value _
                             , Me.Fields.Header.住所2.Value _
                             , Me.Fields.Header.TEL.Value _
                             , Me.Fields.Header.役職_担当者名.Value _
                             , Me.Fields.Header.代表者役職_代表者名.Value _
                             , Me.Fields.Header.担当者CD.Value _
                             , Me.Fields.Header.仮伝パターンCD.Value _
                             , Me.Fields.Header.売伝パターンCD.Value _
                             , Me.Fields.Header.消費税区分.Value _
                             , Me.Fields.Header.締日.Value _
                             , Me.Fields.Header.回収条件設定金額.Value _
                             , Me.Fields.Header.回収条件以上回収月.Value _
                             , Me.Fields.Header.回収条件以上回収日.Value _
                             , Me.Fields.Header.回収条件以上回収方法.Value _
                             , Me.Fields.Header.回収条件未満回収月.Value _
                             , Me.Fields.Header.回収条件未満回収日.Value _
                             , Me.Fields.Header.回収条件未満回収方法.Value _
                             , Me.Fields.Header.請求書発行区分.Value _
                              )
                Else
                    '-------------------------------------
                    ' 訂正
                    '-------------------------------------
                    tbl(0).Item(tbl.得意先CDColumn.ColumnName) = Me.Fields.Header.得意先CD.Value
                    tbl(0).Item(tbl.得意先名Column.ColumnName) = Me.Fields.Header.得意先名.Value
                    tbl(0).Item(tbl.カナ名Column.ColumnName) = Me.Fields.Header.カナ名.Value
                    tbl(0).Item(tbl.郵便番号Column.ColumnName) = Me.Fields.Header.郵便番号.Value
                    tbl(0).Item(tbl.住所1Column.ColumnName) = Me.Fields.Header.住所1.Value
                    tbl(0).Item(tbl.住所2Column.ColumnName) = Me.Fields.Header.住所2.Value
                    tbl(0).Item(tbl.TELColumn.ColumnName) = Me.Fields.Header.TEL.Value
                    tbl(0).Item(tbl.役職_担当者名Column.ColumnName) = Me.Fields.Header.役職_担当者名.Value
                    tbl(0).Item(tbl.代表者役職_代表者名Column.ColumnName) = Me.Fields.Header.代表者役職_代表者名.Value
                    tbl(0).Item(tbl.担当者CDColumn.ColumnName) = Me.Fields.Header.担当者CD.Value
                    tbl(0).Item(tbl.仮伝パターンCDColumn.ColumnName) = Me.Fields.Header.仮伝パターンCD.Value
                    tbl(0).Item(tbl.売伝パターンCDColumn.ColumnName) = Me.Fields.Header.売伝パターンCD.Value
                    tbl(0).Item(tbl.消費税区分Column.ColumnName) = Me.Fields.Header.消費税区分.Value
                    tbl(0).Item(tbl.締日Column.ColumnName) = Me.Fields.Header.締日.Value
                    tbl(0).Item(tbl.回収条件設定金額Column.ColumnName) = Me.Fields.Header.回収条件設定金額.Value
                    tbl(0).Item(tbl.回収条件以上回収月Column.ColumnName) = Me.Fields.Header.回収条件以上回収月.Value
                    tbl(0).Item(tbl.回収条件以上回収日Column.ColumnName) = Me.Fields.Header.回収条件以上回収日.Value
                    tbl(0).Item(tbl.回収条件以上回収方法Column.ColumnName) = Me.Fields.Header.回収条件以上回収方法.Value
                    tbl(0).Item(tbl.回収条件未満回収月Column.ColumnName) = Me.Fields.Header.回収条件未満回収月.Value
                    tbl(0).Item(tbl.回収条件未満回収日Column.ColumnName) = Me.Fields.Header.回収条件未満回収日.Value
                    tbl(0).Item(tbl.回収条件未満回収方法Column.ColumnName) = Me.Fields.Header.回収条件未満回収方法.Value
                    tbl(0).Item(tbl.請求書発行区分Column.ColumnName) = Me.Fields.Header.請求書発行区分.Value
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
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M得意先個人TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M得意先個人DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Me.Fields.Header.得意先CD.Value, BaseDatabase.Contents.Compare.Equal))

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
            Me.Fields.Header.得意先CD.IsError = False
            Me.Fields.Header.得意先名.IsError = False
            Me.Fields.Header.カナ名.IsError = False
            Me.Fields.Header.郵便番号.IsError = False
            Me.Fields.Header.住所1.IsError = False
            Me.Fields.Header.住所2.IsError = False
            Me.Fields.Header.TEL.IsError = False
            Me.Fields.Header.役職_担当者名.IsError = False
            Me.Fields.Header.代表者役職_代表者名.IsError = False
            Me.Fields.Header.担当者CD.IsError = False
            Me.Fields.Header.仮伝パターンCD.IsError = False
            Me.Fields.Header.売伝パターンCD.IsError = False
            Me.Fields.Header.消費税区分.IsError = False
            Me.Fields.Header.締日.IsError = False
            Me.Fields.Header.回収条件設定金額.IsError = False
            Me.Fields.Header.回収条件以上回収月.IsError = False
            Me.Fields.Header.回収条件以上回収日.IsError = False
            Me.Fields.Header.回収条件以上回収方法.IsError = False
            Me.Fields.Header.回収条件未満回収月.IsError = False
            Me.Fields.Header.回収条件未満回収日.IsError = False
            Me.Fields.Header.回収条件未満回収方法.IsError = False
            Me.Fields.Header.請求書発行区分.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            Validator.BaseChecker(Me.Fields.Header.得意先CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.得意先名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.カナ名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.郵便番号, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.住所1, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.住所2, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.TEL, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.役職_担当者名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.代表者役職_代表者名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.担当者CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.仮伝パターンCD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.売伝パターンCD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.消費税区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.締日, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.回収条件設定金額, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.回収条件以上回収月, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.回収条件以上回収日, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.回収条件以上回収方法, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.回収条件未満回収月, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.回収条件未満回収日, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.回収条件未満回収方法, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.請求書発行区分, strMsg, Me.ControlError)

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
    End Class
End Namespace
