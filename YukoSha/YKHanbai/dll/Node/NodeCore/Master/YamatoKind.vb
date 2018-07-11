﻿Namespace Frame.Master
    Partial Public Class YamatoKind
        Inherits NodeCore.Common.Frame

#Region "ﾌｨｰﾙﾄﾞ定義"
        Public Class Header
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public ヤマト区分 As BaseCore.Common.Field.ItemData
            Public ヤマト区分名 As BaseCore.Common.Field.ItemData
            Public ヤマト種別 As BaseCore.Common.Field.ItemData
            Public ヤマト種別名 As BaseCore.Common.Field.ItemData
            Public 品名CD As BaseCore.Common.Field.ItemData
            Public 品名 As BaseCore.Common.Field.ItemData

            Public 処理登録 As BaseCore.Common.Field.ItemData
            Public 処理修正 As BaseCore.Common.Field.ItemData
            Public 処理削除 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0ヤマト種別DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.ヤマト区分 = New BaseCore.Common.Field.ItemData(tbl.ヤマト区分Column)
                Me.ヤマト区分名 = New BaseCore.Common.Field.ItemData(tbl.ヤマト区分名Column)
                Me.ヤマト種別 = New BaseCore.Common.Field.ItemData(tbl.ヤマト種別Column)
                Me.ヤマト種別名 = New BaseCore.Common.Field.ItemData(tbl.ヤマト種別名Column)
                Me.品名CD = New BaseCore.Common.Field.ItemData(tbl.品名CDColumn)
                Me.品名 = New BaseCore.Common.Field.ItemData(tbl.品名Column)

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
                Me.Fields.Header.ヤマト区分.Value = Nothing
                Me.Fields.Header.ヤマト種別.Value = Nothing
                Me.Fields.Header.処理登録.Value = NodeContents.Constant.CodeValue.フラグ.オン
                Me.Fields.Header.処理修正.Value = NodeContents.Constant.CodeValue.フラグ.オフ
                Me.Fields.Header.処理削除.Value = NodeContents.Constant.CodeValue.フラグ.オフ
            End If

            '----------------------------------------------------------------------
            ' ﾃﾞｰﾀ部ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Fields.Header.ヤマト区分名.Value = Nothing
            Me.Fields.Header.ヤマト種別名.Value = Nothing
            Me.Fields.Header.品名CD.Value = Nothing
            Me.Fields.Header.品名.Value = Nothing

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
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0ヤマト種別TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0ヤマト種別DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.ヤマト区分Column.ColumnName, Me.Fields.Header.ヤマト区分.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.ヤマト種別Column.ColumnName, Me.Fields.Header.ヤマト種別.Value, BaseDatabase.Contents.Compare.Equal))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            tbl = ada.SelectByCommon(qry)
            If tbl.Count = 0 Then
                Return False
            End If

            Me.Fields.Header.ヤマト区分.Value = tbl(0).Item(tbl.ヤマト区分Column.ColumnName)
            Me.Fields.Header.ヤマト区分名.Value = tbl(0).Item(tbl.ヤマト区分名Column.ColumnName)
            Me.Fields.Header.ヤマト種別.Value = tbl(0).Item(tbl.ヤマト種別Column.ColumnName)
            Me.Fields.Header.ヤマト種別名.Value = tbl(0).Item(tbl.ヤマト種別名Column.ColumnName)
            Me.Fields.Header.品名CD.Value = tbl(0).Item(tbl.品名CDColumn.ColumnName)
            Me.Fields.Header.品名.Value = tbl(0).Item(tbl.品名Column.ColumnName)

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

            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.Mヤマト種別TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.Mヤマト種別DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.ヤマト区分Column.ColumnName, Me.Fields.Header.ヤマト区分.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.ヤマト種別Column.ColumnName, Me.Fields.Header.ヤマト種別.Value, BaseDatabase.Contents.Compare.Equal))

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
                               BaseCore.Common.Text.Nz(Me.Fields.Header.ヤマト区分.Value, "") _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.ヤマト種別.Value, "") _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.ヤマト種別名.Value, "") _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.品名CD.Value, "") _
                              )
                Else
                    '-------------------------------------
                    ' 訂正
                    '-------------------------------------
                    tbl(0).Item(tbl.ヤマト区分Column.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.ヤマト区分.Value, "")
                    tbl(0).Item(tbl.ヤマト種別Column.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.ヤマト種別.Value, "")
                    tbl(0).Item(tbl.ヤマト種別名Column.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.ヤマト種別名.Value, "")
                    tbl(0).Item(tbl.品名CDColumn.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.品名CD.Value, "")
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
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.Mヤマト種別TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.Mヤマト種別DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.ヤマト区分Column.ColumnName, Me.Fields.Header.ヤマト区分.Value, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.ヤマト種別Column.ColumnName, Me.Fields.Header.ヤマト種別.Value, BaseDatabase.Contents.Compare.Equal))

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
            Me.Fields.Header.ヤマト区分.IsError = False
            Me.Fields.Header.ヤマト種別.IsError = False
            Me.Fields.Header.ヤマト種別名.IsError = False
            Me.Fields.Header.品名CD.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            Validator.BaseChecker(Me.Fields.Header.ヤマト区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.ヤマト種別, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.ヤマト種別名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.品名CD, strMsg, Me.ControlError)

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
