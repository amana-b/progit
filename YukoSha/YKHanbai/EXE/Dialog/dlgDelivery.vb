Public Class dlgDelivery
    Inherits BaseUI.BaseDialog

#Region "定型準備"
    '''========================================================================================
    '''  <summary>呼び出しﾒｿｯﾄﾞ</summary>
    ''' <param name="Value">親画面からのｷｰ情報</param>
    '''========================================================================================
    Public Shared Function ShowFrom(Value As String) As String
        Dim DialogForm As New dlgDelivery

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
        Me.Text = "出荷先検索"

        '----------------------------------------------------------------------
        ' ｶｽﾀﾑ定義
        '----------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetView.V0出荷先DataTable

        ' ﾃｷｽﾄﾎﾞｯｸｽ
        Me.txt得意先CD.PropetyInitDialog(Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "", tbl.得意先CDColumn.MaxLength, 0, 0)
        Me.txt出荷先名.PropetyInitDialog(Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "", tbl.出荷先名Column.MaxLength, 0, 0)
        Me.txt出荷先CD.PropetyInitDialog(Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "", tbl.出荷先CDColumn.MaxLength, 0, 0)

        ' ﾈｰﾑﾎﾞｯｸｽ
        Me.nam得意先名.PropetyInitDialog(BaseContents.TextBox.TextStyle.None)

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
        Me.txt得意先CD.Text = Me.Argument(0).ToString
        Me.nam得意先名.Text = NodeCore.Common.Logic.CodeToName.得意先(Me.txt得意先CD.Text)

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
    Private Sub txtKey_TextChanged(sender As Object, e As System.EventArgs) Handles txt得意先CD.TextChanged, txt出荷先CD.TextChanged, txt出荷先名.TextChanged
        Me.GridBind()
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
        Dim tbl As New NodeDatabase.DataSetView.V0出荷先DataTable
        Me.grdBase.DataKeyNames = tbl.得意先CDColumn.ColumnName & vbTab & tbl.出荷先CDColumn.ColumnName
    End Sub

    '''========================================================================================
    ''' <summary>表示列 設定</summary>
    '''========================================================================================
    Protected Sub Grid_Colums() Handles Me.GridColums
        '----------------------------------------------------------------------
        ' 表示列設定
        '----------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetView.V0出荷先DataTable
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.出荷先CDColumn))
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.出荷先名Column))
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.TELColumn, , "電話番号"))
    End Sub

    '''========================================================================================
    '''  <summary>ﾊﾞｲﾝﾄﾞ</summary>
    '''========================================================================================
    Private Sub GridBind()
        '----------------------------------------------------------------------
        ' 変数定義
        '----------------------------------------------------------------------
        Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0出荷先TableAdapter
        Dim tbl As New NodeDatabase.DataSetView.V0出荷先DataTable
        Dim qry As New Collection

        '----------------------------------------------------------------------
        ' 条件設定
        '----------------------------------------------------------------------
        qry.Clear()
        qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Me.txt得意先CD.Text, BaseDatabase.Contents.Compare.Equal))
        qry.Add(New BaseDatabase.Condition(tbl.出荷先CDColumn.ColumnName, Me.txt出荷先CD.Text, BaseDatabase.Contents.Compare.LikeCenter, BaseDatabase.Contents.EmptyHandle.Skip))
        qry.Add(New BaseDatabase.Condition(tbl.出荷先名Column.ColumnName, Me.txt出荷先名.Text, BaseDatabase.Contents.Compare.LikeCenter, BaseDatabase.Contents.EmptyHandle.Skip))
        tbl = ada.SelectByCommon(qry)

        '----------------------------------------------------------------------
        ' ﾃﾞｰﾀｿｰｽ
        '----------------------------------------------------------------------
        Me.grdBase.DataSource = tbl
    End Sub
#End Region
End Class