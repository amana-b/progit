<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class StuffNotReserveList
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(StuffNotReserveList))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt現金振込 = New DataDynamics.ActiveReports.TextBox()
        Me.txt単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入区分 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt数量 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入No = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt納入場所 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtHdr仕入年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者別未引当一覧表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl仕入日 = New DataDynamics.ActiveReports.Label()
        Me.lbl単価 = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入先名 = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入先CD = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入区分 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr仕入年月 = New DataDynamics.ActiveReports.Label()
        Me.lbl数量 = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入No = New DataDynamics.ActiveReports.Label()
        Me.lbl商品名 = New DataDynamics.ActiveReports.Label()
        Me.lbl金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl納入場所 = New DataDynamics.ActiveReports.Label()
        Me.lbl担当者 = New DataDynamics.ActiveReports.Label()
        Me.txt担当者CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者名 = New DataDynamics.ActiveReports.TextBox()
        Me.grpFtr計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.txt手形合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt現金振込合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt = New DataDynamics.ActiveReports.TextBox()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        CType(Me.txt現金振込, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt納入場所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr仕入年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者別未引当一覧表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr仕入年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl納入場所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl担当者, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt手形合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt現金振込合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt現金振込, Me.txt単価, Me.txt仕入区分, Me.txt仕入先CD, Me.txt仕入先名, Me.txt数量, Me.txt仕入No, Me.txt商品名, Me.txt金額, Me.txt納入場所})
        Me.Detail.Height = 0.2755917!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt現金振込
        '
        Me.txt現金振込.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込.Height = 0.2755905!
        Me.txt現金振込.Left = 0.0!
        Me.txt現金振込.Name = "txt現金振込"
        Me.txt現金振込.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt現金振込.Text = "YY/MM/DD"
        Me.txt現金振込.Top = 0.0!
        Me.txt現金振込.Width = 0.6692914!
        '
        'txt単価
        '
        Me.txt単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Height = 0.2755905!
        Me.txt単価.Left = 7.913385!
        Me.txt単価.Name = "txt単価"
        Me.txt単価.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt単価.Text = "999,999,999"
        Me.txt単価.Top = 0.000001132488!
        Me.txt単価.Width = 1.023622!
        '
        'txt仕入区分
        '
        Me.txt仕入区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入区分.Height = 0.2755905!
        Me.txt仕入区分.Left = 3.031496!
        Me.txt仕入区分.Name = "txt仕入区分"
        Me.txt仕入区分.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt仕入区分.Text = "あああ"
        Me.txt仕入区分.Top = 0.0000002980233!
        Me.txt仕入区分.Width = 0.6889764!
        '
        'txt仕入先CD
        '
        Me.txt仕入先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先CD.Height = 0.2755905!
        Me.txt仕入先CD.Left = 1.259843!
        Me.txt仕入先CD.Name = "txt仕入先CD"
        Me.txt仕入先CD.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt仕入先CD.Text = "123456"
        Me.txt仕入先CD.Top = 0.00000005960464!
        Me.txt仕入先CD.Width = 0.5511811!
        '
        'txt仕入先名
        '
        Me.txt仕入先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Height = 0.2755905!
        Me.txt仕入先名.Left = 1.811024!
        Me.txt仕入先名.Name = "txt仕入先名"
        Me.txt仕入先名.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: justify; vertical-align: bottom" & _
    "; ddo-char-set: 1"
        Me.txt仕入先名.Text = "あああああいいい"
        Me.txt仕入先名.Top = 0.0000001192093!
        Me.txt仕入先名.Width = 1.220472!
        '
        'txt数量
        '
        Me.txt数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Height = 0.2755905!
        Me.txt数量.Left = 6.948819!
        Me.txt数量.Name = "txt数量"
        Me.txt数量.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt数量.Text = "999,999,999"
        Me.txt数量.Top = 0.0000002980233!
        Me.txt数量.Width = 0.9645669!
        '
        'txt仕入No
        '
        Me.txt仕入No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入No.Height = 0.2755905!
        Me.txt仕入No.Left = 0.6692914!
        Me.txt仕入No.Name = "txt仕入No"
        Me.txt仕入No.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt仕入No.Text = "123456"
        Me.txt仕入No.Top = 0.0000002980233!
        Me.txt仕入No.Width = 0.5905512!
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
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: left; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt商品名.Text = "あああああいいいいいううううう"
        Me.txt商品名.Top = 0.0000005066395!
        Me.txt商品名.Width = 3.228346!
        '
        'txt金額
        '
        Me.txt金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Height = 0.2755905!
        Me.txt金額.Left = 8.937008!
        Me.txt金額.Name = "txt金額"
        Me.txt金額.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt金額.Text = "999,999,999"
        Me.txt金額.Top = 0.0!
        Me.txt金額.Width = 1.299213!
        '
        'txt納入場所
        '
        Me.txt納入場所.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納入場所.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納入場所.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納入場所.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納入場所.Height = 0.2755905!
        Me.txt納入場所.Left = 10.23622!
        Me.txt納入場所.Name = "txt納入場所"
        Me.txt納入場所.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt納入場所.Text = "ああ"
        Me.txt納入場所.Top = 0.0!
        Me.txt納入場所.Width = 0.6889764!
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
        Me.txtNow.Left = 7.574792!
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
        Me.txt頁.Left = 9.718505!
        Me.txt頁.Name = "txt頁"
        Me.txt頁.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt頁.Text = "頁"
        Me.txt頁.Top = 0.0!
        Me.txt頁.Width = 0.379528!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdr
        '
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtHdr仕入年月, Me.txt担当者別未引当一覧表, Me.lbl仕入日, Me.lbl単価, Me.lbl仕入先名, Me.lbl仕入先CD, Me.lbl仕入区分, Me.lblHdr仕入年月, Me.lbl数量, Me.lbl仕入No, Me.lbl商品名, Me.lbl金額, Me.lbl納入場所, Me.lbl担当者, Me.txt担当者CD, Me.txt担当者名})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.9795275!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txtHdr仕入年月
        '
        Me.txtHdr仕入年月.Height = 0.2362205!
        Me.txtHdr仕入年月.Left = 0.7874014!
        Me.txtHdr仕入年月.Name = "txtHdr仕入年月"
        Me.txtHdr仕入年月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtHdr仕入年月.Text = "YY/MM月分"
        Me.txtHdr仕入年月.Top = 0.0!
        Me.txtHdr仕入年月.Width = 1.181102!
        '
        'txt担当者別未引当一覧表
        '
        Me.txt担当者別未引当一覧表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt担当者別未引当一覧表.CharacterSpacing = 5.0!
        Me.txt担当者別未引当一覧表.Height = 0.2362205!
        Me.txt担当者別未引当一覧表.Left = 4.514174!
        Me.txt担当者別未引当一覧表.Name = "txt担当者別未引当一覧表"
        Me.txt担当者別未引当一覧表.Style = "font-family: ＭＳ Ｐゴシック; font-size: 14pt; font-weight: bold; text-align: center; ve" & _
    "rtical-align: bottom; ddo-char-set: 1"
        Me.txt担当者別未引当一覧表.Text = "担当者別未引当一覧表"
        Me.txt担当者別未引当一覧表.Top = 0.1968504!
        Me.txt担当者別未引当一覧表.Width = 2.677166!
        '
        'lbl仕入日
        '
        Me.lbl仕入日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入日.Height = 0.3149606!
        Me.lbl仕入日.HyperLink = Nothing
        Me.lbl仕入日.Left = 0.0!
        Me.lbl仕入日.Name = "lbl仕入日"
        Me.lbl仕入日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl仕入日.Text = "仕入日"
        Me.lbl仕入日.Top = 0.664567!
        Me.lbl仕入日.Width = 0.6692914!
        '
        'lbl単価
        '
        Me.lbl単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Height = 0.3149606!
        Me.lbl単価.HyperLink = Nothing
        Me.lbl単価.Left = 7.913385!
        Me.lbl単価.Name = "lbl単価"
        Me.lbl単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl単価.Text = "単価"
        Me.lbl単価.Top = 0.664567!
        Me.lbl単価.Width = 1.023622!
        '
        'lbl仕入先名
        '
        Me.lbl仕入先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.CharacterSpacing = 2.0!
        Me.lbl仕入先名.Height = 0.3149606!
        Me.lbl仕入先名.HyperLink = Nothing
        Me.lbl仕入先名.Left = 1.811024!
        Me.lbl仕入先名.Name = "lbl仕入先名"
        Me.lbl仕入先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbl仕入先名.Text = "仕入先名(略称)"
        Me.lbl仕入先名.Top = 0.664567!
        Me.lbl仕入先名.Width = 1.220472!
        '
        'lbl仕入先CD
        '
        Me.lbl仕入先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先CD.Height = 0.3346457!
        Me.lbl仕入先CD.HyperLink = Nothing
        Me.lbl仕入先CD.Left = 1.259843!
        Me.lbl仕入先CD.Name = "lbl仕入先CD"
        Me.lbl仕入先CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl仕入先CD.Text = "ｺｰﾄﾞ"
        Me.lbl仕入先CD.Top = 0.664567!
        Me.lbl仕入先CD.Width = 0.5511811!
        '
        'lbl仕入区分
        '
        Me.lbl仕入区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入区分.Height = 0.3149606!
        Me.lbl仕入区分.HyperLink = Nothing
        Me.lbl仕入区分.Left = 3.031496!
        Me.lbl仕入区分.Name = "lbl仕入区分"
        Me.lbl仕入区分.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl仕入区分.Text = "仕入区分"
        Me.lbl仕入区分.Top = 0.664567!
        Me.lbl仕入区分.Width = 0.6889764!
        '
        'lblHdr仕入年月
        '
        Me.lblHdr仕入年月.Height = 0.2362205!
        Me.lblHdr仕入年月.HyperLink = Nothing
        Me.lblHdr仕入年月.Left = 0.0!
        Me.lblHdr仕入年月.Name = "lblHdr仕入年月"
        Me.lblHdr仕入年月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdr仕入年月.Text = "仕入日"
        Me.lblHdr仕入年月.Top = 0.0!
        Me.lblHdr仕入年月.Width = 0.7874014!
        '
        'lbl数量
        '
        Me.lbl数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Height = 0.3149606!
        Me.lbl数量.HyperLink = Nothing
        Me.lbl数量.Left = 6.948819!
        Me.lbl数量.Name = "lbl数量"
        Me.lbl数量.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl数量.Text = "数量"
        Me.lbl数量.Top = 0.664567!
        Me.lbl数量.Width = 0.9645669!
        '
        'lbl仕入No
        '
        Me.lbl仕入No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入No.Height = 0.3149606!
        Me.lbl仕入No.HyperLink = Nothing
        Me.lbl仕入No.Left = 0.6692914!
        Me.lbl仕入No.Name = "lbl仕入No"
        Me.lbl仕入No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl仕入No.Text = "仕入No"
        Me.lbl仕入No.Top = 0.664567!
        Me.lbl仕入No.Width = 0.5905512!
        '
        'lbl商品名
        '
        Me.lbl商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.CharacterSpacing = 5.0!
        Me.lbl商品名.Height = 0.3149606!
        Me.lbl商品名.HyperLink = Nothing
        Me.lbl商品名.Left = 3.720472!
        Me.lbl商品名.Name = "lbl商品名"
        Me.lbl商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl商品名.Text = "商品名"
        Me.lbl商品名.Top = 0.664567!
        Me.lbl商品名.Width = 3.228346!
        '
        'lbl金額
        '
        Me.lbl金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Height = 0.3149606!
        Me.lbl金額.HyperLink = Nothing
        Me.lbl金額.Left = 8.937008!
        Me.lbl金額.Name = "lbl金額"
        Me.lbl金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl金額.Text = "金額"
        Me.lbl金額.Top = 0.664567!
        Me.lbl金額.Width = 1.299213!
        '
        'lbl納入場所
        '
        Me.lbl納入場所.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納入場所.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納入場所.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納入場所.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納入場所.Height = 0.3149606!
        Me.lbl納入場所.HyperLink = Nothing
        Me.lbl納入場所.Left = 10.23622!
        Me.lbl納入場所.Name = "lbl納入場所"
        Me.lbl納入場所.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl納入場所.Text = "納入場所"
        Me.lbl納入場所.Top = 0.6661418!
        Me.lbl納入場所.Width = 0.6889764!
        '
        'lbl担当者
        '
        Me.lbl担当者.Height = 0.2362205!
        Me.lbl担当者.HyperLink = Nothing
        Me.lbl担当者.Left = 0.0!
        Me.lbl担当者.Name = "lbl担当者"
        Me.lbl担当者.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl担当者.Text = "担当者"
        Me.lbl担当者.Top = 0.3362205!
        Me.lbl担当者.Width = 0.7874014!
        '
        'txt担当者CD
        '
        Me.txt担当者CD.Height = 0.2362205!
        Me.txt担当者CD.Left = 0.7874014!
        Me.txt担当者CD.Name = "txt担当者CD"
        Me.txt担当者CD.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt担当者CD.Text = "123"
        Me.txt担当者CD.Top = 0.3362205!
        Me.txt担当者CD.Width = 0.3937008!
        '
        'txt担当者名
        '
        Me.txt担当者名.Height = 0.2362205!
        Me.txt担当者名.Left = 1.228347!
        Me.txt担当者名.Name = "txt担当者名"
        Me.txt担当者名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt担当者名.Text = "あああああいいいいいううううう"
        Me.txt担当者名.Top = 0.3362205!
        Me.txt担当者名.Width = 2.826772!
        '
        'grpFtr計
        '
        Me.grpFtr計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox15, Me.TextBox14, Me.TextBox12, Me.TextBox11, Me.TextBox13, Me.Label2, Me.TextBox19, Me.txt手形合計, Me.txt現金振込合計, Me.txt総合計, Me.txt})
        Me.grpFtr計.Height = 0.2755905!
        Me.grpFtr計.Name = "grpFtr計"
        '
        'TextBox15
        '
        Me.TextBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Height = 0.2755905!
        Me.TextBox15.Left = 7.913385!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox15.Text = Nothing
        Me.TextBox15.Top = 0.0!
        Me.TextBox15.Width = 1.023622!
        '
        'TextBox14
        '
        Me.TextBox14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Height = 0.2755905!
        Me.TextBox14.Left = 6.948819!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox14.Text = Nothing
        Me.TextBox14.Top = 0.0000002980233!
        Me.TextBox14.Width = 0.9645669!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Height = 0.2755905!
        Me.TextBox12.Left = 3.031496!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.TextBox12.Text = Nothing
        Me.TextBox12.Top = 0.0000002980233!
        Me.TextBox12.Width = 0.6889764!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Height = 0.2755905!
        Me.TextBox11.Left = 1.811024!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 0.0000001192093!
        Me.TextBox11.Width = 1.220472!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Height = 0.2755905!
        Me.TextBox13.Left = 3.720472!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: left; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox13.Text = Nothing
        Me.TextBox13.Top = 0.0000005066395!
        Me.TextBox13.Width = 3.228346!
        '
        'Label2
        '
        Me.Label2.Height = 0.1771654!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 8.092914!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label2.Text = "＊総合計"
        Me.Label2.Top = 0.05118111!
        Me.Label2.Width = 0.7874016!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Height = 0.2755905!
        Me.TextBox19.Left = 1.259843!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox19.Text = Nothing
        Me.TextBox19.Top = 0.00000005960464!
        Me.TextBox19.Width = 0.5511811!
        '
        'txt手形合計
        '
        Me.txt手形合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形合計.Height = 0.2755905!
        Me.txt手形合計.Left = 0.6692914!
        Me.txt手形合計.Name = "txt手形合計"
        Me.txt手形合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt手形合計.Text = Nothing
        Me.txt手形合計.Top = 0.0!
        Me.txt手形合計.Width = 0.5905512!
        '
        'txt現金振込合計
        '
        Me.txt現金振込合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt現金振込合計.Height = 0.2755905!
        Me.txt現金振込合計.Left = 0.0!
        Me.txt現金振込合計.Name = "txt現金振込合計"
        Me.txt現金振込合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt現金振込合計.Text = Nothing
        Me.txt現金振込合計.Top = 0.0!
        Me.txt現金振込合計.Width = 0.6692914!
        '
        'txt総合計
        '
        Me.txt総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計.Height = 0.2755905!
        Me.txt総合計.Left = 8.937008!
        Me.txt総合計.Name = "txt総合計"
        Me.txt総合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計.Text = "999,999,999"
        Me.txt総合計.Top = 0.0!
        Me.txt総合計.Width = 1.299213!
        '
        'txt
        '
        Me.txt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt.Height = 0.2755905!
        Me.txt.Left = 10.23622!
        Me.txt.Name = "txt"
        Me.txt.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt.Text = Nothing
        Me.txt.Top = 0.0!
        Me.txt.Width = 0.6889764!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.txt担当者計, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.Label1})
        Me.GroupFooter1.Height = 0.275591!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.2755905!
        Me.TextBox1.Left = 10.23622!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.6889764!
        '
        'txt担当者計
        '
        Me.txt担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者計.Height = 0.2755905!
        Me.txt担当者計.Left = 8.937008!
        Me.txt担当者計.Name = "txt担当者計"
        Me.txt担当者計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者計.Text = "999,999,999"
        Me.txt担当者計.Top = 0.0!
        Me.txt担当者計.Width = 1.299213!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.2755905!
        Me.TextBox3.Left = 7.913385!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 1.023622!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Height = 0.2755905!
        Me.TextBox4.Left = 6.948819!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.0000002980233!
        Me.TextBox4.Width = 0.9645669!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Height = 0.2755905!
        Me.TextBox5.Left = 3.720472!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: left; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0.0000005066395!
        Me.TextBox5.Width = 3.228346!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Height = 0.2755905!
        Me.TextBox6.Left = 3.031496!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0.0000002980233!
        Me.TextBox6.Width = 0.6889764!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Height = 0.2755905!
        Me.TextBox7.Left = 0.6692914!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 0.5905512!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Height = 0.2755905!
        Me.TextBox8.Left = 1.811024!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.0000001192093!
        Me.TextBox8.Width = 1.220472!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Height = 0.2755905!
        Me.TextBox9.Left = 1.259843!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0.00000005960464!
        Me.TextBox9.Width = 0.551181!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Height = 0.2755906!
        Me.TextBox10.Left = 0.0!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox10.Text = Nothing
        Me.TextBox10.Top = 0.0!
        Me.TextBox10.Width = 0.6692914!
        '
        'Label1
        '
        Me.Label1.Height = 0.1771654!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 8.06693!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label1.Text = "＊担当者計"
        Me.Label1.Top = 0.03070866!
        Me.Label1.Width = 0.7874014!
        '
        'StuffNotReserveList
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.9252!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.grpFtr計)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt現金振込, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt納入場所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr仕入年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者別未引当一覧表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr仕入年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl納入場所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl担当者, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt手形合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt現金振込合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt現金振込 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt数量 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txtHdr仕入年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者別未引当一覧表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl仕入日 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl仕入先名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl仕入先CD As DataDynamics.ActiveReports.Label
    Private WithEvents lbl仕入区分 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr仕入年月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl数量 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl仕入No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt手形合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl単価 As DataDynamics.ActiveReports.Label
    Private WithEvents txt総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt納入場所 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl納入場所 As DataDynamics.ActiveReports.Label
    Private WithEvents txt As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl担当者 As DataDynamics.ActiveReports.Label
    Private WithEvents txt担当者CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt現金振込合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
End Class
