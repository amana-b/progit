Namespace Frame.Master
    Partial Public Class ItemName
        Inherits NodeCore.Common.Frame

#Region "ﾌｨｰﾙﾄﾞ定義"
        Public Class Header
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 品名CD As BaseCore.Common.Field.ItemData
            Public 品名 As BaseCore.Common.Field.ItemData
            Public 摘要 As BaseCore.Common.Field.ItemData
            Public 定番品区分 As BaseCore.Common.Field.ItemData
            Public 定番品区分名 As BaseCore.Common.Field.ItemData
            Public 在庫区分 As BaseCore.Common.Field.ItemData
            Public 在庫区分名 As BaseCore.Common.Field.ItemData
            Public 得意先CD As BaseCore.Common.Field.ItemData
            Public 得意先名 As BaseCore.Common.Field.ItemData
            Public 御客様NO As BaseCore.Common.Field.ItemData
            Public 適正在庫数 As BaseCore.Common.Field.ItemData
            Public 売上単価 As BaseCore.Common.Field.ItemData
            Public 在庫単価 As BaseCore.Common.Field.ItemData
            Public 本台帳NO As BaseCore.Common.Field.ItemData
            Public 本台帳NO連番 As BaseCore.Common.Field.ItemData
            Public ヤマト区分 As BaseCore.Common.Field.ItemData
            Public ヤマト区分名 As BaseCore.Common.Field.ItemData
            Public ヤマト種別 As BaseCore.Common.Field.ItemData
            Public ヤマト種別名 As BaseCore.Common.Field.ItemData
            Public 表記用単価 As BaseCore.Common.Field.ItemData

            Public 処理登録 As BaseCore.Common.Field.ItemData
            Public 処理修正 As BaseCore.Common.Field.ItemData
            Public 処理削除 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0品名DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.品名CD = New BaseCore.Common.Field.ItemData(tbl.品名CDColumn)
                Me.品名 = New BaseCore.Common.Field.ItemData(tbl.品名Column)
                Me.摘要 = New BaseCore.Common.Field.ItemData(tbl.摘要Column)
                Me.定番品区分 = New BaseCore.Common.Field.ItemData(tbl.定番品区分Column)
                Me.定番品区分名 = New BaseCore.Common.Field.ItemData(tbl.定番品区分名Column)
                Me.在庫区分 = New BaseCore.Common.Field.ItemData(tbl.在庫区分Column)
                Me.在庫区分名 = New BaseCore.Common.Field.ItemData(tbl.在庫区分名Column)
                Me.得意先CD = New BaseCore.Common.Field.ItemData(tbl.得意先CDColumn)
                Me.得意先名 = New BaseCore.Common.Field.ItemData(tbl.得意先名Column)
                Me.御客様NO = New BaseCore.Common.Field.ItemData(tbl.御客様NOColumn)
                Me.適正在庫数 = New BaseCore.Common.Field.ItemData(tbl.適正在庫数Column, 11)
                Me.売上単価 = New BaseCore.Common.Field.ItemData(tbl.売上単価Column, NodeContents.Constant.桁数.金額.整数, NodeContents.Constant.桁数.金額.小数)
                Me.在庫単価 = New BaseCore.Common.Field.ItemData(tbl.在庫単価Column, NodeContents.Constant.桁数.金額.整数, NodeContents.Constant.桁数.金額.小数)
                Me.本台帳NO = New BaseCore.Common.Field.ItemData(tbl.本台帳NOColumn)
                Me.本台帳NO連番 = New BaseCore.Common.Field.ItemData(tbl.本台帳NO連番Column)
                Me.ヤマト区分 = New BaseCore.Common.Field.ItemData(tbl.ヤマト区分Column)
                Me.ヤマト区分名 = New BaseCore.Common.Field.ItemData(tbl.ヤマト区分名Column)
                Me.ヤマト種別 = New BaseCore.Common.Field.ItemData(tbl.ヤマト種別Column)
                Me.ヤマト種別名 = New BaseCore.Common.Field.ItemData(tbl.ヤマト種別名Column)
                Me.表記用単価 = New BaseCore.Common.Field.ItemData(tbl.表記用単価Column, NodeContents.Constant.桁数.金額.整数, NodeContents.Constant.桁数.金額.小数)

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
                Me.Fields.Header.品名CD.Value = Nothing
                Me.Fields.Header.処理登録.Value = NodeContents.Constant.CodeValue.フラグ.オン
                Me.Fields.Header.処理修正.Value = NodeContents.Constant.CodeValue.フラグ.オフ
                Me.Fields.Header.処理削除.Value = NodeContents.Constant.CodeValue.フラグ.オフ
            End If

            '----------------------------------------------------------------------
            ' ﾃﾞｰﾀ部ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Fields.Header.品名.Value = Nothing
            Me.Fields.Header.摘要.Value = Nothing
            Me.Fields.Header.定番品区分.Value = Nothing
            Me.Fields.Header.定番品区分名.Value = Nothing
            Me.Fields.Header.在庫区分.Value = Nothing
            Me.Fields.Header.在庫区分名.Value = Nothing
            Me.Fields.Header.得意先CD.Value = Nothing
            Me.Fields.Header.得意先名.Value = Nothing
            Me.Fields.Header.御客様NO.Value = Nothing
            Me.Fields.Header.適正在庫数.Value = Nothing
            Me.Fields.Header.売上単価.Value = Nothing
            Me.Fields.Header.在庫単価.Value = Nothing
            Me.Fields.Header.本台帳NO.Value = Nothing
            Me.Fields.Header.本台帳NO連番.Value = Nothing
            Me.Fields.Header.ヤマト区分.Value = Nothing
            Me.Fields.Header.ヤマト区分名.Value = Nothing
            Me.Fields.Header.ヤマト種別.Value = Nothing
            Me.Fields.Header.ヤマト種別名.Value = Nothing
            Me.Fields.Header.表記用単価.Value = Nothing

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
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0品名TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0品名DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.品名CDColumn.ColumnName, Me.Fields.Header.品名CD.Value, BaseDatabase.Contents.Compare.Equal))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            tbl = ada.SelectByCommon(qry)
            If tbl.Count = 0 Then
                Return False
            End If

            Me.Fields.Header.品名CD.Value = tbl(0).Item(tbl.品名CDColumn.ColumnName)
            Me.Fields.Header.品名.Value = tbl(0).Item(tbl.品名Column.ColumnName)
            Me.Fields.Header.摘要.Value = tbl(0).Item(tbl.摘要Column.ColumnName)
            Me.Fields.Header.定番品区分.Value = tbl(0).Item(tbl.定番品区分Column.ColumnName)
            Me.Fields.Header.定番品区分名.Value = tbl(0).Item(tbl.定番品区分名Column.ColumnName)
            Me.Fields.Header.在庫区分.Value = tbl(0).Item(tbl.在庫区分Column.ColumnName)
            Me.Fields.Header.在庫区分名.Value = tbl(0).Item(tbl.在庫区分名Column.ColumnName)
            Me.Fields.Header.得意先CD.Value = tbl(0).Item(tbl.得意先CDColumn.ColumnName)
            Me.Fields.Header.得意先名.Value = tbl(0).Item(tbl.得意先名Column.ColumnName)
            Me.Fields.Header.御客様NO.Value = tbl(0).Item(tbl.御客様NOColumn.ColumnName)
            Me.Fields.Header.適正在庫数.Value = tbl(0).Item(tbl.適正在庫数Column.ColumnName)
            Me.Fields.Header.売上単価.Value = tbl(0).Item(tbl.売上単価Column.ColumnName)
            Me.Fields.Header.在庫単価.Value = tbl(0).Item(tbl.在庫単価Column.ColumnName)
            Me.Fields.Header.本台帳NO.Value = tbl(0).Item(tbl.本台帳NOColumn.ColumnName)
            Me.Fields.Header.本台帳NO連番.Value = tbl(0).Item(tbl.本台帳NO連番Column.ColumnName)
            Me.Fields.Header.ヤマト区分.Value = tbl(0).Item(tbl.ヤマト区分Column.ColumnName)
            Me.Fields.Header.ヤマト区分名.Value = tbl(0).Item(tbl.ヤマト区分名Column.ColumnName)
            Me.Fields.Header.ヤマト種別.Value = tbl(0).Item(tbl.ヤマト種別Column.ColumnName)
            Me.Fields.Header.ヤマト種別名.Value = tbl(0).Item(tbl.ヤマト種別名Column.ColumnName)
            Me.Fields.Header.表記用単価.Value = tbl(0).Item(tbl.表記用単価Column.ColumnName)

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

            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M品名TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M品名DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.品名CDColumn.ColumnName, Me.Fields.Header.品名CD.Value, BaseDatabase.Contents.Compare.Equal))

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
                               BaseCore.Common.Text.Nz(Me.Fields.Header.品名CD.Value, "") _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.品名.Value, "") _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.摘要.Value, "") _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.定番品区分.Value, "") _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.在庫区分.Value, "") _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.得意先CD.Value, "") _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.御客様NO.Value, "") _
                             , BaseCore.Common.Text.Nz(BaseCore.Common.Text.CVal(Me.Fields.Header.適正在庫数.Value), 0) _
                             , BaseCore.Common.Text.Nz(BaseCore.Common.Text.CVal(Me.Fields.Header.売上単価.Value), 0) _
                             , BaseCore.Common.Text.Nz(BaseCore.Common.Text.CVal(Me.Fields.Header.在庫単価.Value), 0) _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.本台帳NO.Value, "") _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.本台帳NO連番.Value, "") _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.ヤマト区分.Value, "") _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.ヤマト種別.Value, "") _
                             , BaseCore.Common.Text.Nz(BaseCore.Common.Text.CVal(Me.Fields.Header.表記用単価.Value), 0) _
                              )
                Else
                    '-------------------------------------
                    ' 訂正
                    '-------------------------------------
                    tbl(0).Item(tbl.品名CDColumn.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.品名CD.Value, "")
                    tbl(0).Item(tbl.品名Column.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.品名.Value, "")
                    tbl(0).Item(tbl.摘要Column.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.摘要.Value, "")
                    tbl(0).Item(tbl.定番品区分Column.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.定番品区分.Value, "")
                    tbl(0).Item(tbl.在庫区分Column.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.在庫区分.Value, "")
                    tbl(0).Item(tbl.得意先CDColumn.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.得意先CD.Value, "")
                    tbl(0).Item(tbl.御客様NOColumn.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.御客様NO.Value, "")
                    tbl(0).Item(tbl.適正在庫数Column.ColumnName) = BaseCore.Common.Text.Nz(BaseCore.Common.Text.CVal(Me.Fields.Header.適正在庫数.Value), 0)
                    tbl(0).Item(tbl.売上単価Column.ColumnName) = BaseCore.Common.Text.Nz(BaseCore.Common.Text.CVal(Me.Fields.Header.売上単価.Value), 0)
                    tbl(0).Item(tbl.在庫単価Column.ColumnName) = BaseCore.Common.Text.Nz(BaseCore.Common.Text.CVal(Me.Fields.Header.在庫単価.Value), 0)
                    tbl(0).Item(tbl.本台帳NOColumn.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.本台帳NO.Value, "")
                    tbl(0).Item(tbl.本台帳NO連番Column.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.本台帳NO連番.Value, "")
                    tbl(0).Item(tbl.ヤマト区分Column.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.ヤマト区分.Value, "")
                    tbl(0).Item(tbl.ヤマト種別Column.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.ヤマト種別.Value, "")
                    tbl(0).Item(tbl.表記用単価Column.ColumnName) = BaseCore.Common.Text.Nz(BaseCore.Common.Text.CVal(Me.Fields.Header.表記用単価.Value), 0)
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
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M品名TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M品名DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.品名CDColumn.ColumnName, Me.Fields.Header.品名CD.Value, BaseDatabase.Contents.Compare.Equal))

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
            Me.Fields.Header.品名CD.IsError = False
            Me.Fields.Header.品名.IsError = False
            Me.Fields.Header.摘要.IsError = False
            Me.Fields.Header.定番品区分.IsError = False
            Me.Fields.Header.定番品区分名.IsError = False
            Me.Fields.Header.在庫区分.IsError = False
            Me.Fields.Header.在庫区分名.IsError = False
            Me.Fields.Header.得意先CD.IsError = False
            Me.Fields.Header.得意先名.IsError = False
            Me.Fields.Header.御客様NO.IsError = False
            Me.Fields.Header.適正在庫数.IsError = False
            Me.Fields.Header.売上単価.IsError = False
            Me.Fields.Header.在庫単価.IsError = False
            Me.Fields.Header.本台帳NO.IsError = False
            Me.Fields.Header.本台帳NO連番.IsError = False
            Me.Fields.Header.ヤマト区分.IsError = False
            Me.Fields.Header.ヤマト区分名.IsError = False
            Me.Fields.Header.ヤマト種別.IsError = False
            Me.Fields.Header.ヤマト種別名.IsError = False
            Me.Fields.Header.表記用単価.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            Validator.BaseChecker(Me.Fields.Header.品名CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.品名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.摘要, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.定番品区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.定番品区分名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.在庫区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.在庫区分名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.得意先CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.得意先名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.御客様NO, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.適正在庫数, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.売上単価, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.在庫単価, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.本台帳NO, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.本台帳NO連番, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.ヤマト区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.ヤマト区分名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.ヤマト種別, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.ヤマト種別名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.表記用単価, strMsg, Me.ControlError)

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
