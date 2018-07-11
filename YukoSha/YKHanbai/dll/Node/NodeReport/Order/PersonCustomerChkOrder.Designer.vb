<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PersonCustomerChkOrder
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PersonCustomerChkOrder))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt担当者名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt件数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt備考 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先CD = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txt受注日 = New DataDynamics.ActiveReports.TextBox()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注台帳区分名 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl受注 = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先名 = New DataDynamics.ActiveReports.Label()
        Me.lbl金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl受注通数 = New DataDynamics.ActiveReports.Label()
        Me.lbl受注数 = New DataDynamics.ActiveReports.Label()
        Me.ｌｂｌ件数 = New DataDynamics.ActiveReports.Label()
        Me.lbl年月 = New DataDynamics.ActiveReports.Label()
        Me.lbl備考 = New DataDynamics.ActiveReports.Label()
        Me.lbl担当者 = New DataDynamics.ActiveReports.Label()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdrﾌﾚｷ計 = New DataDynamics.ActiveReports.GroupHeader()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox()
        Me.grpFtrﾌﾚｷ計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox()
        Me.txtﾌﾚｷ計金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txtﾌﾚｷ計受注通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txtﾌﾚｷ計受注数 = New DataDynamics.ActiveReports.TextBox()
        Me.txtﾌﾚｷ計件数 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox50 = New DataDynamics.ActiveReports.TextBox()
        Me.txtﾌﾚｷ計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox24 = New DataDynamics.ActiveReports.TextBox()
        Me.Label16 = New DataDynamics.ActiveReports.Label()
        Me.grpHdrオフセット計 = New DataDynamics.ActiveReports.GroupHeader()
        Me.grpFtrオフセット計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtオフセット金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txtオフセット受注通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txtオフセット受注数 = New DataDynamics.ActiveReports.TextBox()
        Me.txtオフセット件数 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox45 = New DataDynamics.ActiveReports.TextBox()
        Me.txtオフセット計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox()
        Me.Label15 = New DataDynamics.ActiveReports.Label()
        Me.grpHdrﾗﾍﾞﾙ総計 = New DataDynamics.ActiveReports.GroupHeader()
        Me.grpFtrﾗﾍﾞﾙ総計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox33 = New DataDynamics.ActiveReports.TextBox()
        Me.txtラベル総計金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txtラベル総計受注通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txtラベル総計受注数 = New DataDynamics.ActiveReports.TextBox()
        Me.txtラベル総計件数 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox38 = New DataDynamics.ActiveReports.TextBox()
        Me.txtラベル総計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox40 = New DataDynamics.ActiveReports.TextBox()
        Me.Label14 = New DataDynamics.ActiveReports.Label()
        Me.grpHdr総合計 = New DataDynamics.ActiveReports.GroupHeader()
        Me.grpFtr総合計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox25 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計受注通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計受注数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計件数 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox30 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox32 = New DataDynamics.ActiveReports.TextBox()
        Me.Label13 = New DataDynamics.ActiveReports.Label()
        Me.grpHdr担当者計 = New DataDynamics.ActiveReports.GroupHeader()
        Me.grpFtr担当者計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox41 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者受注通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者受注数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者件数 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox46 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox48 = New DataDynamics.ActiveReports.TextBox()
        Me.Label11 = New DataDynamics.ActiveReports.Label()
        Me.grpHdrﾗﾍﾞﾙ計 = New DataDynamics.ActiveReports.GroupHeader()
        Me.grpFtrﾗﾍﾞﾙ計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox49 = New DataDynamics.ActiveReports.TextBox()
        Me.txtラベル金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txtラベル受注通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txtラベル受注数 = New DataDynamics.ActiveReports.TextBox()
        Me.txtラベル件数 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox54 = New DataDynamics.ActiveReports.TextBox()
        Me.txtラベル計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox56 = New DataDynamics.ActiveReports.TextBox()
        Me.Label10 = New DataDynamics.ActiveReports.Label()
        CType(Me.txt担当者名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt備考, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注台帳区分名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl受注, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl受注通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ｌｂｌ件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl備考, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl担当者, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtﾌﾚｷ計金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtﾌﾚｷ計受注通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtﾌﾚｷ計受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtﾌﾚｷ計件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtﾌﾚｷ計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtオフセット金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtオフセット受注通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtオフセット受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtオフセット件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtオフセット計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtラベル総計金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtラベル総計受注通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtラベル総計受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtラベル総計件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtラベル総計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計受注通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者受注通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtラベル金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtラベル受注通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtラベル受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtラベル件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtラベル計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt担当者名, Me.txt件数, Me.txt得意先名, Me.txt年月, Me.txt金額, Me.txt受注通数, Me.txt受注数, Me.txt備考, Me.txt担当者CD, Me.txt得意先CD})
        Me.Detail.Height = 0.2755905!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt担当者名
        '
        Me.txt担当者名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者名.Height = 0.2755905!
        Me.txt担当者名.Left = 0.368504!
        Me.txt担当者名.Name = "txt担当者名"
        Me.txt担当者名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者名.Text = "あああああいいい"
        Me.txt担当者名.Top = 0.0!
        Me.txt担当者名.Width = 1.574803!
        '
        'txt件数
        '
        Me.txt件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt件数.Height = 0.2755905!
        Me.txt件数.Left = 5.506299!
        Me.txt件数.Name = "txt件数"
        Me.txt件数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt件数.Text = "999"
        Me.txt件数.Top = 0.0!
        Me.txt件数.Width = 1.003937!
        '
        'txt得意先名
        '
        Me.txt得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Height = 0.2755905!
        Me.txt得意先名.Left = 2.514173!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt得意先名.Text = "あああああいいいいいううううう"
        Me.txt得意先名.Top = 0.0!
        Me.txt得意先名.Width = 2.362205!
        '
        'txt年月
        '
        Me.txt年月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt年月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt年月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt年月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt年月.Height = 0.2755905!
        Me.txt年月.Left = 4.876378!
        Me.txt年月.Name = "txt年月"
        Me.txt年月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt年月.Text = "MM/DD"
        Me.txt年月.Top = 0.0!
        Me.txt年月.Width = 0.6299214!
        '
        'txt金額
        '
        Me.txt金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Height = 0.2755905!
        Me.txt金額.Left = 8.596851!
        Me.txt金額.Name = "txt金額"
        Me.txt金額.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt金額.Text = "999,999,999"
        Me.txt金額.Top = 0.0!
        Me.txt金額.Width = 1.062992!
        '
        'txt受注通数
        '
        Me.txt受注通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注通数.Height = 0.2755905!
        Me.txt受注通数.Left = 7.573229!
        Me.txt受注通数.Name = "txt受注通数"
        Me.txt受注通数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt受注通数.Text = "999,999"
        Me.txt受注通数.Top = 0.0!
        Me.txt受注通数.Width = 1.023623!
        '
        'txt受注数
        '
        Me.txt受注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Height = 0.2755905!
        Me.txt受注数.Left = 6.510237!
        Me.txt受注数.Name = "txt受注数"
        Me.txt受注数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt受注数.Text = "999,999"
        Me.txt受注数.Top = 0.0!
        Me.txt受注数.Width = 1.062992!
        '
        'txt備考
        '
        Me.txt備考.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Height = 0.2755905!
        Me.txt備考.Left = 9.659843!
        Me.txt備考.Name = "txt備考"
        Me.txt備考.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt備考.Text = Nothing
        Me.txt備考.Top = 0.0!
        Me.txt備考.Width = 1.259843!
        '
        'txt担当者CD
        '
        Me.txt担当者CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者CD.Height = 0.2755905!
        Me.txt担当者CD.Left = 0.01417323!
        Me.txt担当者CD.Name = "txt担当者CD"
        Me.txt担当者CD.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者CD.Text = "123"
        Me.txt担当者CD.Top = 0.0!
        Me.txt担当者CD.Width = 0.3543307!
        '
        'txt得意先CD
        '
        Me.txt得意先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Height = 0.2755905!
        Me.txt得意先CD.Left = 1.943307!
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt得意先CD.Text = "123456"
        Me.txt得意先CD.Top = 0.0!
        Me.txt得意先CD.Width = 0.5708662!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt受注日, Me.txtNow, Me.txt頁, Me.txt受注台帳区分名, Me.lbl受注, Me.lbl得意先名, Me.lbl金額, Me.lbl受注通数, Me.lbl受注数, Me.ｌｂｌ件数, Me.lbl年月, Me.lbl備考, Me.lbl担当者})
        Me.PageHeader.Height = 1.119685!
        Me.PageHeader.Name = "PageHeader"
        '
        'txt受注日
        '
        Me.txt受注日.Height = 0.2362205!
        Me.txt受注日.Left = 0.6755906!
        Me.txt受注日.Name = "txt受注日"
        Me.txt受注日.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt受注日.Text = "00/00/00～99/99/99　日迄"
        Me.txt受注日.Top = 0.2598425!
        Me.txt受注日.Width = 2.046457!
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
        'txt受注台帳区分名
        '
        Me.txt受注台帳区分名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt受注台帳区分名.Height = 0.2755905!
        Me.txt受注台帳区分名.Left = 3.179134!
        Me.txt受注台帳区分名.Name = "txt受注台帳区分名"
        Me.txt受注台帳区分名.Style = "font-family: ＭＳ 明朝; font-size: 16pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt受注台帳区分名.Text = "担 当 者 別 得 意 先 別 受 注 集 計 表"
        Me.txt受注台帳区分名.Top = 0.3409449!
        Me.txt受注台帳区分名.Width = 4.619291!
        '
        'lbl受注
        '
        Me.lbl受注.Height = 0.2362205!
        Me.lbl受注.HyperLink = Nothing
        Me.lbl受注.Left = 0.0!
        Me.lbl受注.Name = "lbl受注"
        Me.lbl受注.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl受注.Text = "受注"
        Me.lbl受注.Top = 0.2598425!
        Me.lbl受注.Width = 0.5905512!
        '
        'lbl得意先名
        '
        Me.lbl得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Height = 0.3346457!
        Me.lbl得意先名.HyperLink = Nothing
        Me.lbl得意先名.Left = 1.929134!
        Me.lbl得意先名.Name = "lbl得意先名"
        Me.lbl得意先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl得意先名.Text = "得意先"
        Me.lbl得意先名.Top = 0.7850394!
        Me.lbl得意先名.Width = 2.933071!
        '
        'lbl金額
        '
        Me.lbl金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Height = 0.3346457!
        Me.lbl金額.HyperLink = Nothing
        Me.lbl金額.Left = 8.582677!
        Me.lbl金額.Name = "lbl金額"
        Me.lbl金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl金額.Text = "金額"
        Me.lbl金額.Top = 0.7850394!
        Me.lbl金額.Width = 1.062992!
        '
        'lbl受注通数
        '
        Me.lbl受注通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注通数.Height = 0.3346457!
        Me.lbl受注通数.HyperLink = Nothing
        Me.lbl受注通数.Left = 7.559055!
        Me.lbl受注通数.Name = "lbl受注通数"
        Me.lbl受注通数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl受注通数.Text = "受注通数"
        Me.lbl受注通数.Top = 0.7850394!
        Me.lbl受注通数.Width = 1.023622!
        '
        'lbl受注数
        '
        Me.lbl受注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注数.Height = 0.3346457!
        Me.lbl受注数.HyperLink = Nothing
        Me.lbl受注数.Left = 6.496063!
        Me.lbl受注数.Name = "lbl受注数"
        Me.lbl受注数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl受注数.Text = "受注数"
        Me.lbl受注数.Top = 0.7850394!
        Me.lbl受注数.Width = 1.062992!
        '
        'ｌｂｌ件数
        '
        Me.ｌｂｌ件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ件数.Height = 0.3346457!
        Me.ｌｂｌ件数.HyperLink = Nothing
        Me.ｌｂｌ件数.Left = 5.492126!
        Me.ｌｂｌ件数.Name = "ｌｂｌ件数"
        Me.ｌｂｌ件数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.ｌｂｌ件数.Text = "件数"
        Me.ｌｂｌ件数.Top = 0.7850394!
        Me.ｌｂｌ件数.Width = 1.003937!
        '
        'lbl年月
        '
        Me.lbl年月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl年月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl年月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl年月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl年月.Height = 0.3346457!
        Me.lbl年月.HyperLink = Nothing
        Me.lbl年月.Left = 4.862205!
        Me.lbl年月.Name = "lbl年月"
        Me.lbl年月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl年月.Text = "年月"
        Me.lbl年月.Top = 0.7850394!
        Me.lbl年月.Width = 0.6299213!
        '
        'lbl備考
        '
        Me.lbl備考.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Height = 0.3346457!
        Me.lbl備考.HyperLink = Nothing
        Me.lbl備考.Left = 9.645669!
        Me.lbl備考.Name = "lbl備考"
        Me.lbl備考.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl備考.Text = "備　考"
        Me.lbl備考.Top = 0.7850394!
        Me.lbl備考.Width = 1.259843!
        '
        'lbl担当者
        '
        Me.lbl担当者.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl担当者.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl担当者.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl担当者.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl担当者.Height = 0.3346457!
        Me.lbl担当者.HyperLink = Nothing
        Me.lbl担当者.Left = 0.0000001192093!
        Me.lbl担当者.Name = "lbl担当者"
        Me.lbl担当者.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl担当者.Text = "担当者"
        Me.lbl担当者.Top = 0.7850404!
        Me.lbl担当者.Width = 1.929134!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdrﾌﾚｷ計
        '
        Me.grpHdrﾌﾚｷ計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox3, Me.TextBox4, Me.TextBox8, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox13, Me.TextBox14})
        Me.grpHdrﾌﾚｷ計.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdrﾌﾚｷ計.Height = 0.2755915!
        Me.grpHdrﾌﾚｷ計.Name = "grpHdrﾌﾚｷ計"
        Me.grpHdrﾌﾚｷ計.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.2755906!
        Me.TextBox3.Left = 9.645666!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 1.259842!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Height = 0.2755906!
        Me.TextBox4.Left = 8.582681!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 1.062992!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Height = 0.2755906!
        Me.TextBox8.Left = 7.559056!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 1.023622!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Height = 0.2755906!
        Me.TextBox10.Left = 6.496063!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox10.Text = Nothing
        Me.TextBox10.Top = 0.0!
        Me.TextBox10.Width = 1.062992!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Height = 0.2755906!
        Me.TextBox11.Left = 5.492126!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 0.0!
        Me.TextBox11.Width = 1.003937!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Height = 0.2755906!
        Me.TextBox12.Left = 4.862205!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox12.Text = Nothing
        Me.TextBox12.Top = 0.0!
        Me.TextBox12.Width = 0.6299213!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Height = 0.2755906!
        Me.TextBox13.Left = 1.929134!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox13.Text = "　　　　　　　　　　　　　　(ﾗﾍﾞﾙ)"
        Me.TextBox13.Top = 0.0!
        Me.TextBox13.Width = 2.933071!
        '
        'TextBox14
        '
        Me.TextBox14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Height = 0.2755906!
        Me.TextBox14.Left = 0.0!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox14.Text = Nothing
        Me.TextBox14.Top = 0.0000009536743!
        Me.TextBox14.Width = 1.929134!
        '
        'grpFtrﾌﾚｷ計
        '
        Me.grpFtrﾌﾚｷ計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtﾌﾚｷ計, Me.TextBox17, Me.txtﾌﾚｷ計金額, Me.txtﾌﾚｷ計受注通数, Me.txtﾌﾚｷ計受注数, Me.txtﾌﾚｷ計件数, Me.TextBox50, Me.TextBox24, Me.Label16})
        Me.grpFtrﾌﾚｷ計.Height = 0.2755905!
        Me.grpFtrﾌﾚｷ計.Name = "grpFtrﾌﾚｷ計"
        '
        'TextBox17
        '
        Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Height = 0.2755906!
        Me.TextBox17.Left = 9.645666!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox17.Text = Nothing
        Me.TextBox17.Top = 0.0!
        Me.TextBox17.Width = 1.259842!
        '
        'txtﾌﾚｷ計金額
        '
        Me.txtﾌﾚｷ計金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計金額.Height = 0.2755906!
        Me.txtﾌﾚｷ計金額.Left = 8.582681!
        Me.txtﾌﾚｷ計金額.Name = "txtﾌﾚｷ計金額"
        Me.txtﾌﾚｷ計金額.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtﾌﾚｷ計金額.Text = "999,999,999"
        Me.txtﾌﾚｷ計金額.Top = 0.0!
        Me.txtﾌﾚｷ計金額.Width = 1.062992!
        '
        'txtﾌﾚｷ計受注通数
        '
        Me.txtﾌﾚｷ計受注通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計受注通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計受注通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計受注通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計受注通数.Height = 0.2755906!
        Me.txtﾌﾚｷ計受注通数.Left = 7.559056!
        Me.txtﾌﾚｷ計受注通数.Name = "txtﾌﾚｷ計受注通数"
        Me.txtﾌﾚｷ計受注通数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtﾌﾚｷ計受注通数.Text = "999,999"
        Me.txtﾌﾚｷ計受注通数.Top = 0.0!
        Me.txtﾌﾚｷ計受注通数.Width = 1.023622!
        '
        'txtﾌﾚｷ計受注数
        '
        Me.txtﾌﾚｷ計受注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計受注数.Height = 0.2755906!
        Me.txtﾌﾚｷ計受注数.Left = 6.496063!
        Me.txtﾌﾚｷ計受注数.Name = "txtﾌﾚｷ計受注数"
        Me.txtﾌﾚｷ計受注数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtﾌﾚｷ計受注数.Text = "999,999"
        Me.txtﾌﾚｷ計受注数.Top = 0.0!
        Me.txtﾌﾚｷ計受注数.Width = 1.062992!
        '
        'txtﾌﾚｷ計件数
        '
        Me.txtﾌﾚｷ計件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計件数.Height = 0.2755906!
        Me.txtﾌﾚｷ計件数.Left = 5.492126!
        Me.txtﾌﾚｷ計件数.Name = "txtﾌﾚｷ計件数"
        Me.txtﾌﾚｷ計件数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtﾌﾚｷ計件数.Text = "999"
        Me.txtﾌﾚｷ計件数.Top = 0.0!
        Me.txtﾌﾚｷ計件数.Width = 1.003937!
        '
        'TextBox50
        '
        Me.TextBox50.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox50.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox50.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox50.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox50.Height = 0.2755906!
        Me.TextBox50.Left = 4.862205!
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox50.Text = Nothing
        Me.TextBox50.Top = 0.0!
        Me.TextBox50.Width = 0.6299213!
        '
        'txtﾌﾚｷ計
        '
        Me.txtﾌﾚｷ計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtﾌﾚｷ計.Height = 0.2755906!
        Me.txtﾌﾚｷ計.Left = 1.929134!
        Me.txtﾌﾚｷ計.Name = "txtﾌﾚｷ計"
        Me.txtﾌﾚｷ計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtﾌﾚｷ計.Text = "99件"
        Me.txtﾌﾚｷ計.Top = 0.0!
        Me.txtﾌﾚｷ計.Width = 2.933071!
        '
        'TextBox24
        '
        Me.TextBox24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Height = 0.2755906!
        Me.TextBox24.Left = 0.0!
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox24.Text = Nothing
        Me.TextBox24.Top = 0.0000009536743!
        Me.TextBox24.Width = 1.929134!
        '
        'Label16
        '
        Me.Label16.Height = 0.1968504!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 3.044882!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label16.Text = "＊ﾌﾚｷ計"
        Me.Label16.Top = 0.04094489!
        Me.Label16.Width = 0.7874016!
        '
        'grpHdrオフセット計
        '
        Me.grpHdrオフセット計.Height = 0.0!
        Me.grpHdrオフセット計.Name = "grpHdrオフセット計"
        '
        'grpFtrオフセット計
        '
        Me.grpFtrオフセット計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtオフセット計, Me.TextBox1, Me.txtオフセット金額, Me.txtオフセット受注通数, Me.txtオフセット受注数, Me.txtオフセット件数, Me.TextBox45, Me.TextBox16, Me.Label15})
        Me.grpFtrオフセット計.Height = 0.2755905!
        Me.grpFtrオフセット計.Name = "grpFtrオフセット計"
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.2755906!
        Me.TextBox1.Left = 9.645666!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 1.259842!
        '
        'txtオフセット金額
        '
        Me.txtオフセット金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット金額.Height = 0.2755906!
        Me.txtオフセット金額.Left = 8.582681!
        Me.txtオフセット金額.Name = "txtオフセット金額"
        Me.txtオフセット金額.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtオフセット金額.Text = "999,999,999"
        Me.txtオフセット金額.Top = 0.0!
        Me.txtオフセット金額.Width = 1.062992!
        '
        'txtオフセット受注通数
        '
        Me.txtオフセット受注通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット受注通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット受注通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット受注通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット受注通数.Height = 0.2755906!
        Me.txtオフセット受注通数.Left = 7.559056!
        Me.txtオフセット受注通数.Name = "txtオフセット受注通数"
        Me.txtオフセット受注通数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtオフセット受注通数.Text = "999,999"
        Me.txtオフセット受注通数.Top = 0.0!
        Me.txtオフセット受注通数.Width = 1.023622!
        '
        'txtオフセット受注数
        '
        Me.txtオフセット受注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット受注数.Height = 0.2755906!
        Me.txtオフセット受注数.Left = 6.496063!
        Me.txtオフセット受注数.Name = "txtオフセット受注数"
        Me.txtオフセット受注数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtオフセット受注数.Text = "999,999"
        Me.txtオフセット受注数.Top = 0.0!
        Me.txtオフセット受注数.Width = 1.062992!
        '
        'txtオフセット件数
        '
        Me.txtオフセット件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット件数.Height = 0.2755906!
        Me.txtオフセット件数.Left = 5.492126!
        Me.txtオフセット件数.Name = "txtオフセット件数"
        Me.txtオフセット件数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtオフセット件数.Text = "999"
        Me.txtオフセット件数.Top = 0.0!
        Me.txtオフセット件数.Width = 1.003937!
        '
        'TextBox45
        '
        Me.TextBox45.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox45.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox45.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox45.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox45.Height = 0.2755906!
        Me.TextBox45.Left = 4.862205!
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox45.Text = Nothing
        Me.TextBox45.Top = 0.0!
        Me.TextBox45.Width = 0.6299213!
        '
        'txtオフセット計
        '
        Me.txtオフセット計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオフセット計.Height = 0.2755906!
        Me.txtオフセット計.Left = 1.929134!
        Me.txtオフセット計.Name = "txtオフセット計"
        Me.txtオフセット計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtオフセット計.Text = "99件"
        Me.txtオフセット計.Top = 0.0!
        Me.txtオフセット計.Width = 2.933071!
        '
        'TextBox16
        '
        Me.TextBox16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Height = 0.2755906!
        Me.TextBox16.Left = 0.0!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox16.Text = Nothing
        Me.TextBox16.Top = 0.0000009536743!
        Me.TextBox16.Width = 1.929134!
        '
        'Label15
        '
        Me.Label15.Height = 0.1968504!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 3.044882!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label15.Text = "＊ｵﾌｾｯﾄ計"
        Me.Label15.Top = 0.04094489!
        Me.Label15.Width = 0.7874016!
        '
        'grpHdrﾗﾍﾞﾙ総計
        '
        Me.grpHdrﾗﾍﾞﾙ総計.Height = 0.0!
        Me.grpHdrﾗﾍﾞﾙ総計.Name = "grpHdrﾗﾍﾞﾙ総計"
        '
        'grpFtrﾗﾍﾞﾙ総計
        '
        Me.grpFtrﾗﾍﾞﾙ総計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtラベル総計, Me.TextBox33, Me.txtラベル総計金額, Me.txtラベル総計受注通数, Me.txtラベル総計受注数, Me.txtラベル総計件数, Me.TextBox38, Me.TextBox40, Me.Label14})
        Me.grpFtrﾗﾍﾞﾙ総計.Height = 0.2755905!
        Me.grpFtrﾗﾍﾞﾙ総計.Name = "grpFtrﾗﾍﾞﾙ総計"
        '
        'TextBox33
        '
        Me.TextBox33.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Height = 0.2755906!
        Me.TextBox33.Left = 9.645666!
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox33.Text = Nothing
        Me.TextBox33.Top = 0.0!
        Me.TextBox33.Width = 1.259842!
        '
        'txtラベル総計金額
        '
        Me.txtラベル総計金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計金額.Height = 0.2755906!
        Me.txtラベル総計金額.Left = 8.582681!
        Me.txtラベル総計金額.Name = "txtラベル総計金額"
        Me.txtラベル総計金額.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtラベル総計金額.Text = "999,999,999"
        Me.txtラベル総計金額.Top = 0.0!
        Me.txtラベル総計金額.Width = 1.062992!
        '
        'txtラベル総計受注通数
        '
        Me.txtラベル総計受注通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計受注通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計受注通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計受注通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計受注通数.Height = 0.2755906!
        Me.txtラベル総計受注通数.Left = 7.559056!
        Me.txtラベル総計受注通数.Name = "txtラベル総計受注通数"
        Me.txtラベル総計受注通数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtラベル総計受注通数.Text = "999,999"
        Me.txtラベル総計受注通数.Top = 0.0!
        Me.txtラベル総計受注通数.Width = 1.023622!
        '
        'txtラベル総計受注数
        '
        Me.txtラベル総計受注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計受注数.Height = 0.2755906!
        Me.txtラベル総計受注数.Left = 6.496063!
        Me.txtラベル総計受注数.Name = "txtラベル総計受注数"
        Me.txtラベル総計受注数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtラベル総計受注数.Text = "999,999"
        Me.txtラベル総計受注数.Top = 0.0!
        Me.txtラベル総計受注数.Width = 1.062992!
        '
        'txtラベル総計件数
        '
        Me.txtラベル総計件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計件数.Height = 0.2755906!
        Me.txtラベル総計件数.Left = 5.492126!
        Me.txtラベル総計件数.Name = "txtラベル総計件数"
        Me.txtラベル総計件数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtラベル総計件数.Text = "999"
        Me.txtラベル総計件数.Top = 0.0!
        Me.txtラベル総計件数.Width = 1.003937!
        '
        'TextBox38
        '
        Me.TextBox38.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.Height = 0.2755906!
        Me.TextBox38.Left = 4.862205!
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox38.Text = Nothing
        Me.TextBox38.Top = 0.0!
        Me.TextBox38.Width = 0.6299213!
        '
        'txtラベル総計
        '
        Me.txtラベル総計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル総計.Height = 0.2755906!
        Me.txtラベル総計.Left = 1.929134!
        Me.txtラベル総計.Name = "txtラベル総計"
        Me.txtラベル総計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtラベル総計.Text = "99件"
        Me.txtラベル総計.Top = 0.0!
        Me.txtラベル総計.Width = 2.933071!
        '
        'TextBox40
        '
        Me.TextBox40.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.Height = 0.2755906!
        Me.TextBox40.Left = 0.0!
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox40.Text = Nothing
        Me.TextBox40.Top = 0.0000009536743!
        Me.TextBox40.Width = 1.929134!
        '
        'Label14
        '
        Me.Label14.Height = 0.1968504!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 3.044882!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label14.Text = "＊ﾗﾍﾞﾙ計"
        Me.Label14.Top = 0.04094489!
        Me.Label14.Width = 0.7874016!
        '
        'grpHdr総合計
        '
        Me.grpHdr総合計.Height = 0.0!
        Me.grpHdr総合計.Name = "grpHdr総合計"
        '
        'grpFtr総合計
        '
        Me.grpFtr総合計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt総合計, Me.TextBox25, Me.txt総合計金額, Me.txt総合計受注通数, Me.txt総合計受注数, Me.txt総合計件数, Me.TextBox30, Me.TextBox32, Me.Label13})
        Me.grpFtr総合計.Height = 0.2755905!
        Me.grpFtr総合計.Name = "grpFtr総合計"
        '
        'TextBox25
        '
        Me.TextBox25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Height = 0.2755906!
        Me.TextBox25.Left = 9.645666!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox25.Text = Nothing
        Me.TextBox25.Top = 0.0!
        Me.TextBox25.Width = 1.259842!
        '
        'txt総合計金額
        '
        Me.txt総合計金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計金額.Height = 0.2755906!
        Me.txt総合計金額.Left = 8.582681!
        Me.txt総合計金額.Name = "txt総合計金額"
        Me.txt総合計金額.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt総合計金額.Text = "999,999,999"
        Me.txt総合計金額.Top = 0.0!
        Me.txt総合計金額.Width = 1.062992!
        '
        'txt総合計受注通数
        '
        Me.txt総合計受注通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計受注通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計受注通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計受注通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計受注通数.Height = 0.2755906!
        Me.txt総合計受注通数.Left = 7.559056!
        Me.txt総合計受注通数.Name = "txt総合計受注通数"
        Me.txt総合計受注通数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt総合計受注通数.Text = "999,999"
        Me.txt総合計受注通数.Top = 0.0!
        Me.txt総合計受注通数.Width = 1.023622!
        '
        'txt総合計受注数
        '
        Me.txt総合計受注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計受注数.Height = 0.2755906!
        Me.txt総合計受注数.Left = 6.496063!
        Me.txt総合計受注数.Name = "txt総合計受注数"
        Me.txt総合計受注数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt総合計受注数.Text = "999,999"
        Me.txt総合計受注数.Top = 0.0!
        Me.txt総合計受注数.Width = 1.062992!
        '
        'txt総合計件数
        '
        Me.txt総合計件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計件数.Height = 0.2755906!
        Me.txt総合計件数.Left = 5.492126!
        Me.txt総合計件数.Name = "txt総合計件数"
        Me.txt総合計件数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt総合計件数.Text = "999"
        Me.txt総合計件数.Top = 0.0!
        Me.txt総合計件数.Width = 1.003937!
        '
        'TextBox30
        '
        Me.TextBox30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Height = 0.2755906!
        Me.TextBox30.Left = 4.862205!
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox30.Text = Nothing
        Me.TextBox30.Top = 0.0!
        Me.TextBox30.Width = 0.6299213!
        '
        'txt総合計
        '
        Me.txt総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計.Height = 0.2755906!
        Me.txt総合計.Left = 1.929134!
        Me.txt総合計.Name = "txt総合計"
        Me.txt総合計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt総合計.Text = "99件"
        Me.txt総合計.Top = 0.0!
        Me.txt総合計.Width = 2.933071!
        '
        'TextBox32
        '
        Me.TextBox32.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Height = 0.2755906!
        Me.TextBox32.Left = 0.0!
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox32.Text = Nothing
        Me.TextBox32.Top = 0.0000009536743!
        Me.TextBox32.Width = 1.929134!
        '
        'Label13
        '
        Me.Label13.Height = 0.1968504!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 3.044882!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label13.Text = "＊総合計"
        Me.Label13.Top = 0.02755906!
        Me.Label13.Width = 0.7874016!
        '
        'grpHdr担当者計
        '
        Me.grpHdr担当者計.Height = 0.0!
        Me.grpHdr担当者計.Name = "grpHdr担当者計"
        '
        'grpFtr担当者計
        '
        Me.grpFtr担当者計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt担当者計, Me.TextBox41, Me.txt担当者金額, Me.txt担当者受注通数, Me.txt担当者受注数, Me.txt担当者件数, Me.TextBox46, Me.TextBox48, Me.Label11})
        Me.grpFtr担当者計.Height = 0.2755905!
        Me.grpFtr担当者計.Name = "grpFtr担当者計"
        '
        'TextBox41
        '
        Me.TextBox41.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.Height = 0.2755906!
        Me.TextBox41.Left = 9.645666!
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox41.Text = Nothing
        Me.TextBox41.Top = 0.0!
        Me.TextBox41.Width = 1.259842!
        '
        'txt担当者金額
        '
        Me.txt担当者金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者金額.Height = 0.2755906!
        Me.txt担当者金額.Left = 8.582681!
        Me.txt担当者金額.Name = "txt担当者金額"
        Me.txt担当者金額.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt担当者金額.Text = "999,999,999"
        Me.txt担当者金額.Top = 0.0!
        Me.txt担当者金額.Width = 1.062992!
        '
        'txt担当者受注通数
        '
        Me.txt担当者受注通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者受注通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者受注通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者受注通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者受注通数.Height = 0.2755906!
        Me.txt担当者受注通数.Left = 7.559056!
        Me.txt担当者受注通数.Name = "txt担当者受注通数"
        Me.txt担当者受注通数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt担当者受注通数.Text = "999,999"
        Me.txt担当者受注通数.Top = 0.0!
        Me.txt担当者受注通数.Width = 1.023622!
        '
        'txt担当者受注数
        '
        Me.txt担当者受注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者受注数.Height = 0.2755906!
        Me.txt担当者受注数.Left = 6.496063!
        Me.txt担当者受注数.Name = "txt担当者受注数"
        Me.txt担当者受注数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt担当者受注数.Text = "999,999"
        Me.txt担当者受注数.Top = 0.0!
        Me.txt担当者受注数.Width = 1.062992!
        '
        'txt担当者件数
        '
        Me.txt担当者件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者件数.Height = 0.2755906!
        Me.txt担当者件数.Left = 5.492126!
        Me.txt担当者件数.Name = "txt担当者件数"
        Me.txt担当者件数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt担当者件数.Text = "999"
        Me.txt担当者件数.Top = 0.0!
        Me.txt担当者件数.Width = 1.003937!
        '
        'TextBox46
        '
        Me.TextBox46.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox46.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox46.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox46.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox46.Height = 0.2755906!
        Me.TextBox46.Left = 4.862205!
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox46.Text = Nothing
        Me.TextBox46.Top = 0.0!
        Me.TextBox46.Width = 0.6299213!
        '
        'txt担当者計
        '
        Me.txt担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者計.Height = 0.2755906!
        Me.txt担当者計.Left = 1.929134!
        Me.txt担当者計.Name = "txt担当者計"
        Me.txt担当者計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt担当者計.Text = "99件"
        Me.txt担当者計.Top = 0.0!
        Me.txt担当者計.Width = 2.933071!
        '
        'TextBox48
        '
        Me.TextBox48.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox48.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox48.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox48.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox48.Height = 0.2755906!
        Me.TextBox48.Left = 0.0!
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox48.Text = Nothing
        Me.TextBox48.Top = 0.0000009536743!
        Me.TextBox48.Width = 1.929134!
        '
        'Label11
        '
        Me.Label11.Height = 0.1968504!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 3.044882!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label11.Text = "＊担当者計"
        Me.Label11.Top = 0.04094489!
        Me.Label11.Width = 0.7874016!
        '
        'grpHdrﾗﾍﾞﾙ計
        '
        Me.grpHdrﾗﾍﾞﾙ計.Height = 0.0!
        Me.grpHdrﾗﾍﾞﾙ計.Name = "grpHdrﾗﾍﾞﾙ計"
        '
        'grpFtrﾗﾍﾞﾙ計
        '
        Me.grpFtrﾗﾍﾞﾙ計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtラベル計, Me.TextBox49, Me.txtラベル金額, Me.txtラベル受注通数, Me.txtラベル受注数, Me.txtラベル件数, Me.TextBox54, Me.TextBox56, Me.Label10})
        Me.grpFtrﾗﾍﾞﾙ計.Height = 0.2755905!
        Me.grpFtrﾗﾍﾞﾙ計.Name = "grpFtrﾗﾍﾞﾙ計"
        '
        'TextBox49
        '
        Me.TextBox49.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox49.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox49.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox49.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox49.Height = 0.2755906!
        Me.TextBox49.Left = 9.645666!
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox49.Text = Nothing
        Me.TextBox49.Top = 0.0!
        Me.TextBox49.Width = 1.259842!
        '
        'txtラベル金額
        '
        Me.txtラベル金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル金額.Height = 0.2755906!
        Me.txtラベル金額.Left = 8.582681!
        Me.txtラベル金額.Name = "txtラベル金額"
        Me.txtラベル金額.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtラベル金額.Text = "999,999,999"
        Me.txtラベル金額.Top = 0.0!
        Me.txtラベル金額.Width = 1.062992!
        '
        'txtラベル受注通数
        '
        Me.txtラベル受注通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル受注通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル受注通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル受注通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル受注通数.Height = 0.2755906!
        Me.txtラベル受注通数.Left = 7.559056!
        Me.txtラベル受注通数.Name = "txtラベル受注通数"
        Me.txtラベル受注通数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtラベル受注通数.Text = "999,999"
        Me.txtラベル受注通数.Top = 0.0!
        Me.txtラベル受注通数.Width = 1.023622!
        '
        'txtラベル受注数
        '
        Me.txtラベル受注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル受注数.Height = 0.2755906!
        Me.txtラベル受注数.Left = 6.496063!
        Me.txtラベル受注数.Name = "txtラベル受注数"
        Me.txtラベル受注数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtラベル受注数.Text = "999,999"
        Me.txtラベル受注数.Top = 0.0!
        Me.txtラベル受注数.Width = 1.062992!
        '
        'txtラベル件数
        '
        Me.txtラベル件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル件数.Height = 0.2755906!
        Me.txtラベル件数.Left = 5.492126!
        Me.txtラベル件数.Name = "txtラベル件数"
        Me.txtラベル件数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtラベル件数.Text = "999"
        Me.txtラベル件数.Top = 0.0!
        Me.txtラベル件数.Width = 1.003937!
        '
        'TextBox54
        '
        Me.TextBox54.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox54.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox54.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox54.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox54.Height = 0.2755906!
        Me.TextBox54.Left = 4.862205!
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox54.Text = Nothing
        Me.TextBox54.Top = 0.0!
        Me.TextBox54.Width = 0.6299213!
        '
        'txtラベル計
        '
        Me.txtラベル計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtラベル計.Height = 0.2755906!
        Me.txtラベル計.Left = 1.929134!
        Me.txtラベル計.Name = "txtラベル計"
        Me.txtラベル計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtラベル計.Text = "99件"
        Me.txtラベル計.Top = 0.0!
        Me.txtラベル計.Width = 2.933071!
        '
        'TextBox56
        '
        Me.TextBox56.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox56.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox56.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox56.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox56.Height = 0.2755906!
        Me.TextBox56.Left = 0.0!
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox56.Text = Nothing
        Me.TextBox56.Top = 0.0000009536743!
        Me.TextBox56.Width = 1.929134!
        '
        'Label10
        '
        Me.Label10.Height = 0.1968504!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 3.044882!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label10.Text = "＊ﾗﾍﾞﾙ計"
        Me.Label10.Top = 0.04094489!
        Me.Label10.Width = 0.7874016!
        '
        'PersonCustomerChkOrder
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
        Me.Sections.Add(Me.grpHdrﾌﾚｷ計)
        Me.Sections.Add(Me.grpHdrオフセット計)
        Me.Sections.Add(Me.grpHdrﾗﾍﾞﾙ総計)
        Me.Sections.Add(Me.grpHdr総合計)
        Me.Sections.Add(Me.grpHdr担当者計)
        Me.Sections.Add(Me.grpHdrﾗﾍﾞﾙ計)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtrﾗﾍﾞﾙ計)
        Me.Sections.Add(Me.grpFtr担当者計)
        Me.Sections.Add(Me.grpFtr総合計)
        Me.Sections.Add(Me.grpFtrﾗﾍﾞﾙ総計)
        Me.Sections.Add(Me.grpFtrオフセット計)
        Me.Sections.Add(Me.grpFtrﾌﾚｷ計)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt担当者名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt備考, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注台帳区分名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl受注, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl受注通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ｌｂｌ件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl備考, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl担当者, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtﾌﾚｷ計金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtﾌﾚｷ計受注通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtﾌﾚｷ計受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtﾌﾚｷ計件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtﾌﾚｷ計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtオフセット金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtオフセット受注通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtオフセット受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtオフセット件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtオフセット計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtラベル総計金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtラベル総計受注通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtラベル総計受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtラベル総計件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtラベル総計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計受注通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者受注通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtラベル金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtラベル受注通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtラベル受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtラベル件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtラベル計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents grpHdrﾌﾚｷ計 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents ｌｂｌ件数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl担当者 As DataDynamics.ActiveReports.Label
    Private WithEvents txt担当者名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl年月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl受注数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl受注通数 As DataDynamics.ActiveReports.Label
    Private WithEvents txt件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl金額 As DataDynamics.ActiveReports.Label
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl備考 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtrﾌﾚｷ計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt受注日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt受注通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt受注数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt備考 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt受注台帳区分名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdrオフセット計 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents grpFtrオフセット計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents lbl受注 As DataDynamics.ActiveReports.Label
    Private WithEvents txt担当者CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtﾌﾚｷ計金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtﾌﾚｷ計受注通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtﾌﾚｷ計受注数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtﾌﾚｷ計件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox50 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtﾌﾚｷ計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox24 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtオフセット金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtオフセット受注通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtオフセット受注数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtオフセット件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox45 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtオフセット計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox16 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdrﾗﾍﾞﾙ総計 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents grpFtrﾗﾍﾞﾙ総計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents TextBox33 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtラベル総計金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtラベル総計受注通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtラベル総計受注数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtラベル総計件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox38 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtラベル総計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox40 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr総合計 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents grpFtr総合計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents TextBox25 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計受注通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計受注数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox30 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox32 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr担当者計 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents grpFtr担当者計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents TextBox41 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者受注通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者受注数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox46 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox48 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdrﾗﾍﾞﾙ計 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents grpFtrﾗﾍﾞﾙ計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents TextBox49 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtラベル金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtラベル受注通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtラベル受注数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtラベル件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox54 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtラベル計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox56 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label16 As DataDynamics.ActiveReports.Label
    Private WithEvents Label15 As DataDynamics.ActiveReports.Label
    Private WithEvents Label14 As DataDynamics.ActiveReports.Label
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents Label11 As DataDynamics.ActiveReports.Label
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
End Class
