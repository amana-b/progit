<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class WorkList
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(WorkList))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt印刷場所 = New DataDynamics.ActiveReports.TextBox()
        Me.txt作業No = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt寸法 = New DataDynamics.ActiveReports.TextBox()
        Me.txt台紙 = New DataDynamics.ActiveReports.TextBox()
        Me.txt糊 = New DataDynamics.ActiveReports.TextBox()
        Me.txt刃型No = New DataDynamics.ActiveReports.TextBox()
        Me.txt本台帳No = New DataDynamics.ActiveReports.TextBox()
        Me.txt紙名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt版No = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt受注日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt作業準備リスト = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注区分 = New DataDynamics.ActiveReports.TextBox()
        Me.txt新再区分 = New DataDynamics.ActiveReports.TextBox()
        Me.txt場所区分 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl作業No = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先名 = New DataDynamics.ActiveReports.Label()
        Me.ｌｂｌ商品名 = New DataDynamics.ActiveReports.Label()
        Me.lbl本台帳No = New DataDynamics.ActiveReports.Label()
        Me.lbl紙名 = New DataDynamics.ActiveReports.Label()
        Me.lbl糊 = New DataDynamics.ActiveReports.Label()
        Me.lbl台紙 = New DataDynamics.ActiveReports.Label()
        Me.lbl寸法 = New DataDynamics.ActiveReports.Label()
        Me.lbl刃型No = New DataDynamics.ActiveReports.Label()
        Me.lbl版No = New DataDynamics.ActiveReports.Label()
        Me.lbl印刷場所 = New DataDynamics.ActiveReports.Label()
        Me.lbl受注日 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先件数 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl合計 = New DataDynamics.ActiveReports.Label()
        CType(Me.txt印刷場所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt寸法, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt台紙, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt糊, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt刃型No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt本台帳No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt紙名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt版No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt作業準備リスト, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt新再区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt場所区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ｌｂｌ商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl本台帳No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl紙名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl糊, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl台紙, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl寸法, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl刃型No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl版No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl印刷場所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl受注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt印刷場所, Me.txt作業No, Me.txt得意先名, Me.txt商品名, Me.txt寸法, Me.txt台紙, Me.txt糊, Me.txt刃型No, Me.txt本台帳No, Me.txt紙名, Me.txt版No})
        Me.Detail.Height = 0.2755905!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt印刷場所
        '
        Me.txt印刷場所.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt印刷場所.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt印刷場所.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt印刷場所.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt印刷場所.Height = 0.2755905!
        Me.txt印刷場所.Left = 10.3937!
        Me.txt印刷場所.Name = "txt印刷場所"
        Me.txt印刷場所.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txt印刷場所.Text = "ああ"
        Me.txt印刷場所.Top = 0.0!
        Me.txt印刷場所.Width = 0.5905512!
        '
        'txt作業No
        '
        Me.txt作業No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Height = 0.2755905!
        Me.txt作業No.Left = 0.0!
        Me.txt作業No.Name = "txt作業No"
        Me.txt作業No.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txt作業No.Text = "12345"
        Me.txt作業No.Top = 0.0!
        Me.txt作業No.Width = 0.511811!
        '
        'txt得意先名
        '
        Me.txt得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Height = 0.2755905!
        Me.txt得意先名.Left = 0.511811!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: left; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt得意先名.Text = "あああああいいいいいううううう"
        Me.txt得意先名.Top = 0.00000005960464!
        Me.txt得意先名.Width = 2.086614!
        '
        'txt商品名
        '
        Me.txt商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Height = 0.2755905!
        Me.txt商品名.Left = 2.598425!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: left; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt商品名.Text = "あああああいいいいい"
        Me.txt商品名.Top = 0.0!
        Me.txt商品名.Width = 2.066929!
        '
        'txt寸法
        '
        Me.txt寸法.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt寸法.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt寸法.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt寸法.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt寸法.Height = 0.2755905!
        Me.txt寸法.Left = 8.464567!
        Me.txt寸法.Name = "txt寸法"
        Me.txt寸法.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txt寸法.Text = "YY/MM/DD"
        Me.txt寸法.Top = 0.0!
        Me.txt寸法.Width = 0.8267716!
        '
        'txt台紙
        '
        Me.txt台紙.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙.Height = 0.2755905!
        Me.txt台紙.Left = 7.598425!
        Me.txt台紙.Name = "txt台紙"
        Me.txt台紙.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt台紙.Text = "あああああ"
        Me.txt台紙.Top = 0.0!
        Me.txt台紙.Width = 0.8661417!
        '
        'txt糊
        '
        Me.txt糊.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊.Height = 0.2755905!
        Me.txt糊.Left = 6.732284!
        Me.txt糊.Name = "txt糊"
        Me.txt糊.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt糊.Text = "あああああ"
        Me.txt糊.Top = 0.0!
        Me.txt糊.Width = 0.8661417!
        '
        'txt刃型No
        '
        Me.txt刃型No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型No.Height = 0.2755905!
        Me.txt刃型No.Left = 9.291339!
        Me.txt刃型No.Name = "txt刃型No"
        Me.txt刃型No.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txt刃型No.Text = "1234"
        Me.txt刃型No.Top = 0.00000005960464!
        Me.txt刃型No.Width = 0.5905512!
        '
        'txt本台帳No
        '
        Me.txt本台帳No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt本台帳No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt本台帳No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt本台帳No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt本台帳No.Height = 0.2755905!
        Me.txt本台帳No.Left = 4.665355!
        Me.txt本台帳No.Name = "txt本台帳No"
        Me.txt本台帳No.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txt本台帳No.Text = "123456789"
        Me.txt本台帳No.Top = 0.0!
        Me.txt本台帳No.Width = 0.6889764!
        '
        'txt紙名
        '
        Me.txt紙名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙名.Height = 0.2755905!
        Me.txt紙名.Left = 5.354331!
        Me.txt紙名.Name = "txt紙名"
        Me.txt紙名.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: left; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt紙名.Text = "あああああいいいいい"
        Me.txt紙名.Top = 0.0!
        Me.txt紙名.Width = 1.377953!
        '
        'txt版No
        '
        Me.txt版No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版No.Height = 0.2755905!
        Me.txt版No.Left = 9.88189!
        Me.txt版No.Name = "txt版No"
        Me.txt版No.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txt版No.Text = "123456"
        Me.txt版No.Top = 0.0!
        Me.txt版No.Width = 0.511811!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNow, Me.txt頁})
        Me.PageHeader.Height = 0.3199635!
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
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt受注日, Me.txt作業準備リスト, Me.txt受注区分, Me.txt新再区分, Me.txt場所区分, Me.lbl作業No, Me.lbl得意先名, Me.ｌｂｌ商品名, Me.lbl本台帳No, Me.lbl紙名, Me.lbl糊, Me.lbl台紙, Me.lbl寸法, Me.lbl刃型No, Me.lbl版No, Me.lbl印刷場所, Me.lbl受注日})
        Me.grpHdr.Height = 0.8645832!
        Me.grpHdr.Name = "grpHdr"
        '
        'txt受注日
        '
        Me.txt受注日.Height = 0.2362205!
        Me.txt受注日.Left = 0.7370077!
        Me.txt受注日.Name = "txt受注日"
        Me.txt受注日.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt受注日.Text = "99/99/99　日分"
        Me.txt受注日.Top = 0.0!
        Me.txt受注日.Width = 1.431496!
        '
        'txt作業準備リスト
        '
        Me.txt作業準備リスト.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt作業準備リスト.Height = 0.2362205!
        Me.txt作業準備リスト.Left = 4.309843!
        Me.txt作業準備リスト.Name = "txt作業準備リスト"
        Me.txt作業準備リスト.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt作業準備リスト.Text = "作業準備リスト"
        Me.txt作業準備リスト.Top = 0.08110237!
        Me.txt作業準備リスト.Width = 2.608661!
        '
        'txt受注区分
        '
        Me.txt受注区分.Height = 0.2362205!
        Me.txt受注区分.Left = 7.093306!
        Me.txt受注区分.Name = "txt受注区分"
        Me.txt受注区分.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt受注区分.Text = "(●●のみ)"
        Me.txt受注区分.Top = 0.08267725!
        Me.txt受注区分.Width = 0.9728355!
        '
        'txt新再区分
        '
        Me.txt新再区分.Height = 0.2362205!
        Me.txt新再区分.Left = 8.121653!
        Me.txt新再区分.Name = "txt新再区分"
        Me.txt新再区分.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt新再区分.Text = "(●●のみ)"
        Me.txt新再区分.Top = 0.08267725!
        Me.txt新再区分.Width = 1.483071!
        '
        'txt場所区分
        '
        Me.txt場所区分.Height = 0.2362205!
        Me.txt場所区分.Left = 9.72441!
        Me.txt場所区分.Name = "txt場所区分"
        Me.txt場所区分.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt場所区分.Text = "(●●分)"
        Me.txt場所区分.Top = 0.08267725!
        Me.txt場所区分.Width = 0.9728355!
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
        Me.lbl作業No.Top = 0.5165353!
        Me.lbl作業No.Width = 0.511811!
        '
        'lbl得意先名
        '
        Me.lbl得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Height = 0.3346457!
        Me.lbl得意先名.HyperLink = Nothing
        Me.lbl得意先名.Left = 0.511811!
        Me.lbl得意先名.Name = "lbl得意先名"
        Me.lbl得意先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl得意先名.Text = "得意先名"
        Me.lbl得意先名.Top = 0.5165353!
        Me.lbl得意先名.Width = 2.086614!
        '
        'ｌｂｌ商品名
        '
        Me.ｌｂｌ商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Height = 0.3346457!
        Me.ｌｂｌ商品名.HyperLink = Nothing
        Me.ｌｂｌ商品名.Left = 2.598425!
        Me.ｌｂｌ商品名.Name = "ｌｂｌ商品名"
        Me.ｌｂｌ商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.ｌｂｌ商品名.Text = "商品名"
        Me.ｌｂｌ商品名.Top = 0.5165353!
        Me.ｌｂｌ商品名.Width = 2.066929!
        '
        'lbl本台帳No
        '
        Me.lbl本台帳No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl本台帳No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl本台帳No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl本台帳No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl本台帳No.Height = 0.3346457!
        Me.lbl本台帳No.HyperLink = Nothing
        Me.lbl本台帳No.Left = 4.665355!
        Me.lbl本台帳No.Name = "lbl本台帳No"
        Me.lbl本台帳No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl本台帳No.Text = "本台帳No"
        Me.lbl本台帳No.Top = 0.5165353!
        Me.lbl本台帳No.Width = 0.6889763!
        '
        'lbl紙名
        '
        Me.lbl紙名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙名.Height = 0.3346457!
        Me.lbl紙名.HyperLink = Nothing
        Me.lbl紙名.Left = 5.354331!
        Me.lbl紙名.Name = "lbl紙名"
        Me.lbl紙名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl紙名.Text = "紙名"
        Me.lbl紙名.Top = 0.5165353!
        Me.lbl紙名.Width = 1.377953!
        '
        'lbl糊
        '
        Me.lbl糊.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊.Height = 0.3346457!
        Me.lbl糊.HyperLink = Nothing
        Me.lbl糊.Left = 6.732284!
        Me.lbl糊.Name = "lbl糊"
        Me.lbl糊.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl糊.Text = "糊"
        Me.lbl糊.Top = 0.5165353!
        Me.lbl糊.Width = 0.8661417!
        '
        'lbl台紙
        '
        Me.lbl台紙.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙.Height = 0.3346457!
        Me.lbl台紙.HyperLink = Nothing
        Me.lbl台紙.Left = 7.598424!
        Me.lbl台紙.Name = "lbl台紙"
        Me.lbl台紙.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl台紙.Text = "台紙"
        Me.lbl台紙.Top = 0.5165353!
        Me.lbl台紙.Width = 0.8267716!
        '
        'lbl寸法
        '
        Me.lbl寸法.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl寸法.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl寸法.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl寸法.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl寸法.Height = 0.3346457!
        Me.lbl寸法.HyperLink = Nothing
        Me.lbl寸法.Left = 8.425195!
        Me.lbl寸法.Name = "lbl寸法"
        Me.lbl寸法.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl寸法.Text = "寸法"
        Me.lbl寸法.Top = 0.5165353!
        Me.lbl寸法.Width = 0.8267716!
        '
        'lbl刃型No
        '
        Me.lbl刃型No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl刃型No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl刃型No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl刃型No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl刃型No.Height = 0.3346457!
        Me.lbl刃型No.HyperLink = Nothing
        Me.lbl刃型No.Left = 9.251966!
        Me.lbl刃型No.Name = "lbl刃型No"
        Me.lbl刃型No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl刃型No.Text = "刃型No"
        Me.lbl刃型No.Top = 0.5165353!
        Me.lbl刃型No.Width = 0.5905511!
        '
        'lbl版No
        '
        Me.lbl版No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版No.Height = 0.3346457!
        Me.lbl版No.HyperLink = Nothing
        Me.lbl版No.Left = 9.842521!
        Me.lbl版No.Name = "lbl版No"
        Me.lbl版No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl版No.Text = "版No"
        Me.lbl版No.Top = 0.5165353!
        Me.lbl版No.Width = 0.511811!
        '
        'lbl印刷場所
        '
        Me.lbl印刷場所.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl印刷場所.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl印刷場所.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl印刷場所.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl印刷場所.Height = 0.3346457!
        Me.lbl印刷場所.HyperLink = Nothing
        Me.lbl印刷場所.Left = 10.35433!
        Me.lbl印刷場所.Name = "lbl印刷場所"
        Me.lbl印刷場所.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl印刷場所.Text = "印刷場所"
        Me.lbl印刷場所.Top = 0.5165353!
        Me.lbl印刷場所.Width = 0.5905511!
        '
        'lbl受注日
        '
        Me.lbl受注日.Height = 0.2362205!
        Me.lbl受注日.HyperLink = Nothing
        Me.lbl受注日.Left = 0.0!
        Me.lbl受注日.Name = "lbl受注日"
        Me.lbl受注日.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-al" & _
    "ign: center; vertical-align: middle; ddo-char-set: 1"
        Me.lbl受注日.Text = "受注日"
        Me.lbl受注日.Top = 0.0!
        Me.lbl受注日.Width = 0.5846457!
        '
        'grpFtr
        '
        Me.grpFtr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.txt得意先件数, Me.TextBox11, Me.lbl合計})
        Me.grpFtr.Height = 0.2755905!
        Me.grpFtr.Name = "grpFtr"
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.2755906!
        Me.TextBox1.Left = 10.3937!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.5905511!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Height = 0.2755906!
        Me.TextBox2.Left = 9.881888!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 0.511811!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.2755906!
        Me.TextBox3.Left = 9.291341!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.00000005960464!
        Me.TextBox3.Width = 0.5905511!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Height = 0.2755906!
        Me.TextBox4.Left = 8.46457!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 0.8267716!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Height = 0.2755906!
        Me.TextBox5.Left = 7.598424!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 0.8661417!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Height = 0.2755906!
        Me.TextBox6.Left = 6.732284!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 0.8661417!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Height = 0.2755906!
        Me.TextBox7.Left = 5.354331!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: left; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 1.377953!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Height = 0.2755906!
        Me.TextBox8.Left = 4.665355!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 0.6889763!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Height = 0.2755906!
        Me.TextBox9.Left = 2.598426!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: left; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0.0!
        Me.TextBox9.Width = 2.066929!
        '
        'txt得意先件数
        '
        Me.txt得意先件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先件数.Height = 0.2755906!
        Me.txt得意先件数.Left = 0.511811!
        Me.txt得意先件数.Name = "txt得意先件数"
        Me.txt得意先件数.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt得意先件数.Text = "99件"
        Me.txt得意先件数.Top = 0.00000005960464!
        Me.txt得意先件数.Width = 2.086615!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Height = 0.2755906!
        Me.TextBox11.Left = 0.0!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 0.0!
        Me.TextBox11.Width = 0.511811!
        '
        'lbl合計
        '
        Me.lbl合計.Height = 0.1968504!
        Me.lbl合計.HyperLink = Nothing
        Me.lbl合計.Left = 0.7779528!
        Me.lbl合計.Name = "lbl合計"
        Me.lbl合計.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl合計.Text = "＊合計　件数"
        Me.lbl合計.Top = 0.04094489!
        Me.lbl合計.Width = 0.9645671!
        '
        'WorkList
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.90551!
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
        CType(Me.txt印刷場所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt寸法, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt台紙, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt糊, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt刃型No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt本台帳No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt紙名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt版No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt作業準備リスト, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt新再区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt場所区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ｌｂｌ商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl本台帳No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl紙名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl糊, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl台紙, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl寸法, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl刃型No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl版No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl印刷場所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl受注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl合計, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt印刷場所 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt作業No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt寸法 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt台紙 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt糊 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt刃型No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents grpFtr As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt本台帳No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt紙名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt版No As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl合計 As DataDynamics.ActiveReports.Label
    Private WithEvents txt受注日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt作業準備リスト As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt受注区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt新再区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt場所区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl作業No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先名 As DataDynamics.ActiveReports.Label
    Private WithEvents ｌｂｌ商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl本台帳No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl紙名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl糊 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl台紙 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl寸法 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl刃型No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl版No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl印刷場所 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl受注日 As DataDynamics.ActiveReports.Label
End Class
