Public Class dlgYamatoKind
    Inherits BaseUI.BaseDialog

#Region "定型準備"
    '''========================================================================================
    '''  <summary>呼び出しﾒｿｯﾄﾞ</summary>
    ''' <param name="Value">親画面からのｷｰ情報</param>
    '''========================================================================================
    Public Shared Function ShowFrom(Value As String) As String
        Dim DialogForm As New dlgYamatoKind

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
        Me.Text = "ヤマト運輸用種別マスタ検索"

        '----------------------------------------------------------------------
        ' ｶｽﾀﾑ定義
        '----------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetView.V0ヤマト種別DataTable

        ' ﾃｷｽﾄﾎﾞｯｸｽ
        Me.txtヤマト区分.PropetyInitDialog(Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "", tbl.ヤマト区分Column.MaxLength, 0, 0)
        Me.txtヤマト種別.PropetyInitDialog(Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "", tbl.ヤマト種別Column.MaxLength, 0, 0)

        ' ﾈｰﾑﾎﾞｯｸｽ
        Me.namヤマト区分名.PropetyInitDialog(BaseContents.TextBox.TextStyle.None)

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
        Me.txtヤマト区分.Text = Me.Argument(0).ToString
        Me.namヤマト区分名.Text = NodeCore.Common.Logic.CodeToName.ヤマト区分(Me.txtヤマト区分.Text)

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
    Private Sub txtKey_TextChanged(sender As Object, e As System.EventArgs) Handles txtヤマト種別.TextChanged, txtヤマト区分.TextChanged
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
        Dim tbl As New NodeDatabase.DataSetView.V0ヤマト種別DataTable
        Me.grdBase.DataKeyNames = tbl.ヤマト区分Column.ColumnName & vbTab & tbl.ヤマト種別Column.ColumnName
    End Sub

    '''========================================================================================
    ''' <summary>表示列 設定</summary>
    '''========================================================================================
    Protected Sub Grid_Colums() Handles Me.GridColums
        '----------------------------------------------------------------------
        ' 表示列設定
        '----------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetView.V0ヤマト種別DataTable
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.ヤマト種別Column))
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.ヤマト種別名Column))
    End Sub

    '''========================================================================================
    '''  <summary>ﾊﾞｲﾝﾄﾞ</summary>
    '''========================================================================================
    Private Sub GridBind()
        '----------------------------------------------------------------------
        ' 変数定義
        '----------------------------------------------------------------------
        Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0ヤマト種別TableAdapter
        Dim tbl As New NodeDatabase.DataSetView.V0ヤマト種別DataTable
        Dim qry As New Collection

        '----------------------------------------------------------------------
        ' 条件設定
        '----------------------------------------------------------------------
        qry.Clear()
        qry.Add(New BaseDatabase.Condition(tbl.ヤマト区分Column.ColumnName, Me.txtヤマト区分.Text, BaseDatabase.Contents.Compare.LikeFront, BaseDatabase.Contents.EmptyHandle.Skip))
        qry.Add(New BaseDatabase.Condition(tbl.ヤマト種別Column.ColumnName, Me.txtヤマト種別.Text, BaseDatabase.Contents.Compare.LikeFront, BaseDatabase.Contents.EmptyHandle.Skip))
        tbl = ada.SelectByCommon(qry)

        '----------------------------------------------------------------------
        ' ﾃﾞｰﾀｿｰｽ
        '----------------------------------------------------------------------
        Me.grdBase.DataSource = tbl
    End Sub
#End Region
End Class