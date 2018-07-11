<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class QuotationTotalInner
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(QuotationTotalInner))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt入金明細表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl積算日 = New DataDynamics.ActiveReports.Label()
        Me.txt積算日 = New DataDynamics.ActiveReports.TextBox()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl積算No = New DataDynamics.ActiveReports.Label()
        Me.txt積算No = New DataDynamics.ActiveReports.TextBox()
        Me.txt入力担当CD = New DataDynamics.ActiveReports.TextBox()
        Me.grpFtr = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.lbl見積数量 = New DataDynamics.ActiveReports.Label()
        Me.txt見積数量 = New DataDynamics.ActiveReports.TextBox()
        Me.txt3見積数量 = New DataDynamics.ActiveReports.TextBox()
        Me.txt2見積数量 = New DataDynamics.ActiveReports.TextBox()
        Me.txt5見積数量 = New DataDynamics.ActiveReports.TextBox()
        Me.txt4見積数量 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt入金明細表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl積算日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt積算日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl積算No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt積算No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入力担当CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl見積数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt見積数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3見積数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt2見積数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt5見積数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4見積数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lbl見積数量, Me.txt見積数量, Me.txt3見積数量, Me.txt2見積数量, Me.txt5見積数量, Me.txt4見積数量})
        Me.Detail.Height = 0.1968504!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt頁, Me.txtNow})
        Me.PageFooter.Height = 0.2362205!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdr
        '
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt入金明細表, Me.lbl積算日, Me.txt積算日, Me.Label3, Me.TextBox5, Me.lbl積算No, Me.txt積算No, Me.txt入力担当CD})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.5430613!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txt入金明細表
        '
        Me.txt入金明細表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt入金明細表.CharacterSpacing = 5.0!
        Me.txt入金明細表.Height = 0.307874!
        Me.txt入金明細表.Left = 0.0!
        Me.txt入金明細表.Name = "txt入金明細表"
        Me.txt入金明細表.Style = "font-family: ＭＳ 明朝; font-size: 16pt; font-weight: bold; text-align: center; verti" & _
    "cal-align: bottom; ddo-char-set: 1"
        Me.txt入金明細表.Text = "見積積算表(内訳)"
        Me.txt入金明細表.Top = 0.0!
        Me.txt入金明細表.Width = 2.637795!
        '
        'lbl積算日
        '
        Me.lbl積算日.Height = 0.1574803!
        Me.lbl積算日.HyperLink = Nothing
        Me.lbl積算日.Left = 3.466142!
        Me.lbl積算日.Name = "lbl積算日"
        Me.lbl積算日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbl積算日.Text = "積算年月日"
        Me.lbl積算日.Top = 0.05118111!
        Me.lbl積算日.Width = 0.7874016!
        '
        'txt積算日
        '
        Me.txt積算日.Height = 0.1574803!
        Me.txt積算日.Left = 3.466142!
        Me.txt積算日.Name = "txt積算日"
        Me.txt積算日.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txt積算日.Text = "YY/MM/DD"
        Me.txt積算日.Top = 0.2086614!
        Me.txt積算日.Width = 0.7874016!
        '
        'Label3
        '
        Me.Label3.Height = 0.1574803!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 4.687402!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label3.Text = "担当者"
        Me.Label3.Top = 0.05118111!
        Me.Label3.Width = 0.9055118!
        '
        'TextBox5
        '
        Me.TextBox5.Height = 0.1574803!
        Me.TextBox5.Left = 4.687402!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox5.Text = "あああああいい"
        Me.TextBox5.Top = 0.2086614!
        Me.TextBox5.Width = 0.9055118!
        '
        'lbl積算No
        '
        Me.lbl積算No.Height = 0.1574803!
        Me.lbl積算No.HyperLink = Nothing
        Me.lbl積算No.Left = 6.550394!
        Me.lbl積算No.Name = "lbl積算No"
        Me.lbl積算No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl積算No.Text = "積算No"
        Me.lbl積算No.Top = 0.01023622!
        Me.lbl積算No.Width = 0.8118109!
        '
        'txt積算No
        '
        Me.txt積算No.Height = 0.1968504!
        Me.txt積算No.Left = 6.550394!
        Me.txt積算No.Name = "txt積算No"
        Me.txt積算No.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: justify; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt積算No.Text = "123456"
        Me.txt積算No.Top = 0.1677165!
        Me.txt積算No.Width = 0.8118109!
        '
        'txt入力担当CD
        '
        Me.txt入力担当CD.Height = 0.1574803!
        Me.txt入力担当CD.Left = 5.475591!
        Me.txt入力担当CD.Name = "txt入力担当CD"
        Me.txt入力担当CD.Style = "background-color: Red; font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; v" & _
    "ertical-align: bottom; ddo-char-set: 1"
        Me.txt入力担当CD.Text = "99"
        Me.txt入力担当CD.Top = 0.05275591!
        Me.txt入力担当CD.Visible = False
        Me.txt入力担当CD.Width = 0.1574803!
        '
        'grpFtr
        '
        Me.grpFtr.Height = 0.0!
        Me.grpFtr.Name = "grpFtr"
        '
        'txt頁
        '
        Me.txt頁.Height = 0.1968504!
        Me.txt頁.Left = 3.173229!
        Me.txt頁.Name = "txt頁"
        Me.txt頁.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; text-justify: auto; verti" & _
    "cal-align: middle; ddo-char-set: 1"
        Me.txt頁.Text = "頁"
        Me.txt頁.Top = 0.02047244!
        Me.txt頁.Width = 0.3795276!
        '
        'txtNow
        '
        Me.txtNow.Height = 0.1968504!
        Me.txtNow.Left = 5.414183!
        Me.txtNow.Name = "txtNow"
        Me.txtNow.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; text-justify: auto; verti" & _
    "cal-align: middle; ddo-char-set: 1"
        Me.txtNow.Text = "YY/MM/DD　00:00:00 作成"
        Me.txtNow.Top = 0.02047244!
        Me.txtNow.Width = 1.771653!
        '
        'lbl見積数量
        '
        Me.lbl見積数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl見積数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl見積数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl見積数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl見積数量.Height = 0.1968504!
        Me.lbl見積数量.HyperLink = Nothing
        Me.lbl見積数量.Left = 0.0!
        Me.lbl見積数量.Name = "lbl見積数量"
        Me.lbl見積数量.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbl見積数量.Text = "見積数量"
        Me.lbl見積数量.Top = 0.0!
        Me.lbl見積数量.Width = 2.047244!
        '
        'txt見積数量
        '
        Me.txt見積数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt見積数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt見積数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt見積数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt見積数量.Height = 0.1968504!
        Me.txt見積数量.Left = 2.047244!
        Me.txt見積数量.Name = "txt見積数量"
        Me.txt見積数量.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt見積数量.Text = "999,999枚"
        Me.txt見積数量.Top = 0.0!
        Me.txt見積数量.Width = 1.023622!
        '
        'txt3見積数量
        '
        Me.txt3見積数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3見積数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3見積数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3見積数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3見積数量.Height = 0.1968504!
        Me.txt3見積数量.Left = 4.094488!
        Me.txt3見積数量.Name = "txt3見積数量"
        Me.txt3見積数量.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt3見積数量.Text = "999,999枚"
        Me.txt3見積数量.Top = 0.0!
        Me.txt3見積数量.Width = 1.062992!
        '
        'txt2見積数量
        '
        Me.txt2見積数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2見積数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2見積数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2見積数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2見積数量.Height = 0.1968504!
        Me.txt2見積数量.Left = 3.070866!
        Me.txt2見積数量.Name = "txt2見積数量"
        Me.txt2見積数量.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt2見積数量.Text = "999,999枚"
        Me.txt2見積数量.Top = 0.0!
        Me.txt2見積数量.Width = 1.023622!
        '
        'txt5見積数量
        '
        Me.txt5見積数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5見積数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5見積数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5見積数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5見積数量.Height = 0.1968504!
        Me.txt5見積数量.Left = 6.181103!
        Me.txt5見積数量.Name = "txt5見積数量"
        Me.txt5見積数量.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt5見積数量.Text = "999,999枚"
        Me.txt5見積数量.Top = 0.0!
        Me.txt5見積数量.Width = 1.062992!
        '
        'txt4見積数量
        '
        Me.txt4見積数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4見積数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4見積数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4見積数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4見積数量.Height = 0.1968504!
        Me.txt4見積数量.Left = 5.15748!
        Me.txt4見積数量.Name = "txt4見積数量"
        Me.txt4見積数量.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt4見積数量.Text = "999,999枚"
        Me.txt4見積数量.Top = 0.0!
        Me.txt4見積数量.Width = 1.023622!
        '
        'QuotationTotalInner
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.244094!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt入金明細表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl積算日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt積算日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl積算No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt積算No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入力担当CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl見積数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt見積数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3見積数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt2見積数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt5見積数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4見積数量, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt入金明細表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpFtr As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents lbl積算日 As DataDynamics.ActiveReports.Label
    Private WithEvents txt積算日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl積算No As DataDynamics.ActiveReports.Label
    Private WithEvents txt積算No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt入力担当CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl見積数量 As DataDynamics.ActiveReports.Label
    Private WithEvents txt見積数量 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt3見積数量 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt2見積数量 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt5見積数量 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt4見積数量 As DataDynamics.ActiveReports.TextBox
End Class
