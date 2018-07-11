<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DeliveryList
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DeliveryList))
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txtdtl出荷先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl出荷先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl郵便番号 = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtl住所 = New DataDynamics.ActiveReports.TextBox()
        Me.txtdtlTEL = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr得意先CD = New DataDynamics.ActiveReports.GroupHeader()
        Me.lblTitle = New DataDynamics.ActiveReports.Label()
        Me.lbl出荷先CD = New DataDynamics.ActiveReports.Label()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先CD = New DataDynamics.ActiveReports.TextBox()
        Me.lbl得意先 = New DataDynamics.ActiveReports.Label()
        Me.lbl出荷先名 = New DataDynamics.ActiveReports.Label()
        Me.lbl郵便番号 = New DataDynamics.ActiveReports.Label()
        Me.lbl住所 = New DataDynamics.ActiveReports.Label()
        Me.lblTEL = New DataDynamics.ActiveReports.Label()
        Me.grpFtr得意先CD = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.txt出荷先計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl出荷先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl出荷先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl郵便番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtl住所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtlTEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl出荷先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl出荷先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl郵便番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl住所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt出荷先計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label2, Me.TextBox1, Me.TextBox2, Me.txtNow})
        Me.PageHeader.Height = 0.1771654!
        Me.PageHeader.Name = "PageHeader"
        '
        'Label2
        '
        Me.Label2.Height = 0.1771654!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 10.4!
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
        Me.TextBox1.Left = 10.548!
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
        Me.TextBox2.Left = 10.154!
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
        Me.txtNow.Left = 8.465!
        Me.txtNow.Name = "txtNow"
        Me.txtNow.Style = "font-family: ＭＳ 明朝; font-size: 9.75pt; text-align: left"
        Me.txtNow.Text = "Now"
        Me.txtNow.Top = 0.0!
        Me.txtNow.Width = 1.688976!
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtdtl出荷先CD, Me.txtdtl出荷先名, Me.txtdtl郵便番号, Me.txtdtl住所, Me.txtdtlTEL})
        Me.Detail.Height = 0.275!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'txtdtl出荷先CD
        '
        Me.txtdtl出荷先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl出荷先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl出荷先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl出荷先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl出荷先CD.Height = 0.275!
        Me.txtdtl出荷先CD.Left = -0.0000001192093!
        Me.txtdtl出荷先CD.Name = "txtdtl出荷先CD"
        Me.txtdtl出荷先CD.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtdtl出荷先CD.Text = "999"
        Me.txtdtl出荷先CD.Top = -0.00000001490116!
        Me.txtdtl出荷先CD.Width = 0.5!
        '
        'txtdtl出荷先名
        '
        Me.txtdtl出荷先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl出荷先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl出荷先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl出荷先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl出荷先名.Height = 0.275!
        Me.txtdtl出荷先名.Left = 0.5!
        Me.txtdtl出荷先名.Name = "txtdtl出荷先名"
        Me.txtdtl出荷先名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txtdtl出荷先名.Text = "ああああああああああいいいいいい"
        Me.txtdtl出荷先名.Top = 0.0!
        Me.txtdtl出荷先名.Width = 2.5!
        '
        'txtdtl郵便番号
        '
        Me.txtdtl郵便番号.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl郵便番号.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl郵便番号.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl郵便番号.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl郵便番号.Height = 0.275!
        Me.txtdtl郵便番号.Left = 3.0!
        Me.txtdtl郵便番号.Name = "txtdtl郵便番号"
        Me.txtdtl郵便番号.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtdtl郵便番号.Text = "999-9999"
        Me.txtdtl郵便番号.Top = 0.0!
        Me.txtdtl郵便番号.Width = 0.7!
        '
        'txtdtl住所
        '
        Me.txtdtl住所.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl住所.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl住所.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl住所.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtl住所.Height = 0.275!
        Me.txtdtl住所.Left = 3.7!
        Me.txtdtl住所.Name = "txtdtl住所"
        Me.txtdtl住所.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txtdtl住所.Text = "ああああああああああいいいいいいいいいいううううううううううええ"
        Me.txtdtl住所.Top = 0.0!
        Me.txtdtl住所.Width = 5.55!
        '
        'txtdtlTEL
        '
        Me.txtdtlTEL.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtlTEL.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtlTEL.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtlTEL.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtdtlTEL.Height = 0.275!
        Me.txtdtlTEL.Left = 9.250006!
        Me.txtdtlTEL.Name = "txtdtlTEL"
        Me.txtdtlTEL.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtdtlTEL.Text = "999-9999-9999"
        Me.txtdtlTEL.Top = 0.0!
        Me.txtdtlTEL.Width = 1.2!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdr得意先CD
        '
        Me.grpHdr得意先CD.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitle, Me.lbl出荷先CD, Me.txt得意先名, Me.txt得意先CD, Me.lbl得意先, Me.lbl出荷先名, Me.lbl郵便番号, Me.lbl住所, Me.lblTEL})
        Me.grpHdr得意先CD.DataField = "得意先CD"
        Me.grpHdr得意先CD.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr得意先CD.Height = 0.65!
        Me.grpHdr得意先CD.Name = "grpHdr得意先CD"
        Me.grpHdr得意先CD.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'lblTitle
        '
        Me.lblTitle.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.lblTitle.Height = 0.25!
        Me.lblTitle.HyperLink = Nothing
        Me.lblTitle.Left = 4.051!
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 16pt; font-weight: bold; text-alig" & _
    "n: center; vertical-align: middle; ddo-char-set: 1"
        Me.lblTitle.Text = "出 荷 先 リ ス ト"
        Me.lblTitle.Top = 0.0!
        Me.lblTitle.Width = 3.0!
        '
        'lbl出荷先CD
        '
        Me.lbl出荷先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷先CD.Height = 0.275!
        Me.lbl出荷先CD.HyperLink = Nothing
        Me.lbl出荷先CD.Left = 0.0!
        Me.lbl出荷先CD.Name = "lbl出荷先CD"
        Me.lbl出荷先CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl出荷先CD.Text = "コード"
        Me.lbl出荷先CD.Top = 0.395!
        Me.lbl出荷先CD.Width = 0.5!
        '
        'txt得意先名
        '
        Me.txt得意先名.Height = 0.197!
        Me.txt得意先名.Left = 1.52!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; vertical-align: middle; ddo-char-set: 1"
        Me.txt得意先名.Text = "ああああああああああいいいいいい"
        Me.txt得意先名.Top = 0.167!
        Me.txt得意先名.Width = 2.5!
        '
        'txt得意先CD
        '
        Me.txt得意先CD.Height = 0.197!
        Me.txt得意先CD.Left = 1.02!
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt得意先CD.Text = "999999"
        Me.txt得意先CD.Top = 0.17!
        Me.txt得意先CD.Width = 0.5!
        '
        'lbl得意先
        '
        Me.lbl得意先.Height = 0.197!
        Me.lbl得意先.HyperLink = Nothing
        Me.lbl得意先.Left = 0.2750007!
        Me.lbl得意先.Name = "lbl得意先"
        Me.lbl得意先.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl得意先.Text = "得意先"
        Me.lbl得意先.Top = 0.167!
        Me.lbl得意先.Width = 0.745!
        '
        'lbl出荷先名
        '
        Me.lbl出荷先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷先名.Height = 0.275!
        Me.lbl出荷先名.HyperLink = Nothing
        Me.lbl出荷先名.Left = 0.5!
        Me.lbl出荷先名.Name = "lbl出荷先名"
        Me.lbl出荷先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl出荷先名.Text = "出 荷 先 名"
        Me.lbl出荷先名.Top = 0.395!
        Me.lbl出荷先名.Width = 2.5!
        '
        'lbl郵便番号
        '
        Me.lbl郵便番号.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl郵便番号.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl郵便番号.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl郵便番号.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl郵便番号.Height = 0.275!
        Me.lbl郵便番号.HyperLink = Nothing
        Me.lbl郵便番号.Left = 3.0!
        Me.lbl郵便番号.Name = "lbl郵便番号"
        Me.lbl郵便番号.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl郵便番号.Text = "郵便番号"
        Me.lbl郵便番号.Top = 0.395!
        Me.lbl郵便番号.Width = 0.7!
        '
        'lbl住所
        '
        Me.lbl住所.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl住所.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl住所.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl住所.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl住所.Height = 0.275!
        Me.lbl住所.HyperLink = Nothing
        Me.lbl住所.Left = 3.7!
        Me.lbl住所.Name = "lbl住所"
        Me.lbl住所.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl住所.Text = "住　　　　　所"
        Me.lbl住所.Top = 0.3950001!
        Me.lbl住所.Width = 5.55!
        '
        'lblTEL
        '
        Me.lblTEL.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblTEL.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblTEL.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblTEL.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblTEL.Height = 0.275!
        Me.lblTEL.HyperLink = Nothing
        Me.lblTEL.Left = 9.250007!
        Me.lblTEL.Name = "lblTEL"
        Me.lblTEL.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblTEL.Text = "ＴＥＬ"
        Me.lblTEL.Top = 0.3950001!
        Me.lblTEL.Width = 1.2!
        '
        'grpFtr得意先CD
        '
        Me.grpFtr得意先CD.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox3, Me.txt出荷先計, Me.TextBox5, Me.TextBox6, Me.TextBox7})
        Me.grpFtr得意先CD.Height = 0.275!
        Me.grpFtr得意先CD.Name = "grpFtr得意先CD"
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.275!
        Me.TextBox3.Left = 0.0!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.5!
        '
        'txt出荷先計
        '
        Me.txt出荷先計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先計.Height = 0.275!
        Me.txt出荷先計.Left = 0.5000001!
        Me.txt出荷先計.Name = "txt出荷先計"
        Me.txt出荷先計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt出荷先計.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.txt出荷先計.Text = Nothing
        Me.txt出荷先計.Top = 0.00000001490116!
        Me.txt出荷先計.Width = 2.5!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Height = 0.275!
        Me.TextBox5.Left = 3.0!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0.00000001490116!
        Me.TextBox5.Width = 0.7!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Height = 0.275!
        Me.TextBox6.Left = 3.7!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0.00000001490116!
        Me.TextBox6.Width = 5.55!
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
        'DeliveryList
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 11.10236!
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
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl出荷先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl出荷先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl郵便番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtl住所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtlTEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl出荷先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl出荷先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl郵便番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl住所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt出荷先計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents grpHdr得意先CD As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents grpFtr得意先CD As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents lbl出荷先CD As DataDynamics.ActiveReports.Label
    Friend WithEvents lblTitle As DataDynamics.ActiveReports.Label
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl得意先 As DataDynamics.ActiveReports.Label
    Private WithEvents txtdtl出荷先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl出荷先名 As DataDynamics.ActiveReports.Label
    Private WithEvents txtdtl出荷先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl郵便番号 As DataDynamics.ActiveReports.Label
    Private WithEvents txtdtl郵便番号 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl住所 As DataDynamics.ActiveReports.Label
    Private WithEvents txtdtl住所 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblTEL As DataDynamics.ActiveReports.Label
    Private WithEvents txtdtlTEL As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt出荷先計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
End Class
