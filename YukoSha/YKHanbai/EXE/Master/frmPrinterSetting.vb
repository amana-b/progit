Public Class frmPrinterSetting
    Inherits BaseUI.BaseForm

#Region "ﾌﾚｰﾑﾜｰｸ"
    Private Frame As NodeCore.Frame.Master.PrinterSetting
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
        F01 = "自ｺﾝﾋﾟｭｰﾀ名表示"
        F02 = "行挿入"
        F03 = "行削除"
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
        Me.txtコンピュータ名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txtプリンタ名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")

        ' ﾈｰﾑﾎﾞｯｸｽ

        ' ﾄﾞﾛｯﾌﾟﾀﾞｳﾝ
        Me.ddl帳票区分.PropetyInitForm(BaseContents.Field.LockType.Data, True, NodeUI.List.Type.M区分_帳票区分)

    End Sub

    '''========================================================================================
    '''  <summary>ﾌﾚｰﾑﾜｰｸの準備</summary>
    '''========================================================================================
    Protected Overrides Sub FrameInit()
        '-------------------------------------
        ' ｺﾝｽﾄﾗｸﾀ
        '-------------------------------------
        Frame = New NodeCore.Frame.Master.PrinterSetting(Me.Security, Me.Config)

        '-------------------------------------
        ' 紐付け
        '-------------------------------------
        Frame.Fields.Header.帳票区分.Control = Me.ddl帳票区分
        Frame.Fields.Header.コンピュータ名.Control = Me.txtコンピュータ名
        Frame.Fields.Header.プリンタ名.Control = Me.txtプリンタ名
    End Sub
#End Region

#Region "ﾍﾟｰｼﾞｲﾍﾞﾝﾄ"
    '''========================================================================================
    '''  <summary>ﾍﾟｰｼﾞﾛｰﾄﾞ</summary>
    '''========================================================================================
    Private Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        '----------------------------------------------------------------------
        ' 画面ｸﾘｱ
        '----------------------------------------------------------------------
        Frame.Clear()

        '----------------------------------------------------------------------
        ' ｸﾞﾘｯﾄ初期表示
        '----------------------------------------------------------------------
        GridInput1_DataBind()
    End Sub
#End Region

#Region "ﾕｰｻﾞｲﾍﾞﾝﾄ"
    '''========================================================================================
    ''' <summary>ｷｰ変更</summary>
    '''========================================================================================
    Private Sub ddl帳票区分_AfterUpdate(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        ' 該当ﾃﾞｰﾀ 読込
        '----------------------------------------------------------------------
        Frame.Read()

        '----------------------------------------------------------------------
        ' ﾃｷｽﾄﾎﾞｯｸｽ 書式適用
        '----------------------------------------------------------------------
        Me.TextBoxFormat()
    End Sub
#End Region

#Region "ｸﾞﾘｯﾄﾞ関連"
    Private Sub GridInput1_Setting(ByRef TextBoxAddTop As BaseUI.Control.TextBox, ByRef TextBoxAddBtm As BaseUI.Control.TextBox, ByRef ButtonInsert As BaseUI.Control.Button, ByRef ButtonDelete As BaseUI.Control.Button) Handles GridInput1.Setting
        TextBoxAddTop = Me.txtコンピュータ名
        TextBoxAddBtm = Me.txtプリンタ名

        ButtonInsert = Me.btnF02
        ButtonDelete = Me.btnF03

        Dim tbl As New NodeDatabase.DataSetView.V0特殊帳票DataTable

        Me.GridInput1.Columns.Add(BaseUI.Common.GridView.NewColumn("NO", 4))
        Me.GridInput1.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.コンピュータ名Column, , "ｺﾝﾋﾟｭｰﾀ名"))
        Me.GridInput1.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.プリンタ名Column, , "ﾌﾟﾘﾝﾀ名"))

        Me.GridInput1.Columns("NO").Width = 33
        Me.GridInput1.Columns(tbl.コンピュータ名Column.ColumnName).Width = 284
        Me.GridInput1.Columns(tbl.プリンタ名Column.ColumnName).Width = 285
    End Sub

    '''========================================================================================
    '''  <summary>ﾊﾞｲﾝﾄﾞ(ﾌﾚｰﾑﾌｨｰﾙﾄﾞ → ｸﾞﾘｯﾄﾞ)</summary>
    '''========================================================================================
    Private Sub GridInput1_DataBind() Handles GridInput1.DataBind
        Me.GridInput1.Rows.Clear()

        If Frame.Fields.Detail1 Is Nothing Then
            Exit Sub
        End If

        Dim tbl As New NodeDatabase.DataSetView.V0特殊帳票DataTable

        For i As Integer = 0 To Frame.Fields.Detail1.Count - 1
            Me.GridInput1.Rows.Add()
            Me.GridInput1.Rows(i).Cells("NO").Value = Frame.Fields.Detail1(i).行NO.Value
            Me.GridInput1.Rows(i).Cells(tbl.コンピュータ名Column.ColumnName).Value = Frame.Fields.Detail1(i).コンピュータ名.Value
            Me.GridInput1.Rows(i).Cells(tbl.プリンタ名Column.ColumnName).Value = Frame.Fields.Detail1(i).プリンタ名.Value
        Next
    End Sub

    ' '''========================================================================================
    ' '''  <summary>行追加</summary>
    ' '''========================================================================================
    'Private Sub GridInput1_RowAddition() Handles GridInput1.RowAddition
    '    Frame.Add_Detail1()

    '    Dim tbl As New NodeDatabase.DataSetView.V0オフセット発注DataTable
    '    Dim i As Integer = Frame.Fields.Detail1.Count - 1

    '    Frame.Fields.Detail1(i).コンピュータ名.Value = Me.txtコンピュータ名.Text
    '    Frame.Fields.Detail1(i).プリンタ名.Value = Me.txtプリンタ名.Text
    'End Sub

    ' '''========================================================================================
    ' '''  <summary>行挿入</summary>
    ' '''========================================================================================
    'Private Sub GridInput1_RowInsertExecute(RowIndex As Integer) Handles GridInput1.RowInsertExecute
    '    Frame.Insert_Detail1(RowIndex)
    'End Sub

    ' '''========================================================================================
    ' '''  <summary>行削除</summary>
    ' '''========================================================================================
    'Private Sub GridInput1_RowDeleteExecute(RowIndex As Integer) Handles GridInput1.RowDeleteExecute
    '    Frame.Del_Detail1(RowIndex)
    'End Sub

    'Private Sub GridInput1_RowDeleteValid(ByRef IsError As Boolean) Handles GridInput1.RowDeleteValid

    'End Sub
#End Region

#Region "ﾌｧﾝｸｼｮﾝ"
#Region "自ｺﾝﾋﾟｭｰﾀ名表示"
    '''========================================================================================
    '''  <summary>検索</summary>
    '''========================================================================================
    Protected Overrides Sub btnF01_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF01_Click(sender, e)

        '----------------------------------------------------------------------
        ' 取得 
        '----------------------------------------------------------------------
        Me.txtコンピュータ名.Text = My.Computer.Name
    End Sub
#End Region

#Region "検索"
    '''========================================================================================
    '''  <summary>検索</summary>
    '''========================================================================================
    Protected Overrides Sub btnF07_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        '  ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF07_Click(sender, e)

        '----------------------------------------------------------------------
        '  ﾀﾞｲｱﾛｸﾞｵｰﾌﾟﾝ
        '----------------------------------------------------------------------
        Dialog.Common.Open(Me)
    End Sub
#End Region

#Region "確定"
    '''========================================================================================
    '''  <summary>確定</summary>
    '''========================================================================================
    Protected Overrides Sub btnF12_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        '  ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF12_Click(sender, e)

        '----------------------------------------------------------------------
        '  実行
        '----------------------------------------------------------------------
        '-------------------------------------
        ' 保存
        '-------------------------------------
        ' 検査
        Select Case Frame.Valid_Write
            Case NodeContents.ActionButton.ErrorLevel.Warning
                CType(Frame.ControlError, System.Windows.Forms.Control).Focus()
                If MsgBox(Frame.LastError, MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "警告") = MsgBoxResult.Cancel Then
                    Exit Sub
                End If

            Case NodeContents.ActionButton.ErrorLevel.Fatal
                CType(Frame.ControlError, System.Windows.Forms.Control).Focus()
                MsgBox(Frame.LastError, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
                Exit Sub
        End Select

        ' 実行
        Frame.Write()

        '-------------------------------------
        ' 画面ｸﾘｱ
        '-------------------------------------
        Frame.Clear()

        '-------------------------------------
        ' ｷｰ部入力制御
        '-------------------------------------
        Me.FormEnableKey()
    End Sub
#End Region
#End Region
End Class
