<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CustomerLedgerNo
    Inherits DataDynamics.ActiveReports.ActiveReport

    'ActiveReport がコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub

    'メモ: 以下のプロシージャは ActiveReport デザイナで必要です。
    'ActiveReport デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CustomerLedgerNo))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt伝票区分 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月残高 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意 = New DataDynamics.ActiveReports.TextBox()
        Me.txt単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txt対象年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名摘要 = New DataDynamics.ActiveReports.TextBox()
        Me.txt入金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt数量 = New DataDynamics.ActiveReports.TextBox()
        Me.txt売上金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt出荷先名得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt作業No = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtHdr対象年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先元帳 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl伝票区分 = New DataDynamics.ActiveReports.Label()
        Me.lbl当月残高 = New DataDynamics.ActiveReports.Label()
        Me.lbl伝票No = New DataDynamics.ActiveReports.Label()
        Me.lbl商品名摘要 = New DataDynamics.ActiveReports.Label()
        Me.lbl対象年月 = New DataDynamics.ActiveReports.Label()
        Me.lbl単価 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr対象年月 = New DataDynamics.ActiveReports.Label()
        Me.lbl入金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl数量 = New DataDynamics.ActiveReports.Label()
        Me.lbl売上金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl出荷先名得意先名 = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先 = New DataDynamics.ActiveReports.Label()
        Me.txt得意先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl作業No = New DataDynamics.ActiveReports.Label()
        Me.grpFtr計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt当月残高合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt入金合計金額 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.txt売上合計金額 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt伝票区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名摘要, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt売上金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt出荷先名得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先元帳, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl伝票区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl当月残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl伝票No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl商品名摘要, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl入金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl売上金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl出荷先名得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月残高合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入金合計金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt売上合計金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt伝票区分, Me.txt当月残高, Me.txt得意, Me.txt単価, Me.txt対象年月, Me.txt商品名摘要, Me.txt入金額, Me.txt数量, Me.txt売上金額, Me.txt出荷先名得意先名, Me.txt作業No})
        Me.Detail.Height = 0.1968504!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt伝票区分
        '
        Me.txt伝票区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票区分.Height = 0.1968504!
        Me.txt伝票区分.Left = 1.102362!
        Me.txt伝票区分.Name = "txt伝票区分"
        Me.txt伝票区分.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt伝票区分.Text = "あああ"
        Me.txt伝票区分.Top = 0.0!
        Me.txt伝票区分.Width = 0.5905512!
        '
        'txt当月残高
        '
        Me.txt当月残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高.Height = 0.1968504!
        Me.txt当月残高.Left = 7.637795!
        Me.txt当月残高.Name = "txt当月残高"
        Me.txt当月残高.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月残高.Text = "999,999,999"
        Me.txt当月残高.Top = 0.000001132488!
        Me.txt当月残高.Width = 0.9055118!
        '
        'txt得意
        '
        Me.txt得意.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意.Height = 0.1968504!
        Me.txt得意.Left = 0.5905512!
        Me.txt得意.Name = "txt得意"
        Me.txt得意.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt得意.Text = "123456"
        Me.txt得意.Top = 0.000000178814!
        Me.txt得意.Width = 0.511811!
        '
        'txt単価
        '
        Me.txt単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Height = 0.1968504!
        Me.txt単価.Left = 4.960629!
        Me.txt単価.Name = "txt単価"
        Me.txt単価.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt単価.Text = "999,999,999"
        Me.txt単価.Top = 0.0000002980233!
        Me.txt単価.Width = 0.9448819!
        '
        'txt対象年月
        '
        Me.txt対象年月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対象年月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対象年月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対象年月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対象年月.Height = 0.1968504!
        Me.txt対象年月.Left = 0.0!
        Me.txt対象年月.Name = "txt対象年月"
        Me.txt対象年月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt対象年月.Text = "YY/MM/DD"
        Me.txt対象年月.Top = 0.00000005960464!
        Me.txt対象年月.Width = 0.5905512!
        '
        'txt商品名摘要
        '
        Me.txt商品名摘要.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名摘要.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名摘要.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名摘要.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名摘要.Height = 0.1968504!
        Me.txt商品名摘要.Left = 1.692913!
        Me.txt商品名摘要.Name = "txt商品名摘要"
        Me.txt商品名摘要.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: justify; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt商品名摘要.Text = "あああああいいいいいううううう"
        Me.txt商品名摘要.Top = 0.0000001192093!
        Me.txt商品名摘要.Width = 2.007874!
        '
        'txt入金額
        '
        Me.txt入金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金額.Height = 0.1968504!
        Me.txt入金額.Left = 6.771653!
        Me.txt入金額.Name = "txt入金額"
        Me.txt入金額.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt入金額.Text = "999,999,999"
        Me.txt入金額.Top = 0.0000002980233!
        Me.txt入金額.Width = 0.8661417!
        '
        'txt数量
        '
        Me.txt数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Height = 0.1968504!
        Me.txt数量.Left = 4.133858!
        Me.txt数量.Name = "txt数量"
        Me.txt数量.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt数量.Text = "999,999"
        Me.txt数量.Top = 0.0000002980233!
        Me.txt数量.Width = 0.8267716!
        '
        'txt売上金額
        '
        Me.txt売上金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上金額.Height = 0.1968504!
        Me.txt売上金額.Left = 5.905511!
        Me.txt売上金額.Name = "txt売上金額"
        Me.txt売上金額.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt売上金額.Text = "999,999,999"
        Me.txt売上金額.Top = 0.0000005066395!
        Me.txt売上金額.Width = 0.8661417!
        '
        'txt出荷先名得意先名
        '
        Me.txt出荷先名得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先名得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先名得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先名得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先名得意先名.Height = 0.1968504!
        Me.txt出荷先名得意先名.Left = 8.543306!
        Me.txt出荷先名得意先名.Name = "txt出荷先名得意先名"
        Me.txt出荷先名得意先名.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: left; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt出荷先名得意先名.Text = "あああああいいいいい"
        Me.txt出荷先名得意先名.Top = 0.0!
        Me.txt出荷先名得意先名.Width = 1.968504!
        '
        'txt作業No
        '
        Me.txt作業No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Height = 0.1968504!
        Me.txt作業No.Left = 3.700787!
        Me.txt作業No.Name = "txt作業No"
        Me.txt作業No.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt作業No.Text = "123456"
        Me.txt作業No.Top = 0.0!
        Me.txt作業No.Width = 0.4330709!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNow, Me.txt頁})
        Me.PageHeader.Height = 0.2362205!
        Me.PageHeader.Name = "PageHeader"
        '
        'txtNow
        '
        Me.txtNow.Height = 0.2362205!
        Me.txtNow.Left = 7.574792!
        Me.txtNow.Name = "txtNow"
        Me.txtNow.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtNow.Text = "YY/MM/DD　123456 作成"
        Me.txtNow.Top = 0.0!
        Me.txtNow.Width = 1.890551!
        '
        'txt頁
        '
        Me.txt頁.Height = 0.2362205!
        Me.txt頁.Left = 9.718505!
        Me.txt頁.Name = "txt頁"
        Me.txt頁.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt頁.Text = "頁"
        Me.txt頁.Top = 0.0!
        Me.txt頁.Width = 0.379528!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdr
        '
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtHdr対象年月, Me.txt得意先元帳, Me.lbl伝票区分, Me.lbl当月残高, Me.lbl伝票No, Me.lbl商品名摘要, Me.lbl対象年月, Me.lbl単価, Me.lblHdr対象年月, Me.lbl入金額, Me.lbl数量, Me.lbl売上金額, Me.lbl出荷先名得意先名, Me.lbl得意先, Me.txt得意先CD, Me.txt得意先名, Me.lbl作業No})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 1.318898!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txtHdr対象年月
        '
        Me.txtHdr対象年月.Height = 0.2362205!
        Me.txtHdr対象年月.Left = 0.7874014!
        Me.txtHdr対象年月.Name = "txtHdr対象年月"
        Me.txtHdr対象年月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtHdr対象年月.Text = "YY/MM月分"
        Me.txtHdr対象年月.Top = 0.0!
        Me.txtHdr対象年月.Width = 1.181102!
        '
        'txt得意先元帳
        '
        Me.txt得意先元帳.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt得意先元帳.CharacterSpacing = 10.0!
        Me.txt得意先元帳.Height = 0.2362205!
        Me.txt得意先元帳.Left = 4.125197!
        Me.txt得意先元帳.Name = "txt得意先元帳"
        Me.txt得意先元帳.Style = "font-family: ＭＳ Ｐゴシック; font-size: 14pt; font-weight: bold; text-align: center; ve" & _
    "rtical-align: bottom; ddo-char-set: 1"
        Me.txt得意先元帳.Text = "得意先元帳"
        Me.txt得意先元帳.Top = 0.1122047!
        Me.txt得意先元帳.Width = 2.725591!
        '
        'lbl伝票区分
        '
        Me.lbl伝票区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票区分.Height = 0.2755905!
        Me.lbl伝票区分.HyperLink = Nothing
        Me.lbl伝票区分.Left = 1.102362!
        Me.lbl伝票区分.Name = "lbl伝票区分"
        Me.lbl伝票区分.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl伝票区分.Text = "伝票区分"
        Me.lbl伝票区分.Top = 1.043307!
        Me.lbl伝票区分.Width = 0.5905512!
        '
        'lbl当月残高
        '
        Me.lbl当月残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月残高.CharacterSpacing = 1.0!
        Me.lbl当月残高.Height = 0.2755905!
        Me.lbl当月残高.HyperLink = Nothing
        Me.lbl当月残高.Left = 7.637795!
        Me.lbl当月残高.Name = "lbl当月残高"
        Me.lbl当月残高.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl当月残高.Text = "当月残高"
        Me.lbl当月残高.Top = 1.043307!
        Me.lbl当月残高.Width = 0.9055118!
        '
        'lbl伝票No
        '
        Me.lbl伝票No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Height = 0.2755905!
        Me.lbl伝票No.HyperLink = Nothing
        Me.lbl伝票No.Left = 0.5905514!
        Me.lbl伝票No.Name = "lbl伝票No"
        Me.lbl伝票No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl伝票No.Text = "伝票No"
        Me.lbl伝票No.Top = 1.043307!
        Me.lbl伝票No.Width = 0.511811!
        '
        'lbl商品名摘要
        '
        Me.lbl商品名摘要.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名摘要.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名摘要.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名摘要.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名摘要.CharacterSpacing = 10.0!
        Me.lbl商品名摘要.Height = 0.2755905!
        Me.lbl商品名摘要.HyperLink = Nothing
        Me.lbl商品名摘要.Left = 1.692914!
        Me.lbl商品名摘要.Name = "lbl商品名摘要"
        Me.lbl商品名摘要.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl商品名摘要.Text = "商品名/摘要"
        Me.lbl商品名摘要.Top = 1.043307!
        Me.lbl商品名摘要.Width = 2.007874!
        '
        'lbl対象年月
        '
        Me.lbl対象年月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl対象年月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl対象年月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl対象年月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl対象年月.Height = 0.2755905!
        Me.lbl対象年月.HyperLink = Nothing
        Me.lbl対象年月.Left = 0.0000002384186!
        Me.lbl対象年月.Name = "lbl対象年月"
        Me.lbl対象年月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl対象年月.Text = "年月日"
        Me.lbl対象年月.Top = 1.043307!
        Me.lbl対象年月.Width = 0.5905512!
        '
        'lbl単価
        '
        Me.lbl単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.CharacterSpacing = 10.0!
        Me.lbl単価.Height = 0.2755905!
        Me.lbl単価.HyperLink = Nothing
        Me.lbl単価.Left = 4.96063!
        Me.lbl単価.Name = "lbl単価"
        Me.lbl単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl単価.Text = "単価"
        Me.lbl単価.Top = 1.043307!
        Me.lbl単価.Width = 0.9448819!
        '
        'lblHdr対象年月
        '
        Me.lblHdr対象年月.Height = 0.2362205!
        Me.lblHdr対象年月.HyperLink = Nothing
        Me.lblHdr対象年月.Left = 0.0!
        Me.lblHdr対象年月.Name = "lblHdr対象年月"
        Me.lblHdr対象年月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdr対象年月.Text = "対象年月"
        Me.lblHdr対象年月.Top = 0.0!
        Me.lblHdr対象年月.Width = 0.7874014!
        '
        'lbl入金額
        '
        Me.lbl入金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl入金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl入金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl入金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl入金額.Height = 0.2755905!
        Me.lbl入金額.HyperLink = Nothing
        Me.lbl入金額.Left = 6.771654!
        Me.lbl入金額.Name = "lbl入金額"
        Me.lbl入金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl入金額.Text = "入金額"
        Me.lbl入金額.Top = 1.043307!
        Me.lbl入金額.Width = 0.8661417!
        '
        'lbl数量
        '
        Me.lbl数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.CharacterSpacing = 10.0!
        Me.lbl数量.Height = 0.2755905!
        Me.lbl数量.HyperLink = Nothing
        Me.lbl数量.Left = 4.133858!
        Me.lbl数量.Name = "lbl数量"
        Me.lbl数量.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl数量.Text = "数量"
        Me.lbl数量.Top = 1.043307!
        Me.lbl数量.Width = 0.8267716!
        '
        'lbl売上金額
        '
        Me.lbl売上金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上金額.CharacterSpacing = 5.0!
        Me.lbl売上金額.Height = 0.2755905!
        Me.lbl売上金額.HyperLink = Nothing
        Me.lbl売上金額.Left = 5.905512!
        Me.lbl売上金額.Name = "lbl売上金額"
        Me.lbl売上金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl売上金額.Text = "売上金額"
        Me.lbl売上金額.Top = 1.043307!
        Me.lbl売上金額.Width = 0.8661417!
        '
        'lbl出荷先名得意先名
        '
        Me.lbl出荷先名得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷先名得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷先名得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷先名得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷先名得意先名.CharacterSpacing = 3.0!
        Me.lbl出荷先名得意先名.Height = 0.2755905!
        Me.lbl出荷先名得意先名.HyperLink = Nothing
        Me.lbl出荷先名得意先名.Left = 8.543307!
        Me.lbl出荷先名得意先名.Name = "lbl出荷先名得意先名"
        Me.lbl出荷先名得意先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl出荷先名得意先名.Text = "出荷先名/得意先名"
        Me.lbl出荷先名得意先名.Top = 1.043307!
        Me.lbl出荷先名得意先名.Width = 1.968504!
        '
        'lbl得意先
        '
        Me.lbl得意先.Height = 0.2362205!
        Me.lbl得意先.HyperLink = Nothing
        Me.lbl得意先.Left = 0.0!
        Me.lbl得意先.Name = "lbl得意先"
        Me.lbl得意先.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl得意先.Text = "得意先"
        Me.lbl得意先.Top = 0.5409449!
        Me.lbl得意先.Width = 0.7874014!
        '
        'txt得意先CD
        '
        Me.txt得意先CD.Height = 0.2362205!
        Me.txt得意先CD.Left = 0.7874014!
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt得意先CD.Text = "123456"
        Me.txt得意先CD.Top = 0.5409449!
        Me.txt得意先CD.Width = 0.5905512!
        '
        'txt得意先名
        '
        Me.txt得意先名.Height = 0.2362205!
        Me.txt得意先名.Left = 1.433071!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt得意先名.Text = "あああああいいいいいううううう"
        Me.txt得意先名.Top = 0.5409449!
        Me.txt得意先名.Width = 2.826772!
        '
        'lbl作業No
        '
        Me.lbl作業No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Height = 0.2755905!
        Me.lbl作業No.HyperLink = Nothing
        Me.lbl作業No.Left = 3.700787!
        Me.lbl作業No.Name = "lbl作業No"
        Me.lbl作業No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: justify; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl作業No.Text = "作業No"
        Me.lbl作業No.Top = 1.043307!
        Me.lbl作業No.Width = 0.4330709!
        '
        'grpFtr計
        '
        Me.grpFtr計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt当月残高合計, Me.txt入金合計金額, Me.TextBox4, Me.TextBox2, Me.txt売上合計金額, Me.TextBox17, Me.Label2, Me.TextBox19, Me.TextBox3, Me.TextBox, Me.TextBox8, Me.TextBox1})
        Me.grpFtr計.Height = 0.1968504!
        Me.grpFtr計.Name = "grpFtr計"
        '
        'txt当月残高合計
        '
        Me.txt当月残高合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高合計.Height = 0.1968504!
        Me.txt当月残高合計.Left = 7.637795!
        Me.txt当月残高合計.Name = "txt当月残高合計"
        Me.txt当月残高合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月残高合計.Text = "999,999,999"
        Me.txt当月残高合計.Top = 0.0!
        Me.txt当月残高合計.Width = 0.9055118!
        '
        'txt入金合計金額
        '
        Me.txt入金合計金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金合計金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金合計金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金合計金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金合計金額.Height = 0.1968504!
        Me.txt入金合計金額.Left = 6.771654!
        Me.txt入金合計金額.Name = "txt入金合計金額"
        Me.txt入金合計金額.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt入金合計金額.Text = "999,999,999"
        Me.txt入金合計金額.Top = 0.0000002980233!
        Me.txt入金合計金額.Width = 0.8661417!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Height = 0.1968504!
        Me.TextBox4.Left = 4.96063!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.0000002980233!
        Me.TextBox4.Width = 0.9448819!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Height = 0.1968504!
        Me.TextBox2.Left = 1.692913!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0000001192093!
        Me.TextBox2.Width = 2.007874!
        '
        'txt売上合計金額
        '
        Me.txt売上合計金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上合計金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上合計金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上合計金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上合計金額.Height = 0.1968504!
        Me.txt売上合計金額.Left = 5.905512!
        Me.txt売上合計金額.Name = "txt売上合計金額"
        Me.txt売上合計金額.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt売上合計金額.Text = "999,999,999"
        Me.txt売上合計金額.Top = 0.0000005066395!
        Me.txt売上合計金額.Width = 0.8661417!
        '
        'TextBox17
        '
        Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Height = 0.1968504!
        Me.TextBox17.Left = 0.5905512!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox17.Text = Nothing
        Me.TextBox17.Top = 0.0!
        Me.TextBox17.Width = 0.511811!
        '
        'Label2
        '
        Me.Label2.Height = 0.1771654!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 5.062993!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label2.Text = "＊得意先計"
        Me.Label2.Top = 0.01023622!
        Me.Label2.Width = 0.7874016!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Height = 0.1968504!
        Me.TextBox19.Left = 0.0!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox19.Text = Nothing
        Me.TextBox19.Top = 0.00000005960464!
        Me.TextBox19.Width = 0.5905512!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.1968504!
        Me.TextBox3.Left = 4.133858!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.8267716!
        '
        'TextBox
        '
        Me.TextBox.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox.Height = 0.1968504!
        Me.TextBox.Left = 1.102362!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox.Text = Nothing
        Me.TextBox.Top = 0.0!
        Me.TextBox.Width = 0.5905512!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Height = 0.1968504!
        Me.TextBox8.Left = 8.543307!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 1.968504!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.1968504!
        Me.TextBox1.Left = 3.700787!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.4330709!
        '
        'CustomerLedgerNo
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.51181!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr計)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt伝票区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名摘要, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt売上金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt出荷先名得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先元帳, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl伝票区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl当月残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl伝票No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl商品名摘要, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl入金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl売上金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl出荷先名得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月残高合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入金合計金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt売上合計金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents Label9 As DataDynamics.ActiveReports.Label
    Private WithEvents Label12 As DataDynamics.ActiveReports.Label
    Private WithEvents txt自社担当者名 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lbl本支店名 As DataDynamics.ActiveReports.Label
    Private WithEvents txt枝版 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl部署名 As DataDynamics.ActiveReports.Label
    Private WithEvents txt伝票区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当月残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt対象年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名摘要 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt入金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt数量 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt売上金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txtHdr対象年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先元帳 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl伝票区分 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl伝票No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl商品名摘要 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl対象年月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl単価 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr対象年月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl入金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl数量 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl売上金額 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt当月残高合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt入金合計金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt売上合計金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt出荷先名得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl出荷先名得意先名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl当月残高 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl得意先 As DataDynamics.ActiveReports.Label
    Private WithEvents txt得意先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt作業No As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl作業No As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
End Class
