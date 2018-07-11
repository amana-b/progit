<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CustomerRanking
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CustomerRanking))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt売上額構成比 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt順位 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt売上額 = New DataDynamics.ActiveReports.TextBox()
        Me.tx粗利 = New DataDynamics.ActiveReports.TextBox()
        Me.txt粗利構成比 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt得意先順位表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl通数 = New DataDynamics.ActiveReports.Label()
        Me.lbl売上額構成比 = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先CD = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先名 = New DataDynamics.ActiveReports.Label()
        Me.lbl売上額 = New DataDynamics.ActiveReports.Label()
        Me.lbl粗利 = New DataDynamics.ActiveReports.Label()
        Me.lbl粗利構成比 = New DataDynamics.ActiveReports.Label()
        Me.txt対象年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt順位並び方 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl順位 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt全得意先売上額構成比 = New DataDynamics.ActiveReports.TextBox()
        Me.txt全得意先売上額 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.txt全得意先通数 = New DataDynamics.ActiveReports.TextBox()
        Me.ttxt全得意先粗利 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数m合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt全得意先粗利構成比 = New DataDynamics.ActiveReports.TextBox()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt得意先粗利 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先売上額構成比 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先売上額 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox30 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先粗利構成比 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.GroupHeader2 = New DataDynamics.ActiveReports.GroupHeader()
        Me.GroupFooter2 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt順位粗利 = New DataDynamics.ActiveReports.TextBox()
        Me.txt順位売上額構成比 = New DataDynamics.ActiveReports.TextBox()
        Me.txt順位売上額 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数順位 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数得意先計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt順位粗利構成比 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt売上額構成比, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt順位, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt売上額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tx粗利, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt粗利構成比, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先順位表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl売上額構成比, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl売上額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl粗利, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl粗利構成比, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt順位並び方, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl順位, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt全得意先売上額構成比, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt全得意先売上額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt全得意先通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ttxt全得意先粗利, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数m合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt全得意先粗利構成比, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先粗利, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先売上額構成比, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先売上額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先粗利構成比, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt順位粗利, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt順位売上額構成比, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt順位売上額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数順位, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数得意先計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt順位粗利構成比, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt通数, Me.txt売上額構成比, Me.txt得意先名, Me.txt順位, Me.txt得意先CD, Me.txt売上額, Me.tx粗利, Me.txt粗利構成比})
        Me.Detail.Height = 0.2755905!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt通数
        '
        Me.txt通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数.Height = 0.2755905!
        Me.txt通数.Left = 3.543307!
        Me.txt通数.Name = "txt通数"
        Me.txt通数.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt通数.Text = "999,999,999"
        Me.txt通数.Top = 0.0!
        Me.txt通数.Width = 1.043307!
        '
        'txt売上額構成比
        '
        Me.txt売上額構成比.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上額構成比.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上額構成比.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上額構成比.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上額構成比.Height = 0.2755905!
        Me.txt売上額構成比.Left = 5.629922!
        Me.txt売上額構成比.Name = "txt売上額構成比"
        Me.txt売上額構成比.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt売上額構成比.Text = "99.99"
        Me.txt売上額構成比.Top = 0.000001132488!
        Me.txt売上額構成比.Width = 0.472441!
        '
        'txt得意先名
        '
        Me.txt得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.CanGrow = False
        Me.txt得意先名.Height = 0.2755905!
        Me.txt得意先名.Left = 1.259843!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt得意先名.Text = "あああああいいいいいうううううえええええおおおおお"
        Me.txt得意先名.Top = 0.0!
        Me.txt得意先名.Width = 2.283465!
        '
        'txt順位
        '
        Me.txt順位.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位.Height = 0.2755905!
        Me.txt順位.Left = 0.0!
        Me.txt順位.Name = "txt順位"
        Me.txt順位.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt順位.Text = "999"
        Me.txt順位.Top = 0.00000005960464!
        Me.txt順位.Width = 0.472441!
        '
        'txt得意先CD
        '
        Me.txt得意先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Height = 0.2755905!
        Me.txt得意先CD.Left = 0.472441!
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt得意先CD.Text = "12345"
        Me.txt得意先CD.Top = 0.0!
        Me.txt得意先CD.Width = 0.7874016!
        '
        'txt売上額
        '
        Me.txt売上額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上額.Height = 0.2755905!
        Me.txt売上額.Left = 4.586615!
        Me.txt売上額.Name = "txt売上額"
        Me.txt売上額.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt売上額.Text = "999,999,999"
        Me.txt売上額.Top = 0.0000002980233!
        Me.txt売上額.Width = 1.043307!
        '
        'tx粗利
        '
        Me.tx粗利.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.tx粗利.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.tx粗利.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.tx粗利.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.tx粗利.Height = 0.2755905!
        Me.tx粗利.Left = 6.102363!
        Me.tx粗利.Name = "tx粗利"
        Me.tx粗利.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.tx粗利.Text = "999,999,999"
        Me.tx粗利.Top = 0.0!
        Me.tx粗利.Width = 1.023622!
        '
        'txt粗利構成比
        '
        Me.txt粗利構成比.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利構成比.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利構成比.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利構成比.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利構成比.Height = 0.2755905!
        Me.txt粗利構成比.Left = 7.125985!
        Me.txt粗利構成比.Name = "txt粗利構成比"
        Me.txt粗利構成比.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt粗利構成比.Text = "99.99"
        Me.txt粗利構成比.Top = 0.0!
        Me.txt粗利構成比.Width = 0.492126!
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
        Me.txtNow.Left = 5.066977!
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
        Me.txt頁.Left = 7.21063!
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
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt得意先順位表, Me.lbl通数, Me.lbl売上額構成比, Me.lbl得意先CD, Me.lbl得意先名, Me.lbl売上額, Me.lbl粗利, Me.lbl粗利構成比, Me.txt対象年月, Me.txt順位並び方, Me.lbl順位})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.9992127!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txt得意先順位表
        '
        Me.txt得意先順位表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt得意先順位表.CharacterSpacing = 5.0!
        Me.txt得意先順位表.Height = 0.2362205!
        Me.txt得意先順位表.Left = 2.395276!
        Me.txt得意先順位表.Name = "txt得意先順位表"
        Me.txt得意先順位表.Style = "font-family: ＭＳ Ｐゴシック; font-size: 14pt; font-weight: bold; text-align: center; ve" & _
    "rtical-align: bottom; ddo-char-set: 1"
        Me.txt得意先順位表.Text = "得意先順位表"
        Me.txt得意先順位表.Top = 0.1968504!
        Me.txt得意先順位表.Width = 2.047244!
        '
        'lbl通数
        '
        Me.lbl通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Height = 0.3346457!
        Me.lbl通数.HyperLink = Nothing
        Me.lbl通数.Left = 3.543307!
        Me.lbl通数.Name = "lbl通数"
        Me.lbl通数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl通数.Text = "通数"
        Me.lbl通数.Top = 0.664567!
        Me.lbl通数.Width = 1.043307!
        '
        'lbl売上額構成比
        '
        Me.lbl売上額構成比.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上額構成比.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上額構成比.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上額構成比.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上額構成比.Height = 0.3346457!
        Me.lbl売上額構成比.HyperLink = Nothing
        Me.lbl売上額構成比.Left = 5.629922!
        Me.lbl売上額構成比.Name = "lbl売上額構成比"
        Me.lbl売上額構成比.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl売上額構成比.Text = "構成比"
        Me.lbl売上額構成比.Top = 0.664567!
        Me.lbl売上額構成比.Width = 0.472441!
        '
        'lbl得意先CD
        '
        Me.lbl得意先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Height = 0.3346457!
        Me.lbl得意先CD.HyperLink = Nothing
        Me.lbl得意先CD.Left = 0.472441!
        Me.lbl得意先CD.Name = "lbl得意先CD"
        Me.lbl得意先CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl得意先CD.Text = "得意先ｺｰﾄﾞ"
        Me.lbl得意先CD.Top = 0.664567!
        Me.lbl得意先CD.Width = 0.7874016!
        '
        'lbl得意先名
        '
        Me.lbl得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.CharacterSpacing = 10.0!
        Me.lbl得意先名.Height = 0.3346457!
        Me.lbl得意先名.HyperLink = Nothing
        Me.lbl得意先名.Left = 1.259843!
        Me.lbl得意先名.Name = "lbl得意先名"
        Me.lbl得意先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl得意先名.Text = "得意先名"
        Me.lbl得意先名.Top = 0.664567!
        Me.lbl得意先名.Width = 2.283465!
        '
        'lbl売上額
        '
        Me.lbl売上額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上額.Height = 0.3346457!
        Me.lbl売上額.HyperLink = Nothing
        Me.lbl売上額.Left = 4.586615!
        Me.lbl売上額.Name = "lbl売上額"
        Me.lbl売上額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl売上額.Text = "売上額"
        Me.lbl売上額.Top = 0.664567!
        Me.lbl売上額.Width = 1.043307!
        '
        'lbl粗利
        '
        Me.lbl粗利.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Height = 0.3346457!
        Me.lbl粗利.HyperLink = Nothing
        Me.lbl粗利.Left = 6.102363!
        Me.lbl粗利.Name = "lbl粗利"
        Me.lbl粗利.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl粗利.Text = "粗利"
        Me.lbl粗利.Top = 0.664567!
        Me.lbl粗利.Width = 1.023622!
        '
        'lbl粗利構成比
        '
        Me.lbl粗利構成比.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利構成比.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利構成比.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利構成比.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利構成比.Height = 0.3346457!
        Me.lbl粗利構成比.HyperLink = Nothing
        Me.lbl粗利構成比.Left = 7.125985!
        Me.lbl粗利構成比.Name = "lbl粗利構成比"
        Me.lbl粗利構成比.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl粗利構成比.Text = "構成比"
        Me.lbl粗利構成比.Top = 0.664567!
        Me.lbl粗利構成比.Width = 0.492126!
        '
        'txt対象年月
        '
        Me.txt対象年月.Height = 0.2362205!
        Me.txt対象年月.Left = 0.0!
        Me.txt対象年月.Name = "txt対象年月"
        Me.txt対象年月.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txt対象年月.Text = "00/00/00～99/99/99　日迄"
        Me.txt対象年月.Top = 0.1968504!
        Me.txt対象年月.Width = 1.712992!
        '
        'txt順位並び方
        '
        Me.txt順位並び方.Height = 0.2362205!
        Me.txt順位並び方.Left = 5.474803!
        Me.txt順位並び方.Name = "txt順位並び方"
        Me.txt順位並び方.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt順位並び方.Text = "(●●順999位迄)"
        Me.txt順位並び方.Top = 0.2362205!
        Me.txt順位並び方.Width = 1.379134!
        '
        'lbl順位
        '
        Me.lbl順位.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl順位.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl順位.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl順位.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl順位.CharacterSpacing = 5.0!
        Me.lbl順位.Height = 0.3346457!
        Me.lbl順位.HyperLink = Nothing
        Me.lbl順位.Left = 0.0!
        Me.lbl順位.Name = "lbl順位"
        Me.lbl順位.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl順位.Text = "順位"
        Me.lbl順位.Top = 0.6645669!
        Me.lbl順位.Width = 0.472441!
        '
        'grpFtr計
        '
        Me.grpFtr計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt全得意先売上額構成比, Me.txt全得意先売上額, Me.TextBox11, Me.txt全得意先通数, Me.ttxt全得意先粗利, Me.txt通数m合計, Me.txt全得意先粗利構成比, Me.Label4, Me.TextBox3})
        Me.grpFtr計.Height = 0.2755906!
        Me.grpFtr計.Name = "grpFtr計"
        '
        'txt全得意先売上額構成比
        '
        Me.txt全得意先売上額構成比.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt全得意先売上額構成比.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt全得意先売上額構成比.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt全得意先売上額構成比.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt全得意先売上額構成比.Height = 0.2755905!
        Me.txt全得意先売上額構成比.Left = 5.629922!
        Me.txt全得意先売上額構成比.Name = "txt全得意先売上額構成比"
        Me.txt全得意先売上額構成比.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt全得意先売上額構成比.Text = "999.99"
        Me.txt全得意先売上額構成比.Top = 0.0!
        Me.txt全得意先売上額構成比.Width = 0.472441!
        '
        'txt全得意先売上額
        '
        Me.txt全得意先売上額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt全得意先売上額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt全得意先売上額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt全得意先売上額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt全得意先売上額.Height = 0.2755905!
        Me.txt全得意先売上額.Left = 4.586615!
        Me.txt全得意先売上額.Name = "txt全得意先売上額"
        Me.txt全得意先売上額.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt全得意先売上額.Text = "999,999,999,999"
        Me.txt全得意先売上額.Top = 0.0!
        Me.txt全得意先売上額.Width = 1.043307!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Height = 0.2755905!
        Me.TextBox11.Left = 0.472441!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 0.0!
        Me.TextBox11.Width = 0.7874016!
        '
        'txt全得意先通数
        '
        Me.txt全得意先通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt全得意先通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt全得意先通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt全得意先通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt全得意先通数.Height = 0.2755905!
        Me.txt全得意先通数.Left = 3.543307!
        Me.txt全得意先通数.Name = "txt全得意先通数"
        Me.txt全得意先通数.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt全得意先通数.Text = "999,999,999,999"
        Me.txt全得意先通数.Top = 0.0!
        Me.txt全得意先通数.Width = 1.043307!
        '
        'ttxt全得意先粗利
        '
        Me.ttxt全得意先粗利.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ttxt全得意先粗利.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ttxt全得意先粗利.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ttxt全得意先粗利.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ttxt全得意先粗利.Height = 0.2755905!
        Me.ttxt全得意先粗利.Left = 6.102363!
        Me.ttxt全得意先粗利.Name = "ttxt全得意先粗利"
        Me.ttxt全得意先粗利.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.ttxt全得意先粗利.Text = "999,999,999,999"
        Me.ttxt全得意先粗利.Top = 0.0!
        Me.ttxt全得意先粗利.Width = 1.023622!
        '
        'txt通数m合計
        '
        Me.txt通数m合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m合計.Height = 0.2755905!
        Me.txt通数m合計.Left = 1.259843!
        Me.txt通数m合計.Name = "txt通数m合計"
        Me.txt通数m合計.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt通数m合計.Text = Nothing
        Me.txt通数m合計.Top = 0.0!
        Me.txt通数m合計.Width = 2.283465!
        '
        'txt全得意先粗利構成比
        '
        Me.txt全得意先粗利構成比.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt全得意先粗利構成比.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt全得意先粗利構成比.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt全得意先粗利構成比.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt全得意先粗利構成比.Height = 0.2755905!
        Me.txt全得意先粗利構成比.Left = 7.125985!
        Me.txt全得意先粗利構成比.Name = "txt全得意先粗利構成比"
        Me.txt全得意先粗利構成比.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt全得意先粗利構成比.Text = "999.99"
        Me.txt全得意先粗利構成比.Top = 0.0!
        Me.txt全得意先粗利構成比.Width = 0.492126!
        '
        'Label4
        '
        Me.Label4.Height = 0.1968504!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 2.159843!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label4.Text = "＊全得意先の合計"
        Me.Label4.Top = 0.03070866!
        Me.Label4.Width = 1.334646!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.2755906!
        Me.TextBox3.Left = 0.0!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.472441!
        '
        'Label2
        '
        Me.Label2.Height = 0.1968504!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 1.597638!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label2.Text = "＊その他の得意先の合計"
        Me.Label2.Top = 0.03070866!
        Me.Label2.Width = 1.886614!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt得意先粗利, Me.txt得意先売上額構成比, Me.txt得意先売上額, Me.TextBox30, Me.txt得意先通数, Me.txt通数担当者計, Me.txt得意先粗利構成比, Me.Label2, Me.TextBox2})
        Me.GroupFooter1.Height = 0.2755906!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'txt得意先粗利
        '
        Me.txt得意先粗利.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先粗利.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先粗利.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先粗利.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先粗利.Height = 0.2755905!
        Me.txt得意先粗利.Left = 6.102363!
        Me.txt得意先粗利.Name = "txt得意先粗利"
        Me.txt得意先粗利.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt得意先粗利.Text = "999,999,999,999"
        Me.txt得意先粗利.Top = 0.0!
        Me.txt得意先粗利.Width = 1.023622!
        '
        'txt得意先売上額構成比
        '
        Me.txt得意先売上額構成比.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先売上額構成比.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先売上額構成比.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先売上額構成比.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先売上額構成比.Height = 0.2755905!
        Me.txt得意先売上額構成比.Left = 5.629922!
        Me.txt得意先売上額構成比.Name = "txt得意先売上額構成比"
        Me.txt得意先売上額構成比.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt得意先売上額構成比.Text = "999.99"
        Me.txt得意先売上額構成比.Top = 0.0!
        Me.txt得意先売上額構成比.Width = 0.472441!
        '
        'txt得意先売上額
        '
        Me.txt得意先売上額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先売上額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先売上額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先売上額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先売上額.Height = 0.2755905!
        Me.txt得意先売上額.Left = 4.586615!
        Me.txt得意先売上額.Name = "txt得意先売上額"
        Me.txt得意先売上額.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt得意先売上額.Text = "999,999,999,999"
        Me.txt得意先売上額.Top = 0.0!
        Me.txt得意先売上額.Width = 1.043307!
        '
        'TextBox30
        '
        Me.TextBox30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Height = 0.2755905!
        Me.TextBox30.Left = 0.472441!
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.TextBox30.Text = Nothing
        Me.TextBox30.Top = 0.0!
        Me.TextBox30.Width = 0.7874016!
        '
        'txt得意先通数
        '
        Me.txt得意先通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先通数.Height = 0.2755905!
        Me.txt得意先通数.Left = 3.543307!
        Me.txt得意先通数.Name = "txt得意先通数"
        Me.txt得意先通数.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt得意先通数.Text = "999,999,999,999"
        Me.txt得意先通数.Top = 0.0!
        Me.txt得意先通数.Width = 1.043307!
        '
        'txt通数担当者計
        '
        Me.txt通数担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数担当者計.Height = 0.2755905!
        Me.txt通数担当者計.Left = 1.259843!
        Me.txt通数担当者計.Name = "txt通数担当者計"
        Me.txt通数担当者計.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt通数担当者計.Text = Nothing
        Me.txt通数担当者計.Top = 0.0!
        Me.txt通数担当者計.Width = 2.283465!
        '
        'txt得意先粗利構成比
        '
        Me.txt得意先粗利構成比.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先粗利構成比.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先粗利構成比.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先粗利構成比.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先粗利構成比.Height = 0.2755905!
        Me.txt得意先粗利構成比.Left = 7.125985!
        Me.txt得意先粗利構成比.Name = "txt得意先粗利構成比"
        Me.txt得意先粗利構成比.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt得意先粗利構成比.Text = "999.99"
        Me.txt得意先粗利構成比.Top = 0.0!
        Me.txt得意先粗利構成比.Width = 0.492126!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Height = 0.2755906!
        Me.TextBox2.Left = 0.0!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 0.472441!
        '
        'Label3
        '
        Me.Label3.Height = 0.1968504!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 1.99685!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label3.Text = "＊1位～999位までの合計"
        Me.Label3.Top = 0.03070866!
        Me.Label3.Width = 1.479528!
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Height = 0.0!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt順位粗利, Me.txt順位売上額構成比, Me.txt順位売上額, Me.TextBox8, Me.txt通数順位, Me.txt通数得意先計, Me.txt順位粗利構成比, Me.Label3, Me.TextBox1})
        Me.GroupFooter2.Height = 0.2755908!
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'txt順位粗利
        '
        Me.txt順位粗利.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位粗利.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位粗利.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位粗利.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位粗利.Height = 0.2755905!
        Me.txt順位粗利.Left = 6.102363!
        Me.txt順位粗利.Name = "txt順位粗利"
        Me.txt順位粗利.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt順位粗利.Text = "999,999,999,999"
        Me.txt順位粗利.Top = 0.0!
        Me.txt順位粗利.Width = 1.023622!
        '
        'txt順位売上額構成比
        '
        Me.txt順位売上額構成比.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位売上額構成比.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位売上額構成比.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位売上額構成比.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位売上額構成比.Height = 0.2755905!
        Me.txt順位売上額構成比.Left = 5.629922!
        Me.txt順位売上額構成比.Name = "txt順位売上額構成比"
        Me.txt順位売上額構成比.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt順位売上額構成比.Text = "999.99"
        Me.txt順位売上額構成比.Top = 0.0!
        Me.txt順位売上額構成比.Width = 0.472441!
        '
        'txt順位売上額
        '
        Me.txt順位売上額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位売上額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位売上額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位売上額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位売上額.Height = 0.2755905!
        Me.txt順位売上額.Left = 4.586615!
        Me.txt順位売上額.Name = "txt順位売上額"
        Me.txt順位売上額.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt順位売上額.Text = "999,999,999,999"
        Me.txt順位売上額.Top = 0.0000002980233!
        Me.txt順位売上額.Width = 1.043307!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Height = 0.2755905!
        Me.TextBox8.Left = 0.472441!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 0.7874016!
        '
        'txt通数順位
        '
        Me.txt通数順位.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数順位.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数順位.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数順位.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数順位.Height = 0.2755905!
        Me.txt通数順位.Left = 3.543307!
        Me.txt通数順位.Name = "txt通数順位"
        Me.txt通数順位.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt通数順位.Text = "999,999,999,999"
        Me.txt通数順位.Top = 0.0!
        Me.txt通数順位.Width = 1.043307!
        '
        'txt通数得意先計
        '
        Me.txt通数得意先計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数得意先計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数得意先計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数得意先計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数得意先計.Height = 0.2755905!
        Me.txt通数得意先計.Left = 1.259843!
        Me.txt通数得意先計.Name = "txt通数得意先計"
        Me.txt通数得意先計.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt通数得意先計.Text = Nothing
        Me.txt通数得意先計.Top = 0.0!
        Me.txt通数得意先計.Width = 2.283465!
        '
        'txt順位粗利構成比
        '
        Me.txt順位粗利構成比.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位粗利構成比.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位粗利構成比.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位粗利構成比.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt順位粗利構成比.Height = 0.2755905!
        Me.txt順位粗利構成比.Left = 7.125985!
        Me.txt順位粗利構成比.Name = "txt順位粗利構成比"
        Me.txt順位粗利構成比.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt順位粗利構成比.Text = "999.99"
        Me.txt順位粗利構成比.Top = 0.00000002980232!
        Me.txt順位粗利構成比.Width = 0.492126!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.2755906!
        Me.TextBox1.Left = 0.0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.472441!
        '
        'CustomerRanking
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.637795!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.GroupHeader2)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter2)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.grpFtr計)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt売上額構成比, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt順位, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt売上額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tx粗利, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt粗利構成比, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先順位表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl売上額構成比, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl売上額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl粗利, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl粗利構成比, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt順位並び方, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl順位, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt全得意先売上額構成比, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt全得意先売上額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt全得意先通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ttxt全得意先粗利, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数m合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt全得意先粗利構成比, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先粗利, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先売上額構成比, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先売上額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先粗利構成比, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt順位粗利, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt順位売上額構成比, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt順位売上額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数順位, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数得意先計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt順位粗利構成比, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt売上額構成比 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt順位 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt売上額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt得意先順位表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl通数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先CD As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl売上額 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt全得意先売上額構成比 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt全得意先売上額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents tx粗利 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl粗利 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl売上額構成比 As DataDynamics.ActiveReports.Label
    Private WithEvents ttxt全得意先粗利 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl粗利構成比 As DataDynamics.ActiveReports.Label
    Private WithEvents txt全得意先通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt通数m合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先粗利 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先売上額構成比 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先売上額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox30 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents txt通数担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader2 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents GroupFooter2 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt順位粗利 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt順位売上額構成比 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt順位売上額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt通数順位 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt通数得意先計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt粗利構成比 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt全得意先粗利構成比 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先粗利構成比 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt順位粗利構成比 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt対象年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents txt順位並び方 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl順位 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先通数 As DataDynamics.ActiveReports.TextBox
End Class
