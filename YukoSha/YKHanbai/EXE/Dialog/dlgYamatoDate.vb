Public Class dlgYamatoDate
    Inherits BaseUI.BaseDialog

#Region "定型準備"
    '''========================================================================================
    '''  <summary>呼び出しﾒｿｯﾄﾞ</summary>
    ''' <param name="Value">親画面からのｷｰ情報</param>
    '''========================================================================================
    Public Shared Function ShowFrom(Value As String) As String
        Dim DialogForm As New dlgYamatoDate

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
        Me.Text = "ヤマト運輸用ﾃﾞｰﾀ区分マスタ検索"

        '----------------------------------------------------------------------
        ' ｺﾝﾄﾛｰﾙｻｲｽﾞを親へ渡す
        '----------------------------------------------------------------------
        Me.ChildWidth = Me.grpfind.Width
        Me.ChildHeight = Me.grpfind.Height
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
        Me.txtデータ区分.Text = Me.Argument(0).ToString

        '----------------------------------------------------------------------
        ' 検索
        '----------------------------------------------------------------------
        Me.GridBind()
    End Sub

    '''========================================================================================
    '''  <summary>ｺﾝﾄﾛｰﾙ位置設定</summary>
    '''========================================================================================
    Private Sub Control_Set(ByVal Left As Integer) Handles Me.ControlSet
        Me.grpfind.Left = Left
    End Sub
#End Region

#Region "ﾕｰｻﾞｲﾍﾞﾝﾄ"
    '''========================================================================================
    ''' <summary>検索項目</summary>
    '''========================================================================================
    Private Sub txtKey_TextChanged(sender As Object, e As System.EventArgs) Handles txtデータ区分.TextChanged
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
        Dim tbl As New NodeDatabase.DataSetFunc.F0ヤマトデータDialogDataTable
        Me.grdBase.DataKeyNames = tbl.データ区分Column.ColumnName
    End Sub

    '''========================================================================================
    ''' <summary>表示列 設定</summary>
    '''========================================================================================
    Protected Sub Grid_Colums() Handles Me.GridColums
        '----------------------------------------------------------------------
        ' 表示列設定
        '----------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetFunc.F0ヤマトデータDialogDataTable
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.データ区分Column))
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.データ区分名Column))
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.種別内訳区分名Column.ColumnName, 6, "種別内訳区分"))
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.入数Column.ColumnName, tbl.入数Column.MaxLength))
        Me.grdBase.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.最大ケース数Column))
    End Sub

    '''========================================================================================
    '''  <summary>ﾊﾞｲﾝﾄﾞ</summary>
    '''========================================================================================
    Private Sub GridBind()
        '----------------------------------------------------------------------
        ' 変数定義
        '----------------------------------------------------------------------
        Dim ada As New NodeDatabase.DataSetFuncTableAdapters.F0ヤマトデータDialogTableAdapter
        Dim tbl As New NodeDatabase.DataSetFunc.F0ヤマトデータDialogDataTable
        Dim qry As New Collection

        '----------------------------------------------------------------------
        ' 条件設定
        '----------------------------------------------------------------------
        qry.Clear()
        qry.Add(New BaseDatabase.Condition(tbl.データ区分Column.ColumnName, Me.txtデータ区分.Text, BaseDatabase.Contents.Compare.LikeFront, BaseDatabase.Contents.EmptyHandle.Skip))
        tbl = ada.SelectByCommon(qry)

        '----------------------------------------------------------------------
        ' ﾃﾞｰﾀｿｰｽ
        '----------------------------------------------------------------------
        Me.grdBase.DataSource = tbl
    End Sub
#End Region
End Class