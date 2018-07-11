Public Class dlgYamatoShop
    Inherits BaseUI.BaseDialog

#Region "定型準備"
    '''========================================================================================
    '''  <summary>呼び出しﾒｿｯﾄﾞ</summary>
    ''' <param name="Value">親画面からのｷｰ情報</param>
    '''========================================================================================
    Public Shared Function ShowFrom(Value As String) As String
        Dim DialogForm As New dlgYamatoShop

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
        Me.Text = "ヤマト運輸店所マスタ検索"

        '----------------------------------------------------------------------
        ' ｶｽﾀﾑ定義
        '----------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetMaster.Mヤマト店所DataTable

        ' ﾃｷｽﾄﾎﾞｯｸｽ
        Me.txtTEL.PropetyInitDialog(Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "", tbl.TELColumn.MaxLength, 0, 0)
        Me.txt店所名.PropetyInitDialog(Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "", tbl.ヤマト店所名Column.MaxLength, 0, 0)
        Me.txt店所CD.PropetyInitDialog(Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "", tbl.ヤマト店所CDColumn.MaxLength, 0, 0)

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
    Private Sub txtKey_TextChanged(sender As Object, e As System.EventArgs) Handles txt店所CD.TextChanged, txt店所名.TextChanged, txtTEL.TextChanged
        Me.GridBind()
    End Sub
#End Region

#Region "ｸﾞﾘｯﾄﾞ関連"
    '''========================================================================================
    ''' <summary>初期化</summary>
    '''========================================================================================
    Private Sub Grid_Initialize() Handles Me.GridInitialize
        '----------------------------------------------------------------------
        ' ｸﾞﾘｯﾄﾞ設定
        '----------------------------------------------------------------------
        '----------------------------------------------------------------------
        ' ｷｰ設定
        '----------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetMaster.Mヤマト店所DataTable
        Me.grdBase.DataKeyNames = tbl.ヤマト店所CDColumn.ColumnName
    End Sub

    '''========================================================================================
    ''' <summary>表示列 設定</summary>
    '''========================================================================================
    Protected Sub Grid_Colums() Handles Me.GridColums
        '----------------------------------------------------------------------
        ' 表示列設定
        '----------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetMaster.Mヤマト店所DataTable
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.ヤマト店所CDColumn))
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.ヤマト店所名Column))
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.TELColumn))
    End Sub

    '''========================================================================================
    '''  <summary>ﾊﾞｲﾝﾄﾞ</summary>
    '''========================================================================================
    Private Sub GridBind()
        '----------------------------------------------------------------------
        ' 変数定義
        '----------------------------------------------------------------------
        Dim ada As New NodeDatabase.DataSetMasterTableAdapters.Mヤマト店所TableAdapter
        Dim tbl As New NodeDatabase.DataSetMaster.Mヤマト店所DataTable
        Dim qry As New Collection

        '----------------------------------------------------------------------
        ' 条件設定
        '----------------------------------------------------------------------
        qry.Clear()
        qry.Add(New BaseDatabase.Condition(tbl.ヤマト店所CDColumn.ColumnName, Me.txt店所CD.Text, BaseDatabase.Contents.Compare.LikeFront, BaseDatabase.Contents.EmptyHandle.Skip))
        qry.Add(New BaseDatabase.Condition(tbl.ヤマト店所名Column.ColumnName, Me.txt店所名.Text, BaseDatabase.Contents.Compare.LikeCenter, BaseDatabase.Contents.EmptyHandle.Skip))
        qry.Add(New BaseDatabase.Condition(tbl.TELColumn.ColumnName, Me.txtTEL.Text, BaseDatabase.Contents.Compare.LikeFront, BaseDatabase.Contents.EmptyHandle.Skip))
        tbl = ada.SelectByCommon(qry)

        '----------------------------------------------------------------------
        ' ﾃﾞｰﾀｿｰｽ
        '----------------------------------------------------------------------
        Me.grdBase.DataSource = tbl
    End Sub
#End Region
End Class