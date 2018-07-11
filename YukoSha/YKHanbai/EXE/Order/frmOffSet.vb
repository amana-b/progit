Public Class frmOffSet
    Inherits BaseUI.BaseForm

#Region "ﾌﾚｰﾑﾜｰｸ"
    Private Frame As NodeCore.Frame.Order.OffSet
#End Region

#Region "定型準備"
    '''========================================================================================
    '''  <summary>準備(ﾌｧﾝｸｼｮﾝ)</summary>
    ''' <param name="F01">F01ﾎﾞﾀﾝ名</param>
    ''' <param name="F02">F02ﾎﾞﾀﾝ名</param>
    ''' <param name="F03">F03ﾎﾞﾀﾝ名</param>
    ''' <param name="F04">F04ﾎﾞﾀﾝ名</param>
    ''' <param name="F05">F05ﾎﾞﾀﾝ名</param>
    ''' <param name="F06">F06ﾎﾞﾀﾝ名</param>
    ''' <param name="F07">F07ﾎﾞﾀﾝ名</param>
    ''' <param name="F08">F08ﾎﾞﾀﾝ名</param>
    ''' <param name="F09">F09ﾎﾞﾀﾝ名</param>
    ''' <param name="F10">F10ﾎﾞﾀﾝ名</param>
    ''' <param name="F11">F11ﾎﾞﾀﾝ名</param>
    ''' <param name="F12">F12ﾎﾞﾀﾝ名</param>
    '''========================================================================================
    Protected Overrides Sub FuncInitialize(ByRef ESC As String, ByRef F01 As String, ByRef F02 As String, ByRef F03 As String, ByRef F04 As String, ByRef F05 As String, ByRef F06 As String, ByRef F07 As String, ByRef F08 As String, ByRef F09 As String, ByRef F10 As String, ByRef F11 As String, ByRef F12 As String)
        F02 = "行追加"
        F03 = "行削除"
        F07 = "検索"
        F12 = "確定"
    End Sub

    '''========================================================================================
    '''  <summary>NodeDabataseの接続文字列の書き換え</summary>
    '''========================================================================================
    Protected Overrides Sub Provider()
        Dim Provider As New NodeDatabase.Provider           ' 接続文字列の書き換えを行っている
        Provider.ConnectionStringBase = System.Configuration.ConfigurationManager.AppSettings("ConnectionStringBase")
    End Sub

    '''========================================================================================
    '''  <summary>ｺﾝﾄﾛｰﾙの準備</summary>
    '''========================================================================================
    Protected Overrides Sub ControlInit()
        '----------------------------------------------------------------------
        ' ｶｽﾀﾑ定義
        '----------------------------------------------------------------------
        ' ﾗｼﾞｵﾎﾞﾀﾝ
        Me.opt登録.PropetyInitForm(BaseContents.Field.LockType.None)
        Me.opt修正.PropetyInitForm(BaseContents.Field.LockType.None)
        Me.opt削除.PropetyInitForm(BaseContents.Field.LockType.None)

        ' ﾃｷｽﾄﾎﾞｯｸｽ
        Me.txt作業NO.PropetyInitForm(BaseContents.Field.LockType.Key, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.T受注基本, Me.txt作業NO.Name, "")
        Me.txt発注先CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M仕入先, Me.txt発注先CD.Name, Me.nam仕入先名.Name)
        Me.txt発注日.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.YYYYMMDD, NodeUI.Help.Type.None, "", "")
        Me.txt発注納期.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.YYYYMMDD, NodeUI.Help.Type.None, "", "")
        Me.txt発注数.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt発注単価.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")

        ' ﾈｰﾑﾎﾞｯｸｽ
        Me.nam得意先名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam商品名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam受注数.PropetyInitForm(BaseContents.TextBox.TextStyle.Currency)
        Me.nam受注単価.PropetyInitForm(BaseContents.TextBox.TextStyle.Currency)
        Me.nam受注金額.PropetyInitForm(BaseContents.TextBox.TextStyle.Currency)
        Me.nam仕入先名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam発注金額.PropetyInitForm(BaseContents.TextBox.TextStyle.Currency)

        ' ﾄﾞﾛｯﾌﾟﾀﾞｳﾝ
        Me.ddl工程区分.PropetyInitForm(BaseContents.Field.LockType.Data, True, NodeUI.List.Type.M区分_工程区分)
        Me.ddl発注単位区分.PropetyInitForm(BaseContents.Field.LockType.Data, True, NodeUI.List.Type.M区分_発注単位区分)
    End Sub

    '''========================================================================================
    '''  <summary>ﾌﾚｰﾑﾜｰｸの準備</summary>
    '''========================================================================================
    Protected Overrides Sub FrameInit()
        '-------------------------------------
        ' ｺﾝｽﾄﾗｸﾀ
        '-------------------------------------
        Frame = New NodeCore.Frame.Order.OffSet(Me.Security, Me.Config)

        '-------------------------------------
        ' 紐付け
        '-------------------------------------
        Frame.Fields.Header.処理登録.Control = Me.opt登録
        Frame.Fields.Header.処理修正.Control = Me.opt修正
        Frame.Fields.Header.処理削除.Control = Me.opt削除

        Frame.Fields.Header.作業NO.Control = Me.txt作業NO

        Frame.Fields.Header.得意先名.Control = Me.nam得意先名
        Frame.Fields.Header.代表商品名.Control = Me.nam商品名
        Frame.Fields.Header.受注数合計.Control = Me.nam受注数
        Frame.Fields.Header.受注単価.Control = Me.nam受注単価
        Frame.Fields.Header.受注金額.Control = Me.nam受注金額

        Frame.Fields.Header.発注先CD.Control = Me.txt発注先CD
        Frame.Fields.Header.仕入先名.Control = Me.nam仕入先名
        Frame.Fields.Header.工程区分.Control = Me.ddl工程区分
        Frame.Fields.Header.発注日.Control = Me.txt発注日
        Frame.Fields.Header.発注納期.Control = Me.txt発注納期
        Frame.Fields.Header.発注数.Control = Me.txt発注数
        Frame.Fields.Header.発注単位区分.Control = Me.ddl発注単位区分
        Frame.Fields.Header.発注単価.Control = Me.txt発注単価
        Frame.Fields.Header.発注金額.Control = Me.nam発注金額
    End Sub
#End Region

#Region "ﾍﾟｰｼﾞｲﾍﾞﾝﾄ"
    '''========================================================================================
    '''  <summary>ﾍﾟｰｼﾞﾛｰﾄﾞ</summary>
    '''========================================================================================
    Private Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        '----------------------------------------------------------------------
        ' 画面ｸﾘｱ
        '----------------------------------------------------------------------
        Frame.Clear()

        '----------------------------------------------------------------------
        ' ｷｰ部入力制御
        '----------------------------------------------------------------------
        Me.FormEnableKey()
    End Sub
#End Region

#Region "ﾕｰｻﾞｲﾍﾞﾝﾄ"
    '''========================================================================================
    '''  <summary>処理区分変更</summary>
    '''========================================================================================
    Private Sub opt処理区分_AfterUpdate(sender As Object, e As System.EventArgs) Handles opt登録.AfterUpdate, opt修正.AfterUpdate, opt削除.AfterUpdate
        '----------------------------------------------------------------------
        ' 画面ｸﾘｱ
        '----------------------------------------------------------------------
        Frame.Clear(False)

        '----------------------------------------------------------------------
        ' ｷｰ部入力制御
        '----------------------------------------------------------------------
        Me.FormEnableKey()
    End Sub

    '''========================================================================================
    ''' <summary>ｷｰ変更</summary>
    '''========================================================================================
    Private Sub txt作業NO_AfterUpdate(sender As Object, e As System.EventArgs) Handles txt作業NO.AfterUpdate
        '----------------------------------------------------------------------
        ' 該当ﾃﾞｰﾀ 読込
        '----------------------------------------------------------------------
        If Frame.Read() Then
            If Me.opt登録.Checked Then
                Me.FormEnableKey()
                MsgBox("指定された作業NOは既に登録済みです", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
                Exit Sub
            End If
        Else
            If Me.opt修正.Checked Or Me.opt削除.Checked Then
                Me.FormEnableKey()
                MsgBox("指定された作業NOは登録がありません", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
                Exit Sub
            End If
        End If

        '----------------------------------------------------------------------
        ' ﾃｷｽﾄﾎﾞｯｸｽ 書式適用
        '----------------------------------------------------------------------
        Me.TextBoxFormat()

        '----------------------------------------------------------------------
        ' ﾊﾞｲﾝﾄﾞ(ﾌﾚｰﾑﾌｨｰﾙﾄﾞ → ｸﾞﾘｯﾄﾞ)
        '----------------------------------------------------------------------
        Me.grdDetall_DataBind()

        '----------------------------------------------------------------------
        ' 先頭行 選択
        '----------------------------------------------------------------------
        If Me.grdDetall.Rows.Count > 0 Then
            Me.grdDetall.CurrentCell = Me.grdDetall.Rows(0).Cells(0)
            Me.grdDetall_SelectionChanged(Me.grdDetall, System.EventArgs.Empty)
        End If

        '----------------------------------------------------------------------
        ' ﾃﾞｰﾀ部入力制御
        '----------------------------------------------------------------------
        Me.FormEnableData()
    End Sub
#End Region

#Region "ｸﾞﾘｯﾄﾞ関連"
    '''========================================================================================
    '''  <summary>初期化</summary>
    '''========================================================================================
    Private Sub grdDetall_Setting(ByRef TextBoxAddTop As BaseUI.Control.TextBox, ByRef TextBoxAddBtm As BaseUI.Control.TextBox, ByRef ButtonInsert As BaseUI.Control.Button, ByRef ButtonDelete As BaseUI.Control.Button) Handles grdDetall.Setting
        '----------------------------------------------------------------------
        ' 共通処理
        '----------------------------------------------------------------------
        TextBoxAddTop = Me.txt発注先CD
        TextBoxAddBtm = Me.txt発注単価

        ButtonInsert = Me.btnF02
        ButtonDelete = Me.btnF03

        Me.grdDetall.RowHeadersVisible = False      ' 行No 表示/非表示
        Me.grdDetall.RowHeadersWidth = 50           ' 行No の列幅

        '----------------------------------------------------------------------
        ' 列定義
        '----------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetView.V0オフセット発注DataTable

        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.発注先CDColumn, , "発注CD", , , , 65))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.仕入先名Column, , "発注CD", , , , 280))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.工程区分名Column, , "工程", , , , 80))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.発注日Column, , , , , , 90))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.発注納期Column, , , , , , 90))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.発注数Column, , , , Windows.Forms.DataGridViewContentAlignment.MiddleRight, "#,##0", 100))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.発注単位区分名Column, , "単位", , , , 50))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.発注単価Column, , , , Windows.Forms.DataGridViewContentAlignment.MiddleRight, "#,##0.00", 100))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.発注金額Column, , , , Windows.Forms.DataGridViewContentAlignment.MiddleRight, "#,##0", 100))

        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.行NOColumn, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.工程区分Column, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.発注単位区分Column, , , False))
    End Sub

    '''========================================================================================
    '''  <summary>ﾊﾞｲﾝﾄﾞ全行(ﾌﾚｰﾑﾌｨｰﾙﾄﾞ → ｸﾞﾘｯﾄﾞ)</summary>
    '''========================================================================================
    Private Sub grdDetall_DataBind() Handles grdDetall.DataBind
        '----------------------------------------------------------------------
        ' 空行追加
        '----------------------------------------------------------------------
        Dim MaxLine As Integer = 100

        If MaxLine > Frame.Fields.Detail1.Count Then
            Frame.Add_Detail1(MaxLine - Frame.Fields.Detail1.Count, False)
        End If

        '----------------------------------------------------------------------
        ' Rows.Clear や Rows.Add 時に｢SelectionChanged｣ｲﾍﾞﾝﾄが発生してしまうので解除
        '----------------------------------------------------------------------
        RemoveHandler Me.grdDetall.SelectionChanged, AddressOf Me.grdDetall_SelectionChanged

        '----------------------------------------------------------------------
        ' ﾊﾞｲﾝﾄﾞ
        '----------------------------------------------------------------------
        Me.grdDetall.Rows.Clear()

        For i As Integer = 0 To Frame.Fields.Detail1.Count - 1
            Me.grdDetall.Rows.Add()

            Me.grdDetall_RowBind(i)
        Next

        '----------------------------------------------------------------------
        ' Rows.Clear や Rows.Add 時に｢SelectionChanged｣ｲﾍﾞﾝﾄが発生してしまうので復旧
        '----------------------------------------------------------------------
        AddHandler Me.grdDetall.SelectionChanged, AddressOf Me.grdDetall_SelectionChanged
    End Sub

    '''========================================================================================
    '''  <summary>ﾊﾞｲﾝﾄﾞ単行(ﾌﾚｰﾑﾌｨｰﾙﾄﾞ → ｸﾞﾘｯﾄﾞ)</summary>
    '''========================================================================================
    Private Sub grdDetall_RowBind(ByVal RowIndex As Integer) Handles grdDetall.RowBind
        Dim tbl As New NodeDatabase.DataSetView.V0オフセット発注DataTable

        Me.grdDetall.Rows(RowIndex).Cells(tbl.発注先CDColumn.ColumnName).Value = Frame.Fields.Detail1(RowIndex).発注先CD.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.仕入先名Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).仕入先名.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.工程区分Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).工程区分.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.工程区分名Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).工程区分名.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.発注日Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).発注日.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.発注納期Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).発注納期.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.発注数Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).発注数.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.発注単位区分Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).発注単位区分.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.発注単位区分名Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).発注単位区分名.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.発注単価Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).発注単価.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.発注金額Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).発注金額.Value
    End Sub

    '''========================================================================================
    '''  <summary>行選択</summary>
    '''========================================================================================
    Private Sub grdDetall_SelectionChanged(sender As Object, e As System.EventArgs) Handles grdDetall.SelectionChanged
        If Me.grdDetall.CurrentRow Is Nothing Then
            Exit Sub
        End If

        Dim tbl As New NodeDatabase.DataSetView.V0オフセット発注DataTable
        Dim i As Integer = Me.grdDetall.CurrentRow.Index

        Me.txt発注先CD.Text = Me.grdDetall.Rows(i).Cells(tbl.発注先CDColumn.ColumnName).Value
        Me.nam仕入先名.Text = Me.grdDetall.Rows(i).Cells(tbl.仕入先名Column.ColumnName).Value
        Me.txt発注日.Text = Me.grdDetall.Rows(i).Cells(tbl.発注日Column.ColumnName).Value
        Me.txt発注納期.Text = Me.grdDetall.Rows(i).Cells(tbl.発注納期Column.ColumnName).Value
        Me.txt発注数.Text = Me.grdDetall.Rows(i).Cells(tbl.発注数Column.ColumnName).Value
        Me.txt発注単価.Text = Me.grdDetall.Rows(i).Cells(tbl.発注単価Column.ColumnName).Value
        Me.nam発注金額.Text = Me.grdDetall.Rows(i).Cells(tbl.発注金額Column.ColumnName).Value

        Me.ddl工程区分.SelectedValue = Me.grdDetall.Rows(i).Cells(tbl.工程区分Column.ColumnName).Value
        Me.ddl発注単位区分.SelectedValue = Me.grdDetall.Rows(i).Cells(tbl.発注単位区分Column.ColumnName).Value

        '----------------------------------------------------------------------
        ' ﾃｷｽﾄﾎﾞｯｸｽ 書式適用
        '----------------------------------------------------------------------
        Me.TextBoxFormat()
    End Sub

    '''========================================================================================
    '''  <summary>行更新(検査)</summary>
    '''========================================================================================
    Private Sub grdDetall_RowUpdateValid(ByRef IsError As Boolean) Handles grdDetall.RowUpdateValid
        ' 検査
        Select Case Frame.Valid_RowAdd
            Case NodeContents.ActionButton.ErrorLevel.Warning
                CType(Frame.ControlError, System.Windows.Forms.Control).Focus()
                If MsgBox(Frame.LastError, MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "警告") = MsgBoxResult.Cancel Then
                    IsError = True
                End If

            Case NodeContents.ActionButton.ErrorLevel.Fatal
                CType(Frame.ControlError, System.Windows.Forms.Control).Focus()
                MsgBox(Frame.LastError, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
                IsError = True
        End Select
    End Sub

    '''========================================================================================
    '''  <summary>行更新(実行)</summary>
    '''========================================================================================
    Private Sub grdDetall_RowUpdateExecute(ByVal RowIndex As Integer) Handles grdDetall.RowUpdateExecute
        Dim tbl As New NodeDatabase.DataSetView.V0オフセット発注DataTable

        Frame.Fields.Detail1(RowIndex).発注先CD.Value = Me.txt発注先CD.Text
        Frame.Fields.Detail1(RowIndex).仕入先名.Value = Me.nam仕入先名.Text
        Frame.Fields.Detail1(RowIndex).工程区分.Value = Me.ddl工程区分.SelectedValue
        Frame.Fields.Detail1(RowIndex).工程区分名.Value = Me.ddl工程区分.Text
        Frame.Fields.Detail1(RowIndex).発注日.Value = Me.txt発注日.Text
        Frame.Fields.Detail1(RowIndex).発注納期.Value = Me.txt発注納期.Text
        Frame.Fields.Detail1(RowIndex).発注数.Value = Me.txt発注数.Text
        Frame.Fields.Detail1(RowIndex).発注単位区分.Value = Me.ddl発注単位区分.SelectedValue
        Frame.Fields.Detail1(RowIndex).発注単位区分名.Value = Me.ddl発注単位区分.Text
        Frame.Fields.Detail1(RowIndex).発注単価.Value = Me.txt発注単価.Text
        Frame.Fields.Detail1(RowIndex).発注金額.Value = BaseCore.Common.Calc.RoundDown(BaseCore.Common.Text.CVal(Me.txt発注数.Text) * BaseCore.Common.Text.CVal(Me.txt発注単価.Text), 0)
    End Sub

    '''========================================================================================
    '''  <summary>行挿入(実行)</summary>
    '''========================================================================================
    Private Sub grdDetall_RowInsert(RowIndex As Integer) Handles grdDetall.RowInsert
        Frame.Insert_Detail1(RowIndex)
    End Sub

    '''========================================================================================
    '''  <summary>行削除(実行)</summary>
    '''========================================================================================
    Private Sub grdDetall_RowDelete(RowIndex As Integer) Handles grdDetall.RowDelete
        Frame.Del_Detail1(RowIndex)
    End Sub
#End Region

#Region "ﾌｧﾝｸｼｮﾝ"
    '''========================================================================================
    '''  <summary>検索</summary>
    '''========================================================================================
    Protected Overrides Sub btnF07_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF07_Click(sender, e)

        '----------------------------------------------------------------------
        ' ﾀﾞｲｱﾛｸﾞｵｰﾌﾟﾝ
        '----------------------------------------------------------------------
        Dialog.Common.Open(Me)
    End Sub

    '''========================================================================================
    '''  <summary>確定</summary>
    '''========================================================================================
    Protected Overrides Sub btnF12_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF12_Click(sender, e)

        '----------------------------------------------------------------------
        ' 実行
        '----------------------------------------------------------------------
        Select Case True
            Case Me.opt登録.Checked Or Me.opt修正.Checked
                '-------------------------------------
                ' 保存
                '-------------------------------------
                ' 検査
                Select Case Frame.Valid_Write
                    Case NodeContents.ActionButton.ErrorLevel.Warning
                        CType(Frame.ControlError, System.Windows.Forms.Control).Focus()
                        If MsgBox(Frame.LastError, MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "警告") = MsgBoxResult.Cancel Then
                            Exit Sub
                        End If

                    Case NodeContents.ActionButton.ErrorLevel.Fatal
                        CType(Frame.ControlError, System.Windows.Forms.Control).Focus()
                        MsgBox(Frame.LastError, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
                        Exit Sub
                End Select

                ' 確認
                Select Case True
                    Case Me.opt登録.Checked
                        If MsgBox("登録しますか？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "確認") = MsgBoxResult.No Then
                            Exit Sub
                        End If
                    Case Me.opt修正.Checked
                        If MsgBox("修正しますか？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "確認") = MsgBoxResult.No Then
                            Exit Sub
                        End If
                End Select

                ' 実行
                Frame.Write()

            Case Me.opt削除.Checked
                '-------------------------------------
                ' 削除
                '-------------------------------------
                ' 検査
                Select Case Frame.Valid_Delete
                    Case NodeContents.ActionButton.ErrorLevel.Warning
                        CType(Frame.ControlError, System.Windows.Forms.Control).Focus()
                        If MsgBox(Frame.LastError, MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "警告") = MsgBoxResult.Cancel Then
                            Exit Sub
                        End If

                    Case NodeContents.ActionButton.ErrorLevel.Fatal
                        CType(Frame.ControlError, System.Windows.Forms.Control).Focus()
                        MsgBox(Frame.LastError, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
                        Exit Sub
                End Select

                ' 確認
                If MsgBox("削除しますか？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "確認") = MsgBoxResult.No Then
                    Exit Sub
                End If

                ' 実行
                Frame.Delete()
        End Select

        '-------------------------------------
        ' 画面ｸﾘｱ
        '-------------------------------------
        Frame.Clear()

        '-------------------------------------
        ' ﾊﾞｲﾝﾄﾞ(ﾌﾚｰﾑﾌｨｰﾙﾄﾞ → ｸﾞﾘｯﾄﾞ)
        '-------------------------------------
        Me.grdDetall_DataBind()

        '-------------------------------------
        ' ｷｰ部入力制御
        '-------------------------------------
        Me.FormEnableKey()
    End Sub
#End Region
End Class
