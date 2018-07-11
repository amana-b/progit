<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DesertLandLabel
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DesertLandLabel))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt日付 = New DataDynamics.ActiveReports.TextBox()
        Me.txt巻数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt2巻数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt3巻数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt4巻数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt5巻数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt6巻数 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txt出金明細表 = New DataDynamics.ActiveReports.TextBox()
        Me.txt出荷先 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.GroupHeader2 = New DataDynamics.ActiveReports.GroupHeader()
        Me.grpFtr枚数計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt6枚数計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt5枚数計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt4枚数計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt3枚数計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt2枚数計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt枚数計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt売上年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt2商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt3商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt4商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt5商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt6商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt6単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txt5単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txt4単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txt3単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txt2単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txt単価 = New DataDynamics.ActiveReports.TextBox()
        Me.grpFtr金額計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt6金額計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt5金額計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt4金額計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt3金額計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt2金額計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt金額計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox23 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.grpFtr巻数計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt6巻数計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt5巻数計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt4巻数計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt3巻数計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt2巻数計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt巻数計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt日付, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt巻数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt2巻数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3巻数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4巻数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt5巻数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt6巻数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt出金明細表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt出荷先, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt6枚数計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt5枚数計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4枚数計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3枚数計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt2枚数計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt枚数計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt売上年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt2商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt5商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt6商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt6単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt5単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt2単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt6金額計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt5金額計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4金額計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3金額計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt2金額計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt金額計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt6巻数計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt5巻数計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt4巻数計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3巻数計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt2巻数計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt巻数計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt日付, Me.txt巻数, Me.txt2巻数, Me.txt3巻数, Me.txt4巻数, Me.txt5巻数, Me.txt6巻数})
        Me.Detail.Height = 0.2559055!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt日付
        '
        Me.txt日付.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt日付.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt日付.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt日付.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt日付.Height = 0.2559055!
        Me.txt日付.Left = 0.0!
        Me.txt日付.Name = "txt日付"
        Me.txt日付.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt日付.Text = "DD日(●)"
        Me.txt日付.Top = 0.0!
        Me.txt日付.Width = 1.023622!
        '
        'txt巻数
        '
        Me.txt巻数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻数.Height = 0.2559055!
        Me.txt巻数.Left = 1.023622!
        Me.txt巻数.Name = "txt巻数"
        Me.txt巻数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt巻数.Text = "99"
        Me.txt巻数.Top = 0.0!
        Me.txt巻数.Width = 1.043307!
        '
        'txt2巻数
        '
        Me.txt2巻数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2巻数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2巻数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2巻数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2巻数.Height = 0.2559055!
        Me.txt2巻数.Left = 2.066929!
        Me.txt2巻数.Name = "txt2巻数"
        Me.txt2巻数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt2巻数.Text = "99"
        Me.txt2巻数.Top = 0.0!
        Me.txt2巻数.Width = 1.043307!
        '
        'txt3巻数
        '
        Me.txt3巻数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3巻数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3巻数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3巻数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3巻数.Height = 0.2559055!
        Me.txt3巻数.Left = 3.110237!
        Me.txt3巻数.Name = "txt3巻数"
        Me.txt3巻数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt3巻数.Text = "99"
        Me.txt3巻数.Top = 0.0!
        Me.txt3巻数.Width = 1.043307!
        '
        'txt4巻数
        '
        Me.txt4巻数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4巻数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4巻数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4巻数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4巻数.Height = 0.2559055!
        Me.txt4巻数.Left = 4.153544!
        Me.txt4巻数.Name = "txt4巻数"
        Me.txt4巻数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt4巻数.Text = "99"
        Me.txt4巻数.Top = 0.0!
        Me.txt4巻数.Width = 1.043307!
        '
        'txt5巻数
        '
        Me.txt5巻数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5巻数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5巻数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5巻数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5巻数.Height = 0.2559055!
        Me.txt5巻数.Left = 5.196851!
        Me.txt5巻数.Name = "txt5巻数"
        Me.txt5巻数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt5巻数.Text = "99"
        Me.txt5巻数.Top = 0.0!
        Me.txt5巻数.Width = 1.043307!
        '
        'txt6巻数
        '
        Me.txt6巻数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt6巻数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt6巻数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt6巻数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt6巻数.Height = 0.2559055!
        Me.txt6巻数.Left = 6.240159!
        Me.txt6巻数.Name = "txt6巻数"
        Me.txt6巻数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt6巻数.Text = "99"
        Me.txt6巻数.Top = 0.0!
        Me.txt6巻数.Width = 1.043307!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt出金明細表, Me.txt出荷先, Me.TextBox14, Me.TextBox22})
        Me.PageHeader.Height = 1.244554!
        Me.PageHeader.Name = "PageHeader"
        '
        'txt出金明細表
        '
        Me.txt出金明細表.Height = 0.3937008!
        Me.txt出金明細表.Left = 2.30315!
        Me.txt出金明細表.Name = "txt出金明細表"
        Me.txt出金明細表.Style = "font-family: ＭＳ Ｐゴシック; font-size: 18pt; font-weight: bold; text-align: center; ve" & _
    "rtical-align: middle; ddo-char-set: 1"
        Me.txt出金明細表.Text = "＜ラベル出荷明細表＞"
        Me.txt出金明細表.Top = 0.0!
        Me.txt出金明細表.Width = 2.681496!
        '
        'txt出荷先
        '
        Me.txt出荷先.Height = 0.2362205!
        Me.txt出荷先.Left = 0.0!
        Me.txt出荷先.Name = "txt出荷先"
        Me.txt出荷先.Style = "font-family: ＭＳ Ｐゴシック; font-size: 14pt; font-weight: bold; text-align: left; vert" & _
    "ical-align: bottom; ddo-char-set: 1"
        Me.txt出荷先.Text = "（株）デザートランド北海道工場　御中"
        Me.txt出荷先.Top = 0.5425197!
        Me.txt出荷先.Width = 3.525591!
        '
        'TextBox14
        '
        Me.TextBox14.Height = 0.2362205!
        Me.TextBox14.Left = 5.922835!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Style = "font-family: ＭＳ Ｐゴシック; font-size: 14pt; font-weight: bold; text-align: right; ver" & _
    "tical-align: bottom; ddo-char-set: 1"
        Me.TextBox14.Text = "（株）友功社"
        Me.TextBox14.Top = 0.6370079!
        Me.TextBox14.Width = 1.181102!
        '
        'TextBox22
        '
        Me.TextBox22.Height = 0.2362205!
        Me.TextBox22.Left = 5.169292!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Style = "font-family: ＭＳ Ｐゴシック; font-size: 11pt; text-align: right; vertical-align: bottom" & _
    "; ddo-char-set: 1"
        Me.TextBox22.Text = "(単位: 1巻＝ 2000枚)"
        Me.TextBox22.Top = 0.9322835!
        Me.TextBox22.Width = 1.954725!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Height = 0.0!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'grpFtr枚数計
        '
        Me.grpFtr枚数計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt6枚数計, Me.txt5枚数計, Me.txt4枚数計, Me.txt3枚数計, Me.txt2枚数計, Me.txt枚数計, Me.TextBox9})
        Me.grpFtr枚数計.Height = 0.2559055!
        Me.grpFtr枚数計.Name = "grpFtr枚数計"
        '
        'txt6枚数計
        '
        Me.txt6枚数計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt6枚数計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt6枚数計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt6枚数計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt6枚数計.Height = 0.2559055!
        Me.txt6枚数計.Left = 6.240159!
        Me.txt6枚数計.Name = "txt6枚数計"
        Me.txt6枚数計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt6枚数計.Text = "999,999"
        Me.txt6枚数計.Top = 0.0!
        Me.txt6枚数計.Width = 1.043307!
        '
        'txt5枚数計
        '
        Me.txt5枚数計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt5枚数計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5枚数計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5枚数計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt5枚数計.Height = 0.2559055!
        Me.txt5枚数計.Left = 5.196851!
        Me.txt5枚数計.Name = "txt5枚数計"
        Me.txt5枚数計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt5枚数計.Text = "999,999"
        Me.txt5枚数計.Top = 0.0!
        Me.txt5枚数計.Width = 1.043307!
        '
        'txt4枚数計
        '
        Me.txt4枚数計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt4枚数計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4枚数計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4枚数計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt4枚数計.Height = 0.2559055!
        Me.txt4枚数計.Left = 4.153544!
        Me.txt4枚数計.Name = "txt4枚数計"
        Me.txt4枚数計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt4枚数計.Text = "999,999"
        Me.txt4枚数計.Top = 0.0!
        Me.txt4枚数計.Width = 1.043307!
        '
        'txt3枚数計
        '
        Me.txt3枚数計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt3枚数計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3枚数計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3枚数計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt3枚数計.Height = 0.2559055!
        Me.txt3枚数計.Left = 3.110237!
        Me.txt3枚数計.Name = "txt3枚数計"
        Me.txt3枚数計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt3枚数計.Text = "999,999"
        Me.txt3枚数計.Top = 0.0!
        Me.txt3枚数計.Width = 1.043307!
        '
        'txt2枚数計
        '
        Me.txt2枚数計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt2枚数計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2枚数計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2枚数計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt2枚数計.Height = 0.2559055!
        Me.txt2枚数計.Left = 2.066929!
        Me.txt2枚数計.Name = "txt2枚数計"
        Me.txt2枚数計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt2枚数計.Text = "999,999"
        Me.txt2枚数計.Top = 0.0!
        Me.txt2枚数計.Width = 1.043307!
        '
        'txt枚数計
        '
        Me.txt枚数計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt枚数計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt枚数計.Height = 0.2559055!
        Me.txt枚数計.Left = 1.023622!
        Me.txt枚数計.Name = "txt枚数計"
        Me.txt枚数計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt枚数計.Text = "999,999"
        Me.txt枚数計.Top = 0.0!
        Me.txt枚数計.Width = 1.043307!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox9.Height = 0.2559055!
        Me.TextBox9.Left = 0.0!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox9.Text = "枚数 計"
        Me.TextBox9.Top = 0.0!
        Me.TextBox9.Width = 1.023622!
        '
        'grpHdr
        '
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt売上年月, Me.txt商品名, Me.txt2商品名, Me.txt3商品名, Me.txt4商品名, Me.txt5商品名, Me.txt6商品名, Me.txt6単価, Me.txt5単価, Me.txt4単価, Me.txt3単価, Me.txt2単価, Me.txt単価})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.7874016!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txt売上年月
        '
        Me.txt売上年月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt売上年月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt売上年月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt売上年月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt売上年月.Height = 0.7874014!
        Me.txt売上年月.Left = 0.0!
        Me.txt売上年月.Name = "txt売上年月"
        Me.txt売上年月.Style = "font-family: ＭＳ Ｐゴシック; font-size: 12pt; text-align: center; vertical-align: top; " & _
    "ddo-char-set: 1"
        Me.txt売上年月.Text = "YYYY年" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MM月"
        Me.txt売上年月.Top = 0.0!
        Me.txt売上年月.Width = 1.023622!
        '
        'txt商品名
        '
        Me.txt商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt商品名.Height = 0.511811!
        Me.txt商品名.Left = 1.023622!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ Ｐゴシック; font-size: 10pt; text-align: center; vertical-align: middl" & _
    "e; ddo-char-set: 1"
        Me.txt商品名.Text = "あああああいいいいい"
        Me.txt商品名.Top = 0.0!
        Me.txt商品名.Width = 1.043307!
        '
        'txt2商品名
        '
        Me.txt2商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt2商品名.Height = 0.511811!
        Me.txt2商品名.Left = 2.066929!
        Me.txt2商品名.Name = "txt2商品名"
        Me.txt2商品名.Style = "font-family: ＭＳ Ｐゴシック; font-size: 10pt; text-align: center; vertical-align: middl" & _
    "e; ddo-char-set: 1"
        Me.txt2商品名.Text = "あああああいいいいい"
        Me.txt2商品名.Top = 0.0!
        Me.txt2商品名.Width = 1.043307!
        '
        'txt3商品名
        '
        Me.txt3商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt3商品名.Height = 0.511811!
        Me.txt3商品名.Left = 3.110237!
        Me.txt3商品名.Name = "txt3商品名"
        Me.txt3商品名.Style = "font-family: ＭＳ Ｐゴシック; font-size: 10pt; text-align: center; vertical-align: middl" & _
    "e; ddo-char-set: 1"
        Me.txt3商品名.Text = "あああああいいいいい"
        Me.txt3商品名.Top = 0.0!
        Me.txt3商品名.Width = 1.043307!
        '
        'txt4商品名
        '
        Me.txt4商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt4商品名.Height = 0.511811!
        Me.txt4商品名.Left = 4.153544!
        Me.txt4商品名.Name = "txt4商品名"
        Me.txt4商品名.Style = "font-family: ＭＳ Ｐゴシック; font-size: 10pt; text-align: center; vertical-align: middl" & _
    "e; ddo-char-set: 1"
        Me.txt4商品名.Text = "あああああいいいいい"
        Me.txt4商品名.Top = 0.0!
        Me.txt4商品名.Width = 1.043307!
        '
        'txt5商品名
        '
        Me.txt5商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt5商品名.Height = 0.511811!
        Me.txt5商品名.Left = 5.196851!
        Me.txt5商品名.Name = "txt5商品名"
        Me.txt5商品名.Style = "font-family: ＭＳ Ｐゴシック; font-size: 10pt; text-align: center; vertical-align: middl" & _
    "e; ddo-char-set: 1"
        Me.txt5商品名.Text = "あああああいいいいい"
        Me.txt5商品名.Top = 0.0!
        Me.txt5商品名.Width = 1.043307!
        '
        'txt6商品名
        '
        Me.txt6商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt6商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt6商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt6商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt6商品名.Height = 0.511811!
        Me.txt6商品名.Left = 6.240159!
        Me.txt6商品名.Name = "txt6商品名"
        Me.txt6商品名.Style = "font-family: ＭＳ Ｐゴシック; font-size: 10pt; text-align: center; vertical-align: middl" & _
    "e; ddo-char-set: 1"
        Me.txt6商品名.Text = "あああああいいいいい"
        Me.txt6商品名.Top = 0.0!
        Me.txt6商品名.Width = 1.043307!
        '
        'txt6単価
        '
        Me.txt6単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt6単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt6単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt6単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt6単価.Height = 0.2755905!
        Me.txt6単価.Left = 6.240159!
        Me.txt6単価.Name = "txt6単価"
        Me.txt6単価.Style = "font-family: ＭＳ Ｐゴシック; font-size: 10pt; text-align: right; vertical-align: middle" & _
    "; ddo-char-set: 1"
        Me.txt6単価.Text = "@999.99"
        Me.txt6単価.Top = 0.511811!
        Me.txt6単価.Width = 1.043307!
        '
        'txt5単価
        '
        Me.txt5単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt5単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5単価.Height = 0.2755905!
        Me.txt5単価.Left = 5.196851!
        Me.txt5単価.Name = "txt5単価"
        Me.txt5単価.Style = "font-family: ＭＳ Ｐゴシック; font-size: 10pt; text-align: right; vertical-align: middle" & _
    "; ddo-char-set: 1"
        Me.txt5単価.Text = "@999.99"
        Me.txt5単価.Top = 0.511811!
        Me.txt5単価.Width = 1.043307!
        '
        'txt4単価
        '
        Me.txt4単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt4単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4単価.Height = 0.2755905!
        Me.txt4単価.Left = 4.153544!
        Me.txt4単価.Name = "txt4単価"
        Me.txt4単価.Style = "font-family: ＭＳ Ｐゴシック; font-size: 10pt; text-align: right; vertical-align: middle" & _
    "; ddo-char-set: 1"
        Me.txt4単価.Text = "@999.99"
        Me.txt4単価.Top = 0.511811!
        Me.txt4単価.Width = 1.043307!
        '
        'txt3単価
        '
        Me.txt3単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt3単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3単価.Height = 0.2755905!
        Me.txt3単価.Left = 3.110237!
        Me.txt3単価.Name = "txt3単価"
        Me.txt3単価.Style = "font-family: ＭＳ Ｐゴシック; font-size: 10pt; text-align: right; vertical-align: middle" & _
    "; ddo-char-set: 1"
        Me.txt3単価.Text = "@999.99"
        Me.txt3単価.Top = 0.511811!
        Me.txt3単価.Width = 1.043307!
        '
        'txt2単価
        '
        Me.txt2単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt2単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2単価.Height = 0.2755905!
        Me.txt2単価.Left = 2.066929!
        Me.txt2単価.Name = "txt2単価"
        Me.txt2単価.Style = "font-family: ＭＳ Ｐゴシック; font-size: 10pt; text-align: right; vertical-align: middle" & _
    "; ddo-char-set: 1"
        Me.txt2単価.Text = "@999.99"
        Me.txt2単価.Top = 0.511811!
        Me.txt2単価.Width = 1.043307!
        '
        'txt単価
        '
        Me.txt単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Height = 0.2755905!
        Me.txt単価.Left = 1.023622!
        Me.txt単価.Name = "txt単価"
        Me.txt単価.Style = "font-family: ＭＳ Ｐゴシック; font-size: 10pt; text-align: right; vertical-align: middle" & _
    "; ddo-char-set: 1"
        Me.txt単価.Text = "@999.99"
        Me.txt単価.Top = 0.511811!
        Me.txt単価.Width = 1.043307!
        '
        'grpFtr金額計
        '
        Me.grpFtr金額計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt6金額計, Me.txt5金額計, Me.txt4金額計, Me.txt3金額計, Me.txt2金額計, Me.txt金額計, Me.TextBox23})
        Me.grpFtr金額計.Height = 0.2559055!
        Me.grpFtr金額計.Name = "grpFtr金額計"
        '
        'txt6金額計
        '
        Me.txt6金額計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt6金額計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt6金額計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt6金額計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt6金額計.Height = 0.2559055!
        Me.txt6金額計.Left = 6.240159!
        Me.txt6金額計.Name = "txt6金額計"
        Me.txt6金額計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt6金額計.Text = "999,999,999"
        Me.txt6金額計.Top = 0.0!
        Me.txt6金額計.Width = 1.043307!
        '
        'txt5金額計
        '
        Me.txt5金額計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt5金額計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5金額計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5金額計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt5金額計.Height = 0.2559055!
        Me.txt5金額計.Left = 5.196851!
        Me.txt5金額計.Name = "txt5金額計"
        Me.txt5金額計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt5金額計.Text = "999,999,999"
        Me.txt5金額計.Top = 0.0!
        Me.txt5金額計.Width = 1.043307!
        '
        'txt4金額計
        '
        Me.txt4金額計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt4金額計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4金額計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4金額計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt4金額計.Height = 0.2559055!
        Me.txt4金額計.Left = 4.153544!
        Me.txt4金額計.Name = "txt4金額計"
        Me.txt4金額計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt4金額計.Text = "999,999,999" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt4金額計.Top = 0.0!
        Me.txt4金額計.Width = 1.043307!
        '
        'txt3金額計
        '
        Me.txt3金額計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt3金額計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3金額計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3金額計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt3金額計.Height = 0.2559055!
        Me.txt3金額計.Left = 3.110237!
        Me.txt3金額計.Name = "txt3金額計"
        Me.txt3金額計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt3金額計.Text = "999,999,999"
        Me.txt3金額計.Top = 0.0!
        Me.txt3金額計.Width = 1.043307!
        '
        'txt2金額計
        '
        Me.txt2金額計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt2金額計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2金額計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2金額計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt2金額計.Height = 0.2559055!
        Me.txt2金額計.Left = 2.066929!
        Me.txt2金額計.Name = "txt2金額計"
        Me.txt2金額計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt2金額計.Text = "999,999,999"
        Me.txt2金額計.Top = 0.0!
        Me.txt2金額計.Width = 1.043307!
        '
        'txt金額計
        '
        Me.txt金額計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt金額計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt金額計.Height = 0.2559055!
        Me.txt金額計.Left = 1.023622!
        Me.txt金額計.Name = "txt金額計"
        Me.txt金額計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt金額計.Text = "999,999,999"
        Me.txt金額計.Top = 0.0!
        Me.txt金額計.Width = 1.043307!
        '
        'TextBox23
        '
        Me.TextBox23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox23.Height = 0.2559055!
        Me.TextBox23.Left = 0.0!
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox23.Text = "金額 計"
        Me.TextBox23.Top = 0.0!
        Me.TextBox23.Width = 1.023622!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'grpFtr巻数計
        '
        Me.grpFtr巻数計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt6巻数計, Me.txt5巻数計, Me.txt4巻数計, Me.txt3巻数計, Me.txt2巻数計, Me.txt巻数計, Me.TextBox5})
        Me.grpFtr巻数計.Height = 0.2559055!
        Me.grpFtr巻数計.Name = "grpFtr巻数計"
        '
        'txt6巻数計
        '
        Me.txt6巻数計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt6巻数計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt6巻数計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt6巻数計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt6巻数計.Height = 0.2559055!
        Me.txt6巻数計.Left = 6.240159!
        Me.txt6巻数計.Name = "txt6巻数計"
        Me.txt6巻数計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt6巻数計.Text = "999"
        Me.txt6巻数計.Top = 0.0!
        Me.txt6巻数計.Width = 1.043307!
        '
        'txt5巻数計
        '
        Me.txt5巻数計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt5巻数計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5巻数計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt5巻数計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt5巻数計.Height = 0.2559055!
        Me.txt5巻数計.Left = 5.196851!
        Me.txt5巻数計.Name = "txt5巻数計"
        Me.txt5巻数計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt5巻数計.Text = "999"
        Me.txt5巻数計.Top = 0.0!
        Me.txt5巻数計.Width = 1.043307!
        '
        'txt4巻数計
        '
        Me.txt4巻数計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt4巻数計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4巻数計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt4巻数計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt4巻数計.Height = 0.2559055!
        Me.txt4巻数計.Left = 4.153544!
        Me.txt4巻数計.Name = "txt4巻数計"
        Me.txt4巻数計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt4巻数計.Text = "999"
        Me.txt4巻数計.Top = 0.0!
        Me.txt4巻数計.Width = 1.043307!
        '
        'txt3巻数計
        '
        Me.txt3巻数計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt3巻数計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3巻数計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt3巻数計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt3巻数計.Height = 0.2559055!
        Me.txt3巻数計.Left = 3.110237!
        Me.txt3巻数計.Name = "txt3巻数計"
        Me.txt3巻数計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt3巻数計.Text = "999"
        Me.txt3巻数計.Top = 0.0!
        Me.txt3巻数計.Width = 1.043307!
        '
        'txt2巻数計
        '
        Me.txt2巻数計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt2巻数計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2巻数計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt2巻数計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt2巻数計.Height = 0.2559055!
        Me.txt2巻数計.Left = 2.066929!
        Me.txt2巻数計.Name = "txt2巻数計"
        Me.txt2巻数計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt2巻数計.Text = "999"
        Me.txt2巻数計.Top = 0.0!
        Me.txt2巻数計.Width = 1.043307!
        '
        'txt巻数計
        '
        Me.txt巻数計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt巻数計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻数計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻数計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt巻数計.Height = 0.2559055!
        Me.txt巻数計.Left = 1.023622!
        Me.txt巻数計.Name = "txt巻数計"
        Me.txt巻数計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt巻数計.Text = "999"
        Me.txt巻数計.Top = 0.0!
        Me.txt巻数計.Width = 1.043307!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox5.Height = 0.2559055!
        Me.TextBox5.Left = 0.0!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox5.Text = "巻数 計"
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 1.023622!
        '
        'DesertLandLabel
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.283465!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr)
        Me.Sections.Add(Me.GroupHeader2)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr巻数計)
        Me.Sections.Add(Me.grpFtr枚数計)
        Me.Sections.Add(Me.grpFtr金額計)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt日付, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt巻数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt2巻数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3巻数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4巻数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt5巻数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt6巻数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt出金明細表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt出荷先, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt6枚数計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt5枚数計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4枚数計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3枚数計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt2枚数計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt枚数計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt売上年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt2商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt5商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt6商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt6単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt5単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt2単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt6金額計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt5金額計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4金額計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3金額計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt2金額計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt金額計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt6巻数計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt5巻数計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt4巻数計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3巻数計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt2巻数計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt巻数計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt日付 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt巻数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader2 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents grpFtr枚数計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt出金明細表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpFtr金額計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents grpFtr巻数計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt6巻数計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt5巻数計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt4巻数計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt3巻数計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt2巻数計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt巻数計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt6枚数計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt5枚数計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt4枚数計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt3枚数計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt2枚数計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt枚数計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt6金額計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt5金額計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt4金額計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt3金額計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt2金額計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt金額計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox23 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt出荷先 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt2巻数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt3巻数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt4巻数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt5巻数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt6巻数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt売上年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt2商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt3商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt4商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt5商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt6商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt6単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt5単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt4単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt3単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt2単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt単価 As DataDynamics.ActiveReports.TextBox
End Class
