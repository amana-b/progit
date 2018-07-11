Namespace Frame.Master
    Partial Public Class YamatoDate
        Inherits NodeCore.Common.Frame

#Region "ﾌｨｰﾙﾄﾞ定義"
        Public Class Header
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public ヤマト区分 As BaseCore.Common.Field.ItemData
            Public ヤマト区分名 As BaseCore.Common.Field.ItemData
            Public 略称 As BaseCore.Common.Field.ItemData
            Public 種別内訳区分 As BaseCore.Common.Field.ItemData
            Public 種別内訳区分名 As BaseCore.Common.Field.ItemData
            Public 入数 As BaseCore.Common.Field.ItemData
            Public 最大ケース数 As BaseCore.Common.Field.ItemData
            Public 受注単価 As BaseCore.Common.Field.ItemData
            Public 品名CD As BaseCore.Common.Field.ItemData
            Public 品名 As BaseCore.Common.Field.ItemData
            Public 光村印刷得意先CD As BaseCore.Common.Field.ItemData
            Public 光村印刷得意先名 As BaseCore.Common.Field.ItemData
            Public 光村印刷出荷先CD As BaseCore.Common.Field.ItemData
            Public 光村印刷出荷先名 As BaseCore.Common.Field.ItemData
            Public 材料請求時単価 As BaseCore.Common.Field.ItemData
            Public 材料請求時品名 As BaseCore.Common.Field.ItemData
            Public クロネコメール便バーコード開始NO1 As BaseCore.Common.Field.ItemData
            Public クロネコメール便バーコード開始NO2 As BaseCore.Common.Field.ItemData
            Public クロネコメール便バーコード開始NO3 As BaseCore.Common.Field.ItemData
            Public クロネコメール便バーコード終了NO1 As BaseCore.Common.Field.ItemData
            Public クロネコメール便バーコード終了NO2 As BaseCore.Common.Field.ItemData
            Public クロネコメール便バーコード終了NO3 As BaseCore.Common.Field.ItemData
            Public クロネコメール便バーコード次回発番NO1 As BaseCore.Common.Field.ItemData
            Public クロネコメール便バーコード次回発番NO2 As BaseCore.Common.Field.ItemData
            Public クロネコメール便バーコード次回発番NO3 As BaseCore.Common.Field.ItemData

            Public 処理登録 As BaseCore.Common.Field.ItemData
            Public 処理修正 As BaseCore.Common.Field.ItemData
            Public 処理削除 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0ヤマト区分DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.ヤマト区分 = New BaseCore.Common.Field.ItemData(tbl.ヤマト区分Column)
                Me.ヤマト区分名 = New BaseCore.Common.Field.ItemData(tbl.ヤマト区分名Column)
                Me.略称 = New BaseCore.Common.Field.ItemData(tbl.略称Column)
                Me.種別内訳区分 = New BaseCore.Common.Field.ItemData(tbl.種別内訳区分Column)
                Me.種別内訳区分名 = New BaseCore.Common.Field.ItemData(tbl.種別内訳区分名Column)
                Me.入数 = New BaseCore.Common.Field.ItemData(tbl.入数Column, 7, 0)
                Me.最大ケース数 = New BaseCore.Common.Field.ItemData(tbl.最大ケース数Column, 3, 0)
                Me.受注単価 = New BaseCore.Common.Field.ItemData(tbl.受注単価Column, NodeContents.Constant.桁数.金額.整数, NodeContents.Constant.桁数.金額.小数)
                Me.品名CD = New BaseCore.Common.Field.ItemData(tbl.品名CDColumn)
                Me.品名 = New BaseCore.Common.Field.ItemData(tbl.品名Column)
                Me.光村印刷得意先CD = New BaseCore.Common.Field.ItemData(tbl.光村印刷得意先CDColumn)
                Me.光村印刷得意先名 = New BaseCore.Common.Field.ItemData(tbl.光村印刷得意先名Column)
                Me.光村印刷出荷先CD = New BaseCore.Common.Field.ItemData(tbl.光村印刷出荷先CDColumn)
                Me.光村印刷出荷先名 = New BaseCore.Common.Field.ItemData(tbl.光村印刷出荷先名Column)
                Me.材料請求時単価 = New BaseCore.Common.Field.ItemData(tbl.材料請求時単価Column, NodeContents.Constant.桁数.金額.整数, NodeContents.Constant.桁数.金額.小数)
                Me.材料請求時品名 = New BaseCore.Common.Field.ItemData(tbl.材料請求時品名Column)
                Me.クロネコメール便バーコード開始NO1 = New BaseCore.Common.Field.ItemData(tbl.クロネコメール便バーコード開始NOColumn, 4)
                Me.クロネコメール便バーコード開始NO2 = New BaseCore.Common.Field.ItemData(tbl.クロネコメール便バーコード開始NOColumn, 4)
                Me.クロネコメール便バーコード開始NO3 = New BaseCore.Common.Field.ItemData(tbl.クロネコメール便バーコード開始NOColumn, 3)
                Me.クロネコメール便バーコード終了NO1 = New BaseCore.Common.Field.ItemData(tbl.クロネコメール便バーコード終了NOColumn, 4)
                Me.クロネコメール便バーコード終了NO2 = New BaseCore.Common.Field.ItemData(tbl.クロネコメール便バーコード終了NOColumn, 4)
                Me.クロネコメール便バーコード終了NO3 = New BaseCore.Common.Field.ItemData(tbl.クロネコメール便バーコード終了NOColumn, 3)
                Me.クロネコメール便バーコード次回発番NO1 = New BaseCore.Common.Field.ItemData(tbl.クロネコメール便バーコード次回発番NOColumn, 4)
                Me.クロネコメール便バーコード次回発番NO2 = New BaseCore.Common.Field.ItemData(tbl.クロネコメール便バーコード次回発番NOColumn, 4)
                Me.クロネコメール便バーコード次回発番NO3 = New BaseCore.Common.Field.ItemData(tbl.クロネコメール便バーコード次回発番NOColumn, 3)

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
                Me.Fields.Header.処理登録.Value = NodeContents.Constant.CodeValue.フラグ.オン
                Me.Fields.Header.処理修正.Value = NodeContents.Constant.CodeValue.フラグ.オフ
                Me.Fields.Header.処理削除.Value = NodeContents.Constant.CodeValue.フラグ.オフ
            End If

            '----------------------------------------------------------------------
            ' ﾃﾞｰﾀ部ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Fields.Header.ヤマト区分名.Value = Nothing
            Me.Fields.Header.略称.Value = Nothing
            Me.Fields.Header.種別内訳区分.Value = Nothing
            Me.Fields.Header.種別内訳区分名.Value = Nothing
            Me.Fields.Header.入数.Value = Nothing
            Me.Fields.Header.最大ケース数.Value = Nothing
            Me.Fields.Header.受注単価.Value = Nothing
            Me.Fields.Header.品名CD.Value = Nothing
            Me.Fields.Header.品名.Value = Nothing
            Me.Fields.Header.光村印刷得意先CD.Value = Nothing
            Me.Fields.Header.光村印刷得意先名.Value = Nothing
            Me.Fields.Header.光村印刷出荷先CD.Value = Nothing
            Me.Fields.Header.光村印刷出荷先名.Value = Nothing
            Me.Fields.Header.材料請求時単価.Value = Nothing
            Me.Fields.Header.材料請求時品名.Value = Nothing
            Me.Fields.Header.クロネコメール便バーコード開始NO1.Value = Nothing
            Me.Fields.Header.クロネコメール便バーコード開始NO2.Value = Nothing
            Me.Fields.Header.クロネコメール便バーコード開始NO3.Value = Nothing
            Me.Fields.Header.クロネコメール便バーコード終了NO1.Value = Nothing
            Me.Fields.Header.クロネコメール便バーコード終了NO2.Value = Nothing
            Me.Fields.Header.クロネコメール便バーコード終了NO3.Value = Nothing
            Me.Fields.Header.クロネコメール便バーコード次回発番NO1.Value = Nothing
            Me.Fields.Header.クロネコメール便バーコード次回発番NO2.Value = Nothing
            Me.Fields.Header.クロネコメール便バーコード次回発番NO3.Value = Nothing

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
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0ヤマト区分TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0ヤマト区分DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.ヤマト区分Column.ColumnName, Me.Fields.Header.ヤマト区分.Value, BaseDatabase.Contents.Compare.Equal))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            tbl = ada.SelectByCommon(qry)
            If tbl.Count = 0 Then
                Return False
            End If

            Me.Fields.Header.ヤマト区分.Value = tbl(0).Item(tbl.ヤマト区分Column.ColumnName)
            Me.Fields.Header.ヤマト区分名.Value = tbl(0).Item(tbl.ヤマト区分名Column.ColumnName)
            Me.Fields.Header.略称.Value = tbl(0).Item(tbl.略称Column.ColumnName)
            Me.Fields.Header.種別内訳区分.Value = tbl(0).Item(tbl.種別内訳区分Column.ColumnName)
            Me.Fields.Header.種別内訳区分名.Value = tbl(0).Item(tbl.種別内訳区分名Column.ColumnName)
            Me.Fields.Header.入数.Value = tbl(0).Item(tbl.入数Column.ColumnName)
            Me.Fields.Header.最大ケース数.Value = tbl(0).Item(tbl.最大ケース数Column.ColumnName)
            Me.Fields.Header.受注単価.Value = tbl(0).Item(tbl.受注単価Column.ColumnName)
            Me.Fields.Header.品名CD.Value = tbl(0).Item(tbl.品名CDColumn.ColumnName)
            Me.Fields.Header.品名.Value = tbl(0).Item(tbl.品名Column.ColumnName)
            Me.Fields.Header.光村印刷得意先CD.Value = tbl(0).Item(tbl.光村印刷得意先CDColumn.ColumnName)
            Me.Fields.Header.光村印刷得意先名.Value = tbl(0).Item(tbl.光村印刷得意先名Column.ColumnName)
            Me.Fields.Header.光村印刷出荷先CD.Value = tbl(0).Item(tbl.光村印刷出荷先CDColumn.ColumnName)
            Me.Fields.Header.光村印刷出荷先名.Value = tbl(0).Item(tbl.光村印刷出荷先名Column.ColumnName)
            Me.Fields.Header.材料請求時単価.Value = tbl(0).Item(tbl.材料請求時単価Column.ColumnName)
            Me.Fields.Header.材料請求時品名.Value = tbl(0).Item(tbl.材料請求時品名Column.ColumnName)
            Me.Fields.Header.クロネコメール便バーコード開始NO1.Value = BaseCore.Common.Text.MidB(tbl(0).Item(tbl.クロネコメール便バーコード開始NOColumn.ColumnName), 1, 4)
            Me.Fields.Header.クロネコメール便バーコード開始NO2.Value = BaseCore.Common.Text.MidB(tbl(0).Item(tbl.クロネコメール便バーコード開始NOColumn.ColumnName), 5, 4)
            Me.Fields.Header.クロネコメール便バーコード開始NO3.Value = BaseCore.Common.Text.MidB(tbl(0).Item(tbl.クロネコメール便バーコード開始NOColumn.ColumnName), 9, 3)
            Me.Fields.Header.クロネコメール便バーコード終了NO1.Value = BaseCore.Common.Text.MidB(tbl(0).Item(tbl.クロネコメール便バーコード終了NOColumn.ColumnName), 1, 4)
            Me.Fields.Header.クロネコメール便バーコード終了NO2.Value = BaseCore.Common.Text.MidB(tbl(0).Item(tbl.クロネコメール便バーコード終了NOColumn.ColumnName), 5, 4)
            Me.Fields.Header.クロネコメール便バーコード終了NO3.Value = BaseCore.Common.Text.MidB(tbl(0).Item(tbl.クロネコメール便バーコード終了NOColumn.ColumnName), 9, 3)
            Me.Fields.Header.クロネコメール便バーコード次回発番NO1.Value = BaseCore.Common.Text.MidB(tbl(0).Item(tbl.クロネコメール便バーコード次回発番NOColumn.ColumnName), 1, 4)
            Me.Fields.Header.クロネコメール便バーコード次回発番NO2.Value = BaseCore.Common.Text.MidB(tbl(0).Item(tbl.クロネコメール便バーコード次回発番NOColumn.ColumnName), 5, 4)
            Me.Fields.Header.クロネコメール便バーコード次回発番NO3.Value = BaseCore.Common.Text.MidB(tbl(0).Item(tbl.クロネコメール便バーコード次回発番NOColumn.ColumnName), 9, 3)

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

            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.Mヤマト区分TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.Mヤマト区分DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.ヤマト区分Column.ColumnName, Me.Fields.Header.ヤマト区分.Value, BaseDatabase.Contents.Compare.Equal))

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
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.ヤマト区分名.Value, "") _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.略称.Value, "") _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.種別内訳区分.Value, "") _
                             , BaseCore.Common.Text.Nz(BaseCore.Common.Text.CVal(Me.Fields.Header.入数.Value), 0) _
                             , BaseCore.Common.Text.Nz(BaseCore.Common.Text.CVal(Me.Fields.Header.最大ケース数.Value), 0) _
                             , BaseCore.Common.Text.Nz(BaseCore.Common.Text.CVal(Me.Fields.Header.受注単価.Value), 0) _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.品名CD.Value, "") _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.光村印刷得意先CD.Value, "") _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.光村印刷出荷先CD.Value, "") _
                             , BaseCore.Common.Text.Nz(BaseCore.Common.Text.CVal(Me.Fields.Header.材料請求時単価.Value), 0) _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.材料請求時品名.Value, "") _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.クロネコメール便バーコード開始NO1.Value, "0000") & BaseCore.Common.Text.Nz(Me.Fields.Header.クロネコメール便バーコード開始NO2.Value, "0000") & BaseCore.Common.Text.Nz(Me.Fields.Header.クロネコメール便バーコード開始NO3.Value, "000") _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.クロネコメール便バーコード終了NO1.Value, "0000") & BaseCore.Common.Text.Nz(Me.Fields.Header.クロネコメール便バーコード終了NO2.Value, "0000") & BaseCore.Common.Text.Nz(Me.Fields.Header.クロネコメール便バーコード終了NO3.Value, "000") _
                             , BaseCore.Common.Text.Nz(Me.Fields.Header.クロネコメール便バーコード次回発番NO1.Value, "0000") & BaseCore.Common.Text.Nz(Me.Fields.Header.クロネコメール便バーコード次回発番NO2.Value, "0000") & BaseCore.Common.Text.Nz(Me.Fields.Header.クロネコメール便バーコード次回発番NO3.Value, "000") _
                              )
                Else
                    '-------------------------------------
                    ' 訂正
                    '-------------------------------------
                    tbl(0).Item(tbl.ヤマト区分Column.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.ヤマト区分.Value, "")
                    tbl(0).Item(tbl.ヤマト区分名Column.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.ヤマト区分名.Value, "")
                    tbl(0).Item(tbl.略称Column.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.略称.Value, "")
                    tbl(0).Item(tbl.種別内訳区分Column.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.種別内訳区分.Value, "")
                    tbl(0).Item(tbl.入数Column.ColumnName) = BaseCore.Common.Text.Nz(BaseCore.Common.Text.CVal(Me.Fields.Header.入数.Value), 0)
                    tbl(0).Item(tbl.最大ケース数Column.ColumnName) = BaseCore.Common.Text.Nz(BaseCore.Common.Text.CVal(Me.Fields.Header.最大ケース数.Value), 0)
                    tbl(0).Item(tbl.受注単価Column.ColumnName) = BaseCore.Common.Text.Nz(BaseCore.Common.Text.CVal(Me.Fields.Header.受注単価.Value), 0)
                    tbl(0).Item(tbl.品名CDColumn.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.品名CD.Value, "")
                    tbl(0).Item(tbl.光村印刷得意先CDColumn.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.光村印刷得意先CD.Value, "")
                    tbl(0).Item(tbl.光村印刷出荷先CDColumn.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.光村印刷出荷先CD.Value, "")
                    tbl(0).Item(tbl.材料請求時単価Column.ColumnName) = BaseCore.Common.Text.Nz(BaseCore.Common.Text.CVal(Me.Fields.Header.材料請求時単価.Value), 0)
                    tbl(0).Item(tbl.材料請求時品名Column.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.材料請求時品名.Value, "")
                    tbl(0).Item(tbl.クロネコメール便バーコード開始NOColumn.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.クロネコメール便バーコード開始NO1.Value, "0000") & BaseCore.Common.Text.Nz(Me.Fields.Header.クロネコメール便バーコード開始NO2.Value, "0000") & BaseCore.Common.Text.Nz(Me.Fields.Header.クロネコメール便バーコード開始NO3.Value, "000")
                    tbl(0).Item(tbl.クロネコメール便バーコード終了NOColumn.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.クロネコメール便バーコード終了NO1.Value, "0000") & BaseCore.Common.Text.Nz(Me.Fields.Header.クロネコメール便バーコード終了NO2.Value, "0000") & BaseCore.Common.Text.Nz(Me.Fields.Header.クロネコメール便バーコード終了NO3.Value, "000")
                    tbl(0).Item(tbl.クロネコメール便バーコード次回発番NOColumn.ColumnName) = BaseCore.Common.Text.Nz(Me.Fields.Header.クロネコメール便バーコード次回発番NO1.Value, "0000") & BaseCore.Common.Text.Nz(Me.Fields.Header.クロネコメール便バーコード次回発番NO2.Value, "0000") & BaseCore.Common.Text.Nz(Me.Fields.Header.クロネコメール便バーコード次回発番NO3.Value, "000")
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
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.Mヤマト区分TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.Mヤマト区分DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.ヤマト区分Column.ColumnName, Me.Fields.Header.ヤマト区分.Value, BaseDatabase.Contents.Compare.Equal))

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
            Me.Fields.Header.ヤマト区分名.IsError = False
            Me.Fields.Header.略称.IsError = False
            Me.Fields.Header.種別内訳区分.IsError = False
            Me.Fields.Header.入数.IsError = False
            Me.Fields.Header.最大ケース数.IsError = False
            Me.Fields.Header.受注単価.IsError = False
            Me.Fields.Header.品名CD.IsError = False
            Me.Fields.Header.光村印刷得意先CD.IsError = False
            Me.Fields.Header.光村印刷出荷先CD.IsError = False
            Me.Fields.Header.材料請求時単価.IsError = False
            Me.Fields.Header.材料請求時品名.IsError = False
            Me.Fields.Header.クロネコメール便バーコード開始NO1.IsError = False
            Me.Fields.Header.クロネコメール便バーコード開始NO2.IsError = False
            Me.Fields.Header.クロネコメール便バーコード開始NO3.IsError = False
            Me.Fields.Header.クロネコメール便バーコード終了NO1.IsError = False
            Me.Fields.Header.クロネコメール便バーコード終了NO2.IsError = False
            Me.Fields.Header.クロネコメール便バーコード終了NO3.IsError = False
            Me.Fields.Header.クロネコメール便バーコード次回発番NO1.IsError = False
            Me.Fields.Header.クロネコメール便バーコード次回発番NO2.IsError = False
            Me.Fields.Header.クロネコメール便バーコード次回発番NO3.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            Validator.BaseChecker(Me.Fields.Header.ヤマト区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.ヤマト区分名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.略称, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.種別内訳区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.種別内訳区分名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.入数, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.最大ケース数, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.受注単価, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.品名CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.光村印刷得意先CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.光村印刷出荷先CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.材料請求時単価, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.材料請求時品名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.クロネコメール便バーコード開始NO1, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.クロネコメール便バーコード開始NO2, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.クロネコメール便バーコード開始NO3, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.クロネコメール便バーコード終了NO1, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.クロネコメール便バーコード終了NO2, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.クロネコメール便バーコード終了NO3, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.クロネコメール便バーコード次回発番NO1, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.クロネコメール便バーコード次回発番NO2, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.クロネコメール便バーコード次回発番NO3, strMsg, Me.ControlError)

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
