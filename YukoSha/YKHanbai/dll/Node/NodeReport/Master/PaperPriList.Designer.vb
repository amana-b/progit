<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PaperPriList
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
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PaperPriList))
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txtdtl仕入先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl仕入先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl社内用紙ｺｰﾄﾞ = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl社内用糊ｺｰﾄﾞ = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl社内用糊名 = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl社内用紙名 = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl社内用台紙ｺｰﾄﾞ = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl社内用台紙名 = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl単価区分 = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl単価金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl発注用紙ｺｰﾄﾞ = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl発注用糊ｺｰﾄﾞ = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl発注用台紙ｺｰﾄﾞ = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl発注用紙名 = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl発注用糊名 = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl発注用台紙名 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr紙価格 = New DataDynamics.ActiveReports.GroupHeader()
        Me.lblSlipDate = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入先CD = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入先名 = New DataDynamics.ActiveReports.Label()
        Me.lbl紙ｺｰﾄﾞ = New DataDynamics.ActiveReports.Label()
        Me.lbl紙名 = New DataDynamics.ActiveReports.Label()
        Me.lbl糊ｺｰﾄﾞ = New DataDynamics.ActiveReports.Label()
        Me.lbl糊名 = New DataDynamics.ActiveReports.Label()
        Me.lbl台紙ｺｰﾄﾞ = New DataDynamics.ActiveReports.Label()
        Me.lbl台紙名 = New DataDynamics.ActiveReports.Label()
        Me.lbl単価区分 = New DataDynamics.ActiveReports.Label()
        Me.lbl単価金額 = New DataDynamics.ActiveReports.Label()
        Me.lblhd単価種別 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr紙価格 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl仕入先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl仕入先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl社内用紙ｺｰﾄﾞ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl社内用糊ｺｰﾄﾞ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl社内用糊名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl社内用紙名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl社内用台紙ｺｰﾄﾞ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl社内用台紙名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl単価区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl単価金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl発注用紙ｺｰﾄﾞ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl発注用糊ｺｰﾄﾞ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl発注用台紙ｺｰﾄﾞ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl発注用紙名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl発注用糊名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl発注用台紙名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSlipDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl紙ｺｰﾄﾞ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl紙名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl糊ｺｰﾄﾞ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl糊名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl台紙ｺｰﾄﾞ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl台紙名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl単価区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl単価金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblhd単価種別, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label2, Me.TextBox1, Me.TextBox2, Me.txtNow, Me.Label1})
        Me.PageHeader.Height = 0.1771654!
        Me.PageHeader.Name = "PageHeader"
        '
        'Label2
        '
        Me.Label2.Height = 0.1771654!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 7.147244!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ 明朝; font-size: 9.75pt; text-align: center; vertical-align: top"
        Me.Label2.Text = "/"
        Me.Label2.Top = 0.0!
        Me.Label2.Width = 0.1574803!
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = False
        Me.TextBox1.Height = 0.1771654!
        Me.TextBox1.Left = 7.295244!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 9.75pt; text-align: center"
        Me.TextBox1.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.TextBox1.Text = "##"
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.3149606!
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = False
        Me.TextBox2.Height = 0.1771654!
        Me.TextBox2.Left = 6.901244!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ 明朝; font-size: 9.75pt; text-align: center"
        Me.TextBox2.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox2.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.TextBox2.Text = "#"
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 0.2362205!
        '
        'txtNow
        '
        Me.txtNow.CanGrow = False
        Me.txtNow.Height = 0.1771654!
        Me.txtNow.Left = 4.87441!
        Me.txtNow.Name = "txtNow"
        Me.txtNow.Style = "font-family: ＭＳ 明朝; font-size: 9.75pt; text-align: left"
        Me.txtNow.Text = "Now"
        Me.txtNow.Top = 0.0!
        Me.txtNow.Width = 1.38189!
        '
        'Label1
        '
        Me.Label1.Height = 0.1771654!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 6.258662!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ 明朝; font-size: 9.75pt; text-align: center; vertical-align: top"
        Me.Label1.Text = "作成"
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 0.3519688!
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtdtl仕入先CD, Me.txtdtl仕入先名, Me.txtdtl社内用紙ｺｰﾄﾞ, Me.txtdtl社内用糊ｺｰﾄﾞ, Me.txtdtl社内用糊名, Me.txtdtl社内用紙名, Me.txtdtl社内用台紙ｺｰﾄﾞ, Me.txtdtl社内用台紙名, Me.txtdtl単価区分, Me.txtdtl単価金額, Me.txtdtl発注用紙ｺｰﾄﾞ, Me.txtdtl発注用糊ｺｰﾄﾞ, Me.txtdtl発注用台紙ｺｰﾄﾞ, Me.txtdtl発注用紙名, Me.txtdtl発注用糊名, Me.txtdtl発注用台紙名})
        Me.Detail.Height = 0.3149606!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'txtdtl仕入先CD
        '
        Me.txtdtl仕入先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl仕入先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl仕入先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl仕入先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl仕入先CD.Height = 0.3149606!
        Me.txtdtl仕入先CD.Left = -0.0000001192093!
        Me.txtdtl仕入先CD.Name = "txtdtl仕入先CD"
        Me.txtdtl仕入先CD.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 128"
        Me.txtdtl仕入先CD.Text = "123456"
        Me.txtdtl仕入先CD.Top = -0.00000001490116!
        Me.txtdtl仕入先CD.Width = 0.511811!
        '
        'txtdtl仕入先名
        '
        Me.txtdtl仕入先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl仕入先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl仕入先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl仕入先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl仕入先名.Height = 0.3149606!
        Me.txtdtl仕入先名.Left = 0.5118111!
        Me.txtdtl仕入先名.Name = "txtdtl仕入先名"
        Me.txtdtl仕入先名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txtdtl仕入先名.Text = "リンテック(株)"
        Me.txtdtl仕入先名.Top = 0.0!
        Me.txtdtl仕入先名.Width = 1.102362!
        '
        'txtdtl社内用紙ｺｰﾄﾞ
        '
        Me.txtdtl社内用紙ｺｰﾄﾞ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl社内用紙ｺｰﾄﾞ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl社内用紙ｺｰﾄﾞ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl社内用紙ｺｰﾄﾞ.Height = 0.1574803!
        Me.txtdtl社内用紙ｺｰﾄﾞ.Left = 1.614173!
        Me.txtdtl社内用紙ｺｰﾄﾞ.Name = "txtdtl社内用紙ｺｰﾄﾞ"
        Me.txtdtl社内用紙ｺｰﾄﾞ.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtdtl社内用紙ｺｰﾄﾞ.Text = "1234"
        Me.txtdtl社内用紙ｺｰﾄﾞ.Top = 0.0!
        Me.txtdtl社内用紙ｺｰﾄﾞ.Width = 0.4330709!
        '
        'txtdtl社内用糊ｺｰﾄﾞ
        '
        Me.txtdtl社内用糊ｺｰﾄﾞ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl社内用糊ｺｰﾄﾞ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl社内用糊ｺｰﾄﾞ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl社内用糊ｺｰﾄﾞ.Height = 0.1574803!
        Me.txtdtl社内用糊ｺｰﾄﾞ.Left = 3.602362!
        Me.txtdtl社内用糊ｺｰﾄﾞ.Name = "txtdtl社内用糊ｺｰﾄﾞ"
        Me.txtdtl社内用糊ｺｰﾄﾞ.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtdtl社内用糊ｺｰﾄﾞ.Text = "123"
        Me.txtdtl社内用糊ｺｰﾄﾞ.Top = 0.0!
        Me.txtdtl社内用糊ｺｰﾄﾞ.Width = 0.3543307!
        '
        'txtdtl社内用糊名
        '
        Me.txtdtl社内用糊名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl社内用糊名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl社内用糊名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl社内用糊名.Height = 0.1574803!
        Me.txtdtl社内用糊名.Left = 3.956693!
        Me.txtdtl社内用糊名.Name = "txtdtl社内用糊名"
        Me.txtdtl社内用糊名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txtdtl社内用糊名.Text = "あいうえおかきく"
        Me.txtdtl社内用糊名.Top = 0.0!
        Me.txtdtl社内用糊名.Width = 1.141732!
        '
        'txtdtl社内用紙名
        '
        Me.txtdtl社内用紙名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl社内用紙名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl社内用紙名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl社内用紙名.Height = 0.1574803!
        Me.txtdtl社内用紙名.Left = 2.047244!
        Me.txtdtl社内用紙名.Name = "txtdtl社内用紙名"
        Me.txtdtl社内用紙名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txtdtl社内用紙名.Text = "ああああああああああいい"
        Me.txtdtl社内用紙名.Top = 0.0!
        Me.txtdtl社内用紙名.Width = 1.555118!
        '
        'txtdtl社内用台紙ｺｰﾄﾞ
        '
        Me.txtdtl社内用台紙ｺｰﾄﾞ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl社内用台紙ｺｰﾄﾞ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl社内用台紙ｺｰﾄﾞ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl社内用台紙ｺｰﾄﾞ.Height = 0.1574803!
        Me.txtdtl社内用台紙ｺｰﾄﾞ.Left = 5.098425!
        Me.txtdtl社内用台紙ｺｰﾄﾞ.Name = "txtdtl社内用台紙ｺｰﾄﾞ"
        Me.txtdtl社内用台紙ｺｰﾄﾞ.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtdtl社内用台紙ｺｰﾄﾞ.Text = "12" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtdtl社内用台紙ｺｰﾄﾞ.Top = 0.0!
        Me.txtdtl社内用台紙ｺｰﾄﾞ.Width = 0.2952756!
        '
        'txtdtl社内用台紙名
        '
        Me.txtdtl社内用台紙名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl社内用台紙名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl社内用台紙名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl社内用台紙名.Height = 0.1574803!
        Me.txtdtl社内用台紙名.Left = 5.393701!
        Me.txtdtl社内用台紙名.Name = "txtdtl社内用台紙名"
        Me.txtdtl社内用台紙名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txtdtl社内用台紙名.Text = "あいうえおかきく"
        Me.txtdtl社内用台紙名.Top = 0.0!
        Me.txtdtl社内用台紙名.Width = 1.102362!
        '
        'txtdtl単価区分
        '
        Me.txtdtl単価区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl単価区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl単価区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl単価区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl単価区分.Height = 0.3149606!
        Me.txtdtl単価区分.Left = 6.496063!
        Me.txtdtl単価区分.Name = "txtdtl単価区分"
        Me.txtdtl単価区分.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txtdtl単価区分.Text = "㎡単価"
        Me.txtdtl単価区分.Top = 0.0!
        Me.txtdtl単価区分.Width = 0.472441!
        '
        'txtdtl単価金額
        '
        Me.txtdtl単価金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl単価金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl単価金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl単価金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl単価金額.Height = 0.3149606!
        Me.txtdtl単価金額.Left = 6.968504!
        Me.txtdtl単価金額.Name = "txtdtl単価金額"
        Me.txtdtl単価金額.Style = "font-family: ＭＳ 明朝; font-size: 9.75pt; text-align: right; vertical-align: middle;" & _
    " ddo-char-set: 128"
        Me.txtdtl単価金額.Text = "99,999.99"
        Me.txtdtl単価金額.Top = 0.0!
        Me.txtdtl単価金額.Width = 0.7181102!
        '
        'txtdtl発注用紙ｺｰﾄﾞ
        '
        Me.txtdtl発注用紙ｺｰﾄﾞ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl発注用紙ｺｰﾄﾞ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl発注用紙ｺｰﾄﾞ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl発注用紙ｺｰﾄﾞ.Height = 0.1574803!
        Me.txtdtl発注用紙ｺｰﾄﾞ.Left = 1.614173!
        Me.txtdtl発注用紙ｺｰﾄﾞ.Name = "txtdtl発注用紙ｺｰﾄﾞ"
        Me.txtdtl発注用紙ｺｰﾄﾞ.Style = "font-family: ＭＳ 明朝; font-size: 8.25pt; text-align: center; vertical-align: top; d" & _
    "do-char-set: 1"
        Me.txtdtl発注用紙ｺｰﾄﾞ.Text = "(1234)"
        Me.txtdtl発注用紙ｺｰﾄﾞ.Top = 0.1574803!
        Me.txtdtl発注用紙ｺｰﾄﾞ.Width = 0.4330709!
        '
        'txtdtl発注用糊ｺｰﾄﾞ
        '
        Me.txtdtl発注用糊ｺｰﾄﾞ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl発注用糊ｺｰﾄﾞ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl発注用糊ｺｰﾄﾞ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl発注用糊ｺｰﾄﾞ.Height = 0.1574803!
        Me.txtdtl発注用糊ｺｰﾄﾞ.Left = 3.602362!
        Me.txtdtl発注用糊ｺｰﾄﾞ.Name = "txtdtl発注用糊ｺｰﾄﾞ"
        Me.txtdtl発注用糊ｺｰﾄﾞ.Style = "font-family: ＭＳ 明朝; font-size: 8.25pt; text-align: center; vertical-align: top; d" & _
    "do-char-set: 1"
        Me.txtdtl発注用糊ｺｰﾄﾞ.Text = "(123)"
        Me.txtdtl発注用糊ｺｰﾄﾞ.Top = 0.1574803!
        Me.txtdtl発注用糊ｺｰﾄﾞ.Width = 0.3543307!
        '
        'txtdtl発注用台紙ｺｰﾄﾞ
        '
        Me.txtdtl発注用台紙ｺｰﾄﾞ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl発注用台紙ｺｰﾄﾞ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl発注用台紙ｺｰﾄﾞ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl発注用台紙ｺｰﾄﾞ.Height = 0.1574803!
        Me.txtdtl発注用台紙ｺｰﾄﾞ.Left = 5.098425!
        Me.txtdtl発注用台紙ｺｰﾄﾞ.Name = "txtdtl発注用台紙ｺｰﾄﾞ"
        Me.txtdtl発注用台紙ｺｰﾄﾞ.Style = "font-family: ＭＳ 明朝; font-size: 8.25pt; text-align: center; vertical-align: top; d" & _
    "do-char-set: 1"
        Me.txtdtl発注用台紙ｺｰﾄﾞ.Text = "(12)"
        Me.txtdtl発注用台紙ｺｰﾄﾞ.Top = 0.1574803!
        Me.txtdtl発注用台紙ｺｰﾄﾞ.Width = 0.2952756!
        '
        'txtdtl発注用紙名
        '
        Me.txtdtl発注用紙名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl発注用紙名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl発注用紙名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl発注用紙名.Height = 0.1574803!
        Me.txtdtl発注用紙名.Left = 2.047244!
        Me.txtdtl発注用紙名.Name = "txtdtl発注用紙名"
        Me.txtdtl発注用紙名.Style = "font-family: ＭＳ 明朝; font-size: 8.25pt; text-align: left; vertical-align: top; ddo" & _
    "-char-set: 1"
        Me.txtdtl発注用紙名.Text = "(ああああああああああいい)"
        Me.txtdtl発注用紙名.Top = 0.1574803!
        Me.txtdtl発注用紙名.Width = 1.555118!
        '
        'txtdtl発注用糊名
        '
        Me.txtdtl発注用糊名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl発注用糊名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl発注用糊名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl発注用糊名.Height = 0.1574803!
        Me.txtdtl発注用糊名.Left = 3.956693!
        Me.txtdtl発注用糊名.Name = "txtdtl発注用糊名"
        Me.txtdtl発注用糊名.Style = "font-family: ＭＳ 明朝; font-size: 8.25pt; text-align: left; vertical-align: top; ddo" & _
    "-char-set: 1"
        Me.txtdtl発注用糊名.Text = "(あいうえおかきく)"
        Me.txtdtl発注用糊名.Top = 0.1574803!
        Me.txtdtl発注用糊名.Width = 1.141732!
        '
        'txtdtl発注用台紙名
        '
        Me.txtdtl発注用台紙名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl発注用台紙名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl発注用台紙名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl発注用台紙名.Height = 0.1574803!
        Me.txtdtl発注用台紙名.Left = 5.393701!
        Me.txtdtl発注用台紙名.Name = "txtdtl発注用台紙名"
        Me.txtdtl発注用台紙名.Style = "font-family: ＭＳ 明朝; font-size: 8.25pt; text-align: left; vertical-align: top; ddo" & _
    "-char-set: 1"
        Me.txtdtl発注用台紙名.Text = "(あいうえおかきく)"
        Me.txtdtl発注用台紙名.Top = 0.1574803!
        Me.txtdtl発注用台紙名.Width = 1.102362!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdr紙価格
        '
        Me.grpHdr紙価格.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblSlipDate, Me.lbl仕入先CD, Me.lbl仕入先名, Me.lbl紙ｺｰﾄﾞ, Me.lbl紙名, Me.lbl糊ｺｰﾄﾞ, Me.lbl糊名, Me.lbl台紙ｺｰﾄﾞ, Me.lbl台紙名, Me.lbl単価区分, Me.lbl単価金額, Me.lblhd単価種別})
        Me.grpHdr紙価格.DataField = "得意先CD"
        Me.grpHdr紙価格.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr紙価格.Height = 0.6692913!
        Me.grpHdr紙価格.Name = "grpHdr紙価格"
        Me.grpHdr紙価格.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'lblSlipDate
        '
        Me.lblSlipDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.lblSlipDate.Height = 0.25!
        Me.lblSlipDate.HyperLink = Nothing
        Me.lblSlipDate.Left = 2.832677!
        Me.lblSlipDate.Name = "lblSlipDate"
        Me.lblSlipDate.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 16pt; font-weight: bold; text-alig" & _
    "n: center; vertical-align: middle; ddo-char-set: 1"
        Me.lblSlipDate.Text = "紙　価　格　表"
        Me.lblSlipDate.Top = 0.0!
        Me.lblSlipDate.Width = 1.955906!
        '
        'lbl仕入先CD
        '
        Me.lbl仕入先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先CD.Height = 0.3149606!
        Me.lbl仕入先CD.HyperLink = Nothing
        Me.lbl仕入先CD.Left = 0.0!
        Me.lbl仕入先CD.Name = "lbl仕入先CD"
        Me.lbl仕入先CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl仕入先CD.Text = "仕入先ｺｰﾄﾞ"
        Me.lbl仕入先CD.Top = 0.3543307!
        Me.lbl仕入先CD.Width = 0.511811!
        '
        'lbl仕入先名
        '
        Me.lbl仕入先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Height = 0.3149606!
        Me.lbl仕入先名.HyperLink = Nothing
        Me.lbl仕入先名.Left = 0.5118111!
        Me.lbl仕入先名.Name = "lbl仕入先名"
        Me.lbl仕入先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl仕入先名.Text = "仕 入 先 名"
        Me.lbl仕入先名.Top = 0.3543307!
        Me.lbl仕入先名.Width = 1.102362!
        '
        'lbl紙ｺｰﾄﾞ
        '
        Me.lbl紙ｺｰﾄﾞ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙ｺｰﾄﾞ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙ｺｰﾄﾞ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙ｺｰﾄﾞ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙ｺｰﾄﾞ.Height = 0.3149606!
        Me.lbl紙ｺｰﾄﾞ.HyperLink = Nothing
        Me.lbl紙ｺｰﾄﾞ.Left = 1.614173!
        Me.lbl紙ｺｰﾄﾞ.Name = "lbl紙ｺｰﾄﾞ"
        Me.lbl紙ｺｰﾄﾞ.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl紙ｺｰﾄﾞ.Text = "紙" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " ｺｰﾄﾞ"
        Me.lbl紙ｺｰﾄﾞ.Top = 0.3543307!
        Me.lbl紙ｺｰﾄﾞ.Width = 0.4330709!
        '
        'lbl紙名
        '
        Me.lbl紙名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙名.Height = 0.3149606!
        Me.lbl紙名.HyperLink = Nothing
        Me.lbl紙名.Left = 2.047244!
        Me.lbl紙名.Name = "lbl紙名"
        Me.lbl紙名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl紙名.Text = "紙 名"
        Me.lbl紙名.Top = 0.3543307!
        Me.lbl紙名.Width = 1.555118!
        '
        'lbl糊ｺｰﾄﾞ
        '
        Me.lbl糊ｺｰﾄﾞ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊ｺｰﾄﾞ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊ｺｰﾄﾞ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊ｺｰﾄﾞ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊ｺｰﾄﾞ.Height = 0.3149606!
        Me.lbl糊ｺｰﾄﾞ.HyperLink = Nothing
        Me.lbl糊ｺｰﾄﾞ.Left = 3.602362!
        Me.lbl糊ｺｰﾄﾞ.Name = "lbl糊ｺｰﾄﾞ"
        Me.lbl糊ｺｰﾄﾞ.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 128"
        Me.lbl糊ｺｰﾄﾞ.Text = "糊" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " ｺｰﾄﾞ"
        Me.lbl糊ｺｰﾄﾞ.Top = 0.3543307!
        Me.lbl糊ｺｰﾄﾞ.Width = 0.3543307!
        '
        'lbl糊名
        '
        Me.lbl糊名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊名.Height = 0.3149606!
        Me.lbl糊名.HyperLink = Nothing
        Me.lbl糊名.Left = 3.956693!
        Me.lbl糊名.Name = "lbl糊名"
        Me.lbl糊名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl糊名.Text = "糊 名"
        Me.lbl糊名.Top = 0.3543307!
        Me.lbl糊名.Width = 1.141732!
        '
        'lbl台紙ｺｰﾄﾞ
        '
        Me.lbl台紙ｺｰﾄﾞ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙ｺｰﾄﾞ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙ｺｰﾄﾞ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙ｺｰﾄﾞ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙ｺｰﾄﾞ.Height = 0.3149606!
        Me.lbl台紙ｺｰﾄﾞ.HyperLink = Nothing
        Me.lbl台紙ｺｰﾄﾞ.Left = 5.098425!
        Me.lbl台紙ｺｰﾄﾞ.Name = "lbl台紙ｺｰﾄﾞ"
        Me.lbl台紙ｺｰﾄﾞ.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl台紙ｺｰﾄﾞ.Text = "台紙ｺｰﾄﾞ"
        Me.lbl台紙ｺｰﾄﾞ.Top = 0.3543307!
        Me.lbl台紙ｺｰﾄﾞ.Width = 0.2952756!
        '
        'lbl台紙名
        '
        Me.lbl台紙名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙名.Height = 0.3149606!
        Me.lbl台紙名.HyperLink = Nothing
        Me.lbl台紙名.Left = 5.393701!
        Me.lbl台紙名.Name = "lbl台紙名"
        Me.lbl台紙名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl台紙名.Text = "台 紙 名"
        Me.lbl台紙名.Top = 0.3543307!
        Me.lbl台紙名.Width = 1.102362!
        '
        'lbl単価区分
        '
        Me.lbl単価区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価区分.Height = 0.3149606!
        Me.lbl単価区分.HyperLink = Nothing
        Me.lbl単価区分.Left = 6.496063!
        Me.lbl単価区分.Name = "lbl単価区分"
        Me.lbl単価区分.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl単価区分.Text = "単価" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "区分"
        Me.lbl単価区分.Top = 0.3543307!
        Me.lbl単価区分.Width = 0.472441!
        '
        'lbl単価金額
        '
        Me.lbl単価金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価金額.Height = 0.3149606!
        Me.lbl単価金額.HyperLink = Nothing
        Me.lbl単価金額.Left = 6.968504!
        Me.lbl単価金額.Name = "lbl単価金額"
        Me.lbl単価金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl単価金額.Text = "単価金額"
        Me.lbl単価金額.Top = 0.3543307!
        Me.lbl単価金額.Width = 0.7181103!
        '
        'lblhd単価種別
        '
        Me.lblhd単価種別.Height = 0.2125984!
        Me.lblhd単価種別.HyperLink = Nothing
        Me.lblhd単価種別.Left = 4.862205!
        Me.lblhd単価種別.Name = "lblhd単価種別"
        Me.lblhd単価種別.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblhd単価種別.Text = "（ああああ）"
        Me.lblhd単価種別.Top = 0.06141733!
        Me.lblhd単価種別.Width = 0.9814963!
        '
        'grpFtr紙価格
        '
        Me.grpFtr紙価格.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox7})
        Me.grpFtr紙価格.Height = 0.0!
        Me.grpFtr紙価格.Name = "grpFtr紙価格"
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Height = 0.275!
        Me.TextBox7.Left = 9.250007!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0.00000001490116!
        Me.TextBox7.Width = 1.2!
        '
        'PaperPriList
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.694882!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr紙価格)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr紙価格)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl仕入先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl仕入先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl社内用紙ｺｰﾄﾞ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl社内用糊ｺｰﾄﾞ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl社内用糊名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl社内用紙名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl社内用台紙ｺｰﾄﾞ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl社内用台紙名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl単価区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl単価金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl発注用紙ｺｰﾄﾞ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl発注用糊ｺｰﾄﾞ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl発注用台紙ｺｰﾄﾞ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl発注用紙名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl発注用糊名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl発注用台紙名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSlipDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl紙ｺｰﾄﾞ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl紙名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl糊ｺｰﾄﾞ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl糊名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl台紙ｺｰﾄﾞ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl台紙名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl単価区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl単価金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblhd単価種別, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents grpHdr得意先CD As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl社内用紙ｺｰﾄﾞ As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl社内用糊ｺｰﾄﾞ As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl社内用糊名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl社内用紙名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl社内用台紙ｺｰﾄﾞ As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl社内用台紙名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl単価区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl単価金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl発注用紙ｺｰﾄﾞ As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl発注用糊ｺｰﾄﾞ As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl発注用台紙ｺｰﾄﾞ As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl発注用紙名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl発注用糊名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl発注用台紙名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents grpHdr紙価格 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents lblSlipDate As DataDynamics.ActiveReports.Label
    Friend WithEvents lbl仕入先CD As DataDynamics.ActiveReports.Label
    Private WithEvents lbl仕入先名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl紙ｺｰﾄﾞ As DataDynamics.ActiveReports.Label
    Private WithEvents lbl紙名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl糊ｺｰﾄﾞ As DataDynamics.ActiveReports.Label
    Private WithEvents lbl糊名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl台紙ｺｰﾄﾞ As DataDynamics.ActiveReports.Label
    Private WithEvents lbl台紙名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl単価区分 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl単価金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lblhd単価種別 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr紙価格 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl仕入先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl仕入先名 As DataDynamics.ActiveReports.TextBox
End Class
