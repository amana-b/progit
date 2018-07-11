Public Class frmPaperPriList
    Inherits BaseUI.BaseForm

#Region "ﾌﾚｰﾑﾜｰｸ"
    Private Frame As NodeCore.Frame.Master.PaperPriList
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
        Me.opt平米単価.PropetyInitForm(BaseContents.Field.LockType.None)
        Me.optm単価.PropetyInitForm(BaseContents.Field.LockType.None)
        Me.opt両方.PropetyInitForm(BaseContents.Field.LockType.None)
        Me.opt発注単価.PropetyInitForm(BaseContents.Field.LockType.None)
        Me.opt社内単価.PropetyInitForm(BaseContents.Field.LockType.None)
        Me.opt仕入先CD順.PropetyInitForm(BaseContents.Field.LockType.None)
        Me.opt紙糊台紙CD順.PropetyInitForm(BaseContents.Field.LockType.None)

        ' ﾃｷｽﾄﾎﾞｯｸｽ
        Me.txt仕入先CDF.PropetyInitForm(BaseContents.Field.LockType.Key, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M仕入先, Me.txt仕入先CDF.Name, Me.nam仕入先名F.Name)
        Me.txt仕入先CDT.PropetyInitForm(BaseContents.Field.LockType.Key, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M仕入先, Me.txt仕入先CDT.Name, Me.nam仕入先名T.Name)
        Me.txt社内用紙CDF.PropetyInitForm(BaseContents.Field.LockType.Key, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M紙, Me.txt社内用紙CDF.Name, Me.nam社内用紙名F.Name)
        Me.txt社内用紙CDT.PropetyInitForm(BaseContents.Field.LockType.Key, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M紙, Me.txt社内用紙CDT.Name, Me.nam社内用紙名T.Name)
        Me.txt社内用糊CDF.PropetyInitForm(BaseContents.Field.LockType.Key, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M糊, Me.txt社内用糊CDF.Name, Me.nam社内用糊名F.Name)
        Me.txt社内用糊CDT.PropetyInitForm(BaseContents.Field.LockType.Key, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M糊, Me.txt社内用糊CDT.Name, Me.nam社内用糊名T.Name)
        Me.txt社内用台紙CDF.PropetyInitForm(BaseContents.Field.LockType.Key, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M台紙, Me.txt社内用台紙CDF.Name, Me.nam社内用台紙名F.Name)
        Me.txt社内用台紙CDT.PropetyInitForm(BaseContents.Field.LockType.Key, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M台紙, Me.txt社内用台紙CDT.Name, Me.nam社内用台紙名T.Name)

        ' ﾈｰﾑﾎﾞｯｸｽ
        Me.nam仕入先名F.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam仕入先名T.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam社内用紙名F.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam社内用紙名T.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam社内用糊名F.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam社内用糊名T.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam社内用台紙名F.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam社内用台紙名T.PropetyInitForm(BaseContents.TextBox.TextStyle.None)

        ' ﾄﾞﾛｯﾌﾟﾀﾞｳﾝ

    End Sub

    '''========================================================================================
    '''  <summary>ﾌﾚｰﾑﾜｰｸの準備</summary>
    '''========================================================================================
    Protected Overrides Sub FrameInit()
        ''-------------------------------------
        ' ｺﾝｽﾄﾗｸﾀ
        '-------------------------------------
        Frame = New NodeCore.Frame.Master.PaperPriList(Me.Security, Me.Config)

        '-------------------------------------
        ' 紐付け
        '-------------------------------------
        Frame.Fields.Header.仕入先CDF.Control = Me.txt仕入先CDF
        Frame.Fields.Header.仕入先CDT.Control = Me.txt仕入先CDT
        Frame.Fields.Header.社内用紙CDF.Control = Me.txt社内用紙CDF
        Frame.Fields.Header.社内用紙CDT.Control = Me.txt社内用紙CDT
        Frame.Fields.Header.社内用糊CDF.Control = Me.txt社内用糊CDF
        Frame.Fields.Header.社内用糊CDT.Control = Me.txt社内用糊CDT
        Frame.Fields.Header.社内用台紙CDF.Control = Me.txt社内用台紙CDF
        Frame.Fields.Header.社内用台紙CDT.Control = Me.txt社内用台紙CDT

        Frame.Fields.Header.平米単価.Control = Me.opt平米単価
        Frame.Fields.Header.m単価.Control = Me.optm単価
        Frame.Fields.Header.両方.Control = Me.opt両方
        Frame.Fields.Header.発注単価.Control = Me.opt発注単価
        Frame.Fields.Header.社内単価.Control = Me.opt社内単価
        Frame.Fields.Header.仕入先ｺｰﾄﾞ順.Control = Me.opt仕入先CD順
        Frame.Fields.Header.紙・糊・台紙・ｺｰﾄﾞ順.Control = Me.opt紙糊台紙CD順
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
    '''  <summary>ﾌﾟﾚﾋﾞｭｰ</summary>
    '''========================================================================================
    Protected Overrides Sub btnF11_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        '  ﾍﾞｰｽ処理
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
        '  ﾍﾞｰｽ処理
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
