<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CustomerList
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CustomerList))
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.txtdtl本支店名 = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl部署名 = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl郵便番号 = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl担当者名 = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtlTEL = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl住所1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl住所2 = New DataDynamics.ActiveReports.TextBox()
        Me.lbldtlTEL = New DataDynamics.ActiveReports.Label()
        Me.lbldtlFAX = New DataDynamics.ActiveReports.Label()
        Me.lbldtl携帯 = New DataDynamics.ActiveReports.Label()
        Me.txtdtlFAX = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl携帯 = New DataDynamics.ActiveReports.TextBox()
        Me.lbldtlメール = New DataDynamics.ActiveReports.Label()
        Me.txtdtlメール = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr得意先CD = New DataDynamics.ActiveReports.GroupHeader()
        Me.lblTitle = New DataDynamics.ActiveReports.Label()
        Me.lbl本支店名 = New DataDynamics.ActiveReports.Label()
        Me.lbl代表者役職_代表者名 = New DataDynamics.ActiveReports.Label()
        Me.lbl部署名 = New DataDynamics.ActiveReports.Label()
        Me.lbl担当者名 = New DataDynamics.ActiveReports.Label()
        Me.lbl備考欄 = New DataDynamics.ActiveReports.Label()
        Me.lbl住所 = New DataDynamics.ActiveReports.Label()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt代表者役職_代表者名 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl締日 = New DataDynamics.ActiveReports.Label()
        Me.txt締日名 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl回収条件 = New DataDynamics.ActiveReports.Label()
        Me.txt回収条件以上設定金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt回収条件未満設定金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt回収条件未満 = New DataDynamics.ActiveReports.TextBox()
        Me.txt回収条件以上 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl円以上 = New DataDynamics.ActiveReports.Label()
        Me.lbl円未満 = New DataDynamics.ActiveReports.Label()
        Me.ｌｂｌ自社担当者名 = New DataDynamics.ActiveReports.Label()
        Me.txt自社担当者名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt回収条件以上回収月名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt回収条件未満回収月名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt回収条件以上回収日名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt回収条件未満回収日名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt回収条件以上回収方法名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt回収条件未満回収方法名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt代表者役職_代表者名1 = New DataDynamics.ActiveReports.TextBox()
        Me.txt代表者役職_代表者名2 = New DataDynamics.ActiveReports.TextBox()
        Me.grpFtr得意先CD = New DataDynamics.ActiveReports.GroupFooter()
        Me.SubReport = New DataDynamics.ActiveReports.SubReport()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.Line2 = New DataDynamics.ActiveReports.Line()
        Me.Line3 = New DataDynamics.ActiveReports.Line()
        Me.Line4 = New DataDynamics.ActiveReports.Line()
        Me.txtdtl行NO = New DataDynamics.ActiveReports.TextBox()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl本支店名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl部署名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl郵便番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl担当者名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtlTEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl住所1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl住所2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbldtlTEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbldtlFAX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbldtl携帯, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtlFAX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl携帯, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbldtlメール, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtlメール, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl本支店名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl代表者役職_代表者名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl部署名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl担当者名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl備考欄, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl住所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt代表者役職_代表者名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl締日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt締日名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl回収条件, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt回収条件以上設定金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt回収条件未満設定金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt回収条件未満, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt回収条件以上, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl円以上, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl円未満, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ｌｂｌ自社担当者名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt自社担当者名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt回収条件以上回収月名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt回収条件未満回収月名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt回収条件以上回収日名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt回収条件未満回収日名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt回収条件以上回収方法名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt回収条件未満回収方法名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt代表者役職_代表者名1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt代表者役職_代表者名2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl行NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label4, Me.Label3, Me.txtdtl本支店名, Me.txtdtl部署名, Me.txtdtl郵便番号, Me.txtdtl担当者名, Me.txtdtlTEL, Me.txtdtl住所1, Me.txtdtl住所2, Me.lbldtlTEL, Me.lbldtlFAX, Me.lbldtl携帯, Me.txtdtlFAX, Me.txtdtl携帯, Me.lbldtlメール, Me.txtdtlメール, Me.txtdtl行NO})
        Me.Detail.Height = 0.5314961!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'Label4
        '
        Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Height = 0.5314961!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 3.564567!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8.25pt; text-align: left; vertical-a" & _
    "lign: bottom; ddo-char-set: 128"
        Me.Label4.Text = ""
        Me.Label4.Top = 0.0!
        Me.Label4.Width = 4.120079!
        '
        'Label3
        '
        Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Height = 0.5314961!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.5000001!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8.25pt; text-align: left; vertical-a" & _
    "lign: bottom; ddo-char-set: 128"
        Me.Label3.Text = ""
        Me.Label3.Top = 0.0!
        Me.Label3.Width = 3.064567!
        '
        'txtdtl本支店名
        '
        Me.txtdtl本支店名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl本支店名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl本支店名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl本支店名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl本支店名.Height = 0.5314961!
        Me.txtdtl本支店名.Left = -0.0000001192093!
        Me.txtdtl本支店名.Name = "txtdtl本支店名"
        Me.txtdtl本支店名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtdtl本支店名.Text = "ああああああ"
        Me.txtdtl本支店名.Top = -0.00000001490116!
        Me.txtdtl本支店名.Width = 0.5!
        '
        'txtdtl部署名
        '
        Me.txtdtl部署名.Height = 0.1771654!
        Me.txtdtl部署名.Left = 0.5!
        Me.txtdtl部署名.Name = "txtdtl部署名"
        Me.txtdtl部署名.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.txtdtl部署名.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txtdtl部署名.Text = "ああああああああああいいいいいい"
        Me.txtdtl部署名.Top = 0.0!
        Me.txtdtl部署名.Width = 3.064567!
        '
        'txtdtl郵便番号
        '
        Me.txtdtl郵便番号.Height = 0.1771654!
        Me.txtdtl郵便番号.Left = 0.5000001!
        Me.txtdtl郵便番号.Name = "txtdtl郵便番号"
        Me.txtdtl郵便番号.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txtdtl郵便番号.Text = "999-9999"
        Me.txtdtl郵便番号.Top = 0.1771654!
        Me.txtdtl郵便番号.Width = 0.5905512!
        '
        'txtdtl担当者名
        '
        Me.txtdtl担当者名.Height = 0.1771654!
        Me.txtdtl担当者名.Left = 3.564567!
        Me.txtdtl担当者名.Name = "txtdtl担当者名"
        Me.txtdtl担当者名.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.txtdtl担当者名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txtdtl担当者名.Text = "ああああああああああい"
        Me.txtdtl担当者名.Top = 0.0!
        Me.txtdtl担当者名.Width = 1.811024!
        '
        'txtdtlTEL
        '
        Me.txtdtlTEL.Height = 0.1771654!
        Me.txtdtlTEL.Left = 5.598032!
        Me.txtdtlTEL.Name = "txtdtlTEL"
        Me.txtdtlTEL.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txtdtlTEL.Text = "999-9999-9999"
        Me.txtdtlTEL.Top = 0.0!
        Me.txtdtlTEL.Width = 0.9055118!
        '
        'txtdtl住所1
        '
        Me.txtdtl住所1.Height = 0.1771654!
        Me.txtdtl住所1.Left = 1.090551!
        Me.txtdtl住所1.Name = "txtdtl住所1"
        Me.txtdtl住所1.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txtdtl住所1.Text = "ああああああああああいいいいいい"
        Me.txtdtl住所1.Top = 0.1771654!
        Me.txtdtl住所1.Width = 2.480315!
        '
        'txtdtl住所2
        '
        Me.txtdtl住所2.Height = 0.1771654!
        Me.txtdtl住所2.Left = 1.090551!
        Me.txtdtl住所2.Name = "txtdtl住所2"
        Me.txtdtl住所2.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txtdtl住所2.Text = "ああああああああああいいいいいい"
        Me.txtdtl住所2.Top = 0.3543307!
        Me.txtdtl住所2.Width = 2.480315!
        '
        'lbldtlTEL
        '
        Me.lbldtlTEL.Height = 0.1771654!
        Me.lbldtlTEL.HyperLink = Nothing
        Me.lbldtlTEL.Left = 5.361812!
        Me.lbldtlTEL.Name = "lbldtlTEL"
        Me.lbldtlTEL.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-ali" & _
    "gn: middle; ddo-char-set: 1"
        Me.lbldtlTEL.Text = "TEL"
        Me.lbldtlTEL.Top = 0.0!
        Me.lbldtlTEL.Width = 0.2362205!
        '
        'lbldtlFAX
        '
        Me.lbldtlFAX.Height = 0.1771654!
        Me.lbldtlFAX.HyperLink = Nothing
        Me.lbldtlFAX.Left = 6.503544!
        Me.lbldtlFAX.Name = "lbldtlFAX"
        Me.lbldtlFAX.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbldtlFAX.Text = "FAX"
        Me.lbldtlFAX.Top = 0.0!
        Me.lbldtlFAX.Width = 0.2755905!
        '
        'lbldtl携帯
        '
        Me.lbldtl携帯.Height = 0.1771654!
        Me.lbldtl携帯.HyperLink = Nothing
        Me.lbldtl携帯.Left = 6.503544!
        Me.lbldtl携帯.Name = "lbldtl携帯"
        Me.lbldtl携帯.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbldtl携帯.Text = "携帯"
        Me.lbldtl携帯.Top = 0.1771654!
        Me.lbldtl携帯.Width = 0.2755905!
        '
        'txtdtlFAX
        '
        Me.txtdtlFAX.Height = 0.1771654!
        Me.txtdtlFAX.Left = 6.779134!
        Me.txtdtlFAX.Name = "txtdtlFAX"
        Me.txtdtlFAX.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txtdtlFAX.Text = "999-9999-9999"
        Me.txtdtlFAX.Top = 0.0!
        Me.txtdtlFAX.Width = 0.9055118!
        '
        'txtdtl携帯
        '
        Me.txtdtl携帯.Height = 0.1771654!
        Me.txtdtl携帯.Left = 6.779134!
        Me.txtdtl携帯.Name = "txtdtl携帯"
        Me.txtdtl携帯.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txtdtl携帯.Text = "999-9999-9999"
        Me.txtdtl携帯.Top = 0.1771654!
        Me.txtdtl携帯.Width = 0.9055119!
        '
        'lbldtlメール
        '
        Me.lbldtlメール.Height = 0.1771654!
        Me.lbldtlメール.HyperLink = Nothing
        Me.lbldtlメール.Left = 3.570866!
        Me.lbldtlメール.Name = "lbldtlメール"
        Me.lbldtlメール.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8.25pt; text-align: right; vertical-" & _
    "align: middle; ddo-char-set: 128"
        Me.lbldtlメール.Text = "mail"
        Me.lbldtlメール.Top = 0.3543307!
        Me.lbldtlメール.Width = 0.2755905!
        '
        'txtdtlメール
        '
        Me.txtdtlメール.Height = 0.1771654!
        Me.txtdtlメール.Left = 3.846457!
        Me.txtdtlメール.Name = "txtdtlメール"
        Me.txtdtlメール.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txtdtlメール.Text = "....*....1....*....2....*....3....*....4....*....5....*....6"
        Me.txtdtlメール.Top = 0.3543307!
        Me.txtdtlメール.Width = 3.818898!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdr得意先CD
        '
        Me.grpHdr得意先CD.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitle, Me.lbl本支店名, Me.lbl代表者役職_代表者名, Me.lbl部署名, Me.lbl担当者名, Me.lbl備考欄, Me.lbl住所, Me.txt得意先名, Me.txt得意先CD, Me.txt代表者役職_代表者名, Me.lbl締日, Me.txt締日名, Me.lbl回収条件, Me.txt回収条件以上設定金額, Me.txt回収条件未満設定金額, Me.txt回収条件未満, Me.txt回収条件以上, Me.lbl円以上, Me.lbl円未満, Me.ｌｂｌ自社担当者名, Me.txt自社担当者名, Me.txt回収条件以上回収月名, Me.txt回収条件未満回収月名, Me.txt回収条件以上回収日名, Me.txt回収条件未満回収日名, Me.txt回収条件以上回収方法名, Me.txt回収条件未満回収方法名, Me.txt代表者役職_代表者名1, Me.txt代表者役職_代表者名2})
        Me.grpHdr得意先CD.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr得意先CD.Height = 1.771654!
        Me.grpHdr得意先CD.Name = "grpHdr得意先CD"
        Me.grpHdr得意先CD.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'lblTitle
        '
        Me.lblTitle.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.lblTitle.Height = 0.25!
        Me.lblTitle.HyperLink = Nothing
        Me.lblTitle.Left = 4.665355!
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 16pt; font-weight: bold; text-alig" & _
    "n: center; vertical-align: middle; ddo-char-set: 1"
        Me.lblTitle.Text = "顧 客 台 帳"
        Me.lblTitle.Top = 0.0!
        Me.lblTitle.Width = 3.0!
        '
        'lbl本支店名
        '
        Me.lbl本支店名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl本支店名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl本支店名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl本支店名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl本支店名.Height = 0.2018898!
        Me.lbl本支店名.HyperLink = Nothing
        Me.lbl本支店名.Left = 0.0!
        Me.lbl本支店名.Name = "lbl本支店名"
        Me.lbl本支店名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl本支店名.Text = "本支店名"
        Me.lbl本支店名.Top = 1.564173!
        Me.lbl本支店名.Width = 0.5!
        '
        'lbl代表者役職_代表者名
        '
        Me.lbl代表者役職_代表者名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl代表者役職_代表者名.Height = 0.1968504!
        Me.lbl代表者役職_代表者名.HyperLink = Nothing
        Me.lbl代表者役職_代表者名.Left = 0.0!
        Me.lbl代表者役職_代表者名.Name = "lbl代表者役職_代表者名"
        Me.lbl代表者役職_代表者名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-ali" & _
    "gn: bottom; ddo-char-set: 1"
        Me.lbl代表者役職_代表者名.Text = "代表者"
        Me.lbl代表者役職_代表者名.Top = 0.9964567!
        Me.lbl代表者役職_代表者名.Width = 0.3937008!
        '
        'lbl部署名
        '
        Me.lbl部署名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl部署名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl部署名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl部署名.Height = 0.2019685!
        Me.lbl部署名.HyperLink = Nothing
        Me.lbl部署名.Left = 0.5!
        Me.lbl部署名.Name = "lbl部署名"
        Me.lbl部署名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl部署名.Text = "部署名"
        Me.lbl部署名.Top = 1.564173!
        Me.lbl部署名.Width = 0.6244096!
        '
        'lbl担当者名
        '
        Me.lbl担当者名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl担当者名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl担当者名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl担当者名.Height = 0.2019685!
        Me.lbl担当者名.HyperLink = Nothing
        Me.lbl担当者名.Left = 3.564567!
        Me.lbl担当者名.Name = "lbl担当者名"
        Me.lbl担当者名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: left; vertical-alig" & _
    "n: bottom; ddo-char-set: 1"
        Me.lbl担当者名.Text = "担当者名"
        Me.lbl担当者名.Top = 1.564173!
        Me.lbl担当者名.Width = 1.732283!
        '
        'lbl備考欄
        '
        Me.lbl備考欄.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考欄.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考欄.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考欄.Height = 0.2019685!
        Me.lbl備考欄.HyperLink = Nothing
        Me.lbl備考欄.Left = 5.296851!
        Me.lbl備考欄.Name = "lbl備考欄"
        Me.lbl備考欄.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: left; vertical-alig" & _
    "n: bottom; ddo-char-set: 1"
        Me.lbl備考欄.Text = "備考欄"
        Me.lbl備考欄.Top = 1.564174!
        Me.lbl備考欄.Width = 2.387795!
        '
        'lbl住所
        '
        Me.lbl住所.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl住所.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl住所.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl住所.Height = 0.2019685!
        Me.lbl住所.HyperLink = Nothing
        Me.lbl住所.Left = 1.12441!
        Me.lbl住所.Name = "lbl住所"
        Me.lbl住所.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: left; vertical-alig" & _
    "n: bottom; ddo-char-set: 1"
        Me.lbl住所.Text = "住所"
        Me.lbl住所.Top = 1.564173!
        Me.lbl住所.Width = 2.440157!
        '
        'txt得意先名
        '
        Me.txt得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Height = 0.197!
        Me.txt得意先名.Left = 0.5000001!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 12pt; vertical-align: bottom; ddo-char-set: 1"
        Me.txt得意先名.Text = "ああああああああああいいいいいい"
        Me.txt得意先名.Top = 0.1964567!
        Me.txt得意先名.Width = 3.2!
        '
        'txt得意先CD
        '
        Me.txt得意先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Height = 0.197!
        Me.txt得意先CD.Left = 0.0!
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt得意先CD.Text = "999999"
        Me.txt得意先CD.Top = 0.1964567!
        Me.txt得意先CD.Width = 0.5!
        '
        'txt代表者役職_代表者名
        '
        Me.txt代表者役職_代表者名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt代表者役職_代表者名.Height = 0.3937008!
        Me.txt代表者役職_代表者名.Left = 0.3937008!
        Me.txt代表者役職_代表者名.Name = "txt代表者役職_代表者名"
        Me.txt代表者役職_代表者名.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.txt代表者役職_代表者名.Style = "font-family: ＭＳ 明朝; font-size: 12pt; vertical-align: bottom; ddo-char-set: 1"
        Me.txt代表者役職_代表者名.Text = "ああああああああああいいいいいいううううううううううええええええ"
        Me.txt代表者役職_代表者名.Top = 0.7996063!
        Me.txt代表者役職_代表者名.Width = 2.783465!
        '
        'lbl締日
        '
        Me.lbl締日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl締日.Height = 0.1968504!
        Me.lbl締日.HyperLink = Nothing
        Me.lbl締日.Left = 3.177166!
        Me.lbl締日.Name = "lbl締日"
        Me.lbl締日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-ali" & _
    "gn: bottom; ddo-char-set: 1"
        Me.lbl締日.Text = "締日"
        Me.lbl締日.Top = 0.9964567!
        Me.lbl締日.Width = 0.2755905!
        '
        'txt締日名
        '
        Me.txt締日名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt締日名.Height = 0.1968504!
        Me.txt締日名.Left = 3.452756!
        Me.txt締日名.Name = "txt締日名"
        Me.txt締日名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; vertical-align: bottom; ddo-char-set: 1"
        Me.txt締日名.Text = "あああ"
        Me.txt締日名.Top = 0.9964567!
        Me.txt締日名.Width = 0.511811!
        '
        'lbl回収条件
        '
        Me.lbl回収条件.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl回収条件.Height = 0.1968504!
        Me.lbl回収条件.HyperLink = Nothing
        Me.lbl回収条件.Left = 3.966536!
        Me.lbl回収条件.Name = "lbl回収条件"
        Me.lbl回収条件.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-ali" & _
    "gn: bottom; ddo-char-set: 1"
        Me.lbl回収条件.Text = "回収条件"
        Me.lbl回収条件.Top = 0.9964567!
        Me.lbl回収条件.Width = 0.5488181!
        '
        'txt回収条件以上設定金額
        '
        Me.txt回収条件以上設定金額.Height = 0.1968504!
        Me.txt回収条件以上設定金額.Left = 4.515355!
        Me.txt回収条件以上設定金額.Name = "txt回収条件以上設定金額"
        Me.txt回収条件以上設定金額.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt回収条件以上設定金額.Text = "999,999,999"
        Me.txt回収条件以上設定金額.Top = 0.7996063!
        Me.txt回収条件以上設定金額.Width = 0.7283465!
        '
        'txt回収条件未満設定金額
        '
        Me.txt回収条件未満設定金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt回収条件未満設定金額.Height = 0.1968504!
        Me.txt回収条件未満設定金額.Left = 4.515355!
        Me.txt回収条件未満設定金額.Name = "txt回収条件未満設定金額"
        Me.txt回収条件未満設定金額.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt回収条件未満設定金額.Text = "999,999,999"
        Me.txt回収条件未満設定金額.Top = 0.9964567!
        Me.txt回収条件未満設定金額.Width = 0.7283463!
        '
        'txt回収条件未満
        '
        Me.txt回収条件未満.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt回収条件未満.Height = 0.1968504!
        Me.txt回収条件未満.Left = 5.716142!
        Me.txt回収条件未満.Name = "txt回収条件未満"
        Me.txt回収条件未満.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.txt回収条件未満.Style = "font-family: ＭＳ 明朝; font-size: 11pt; vertical-align: bottom; ddo-char-set: 1"
        Me.txt回収条件未満.Text = "あああ"
        Me.txt回収条件未満.Top = 0.9964567!
        Me.txt回収条件未満.Width = 1.968504!
        '
        'txt回収条件以上
        '
        Me.txt回収条件以上.Height = 0.1968504!
        Me.txt回収条件以上.Left = 5.716142!
        Me.txt回収条件以上.Name = "txt回収条件以上"
        Me.txt回収条件以上.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.txt回収条件以上.Style = "font-family: ＭＳ 明朝; font-size: 11pt; vertical-align: bottom; ddo-char-set: 1"
        Me.txt回収条件以上.Text = "あああ"
        Me.txt回収条件以上.Top = 0.7996063!
        Me.txt回収条件以上.Width = 1.968504!
        '
        'lbl円以上
        '
        Me.lbl円以上.Height = 0.1968504!
        Me.lbl円以上.HyperLink = Nothing
        Me.lbl円以上.Left = 5.243701!
        Me.lbl円以上.Name = "lbl円以上"
        Me.lbl円以上.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8.25pt; text-align: center; vertical" & _
    "-align: bottom; ddo-char-set: 128"
        Me.lbl円以上.Text = "円以上"
        Me.lbl円以上.Top = 0.7996063!
        Me.lbl円以上.Width = 0.472441!
        '
        'lbl円未満
        '
        Me.lbl円未満.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl円未満.Height = 0.1968504!
        Me.lbl円未満.HyperLink = Nothing
        Me.lbl円未満.Left = 5.243701!
        Me.lbl円未満.Name = "lbl円未満"
        Me.lbl円未満.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8.25pt; text-align: center; vertical" & _
    "-align: bottom; ddo-char-set: 128"
        Me.lbl円未満.Text = "円未満"
        Me.lbl円未満.Top = 0.9964567!
        Me.lbl円未満.Width = 0.472441!
        '
        'ｌｂｌ自社担当者名
        '
        Me.ｌｂｌ自社担当者名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ自社担当者名.Height = 0.197!
        Me.ｌｂｌ自社担当者名.HyperLink = Nothing
        Me.ｌｂｌ自社担当者名.Left = 5.609843!
        Me.ｌｂｌ自社担当者名.Name = "ｌｂｌ自社担当者名"
        Me.ｌｂｌ自社担当者名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-ali" & _
    "gn: bottom; ddo-char-set: 1"
        Me.ｌｂｌ自社担当者名.Text = "社内担当"
        Me.ｌｂｌ自社担当者名.Top = 0.4956693!
        Me.ｌｂｌ自社担当者名.Width = 0.5000001!
        '
        'txt自社担当者名
        '
        Me.txt自社担当者名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt自社担当者名.Height = 0.1968504!
        Me.txt自社担当者名.Left = 6.109843!
        Me.txt自社担当者名.Name = "txt自社担当者名"
        Me.txt自社担当者名.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.txt自社担当者名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; vertical-align: bottom; ddo-char-set: 1"
        Me.txt自社担当者名.Text = "ああああああああああい"
        Me.txt自社担当者名.Top = 0.4956693!
        Me.txt自社担当者名.Width = 1.574803!
        '
        'txt回収条件以上回収月名
        '
        Me.txt回収条件以上回収月名.Height = 0.1968504!
        Me.txt回収条件以上回収月名.Left = 4.555119!
        Me.txt回収条件以上回収月名.Name = "txt回収条件以上回収月名"
        Me.txt回収条件以上回収月名.Style = "background-color: Red; font-family: ＭＳ 明朝; font-size: 10pt; vertical-align: botto" & _
    "m; ddo-char-set: 1"
        Me.txt回収条件以上回収月名.Text = Nothing
        Me.txt回収条件以上回収月名.Top = 0.4956693!
        Me.txt回収条件以上回収月名.Visible = False
        Me.txt回収条件以上回収月名.Width = 0.1181102!
        '
        'txt回収条件未満回収月名
        '
        Me.txt回収条件未満回収月名.Height = 0.1968504!
        Me.txt回収条件未満回収月名.Left = 4.673229!
        Me.txt回収条件未満回収月名.Name = "txt回収条件未満回収月名"
        Me.txt回収条件未満回収月名.Style = "background-color: Red; font-family: ＭＳ 明朝; font-size: 10pt; vertical-align: botto" & _
    "m; ddo-char-set: 1"
        Me.txt回収条件未満回収月名.Text = Nothing
        Me.txt回収条件未満回収月名.Top = 0.4956693!
        Me.txt回収条件未満回収月名.Visible = False
        Me.txt回収条件未満回収月名.Width = 0.1181103!
        '
        'txt回収条件以上回収日名
        '
        Me.txt回収条件以上回収日名.Height = 0.1968504!
        Me.txt回収条件以上回収日名.Left = 4.797245!
        Me.txt回収条件以上回収日名.Name = "txt回収条件以上回収日名"
        Me.txt回収条件以上回収日名.Style = "background-color: Red; font-family: ＭＳ 明朝; font-size: 10pt; vertical-align: botto" & _
    "m; ddo-char-set: 1"
        Me.txt回収条件以上回収日名.Text = Nothing
        Me.txt回収条件以上回収日名.Top = 0.4956693!
        Me.txt回収条件以上回収日名.Visible = False
        Me.txt回収条件以上回収日名.Width = 0.1181103!
        '
        'txt回収条件未満回収日名
        '
        Me.txt回収条件未満回収日名.Height = 0.1968504!
        Me.txt回収条件未満回収日名.Left = 4.925591!
        Me.txt回収条件未満回収日名.Name = "txt回収条件未満回収日名"
        Me.txt回収条件未満回収日名.Style = "background-color: Red; font-family: ＭＳ 明朝; font-size: 10pt; vertical-align: botto" & _
    "m; ddo-char-set: 1"
        Me.txt回収条件未満回収日名.Text = Nothing
        Me.txt回収条件未満回収日名.Top = 0.4956693!
        Me.txt回収条件未満回収日名.Visible = False
        Me.txt回収条件未満回収日名.Width = 0.1181102!
        '
        'txt回収条件以上回収方法名
        '
        Me.txt回収条件以上回収方法名.Height = 0.1968504!
        Me.txt回収条件以上回収方法名.Left = 5.053937!
        Me.txt回収条件以上回収方法名.Name = "txt回収条件以上回収方法名"
        Me.txt回収条件以上回収方法名.Style = "background-color: Red; font-family: ＭＳ 明朝; font-size: 10pt; vertical-align: botto" & _
    "m; ddo-char-set: 1"
        Me.txt回収条件以上回収方法名.Text = Nothing
        Me.txt回収条件以上回収方法名.Top = 0.4956693!
        Me.txt回収条件以上回収方法名.Visible = False
        Me.txt回収条件以上回収方法名.Width = 0.1181102!
        '
        'txt回収条件未満回収方法名
        '
        Me.txt回収条件未満回収方法名.Height = 0.1968504!
        Me.txt回収条件未満回収方法名.Left = 5.178741!
        Me.txt回収条件未満回収方法名.Name = "txt回収条件未満回収方法名"
        Me.txt回収条件未満回収方法名.Style = "background-color: Red; font-family: ＭＳ 明朝; font-size: 10pt; vertical-align: botto" & _
    "m; ddo-char-set: 1"
        Me.txt回収条件未満回収方法名.Text = Nothing
        Me.txt回収条件未満回収方法名.Top = 0.4956693!
        Me.txt回収条件未満回収方法名.Visible = False
        Me.txt回収条件未満回収方法名.Width = 0.1181102!
        '
        'txt代表者役職_代表者名1
        '
        Me.txt代表者役職_代表者名1.Height = 0.1968504!
        Me.txt代表者役職_代表者名1.Left = 0.0!
        Me.txt代表者役職_代表者名1.Name = "txt代表者役職_代表者名1"
        Me.txt代表者役職_代表者名1.Style = "background-color: Red; font-family: ＭＳ 明朝; font-size: 10pt; vertical-align: botto" & _
    "m; ddo-char-set: 1"
        Me.txt代表者役職_代表者名1.Text = Nothing
        Me.txt代表者役職_代表者名1.Top = 0.4956693!
        Me.txt代表者役職_代表者名1.Visible = False
        Me.txt代表者役職_代表者名1.Width = 0.1181102!
        '
        'txt代表者役職_代表者名2
        '
        Me.txt代表者役職_代表者名2.Height = 0.1968504!
        Me.txt代表者役職_代表者名2.Left = 0.1283465!
        Me.txt代表者役職_代表者名2.Name = "txt代表者役職_代表者名2"
        Me.txt代表者役職_代表者名2.Style = "background-color: Red; font-family: ＭＳ 明朝; font-size: 10pt; vertical-align: botto" & _
    "m; ddo-char-set: 1"
        Me.txt代表者役職_代表者名2.Text = Nothing
        Me.txt代表者役職_代表者名2.Top = 0.4956693!
        Me.txt代表者役職_代表者名2.Visible = False
        Me.txt代表者役職_代表者名2.Width = 0.1181102!
        '
        'grpFtr得意先CD
        '
        Me.grpFtr得意先CD.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.SubReport, Me.Label2, Me.Line1, Me.Line2, Me.Line3, Me.Line4})
        Me.grpFtr得意先CD.Height = 2.755906!
        Me.grpFtr得意先CD.Name = "grpFtr得意先CD"
        '
        'SubReport
        '
        Me.SubReport.CloseBorder = False
        Me.SubReport.Height = 2.559055!
        Me.SubReport.Left = 0.2637796!
        Me.SubReport.Name = "SubReport"
        Me.SubReport.Report = Nothing
        Me.SubReport.ReportName = ""
        Me.SubReport.Top = 0.1968504!
        Me.SubReport.Width = 7.401575!
        '
        'Label2
        '
        Me.Label2.Height = 0.1968504!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.0!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8.25pt; text-align: right; vertical-" & _
    "align: middle; ddo-char-set: 128"
        Me.Label2.Text = "特記事項"
        Me.Label2.Top = 0.0!
        Me.Label2.Width = 0.5905512!
        '
        'Line1
        '
        Me.Line1.Height = 2.755906!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0!
        Me.Line1.Width = 0.0!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 0.0!
        Me.Line1.Y1 = 0.0!
        Me.Line1.Y2 = 2.755906!
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.0!
        Me.Line2.Width = 7.684646!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 7.684646!
        Me.Line2.Y1 = 0.0!
        Me.Line2.Y2 = 0.0!
        '
        'Line3
        '
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.0!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 2.755906!
        Me.Line3.Width = 7.684646!
        Me.Line3.X1 = 0.0!
        Me.Line3.X2 = 7.684646!
        Me.Line3.Y1 = 2.755906!
        Me.Line3.Y2 = 2.755906!
        '
        'Line4
        '
        Me.Line4.Height = 2.755905!
        Me.Line4.Left = 7.684646!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.0!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 7.684646!
        Me.Line4.X2 = 7.684646!
        Me.Line4.Y1 = 0.0!
        Me.Line4.Y2 = 2.755905!
        '
        'txtdtl行NO
        '
        Me.txtdtl行NO.Height = 0.1968504!
        Me.txtdtl行NO.Left = 0.0!
        Me.txtdtl行NO.Name = "txtdtl行NO"
        Me.txtdtl行NO.Style = "background-color: Red; font-family: ＭＳ 明朝; font-size: 10pt; vertical-align: botto" & _
    "m; ddo-char-set: 1"
        Me.txtdtl行NO.Text = Nothing
        Me.txtdtl行NO.Top = 0.0!
        Me.txtdtl行NO.Visible = False
        Me.txtdtl行NO.Width = 0.1181102!
        '
        'CustomerList
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.695063!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr得意先CD)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr得意先CD)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl本支店名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl部署名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl郵便番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl担当者名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtlTEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl住所1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl住所2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbldtlTEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbldtlFAX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbldtl携帯, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtlFAX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl携帯, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbldtlメール, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtlメール, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl本支店名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl代表者役職_代表者名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl部署名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl担当者名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl備考欄, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl住所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt代表者役職_代表者名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl締日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt締日名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl回収条件, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt回収条件以上設定金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt回収条件未満設定金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt回収条件未満, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt回収条件以上, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl円以上, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl円未満, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ｌｂｌ自社担当者名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt自社担当者名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt回収条件以上回収月名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt回収条件未満回収月名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt回収条件以上回収日名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt回収条件未満回収日名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt回収条件以上回収方法名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt回収条件未満回収方法名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt代表者役職_代表者名1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt代表者役職_代表者名2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl行NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents grpHdr得意先CD As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents grpFtr得意先CD As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents lbl本支店名 As DataDynamics.ActiveReports.Label
    Friend WithEvents lblTitle As DataDynamics.ActiveReports.Label
    Private WithEvents lbl代表者役職_代表者名 As DataDynamics.ActiveReports.Label
    Private WithEvents txtdtl本支店名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl部署名 As DataDynamics.ActiveReports.Label
    Private WithEvents txtdtl部署名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl郵便番号 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl担当者名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl備考欄 As DataDynamics.ActiveReports.Label
    Private WithEvents txtdtl担当者名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtlTEL As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl住所 As DataDynamics.ActiveReports.Label
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents txt代表者役職_代表者名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl締日 As DataDynamics.ActiveReports.Label
    Private WithEvents txt締日名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl回収条件 As DataDynamics.ActiveReports.Label
    Private WithEvents txt回収条件以上設定金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt回収条件未満設定金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt回収条件未満 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt回収条件以上 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl円以上 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl円未満 As DataDynamics.ActiveReports.Label
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents txtdtl住所1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl住所2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbldtlTEL As DataDynamics.ActiveReports.Label
    Private WithEvents lbldtlFAX As DataDynamics.ActiveReports.Label
    Private WithEvents lbldtl携帯 As DataDynamics.ActiveReports.Label
    Private WithEvents txtdtlFAX As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl携帯 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbldtlメール As DataDynamics.ActiveReports.Label
    Private WithEvents txtdtlメール As DataDynamics.ActiveReports.TextBox
    Private WithEvents ｌｂｌ自社担当者名 As DataDynamics.ActiveReports.Label
    Private WithEvents txt自社担当者名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt回収条件以上回収月名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt回収条件未満回収月名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt回収条件以上回収日名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt回収条件未満回収日名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt回収条件以上回収方法名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt回収条件未満回収方法名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents SubReport As DataDynamics.ActiveReports.SubReport
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Private WithEvents Line3 As DataDynamics.ActiveReports.Line
    Private WithEvents Line4 As DataDynamics.ActiveReports.Line
    Private WithEvents txt代表者役職_代表者名1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt代表者役職_代表者名2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtdtl行NO As DataDynamics.ActiveReports.TextBox
End Class
