Public Class frmOrderBase
    Inherits BaseUI.BaseForm

#Region "ﾌﾚｰﾑﾜｰｸ"
    Public Frame As NodeCore.Frame.Order.OrderBase
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
        F10 = "出荷先" & vbCrLf & "保守"
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
        ' ﾄﾞﾛｯﾌﾟﾀﾞｳﾝ
        Me.opt登録.FieldLockType = BaseContents.Field.LockType.None
        Me.opt修正.FieldLockType = BaseContents.Field.LockType.None
        Me.opt削除.FieldLockType = BaseContents.Field.LockType.None

        ' ﾃｷｽﾄﾎﾞｯｸｽ
        Me.txt作業NO.PropetyInitForm(BaseContents.Field.LockType.None, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txt本台帳NO.PropetyInitForm(BaseContents.Field.LockType.None, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txt積算NO.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txt御客様NO.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txt受注日付.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.YYYYMMDD, NodeUI.Help.Type.None, "", "")
        Me.txt納品日付A.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.YYYYMMDD, NodeUI.Help.Type.None, "", "")
        Me.txt納品日付B.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.YYYYMMDD, NodeUI.Help.Type.None, "", "")
        Me.txt入力担当CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M担当者, Me.txt入力担当CD.Name, Me.nam入力担当名.Name)
        Me.txt得意先CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M得意先, Me.txt得意先CD.Name, Me.nam得意先名.Name)
        Me.txt請求先CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M得意先, Me.txt請求先CD.Name, Me.nam請求先名.Name)
        Me.txt代表商品名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt顧客商品CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txt通数1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt通数2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt通数3.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt受注単価.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt受注金額.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt印刷場所CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M印刷場所, Me.txt印刷場所CD.Name, Me.nam印刷場所名.Name)
        Me.txt刃型NO.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txt版NO.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txtギヤ数.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt発送仕上特記事項.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt版代金額.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt版代数量.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt版代単価.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt刃型金額.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt刃型数量.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt刃型単価.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt版下金額.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt版下数量.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt版下単価.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt運賃金額.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt運賃数量.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt運賃単価.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt売上金額.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt売上名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt作業注意01.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt作業注意02.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt作業注意03.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt作業注意04.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt作業注意05.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt作業注意06.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt作業注意07.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt作業注意08.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt作業注意09.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt作業注意10.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt出荷注意01.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt出荷注意02.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt出荷注意03.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt出荷注意04.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt出荷注意05.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt出荷注意06.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt出荷注意07.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt出荷注意08.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt出荷注意09.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt出荷注意10.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
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
        Me.nam入力担当名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam印刷場所名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam単位区分.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam受注数合計Title.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam受注数合計.PropetyInitForm(BaseContents.TextBox.TextStyle.Currency)
        Me.nam内在庫引当数合計Title.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam内在庫引当数合計.PropetyInitForm(BaseContents.TextBox.TextStyle.Currency)
        Me.nam内製造数合計Title.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam内製造数合計.PropetyInitForm(BaseContents.TextBox.TextStyle.Currency)

        ' ﾄﾞﾛｯﾌﾟﾀﾞｳﾝ
        Me.ddl新再版区分.PropetyInitForm(BaseContents.Field.LockType.None, False, NodeUI.List.Type.M区分_新再版区分)
        Me.ddl確約区分.PropetyInitForm(BaseContents.Field.LockType.Data, False, NodeUI.List.Type.M区分_確約区分)
        Me.ddl単位区分.PropetyInitForm(BaseContents.Field.LockType.Data, False, NodeUI.List.Type.M区分_単位区分)
        Me.ddl受注区分.PropetyInitForm(BaseContents.Field.LockType.Data, False, NodeUI.List.Type.M区分_受注区分)
        Me.ddl版代売上区分.PropetyInitForm(BaseContents.Field.LockType.Data, False, NodeUI.List.Type.M区分_売上指示区分)
        Me.ddl刃型売上区分.PropetyInitForm(BaseContents.Field.LockType.Data, False, NodeUI.List.Type.M区分_売上指示区分)
        Me.ddl版下売上区分.PropetyInitForm(BaseContents.Field.LockType.Data, False, NodeUI.List.Type.M区分_売上指示区分)
        Me.ddl運賃売上区分.PropetyInitForm(BaseContents.Field.LockType.Data, False, NodeUI.List.Type.M区分_売上指示区分運賃)
        Me.ddl売上区分.PropetyInitForm(BaseContents.Field.LockType.Data, False, NodeUI.List.Type.M区分_売上指示区分)

        ' ﾎﾞﾀﾝ
        Me.btn商品内訳.PropetyInitForm(BaseContents.Field.LockType.Data)
        Me.btn紙発注.PropetyInitForm(BaseContents.Field.LockType.Data)
    End Sub

    '''========================================================================================
    '''  <summary>ﾌﾚｰﾑﾜｰｸの準備</summary>
    '''========================================================================================
    Protected Overrides Sub FrameInit()
        '-------------------------------------
        ' ｺﾝｽﾄﾗｸﾀ
        '-------------------------------------
        Frame = New NodeCore.Frame.Order.OrderBase(Me.Security, Me.Config)

        '-------------------------------------
        ' 紐付け
        '-------------------------------------
        Frame.Fields.HeaderBase.処理登録.Control = Me.opt登録
        Frame.Fields.HeaderBase.処理修正.Control = Me.opt修正
        Frame.Fields.HeaderBase.処理削除.Control = Me.opt削除

        Frame.Fields.HeaderBase.作業NO.Control = Me.txt作業NO
        Frame.Fields.HeaderBase.本台帳NO.Control = Me.txt本台帳NO
        Frame.Fields.HeaderBase.御客様NO.Control = Me.txt御客様NO
        Frame.Fields.HeaderBase.枝番.Control = ""
        Frame.Fields.HeaderBase.受注日付.Control = Me.txt受注日付
        Frame.Fields.HeaderBase.納品日付A.Control = Me.txt納品日付A
        Frame.Fields.HeaderBase.納品日付B.Control = Me.txt納品日付B
        Frame.Fields.HeaderBase.確約区分.Control = Me.ddl確約区分
        Frame.Fields.HeaderBase.入力担当者CD.Control = Me.txt入力担当CD
        Frame.Fields.HeaderBase.得意先CD.Control = Me.txt得意先CD
        Frame.Fields.HeaderBase.請求先CD.Control = Me.txt請求先CD
        Frame.Fields.HeaderBase.定番フラグ.Control = ""
        Frame.Fields.HeaderBase.代表商品名.Control = Me.txt代表商品名
        Frame.Fields.HeaderBase.顧客商品CD.Control = Me.txt顧客商品CD
        Frame.Fields.HeaderBase.顧客商品CDALL.Control = ""
        Frame.Fields.HeaderBase.受注数合計.Control = Me.nam受注数合計
        Frame.Fields.HeaderBase.内在庫引当数合計.Control = Me.nam内在庫引当数合計
        Frame.Fields.HeaderBase.通数合計.Control = ""
        Frame.Fields.HeaderBase.通数1.Control = Me.txt通数1
        Frame.Fields.HeaderBase.通数2.Control = Me.txt通数2
        Frame.Fields.HeaderBase.通数3.Control = Me.txt通数3
        Frame.Fields.HeaderBase.受注単価.Control = Me.txt受注単価
        Frame.Fields.HeaderBase.単位区分.Control = Me.ddl単位区分
        Frame.Fields.HeaderBase.受注金額.Control = Me.txt受注金額
        Frame.Fields.HeaderBase.原価決定日付.Control = ""
        Frame.Fields.HeaderBase.通数累計.Control = ""
        Frame.Fields.HeaderBase.売上数累計.Control = ""
        Frame.Fields.HeaderBase.入庫数累計.Control = ""
        Frame.Fields.HeaderBase.売上金額.Control = Me.txt売上金額
        Frame.Fields.HeaderBase.仕入金額.Control = ""
        Frame.Fields.HeaderBase.固定経費.Control = ""
        Frame.Fields.HeaderBase.入金区分.Control = ""
        Frame.Fields.HeaderBase.印刷場所CD.Control = Me.txt印刷場所CD
        Frame.Fields.HeaderBase.受注区分.Control = Me.ddl受注区分
        Frame.Fields.HeaderBase.刃型NO.Control = Me.txt刃型NO
        Frame.Fields.HeaderBase.版NO.Control = Me.txt版NO
        Frame.Fields.HeaderBase.ギヤ数.Control = Me.txtギヤ数
        Frame.Fields.HeaderBase.発送仕上特記事項.Control = Me.txt発送仕上特記事項
        Frame.Fields.HeaderBase.作業伝票一括発行日付本社.Control = ""
        Frame.Fields.HeaderBase.作業伝票一括発行日付河北.Control = ""
        Frame.Fields.HeaderBase.受注ラベル印字フラグ本社.Control = ""
        Frame.Fields.HeaderBase.受注ラベル印字フラグ河北.Control = ""
        Frame.Fields.HeaderBase.廃棄年月.Control = ""

        Frame.Fields.HeaderBase.新再版区分.Control = Me.ddl新再版区分
        Frame.Fields.HeaderBase.得意先名.Control = Me.nam得意先名
        Frame.Fields.HeaderBase.請求先名.Control = Me.nam請求先名
        Frame.Fields.HeaderBase.担当者名.Control = Me.nam入力担当名
        Frame.Fields.HeaderBase.印刷場所名.Control = Me.nam印刷場所名
        Frame.Fields.HeaderBase.内製造数合計.Control = Me.nam内製造数合計

        Frame.Fields.HeaderBase.売上金額01.Control = Me.txt版代金額
        Frame.Fields.HeaderBase.売上区分01.Control = Me.ddl版代売上区分
        Frame.Fields.HeaderBase.売上名01.Control = ""
        Frame.Fields.HeaderBase.売上数量01.Control = Me.txt版代数量
        Frame.Fields.HeaderBase.売上単価01.Control = Me.txt版代単価
        Frame.Fields.HeaderBase.売上金額02.Control = Me.txt刃型金額
        Frame.Fields.HeaderBase.売上区分02.Control = Me.ddl刃型売上区分
        Frame.Fields.HeaderBase.売上名02.Control = ""
        Frame.Fields.HeaderBase.売上数量02.Control = Me.txt刃型数量
        Frame.Fields.HeaderBase.売上単価02.Control = Me.txt刃型単価
        Frame.Fields.HeaderBase.売上金額03.Control = Me.txt版下金額
        Frame.Fields.HeaderBase.売上区分03.Control = Me.ddl版下売上区分
        Frame.Fields.HeaderBase.売上名03.Control = ""
        Frame.Fields.HeaderBase.売上数量03.Control = Me.txt版下数量
        Frame.Fields.HeaderBase.売上単価03.Control = Me.txt版下単価
        Frame.Fields.HeaderBase.売上金額04.Control = Me.txt運賃金額
        Frame.Fields.HeaderBase.売上区分04.Control = Me.ddl運賃売上区分
        Frame.Fields.HeaderBase.売上名04.Control = ""
        Frame.Fields.HeaderBase.売上数量04.Control = Me.txt運賃数量
        Frame.Fields.HeaderBase.売上単価04.Control = Me.txt運賃単価
        Frame.Fields.HeaderBase.売上金額05.Control = Me.txt売上金額
        Frame.Fields.HeaderBase.売上区分05.Control = Me.ddl売上区分
        Frame.Fields.HeaderBase.売上名05.Control = Me.txt売上名
        Frame.Fields.HeaderBase.売上数量05.Control = ""
        Frame.Fields.HeaderBase.売上単価05.Control = ""

        Frame.Fields.HeaderBase.作業注意01.Control = Me.txt作業注意01
        Frame.Fields.HeaderBase.作業注意02.Control = Me.txt作業注意02
        Frame.Fields.HeaderBase.作業注意03.Control = Me.txt作業注意03
        Frame.Fields.HeaderBase.作業注意04.Control = Me.txt作業注意04
        Frame.Fields.HeaderBase.作業注意05.Control = Me.txt作業注意05
        Frame.Fields.HeaderBase.作業注意06.Control = Me.txt作業注意06
        Frame.Fields.HeaderBase.作業注意07.Control = Me.txt作業注意07
        Frame.Fields.HeaderBase.作業注意08.Control = Me.txt作業注意08
        Frame.Fields.HeaderBase.作業注意09.Control = Me.txt作業注意09
        Frame.Fields.HeaderBase.作業注意10.Control = Me.txt作業注意10

        Frame.Fields.HeaderBase.出荷注意01.Control = Me.txt出荷注意01
        Frame.Fields.HeaderBase.出荷注意02.Control = Me.txt出荷注意02
        Frame.Fields.HeaderBase.出荷注意03.Control = Me.txt出荷注意03
        Frame.Fields.HeaderBase.出荷注意04.Control = Me.txt出荷注意04
        Frame.Fields.HeaderBase.出荷注意05.Control = Me.txt出荷注意05
        Frame.Fields.HeaderBase.出荷注意06.Control = Me.txt出荷注意06
        Frame.Fields.HeaderBase.出荷注意07.Control = Me.txt出荷注意07
        Frame.Fields.HeaderBase.出荷注意08.Control = Me.txt出荷注意08
        Frame.Fields.HeaderBase.出荷注意09.Control = Me.txt出荷注意09
        Frame.Fields.HeaderBase.出荷注意10.Control = Me.txt出荷注意10

        Frame.Fields.HeaderBase.出荷先CD01.Control = Me.txt出荷先CD01
        Frame.Fields.HeaderBase.出荷先名01.Control = Me.txt出荷先名01
        Frame.Fields.HeaderBase.出荷先CD02.Control = Me.txt出荷先CD02
        Frame.Fields.HeaderBase.出荷先名02.Control = Me.txt出荷先名02
        Frame.Fields.HeaderBase.出荷先CD03.Control = Me.txt出荷先CD03
        Frame.Fields.HeaderBase.出荷先名03.Control = Me.txt出荷先名03
        Frame.Fields.HeaderBase.出荷先CD04.Control = Me.txt出荷先CD04
        Frame.Fields.HeaderBase.出荷先名04.Control = Me.txt出荷先名04
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
        Me.KeyInControl()

        '----------------------------------------------------------------------
        ' ｷｰ部入力制御
        '----------------------------------------------------------------------
        Me.FormEnableKey()
    End Sub

    '''========================================================================================
    '''  <summary>新再版区分変更</summary>
    '''========================================================================================
    Private Sub ddl新再版区分_AfterUpdate(sender As Object, e As System.EventArgs) Handles ddl新再版区分.AfterUpdate
        '----------------------------------------------------------------------
        ' 画面ｸﾘｱ
        '----------------------------------------------------------------------
        Frame.Clear(False)

        '----------------------------------------------------------------------
        ' ｷｰ部入力制御
        '----------------------------------------------------------------------
        Me.KeyInControl(True)

        '----------------------------------------------------------------------
        ' ｷｰ部入力制御
        '----------------------------------------------------------------------
        Me.FormEnableKey()
    End Sub

    '''========================================================================================
    ''' <summary>ｷｰ変更(作業NO/本台帳NO)</summary>
    '''========================================================================================
    Private Sub txtキーNO_AfterUpdate(sender As Object, e As System.EventArgs) Handles txt作業NO.AfterUpdate, txt本台帳NO.AfterUpdate
        '----------------------------------------------------------------------
        ' 本台帳NO/作業NO 入力検査
        '----------------------------------------------------------------------
        If Not Frame.KeyNO_Check() Then
            MsgBox(Frame.LastError, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
            Select Case True
                Case Me.txt作業NO.Enabled = True : Me.txt作業NO.Focus()
                Case Me.txt本台帳NO.Enabled = True : Me.txt本台帳NO.Focus()
            End Select
            Exit Sub
        End If

        '----------------------------------------------------------------------
        ' 廃棄判断
        '----------------------------------------------------------------------
        If Frame.Exist_Scrap() Then
            Me.FormEnableKey()
            MsgBox("この本台帳は既に廃棄済みです", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
            Select Case True
                Case Me.txt作業NO.Enabled = True : Me.txt作業NO.Focus()
                Case Me.txt本台帳NO.Enabled = True : Me.txt本台帳NO.Focus()
            End Select
            Exit Sub
        End If

        '----------------------------------------------------------------------
        ' 該当ﾃﾞｰﾀ 読込
        '----------------------------------------------------------------------
        Select Case True
            Case Me.ddl新再版区分.SelectedValue = NodeContents.Constant.CodeValue.新再版区分.新版
                Select Case True
                    Case Me.opt登録.Checked
                        If Frame.Read() Then
                            Me.FormEnableKey()
                            MsgBox("指定された作業NOは既に登録済みです", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
                            Me.txt作業NO.Focus()
                            Exit Sub
                        End If
                    Case Me.opt修正.Checked, Me.opt削除.Checked
                        If Not Frame.Read() Then
                            Me.FormEnableKey()
                            MsgBox("指定された作業NOは登録がありません", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
                            Me.txt作業NO.Focus()
                            Exit Sub
                        End If
                End Select
            Case Me.ddl新再版区分.SelectedValue = NodeContents.Constant.CodeValue.新再版区分.再版
                Select Case True
                    Case Me.opt登録.Checked
                        If Not Frame.Read() Then
                            If MsgBox("指定された作業NOは登録がありません 続けますか？", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "警告") = MsgBoxResult.No Then
                                Me.FormEnableKey()
                                Exit Sub
                            End If
                        Else
                            ' 再版で登録の場合は本台帳のﾃﾞｰﾀを元に入力するための処置
                            Frame.RePrintShow()
                        End If
                    Case Me.opt修正.Checked, Me.opt削除.Checked
                        If Not Frame.Read() Then
                            Me.FormEnableKey()
                            MsgBox("指定された作業NOは登録がありません", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
                            Me.txt作業NO.Focus()
                            Exit Sub
                        End If
                End Select
        End Select

        '----------------------------------------------------------------------
        ' ﾃｷｽﾄﾎﾞｯｸｽ 書式適用
        '----------------------------------------------------------------------
        Me.TextBoxFormat()

        '----------------------------------------------------------------------
        ' ﾃﾞｰﾀ部入力制御
        '----------------------------------------------------------------------
        Me.FormEnableData()
    End Sub

    '''========================================================================================
    ''' <summary>商品内訳ｵｰﾌﾟﾝ</summary>
    '''========================================================================================
    Private Sub btn商品内訳_Click(sender As Object, e As System.EventArgs) Handles btn商品内訳.Click
        Dim frm As New frmOrderItem()
        Me.Hide()
        frm.ShowDialog(Me)
        Me.Show()

        ' 商品内訳画面での数量計算後の再紐付け
        Frame.Fields.HeaderBase.受注数合計.Control = Me.nam受注数合計
        Frame.Fields.HeaderBase.内在庫引当数合計.Control = Me.nam内在庫引当数合計
        Frame.Fields.HeaderBase.内製造数合計.Control = Me.nam内製造数合計
        Frame.Clac_OrderMoney()    ' 受注金額計算
    End Sub

    '''========================================================================================
    ''' <summary>紙発注ｵｰﾌﾟﾝ</summary>
    '''========================================================================================
    Private Sub btn紙発注_Click(sender As Object, e As System.EventArgs) Handles btn紙発注.Click
        Dim frm As New frmOrderPaper()
        Me.Hide()
        frm.ShowDialog(Me)
        Me.Show()
    End Sub

    '''========================================================================================
    ''' <summary>ｷｰ部入力制御</summary>
    '''========================================================================================
    Private Sub KeyInControl(Optional ByVal blnFocus As Boolean = False)
        ' 再版で登録の場合のみ、本台帳NOで呼出
        Select Case True
            Case Me.ddl新再版区分.SelectedValue = NodeContents.Constant.CodeValue.新再版区分.新版
                Me.grp作業NO.Text = "本台帳NO"
                Me.txt作業NO.Enabled = True
                Me.txt本台帳NO.Enabled = False
            Case Me.ddl新再版区分.SelectedValue = NodeContents.Constant.CodeValue.新再版区分.再版
                Select Case True
                    Case Me.opt登録.Checked
                        Me.grp作業NO.Text = "作業NO"
                        Me.txt作業NO.Enabled = False
                        Me.txt本台帳NO.Enabled = True
                    Case Me.opt修正.Checked, Me.opt削除.Checked
                        Me.grp作業NO.Text = "作業NO"
                        Me.txt作業NO.Enabled = True
                        Me.txt本台帳NO.Enabled = False
                End Select
        End Select

        If blnFocus Then
            Select Case True
                Case Me.ddl新再版区分.SelectedValue = NodeContents.Constant.CodeValue.新再版区分.新版 : Me.txt作業NO.Focus()
                Case Me.ddl新再版区分.SelectedValue = NodeContents.Constant.CodeValue.新再版区分.再版
                    Select Case True
                        Case Me.opt登録.Checked : Me.txt本台帳NO.Focus()
                        Case Me.opt修正.Checked : Me.txt作業NO.Focus()
                        Case Me.opt削除.Checked : Me.txt作業NO.Focus()
                    End Select
            End Select
        End If

    End Sub

    '''========================================================================================
    ''' <summary>更新後処理</summary>
    '''========================================================================================
    Private Sub txt通数_AfterUpdate(sender As Object, e As System.EventArgs) Handles txt通数1.AfterUpdate, txt通数2.AfterUpdate, txt通数3.AfterUpdate
        Frame.Clac_PrintQty()      ' 通数合計計算
    End Sub

    Private Sub txt受注単価_AfterUpdate(sender As Object, e As System.EventArgs) Handles txt受注単価.AfterUpdate
        Frame.Clac_OrderMoney()    ' 受注金額計算
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
        ' ｷｰ部入力制御
        '-------------------------------------
        Me.FormEnableKey()
    End Sub
#End Region
End Class
