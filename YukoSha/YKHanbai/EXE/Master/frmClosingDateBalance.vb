Public Class frmClosingDateBalance
    Inherits BaseUI.BaseForm

#Region "ﾌﾚｰﾑﾜｰｸ"
    Private Frame As NodeCore.Frame.Master.ClosingDateBalance
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
        '-------------------------------------
        ' ﾍﾙﾌﾟﾀｲﾌﾟ
        '-------------------------------------
        ' 得意先CD
        Me.txt得意先CD.HelpType = NodeUI.Help.Type.M得意先
        Me.txt得意先CD.HelpKeys = Me.txt得意先CD.Name
        Me.txt得意先CD.HelpLink = ""

        '-------------------------------------
        ' ﾘｽﾄﾀｲﾌﾟ
        '-------------------------------------
    End Sub

    '''========================================================================================
    '''  <summary>ﾌﾚｰﾑﾜｰｸの準備</summary>
    '''========================================================================================
    Protected Overrides Sub FrameInit()
        '-------------------------------------
        ' ｺﾝｽﾄﾗｸﾀ
        '-------------------------------------
        Frame = New NodeCore.Frame.Master.ClosingDateBalance(Me.Security, Me.Config)

        '-------------------------------------
        ' 紐付け
        '-------------------------------------
        'Frame.Fields.Header.処理登録.Control = Me.opt登録
        'Frame.Fields.Header.処理修正.Control = Me.opt修正
        'Frame.Fields.Header.処理削除.Control = Me.opt削除

        Frame.Fields.Header.得意先CD.Control = Me.txt得意先CD

        Frame.Fields.Header.得意先名.Control = Me.nam得意先名
        Frame.Fields.Header.締日.Control = Me.txt確定済締切対象年月日
        Frame.Fields.Header.期首残高.Control = Me.txt確定済請求残高
        Frame.Fields.Header.表示締日.Control = Me.nam表示用締日
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
        ' ｷｰ部入力制御
        '----------------------------------------------------------------------
        Me.FormEnableKey()
    End Sub
#End Region

#Region "ﾕｰｻﾞｲﾍﾞﾝﾄ"

    '''========================================================================================
    '''  <summary>処理区分変更</summary>
    '''========================================================================================
    Private Sub opt削除_AfterUpdate(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        ' 画面ｸﾘｱ
        '----------------------------------------------------------------------
        Frame.Clear(False)

        '----------------------------------------------------------------------
        ' ｷｰ部入力制御
        '----------------------------------------------------------------------
        Me.FormEnableKey()
    End Sub

    '''========================================================================================
    ''' <summary>ｷｰ変更</summary>
    '''========================================================================================
    Private Sub txt得意先CD_AfterUpdate(sender As Object, e As System.EventArgs) Handles txt得意先CD.AfterUpdate
        '----------------------------------------------------------------------
        ' 該当ﾃﾞｰﾀ 読込
        '----------------------------------------------------------------------
        If Not Frame.Read() Then
            Me.FormEnableKey()
            MsgBox("マスタに登録がありません", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
            Exit Sub
        End If

        '----------------------------------------------------------------------
        ' ﾃｷｽﾄﾎﾞｯｸｽ 書式摘要
        '----------------------------------------------------------------------
        Me.TextBoxFormat()

        '----------------------------------------------------------------------
        ' ﾊﾞｲﾝﾄﾞ(ﾌﾚｰﾑﾌｨｰﾙﾄﾞ → ｸﾞﾘｯﾄﾞ)
        '----------------------------------------------------------------------
        Me.GridInput1_DataBind()

        '----------------------------------------------------------------------
        ' ﾃﾞｰﾀ部入力制御
        '----------------------------------------------------------------------
        Me.FormEnableData()
    End Sub
#End Region

#Region "ﾌｧﾝｸｼｮﾝ"
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

        ' 確認
        If MsgBox("登録しますか？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "確認") = MsgBoxResult.No Then
            Exit Sub
        End If

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

    Private Sub GridInput1_Setting(ByRef TextBoxAddTop As BaseUI.Control.TextBox, ByRef TextBoxAddBtm As BaseUI.Control.TextBox, ByRef ButtonInsert As BaseUI.Control.Button, ByRef ButtonDelete As BaseUI.Control.Button) Handles GridInput1.Setting
        'TextBoxAddTop = Me.txt仕入先CD
        'TextBoxAddBtm = Me.txt発注金額

        ButtonInsert = Me.btnF02
        ButtonDelete = Me.btnF03

        Dim tbl As New NodeDatabase.DataSetView.V0締日残高DataTable

        Me.GridInput1.Columns.Add(BaseUI.Common.GridView.NewColumn("No"))
        Me.GridInput1.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.締日Column.ColumnName, , "締切対象年月日"))
        Me.GridInput1.Columns.Add(BaseUI.Common.GridView.NewColumn(tbl.期首残高Column.ColumnName, , "請求残高"))

        Me.GridInput1.Columns("No").Width = 32
        Me.GridInput1.Columns(tbl.締日Column.ColumnName).Width = 200
        Me.GridInput1.Columns(tbl.期首残高Column.ColumnName).Width = 200
    End Sub

    '''========================================================================================
    '''  <summary>ﾊﾞｲﾝﾄﾞ(ﾌﾚｰﾑﾌｨｰﾙﾄﾞ → ｸﾞﾘｯﾄﾞ)</summary>
    '''========================================================================================
    Private Sub GridInput1_DataBind() Handles GridInput1.DataBind
        Me.GridInput1.Rows.Clear()

        If Frame.Fields.Detail1 Is Nothing Then
            Exit Sub
        End If

        Dim tbl As New NodeDatabase.DataSetView.V0締日残高DataTable

        For i As Integer = 0 To Frame.Fields.Detail1.Count - 1
            Me.GridInput1.Rows.Add()
            Me.GridInput1.Rows(i).Cells("No").Value = i + 1
            Me.GridInput1.Rows(i).Cells(tbl.締日Column.ColumnName).Value = Frame.Fields.Detail1(i).締切対象年月日.Value
            Me.GridInput1.Rows(i).Cells(tbl.期首残高Column.ColumnName).Value = Frame.Fields.Detail1(i).請求残高.Value
        Next
    End Sub

    ' '''========================================================================================
    ' '''  <summary>行追加</summary>
    ' '''========================================================================================
    'Private Sub GridInput1_RowAddition() Handles GridInput1.RowAddition
    '    Frame.Add_Detail1()

    '    Dim tbl As New NodeDatabase.DataSetView.V0締日残高DataTable
    '    Dim i As Integer = Frame.Fields.Detail1.Count - 1

    '    Frame.Fields.Detail1(i).NO.Value = i + 1
    '    Frame.Fields.Detail1(i).締切対象年月日.Value = Me.txt確定済締切対象年月日.Text
    '    Frame.Fields.Detail1(i).請求残高.Value = Me.txt確定済請求残高.SelectedText
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
End Class
