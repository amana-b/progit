Public Class frmBalanceMonthly
    Inherits BaseUI.BaseForm

#Region "ﾌﾚｰﾑﾜｰｸ"
    Private Frame As NodeCore.Frame.Master.BalanceMonthly
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

        ' ﾃｷｽﾄﾎﾞｯｸｽ
        Me.txt取引先CD.PropetyInitForm(BaseContents.Field.LockType.Key, True, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M取引先, Me.txt取引先CD.Name & vbTab & Me.ddl取引先区分.Name, "")
        Me.txt月次年月.PropetyInitForm(BaseContents.Field.LockType.Data, True, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.YYYYMMDD, NodeUI.Help.Type.M仕入先, "", "")
        Me.txt月次残高.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        ' ﾈｰﾑﾎﾞｯｸｽ
        Me.nam取引先名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam締日.PropetyInitForm(BaseContents.TextBox.TextStyle.None)

        ' ﾄﾞﾛｯﾌﾟﾀﾞｳﾝ
        Me.ddl取引先区分.PropetyInitForm(BaseContents.Field.LockType.Key, True, NodeUI.List.Type.M区分_取引先区分)

    End Sub

    '''========================================================================================
    '''  <summary>ﾌﾚｰﾑﾜｰｸの準備</summary>
    '''========================================================================================
    Protected Overrides Sub FrameInit()
        '-------------------------------------
        ' ｺﾝｽﾄﾗｸﾀ
        '-------------------------------------
        Frame = New NodeCore.Frame.Master.BalanceMonthly(Me.Security, Me.Config)

        '-------------------------------------
        ' 紐付け
        '-------------------------------------
        Frame.Fields.Header.取引先区分.Control = Me.ddl取引先区分
        Frame.Fields.Header.取引先CD.Control = Me.txt取引先CD
        Frame.Fields.Header.取引先名.Control = Me.nam取引先名
        Frame.Fields.Header.締日.Control = Me.nam締日
        Frame.Fields.Header.月次年月.Control = Me.txt月次年月
        Frame.Fields.Header.月次残高.Control = Me.txt月次残高
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
        ' 明細行初期化
        '----------------------------------------------------------------------
        Me.txt取引先CD_AfterUpdate(Me, System.EventArgs.Empty)

        '----------------------------------------------------------------------
        ' ｷｰ部入力制御
        '----------------------------------------------------------------------
        'Me.FormEnableKey()
    End Sub
#End Region

#Region "ﾕｰｻﾞｲﾍﾞﾝﾄ"
    '''========================================================================================
    ''' <summary>ｷｰ変更</summary>
    '''========================================================================================
    Private Sub ddl取引先区分_AfterUpdate(sender As Object, e As System.EventArgs) Handles ddl取引先区分.AfterUpdate
        Me.txt取引先CD_AfterUpdate(Me, System.EventArgs.Empty)
    End Sub

    Private Sub txt取引先CD_AfterUpdate(sender As Object, e As System.EventArgs) Handles txt取引先CD.AfterUpdate
        '----------------------------------------------------------------------
        ' 該当ﾃﾞｰﾀ 読込
        '----------------------------------------------------------------------
        Frame.Read()

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
        'Me.FormEnableData()
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
        TextBoxAddTop = Me.txt月次年月
        TextBoxAddBtm = Me.txt月次残高

        ButtonInsert = Me.btnF02
        ButtonDelete = Me.btnF03

        Me.grdDetall.RowHeadersVisible = True       ' 行No 表示/非表示
        Me.grdDetall.RowHeadersWidth = 45           ' 行No の列幅

        '----------------------------------------------------------------------
        ' 列定義
        '----------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetView.V0残高月次DataTable

        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.月次年月Column, , , , , , 90))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.月次残高Column, , , , Windows.Forms.DataGridViewContentAlignment.MiddleRight, "#,##0", 100))
    End Sub

    '''========================================================================================
    '''  <summary>ﾊﾞｲﾝﾄﾞ全行(ﾌﾚｰﾑﾌｨｰﾙﾄﾞ → ｸﾞﾘｯﾄﾞ)</summary>
    '''========================================================================================
    Private Sub grdDetall_DataBind() Handles grdDetall.DataBind
        '----------------------------------------------------------------------
        ' 空行追加
        '----------------------------------------------------------------------
        Dim MaxLine As Integer = 500

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
        Dim tbl As New NodeDatabase.DataSetView.V0残高月次DataTable

        Me.grdDetall.Rows(RowIndex).Cells(tbl.月次年月Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).月次年月.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.月次残高Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).月次残高.Value
    End Sub

    '''========================================================================================
    '''  <summary>行選択</summary>
    '''========================================================================================
    Private Sub grdDetall_SelectionChanged(sender As Object, e As System.EventArgs) Handles grdDetall.SelectionChanged
        If Me.grdDetall.CurrentRow Is Nothing Then
            Exit Sub
        End If

        Dim tbl As New NodeDatabase.DataSetView.V0残高月次DataTable
        Dim i As Integer = Me.grdDetall.CurrentRow.Index

        Me.txt月次年月.Text = Me.grdDetall.Rows(i).Cells(tbl.月次年月Column.ColumnName).Value
        Me.txt月次残高.Text = Me.grdDetall.Rows(i).Cells(tbl.月次残高Column.ColumnName).Value

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
        Frame.Fields.Detail1(RowIndex).月次年月.Value = Me.txt月次年月.Text
        Frame.Fields.Detail1(RowIndex).月次残高.Value = Me.txt月次残高.Text
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
        ' 確定
        '----------------------------------------------------------------------
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
        If MsgBox("登録しますか？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "確認") = MsgBoxResult.No Then
            Exit Sub
        End If

        ' 実行
        Frame.Write()

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
        'Me.FormEnableKey()
    End Sub
#End Region
End Class
