<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PurchaseBill
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PurchaseBill))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt仕入先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt作業No = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt納入区分名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt引当区分名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入No = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入区分名 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtHdr仕入日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入明細表 = New DataDynamics.ActiveReports.TextBox()
        Me.txt場所区分 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl仕入先CD = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入数量 = New DataDynamics.ActiveReports.Label()
        Me.lbl作業No = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入先名 = New DataDynamics.ActiveReports.Label()
        Me.ｌｂｌ仕入単価 = New DataDynamics.ActiveReports.Label()
        Me.lblHd仕入金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl納入区分 = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入日 = New DataDynamics.ActiveReports.Label()
        Me.lbl引当区分 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr仕入日 = New DataDynamics.ActiveReports.Label()
        Me.lbl商品名 = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入No = New DataDynamics.ActiveReports.Label()
        Me.txt仕入区分 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr総合計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入合計金額 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.txt発送日計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl発送日計 = New DataDynamics.ActiveReports.Label()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.grpFtr仕入先計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox23 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox24 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox25 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入先合計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox27 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox28 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox29 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox30 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox31 = New DataDynamics.ActiveReports.TextBox()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.TextBox32 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox33 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox34 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupHeader2 = New DataDynamics.ActiveReports.GroupHeader()
        Me.grpFtr伝票計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入先伝票計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt仕入先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt納入区分名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt引当区分名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入区分名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr仕入日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入明細表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt場所区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ｌｂｌ仕入単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHd仕入金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl納入区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl引当区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr仕入日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入合計金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発送日計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl発送日計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先伝票計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt仕入先CD, Me.txt仕入数, Me.txt作業No, Me.txt仕入先名, Me.txt仕入単価, Me.txt仕入日, Me.txt納入区分名, Me.txt仕入金額, Me.txt引当区分名, Me.txt商品名, Me.txt仕入No, Me.txt仕入区分名})
        Me.Detail.Height = 0.2755905!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt仕入先CD
        '
        Me.txt仕入先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先CD.Height = 0.2755905!
        Me.txt仕入先CD.Left = 0.0!
        Me.txt仕入先CD.Name = "txt仕入先CD"
        Me.txt仕入先CD.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt仕入先CD.Text = "123456"
        Me.txt仕入先CD.Top = 0.0!
        Me.txt仕入先CD.Width = 0.472441!
        '
        'txt仕入数
        '
        Me.txt仕入数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入数.Height = 0.2755905!
        Me.txt仕入数.Left = 6.870079!
        Me.txt仕入数.Name = "txt仕入数"
        Me.txt仕入数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt仕入数.Text = "999"
        Me.txt仕入数.Top = 0.000001132488!
        Me.txt仕入数.Width = 0.9448819!
        '
        'txt作業No
        '
        Me.txt作業No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Height = 0.2755905!
        Me.txt作業No.Left = 3.307086!
        Me.txt作業No.Name = "txt作業No"
        Me.txt作業No.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt作業No.Text = "123456"
        Me.txt作業No.Top = 0.000001490116!
        Me.txt作業No.Width = 0.4133858!
        '
        'txt仕入先名
        '
        Me.txt仕入先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Height = 0.2755905!
        Me.txt仕入先名.Left = 0.472441!
        Me.txt仕入先名.Name = "txt仕入先名"
        Me.txt仕入先名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txt仕入先名.Text = "あああああいいい"
        Me.txt仕入先名.Top = 0.0000001788139!
        Me.txt仕入先名.Width = 1.122047!
        '
        'txt仕入単価
        '
        Me.txt仕入単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入単価.Height = 0.2755905!
        Me.txt仕入単価.Left = 7.81496!
        Me.txt仕入単価.Name = "txt仕入単価"
        Me.txt仕入単価.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt仕入単価.Text = "999.00"
        Me.txt仕入単価.Top = 0.0000001788139!
        Me.txt仕入単価.Width = 0.9645669!
        '
        'txt仕入日
        '
        Me.txt仕入日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入日.Height = 0.2755905!
        Me.txt仕入日.Left = 1.594488!
        Me.txt仕入日.Name = "txt仕入日"
        Me.txt仕入日.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt仕入日.Text = "YY/MM/DD"
        Me.txt仕入日.Top = 0.0!
        Me.txt仕入日.Width = 0.5708662!
        '
        'txt納入区分名
        '
        Me.txt納入区分名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納入区分名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納入区分名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納入区分名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納入区分名.Height = 0.2755905!
        Me.txt納入区分名.Left = 9.783464!
        Me.txt納入区分名.Name = "txt納入区分名"
        Me.txt納入区分名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt納入区分名.Text = "ああ"
        Me.txt納入区分名.Top = 0.0!
        Me.txt納入区分名.Width = 0.472441!
        '
        'txt仕入金額
        '
        Me.txt仕入金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入金額.Height = 0.2755905!
        Me.txt仕入金額.Left = 8.779528!
        Me.txt仕入金額.Name = "txt仕入金額"
        Me.txt仕入金額.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt仕入金額.Text = "999,999"
        Me.txt仕入金額.Top = 0.0!
        Me.txt仕入金額.Width = 1.003937!
        '
        'txt引当区分名
        '
        Me.txt引当区分名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt引当区分名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt引当区分名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt引当区分名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt引当区分名.Height = 0.2755905!
        Me.txt引当区分名.Left = 10.25591!
        Me.txt引当区分名.Name = "txt引当区分名"
        Me.txt引当区分名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt引当区分名.Text = Nothing
        Me.txt引当区分名.Top = 0.0!
        Me.txt引当区分名.Width = 0.5511811!
        '
        'txt商品名
        '
        Me.txt商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Height = 0.2755905!
        Me.txt商品名.Left = 3.720472!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txt商品名.Text = "あああああいいいいいううううう"
        Me.txt商品名.Top = 0.0!
        Me.txt商品名.Width = 3.149606!
        '
        'txt仕入No
        '
        Me.txt仕入No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入No.Height = 0.2755905!
        Me.txt仕入No.Left = 2.165354!
        Me.txt仕入No.Name = "txt仕入No"
        Me.txt仕入No.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt仕入No.Text = "123456" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt仕入No.Top = 0.0!
        Me.txt仕入No.Width = 0.5314961!
        '
        'txt仕入区分名
        '
        Me.txt仕入区分名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入区分名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入区分名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入区分名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入区分名.Height = 0.2755905!
        Me.txt仕入区分名.Left = 2.69685!
        Me.txt仕入区分名.Name = "txt仕入区分名"
        Me.txt仕入区分名.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt仕入区分名.Text = "ああああ"
        Me.txt仕入区分名.Top = 0.0!
        Me.txt仕入区分名.Width = 0.6102362!
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
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtHdr仕入日, Me.txt仕入明細表, Me.txt場所区分, Me.lbl仕入先CD, Me.lbl仕入数量, Me.lbl作業No, Me.lbl仕入先名, Me.ｌｂｌ仕入単価, Me.lblHd仕入金額, Me.lbl納入区分, Me.lbl仕入日, Me.lbl引当区分, Me.lblHdr仕入日, Me.lbl商品名, Me.lbl仕入No, Me.txt仕入区分})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.7488193!
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
        'txt仕入明細表
        '
        Me.txt仕入明細表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt仕入明細表.Height = 0.2362205!
        Me.txt仕入明細表.Left = 4.065748!
        Me.txt仕入明細表.Name = "txt仕入明細表"
        Me.txt仕入明細表.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入明細表.Text = "仕 入 明 細 表"
        Me.txt仕入明細表.Top = 0.08110237!
        Me.txt仕入明細表.Width = 2.681497!
        '
        'txt場所区分
        '
        Me.txt場所区分.Height = 0.2362205!
        Me.txt場所区分.Left = 6.837402!
        Me.txt場所区分.Name = "txt場所区分"
        Me.txt場所区分.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt場所区分.Text = "(●●分)"
        Me.txt場所区分.Top = 0.06220473!
        Me.txt場所区分.Width = 0.9728355!
        '
        'lbl仕入先CD
        '
        Me.lbl仕入先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先CD.Height = 0.3346457!
        Me.lbl仕入先CD.HyperLink = Nothing
        Me.lbl仕入先CD.Left = 0.0!
        Me.lbl仕入先CD.Name = "lbl仕入先CD"
        Me.lbl仕入先CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl仕入先CD.Text = "ｺｰﾄﾞ"
        Me.lbl仕入先CD.Top = 0.4141732!
        Me.lbl仕入先CD.Width = 0.472441!
        '
        'lbl仕入数量
        '
        Me.lbl仕入数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入数量.Height = 0.3346457!
        Me.lbl仕入数量.HyperLink = Nothing
        Me.lbl仕入数量.Left = 6.870079!
        Me.lbl仕入数量.Name = "lbl仕入数量"
        Me.lbl仕入数量.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl仕入数量.Text = "数量"
        Me.lbl仕入数量.Top = 0.4141734!
        Me.lbl仕入数量.Width = 0.9448819!
        '
        'lbl作業No
        '
        Me.lbl作業No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Height = 0.3346457!
        Me.lbl作業No.HyperLink = Nothing
        Me.lbl作業No.Left = 3.307086!
        Me.lbl作業No.Name = "lbl作業No"
        Me.lbl作業No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl作業No.Text = "作業No"
        Me.lbl作業No.Top = 0.4141734!
        Me.lbl作業No.Width = 0.4133858!
        '
        'lbl仕入先名
        '
        Me.lbl仕入先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Height = 0.3346457!
        Me.lbl仕入先名.HyperLink = Nothing
        Me.lbl仕入先名.Left = 0.472441!
        Me.lbl仕入先名.Name = "lbl仕入先名"
        Me.lbl仕入先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl仕入先名.Text = "仕入先名"
        Me.lbl仕入先名.Top = 0.4141732!
        Me.lbl仕入先名.Width = 1.122047!
        '
        'ｌｂｌ仕入単価
        '
        Me.ｌｂｌ仕入単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ仕入単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ仕入単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ仕入単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ仕入単価.Height = 0.3346457!
        Me.ｌｂｌ仕入単価.HyperLink = Nothing
        Me.ｌｂｌ仕入単価.Left = 7.81496!
        Me.ｌｂｌ仕入単価.Name = "ｌｂｌ仕入単価"
        Me.ｌｂｌ仕入単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.ｌｂｌ仕入単価.Text = "単価"
        Me.ｌｂｌ仕入単価.Top = 0.4141734!
        Me.ｌｂｌ仕入単価.Width = 0.9645669!
        '
        'lblHd仕入金額
        '
        Me.lblHd仕入金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHd仕入金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHd仕入金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHd仕入金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHd仕入金額.Height = 0.3346457!
        Me.lblHd仕入金額.HyperLink = Nothing
        Me.lblHd仕入金額.Left = 8.779528!
        Me.lblHd仕入金額.Name = "lblHd仕入金額"
        Me.lblHd仕入金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lblHd仕入金額.Text = "金額"
        Me.lblHd仕入金額.Top = 0.4141736!
        Me.lblHd仕入金額.Width = 1.003937!
        '
        'lbl納入区分
        '
        Me.lbl納入区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納入区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納入区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納入区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納入区分.Height = 0.3346457!
        Me.lbl納入区分.HyperLink = Nothing
        Me.lbl納入区分.Left = 9.783464!
        Me.lbl納入区分.Name = "lbl納入区分"
        Me.lbl納入区分.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7.5pt; text-align: center; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.lbl納入区分.Text = "納入区分"
        Me.lbl納入区分.Top = 0.4141736!
        Me.lbl納入区分.Width = 0.472441!
        '
        'lbl仕入日
        '
        Me.lbl仕入日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入日.Height = 0.3346457!
        Me.lbl仕入日.HyperLink = Nothing
        Me.lbl仕入日.Left = 1.594488!
        Me.lbl仕入日.Name = "lbl仕入日"
        Me.lbl仕入日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl仕入日.Text = "仕入日"
        Me.lbl仕入日.Top = 0.4141734!
        Me.lbl仕入日.Width = 0.5708662!
        '
        'lbl引当区分
        '
        Me.lbl引当区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl引当区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl引当区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl引当区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl引当区分.Height = 0.3346457!
        Me.lbl引当区分.HyperLink = Nothing
        Me.lbl引当区分.Left = 10.25591!
        Me.lbl引当区分.Name = "lbl引当区分"
        Me.lbl引当区分.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl引当区分.Text = "引当区分"
        Me.lbl引当区分.Top = 0.4141734!
        Me.lbl引当区分.Width = 0.5511811!
        '
        'lblHdr仕入日
        '
        Me.lblHdr仕入日.Height = 0.2362205!
        Me.lblHdr仕入日.HyperLink = Nothing
        Me.lblHdr仕入日.Left = 0.0!
        Me.lblHdr仕入日.Name = "lblHdr仕入日"
        Me.lblHdr仕入日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdr仕入日.Text = "仕入日"
        Me.lblHdr仕入日.Top = 0.0!
        Me.lblHdr仕入日.Width = 0.7874014!
        '
        'lbl商品名
        '
        Me.lbl商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Height = 0.3346457!
        Me.lbl商品名.HyperLink = Nothing
        Me.lbl商品名.Left = 3.720472!
        Me.lbl商品名.Name = "lbl商品名"
        Me.lbl商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl商品名.Text = "品　　　名"
        Me.lbl商品名.Top = 0.4141734!
        Me.lbl商品名.Width = 3.149606!
        '
        'lbl仕入No
        '
        Me.lbl仕入No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入No.Height = 0.3346457!
        Me.lbl仕入No.HyperLink = Nothing
        Me.lbl仕入No.Left = 2.165354!
        Me.lbl仕入No.Name = "lbl仕入No"
        Me.lbl仕入No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl仕入No.Text = "仕入No"
        Me.lbl仕入No.Top = 0.4141734!
        Me.lbl仕入No.Width = 0.5314961!
        '
        'txt仕入区分
        '
        Me.txt仕入区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入区分.Height = 0.3346457!
        Me.txt仕入区分.HyperLink = Nothing
        Me.txt仕入区分.Left = 2.69685!
        Me.txt仕入区分.Name = "txt仕入区分"
        Me.txt仕入区分.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.txt仕入区分.Text = "仕入区分"
        Me.txt仕入区分.Top = 0.4141732!
        Me.txt仕入区分.Width = 0.6102362!
        '
        'grpFtr総合計
        '
        Me.grpFtr総合計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.TextBox2, Me.TextBox6, Me.txt仕入合計金額, Me.TextBox3, Me.txt発送日計, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.lbl発送日計, Me.TextBox4, Me.TextBox10, Me.TextBox11})
        Me.grpFtr総合計.Height = 0.2755905!
        Me.grpFtr総合計.Name = "grpFtr総合計"
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.2755905!
        Me.TextBox1.Left = 10.25591!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.5511811!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Height = 0.2755905!
        Me.TextBox2.Left = 1.594488!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 0.5708662!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Height = 0.2755905!
        Me.TextBox6.Left = 9.783464!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 0.472441!
        '
        'txt仕入合計金額
        '
        Me.txt仕入合計金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計金額.Height = 0.2755905!
        Me.txt仕入合計金額.Left = 8.779529!
        Me.txt仕入合計金額.Name = "txt仕入合計金額"
        Me.txt仕入合計金額.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt仕入合計金額.Text = "999,999,999" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt仕入合計金額.Top = 0.0!
        Me.txt仕入合計金額.Width = 1.003937!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.2755905!
        Me.TextBox3.Left = 7.81496!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.9645669!
        '
        'txt発送日計
        '
        Me.txt発送日計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送日計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送日計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送日計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送日計.Height = 0.2755905!
        Me.txt発送日計.Left = 0.472441!
        Me.txt発送日計.Name = "txt発送日計"
        Me.txt発送日計.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txt発送日計.Text = Nothing
        Me.txt発送日計.Top = 0.0!
        Me.txt発送日計.Width = 1.122047!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Height = 0.2755905!
        Me.TextBox7.Left = 3.307086!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 0.4133858!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Height = 0.2755905!
        Me.TextBox8.Left = 6.870079!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 0.9448819!
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
        Me.TextBox9.Width = 0.472441!
        '
        'lbl発送日計
        '
        Me.lbl発送日計.Height = 0.1968504!
        Me.lbl発送日計.HyperLink = Nothing
        Me.lbl発送日計.Left = 7.917326!
        Me.lbl発送日計.Name = "lbl発送日計"
        Me.lbl発送日計.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl発送日計.Text = "＊総合計"
        Me.lbl発送日計.Top = 0.0480315!
        Me.lbl発送日計.Width = 0.7874014!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Height = 0.2755905!
        Me.TextBox4.Left = 3.720472!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 3.149606!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Height = 0.2755905!
        Me.TextBox10.Left = 2.165354!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox10.Text = Nothing
        Me.TextBox10.Top = 0.0!
        Me.TextBox10.Width = 0.5314961!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Height = 0.2755905!
        Me.TextBox11.Left = 2.69685!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 0.0!
        Me.TextBox11.Width = 0.6102362!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'grpFtr仕入先計
        '
        Me.grpFtr仕入先計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox23, Me.TextBox24, Me.TextBox25, Me.txt仕入先合計, Me.TextBox27, Me.TextBox28, Me.TextBox29, Me.TextBox30, Me.TextBox31, Me.Label3, Me.TextBox32, Me.TextBox33, Me.TextBox34})
        Me.grpFtr仕入先計.Height = 0.2755906!
        Me.grpFtr仕入先計.Name = "grpFtr仕入先計"
        '
        'TextBox23
        '
        Me.TextBox23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Height = 0.2755906!
        Me.TextBox23.Left = 0.0!
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox23.Text = Nothing
        Me.TextBox23.Top = 0.0!
        Me.TextBox23.Width = 0.472441!
        '
        'TextBox24
        '
        Me.TextBox24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Height = 0.2755906!
        Me.TextBox24.Left = 1.594488!
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox24.Text = Nothing
        Me.TextBox24.Top = 0.0!
        Me.TextBox24.Width = 0.5708662!
        '
        'TextBox25
        '
        Me.TextBox25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Height = 0.2755906!
        Me.TextBox25.Left = 9.783465!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox25.Text = Nothing
        Me.TextBox25.Top = 0.0!
        Me.TextBox25.Width = 0.472441!
        '
        'txt仕入先合計
        '
        Me.txt仕入先合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先合計.Height = 0.2755906!
        Me.txt仕入先合計.Left = 8.779528!
        Me.txt仕入先合計.Name = "txt仕入先合計"
        Me.txt仕入先合計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt仕入先合計.Text = "999,999,999" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt仕入先合計.Top = 0.0!
        Me.txt仕入先合計.Width = 1.003937!
        '
        'TextBox27
        '
        Me.TextBox27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Height = 0.2755906!
        Me.TextBox27.Left = 7.814959!
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.TextBox27.Text = Nothing
        Me.TextBox27.Top = 0.0!
        Me.TextBox27.Width = 0.9645666!
        '
        'TextBox28
        '
        Me.TextBox28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Height = 0.2755906!
        Me.TextBox28.Left = 0.472441!
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.TextBox28.Text = Nothing
        Me.TextBox28.Top = 0.0!
        Me.TextBox28.Width = 1.122047!
        '
        'TextBox29
        '
        Me.TextBox29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Height = 0.2755905!
        Me.TextBox29.Left = 3.307087!
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox29.Text = Nothing
        Me.TextBox29.Top = 0.0!
        Me.TextBox29.Width = 0.4133858!
        '
        'TextBox30
        '
        Me.TextBox30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Height = 0.2755906!
        Me.TextBox30.Left = 6.870079!
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox30.Text = Nothing
        Me.TextBox30.Top = 0.0!
        Me.TextBox30.Width = 0.944882!
        '
        'TextBox31
        '
        Me.TextBox31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Height = 0.2755906!
        Me.TextBox31.Left = 10.2559!
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox31.Text = Nothing
        Me.TextBox31.Top = 0.0!
        Me.TextBox31.Width = 0.551181!
        '
        'Label3
        '
        Me.Label3.Height = 0.1968504!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 7.917324!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label3.Text = "＊仕入先計"
        Me.Label3.Top = 0.0480315!
        Me.Label3.Width = 0.7874014!
        '
        'TextBox32
        '
        Me.TextBox32.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Height = 0.2755906!
        Me.TextBox32.Left = 3.720472!
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.TextBox32.Text = Nothing
        Me.TextBox32.Top = 0.0!
        Me.TextBox32.Width = 3.149606!
        '
        'TextBox33
        '
        Me.TextBox33.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Height = 0.2755906!
        Me.TextBox33.Left = 2.165354!
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox33.Text = Nothing
        Me.TextBox33.Top = 0.0!
        Me.TextBox33.Width = 0.5314961!
        '
        'TextBox34
        '
        Me.TextBox34.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Height = 0.2755906!
        Me.TextBox34.Left = 2.69685!
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox34.Text = Nothing
        Me.TextBox34.Top = 0.0!
        Me.TextBox34.Width = 0.6102362!
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Height = 0.0!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'grpFtr伝票計
        '
        Me.grpFtr伝票計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox5, Me.TextBox12, Me.TextBox13, Me.txt仕入先伝票計, Me.TextBox15, Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.Label1, Me.TextBox20, Me.TextBox21, Me.TextBox22})
        Me.grpFtr伝票計.Height = 0.2755906!
        Me.grpFtr伝票計.Name = "grpFtr伝票計"
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Height = 0.2755906!
        Me.TextBox5.Left = 0.0!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 0.472441!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Height = 0.2755906!
        Me.TextBox12.Left = 1.594488!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox12.Text = Nothing
        Me.TextBox12.Top = 0.0!
        Me.TextBox12.Width = 0.5708662!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Height = 0.2755906!
        Me.TextBox13.Left = 9.783465!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox13.Text = Nothing
        Me.TextBox13.Top = 0.0!
        Me.TextBox13.Width = 0.472441!
        '
        'txt仕入先伝票計
        '
        Me.txt仕入先伝票計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先伝票計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先伝票計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先伝票計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先伝票計.Height = 0.2755906!
        Me.txt仕入先伝票計.Left = 8.779528!
        Me.txt仕入先伝票計.Name = "txt仕入先伝票計"
        Me.txt仕入先伝票計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt仕入先伝票計.Text = "999,999,999" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt仕入先伝票計.Top = 0.0!
        Me.txt仕入先伝票計.Width = 1.003937!
        '
        'TextBox15
        '
        Me.TextBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Height = 0.2755906!
        Me.TextBox15.Left = 7.814959!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.TextBox15.Text = Nothing
        Me.TextBox15.Top = 0.0!
        Me.TextBox15.Width = 0.9645666!
        '
        'TextBox16
        '
        Me.TextBox16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Height = 0.2755906!
        Me.TextBox16.Left = 0.472441!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.TextBox16.Text = Nothing
        Me.TextBox16.Top = 0.0!
        Me.TextBox16.Width = 1.122047!
        '
        'TextBox17
        '
        Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Height = 0.2755905!
        Me.TextBox17.Left = 3.307087!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox17.Text = Nothing
        Me.TextBox17.Top = 0.0!
        Me.TextBox17.Width = 0.4133858!
        '
        'TextBox18
        '
        Me.TextBox18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Height = 0.2755906!
        Me.TextBox18.Left = 6.870079!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox18.Text = Nothing
        Me.TextBox18.Top = 0.0!
        Me.TextBox18.Width = 0.944882!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Height = 0.2755906!
        Me.TextBox19.Left = 10.2559!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox19.Text = Nothing
        Me.TextBox19.Top = 0.0!
        Me.TextBox19.Width = 0.551181!
        '
        'Label1
        '
        Me.Label1.Height = 0.1968504!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 7.917324!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label1.Text = "＊伝票計"
        Me.Label1.Top = 0.0480315!
        Me.Label1.Width = 0.7874014!
        '
        'TextBox20
        '
        Me.TextBox20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Height = 0.2755906!
        Me.TextBox20.Left = 3.720472!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.TextBox20.Text = Nothing
        Me.TextBox20.Top = 0.0!
        Me.TextBox20.Width = 3.149606!
        '
        'TextBox21
        '
        Me.TextBox21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Height = 0.2755906!
        Me.TextBox21.Left = 2.165354!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox21.Text = Nothing
        Me.TextBox21.Top = 0.0!
        Me.TextBox21.Width = 0.5314961!
        '
        'TextBox22
        '
        Me.TextBox22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Height = 0.2755906!
        Me.TextBox22.Left = 2.69685!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox22.Text = Nothing
        Me.TextBox22.Top = 0.0!
        Me.TextBox22.Width = 0.6102362!
        '
        'PurchaseBill
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
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.GroupHeader2)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr伝票計)
        Me.Sections.Add(Me.grpFtr仕入先計)
        Me.Sections.Add(Me.grpFtr総合計)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt仕入先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt納入区分名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt引当区分名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入区分名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr仕入日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入明細表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt場所区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ｌｂｌ仕入単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHd仕入金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl納入区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl引当区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr仕入日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入合計金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発送日計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl発送日計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先伝票計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt仕入先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt作業No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpFtr総合計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt仕入日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt納入区分名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt引当区分名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入合計金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt発送日計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr仕入日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入明細表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt場所区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl仕入先CD As DataDynamics.ActiveReports.Label
    Private WithEvents lbl仕入数量 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl作業No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl仕入先名 As DataDynamics.ActiveReports.Label
    Private WithEvents ｌｂｌ仕入単価 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHd仕入金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl納入区分 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl仕入日 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl引当区分 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr仕入日 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl発送日計 As DataDynamics.ActiveReports.Label
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl仕入No As DataDynamics.ActiveReports.Label
    Private WithEvents txt仕入No As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入区分 As DataDynamics.ActiveReports.Label
    Private WithEvents txt仕入区分名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents grpFtr仕入先計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents GroupHeader2 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents grpFtr伝票計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents TextBox23 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox24 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox25 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox27 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox28 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox29 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox30 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox31 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox32 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox33 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox34 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先伝票計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox16 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
End Class
