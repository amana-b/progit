<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DepositPlan
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DepositPlan))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt請求年月日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt備考 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt入金予定額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt今回売上額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt回収予定日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt入金済額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt集金区分名 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt回収日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt入金明細表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl請求年月日 = New DataDynamics.ActiveReports.Label()
        Me.lbl備考 = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先名 = New DataDynamics.ActiveReports.Label()
        Me.lbl今回売上額 = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先CD = New DataDynamics.ActiveReports.Label()
        Me.lbl入金予定額 = New DataDynamics.ActiveReports.Label()
        Me.lbl回収日 = New DataDynamics.ActiveReports.Label()
        Me.lbl回収予定日 = New DataDynamics.ActiveReports.Label()
        Me.lbl入金済額 = New DataDynamics.ActiveReports.Label()
        Me.txt集金区分 = New DataDynamics.ActiveReports.Label()
        Me.txt回収方法 = New DataDynamics.ActiveReports.TextBox()
        Me.grpFtr計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.txt入金予定合計額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt今回売上合計額 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.txt入金済合計額 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox23 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt請求年月日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt備考, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入金予定額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt今回売上額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt回収予定日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入金済額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt集金区分名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt回収日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入金明細表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl請求年月日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl備考, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl今回売上額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl入金予定額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl回収日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl回収予定日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl入金済額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt集金区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt回収方法, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入金予定合計額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt今回売上合計額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入金済合計額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt請求年月日, Me.txt備考, Me.txt得意先名, Me.txt入金予定額, Me.txt得意先CD, Me.txt今回売上額, Me.txt回収予定日, Me.txt入金済額, Me.txt集金区分名})
        Me.Detail.Height = 0.2755905!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt請求年月日
        '
        Me.txt請求年月日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求年月日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求年月日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求年月日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求年月日.Height = 0.2755905!
        Me.txt請求年月日.Left = 2.755906!
        Me.txt請求年月日.Name = "txt請求年月日"
        Me.txt請求年月日.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt請求年月日.Text = "YY/MM/DD"
        Me.txt請求年月日.Top = 0.0!
        Me.txt請求年月日.Width = 0.7283465!
        '
        'txt備考
        '
        Me.txt備考.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Height = 0.2755905!
        Me.txt備考.Left = 7.657481!
        Me.txt備考.Name = "txt備考"
        Me.txt備考.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt備考.Text = "あああああいいいいいうううううえええええ"
        Me.txt備考.Top = 0.000001132488!
        Me.txt備考.Width = 2.972441!
        '
        'txt得意先名
        '
        Me.txt得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.CanGrow = False
        Me.txt得意先名.Height = 0.2755905!
        Me.txt得意先名.Left = 0.6299213!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txt得意先名.Text = "あああああいいいいいううううう"
        Me.txt得意先名.Top = 0.0000002384186!
        Me.txt得意先名.Width = 2.125984!
        '
        'txt入金予定額
        '
        Me.txt入金予定額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金予定額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金予定額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金予定額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金予定額.Height = 0.2755905!
        Me.txt入金予定額.Left = 5.216536!
        Me.txt入金予定額.Name = "txt入金予定額"
        Me.txt入金予定額.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt入金予定額.Text = "999,999"
        Me.txt入金予定額.Top = 0.0000002980233!
        Me.txt入金予定額.Width = 0.8661417!
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
        Me.txt得意先CD.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt得意先CD.Text = "123456"
        Me.txt得意先CD.Top = 0.00000005960464!
        Me.txt得意先CD.Width = 0.6299213!
        '
        'txt今回売上額
        '
        Me.txt今回売上額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上額.Height = 0.2755905!
        Me.txt今回売上額.Left = 3.484252!
        Me.txt今回売上額.Name = "txt今回売上額"
        Me.txt今回売上額.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt今回売上額.Text = "999,999"
        Me.txt今回売上額.Top = 0.0000001192093!
        Me.txt今回売上額.Width = 0.8661417!
        '
        'txt回収予定日
        '
        Me.txt回収予定日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt回収予定日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt回収予定日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt回収予定日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt回収予定日.Height = 0.2755905!
        Me.txt回収予定日.Left = 6.870079!
        Me.txt回収予定日.Name = "txt回収予定日"
        Me.txt回収予定日.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt回収予定日.Text = "YY/MM/DD"
        Me.txt回収予定日.Top = 0.0000002980233!
        Me.txt回収予定日.Width = 0.7874016!
        '
        'txt入金済額
        '
        Me.txt入金済額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金済額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金済額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金済額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金済額.Height = 0.2755905!
        Me.txt入金済額.Left = 4.350394!
        Me.txt入金済額.Name = "txt入金済額"
        Me.txt入金済額.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt入金済額.Text = "999,999"
        Me.txt入金済額.Top = 0.0000002980233!
        Me.txt入金済額.Width = 0.8661417!
        '
        'txt集金区分名
        '
        Me.txt集金区分名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt集金区分名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt集金区分名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt集金区分名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt集金区分名.Height = 0.2755905!
        Me.txt集金区分名.Left = 6.082677!
        Me.txt集金区分名.Name = "txt集金区分名"
        Me.txt集金区分名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt集金区分名.Text = "ああああ"
        Me.txt集金区分名.Top = 0.0000005066395!
        Me.txt集金区分名.Width = 0.7874016!
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
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt回収日, Me.txt入金明細表, Me.lbl請求年月日, Me.lbl備考, Me.lbl得意先名, Me.lbl今回売上額, Me.lbl得意先CD, Me.lbl入金予定額, Me.lbl回収日, Me.lbl回収予定日, Me.lbl入金済額, Me.txt集金区分, Me.txt回収方法})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.7874016!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txt回収日
        '
        Me.txt回収日.Height = 0.2362205!
        Me.txt回収日.Left = 0.7874014!
        Me.txt回収日.Name = "txt回収日"
        Me.txt回収日.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt回収日.Text = "00/00/00～99/99/99　日迄"
        Me.txt回収日.Top = 0.0!
        Me.txt回収日.Width = 2.150394!
        '
        'txt入金明細表
        '
        Me.txt入金明細表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt入金明細表.Height = 0.2362205!
        Me.txt入金明細表.Left = 4.065748!
        Me.txt入金明細表.Name = "txt入金明細表"
        Me.txt入金明細表.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt入金明細表.Text = "入 金 予 定 表"
        Me.txt入金明細表.Top = 0.08110237!
        Me.txt入金明細表.Width = 2.681497!
        '
        'lbl請求年月日
        '
        Me.lbl請求年月日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl請求年月日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl請求年月日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl請求年月日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl請求年月日.Height = 0.2559055!
        Me.lbl請求年月日.HyperLink = Nothing
        Me.lbl請求年月日.Left = 2.755906!
        Me.lbl請求年月日.Name = "lbl請求年月日"
        Me.lbl請求年月日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl請求年月日.Text = "請求年月日"
        Me.lbl請求年月日.Top = 0.5314961!
        Me.lbl請求年月日.Width = 0.7283465!
        '
        'lbl備考
        '
        Me.lbl備考.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Height = 0.2559055!
        Me.lbl備考.HyperLink = Nothing
        Me.lbl備考.Left = 7.657481!
        Me.lbl備考.Name = "lbl備考"
        Me.lbl備考.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: justify; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl備考.Text = "　　　　　備　考"
        Me.lbl備考.Top = 0.5314961!
        Me.lbl備考.Width = 2.972441!
        '
        'lbl得意先名
        '
        Me.lbl得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Height = 0.2559055!
        Me.lbl得意先名.HyperLink = Nothing
        Me.lbl得意先名.Left = 0.6299213!
        Me.lbl得意先名.Name = "lbl得意先名"
        Me.lbl得意先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl得意先名.Text = "得　意　先　名"
        Me.lbl得意先名.Top = 0.5314961!
        Me.lbl得意先名.Width = 2.125984!
        '
        'lbl今回売上額
        '
        Me.lbl今回売上額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回売上額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回売上額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回売上額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回売上額.Height = 0.2559055!
        Me.lbl今回売上額.HyperLink = Nothing
        Me.lbl今回売上額.Left = 3.484252!
        Me.lbl今回売上額.Name = "lbl今回売上額"
        Me.lbl今回売上額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl今回売上額.Text = "今回売上額"
        Me.lbl今回売上額.Top = 0.5314961!
        Me.lbl今回売上額.Width = 0.8661417!
        '
        'lbl得意先CD
        '
        Me.lbl得意先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Height = 0.2559055!
        Me.lbl得意先CD.HyperLink = Nothing
        Me.lbl得意先CD.Left = 0.0!
        Me.lbl得意先CD.Name = "lbl得意先CD"
        Me.lbl得意先CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl得意先CD.Text = "得意先ｺｰﾄﾞ"
        Me.lbl得意先CD.Top = 0.5314961!
        Me.lbl得意先CD.Width = 0.6299213!
        '
        'lbl入金予定額
        '
        Me.lbl入金予定額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl入金予定額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl入金予定額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl入金予定額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl入金予定額.Height = 0.2559055!
        Me.lbl入金予定額.HyperLink = Nothing
        Me.lbl入金予定額.Left = 5.216536!
        Me.lbl入金予定額.Name = "lbl入金予定額"
        Me.lbl入金予定額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl入金予定額.Text = "入金予定額"
        Me.lbl入金予定額.Top = 0.5314961!
        Me.lbl入金予定額.Width = 0.8661417!
        '
        'lbl回収日
        '
        Me.lbl回収日.Height = 0.2362205!
        Me.lbl回収日.HyperLink = Nothing
        Me.lbl回収日.Left = 0.0!
        Me.lbl回収日.Name = "lbl回収日"
        Me.lbl回収日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl回収日.Text = "回収日"
        Me.lbl回収日.Top = 0.0!
        Me.lbl回収日.Width = 0.7874014!
        '
        'lbl回収予定日
        '
        Me.lbl回収予定日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl回収予定日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl回収予定日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl回収予定日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl回収予定日.Height = 0.2559055!
        Me.lbl回収予定日.HyperLink = Nothing
        Me.lbl回収予定日.Left = 6.870079!
        Me.lbl回収予定日.Name = "lbl回収予定日"
        Me.lbl回収予定日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl回収予定日.Text = "回収予定日"
        Me.lbl回収予定日.Top = 0.5314961!
        Me.lbl回収予定日.Width = 0.7874016!
        '
        'lbl入金済額
        '
        Me.lbl入金済額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl入金済額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl入金済額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl入金済額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl入金済額.Height = 0.2559055!
        Me.lbl入金済額.HyperLink = Nothing
        Me.lbl入金済額.Left = 4.350394!
        Me.lbl入金済額.Name = "lbl入金済額"
        Me.lbl入金済額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl入金済額.Text = "入金済額"
        Me.lbl入金済額.Top = 0.5314961!
        Me.lbl入金済額.Width = 0.8661417!
        '
        'txt集金区分
        '
        Me.txt集金区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt集金区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt集金区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt集金区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt集金区分.Height = 0.2559055!
        Me.txt集金区分.HyperLink = Nothing
        Me.txt集金区分.Left = 6.082677!
        Me.txt集金区分.Name = "txt集金区分"
        Me.txt集金区分.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.txt集金区分.Text = "集金区分"
        Me.txt集金区分.Top = 0.5314961!
        Me.txt集金区分.Width = 0.7874016!
        '
        'txt回収方法
        '
        Me.txt回収方法.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt回収方法.Height = 0.2362205!
        Me.txt回収方法.Left = 7.874016!
        Me.txt回収方法.Name = "txt回収方法"
        Me.txt回収方法.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt回収方法.Text = "(あああああ)"
        Me.txt回収方法.Top = 0.0496063!
        Me.txt回収方法.Width = 1.181102!
        '
        'grpFtr計
        '
        Me.grpFtr計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.TextBox3, Me.txt入金予定合計額, Me.txt今回売上合計額, Me.TextBox15, Me.TextBox17, Me.Label2, Me.TextBox19, Me.txt入金済合計額, Me.TextBox23})
        Me.grpFtr計.Height = 0.2755906!
        Me.grpFtr計.Name = "grpFtr計"
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.2755905!
        Me.TextBox1.Left = 7.657481!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 2.972441!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.2755905!
        Me.TextBox3.Left = 6.870079!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0000002980233!
        Me.TextBox3.Width = 0.7874016!
        '
        'txt入金予定合計額
        '
        Me.txt入金予定合計額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金予定合計額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金予定合計額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金予定合計額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金予定合計額.Height = 0.2755905!
        Me.txt入金予定合計額.Left = 5.216536!
        Me.txt入金予定合計額.Name = "txt入金予定合計額"
        Me.txt入金予定合計額.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt入金予定合計額.Text = "999,999,999"
        Me.txt入金予定合計額.Top = 0.0000002980233!
        Me.txt入金予定合計額.Width = 0.8661417!
        '
        'txt今回売上合計額
        '
        Me.txt今回売上合計額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上合計額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上合計額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上合計額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上合計額.Height = 0.2755905!
        Me.txt今回売上合計額.Left = 3.484252!
        Me.txt今回売上合計額.Name = "txt今回売上合計額"
        Me.txt今回売上合計額.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt今回売上合計額.Text = "999,999,999" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt今回売上合計額.Top = 0.0000001192093!
        Me.txt今回売上合計額.Width = 0.8661417!
        '
        'TextBox15
        '
        Me.TextBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Height = 0.2755905!
        Me.TextBox15.Left = 6.082677!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox15.Text = Nothing
        Me.TextBox15.Top = 0.0000005066395!
        Me.TextBox15.Width = 0.7874016!
        '
        'TextBox17
        '
        Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Height = 0.2755905!
        Me.TextBox17.Left = 0.6299213!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.TextBox17.Text = Nothing
        Me.TextBox17.Top = 0.00000005960464!
        Me.TextBox17.Width = 2.125984!
        '
        'Label2
        '
        Me.Label2.Height = 0.1968504!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 1.904725!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "center; vertical-align: bottom; ddo-char-set: 1"
        Me.Label2.Text = "＊担当者計"
        Me.Label2.Top = 0.0480315!
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
        'txt入金済合計額
        '
        Me.txt入金済合計額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金済合計額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金済合計額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金済合計額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金済合計額.Height = 0.2755905!
        Me.txt入金済合計額.Left = 4.350394!
        Me.txt入金済合計額.Name = "txt入金済合計額"
        Me.txt入金済合計額.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt入金済合計額.Text = "999,999,999"
        Me.txt入金済合計額.Top = 0.0!
        Me.txt入金済合計額.Width = 0.8661417!
        '
        'TextBox23
        '
        Me.TextBox23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Height = 0.2755905!
        Me.TextBox23.Left = 2.755906!
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox23.Text = Nothing
        Me.TextBox23.Top = 0.0!
        Me.TextBox23.Width = 0.7283465!
        '
        'DepositPlan
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
        Me.Sections.Add(Me.grpFtr計)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt請求年月日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt備考, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入金予定額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt今回売上額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt回収予定日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入金済額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt集金区分名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt回収日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入金明細表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl請求年月日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl備考, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl今回売上額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl入金予定額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl回収日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl回収予定日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl入金済額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt集金区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt回収方法, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入金予定合計額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt今回売上合計額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入金済合計額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt請求年月日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt備考 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt入金予定額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt今回売上額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt回収予定日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt入金済額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt集金区分名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt回収日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt入金明細表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl請求年月日 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl備考 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl今回売上額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先CD As DataDynamics.ActiveReports.Label
    Private WithEvents lbl入金予定額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl回収日 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl回収予定日 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl入金済額 As DataDynamics.ActiveReports.Label
    Private WithEvents txt集金区分 As DataDynamics.ActiveReports.Label
    Private WithEvents txt回収方法 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpFtr計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt入金予定合計額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt今回売上合計額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt入金済合計額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox23 As DataDynamics.ActiveReports.TextBox
End Class
