Namespace Frame.Order
    Partial Public Class OffSet
        Inherits NodeCore.Common.Frame

#Region "ﾌｨｰﾙﾄﾞ定義"
        Public Class Header
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 処理登録 As BaseCore.Common.Field.ItemData
            Public 処理修正 As BaseCore.Common.Field.ItemData
            Public 処理削除 As BaseCore.Common.Field.ItemData

            Public 作業NO As BaseCore.Common.Field.ItemData

            Public 得意先名 As BaseCore.Common.Field.ItemData
            Public 代表商品名 As BaseCore.Common.Field.ItemData
            Public 受注数合計 As BaseCore.Common.Field.ItemData
            Public 受注単価 As BaseCore.Common.Field.ItemData
            Public 受注金額 As BaseCore.Common.Field.ItemData

            Public 発注先CD As BaseCore.Common.Field.ItemData
            Public 仕入先名 As BaseCore.Common.Field.ItemData
            Public 工程区分 As BaseCore.Common.Field.ItemData
            Public 発注日 As BaseCore.Common.Field.ItemData
            Public 発注納期 As BaseCore.Common.Field.ItemData
            Public 発注数 As BaseCore.Common.Field.ItemData
            Public 発注単位区分 As BaseCore.Common.Field.ItemData
            Public 発注単価 As BaseCore.Common.Field.ItemData
            Public 発注金額 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0オフセット発注DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.処理登録 = New BaseCore.Common.Field.ItemData("処理登録", TypeCode.String, 1)
                Me.処理修正 = New BaseCore.Common.Field.ItemData("処理修正", TypeCode.String, 1)
                Me.処理削除 = New BaseCore.Common.Field.ItemData("処理削除", TypeCode.String, 1)

                Me.作業NO = New BaseCore.Common.Field.ItemData(tbl.作業NOColumn)

                Me.得意先名 = New BaseCore.Common.Field.ItemData(tbl.得意先名Column)
                Me.代表商品名 = New BaseCore.Common.Field.ItemData(tbl.代表商品名Column)
                Me.受注数合計 = New BaseCore.Common.Field.ItemData(tbl.受注数合計Column, NodeContents.Constant.桁数.数量.整数, NodeContents.Constant.桁数.数量.小数)
                Me.受注単価 = New BaseCore.Common.Field.ItemData(tbl.受注単価Column, NodeContents.Constant.桁数.単価.整数, NodeContents.Constant.桁数.単価.小数)
                Me.受注金額 = New BaseCore.Common.Field.ItemData(tbl.受注金額Column, NodeContents.Constant.桁数.金額.整数, NodeContents.Constant.桁数.金額.小数)

                Me.発注先CD = New BaseCore.Common.Field.ItemData(tbl.発注先CDColumn)
                Me.仕入先名 = New BaseCore.Common.Field.ItemData(tbl.仕入先名Column)
                Me.工程区分 = New BaseCore.Common.Field.ItemData(tbl.工程区分Column)
                Me.発注日 = New BaseCore.Common.Field.ItemData(tbl.発注日Column)
                Me.発注納期 = New BaseCore.Common.Field.ItemData(tbl.発注納期Column)
                Me.発注数 = New BaseCore.Common.Field.ItemData(tbl.発注数Column, NodeContents.Constant.桁数.数量.整数, NodeContents.Constant.桁数.数量.小数)
                Me.発注単位区分 = New BaseCore.Common.Field.ItemData(tbl.発注単位区分Column)
                Me.発注単価 = New BaseCore.Common.Field.ItemData(tbl.発注単価Column, NodeContents.Constant.桁数.単価.整数, NodeContents.Constant.桁数.単価.小数)
                Me.発注金額 = New BaseCore.Common.Field.ItemData(tbl.発注金額Column, NodeContents.Constant.桁数.金額.整数, NodeContents.Constant.桁数.金額.小数)
            End Sub
        End Class

        Public Class Detail1
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 発注先CD As BaseCore.Common.Field.ItemData
            Public 工程区分 As BaseCore.Common.Field.ItemData
            Public 発注日 As BaseCore.Common.Field.ItemData
            Public 発注納期 As BaseCore.Common.Field.ItemData
            Public 発注数 As BaseCore.Common.Field.ItemData
            Public 発注単位区分 As BaseCore.Common.Field.ItemData
            Public 発注単価 As BaseCore.Common.Field.ItemData
            Public 発注金額 As BaseCore.Common.Field.ItemData

            Public 仕入先名 As BaseCore.Common.Field.ItemData
            Public 工程区分名 As BaseCore.Common.Field.ItemData
            Public 発注単位区分名 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0オフセット発注DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.発注先CD = New BaseCore.Common.Field.ItemData(tbl.発注先CDColumn)
                Me.工程区分 = New BaseCore.Common.Field.ItemData(tbl.工程区分Column)
                Me.発注日 = New BaseCore.Common.Field.ItemData(tbl.発注日Column)
                Me.発注納期 = New BaseCore.Common.Field.ItemData(tbl.発注納期Column)
                Me.発注数 = New BaseCore.Common.Field.ItemData(tbl.発注数Column, NodeContents.Constant.桁数.数量.整数, NodeContents.Constant.桁数.数量.小数)
                Me.発注単位区分 = New BaseCore.Common.Field.ItemData(tbl.発注単位区分Column)
                Me.発注単価 = New BaseCore.Common.Field.ItemData(tbl.発注単価Column, NodeContents.Constant.桁数.単価.整数, NodeContents.Constant.桁数.単価.小数)
                Me.発注金額 = New BaseCore.Common.Field.ItemData(tbl.発注金額Column, NodeContents.Constant.桁数.金額.整数, NodeContents.Constant.桁数.金額.小数)

                Me.仕入先名 = New BaseCore.Common.Field.ItemData(tbl.仕入先名Column)
                Me.工程区分名 = New BaseCore.Common.Field.ItemData(tbl.工程区分名Column)
                Me.発注単位区分名 = New BaseCore.Common.Field.ItemData(tbl.発注単位区分名Column)
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
                Me.Fields.Header.処理登録.Value = NodeContents.Constant.CodeValue.フラグ.オン
                Me.Fields.Header.処理修正.Value = NodeContents.Constant.CodeValue.フラグ.オフ
                Me.Fields.Header.処理削除.Value = NodeContents.Constant.CodeValue.フラグ.オフ
                Me.Fields.Header.作業NO.Value = Nothing
            End If

            '----------------------------------------------------------------------
            ' ﾃﾞｰﾀ部ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Fields.Header.得意先名.Value = Nothing
            Me.Fields.Header.代表商品名.Value = Nothing
            Me.Fields.Header.受注数合計.Value = Nothing
            Me.Fields.Header.受注単価.Value = Nothing
            Me.Fields.Header.受注金額.Value = Nothing

            Me.Fields.Header.発注先CD.Value = Nothing
            Me.Fields.Header.仕入先名.Value = Nothing
            Me.Fields.Header.工程区分.Value = Nothing
            Me.Fields.Header.発注日.Value = Nothing
            Me.Fields.Header.発注納期.Value = Nothing
            Me.Fields.Header.発注数.Value = Nothing
            Me.Fields.Header.発注単位区分.Value = Nothing
            Me.Fields.Header.発注単価.Value = Nothing
            Me.Fields.Header.発注金額.Value = Nothing

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "Exist"
        '''========================================================================================
        ''' <SUMMARY>存在確認</SUMMARY>
        ''' <RETURNS>True:あり, False:なし</RETURNS>
        '''========================================================================================
        Protected Overrides Function Exist_Header() As Boolean
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0オフセット発注TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0オフセット発注DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.作業NOColumn.ColumnName, Me.Fields.Header.作業NO.Value, BaseDatabase.Contents.Compare.Equal))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            tbl = ada.SelectByCommon(qry)

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return (tbl.Count > 0)
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
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0オフセット発注TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0オフセット発注DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' ｷｰ項目以外 ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Clear_Header(False)

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.作業NOColumn.ColumnName, Me.Fields.Header.作業NO.Value, BaseDatabase.Contents.Compare.Equal))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            tbl = ada.SelectByCommon(qry)
            If tbl.Count > 0 Then
                Me.Fields.Header.得意先名.Value = tbl(0).Item(tbl.得意先名Column.ColumnName)
                Me.Fields.Header.代表商品名.Value = tbl(0).Item(tbl.代表商品名Column.ColumnName)
                Me.Fields.Header.受注数合計.Value = tbl(0).Item(tbl.受注数合計Column.ColumnName)
                Me.Fields.Header.受注単価.Value = tbl(0).Item(tbl.受注単価Column.ColumnName)
                Me.Fields.Header.受注金額.Value = tbl(0).Item(tbl.受注金額Column.ColumnName)
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
            Me.Fields.Header.処理登録.IsError = False
            Me.Fields.Header.処理修正.IsError = False
            Me.Fields.Header.処理削除.IsError = False
            Me.Fields.Header.作業NO.IsError = False
            Me.Fields.Header.得意先名.IsError = False
            Me.Fields.Header.代表商品名.IsError = False
            Me.Fields.Header.受注数合計.IsError = False
            Me.Fields.Header.受注単価.IsError = False
            Me.Fields.Header.受注金額.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            Validator.BaseChecker(Me.Fields.Header.処理登録, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.処理修正, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.処理削除, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.作業NO, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.得意先名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.代表商品名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.受注数合計, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.受注単価, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.受注金額, strMsg, Me.ControlError)

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
                Dim blnExist As Boolean = Me.Exist

                Select Case True
                    Case Me.Fields.Header.処理登録.Value = NodeContents.Constant.CodeValue.フラグ.オン
                        If blnExist Then
                            Validator.SetMessage(strMsg, "指定された作業NOは既に登録済みです。", Me.ControlError, Me.Fields.Header.作業NO)
                        End If

                    Case Me.Fields.Header.処理修正.Value = NodeContents.Constant.CodeValue.フラグ.オン
                        If Not blnExist Then
                            Validator.SetMessage(strMsg, "指定された作業NOは登録がありません。", Me.ControlError, Me.Fields.Header.作業NO)
                        End If
                End Select
            End If

            '-------------------------------------
            ' ｵﾌｾｯﾄ検査
            '-------------------------------------
            If strMsg = "" Then
                Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0受注基本TableAdapter
                Dim tbl As New NodeDatabase.DataSetView.V0受注基本DataTable
                Dim qry As New Collection

                qry.Clear()
                qry.Add(New BaseDatabase.Condition(tbl.作業NOColumn.ColumnName, Me.Fields.Header.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
                tbl = ada.SelectByCommon(qry)

                If tbl.Count = 0 Then
                    Validator.SetMessage(strMsg, "指定された作業NOはｵﾌｾｯﾄではありません。", Me.ControlError, Me.Fields.Header.作業NO)
                End If

                If tbl.Rows(0).Item(tbl.受注区分Column.ColumnName) <> NodeContents.Constant.CodeValue.取引先区分.仕入先 Then
                    Validator.SetMessage(strMsg, "指定された作業NOはｵﾌｾｯﾄではありません。", Me.ControlError, Me.Fields.Header.作業NO)
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
            Me.Fields.Header.発注先CD.IsError = False
            Me.Fields.Header.仕入先名.IsError = False
            Me.Fields.Header.工程区分.IsError = False
            Me.Fields.Header.発注日.IsError = False
            Me.Fields.Header.発注納期.IsError = False
            Me.Fields.Header.発注数.IsError = False
            Me.Fields.Header.発注単位区分.IsError = False
            Me.Fields.Header.発注単価.IsError = False
            Me.Fields.Header.発注金額.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            Validator.BaseChecker(Me.Fields.Header.発注先CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.仕入先名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.工程区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.発注日, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.発注納期, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.発注数, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.発注単位区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.発注単価, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.発注金額, strMsg, Me.ControlError)

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
        ''' <SUMMARY>検査(共通)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Protected Overrides Function Valid_RowAdd_Header_Another() As NodeContents.ActionButton.ErrorLevel
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
                Dim blnExist As Boolean = Me.Exist

                Select Case True
                    Case Me.Fields.Header.処理登録.Value = NodeContents.Constant.CodeValue.フラグ.オン
                        If blnExist Then
                            Validator.SetMessage(strMsg, "指定された作業NOは既に登録済みです。", Me.ControlError, Me.Fields.Header.作業NO)
                        End If

                    Case Me.Fields.Header.処理修正.Value = NodeContents.Constant.CodeValue.フラグ.オン
                        If Not blnExist Then
                            Validator.SetMessage(strMsg, "指定された作業NOは登録がありません。", Me.ControlError, Me.Fields.Header.作業NO)
                        End If
                End Select
            End If

            '-------------------------------------
            ' ﾏｽﾀ存在検査
            '-------------------------------------
            If strMsg = "" Then
                If Not NodeCore.Common.Exist.仕入先(Me.Fields.Header.発注先CD.Value) Then
                    Validator.SetMessage(strMsg, "仕入先マスタに未登録です。", Me.ControlError, Me.Fields.Header.発注先CD)
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
            Me.Fields.Detail1(Index).発注先CD.Value = Nothing
            Me.Fields.Detail1(Index).工程区分.Value = Nothing
            Me.Fields.Detail1(Index).発注日.Value = Nothing
            Me.Fields.Detail1(Index).発注納期.Value = Nothing
            Me.Fields.Detail1(Index).発注数.Value = Nothing
            Me.Fields.Detail1(Index).発注単位区分.Value = Nothing
            Me.Fields.Detail1(Index).発注単価.Value = Nothing
            Me.Fields.Detail1(Index).発注金額.Value = Nothing

            Me.Fields.Detail1(Index).仕入先名.Value = Nothing
            Me.Fields.Detail1(Index).工程区分名.Value = Nothing
            Me.Fields.Detail1(Index).発注単位区分名.Value = Nothing
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
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0オフセット発注TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0オフセット発注DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.作業NOColumn.ColumnName, Me.Fields.Header.作業NO.Value, BaseDatabase.Contents.Compare.Equal))

            Dim strSort As String = ""
            Dim strDelim As String = ""

            strSort &= strDelim & tbl.行NOColumn.ColumnName : strDelim = ","

            tbl = ada.SelectByCommon(qry, strSort)

            '----------------------------------------------------------------------
            ' ﾌﾚｰﾑ作成
            '----------------------------------------------------------------------
            Me.Add_Detail1(tbl.Count)

            '----------------------------------------------------------------------
            ' 値設定
            '----------------------------------------------------------------------
            For i As Integer = 0 To tbl.Rows.Count - 1
                Me.Fields.Detail1(i).発注先CD.Value = tbl(i).Item(tbl.発注先CDColumn.ColumnName)
                Me.Fields.Detail1(i).工程区分.Value = tbl(i).Item(tbl.工程区分Column.ColumnName)
                Me.Fields.Detail1(i).発注日.Value = tbl(i).Item(tbl.発注日Column.ColumnName)
                Me.Fields.Detail1(i).発注納期.Value = tbl(i).Item(tbl.発注納期Column.ColumnName)
                Me.Fields.Detail1(i).発注数.Value = tbl(i).Item(tbl.発注数Column.ColumnName)
                Me.Fields.Detail1(i).発注単位区分.Value = tbl(i).Item(tbl.発注単位区分Column.ColumnName)
                Me.Fields.Detail1(i).発注単価.Value = tbl(i).Item(tbl.発注単価Column.ColumnName)
                Me.Fields.Detail1(i).発注金額.Value = tbl(i).Item(tbl.発注金額Column.ColumnName)

                Me.Fields.Detail1(i).仕入先名.Value = tbl(i).Item(tbl.仕入先名Column.ColumnName)
                Me.Fields.Detail1(i).工程区分名.Value = tbl(i).Item(tbl.工程区分名Column.ColumnName)
                Me.Fields.Detail1(i).発注単位区分名.Value = tbl(i).Item(tbl.発注単位区分名Column.ColumnName)
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
            Dim ada As New NodeDatabase.DataSetTranTableAdapters.Tオフセット発注TableAdapter
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

                        ada.Insert(Me.Fields.Header.作業NO.Value _
                                 , Me.RowCount _
                                 , Me.Fields.Detail1(i).発注先CD.Value _
                                 , Me.Fields.Detail1(i).工程区分.Value _
                                 , Me.Fields.Detail1(i).発注日.Value _
                                 , Me.Fields.Detail1(i).発注納期.Value _
                                 , BaseCore.Common.Text.CVal(Me.Fields.Detail1(i).発注数.Value) _
                                 , Me.Fields.Detail1(i).発注単位区分.Value _
                                 , BaseCore.Common.Text.CVal(Me.Fields.Detail1(i).発注単価.Value) _
                                 , BaseCore.Common.Text.CVal(Me.Fields.Detail1(i).発注金額.Value) _
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
            Dim ada As New NodeDatabase.DataSetTranTableAdapters.Tオフセット発注TableAdapter
            Dim tbl As New NodeDatabase.DataSetTran.Tオフセット発注DataTable
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
                    qry.Add(New BaseDatabase.Condition(tbl.作業NOColumn.ColumnName, Me.Fields.Header.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
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
                Me.Fields.Detail1(i).発注先CD.IsError = False
                Me.Fields.Detail1(i).工程区分.IsError = False
                Me.Fields.Detail1(i).発注日.IsError = False
                Me.Fields.Detail1(i).発注納期.IsError = False
                Me.Fields.Detail1(i).発注数.IsError = False
                Me.Fields.Detail1(i).発注単位区分.IsError = False
                Me.Fields.Detail1(i).発注単価.IsError = False
                Me.Fields.Detail1(i).発注金額.IsError = False

                Me.Fields.Detail1(i).仕入先名.IsError = False
                Me.Fields.Detail1(i).工程区分名.IsError = False
                Me.Fields.Detail1(i).発注単位区分名.IsError = False
            Next

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            For i As Integer = 0 To Me.Fields.Detail1.Count - 1
                If Me.Empty_Detail1(Me.Fields.Detail1(i)) Then
                    Continue For
                End If

                Validator.BaseChecker(Me.Fields.Detail1(i).発注先CD, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).工程区分, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).発注日, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).発注納期, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).発注数, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).発注単位区分, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).発注単価, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).発注金額, strMsg, Me.ControlError)

                Validator.BaseChecker(Me.Fields.Detail1(i).仕入先名, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).工程区分名, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).発注単位区分名, strMsg, Me.ControlError)
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
                Case Not BaseCore.Common.Text.IsEmptyOrZero(row.発注先CD.Value) : Return False
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
            Me.Fields.Detail1(IndexT).発注先CD.Value = Me.Fields.Detail1(IndexF).発注先CD.Value
            Me.Fields.Detail1(IndexT).工程区分.Value = Me.Fields.Detail1(IndexF).工程区分.Value
            Me.Fields.Detail1(IndexT).発注日.Value = Me.Fields.Detail1(IndexF).発注日.Value
            Me.Fields.Detail1(IndexT).発注納期.Value = Me.Fields.Detail1(IndexF).発注納期.Value
            Me.Fields.Detail1(IndexT).発注数.Value = Me.Fields.Detail1(IndexF).発注数.Value
            Me.Fields.Detail1(IndexT).発注単位区分.Value = Me.Fields.Detail1(IndexF).発注単位区分.Value
            Me.Fields.Detail1(IndexT).発注単価.Value = Me.Fields.Detail1(IndexF).発注単価.Value
            Me.Fields.Detail1(IndexT).発注金額.Value = Me.Fields.Detail1(IndexF).発注金額.Value

            Me.Fields.Detail1(IndexT).仕入先名.Value = Me.Fields.Detail1(IndexF).仕入先名.Value
            Me.Fields.Detail1(IndexT).工程区分名.Value = Me.Fields.Detail1(IndexF).工程区分名.Value
            Me.Fields.Detail1(IndexT).発注単位区分名.Value = Me.Fields.Detail1(IndexF).発注単位区分名.Value
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
