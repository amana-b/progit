<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class BillList
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(BillList))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt得意先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt消費税額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt繰越 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt税込売上合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前回請求 = New DataDynamics.ActiveReports.TextBox()
        Me.txt手形 = New DataDynamics.ActiveReports.TextBox()
        Me.txt今回請求金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt今回売上 = New DataDynamics.ActiveReports.TextBox()
        Me.txt現金振込 = New DataDynamics.ActiveReports.TextBox()
        Me.txt相殺その他 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt対象年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt請求一覧表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl得意先CD = New DataDynamics.ActiveReports.Label()
        Me.lbl消費税額 = New DataDynamics.ActiveReports.Label()
        Me.lbl繰越 = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先名 = New DataDynamics.ActiveReports.Label()
        Me.ｌｂｌ税込売上合計 = New DataDynamics.ActiveReports.Label()
        Me.lbl今回請求金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl手形 = New DataDynamics.ActiveReports.Label()
        Me.lbl前回請求 = New DataDynamics.ActiveReports.Label()
        Me.lbl対象年月 = New DataDynamics.ActiveReports.Label()
        Me.lbl今回売上 = New DataDynamics.ActiveReports.Label()
        Me.lbl現金振込 = New DataDynamics.ActiveReports.Label()
        Me.lbl相殺その他 = New DataDynamics.ActiveReports.Label()
        Me.txt締日 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl締日 = New DataDynamics.ActiveReports.Label()
        Me.txtｺｰﾄﾞ並順 = New DataDynamics.ActiveReports.TextBox()
        Me.grpFtr総合計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt前回請求総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt手形総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt今回請求総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt税込売上総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕上日計件数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt繰越総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.消費税総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.txt今回売上総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt現金振込総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt相殺その他総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt繰越, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt税込売上合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前回請求, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt手形, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt今回請求金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt今回売上, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt現金振込, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt相殺その他, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求一覧表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl繰越, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ｌｂｌ税込売上合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl今回請求金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl手形, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl前回請求, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl今回売上, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl現金振込, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl相殺その他, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt締日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl締日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtｺｰﾄﾞ並順, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前回請求総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt手形総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt今回請求総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt税込売上総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕上日計件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt繰越総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.消費税総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt今回売上総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt現金振込総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt相殺その他総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt得意先CD, Me.txt消費税額, Me.txt繰越, Me.txt得意先名, Me.txt税込売上合計, Me.txt前回請求, Me.txt手形, Me.txt今回請求金額, Me.txt今回売上, Me.txt現金振込, Me.txt相殺その他})
        Me.Detail.Height = 0.2755905!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
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
        Me.txt得意先CD.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt得意先CD.Text = "123456"
        Me.txt得意先CD.Top = 0.0!
        Me.txt得意先CD.Width = 0.6299213!
        '
        'txt消費税額
        '
        Me.txt消費税額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額.Height = 0.2755905!
        Me.txt消費税額.Left = 7.972441!
        Me.txt消費税額.Name = "txt消費税額"
        Me.txt消費税額.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt消費税額.Text = "999,999,999"
        Me.txt消費税額.Top = 0.000001132488!
        Me.txt消費税額.Width = 0.8661417!
        '
        'txt繰越
        '
        Me.txt繰越.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越.Height = 0.2755905!
        Me.txt繰越.Left = 6.240158!
        Me.txt繰越.Name = "txt繰越"
        Me.txt繰越.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt繰越.Text = "999,999,999"
        Me.txt繰越.Top = 0.000001490116!
        Me.txt繰越.Width = 0.8661417!
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
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txt得意先名.Text = "あああああいいいいいううううう"
        Me.txt得意先名.Top = 0.0000001788139!
        Me.txt得意先名.Width = 2.125984!
        '
        'txt税込売上合計
        '
        Me.txt税込売上合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込売上合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込売上合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込売上合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込売上合計.Height = 0.2755905!
        Me.txt税込売上合計.Left = 8.838583!
        Me.txt税込売上合計.Name = "txt税込売上合計"
        Me.txt税込売上合計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt税込売上合計.Text = "999,999,999"
        Me.txt税込売上合計.Top = 0.0000001788139!
        Me.txt税込売上合計.Width = 0.8661417!
        '
        'txt前回請求
        '
        Me.txt前回請求.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回請求.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回請求.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回請求.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回請求.Height = 0.2755905!
        Me.txt前回請求.Left = 2.755906!
        Me.txt前回請求.Name = "txt前回請求"
        Me.txt前回請求.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt前回請求.Text = "999,999,999"
        Me.txt前回請求.Top = 0.0!
        Me.txt前回請求.Width = 0.8858268!
        '
        'txt手形
        '
        Me.txt手形.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形.Height = 0.2755905!
        Me.txt手形.Left = 4.507874!
        Me.txt手形.Name = "txt手形"
        Me.txt手形.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt手形.Text = "999,999,999"
        Me.txt手形.Top = 0.0!
        Me.txt手形.Width = 0.8661417!
        '
        'txt今回請求金額
        '
        Me.txt今回請求金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回請求金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回請求金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回請求金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回請求金額.Height = 0.2755905!
        Me.txt今回請求金額.Left = 9.704724!
        Me.txt今回請求金額.Name = "txt今回請求金額"
        Me.txt今回請求金額.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt今回請求金額.Text = "999,999,999"
        Me.txt今回請求金額.Top = 0.0!
        Me.txt今回請求金額.Width = 0.8661417!
        '
        'txt今回売上
        '
        Me.txt今回売上.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上.Height = 0.2755905!
        Me.txt今回売上.Left = 7.106299!
        Me.txt今回売上.Name = "txt今回売上"
        Me.txt今回売上.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt今回売上.Text = "999,999,999"
        Me.txt今回売上.Top = 0.0000001788139!
        Me.txt今回売上.Width = 0.8661417!
        '
        'txt現金振込
        '
        Me.txt現金振込.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込.Height = 0.2755905!
        Me.txt現金振込.Left = 3.641732!
        Me.txt現金振込.Name = "txt現金振込"
        Me.txt現金振込.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt現金振込.Text = "999,999,999"
        Me.txt現金振込.Top = 0.0!
        Me.txt現金振込.Width = 0.8661417!
        '
        'txt相殺その他
        '
        Me.txt相殺その他.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相殺その他.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相殺その他.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相殺その他.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相殺その他.Height = 0.2755905!
        Me.txt相殺その他.Left = 5.374016!
        Me.txt相殺その他.Name = "txt相殺その他"
        Me.txt相殺その他.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt相殺その他.Text = "999,999,999"
        Me.txt相殺その他.Top = 0.0!
        Me.txt相殺その他.Width = 0.8661417!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNow, Me.txt頁})
        Me.PageHeader.Height = 0.2755905!
        Me.PageHeader.Name = "PageHeader"
        '
        'txtNow
        '
        Me.txtNow.Height = 0.2362205!
        Me.txtNow.Left = 8.188977!
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
        Me.txt頁.Left = 10.33269!
        Me.txt頁.Name = "txt頁"
        Me.txt頁.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt頁.Text = "頁"
        Me.txt頁.Top = 0.0!
        Me.txt頁.Width = 0.3795285!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdr
        '
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt対象年月, Me.txt請求一覧表, Me.lbl得意先CD, Me.lbl消費税額, Me.lbl繰越, Me.lbl得意先名, Me.ｌｂｌ税込売上合計, Me.lbl今回請求金額, Me.lbl手形, Me.lbl前回請求, Me.lbl対象年月, Me.lbl今回売上, Me.lbl現金振込, Me.lbl相殺その他, Me.txt締日, Me.lbl締日, Me.txtｺｰﾄﾞ並順})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 1.045669!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txt対象年月
        '
        Me.txt対象年月.Height = 0.2362205!
        Me.txt対象年月.Left = 0.7874014!
        Me.txt対象年月.Name = "txt対象年月"
        Me.txt対象年月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt対象年月.Text = "99/99月分"
        Me.txt対象年月.Top = 0.0!
        Me.txt対象年月.Width = 1.119292!
        '
        'txt請求一覧表
        '
        Me.txt請求一覧表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt請求一覧表.Height = 0.2362205!
        Me.txt請求一覧表.Left = 4.065748!
        Me.txt請求一覧表.Name = "txt請求一覧表"
        Me.txt請求一覧表.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt請求一覧表.Text = "請 求 一 覧 表"
        Me.txt請求一覧表.Top = 0.08110237!
        Me.txt請求一覧表.Width = 2.681497!
        '
        'lbl得意先CD
        '
        Me.lbl得意先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Height = 0.3346457!
        Me.lbl得意先CD.HyperLink = Nothing
        Me.lbl得意先CD.Left = 0.0!
        Me.lbl得意先CD.Name = "lbl得意先CD"
        Me.lbl得意先CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl得意先CD.Text = "得意先ｺｰﾄﾞ"
        Me.lbl得意先CD.Top = 0.7110237!
        Me.lbl得意先CD.Width = 0.6299213!
        '
        'lbl消費税額
        '
        Me.lbl消費税額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額.Height = 0.3346457!
        Me.lbl消費税額.HyperLink = Nothing
        Me.lbl消費税額.Left = 7.972441!
        Me.lbl消費税額.Name = "lbl消費税額"
        Me.lbl消費税額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl消費税額.Text = "消費税額"
        Me.lbl消費税額.Top = 0.7110235!
        Me.lbl消費税額.Width = 0.8661417!
        '
        'lbl繰越
        '
        Me.lbl繰越.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl繰越.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl繰越.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl繰越.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl繰越.Height = 0.3346457!
        Me.lbl繰越.HyperLink = Nothing
        Me.lbl繰越.Left = 6.240158!
        Me.lbl繰越.Name = "lbl繰越"
        Me.lbl繰越.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl繰越.Text = "繰越"
        Me.lbl繰越.Top = 0.7110235!
        Me.lbl繰越.Width = 0.8661418!
        '
        'lbl得意先名
        '
        Me.lbl得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Height = 0.3346457!
        Me.lbl得意先名.HyperLink = Nothing
        Me.lbl得意先名.Left = 0.6299213!
        Me.lbl得意先名.Name = "lbl得意先名"
        Me.lbl得意先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl得意先名.Text = "得　意　先　名"
        Me.lbl得意先名.Top = 0.7110237!
        Me.lbl得意先名.Width = 2.125984!
        '
        'ｌｂｌ税込売上合計
        '
        Me.ｌｂｌ税込売上合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ税込売上合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ税込売上合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ税込売上合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ税込売上合計.Height = 0.3346457!
        Me.ｌｂｌ税込売上合計.HyperLink = Nothing
        Me.ｌｂｌ税込売上合計.Left = 8.838583!
        Me.ｌｂｌ税込売上合計.Name = "ｌｂｌ税込売上合計"
        Me.ｌｂｌ税込売上合計.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.ｌｂｌ税込売上合計.Text = "税込売上合計"
        Me.ｌｂｌ税込売上合計.Top = 0.7110235!
        Me.ｌｂｌ税込売上合計.Width = 0.8661417!
        '
        'lbl今回請求金額
        '
        Me.lbl今回請求金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回請求金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回請求金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回請求金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回請求金額.Height = 0.3346457!
        Me.lbl今回請求金額.HyperLink = Nothing
        Me.lbl今回請求金額.Left = 9.704724!
        Me.lbl今回請求金額.Name = "lbl今回請求金額"
        Me.lbl今回請求金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl今回請求金額.Text = "今回請求金額"
        Me.lbl今回請求金額.Top = 0.7110237!
        Me.lbl今回請求金額.Width = 0.8661417!
        '
        'lbl手形
        '
        Me.lbl手形.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl手形.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl手形.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl手形.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl手形.Height = 0.3346457!
        Me.lbl手形.HyperLink = Nothing
        Me.lbl手形.Left = 4.507874!
        Me.lbl手形.Name = "lbl手形"
        Me.lbl手形.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7.5pt; text-align: center; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.lbl手形.Text = "手形"
        Me.lbl手形.Top = 0.7110237!
        Me.lbl手形.Width = 0.8661417!
        '
        'lbl前回請求
        '
        Me.lbl前回請求.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前回請求.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前回請求.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前回請求.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前回請求.Height = 0.3346457!
        Me.lbl前回請求.HyperLink = Nothing
        Me.lbl前回請求.Left = 2.755906!
        Me.lbl前回請求.Name = "lbl前回請求"
        Me.lbl前回請求.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl前回請求.Text = "前回請求"
        Me.lbl前回請求.Top = 0.7110235!
        Me.lbl前回請求.Width = 0.8858268!
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
        'lbl今回売上
        '
        Me.lbl今回売上.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回売上.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回売上.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回売上.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回売上.Height = 0.3346457!
        Me.lbl今回売上.HyperLink = Nothing
        Me.lbl今回売上.Left = 7.106299!
        Me.lbl今回売上.Name = "lbl今回売上"
        Me.lbl今回売上.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl今回売上.Text = "今回売上"
        Me.lbl今回売上.Top = 0.7110237!
        Me.lbl今回売上.Width = 0.8661417!
        '
        'lbl現金振込
        '
        Me.lbl現金振込.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl現金振込.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl現金振込.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl現金振込.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl現金振込.Height = 0.3346457!
        Me.lbl現金振込.HyperLink = Nothing
        Me.lbl現金振込.Left = 3.641732!
        Me.lbl現金振込.Name = "lbl現金振込"
        Me.lbl現金振込.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl現金振込.Text = "現金・振込"
        Me.lbl現金振込.Top = 0.7110235!
        Me.lbl現金振込.Width = 0.8661417!
        '
        'lbl相殺その他
        '
        Me.lbl相殺その他.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl相殺その他.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl相殺その他.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl相殺その他.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl相殺その他.Height = 0.3346457!
        Me.lbl相殺その他.HyperLink = Nothing
        Me.lbl相殺その他.Left = 5.374016!
        Me.lbl相殺その他.Name = "lbl相殺その他"
        Me.lbl相殺その他.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl相殺その他.Text = "相殺・その他"
        Me.lbl相殺その他.Top = 0.7110233!
        Me.lbl相殺その他.Width = 0.8661417!
        '
        'txt締日
        '
        Me.txt締日.Height = 0.2362205!
        Me.txt締日.Left = 0.7874014!
        Me.txt締日.Name = "txt締日"
        Me.txt締日.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt締日.Text = "99日締"
        Me.txt締日.Top = 0.3362205!
        Me.txt締日.Width = 1.119292!
        '
        'lbl締日
        '
        Me.lbl締日.Height = 0.2362205!
        Me.lbl締日.HyperLink = Nothing
        Me.lbl締日.Left = 0.0!
        Me.lbl締日.Name = "lbl締日"
        Me.lbl締日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl締日.Text = "締日"
        Me.lbl締日.Top = 0.3362205!
        Me.lbl締日.Width = 0.7874014!
        '
        'txtｺｰﾄﾞ並順
        '
        Me.txtｺｰﾄﾞ並順.Height = 0.2362205!
        Me.txtｺｰﾄﾞ並順.Left = 9.296457!
        Me.txtｺｰﾄﾞ並順.Name = "txtｺｰﾄﾞ並順"
        Me.txtｺｰﾄﾞ並順.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txtｺｰﾄﾞ並順.Text = "あああ順"
        Me.txtｺｰﾄﾞ並順.Top = 0.2125984!
        Me.txtｺｰﾄﾞ並順.Width = 1.119292!
        '
        'grpFtr総合計
        '
        Me.grpFtr総合計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt前回請求総合計, Me.txt手形総合計, Me.txt今回請求総合計, Me.txt税込売上総合計, Me.txt仕上日計件数, Me.txt繰越総合計, Me.消費税総合計, Me.TextBox9, Me.txt今回売上総合計, Me.txt現金振込総合計, Me.txt相殺その他総合計, Me.Label3})
        Me.grpFtr総合計.Height = 0.2755905!
        Me.grpFtr総合計.Name = "grpFtr総合計"
        '
        'txt前回請求総合計
        '
        Me.txt前回請求総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回請求総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回請求総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回請求総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回請求総合計.Height = 0.2755905!
        Me.txt前回請求総合計.Left = 2.755906!
        Me.txt前回請求総合計.Name = "txt前回請求総合計"
        Me.txt前回請求総合計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt前回請求総合計.Text = "999,999,999"
        Me.txt前回請求総合計.Top = 0.0!
        Me.txt前回請求総合計.Width = 0.8858268!
        '
        'txt手形総合計
        '
        Me.txt手形総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形総合計.Height = 0.2755905!
        Me.txt手形総合計.Left = 4.507874!
        Me.txt手形総合計.Name = "txt手形総合計"
        Me.txt手形総合計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt手形総合計.Text = "999,999,999"
        Me.txt手形総合計.Top = 0.0!
        Me.txt手形総合計.Width = 0.8661417!
        '
        'txt今回請求総合計
        '
        Me.txt今回請求総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回請求総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回請求総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回請求総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回請求総合計.Height = 0.2755905!
        Me.txt今回請求総合計.Left = 9.704724!
        Me.txt今回請求総合計.Name = "txt今回請求総合計"
        Me.txt今回請求総合計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt今回請求総合計.Text = "999,999,999" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt今回請求総合計.Top = 0.0!
        Me.txt今回請求総合計.Width = 0.8661417!
        '
        'txt税込売上総合計
        '
        Me.txt税込売上総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込売上総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込売上総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込売上総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込売上総合計.Height = 0.2755905!
        Me.txt税込売上総合計.Left = 8.838583!
        Me.txt税込売上総合計.Name = "txt税込売上総合計"
        Me.txt税込売上総合計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt税込売上総合計.Text = "999,999,999"
        Me.txt税込売上総合計.Top = 0.0!
        Me.txt税込売上総合計.Width = 0.8661417!
        '
        'txt仕上日計件数
        '
        Me.txt仕上日計件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕上日計件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕上日計件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕上日計件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕上日計件数.Height = 0.2755905!
        Me.txt仕上日計件数.Left = 0.6299213!
        Me.txt仕上日計件数.Name = "txt仕上日計件数"
        Me.txt仕上日計件数.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt仕上日計件数.Text = "件"
        Me.txt仕上日計件数.Top = 0.0!
        Me.txt仕上日計件数.Width = 2.125984!
        '
        'txt繰越総合計
        '
        Me.txt繰越総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越総合計.Height = 0.2755905!
        Me.txt繰越総合計.Left = 6.240158!
        Me.txt繰越総合計.Name = "txt繰越総合計"
        Me.txt繰越総合計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt繰越総合計.Text = "999,999,999"
        Me.txt繰越総合計.Top = 0.0!
        Me.txt繰越総合計.Width = 0.8661417!
        '
        '消費税総合計
        '
        Me.消費税総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.消費税総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.消費税総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.消費税総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.消費税総合計.Height = 0.2755905!
        Me.消費税総合計.Left = 7.972441!
        Me.消費税総合計.Name = "消費税総合計"
        Me.消費税総合計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.消費税総合計.Text = "999,999,999"
        Me.消費税総合計.Top = 0.0!
        Me.消費税総合計.Width = 0.8661417!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Height = 0.2755905!
        Me.TextBox9.Left = 0.0!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0.0!
        Me.TextBox9.Width = 0.6299213!
        '
        'txt今回売上総合計
        '
        Me.txt今回売上総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上総合計.Height = 0.2755905!
        Me.txt今回売上総合計.Left = 7.106299!
        Me.txt今回売上総合計.Name = "txt今回売上総合計"
        Me.txt今回売上総合計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt今回売上総合計.Text = "999,999,999"
        Me.txt今回売上総合計.Top = 0.0000001788139!
        Me.txt今回売上総合計.Width = 0.8661418!
        '
        'txt現金振込総合計
        '
        Me.txt現金振込総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込総合計.Height = 0.2755905!
        Me.txt現金振込総合計.Left = 3.641732!
        Me.txt現金振込総合計.Name = "txt現金振込総合計"
        Me.txt現金振込総合計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt現金振込総合計.Text = "999,999,999"
        Me.txt現金振込総合計.Top = 0.0!
        Me.txt現金振込総合計.Width = 0.8661417!
        '
        'txt相殺その他総合計
        '
        Me.txt相殺その他総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相殺その他総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相殺その他総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相殺その他総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相殺その他総合計.Height = 0.2755905!
        Me.txt相殺その他総合計.Left = 5.374016!
        Me.txt相殺その他総合計.Name = "txt相殺その他総合計"
        Me.txt相殺その他総合計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt相殺その他総合計.Text = "999,999,999"
        Me.txt相殺その他総合計.Top = 0.0!
        Me.txt相殺その他総合計.Width = 0.8661417!
        '
        'Label3
        '
        Me.Label3.Height = 0.1968504!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 1.332284!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label3.Text = "＊総合計"
        Me.Label3.Top = 0.03779528!
        Me.Label3.Width = 0.7874014!
        '
        'BillList
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.59055!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr総合計)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt繰越, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt税込売上合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前回請求, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt手形, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt今回請求金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt今回売上, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt現金振込, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt相殺その他, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求一覧表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl繰越, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ｌｂｌ税込売上合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl今回請求金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl手形, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl前回請求, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl今回売上, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl現金振込, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl相殺その他, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt締日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl締日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtｺｰﾄﾞ並順, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前回請求総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt手形総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt今回請求総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt税込売上総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕上日計件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt繰越総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.消費税総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt今回売上総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt現金振込総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt相殺その他総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt得意先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt消費税額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt繰越 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt税込売上合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前回請求 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt手形 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt今回請求金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt今回売上 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt現金振込 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt相殺その他 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt対象年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt請求一覧表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl得意先CD As DataDynamics.ActiveReports.Label
    Private WithEvents lbl消費税額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl繰越 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先名 As DataDynamics.ActiveReports.Label
    Private WithEvents ｌｂｌ税込売上合計 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl今回請求金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl手形 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl前回請求 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl対象年月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl今回売上 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl現金振込 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl相殺その他 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr総合計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt前回請求総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt手形総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt今回請求総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt税込売上総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕上日計件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt繰越総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents 消費税総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt今回売上総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt現金振込総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt相殺その他総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents txt締日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl締日 As DataDynamics.ActiveReports.Label
    Private WithEvents txtｺｰﾄﾞ並順 As DataDynamics.ActiveReports.TextBox
End Class
