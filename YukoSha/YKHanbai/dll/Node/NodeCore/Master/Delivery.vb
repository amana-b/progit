Namespace Frame.Master
    Partial Public Class Delivery
        Inherits NodeCore.Common.Frame

#Region "ﾌｨｰﾙﾄﾞ定義"
        Public Class Header
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 得意先CD As BaseCore.Common.Field.ItemData
            Public 出荷先CD As BaseCore.Common.Field.ItemData
            Public 出荷先名 As BaseCore.Common.Field.ItemData
            Public 郵便番号 As BaseCore.Common.Field.ItemData
            Public 住所1 As BaseCore.Common.Field.ItemData
            Public 住所2 As BaseCore.Common.Field.ItemData
            Public TEL As BaseCore.Common.Field.ItemData
            Public FAX As BaseCore.Common.Field.ItemData

            Public 処理登録 As BaseCore.Common.Field.ItemData
            Public 処理修正 As BaseCore.Common.Field.ItemData
            Public 処理削除 As BaseCore.Common.Field.ItemData

            Public 得意先名 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0出荷先DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.得意先CD = New BaseCore.Common.Field.ItemData(tbl.得意先CDColumn)
                Me.出荷先CD = New BaseCore.Common.Field.ItemData(tbl.出荷先CDColumn)
                Me.出荷先名 = New BaseCore.Common.Field.ItemData(tbl.出荷先名Column)
                Me.郵便番号 = New BaseCore.Common.Field.ItemData(tbl.郵便番号Column)
                Me.住所1 = New BaseCore.Common.Field.ItemData(tbl.住所1Column)
                Me.住所2 = New BaseCore.Common.Field.ItemData(tbl.住所2Column)
                Me.TEL = New BaseCore.Common.Field.ItemData(tbl.TELColumn)
                Me.FAX = New BaseCore.Common.Field.ItemData(tbl.FAXColumn)

                Me.処理登録 = New BaseCore.Common.Field.ItemData("処理登録", TypeCode.String, 1)
                Me.処理修正 = New BaseCore.Common.Field.ItemData("処理修正", TypeCode.String, 1)
                Me.処理削除 = New BaseCore.Common.Field.ItemData("処理削除", TypeCode.String, 1)

                Me.得意先名 = New BaseCore.Common.Field.ItemData(tbl.得意先名Column)
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
                Me.Fields.Header.出荷先CD.Value = Nothing
                Me.Fields.Header.処理登録.Value = NodeContents.Constant.CodeValue.フラグ.オン
                Me.Fields.Header.処理修正.Value = NodeContents.Constant.CodeValue.フラグ.オフ
                Me.Fields.Header.処理削除.Value = NodeContents.Constant.CodeValue.フラグ.オフ
            End If

            '----------------------------------------------------------------------
            ' ﾃﾞｰﾀ部ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Fields.Header.出荷先名.Value = Nothing
            Me.Fields.Header.郵便番号.Value = Nothing
            Me.Fields.Header.住所1.Value = Nothing
            Me.Fields.Header.住所2.Value = Nothing
            Me.Fields.Header.TEL.Value = Nothing
            Me.Fields.Header.FAX.Value = Nothing
            Me.Fields.Header.得意先名.Value = Nothing

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
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M得意先TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M得意先DataTable
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
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0出荷先TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0出荷先DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Me.Fields.Header.得意先CD.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.出荷先CDColumn.ColumnName, Me.Fields.Header.出荷先CD.Value, BaseDatabase.Contents.Compare.Equal))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            tbl = ada.SelectByCommon(qry)
            If tbl.Count = 0 Then
                Return False
            End If

            Me.Fields.Header.得意先CD.Value = tbl(0).Item(tbl.得意先CDColumn.ColumnName)
            Me.Fields.Header.出荷先CD.Value = tbl(0).Item(tbl.出荷先CDColumn.ColumnName)
            Me.Fields.Header.出荷先名.Value = tbl(0).Item(tbl.出荷先名Column.ColumnName)
            Me.Fields.Header.郵便番号.Value = tbl(0).Item(tbl.郵便番号Column.ColumnName)
            Me.Fields.Header.住所1.Value = tbl(0).Item(tbl.住所1Column.ColumnName)
            Me.Fields.Header.住所2.Value = tbl(0).Item(tbl.住所2Column.ColumnName)
            Me.Fields.Header.TEL.Value = tbl(0).Item(tbl.TELColumn.ColumnName)
            Me.Fields.Header.FAX.Value = tbl(0).Item(tbl.FAXColumn.ColumnName)
            Me.Fields.Header.得意先名.Value = tbl(0).Item(tbl.得意先名Column.ColumnName)

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

            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M出荷先TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M出荷先DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Me.Fields.Header.得意先CD.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.出荷先CDColumn.ColumnName, Me.Fields.Header.出荷先CD.Value, BaseDatabase.Contents.Compare.Equal))

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
                             , Me.Fields.Header.出荷先CD.Value _
                             , Me.Fields.Header.出荷先名.Value _
                             , Me.Fields.Header.郵便番号.Value _
                             , Me.Fields.Header.住所1.Value _
                             , Me.Fields.Header.住所2.Value _
                             , Me.Fields.Header.TEL.Value _
                             , Me.Fields.Header.FAX.Value _
                              )
                Else
                    '-------------------------------------
                    ' 訂正
                    '-------------------------------------
                    tbl(0).Item(tbl.得意先CDColumn.ColumnName) = Me.Fields.Header.得意先CD.Value
                    tbl(0).Item(tbl.出荷先CDColumn.ColumnName) = Me.Fields.Header.出荷先CD.Value
                    tbl(0).Item(tbl.出荷先名Column.ColumnName) = Me.Fields.Header.出荷先名.Value
                    tbl(0).Item(tbl.郵便番号Column.ColumnName) = Me.Fields.Header.郵便番号.Value
                    tbl(0).Item(tbl.住所1Column.ColumnName) = Me.Fields.Header.住所1.Value
                    tbl(0).Item(tbl.住所2Column.ColumnName) = Me.Fields.Header.住所2.Value
                    tbl(0).Item(tbl.TELColumn.ColumnName) = Me.Fields.Header.TEL.Value
                    tbl(0).Item(tbl.FAXColumn.ColumnName) = Me.Fields.Header.FAX.Value
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
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M出荷先TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M出荷先DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Me.Fields.Header.得意先CD.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.出荷先CDColumn.ColumnName, Me.Fields.Header.出荷先CD.Value, BaseDatabase.Contents.Compare.Equal))

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
            Me.Fields.Header.出荷先CD.IsError = False
            Me.Fields.Header.出荷先名.IsError = False
            Me.Fields.Header.郵便番号.IsError = False
            Me.Fields.Header.住所1.IsError = False
            Me.Fields.Header.住所2.IsError = False
            Me.Fields.Header.TEL.IsError = False
            Me.Fields.Header.FAX.IsError = False
            Me.Fields.Header.得意先名.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            Validator.BaseChecker(Me.Fields.Header.得意先CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.出荷先CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.出荷先名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.郵便番号, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.住所1, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.住所2, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.TEL, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.FAX, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.得意先名, strMsg, Me.ControlError)

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
