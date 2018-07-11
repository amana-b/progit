<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ItemConfig
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ItemConfig))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt6商品構成資材No = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品構成資材No = New DataDynamics.ActiveReports.TextBox()
        Me.txt3商品構成資材No = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt2商品構成資材No = New DataDynamics.ActiveReports.TextBox()
        Me.txt5商品構成資材No = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品構成資材No4 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtHdr仕入日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt入金明細表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl6商品構成資材No = New DataDynamics.ActiveReports.Label()
        Me.lbl商品構成資材No = New DataDynamics.ActiveReports.Label()
        Me.lbl2商品構成資材No = New DataDynamics.ActiveReports.Label()
        Me.lblNo = New DataDynamics.ActiveReports.Label()
        Me.lbl3商品構成資材No = New DataDynamics.ActiveReports.Label()
        Me.lblHdr入金日 = New DataDynamics.ActiveReports.Label()
        Me.lbl5商品構成資材No = New DataDynamics.ActiveReports.Label()
        Me.lbl4商品構成資材No = New DataDynamics.ActiveReports.Label()
        Me.txt回収方法 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl商品名 = New DataDynamics.ActiveReports.Label()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt住所 = New DataDynamics.ActiveReports.TextBox()
        Me.txt法人 = New DataDynamics.ActiveReports.TextBox()
        Me.txt会社名 = New DataDynamics.ActiveReports.TextBox()
        Me.txtTEL = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.txtFAX = New DataDynamics.ActiveReports.TextBox()
        Me.lblHDNo = New DataDynamics.ActiveReports.Label()
        Me.grpFtr = New DataDynamics.ActiveReports.GroupFooter()
        CType(Me.txt6商品構成資材No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品構成資材No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3商品構成資材No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt2商品構成資材No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt5商品構成資材No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品構成資材No4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr仕入日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入金明細表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl6商品構成資材No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl商品構成資材No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl2商品構成資材No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl3商品構成資材No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr入金日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl5商品構成資材No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl4商品構成資材No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt回収方法, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt住所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt法人, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt会社名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFAX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHDNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt6商品構成資材No, Me.txt商品構成資材No, Me.txt3商品構成資材No, Me.txt得意先CD, Me.txt2商品構成資材No, Me.txt5商品構成資材No, Me.txt商品構成資材No4})
        Me.Detail.Height = 0.2755905!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt6商品構成資材No
        '
        Me.txt6商品構成資材No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt6商品構成資材No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt6商品構成資材No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt6商品構成資材No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt6商品構成資材No.Height = 0.2755905!
        Me.txt6商品構成資材No.Left = 9.409449!
        Me.txt6商品構成資材No.Name = "txt6商品構成資材No"
        Me.txt6商品構成資材No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt6商品構成資材No.Text = "12345678901234567890"
        Me.txt6商品構成資材No.Top = 0.0!
        Me.txt6商品構成資材No.Width = 1.653543!
        '
        'txt商品構成資材No
        '
        Me.txt商品構成資材No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品構成資材No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品構成資材No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品構成資材No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品構成資材No.CanGrow = False
        Me.txt商品構成資材No.Height = 0.2755905!
        Me.txt商品構成資材No.Left = 0.5511811!
        Me.txt商品構成資材No.Name = "txt商品構成資材No"
        Me.txt商品構成資材No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt商品構成資材No.Text = "12345678901234567890"
        Me.txt商品構成資材No.Top = 0.0000002384186!
        Me.txt商品構成資材No.Width = 2.30315!
        '
        'txt3商品構成資材No
        '
        Me.txt3商品構成資材No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3商品構成資材No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3商品構成資材No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3商品構成資材No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3商品構成資材No.Height = 0.2755905!
        Me.txt3商品構成資材No.Left = 4.488189!
        Me.txt3商品構成資材No.Name = "txt3商品構成資材No"
        Me.txt3商品構成資材No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt3商品構成資材No.Text = "12345678901234567890"
        Me.txt3商品構成資材No.Top = 0.0000002980233!
        Me.txt3商品構成資材No.Width = 1.653543!
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
        Me.txt得意先CD.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt得意先CD.Text = "123"
        Me.txt得意先CD.Top = 0.00000005960464!
        Me.txt得意先CD.Width = 0.5511811!
        '
        'txt2商品構成資材No
        '
        Me.txt2商品構成資材No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2商品構成資材No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2商品構成資材No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2商品構成資材No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2商品構成資材No.Height = 0.2755905!
        Me.txt2商品構成資材No.Left = 2.854331!
        Me.txt2商品構成資材No.Name = "txt2商品構成資材No"
        Me.txt2商品構成資材No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt2商品構成資材No.Text = "12345678901234567890"
        Me.txt2商品構成資材No.Top = 0.0000001192093!
        Me.txt2商品構成資材No.Width = 1.633858!
        '
        'txt5商品構成資材No
        '
        Me.txt5商品構成資材No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5商品構成資材No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5商品構成資材No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5商品構成資材No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5商品構成資材No.Height = 0.2755905!
        Me.txt5商品構成資材No.Left = 7.77559!
        Me.txt5商品構成資材No.Name = "txt5商品構成資材No"
        Me.txt5商品構成資材No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt5商品構成資材No.Text = "12345678901234567890"
        Me.txt5商品構成資材No.Top = 0.0000002980233!
        Me.txt5商品構成資材No.Width = 1.633858!
        '
        'txt商品構成資材No4
        '
        Me.txt商品構成資材No4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品構成資材No4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品構成資材No4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品構成資材No4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品構成資材No4.Height = 0.2755905!
        Me.txt商品構成資材No4.Left = 6.141732!
        Me.txt商品構成資材No4.Name = "txt商品構成資材No4"
        Me.txt商品構成資材No4.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt商品構成資材No4.Text = "12345678901234567890"
        Me.txt商品構成資材No4.Top = 0.0000005066395!
        Me.txt商品構成資材No4.Width = 1.633858!
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdr
        '
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtHdr仕入日, Me.txt入金明細表, Me.lbl6商品構成資材No, Me.lbl商品構成資材No, Me.lbl2商品構成資材No, Me.lblNo, Me.lbl3商品構成資材No, Me.lblHdr入金日, Me.lbl5商品構成資材No, Me.lbl4商品構成資材No, Me.txt回収方法, Me.txt得意先名, Me.lbl商品名, Me.txt商品名, Me.txt住所, Me.txt法人, Me.txt会社名, Me.txtTEL, Me.TextBox4, Me.txtFAX, Me.lblHDNo})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 1.705512!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txtHdr仕入日
        '
        Me.txtHdr仕入日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txtHdr仕入日.Height = 0.2362205!
        Me.txtHdr仕入日.Left = 0.7874016!
        Me.txtHdr仕入日.Name = "txtHdr仕入日"
        Me.txtHdr仕入日.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txtHdr仕入日.Text = "123456"
        Me.txtHdr仕入日.Top = 0.9929135!
        Me.txtHdr仕入日.Width = 0.6299213!
        '
        'txt入金明細表
        '
        Me.txt入金明細表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt入金明細表.CharacterSpacing = 10.0!
        Me.txt入金明細表.Height = 0.3149606!
        Me.txt入金明細表.Left = 4.065748!
        Me.txt入金明細表.Name = "txt入金明細表"
        Me.txt入金明細表.Style = "font-family: ＭＳ 明朝; font-size: 16pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt入金明細表.Text = "商品構成表"
        Me.txt入金明細表.Top = 0.0!
        Me.txt入金明細表.Width = 2.047244!
        '
        'lbl6商品構成資材No
        '
        Me.lbl6商品構成資材No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl6商品構成資材No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl6商品構成資材No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl6商品構成資材No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl6商品構成資材No.Height = 0.3346457!
        Me.lbl6商品構成資材No.HyperLink = Nothing
        Me.lbl6商品構成資材No.Left = 9.409449!
        Me.lbl6商品構成資材No.Name = "lbl6商品構成資材No"
        Me.lbl6商品構成資材No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl6商品構成資材No.Text = "商品構成資材No"
        Me.lbl6商品構成資材No.Top = 1.370865!
        Me.lbl6商品構成資材No.Width = 1.653543!
        '
        'lbl商品構成資材No
        '
        Me.lbl商品構成資材No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品構成資材No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品構成資材No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品構成資材No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品構成資材No.Height = 0.3346457!
        Me.lbl商品構成資材No.HyperLink = Nothing
        Me.lbl商品構成資材No.Left = 0.5511811!
        Me.lbl商品構成資材No.Name = "lbl商品構成資材No"
        Me.lbl商品構成資材No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl商品構成資材No.Text = "商品構成資材No"
        Me.lbl商品構成資材No.Top = 1.370866!
        Me.lbl商品構成資材No.Width = 2.30315!
        '
        'lbl2商品構成資材No
        '
        Me.lbl2商品構成資材No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2商品構成資材No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2商品構成資材No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2商品構成資材No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2商品構成資材No.Height = 0.3346457!
        Me.lbl2商品構成資材No.HyperLink = Nothing
        Me.lbl2商品構成資材No.Left = 2.854331!
        Me.lbl2商品構成資材No.Name = "lbl2商品構成資材No"
        Me.lbl2商品構成資材No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl2商品構成資材No.Text = "商品構成資材No"
        Me.lbl2商品構成資材No.Top = 1.370866!
        Me.lbl2商品構成資材No.Width = 1.633858!
        '
        'lblNo
        '
        Me.lblNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblNo.CharacterSpacing = 5.0!
        Me.lblNo.Height = 0.3346457!
        Me.lblNo.HyperLink = Nothing
        Me.lblNo.Left = 0.0!
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lblNo.Text = "No"
        Me.lblNo.Top = 1.370866!
        Me.lblNo.Width = 0.5511811!
        '
        'lbl3商品構成資材No
        '
        Me.lbl3商品構成資材No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl3商品構成資材No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl3商品構成資材No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl3商品構成資材No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl3商品構成資材No.Height = 0.3346457!
        Me.lbl3商品構成資材No.HyperLink = Nothing
        Me.lbl3商品構成資材No.Left = 4.488189!
        Me.lbl3商品構成資材No.Name = "lbl3商品構成資材No"
        Me.lbl3商品構成資材No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl3商品構成資材No.Text = "商品構成資材No"
        Me.lbl3商品構成資材No.Top = 1.370866!
        Me.lbl3商品構成資材No.Width = 1.653543!
        '
        'lblHdr入金日
        '
        Me.lblHdr入金日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lblHdr入金日.Height = 0.2362205!
        Me.lblHdr入金日.HyperLink = Nothing
        Me.lblHdr入金日.Left = 0.0000002384186!
        Me.lblHdr入金日.Name = "lblHdr入金日"
        Me.lblHdr入金日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdr入金日.Text = "製造ﾛｯﾄNo."
        Me.lblHdr入金日.Top = 0.9929135!
        Me.lblHdr入金日.Width = 0.7874014!
        '
        'lbl5商品構成資材No
        '
        Me.lbl5商品構成資材No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl5商品構成資材No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl5商品構成資材No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl5商品構成資材No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl5商品構成資材No.Height = 0.3346457!
        Me.lbl5商品構成資材No.HyperLink = Nothing
        Me.lbl5商品構成資材No.Left = 7.77559!
        Me.lbl5商品構成資材No.Name = "lbl5商品構成資材No"
        Me.lbl5商品構成資材No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl5商品構成資材No.Text = "商品構成資材No"
        Me.lbl5商品構成資材No.Top = 1.370866!
        Me.lbl5商品構成資材No.Width = 1.633858!
        '
        'lbl4商品構成資材No
        '
        Me.lbl4商品構成資材No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl4商品構成資材No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl4商品構成資材No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl4商品構成資材No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl4商品構成資材No.Height = 0.3346457!
        Me.lbl4商品構成資材No.HyperLink = Nothing
        Me.lbl4商品構成資材No.Left = 6.141732!
        Me.lbl4商品構成資材No.Name = "lbl4商品構成資材No"
        Me.lbl4商品構成資材No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl4商品構成資材No.Text = "商品構成資材No"
        Me.lbl4商品構成資材No.Top = 1.370866!
        Me.lbl4商品構成資材No.Width = 1.633858!
        '
        'txt回収方法
        '
        Me.txt回収方法.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt回収方法.Height = 0.2362205!
        Me.txt回収方法.Left = 5.688976!
        Me.txt回収方法.Name = "txt回収方法"
        Me.txt回収方法.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt回収方法.Text = "123456789"
        Me.txt回収方法.Top = 0.9929135!
        Me.txt回収方法.Width = 0.984252!
        '
        'txt得意先名
        '
        Me.txt得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt得意先名.Height = 0.2362205!
        Me.txt得意先名.Left = 0.0!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt得意先名.Text = "あああああいいいいい　　　御中"
        Me.txt得意先名.Top = 0.1330709!
        Me.txt得意先名.Width = 3.267717!
        '
        'lbl商品名
        '
        Me.lbl商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl商品名.Height = 0.2362205!
        Me.lbl商品名.HyperLink = Nothing
        Me.lbl商品名.Left = 1.547638!
        Me.lbl商品名.Name = "lbl商品名"
        Me.lbl商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl商品名.Text = "商品名"
        Me.lbl商品名.Top = 0.9929134!
        Me.lbl商品名.Width = 0.5905512!
        '
        'txt商品名
        '
        Me.txt商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt商品名.Height = 0.2362205!
        Me.txt商品名.Left = 2.138189!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt商品名.Text = "あああああいいいいいううううう"
        Me.txt商品名.Top = 0.9929134!
        Me.txt商品名.Width = 2.637795!
        '
        'txt住所
        '
        Me.txt住所.Height = 0.1968504!
        Me.txt住所.Left = 8.579922!
        Me.txt住所.Name = "txt住所"
        Me.txt住所.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txt住所.Text = " 〒117-0032　東京都練馬区谷原3-24-1"
        Me.txt住所.Top = 0.7015749!
        Me.txt住所.Width = 2.401575!
        '
        'txt法人
        '
        Me.txt法人.CharacterSpacing = 1.0!
        Me.txt法人.Height = 0.4330709!
        Me.txt法人.Left = 8.579922!
        Me.txt法人.Name = "txt法人"
        Me.txt法人.Style = "font-family: ＭＳ 明朝; font-size: 13pt; text-align: justify; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txt法人.Text = "株式会社"
        Me.txt法人.Top = 0.268504!
        Me.txt法人.Width = 0.9055118!
        '
        'txt会社名
        '
        Me.txt会社名.CharacterSpacing = 15.0!
        Me.txt会社名.Height = 0.4330709!
        Me.txt会社名.Left = 9.48507!
        Me.txt会社名.Name = "txt会社名"
        Me.txt会社名.Style = "font-family: ＭＳ 明朝; font-size: 20pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt会社名.Text = "友功社"
        Me.txt会社名.Top = 0.2685039!
        Me.txt会社名.Width = 1.456693!
        '
        'txtTEL
        '
        Me.txtTEL.Height = 0.1968504!
        Me.txtTEL.Left = 8.579922!
        Me.txtTEL.Name = "txtTEL"
        Me.txtTEL.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: justify; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtTEL.Text = "    TEL　０３-３９９６-５３３３ (代)"
        Me.txtTEL.Top = 0.8984253!
        Me.txtTEL.Width = 2.401575!
        '
        'TextBox4
        '
        Me.TextBox4.Height = 0.1968504!
        Me.TextBox4.Left = 8.579922!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.TextBox4.Text = "ラベル・シール・ステッカー特殊印刷"
        Me.TextBox4.Top = 0.07165354!
        Me.TextBox4.Width = 2.424016!
        '
        'txtFAX
        '
        Me.txtFAX.Height = 0.1968504!
        Me.txtFAX.Left = 8.579922!
        Me.txtFAX.Name = "txtFAX"
        Me.txtFAX.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: justify; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtFAX.Text = "    Fax　０３-３９９６-４３３３"
        Me.txtFAX.Top = 1.095276!
        Me.txtFAX.Width = 2.401575!
        '
        'lblHDNo
        '
        Me.lblHDNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lblHDNo.Height = 0.2362205!
        Me.lblHDNo.HyperLink = Nothing
        Me.lblHDNo.Left = 5.216536!
        Me.lblHDNo.Name = "lblHDNo"
        Me.lblHDNo.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHDNo.Text = "HDNo."
        Me.lblHDNo.Top = 0.9929134!
        Me.lblHDNo.Width = 0.472441!
        '
        'grpFtr
        '
        Me.grpFtr.Height = 0.0!
        Me.grpFtr.Name = "grpFtr"
        '
        'ItemConfig
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 11.06299!
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
        CType(Me.txt6商品構成資材No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品構成資材No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3商品構成資材No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt2商品構成資材No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt5商品構成資材No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品構成資材No4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr仕入日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入金明細表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl6商品構成資材No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl商品構成資材No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl2商品構成資材No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl3商品構成資材No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr入金日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl5商品構成資材No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl4商品構成資材No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt回収方法, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt住所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt法人, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt会社名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFAX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHDNo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt6商品構成資材No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品構成資材No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt3商品構成資材No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt2商品構成資材No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt5商品構成資材No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品構成資材No4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txtHdr仕入日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt入金明細表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl6商品構成資材No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl商品構成資材No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl2商品構成資材No As DataDynamics.ActiveReports.Label
    Private WithEvents lblNo As DataDynamics.ActiveReports.Label
    Private WithEvents lbl3商品構成資材No As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr入金日 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl5商品構成資材No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl4商品構成資材No As DataDynamics.ActiveReports.Label
    Private WithEvents txt回収方法 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt住所 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt法人 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt会社名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtTEL As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtFAX As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHDNo As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr As DataDynamics.ActiveReports.GroupFooter
End Class
