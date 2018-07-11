Public Class dlgPaper
    Inherits BaseUI.BaseDialog

#Region "定型準備"
    '''========================================================================================
    '''  <summary>呼び出しﾒｿｯﾄﾞ</summary>
    ''' <param name="Value">親画面からのｷｰ情報</param>
    '''========================================================================================
    Public Shared Function ShowFrom(Value As String) As String
        Dim DialogForm As New dlgPaper

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
        Me.Text = "紙検索"

        '----------------------------------------------------------------------
        ' ｶｽﾀﾑ定義
        '----------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetView.V0紙DataTable

        ' ﾗｼﾞｵﾎﾞﾀﾝ
        Me.opt紙.PropetyInitDialog()
        Me.optオーバーコード.PropetyInitDialog()
        Me.opt箔.PropetyInitDialog()
        Me.opt紙その他.PropetyInitDialog()
        Me.opt全て.PropetyInitDialog()

        ' ﾃｷｽﾄﾎﾞｯｸｽ
        Me.txt紙名.PropetyInitDialog(Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "", tbl.紙名Column.MaxLength, 0, 0)
        Me.txt紙CD.PropetyInitDialog(Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "", tbl.紙CDColumn.MaxLength, 0, 0)

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
    Private Sub txtKey_TextChanged(sender As Object, e As System.EventArgs) Handles txt紙CD.TextChanged, txt紙名.TextChanged
        Me.GridBind()
    End Sub

    Private Sub optKey_CheckedChanged(sender As Object, e As System.EventArgs) Handles opt全て.CheckedChanged, opt紙.CheckedChanged, optオーバーコード.CheckedChanged, opt箔.CheckedChanged, opt紙その他.CheckedChanged
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
        Dim tbl As New NodeDatabase.DataSetView.V0紙DataTable
        Me.grdBase.DataKeyNames = tbl.紙CDColumn.ColumnName
    End Sub

    '''========================================================================================
    ''' <summary>表示列 設定</summary>
    '''========================================================================================
    Protected Sub Grid_Colums() Handles Me.GridColums
        '----------------------------------------------------------------------
        ' 表示列設定
        '----------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetView.V0紙DataTable
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.紙CDColumn))
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.紙名Column))
    End Sub

    '''========================================================================================
    '''  <summary>ﾊﾞｲﾝﾄﾞ</summary>
    '''========================================================================================
    Private Sub GridBind()
        '----------------------------------------------------------------------
        ' 変数定義
        '----------------------------------------------------------------------
        Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0紙TableAdapter
        Dim tbl As New NodeDatabase.DataSetView.V0紙DataTable
        Dim qry As New Collection

        '----------------------------------------------------------------------
        ' 条件設定
        '----------------------------------------------------------------------
        qry.Clear()

        Select Case True
            Case Me.opt紙.Checked
                qry.Add(New BaseDatabase.Condition(tbl.紙種別区分Column.ColumnName, NodeContents.Constant.CodeValue.紙種別.紙, BaseDatabase.Contents.Compare.Equal))

            Case Me.optオーバーコード.Checked
                qry.Add(New BaseDatabase.Condition(tbl.紙種別区分Column.ColumnName, NodeContents.Constant.CodeValue.紙種別.オーバーコート, BaseDatabase.Contents.Compare.Equal))

            Case Me.opt箔.Checked
                qry.Add(New BaseDatabase.Condition(tbl.紙種別区分Column.ColumnName, NodeContents.Constant.CodeValue.紙種別.箔, BaseDatabase.Contents.Compare.Equal))

            Case Me.opt紙その他.Checked
                qry.Add(New BaseDatabase.Condition(tbl.紙種別区分Column.ColumnName, NodeContents.Constant.CodeValue.紙種別.紙その他, BaseDatabase.Contents.Compare.Equal))

            Case Me.opt全て.Checked
        End Select

        qry.Add(New BaseDatabase.Condition(tbl.紙CDColumn.ColumnName, Me.txt紙CD.Text, BaseDatabase.Contents.Compare.LikeCenter, BaseDatabase.Contents.EmptyHandle.Skip))
        qry.Add(New BaseDatabase.Condition(tbl.紙名Column.ColumnName, Me.txt紙名.Text, BaseDatabase.Contents.Compare.LikeCenter, BaseDatabase.Contents.EmptyHandle.Skip))
        tbl = ada.SelectByCommon(qry)

        '----------------------------------------------------------------------
        ' ﾃﾞｰﾀｿｰｽ
        '----------------------------------------------------------------------
        Me.grdBase.DataSource = tbl
    End Sub
#End Region
End Class