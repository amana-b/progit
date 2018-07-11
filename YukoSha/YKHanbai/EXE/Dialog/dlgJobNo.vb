Public Class dlgJobNo
#Region "共通変数"
    Protected Argument() As String      ' 親ﾌｫｰﾑから受け取った引数
    Protected ReturnValue As String     ' 親ﾌｫｰﾑに返す戻り値
#End Region

#Region "定型準備"
    '''========================================================================================
    '''  <summary>呼び出しﾒｿｯﾄﾞ</summary>
    ''' <param name="Value">親画面からのｷｰ情報</param>
    '''========================================================================================
    Public Shared Function ShowFrom(Value As String) As String
        Dim DialogForm As New dlgJobNo

        DialogForm.Argument = Value.Split(vbTab)
        DialogForm.ShowDialog()

        Dim strReturn As String = DialogForm.ReturnValue
        DialogForm.Dispose()

        Return strReturn
    End Function

    '''========================================================================================
    '''  <summary>準備(ﾍﾟｰｼﾞ)</summary>
    '''========================================================================================
    Private Sub Page_Initialize()
        '----------------------------------------------------------------------
        ' ﾀｲﾄﾙ
        '----------------------------------------------------------------------
        Me.Text = "作業NO検索"

        '----------------------------------------------------------------------
        ' ｶｽﾀﾑ定義
        '----------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetView.V0受注基本DataTable

        ' ﾗｼﾞｵﾎﾞﾀﾝ
        Me.opt両方.PropetyInitDialog()
        Me.opt新版.PropetyInitDialog()
        Me.opt再販.PropetyInitDialog()

        ' ﾃｷｽﾄﾎﾞｯｸｽ
        Me.txt得意先CD.PropetyInitDialog(Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "", tbl.得意先CDColumn.MaxLength, 0, 0)
        Me.txt受注日付F.PropetyInitDialog(Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.DateTimeF, NodeUI.Help.Type.None, "", "", tbl.受注日付Column.MaxLength, 0, 0)
        Me.txt受注日付T.PropetyInitDialog(Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.DateTimeT, NodeUI.Help.Type.None, "", "", tbl.受注日付Column.MaxLength, 0, 0)
        Me.txt顧客商品.PropetyInitDialog(Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "", tbl.顧客商品CDColumn.MaxLength, 0, 0)
        Me.txt商品名.PropetyInitDialog(Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "", tbl.代表商品名Column.MaxLength, 0, 0)

        ' ｺﾝﾎﾞﾎﾞｯｸｽ
        Me.ddl受注区分.PropetyInitDialog(NodeUI.List.Type.M区分_受注区分)

        ' ﾈｰﾑﾎﾞｯｸｽ
        Me.nam得意先名.PropetyInitDialog(BaseContents.TextBox.TextStyle.None)
    End Sub
#End Region

#Region "ﾍﾟｰｼﾞｲﾍﾞﾝﾄ"
    '''========================================================================================
    '''  <summary>ﾍﾟｰｼﾞ開始(Load)</summary>
    '''========================================================================================
    Protected Overrides Sub OnLoad(e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ｷｰﾎﾞｰﾄﾞｲﾍﾞﾝﾄ を発生させる
        '----------------------------------------------------------------------
        Me.KeyPreview = True

        '----------------------------------------------------------------------
        ' ﾛｰﾄﾞｲﾍﾞﾝﾄ
        '----------------------------------------------------------------------
        MyBase.OnLoad(e)

        '----------------------------------------------------------------------
        ' ｺﾝﾄﾛｰﾙの準備
        '----------------------------------------------------------------------
        Me.Page_Initialize()

        '----------------------------------------------------------------------
        ' 初期化
        '----------------------------------------------------------------------
        Me.txt得意先CD.Text = ""
        Me.txt受注日付F.Text = ""
        Me.txt受注日付T.Text = ""
        Me.txt顧客商品.Text = ""
        Me.txt商品名.Text = ""
        Me.nam得意先名.Text = ""

        '----------------------------------------------------------------------
        ' ｸﾞﾘｯﾄﾞ
        '----------------------------------------------------------------------
        Me.grdView.RowHeadersVisible = True             ' 行No

        '----------------------------------------------------------------------
        ' ﾌｫｰﾑ設定
        '----------------------------------------------------------------------
        ' サイズ変更不可の直線ウィンドウに変更する
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle       ' ｻｲｽﾞ変更不可
    End Sub

    '''========================================================================================
    '''  <summary>ｷｰ押下</summary>
    '''========================================================================================
    Protected Overrides Sub OnKeyDown(e As System.Windows.Forms.KeyEventArgs)
        '----------------------------------------------------------------------
        '  ﾌｧﾝｸｼｮﾝｷｰ制御
        '----------------------------------------------------------------------
        Select Case e.KeyData
            Case System.Windows.Forms.Keys.Escape : Me.btnESC_Click(Me.btnESC, e)
            Case System.Windows.Forms.Keys.F12 : Me.btnF12_Click(Me.btnF12, e)
            Case System.Windows.Forms.Keys.Enter : Me.btnF12_Click(Me.btnF12, e)
        End Select

        '----------------------------------------------------------------------
        '  Enterｷｰは次項目へ
        '----------------------------------------------------------------------
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            If e.Control = False Then
                Me.SelectNextControl(Me.ActiveControl, Not e.Shift, True, True, True)
            End If
        End If

        MyBase.OnKeyDown(e)
    End Sub
#End Region

#Region "ｸﾞﾘｯﾄﾞ関連"
    '''========================================================================================
    ''' <summary>ｸﾞﾘｯﾄﾞｲﾍﾞﾝﾄ発生</summary>
    '''========================================================================================
    Public Event GridColums()
    Private Sub grdView_HandleCreated(sender As Object, e As System.EventArgs) Handles grdView.HandleCreated
        '----------------------------------------------------------------------
        ' 返却ｷｰ定義
        '----------------------------------------------------------------------
        Me.grdView.DataKeyNames = ""            ' 空白ならﾌﾟﾗｲﾏﾘｷｰを返す

        '----------------------------------------------------------------------
        ' 表示列設定
        '----------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetView.V0受注基本DataTable

        Me.grdView.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.受注日付Column))
        Me.grdView.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.作業NOColumn))
        Me.grdView.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.得意先CDColumn))
        Me.grdView.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.得意先名Column))
        Me.grdView.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.代表商品名Column))
        Me.grdView.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.受注数合計Column))
        Me.grdView.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.受注数合計Column))
    End Sub

    '''========================================================================================
    ''' <summary>ｸﾞﾘｯﾄﾞｼﾝｸﾞﾙｸﾘｯｸ</summary>
    '''========================================================================================
    Private Sub grdView_Click(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdView.CellClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        Me.Grid_Value(e.RowIndex)
        Me.btnF12_Click(Me.btnF12, e)
    End Sub

    '''========================================================================================
    ''' <summary>行移動</summary>
    '''========================================================================================
    Private Sub grdView_RowEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdView.RowEnter
        Me.Grid_Value(e.RowIndex)
    End Sub

    '''========================================================================================
    '''  <summary>値取得</summary>
    '''========================================================================================
    Private Sub Grid_Value(ByVal intRow As Integer)
        If intRow < 0 Then
            Exit Sub
        End If
        Dim strprm As String = ""
        Dim strDelim As String = ""

        Dim DataRowView As DataRowView = Me.grdView.Rows(intRow).DataBoundItem

        ' 空白の場合ﾌﾟﾗｲﾏﾘｰｷｰを設定
        If Me.grdView.DataKeyNames = "" Then
            For Each DataColumn As System.Data.DataColumn In DataRowView.DataView.Table.PrimaryKey
                Me.grdView.DataKeyNames &= strDelim & DataColumn.ColumnName : strDelim = vbTab
            Next
        End If

        ' DataKeyNamesの値を返却
        strDelim = ""
        For Each DataColumn As String In Me.grdView.DataKeyNames.Split(vbTab)
            If DataColumn = "" Then
                Continue For
            End If

            strprm &= strDelim & DataRowView.Row.Item(DataColumn).ToString : strDelim = vbTab
        Next

        Me.ReturnValue = strprm
    End Sub
#End Region

#Region "ｲﾍﾞﾝﾄ発生(ﾌｧﾝｸｼｮﾝ)"
    Public Sub btnESC_Click(sender As Object, e As System.EventArgs) Handles btnESC.Click
        Me.ReturnValue = ""
        Me.Close()
    End Sub

    Public Sub btnF12_Click(sender As Object, e As System.EventArgs) Handles btnF12.Click
        Me.Close()
    End Sub
#End Region
End Class