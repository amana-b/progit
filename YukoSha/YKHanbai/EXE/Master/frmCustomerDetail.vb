Public Class frmCustomerDetail
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
        F02 = "行挿入"
        F03 = "行削除"
        F04 = "前行内容複写"
        F05 = "1画面目内容複写"
        F12 = "特記事項入力画面に進む"
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
        Me.txt得意先名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt代表者役職_代表者名1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt代表者役職_代表者名2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt役職_担当者名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")

        Me.txt01部署名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt02部署名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt03部署名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt04部署名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt05部署名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt06部署名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt07部署名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt08部署名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt09部署名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt10部署名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt11部署名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt01担当者名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt02担当者名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt03担当者名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt04担当者名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt05担当者名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt06担当者名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt07担当者名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt08担当者名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt09担当者名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt10担当者名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt11担当者名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt01郵便番号.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Post, NodeUI.Help.Type.None, "", "")
        Me.txt02郵便番号.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Post, NodeUI.Help.Type.None, "", "")
        Me.txt03郵便番号.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Post, NodeUI.Help.Type.None, "", "")
        Me.txt04郵便番号.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Post, NodeUI.Help.Type.None, "", "")
        Me.txt05郵便番号.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Post, NodeUI.Help.Type.None, "", "")
        Me.txt06郵便番号.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Post, NodeUI.Help.Type.None, "", "")
        Me.txt07郵便番号.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Post, NodeUI.Help.Type.None, "", "")
        Me.txt08郵便番号.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Post, NodeUI.Help.Type.None, "", "")
        Me.txt09郵便番号.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Post, NodeUI.Help.Type.None, "", "")
        Me.txt10郵便番号.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Post, NodeUI.Help.Type.None, "", "")
        Me.txt11郵便番号.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Post, NodeUI.Help.Type.None, "", "")
        Me.txt01住所1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt02住所1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt03住所1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt04住所1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt05住所1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt06住所1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt07住所1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt08住所1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt09住所1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt10住所1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt11住所1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt01住所2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt02住所2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt03住所2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt04住所2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt05住所2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt06住所2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt07住所2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt08住所2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt09住所2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt10住所2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt11住所2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt01TEL.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt02TEL.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt03TEL.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt04TEL.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt05TEL.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt06TEL.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt07TEL.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt08TEL.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt09TEL.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt10TEL.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt11TEL.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt01FAX.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt02FAX.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt03FAX.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt04FAX.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt05FAX.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt06FAX.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt07FAX.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt08FAX.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt09FAX.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt10FAX.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt11FAX.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt01携帯.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt02携帯.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt03携帯.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt04携帯.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt05携帯.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt06携帯.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt07携帯.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt08携帯.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt09携帯.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt10携帯.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt11携帯.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt01メール.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt02メール.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt03メール.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt04メール.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt05メール.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt06メール.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt07メール.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt08メール.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt09メール.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt10メール.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt11メール.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt01本支店名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt02本支店名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt03本支店名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt04本支店名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt05本支店名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt06本支店名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt07本支店名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt08本支店名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt09本支店名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt10本支店名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt11本支店名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")

        ' ﾈｰﾑﾎﾞｯｸｽ

        ' ﾄﾞﾛｯﾌﾟﾀﾞｳﾝ

        '-------------------------------------
        ' ﾀｸﾞ設定(値ｺﾋﾟｰで使用)
        '-------------------------------------
        Me.txt01部署名.Tag = "1:1"
        Me.txt02部署名.Tag = "1:2"
        Me.txt03部署名.Tag = "1:3"
        Me.txt04部署名.Tag = "1:4"
        Me.txt05部署名.Tag = "1:5"
        Me.txt06部署名.Tag = "1:6"
        Me.txt07部署名.Tag = "1:7"
        Me.txt08部署名.Tag = "1:8"
        Me.txt09部署名.Tag = "1:9"
        Me.txt10部署名.Tag = "1:10"
        Me.txt11部署名.Tag = "1:11"
        Me.txt01担当者名.Tag = "2:1"
        Me.txt02担当者名.Tag = "2:2"
        Me.txt03担当者名.Tag = "2:3"
        Me.txt04担当者名.Tag = "2:4"
        Me.txt05担当者名.Tag = "2:5"
        Me.txt06担当者名.Tag = "2:6"
        Me.txt07担当者名.Tag = "2:7"
        Me.txt08担当者名.Tag = "2:8"
        Me.txt09担当者名.Tag = "2:9"
        Me.txt10担当者名.Tag = "2:10"
        Me.txt11担当者名.Tag = "2:11"
        Me.txt01郵便番号.Tag = "3:1"
        Me.txt02郵便番号.Tag = "3:2"
        Me.txt03郵便番号.Tag = "3:3"
        Me.txt04郵便番号.Tag = "3:4"
        Me.txt05郵便番号.Tag = "3:5"
        Me.txt06郵便番号.Tag = "3:6"
        Me.txt07郵便番号.Tag = "3:7"
        Me.txt08郵便番号.Tag = "3:8"
        Me.txt09郵便番号.Tag = "3:9"
        Me.txt10郵便番号.Tag = "3:10"
        Me.txt11郵便番号.Tag = "3:11"
        Me.txt01住所1.Tag = "4:1"
        Me.txt02住所1.Tag = "4:2"
        Me.txt03住所1.Tag = "4:3"
        Me.txt04住所1.Tag = "4:4"
        Me.txt05住所1.Tag = "4:5"
        Me.txt06住所1.Tag = "4:6"
        Me.txt07住所1.Tag = "4:7"
        Me.txt08住所1.Tag = "4:8"
        Me.txt09住所1.Tag = "4:9"
        Me.txt10住所1.Tag = "4:10"
        Me.txt11住所1.Tag = "4:11"
        Me.txt01住所2.Tag = "5:1"
        Me.txt02住所2.Tag = "5:2"
        Me.txt03住所2.Tag = "5:3"
        Me.txt04住所2.Tag = "5:4"
        Me.txt05住所2.Tag = "5:5"
        Me.txt06住所2.Tag = "5:6"
        Me.txt07住所2.Tag = "5:7"
        Me.txt08住所2.Tag = "5:8"
        Me.txt09住所2.Tag = "5:9"
        Me.txt10住所2.Tag = "5:10"
        Me.txt11住所2.Tag = "5:11"
        Me.txt01TEL.Tag = "6:1"
        Me.txt02TEL.Tag = "6:2"
        Me.txt03TEL.Tag = "6:3"
        Me.txt04TEL.Tag = "6:4"
        Me.txt05TEL.Tag = "6:5"
        Me.txt06TEL.Tag = "6:6"
        Me.txt07TEL.Tag = "6:7"
        Me.txt08TEL.Tag = "6:8"
        Me.txt09TEL.Tag = "6:9"
        Me.txt10TEL.Tag = "6:10"
        Me.txt11TEL.Tag = "6:11"
        Me.txt01FAX.Tag = "7:1"
        Me.txt02FAX.Tag = "7:2"
        Me.txt03FAX.Tag = "7:3"
        Me.txt04FAX.Tag = "7:4"
        Me.txt05FAX.Tag = "7:5"
        Me.txt06FAX.Tag = "7:6"
        Me.txt07FAX.Tag = "7:7"
        Me.txt08FAX.Tag = "7:8"
        Me.txt09FAX.Tag = "7:9"
        Me.txt10FAX.Tag = "7:10"
        Me.txt11FAX.Tag = "7:11"
        Me.txt01携帯.Tag = "8:1"
        Me.txt02携帯.Tag = "8:2"
        Me.txt03携帯.Tag = "8:3"
        Me.txt04携帯.Tag = "8:4"
        Me.txt05携帯.Tag = "8:5"
        Me.txt06携帯.Tag = "8:6"
        Me.txt07携帯.Tag = "8:7"
        Me.txt08携帯.Tag = "8:8"
        Me.txt09携帯.Tag = "8:9"
        Me.txt10携帯.Tag = "8:10"
        Me.txt11携帯.Tag = "8:11"
        Me.txt01メール.Tag = "9:1"
        Me.txt02メール.Tag = "9:2"
        Me.txt03メール.Tag = "9:3"
        Me.txt04メール.Tag = "9:4"
        Me.txt05メール.Tag = "9:5"
        Me.txt06メール.Tag = "9:6"
        Me.txt07メール.Tag = "9:7"
        Me.txt08メール.Tag = "9:8"
        Me.txt09メール.Tag = "9:9"
        Me.txt10メール.Tag = "9:10"
        Me.txt11メール.Tag = "9:11"
        Me.txt01本支店名.Tag = "10:1"
        Me.txt02本支店名.Tag = "10:2"
        Me.txt03本支店名.Tag = "10:3"
        Me.txt04本支店名.Tag = "10:4"
        Me.txt05本支店名.Tag = "10:5"
        Me.txt06本支店名.Tag = "10:6"
        Me.txt07本支店名.Tag = "10:7"
        Me.txt08本支店名.Tag = "10:8"
        Me.txt09本支店名.Tag = "10:9"
        Me.txt10本支店名.Tag = "10:10"
        Me.txt11本支店名.Tag = "10:11"
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
        Frame.Fields.Detail.行NO.Control = Me.txt行NO
        Frame.Fields.Detail.部署名_01.Control = Me.txt01部署名
        Frame.Fields.Detail.部署名_02.Control = Me.txt02部署名
        Frame.Fields.Detail.部署名_03.Control = Me.txt03部署名
        Frame.Fields.Detail.部署名_04.Control = Me.txt04部署名
        Frame.Fields.Detail.部署名_05.Control = Me.txt05部署名
        Frame.Fields.Detail.部署名_06.Control = Me.txt06部署名
        Frame.Fields.Detail.部署名_07.Control = Me.txt07部署名
        Frame.Fields.Detail.部署名_08.Control = Me.txt08部署名
        Frame.Fields.Detail.部署名_09.Control = Me.txt09部署名
        Frame.Fields.Detail.部署名_10.Control = Me.txt10部署名
        Frame.Fields.Detail.部署名_11.Control = Me.txt11部署名
        Frame.Fields.Detail.担当者名_01.Control = Me.txt01担当者名
        Frame.Fields.Detail.担当者名_02.Control = Me.txt02担当者名
        Frame.Fields.Detail.担当者名_03.Control = Me.txt03担当者名
        Frame.Fields.Detail.担当者名_04.Control = Me.txt04担当者名
        Frame.Fields.Detail.担当者名_05.Control = Me.txt05担当者名
        Frame.Fields.Detail.担当者名_06.Control = Me.txt06担当者名
        Frame.Fields.Detail.担当者名_07.Control = Me.txt07担当者名
        Frame.Fields.Detail.担当者名_08.Control = Me.txt08担当者名
        Frame.Fields.Detail.担当者名_09.Control = Me.txt09担当者名
        Frame.Fields.Detail.担当者名_10.Control = Me.txt10担当者名
        Frame.Fields.Detail.担当者名_11.Control = Me.txt11担当者名
        Frame.Fields.Detail.郵便番号_01.Control = Me.txt01郵便番号
        Frame.Fields.Detail.郵便番号_02.Control = Me.txt02郵便番号
        Frame.Fields.Detail.郵便番号_03.Control = Me.txt03郵便番号
        Frame.Fields.Detail.郵便番号_04.Control = Me.txt04郵便番号
        Frame.Fields.Detail.郵便番号_05.Control = Me.txt05郵便番号
        Frame.Fields.Detail.郵便番号_06.Control = Me.txt06郵便番号
        Frame.Fields.Detail.郵便番号_07.Control = Me.txt07郵便番号
        Frame.Fields.Detail.郵便番号_08.Control = Me.txt08郵便番号
        Frame.Fields.Detail.郵便番号_09.Control = Me.txt09郵便番号
        Frame.Fields.Detail.郵便番号_10.Control = Me.txt10郵便番号
        Frame.Fields.Detail.郵便番号_11.Control = Me.txt11郵便番号
        Frame.Fields.Detail.住所1_01.Control = Me.txt01住所1
        Frame.Fields.Detail.住所1_02.Control = Me.txt02住所1
        Frame.Fields.Detail.住所1_03.Control = Me.txt03住所1
        Frame.Fields.Detail.住所1_04.Control = Me.txt04住所1
        Frame.Fields.Detail.住所1_05.Control = Me.txt05住所1
        Frame.Fields.Detail.住所1_06.Control = Me.txt06住所1
        Frame.Fields.Detail.住所1_07.Control = Me.txt07住所1
        Frame.Fields.Detail.住所1_08.Control = Me.txt08住所1
        Frame.Fields.Detail.住所1_09.Control = Me.txt09住所1
        Frame.Fields.Detail.住所1_10.Control = Me.txt10住所1
        Frame.Fields.Detail.住所1_11.Control = Me.txt11住所1
        Frame.Fields.Detail.住所2_01.Control = Me.txt01住所2
        Frame.Fields.Detail.住所2_02.Control = Me.txt02住所2
        Frame.Fields.Detail.住所2_03.Control = Me.txt03住所2
        Frame.Fields.Detail.住所2_04.Control = Me.txt04住所2
        Frame.Fields.Detail.住所2_05.Control = Me.txt05住所2
        Frame.Fields.Detail.住所2_06.Control = Me.txt06住所2
        Frame.Fields.Detail.住所2_07.Control = Me.txt07住所2
        Frame.Fields.Detail.住所2_08.Control = Me.txt08住所2
        Frame.Fields.Detail.住所2_09.Control = Me.txt09住所2
        Frame.Fields.Detail.住所2_10.Control = Me.txt10住所2
        Frame.Fields.Detail.住所2_11.Control = Me.txt11住所2
        Frame.Fields.Detail.TEL_01.Control = Me.txt01TEL
        Frame.Fields.Detail.TEL_02.Control = Me.txt02TEL
        Frame.Fields.Detail.TEL_03.Control = Me.txt03TEL
        Frame.Fields.Detail.TEL_04.Control = Me.txt04TEL
        Frame.Fields.Detail.TEL_05.Control = Me.txt05TEL
        Frame.Fields.Detail.TEL_06.Control = Me.txt06TEL
        Frame.Fields.Detail.TEL_07.Control = Me.txt07TEL
        Frame.Fields.Detail.TEL_08.Control = Me.txt08TEL
        Frame.Fields.Detail.TEL_09.Control = Me.txt09TEL
        Frame.Fields.Detail.TEL_10.Control = Me.txt10TEL
        Frame.Fields.Detail.TEL_11.Control = Me.txt11TEL
        Frame.Fields.Detail.FAX_01.Control = Me.txt01FAX
        Frame.Fields.Detail.FAX_02.Control = Me.txt02FAX
        Frame.Fields.Detail.FAX_03.Control = Me.txt03FAX
        Frame.Fields.Detail.FAX_04.Control = Me.txt04FAX
        Frame.Fields.Detail.FAX_05.Control = Me.txt05FAX
        Frame.Fields.Detail.FAX_06.Control = Me.txt06FAX
        Frame.Fields.Detail.FAX_07.Control = Me.txt07FAX
        Frame.Fields.Detail.FAX_08.Control = Me.txt08FAX
        Frame.Fields.Detail.FAX_09.Control = Me.txt09FAX
        Frame.Fields.Detail.FAX_10.Control = Me.txt10FAX
        Frame.Fields.Detail.FAX_11.Control = Me.txt11FAX
        Frame.Fields.Detail.携帯_01.Control = Me.txt01携帯
        Frame.Fields.Detail.携帯_02.Control = Me.txt02携帯
        Frame.Fields.Detail.携帯_03.Control = Me.txt03携帯
        Frame.Fields.Detail.携帯_04.Control = Me.txt04携帯
        Frame.Fields.Detail.携帯_05.Control = Me.txt05携帯
        Frame.Fields.Detail.携帯_06.Control = Me.txt06携帯
        Frame.Fields.Detail.携帯_07.Control = Me.txt07携帯
        Frame.Fields.Detail.携帯_08.Control = Me.txt08携帯
        Frame.Fields.Detail.携帯_09.Control = Me.txt09携帯
        Frame.Fields.Detail.携帯_10.Control = Me.txt10携帯
        Frame.Fields.Detail.携帯_11.Control = Me.txt11携帯
        Frame.Fields.Detail.メール_01.Control = Me.txt01メール
        Frame.Fields.Detail.メール_02.Control = Me.txt02メール
        Frame.Fields.Detail.メール_03.Control = Me.txt03メール
        Frame.Fields.Detail.メール_04.Control = Me.txt04メール
        Frame.Fields.Detail.メール_05.Control = Me.txt05メール
        Frame.Fields.Detail.メール_06.Control = Me.txt06メール
        Frame.Fields.Detail.メール_07.Control = Me.txt07メール
        Frame.Fields.Detail.メール_08.Control = Me.txt08メール
        Frame.Fields.Detail.メール_09.Control = Me.txt09メール
        Frame.Fields.Detail.メール_10.Control = Me.txt10メール
        Frame.Fields.Detail.メール_11.Control = Me.txt11メール
        Frame.Fields.Detail.本支店名_01.Control = Me.txt01本支店名
        Frame.Fields.Detail.本支店名_02.Control = Me.txt02本支店名
        Frame.Fields.Detail.本支店名_03.Control = Me.txt03本支店名
        Frame.Fields.Detail.本支店名_04.Control = Me.txt04本支店名
        Frame.Fields.Detail.本支店名_05.Control = Me.txt05本支店名
        Frame.Fields.Detail.本支店名_06.Control = Me.txt06本支店名
        Frame.Fields.Detail.本支店名_07.Control = Me.txt07本支店名
        Frame.Fields.Detail.本支店名_08.Control = Me.txt08本支店名
        Frame.Fields.Detail.本支店名_09.Control = Me.txt09本支店名
        Frame.Fields.Detail.本支店名_10.Control = Me.txt10本支店名
        Frame.Fields.Detail.本支店名_11.Control = Me.txt11本支店名

        Frame.Fields.Detail.得意先名.Control = Me.txt得意先名
        Frame.Fields.Detail.役職_担当者名.Control = Me.txt役職_担当者名
        Frame.Fields.Detail.代表者役職_代表者名1.Control = Me.txt代表者役職_代表者名1
        Frame.Fields.Detail.代表者役職_代表者名2.Control = Me.txt代表者役職_代表者名2
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
        Me.Text = "得意先マスタ(詳細情報)"

        '----------------------------------------------------------------------
        ' ｳｨﾝﾄﾞｳｻｲｽﾞ指定
        '----------------------------------------------------------------------
        Me.Size = New System.Drawing.Size(1024, 820)

        '----------------------------------------------------------------------
        ' 終了ﾒｯｾｰｼﾞ非表示
        '----------------------------------------------------------------------
        Me.CloseMessage = False

        '----------------------------------------------------------------------
        ' ﾒｲﾝ画面と同期する
        '----------------------------------------------------------------------
        Me.txt得意先名.Text = Frame.Fields.Header.得意先名.Value
        Me.txt役職_担当者名.Text = Frame.Fields.Header.役職_担当者名.Value
        Me.txt代表者役職_代表者名1.Text = Frame.Fields.Header.代表者役職_代表者名1.Value
        Me.txt代表者役職_代表者名2.Text = Frame.Fields.Header.代表者役職_代表者名2.Value
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
        '前画面と同期する
        Frame.Fields.Header.役職_担当者名.Value = Me.txt役職_担当者名.Text
        Frame.Fields.Header.代表者役職_代表者名1.Value = Me.txt代表者役職_代表者名1.Text
        Frame.Fields.Header.代表者役職_代表者名2.Value = Me.txt代表者役職_代表者名2.Text

        '終了確認ﾒｯｾｰｼﾞを表示しない
        Me.Close()
    End Sub
#End Region

#Region "行挿入"
    '''========================================================================================
    '''  <summary>行挿入</summary>
    '''========================================================================================
    Protected Overrides Sub btnF02_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF02_Click(sender, e)

        '----------------------------------------------------------------------
        ' ﾃｷｽﾄ以外は終了
        '----------------------------------------------------------------------
        If BaseUI.Control.Tool.ControlType(Me.CurrentControl) <> BaseContents.Field.ControlType.TextBox Then
            Exit Sub
        End If

        '----------------------------------------------------------------------
        ' ｱｸﾃｨﾌﾞｺﾝﾄﾛｰﾙを求める
        '----------------------------------------------------------------------
        Dim text As BaseUI.Control.TextBox
        text = CType(Me.ActiveControl, BaseUI.Control.TextBox)
        
        '----------------------------------------------------------------------
        ' ｱｸﾃｨﾌﾞﾙｰﾙのﾀｸﾞから挿入する位置を判断する
        '----------------------------------------------------------------------
        Dim blnError As Boolean = False

        If text.Tag = "" Then
            Exit Sub
        End If

        Select Case text.Tag.ToString.Split(":")(1) '位置
            Case "1" : blnError = Frame.InsertLine(1)
            Case "2" : blnError = Frame.InsertLine(2)
            Case "3" : blnError = Frame.InsertLine(3)
            Case "4" : blnError = Frame.InsertLine(4)
            Case "5" : blnError = Frame.InsertLine(5)
            Case "6" : blnError = Frame.InsertLine(6)
            Case "7" : blnError = Frame.InsertLine(7)
            Case "8" : blnError = Frame.InsertLine(8)
            Case "9" : blnError = Frame.InsertLine(9)
            Case "10" : blnError = Frame.InsertLine(10)
            Case "11" : blnError = Frame.InsertLine(11)
            Case Else : Exit Sub
        End Select

        '----------------------------------------------------------------------
        ' ｴﾗｰ処理 
        '----------------------------------------------------------------------
        If Not blnError Then
            MsgBox(Frame.LastError, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
            Exit Sub
        End If
    End Sub
#End Region

#Region "行削除"
    '''========================================================================================
    '''  <summary>行削除</summary>
    '''========================================================================================
    Protected Overrides Sub btnF03_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF03_Click(sender, e)

        '----------------------------------------------------------------------
        ' ﾃｷｽﾄ以外は終了
        '----------------------------------------------------------------------
        If BaseUI.Control.Tool.ControlType(Me.CurrentControl) <> BaseContents.Field.ControlType.TextBox Then
            Exit Sub
        End If

        '----------------------------------------------------------------------
        ' ｱｸﾃｨﾌﾞｺﾝﾄﾛｰﾙを求める
        '----------------------------------------------------------------------
        Dim text As BaseUI.Control.TextBox
        text = CType(Me.ActiveControl, BaseUI.Control.TextBox)

        '----------------------------------------------------------------------
        ' ｱｸﾃｨﾌﾞｺﾝﾄﾙｰﾙのﾀｸﾞから削除する位置を判断する
        '----------------------------------------------------------------------
        Dim blnError As Boolean = False

        If text.Tag = "" Then
            Exit Sub
        End If

        Select Case text.Tag.ToString.Split(":")(1) '位置
            Case "1" : blnError = Frame.DeleteLine(1)
            Case "2" : blnError = Frame.DeleteLine(2)
            Case "3" : blnError = Frame.DeleteLine(3)
            Case "4" : blnError = Frame.DeleteLine(4)
            Case "5" : blnError = Frame.DeleteLine(5)
            Case "6" : blnError = Frame.DeleteLine(6)
            Case "7" : blnError = Frame.DeleteLine(7)
            Case "8" : blnError = Frame.DeleteLine(8)
            Case "9" : blnError = Frame.DeleteLine(9)
            Case "10" : blnError = Frame.DeleteLine(10)
            Case "11" : blnError = Frame.DeleteLine(11)
            Case Else : Exit Sub
        End Select

        '----------------------------------------------------------------------
        ' ｴﾗｰ処理 
        '----------------------------------------------------------------------
        If Not blnError Then
            MsgBox(Frame.LastError, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
            Exit Sub
        End If
    End Sub
#End Region

#Region "前行内容複写"
    '''========================================================================================
    '''  <summary>前行内容複写</summary>
    '''========================================================================================
    Protected Overrides Sub btnF04_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF04_Click(sender, e)

        '----------------------------------------------------------------------
        ' ﾃｷｽﾄ以外は終了
        '----------------------------------------------------------------------
        If BaseUI.Control.Tool.ControlType(Me.CurrentControl) <> BaseContents.Field.ControlType.TextBox Then
            Exit Sub
        End If

        '----------------------------------------------------------------------
        ' ｱｸﾃｨﾌﾞｺﾝﾄﾛｰﾙを求める
        '----------------------------------------------------------------------
        Dim text As BaseUI.Control.TextBox
        text = CType(Me.ActiveControl, BaseUI.Control.TextBox)

        '----------------------------------------------------------------------
        ' ｶﾚﾝﾄｺﾝﾄﾙｰﾙのﾀｸﾞから直前のｺﾝﾄﾛｰﾙを求め値を挿入する
        '----------------------------------------------------------------------
        If text.Tag = "" Then
            Exit Sub
        End If

        Me.CopyPaste(Me, text)

        '----------------------------------------------------------------------
        ' 次項目へ
        '----------------------------------------------------------------------
        Me.NextControl()
    End Sub

    Private Sub CopyPaste(ByVal TargetControl As System.Windows.Forms.Control, ByRef text As BaseUI.Control.TextBox)
        Dim intTargetGroup As Integer = CInt(text.Tag.ToString.Split(":")(0))
        Dim intTargetNumber As Integer = CInt(text.Tag.ToString.Split(":")(1))

        For Each ChildControl As System.Windows.Forms.Control In TargetControl.Controls
            Select Case BaseUI.Control.Tool.ControlType(ChildControl)
                Case BaseContents.Field.ControlType.TextBox
                    If CType(ChildControl, System.Windows.Forms.TextBox).Tag = "" Then
                        Continue For
                    End If

                    If CType(ChildControl, System.Windows.Forms.TextBox).Tag.ToString.Split(":").Length >= 2 Then
                        Dim intCopyGroup As Integer = CInt(CType(ChildControl, System.Windows.Forms.TextBox).Tag.ToString.Split(":")(0))
                        Dim intCopyNumber As Integer = CInt(CType(ChildControl, System.Windows.Forms.TextBox).Tag.ToString.Split(":")(1))

                        If intTargetGroup = intCopyGroup And intTargetNumber - 1 = intCopyNumber Then
                            text.Text = CType(ChildControl, System.Windows.Forms.TextBox).Text
                        End If
                    End If
            End Select

            Me.CopyPaste(ChildControl, text)        '再帰
        Next
    End Sub
#End Region

#Region "1画面目内容複写"
    '''========================================================================================
    '''  <summary>1画面目内容複写</summary>
    '''========================================================================================
    Protected Overrides Sub btnF05_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF05_Click(sender, e)

        '----------------------------------------------------------------------
        ' ﾃｷｽﾄ以外は終了
        '----------------------------------------------------------------------
        If BaseUI.Control.Tool.ControlType(Me.CurrentControl) <> BaseContents.Field.ControlType.TextBox Then
            Exit Sub
        End If

        '----------------------------------------------------------------------
        ' ｱｸﾃｨﾌﾞｺﾝﾄﾛｰﾙを求める
        '----------------------------------------------------------------------
        Dim text As BaseUI.Control.TextBox
        text = CType(Me.ActiveControl, BaseUI.Control.TextBox)

        '----------------------------------------------------------------------
        ' ｱｸﾃｨﾌﾞｺﾝﾄﾙｰﾙのﾀｸﾞから前画面項目内容をｺﾋﾟｰする
        '----------------------------------------------------------------------
        Dim blnError As Boolean = False

        If text.Tag = "" Then
            Exit Sub
        End If

        Select Case text.Tag.ToString.Split(":")(0) '種類
            Case "1"  '部署名
                text.Text = Frame.Fields.Header.得意先名.Value
            Case "2"  '担当者名
                text.Text = Frame.Fields.Header.役職_担当者名.Value
            Case "3"  '郵便番号
                text.Text = Frame.Fields.Header.郵便番号.Value
            Case "4"  '住所1
                text.Text = Frame.Fields.Header.住所1.Value
            Case "5"  '住所2
                text.Text = Frame.Fields.Header.住所2.Value
            Case "6"  'TEL
                text.Text = Frame.Fields.Header.TEL.Value
            Case "7"  'FAX
                text.Text = Frame.Fields.Header.FAX.Value
            Case "8"  '携帯
            Case "9"  'ﾒｰﾙ
            Case "10" '本支店名
            Case Else : Exit Sub
        End Select

        '----------------------------------------------------------------------
        ' 次項目へ
        '----------------------------------------------------------------------
        Me.NextControl()
    End Sub
#End Region

#Region "特記事項入力画面に進む"
    '''========================================================================================
    '''  <summary>特記事項入力画面に進む</summary>
    '''========================================================================================
    Protected Overrides Sub btnF12_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF12_Click(sender, e)

        '----------------------------------------------------------------------
        ' 特記事項ｵｰﾌﾟﾝ
        '----------------------------------------------------------------------
        Dim frm As New frmCustomerNote()
        frm.ShowDialog(Me)
    End Sub
#End Region
#End Region
End Class
