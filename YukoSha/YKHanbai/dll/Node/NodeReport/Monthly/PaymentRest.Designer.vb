<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PaymentRest
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PaymentRest))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt現金振込 = New DataDynamics.ActiveReports.TextBox()
        Me.txt消費税額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前月残高 = New DataDynamics.ActiveReports.TextBox()
        Me.txt相殺その他 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月仕入 = New DataDynamics.ActiveReports.TextBox()
        Me.txt手形 = New DataDynamics.ActiveReports.TextBox()
        Me.txt繰越額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月総仕入額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月残高 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt対象年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt買掛残高一覧表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl現金振込 = New DataDynamics.ActiveReports.Label()
        Me.lbl消費税額 = New DataDynamics.ActiveReports.Label()
        Me.lbl前月残高 = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入先名 = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入先CD = New DataDynamics.ActiveReports.Label()
        Me.lbl相殺その他 = New DataDynamics.ActiveReports.Label()
        Me.lbl対象年月 = New DataDynamics.ActiveReports.Label()
        Me.lbl当月仕入 = New DataDynamics.ActiveReports.Label()
        Me.lbl手形 = New DataDynamics.ActiveReports.Label()
        Me.lbl繰越額 = New DataDynamics.ActiveReports.Label()
        Me.lbl当月総仕入額 = New DataDynamics.ActiveReports.Label()
        Me.txt並順 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl当月残高 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt消費税額合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月仕入合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt相殺その他合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入件数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt繰越額合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前月残高合計 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.txt手形合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt現金振込合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月総仕入合計額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月残高合計 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt現金振込, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前月残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt相殺その他, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月仕入, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt手形, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt繰越額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月総仕入額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt買掛残高一覧表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl現金振込, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl前月残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl相殺その他, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl当月仕入, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl手形, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl繰越額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl当月総仕入額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt並順, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl当月残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt消費税額合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月仕入合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt相殺その他合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt繰越額合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前月残高合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt手形合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt現金振込合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月総仕入合計額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月残高合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt現金振込, Me.txt消費税額, Me.txt前月残高, Me.txt相殺その他, Me.txt仕入先CD, Me.txt仕入先名, Me.txt当月仕入, Me.txt手形, Me.txt繰越額, Me.txt当月総仕入額, Me.txt当月残高})
        Me.Detail.Height = 0.2755905!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt現金振込
        '
        Me.txt現金振込.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込.Height = 0.2755905!
        Me.txt現金振込.Left = 3.444882!
        Me.txt現金振込.Name = "txt現金振込"
        Me.txt現金振込.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt現金振込.Text = "999,999,999"
        Me.txt現金振込.Top = 0.0!
        Me.txt現金振込.Width = 0.8661417!
        '
        'txt消費税額
        '
        Me.txt消費税額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額.Height = 0.2755905!
        Me.txt消費税額.Left = 7.933071!
        Me.txt消費税額.Name = "txt消費税額"
        Me.txt消費税額.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt消費税額.Text = "999,999,999"
        Me.txt消費税額.Top = 0.000001132488!
        Me.txt消費税額.Width = 0.8661417!
        '
        'txt前月残高
        '
        Me.txt前月残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前月残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前月残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前月残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前月残高.Height = 0.2755905!
        Me.txt前月残高.Left = 2.57874!
        Me.txt前月残高.Name = "txt前月残高"
        Me.txt前月残高.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt前月残高.Text = "999,999,999"
        Me.txt前月残高.Top = 0.000000178814!
        Me.txt前月残高.Width = 0.8661417!
        '
        'txt相殺その他
        '
        Me.txt相殺その他.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相殺その他.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相殺その他.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相殺その他.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相殺その他.Height = 0.2755905!
        Me.txt相殺その他.Left = 5.23622!
        Me.txt相殺その他.Name = "txt相殺その他"
        Me.txt相殺その他.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt相殺その他.Text = "999,999,999"
        Me.txt相殺その他.Top = 0.0000002980233!
        Me.txt相殺その他.Width = 0.8858268!
        '
        'txt仕入先CD
        '
        Me.txt仕入先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先CD.Height = 0.2755905!
        Me.txt仕入先CD.Left = 0.0!
        Me.txt仕入先CD.Name = "txt仕入先CD"
        Me.txt仕入先CD.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt仕入先CD.Text = "123456"
        Me.txt仕入先CD.Top = 0.00000005960464!
        Me.txt仕入先CD.Width = 0.5511811!
        '
        'txt仕入先名
        '
        Me.txt仕入先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Height = 0.2755905!
        Me.txt仕入先名.Left = 0.5511811!
        Me.txt仕入先名.Name = "txt仕入先名"
        Me.txt仕入先名.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: justify; vertical-align: bottom" & _
    "; ddo-char-set: 1"
        Me.txt仕入先名.Text = "あああああいいいいい"
        Me.txt仕入先名.Top = 0.0000001192093!
        Me.txt仕入先名.Width = 2.027559!
        '
        'txt当月仕入
        '
        Me.txt当月仕入.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月仕入.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月仕入.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月仕入.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月仕入.Height = 0.2755905!
        Me.txt当月仕入.Left = 7.027559!
        Me.txt当月仕入.Name = "txt当月仕入"
        Me.txt当月仕入.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月仕入.Text = "999,999,999"
        Me.txt当月仕入.Top = 0.0000002980233!
        Me.txt当月仕入.Width = 0.9055118!
        '
        'txt手形
        '
        Me.txt手形.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形.Height = 0.2755905!
        Me.txt手形.Left = 4.311024!
        Me.txt手形.Name = "txt手形"
        Me.txt手形.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt手形.Text = "999,999,999"
        Me.txt手形.Top = 0.0000002980233!
        Me.txt手形.Width = 0.9251968!
        '
        'txt繰越額
        '
        Me.txt繰越額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越額.Height = 0.2755905!
        Me.txt繰越額.Left = 6.122047!
        Me.txt繰越額.Name = "txt繰越額"
        Me.txt繰越額.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt繰越額.Text = "999,999,999"
        Me.txt繰越額.Top = 0.0000005066395!
        Me.txt繰越額.Width = 0.9055118!
        '
        'txt当月総仕入額
        '
        Me.txt当月総仕入額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月総仕入額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月総仕入額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月総仕入額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月総仕入額.Height = 0.2755905!
        Me.txt当月総仕入額.Left = 8.799212!
        Me.txt当月総仕入額.Name = "txt当月総仕入額"
        Me.txt当月総仕入額.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月総仕入額.Text = "999,999,999"
        Me.txt当月総仕入額.Top = 0.0!
        Me.txt当月総仕入額.Width = 0.9055118!
        '
        'txt当月残高
        '
        Me.txt当月残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高.Height = 0.2755906!
        Me.txt当月残高.Left = 9.704724!
        Me.txt当月残高.Name = "txt当月残高"
        Me.txt当月残高.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月残高.Text = "999,999,999"
        Me.txt当月残高.Top = 0.0!
        Me.txt当月残高.Width = 0.9055118!
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
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt対象年月, Me.txt買掛残高一覧表, Me.lbl現金振込, Me.lbl消費税額, Me.lbl前月残高, Me.lbl仕入先名, Me.lbl仕入先CD, Me.lbl相殺その他, Me.lbl対象年月, Me.lbl当月仕入, Me.lbl手形, Me.lbl繰越額, Me.lbl当月総仕入額, Me.txt並順, Me.lbl当月残高})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.9992127!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txt対象年月
        '
        Me.txt対象年月.Height = 0.2362205!
        Me.txt対象年月.Left = 0.7874014!
        Me.txt対象年月.Name = "txt対象年月"
        Me.txt対象年月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対象年月.Text = "YY/MM月分"
        Me.txt対象年月.Top = 0.0!
        Me.txt対象年月.Width = 1.181102!
        '
        'txt買掛残高一覧表
        '
        Me.txt買掛残高一覧表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt買掛残高一覧表.CharacterSpacing = 10.0!
        Me.txt買掛残高一覧表.Height = 0.2362205!
        Me.txt買掛残高一覧表.Left = 4.514174!
        Me.txt買掛残高一覧表.Name = "txt買掛残高一覧表"
        Me.txt買掛残高一覧表.Style = "font-family: ＭＳ Ｐゴシック; font-size: 14pt; font-weight: bold; text-align: center; ve" & _
    "rtical-align: bottom; ddo-char-set: 1"
        Me.txt買掛残高一覧表.Text = "買掛残高一覧表"
        Me.txt買掛残高一覧表.Top = 0.1968504!
        Me.txt買掛残高一覧表.Width = 2.440945!
        '
        'lbl現金振込
        '
        Me.lbl現金振込.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl現金振込.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl現金振込.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl現金振込.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl現金振込.Height = 0.3346457!
        Me.lbl現金振込.HyperLink = Nothing
        Me.lbl現金振込.Left = 3.444882!
        Me.lbl現金振込.Name = "lbl現金振込"
        Me.lbl現金振込.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl現金振込.Text = "現金・振込"
        Me.lbl現金振込.Top = 0.664567!
        Me.lbl現金振込.Width = 0.8661417!
        '
        'lbl消費税額
        '
        Me.lbl消費税額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額.Height = 0.3346457!
        Me.lbl消費税額.HyperLink = Nothing
        Me.lbl消費税額.Left = 7.933071!
        Me.lbl消費税額.Name = "lbl消費税額"
        Me.lbl消費税額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl消費税額.Text = "消費税額"
        Me.lbl消費税額.Top = 0.664567!
        Me.lbl消費税額.Width = 0.8661417!
        '
        'lbl前月残高
        '
        Me.lbl前月残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前月残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前月残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前月残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前月残高.Height = 0.3346457!
        Me.lbl前月残高.HyperLink = Nothing
        Me.lbl前月残高.Left = 2.578741!
        Me.lbl前月残高.Name = "lbl前月残高"
        Me.lbl前月残高.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl前月残高.Text = "前月残高"
        Me.lbl前月残高.Top = 0.664567!
        Me.lbl前月残高.Width = 0.8661417!
        '
        'lbl仕入先名
        '
        Me.lbl仕入先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.CharacterSpacing = 10.0!
        Me.lbl仕入先名.Height = 0.3346457!
        Me.lbl仕入先名.HyperLink = Nothing
        Me.lbl仕入先名.Left = 0.5511816!
        Me.lbl仕入先名.Name = "lbl仕入先名"
        Me.lbl仕入先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbl仕入先名.Text = "仕入先名"
        Me.lbl仕入先名.Top = 0.664567!
        Me.lbl仕入先名.Width = 2.027559!
        '
        'lbl仕入先CD
        '
        Me.lbl仕入先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先CD.Height = 0.3346457!
        Me.lbl仕入先CD.HyperLink = Nothing
        Me.lbl仕入先CD.Left = 0.0000004768372!
        Me.lbl仕入先CD.Name = "lbl仕入先CD"
        Me.lbl仕入先CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl仕入先CD.Text = "仕入先" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ｺｰﾄﾞ"
        Me.lbl仕入先CD.Top = 0.664567!
        Me.lbl仕入先CD.Width = 0.5511811!
        '
        'lbl相殺その他
        '
        Me.lbl相殺その他.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl相殺その他.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl相殺その他.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl相殺その他.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl相殺その他.Height = 0.3346457!
        Me.lbl相殺その他.HyperLink = Nothing
        Me.lbl相殺その他.Left = 5.236221!
        Me.lbl相殺その他.Name = "lbl相殺その他"
        Me.lbl相殺その他.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl相殺その他.Text = "相殺・その他"
        Me.lbl相殺その他.Top = 0.664567!
        Me.lbl相殺その他.Width = 0.8858268!
        '
        'lbl対象年月
        '
        Me.lbl対象年月.Height = 0.2362205!
        Me.lbl対象年月.HyperLink = Nothing
        Me.lbl対象年月.Left = 0.0!
        Me.lbl対象年月.Name = "lbl対象年月"
        Me.lbl対象年月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl対象年月.Text = "対象年月"
        Me.lbl対象年月.Top = 0.0!
        Me.lbl対象年月.Width = 0.7874014!
        '
        'lbl当月仕入
        '
        Me.lbl当月仕入.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月仕入.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月仕入.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月仕入.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月仕入.Height = 0.3346457!
        Me.lbl当月仕入.HyperLink = Nothing
        Me.lbl当月仕入.Left = 7.027559!
        Me.lbl当月仕入.Name = "lbl当月仕入"
        Me.lbl当月仕入.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl当月仕入.Text = "当月仕入"
        Me.lbl当月仕入.Top = 0.664567!
        Me.lbl当月仕入.Width = 0.9055118!
        '
        'lbl手形
        '
        Me.lbl手形.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl手形.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl手形.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl手形.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl手形.CharacterSpacing = 10.0!
        Me.lbl手形.Height = 0.3346457!
        Me.lbl手形.HyperLink = Nothing
        Me.lbl手形.Left = 4.311024!
        Me.lbl手形.Name = "lbl手形"
        Me.lbl手形.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl手形.Text = "手形"
        Me.lbl手形.Top = 0.664567!
        Me.lbl手形.Width = 0.9251968!
        '
        'lbl繰越額
        '
        Me.lbl繰越額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl繰越額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl繰越額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl繰越額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl繰越額.CharacterSpacing = 5.0!
        Me.lbl繰越額.Height = 0.3346457!
        Me.lbl繰越額.HyperLink = Nothing
        Me.lbl繰越額.Left = 6.122047!
        Me.lbl繰越額.Name = "lbl繰越額"
        Me.lbl繰越額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl繰越額.Text = "繰越額"
        Me.lbl繰越額.Top = 0.664567!
        Me.lbl繰越額.Width = 0.9055118!
        '
        'lbl当月総仕入額
        '
        Me.lbl当月総仕入額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月総仕入額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月総仕入額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月総仕入額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月総仕入額.Height = 0.3346457!
        Me.lbl当月総仕入額.HyperLink = Nothing
        Me.lbl当月総仕入額.Left = 8.799212!
        Me.lbl当月総仕入額.Name = "lbl当月総仕入額"
        Me.lbl当月総仕入額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl当月総仕入額.Text = "当月総仕入額"
        Me.lbl当月総仕入額.Top = 0.664567!
        Me.lbl当月総仕入額.Width = 0.9055118!
        '
        'txt並順
        '
        Me.txt並順.Height = 0.2362205!
        Me.txt並順.Left = 8.543307!
        Me.txt並順.Name = "txt並順"
        Me.txt並順.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt並順.Text = "(●●順)"
        Me.txt並順.Top = 0.1968504!
        Me.txt並順.Width = 0.7874016!
        '
        'lbl当月残高
        '
        Me.lbl当月残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月残高.Height = 0.3346457!
        Me.lbl当月残高.HyperLink = Nothing
        Me.lbl当月残高.Left = 9.704724!
        Me.lbl当月残高.Name = "lbl当月残高"
        Me.lbl当月残高.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl当月残高.Text = "当月残高"
        Me.lbl当月残高.Top = 0.6661418!
        Me.lbl当月残高.Width = 0.9055118!
        '
        'grpFtr計
        '
        Me.grpFtr計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt消費税額合計, Me.txt当月仕入合計, Me.txt相殺その他合計, Me.txt仕入件数, Me.txt繰越額合計, Me.txt前月残高合計, Me.Label2, Me.TextBox19, Me.txt手形合計, Me.txt現金振込合計, Me.txt当月総仕入合計額, Me.txt当月残高合計})
        Me.grpFtr計.Height = 0.2755905!
        Me.grpFtr計.Name = "grpFtr計"
        '
        'txt消費税額合計
        '
        Me.txt消費税額合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額合計.Height = 0.2755905!
        Me.txt消費税額合計.Left = 7.933071!
        Me.txt消費税額合計.Name = "txt消費税額合計"
        Me.txt消費税額合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt消費税額合計.Text = "999,999,999"
        Me.txt消費税額合計.Top = 0.0!
        Me.txt消費税額合計.Width = 0.8661417!
        '
        'txt当月仕入合計
        '
        Me.txt当月仕入合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月仕入合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月仕入合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月仕入合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月仕入合計.Height = 0.2755905!
        Me.txt当月仕入合計.Left = 7.027559!
        Me.txt当月仕入合計.Name = "txt当月仕入合計"
        Me.txt当月仕入合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月仕入合計.Text = "999,999,999"
        Me.txt当月仕入合計.Top = 0.0000002980233!
        Me.txt当月仕入合計.Width = 0.9055118!
        '
        'txt相殺その他合計
        '
        Me.txt相殺その他合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相殺その他合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相殺その他合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相殺その他合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相殺その他合計.Height = 0.2755905!
        Me.txt相殺その他合計.Left = 5.23622!
        Me.txt相殺その他合計.Name = "txt相殺その他合計"
        Me.txt相殺その他合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt相殺その他合計.Text = "999,999,999"
        Me.txt相殺その他合計.Top = 0.0000002980233!
        Me.txt相殺その他合計.Width = 0.8858268!
        '
        'txt仕入件数
        '
        Me.txt仕入件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入件数.Height = 0.2755905!
        Me.txt仕入件数.Left = 0.5511811!
        Me.txt仕入件数.Name = "txt仕入件数"
        Me.txt仕入件数.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入件数.Text = "件"
        Me.txt仕入件数.Top = 0.0000001192093!
        Me.txt仕入件数.Width = 2.027559!
        '
        'txt繰越額合計
        '
        Me.txt繰越額合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越額合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越額合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越額合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越額合計.Height = 0.2755905!
        Me.txt繰越額合計.Left = 6.122047!
        Me.txt繰越額合計.Name = "txt繰越額合計"
        Me.txt繰越額合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt繰越額合計.Text = "999,999,999"
        Me.txt繰越額合計.Top = 0.0000005066395!
        Me.txt繰越額合計.Width = 0.9055118!
        '
        'txt前月残高合計
        '
        Me.txt前月残高合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前月残高合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前月残高合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前月残高合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前月残高合計.Height = 0.2755905!
        Me.txt前月残高合計.Left = 2.57874!
        Me.txt前月残高合計.Name = "txt前月残高合計"
        Me.txt前月残高合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt前月残高合計.Text = "999,999,999"
        Me.txt前月残高合計.Top = 0.0!
        Me.txt前月残高合計.Width = 0.8661417!
        '
        'Label2
        '
        Me.Label2.Height = 0.1771654!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.9582678!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label2.Text = "＊総合計"
        Me.Label2.Top = 0.05118111!
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
        Me.TextBox19.Width = 0.5511811!
        '
        'txt手形合計
        '
        Me.txt手形合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形合計.Height = 0.2755905!
        Me.txt手形合計.Left = 4.311024!
        Me.txt手形合計.Name = "txt手形合計"
        Me.txt手形合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt手形合計.Text = "999,999,999"
        Me.txt手形合計.Top = 0.0!
        Me.txt手形合計.Width = 0.9251968!
        '
        'txt現金振込合計
        '
        Me.txt現金振込合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込合計.Height = 0.2755905!
        Me.txt現金振込合計.Left = 3.444882!
        Me.txt現金振込合計.Name = "txt現金振込合計"
        Me.txt現金振込合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt現金振込合計.Text = "999,999,999"
        Me.txt現金振込合計.Top = 0.0!
        Me.txt現金振込合計.Width = 0.8661417!
        '
        'txt当月総仕入合計額
        '
        Me.txt当月総仕入合計額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月総仕入合計額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月総仕入合計額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月総仕入合計額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月総仕入合計額.Height = 0.2755905!
        Me.txt当月総仕入合計額.Left = 8.799212!
        Me.txt当月総仕入合計額.Name = "txt当月総仕入合計額"
        Me.txt当月総仕入合計額.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月総仕入合計額.Text = "999,999,999"
        Me.txt当月総仕入合計額.Top = 0.0!
        Me.txt当月総仕入合計額.Width = 0.9055118!
        '
        'txt当月残高合計
        '
        Me.txt当月残高合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高合計.Height = 0.2755906!
        Me.txt当月残高合計.Left = 9.704724!
        Me.txt当月残高合計.Name = "txt当月残高合計"
        Me.txt当月残高合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月残高合計.Text = "999,999,999"
        Me.txt当月残高合計.Top = 0.0!
        Me.txt当月残高合計.Width = 0.9055118!
        '
        'PaymentRest
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.61024!
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
        CType(Me.txt現金振込, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前月残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt相殺その他, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月仕入, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt手形, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt繰越額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月総仕入額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt買掛残高一覧表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl現金振込, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl前月残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl相殺その他, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl当月仕入, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl手形, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl繰越額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl当月総仕入額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt並順, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl当月残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt消費税額合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月仕入合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt相殺その他合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt繰越額合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前月残高合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt手形合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt現金振込合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月総仕入合計額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月残高合計, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt現金振込 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt消費税額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前月残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt相殺その他 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当月仕入 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt手形 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt繰越額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt対象年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt買掛残高一覧表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl現金振込 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl前月残高 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl仕入先名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl仕入先CD As DataDynamics.ActiveReports.Label
    Private WithEvents lbl相殺その他 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl対象年月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl当月仕入 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl手形 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl繰越額 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt消費税額合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当月仕入合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt相殺その他合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt繰越額合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前月残高合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt手形合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt現金振込合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当月総仕入額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl当月総仕入額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl消費税額 As DataDynamics.ActiveReports.Label
    Private WithEvents txt当月総仕入合計額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt並順 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当月残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl当月残高 As DataDynamics.ActiveReports.Label
    Private WithEvents txt当月残高合計 As DataDynamics.ActiveReports.TextBox
End Class
