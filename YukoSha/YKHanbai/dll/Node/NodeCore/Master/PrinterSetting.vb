Namespace Frame.Master
    Partial Public Class PrinterSetting
        Inherits NodeCore.Common.Frame

#Region "ﾌｨｰﾙﾄﾞ定義"
#Region "Header"
        Public Class Header
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 帳票区分 As BaseCore.Common.Field.ItemData
            Public コンピュータ名 As BaseCore.Common.Field.ItemData
            Public プリンタ名 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0特殊帳票DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.帳票区分 = New BaseCore.Common.Field.ItemData(tbl.帳票区分Column)
                Me.コンピュータ名 = New BaseCore.Common.Field.ItemData(tbl.コンピュータ名Column)
                Me.プリンタ名 = New BaseCore.Common.Field.ItemData(tbl.プリンタ名Column)
            End Sub
        End Class
#End Region

#Region "Detail"
        Public Class Detail1
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 行NO As BaseCore.Common.Field.ItemData
            Public コンピュータ名 As BaseCore.Common.Field.ItemData
            Public プリンタ名 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0特殊帳票DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.行NO = New BaseCore.Common.Field.ItemData("行NO", TypeCode.Int16, 4, 0)
                Me.コンピュータ名 = New BaseCore.Common.Field.ItemData(tbl.コンピュータ名Column)
                Me.プリンタ名 = New BaseCore.Common.Field.ItemData(tbl.プリンタ名Column)
            End Sub
        End Class
#End Region

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
                Me.Fields.Header.帳票区分.Value = Nothing
            End If

            '----------------------------------------------------------------------
            ' ﾃﾞｰﾀ部ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Fields.Header.コンピュータ名.Value = Nothing
            Me.Fields.Header.プリンタ名.Value = Nothing

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
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0特殊帳票TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0特殊帳票DataTable
            Dim qry As New Collection

            Dim strSort As String = ""

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.帳票区分Column.ColumnName, Me.Fields.Header.帳票区分.Value, BaseDatabase.Contents.Compare.Equal))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            tbl = ada.SelectByCommon(qry)
            If tbl.Count = 0 Then
                Return False
            End If

            Me.Fields.Header.帳票区分.Value = tbl(0).Item(tbl.帳票区分Column.ColumnName)
            Me.Fields.Header.コンピュータ名.Value = ""
            Me.Fields.Header.プリンタ名.Value = ""

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
            Me.Fields.Header.帳票区分.IsError = False
            Me.Fields.Header.コンピュータ名.IsError = False
            Me.Fields.Header.プリンタ名.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            Validator.BaseChecker(Me.Fields.Header.帳票区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.コンピュータ名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.プリンタ名, strMsg, Me.ControlError)

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
        ''' <SUMMARY>検査(個別)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Protected Overrides Function Valid_Write_Header_Another() As NodeContents.ActionButton.ErrorLevel
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim strMsg As String = ""
            Dim Validator As New BaseCore.Common.Validator

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

#Region "Valid_Write"
        '''========================================================================================
        ''' <SUMMARY>検査(共通)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Protected Overrides Function Valid_Delete_Header_Common() As NodeContents.ActionButton.ErrorLevel
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim strMsg As String = ""
            Dim Validator As New BaseCore.Common.Validator

            '------------------------------------------------------------------
            ' ｴﾗｰｸﾘｱ
            '------------------------------------------------------------------
            Me.Fields.Header.帳票区分.IsError = False
            Me.Fields.Header.コンピュータ名.IsError = False
            Me.Fields.Header.プリンタ名.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            Validator.BaseChecker(Me.Fields.Header.帳票区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.コンピュータ名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.プリンタ名, strMsg, Me.ControlError)

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
        ''' <SUMMARY>検査(個別)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Protected Overrides Function Valid_Delete_Header_Another() As NodeContents.ActionButton.ErrorLevel
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim strMsg As String = ""
            Dim Validator As New BaseCore.Common.Validator

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
            Me.Fields.Detail1(Index).行NO.Value = Index + 1
            Me.Fields.Detail1(Index).コンピュータ名.Value = Nothing
            Me.Fields.Detail1(Index).プリンタ名.Value = Nothing
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
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0特殊帳票TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0特殊帳票DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.帳票区分Column.ColumnName, Me.Fields.Header.帳票区分.Value, BaseDatabase.Contents.Compare.Equal))

            Dim strSort As String = ""
            Dim strDelim As String = ""

            strSort &= strDelim & tbl.コンピュータ名Column.ColumnName : strDelim = ","

            tbl = ada.SelectByCommon(qry, strSort)

            '----------------------------------------------------------------------
            ' ﾌﾚｰﾑ作成
            '----------------------------------------------------------------------
            Me.Add_Detail1(tbl.Count)

            '----------------------------------------------------------------------
            ' 値設定
            '----------------------------------------------------------------------
            For i As Integer = 0 To tbl.Rows.Count - 1
                Me.Fields.Detail1(i).行NO.Value = i + 1
                Me.Fields.Detail1(i).コンピュータ名.Value = tbl(i).Item(tbl.コンピュータ名Column.ColumnName)
                Me.Fields.Detail1(i).プリンタ名.Value = tbl(i).Item(tbl.プリンタ名Column.ColumnName)
            Next

            '999行に満たない場合、空行挿入する
            If tbl.Rows.Count < 999 Then
                Me.Add_Detail1(999 - tbl.Count)

                For i As Integer = tbl.Rows.Count To 999 - 1
                    Me.Fields.Detail1(i).行NO.Value = i + 1
                    Me.Fields.Detail1(i).コンピュータ名.Value = ""
                    Me.Fields.Detail1(i).プリンタ名.Value = ""
                Next
            End If

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
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M特殊帳票TableAdapter
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

                        ada.Insert(Me.Fields.Header.帳票区分.Value _
                                 , Me.Fields.Detail1(i).コンピュータ名.Value _
                                 , Me.Fields.Detail1(i).プリンタ名.Value _
                                  )
                    Next
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

#Region "Delete"
        '''========================================================================================
        ''' <SUMMARY>削除</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Delete_Detail1() As Boolean
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M特殊帳票TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M特殊帳票DataTable
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
                    qry.Add(New BaseDatabase.Condition(tbl.帳票区分Column.ColumnName, Me.Fields.Header.帳票区分.Value, BaseDatabase.Contents.Compare.Equal))
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
                Me.Fields.Detail1(i).行NO.IsError = False
                Me.Fields.Detail1(i).コンピュータ名.IsError = False
                Me.Fields.Detail1(i).プリンタ名.IsError = False
            Next

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            For i As Integer = 0 To Me.Fields.Detail1.Count - 1
                If Not Me.Empty_Detail1(Me.Fields.Detail1(i)) Then
                    Validator.BaseChecker(Me.Fields.Detail1(i).行NO, strMsg, Me.ControlError)
                    Validator.BaseChecker(Me.Fields.Detail1(i).コンピュータ名, strMsg, Me.ControlError)
                    Validator.BaseChecker(Me.Fields.Detail1(i).プリンタ名, strMsg, Me.ControlError)
                End If
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
                Case Not BaseCore.Common.Text.IsEmptyOrZero(row.コンピュータ名.Value) : Return False
            End Select

            '------------------------------------------------------------------
            ' 無効行
            '------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "ﾌﾚｰﾑ関連"
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
            Me.Fields.Detail1(IndexT).行NO.Value = Me.Fields.Detail1(IndexF).行NO.Value
            Me.Fields.Detail1(IndexT).コンピュータ名.Value = Me.Fields.Detail1(IndexF).コンピュータ名.Value
            Me.Fields.Detail1(IndexT).プリンタ名.Value = Me.Fields.Detail1(IndexF).プリンタ名.Value
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
                Me.Fields.Detail1(i).行NO.Value = i + 1
            Next
        End Sub
#End Region
#End Region
#End Region
    End Class
End Namespace
