Namespace Frame.Master
    Partial Public Class Personnel
        Inherits NodeCore.Common.Frame

#Region "ﾌｨｰﾙﾄﾞ定義"
        Public Class Header
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 担当者CD As BaseCore.Common.Field.ItemData
            Public 担当者名 As BaseCore.Common.Field.ItemData
            Public コーター通数 As BaseCore.Common.Field.ItemData
            Public コーター金額 As BaseCore.Common.Field.ItemData
            Public 開始見積NO As BaseCore.Common.Field.ItemData
            Public 売上日計表対象有無 As BaseCore.Common.Field.ItemData

            Public 処理登録 As BaseCore.Common.Field.ItemData
            Public 処理修正 As BaseCore.Common.Field.ItemData
            Public 処理削除 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0担当者DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.担当者CD = New BaseCore.Common.Field.ItemData(tbl.担当者CDColumn)
                Me.担当者名 = New BaseCore.Common.Field.ItemData(tbl.担当者名Column)
                Me.コーター通数 = New BaseCore.Common.Field.ItemData(tbl.コーター通数Column)
                Me.コーター金額 = New BaseCore.Common.Field.ItemData(tbl.コーター金額Column)
                Me.開始見積NO = New BaseCore.Common.Field.ItemData(tbl.開始見積NOColumn)
                Me.売上日計表対象有無 = New BaseCore.Common.Field.ItemData(tbl.売上日計表対象有無Column)

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
                Me.Fields.Header.担当者CD.Value = Nothing
                Me.Fields.Header.処理登録.Value = NodeContents.Constant.CodeValue.フラグ.オン
                Me.Fields.Header.処理修正.Value = NodeContents.Constant.CodeValue.フラグ.オフ
                Me.Fields.Header.処理削除.Value = NodeContents.Constant.CodeValue.フラグ.オフ
            End If

            '----------------------------------------------------------------------
            ' ﾃﾞｰﾀ部ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Fields.Header.担当者名.Value = Nothing
            Me.Fields.Header.コーター通数.Value = Nothing
            Me.Fields.Header.コーター金額.Value = Nothing
            Me.Fields.Header.開始見積NO.Value = Nothing
            Me.Fields.Header.売上日計表対象有無.Value = Nothing

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
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0担当者TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0担当者DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.担当者CDColumn.ColumnName, Me.Fields.Header.担当者CD.Value, BaseDatabase.Contents.Compare.Equal))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            tbl = ada.SelectByCommon(qry)
            If tbl.Count = 0 Then
                Return False
            End If

            Me.Fields.Header.担当者CD.Value = tbl(0).Item(tbl.担当者CDColumn.ColumnName)
            Me.Fields.Header.担当者名.Value = tbl(0).Item(tbl.担当者名Column.ColumnName)
            Me.Fields.Header.コーター通数.Value = tbl(0).Item(tbl.コーター通数Column.ColumnName)
            Me.Fields.Header.コーター金額.Value = tbl(0).Item(tbl.コーター金額Column.ColumnName)
            Me.Fields.Header.開始見積NO.Value = tbl(0).Item(tbl.開始見積NOColumn.ColumnName)
            Me.Fields.Header.売上日計表対象有無.Value = tbl(0).Item(tbl.売上日計表対象有無Column.ColumnName)

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

            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M担当者TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M担当者DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.担当者CDColumn.ColumnName, Me.Fields.Header.担当者CD.Value, BaseDatabase.Contents.Compare.Equal))

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
                    ada.Insert(Me.Fields.Header.担当者CD.Value _
                             , Me.Fields.Header.担当者名.Value _
                             , Me.Fields.Header.コーター通数.Value _
                             , Me.Fields.Header.コーター金額.Value _
                             , Me.Fields.Header.開始見積NO.Value _
                             , Me.Fields.Header.売上日計表対象有無.Value _
                              )
                Else
                    '-------------------------------------
                    ' 訂正
                    '-------------------------------------
                    tbl(0).Item(tbl.担当者CDColumn.ColumnName) = Me.Fields.Header.担当者CD.Value
                    tbl(0).Item(tbl.担当者名Column.ColumnName) = Me.Fields.Header.担当者名.Value
                    tbl(0).Item(tbl.コーター通数Column.ColumnName) = Me.Fields.Header.コーター通数.Value
                    tbl(0).Item(tbl.コーター金額Column.ColumnName) = Me.Fields.Header.コーター金額.Value
                    tbl(0).Item(tbl.開始見積NOColumn.ColumnName) = Me.Fields.Header.開始見積NO.Value
                    tbl(0).Item(tbl.売上日計表対象有無Column.ColumnName) = Me.Fields.Header.売上日計表対象有無.Value
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
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M担当者TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M担当者DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.担当者CDColumn.ColumnName, Me.Fields.Header.担当者CD.Value, BaseDatabase.Contents.Compare.Equal))

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
            Me.Fields.Header.担当者CD.IsError = False
            Me.Fields.Header.担当者名.IsError = False
            Me.Fields.Header.コーター通数.IsError = False
            Me.Fields.Header.コーター通数.IsError = False
            Me.Fields.Header.開始見積NO.IsError = False
            Me.Fields.Header.売上日計表対象有無.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            Validator.BaseChecker(Me.Fields.Header.担当者CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.担当者名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.コーター通数, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.コーター金額, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.開始見積NO, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.売上日計表対象有無, strMsg, Me.ControlError)

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
