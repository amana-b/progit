<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class OrderRegister
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(OrderRegister))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt枚数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt機械別 = New DataDynamics.ActiveReports.TextBox()
        Me.txt作業No = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt入力担当者 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入先 = New DataDynamics.ActiveReports.TextBox()
        Me.txt台紙名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txtベース名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt糊名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt発注日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt寸法 = New DataDynamics.ActiveReports.TextBox()
        Me.txt客先納期 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txt受注日 = New DataDynamics.ActiveReports.TextBox()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注台帳 = New DataDynamics.ActiveReports.TextBox()
        Me.txt新再区分 = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注区分 = New DataDynamics.ActiveReports.TextBox()
        Me.txt機械区分 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl客先納期 = New DataDynamics.ActiveReports.Label()
        Me.lbl受注単価 = New DataDynamics.ActiveReports.Label()
        Me.lbl入力担当者 = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入先 = New DataDynamics.ActiveReports.Label()
        Me.lbl発注日 = New DataDynamics.ActiveReports.Label()
        Me.lbl寸法 = New DataDynamics.ActiveReports.Label()
        Me.lbl台紙名 = New DataDynamics.ActiveReports.Label()
        Me.lblベース数 = New DataDynamics.ActiveReports.Label()
        Me.lbl糊名 = New DataDynamics.ActiveReports.Label()
        Me.lbl通数 = New DataDynamics.ActiveReports.Label()
        Me.ｌｂｌ枚数 = New DataDynamics.ActiveReports.Label()
        Me.lbl機械別 = New DataDynamics.ActiveReports.Label()
        Me.lbl商品名 = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先名 = New DataDynamics.ActiveReports.Label()
        Me.lbl作業No = New DataDynamics.ActiveReports.Label()
        Me.lbl受注台帳 = New DataDynamics.ActiveReports.Label()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr得意先CD = New DataDynamics.ActiveReports.GroupHeader()
        Me.grpFtr受注 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt枚数計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品受注金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先受注日計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        CType(Me.txt枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt機械別, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入力担当者, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt台紙名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtベース名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt糊名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt寸法, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt客先納期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注台帳, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt新再区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt機械区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl客先納期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl受注単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl入力担当者, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入先, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl発注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl寸法, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl台紙名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblベース数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl糊名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ｌｂｌ枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl機械別, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl受注台帳, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt枚数計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品受注金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先受注日計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt枚数, Me.txt機械別, Me.txt作業No, Me.txt得意先名, Me.txt商品名, Me.txt入力担当者, Me.txt仕入先, Me.txt台紙名, Me.txt受注単価, Me.txtベース名, Me.txt通数, Me.txt糊名, Me.txt発注日, Me.txt寸法, Me.txt客先納期})
        Me.Detail.Height = 0.4409449!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt枚数
        '
        Me.txt枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数.Height = 0.4409449!
        Me.txt枚数.Left = 5.098425!
        Me.txt枚数.Name = "txt枚数"
        Me.txt枚数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt枚数.Text = "1234"
        Me.txt枚数.Top = 0.0!
        Me.txt枚数.Width = 0.7716536!
        '
        'txt機械別
        '
        Me.txt機械別.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt機械別.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt機械別.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt機械別.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt機械別.Height = 0.4409449!
        Me.txt機械別.Left = 4.326772!
        Me.txt機械別.Name = "txt機械別"
        Me.txt機械別.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt機械別.Text = "ああああ"
        Me.txt機械別.Top = 0.0!
        Me.txt機械別.Width = 0.7716536!
        '
        'txt作業No
        '
        Me.txt作業No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Height = 0.4409449!
        Me.txt作業No.Left = 0.0!
        Me.txt作業No.Name = "txt作業No"
        Me.txt作業No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt作業No.Text = "123456"
        Me.txt作業No.Top = 0.0!
        Me.txt作業No.Width = 0.468504!
        '
        'txt得意先名
        '
        Me.txt得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Height = 0.4409449!
        Me.txt得意先名.Left = 0.468504!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt得意先名.Text = "あああああいいいいいううううう"
        Me.txt得意先名.Top = 0.0!
        Me.txt得意先名.Width = 1.791339!
        '
        'txt商品名
        '
        Me.txt商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Height = 0.4409449!
        Me.txt商品名.Left = 2.259843!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt商品名.Text = "あああああいいいいいううううう"
        Me.txt商品名.Top = 0.0!
        Me.txt商品名.Width = 2.066929!
        '
        'txt入力担当者
        '
        Me.txt入力担当者.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入力担当者.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入力担当者.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入力担当者.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入力担当者.Height = 0.4409449!
        Me.txt入力担当者.Left = 12.64961!
        Me.txt入力担当者.Name = "txt入力担当者"
        Me.txt入力担当者.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt入力担当者.Text = "あああああ"
        Me.txt入力担当者.Top = 0.0!
        Me.txt入力担当者.Width = 1.074803!
        '
        'txt仕入先
        '
        Me.txt仕入先.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先.Height = 0.4409449!
        Me.txt仕入先.Left = 11.60236!
        Me.txt仕入先.Name = "txt仕入先"
        Me.txt仕入先.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt仕入先.Text = "あああああ"
        Me.txt仕入先.Top = 0.0!
        Me.txt仕入先.Width = 1.047244!
        '
        'txt台紙名
        '
        Me.txt台紙名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙名.Height = 0.4409449!
        Me.txt台紙名.Left = 8.901575!
        Me.txt台紙名.Name = "txt台紙名"
        Me.txt台紙名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt台紙名.Text = "あああ"
        Me.txt台紙名.Top = 0.0!
        Me.txt台紙名.Width = 0.7992126!
        '
        'txt受注単価
        '
        Me.txt受注単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注単価.Height = 0.4409449!
        Me.txt受注単価.Left = 13.72441!
        Me.txt受注単価.Name = "txt受注単価"
        Me.txt受注単価.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt受注単価.Text = "999,999"
        Me.txt受注単価.Top = 0.0!
        Me.txt受注単価.Width = 0.7992126!
        '
        'txtベース名
        '
        Me.txtベース名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtベース名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtベース名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtベース名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtベース名.Height = 0.4409449!
        Me.txtベース名.Left = 6.669291!
        Me.txtベース名.Name = "txtベース名"
        Me.txtベース名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txtベース名.Text = "ｷｬｽﾄ1234"
        Me.txtベース名.Top = 0.0!
        Me.txtベース名.Width = 1.377953!
        '
        'txt通数
        '
        Me.txt通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数.Height = 0.4409449!
        Me.txt通数.Left = 5.870079!
        Me.txt通数.Name = "txt通数"
        Me.txt通数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt通数.Text = "1234"
        Me.txt通数.Top = 0.0!
        Me.txt通数.Width = 0.7992126!
        '
        'txt糊名
        '
        Me.txt糊名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊名.Height = 0.4409449!
        Me.txt糊名.Left = 8.047244!
        Me.txt糊名.Name = "txt糊名"
        Me.txt糊名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt糊名.Text = "あああ"
        Me.txt糊名.Top = 0.0!
        Me.txt糊名.Width = 0.8543308!
        '
        'txt発注日
        '
        Me.txt発注日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Height = 0.4409449!
        Me.txt発注日.Left = 10.52756!
        Me.txt発注日.Name = "txt発注日"
        Me.txt発注日.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt発注日.Text = "YY/MM/DD"
        Me.txt発注日.Top = 0.0!
        Me.txt発注日.Width = 1.074803!
        '
        'txt寸法
        '
        Me.txt寸法.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt寸法.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt寸法.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt寸法.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt寸法.Height = 0.4409449!
        Me.txt寸法.Left = 9.700788!
        Me.txt寸法.Name = "txt寸法"
        Me.txt寸法.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt寸法.Text = "999" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt寸法.Top = 0.0!
        Me.txt寸法.Width = 0.8267716!
        '
        'txt客先納期
        '
        Me.txt客先納期.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt客先納期.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt客先納期.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt客先納期.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt客先納期.Height = 0.4409449!
        Me.txt客先納期.Left = 14.52362!
        Me.txt客先納期.Name = "txt客先納期"
        Me.txt客先納期.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt客先納期.Text = "YY/MM/DD"
        Me.txt客先納期.Top = 0.0!
        Me.txt客先納期.Width = 0.6614173!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt受注日, Me.txtNow, Me.txt頁, Me.txt受注台帳, Me.txt新再区分, Me.txt受注区分, Me.txt機械区分, Me.lbl客先納期, Me.lbl受注単価, Me.lbl入力担当者, Me.lbl仕入先, Me.lbl発注日, Me.lbl寸法, Me.lbl台紙名, Me.lblベース数, Me.lbl糊名, Me.lbl通数, Me.ｌｂｌ枚数, Me.lbl機械別, Me.lbl商品名, Me.lbl得意先名, Me.lbl作業No, Me.lbl受注台帳})
        Me.PageHeader.Height = 1.122835!
        Me.PageHeader.Name = "PageHeader"
        '
        'txt受注日
        '
        Me.txt受注日.Height = 0.2362205!
        Me.txt受注日.Left = 0.7610237!
        Me.txt受注日.Name = "txt受注日"
        Me.txt受注日.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt受注日.Text = "00/00/00～99/99/99　日分(迄)"
        Me.txt受注日.Top = 0.3149607!
        Me.txt受注日.Width = 2.491339!
        '
        'txtNow
        '
        Me.txtNow.Height = 0.2362205!
        Me.txtNow.Left = 12.20276!
        Me.txtNow.Name = "txtNow"
        Me.txtNow.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtNow.Text = "YY/MM/DD　123456 作成"
        Me.txtNow.Top = 0.0!
        Me.txtNow.Width = 2.067716!
        '
        'txt頁
        '
        Me.txt頁.Height = 0.2362205!
        Me.txt頁.Left = 14.52363!
        Me.txt頁.Name = "txt頁"
        Me.txt頁.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt頁.Text = "頁"
        Me.txt頁.Top = 0.0!
        Me.txt頁.Width = 0.3795285!
        '
        'txt受注台帳
        '
        Me.txt受注台帳.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt受注台帳.Height = 0.3307087!
        Me.txt受注台帳.Left = 4.290945!
        Me.txt受注台帳.Name = "txt受注台帳"
        Me.txt受注台帳.Style = "font-family: ＭＳ 明朝; font-size: 18pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt受注台帳.Text = "受　注　台　帳"
        Me.txt受注台帳.Top = 0.2362205!
        Me.txt受注台帳.Width = 2.305512!
        '
        'txt新再区分
        '
        Me.txt新再区分.Height = 0.2988189!
        Me.txt新再区分.Left = 6.74252!
        Me.txt新再区分.Name = "txt新再区分"
        Me.txt新再区分.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt新再区分.Text = "(●版)"
        Me.txt新再区分.Top = 0.2799213!
        Me.txt新再区分.Width = 0.8480315!
        '
        'txt受注区分
        '
        Me.txt受注区分.Height = 0.2988189!
        Me.txt受注区分.Left = 7.875985!
        Me.txt受注区分.Name = "txt受注区分"
        Me.txt受注区分.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt受注区分.Text = "(あああああ)"
        Me.txt受注区分.Top = 0.2799213!
        Me.txt受注区分.Width = 1.410237!
        '
        'txt機械区分
        '
        Me.txt機械区分.Height = 0.2988189!
        Me.txt機械区分.Left = 10.3248!
        Me.txt機械区分.Name = "txt機械区分"
        Me.txt機械区分.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt機械区分.Text = "(●●分)"
        Me.txt機械区分.Top = 0.2799213!
        Me.txt機械区分.Width = 1.410237!
        '
        'lbl客先納期
        '
        Me.lbl客先納期.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl客先納期.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl客先納期.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl客先納期.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl客先納期.Height = 0.3346457!
        Me.lbl客先納期.HyperLink = Nothing
        Me.lbl客先納期.Left = 14.52362!
        Me.lbl客先納期.Name = "lbl客先納期"
        Me.lbl客先納期.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl客先納期.Text = "客先納期"
        Me.lbl客先納期.Top = 0.7881891!
        Me.lbl客先納期.Width = 0.6614173!
        '
        'lbl受注単価
        '
        Me.lbl受注単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注単価.Height = 0.3346457!
        Me.lbl受注単価.HyperLink = Nothing
        Me.lbl受注単価.Left = 13.72441!
        Me.lbl受注単価.Name = "lbl受注単価"
        Me.lbl受注単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl受注単価.Text = "受注単価"
        Me.lbl受注単価.Top = 0.7881891!
        Me.lbl受注単価.Width = 0.7992126!
        '
        'lbl入力担当者
        '
        Me.lbl入力担当者.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl入力担当者.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl入力担当者.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl入力担当者.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl入力担当者.Height = 0.3346457!
        Me.lbl入力担当者.HyperLink = Nothing
        Me.lbl入力担当者.Left = 12.64961!
        Me.lbl入力担当者.Name = "lbl入力担当者"
        Me.lbl入力担当者.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl入力担当者.Text = "入力担当者"
        Me.lbl入力担当者.Top = 0.7881891!
        Me.lbl入力担当者.Width = 1.074803!
        '
        'lbl仕入先
        '
        Me.lbl仕入先.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先.Height = 0.3346457!
        Me.lbl仕入先.HyperLink = Nothing
        Me.lbl仕入先.Left = 11.60236!
        Me.lbl仕入先.Name = "lbl仕入先"
        Me.lbl仕入先.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl仕入先.Text = "仕入先"
        Me.lbl仕入先.Top = 0.7881891!
        Me.lbl仕入先.Width = 1.047244!
        '
        'lbl発注日
        '
        Me.lbl発注日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注日.Height = 0.3346457!
        Me.lbl発注日.HyperLink = Nothing
        Me.lbl発注日.Left = 10.52756!
        Me.lbl発注日.Name = "lbl発注日"
        Me.lbl発注日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl発注日.Text = "仮発注日/発注日"
        Me.lbl発注日.Top = 0.7881891!
        Me.lbl発注日.Width = 1.074803!
        '
        'lbl寸法
        '
        Me.lbl寸法.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl寸法.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl寸法.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl寸法.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl寸法.Height = 0.3346457!
        Me.lbl寸法.HyperLink = Nothing
        Me.lbl寸法.Left = 9.700788!
        Me.lbl寸法.Name = "lbl寸法"
        Me.lbl寸法.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl寸法.Text = "寸　法"
        Me.lbl寸法.Top = 0.7881891!
        Me.lbl寸法.Width = 0.8267716!
        '
        'lbl台紙名
        '
        Me.lbl台紙名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙名.Height = 0.3346457!
        Me.lbl台紙名.HyperLink = Nothing
        Me.lbl台紙名.Left = 8.901575!
        Me.lbl台紙名.Name = "lbl台紙名"
        Me.lbl台紙名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl台紙名.Text = "台紙名"
        Me.lbl台紙名.Top = 0.7881891!
        Me.lbl台紙名.Width = 0.7992126!
        '
        'lblベース数
        '
        Me.lblベース数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblベース数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblベース数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblベース数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblベース数.Height = 0.3346457!
        Me.lblベース数.HyperLink = Nothing
        Me.lblベース数.Left = 6.669291!
        Me.lblベース数.Name = "lblベース数"
        Me.lblベース数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lblベース数.Text = "ベース数"
        Me.lblベース数.Top = 0.7881891!
        Me.lblベース数.Width = 1.377953!
        '
        'lbl糊名
        '
        Me.lbl糊名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊名.Height = 0.3346457!
        Me.lbl糊名.HyperLink = Nothing
        Me.lbl糊名.Left = 8.047244!
        Me.lbl糊名.Name = "lbl糊名"
        Me.lbl糊名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl糊名.Text = "糊名"
        Me.lbl糊名.Top = 0.7881891!
        Me.lbl糊名.Width = 0.8543308!
        '
        'lbl通数
        '
        Me.lbl通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Height = 0.3346457!
        Me.lbl通数.HyperLink = Nothing
        Me.lbl通数.Left = 5.870079!
        Me.lbl通数.Name = "lbl通数"
        Me.lbl通数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl通数.Text = "通　数"
        Me.lbl通数.Top = 0.7881891!
        Me.lbl通数.Width = 0.7992126!
        '
        'ｌｂｌ枚数
        '
        Me.ｌｂｌ枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ枚数.Height = 0.3346457!
        Me.ｌｂｌ枚数.HyperLink = Nothing
        Me.ｌｂｌ枚数.Left = 5.098425!
        Me.ｌｂｌ枚数.Name = "ｌｂｌ枚数"
        Me.ｌｂｌ枚数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.ｌｂｌ枚数.Text = "枚　数"
        Me.ｌｂｌ枚数.Top = 0.7881891!
        Me.ｌｂｌ枚数.Width = 0.7716536!
        '
        'lbl機械別
        '
        Me.lbl機械別.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl機械別.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl機械別.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl機械別.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl機械別.Height = 0.3346457!
        Me.lbl機械別.HyperLink = Nothing
        Me.lbl機械別.Left = 4.326772!
        Me.lbl機械別.Name = "lbl機械別"
        Me.lbl機械別.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl機械別.Text = "機械別"
        Me.lbl機械別.Top = 0.7881891!
        Me.lbl機械別.Width = 0.7716536!
        '
        'lbl商品名
        '
        Me.lbl商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Height = 0.3346457!
        Me.lbl商品名.HyperLink = Nothing
        Me.lbl商品名.Left = 2.259843!
        Me.lbl商品名.Name = "lbl商品名"
        Me.lbl商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl商品名.Text = "商品名"
        Me.lbl商品名.Top = 0.7881891!
        Me.lbl商品名.Width = 2.066929!
        '
        'lbl得意先名
        '
        Me.lbl得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Height = 0.3346457!
        Me.lbl得意先名.HyperLink = Nothing
        Me.lbl得意先名.Left = 0.468504!
        Me.lbl得意先名.Name = "lbl得意先名"
        Me.lbl得意先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl得意先名.Text = "得意先名"
        Me.lbl得意先名.Top = 0.7881891!
        Me.lbl得意先名.Width = 1.791339!
        '
        'lbl作業No
        '
        Me.lbl作業No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Height = 0.3346457!
        Me.lbl作業No.HyperLink = Nothing
        Me.lbl作業No.Left = 0.0!
        Me.lbl作業No.Name = "lbl作業No"
        Me.lbl作業No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl作業No.Text = "作業No"
        Me.lbl作業No.Top = 0.7881891!
        Me.lbl作業No.Width = 0.468504!
        '
        'lbl受注台帳
        '
        Me.lbl受注台帳.Height = 0.2362205!
        Me.lbl受注台帳.HyperLink = Nothing
        Me.lbl受注台帳.Left = 0.05118111!
        Me.lbl受注台帳.Name = "lbl受注台帳"
        Me.lbl受注台帳.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl受注台帳.Text = "受注台帳"
        Me.lbl受注台帳.Top = 0.3149607!
        Me.lbl受注台帳.Width = 0.6692914!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdr得意先CD
        '
        Me.grpHdr得意先CD.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr得意先CD.Height = 0.0!
        Me.grpHdr得意先CD.Name = "grpHdr得意先CD"
        Me.grpHdr得意先CD.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'grpFtr受注
        '
        Me.grpFtr受注.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.txt通数計, Me.txt枚数計, Me.TextBox12, Me.txt商品受注金額, Me.txt得意先受注日計, Me.TextBox15, Me.Label1, Me.Label2})
        Me.grpFtr受注.Height = 0.4409449!
        Me.grpFtr受注.Name = "grpFtr受注"
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.4409449!
        Me.TextBox1.Left = 14.52362!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.6614173!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Height = 0.4409449!
        Me.TextBox2.Left = 13.72441!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 0.7992126!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.4409449!
        Me.TextBox3.Left = 12.64961!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 1.074803!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Height = 0.4409449!
        Me.TextBox4.Left = 11.60236!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 1.047244!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Height = 0.4409449!
        Me.TextBox5.Left = 10.52756!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 1.074803!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Height = 0.4409449!
        Me.TextBox6.Left = 9.700788!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 0.8267716!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Height = 0.4409449!
        Me.TextBox7.Left = 8.901575!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 0.7992126!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Height = 0.4409449!
        Me.TextBox8.Left = 8.047244!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 0.8543308!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Height = 0.4409449!
        Me.TextBox9.Left = 6.669291!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0.0!
        Me.TextBox9.Width = 1.377953!
        '
        'txt通数計
        '
        Me.txt通数計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数計.Height = 0.4409449!
        Me.txt通数計.Left = 5.870079!
        Me.txt通数計.Name = "txt通数計"
        Me.txt通数計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt通数計.Text = "1234"
        Me.txt通数計.Top = 0.0!
        Me.txt通数計.Width = 0.7992126!
        '
        'txt枚数計
        '
        Me.txt枚数計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数計.Height = 0.4409449!
        Me.txt枚数計.Left = 5.098425!
        Me.txt枚数計.Name = "txt枚数計"
        Me.txt枚数計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt枚数計.Text = "1234"
        Me.txt枚数計.Top = 0.0!
        Me.txt枚数計.Width = 0.7716536!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Height = 0.4409449!
        Me.TextBox12.Left = 4.326772!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox12.Text = Nothing
        Me.TextBox12.Top = 0.0!
        Me.TextBox12.Width = 0.7716536!
        '
        'txt商品受注金額
        '
        Me.txt商品受注金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品受注金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品受注金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品受注金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品受注金額.Height = 0.4409449!
        Me.txt商品受注金額.Left = 2.259843!
        Me.txt商品受注金額.Name = "txt商品受注金額"
        Me.txt商品受注金額.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt商品受注金額.Text = "999,999,999"
        Me.txt商品受注金額.Top = 0.0!
        Me.txt商品受注金額.Width = 2.066929!
        '
        'txt得意先受注日計
        '
        Me.txt得意先受注日計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先受注日計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先受注日計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先受注日計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先受注日計.Height = 0.4409449!
        Me.txt得意先受注日計.Left = 0.468504!
        Me.txt得意先受注日計.Name = "txt得意先受注日計"
        Me.txt得意先受注日計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt得意先受注日計.Text = "99件"
        Me.txt得意先受注日計.Top = 0.0!
        Me.txt得意先受注日計.Width = 1.791339!
        '
        'TextBox15
        '
        Me.TextBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Height = 0.4409449!
        Me.TextBox15.Left = 0.0!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox15.Text = Nothing
        Me.TextBox15.Top = 0.0!
        Me.TextBox15.Width = 0.468504!
        '
        'Label1
        '
        Me.Label1.Height = 0.2362205!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.9590552!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label1.Text = "*受注日計"
        Me.Label1.Top = 0.0992126!
        Me.Label1.Width = 0.7874015!
        '
        'Label2
        '
        Me.Label2.Height = 0.2362205!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 2.551181!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label2.Text = "受注金額"
        Me.Label2.Top = 0.1125984!
        Me.Label2.Width = 0.7874016!
        '
        'OrderRegister
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 15.46063!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr得意先CD)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr受注)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt機械別, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入力担当者, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt台紙名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtベース名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt糊名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt寸法, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt客先納期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注台帳, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt新再区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt機械区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl客先納期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl受注単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl入力担当者, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入先, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl発注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl寸法, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl台紙名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblベース数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl糊名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ｌｂｌ枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl機械別, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl受注台帳, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt枚数計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品受注金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先受注日計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents grpHdr得意先CD As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt枚数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt機械別 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt作業No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpFtr受注 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt受注日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt入力担当者 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt台紙名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt受注単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt受注台帳 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt新再区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt受注区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt機械区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtベース名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt糊名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt発注日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt寸法 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt客先納期 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt通数計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt枚数計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品受注金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先受注日計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl客先納期 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl受注単価 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl入力担当者 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl仕入先 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl発注日 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl寸法 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl台紙名 As DataDynamics.ActiveReports.Label
    Private WithEvents lblベース数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl糊名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl通数 As DataDynamics.ActiveReports.Label
    Private WithEvents ｌｂｌ枚数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl機械別 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl作業No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl受注台帳 As DataDynamics.ActiveReports.Label
End Class
