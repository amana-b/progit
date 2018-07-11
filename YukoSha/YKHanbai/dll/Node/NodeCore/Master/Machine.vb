Namespace Frame.Master
    Partial Public Class Machine
        Inherits NodeCore.Common.Frame

#Region "ﾌｨｰﾙﾄﾞ定義"
        Public Class Header
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 機械CD As BaseCore.Common.Field.ItemData
            Public 機械名 As BaseCore.Common.Field.ItemData
            Public 固定経費平圧金額 As BaseCore.Common.Field.ItemData
            Public 固定経費平圧条件外一通あたり金額 As BaseCore.Common.Field.ItemData
            Public 機械区分 As BaseCore.Common.Field.ItemData
            Public 担当者CD As BaseCore.Common.Field.ItemData
            Public コーター回転数 As BaseCore.Common.Field.ItemData
            Public コーター日数 As BaseCore.Common.Field.ItemData
            Public 分類CD As BaseCore.Common.Field.ItemData
            Public 機械種別区分 As BaseCore.Common.Field.ItemData
            Public 固定経費平圧条件 As BaseCore.Common.Field.ItemData
            Public 固定経費輪転条件 As BaseCore.Common.Field.ItemData
            Public 固定経費輪転金額 As BaseCore.Common.Field.ItemData
            Public 固定経費輪転条件外一通あたり金額 As BaseCore.Common.Field.ItemData
            Public 担当者名 As BaseCore.Common.Field.ItemData

            Public 処理登録 As BaseCore.Common.Field.ItemData
            Public 処理修正 As BaseCore.Common.Field.ItemData
            Public 処理削除 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0機械DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.機械CD = New BaseCore.Common.Field.ItemData(tbl.機械CDColumn)
                Me.機械名 = New BaseCore.Common.Field.ItemData(tbl.機械名Column)
                Me.固定経費平圧金額 = New BaseCore.Common.Field.ItemData(tbl.固定経費平圧金額Column, 7, 0)
                Me.固定経費平圧条件外一通あたり金額 = New BaseCore.Common.Field.ItemData(tbl.固定経費平圧条件外一通あたり金額Column, 7, 2)
                Me.機械区分 = New BaseCore.Common.Field.ItemData(tbl.機械区分Column)
                Me.担当者CD = New BaseCore.Common.Field.ItemData(tbl.担当者CDColumn)
                Me.コーター回転数 = New BaseCore.Common.Field.ItemData(tbl.コーター回転数Column, 7, 0)
                Me.コーター日数 = New BaseCore.Common.Field.ItemData(tbl.コーター日数Column, 2, 0)
                Me.分類CD = New BaseCore.Common.Field.ItemData(tbl.分類CDColumn)
                Me.機械種別区分 = New BaseCore.Common.Field.ItemData(tbl.機械種別区分Column)
                Me.固定経費平圧条件 = New BaseCore.Common.Field.ItemData(tbl.固定経費平圧条件Column, 7, 0)
                Me.固定経費輪転条件 = New BaseCore.Common.Field.ItemData(tbl.固定経費輪転条件Column, 7, 0)
                Me.固定経費輪転金額 = New BaseCore.Common.Field.ItemData(tbl.固定経費輪転金額Column, 7, 0)
                Me.固定経費輪転条件外一通あたり金額 = New BaseCore.Common.Field.ItemData(tbl.固定経費輪転条件外一通あたり金額Column, 7, 2)
                Me.担当者名 = New BaseCore.Common.Field.ItemData(tbl.担当者名Column)

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
                Me.Fields.Header.機械CD.Value = Nothing
                Me.Fields.Header.処理登録.Value = NodeContents.Constant.CodeValue.フラグ.オン
                Me.Fields.Header.処理修正.Value = NodeContents.Constant.CodeValue.フラグ.オフ
                Me.Fields.Header.処理削除.Value = NodeContents.Constant.CodeValue.フラグ.オフ
            End If

            '----------------------------------------------------------------------
            ' ﾃﾞｰﾀ部ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Fields.Header.機械名.Value = Nothing
            Me.Fields.Header.固定経費平圧金額.Value = "0"
            Me.Fields.Header.固定経費平圧条件外一通あたり金額.Value = "0.00"
            Me.Fields.Header.機械区分.Value = Nothing
            Me.Fields.Header.担当者CD.Value = Nothing
            Me.Fields.Header.コーター回転数.Value = "0"
            Me.Fields.Header.コーター日数.Value = "0"
            Me.Fields.Header.分類CD.Value = Nothing
            Me.Fields.Header.機械種別区分.Value = Nothing
            Me.Fields.Header.固定経費平圧条件.Value = "0"
            Me.Fields.Header.固定経費輪転条件.Value = "0"
            Me.Fields.Header.固定経費輪転金額.Value = "0"
            Me.Fields.Header.固定経費輪転条件外一通あたり金額.Value = "0.00"
            Me.Fields.Header.担当者名.Value = Nothing

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
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
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0機械TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0機械DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.機械CDColumn.ColumnName, Me.Fields.Header.機械CD.Value, BaseDatabase.Contents.Compare.Equal))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            tbl = ada.SelectByCommon(qry)
            If tbl.Count = 0 Then
                Return False
            End If

            Me.Fields.Header.機械CD.Value = tbl(0).Item(tbl.機械CDColumn.ColumnName)
            Me.Fields.Header.機械名.Value = tbl(0).Item(tbl.機械名Column.ColumnName)
            Me.Fields.Header.固定経費平圧金額.Value = tbl(0).Item(tbl.固定経費平圧金額Column.ColumnName)
            Me.Fields.Header.固定経費平圧条件外一通あたり金額.Value = tbl(0).Item(tbl.固定経費平圧条件外一通あたり金額Column.ColumnName)
            Me.Fields.Header.機械区分.Value = tbl(0).Item(tbl.機械区分Column.ColumnName)
            Me.Fields.Header.担当者CD.Value = tbl(0).Item(tbl.担当者CDColumn.ColumnName)
            Me.Fields.Header.コーター回転数.Value = tbl(0).Item(tbl.コーター回転数Column.ColumnName)
            Me.Fields.Header.コーター日数.Value = tbl(0).Item(tbl.コーター日数Column.ColumnName)
            Me.Fields.Header.分類CD.Value = tbl(0).Item(tbl.分類CDColumn.ColumnName)
            Me.Fields.Header.機械種別区分.Value = tbl(0).Item(tbl.機械種別区分Column.ColumnName)
            Me.Fields.Header.固定経費平圧条件.Value = tbl(0).Item(tbl.固定経費平圧条件Column.ColumnName)
            Me.Fields.Header.固定経費輪転条件.Value = tbl(0).Item(tbl.固定経費輪転条件Column.ColumnName)
            Me.Fields.Header.固定経費輪転金額.Value = tbl(0).Item(tbl.固定経費輪転金額Column.ColumnName)
            Me.Fields.Header.固定経費輪転条件外一通あたり金額.Value = tbl(0).Item(tbl.固定経費輪転条件外一通あたり金額Column.ColumnName)
            Me.Fields.Header.担当者名.Value = tbl(0).Item(tbl.担当者名Column.ColumnName)

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

            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M機械TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M機械DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.機械CDColumn.ColumnName, Me.Fields.Header.機械CD.Value, BaseDatabase.Contents.Compare.Equal))

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
                    ada.Insert(Me.Fields.Header.機械CD.Value _
                             , Me.Fields.Header.機械名.Value _
                             , BaseCore.Common.Text.CVal(Me.Fields.Header.固定経費平圧金額.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.Header.固定経費平圧条件外一通あたり金額.Value) _
                             , Me.Fields.Header.機械区分.Value _
                             , Me.Fields.Header.担当者CD.Value _
                             , BaseCore.Common.Text.CVal(Me.Fields.Header.コーター回転数.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.Header.コーター日数.Value) _
                             , Me.Fields.Header.分類CD.Value _
                             , Me.Fields.Header.機械種別区分.Value _
                             , BaseCore.Common.Text.CVal(Me.Fields.Header.固定経費平圧条件.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.Header.固定経費輪転条件.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.Header.固定経費輪転金額.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.Header.固定経費輪転条件外一通あたり金額.Value) _
                              )
                Else
                    '-------------------------------------
                    ' 訂正
                    '-------------------------------------
                    tbl(0).Item(tbl.機械CDColumn.ColumnName) = Me.Fields.Header.機械CD.Value
                    tbl(0).Item(tbl.機械名Column.ColumnName) = Me.Fields.Header.機械名.Value
                    tbl(0).Item(tbl.固定経費平圧金額Column.ColumnName) = BaseCore.Common.Text.CVal(Me.Fields.Header.固定経費平圧金額.Value)
                    tbl(0).Item(tbl.固定経費平圧条件外一通あたり金額Column.ColumnName) = BaseCore.Common.Text.CVal(Me.Fields.Header.固定経費平圧条件外一通あたり金額.Value)
                    tbl(0).Item(tbl.機械区分Column.ColumnName) = Me.Fields.Header.機械区分.Value
                    tbl(0).Item(tbl.担当者CDColumn.ColumnName) = Me.Fields.Header.担当者CD.Value
                    tbl(0).Item(tbl.コーター回転数Column.ColumnName) = BaseCore.Common.Text.CVal(Me.Fields.Header.コーター回転数.Value)
                    tbl(0).Item(tbl.コーター日数Column.ColumnName) = BaseCore.Common.Text.CVal(Me.Fields.Header.コーター日数.Value)
                    tbl(0).Item(tbl.分類CDColumn.ColumnName) = Me.Fields.Header.分類CD.Value
                    tbl(0).Item(tbl.機械種別区分Column.ColumnName) = Me.Fields.Header.機械種別区分.Value
                    tbl(0).Item(tbl.固定経費平圧条件Column.ColumnName) = BaseCore.Common.Text.CVal(Me.Fields.Header.固定経費平圧条件.Value)
                    tbl(0).Item(tbl.固定経費輪転条件Column.ColumnName) = BaseCore.Common.Text.CVal(Me.Fields.Header.固定経費輪転条件.Value)
                    tbl(0).Item(tbl.固定経費輪転金額Column.ColumnName) = BaseCore.Common.Text.CVal(Me.Fields.Header.固定経費輪転金額.Value)
                    tbl(0).Item(tbl.固定経費輪転条件外一通あたり金額Column.ColumnName) = BaseCore.Common.Text.CVal(Me.Fields.Header.固定経費輪転条件外一通あたり金額.Value)
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
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M機械TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M機械DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.機械CDColumn.ColumnName, Me.Fields.Header.機械CD.Value, BaseDatabase.Contents.Compare.Equal))

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
            Me.Fields.Header.機械CD.IsError = False
            Me.Fields.Header.機械名.IsError = False
            Me.Fields.Header.固定経費平圧金額.IsError = False
            Me.Fields.Header.固定経費平圧条件外一通あたり金額.IsError = False
            Me.Fields.Header.機械区分.IsError = False
            Me.Fields.Header.担当者CD.IsError = False
            Me.Fields.Header.コーター回転数.IsError = False
            Me.Fields.Header.コーター日数.IsError = False
            Me.Fields.Header.分類CD.IsError = False
            Me.Fields.Header.機械種別区分.IsError = False
            Me.Fields.Header.固定経費平圧条件.IsError = False
            Me.Fields.Header.固定経費輪転条件.IsError = False
            Me.Fields.Header.固定経費輪転金額.IsError = False
            Me.Fields.Header.固定経費輪転条件外一通あたり金額.IsError = False
            Me.Fields.Header.担当者名.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            Validator.BaseChecker(Me.Fields.Header.機械CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.機械名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.固定経費平圧金額, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.固定経費平圧条件外一通あたり金額, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.機械区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.担当者CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.コーター回転数, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.コーター日数, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.分類CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.機械種別区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.固定経費平圧条件, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.固定経費輪転条件, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.固定経費輪転金額, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.固定経費輪転条件外一通あたり金額, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.担当者名, strMsg, Me.ControlError)

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
