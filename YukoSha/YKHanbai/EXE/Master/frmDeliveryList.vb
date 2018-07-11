Public Class frmDeliveryList
    Inherits BaseUI.BaseForm

#Region "ﾌﾚｰﾑﾜｰｸ"
    Private Frame As NodeCore.Frame.Master.DeliveryList
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
        Me.txt得意先CDF.PropetyInitForm(BaseContents.Field.LockType.Key, True, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M得意先, Me.txt得意先CDF.Name, Me.nam得意先名F.Name)
        Me.txt得意先CDT.PropetyInitForm(BaseContents.Field.LockType.Key, True, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M得意先, Me.txt得意先CDT.Name, Me.nam得意先名T.Name)

        ' ﾈｰﾑﾎﾞｯｸｽ
        Me.nam得意先名F.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam得意先名T.PropetyInitForm(BaseContents.TextBox.TextStyle.None)

        ' ﾄﾞﾛｯﾌﾟﾀﾞｳﾝ

    End Sub

    '''========================================================================================
    '''  <summary>ﾌﾚｰﾑﾜｰｸの準備</summary>
    '''========================================================================================
    Protected Overrides Sub FrameInit()
        '-------------------------------------
        ' ｺﾝｽﾄﾗｸﾀ
        '-------------------------------------
        Frame = New NodeCore.Frame.Master.DeliveryList(Me.Security, Me.Config)

        '-------------------------------------
        ' 紐付け
        '-------------------------------------
        Frame.Fields.Header.得意先CDF.Control = Me.txt得意先CDF
        Frame.Fields.Header.得意先CDT.Control = Me.txt得意先CDT
    End Sub
#End Region

#Region "ﾍﾟｰｼﾞｲﾍﾞﾝﾄ"
    '''========================================================================================
    '''  <summary>ﾍﾟｰｼﾞﾛｰﾄﾞ</summary>
    '''========================================================================================
    Private Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        '----------------------------------------------------------------------
        ' 終了ﾒｯｾｰｼﾞ非表示
        '----------------------------------------------------------------------
        Me.CloseMessage = False

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
#End Region

#Region "ﾌｧﾝｸｼｮﾝ"
    '''========================================================================================
    '''  <summary>ﾌｫｰﾑ終了</summary>
    '''========================================================================================
    Protected Overrides Sub OnClosing(e As System.ComponentModel.CancelEventArgs)
        If MsgBox(Me.Text & "を終了しますか？", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "プログラム終了確認") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    '''========================================================================================
    '''  <summary>閉じる</summary>
    '''========================================================================================
    Protected Overrides Sub btnESC_Click(sender As Object, e As System.EventArgs)
        Me.Close()
    End Sub

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
End Class
