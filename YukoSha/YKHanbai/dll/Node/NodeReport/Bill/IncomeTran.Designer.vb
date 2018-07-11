<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class IncomeTran
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(IncomeTran))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt4月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt1月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt6月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt5月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月累計金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt項目名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月累計構成比 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt入金明細表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl当月迄累計 = New DataDynamics.ActiveReports.Label()
        Me.lbl項目 = New DataDynamics.ActiveReports.Label()
        Me.lbl金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl構成比 = New DataDynamics.ActiveReports.Label()
        Me.txt会社名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt法人 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl月次実績推移 = New DataDynamics.ActiveReports.Label()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.lbl4月 = New DataDynamics.ActiveReports.Label()
        Me.lbl6月 = New DataDynamics.ActiveReports.Label()
        Me.lbl1月 = New DataDynamics.ActiveReports.Label()
        Me.lbl5月 = New DataDynamics.ActiveReports.Label()
        Me.lbl7月 = New DataDynamics.ActiveReports.Label()
        Me.lbl3月 = New DataDynamics.ActiveReports.Label()
        Me.lbl12月 = New DataDynamics.ActiveReports.Label()
        Me.lbl9月 = New DataDynamics.ActiveReports.Label()
        Me.lbl8月 = New DataDynamics.ActiveReports.Label()
        Me.lbl2月 = New DataDynamics.ActiveReports.Label()
        Me.lbl11月 = New DataDynamics.ActiveReports.Label()
        Me.lbl10月 = New DataDynamics.ActiveReports.Label()
        Me.txt対象年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt7月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt8月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt9月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt10月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt11月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt12月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt3月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt2月 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt4月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt6月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt5月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月累計金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt項目名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月累計構成比, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入金明細表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl当月迄累計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl項目, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl構成比, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt会社名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt法人, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl月次実績推移, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl4月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl6月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl1月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl5月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl7月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl3月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl12月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl9月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl8月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl2月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl11月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl10月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt7月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt8月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt9月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt10月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt11月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt12月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt2月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt4月, Me.txt1月, Me.txt6月, Me.txt5月, Me.txt当月累計金額, Me.txt項目名, Me.txt当月累計構成比, Me.txt7月, Me.txt8月, Me.txt9月, Me.txt10月, Me.txt11月, Me.txt12月, Me.txt3月, Me.txt2月})
        Me.Detail.Height = 0.1968504!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt4月
        '
        Me.txt4月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt4月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4月.Height = 0.1968504!
        Me.txt4月.Left = 2.913386!
        Me.txt4月.Name = "txt4月"
        Me.txt4月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt4月.Text = "999,999"
        Me.txt4月.Top = 0.0!
        Me.txt4月.Width = 0.8464568!
        '
        'txt1月
        '
        Me.txt1月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt1月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt1月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt1月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt1月.Height = 0.1968504!
        Me.txt1月.Left = 10.64961!
        Me.txt1月.Name = "txt1月"
        Me.txt1月.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt1月.Text = "999,999"
        Me.txt1月.Top = 0.0!
        Me.txt1月.Width = 0.8464568!
        '
        'txt6月
        '
        Me.txt6月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt6月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt6月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt6月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt6月.Height = 0.1968504!
        Me.txt6月.Left = 4.606299!
        Me.txt6月.Name = "txt6月"
        Me.txt6月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt6月.Text = "999,999"
        Me.txt6月.Top = 0.0!
        Me.txt6月.Width = 0.8661417!
        '
        'txt5月
        '
        Me.txt5月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt5月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5月.Height = 0.1968504!
        Me.txt5月.Left = 3.759843!
        Me.txt5月.Name = "txt5月"
        Me.txt5月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt5月.Text = "999,999"
        Me.txt5月.Top = 0.0!
        Me.txt5月.Width = 0.8464568!
        '
        'txt当月累計金額
        '
        Me.txt当月累計金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt当月累計金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月累計金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月累計金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月累計金額.Height = 0.1968504!
        Me.txt当月累計金額.Left = 1.535433!
        Me.txt当月累計金額.Name = "txt当月累計金額"
        Me.txt当月累計金額.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt当月累計金額.Text = "999,999,999"
        Me.txt当月累計金額.Top = 0.0!
        Me.txt当月累計金額.Width = 0.8661417!
        '
        'txt項目名
        '
        Me.txt項目名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt項目名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt項目名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt項目名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt項目名.CharacterSpacing = 3.0!
        Me.txt項目名.Height = 0.1968504!
        Me.txt項目名.Left = 0.0!
        Me.txt項目名.Name = "txt項目名"
        Me.txt項目名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt項目名.Text = "あああああ"
        Me.txt項目名.Top = 0.0!
        Me.txt項目名.Width = 1.535433!
        '
        'txt当月累計構成比
        '
        Me.txt当月累計構成比.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt当月累計構成比.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月累計構成比.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月累計構成比.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月累計構成比.Height = 0.1968504!
        Me.txt当月累計構成比.Left = 2.401575!
        Me.txt当月累計構成比.Name = "txt当月累計構成比"
        Me.txt当月累計構成比.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt当月累計構成比.Text = "999.9"
        Me.txt当月累計構成比.Top = 0.0!
        Me.txt当月累計構成比.Width = 0.511811!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNow})
        Me.PageHeader.Height = 0.2362205!
        Me.PageHeader.Name = "PageHeader"
        '
        'txtNow
        '
        Me.txtNow.Height = 0.2362205!
        Me.txtNow.Left = 11.30118!
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
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt入金明細表, Me.lbl当月迄累計, Me.lbl項目, Me.lbl金額, Me.lbl構成比, Me.txt会社名, Me.txt法人, Me.lbl月次実績推移, Me.Label1, Me.lbl4月, Me.lbl6月, Me.lbl1月, Me.lbl5月, Me.lbl7月, Me.lbl3月, Me.lbl12月, Me.lbl9月, Me.lbl8月, Me.lbl2月, Me.lbl11月, Me.lbl10月, Me.txt対象年月})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 1.007874!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txt入金明細表
        '
        Me.txt入金明細表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt入金明細表.CharacterSpacing = 20.0!
        Me.txt入金明細表.Height = 0.3937008!
        Me.txt入金明細表.Left = 5.169291!
        Me.txt入金明細表.Name = "txt入金明細表"
        Me.txt入金明細表.Style = "font-family: ＭＳ 明朝; font-size: 16pt; font-weight: bold; text-align: center; verti" & _
    "cal-align: bottom; ddo-char-set: 1"
        Me.txt入金明細表.Text = "損益推移表"
        Me.txt入金明細表.Top = 0.0!
        Me.txt入金明細表.Width = 2.594488!
        '
        'lbl当月迄累計
        '
        Me.lbl当月迄累計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月迄累計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月迄累計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月迄累計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl当月迄累計.CharacterSpacing = 3.0!
        Me.lbl当月迄累計.Height = 0.1968504!
        Me.lbl当月迄累計.HyperLink = Nothing
        Me.lbl当月迄累計.Left = 1.535433!
        Me.lbl当月迄累計.Name = "lbl当月迄累計"
        Me.lbl当月迄累計.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl当月迄累計.Text = "当月迄累計"
        Me.lbl当月迄累計.Top = 0.6141733!
        Me.lbl当月迄累計.Width = 1.377953!
        '
        'lbl項目
        '
        Me.lbl項目.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl項目.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl項目.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl項目.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl項目.CharacterSpacing = 30.0!
        Me.lbl項目.Height = 0.3937008!
        Me.lbl項目.HyperLink = Nothing
        Me.lbl項目.Left = 0.0!
        Me.lbl項目.Name = "lbl項目"
        Me.lbl項目.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl項目.Text = "項目"
        Me.lbl項目.Top = 0.6141734!
        Me.lbl項目.Width = 1.535433!
        '
        'lbl金額
        '
        Me.lbl金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.CharacterSpacing = 5.0!
        Me.lbl金額.Height = 0.1968504!
        Me.lbl金額.HyperLink = Nothing
        Me.lbl金額.Left = 1.535433!
        Me.lbl金額.Name = "lbl金額"
        Me.lbl金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl金額.Text = "金額"
        Me.lbl金額.Top = 0.8110237!
        Me.lbl金額.Width = 0.8661417!
        '
        'lbl構成比
        '
        Me.lbl構成比.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl構成比.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl構成比.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl構成比.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl構成比.Height = 0.1968504!
        Me.lbl構成比.HyperLink = Nothing
        Me.lbl構成比.Left = 2.401575!
        Me.lbl構成比.Name = "lbl構成比"
        Me.lbl構成比.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl構成比.Text = "構成比"
        Me.lbl構成比.Top = 0.8110237!
        Me.lbl構成比.Width = 0.511811!
        '
        'txt会社名
        '
        Me.txt会社名.Height = 0.3149606!
        Me.txt会社名.Left = 1.189764!
        Me.txt会社名.Name = "txt会社名"
        Me.txt会社名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt会社名.Text = "友功社"
        Me.txt会社名.Top = 0.2661417!
        Me.txt会社名.Width = 0.984252!
        '
        'txt法人
        '
        Me.txt法人.Height = 0.3149606!
        Me.txt法人.Left = 0.2055119!
        Me.txt法人.Name = "txt法人"
        Me.txt法人.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt法人.Text = "株式会社"
        Me.txt法人.Top = 0.2661417!
        Me.txt法人.Width = 0.984252!
        '
        'lbl月次実績推移
        '
        Me.lbl月次実績推移.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl月次実績推移.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl月次実績推移.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl月次実績推移.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl月次実績推移.CharacterSpacing = 30.0!
        Me.lbl月次実績推移.Height = 0.1968504!
        Me.lbl月次実績推移.HyperLink = Nothing
        Me.lbl月次実績推移.Left = 2.913386!
        Me.lbl月次実績推移.Name = "lbl月次実績推移"
        Me.lbl月次実績推移.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl月次実績推移.Text = "月次実績推移"
        Me.lbl月次実績推移.Top = 0.6141733!
        Me.lbl月次実績推移.Width = 10.31496!
        '
        'Label1
        '
        Me.Label1.Height = 0.230315!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 12.29921!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-ali" & _
    "gn: middle; ddo-char-set: 1"
        Me.Label1.Text = "(単位：千円)"
        Me.Label1.Top = 0.372441!
        Me.Label1.Width = 0.8657475!
        '
        'grpFtr計
        '
        Me.grpFtr計.Height = 0.0!
        Me.grpFtr計.Name = "grpFtr計"
        '
        'lbl4月
        '
        Me.lbl4月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl4月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl4月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl4月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl4月.CharacterSpacing = 10.0!
        Me.lbl4月.Height = 0.1968504!
        Me.lbl4月.HyperLink = Nothing
        Me.lbl4月.Left = 2.913386!
        Me.lbl4月.Name = "lbl4月"
        Me.lbl4月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl4月.Text = "4月"
        Me.lbl4月.Top = 0.8110237!
        Me.lbl4月.Width = 0.8464568!
        '
        'lbl6月
        '
        Me.lbl6月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl6月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl6月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl6月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl6月.CharacterSpacing = 10.0!
        Me.lbl6月.Height = 0.1968504!
        Me.lbl6月.HyperLink = Nothing
        Me.lbl6月.Left = 4.606299!
        Me.lbl6月.Name = "lbl6月"
        Me.lbl6月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl6月.Text = "6月"
        Me.lbl6月.Top = 0.8110237!
        Me.lbl6月.Width = 0.8661417!
        '
        'lbl1月
        '
        Me.lbl1月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1月.CharacterSpacing = 10.0!
        Me.lbl1月.Height = 0.1968504!
        Me.lbl1月.HyperLink = Nothing
        Me.lbl1月.Left = 10.64961!
        Me.lbl1月.Name = "lbl1月"
        Me.lbl1月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl1月.Text = "1月"
        Me.lbl1月.Top = 0.8110237!
        Me.lbl1月.Width = 0.8464569!
        '
        'lbl5月
        '
        Me.lbl5月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl5月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl5月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl5月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl5月.CharacterSpacing = 10.0!
        Me.lbl5月.Height = 0.1968504!
        Me.lbl5月.HyperLink = Nothing
        Me.lbl5月.Left = 3.759843!
        Me.lbl5月.Name = "lbl5月"
        Me.lbl5月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl5月.Text = "5月"
        Me.lbl5月.Top = 0.8110237!
        Me.lbl5月.Width = 0.8464569!
        '
        'lbl7月
        '
        Me.lbl7月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl7月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl7月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl7月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl7月.CharacterSpacing = 10.0!
        Me.lbl7月.Height = 0.1968504!
        Me.lbl7月.HyperLink = Nothing
        Me.lbl7月.Left = 5.472441!
        Me.lbl7月.Name = "lbl7月"
        Me.lbl7月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl7月.Text = "7月"
        Me.lbl7月.Top = 0.8110237!
        Me.lbl7月.Width = 0.8464569!
        '
        'lbl3月
        '
        Me.lbl3月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl3月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl3月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl3月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl3月.CharacterSpacing = 10.0!
        Me.lbl3月.Height = 0.1968504!
        Me.lbl3月.HyperLink = Nothing
        Me.lbl3月.Left = 12.3622!
        Me.lbl3月.Name = "lbl3月"
        Me.lbl3月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl3月.Text = "3月"
        Me.lbl3月.Top = 0.8110237!
        Me.lbl3月.Width = 0.8661417!
        '
        'lbl12月
        '
        Me.lbl12月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl12月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl12月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl12月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl12月.CharacterSpacing = 10.0!
        Me.lbl12月.Height = 0.1968504!
        Me.lbl12月.HyperLink = Nothing
        Me.lbl12月.Left = 9.783464!
        Me.lbl12月.Name = "lbl12月"
        Me.lbl12月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl12月.Text = "12月"
        Me.lbl12月.Top = 0.8110237!
        Me.lbl12月.Width = 0.8661417!
        '
        'lbl9月
        '
        Me.lbl9月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl9月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl9月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl9月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl9月.CharacterSpacing = 10.0!
        Me.lbl9月.Height = 0.1968504!
        Me.lbl9月.HyperLink = Nothing
        Me.lbl9月.Left = 7.18504!
        Me.lbl9月.Name = "lbl9月"
        Me.lbl9月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl9月.Text = "9月"
        Me.lbl9月.Top = 0.8110237!
        Me.lbl9月.Width = 0.8661417!
        '
        'lbl8月
        '
        Me.lbl8月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl8月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl8月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl8月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl8月.CharacterSpacing = 10.0!
        Me.lbl8月.Height = 0.1968504!
        Me.lbl8月.HyperLink = Nothing
        Me.lbl8月.Left = 6.318898!
        Me.lbl8月.Name = "lbl8月"
        Me.lbl8月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl8月.Text = "8月"
        Me.lbl8月.Top = 0.8110237!
        Me.lbl8月.Width = 0.8661417!
        '
        'lbl2月
        '
        Me.lbl2月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2月.CharacterSpacing = 10.0!
        Me.lbl2月.Height = 0.1968504!
        Me.lbl2月.HyperLink = Nothing
        Me.lbl2月.Left = 11.49606!
        Me.lbl2月.Name = "lbl2月"
        Me.lbl2月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl2月.Text = "2月"
        Me.lbl2月.Top = 0.8110237!
        Me.lbl2月.Width = 0.8661417!
        '
        'lbl11月
        '
        Me.lbl11月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl11月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl11月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl11月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl11月.CharacterSpacing = 10.0!
        Me.lbl11月.Height = 0.1968504!
        Me.lbl11月.HyperLink = Nothing
        Me.lbl11月.Left = 8.917323!
        Me.lbl11月.Name = "lbl11月"
        Me.lbl11月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl11月.Text = "11月"
        Me.lbl11月.Top = 0.8110237!
        Me.lbl11月.Width = 0.8661417!
        '
        'lbl10月
        '
        Me.lbl10月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl10月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl10月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl10月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl10月.CharacterSpacing = 10.0!
        Me.lbl10月.Height = 0.1968504!
        Me.lbl10月.HyperLink = Nothing
        Me.lbl10月.Left = 8.051182!
        Me.lbl10月.Name = "lbl10月"
        Me.lbl10月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl10月.Text = "10月"
        Me.lbl10月.Top = 0.8110237!
        Me.lbl10月.Width = 0.8661417!
        '
        'txt対象年月
        '
        Me.txt対象年月.Height = 0.2362205!
        Me.txt対象年月.Left = 10.6685!
        Me.txt対象年月.Name = "txt対象年月"
        Me.txt対象年月.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対象年月.Text = "YY年MM月 現在"
        Me.txt対象年月.Top = 0.3480315!
        Me.txt対象年月.Width = 1.413779!
        '
        'txt7月
        '
        Me.txt7月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt7月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt7月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt7月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt7月.Height = 0.1968504!
        Me.txt7月.Left = 5.472441!
        Me.txt7月.Name = "txt7月"
        Me.txt7月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt7月.Text = "999,999"
        Me.txt7月.Top = 0.0!
        Me.txt7月.Width = 0.8464569!
        '
        'txt8月
        '
        Me.txt8月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt8月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt8月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt8月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt8月.Height = 0.1968504!
        Me.txt8月.Left = 6.318898!
        Me.txt8月.Name = "txt8月"
        Me.txt8月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt8月.Text = "999,999"
        Me.txt8月.Top = 0.0!
        Me.txt8月.Width = 0.8661417!
        '
        'txt9月
        '
        Me.txt9月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt9月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt9月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt9月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt9月.Height = 0.1968504!
        Me.txt9月.Left = 7.18504!
        Me.txt9月.Name = "txt9月"
        Me.txt9月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt9月.Text = "999,999"
        Me.txt9月.Top = 0.0!
        Me.txt9月.Width = 0.8661417!
        '
        'txt10月
        '
        Me.txt10月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt10月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt10月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt10月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt10月.Height = 0.1968504!
        Me.txt10月.Left = 8.051182!
        Me.txt10月.Name = "txt10月"
        Me.txt10月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt10月.Text = "999,999"
        Me.txt10月.Top = 0.0!
        Me.txt10月.Width = 0.8661417!
        '
        'txt11月
        '
        Me.txt11月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt11月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt11月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt11月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt11月.Height = 0.1968504!
        Me.txt11月.Left = 8.917323!
        Me.txt11月.Name = "txt11月"
        Me.txt11月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt11月.Text = "999,999"
        Me.txt11月.Top = 0.00000002980232!
        Me.txt11月.Width = 0.8661417!
        '
        'txt12月
        '
        Me.txt12月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt12月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt12月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt12月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt12月.Height = 0.1968504!
        Me.txt12月.Left = 9.783464!
        Me.txt12月.Name = "txt12月"
        Me.txt12月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt12月.Text = "999,999"
        Me.txt12月.Top = 0.0!
        Me.txt12月.Width = 0.8661417!
        '
        'txt3月
        '
        Me.txt3月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt3月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt3月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3月.Height = 0.1968504!
        Me.txt3月.Left = 12.3622!
        Me.txt3月.Name = "txt3月"
        Me.txt3月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt3月.Text = "999,999"
        Me.txt3月.Top = 0.0!
        Me.txt3月.Width = 0.8661417!
        '
        'txt2月
        '
        Me.txt2月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt2月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2月.Height = 0.1968504!
        Me.txt2月.Left = 11.49606!
        Me.txt2月.Name = "txt2月"
        Me.txt2月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt2月.Text = "999,999"
        Me.txt2月.Top = 0.00000002980232!
        Me.txt2月.Width = 0.8661417!
        '
        'IncomeTran
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 13.22835!
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
        CType(Me.txt4月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt6月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt5月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月累計金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt項目名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月累計構成比, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入金明細表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl当月迄累計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl項目, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl構成比, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt会社名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt法人, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl月次実績推移, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl4月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl6月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl1月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl5月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl7月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl3月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl12月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl9月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl8月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl2月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl11月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl10月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt7月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt8月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt9月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt10月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt11月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt12月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt2月, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt4月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt1月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt6月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt5月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当月累計金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt項目名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当月累計構成比 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt入金明細表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl当月迄累計 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl項目 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl構成比 As DataDynamics.ActiveReports.Label
    Private WithEvents txt会社名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt法人 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl月次実績推移 As DataDynamics.ActiveReports.Label
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents lbl4月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl6月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl1月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl5月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl7月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl3月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl12月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl9月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl8月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl2月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl11月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl10月 As DataDynamics.ActiveReports.Label
    Private WithEvents txt7月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt8月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt9月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt10月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt11月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt12月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt3月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt2月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt対象年月 As DataDynamics.ActiveReports.TextBox
End Class
