Public Class frmCustomerPrint
    Inherits BaseUI.BaseForm

#Region "ﾌﾚｰﾑﾜｰｸ"
    Private Frame As NodeCore.Frame.Master.Customer
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
        ESC = "前画面へ戻る"
        F07 = "検索"
        F11 = "ﾌﾟﾚﾋﾞｭｰ"
        F12 = "印刷"
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
        Me.txt得意先CDF.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M得意先, Me.txt得意先CDF.Name, Me.nam得意先名F.Name)
        Me.txt得意先CDT.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M得意先, Me.txt得意先CDT.Name, Me.nam得意先名T.Name)
        Me.txt自社担当者CDF.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M担当者, Me.txt自社担当者CDF.Name, Me.nam自社担当者名F.Name)
        Me.txt自社担当者CDT.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M担当者, Me.txt自社担当者CDT.Name, Me.nam自社担当者名T.Name)

        ' ﾈｰﾑﾎﾞｯｸｽ
        Me.nam得意先名F.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam得意先名T.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam自社担当者名F.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam自社担当者名T.PropetyInitForm(BaseContents.TextBox.TextStyle.None)

        ' ﾄﾞﾛｯﾌﾟﾀﾞｳﾝ

    End Sub

    '''========================================================================================
    '''  <summary>ﾌﾚｰﾑﾜｰｸの準備</summary>
    '''========================================================================================
    Protected Overrides Sub FrameInit()
        '-------------------------------------
        ' ｺﾝｽﾄﾗｸﾀ
        '-------------------------------------
        Frame = CType(Me.Owner, frmCustomer).Frame    ' 親ﾌｫｰﾑのﾌﾚｰﾑﾜｰｸを使用する

        '-------------------------------------
        ' 紐付け
        '-------------------------------------
        Frame.Fields.Print.得意先CDF.Control = Me.txt得意先CDF
        Frame.Fields.Print.得意先CDT.Control = Me.txt得意先CDT
        Frame.Fields.Print.自社担当者CDF.Control = Me.txt自社担当者CDF
        Frame.Fields.Print.自社担当者CDT.Control = Me.txt自社担当者CDT
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
        Me.Text = "得意先台帳印字"

        '----------------------------------------------------------------------
        ' 終了ﾒｯｾｰｼﾞ非表示
        '----------------------------------------------------------------------
        Me.CloseMessage = False

        '----------------------------------------------------------------------
        ' ﾒｲﾝ画面と同期する
        '----------------------------------------------------------------------
        Me.txt得意先CDF.Text = Frame.Fields.Header.得意先CD.Value
        Me.txt得意先CDT.Text = Frame.Fields.Header.得意先CD.Value
        Me.txt自社担当者CDF.Text = Frame.Fields.Header.自社担当者CD.Value
        Me.txt自社担当者CDT.Text = Frame.Fields.Header.自社担当者CD.Value

        Me.nam得意先名F.Text = (New NodeUI.Help.Names).Execute(Me.txt得意先CDF.HelpType, Me.txt得意先CDF.Text)
        Me.nam得意先名T.Text = (New NodeUI.Help.Names).Execute(Me.txt得意先CDT.HelpType, Me.txt得意先CDT.Text)
        Me.nam自社担当者名F.Text = (New NodeUI.Help.Names).Execute(Me.txt自社担当者CDF.HelpType, Me.txt自社担当者CDF.Text)
        Me.nam自社担当者名T.Text = (New NodeUI.Help.Names).Execute(Me.txt自社担当者CDT.HelpType, Me.txt自社担当者CDT.Text)
    End Sub
#End Region

#Region "ﾕｰｻﾞｲﾍﾞﾝﾄ"
#End Region

#Region "ﾌｧﾝｸｼｮﾝ"
#Region "前画面へ戻る"
    '''========================================================================================
    '''  <summary>前画面へ戻る</summary>
    '''========================================================================================
    Protected Overrides Sub btnESC_Click(sender As Object, e As System.EventArgs)
        '終了確認ﾒｯｾｰｼﾞを表示しない
        Me.Close()
    End Sub
#End Region

#Region "検索"
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
#End Region

#Region "ﾌﾟﾚﾋﾞｭｰ"
    '''========================================================================================
    '''  <summary>ﾌﾟﾚﾋﾞｭｰ</summary>
    '''========================================================================================
    Protected Overrides Sub btnF11_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF11_Click(sender, e)

        '----------------------------------------------------------------------
        ' ﾚﾎﾟｰﾄ作成
        '----------------------------------------------------------------------
        If Not Frame.Execute() Then
            MsgBox(Frame.LastError, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
            Exit Sub
        End If

        '----------------------------------------------------------------------
        ' ﾌﾟﾚﾋﾞｭｰ表示
        '----------------------------------------------------------------------
        Me.ReportPreview(Frame.Report1)
    End Sub
#End Region

#Region "印刷"
    '''========================================================================================
    '''  <summary>印刷</summary>
    '''========================================================================================
    Protected Overrides Sub btnF12_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF12_Click(sender, e)

        '----------------------------------------------------------------------
        ' 直接印刷
        '----------------------------------------------------------------------
        If Not Frame.Execute1() Then
            MsgBox(Frame.LastError, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
            Exit Sub
        End If
    End Sub
#End Region
#End Region
End Class
