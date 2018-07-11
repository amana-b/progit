Public Class frmFlexBlade
    Inherits BaseUI.BaseForm

#Region "ﾌﾚｰﾑﾜｰｸ"
    Private Frame As NodeCore.Frame.Order.FlexBlade
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
        Me.opt登録.PropetyInitForm(BaseContents.Field.LockType.None)
        Me.opt修正.PropetyInitForm(BaseContents.Field.LockType.None)
        Me.opt削除.PropetyInitForm(BaseContents.Field.LockType.None)

        ' ﾃｷｽﾄﾎﾞｯｸｽ
        Me.txt作業NO.PropetyInitForm(BaseContents.Field.LockType.None, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txt本台帳NO.PropetyInitForm(BaseContents.Field.LockType.None, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txt機番.PropetyInitForm(BaseContents.Field.LockType.None, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txt御客様NO.PropetyInitForm(BaseContents.Field.LockType.None, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txt受注日付.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.YYYYMMDD, NodeUI.Help.Type.None, "", "")
        Me.txt納品日付B.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.YYYYMMDD, NodeUI.Help.Type.None, "", "")
        Me.txt得意先CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M得意先, Me.txt得意先CD.Name, Me.nam得意先名.Name)
        Me.txt請求先CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M得意先, Me.txt請求先CD.Name, Me.nam請求先名.Name)
        Me.txt代表商品名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt顧客刃型番号.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txt台紙CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M台紙, Me.txt台紙CD.Name, Me.nam台紙名.Name)
        Me.txt担当者CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M担当者, Me.txt担当者CD.Name, Me.nam担当者名.Name)
        Me.txt受注数合計.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt受注単価.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt受注金額.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt原価.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt計上先作業NO.PropetyInitForm(BaseContents.Field.LockType.Data, True, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txt仕入先CD.PropetyInitForm(BaseContents.Field.LockType.Data, True, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M仕入先, Me.txt仕入先CD.Name, Me.nam仕入先名.Name)
        Me.txtバリヤ表区分.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txt刃型情報ギヤ数.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt刃型情報板厚.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt刃型情報総円周.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt刃型情報バリヤ.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt刃型サイズ一面紙幅方向.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt刃型サイズ一面流れ方向.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt刃型サイズ一面角.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt面付紙幅方向面数.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt面付紙幅方向ドブ寸法.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt面付流れ方向面数.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt面付流れ方向ドブ寸法.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt刃型サイズ全体紙幅方向.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt刃型サイズ全体流れ方向.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt線幅刃型線.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt線幅原点.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt線幅トンボ.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt注意事項01.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt注意事項02.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt注意事項03.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt注意事項04.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt注意事項05.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt出荷先CD01.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M出荷先, Me.txt得意先CD.Name & vbTab & Me.txt出荷先CD01.Name, Me.txt出荷先名01.Name)
        Me.txt出荷先名01.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt出荷先CD02.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M出荷先, Me.txt得意先CD.Name & vbTab & Me.txt出荷先CD02.Name, Me.txt出荷先名02.Name)
        Me.txt出荷先名02.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt出荷先CD03.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M出荷先, Me.txt得意先CD.Name & vbTab & Me.txt出荷先CD03.Name, Me.txt出荷先名03.Name)
        Me.txt出荷先名03.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt出荷先CD04.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M出荷先, Me.txt得意先CD.Name & vbTab & Me.txt出荷先CD04.Name, Me.txt出荷先名04.Name)
        Me.txt出荷先名04.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")

        ' ﾈｰﾑﾎﾞｯｸｽ
        Me.nam得意先名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam請求先名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam台紙名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam担当者名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam仕入先名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.namバリヤ表区分名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam受注金額.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam受注数合計.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam受注単価.PropetyInitForm(BaseContents.TextBox.TextStyle.None)

        ' ﾄﾞﾛｯﾌﾟﾀﾞｳﾝ
        Me.ddl社内外区分.PropetyInitForm(BaseContents.Field.LockType.None, True, NodeUI.List.Type.M区分_社内外区分)
        Me.ddl確約区分.PropetyInitForm(BaseContents.Field.LockType.Data, True, NodeUI.List.Type.M区分_確約区分)
        Me.ddl刃型区分.PropetyInitForm(BaseContents.Field.LockType.Data, True, NodeUI.List.Type.M区分_刃型区分)
        Me.ddlフレキ機械種別区分.PropetyInitForm(BaseContents.Field.LockType.Data, True, NodeUI.List.Type.M区分_フレキ機械種別区分)
        Me.ddl刃型サイズ一面形状区分.PropetyInitForm(BaseContents.Field.LockType.Data, True, NodeUI.List.Type.M区分_刃型形状区分)
    End Sub

    '''========================================================================================
    '''  <summary>ﾌﾚｰﾑﾜｰｸの準備</summary>
    '''========================================================================================
    Protected Overrides Sub FrameInit()
        '-------------------------------------
        ' ｺﾝｽﾄﾗｸﾀ
        '-------------------------------------
        Frame = New NodeCore.Frame.Order.FlexBlade(Me.Security, Me.Config)

        '-------------------------------------
        ' 紐付け
        '-------------------------------------
        Frame.Fields.Header.作業NO.Control = Me.txt作業NO
        Frame.Fields.Header.本台帳NO.Control = Me.txt本台帳NO
        Frame.Fields.Header.機番.Control = Me.txt機番
        Frame.Fields.Header.刃型区分.Control = Me.ddl刃型区分
        Frame.Fields.Header.顧客刃型番号.Control = Me.txt顧客刃型番号
        Frame.Fields.Header.担当者CD.Control = Me.txt担当者CD
        Frame.Fields.Header.担当者名.Control = Me.nam担当者名
        Frame.Fields.Header.原価.Control = Me.txt原価
        Frame.Fields.Header.刃型サイズ一面紙幅方向.Control = Me.txt刃型サイズ一面紙幅方向
        Frame.Fields.Header.刃型サイズ一面流れ方向.Control = Me.txt刃型サイズ一面流れ方向
        Frame.Fields.Header.刃型サイズ一面角.Control = Me.txt刃型サイズ一面角
        Frame.Fields.Header.刃型サイズ一面形状区分.Control = Me.ddl刃型サイズ一面形状区分
        Frame.Fields.Header.刃型情報ギヤ数.Control = Me.txt刃型情報ギヤ数
        Frame.Fields.Header.刃型情報板厚.Control = Me.txt刃型情報板厚
        Frame.Fields.Header.刃型情報総円周.Control = Me.txt刃型情報総円周
        Frame.Fields.Header.刃型情報バリヤ.Control = Me.txt刃型情報バリヤ
        Frame.Fields.Header.面付紙幅方向面数.Control = Me.txt面付紙幅方向面数
        Frame.Fields.Header.面付紙幅方向ドブ寸法.Control = Me.txt面付紙幅方向ドブ寸法
        Frame.Fields.Header.面付流れ方向面数.Control = Me.txt面付流れ方向面数
        Frame.Fields.Header.面付流れ方向ドブ寸法.Control = Me.txt面付流れ方向ドブ寸法
        Frame.Fields.Header.刃型サイズ全体紙幅方向.Control = Me.txt刃型サイズ全体紙幅方向
        Frame.Fields.Header.刃型サイズ全体流れ方向.Control = Me.txt刃型サイズ全体流れ方向
        Frame.Fields.Header.線幅刃型線.Control = Me.txt線幅刃型線
        Frame.Fields.Header.線幅原点.Control = Me.txt線幅原点
        Frame.Fields.Header.線幅トンボ.Control = Me.txt線幅トンボ
        Frame.Fields.Header.バリヤ表区分.Control = Me.txtバリヤ表区分
        Frame.Fields.Header.バリヤ表区分名.Control = Me.namバリヤ表区分名
        Frame.Fields.Header.台紙CD.Control = Me.txt台紙CD
        Frame.Fields.Header.台紙名.Control = Me.nam台紙名
        Frame.Fields.Header.フレキ機械種別区分.Control = Me.ddlフレキ機械種別区分
        Frame.Fields.Header.計上先作業NO.Control = Me.txt計上先作業NO
        Frame.Fields.Header.仕入先CD.Control = Me.txt仕入先CD
        Frame.Fields.Header.仕入先名.Control = Me.nam仕入先名

        Frame.Fields.Header.社内外区分.Control = Me.ddl社内外区分
        Frame.Fields.Header.御客様NO.Control = Me.txt御客様NO
        Frame.Fields.Header.受注日付.Control = Me.txt受注日付
        Frame.Fields.Header.納品日付B.Control = Me.txt納品日付B
        Frame.Fields.Header.確約区分.Control = Me.ddl確約区分
        Frame.Fields.Header.得意先CD.Control = Me.txt得意先CD
        Frame.Fields.Header.得意先名.Control = Me.nam得意先名
        Frame.Fields.Header.請求先CD.Control = Me.txt請求先CD
        Frame.Fields.Header.請求先名.Control = Me.nam請求先名
        Frame.Fields.Header.代表商品名.Control = Me.txt代表商品名
        Frame.Fields.Header.受注数合計.Control = Me.txt受注数合計
        Frame.Fields.Header.受注単価.Control = Me.txt受注単価
        Frame.Fields.Header.受注金額.Control = Me.txt受注金額

        Frame.Fields.Header.注意事項01.Control = Me.txt注意事項01
        Frame.Fields.Header.注意事項02.Control = Me.txt注意事項02
        Frame.Fields.Header.注意事項03.Control = Me.txt注意事項03
        Frame.Fields.Header.注意事項04.Control = Me.txt注意事項04
        Frame.Fields.Header.注意事項05.Control = Me.txt注意事項05

        Frame.Fields.Header.出荷先CD01.Control = Me.txt出荷先CD01
        Frame.Fields.Header.出荷先名01.Control = Me.txt出荷先名01
        Frame.Fields.Header.出荷先CD02.Control = Me.txt出荷先CD02
        Frame.Fields.Header.出荷先名02.Control = Me.txt出荷先名02
        Frame.Fields.Header.出荷先CD03.Control = Me.txt出荷先CD03
        Frame.Fields.Header.出荷先名03.Control = Me.txt出荷先名03
        Frame.Fields.Header.出荷先CD04.Control = Me.txt出荷先CD04
        Frame.Fields.Header.出荷先名04.Control = Me.txt出荷先名04

        Frame.Fields.Header.処理登録.Control = Me.opt登録
        Frame.Fields.Header.処理修正.Control = Me.opt修正
        Frame.Fields.Header.処理削除.Control = Me.opt削除
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
    End Sub
#End Region

#Region "ﾕｰｻﾞｲﾍﾞﾝﾄ"
    '''========================================================================================
    '''  <summary>処理区分変更</summary>
    '''========================================================================================
    Private Sub opt処理区分_AfterUpdate(sender As Object, e As System.EventArgs) Handles opt登録.AfterUpdate, opt修正.AfterUpdate, opt削除.AfterUpdate
        '----------------------------------------------------------------------
        ' 画面ｸﾘｱ
        '----------------------------------------------------------------------
        Frame.Clear(False)

        '----------------------------------------------------------------------
        ' ｷｰ部入力制御
        '----------------------------------------------------------------------
        Select Case True
            Case Me.opt登録.Checked
                If Me.ddl社内外区分.SelectedValue = NodeContents.Constant.CodeValue.社内外区分.社内 Then
                    Me.txt作業NO.Enabled = False
                    Me.txt本台帳NO.Enabled = True
                    Me.txt機番.Enabled = True
                    Me.txt御客様NO.Enabled = True
                Else
                    Me.txt作業NO.Enabled = False
                    Me.txt本台帳NO.Enabled = False
                    Me.txt機番.Enabled = False
                    Me.txt御客様NO.Enabled = True
                End If

                Me.FormEnableData()

            Case Me.opt修正.Checked
                Me.txt作業NO.Enabled = True
                Me.txt本台帳NO.Enabled = False
                Me.txt機番.Enabled = False
                Me.txt御客様NO.Enabled = False

                Me.FormEnableKey()

            Case Me.opt削除.Checked
                Me.txt作業NO.Enabled = True
                Me.txt本台帳NO.Enabled = False
                Me.txt機番.Enabled = False
                Me.txt御客様NO.Enabled = False

                Me.FormEnableKey()
        End Select

        '----------------------------------------------------------------------
        ' 必須
        '----------------------------------------------------------------------
        Me.txt作業NO.Required = False
        Me.txt本台帳NO.Required = False
        Me.txt受注日付.Required = False
        Me.txt納品日付B.Required = False
        Me.txt得意先CD.Required = False
        Me.txt代表商品名.Required = False
        Me.txt計上先作業NO.Required = False
        Me.txt仕入先CD.Required = False

        Select Case True
            Case Me.opt登録.Checked
                If Me.ddl社内外区分.SelectedValue = NodeContents.Constant.CodeValue.社内外区分.社内 Then
                    Me.txt本台帳NO.Required = True
                    Me.txt受注日付.Required = True
                    Me.txt納品日付B.Required = True
                    Me.txt得意先CD.Required = True
                    Me.txt代表商品名.Required = True
                    Me.txt計上先作業NO.Required = True
                    Me.txt仕入先CD.Required = True
                Else
                    Me.txt受注日付.Required = True
                    Me.txt納品日付B.Required = True
                    Me.txt得意先CD.Required = True
                    Me.txt代表商品名.Required = True
                End If

            Case Me.opt修正.Checked
                If Me.ddl社内外区分.SelectedValue = NodeContents.Constant.CodeValue.社内外区分.社内 Then
                    Me.txt作業NO.Required = True
                    Me.txt本台帳NO.Required = True
                    Me.txt受注日付.Required = True
                    Me.txt納品日付B.Required = True
                    Me.txt得意先CD.Required = True
                    Me.txt代表商品名.Required = True
                    Me.txt計上先作業NO.Required = True
                    Me.txt仕入先CD.Required = True
                Else
                    Me.txt作業NO.Required = True
                    Me.txt受注日付.Required = True
                    Me.txt納品日付B.Required = True
                    Me.txt得意先CD.Required = True
                    Me.txt代表商品名.Required = True
                End If

            Case Me.opt削除.Checked
                Me.txt作業NO.Required = True
        End Select
    End Sub

    '''========================================================================================
    '''  <summary>社内外区分</summary>
    '''========================================================================================
    Private Sub ddl社内外区分_AfterUpdate(sender As Object, e As System.EventArgs) Handles ddl社内外区分.AfterUpdate
        Me.opt処理区分_AfterUpdate(Nothing, System.EventArgs.Empty)
    End Sub

    '''========================================================================================
    '''  <summary>ｷｰ変更</summary>
    '''========================================================================================
    Private Sub txt作業NO_AfterUpdate(sender As Object, e As System.EventArgs) Handles txt作業NO.AfterUpdate
        '----------------------------------------------------------------------
        ' 該当ﾃﾞｰﾀ 読込
        '----------------------------------------------------------------------
        If Frame.Read() Then
            If Me.opt登録.Checked Then
                Me.FormEnableKey()
                MsgBox("既にマスタに登録済みです", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
                Exit Sub
            End If
        Else
            If Me.opt修正.Checked Or Me.opt削除.Checked Then
                Me.FormEnableKey()
                MsgBox("マスタに登録がありません", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
                Exit Sub
            End If
        End If

        '----------------------------------------------------------------------
        ' ﾃｷｽﾄﾎﾞｯｸｽ 書式適用
        '----------------------------------------------------------------------
        Me.TextBoxFormat()

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
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF07_Click(sender, e)

        '----------------------------------------------------------------------
        ' ﾀﾞｲｱﾛｸﾞｵｰﾌﾟﾝ
        '----------------------------------------------------------------------
        Dialog.Common.Open(Me)
    End Sub

    '''========================================================================================
    '''  <summary>確定</summary>
    '''========================================================================================
    Protected Overrides Sub btnF12_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF12_Click(sender, e)

        '----------------------------------------------------------------------
        ' 実行
        '----------------------------------------------------------------------
        Select Case True
            Case Me.opt登録.Checked Or Me.opt修正.Checked
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
                Select Case True
                    Case Me.opt登録.Checked
                        If MsgBox("登録しますか？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "確認") = MsgBoxResult.No Then
                            Exit Sub
                        End If
                    Case Me.opt修正.Checked
                        If MsgBox("修正しますか？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "確認") = MsgBoxResult.No Then
                            Exit Sub
                        End If
                End Select

                ' 実行
                Frame.Write()

            Case Me.opt削除.Checked
                '-------------------------------------
                ' 削除
                '-------------------------------------
                ' 検査
                Select Case Frame.Valid_Delete
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
                If MsgBox("削除しますか？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "確認") = MsgBoxResult.No Then
                    Exit Sub
                End If

                ' 実行
                Frame.Delete()
        End Select

        '-------------------------------------
        ' 画面ｸﾘｱ
        '-------------------------------------
        Frame.Clear()

        '-------------------------------------
        ' ﾊﾞｲﾝﾄﾞ(ﾌﾚｰﾑﾌｨｰﾙﾄﾞ → ｸﾞﾘｯﾄﾞ)
        '-------------------------------------
        'Me.grdDetall_DataBind()

        '-------------------------------------
        ' ｷｰ部入力制御
        '-------------------------------------
        Me.FormEnableKey()
    End Sub
#End Region
End Class
