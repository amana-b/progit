Namespace Frame.Master
    Partial Public Class Type1
        Inherits NodeCore.Common.Frame

#Region "ﾌｨｰﾙﾄﾞ定義"
        Public Class Header
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 大分類CD As BaseCore.Common.Field.ItemData
            Public 大分類名 As BaseCore.Common.Field.ItemData
            Public 月当たり人件費 As BaseCore.Common.Field.ItemData
            Public 月当たり間接固定経費 As BaseCore.Common.Field.ItemData

            Public 処理登録 As BaseCore.Common.Field.ItemData
            Public 処理修正 As BaseCore.Common.Field.ItemData
            Public 処理削除 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetMaster.M大分類DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.大分類CD = New BaseCore.Common.Field.ItemData(tbl.大分類CDColumn)
                Me.大分類名 = New BaseCore.Common.Field.ItemData(tbl.大分類名Column)
                Me.月当たり人件費 = New BaseCore.Common.Field.ItemData(tbl.月当たり人件費Column, 11, NodeContents.Constant.桁数.金額.小数)
                Me.月当たり間接固定経費 = New BaseCore.Common.Field.ItemData(tbl.月当たり間接固定経費Column, 11, NodeContents.Constant.桁数.金額.小数)

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
                Me.Fields.Header.大分類CD.Value = Nothing
                Me.Fields.Header.処理登録.Value = NodeContents.Constant.CodeValue.フラグ.オン
                Me.Fields.Header.処理修正.Value = NodeContents.Constant.CodeValue.フラグ.オフ
                Me.Fields.Header.処理削除.Value = NodeContents.Constant.CodeValue.フラグ.オフ
            End If

            '----------------------------------------------------------------------
            ' ﾃﾞｰﾀ部ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Fields.Header.大分類名.Value = Nothing
            Me.Fields.Header.月当たり人件費.Value = Nothing
            Me.Fields.Header.月当たり間接固定経費.Value = Nothing

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
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M大分類TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M大分類DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.大分類CDColumn.ColumnName, Me.Fields.Header.大分類CD.Value, BaseDatabase.Contents.Compare.Equal))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            tbl = ada.SelectByCommon(qry)
            If tbl.Count = 0 Then
                Return False
            End If

            Me.Fields.Header.大分類CD.Value = tbl(0).Item(tbl.大分類CDColumn.ColumnName)
            Me.Fields.Header.大分類名.Value = tbl(0).Item(tbl.大分類名Column.ColumnName)
            Me.Fields.Header.月当たり人件費.Value = tbl(0).Item(tbl.月当たり人件費Column.ColumnName)
            Me.Fields.Header.月当たり間接固定経費.Value = tbl(0).Item(tbl.月当たり間接固定経費Column.ColumnName)

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

            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M大分類TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M大分類DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.大分類CDColumn.ColumnName, Me.Fields.Header.大分類CD.Value, BaseDatabase.Contents.Compare.Equal))

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
                    ada.Insert(Me.Fields.Header.大分類CD.Value _
                             , Me.Fields.Header.大分類名.Value _
                             , BaseCore.Common.Text.CVal(Me.Fields.Header.月当たり人件費.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.Header.月当たり間接固定経費.Value) _
                              )
                Else
                    '-------------------------------------
                    ' 訂正
                    '-------------------------------------
                    tbl(0).Item(tbl.大分類CDColumn.ColumnName) = Me.Fields.Header.大分類CD.Value
                    tbl(0).Item(tbl.大分類名Column.ColumnName) = Me.Fields.Header.大分類名.Value
                    tbl(0).Item(tbl.月当たり人件費Column.ColumnName) = BaseCore.Common.Text.CVal(Me.Fields.Header.月当たり人件費.Value)
                    tbl(0).Item(tbl.月当たり間接固定経費Column.ColumnName) = BaseCore.Common.Text.CVal(Me.Fields.Header.月当たり間接固定経費.Value)
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
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M大分類TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M大分類DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.大分類CDColumn.ColumnName, Me.Fields.Header.大分類CD.Value, BaseDatabase.Contents.Compare.Equal))

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
            Me.Fields.Header.大分類CD.IsError = False
            Me.Fields.Header.大分類名.IsError = False
            Me.Fields.Header.月当たり人件費.IsError = False
            Me.Fields.Header.月当たり間接固定経費.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            Validator.BaseChecker(Me.Fields.Header.大分類CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.大分類名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.月当たり人件費, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.月当たり間接固定経費, strMsg, Me.ControlError)

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
