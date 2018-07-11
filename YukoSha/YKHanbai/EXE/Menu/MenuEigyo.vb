Public Class MenuEigyo
    Public Class MenuNo
        Public Const メイン As String = "メイン"
        Public Const 受注 As String = "メイン-受注"
        Public Const マスタ As String = "メイン-マスタ"
        Public Const コード表 As String = "メイン-マスタ-コード表"
        Public Const 紙価格 As String = "メイン-マスタ-紙価格"
        Public Const ヤマト運輸関連 As String = "メイン-マスタ-ヤマト運輸関連"
        Public Const 各種残高設定関連 As String = "メイン-マスタ-各種残高設定関連"
    End Class

#Region "ｲﾍﾞﾝﾄﾍﾟｰｼﾞ"
    '''========================================================================================
    '''  <summary>ﾍﾟｰｼﾞ開始(Load)</summary>
    '''========================================================================================
    Protected Overrides Sub OnLoad(e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ｳｨﾝﾄﾞｳｻｲｽﾞ 固定
        '----------------------------------------------------------------------
        Me.Size = New System.Drawing.Size(800, 600)

        '----------------------------------------------------------------------
        ' ｷｰﾎﾞｰﾄﾞｲﾍﾞﾝﾄ を発生させる
        '----------------------------------------------------------------------
        Me.KeyPreview = True

        '----------------------------------------------------------------------
        ' ｻｲｽﾞ変更不可の直線ｳｨﾝﾄﾞｳに変更する
        '----------------------------------------------------------------------
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle

        '----------------------------------------------------------------------
        ' ﾒﾆｭｰ初期化
        '----------------------------------------------------------------------
        Me.Loadメイン()

        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.OnLoad(e)
    End Sub
#End Region

#Region "共通制御"
    '''========================================================================================
    '''  <summary>ﾒﾆｭｰﾎﾞﾀﾝ ｸﾘｯｸｲﾍﾞﾝﾄ</summary>
    '''========================================================================================
    Private Sub btnCommon_Click(sender As Object, e As System.EventArgs) Handles btn0101.Click, btn0102.Click, btn0103.Click, btn0104.Click, btn0105.Click, btn0106.Click _
                                                                               , btn0201.Click, btn0202.Click, btn0203.Click, btn0204.Click, btn0205.Click, btn0206.Click _
                                                                               , btn0301.Click, btn0302.Click, btn0303.Click, btn0304.Click, btn0305.Click, btn0306.Click
        Select Case Me.lblMenuNo.Text
            Case MenuNo.メイン : Me.Clickメイン(CType(sender, BaseUI.Control.Button))
            Case MenuNo.受注 : Me.Click受注(CType(sender, BaseUI.Control.Button))
            Case MenuNo.マスタ : Me.Clickマスタ(CType(sender, BaseUI.Control.Button))
            Case MenuNo.コード表 : Me.Clickコード表(CType(sender, BaseUI.Control.Button))
            Case MenuNo.紙価格 : Me.Click紙価格(CType(sender, BaseUI.Control.Button))
            Case MenuNo.ヤマト運輸関連 : Me.Clickヤマト運輸関連(CType(sender, BaseUI.Control.Button))
            Case MenuNo.各種残高設定関連 : Me.Click各種残高設定関連(CType(sender, BaseUI.Control.Button))
        End Select

        Me.lblMenuTitle.Text = Me.Text
    End Sub

    '''========================================================================================
    '''  <summary>戻るﾎﾞﾀﾝ ｸﾘｯｸｲﾍﾞﾝﾄ</summary>
    '''========================================================================================
    Private Sub btnBack_Click(sender As Object, e As System.EventArgs) Handles btnBack.Click
        Select Case Me.lblMenuNo.Text
            Case MenuNo.メイン
            Case MenuNo.受注 : Me.Loadメイン()
            Case MenuNo.マスタ : Me.Loadメイン()
            Case MenuNo.コード表 : Me.Loadマスタ()
            Case MenuNo.紙価格 : Me.Loadマスタ()
            Case MenuNo.ヤマト運輸関連 : Me.Loadマスタ()
            Case MenuNo.各種残高設定関連 : Me.Loadマスタ()
        End Select
    End Sub

    '''========================================================================================
    '''  <summary>ﾃｷｽﾄ設定されてなければ非表示</summary>
    '''========================================================================================
    Private Sub btnVisible()
        Me.btn0101.Visible = (Me.btn0101.Text <> "")
        Me.btn0102.Visible = (Me.btn0102.Text <> "")
        Me.btn0103.Visible = (Me.btn0103.Text <> "")
        Me.btn0104.Visible = (Me.btn0104.Text <> "")
        Me.btn0105.Visible = (Me.btn0105.Text <> "")
        Me.btn0106.Visible = (Me.btn0106.Text <> "")

        Me.btn0201.Visible = (Me.btn0201.Text <> "")
        Me.btn0202.Visible = (Me.btn0202.Text <> "")
        Me.btn0203.Visible = (Me.btn0203.Text <> "")
        Me.btn0204.Visible = (Me.btn0204.Text <> "")
        Me.btn0205.Visible = (Me.btn0205.Text <> "")
        Me.btn0206.Visible = (Me.btn0206.Text <> "")

        Me.btn0301.Visible = (Me.btn0301.Text <> "")
        Me.btn0302.Visible = (Me.btn0302.Text <> "")
        Me.btn0303.Visible = (Me.btn0303.Text <> "")
        Me.btn0304.Visible = (Me.btn0304.Text <> "")
        Me.btn0305.Visible = (Me.btn0305.Text <> "")
        Me.btn0306.Visible = (Me.btn0306.Text <> "")

        If Me.lblMenuNo.Text = MenuNo.メイン Then
            Me.btnBack.Enabled = False
        Else
            Me.btnBack.Enabled = True
        End If
    End Sub

    '''========================================================================================
    '''  <summary>ﾌｫｰﾑのｵｰﾌﾟﾝ</summary>
    '''========================================================================================
    Private Sub FormOpen(frmBase As BaseUI.BaseForm, btnCommon As BaseUI.Control.Button)
        frmBase.Text = btnCommon.Text.Replace("*", "")
        frmBase.Show()
    End Sub
#End Region

#Region "ﾒﾆｭｰ一式"
#Region "[ﾒｲﾝ]"
    Private Sub Loadメイン()
        Me.lblMenuNo.Text = MenuNo.メイン
        Me.Text = "ラベル印刷業総合管理システム"

        Me.btn0101.Text = "受注処理"
        Me.btn0102.Text = "日次処理"
        Me.btn0103.Text = "締日処理"
        Me.btn0104.Text = "月次処理"
        Me.btn0105.Text = ""
        Me.btn0106.Text = "随時処理･問合せ"

        Me.btn0201.Text = "工程管理"
        Me.btn0202.Text = "見積処理"
        Me.btn0203.Text = "コーセー関連"
        Me.btn0204.Text = "ヤマト運輸関連"
        Me.btn0205.Text = "刃型管理"
        Me.btn0206.Text = ""

        Me.btn0301.Text = "マスタ保守／コード表"
        Me.btn0302.Text = "*特殊帳票ﾌﾟﾘﾝﾀ設定"
        Me.btn0303.Text = ""
        Me.btn0304.Text = "出荷ﾁｪｯｸ関連"
        Me.btn0305.Text = ""
        Me.btn0306.Text = ""

        Me.btnVisible()
    End Sub

    Private Sub Clickメイン(btnCommon As BaseUI.Control.Button)
        Select Case btnCommon.Name
            Case Me.btn0101.Name : Me.Load受注()                                   ' 受注関連
            Case Me.btn0102.Name
            Case Me.btn0103.Name
            Case Me.btn0104.Name
            Case Me.btn0105.Name
            Case Me.btn0106.Name

            Case Me.btn0201.Name
            Case Me.btn0202.Name
            Case Me.btn0203.Name
            Case Me.btn0204.Name
            Case Me.btn0205.Name
            Case Me.btn0206.Name

            Case Me.btn0301.Name : Me.Loadマスタ()                                 ' マスタ関連
            Case Me.btn0302.Name : Me.FormOpen(New frmPrinterSetting(), btnCommon) ' 特殊帳票ﾌﾟﾘﾝﾀ設定
            Case Me.btn0303.Name
            Case Me.btn0304.Name
            Case Me.btn0305.Name
            Case Me.btn0306.Name
        End Select
    End Sub
#End Region

#Region "[受注]"
    Private Sub Load受注()
        Me.lblMenuNo.Text = MenuNo.受注
        Me.Text = "受注処理"

        Me.btn0101.Text = "*受注入力"
        Me.btn0102.Text = "*ﾌﾚｷ用受注入力"
        Me.btn0103.Text = "テスト"
        Me.btn0104.Text = "*納期別場所別受注台帳"
        Me.btn0105.Text = "*受注台帳"
        Me.btn0106.Text = "*受注台帳保守"

        Me.btn0201.Text = "*納入場所振分入力"
        Me.btn0202.Text = "*担当者別得意先別受注集計表"
        Me.btn0203.Text = "*受注ラベル発行"
        Me.btn0204.Text = "*作業準備リスト"
        Me.btn0205.Text = "*作業進捗リスト"
        Me.btn0206.Text = "*生産計画入力"

        Me.btn0301.Text = "*生産計画表"
        Me.btn0302.Text = "*本台帳ﾊﾞｰｺｰﾄﾞ印字"
        Me.btn0303.Text = "発送･仕上予定関連"
        Me.btn0304.Text = "*オフセット発注書"
        Me.btn0305.Text = "各種帳票関連"
        Me.btn0306.Text = "本台帳廃棄処理"

        Me.btnVisible()
    End Sub

    Private Sub Click受注(btnCommon As BaseUI.Control.Button)
        Select Case btnCommon.Name
            Case Me.btn0101.Name : Me.FormOpen(New frmOrderBase(), btnCommon) ' 受注入力
            Case Me.btn0102.Name : Me.FormOpen(New frmFlexBlade(), btnCommon) ' ﾌﾚｷ用受注入力
            Case Me.btn0103.Name : Me.FormOpen(New frmTest(), btnCommon) ' ﾌﾚｷ用受注入力
            Case Me.btn0104.Name
            Case Me.btn0105.Name ' 受注台帳
            Case Me.btn0106.Name ' 受注台帳保守

            Case Me.btn0201.Name ' 納入場所振分入力
            Case Me.btn0202.Name ' 担当者別得意先別受注集計表
            Case Me.btn0203.Name ' 受注ラベル発行
            Case Me.btn0204.Name ' 作業準備リスト
            Case Me.btn0205.Name ' 作業進捗リスト
            Case Me.btn0206.Name ' 生産計画入力

            Case Me.btn0301.Name ' 生産計画表
            Case Me.btn0302.Name ' 本台帳ﾊﾞｰｺｰﾄﾞ印字
            Case Me.btn0303.Name ' 発送･仕上予定関連
            Case Me.btn0304.Name : Me.FormOpen(New frmOffSet(), btnCommon)        ' オフセット発注書
            Case Me.btn0305.Name ' 各種帳票関連()
            Case Me.btn0306.Name ' 本台帳廃棄処理
        End Select
    End Sub
#End Region

#Region "[マスタ]"
    Private Sub Loadマスタ()
        Me.lblMenuNo.Text = MenuNo.マスタ
        Me.Text = "マスタ保守／コード表"

        Me.btn0101.Text = "*紙マスタ保守"
        Me.btn0102.Text = "*糊マスタ保守"
        Me.btn0103.Text = "*台紙ﾏｽﾀ保守"
        Me.btn0104.Text = "*担当者ﾏｽﾀ保守"
        Me.btn0105.Text = "*機械ﾏｽﾀ保守"
        Me.btn0106.Text = "*大分類ﾏｽﾀ保守"

        Me.btn0201.Text = "*小分類ﾏｽﾀ保守"
        Me.btn0202.Text = "*印刷場所ﾏｽﾀ保守"
        Me.btn0203.Text = "*得意先ﾏｽﾀ保守"
        Me.btn0204.Text = "*得意先(個人用)ﾏｽﾀ保守"
        Me.btn0205.Text = "*出荷先ﾏｽﾀ保守"
        Me.btn0206.Text = "*仕入先ﾏｽﾀ保守"

        Me.btn0301.Text = "*品名ﾏｽﾀ保守"
        Me.btn0302.Text = ""
        Me.btn0303.Text = "各種残高設定関連"
        Me.btn0304.Text = "ヤマト運輸関連"
        Me.btn0305.Text = "各種コード表関連"
        Me.btn0306.Text = "紙価格関連"

        Me.btnVisible()
    End Sub

    Private Sub Clickマスタ(btnCommon As BaseUI.Control.Button)
        Select Case btnCommon.Name
            Case Me.btn0101.Name : Me.FormOpen(New frmPaper(), btnCommon)         ' 紙ﾏｽﾀ
            Case Me.btn0102.Name : Me.FormOpen(New frmPaste(), btnCommon)         ' 糊ﾏｽﾀ
            Case Me.btn0103.Name : Me.FormOpen(New frmMount(), btnCommon)         ' 台紙ﾏｽﾀ
            Case Me.btn0104.Name : Me.FormOpen(New frmPersonnel(), btnCommon)     ' 担当者ﾏｽﾀ
            Case Me.btn0105.Name : Me.FormOpen(New frmMachine(), btnCommon)       ' 機械ﾏｽﾀ
            Case Me.btn0106.Name : Me.FormOpen(New frmType1(), btnCommon)         ' 大分類ﾏｽﾀ

            Case Me.btn0201.Name : Me.FormOpen(New frmType2(), btnCommon)         ' 小分類ﾏｽﾀ
            Case Me.btn0202.Name : Me.FormOpen(New frmPrintLoc(), btnCommon)      ' 印刷場所ﾏｽﾀ
            Case Me.btn0203.Name : Me.FormOpen(New frmCustomer(), btnCommon)      ' 得意先ﾏｽﾀ
            Case Me.btn0204.Name : Me.FormOpen(New frmCustomerOne(), btnCommon)   ' 得意先(個人用)ﾏｽﾀ
            Case Me.btn0205.Name : Me.FormOpen(New frmDelivery(), btnCommon)      ' 出荷先ﾏｽﾀ
            Case Me.btn0206.Name : Me.FormOpen(New frmSupplier(), btnCommon)      ' 仕入先ﾏｽﾀ

            Case Me.btn0301.Name : Me.FormOpen(New frmItemName(), btnCommon)      ' 品名ﾏｽﾀ
            Case Me.btn0302.Name
            Case Me.btn0303.Name : Me.Load各種残高設定関連()                      ' 各種残高設定
            Case Me.btn0304.Name : Me.Loadヤマト運輸関連()                        ' ヤマト運輸
            Case Me.btn0305.Name : Me.Loadコード表()                              ' 各種コード表
            Case Me.btn0306.Name : Me.Load紙価格()                                ' 紙価格関連
        End Select
    End Sub
#End Region

#Region "[マスタ] - [各種残高設定関連]"
    Private Sub Load各種残高設定関連()
        Me.lblMenuNo.Text = MenuNo.各種残高設定関連
        Me.Text = "各種残高設定関連"

        Me.btn0101.Text = ""
        Me.btn0102.Text = "*締日残高ﾃﾞｰﾀ保守" & vbCrLf & "(得意先)"
        Me.btn0103.Text = "*月次残高ﾃﾞｰﾀ保守" & vbCrLf & "(得意先･仕入先)"
        Me.btn0104.Text = ""
        Me.btn0105.Text = ""
        Me.btn0106.Text = ""

        Me.btn0201.Text = ""
        Me.btn0202.Text = ""
        Me.btn0203.Text = ""
        Me.btn0204.Text = ""
        Me.btn0205.Text = ""
        Me.btn0206.Text = ""

        Me.btn0301.Text = ""
        Me.btn0302.Text = ""
        Me.btn0303.Text = ""
        Me.btn0304.Text = ""
        Me.btn0305.Text = ""
        Me.btn0306.Text = ""

        Me.btnVisible()
    End Sub

    Private Sub Click各種残高設定関連(btnCommon As BaseUI.Control.Button)
        Select Case btnCommon.Name
            Case Me.btn0101.Name
            Case Me.btn0102.Name : Me.FormOpen(New frmBalanceClosing(), btnCommon)    ' 締日残高ﾃﾞｰﾀ保守(得意先)
            Case Me.btn0103.Name : Me.FormOpen(New frmBalanceMonthly(), btnCommon)    ' 月次残高ﾃﾞｰﾀ保守(得意先･仕入先)
            Case Me.btn0104.Name
            Case Me.btn0105.Name
            Case Me.btn0106.Name

            Case Me.btn0201.Name
            Case Me.btn0202.Name
            Case Me.btn0203.Name
            Case Me.btn0204.Name
            Case Me.btn0205.Name
            Case Me.btn0206.Name

            Case Me.btn0301.Name
            Case Me.btn0302.Name
            Case Me.btn0303.Name
            Case Me.btn0304.Name
            Case Me.btn0305.Name
            Case Me.btn0306.Name
        End Select
    End Sub
#End Region

#Region "[マスタ] - [ヤマト運輸関連]"
    Private Sub Loadヤマト運輸関連()
        Me.lblMenuNo.Text = MenuNo.ヤマト運輸関連
        Me.Text = "ヤマト運輸関連"

        Me.btn0101.Text = "*ﾔﾏﾄ運輸用店所ﾏｽﾀ保守"
        Me.btn0102.Text = "*ﾔﾏﾄ運輸用ﾃﾞｰﾀ区分ﾏｽﾀ保守"
        Me.btn0103.Text = "*ﾔﾏﾄ運輸用種別ﾏｽﾀ保守"
        Me.btn0104.Text = ""
        Me.btn0105.Text = ""
        Me.btn0106.Text = ""

        Me.btn0201.Text = ""
        Me.btn0202.Text = ""
        Me.btn0203.Text = ""
        Me.btn0204.Text = ""
        Me.btn0205.Text = ""
        Me.btn0206.Text = ""

        Me.btn0301.Text = ""
        Me.btn0302.Text = ""
        Me.btn0303.Text = ""
        Me.btn0304.Text = ""
        Me.btn0305.Text = ""
        Me.btn0306.Text = ""

        Me.btnVisible()
    End Sub

    Private Sub Clickヤマト運輸関連(btnCommon As BaseUI.Control.Button)
        Select Case btnCommon.Name
            Case Me.btn0101.Name : Me.FormOpen(New frmYamatoShop(), btnCommon)    ' ﾔﾏﾄ運輸用店所ﾏｽﾀ
            Case Me.btn0102.Name : Me.FormOpen(New frmYamatoType(), btnCommon)    ' ﾔﾏﾄ運輸用ﾃﾞｰﾀ区分ﾏｽﾀ保守
            Case Me.btn0103.Name : Me.FormOpen(New frmYamatoKind(), btnCommon)    ' ﾔﾏﾄ運輸用種別ﾏｽﾀ保守
            Case Me.btn0104.Name
            Case Me.btn0105.Name
            Case Me.btn0106.Name

            Case Me.btn0201.Name
            Case Me.btn0202.Name
            Case Me.btn0203.Name
            Case Me.btn0204.Name
            Case Me.btn0205.Name
            Case Me.btn0206.Name

            Case Me.btn0301.Name
            Case Me.btn0302.Name
            Case Me.btn0303.Name
            Case Me.btn0304.Name
            Case Me.btn0305.Name
            Case Me.btn0306.Name
        End Select
    End Sub
#End Region

#Region "[マスタ] - [コード表]"
    Private Sub Loadコード表()
        Me.lblMenuNo.Text = MenuNo.コード表
        Me.Text = "各種コード表関連"

        Me.btn0101.Text = "*得意先ランク設定"
        Me.btn0102.Text = "*担当者別顧客リスト"
        Me.btn0103.Text = "*出荷先リスト"
        Me.btn0104.Text = "*定番リスト"
        Me.btn0105.Text = "*仕入先リスト"
        Me.btn0106.Text = ""

        Me.btn0201.Text = ""
        Me.btn0202.Text = ""
        Me.btn0203.Text = ""
        Me.btn0204.Text = ""
        Me.btn0205.Text = ""
        Me.btn0206.Text = ""

        Me.btn0301.Text = ""
        Me.btn0302.Text = ""
        Me.btn0303.Text = ""
        Me.btn0304.Text = ""
        Me.btn0305.Text = ""
        Me.btn0306.Text = ""

        Me.btnVisible()
    End Sub

    Private Sub Clickコード表(btnCommon As BaseUI.Control.Button)
        Select Case btnCommon.Name
            Case Me.btn0101.Name ' 得意先ランク設定
            Case Me.btn0102.Name ' 担当者別顧客リスト
            Case Me.btn0103.Name : Me.FormOpen(New frmDeliveryList(), btnCommon)    ' 出荷先リスト
            Case Me.btn0104.Name ' 定番リスト
            Case Me.btn0105.Name ' 仕入先リスト
            Case Me.btn0106.Name

            Case Me.btn0201.Name
            Case Me.btn0202.Name
            Case Me.btn0203.Name
            Case Me.btn0204.Name
            Case Me.btn0205.Name
            Case Me.btn0206.Name

            Case Me.btn0301.Name
            Case Me.btn0302.Name
            Case Me.btn0303.Name
            Case Me.btn0304.Name
            Case Me.btn0305.Name
            Case Me.btn0306.Name
        End Select
    End Sub
#End Region

#Region "[マスタ] - [紙価格]"
    Private Sub Load紙価格()
        Me.lblMenuNo.Text = MenuNo.紙価格
        Me.Text = "紙価格関連"

        Me.btn0101.Text = "*紙価格入力"
        Me.btn0102.Text = "*紙価格表"
        Me.btn0103.Text = ""
        Me.btn0104.Text = ""
        Me.btn0105.Text = ""
        Me.btn0106.Text = ""

        Me.btn0201.Text = ""
        Me.btn0202.Text = ""
        Me.btn0203.Text = ""
        Me.btn0204.Text = ""
        Me.btn0205.Text = ""
        Me.btn0206.Text = ""

        Me.btn0301.Text = ""
        Me.btn0302.Text = ""
        Me.btn0303.Text = ""
        Me.btn0304.Text = ""
        Me.btn0305.Text = ""
        Me.btn0306.Text = ""

        Me.btnVisible()
    End Sub

    Private Sub Click紙価格(btnCommon As BaseUI.Control.Button)
        Select Case btnCommon.Name
            Case Me.btn0101.Name : Me.FormOpen(New frmPaperPriIn(), btnCommon)    ' 紙価格入力
            Case Me.btn0102.Name : Me.FormOpen(New frmPaperPriList(), btnCommon)  ' 紙価格表
            Case Me.btn0103.Name
            Case Me.btn0104.Name
            Case Me.btn0105.Name
            Case Me.btn0106.Name

            Case Me.btn0201.Name
            Case Me.btn0202.Name
            Case Me.btn0203.Name
            Case Me.btn0204.Name
            Case Me.btn0205.Name
            Case Me.btn0206.Name

            Case Me.btn0301.Name
            Case Me.btn0302.Name
            Case Me.btn0303.Name
            Case Me.btn0304.Name
            Case Me.btn0305.Name
            Case Me.btn0306.Name
        End Select
    End Sub
#End Region

#End Region
End Class