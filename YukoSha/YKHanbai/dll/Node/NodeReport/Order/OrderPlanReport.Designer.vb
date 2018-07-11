<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class OrderPlanReport
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(OrderPlanReport))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt得意先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt本台帳No = New DataDynamics.ActiveReports.TextBox()
        Me.txt枝番 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前回受注日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注予測枚数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注予測日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注予測通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前回受注枚数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt2回前受注枚数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt2回前受注日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt3回前受注枚数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt3回前受注日 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr得意先CD = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtHdr受注予測日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注台帳区分名 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHdr受注予測日 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl得意先CD = New DataDynamics.ActiveReports.Label()
        Me.lbl本台帳No = New DataDynamics.ActiveReports.Label()
        Me.lbl枝番 = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先名 = New DataDynamics.ActiveReports.Label()
        Me.ｌｂｌ商品名 = New DataDynamics.ActiveReports.Label()
        Me.lblHd受注予測数 = New DataDynamics.ActiveReports.Label()
        Me.lbl前回受注内容 = New DataDynamics.ActiveReports.Label()
        Me.lbl受注単価 = New DataDynamics.ActiveReports.Label()
        Me.lbl受注予測日 = New DataDynamics.ActiveReports.Label()
        Me.lbl2回前受注内容 = New DataDynamics.ActiveReports.Label()
        Me.lbl3回前受注内容 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt本台帳No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt枝番, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前回受注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注予測枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注予測日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注予測通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前回受注枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt2回前受注枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt2回前受注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3回前受注枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3回前受注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr受注予測日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注台帳区分名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr受注予測日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl本台帳No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl枝番, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ｌｂｌ商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHd受注予測数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl前回受注内容, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl受注単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl受注予測日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl2回前受注内容, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl3回前受注内容, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt得意先CD, Me.txt本台帳No, Me.txt枝番, Me.txt得意先名, Me.txt商品名, Me.txt前回受注日, Me.txt受注予測枚数, Me.txt受注単価, Me.txt受注予測日, Me.txt受注予測通数, Me.txt前回受注枚数, Me.txt2回前受注枚数, Me.txt2回前受注日, Me.txt3回前受注枚数, Me.txt3回前受注日})
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
        Me.txt得意先CD.Top = 0.0000009536743!
        Me.txt得意先CD.Width = 0.6299213!
        '
        'txt本台帳No
        '
        Me.txt本台帳No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt本台帳No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt本台帳No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt本台帳No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt本台帳No.Height = 0.2755905!
        Me.txt本台帳No.Left = 2.677165!
        Me.txt本台帳No.Name = "txt本台帳No"
        Me.txt本台帳No.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt本台帳No.Text = "123456"
        Me.txt本台帳No.Top = 0.0!
        Me.txt本台帳No.Width = 0.5708662!
        '
        'txt枝番
        '
        Me.txt枝番.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枝番.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枝番.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枝番.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枝番.Height = 0.2755905!
        Me.txt枝番.Left = 3.248031!
        Me.txt枝番.Name = "txt枝番"
        Me.txt枝番.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt枝番.Text = "12"
        Me.txt枝番.Top = 0.0!
        Me.txt枝番.Width = 0.2362205!
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
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txt得意先名.Text = "あああああいいいいいううううう"
        Me.txt得意先名.Top = 0.0!
        Me.txt得意先名.Width = 2.047244!
        '
        'txt商品名
        '
        Me.txt商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Height = 0.2755905!
        Me.txt商品名.Left = 3.484252!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txt商品名.Text = "あああああいいいいいううううう"
        Me.txt商品名.Top = 0.0!
        Me.txt商品名.Width = 2.047244!
        '
        'txt前回受注日
        '
        Me.txt前回受注日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回受注日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回受注日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回受注日.Height = 0.1377953!
        Me.txt前回受注日.Left = 7.657481!
        Me.txt前回受注日.Name = "txt前回受注日"
        Me.txt前回受注日.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txt前回受注日.Text = "YY/MM/DD"
        Me.txt前回受注日.Top = 0.0!
        Me.txt前回受注日.Width = 1.003937!
        '
        'txt受注予測枚数
        '
        Me.txt受注予測枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注予測枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注予測枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注予測枚数.Height = 0.1377953!
        Me.txt受注予測枚数.Left = 6.811024!
        Me.txt受注予測枚数.Name = "txt受注予測枚数"
        Me.txt受注予測枚数.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt受注予測枚数.Text = "999,999枚"
        Me.txt受注予測枚数.Top = 0.0!
        Me.txt受注予測枚数.Width = 0.8464568!
        '
        'txt受注単価
        '
        Me.txt受注単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注単価.Height = 0.2755905!
        Me.txt受注単価.Left = 5.531496!
        Me.txt受注単価.Name = "txt受注単価"
        Me.txt受注単価.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt受注単価.Text = "999.99"
        Me.txt受注単価.Top = 0.0!
        Me.txt受注単価.Width = 0.6299213!
        '
        'txt受注予測日
        '
        Me.txt受注予測日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注予測日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注予測日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注予測日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注予測日.Height = 0.2755905!
        Me.txt受注予測日.Left = 6.161417!
        Me.txt受注予測日.Name = "txt受注予測日"
        Me.txt受注予測日.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt受注予測日.Text = "YY/MM/DD"
        Me.txt受注予測日.Top = 0.0!
        Me.txt受注予測日.Width = 0.6496063!
        '
        'txt受注予測通数
        '
        Me.txt受注予測通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注予測通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注予測通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注予測通数.Height = 0.1377953!
        Me.txt受注予測通数.Left = 6.811024!
        Me.txt受注予測通数.Name = "txt受注予測通数"
        Me.txt受注予測通数.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt受注予測通数.Text = "999,999通"
        Me.txt受注予測通数.Top = 0.1377953!
        Me.txt受注予測通数.Width = 0.8464569!
        '
        'txt前回受注枚数
        '
        Me.txt前回受注枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回受注枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回受注枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回受注枚数.Height = 0.1377953!
        Me.txt前回受注枚数.Left = 7.65748!
        Me.txt前回受注枚数.Name = "txt前回受注枚数"
        Me.txt前回受注枚数.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt前回受注枚数.Text = "999,999枚"
        Me.txt前回受注枚数.Top = 0.1377953!
        Me.txt前回受注枚数.Width = 1.003937!
        '
        'txt2回前受注枚数
        '
        Me.txt2回前受注枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2回前受注枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2回前受注枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2回前受注枚数.Height = 0.1377953!
        Me.txt2回前受注枚数.Left = 8.661417!
        Me.txt2回前受注枚数.Name = "txt2回前受注枚数"
        Me.txt2回前受注枚数.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt2回前受注枚数.Text = "999,999枚"
        Me.txt2回前受注枚数.Top = 0.1377954!
        Me.txt2回前受注枚数.Width = 1.003937!
        '
        'txt2回前受注日
        '
        Me.txt2回前受注日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2回前受注日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2回前受注日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2回前受注日.Height = 0.1377953!
        Me.txt2回前受注日.Left = 8.661418!
        Me.txt2回前受注日.Name = "txt2回前受注日"
        Me.txt2回前受注日.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txt2回前受注日.Text = "YY/MM/DD"
        Me.txt2回前受注日.Top = 0.0!
        Me.txt2回前受注日.Width = 1.003937!
        '
        'txt3回前受注枚数
        '
        Me.txt3回前受注枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3回前受注枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3回前受注枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3回前受注枚数.Height = 0.1377953!
        Me.txt3回前受注枚数.Left = 9.665354!
        Me.txt3回前受注枚数.Name = "txt3回前受注枚数"
        Me.txt3回前受注枚数.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt3回前受注枚数.Text = "999,999枚"
        Me.txt3回前受注枚数.Top = 0.1377953!
        Me.txt3回前受注枚数.Width = 0.9842521!
        '
        'txt3回前受注日
        '
        Me.txt3回前受注日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3回前受注日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3回前受注日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3回前受注日.Height = 0.1377953!
        Me.txt3回前受注日.Left = 9.665355!
        Me.txt3回前受注日.Name = "txt3回前受注日"
        Me.txt3回前受注日.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txt3回前受注日.Text = "YY/MM/DD"
        Me.txt3回前受注日.Top = 0.0!
        Me.txt3回前受注日.Width = 0.9842521!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNow, Me.txt頁})
        Me.PageHeader.Height = 0.3269354!
        Me.PageHeader.Name = "PageHeader"
        '
        'txtNow
        '
        Me.txtNow.Height = 0.2362205!
        Me.txtNow.Left = 8.076379!
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
        Me.txt頁.Left = 10.24055!
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
        'grpHdr得意先CD
        '
        Me.grpHdr得意先CD.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtHdr受注予測日, Me.txt受注台帳区分名, Me.lblHdr受注予測日, Me.lbl得意先CD, Me.lbl本台帳No, Me.lbl枝番, Me.lbl得意先名, Me.ｌｂｌ商品名, Me.lblHd受注予測数, Me.lbl前回受注内容, Me.lbl受注単価, Me.lbl受注予測日, Me.lbl2回前受注内容, Me.lbl3回前受注内容})
        Me.grpHdr得意先CD.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr得意先CD.Height = 0.6946778!
        Me.grpHdr得意先CD.Name = "grpHdr得意先CD"
        Me.grpHdr得意先CD.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txtHdr受注予測日
        '
        Me.txtHdr受注予測日.Height = 0.2362205!
        Me.txtHdr受注予測日.Left = 0.6244095!
        Me.txtHdr受注予測日.Name = "txtHdr受注予測日"
        Me.txtHdr受注予測日.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txtHdr受注予測日.Text = "00/00/00～99/99/99　日迄"
        Me.txtHdr受注予測日.Top = 0.0!
        Me.txtHdr受注予測日.Width = 1.879529!
        '
        'txt受注台帳区分名
        '
        Me.txt受注台帳区分名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt受注台帳区分名.Height = 0.2362205!
        Me.txt受注台帳区分名.Left = 4.035039!
        Me.txt受注台帳区分名.Name = "txt受注台帳区分名"
        Me.txt受注台帳区分名.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt受注台帳区分名.Text = "受　注　予　測　表"
        Me.txt受注台帳区分名.Top = 0.0!
        Me.txt受注台帳区分名.Width = 2.494094!
        '
        'lblHdr受注予測日
        '
        Me.lblHdr受注予測日.Height = 0.2362205!
        Me.lblHdr受注予測日.Left = 0.0!
        Me.lblHdr受注予測日.Name = "lblHdr受注予測日"
        Me.lblHdr受注予測日.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.lblHdr受注予測日.Text = "予測日"
        Me.lblHdr受注予測日.Top = 0.0!
        Me.lblHdr受注予測日.Width = 0.511811!
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
        Me.lbl得意先CD.Top = 0.4346457!
        Me.lbl得意先CD.Width = 0.6299213!
        '
        'lbl本台帳No
        '
        Me.lbl本台帳No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl本台帳No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl本台帳No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl本台帳No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl本台帳No.Height = 0.2559055!
        Me.lbl本台帳No.HyperLink = Nothing
        Me.lbl本台帳No.Left = 2.677165!
        Me.lbl本台帳No.Name = "lbl本台帳No"
        Me.lbl本台帳No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl本台帳No.Text = "本台帳No"
        Me.lbl本台帳No.Top = 0.4346448!
        Me.lbl本台帳No.Width = 0.5708662!
        '
        'lbl枝番
        '
        Me.lbl枝番.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枝番.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枝番.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枝番.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枝番.Height = 0.2559055!
        Me.lbl枝番.HyperLink = Nothing
        Me.lbl枝番.Left = 3.248031!
        Me.lbl枝番.Name = "lbl枝番"
        Me.lbl枝番.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl枝番.Text = "枝番"
        Me.lbl枝番.Top = 0.4346444!
        Me.lbl枝番.Width = 0.2362205!
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
        Me.lbl得意先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl得意先名.Text = "　得　意　先　名"
        Me.lbl得意先名.Top = 0.4346457!
        Me.lbl得意先名.Width = 2.047244!
        '
        'ｌｂｌ商品名
        '
        Me.ｌｂｌ商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Height = 0.2559055!
        Me.ｌｂｌ商品名.HyperLink = Nothing
        Me.ｌｂｌ商品名.Left = 3.484252!
        Me.ｌｂｌ商品名.Name = "ｌｂｌ商品名"
        Me.ｌｂｌ商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.ｌｂｌ商品名.Text = "　品名"
        Me.ｌｂｌ商品名.Top = 0.4346457!
        Me.ｌｂｌ商品名.Width = 2.047244!
        '
        'lblHd受注予測数
        '
        Me.lblHd受注予測数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHd受注予測数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHd受注予測数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHd受注予測数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHd受注予測数.Height = 0.2559055!
        Me.lblHd受注予測数.HyperLink = Nothing
        Me.lblHd受注予測数.Left = 6.811024!
        Me.lblHd受注予測数.Name = "lblHd受注予測数"
        Me.lblHd受注予測数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7.5pt; text-align: left; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lblHd受注予測数.Text = "受注予測" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　枚数/通数"
        Me.lblHd受注予測数.Top = 0.4346457!
        Me.lblHd受注予測数.Width = 0.8464568!
        '
        'lbl前回受注内容
        '
        Me.lbl前回受注内容.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前回受注内容.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前回受注内容.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前回受注内容.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前回受注内容.Height = 0.2559055!
        Me.lbl前回受注内容.HyperLink = Nothing
        Me.lbl前回受注内容.Left = 7.65748!
        Me.lbl前回受注内容.Name = "lbl前回受注内容"
        Me.lbl前回受注内容.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl前回受注内容.Text = "前回受注内容"
        Me.lbl前回受注内容.Top = 0.4346457!
        Me.lbl前回受注内容.Width = 1.003937!
        '
        'lbl受注単価
        '
        Me.lbl受注単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注単価.Height = 0.2559055!
        Me.lbl受注単価.HyperLink = Nothing
        Me.lbl受注単価.Left = 5.531496!
        Me.lbl受注単価.Name = "lbl受注単価"
        Me.lbl受注単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl受注単価.Text = "受注単価"
        Me.lbl受注単価.Top = 0.4346457!
        Me.lbl受注単価.Width = 0.6299213!
        '
        'lbl受注予測日
        '
        Me.lbl受注予測日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注予測日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注予測日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注予測日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注予測日.Height = 0.2559055!
        Me.lbl受注予測日.HyperLink = Nothing
        Me.lbl受注予測日.Left = 6.161417!
        Me.lbl受注予測日.Name = "lbl受注予測日"
        Me.lbl受注予測日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl受注予測日.Text = "受注予測日"
        Me.lbl受注予測日.Top = 0.4346457!
        Me.lbl受注予測日.Width = 0.6496063!
        '
        'lbl2回前受注内容
        '
        Me.lbl2回前受注内容.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2回前受注内容.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2回前受注内容.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2回前受注内容.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2回前受注内容.Height = 0.2559055!
        Me.lbl2回前受注内容.HyperLink = Nothing
        Me.lbl2回前受注内容.Left = 8.661417!
        Me.lbl2回前受注内容.Name = "lbl2回前受注内容"
        Me.lbl2回前受注内容.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl2回前受注内容.Text = "2回前受注内容"
        Me.lbl2回前受注内容.Top = 0.4346457!
        Me.lbl2回前受注内容.Width = 1.003937!
        '
        'lbl3回前受注内容
        '
        Me.lbl3回前受注内容.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl3回前受注内容.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl3回前受注内容.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl3回前受注内容.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl3回前受注内容.Height = 0.2559055!
        Me.lbl3回前受注内容.HyperLink = Nothing
        Me.lbl3回前受注内容.Left = 9.665354!
        Me.lbl3回前受注内容.Name = "lbl3回前受注内容"
        Me.lbl3回前受注内容.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl3回前受注内容.Text = "3回前受注内容"
        Me.lbl3回前受注内容.Top = 0.4346457!
        Me.lbl3回前受注内容.Width = 0.9842521!
        '
        'grpFtr
        '
        Me.grpFtr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1})
        Me.grpFtr.Height = 0.0!
        Me.grpFtr.Name = "grpFtr"
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.2755905!
        Me.TextBox1.Left = 9.921257!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.9842521!
        '
        'OrderPlanReport
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.66929!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr得意先CD)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt本台帳No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt枝番, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前回受注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注予測枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注予測日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注予測通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前回受注枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt2回前受注枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt2回前受注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3回前受注枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3回前受注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr受注予測日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注台帳区分名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr受注予測日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl本台帳No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl枝番, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ｌｂｌ商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHd受注予測数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl前回受注内容, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl受注単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl受注予測日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl2回前受注内容, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl3回前受注内容, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt得意先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt本台帳No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt枝番 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前回受注日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt受注予測枚数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr得意先CD As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txtHdr受注予測日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt受注台帳区分名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHdr受注予測日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl得意先CD As DataDynamics.ActiveReports.Label
    Private WithEvents lbl本台帳No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl枝番 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先名 As DataDynamics.ActiveReports.Label
    Private WithEvents ｌｂｌ商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHd受注予測数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl前回受注内容 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl受注単価 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl受注予測日 As DataDynamics.ActiveReports.Label
    Private WithEvents txt受注単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt受注予測日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt受注予測通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前回受注枚数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt2回前受注枚数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt2回前受注日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt3回前受注枚数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt3回前受注日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl2回前受注内容 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl3回前受注内容 As DataDynamics.ActiveReports.Label
End Class
