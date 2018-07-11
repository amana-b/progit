Public Class frmOrderPaper
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
        F02 = "行追加"
        F03 = "行削除"
        F06 = "ﾒｰｶｰ専用" & vbCrLf & "原紙検索"
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
        Me.txt巻取区分名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt出し方向区分名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt紙管.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt枚数.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txtスリッター区分名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txtスリッター巾.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txtカット1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txtカット2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txtカット3.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt梱包枚数.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt送りピッチ.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt紙CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M紙, Me.txt紙CD.Name, Me.nam紙名.Name)
        Me.txt紙名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt糊CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M糊, Me.txt糊CD.Name, Me.nam糊名.Name)
        Me.txt糊名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt台紙CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M台紙, Me.txt台紙CD.Name, Me.nam台紙名.Name)
        Me.txt台紙名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt巾mm.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt長さm.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt仕入先CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M仕入先, Me.txt仕入先CD.Name, Me.nam仕入先名.Name)
        Me.txt発注単価.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt有償支給単価.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt発注日付.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.YYYYMMDD, NodeUI.Help.Type.None, "", "")
        Me.txt通数.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt送りmm.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt刷出m.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txtつなぎロス.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txtその他m.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt希望納期日付.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.YYYYMMDD, NodeUI.Help.Type.None, "", "")
        Me.txt基準長.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt発注用摘要1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt発注用摘要2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt発注用摘要3.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")

        ' ﾈｰﾑﾎﾞｯｸｽ
        Me.nam巻取.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam出し方向.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam紙管.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam枚数.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.namスリッター.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.namスリッター巾.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.namカット.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam梱包枚数.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam送りピッチ.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam紙CD.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam紙名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam糊CD.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam糊名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam台紙CD.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam台紙名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.namサイズ.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam仕入先指定区分.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam仕入先CD.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam仕入先名Title.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam仕入先名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam単価区分.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam発注単価.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam支給区分.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam有償支給単価.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam発注日付.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam通数.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam送りmm.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam刷出m.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.namつなぎロス.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.namその他m.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam希望納期日付.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam希望時間帯区分.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam基準長.PropetyInitForm(BaseContents.TextBox.TextStyle.None)

        ' ﾄﾞﾛｯﾌﾟﾀﾞｳﾝ
        Me.ddl巻取区分.PropetyInitForm(BaseContents.Field.LockType.Data, False, NodeUI.List.Type.M区分_巻取区分)
        Me.ddl出し方向区分.PropetyInitForm(BaseContents.Field.LockType.Data, False, NodeUI.List.Type.M区分_出し方向区分)
        Me.ddlスリッター区分.PropetyInitForm(BaseContents.Field.LockType.Data, False, NodeUI.List.Type.M区分_スリッター区分)
        Me.ddl仕入先指定区分.PropetyInitForm(BaseContents.Field.LockType.Data, False, NodeUI.List.Type.M区分_仕入先指定区分)
        Me.ddl単価区分.PropetyInitForm(BaseContents.Field.LockType.Data, False, NodeUI.List.Type.M区分_単価区分)
        Me.ddl支給区分.PropetyInitForm(BaseContents.Field.LockType.Data, False, NodeUI.List.Type.M区分_支給区分)
        Me.ddl希望時間帯区分.PropetyInitForm(BaseContents.Field.LockType.Data, False, NodeUI.List.Type.M区分_希望時間帯区分)
        Me.ddl社内外区分.PropetyInitForm(BaseContents.Field.LockType.Data, False, NodeUI.List.Type.M区分_社内外区分)

        ' ﾎﾞﾀﾝ
        Me.btn外注.PropetyInitForm(BaseContents.Field.LockType.Data)
        Me.btn戻る.PropetyInitForm(BaseContents.Field.LockType.Data)
    End Sub

    '''========================================================================================
    '''  <summary>ﾌﾚｰﾑﾜｰｸの準備</summary>
    '''========================================================================================
    Protected Overrides Sub FrameInit()
        '-------------------------------------
        ' ｺﾝｽﾄﾗｸﾀ
        '-------------------------------------
        Frame = CType(Me.Owner, frmOrderBase).Frame    ' 親ﾌｫｰﾑのﾌﾚｰﾑﾜｰｸを使用する

        '-------------------------------------
        ' 紐付け
        '-------------------------------------
        Frame.Fields.HeaderPaper.巻取区分.Control = Me.ddl巻取区分
        Frame.Fields.HeaderPaper.巻取区分名.Control = Me.txt巻取区分名
        Frame.Fields.HeaderPaper.出し方向区分.Control = Me.ddl出し方向区分
        Frame.Fields.HeaderPaper.出し方向区分名.Control = Me.txt出し方向区分名
        Frame.Fields.HeaderPaper.紙管.Control = Me.txt紙管
        Frame.Fields.HeaderPaper.発行枚数.Control = Me.txt枚数
        Frame.Fields.HeaderPaper.スリッター区分.Control = Me.ddlスリッター区分
        Frame.Fields.HeaderPaper.スリッター区分名.Control = Me.txtスリッター区分名
        Frame.Fields.HeaderPaper.スリッター巾.Control = Me.txtスリッター巾
        Frame.Fields.HeaderPaper.カット1.Control = Me.txtカット1
        Frame.Fields.HeaderPaper.カット2.Control = Me.txtカット2
        Frame.Fields.HeaderPaper.カット3.Control = Me.txtカット3
        Frame.Fields.HeaderPaper.包装枚数.Control = Me.txt梱包枚数
        Frame.Fields.HeaderPaper.送りピッチ.Control = Me.txt送りピッチ
        Frame.Fields.HeaderPaper.社内外区分.Control = Me.ddl社内外区分

        Frame.Fields.HeaderPaper.紙CD.Control = Me.txt紙CD
        Frame.Fields.HeaderPaper.紙名.Control = Me.txt紙名
        Frame.Fields.HeaderPaper.糊CD.Control = Me.txt糊CD
        Frame.Fields.HeaderPaper.糊名.Control = Me.txt糊名
        Frame.Fields.HeaderPaper.台紙CD.Control = Me.txt台紙CD
        Frame.Fields.HeaderPaper.台紙名.Control = Me.txt台紙名
        Frame.Fields.HeaderPaper.寸法巾.Control = Me.txt巾mm
        Frame.Fields.HeaderPaper.寸法長.Control = Me.txt長さm
        Frame.Fields.HeaderPaper.仕入先指定区分.Control = Me.ddl仕入先指定区分
        Frame.Fields.HeaderPaper.仕入先CD.Control = Me.txt仕入先CD
        Frame.Fields.HeaderPaper.支社CD.Control = ""
        Frame.Fields.HeaderPaper.単価区分.Control = Me.ddl単価区分
        Frame.Fields.HeaderPaper.発注単価.Control = Me.txt発注単価
        Frame.Fields.HeaderPaper.社内単価.Control = ""
        Frame.Fields.HeaderPaper.納入区分.Control = ""
        Frame.Fields.HeaderPaper.支給区分.Control = Me.ddl支給区分
        Frame.Fields.HeaderPaper.有償支給単価.Control = Me.txt有償支給単価
        Frame.Fields.HeaderPaper.発注日付.Control = Me.txt発注日付
        Frame.Fields.HeaderPaper.通数.Control = Me.txt通数
        Frame.Fields.HeaderPaper.送りMM.Control = Me.txt送りmm
        Frame.Fields.HeaderPaper.刷出M.Control = Me.txt刷出m
        Frame.Fields.HeaderPaper.つなぎロス.Control = Me.txtつなぎロス
        Frame.Fields.HeaderPaper.その他M.Control = Me.txtその他m
        Frame.Fields.HeaderPaper.希望納期日付.Control = Me.txt希望納期日付
        Frame.Fields.HeaderPaper.希望時間帯区分.Control = Me.ddl希望時間帯区分
        Frame.Fields.HeaderPaper.基準長.Control = Me.txt基準長
        Frame.Fields.HeaderPaper.完納区分.Control = ""
        Frame.Fields.HeaderPaper.発注用摘要1.Control = Me.txt発注用摘要1
        Frame.Fields.HeaderPaper.発注用摘要2.Control = Me.txt発注用摘要2
        Frame.Fields.HeaderPaper.発注用摘要3.Control = Me.txt発注用摘要3

        Frame.Fields.HeaderPaper.仕入先名.Control = Me.nam仕入先名
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
        Me.Text = "受注入力(紙発注画面)"

        '----------------------------------------------------------------------
        ' ｳｨﾝﾄﾞｳｻｲｽﾞ指定
        '----------------------------------------------------------------------
        Me.Size = New System.Drawing.Size(1290, 766)

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
    ''' <summary>外注発注ｵｰﾌﾟﾝ</summary>
    '''========================================================================================
    Private Sub btn外注_Click(sender As Object, e As System.EventArgs) Handles btn外注.Click
        Dim frm As New frmOrderOut()
        Me.Hide()
        frm.ShowDialog(Me)
        Me.Show()
    End Sub

    '''========================================================================================
    ''' <summary>受注入力へ戻る</summary>
    '''========================================================================================
    Private Sub btn戻る_Click(sender As Object, e As System.EventArgs) Handles btn戻る.Click
        Me.Close()
    End Sub

    '''========================================================================================
    '''  <summary>ﾒｰｶｰ専用原紙検索</summary>
    '''========================================================================================
    Protected Overrides Sub btnF06_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF06_Click(sender, e)

        '----------------------------------------------------------------------
        ' 紙価格ﾀﾞｲｱﾛｸﾞｵｰﾌﾟﾝ
        '----------------------------------------------------------------------
        Dim strReturnValue As String = ""
        strReturnValue = dlgPaperPriIn.ShowFrom(Me.txt仕入先CD.Text)

        '----------------------------------------------------------------------
        ' 選択行の値を貼り付け
        '----------------------------------------------------------------------
        If strReturnValue = "" Then
            Exit Sub
        End If

        If strReturnValue.Split(vbTab).Length > 0 Then

        End If
        If strReturnValue.Split(vbTab).Length > 0 Then

        End If
        If strReturnValue.Split(vbTab).Length > 0 Then

        End If
        If strReturnValue.Split(vbTab).Length > 0 Then

        End If








        Dim arrValue() As String = strReturnValue.Split(vbTab)

        'Me.nam仕入先名.Text = NodeCore.Common.Logic.CodeToName.仕入先(Me.txt仕入先CD.Text)
        Dim aaa As String = strReturnValue
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
        TextBoxAddTop = Me.txt紙CD
        TextBoxAddBtm = Me.txt発注用摘要3

        ButtonInsert = Me.btnF02
        ButtonDelete = Me.btnF03

        ' ﾌｫﾝﾄ
        Me.grdDetall.Font = New System.Drawing.Font("ＭＳ ゴシック", 12)

        Me.grdDetall.RowHeadersVisible = False      ' 行No 表示/非表示
        Me.grdDetall.RowHeadersWidth = 50           ' 行No の列幅

        '----------------------------------------------------------------------
        ' 列定義
        '----------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetView.V0受注紙発注DataTable

        Dim grdColumn As New DataGridViewColumn
        grdColumn.CellTemplate = New DataGridViewTextBoxCell
        grdColumn.ReadOnly = True
        grdColumn.Name = "乗"
        grdColumn.HeaderText = ""
        grdColumn.Width = 20

        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.紙CDColumn, , , , , , 45))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.紙名Column, , , , , , 170))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.糊CDColumn, , "糊", , , , 33))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.糊名Column, , , , , , 105))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.台紙CDColumn, , "台", , , , 25))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.台紙名Column, , , , , , 105))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.寸法巾Column, , "巾mm", , Windows.Forms.DataGridViewContentAlignment.MiddleRight, "#,##0", 50))
        Me.grdDetall.Columns.Add(grdColumn)
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.寸法長Column, , "長さm", , Windows.Forms.DataGridViewContentAlignment.MiddleRight, "#,##0", 60))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.仕入先指定区分名Column, , "指定", , , , 30))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.仕入先CDColumn, , "ｺｰﾄﾞ", , , , 60))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.仕入先名Column, , , , , , 180))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.単価区分名Column, , "単価区", , , , 60))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.発注単価Column, , , , Windows.Forms.DataGridViewContentAlignment.MiddleRight, "#,##0.00", 80))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.支給区分名Column, , "支給区分", , , , 70))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.有償支給単価Column, , "支給単価", , Windows.Forms.DataGridViewContentAlignment.MiddleRight, "#,##0.00", 60))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.発注日付Column, , "発注日", , , , 90))

        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.作業NOColumn, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.仕入先指定区分Column, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.単価区分Column, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.納入区分Column, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.支給区分Column, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.支社CDColumn, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.社内単価Column, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.納入区分名Column, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.通数Column, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.送りMMColumn, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.刷出MColumn, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.つなぎロスColumn, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.その他MColumn, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.希望納期日付Column, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.希望時間帯区分Column, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.希望時間帯区分名Column, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.基準長Column, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.完納区分Column, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.完納区分名Column, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.発注用摘要1Column, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.発注用摘要2Column, , , False))
        Me.grdDetall.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.発注用摘要3Column, , , False))
    End Sub

    '''========================================================================================
    '''  <summary>ﾊﾞｲﾝﾄﾞ全行(ﾌﾚｰﾑﾌｨｰﾙﾄﾞ → ｸﾞﾘｯﾄﾞ)</summary>
    '''========================================================================================
    Private Sub grdDetall_DataBind() Handles grdDetall.DataBind
        '----------------------------------------------------------------------
        ' 空行追加
        '----------------------------------------------------------------------
        Dim MaxLine As Integer = 100

        If MaxLine > Frame.Fields.Detail2.Count Then
            Frame.Add_Detail2(MaxLine - Frame.Fields.Detail2.Count, False)
        End If

        '----------------------------------------------------------------------
        ' Rows.Clear や Rows.Add 時に｢SelectionChanged｣ｲﾍﾞﾝﾄが発生してしまうので解除
        '----------------------------------------------------------------------
        RemoveHandler Me.grdDetall.SelectionChanged, AddressOf Me.grdDetall_SelectionChanged

        '----------------------------------------------------------------------
        ' ﾊﾞｲﾝﾄﾞ
        '----------------------------------------------------------------------
        Me.grdDetall.Rows.Clear()

        For i As Integer = 0 To Frame.Fields.Detail2.Count - 1
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
        Dim tbl As New NodeDatabase.DataSetView.V0受注紙発注DataTable

        Me.grdDetall.Rows(RowIndex).Cells(tbl.作業NOColumn.ColumnName).Value = Frame.Fields.Detail2(RowIndex).作業NO.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.紙CDColumn.ColumnName).Value = Frame.Fields.Detail2(RowIndex).紙CD.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.紙名Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).紙名.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.糊CDColumn.ColumnName).Value = Frame.Fields.Detail2(RowIndex).糊CD.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.糊名Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).糊名.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.台紙CDColumn.ColumnName).Value = Frame.Fields.Detail2(RowIndex).台紙CD.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.台紙名Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).台紙名.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.寸法巾Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).寸法巾.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.寸法長Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).寸法長.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.仕入先指定区分Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).仕入先指定区分.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.仕入先CDColumn.ColumnName).Value = Frame.Fields.Detail2(RowIndex).仕入先CD.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.支社CDColumn.ColumnName).Value = Frame.Fields.Detail2(RowIndex).支社CD.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.単価区分Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).単価区分.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.発注単価Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).発注単価.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.社内単価Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).社内単価.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.納入区分Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).納入区分.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.支給区分Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).支給区分.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.有償支給単価Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).有償支給単価.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.発注日付Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).発注日付.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.通数Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).通数.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.送りMMColumn.ColumnName).Value = Frame.Fields.Detail2(RowIndex).送りMM.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.刷出MColumn.ColumnName).Value = Frame.Fields.Detail2(RowIndex).刷出M.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.つなぎロスColumn.ColumnName).Value = Frame.Fields.Detail2(RowIndex).つなぎロス.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.その他MColumn.ColumnName).Value = Frame.Fields.Detail2(RowIndex).その他M.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.希望納期日付Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).希望納期日付.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.希望時間帯区分Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).希望時間帯区分.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.基準長Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).基準長.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.完納区分Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).完納区分.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.発注用摘要1Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).発注用摘要1.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.発注用摘要2Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).発注用摘要2.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.発注用摘要3Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).発注用摘要3.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.仕入先名Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).仕入先名.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.仕入先指定区分名Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).仕入先指定区分名.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.単価区分名Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).単価区分名.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.納入区分名Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).納入区分名.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.支給区分名Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).支給区分名.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.希望時間帯区分名Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).希望時間帯区分名.Value
        Me.grdDetall.Rows(RowIndex).Cells(tbl.完納区分名Column.ColumnName).Value = Frame.Fields.Detail2(RowIndex).完納区分名.Value

        If BaseCore.Common.Text.CVal(Frame.Fields.Detail2(RowIndex).寸法巾.Value) <> 0 Then
            Me.grdDetall.Rows(RowIndex).Cells("乗").Value = "×"
        End If
    End Sub

    '''========================================================================================
    '''  <summary>行選択</summary>
    '''========================================================================================
    Private Sub grdDetall_SelectionChanged(sender As Object, e As System.EventArgs) Handles grdDetall.SelectionChanged
        If Me.grdDetall.CurrentRow Is Nothing Then
            Exit Sub
        End If

        Dim tbl As New NodeDatabase.DataSetView.V0受注紙発注DataTable
        Dim i As Integer = Me.grdDetall.CurrentRow.Index

        Me.txt紙CD.Text = Me.grdDetall.Rows(i).Cells(tbl.紙CDColumn.ColumnName).Value
        Me.txt紙名.Text = Me.grdDetall.Rows(i).Cells(tbl.紙名Column.ColumnName).Value
        Me.txt糊CD.Text = Me.grdDetall.Rows(i).Cells(tbl.糊CDColumn.ColumnName).Value
        Me.txt糊名.Text = Me.grdDetall.Rows(i).Cells(tbl.糊名Column.ColumnName).Value
        Me.txt台紙CD.Text = Me.grdDetall.Rows(i).Cells(tbl.台紙CDColumn.ColumnName).Value
        Me.txt台紙名.Text = Me.grdDetall.Rows(i).Cells(tbl.台紙名Column.ColumnName).Value
        Me.txt巾mm.Text = Me.grdDetall.Rows(i).Cells(tbl.寸法巾Column.ColumnName).Value
        Me.txt長さm.Text = Me.grdDetall.Rows(i).Cells(tbl.寸法長Column.ColumnName).Value
        Me.ddl仕入先指定区分.Text = Me.grdDetall.Rows(i).Cells(tbl.仕入先指定区分Column.ColumnName).Value
        Me.txt仕入先CD.Text = Me.grdDetall.Rows(i).Cells(tbl.仕入先CDColumn.ColumnName).Value
        Me.nam仕入先名.Text = Me.grdDetall.Rows(i).Cells(tbl.仕入先名Column.ColumnName).Value
        Me.ddl単価区分.Text = Me.grdDetall.Rows(i).Cells(tbl.単価区分Column.ColumnName).Value
        Me.txt発注単価.Text = Me.grdDetall.Rows(i).Cells(tbl.発注単価Column.ColumnName).Value
        Me.ddl支給区分.Text = Me.grdDetall.Rows(i).Cells(tbl.支給区分Column.ColumnName).Value
        Me.txt有償支給単価.Text = Me.grdDetall.Rows(i).Cells(tbl.有償支給単価Column.ColumnName).Value
        Me.txt発注日付.Text = Me.grdDetall.Rows(i).Cells(tbl.発注日付Column.ColumnName).Value
        Me.txt通数.Text = Me.grdDetall.Rows(i).Cells(tbl.通数Column.ColumnName).Value
        Me.txt送りmm.Text = Me.grdDetall.Rows(i).Cells(tbl.送りMMColumn.ColumnName).Value
        Me.txt刷出m.Text = Me.grdDetall.Rows(i).Cells(tbl.刷出MColumn.ColumnName).Value
        Me.txtつなぎロス.Text = Me.grdDetall.Rows(i).Cells(tbl.つなぎロスColumn.ColumnName).Value
        Me.txtその他m.Text = Me.grdDetall.Rows(i).Cells(tbl.その他MColumn.ColumnName).Value
        Me.txt希望納期日付.Text = Me.grdDetall.Rows(i).Cells(tbl.希望納期日付Column.ColumnName).Value
        Me.ddl希望時間帯区分.Text = Me.grdDetall.Rows(i).Cells(tbl.希望時間帯区分Column.ColumnName).Value
        Me.txt基準長.Text = Me.grdDetall.Rows(i).Cells(tbl.基準長Column.ColumnName).Value
        Me.txt発注用摘要1.Text = Me.grdDetall.Rows(i).Cells(tbl.発注用摘要1Column.ColumnName).Value
        Me.txt発注用摘要2.Text = Me.grdDetall.Rows(i).Cells(tbl.発注用摘要2Column.ColumnName).Value
        Me.txt発注用摘要3.Text = Me.grdDetall.Rows(i).Cells(tbl.発注用摘要3Column.ColumnName).Value

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
        Dim tbl As New NodeDatabase.DataSetView.V0受注紙発注DataTable

        Frame.Fields.Detail2(RowIndex).紙CD.Value = Me.txt紙CD.Text
        Frame.Fields.Detail2(RowIndex).紙名.Value = Me.txt紙名.Text
        Frame.Fields.Detail2(RowIndex).糊CD.Value = Me.txt糊CD.Text
        Frame.Fields.Detail2(RowIndex).糊名.Value = Me.txt糊名.Text
        Frame.Fields.Detail2(RowIndex).台紙CD.Value = Me.txt台紙CD.Text
        Frame.Fields.Detail2(RowIndex).台紙名.Value = Me.txt台紙名.Text
        Frame.Fields.Detail2(RowIndex).寸法巾.Value = Me.txt巾mm.Text
        Frame.Fields.Detail2(RowIndex).寸法長.Value = Me.txt長さm.Text
        Frame.Fields.Detail2(RowIndex).仕入先指定区分.Value = Me.ddl仕入先指定区分.Text
        Frame.Fields.Detail2(RowIndex).仕入先CD.Value = Me.txt仕入先CD.Text
        Frame.Fields.Detail2(RowIndex).仕入先名.Value = Me.nam仕入先名.Text
        Frame.Fields.Detail2(RowIndex).単価区分.Value = Me.ddl単価区分.Text
        Frame.Fields.Detail2(RowIndex).発注単価.Value = Me.txt発注単価.Text
        Frame.Fields.Detail2(RowIndex).支給区分.Value = Me.ddl支給区分.Text
        Frame.Fields.Detail2(RowIndex).有償支給単価.Value = Me.txt有償支給単価.Text
        Frame.Fields.Detail2(RowIndex).発注日付.Value = Me.txt発注日付.Text
        Frame.Fields.Detail2(RowIndex).通数.Value = Me.txt通数.Text
        Frame.Fields.Detail2(RowIndex).送りMM.Value = Me.txt送りmm.Text
        Frame.Fields.Detail2(RowIndex).刷出M.Value = Me.txt刷出m.Text
        Frame.Fields.Detail2(RowIndex).つなぎロス.Value = Me.txtつなぎロス.Text
        Frame.Fields.Detail2(RowIndex).その他M.Value = Me.txtその他m.Text
        Frame.Fields.Detail2(RowIndex).希望納期日付.Value = Me.txt希望納期日付.Text
        Frame.Fields.Detail2(RowIndex).希望時間帯区分.Value = Me.ddl希望時間帯区分.Text
        Frame.Fields.Detail2(RowIndex).基準長.Value = Me.txt基準長.Text
        Frame.Fields.Detail2(RowIndex).発注用摘要1.Value = Me.txt発注用摘要1.Text
        Frame.Fields.Detail2(RowIndex).発注用摘要2.Value = Me.txt発注用摘要2.Text
        Frame.Fields.Detail2(RowIndex).発注用摘要3.Value = Me.txt発注用摘要3.Text
    End Sub

    '''========================================================================================
    '''  <summary>行挿入(実行)</summary>
    '''========================================================================================
    Private Sub grdDetall_RowInsert(RowIndex As Integer) Handles grdDetall.RowInsert
        Frame.Insert_Detail2(RowIndex)
    End Sub

    '''========================================================================================
    '''  <summary>行削除(実行)</summary>
    '''========================================================================================
    Private Sub grdDetall_RowDelete(RowIndex As Integer) Handles grdDetall.RowDelete
        Frame.Del_Detail2(RowIndex)
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
