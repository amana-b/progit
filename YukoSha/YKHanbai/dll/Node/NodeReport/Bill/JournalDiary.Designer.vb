<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class JournalDiary
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(JournalDiary))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt貸方区分名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt摘要 = New DataDynamics.ActiveReports.TextBox()
        Me.txt借方区分名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt伝票No = New DataDynamics.ActiveReports.TextBox()
        Me.txt借方区分 = New DataDynamics.ActiveReports.TextBox()
        Me.txt貸方区分 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt入出金区分 = New DataDynamics.ActiveReports.TextBox()
        Me.txt入金明細表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl前残 = New DataDynamics.ActiveReports.Label()
        Me.lbl金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl科目名 = New DataDynamics.ActiveReports.Label()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.lbl伝票日付 = New DataDynamics.ActiveReports.Label()
        Me.txt伝票日付 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl勘定科目 = New DataDynamics.ActiveReports.Label()
        Me.lbl伝票No = New DataDynamics.ActiveReports.Label()
        Me.lbl摘要 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt合計金額 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt貸方区分名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt摘要, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt借方区分名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt伝票No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt借方区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt貸方区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入出金区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入金明細表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl前残, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl科目名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl伝票日付, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt伝票日付, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl勘定科目, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl伝票No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl摘要, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt貸方区分名, Me.txt金額, Me.txt摘要, Me.txt借方区分名, Me.txt伝票No, Me.txt借方区分, Me.txt貸方区分})
        Me.Detail.Height = 0.2952756!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt貸方区分名
        '
        Me.txt貸方区分名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方区分名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方区分名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方区分名.Height = 0.2952756!
        Me.txt貸方区分名.Left = 1.535433!
        Me.txt貸方区分名.Name = "txt貸方区分名"
        Me.txt貸方区分名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt貸方区分名.Text = "あああああいい"
        Me.txt貸方区分名.Top = 0.0!
        Me.txt貸方区分名.Width = 1.023622!
        '
        'txt金額
        '
        Me.txt金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Height = 0.2952756!
        Me.txt金額.Left = 6.299213!
        Me.txt金額.Name = "txt金額"
        Me.txt金額.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt金額.Text = "999,999"
        Me.txt金額.Top = 0.000001132488!
        Me.txt金額.Width = 1.043307!
        '
        'txt摘要
        '
        Me.txt摘要.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Height = 0.2952756!
        Me.txt摘要.Left = 3.425197!
        Me.txt摘要.Name = "txt摘要"
        Me.txt摘要.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txt摘要.Text = "あああああいいいいいうううううえええええおおおおおかかかかかききききき"
        Me.txt摘要.Top = 0.0!
        Me.txt摘要.Width = 2.874016!
        '
        'txt借方区分名
        '
        Me.txt借方区分名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt借方区分名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt借方区分名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt借方区分名.Height = 0.2952756!
        Me.txt借方区分名.Left = 0.2362205!
        Me.txt借方区分名.Name = "txt借方区分名"
        Me.txt借方区分名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt借方区分名.Text = "あああああいい"
        Me.txt借方区分名.Top = 0.0!
        Me.txt借方区分名.Width = 1.062992!
        '
        'txt伝票No
        '
        Me.txt伝票No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Height = 0.2952756!
        Me.txt伝票No.Left = 2.559055!
        Me.txt伝票No.Name = "txt伝票No"
        Me.txt伝票No.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt伝票No.Text = "123456"
        Me.txt伝票No.Top = 0.0!
        Me.txt伝票No.Width = 0.8661417!
        '
        'txt借方区分
        '
        Me.txt借方区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt借方区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt借方区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt借方区分.Height = 0.2952756!
        Me.txt借方区分.Left = 0.0!
        Me.txt借方区分.Name = "txt借方区分"
        Me.txt借方区分.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt借方区分.Text = "123"
        Me.txt借方区分.Top = 0.0!
        Me.txt借方区分.Width = 0.2362205!
        '
        'txt貸方区分
        '
        Me.txt貸方区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方区分.Height = 0.2952756!
        Me.txt貸方区分.Left = 1.299213!
        Me.txt貸方区分.Name = "txt貸方区分"
        Me.txt貸方区分.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt貸方区分.Text = "123"
        Me.txt貸方区分.Top = 0.0!
        Me.txt貸方区分.Width = 0.2362205!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNow})
        Me.PageHeader.Height = 0.2755905!
        Me.PageHeader.Name = "PageHeader"
        '
        'txtNow
        '
        Me.txtNow.Height = 0.2362205!
        Me.txtNow.Left = 5.292126!
        Me.txtNow.Name = "txtNow"
        Me.txtNow.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtNow.Text = "YY/MM/DD　123456 作成"
        Me.txtNow.Top = 0.0!
        Me.txtNow.Width = 1.890551!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdr
        '
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt入出金区分, Me.txt入金明細表, Me.lbl前残, Me.lbl金額, Me.lbl科目名, Me.Label1, Me.lbl伝票日付, Me.txt伝票日付, Me.lbl勘定科目, Me.lbl伝票No, Me.lbl摘要})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.980315!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txt入出金区分
        '
        Me.txt入出金区分.Height = 0.1968504!
        Me.txt入出金区分.Left = 0.9539371!
        Me.txt入出金区分.Name = "txt入出金区分"
        Me.txt入出金区分.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt入出金区分.Text = "(●●用)"
        Me.txt入出金区分.Top = 0.0!
        Me.txt入出金区分.Width = 0.7874017!
        '
        'txt入金明細表
        '
        Me.txt入金明細表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt入金明細表.CharacterSpacing = 15.0!
        Me.txt入金明細表.Height = 0.2362205!
        Me.txt入金明細表.Left = 2.487402!
        Me.txt入金明細表.Name = "txt入金明細表"
        Me.txt入金明細表.Style = "font-family: ＭＳ Ｐゴシック; font-size: 14pt; font-weight: bold; text-align: center; ve" & _
    "rtical-align: bottom; ddo-char-set: 1"
        Me.txt入金明細表.Text = "仕訳日記帳"
        Me.txt入金明細表.Top = 0.0!
        Me.txt入金明細表.Width = 2.244094!
        '
        'lbl前残
        '
        Me.lbl前残.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前残.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前残.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前残.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前残.CharacterSpacing = 15.0!
        Me.lbl前残.Height = 0.1574803!
        Me.lbl前残.HyperLink = Nothing
        Me.lbl前残.Left = 1.30315!
        Me.lbl前残.Name = "lbl前残"
        Me.lbl前残.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl前残.Text = "貸方"
        Me.lbl前残.Top = 0.8212599!
        Me.lbl前残.Width = 1.259843!
        '
        'lbl金額
        '
        Me.lbl金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.CharacterSpacing = 15.0!
        Me.lbl金額.Height = 0.3149606!
        Me.lbl金額.HyperLink = Nothing
        Me.lbl金額.Left = 6.299213!
        Me.lbl金額.Name = "lbl金額"
        Me.lbl金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl金額.Text = "金額"
        Me.lbl金額.Top = 0.6653544!
        Me.lbl金額.Width = 1.043307!
        '
        'lbl科目名
        '
        Me.lbl科目名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目名.CharacterSpacing = 15.0!
        Me.lbl科目名.Height = 0.1574803!
        Me.lbl科目名.HyperLink = Nothing
        Me.lbl科目名.Left = 0.0000004768372!
        Me.lbl科目名.Name = "lbl科目名"
        Me.lbl科目名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl科目名.Text = "借方"
        Me.lbl科目名.Top = 0.8212599!
        Me.lbl科目名.Width = 1.299213!
        '
        'Label1
        '
        Me.Label1.Height = 0.1574803!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 6.68819!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-ali" & _
    "gn: middle; ddo-char-set: 1"
        Me.Label1.Text = "(単位：円)"
        Me.Label1.Top = 0.4795276!
        Me.Label1.Width = 0.5905512!
        '
        'lbl伝票日付
        '
        Me.lbl伝票日付.Height = 0.1968504!
        Me.lbl伝票日付.HyperLink = Nothing
        Me.lbl伝票日付.Left = 2.13937!
        Me.lbl伝票日付.Name = "lbl伝票日付"
        Me.lbl伝票日付.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl伝票日付.Text = "伝票日付"
        Me.lbl伝票日付.Top = 0.4!
        Me.lbl伝票日付.Width = 0.7874014!
        '
        'txt伝票日付
        '
        Me.txt伝票日付.Height = 0.1968504!
        Me.txt伝票日付.Left = 2.926772!
        Me.txt伝票日付.Name = "txt伝票日付"
        Me.txt伝票日付.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt伝票日付.Text = "YY/MM/DD 日分"
        Me.txt伝票日付.Top = 0.4!
        Me.txt伝票日付.Width = 2.172835!
        '
        'lbl勘定科目
        '
        Me.lbl勘定科目.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl勘定科目.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl勘定科目.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl勘定科目.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl勘定科目.CharacterSpacing = 10.0!
        Me.lbl勘定科目.Height = 0.1574803!
        Me.lbl勘定科目.HyperLink = Nothing
        Me.lbl勘定科目.Left = 0.0000004768372!
        Me.lbl勘定科目.Name = "lbl勘定科目"
        Me.lbl勘定科目.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl勘定科目.Text = "勘定科目"
        Me.lbl勘定科目.Top = 0.6637796!
        Me.lbl勘定科目.Width = 2.559055!
        '
        'lbl伝票No
        '
        Me.lbl伝票No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Height = 0.3149606!
        Me.lbl伝票No.HyperLink = Nothing
        Me.lbl伝票No.Left = 2.559056!
        Me.lbl伝票No.Name = "lbl伝票No"
        Me.lbl伝票No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl伝票No.Text = "伝票No"
        Me.lbl伝票No.Top = 0.6653544!
        Me.lbl伝票No.Width = 0.8661417!
        '
        'lbl摘要
        '
        Me.lbl摘要.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl摘要.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl摘要.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl摘要.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl摘要.CharacterSpacing = 15.0!
        Me.lbl摘要.Height = 0.3149606!
        Me.lbl摘要.HyperLink = Nothing
        Me.lbl摘要.Left = 3.425197!
        Me.lbl摘要.Name = "lbl摘要"
        Me.lbl摘要.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl摘要.Text = "摘要"
        Me.lbl摘要.Top = 0.6653544!
        Me.lbl摘要.Width = 2.874016!
        '
        'grpFtr計
        '
        Me.grpFtr計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt合計金額, Me.TextBox1, Me.TextBox2, Me.TextBox19, Me.TextBox3})
        Me.grpFtr計.Height = 0.2952756!
        Me.grpFtr計.Name = "grpFtr計"
        '
        'txt合計金額
        '
        Me.txt合計金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計金額.Height = 0.2952756!
        Me.txt合計金額.Left = 6.299212!
        Me.txt合計金額.Name = "txt合計金額"
        Me.txt合計金額.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt合計金額.Text = "999,999"
        Me.txt合計金額.Top = 0.0!
        Me.txt合計金額.Width = 1.043307!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.2952756!
        Me.TextBox1.Left = 3.425197!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 2.874016!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Height = 0.2952756!
        Me.TextBox2.Left = 2.559055!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 0.8661417!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Height = 0.2952756!
        Me.TextBox19.Left = 0.0!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox19.Text = Nothing
        Me.TextBox19.Top = 0.00000005960464!
        Me.TextBox19.Width = 1.299213!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 29.52756!
        Me.TextBox3.Left = 1.299213!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox3.Text = "999,999,999"
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 1.259843!
        '
        'JournalDiary
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.34252!
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
        CType(Me.txt貸方区分名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt摘要, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt借方区分名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt伝票No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt借方区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt貸方区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入出金区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入金明細表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl前残, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl科目名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl伝票日付, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt伝票日付, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl勘定科目, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl伝票No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl摘要, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt貸方区分名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt摘要 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt借方区分名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt伝票No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt入出金区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt入金明細表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl前残 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl科目名 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt合計金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl伝票日付 As DataDynamics.ActiveReports.Label
    Private WithEvents txt伝票日付 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl勘定科目 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl伝票No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl摘要 As DataDynamics.ActiveReports.Label
    Private WithEvents txt借方区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt貸方区分 As DataDynamics.ActiveReports.TextBox
End Class
