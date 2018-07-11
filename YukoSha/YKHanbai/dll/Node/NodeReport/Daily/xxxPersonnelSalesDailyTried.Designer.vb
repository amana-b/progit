<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xxxPersonnelSalesDailyTried
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(xxxPersonnelSalesDailyTried))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt仕入日 = New DataDynamics.ActiveReports.TextBox()
        Me.txtヌキ代 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtHdr仕入日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者別売上日計累計表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl仕入日 = New DataDynamics.ActiveReports.Label()
        Me.lbl担当者名 = New DataDynamics.ActiveReports.Label()
        Me.ｌｂｌ商品名 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr売上日 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txtヌキ代合計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl発送日計 = New DataDynamics.ActiveReports.Label()
        CType(Me.txt仕入日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtヌキ代, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr仕入日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者別売上日計累計表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl担当者名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ｌｂｌ商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr売上日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtヌキ代合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl発送日計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt仕入日, Me.txtヌキ代, Me.txt合計})
        Me.Detail.Height = 0.1968504!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt仕入日
        '
        Me.txt仕入日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入日.Height = 0.1968504!
        Me.txt仕入日.Left = 0.0!
        Me.txt仕入日.Name = "txt仕入日"
        Me.txt仕入日.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt仕入日.Text = "MM/DD(●)"
        Me.txt仕入日.Top = 0.0!
        Me.txt仕入日.Width = 1.003937!
        '
        'txtヌキ代
        '
        Me.txtヌキ代.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtヌキ代.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtヌキ代.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtヌキ代.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtヌキ代.Height = 0.1968504!
        Me.txtヌキ代.Left = 1.003937!
        Me.txtヌキ代.Name = "txtヌキ代"
        Me.txtヌキ代.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txtヌキ代.Text = "999,999,999"
        Me.txtヌキ代.Top = 0.0!
        Me.txtヌキ代.Width = 1.003937!
        '
        'txt合計
        '
        Me.txt合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計.Height = 0.1968504!
        Me.txt合計.Left = 2.007874!
        Me.txt合計.Name = "txt合計"
        Me.txt合計.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt合計.Text = "999,999,999"
        Me.txt合計.Top = 0.00000005960464!
        Me.txt合計.Width = 1.003937!
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
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtHdr仕入日, Me.txt担当者別売上日計累計表, Me.lbl仕入日, Me.lbl担当者名, Me.ｌｂｌ商品名, Me.lblHdr売上日})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.5913386!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txtHdr仕入日
        '
        Me.txtHdr仕入日.Height = 0.2362205!
        Me.txtHdr仕入日.Left = 0.7874014!
        Me.txtHdr仕入日.Name = "txtHdr仕入日"
        Me.txtHdr仕入日.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txtHdr仕入日.Text = "00/00/00～99/99/99　日迄"
        Me.txtHdr仕入日.Top = 0.0!
        Me.txtHdr仕入日.Width = 2.098425!
        '
        'txt担当者別売上日計累計表
        '
        Me.txt担当者別売上日計累計表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt担当者別売上日計累計表.Height = 0.2362205!
        Me.txt担当者別売上日計累計表.Left = 4.065748!
        Me.txt担当者別売上日計累計表.Name = "txt担当者別売上日計累計表"
        Me.txt担当者別売上日計累計表.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者別売上日計累計表.Text = "担当者別売上日計累計表"
        Me.txt担当者別売上日計累計表.Top = 0.08110237!
        Me.txt担当者別売上日計累計表.Width = 2.681497!
        '
        'lbl仕入日
        '
        Me.lbl仕入日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入日.Height = 0.1771654!
        Me.lbl仕入日.HyperLink = Nothing
        Me.lbl仕入日.Left = 0.0!
        Me.lbl仕入日.Name = "lbl仕入日"
        Me.lbl仕入日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl仕入日.Text = "　　日付"
        Me.lbl仕入日.Top = 0.4141732!
        Me.lbl仕入日.Width = 1.003937!
        '
        'lbl担当者名
        '
        Me.lbl担当者名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl担当者名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl担当者名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl担当者名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl担当者名.Height = 0.1771654!
        Me.lbl担当者名.HyperLink = Nothing
        Me.lbl担当者名.Left = 1.003937!
        Me.lbl担当者名.Name = "lbl担当者名"
        Me.lbl担当者名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl担当者名.Text = "担当者名"
        Me.lbl担当者名.Top = 0.4141732!
        Me.lbl担当者名.Width = 1.003937!
        '
        'ｌｂｌ商品名
        '
        Me.ｌｂｌ商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Height = 0.1771654!
        Me.ｌｂｌ商品名.HyperLink = Nothing
        Me.ｌｂｌ商品名.Left = 2.007874!
        Me.ｌｂｌ商品名.Name = "ｌｂｌ商品名"
        Me.ｌｂｌ商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.ｌｂｌ商品名.Text = "合計"
        Me.ｌｂｌ商品名.Top = 0.4141732!
        Me.ｌｂｌ商品名.Width = 1.003937!
        '
        'lblHdr売上日
        '
        Me.lblHdr売上日.Height = 0.2362205!
        Me.lblHdr売上日.HyperLink = Nothing
        Me.lblHdr売上日.Left = 0.0!
        Me.lblHdr売上日.Name = "lblHdr売上日"
        Me.lblHdr売上日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdr売上日.Text = "売上日"
        Me.lblHdr売上日.Top = 0.0!
        Me.lblHdr売上日.Width = 0.7874014!
        '
        'grpFtr
        '
        Me.grpFtr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt総合計, Me.txtヌキ代合計, Me.TextBox9, Me.lbl発送日計})
        Me.grpFtr.Height = 0.2755905!
        Me.grpFtr.Name = "grpFtr"
        '
        'txt総合計
        '
        Me.txt総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計.Height = 0.1968504!
        Me.txt総合計.Left = 2.007874!
        Me.txt総合計.Name = "txt総合計"
        Me.txt総合計.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt総合計.Text = "999,999,999" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt総合計.Top = 0.00000005960464!
        Me.txt総合計.Width = 1.003937!
        '
        'txtヌキ代合計
        '
        Me.txtヌキ代合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtヌキ代合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtヌキ代合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtヌキ代合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtヌキ代合計.Height = 0.1968504!
        Me.txtヌキ代合計.Left = 1.003937!
        Me.txtヌキ代合計.Name = "txtヌキ代合計"
        Me.txtヌキ代合計.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txtヌキ代合計.Text = "999,999,999"
        Me.txtヌキ代合計.Top = 0.0!
        Me.txtヌキ代合計.Width = 1.003937!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Height = 0.1968504!
        Me.TextBox9.Left = 0.0!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0.0!
        Me.TextBox9.Width = 1.003937!
        '
        'lbl発送日計
        '
        Me.lbl発送日計.Height = 0.1574803!
        Me.lbl発送日計.HyperLink = Nothing
        Me.lbl発送日計.Left = 0.2866142!
        Me.lbl発送日計.Name = "lbl発送日計"
        Me.lbl発送日計.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl発送日計.Text = "＊合計"
        Me.lbl発送日計.Top = 0.02047244!
        Me.lbl発送日計.Width = 0.5905512!
        '
        'PersonnelSalesDailyTried
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.84646!
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
        CType(Me.txt仕入日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtヌキ代, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr仕入日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者別売上日計累計表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl担当者名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ｌｂｌ商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr売上日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtヌキ代合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl発送日計, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt仕入日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtヌキ代 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpFtr As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtヌキ代合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr仕入日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者別売上日計累計表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl仕入日 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl担当者名 As DataDynamics.ActiveReports.Label
    Private WithEvents ｌｂｌ商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr売上日 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl発送日計 As DataDynamics.ActiveReports.Label
End Class
