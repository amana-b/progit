Namespace Frame.Master
    Partial Public Class ClosingDateBalance
        Inherits NodeCore.Common.Frame

#Region "ﾌｨｰﾙﾄﾞ定義"
        Public Class Header
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 処理登録 As BaseCore.Common.Field.ItemData
            Public 処理修正 As BaseCore.Common.Field.ItemData
            Public 処理削除 As BaseCore.Common.Field.ItemData

            Public 得意先CD As BaseCore.Common.Field.ItemData
            Public 締日 As BaseCore.Common.Field.ItemData

            Public 得意先名 As BaseCore.Common.Field.ItemData
            Public 表示締日 As BaseCore.Common.Field.ItemData
            Public 期首残高 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0締日残高DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                'Me.処理登録 = New BaseCore.Common.Field.ItemData("処理登録", TypeCode.String, 1)
                'Me.処理修正 = New BaseCore.Common.Field.ItemData("処理修正", TypeCode.String, 1)
                'Me.処理削除 = New BaseCore.Common.Field.ItemData("処理削除", TypeCode.String, 1)

                Me.得意先CD = New BaseCore.Common.Field.ItemData(tbl.得意先CDColumn)
                Me.締日 = New BaseCore.Common.Field.ItemData(tbl.締日Column)

                Me.得意先名 = New BaseCore.Common.Field.ItemData(tbl.得意先名Column)
                Me.表示締日 = New BaseCore.Common.Field.ItemData(tbl.表示締日Column)
                Me.期首残高 = New BaseCore.Common.Field.ItemData(tbl.期首残高Column, 11, 0)
            End Sub
        End Class

        Public Class Detail1
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public NO As BaseCore.Common.Field.ItemData
            Public 締切対象年月日 As BaseCore.Common.Field.ItemData
            Public 請求残高 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0締日残高DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.NO = New BaseCore.Common.Field.ItemData("NO", TypeCode.Int16, 3, 0)
                Me.締切対象年月日 = New BaseCore.Common.Field.ItemData(tbl.締日Column)
                Me.請求残高 = New BaseCore.Common.Field.ItemData(tbl.期首残高Column, 11, 0)
            End Sub
        End Class

        Public Class Paramater
            Public Header As Header
            Public Detail1 As New List(Of Detail1)
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

#Region "ﾍｯﾀﾞ"
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
                'Me.Fields.Header.処理登録.Value = NodeContents.Constant.CodeValue.フラグ.オン
                'Me.Fields.Header.処理修正.Value = NodeContents.Constant.CodeValue.フラグ.オフ
                'Me.Fields.Header.処理削除.Value = NodeContents.Constant.CodeValue.フラグ.オフ
                Me.Fields.Header.得意先CD.Value = Nothing
                Me.Fields.Header.締日.Value = Nothing
            End If

            '----------------------------------------------------------------------
            ' ﾃﾞｰﾀ部ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Fields.Header.得意先名.Value = Nothing
            Me.Fields.Header.表示締日.Value = Nothing
            Me.Fields.Header.期首残高.Value = Nothing

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
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0締日残高TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0締日残高DataTable
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

            Me.Fields.Header.得意先名.Value = tbl(0).Item(tbl.得意先名Column.ColumnName)
            Me.Fields.Header.表示締日.Value = tbl(0).Item(tbl.表示締日Column.ColumnName)
            Me.Fields.Header.締日.Value = tbl(0).Item(tbl.締日Column.ColumnName)
            Me.Fields.Header.期首残高.Value = tbl(0).Item(tbl.期首残高Column.ColumnName)

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
            'Me.Fields.Header.処理登録.IsError = False
            'Me.Fields.Header.処理修正.IsError = False
            'Me.Fields.Header.処理削除.IsError = False
            Me.Fields.Header.得意先CD.IsError = False
            Me.Fields.Header.締日.IsError = False
            Me.Fields.Header.期首残高.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            'Validator.BaseChecker(Me.Fields.Header.処理登録, strMsg, Me.ControlError)
            'Validator.BaseChecker(Me.Fields.Header.処理修正, strMsg, Me.ControlError)
            'Validator.BaseChecker(Me.Fields.Header.処理削除, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.得意先CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.締日, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.期首残高, strMsg, Me.ControlError)

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
#End Region

#Region "明細"
#Region "Clear"
        '''========================================================================================
        ''' <SUMMARY>ｸﾘｱ</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Clear_Detail1() As Boolean
            '----------------------------------------------------------------------
            ' 行削除
            '----------------------------------------------------------------------
            Me.Fields.Detail1.Clear()

            '----------------------------------------------------------------------
            ' ｸﾘｱ
            '----------------------------------------------------------------------
            For i As Integer = 0 To Me.Fields.Detail1.Count - 1
                Me.Clear_Detail1(i)
            Next

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function

        Public Overrides Function Clear_Detail1(ByVal Index As Integer) As Boolean
            Me.Fields.Detail1(Index).NO.Value = Index + 1
            Me.Fields.Detail1(Index).締切対象年月日.Value = Nothing
            Me.Fields.Detail1(Index).請求残高.Value = Nothing
        End Function
#End Region

#Region "Read"
        '''========================================================================================
        ''' <SUMMARY>読込</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Read_Detail1() As Boolean
            '----------------------------------------------------------------------
            ' 読み込み
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0締日残高TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0締日残高DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Me.Fields.Header.得意先CD.Value, BaseDatabase.Contents.Compare.Equal))

            Dim strSort As String = ""
            Dim strDelim As String = ""

            strSort &= strDelim & tbl.締日Column.ColumnName : strDelim = ","

            tbl = ada.SelectByCommon(qry, strSort)

            '----------------------------------------------------------------------
            ' ﾌﾚｰﾑ作成
            '----------------------------------------------------------------------
            Me.Add_Detail1(tbl.Count)

            '----------------------------------------------------------------------
            ' 値設定
            '----------------------------------------------------------------------
            For i As Integer = 0 To tbl.Rows.Count - 1
                Me.Fields.Detail1(i).NO.Value = i + 1
                Me.Fields.Detail1(i).締切対象年月日.Value = tbl(i).Item(tbl.締日Column.ColumnName)
                Me.Fields.Detail1(i).請求残高.Value = tbl(i).Item(tbl.期首残高Column.ColumnName)
            Next

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "行挿入"
        '''========================================================================================
        ''' <summary>単一行挿入</summary>
        '''========================================================================================
        Public Overrides Sub Insert_Detail1(ByVal Position As Integer)
            '----------------------------------------------------------------------
            ' 行挿入
            '----------------------------------------------------------------------
            Me.Fields.Detail1.Insert(Position, New Detail1(Me.Config))

            '----------------------------------------------------------------------
            ' 行ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Clear_Detail1(Position)

            '----------------------------------------------------------------------
            ' 行番号の再付番
            '----------------------------------------------------------------------
            Me.ReNum_Detail1()
        End Sub

        '''========================================================================================
        ''' <summary>複数行挿入</summary>
        '''========================================================================================
        Public Overrides Sub Insert_Detail1(ByVal Position As Integer, ByVal Count As Integer)
            '----------------------------------------------------------------------
            ' 行挿入 & 行ｸﾘｱ
            '----------------------------------------------------------------------
            For i As Integer = Position To Position + Count - 1
                Me.Fields.Detail1.Insert(Position, New Detail1(Me.Config))
                Me.Clear_Detail1(Position)
            Next

            '----------------------------------------------------------------------
            ' 行番号の再付番
            '----------------------------------------------------------------------
            Me.ReNum_Detail1()
        End Sub
#End Region

#Region "行複写"
        '''========================================================================================
        ''' <summary>単一行複写</summary>
        '''========================================================================================
        Public Overrides Sub Copy_Detail1(ByVal Position As Integer)
            '----------------------------------------------------------------------
            ' 行挿入
            '----------------------------------------------------------------------
            Me.Fields.Detail1.Insert(Position, New Detail1(Me.Config))

            '----------------------------------------------------------------------
            ' 行ｺﾋﾟｰ
            '----------------------------------------------------------------------
            Me.CopyValue_Detail1(Position + 1, Position)

            '----------------------------------------------------------------------
            ' 行番号の再付番
            '----------------------------------------------------------------------
            Me.ReNum_Detail1()
        End Sub

        '''========================================================================================
        ''' <summary>値ｺﾋﾟｰ</summary>
        '''========================================================================================
        Protected Function CopyValue_Detail1(ByVal IndexF As Integer, ByVal IndexT As Integer) As Boolean
            Me.Fields.Detail1(IndexT).NO.Value = Me.Fields.Detail1(IndexF).NO.Value
            Me.Fields.Detail1(IndexT).締切対象年月日.Value = Me.Fields.Detail1(IndexF).締切対象年月日.Value
            Me.Fields.Detail1(IndexT).請求残高.Value = Me.Fields.Detail1(IndexF).請求残高.Value
        End Function
#End Region

#Region "行追加"
        '''========================================================================================
        ''' <summary>単一行追加</summary>
        '''========================================================================================
        Public Overrides Sub Add_Detail1()
            Me.Fields.Detail1.Add(New Detail1(Me.Config))
            Me.Clear_Detail1(Me.Fields.Detail1.Count - 1)
        End Sub

        '''========================================================================================
        ''' <summary>一括行追加</summary>
        ''' <param name="AddCount">追加行数</param>
        '''========================================================================================
        Public Overrides Sub Add_Detail1(ByVal AddCount As Integer, Optional Clear As Boolean = True)
            If Clear Then
                Me.Fields.Detail1.Clear()
            End If

            For i As Integer = 0 To AddCount - 1
                Me.Add_Detail1()
            Next
        End Sub
#End Region

#Region "行削除"
        '''========================================================================================
        ''' <summary>一括行削除</summary>
        '''========================================================================================
        Public Overrides Sub Del_Detail1()
            Me.Fields.Detail1.Clear()
        End Sub

        '''========================================================================================
        ''' <summary>一括行削除</summary>
        '''========================================================================================
        Public Overrides Sub Del_Detail1(ByVal Position As Integer)
            Me.Fields.Detail1.RemoveAt(Position)
        End Sub
#End Region

#Region "行番号の再付番"
        '''========================================================================================
        ''' <summary>行番号の再付番</summary>
        '''========================================================================================
        Public Overrides Sub ReNum_Detail1()
            For i As Integer = 0 To Me.Fields.Detail1.Count - 1
                Me.Fields.Detail1(i).NO.Value = i + 1
            Next
        End Sub
#End Region
#End Region
    End Class
End Namespace
