Public Class BaseDialog
#Region "共通変数"
    Protected Argument() As String                          ' 親ﾌｫｰﾑから受け取った引数
    Protected ReturnValue As String                         ' 親ﾌｫｰﾑに返す戻り値

    Protected GroupBoxCond As New System.Windows.Forms.GroupBox  ' 検索条件ｸﾞﾙｰﾌﾟ

    Protected NumberVisible As Boolean = True               ' ｸﾞﾘｯﾄﾞ行番号の表示
#End Region

#Region "ｲﾍﾞﾝﾄ定義"
    '''========================================================================================
    '''  <summary>準備(ﾍﾟｰｼﾞ)</summary>
    '''========================================================================================
    Public Event PageInitialize()
#End Region

#Region "ｲﾍﾞﾝﾄﾍﾟｰｼﾞ"
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
        ' ｲﾍﾞﾝﾄ発生
        '----------------------------------------------------------------------
        RaiseEvent PageInitialize()

        ' 行No
        Me.grdBase.RowHeadersVisible = NumberVisible

        ' ﾚｺｰﾄﾞｾﾚｸﾀ幅
        Dim SelectorWidth As Integer = 0
        If Me.grdBase.RowHeadersVisible Then
            SelectorWidth = Me.grdBase.TopLeftHeaderCell.Size.Width
        End If

        ' ｸﾞﾘｯﾄﾞ幅取得
        Dim GridWidth As Integer = SelectorWidth + 20  ' +20はｽｸﾛｰﾙﾊﾞｰ
        For Each Column As System.Windows.Forms.DataGridViewColumn In Me.grdBase.Columns
            GridWidth += Column.Width
        Next

        '----------------------------------------------------------------------
        ' ｻｲｽﾞ / 位置
        '----------------------------------------------------------------------
        Dim WidthGridFind As Integer = 30       ' ｸﾞﾘｯﾄﾞと検索条件の間幅

        '-----------------------------------
        ' ﾌｫｰﾑ
        '-----------------------------------
        ' 縦ｻｲｽﾞ
        Me.Height = Me.grpFunc.Height + GroupBoxCond.Height + 120
        If Me.Height < 500 Then
            Me.Height = 500
        End If

        ' 横ｻｲｽﾞ
        If GroupBoxCond.Width < Me.grpFunc.Width Then
            ' 検索条件の幅 < ﾌｧﾝｸｼｮﾝﾎﾞﾀﾝの幅 → ﾌｧﾝｸｼｮﾝﾎﾞﾀﾝの幅 をﾌｫｰﾑ幅の計算元とする
            Me.Width = 20 + GridWidth + Me.grpFunc.Width + WidthGridFind + 25     ' +20はﾌｫｰﾑとｸﾞﾘｯﾄﾞの間幅, +25は条件とﾌｫｰﾑの間幅
        Else
            ' 検索条件の幅 > ﾌｧﾝｸｼｮﾝﾎﾞﾀﾝの幅 → 検索条件の幅 をﾌｫｰﾑ幅の計算元とする
            Me.Width = 20 + GridWidth + GroupBoxCond.Width + WidthGridFind + 25        ' +20はﾌｫｰﾑとｸﾞﾘｯﾄﾞの間幅, +25は条件とﾌｫｰﾑの間幅
        End If

        '-----------------------------------
        ' ｸﾞﾘｯﾄﾞ
        '-----------------------------------
        ' ﾌｫﾝﾄ
        Me.grdBase.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)

        ' 横ｻｲｽﾞ
        Me.grdBase.Width = GridWidth

        ' 縦ｻｲｽﾞ
        Me.grdBase.Height = Me.Height - (25 + 40)

        ' 縦位置
        Me.grdBase.Top = 25

        ' 横位置
        Me.grdBase.Left = 10

        '-----------------------------------
        ' ﾌｧﾝｸｼｮﾝﾎﾞﾀﾝ
        '-----------------------------------
        ' 縦位置
        Me.grpFunc.Top = Me.Height - Me.grpFunc.Height - 40

        ' 左位置
        Me.grpFunc.Left = Me.grdBase.Left + Me.grdBase.Width + WidthGridFind

        '-----------------------------------
        ' 検索条件
        '-----------------------------------
        ' 縦位置
        Me.GroupBoxCond.Top = Me.grdBase.Top

        ' 横位置
        Me.GroupBoxCond.Left = Me.grpFunc.Left

        '----------------------------------------------------------------------
        ' ﾌｫｰﾑ設定
        '----------------------------------------------------------------------
        ' サイズ変更不可の直線ウィンドウに変更する
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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
    Public Event GridInitialize()
    Public Event GridColums()

    Private Sub grdBase_DataBindingComplete(sender As Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles grdBase.DataBindingComplete
        Me.lbl件数.Text = Format(Me.grdBase.RowCount, "#,0 件")
    End Sub

    Private Sub grdBase_HandleCreated(sender As Object, e As System.EventArgs) Handles grdBase.HandleCreated
        ' ｸﾞﾘｯﾄﾞの行高
        Me.grdBase.RowTemplate.Height = 17

        RaiseEvent GridInitialize()
        RaiseEvent GridColums()
    End Sub

    '''========================================================================================
    ''' <summary>ｸﾞﾘｯﾄﾞｼﾝｸﾞﾙｸﾘｯｸ</summary>
    '''========================================================================================
    Private Sub grdBase_Click(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdBase.CellClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        Me.Grid_Value(e.RowIndex)
        Me.btnF12_Click(Me.btnF12, e)
    End Sub

    '''========================================================================================
    ''' <summary>行移動</summary>
    '''========================================================================================
    Private Sub grdBase_RowEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdBase.RowEnter
        Me.Grid_Value(e.RowIndex)
    End Sub

    '''========================================================================================
    '''  <summary>ｸﾞﾘｯﾄﾞｷｰ押下</summary>
    '''========================================================================================
    Private Sub grdBase_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles grdBase.KeyDown
        Select Case e.KeyData
            Case System.Windows.Forms.Keys.Enter : Me.btnF12_Click(Me.btnF12, e)
        End Select
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

        Dim DataRowView As DataRowView = Me.grdBase.Rows(intRow).DataBoundItem
        ' 空白の場合ﾌﾟﾗｲﾏﾘｰｷｰを設定
        If Me.grdBase.DataKeyNames = "" Then
            For Each DataColumn As System.Data.DataColumn In DataRowView.DataView.Table.PrimaryKey
                Me.grdBase.DataKeyNames &= strDelim & DataColumn.ColumnName : strDelim = vbTab
            Next
        End If

        ' DataKeyNamesの値を返却
        strDelim = ""
        For Each DataColumn As String In Me.grdBase.DataKeyNames.Split(vbTab)
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
