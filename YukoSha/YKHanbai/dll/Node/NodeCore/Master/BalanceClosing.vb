Namespace Frame.Master
    Partial Public Class BalanceClosing
        Inherits NodeCore.Common.Frame

#Region "ﾌｨｰﾙﾄﾞ定義"
        Public Class Header
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 得意先CD As BaseCore.Common.Field.ItemData
            Public 得意先名 As BaseCore.Common.Field.ItemData
            Public 締日 As BaseCore.Common.Field.ItemData

            Public 締切日付 As BaseCore.Common.Field.ItemData
            Public 締切残高 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0残高締切DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.得意先CD = New BaseCore.Common.Field.ItemData(tbl.得意先CDColumn)
                Me.得意先名 = New BaseCore.Common.Field.ItemData(tbl.得意先名Column)
                Me.締日 = New BaseCore.Common.Field.ItemData(tbl.締日Column)

                Me.締切日付 = New BaseCore.Common.Field.ItemData(tbl.締切日付Column)
                Me.締切残高 = New BaseCore.Common.Field.ItemData(tbl.締切残高Column, NodeContents.Constant.桁数.取引額.整数, NodeContents.Constant.桁数.取引額.小数)
            End Sub
        End Class

        Public Class Detail1
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 締切日付 As BaseCore.Common.Field.ItemData
            Public 締切残高 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0残高締切DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.締切日付 = New BaseCore.Common.Field.ItemData(tbl.締切日付Column)
                Me.締切残高 = New BaseCore.Common.Field.ItemData(tbl.締切残高Column, NodeContents.Constant.桁数.取引額.整数, NodeContents.Constant.桁数.取引額.小数)
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
                Me.Fields.Header.得意先CD.Value = Nothing
                Me.Fields.Header.得意先名.Value = Nothing
                Me.Fields.Header.締日.Value = Nothing
            End If

            '----------------------------------------------------------------------
            ' ﾃﾞｰﾀ部ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Fields.Header.締切日付.Value = Nothing
            Me.Fields.Header.締切残高.Value = Nothing

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
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0残高締切TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0残高締切DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' ｷｰ項目以外 ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Clear_Header(False)

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Me.Fields.Header.得意先CD.Value, BaseDatabase.Contents.Compare.Equal))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            tbl = ada.SelectByCommon(qry)
            If tbl.Count > 0 Then
                Me.Fields.Header.得意先CD.Value = tbl(0).Item(tbl.得意先CDColumn.ColumnName)
                Me.Fields.Header.得意先名.Value = tbl(0).Item(tbl.得意先名Column.ColumnName)
                Me.Fields.Header.締日.Value = tbl(0).Item(tbl.締日Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "Valid(Write)"
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
            Me.Fields.Header.締日.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            Validator.BaseChecker(Me.Fields.Header.得意先CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.得意先名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.締日, strMsg, Me.ControlError)

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
        ''' <SUMMARY>ﾍｯﾀﾞ(個別)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Valid_Write_Header_Another() As NodeContents.ActionButton.ErrorLevel
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim strMsg As String = ""
            Dim Validator As New BaseCore.Common.Validator

            '------------------------------------------------------------------
            ' 個別検査
            '------------------------------------------------------------------
            '-------------------------------------
            ' 存在検査
            '-------------------------------------
            If strMsg = "" Then
                Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0得意先TableAdapter
                Dim tbl As New NodeDatabase.DataSetView.V0得意先DataTable
                Dim qry As New Collection

                qry.Clear()
                qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Me.Fields.Header.得意先CD.Value, BaseDatabase.Contents.Compare.Equal))
                tbl = ada.SelectByCommon(qry)
                If tbl.Count = 0 Then
                    Validator.SetMessage(strMsg, "得意先マスタに未登録です。", Me.ControlError, Me.Fields.Header.得意先CD)
                End If
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

#Region "Valid(RowAdd)"
        '''========================================================================================
        ''' <SUMMARY>検査(共通)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Protected Overrides Function Valid_RowAdd_Header_Common() As NodeContents.ActionButton.ErrorLevel
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim strMsg As String = ""
            Dim Validator As New BaseCore.Common.Validator

            '------------------------------------------------------------------
            ' ｴﾗｰｸﾘｱ
            '------------------------------------------------------------------
            Me.Fields.Header.締切日付.IsError = False
            Me.Fields.Header.締切残高.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            Validator.BaseChecker(Me.Fields.Header.締切日付, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.締切残高, strMsg, Me.ControlError)

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
            Me.Fields.Detail1(Index).締切日付.Value = Nothing
            Me.Fields.Detail1(Index).締切残高.Value = Nothing
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
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0残高締切TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0残高締切DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Me.Fields.Header.得意先CD.Value, BaseDatabase.Contents.Compare.Equal))

            Dim strSort As String = ""
            Dim strDelim As String = ""

            strSort &= strDelim & tbl.締切日付Column.ColumnName : strDelim = ","

            tbl = ada.SelectByCommon(qry, strSort)

            '----------------------------------------------------------------------
            ' ﾌﾚｰﾑ作成
            '----------------------------------------------------------------------
            Me.Add_Detail1(tbl.Count)

            '----------------------------------------------------------------------
            ' 値設定
            '----------------------------------------------------------------------
            For i As Integer = 0 To tbl.Rows.Count - 1
                Me.Fields.Detail1(i).締切日付.Value = tbl(i).Item(tbl.締切日付Column.ColumnName)
                Me.Fields.Detail1(i).締切残高.Value = tbl(i).Item(tbl.締切残高Column.ColumnName)
            Next

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
        Protected Overrides Function Write_Detail1() As Boolean
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetTranTableAdapters.T残高締切TableAdapter
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 登録
            '----------------------------------------------------------------------
            Try
                Using scope As New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, TimeSpan.Zero)
                    '-------------------------------------
                    ' 登録
                    '-------------------------------------
                    For i As Integer = 0 To Me.Fields.Detail1.Count - 1
                        If Me.Empty_Detail1(Me.Fields.Detail1(i)) Then
                            Continue For
                        End If

                        Me.RowCount = Me.RowCount + 1

                        ada.Insert(Me.Fields.Header.得意先CD.Value _
                                 , Me.Fields.Detail1(i).締切日付.Value _
                                 , BaseCore.Common.Text.CVal(Me.Fields.Detail1(i).締切残高.Value) _
                                  )
                    Next
                    '-------------------------------------
                    ' COMMIT
                    '-------------------------------------
                    scope.Complete()
                End Using

            Catch ex As Exception
                MyBase.LastError = "以下のエラーのため、追加できませんでした。" & vbCrLf & ex.Message
                Return False
            End Try

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
        Protected Overrides Function Delete_Detail1() As Boolean
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetTranTableAdapters.T残高締切TableAdapter
            Dim tbl As New NodeDatabase.DataSetTran.T残高締切DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 削除
            '----------------------------------------------------------------------
            Try
                Using scope As New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, TimeSpan.Zero)
                    '-------------------------------------
                    ' 削除
                    '-------------------------------------
                    qry.Clear()
                    qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Me.Fields.Header.得意先CD.Value, BaseDatabase.Contents.Compare.Equal))
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

#Region "Valid(Write)"
        '''========================================================================================
        ''' <summary>検査</summary>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Protected Overrides Function Valid_Write_Detail1_Common() As NodeContents.ActionButton.ErrorLevel
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim strMsg As String = ""
            Dim Validator As New BaseCore.Common.Validator

            '------------------------------------------------------------------
            ' ｴﾗｰｸﾘｱ
            '------------------------------------------------------------------
            For i As Integer = 0 To Me.Fields.Detail1.Count - 1
                Me.Fields.Detail1(i).締切日付.IsError = False
                Me.Fields.Detail1(i).締切残高.IsError = False
            Next

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            For i As Integer = 0 To Me.Fields.Detail1.Count - 1
                If Me.Empty_Detail1(Me.Fields.Detail1(i)) Then
                    Continue For
                End If

                Validator.BaseChecker(Me.Fields.Detail1(i).締切日付, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).締切残高, strMsg, Me.ControlError)
            Next

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
        ''' <summary>検査</summary>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Protected Overrides Function Valid_Write_Detail1_Another() As NodeContents.ActionButton.ErrorLevel
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim strMsg As String = ""
            Dim Validator As New BaseCore.Common.Validator

            '------------------------------------------------------------------
            ' 個別検査
            '------------------------------------------------------------------
            '-------------------------------------
            ' 重複検査
            '-------------------------------------
            If strMsg = "" Then
                Dim strKey As String
                Dim arrDupl As New Hashtable

                For i As Integer = 0 To Me.Fields.Detail1.Count - 1
                    If Me.Empty_Detail1(Me.Fields.Detail1(i)) Then
                        Continue For
                    End If

                    strKey = Me.Fields.Detail1(i).締切日付.Value
                    If arrDupl.ContainsKey(strKey) Then
                        Validator.SetMessage(strMsg, "締切日付が重複している為、処理できません。(@0)".Replace("@0", strKey), Me.ControlError, Me.Fields.Header.締切日付)
                        Exit For
                    End If

                    arrDupl.Add(strKey, strKey)
                Next
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

#Region "無効行判定"
        '''========================================================================================
        ''' <summary>無効行の判定</summary>
        ''' <param name="Detail">明細行</param>
        ''' <returns>True:無効行, False:有効行</returns>
        '''========================================================================================
        Protected Overrides Function Empty_Detail1(ByVal Detail As Object) As Boolean
            '------------------------------------------------------------------
            ' 変数定義
            '------------------------------------------------------------------
            Dim row As Detail1 = CType(Detail, Detail1)

            '------------------------------------------------------------------
            ' 入力有は有効行
            '------------------------------------------------------------------
            Select Case True
                Case Not BaseCore.Common.Text.IsEmptyOrZero(row.締切日付.Value) : Return False
            End Select

            '------------------------------------------------------------------
            ' 無効行
            '------------------------------------------------------------------
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
            Me.Fields.Detail1(IndexT).締切日付.Value = Me.Fields.Detail1(IndexF).締切日付.Value
            Me.Fields.Detail1(IndexT).締切残高.Value = Me.Fields.Detail1(IndexF).締切残高.Value
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
#End Region
    End Class
End Namespace
