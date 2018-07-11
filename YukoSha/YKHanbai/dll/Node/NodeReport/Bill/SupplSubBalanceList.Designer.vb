<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class SupplSubBalanceList
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SupplSubBalanceList))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt補助科目名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt摘要 = New DataDynamics.ActiveReports.TextBox()
        Me.txt差引残高 = New DataDynamics.ActiveReports.TextBox()
        Me.txt貸方残高 = New DataDynamics.ActiveReports.TextBox()
        Me.txt伝票No = New DataDynamics.ActiveReports.TextBox()
        Me.txt科目CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt相手科目名 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt入金明細表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl科目名 = New DataDynamics.ActiveReports.Label()
        Me.lbl貸方 = New DataDynamics.ActiveReports.Label()
        Me.lbl科目CD = New DataDynamics.ActiveReports.Label()
        Me.lbl補助科目CD = New DataDynamics.ActiveReports.Label()
        Me.lbl補助科目名 = New DataDynamics.ActiveReports.Label()
        Me.lbl残高 = New DataDynamics.ActiveReports.Label()
        Me.lbl前残 = New DataDynamics.ActiveReports.Label()
        Me.lbl事業年度 = New DataDynamics.ActiveReports.Label()
        Me.txt事業年度 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl計算期間 = New DataDynamics.ActiveReports.Label()
        Me.txt計算期間 = New DataDynamics.ActiveReports.TextBox()
        Me.grpFtr科目計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt計算月借方金額 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.txt計算月貸方残高 = New DataDynamics.ActiveReports.TextBox()
        Me.txt月累計貸方金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt計算月差引残高 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl科目計 = New DataDynamics.ActiveReports.Label()
        Me.lbl借方 = New DataDynamics.ActiveReports.Label()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        CType(Me.txt補助科目名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt摘要, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt差引残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt貸方残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt伝票No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt科目CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt相手科目名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入金明細表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl科目名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl貸方, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl科目CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl補助科目CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl補助科目名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl前残, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl事業年度, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt事業年度, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl計算期間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt計算期間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt計算月借方金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt計算月貸方残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt月累計貸方金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt計算月差引残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl科目計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl借方, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt補助科目名, Me.txt摘要, Me.txt差引残高, Me.txt貸方残高, Me.txt伝票No, Me.txt科目CD, Me.txt相手科目名, Me.TextBox4})
        Me.Detail.Height = 0.1771654!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt補助科目名
        '
        Me.txt補助科目名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt補助科目名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt補助科目名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt補助科目名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt補助科目名.Height = 0.1771654!
        Me.txt補助科目名.Left = 1.594488!
        Me.txt補助科目名.Name = "txt補助科目名"
        Me.txt補助科目名.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt補助科目名.Text = "あああああいい"
        Me.txt補助科目名.Top = 0.0!
        Me.txt補助科目名.Width = 0.9448819!
        '
        'txt摘要
        '
        Me.txt摘要.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Height = 0.1771654!
        Me.txt摘要.Left = 4.940945!
        Me.txt摘要.Name = "txt摘要"
        Me.txt摘要.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt摘要.Text = "999,999,999"
        Me.txt摘要.Top = 0.0!
        Me.txt摘要.Width = 1.200787!
        '
        'txt差引残高
        '
        Me.txt差引残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt差引残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt差引残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt差引残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt差引残高.Height = 0.1771654!
        Me.txt差引残高.Left = 3.740158!
        Me.txt差引残高.Name = "txt差引残高"
        Me.txt差引残高.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt差引残高.Text = "999,999,999"
        Me.txt差引残高.Top = 0.0!
        Me.txt差引残高.Width = 1.200787!
        '
        'txt貸方残高
        '
        Me.txt貸方残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方残高.Height = 0.1771654!
        Me.txt貸方残高.Left = 2.53937!
        Me.txt貸方残高.Name = "txt貸方残高"
        Me.txt貸方残高.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt貸方残高.Text = "999,999,999"
        Me.txt貸方残高.Top = 0.0!
        Me.txt貸方残高.Width = 1.200787!
        '
        'txt伝票No
        '
        Me.txt伝票No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Height = 0.1771654!
        Me.txt伝票No.Left = 0.3346457!
        Me.txt伝票No.Name = "txt伝票No"
        Me.txt伝票No.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt伝票No.Text = "あああああいい"
        Me.txt伝票No.Top = 0.0!
        Me.txt伝票No.Width = 0.9448819!
        '
        'txt科目CD
        '
        Me.txt科目CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt科目CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt科目CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt科目CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt科目CD.Height = 0.1771654!
        Me.txt科目CD.Left = 0.0!
        Me.txt科目CD.Name = "txt科目CD"
        Me.txt科目CD.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt科目CD.Text = "123"
        Me.txt科目CD.Top = 0.0!
        Me.txt科目CD.Width = 0.3346457!
        '
        'txt相手科目名
        '
        Me.txt相手科目名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相手科目名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相手科目名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相手科目名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt相手科目名.Height = 0.1771654!
        Me.txt相手科目名.Left = 1.279528!
        Me.txt相手科目名.Name = "txt相手科目名"
        Me.txt相手科目名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt相手科目名.Text = "123"
        Me.txt相手科目名.Top = 0.0!
        Me.txt相手科目名.Width = 0.3149606!
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
        Me.txtNow.Left = 4.544882!
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
        Me.txt頁.Left = 6.817322!
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
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt入金明細表, Me.lbl科目名, Me.lbl貸方, Me.lbl科目CD, Me.lbl補助科目CD, Me.lbl補助科目名, Me.lbl残高, Me.lbl前残, Me.lbl事業年度, Me.txt事業年度, Me.lbl計算期間, Me.txt計算期間, Me.lbl借方, Me.Label1})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 1.065354!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txt入金明細表
        '
        Me.txt入金明細表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt入金明細表.Height = 0.2362205!
        Me.txt入金明細表.Left = 2.22126!
        Me.txt入金明細表.Name = "txt入金明細表"
        Me.txt入金明細表.Style = "font-family: ＭＳ Ｐゴシック; font-size: 14pt; font-weight: bold; text-align: center; ve" & _
    "rtical-align: bottom; ddo-char-set: 1"
        Me.txt入金明細表.Text = "補助科目残高一覧表"
        Me.txt入金明細表.Top = 0.0!
        Me.txt入金明細表.Width = 2.401575!
        '
        'lbl科目名
        '
        Me.lbl科目名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目名.Height = 0.2362205!
        Me.lbl科目名.HyperLink = Nothing
        Me.lbl科目名.Left = 0.3346457!
        Me.lbl科目名.Name = "lbl科目名"
        Me.lbl科目名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl科目名.Text = "科目名"
        Me.lbl科目名.Top = 0.829134!
        Me.lbl科目名.Width = 0.9448819!
        '
        'lbl貸方
        '
        Me.lbl貸方.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl貸方.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl貸方.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl貸方.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl貸方.CharacterSpacing = 10.0!
        Me.lbl貸方.Height = 0.2362205!
        Me.lbl貸方.HyperLink = Nothing
        Me.lbl貸方.Left = 4.940945!
        Me.lbl貸方.Name = "lbl貸方"
        Me.lbl貸方.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl貸方.Text = "貸方"
        Me.lbl貸方.Top = 0.8291339!
        Me.lbl貸方.Width = 1.200787!
        '
        'lbl科目CD
        '
        Me.lbl科目CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目CD.Height = 0.2362205!
        Me.lbl科目CD.HyperLink = Nothing
        Me.lbl科目CD.Left = 0.0!
        Me.lbl科目CD.Name = "lbl科目CD"
        Me.lbl科目CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl科目CD.Text = "ｺｰﾄﾞ"
        Me.lbl科目CD.Top = 0.829134!
        Me.lbl科目CD.Width = 0.3346457!
        '
        'lbl補助科目CD
        '
        Me.lbl補助科目CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl補助科目CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl補助科目CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl補助科目CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl補助科目CD.Height = 0.2362205!
        Me.lbl補助科目CD.HyperLink = Nothing
        Me.lbl補助科目CD.Left = 1.279528!
        Me.lbl補助科目CD.Name = "lbl補助科目CD"
        Me.lbl補助科目CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl補助科目CD.Text = "ｺｰﾄﾞ"
        Me.lbl補助科目CD.Top = 0.829134!
        Me.lbl補助科目CD.Width = 0.3149606!
        '
        'lbl補助科目名
        '
        Me.lbl補助科目名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl補助科目名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl補助科目名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl補助科目名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl補助科目名.Height = 0.2362205!
        Me.lbl補助科目名.HyperLink = Nothing
        Me.lbl補助科目名.Left = 1.594488!
        Me.lbl補助科目名.Name = "lbl補助科目名"
        Me.lbl補助科目名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl補助科目名.Text = "補助科目名"
        Me.lbl補助科目名.Top = 0.8291339!
        Me.lbl補助科目名.Width = 0.9448819!
        '
        'lbl残高
        '
        Me.lbl残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl残高.CharacterSpacing = 10.0!
        Me.lbl残高.Height = 0.2362205!
        Me.lbl残高.HyperLink = Nothing
        Me.lbl残高.Left = 6.141733!
        Me.lbl残高.Name = "lbl残高"
        Me.lbl残高.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl残高.Text = "残高"
        Me.lbl残高.Top = 0.8291339!
        Me.lbl残高.Width = 1.200787!
        '
        'lbl前残
        '
        Me.lbl前残.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前残.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前残.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前残.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前残.CharacterSpacing = 10.0!
        Me.lbl前残.Height = 0.2362205!
        Me.lbl前残.HyperLink = Nothing
        Me.lbl前残.Left = 2.53937!
        Me.lbl前残.Name = "lbl前残"
        Me.lbl前残.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl前残.Text = "前残"
        Me.lbl前残.Top = 0.8291339!
        Me.lbl前残.Width = 1.200787!
        '
        'lbl事業年度
        '
        Me.lbl事業年度.Height = 0.1968504!
        Me.lbl事業年度.HyperLink = Nothing
        Me.lbl事業年度.Left = 2.006299!
        Me.lbl事業年度.Name = "lbl事業年度"
        Me.lbl事業年度.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: justify; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl事業年度.Text = " 事業年度"
        Me.lbl事業年度.Top = 0.3669292!
        Me.lbl事業年度.Width = 0.8661417!
        '
        'txt事業年度
        '
        Me.txt事業年度.CharacterSpacing = 2.0!
        Me.txt事業年度.Height = 0.1968504!
        Me.txt事業年度.Left = 2.872441!
        Me.txt事業年度.Name = "txt事業年度"
        Me.txt事業年度.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt事業年度.Text = "00年00月00日～99年99月99日迄"
        Me.txt事業年度.Top = 0.3669292!
        Me.txt事業年度.Width = 2.755906!
        '
        'lbl計算期間
        '
        Me.lbl計算期間.Height = 0.1968504!
        Me.lbl計算期間.HyperLink = Nothing
        Me.lbl計算期間.Left = 2.006299!
        Me.lbl計算期間.Name = "lbl計算期間"
        Me.lbl計算期間.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: justify; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl計算期間.Text = " 計算期間"
        Me.lbl計算期間.Top = 0.5637796!
        Me.lbl計算期間.Width = 0.8661417!
        '
        'txt計算期間
        '
        Me.txt計算期間.CharacterSpacing = 2.0!
        Me.txt計算期間.Height = 0.1968504!
        Me.txt計算期間.Left = 2.872441!
        Me.txt計算期間.Name = "txt計算期間"
        Me.txt計算期間.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt計算期間.Text = "00年00月00日～99年99月99日迄"
        Me.txt計算期間.Top = 0.5637796!
        Me.txt計算期間.Width = 2.755906!
        '
        'grpFtr科目計
        '
        Me.grpFtr科目計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt計算月借方金額, Me.TextBox19, Me.TextBox3, Me.TextBox2, Me.txt計算月貸方残高, Me.txt月累計貸方金額, Me.txt計算月差引残高, Me.lbl科目計})
        Me.grpFtr科目計.Height = 0.1771654!
        Me.grpFtr科目計.Name = "grpFtr科目計"
        '
        'txt計算月借方金額
        '
        Me.txt計算月借方金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月借方金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月借方金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月借方金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月借方金額.Height = 0.1771654!
        Me.txt計算月借方金額.Left = 2.53937!
        Me.txt計算月借方金額.Name = "txt計算月借方金額"
        Me.txt計算月借方金額.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt計算月借方金額.Text = "999,999,999"
        Me.txt計算月借方金額.Top = 0.0!
        Me.txt計算月借方金額.Width = 1.200787!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Height = 0.1771654!
        Me.TextBox19.Left = 0.0!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox19.Text = Nothing
        Me.TextBox19.Top = 0.0!
        Me.TextBox19.Width = 0.3346457!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.1771654!
        Me.TextBox3.Left = 0.3346457!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.9448819!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Height = 0.1771654!
        Me.TextBox2.Left = 1.279528!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 0.3149606!
        '
        'txt計算月貸方残高
        '
        Me.txt計算月貸方残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月貸方残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月貸方残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月貸方残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月貸方残高.Height = 0.1771654!
        Me.txt計算月貸方残高.Left = 4.940945!
        Me.txt計算月貸方残高.Name = "txt計算月貸方残高"
        Me.txt計算月貸方残高.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt計算月貸方残高.Text = "999,999,999"
        Me.txt計算月貸方残高.Top = 0.0!
        Me.txt計算月貸方残高.Width = 1.200787!
        '
        'txt月累計貸方金額
        '
        Me.txt月累計貸方金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月累計貸方金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月累計貸方金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月累計貸方金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月累計貸方金額.Height = 0.1771654!
        Me.txt月累計貸方金額.Left = 3.740158!
        Me.txt月累計貸方金額.Name = "txt月累計貸方金額"
        Me.txt月累計貸方金額.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt月累計貸方金額.Text = "999,999,999"
        Me.txt月累計貸方金額.Top = 0.0!
        Me.txt月累計貸方金額.Width = 1.200787!
        '
        'txt計算月差引残高
        '
        Me.txt計算月差引残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月差引残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月差引残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月差引残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt計算月差引残高.Height = 0.1771654!
        Me.txt計算月差引残高.Left = 6.141733!
        Me.txt計算月差引残高.Name = "txt計算月差引残高"
        Me.txt計算月差引残高.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt計算月差引残高.Text = "999,999,999"
        Me.txt計算月差引残高.Top = 0.0!
        Me.txt計算月差引残高.Width = 1.200787!
        '
        'lbl科目計
        '
        Me.lbl科目計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目計.Height = 0.1771654!
        Me.lbl科目計.HyperLink = Nothing
        Me.lbl科目計.Left = 1.594488!
        Me.lbl科目計.Name = "lbl科目計"
        Me.lbl科目計.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl科目計.Text = "*科目名"
        Me.lbl科目計.Top = 0.0!
        Me.lbl科目計.Width = 0.9448819!
        '
        'lbl借方
        '
        Me.lbl借方.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl借方.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl借方.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl借方.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl借方.CharacterSpacing = 10.0!
        Me.lbl借方.Height = 0.2362205!
        Me.lbl借方.HyperLink = Nothing
        Me.lbl借方.Left = 3.740158!
        Me.lbl借方.Name = "lbl借方"
        Me.lbl借方.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl借方.Text = "借方"
        Me.lbl借方.Top = 0.8291339!
        Me.lbl借方.Width = 1.200788!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Height = 0.1771653!
        Me.TextBox4.Left = 6.141733!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox4.Text = "999,999,999"
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 1.200788!
        '
        'Label1
        '
        Me.Label1.Height = 0.1968504!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 6.721261!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label1.Text = "(単位：円)"
        Me.Label1.Top = 0.6023623!
        Me.Label1.Width = 0.5905512!
        '
        'SupplSubBalanceList
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
        Me.Sections.Add(Me.grpFtr科目計)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt補助科目名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt摘要, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt差引残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt貸方残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt伝票No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt科目CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt相手科目名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入金明細表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl科目名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl貸方, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl科目CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl補助科目CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl補助科目名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl前残, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl事業年度, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt事業年度, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl計算期間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt計算期間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt計算月借方金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt計算月貸方残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt月累計貸方金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt計算月差引残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl科目計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl借方, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt補助科目名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt摘要 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt差引残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt貸方残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt伝票No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt入金明細表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl科目名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl貸方 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl科目CD As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr科目計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt計算月借方金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl補助科目CD As DataDynamics.ActiveReports.Label
    Private WithEvents lbl補助科目名 As DataDynamics.ActiveReports.Label
    Private WithEvents txt科目CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt相手科目名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl残高 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl前残 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt計算月貸方残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt月累計貸方金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt計算月差引残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl事業年度 As DataDynamics.ActiveReports.Label
    Private WithEvents txt事業年度 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl計算期間 As DataDynamics.ActiveReports.Label
    Private WithEvents txt計算期間 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl借方 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl科目計 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
End Class
