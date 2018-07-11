<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class LocalAccountLedger
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(LocalAccountLedger))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt借方金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt摘要 = New DataDynamics.ActiveReports.TextBox()
        Me.txt差引残高 = New DataDynamics.ActiveReports.TextBox()
        Me.txt貸方残高 = New DataDynamics.ActiveReports.TextBox()
        Me.txt伝票No = New DataDynamics.ActiveReports.TextBox()
        Me.txt年月日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt相手科目名 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt入金明細表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl伝票No = New DataDynamics.ActiveReports.Label()
        Me.lbl貸方残高 = New DataDynamics.ActiveReports.Label()
        Me.lbl年月日 = New DataDynamics.ActiveReports.Label()
        Me.lbl相手科目名 = New DataDynamics.ActiveReports.Label()
        Me.lbl借方金額 = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.txt科目名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt科目CD = New DataDynamics.ActiveReports.TextBox()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.lbl摘要 = New DataDynamics.ActiveReports.Label()
        Me.lbl事業年度 = New DataDynamics.ActiveReports.Label()
        Me.txt事業年度 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl計算期間 = New DataDynamics.ActiveReports.Label()
        Me.txt計算期間 = New DataDynamics.ActiveReports.TextBox()
        Me.grpFtr計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.txt計算月借方金額 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.txt月累計借方金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt計算月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt月累計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt計算月貸方残高 = New DataDynamics.ActiveReports.TextBox()
        Me.txt月累計貸方金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt計算月差引残高 = New DataDynamics.ActiveReports.TextBox()
        Me.txt月累計差引残高 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前日繰越借方金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前日繰越貸方残高 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前日繰越差引残高 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl前日より繰越 = New DataDynamics.ActiveReports.Label()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.GroupHeader2 = New DataDynamics.ActiveReports.GroupHeader()
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前葉繰越借方金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前葉繰越貸方残高 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前葉繰越差引残高 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox26 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl前葉より繰越 = New DataDynamics.ActiveReports.Label()
        Me.GroupFooter2 = New DataDynamics.ActiveReports.GroupFooter()
        CType(Me.txt借方金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt摘要, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt差引残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt貸方残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt伝票No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt年月日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt相手科目名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入金明細表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl伝票No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl貸方残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl年月日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl相手科目名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl借方金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt科目名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt科目CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl摘要, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl事業年度, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt事業年度, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl計算期間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt計算期間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt計算月借方金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt月累計借方金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt計算月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt月累計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt計算月貸方残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt月累計貸方金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt計算月差引残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt月累計差引残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前日繰越借方金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前日繰越貸方残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前日繰越差引残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl前日より繰越, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前葉繰越借方金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前葉繰越貸方残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前葉繰越差引残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl前葉より繰越, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt借方金額, Me.txt摘要, Me.txt差引残高, Me.txt貸方残高, Me.txt伝票No, Me.txt年月日, Me.txt相手科目名})
        Me.Detail.Height = 0.3346457!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt借方金額
        '
        Me.txt借方金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt借方金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt借方金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt借方金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt借方金額.Height = 0.3346457!
        Me.txt借方金額.Left = 2.952756!
        Me.txt借方金額.Name = "txt借方金額"
        Me.txt借方金額.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt借方金額.Text = "999,999,999"
        Me.txt借方金額.Top = 0.0!
        Me.txt借方金額.Width = 1.338583!
        '
        'txt摘要
        '
        Me.txt摘要.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Height = 0.3346457!
        Me.txt摘要.Left = 7.086615!
        Me.txt摘要.Name = "txt摘要"
        Me.txt摘要.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txt摘要.Text = "あああああいいいいいうううううえええええおおおおおかかかかかきききききくくくくく"
        Me.txt摘要.Top = 0.0!
        Me.txt摘要.Width = 3.464567!
        '
        'txt差引残高
        '
        Me.txt差引残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt差引残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt差引残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt差引残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt差引残高.Height = 0.3346457!
        Me.txt差引残高.Left = 5.708662!
        Me.txt差引残高.Name = "txt差引残高"
        Me.txt差引残高.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt差引残高.Text = "999,999,999"
        Me.txt差引残高.Top = 0.0!
        Me.txt差引残高.Width = 1.377953!
        '
        'txt貸方残高
        '
        Me.txt貸方残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方残高.Height = 0.3346457!
        Me.txt貸方残高.Left = 4.291339!
        Me.txt貸方残高.Name = "txt貸方残高"
        Me.txt貸方残高.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt貸方残高.Text = "999,999,999"
        Me.txt貸方残高.Top = 0.0!
        Me.txt貸方残高.Width = 1.417323!
        '
        'txt伝票No
        '
        Me.txt伝票No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Height = 0.3346457!
        Me.txt伝票No.Left = 0.7874016!
        Me.txt伝票No.Name = "txt伝票No"
        Me.txt伝票No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt伝票No.Text = "123456"
        Me.txt伝票No.Top = 0.0!
        Me.txt伝票No.Width = 1.062992!
        '
        'txt年月日
        '
        Me.txt年月日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt年月日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt年月日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt年月日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt年月日.Height = 0.3346457!
        Me.txt年月日.Left = 0.0!
        Me.txt年月日.Name = "txt年月日"
        Me.txt年月日.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt年月日.Text = "YY/MM/DD"
        Me.txt年月日.Top = 0.0!
        Me.txt年月日.Width = 0.7874016!
        '
        'txt相手科目名
        '
        Me.txt相手科目名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相手科目名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相手科目名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相手科目名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相手科目名.Height = 0.3346457!
        Me.txt相手科目名.Left = 1.850394!
        Me.txt相手科目名.Name = "txt相手科目名"
        Me.txt相手科目名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt相手科目名.Text = "あああああああ"
        Me.txt相手科目名.Top = 0.0!
        Me.txt相手科目名.Width = 1.102362!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNow, Me.txt頁})
        Me.PageHeader.Height = 0.2362205!
        Me.PageHeader.Name = "PageHeader"
        '
        'txtNow
        '
        Me.txtNow.Height = 0.2362205!
        Me.txtNow.Left = 7.861418!
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
        Me.txt頁.Left = 10.13393!
        Me.txt頁.Name = "txt頁"
        Me.txt頁.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt頁.Text = "頁"
        Me.txt頁.Top = 0.0!
        Me.txt頁.Width = 0.3795286!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdr
        '
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt入金明細表, Me.lbl伝票No, Me.lbl貸方残高, Me.lbl年月日, Me.lbl相手科目名, Me.lbl借方金額, Me.Label2, Me.txt科目名, Me.txt科目CD, Me.Label3, Me.lbl摘要, Me.lbl事業年度, Me.txt事業年度, Me.lbl計算期間, Me.txt計算期間})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 1.10315!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txt入金明細表
        '
        Me.txt入金明細表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt入金明細表.CharacterSpacing = 30.0!
        Me.txt入金明細表.Height = 0.2362205!
        Me.txt入金明細表.Left = 3.111811!
        Me.txt入金明細表.Name = "txt入金明細表"
        Me.txt入金明細表.Style = "font-family: ＭＳ Ｐゴシック; font-size: 14pt; font-weight: bold; text-align: center; ve" & _
    "rtical-align: bottom; ddo-char-set: 1"
        Me.txt入金明細表.Text = "総勘定元帳"
        Me.txt入金明細表.Top = 0.0!
        Me.txt入金明細表.Width = 3.444882!
        '
        'lbl伝票No
        '
        Me.lbl伝票No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Height = 0.3149606!
        Me.lbl伝票No.HyperLink = Nothing
        Me.lbl伝票No.Left = 0.7874016!
        Me.lbl伝票No.Name = "lbl伝票No"
        Me.lbl伝票No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl伝票No.Text = "伝票No"
        Me.lbl伝票No.Top = 0.7881891!
        Me.lbl伝票No.Width = 1.062992!
        '
        'lbl貸方残高
        '
        Me.lbl貸方残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl貸方残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl貸方残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl貸方残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl貸方残高.CharacterSpacing = 10.0!
        Me.lbl貸方残高.Height = 0.3149606!
        Me.lbl貸方残高.HyperLink = Nothing
        Me.lbl貸方残高.Left = 4.291339!
        Me.lbl貸方残高.Name = "lbl貸方残高"
        Me.lbl貸方残高.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl貸方残高.Text = "貸方残高"
        Me.lbl貸方残高.Top = 0.7881891!
        Me.lbl貸方残高.Width = 1.417323!
        '
        'lbl年月日
        '
        Me.lbl年月日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl年月日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl年月日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl年月日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl年月日.Height = 0.3149606!
        Me.lbl年月日.HyperLink = Nothing
        Me.lbl年月日.Left = 0.0!
        Me.lbl年月日.Name = "lbl年月日"
        Me.lbl年月日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl年月日.Text = "年月日"
        Me.lbl年月日.Top = 0.7881891!
        Me.lbl年月日.Width = 0.7874016!
        '
        'lbl相手科目名
        '
        Me.lbl相手科目名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl相手科目名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl相手科目名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl相手科目名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl相手科目名.Height = 0.3149606!
        Me.lbl相手科目名.HyperLink = Nothing
        Me.lbl相手科目名.Left = 1.850394!
        Me.lbl相手科目名.Name = "lbl相手科目名"
        Me.lbl相手科目名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl相手科目名.Text = "相手科目名"
        Me.lbl相手科目名.Top = 0.7881891!
        Me.lbl相手科目名.Width = 1.102362!
        '
        'lbl借方金額
        '
        Me.lbl借方金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl借方金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl借方金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl借方金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl借方金額.CharacterSpacing = 10.0!
        Me.lbl借方金額.Height = 0.3149606!
        Me.lbl借方金額.HyperLink = Nothing
        Me.lbl借方金額.Left = 2.952756!
        Me.lbl借方金額.Name = "lbl借方金額"
        Me.lbl借方金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl借方金額.Text = "借方金額"
        Me.lbl借方金額.Top = 0.7881891!
        Me.lbl借方金額.Width = 1.338583!
        '
        'Label2
        '
        Me.Label2.Height = 0.1968504!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.0!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label2.Text = "科目コード"
        Me.Label2.Top = 0.0!
        Me.Label2.Width = 0.8303149!
        '
        'txt科目名
        '
        Me.txt科目名.Height = 0.1968504!
        Me.txt科目名.Left = 1.224016!
        Me.txt科目名.Name = "txt科目名"
        Me.txt科目名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt科目名.Text = "あああああ"
        Me.txt科目名.Top = 0.0!
        Me.txt科目名.Width = 0.9228346!
        '
        'txt科目CD
        '
        Me.txt科目CD.Height = 0.1968504!
        Me.txt科目CD.Left = 0.8303149!
        Me.txt科目CD.Name = "txt科目CD"
        Me.txt科目CD.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt科目CD.Text = "123"
        Me.txt科目CD.Top = 0.0!
        Me.txt科目CD.Width = 0.3937008!
        '
        'Label3
        '
        Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.CharacterSpacing = 10.0!
        Me.Label3.Height = 0.3149606!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 5.708662!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label3.Text = "差引残高"
        Me.Label3.Top = 0.7881891!
        Me.Label3.Width = 1.377953!
        '
        'lbl摘要
        '
        Me.lbl摘要.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl摘要.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl摘要.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl摘要.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl摘要.CharacterSpacing = 10.0!
        Me.lbl摘要.Height = 0.3149606!
        Me.lbl摘要.HyperLink = Nothing
        Me.lbl摘要.Left = 7.086615!
        Me.lbl摘要.Name = "lbl摘要"
        Me.lbl摘要.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl摘要.Text = "摘要"
        Me.lbl摘要.Top = 0.7881891!
        Me.lbl摘要.Width = 3.464567!
        '
        'lbl事業年度
        '
        Me.lbl事業年度.Height = 0.1968504!
        Me.lbl事業年度.HyperLink = Nothing
        Me.lbl事業年度.Left = 2.937795!
        Me.lbl事業年度.Name = "lbl事業年度"
        Me.lbl事業年度.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl事業年度.Text = "事業年度"
        Me.lbl事業年度.Top = 0.3669292!
        Me.lbl事業年度.Width = 0.8661417!
        '
        'txt事業年度
        '
        Me.txt事業年度.CharacterSpacing = 3.0!
        Me.txt事業年度.Height = 0.1968504!
        Me.txt事業年度.Left = 3.803937!
        Me.txt事業年度.Name = "txt事業年度"
        Me.txt事業年度.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt事業年度.Text = "00年00月00日～99年99月99日"
        Me.txt事業年度.Top = 0.3669292!
        Me.txt事業年度.Width = 2.752756!
        '
        'lbl計算期間
        '
        Me.lbl計算期間.Height = 0.1968504!
        Me.lbl計算期間.HyperLink = Nothing
        Me.lbl計算期間.Left = 2.937795!
        Me.lbl計算期間.Name = "lbl計算期間"
        Me.lbl計算期間.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl計算期間.Text = "計算期間"
        Me.lbl計算期間.Top = 0.5637796!
        Me.lbl計算期間.Width = 0.8661417!
        '
        'txt計算期間
        '
        Me.txt計算期間.CharacterSpacing = 3.0!
        Me.txt計算期間.Height = 0.1968504!
        Me.txt計算期間.Left = 3.803937!
        Me.txt計算期間.Name = "txt計算期間"
        Me.txt計算期間.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt計算期間.Text = "00年00月00日～99年99月99日"
        Me.txt計算期間.Top = 0.5637796!
        Me.txt計算期間.Width = 2.752756!
        '
        'grpFtr計
        '
        Me.grpFtr計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.txt計算月借方金額, Me.TextBox19, Me.TextBox3, Me.txt月累計借方金額, Me.txt計算月, Me.txt月累計, Me.txt計算月貸方残高, Me.txt月累計貸方金額, Me.txt計算月差引残高, Me.txt月累計差引残高})
        Me.grpFtr計.Height = 0.7692914!
        Me.grpFtr計.Name = "grpFtr計"
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.3346457!
        Me.TextBox1.Left = 7.086615!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 3.464567!
        '
        'txt計算月借方金額
        '
        Me.txt計算月借方金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月借方金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月借方金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月借方金額.Height = 0.1673228!
        Me.txt計算月借方金額.Left = 2.952756!
        Me.txt計算月借方金額.Name = "txt計算月借方金額"
        Me.txt計算月借方金額.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt計算月借方金額.Text = Nothing
        Me.txt計算月借方金額.Top = 0.0!
        Me.txt計算月借方金額.Width = 1.338583!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Height = 0.3346457!
        Me.TextBox19.Left = 0.0!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox19.Text = Nothing
        Me.TextBox19.Top = 0.00000005960464!
        Me.TextBox19.Width = 0.7874016!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.3346457!
        Me.TextBox3.Left = 0.7874016!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 1.062992!
        '
        'txt月累計借方金額
        '
        Me.txt月累計借方金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月累計借方金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月累計借方金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月累計借方金額.Height = 0.1673228!
        Me.txt月累計借方金額.Left = 2.952756!
        Me.txt月累計借方金額.Name = "txt月累計借方金額"
        Me.txt月累計借方金額.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt月累計借方金額.Text = Nothing
        Me.txt月累計借方金額.Top = 0.1673228!
        Me.txt月累計借方金額.Width = 1.338583!
        '
        'txt計算月
        '
        Me.txt計算月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月.Height = 0.1673228!
        Me.txt計算月.Left = 1.850394!
        Me.txt計算月.Name = "txt計算月"
        Me.txt計算月.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt計算月.Text = "月計"
        Me.txt計算月.Top = 0.0!
        Me.txt計算月.Width = 1.102362!
        '
        'txt月累計
        '
        Me.txt月累計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月累計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月累計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月累計.Height = 0.1673228!
        Me.txt月累計.Left = 1.850394!
        Me.txt月累計.Name = "txt月累計"
        Me.txt月累計.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt月累計.Text = "累計"
        Me.txt月累計.Top = 0.167323!
        Me.txt月累計.Width = 1.102362!
        '
        'txt計算月貸方残高
        '
        Me.txt計算月貸方残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月貸方残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月貸方残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月貸方残高.Height = 0.1673228!
        Me.txt計算月貸方残高.Left = 4.291339!
        Me.txt計算月貸方残高.Name = "txt計算月貸方残高"
        Me.txt計算月貸方残高.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt計算月貸方残高.Text = Nothing
        Me.txt計算月貸方残高.Top = 0.0!
        Me.txt計算月貸方残高.Width = 1.417323!
        '
        'txt月累計貸方金額
        '
        Me.txt月累計貸方金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月累計貸方金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月累計貸方金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月累計貸方金額.Height = 0.1673228!
        Me.txt月累計貸方金額.Left = 4.291338!
        Me.txt月累計貸方金額.Name = "txt月累計貸方金額"
        Me.txt月累計貸方金額.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt月累計貸方金額.Text = Nothing
        Me.txt月累計貸方金額.Top = 0.1673229!
        Me.txt月累計貸方金額.Width = 1.417323!
        '
        'txt計算月差引残高
        '
        Me.txt計算月差引残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月差引残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月差引残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月差引残高.Height = 0.1673228!
        Me.txt計算月差引残高.Left = 5.708662!
        Me.txt計算月差引残高.Name = "txt計算月差引残高"
        Me.txt計算月差引残高.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt計算月差引残高.Text = Nothing
        Me.txt計算月差引残高.Top = 0.0!
        Me.txt計算月差引残高.Width = 1.377953!
        '
        'txt月累計差引残高
        '
        Me.txt月累計差引残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月累計差引残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月累計差引残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月累計差引残高.Height = 0.1673228!
        Me.txt月累計差引残高.Left = 5.708661!
        Me.txt月累計差引残高.Name = "txt月累計差引残高"
        Me.txt月累計差引残高.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt月累計差引残高.Text = Nothing
        Me.txt月累計差引残高.Top = 0.1673229!
        Me.txt月累計差引残高.Width = 1.377953!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox12, Me.TextBox13, Me.txt前日繰越借方金額, Me.txt前日繰越貸方残高, Me.txt前日繰越差引残高, Me.TextBox18, Me.lbl前日より繰越})
        Me.GroupHeader1.Height = 0.3346457!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Height = 0.3346457!
        Me.TextBox12.Left = 0.0!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox12.Text = Nothing
        Me.TextBox12.Top = 0.0!
        Me.TextBox12.Width = 0.7874014!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Height = 0.3346457!
        Me.TextBox13.Left = 0.7874014!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox13.Text = Nothing
        Me.TextBox13.Top = 0.0!
        Me.TextBox13.Width = 1.062992!
        '
        'txt前日繰越借方金額
        '
        Me.txt前日繰越借方金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前日繰越借方金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前日繰越借方金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前日繰越借方金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前日繰越借方金額.Height = 0.3346457!
        Me.txt前日繰越借方金額.Left = 2.952756!
        Me.txt前日繰越借方金額.Name = "txt前日繰越借方金額"
        Me.txt前日繰越借方金額.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt前日繰越借方金額.Text = "999,999,999"
        Me.txt前日繰越借方金額.Top = 0.0!
        Me.txt前日繰越借方金額.Width = 1.338583!
        '
        'txt前日繰越貸方残高
        '
        Me.txt前日繰越貸方残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前日繰越貸方残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前日繰越貸方残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前日繰越貸方残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前日繰越貸方残高.Height = 0.3346457!
        Me.txt前日繰越貸方残高.Left = 4.291338!
        Me.txt前日繰越貸方残高.Name = "txt前日繰越貸方残高"
        Me.txt前日繰越貸方残高.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt前日繰越貸方残高.Text = "999,999,999"
        Me.txt前日繰越貸方残高.Top = 0.0!
        Me.txt前日繰越貸方残高.Width = 1.417323!
        '
        'txt前日繰越差引残高
        '
        Me.txt前日繰越差引残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前日繰越差引残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前日繰越差引残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前日繰越差引残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前日繰越差引残高.Height = 0.3346457!
        Me.txt前日繰越差引残高.Left = 5.708661!
        Me.txt前日繰越差引残高.Name = "txt前日繰越差引残高"
        Me.txt前日繰越差引残高.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt前日繰越差引残高.Text = "999,999,999"
        Me.txt前日繰越差引残高.Top = 0.0!
        Me.txt前日繰越差引残高.Width = 1.377953!
        '
        'TextBox18
        '
        Me.TextBox18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Height = 0.3346457!
        Me.TextBox18.Left = 7.086614!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.TextBox18.Text = Nothing
        Me.TextBox18.Top = 0.0!
        Me.TextBox18.Width = 3.464567!
        '
        'lbl前日より繰越
        '
        Me.lbl前日より繰越.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前日より繰越.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前日より繰越.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前日より繰越.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前日より繰越.Height = 0.3346457!
        Me.lbl前日より繰越.HyperLink = Nothing
        Me.lbl前日より繰越.Left = 1.850394!
        Me.lbl前日より繰越.Name = "lbl前日より繰越"
        Me.lbl前日より繰越.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl前日より繰越.Text = "前日より繰越"
        Me.lbl前日より繰越.Top = 0.0!
        Me.lbl前日より繰越.Width = 1.102362!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox20, Me.TextBox21, Me.txt前葉繰越借方金額, Me.txt前葉繰越貸方残高, Me.txt前葉繰越差引残高, Me.TextBox26, Me.lbl前葉より繰越})
        Me.GroupHeader2.Height = 0.3346457!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'TextBox20
        '
        Me.TextBox20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Height = 0.3346457!
        Me.TextBox20.Left = 0.0!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox20.Text = Nothing
        Me.TextBox20.Top = 0.0!
        Me.TextBox20.Width = 0.7874014!
        '
        'TextBox21
        '
        Me.TextBox21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Height = 0.3346457!
        Me.TextBox21.Left = 0.7874014!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox21.Text = Nothing
        Me.TextBox21.Top = 0.0!
        Me.TextBox21.Width = 1.062992!
        '
        'txt前葉繰越借方金額
        '
        Me.txt前葉繰越借方金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前葉繰越借方金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前葉繰越借方金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前葉繰越借方金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前葉繰越借方金額.Height = 0.3346457!
        Me.txt前葉繰越借方金額.Left = 2.952756!
        Me.txt前葉繰越借方金額.Name = "txt前葉繰越借方金額"
        Me.txt前葉繰越借方金額.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt前葉繰越借方金額.Text = "999,999,999"
        Me.txt前葉繰越借方金額.Top = 0.0!
        Me.txt前葉繰越借方金額.Width = 1.338583!
        '
        'txt前葉繰越貸方残高
        '
        Me.txt前葉繰越貸方残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前葉繰越貸方残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前葉繰越貸方残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前葉繰越貸方残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前葉繰越貸方残高.Height = 0.3346457!
        Me.txt前葉繰越貸方残高.Left = 4.291338!
        Me.txt前葉繰越貸方残高.Name = "txt前葉繰越貸方残高"
        Me.txt前葉繰越貸方残高.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt前葉繰越貸方残高.Text = "999,999,999"
        Me.txt前葉繰越貸方残高.Top = 0.0!
        Me.txt前葉繰越貸方残高.Width = 1.417323!
        '
        'txt前葉繰越差引残高
        '
        Me.txt前葉繰越差引残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前葉繰越差引残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前葉繰越差引残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前葉繰越差引残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前葉繰越差引残高.Height = 0.3346457!
        Me.txt前葉繰越差引残高.Left = 5.708661!
        Me.txt前葉繰越差引残高.Name = "txt前葉繰越差引残高"
        Me.txt前葉繰越差引残高.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt前葉繰越差引残高.Text = "999,999,999"
        Me.txt前葉繰越差引残高.Top = 0.0!
        Me.txt前葉繰越差引残高.Width = 1.377953!
        '
        'TextBox26
        '
        Me.TextBox26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.Height = 0.3346457!
        Me.TextBox26.Left = 7.086614!
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.TextBox26.Text = Nothing
        Me.TextBox26.Top = 0.0!
        Me.TextBox26.Width = 3.464567!
        '
        'lbl前葉より繰越
        '
        Me.lbl前葉より繰越.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前葉より繰越.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前葉より繰越.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前葉より繰越.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前葉より繰越.Height = 0.3346457!
        Me.lbl前葉より繰越.HyperLink = Nothing
        Me.lbl前葉より繰越.Left = 1.850394!
        Me.lbl前葉より繰越.Name = "lbl前葉より繰越"
        Me.lbl前葉より繰越.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl前葉より繰越.Text = "前葉より繰越"
        Me.lbl前葉より繰越.Top = 0.0!
        Me.lbl前葉より繰越.Width = 1.102362!
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Height = 0.0!
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'LocalAccountLedger
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.59055!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.GroupHeader2)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter2)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.grpFtr計)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt借方金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt摘要, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt差引残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt貸方残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt伝票No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt年月日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt相手科目名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入金明細表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl伝票No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl貸方残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl年月日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl相手科目名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl借方金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt科目名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt科目CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl摘要, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl事業年度, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt事業年度, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl計算期間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt計算期間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt計算月借方金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt月累計借方金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt計算月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt月累計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt計算月貸方残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt月累計貸方金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt計算月差引残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt月累計差引残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前日繰越借方金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前日繰越貸方残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前日繰越差引残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl前日より繰越, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前葉繰越借方金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前葉繰越貸方残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前葉繰越差引残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl前葉より繰越, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt借方金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt摘要 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt差引残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt貸方残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt伝票No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt入金明細表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl伝票No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl貸方残高 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl年月日 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt計算月借方金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl相手科目名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl借方金額 As DataDynamics.ActiveReports.Label
    Private WithEvents txt年月日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt相手科目名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents txt科目名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt科目CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents GroupHeader2 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents GroupFooter2 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt月累計借方金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl摘要 As DataDynamics.ActiveReports.Label
    Private WithEvents txt計算月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt月累計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt計算月貸方残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt月累計貸方金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt計算月差引残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt月累計差引残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl事業年度 As DataDynamics.ActiveReports.Label
    Private WithEvents txt事業年度 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl計算期間 As DataDynamics.ActiveReports.Label
    Private WithEvents txt計算期間 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前日繰越借方金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前日繰越貸方残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前日繰越差引残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl前日より繰越 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前葉繰越借方金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前葉繰越貸方残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前葉繰越差引残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox26 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl前葉より繰越 As DataDynamics.ActiveReports.Label
End Class
