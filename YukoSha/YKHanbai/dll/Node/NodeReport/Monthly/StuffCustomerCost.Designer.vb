<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class StuffCustomerCost
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(StuffCustomerCost))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt仕入 = New DataDynamics.ActiveReports.TextBox()
        Me.txt粗利 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt諸経費 = New DataDynamics.ActiveReports.TextBox()
        Me.txt売上 = New DataDynamics.ActiveReports.TextBox()
        Me.txt固定経費 = New DataDynamics.ActiveReports.TextBox()
        Me.txt利益 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数m = New DataDynamics.ActiveReports.TextBox()
        Me.txt利益率 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt対象年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者別未引当一覧表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl仕入 = New DataDynamics.ActiveReports.Label()
        Me.lbl粗利 = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先名 = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先CD = New DataDynamics.ActiveReports.Label()
        Me.lbl通数 = New DataDynamics.ActiveReports.Label()
        Me.lbl諸経費 = New DataDynamics.ActiveReports.Label()
        Me.lbl売上 = New DataDynamics.ActiveReports.Label()
        Me.lbl固定経費 = New DataDynamics.ActiveReports.Label()
        Me.lbl利益 = New DataDynamics.ActiveReports.Label()
        Me.lbl担当者 = New DataDynamics.ActiveReports.Label()
        Me.txt担当者CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者名 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl利益率 = New DataDynamics.ActiveReports.Label()
        Me.txt受注区分 = New DataDynamics.ActiveReports.TextBox()
        Me.grpFtr計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt粗利合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt諸経費合計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.txt売上合計 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt固定経費合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt利益合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数m合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt利益率合計 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt利益担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt固定経費担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt粗利担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt諸経費担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt売上担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox30 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox31 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.txt通数担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数m担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt利益率担当者計 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt仕入, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt粗利, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt諸経費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt売上, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt固定経費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt利益, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数m, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt利益率, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者別未引当一覧表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl粗利, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl諸経費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl売上, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl固定経費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl利益, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl担当者, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl利益率, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt粗利合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt諸経費合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt売上合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt固定経費合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt利益合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数m合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt利益率合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt利益担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt固定経費担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt粗利担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt諸経費担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt売上担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数m担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt利益率担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt仕入, Me.txt粗利, Me.txt通数, Me.txt得意先CD, Me.txt得意先名, Me.txt諸経費, Me.txt売上, Me.txt固定経費, Me.txt利益, Me.txt通数m, Me.txt利益率})
        Me.Detail.Height = 0.2755905!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt仕入
        '
        Me.txt仕入.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入.Height = 0.2755905!
        Me.txt仕入.Left = 4.744094!
        Me.txt仕入.Name = "txt仕入"
        Me.txt仕入.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入.Text = "999,999,999"
        Me.txt仕入.Top = 0.0!
        Me.txt仕入.Width = 1.003937!
        '
        'txt粗利
        '
        Me.txt粗利.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利.Height = 0.2755905!
        Me.txt粗利.Left = 6.791339!
        Me.txt粗利.Name = "txt粗利"
        Me.txt粗利.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt粗利.Text = "999,999,999"
        Me.txt粗利.Top = 0.000001132488!
        Me.txt粗利.Width = 0.9645669!
        '
        'txt通数
        '
        Me.txt通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数.Height = 0.1377953!
        Me.txt通数.Left = 2.77559!
        Me.txt通数.Name = "txt通数"
        Me.txt通数.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt通数.Text = "999,999,999通"
        Me.txt通数.Top = 0.0000002980233!
        Me.txt通数.Width = 1.023622!
        '
        'txt得意先CD
        '
        Me.txt得意先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Height = 0.2755905!
        Me.txt得意先CD.Left = 0.0!
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt得意先CD.Text = "123456"
        Me.txt得意先CD.Top = 0.00000005960464!
        Me.txt得意先CD.Width = 0.6299213!
        '
        'txt得意先名
        '
        Me.txt得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Height = 0.2755905!
        Me.txt得意先名.Left = 0.6299213!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: justify; vertical-align: bottom" & _
    "; ddo-char-set: 1"
        Me.txt得意先名.Text = "あああああいいい"
        Me.txt得意先名.Top = 0.0000001192093!
        Me.txt得意先名.Width = 2.145669!
        '
        'txt諸経費
        '
        Me.txt諸経費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費.Height = 0.2755905!
        Me.txt諸経費.Left = 5.748032!
        Me.txt諸経費.Name = "txt諸経費"
        Me.txt諸経費.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt諸経費.Text = "999,999,999"
        Me.txt諸経費.Top = 0.0000002980233!
        Me.txt諸経費.Width = 1.043307!
        '
        'txt売上
        '
        Me.txt売上.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上.Height = 0.2755905!
        Me.txt売上.Left = 3.799212!
        Me.txt売上.Name = "txt売上"
        Me.txt売上.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt売上.Text = "999,999,999"
        Me.txt売上.Top = 0.0000005066395!
        Me.txt売上.Width = 0.9448819!
        '
        'txt固定経費
        '
        Me.txt固定経費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費.Height = 0.2755905!
        Me.txt固定経費.Left = 7.755906!
        Me.txt固定経費.Name = "txt固定経費"
        Me.txt固定経費.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt固定経費.Text = "999,999,999"
        Me.txt固定経費.Top = 0.0!
        Me.txt固定経費.Width = 1.023622!
        '
        'txt利益
        '
        Me.txt利益.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益.Height = 0.2755905!
        Me.txt利益.Left = 8.779528!
        Me.txt利益.Name = "txt利益"
        Me.txt利益.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt利益.Text = "999,999,999"
        Me.txt利益.Top = 0.0000001192093!
        Me.txt利益.Width = 1.043307!
        '
        'txt通数m
        '
        Me.txt通数m.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m.Height = 0.1377953!
        Me.txt通数m.Left = 2.77559!
        Me.txt通数m.Name = "txt通数m"
        Me.txt通数m.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt通数m.Text = "999,999m"
        Me.txt通数m.Top = 0.1377956!
        Me.txt通数m.Width = 1.023622!
        '
        'txt利益率
        '
        Me.txt利益率.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率.Height = 0.2755905!
        Me.txt利益率.Left = 9.822835!
        Me.txt利益率.Name = "txt利益率"
        Me.txt利益率.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt利益率.Text = "999.99"
        Me.txt利益率.Top = 0.0!
        Me.txt利益率.Width = 0.8464568!
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
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt対象年月, Me.txt担当者別未引当一覧表, Me.lbl仕入, Me.lbl粗利, Me.lbl得意先名, Me.lbl得意先CD, Me.lbl通数, Me.lbl諸経費, Me.lbl売上, Me.lbl固定経費, Me.lbl利益, Me.lbl担当者, Me.txt担当者CD, Me.txt担当者名, Me.lbl利益率, Me.txt受注区分})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.7976378!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txt対象年月
        '
        Me.txt対象年月.Height = 0.2362205!
        Me.txt対象年月.Left = 0.0!
        Me.txt対象年月.Name = "txt対象年月"
        Me.txt対象年月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対象年月.Text = "YY/MM月分"
        Me.txt対象年月.Top = 0.0!
        Me.txt対象年月.Width = 1.181102!
        '
        'txt担当者別未引当一覧表
        '
        Me.txt担当者別未引当一覧表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt担当者別未引当一覧表.Height = 0.3149606!
        Me.txt担当者別未引当一覧表.Left = 3.357481!
        Me.txt担当者別未引当一覧表.Name = "txt担当者別未引当一覧表"
        Me.txt担当者別未引当一覧表.Style = "font-family: ＭＳ Ｐゴシック; font-size: 16pt; font-weight: bold; text-align: center; ve" & _
    "rtical-align: bottom; ddo-char-set: 1"
        Me.txt担当者別未引当一覧表.Text = "担当者別得意先別原価集計表"
        Me.txt担当者別未引当一覧表.Top = 0.0!
        Me.txt担当者別未引当一覧表.Width = 3.937008!
        '
        'lbl仕入
        '
        Me.lbl仕入.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入.Height = 0.2559055!
        Me.lbl仕入.HyperLink = Nothing
        Me.lbl仕入.Left = 4.744095!
        Me.lbl仕入.Name = "lbl仕入"
        Me.lbl仕入.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl仕入.Text = "仕入"
        Me.lbl仕入.Top = 0.5417323!
        Me.lbl仕入.Width = 1.003937!
        '
        'lbl粗利
        '
        Me.lbl粗利.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Height = 0.2559055!
        Me.lbl粗利.HyperLink = Nothing
        Me.lbl粗利.Left = 6.791339!
        Me.lbl粗利.Name = "lbl粗利"
        Me.lbl粗利.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl粗利.Text = "粗利"
        Me.lbl粗利.Top = 0.5417323!
        Me.lbl粗利.Width = 0.9645669!
        '
        'lbl得意先名
        '
        Me.lbl得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.CharacterSpacing = 5.0!
        Me.lbl得意先名.Height = 0.2559055!
        Me.lbl得意先名.HyperLink = Nothing
        Me.lbl得意先名.Left = 0.6299217!
        Me.lbl得意先名.Name = "lbl得意先名"
        Me.lbl得意先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbl得意先名.Text = " 得意先名"
        Me.lbl得意先名.Top = 0.5417323!
        Me.lbl得意先名.Width = 2.145669!
        '
        'lbl得意先CD
        '
        Me.lbl得意先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Height = 0.2559055!
        Me.lbl得意先CD.HyperLink = Nothing
        Me.lbl得意先CD.Left = 0.0000004768372!
        Me.lbl得意先CD.Name = "lbl得意先CD"
        Me.lbl得意先CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7.5pt; text-align: center; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.lbl得意先CD.Text = "コード"
        Me.lbl得意先CD.Top = 0.5417323!
        Me.lbl得意先CD.Width = 0.6299213!
        '
        'lbl通数
        '
        Me.lbl通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Height = 0.2559055!
        Me.lbl通数.HyperLink = Nothing
        Me.lbl通数.Left = 2.775591!
        Me.lbl通数.Name = "lbl通数"
        Me.lbl通数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl通数.Text = "通数/m数"
        Me.lbl通数.Top = 0.5417323!
        Me.lbl通数.Width = 1.023622!
        '
        'lbl諸経費
        '
        Me.lbl諸経費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl諸経費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl諸経費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl諸経費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl諸経費.Height = 0.2559055!
        Me.lbl諸経費.HyperLink = Nothing
        Me.lbl諸経費.Left = 5.748032!
        Me.lbl諸経費.Name = "lbl諸経費"
        Me.lbl諸経費.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl諸経費.Text = "諸経費"
        Me.lbl諸経費.Top = 0.5417323!
        Me.lbl諸経費.Width = 1.043307!
        '
        'lbl売上
        '
        Me.lbl売上.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上.CharacterSpacing = 5.0!
        Me.lbl売上.Height = 0.2559055!
        Me.lbl売上.HyperLink = Nothing
        Me.lbl売上.Left = 3.799213!
        Me.lbl売上.Name = "lbl売上"
        Me.lbl売上.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl売上.Text = "売上"
        Me.lbl売上.Top = 0.5417323!
        Me.lbl売上.Width = 0.9448819!
        '
        'lbl固定経費
        '
        Me.lbl固定経費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl固定経費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl固定経費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl固定経費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl固定経費.Height = 0.2559055!
        Me.lbl固定経費.HyperLink = Nothing
        Me.lbl固定経費.Left = 7.755907!
        Me.lbl固定経費.Name = "lbl固定経費"
        Me.lbl固定経費.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl固定経費.Text = "固定経費"
        Me.lbl固定経費.Top = 0.5417323!
        Me.lbl固定経費.Width = 1.023622!
        '
        'lbl利益
        '
        Me.lbl利益.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益.Height = 0.2559055!
        Me.lbl利益.HyperLink = Nothing
        Me.lbl利益.Left = 8.779528!
        Me.lbl利益.Name = "lbl利益"
        Me.lbl利益.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl利益.Text = "利益"
        Me.lbl利益.Top = 0.5417323!
        Me.lbl利益.Width = 1.043307!
        '
        'lbl担当者
        '
        Me.lbl担当者.Height = 0.2362205!
        Me.lbl担当者.HyperLink = Nothing
        Me.lbl担当者.Left = 0.0!
        Me.lbl担当者.Name = "lbl担当者"
        Me.lbl担当者.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl担当者.Text = "担当者"
        Me.lbl担当者.Top = 0.2362205!
        Me.lbl担当者.Width = 0.7874014!
        '
        'txt担当者CD
        '
        Me.txt担当者CD.Height = 0.2362205!
        Me.txt担当者CD.Left = 0.7874014!
        Me.txt担当者CD.Name = "txt担当者CD"
        Me.txt担当者CD.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt担当者CD.Text = "123"
        Me.txt担当者CD.Top = 0.2362205!
        Me.txt担当者CD.Width = 0.3937008!
        '
        'txt担当者名
        '
        Me.txt担当者名.Height = 0.2362205!
        Me.txt担当者名.Left = 1.228347!
        Me.txt担当者名.Name = "txt担当者名"
        Me.txt担当者名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt担当者名.Text = "あああああいいいいい"
        Me.txt担当者名.Top = 0.2362205!
        Me.txt担当者名.Width = 1.670866!
        '
        'lbl利益率
        '
        Me.lbl利益率.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益率.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益率.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益率.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益率.Height = 0.2559055!
        Me.lbl利益率.HyperLink = Nothing
        Me.lbl利益率.Left = 9.822836!
        Me.lbl利益率.Name = "lbl利益率"
        Me.lbl利益率.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl利益率.Text = "利益率％"
        Me.lbl利益率.Top = 0.5417322!
        Me.lbl利益率.Width = 0.8464568!
        '
        'txt受注区分
        '
        Me.txt受注区分.Height = 0.2362205!
        Me.txt受注区分.Left = 7.400788!
        Me.txt受注区分.Name = "txt受注区分"
        Me.txt受注区分.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt受注区分.Text = "(あああああいいいいいうう)"
        Me.txt受注区分.Top = 0.1692913!
        Me.txt受注区分.Width = 2.064568!
        '
        'grpFtr計
        '
        Me.grpFtr計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt粗利合計, Me.txt諸経費合計, Me.TextBox11, Me.txt売上合計, Me.Label2, Me.TextBox19, Me.txt仕入合計, Me.txt固定経費合計, Me.txt利益合計, Me.txt通数合計, Me.txt通数m合計, Me.txt利益率合計})
        Me.grpFtr計.Height = 0.2755905!
        Me.grpFtr計.Name = "grpFtr計"
        '
        'txt粗利合計
        '
        Me.txt粗利合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利合計.Height = 0.2755905!
        Me.txt粗利合計.Left = 6.791339!
        Me.txt粗利合計.Name = "txt粗利合計"
        Me.txt粗利合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt粗利合計.Text = "999,999,999"
        Me.txt粗利合計.Top = 0.0!
        Me.txt粗利合計.Width = 0.9645669!
        '
        'txt諸経費合計
        '
        Me.txt諸経費合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費合計.Height = 0.2755905!
        Me.txt諸経費合計.Left = 5.748032!
        Me.txt諸経費合計.Name = "txt諸経費合計"
        Me.txt諸経費合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt諸経費合計.Text = "999,999,999"
        Me.txt諸経費合計.Top = 0.0!
        Me.txt諸経費合計.Width = 1.043307!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Height = 0.2755905!
        Me.TextBox11.Left = 0.6299213!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 0.0000001192093!
        Me.TextBox11.Width = 2.145669!
        '
        'txt売上合計
        '
        Me.txt売上合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上合計.Height = 0.2755905!
        Me.txt売上合計.Left = 3.799212!
        Me.txt売上合計.Name = "txt売上合計"
        Me.txt売上合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt売上合計.Text = "999,999,999"
        Me.txt売上合計.Top = 0.0000005066395!
        Me.txt売上合計.Width = 0.9448819!
        '
        'Label2
        '
        Me.Label2.Height = 0.1771654!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 1.899999!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label2.Text = "＊合計"
        Me.Label2.Top = 0.05118112!
        Me.Label2.Width = 0.7874016!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Height = 0.2755905!
        Me.TextBox19.Left = 0.0!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox19.Text = Nothing
        Me.TextBox19.Top = 0.00000005960464!
        Me.TextBox19.Width = 0.6299213!
        '
        'txt仕入合計
        '
        Me.txt仕入合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計.Height = 0.2755905!
        Me.txt仕入合計.Left = 4.744094!
        Me.txt仕入合計.Name = "txt仕入合計"
        Me.txt仕入合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入合計.Text = "999,999,999"
        Me.txt仕入合計.Top = 0.0!
        Me.txt仕入合計.Width = 1.003937!
        '
        'txt固定経費合計
        '
        Me.txt固定経費合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費合計.Height = 0.2755905!
        Me.txt固定経費合計.Left = 7.755906!
        Me.txt固定経費合計.Name = "txt固定経費合計"
        Me.txt固定経費合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt固定経費合計.Text = "999,999,999"
        Me.txt固定経費合計.Top = 0.0!
        Me.txt固定経費合計.Width = 1.023622!
        '
        'txt利益合計
        '
        Me.txt利益合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益合計.Height = 0.2755905!
        Me.txt利益合計.Left = 8.779528!
        Me.txt利益合計.Name = "txt利益合計"
        Me.txt利益合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt利益合計.Text = "999,999,999"
        Me.txt利益合計.Top = 0.0000001192093!
        Me.txt利益合計.Width = 1.043307!
        '
        'txt通数合計
        '
        Me.txt通数合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数合計.Height = 0.1377953!
        Me.txt通数合計.Left = 2.77559!
        Me.txt通数合計.Name = "txt通数合計"
        Me.txt通数合計.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt通数合計.Text = "999,999,999通"
        Me.txt通数合計.Top = 0.0!
        Me.txt通数合計.Width = 1.023622!
        '
        'txt通数m合計
        '
        Me.txt通数m合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m合計.Height = 0.1377953!
        Me.txt通数m合計.Left = 2.77559!
        Me.txt通数m合計.Name = "txt通数m合計"
        Me.txt通数m合計.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt通数m合計.Text = "999,999m"
        Me.txt通数m合計.Top = 0.137795!
        Me.txt通数m合計.Width = 1.023622!
        '
        'txt利益率合計
        '
        Me.txt利益率合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率合計.Height = 0.2755905!
        Me.txt利益率合計.Left = 9.822835!
        Me.txt利益率合計.Name = "txt利益率合計"
        Me.txt利益率合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt利益率合計.Text = "999.99"
        Me.txt利益率合計.Top = 0.0!
        Me.txt利益率合計.Width = 0.8464568!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt利益担当者計, Me.txt固定経費担当者計, Me.txt粗利担当者計, Me.txt諸経費担当者計, Me.txt売上担当者計, Me.TextBox30, Me.TextBox31, Me.txt仕入担当者計, Me.Label3, Me.txt通数担当者計, Me.txt通数m担当者計, Me.txt利益率担当者計})
        Me.GroupFooter1.Height = 0.2755905!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'txt利益担当者計
        '
        Me.txt利益担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益担当者計.Height = 0.2755905!
        Me.txt利益担当者計.Left = 8.779528!
        Me.txt利益担当者計.Name = "txt利益担当者計"
        Me.txt利益担当者計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt利益担当者計.Text = "999,999,999"
        Me.txt利益担当者計.Top = 0.0000001192093!
        Me.txt利益担当者計.Width = 1.043307!
        '
        'txt固定経費担当者計
        '
        Me.txt固定経費担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費担当者計.Height = 0.2755905!
        Me.txt固定経費担当者計.Left = 7.755906!
        Me.txt固定経費担当者計.Name = "txt固定経費担当者計"
        Me.txt固定経費担当者計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt固定経費担当者計.Text = "999,999,999"
        Me.txt固定経費担当者計.Top = 0.0!
        Me.txt固定経費担当者計.Width = 1.023622!
        '
        'txt粗利担当者計
        '
        Me.txt粗利担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利担当者計.Height = 0.2755905!
        Me.txt粗利担当者計.Left = 6.791339!
        Me.txt粗利担当者計.Name = "txt粗利担当者計"
        Me.txt粗利担当者計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt粗利担当者計.Text = "999,999,999"
        Me.txt粗利担当者計.Top = 0.0!
        Me.txt粗利担当者計.Width = 0.9645669!
        '
        'txt諸経費担当者計
        '
        Me.txt諸経費担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費担当者計.Height = 0.2755905!
        Me.txt諸経費担当者計.Left = 5.748032!
        Me.txt諸経費担当者計.Name = "txt諸経費担当者計"
        Me.txt諸経費担当者計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt諸経費担当者計.Text = "999,999,999"
        Me.txt諸経費担当者計.Top = 0.0!
        Me.txt諸経費担当者計.Width = 1.043307!
        '
        'txt売上担当者計
        '
        Me.txt売上担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上担当者計.Height = 0.2755905!
        Me.txt売上担当者計.Left = 3.799212!
        Me.txt売上担当者計.Name = "txt売上担当者計"
        Me.txt売上担当者計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt売上担当者計.Text = "999,999,999"
        Me.txt売上担当者計.Top = 0.0000005066395!
        Me.txt売上担当者計.Width = 0.9448819!
        '
        'TextBox30
        '
        Me.TextBox30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Height = 0.2755905!
        Me.TextBox30.Left = 0.6299213!
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox30.Text = Nothing
        Me.TextBox30.Top = 0.0000001192093!
        Me.TextBox30.Width = 2.145669!
        '
        'TextBox31
        '
        Me.TextBox31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Height = 0.2755905!
        Me.TextBox31.Left = 0.0!
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox31.Text = Nothing
        Me.TextBox31.Top = 0.00000005960464!
        Me.TextBox31.Width = 0.6299213!
        '
        'txt仕入担当者計
        '
        Me.txt仕入担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入担当者計.Height = 0.2755905!
        Me.txt仕入担当者計.Left = 4.744094!
        Me.txt仕入担当者計.Name = "txt仕入担当者計"
        Me.txt仕入担当者計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入担当者計.Text = "999,999,999"
        Me.txt仕入担当者計.Top = 0.0!
        Me.txt仕入担当者計.Width = 1.003937!
        '
        'Label3
        '
        Me.Label3.Height = 0.1771654!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 1.874016!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label3.Text = "＊担当者計"
        Me.Label3.Top = 0.03070866!
        Me.Label3.Width = 0.7874014!
        '
        'txt通数担当者計
        '
        Me.txt通数担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数担当者計.Height = 0.1377953!
        Me.txt通数担当者計.Left = 2.77559!
        Me.txt通数担当者計.Name = "txt通数担当者計"
        Me.txt通数担当者計.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt通数担当者計.Text = "999,999,999通"
        Me.txt通数担当者計.Top = 0.0!
        Me.txt通数担当者計.Width = 1.023622!
        '
        'txt通数m担当者計
        '
        Me.txt通数m担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m担当者計.Height = 0.1377953!
        Me.txt通数m担当者計.Left = 2.77559!
        Me.txt通数m担当者計.Name = "txt通数m担当者計"
        Me.txt通数m担当者計.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt通数m担当者計.Text = "999,999m"
        Me.txt通数m担当者計.Top = 0.137795!
        Me.txt通数m担当者計.Width = 1.023622!
        '
        'txt利益率担当者計
        '
        Me.txt利益率担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率担当者計.Height = 0.2755905!
        Me.txt利益率担当者計.Left = 9.822835!
        Me.txt利益率担当者計.Name = "txt利益率担当者計"
        Me.txt利益率担当者計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt利益率担当者計.Text = "999.99"
        Me.txt利益率担当者計.Top = 0.0!
        Me.txt利益率担当者計.Width = 0.8464568!
        '
        'StuffCustomerCost
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.68898!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.grpFtr計)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt仕入, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt粗利, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt諸経費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt売上, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt固定経費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt利益, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数m, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt利益率, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者別未引当一覧表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl粗利, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl諸経費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl売上, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl固定経費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl利益, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl担当者, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl利益率, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt粗利合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt諸経費合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt売上合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt固定経費合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt利益合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数m合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt利益率合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt利益担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt固定経費担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt粗利担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt諸経費担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt売上担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数m担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt利益率担当者計, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt仕入 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt粗利 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt諸経費 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt売上 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt対象年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者別未引当一覧表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl仕入 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先CD As DataDynamics.ActiveReports.Label
    Private WithEvents lbl通数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl諸経費 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl売上 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt粗利合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt諸経費合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt売上合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt固定経費 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl固定経費 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl粗利 As DataDynamics.ActiveReports.Label
    Private WithEvents txt固定経費合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt利益 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl利益 As DataDynamics.ActiveReports.Label
    Private WithEvents txt利益合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl担当者 As DataDynamics.ActiveReports.Label
    Private WithEvents txt担当者CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt通数m As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt通数合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt通数m合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt利益率 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl利益率 As DataDynamics.ActiveReports.Label
    Private WithEvents txt利益率合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt利益担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt固定経費担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt粗利担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt諸経費担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt売上担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox30 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox31 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents txt通数担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt通数m担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt利益率担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt受注区分 As DataDynamics.ActiveReports.TextBox
End Class
