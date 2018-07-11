Public Class dlgPaperPriIn
    Inherits BaseUI.BaseDialog

#Region "定型準備"
    '''========================================================================================
    '''  <summary>呼び出しﾒｿｯﾄﾞ</summary>
    ''' <param name="Value">親画面からのｷｰ情報</param>
    '''========================================================================================
    Public Shared Function ShowFrom(Value As String) As String
        Dim DialogForm As New dlgPaperPriIn

        DialogForm.Argument = Value.Split(vbTab)
        DialogForm.ShowDialog()

        Dim strReturn As String = DialogForm.ReturnValue
        DialogForm.Dispose()

        Return strReturn
    End Function

    '''========================================================================================
    '''  <summary>準備(ﾍﾟｰｼﾞ)</summary>
    '''========================================================================================
    Private Sub Page_Initialize() Handles Me.PageInitialize
        '----------------------------------------------------------------------
        ' ﾀｲﾄﾙ
        '----------------------------------------------------------------------
        Me.Text = "ﾒｰｶｰ専用原紙検索"

        '----------------------------------------------------------------------
        ' ｶｽﾀﾑ定義
        '----------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetView.V0紙価格DataTable

        ' ﾃｷｽﾄﾎﾞｯｸｽ
        Me.txt仕入先CD.PropetyInitDialog(Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "", tbl.仕入先CDColumn.MaxLength, 0, 0)
        Me.txt名称.PropetyInitDialog(Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "", tbl.社内用紙名Column.MaxLength, 0, 0)

        ' ﾈｰﾑﾎﾞｯｸｽ
        Me.nam仕入先名.PropetyInitDialog(BaseContents.TextBox.TextStyle.None)

        '----------------------------------------------------------------------
        ' 検索条件ｸﾞﾙｰﾌﾟを継承元へ渡す
        '----------------------------------------------------------------------
        Me.GroupBoxCond = Me.grpfind
    End Sub
#End Region

#Region "ﾍﾟｰｼﾞｲﾍﾞﾝﾄ"
    '''========================================================================================
    '''  <summary>ﾍﾟｰｼﾞﾛｰﾄﾞ</summary>
    '''========================================================================================
    Private Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        '----------------------------------------------------------------------
        ' 呼び出しﾊﾟﾗﾒｰﾀ 取得
        '----------------------------------------------------------------------
        Me.txt仕入先CD.Text = Me.Argument(0).ToString
        Me.nam仕入先名.Text = NodeCore.Common.Logic.CodeToName.仕入先(Me.txt仕入先CD.Text)

        '----------------------------------------------------------------------
        ' 検索
        '----------------------------------------------------------------------
        Me.GridBind()
    End Sub
#End Region

#Region "ﾕｰｻﾞｲﾍﾞﾝﾄ"
    '''========================================================================================
    ''' <summary>検索項目</summary>
    '''========================================================================================
    Private Sub txtKey_TextChanged(sender As Object, e As System.EventArgs) Handles txt仕入先CD.TextChanged, txt名称.TextChanged
        Me.GridBind()
    End Sub

    '''========================================================================================
    '''  <summary>得意先検索</summary>
    '''========================================================================================
    Private Sub btn仕入先_Click(sender As System.Object, e As System.EventArgs) Handles btn仕入先.Click
        '----------------------------------------------------------------------
        ' ﾀﾞｲｱﾛｸﾞｵｰﾌﾟﾝ
        '----------------------------------------------------------------------
        Dialog.Common.Open(Me, Me.txt仕入先CD)
        Me.nam仕入先名.Text = NodeCore.Common.Logic.CodeToName.仕入先(Me.txt仕入先CD.Text)
    End Sub
#End Region

#Region "ｸﾞﾘｯﾄﾞ関連"
    '''========================================================================================
    ''' <summary>初期化</summary>
    '''========================================================================================
    Private Sub Grid_Initialize() Handles Me.GridInitialize
        '----------------------------------------------------------------------
        ' ｷｰ設定
        '----------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetView.V0紙価格DataTable
        Me.grdBase.DataKeyNames = tbl.仕入先CDColumn.ColumnName & vbTab & tbl.社内用紙CDColumn.ColumnName & vbTab & tbl.社内用糊CDColumn.ColumnName & vbTab & tbl.社内用台紙CDColumn.ColumnName
    End Sub

    '''========================================================================================
    ''' <summary>表示列 設定</summary>
    '''========================================================================================
    Protected Sub Grid_Colums() Handles Me.GridColums
        '----------------------------------------------------------------------
        ' 表示列設定
        '----------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetView.V0紙価格DataTable
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.社内用紙CDColumn, , "ｺｰﾄﾞ"))
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.社内用紙名Column))
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.社内用糊CDColumn, , "ｺｰﾄﾞ"))
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.社内用糊名Column))
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.社内用台紙CDColumn, , "CD"))
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.社内用台紙名Column))
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.社内単価Column, , "単価", , Windows.Forms.DataGridViewContentAlignment.MiddleRight, "#,##0.00", 70))
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.単位区分名Column, , "単位", , , , 70))
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.仕入先名Column, , "仕入先"))
    End Sub

    '''========================================================================================
    '''  <summary>ﾊﾞｲﾝﾄﾞ</summary>
    '''========================================================================================
    Private Sub GridBind()
        '----------------------------------------------------------------------
        ' 変数定義
        '----------------------------------------------------------------------
        Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0紙価格TableAdapter
        Dim tbl As New NodeDatabase.DataSetView.V0紙価格DataTable
        Dim qry As New Collection

        '----------------------------------------------------------------------
        ' 条件設定
        '----------------------------------------------------------------------
        qry.Clear()
        qry.Add(New BaseDatabase.Condition(tbl.仕入先CDColumn.ColumnName, Me.txt仕入先CD.Text, BaseDatabase.Contents.Compare.LikeFront, BaseDatabase.Contents.EmptyHandle.Skip))
        tbl = ada.SelectByCommon(qry)

        '----------------------------------------------------------------------
        ' ﾃﾞｰﾀｿｰｽ
        '----------------------------------------------------------------------
        Me.grdBase.DataSource = tbl
    End Sub
#End Region
End Class