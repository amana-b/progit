<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class TB
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TB))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt前月残高 = New DataDynamics.ActiveReports.TextBox()
        Me.txt比率 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt貸方 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt借方 = New DataDynamics.ActiveReports.TextBox()
        Me.txt残高 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtHdr資産 = New DataDynamics.ActiveReports.TextBox()
        Me.txt入金明細表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl前残 = New DataDynamics.ActiveReports.Label()
        Me.lbl比率 = New DataDynamics.ActiveReports.Label()
        Me.lbl科目名 = New DataDynamics.ActiveReports.Label()
        Me.lbl借方 = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先CD = New DataDynamics.ActiveReports.Label()
        Me.lbl貸方 = New DataDynamics.ActiveReports.Label()
        Me.lblHdrコード = New DataDynamics.ActiveReports.Label()
        Me.lbl残高 = New DataDynamics.ActiveReports.Label()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.txt法人名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt会社名 = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.grpFtr計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt比率合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt貸方合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt借方合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt残高合計 = New DataDynamics.ActiveReports.TextBox()
        Me.utu合計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前残合計 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt前月残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt比率, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt貸方, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt借方, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr資産, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入金明細表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl前残, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl比率, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl科目名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl借方, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl貸方, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdrコード, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt法人名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt会社名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt比率合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt貸方合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt借方合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt残高合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utu合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前残合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt前月残高, Me.txt比率, Me.txt得意先名, Me.txt貸方, Me.txt得意先CD, Me.txt借方, Me.txt残高})
        Me.Detail.Height = 0.1771665!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt前月残高
        '
        Me.txt前月残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前月残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt前月残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt前月残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前月残高.Height = 0.1771654!
        Me.txt前月残高.Left = 1.456693!
        Me.txt前月残高.Name = "txt前月残高"
        Me.txt前月残高.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt前月残高.Text = "999,999,999"
        Me.txt前月残高.Top = 0.0!
        Me.txt前月残高.Width = 1.279528!
        '
        'txt比率
        '
        Me.txt比率.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt比率.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt比率.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt比率.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt比率.Height = 0.1771654!
        Me.txt比率.Left = 6.614173!
        Me.txt比率.Name = "txt比率"
        Me.txt比率.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt比率.Text = "99.99"
        Me.txt比率.Top = 0.000001132488!
        Me.txt比率.Width = 0.472441!
        '
        'txt得意先名
        '
        Me.txt得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.CanGrow = False
        Me.txt得意先名.Height = 0.1771654!
        Me.txt得意先名.Left = 0.3346457!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txt得意先名.Text = "あああああいいい"
        Me.txt得意先名.Top = 0.000000178814!
        Me.txt得意先名.Width = 1.122047!
        '
        'txt貸方
        '
        Me.txt貸方.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方.Height = 0.1771654!
        Me.txt貸方.Left = 4.015748!
        Me.txt貸方.Name = "txt貸方"
        Me.txt貸方.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt貸方.Text = "999,999,999"
        Me.txt貸方.Top = 0.0000002980233!
        Me.txt貸方.Width = 1.279528!
        '
        'txt得意先CD
        '
        Me.txt得意先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt得意先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Height = 0.1771654!
        Me.txt得意先CD.Left = 0.0!
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt得意先CD.Text = "123"
        Me.txt得意先CD.Top = 0.00000005960464!
        Me.txt得意先CD.Width = 0.3346457!
        '
        'txt借方
        '
        Me.txt借方.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt借方.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt借方.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt借方.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt借方.Height = 0.1771654!
        Me.txt借方.Left = 2.73622!
        Me.txt借方.Name = "txt借方"
        Me.txt借方.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt借方.Text = "999,999,999"
        Me.txt借方.Top = 0.0000001192093!
        Me.txt借方.Width = 1.279528!
        '
        'txt残高
        '
        Me.txt残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt残高.Height = 0.1771654!
        Me.txt残高.Left = 5.295276!
        Me.txt残高.Name = "txt残高"
        Me.txt残高.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt残高.Text = "999,999,999"
        Me.txt残高.Top = 0.0000005066395!
        Me.txt残高.Width = 1.318898!
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
        Me.txtNow.Left = 5.015749!
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
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtHdr資産, Me.txt入金明細表, Me.lbl前残, Me.lbl比率, Me.lbl科目名, Me.lbl借方, Me.lbl得意先CD, Me.lbl貸方, Me.lblHdrコード, Me.lbl残高, Me.txt頁, Me.txt法人名, Me.txt会社名, Me.Label1, Me.Label2, Me.TextBox1, Me.Label3, Me.TextBox2})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.9826772!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txtHdr資産
        '
        Me.txtHdr資産.Height = 0.1968504!
        Me.txtHdr資産.Left = 0.7874014!
        Me.txtHdr資産.Name = "txtHdr資産"
        Me.txtHdr資産.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txtHdr資産.Text = "(資産)"
        Me.txtHdr資産.Top = 0.2866142!
        Me.txtHdr資産.Width = 0.7874017!
        '
        'txt入金明細表
        '
        Me.txt入金明細表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt入金明細表.CharacterSpacing = 30.0!
        Me.txt入金明細表.Height = 0.2362205!
        Me.txt入金明細表.Left = 2.487402!
        Me.txt入金明細表.Name = "txt入金明細表"
        Me.txt入金明細表.Style = "font-family: ＭＳ Ｐゴシック; font-size: 14pt; font-weight: bold; text-align: center; ve" & _
    "rtical-align: bottom; ddo-char-set: 1"
        Me.txt入金明細表.Text = "試算表"
        Me.txt入金明細表.Top = 0.0!
        Me.txt入金明細表.Width = 1.968504!
        '
        'lbl前残
        '
        Me.lbl前残.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前残.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.lbl前残.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.lbl前残.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl前残.CharacterSpacing = 25.0!
        Me.lbl前残.Height = 0.2362205!
        Me.lbl前残.HyperLink = Nothing
        Me.lbl前残.Left = 1.456693!
        Me.lbl前残.Name = "lbl前残"
        Me.lbl前残.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl前残.Text = "前残"
        Me.lbl前残.Top = 0.7464567!
        Me.lbl前残.Width = 1.279528!
        '
        'lbl比率
        '
        Me.lbl比率.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl比率.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl比率.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl比率.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl比率.CharacterSpacing = 5.0!
        Me.lbl比率.Height = 0.2362205!
        Me.lbl比率.HyperLink = Nothing
        Me.lbl比率.Left = 6.614173!
        Me.lbl比率.Name = "lbl比率"
        Me.lbl比率.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl比率.Text = "比率"
        Me.lbl比率.Top = 0.7464567!
        Me.lbl比率.Width = 0.472441!
        '
        'lbl科目名
        '
        Me.lbl科目名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl科目名.CharacterSpacing = 10.0!
        Me.lbl科目名.Height = 0.2362205!
        Me.lbl科目名.HyperLink = Nothing
        Me.lbl科目名.Left = 0.3346458!
        Me.lbl科目名.Name = "lbl科目名"
        Me.lbl科目名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl科目名.Text = "科目名"
        Me.lbl科目名.Top = 0.7464567!
        Me.lbl科目名.Width = 1.122047!
        '
        'lbl借方
        '
        Me.lbl借方.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl借方.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl借方.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl借方.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl借方.CharacterSpacing = 25.0!
        Me.lbl借方.Height = 0.2362205!
        Me.lbl借方.HyperLink = Nothing
        Me.lbl借方.Left = 2.73622!
        Me.lbl借方.Name = "lbl借方"
        Me.lbl借方.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl借方.Text = "借方"
        Me.lbl借方.Top = 0.7464567!
        Me.lbl借方.Width = 1.279528!
        '
        'lbl得意先CD
        '
        Me.lbl得意先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl得意先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl得意先CD.Height = 0.2362205!
        Me.lbl得意先CD.HyperLink = Nothing
        Me.lbl得意先CD.Left = 0.0000001192093!
        Me.lbl得意先CD.Name = "lbl得意先CD"
        Me.lbl得意先CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl得意先CD.Text = "ｺｰﾄﾞ"
        Me.lbl得意先CD.Top = 0.7464567!
        Me.lbl得意先CD.Width = 0.3346457!
        '
        'lbl貸方
        '
        Me.lbl貸方.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl貸方.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl貸方.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl貸方.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl貸方.CharacterSpacing = 25.0!
        Me.lbl貸方.Height = 0.2362205!
        Me.lbl貸方.HyperLink = Nothing
        Me.lbl貸方.Left = 4.015748!
        Me.lbl貸方.Name = "lbl貸方"
        Me.lbl貸方.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl貸方.Text = "貸方"
        Me.lbl貸方.Top = 0.7464567!
        Me.lbl貸方.Width = 1.279528!
        '
        'lblHdrコード
        '
        Me.lblHdrコード.Height = 0.1968504!
        Me.lblHdrコード.HyperLink = Nothing
        Me.lblHdrコード.Left = 0.0!
        Me.lblHdrコード.Name = "lblHdrコード"
        Me.lblHdrコード.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdrコード.Text = "(0321)"
        Me.lblHdrコード.Top = 0.2866142!
        Me.lblHdrコード.Width = 0.7874016!
        '
        'lbl残高
        '
        Me.lbl残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.lbl残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.lbl残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl残高.CharacterSpacing = 25.0!
        Me.lbl残高.Height = 0.2362205!
        Me.lbl残高.HyperLink = Nothing
        Me.lbl残高.Left = 5.295276!
        Me.lbl残高.Name = "lbl残高"
        Me.lbl残高.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl残高.Text = "残高"
        Me.lbl残高.Top = 0.7464567!
        Me.lbl残高.Width = 1.318898!
        '
        'txt頁
        '
        Me.txt頁.Height = 0.2362205!
        Me.txt頁.Left = 6.601575!
        Me.txt頁.Name = "txt頁"
        Me.txt頁.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt頁.Text = "(99/99)"
        Me.txt頁.Top = 0.2566929!
        Me.txt頁.Width = 0.472441!
        '
        'txt法人名
        '
        Me.txt法人名.Height = 0.1968504!
        Me.txt法人名.Left = 0.0!
        Me.txt法人名.Name = "txt法人名"
        Me.txt法人名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt法人名.Text = "株式会社"
        Me.txt法人名.Top = 0.5204725!
        Me.txt法人名.Width = 0.7874016!
        '
        'txt会社名
        '
        Me.txt会社名.Height = 0.1968504!
        Me.txt会社名.Left = 0.7874016!
        Me.txt会社名.Name = "txt会社名"
        Me.txt会社名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt会社名.Text = "友功社"
        Me.txt会社名.Top = 0.5204725!
        Me.txt会社名.Width = 0.7874016!
        '
        'Label1
        '
        Me.Label1.Height = 0.1574803!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 6.483465!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-ali" & _
    "gn: middle; ddo-char-set: 1"
        Me.Label1.Text = "(単位：円)"
        Me.Label1.Top = 0.5614173!
        Me.Label1.Width = 0.5905512!
        '
        'Label2
        '
        Me.Label2.Height = 0.1968504!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 2.13937!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label2.Text = "事業年度"
        Me.Label2.Top = 0.3259842!
        Me.Label2.Width = 0.7874014!
        '
        'TextBox1
        '
        Me.TextBox1.Height = 0.1968504!
        Me.TextBox1.Left = 2.926772!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox1.Text = "00年00月00日～99年99月99日"
        Me.TextBox1.Top = 0.3259842!
        Me.TextBox1.Width = 2.172835!
        '
        'Label3
        '
        Me.Label3.Height = 0.1968504!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.13937!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label3.Text = "計算期間"
        Me.Label3.Top = 0.5228347!
        Me.Label3.Width = 0.7874014!
        '
        'TextBox2
        '
        Me.TextBox2.Height = 0.1968504!
        Me.TextBox2.Left = 2.926772!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox2.Text = "00年00月00日～99年99月99日"
        Me.TextBox2.Top = 0.5228347!
        Me.TextBox2.Width = 2.172835!
        '
        'grpFtr計
        '
        Me.grpFtr計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt比率合計, Me.txt貸方合計, Me.txt借方合計, Me.txt残高合計, Me.utu合計, Me.TextBox19, Me.txt前残合計})
        Me.grpFtr計.Height = 0.1771654!
        Me.grpFtr計.Name = "grpFtr計"
        '
        'txt比率合計
        '
        Me.txt比率合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt比率合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt比率合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt比率合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt比率合計.Height = 0.1771654!
        Me.txt比率合計.Left = 6.614173!
        Me.txt比率合計.Name = "txt比率合計"
        Me.txt比率合計.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt比率合計.Text = "99.99"
        Me.txt比率合計.Top = 0.0!
        Me.txt比率合計.Width = 0.472441!
        '
        'txt貸方合計
        '
        Me.txt貸方合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt貸方合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方合計.Height = 0.1771654!
        Me.txt貸方合計.Left = 4.015748!
        Me.txt貸方合計.Name = "txt貸方合計"
        Me.txt貸方合計.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt貸方合計.Text = "999,999,999"
        Me.txt貸方合計.Top = 0.0000002980233!
        Me.txt貸方合計.Width = 1.279528!
        '
        'txt借方合計
        '
        Me.txt借方合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt借方合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt借方合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt借方合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt借方合計.Height = 0.1771654!
        Me.txt借方合計.Left = 2.73622!
        Me.txt借方合計.Name = "txt借方合計"
        Me.txt借方合計.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt借方合計.Text = "999,999,999" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt借方合計.Top = 0.0000001192093!
        Me.txt借方合計.Width = 1.279528!
        '
        'txt残高合計
        '
        Me.txt残高合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt残高合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt残高合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt残高合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt残高合計.Height = 0.1771654!
        Me.txt残高合計.Left = 5.295276!
        Me.txt残高合計.Name = "txt残高合計"
        Me.txt残高合計.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt残高合計.Text = "999,999,999"
        Me.txt残高合計.Top = 0.0000005066395!
        Me.txt残高合計.Width = 1.318898!
        '
        'utu合計
        '
        Me.utu合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.utu合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.utu合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.utu合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.utu合計.CharacterSpacing = 50.0!
        Me.utu合計.Height = 0.1771654!
        Me.utu合計.Left = 0.3346457!
        Me.utu合計.Name = "utu合計"
        Me.utu合計.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.utu合計.Text = "合計"
        Me.utu合計.Top = 0.0!
        Me.utu合計.Width = 1.122047!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Height = 0.1771654!
        Me.TextBox19.Left = 0.0!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox19.Text = Nothing
        Me.TextBox19.Top = 0.00000005960464!
        Me.TextBox19.Width = 0.3346457!
        '
        'txt前残合計
        '
        Me.txt前残合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt前残合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt前残合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt前残合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前残合計.Height = 0.1771654!
        Me.txt前残合計.Left = 1.456693!
        Me.txt前残合計.Name = "txt前残合計"
        Me.txt前残合計.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt前残合計.Text = "999,999,999"
        Me.txt前残合計.Top = 0.0!
        Me.txt前残合計.Width = 1.279528!
        '
        'TB
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.125985!
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
        CType(Me.txt前月残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt比率, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt貸方, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt借方, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr資産, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入金明細表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl前残, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl比率, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl科目名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl借方, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl貸方, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdrコード, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt法人名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt会社名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt比率合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt貸方合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt借方合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt残高合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utu合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前残合計, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt前月残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt比率 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt貸方 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt借方 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txtHdr資産 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt入金明細表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl前残 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl比率 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl科目名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl借方 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先CD As DataDynamics.ActiveReports.Label
    Private WithEvents lbl貸方 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdrコード As DataDynamics.ActiveReports.Label
    Private WithEvents lbl残高 As DataDynamics.ActiveReports.Label
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpFtr計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt比率合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt貸方合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt借方合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt残高合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents utu合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前残合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt法人名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt会社名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
End Class
