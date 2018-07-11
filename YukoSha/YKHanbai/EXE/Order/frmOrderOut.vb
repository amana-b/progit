Public Class frmOrderOut
    Inherits BaseUI.BaseForm

#Region "ﾌﾚｰﾑﾜｰｸ"
    Private Frame As NodeCore.Frame.Order.OrderBase
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
        F07 = "検索"
        F08 = "行確定"
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
        Me.txt外注先CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txt発注納期.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.YYYYMMDD, NodeUI.Help.Type.None, "", "")
        Me.txt発注単価.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt発注金額.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt発注単価商品.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")

        ' ﾈｰﾑﾎﾞｯｸｽ
        Me.nam外注先名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam本台帳NO.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam商品名代表.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam受注数合計.PropetyInitForm(BaseContents.TextBox.TextStyle.Currency)
        Me.nam内在庫引当数合計.PropetyInitForm(BaseContents.TextBox.TextStyle.Currency)
        Me.nam内製造数合計.PropetyInitForm(BaseContents.TextBox.TextStyle.Currency)
        Me.nam受注単価.PropetyInitForm(BaseContents.TextBox.TextStyle.Currency)
        Me.nam受注金額.PropetyInitForm(BaseContents.TextBox.TextStyle.Currency)
        Me.nam枝番.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam定番CD.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam商品名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam受注数.PropetyInitForm(BaseContents.TextBox.TextStyle.Currency)
        Me.nam内在庫引当数.PropetyInitForm(BaseContents.TextBox.TextStyle.Currency)
        Me.nam内製造数.PropetyInitForm(BaseContents.TextBox.TextStyle.Currency)
        Me.nam受注単価商品.PropetyInitForm(BaseContents.TextBox.TextStyle.Currency)

        Me.nam本台帳NOTitle.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam商品名代表Title.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam受注数合計Title.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam内在庫引当数合計Title.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam内製造数合計Title.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam受注単価Title.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam受注金額Title.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam発注単価Title.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam発注金額Title.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam枝番Title.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam定番CDTitle.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam商品名Title.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam受注数Title.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam内在庫引当数Title.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam内製造数Title.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam受注単価商品Title.PropetyInitForm(BaseContents.TextBox.TextStyle.None)

        ' ﾎﾞﾀﾝ
        Me.btn戻る.PropetyInitForm(BaseContents.Field.LockType.Data)
    End Sub

    '''========================================================================================
    '''  <summary>ﾌﾚｰﾑﾜｰｸの準備</summary>
    '''========================================================================================
    Protected Overrides Sub FrameInit()
        '-------------------------------------
        ' ｺﾝｽﾄﾗｸﾀ
        '-------------------------------------
        Frame = CType(Me.Owner.Owner, frmOrderBase).Frame    ' 親ﾌｫｰﾑのﾌﾚｰﾑﾜｰｸを使用する

        '-------------------------------------
        ' 紐付け
        '-------------------------------------
        Frame.Fields.HeaderOut.外注先CD.Control = Me.txt外注先CD
        Frame.Fields.HeaderOut.発注単価.Control = Me.txt発注単価
        Frame.Fields.HeaderOut.発注金額.Control = Me.txt発注金額
        Frame.Fields.HeaderOut.発注納期.Control = Me.txt発注納期

        Frame.Fields.HeaderOut.発注単価商品.Control = Me.txt発注単価商品
        Frame.Fields.HeaderOut.外注先名.Control = Me.nam外注先名

        Frame.Fields.HeaderBase.本台帳NO.Control = Me.nam本台帳NO
        Frame.Fields.HeaderBase.代表商品名.Control = Me.nam商品名代表
        Frame.Fields.HeaderBase.受注数合計.Control = Me.nam受注数合計
        Frame.Fields.HeaderBase.内在庫引当数合計.Control = Me.nam内在庫引当数合計
        Frame.Fields.HeaderBase.内製造数合計.Control = Me.nam内製造数合計
        Frame.Fields.HeaderBase.受注単価.Control = Me.nam受注単価
        Frame.Fields.HeaderBase.受注金額.Control = Me.nam受注金額

        Frame.Fields.HeaderItem.枝番.Control = Me.nam枝番
        Frame.Fields.HeaderItem.定番CD.Control = Me.nam定番CD
        Frame.Fields.HeaderItem.商品名.Control = Me.nam商品名
        Frame.Fields.HeaderItem.受注数.Control = Me.nam受注数
        Frame.Fields.HeaderItem.内在庫引当数.Control = Me.nam内在庫引当数
        Frame.Fields.HeaderItem.内製造数.Control = Me.nam内製造数
        Frame.Fields.HeaderItem.受注単価.Control = Me.nam受注単価商品
    End Sub
#End Region

#Region "ﾍﾟｰｼﾞｲﾍﾞﾝﾄ"
    '''========================================================================================
    '''  <summary>ﾍﾟｰｼﾞﾛｰﾄﾞ</summary>
    '''========================================================================================
    Private Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        '----------------------------------------------------------------------
        ' ﾀｲﾄﾙ
        '----------------------------------------------------------------------
        Me.Text = "受注入力(外注発注画面)"

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
    End Sub
#End Region

#Region "ﾕｰｻﾞｲﾍﾞﾝﾄ"
    '''========================================================================================
    ''' <summary>受注基本ｵｰﾌﾟﾝ</summary>
    '''========================================================================================
    Private Sub btn戻る_Click(sender As Object, e As System.EventArgs) Handles btn戻る.Click
        Me.Close()
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
        TextBoxAddTop = Me.txt発注単価商品
        TextBoxAddBtm = Me.txt発注単価商品

        ButtonInsert = Me.btnF02
        ButtonDelete = Me.btnF03

        Me.grdDetall.RowHeadersVisible = True       ' 行No 表示/非表示
        Me.grdDetall.RowHeadersWidth = 30           ' 行No の列幅

        '----------------------------------------------------------------------
        ' 列定義
        '----------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetView.V0受注商品内訳DataTable

        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.枝番Column, , "枝", , , , 30))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.定番CDColumn, , "定番CD", , , , 110))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.商品名Column, , , , , , 270))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.受注数Column, , , , Windows.Forms.DataGridViewContentAlignment.MiddleRight, "#,##0", 95))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.内在庫引当数Column, , "内在庫引当", , Windows.Forms.DataGridViewContentAlignment.MiddleRight, "#,##0", 95))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.内製造数Column, , , , Windows.Forms.DataGridViewContentAlignment.MiddleRight, "#,##0", 95))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.受注単価Column, , , , Windows.Forms.DataGridViewContentAlignment.MiddleRight, "#,##0.00", 100))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.発注単価Column, , , , Windows.Forms.DataGridViewContentAlignment.MiddleRight, "#,##0.00", 100))

        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.作業NOColumn, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.行NOColumn, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.納品日付AColumn, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.納品日付BColumn, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.顧客商品CDColumn, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.顧客発注NOColumn, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.倉庫NOColumn, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.備考Column, , , False))
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
        Dim tbl As New NodeDatabase.DataSetView.V0受注商品内訳DataTable

        Me.grdDetall.Rows(RowIndex).Cells(tbl.作業NOColumn.ColumnName).Value = Frame.Fields.Detail1(RowIndex).作業NO.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.枝番Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).枝番.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.定番CDColumn.ColumnName).Value = Frame.Fields.Detail1(RowIndex).定番CD.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.商品名Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).商品名.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.受注数Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).受注数.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.内在庫引当数Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).内在庫引当数.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.内製造数Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).内製造数.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.受注単価Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).受注単価.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.発注単価Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).発注単価.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.納品日付AColumn.ColumnName).Value = Frame.Fields.Detail1(RowIndex).納品日付A.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.納品日付BColumn.ColumnName).Value = Frame.Fields.Detail1(RowIndex).納品日付B.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.顧客商品CDColumn.ColumnName).Value = Frame.Fields.Detail1(RowIndex).顧客商品CD.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.顧客発注NOColumn.ColumnName).Value = Frame.Fields.Detail1(RowIndex).顧客発注NO.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.倉庫NOColumn.ColumnName).Value = Frame.Fields.Detail1(RowIndex).倉庫NO.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.備考Column.ColumnName).Value = Frame.Fields.Detail1(RowIndex).備考.Value
    End Sub

    '''========================================================================================
    '''  <summary>行選択</summary>
    '''========================================================================================
    Private Sub grdDetall_SelectionChanged(sender As Object, e As System.EventArgs) Handles grdDetall.SelectionChanged
        If Me.grdDetall.CurrentRow Is Nothing Then
            Exit Sub
        End If

        Dim tbl As New NodeDatabase.DataSetView.V0受注商品内訳DataTable
        Dim i As Integer = Me.grdDetall.CurrentRow.Index

        Me.nam枝番.Text = Me.grdDetall.Rows(i).Cells(tbl.枝番Column.ColumnName).Value
        Me.nam定番CD.Text = Me.grdDetall.Rows(i).Cells(tbl.定番CDColumn.ColumnName).Value
        Me.nam商品名.Text = Me.grdDetall.Rows(i).Cells(tbl.商品名Column.ColumnName).Value
        Me.nam受注数.Text = Me.grdDetall.Rows(i).Cells(tbl.受注数Column.ColumnName).Value
        Me.nam内在庫引当数.Text = Me.grdDetall.Rows(i).Cells(tbl.内在庫引当数Column.ColumnName).Value
        Me.nam内製造数.Text = Me.grdDetall.Rows(i).Cells(tbl.内製造数Column.ColumnName).Value
        Me.nam受注単価商品.Text = Me.grdDetall.Rows(i).Cells(tbl.受注単価Column.ColumnName).Value
        Me.txt発注単価商品.Text = Me.grdDetall.Rows(i).Cells(tbl.発注単価Column.ColumnName).Value

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
        Dim tbl As New NodeDatabase.DataSetView.V0受注商品内訳DataTable

        Frame.Fields.Detail1(RowIndex).枝番.Value = Me.nam枝番.Text
        Frame.Fields.Detail1(RowIndex).定番CD.Value = Me.nam定番CD.Text
        Frame.Fields.Detail1(RowIndex).商品名.Value = Me.nam商品名.Text
        Frame.Fields.Detail1(RowIndex).受注数.Value = Me.nam受注数.Text
        Frame.Fields.Detail1(RowIndex).内在庫引当数.Value = Me.nam内在庫引当数.Text
        Frame.Fields.Detail1(RowIndex).内製造数.Value = Me.nam内製造数.Text
        Frame.Fields.Detail1(RowIndex).受注単価.Value = Me.nam受注単価商品.Text
        Frame.Fields.Detail1(RowIndex).発注単価.Value = Me.txt発注単価.Text
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
    End Sub
#End Region
End Class
