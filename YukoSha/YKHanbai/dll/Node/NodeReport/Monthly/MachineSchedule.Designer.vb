<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MachineSchedule
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MachineSchedule))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt仕入 = New DataDynamics.ActiveReports.TextBox()
        Me.txtクレーム金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt機械名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt版交換回数 = New DataDynamics.ActiveReports.TextBox()
        Me.txtクレーム数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt粗利 = New DataDynamics.ActiveReports.TextBox()
        Me.txt売上 = New DataDynamics.ActiveReports.TextBox()
        Me.txt原価決定済件数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt利益 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数m = New DataDynamics.ActiveReports.TextBox()
        Me.txt固定経費 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt対象年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者別未引当一覧表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl仕入 = New DataDynamics.ActiveReports.Label()
        Me.lblクレーム金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl版交換回数 = New DataDynamics.ActiveReports.Label()
        Me.lbl機械名 = New DataDynamics.ActiveReports.Label()
        Me.lbl通数 = New DataDynamics.ActiveReports.Label()
        Me.lblクレーム数 = New DataDynamics.ActiveReports.Label()
        Me.lbl粗利 = New DataDynamics.ActiveReports.Label()
        Me.lbl売上 = New DataDynamics.ActiveReports.Label()
        Me.lbl原価決定済件数 = New DataDynamics.ActiveReports.Label()
        Me.lbl利益 = New DataDynamics.ActiveReports.Label()
        Me.lbl固定経費 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.txtクレーム金額合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txtクレーム数合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt版交換回数合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt売上合計 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.txt粗利合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt原価決定済件数合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt利益合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数m合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt固定経費合計 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt利益分類計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt原価決定済件数分類計 = New DataDynamics.ActiveReports.TextBox()
        Me.txtクレーム金額分類計 = New DataDynamics.ActiveReports.TextBox()
        Me.txtクレーム数分類計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt売上分類計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt粗利分類計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt版交換回数分類計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox31 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入分類計 = New DataDynamics.ActiveReports.TextBox()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.txt通数分類計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数m分類計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕固定経費分類計 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt仕入, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtクレーム金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt機械名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt版交換回数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtクレーム数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt粗利, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt売上, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt原価決定済件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt利益, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数m, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt固定経費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者別未引当一覧表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblクレーム金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl版交換回数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl機械名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblクレーム数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl粗利, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl売上, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl原価決定済件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl利益, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl固定経費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtクレーム金額合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtクレーム数合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt版交換回数合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt売上合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt粗利合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt原価決定済件数合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt利益合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数m合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt固定経費合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt利益分類計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt原価決定済件数分類計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtクレーム金額分類計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtクレーム数分類計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt売上分類計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt粗利分類計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt版交換回数分類計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入分類計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数分類計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数m分類計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕固定経費分類計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt仕入, Me.txtクレーム金額, Me.txt通数, Me.txt機械名, Me.txt版交換回数, Me.txtクレーム数, Me.txt粗利, Me.txt売上, Me.txt原価決定済件数, Me.txt利益, Me.txt通数m, Me.txt固定経費})
        Me.Detail.Height = 0.2755905!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt仕入
        '
        Me.txt仕入.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入.Height = 0.2755905!
        Me.txt仕入.Left = 3.681102!
        Me.txt仕入.Name = "txt仕入"
        Me.txt仕入.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt仕入.Text = "999,999,999"
        Me.txt仕入.Top = 0.0!
        Me.txt仕入.Width = 0.9055118!
        '
        'txtクレーム金額
        '
        Me.txtクレーム金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム金額.Height = 0.2755905!
        Me.txtクレーム金額.Left = 8.326772!
        Me.txtクレーム金額.Name = "txtクレーム金額"
        Me.txtクレーム金額.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtクレーム金額.Text = "999,999,999"
        Me.txtクレーム金額.Top = 0.000001132488!
        Me.txtクレーム金額.Width = 1.535433!
        '
        'txt通数
        '
        Me.txt通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数.Height = 0.1377953!
        Me.txt通数.Left = 0.984252!
        Me.txt通数.Name = "txt通数"
        Me.txt通数.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt通数.Text = "999,999,999通"
        Me.txt通数.Top = 0.0000002980233!
        Me.txt通数.Width = 0.8661417!
        '
        'txt機械名
        '
        Me.txt機械名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt機械名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt機械名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt機械名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt機械名.Height = 0.2755905!
        Me.txt機械名.Left = 0.0!
        Me.txt機械名.Name = "txt機械名"
        Me.txt機械名.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt機械名.Text = "あああああ"
        Me.txt機械名.Top = 0.00000005960464!
        Me.txt機械名.Width = 0.984252!
        '
        'txt版交換回数
        '
        Me.txt版交換回数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版交換回数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版交換回数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版交換回数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版交換回数.Height = 0.2755905!
        Me.txt版交換回数.Left = 1.850394!
        Me.txt版交換回数.Name = "txt版交換回数"
        Me.txt版交換回数.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt版交換回数.Text = "999回"
        Me.txt版交換回数.Top = 0.0000001192093!
        Me.txt版交換回数.Width = 0.9055118!
        '
        'txtクレーム数
        '
        Me.txtクレーム数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム数.Height = 0.2755905!
        Me.txtクレーム数.Left = 7.34252!
        Me.txtクレーム数.Name = "txtクレーム数"
        Me.txtクレーム数.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtクレーム数.Text = "999"
        Me.txtクレーム数.Top = 0.0000002980233!
        Me.txtクレーム数.Width = 0.984252!
        '
        'txt粗利
        '
        Me.txt粗利.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利.Height = 0.2755905!
        Me.txt粗利.Left = 4.586614!
        Me.txt粗利.Name = "txt粗利"
        Me.txt粗利.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt粗利.Text = "999,999,999"
        Me.txt粗利.Top = 0.0000002980233!
        Me.txt粗利.Width = 0.9055118!
        '
        'txt売上
        '
        Me.txt売上.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上.Height = 0.2755905!
        Me.txt売上.Left = 2.755905!
        Me.txt売上.Name = "txt売上"
        Me.txt売上.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt売上.Text = "999,999,999"
        Me.txt売上.Top = 0.0000005066395!
        Me.txt売上.Width = 0.9251968!
        '
        'txt原価決定済件数
        '
        Me.txt原価決定済件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原価決定済件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原価決定済件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原価決定済件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原価決定済件数.Height = 0.2755905!
        Me.txt原価決定済件数.Left = 9.862205!
        Me.txt原価決定済件数.Name = "txt原価決定済件数"
        Me.txt原価決定済件数.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt原価決定済件数.Text = "999"
        Me.txt原価決定済件数.Top = 0.0!
        Me.txt原価決定済件数.Width = 0.7874016!
        '
        'txt利益
        '
        Me.txt利益.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益.Height = 0.2755905!
        Me.txt利益.Left = 6.397638!
        Me.txt利益.Name = "txt利益"
        Me.txt利益.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt利益.Text = "999,999,999"
        Me.txt利益.Top = 0.0!
        Me.txt利益.Width = 0.9448819!
        '
        'txt通数m
        '
        Me.txt通数m.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m.Height = 0.1377953!
        Me.txt通数m.Left = 0.984252!
        Me.txt通数m.Name = "txt通数m"
        Me.txt通数m.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt通数m.Text = "999,999m"
        Me.txt通数m.Top = 0.1377956!
        Me.txt通数m.Width = 0.8661417!
        '
        'txt固定経費
        '
        Me.txt固定経費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費.Height = 0.2755905!
        Me.txt固定経費.Left = 5.492126!
        Me.txt固定経費.Name = "txt固定経費"
        Me.txt固定経費.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt固定経費.Text = "999,999,999"
        Me.txt固定経費.Top = 0.0!
        Me.txt固定経費.Width = 0.9055118!
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
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt対象年月, Me.txt担当者別未引当一覧表, Me.lbl仕入, Me.lblクレーム金額, Me.lbl版交換回数, Me.lbl機械名, Me.lbl通数, Me.lblクレーム数, Me.lbl粗利, Me.lbl売上, Me.lbl原価決定済件数, Me.lbl利益, Me.lbl固定経費})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.8283465!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txt対象年月
        '
        Me.txt対象年月.Height = 0.2362205!
        Me.txt対象年月.Left = 0.0!
        Me.txt対象年月.Name = "txt対象年月"
        Me.txt対象年月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対象年月.Text = "YY/MM月分"
        Me.txt対象年月.Top = 0.0!
        Me.txt対象年月.Width = 1.181102!
        '
        'txt担当者別未引当一覧表
        '
        Me.txt担当者別未引当一覧表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt担当者別未引当一覧表.CharacterSpacing = 10.0!
        Me.txt担当者別未引当一覧表.Height = 0.3196851!
        Me.txt担当者別未引当一覧表.Left = 3.562205!
        Me.txt担当者別未引当一覧表.Name = "txt担当者別未引当一覧表"
        Me.txt担当者別未引当一覧表.Style = "font-family: ＭＳ Ｐゴシック; font-size: 14pt; font-weight: bold; text-align: center; ve" & _
    "rtical-align: bottom; ddo-char-set: 1"
        Me.txt担当者別未引当一覧表.Text = "機械別集計表"
        Me.txt担当者別未引当一覧表.Top = 0.1133858!
        Me.txt担当者別未引当一覧表.Width = 3.228346!
        '
        'lbl仕入
        '
        Me.lbl仕入.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入.Height = 0.2559055!
        Me.lbl仕入.HyperLink = Nothing
        Me.lbl仕入.Left = 3.700788!
        Me.lbl仕入.Name = "lbl仕入"
        Me.lbl仕入.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl仕入.Text = "仕入"
        Me.lbl仕入.Top = 0.572441!
        Me.lbl仕入.Width = 0.9055118!
        '
        'lblクレーム金額
        '
        Me.lblクレーム金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblクレーム金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblクレーム金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblクレーム金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblクレーム金額.Height = 0.2559055!
        Me.lblクレーム金額.HyperLink = Nothing
        Me.lblクレーム金額.Left = 8.346457!
        Me.lblクレーム金額.Name = "lblクレーム金額"
        Me.lblクレーム金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lblクレーム金額.Text = "クレーム金額"
        Me.lblクレーム金額.Top = 0.572441!
        Me.lblクレーム金額.Width = 1.535433!
        '
        'lbl版交換回数
        '
        Me.lbl版交換回数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版交換回数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版交換回数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版交換回数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版交換回数.Height = 0.2559055!
        Me.lbl版交換回数.HyperLink = Nothing
        Me.lbl版交換回数.Left = 1.870079!
        Me.lbl版交換回数.Name = "lbl版交換回数"
        Me.lbl版交換回数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl版交換回数.Text = "版交換回数"
        Me.lbl版交換回数.Top = 0.572441!
        Me.lbl版交換回数.Width = 0.9055118!
        '
        'lbl機械名
        '
        Me.lbl機械名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl機械名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl機械名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl機械名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl機械名.Height = 0.2559055!
        Me.lbl機械名.HyperLink = Nothing
        Me.lbl機械名.Left = 0.0!
        Me.lbl機械名.Name = "lbl機械名"
        Me.lbl機械名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7.5pt; text-align: center; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.lbl機械名.Text = "機械名"
        Me.lbl機械名.Top = 0.572441!
        Me.lbl機械名.Width = 0.984252!
        '
        'lbl通数
        '
        Me.lbl通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Height = 0.2559055!
        Me.lbl通数.HyperLink = Nothing
        Me.lbl通数.Left = 0.984252!
        Me.lbl通数.Name = "lbl通数"
        Me.lbl通数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl通数.Text = "通数/m数"
        Me.lbl通数.Top = 0.572441!
        Me.lbl通数.Width = 0.8858268!
        '
        'lblクレーム数
        '
        Me.lblクレーム数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblクレーム数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblクレーム数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblクレーム数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblクレーム数.Height = 0.2559055!
        Me.lblクレーム数.HyperLink = Nothing
        Me.lblクレーム数.Left = 7.362205!
        Me.lblクレーム数.Name = "lblクレーム数"
        Me.lblクレーム数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lblクレーム数.Text = "クレーム数"
        Me.lblクレーム数.Top = 0.572441!
        Me.lblクレーム数.Width = 0.984252!
        '
        'lbl粗利
        '
        Me.lbl粗利.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Height = 0.2559055!
        Me.lbl粗利.HyperLink = Nothing
        Me.lbl粗利.Left = 4.606299!
        Me.lbl粗利.Name = "lbl粗利"
        Me.lbl粗利.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl粗利.Text = "粗利"
        Me.lbl粗利.Top = 0.572441!
        Me.lbl粗利.Width = 0.9055118!
        '
        'lbl売上
        '
        Me.lbl売上.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上.CharacterSpacing = 5.0!
        Me.lbl売上.Height = 0.2559055!
        Me.lbl売上.HyperLink = Nothing
        Me.lbl売上.Left = 2.775591!
        Me.lbl売上.Name = "lbl売上"
        Me.lbl売上.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl売上.Text = "売上"
        Me.lbl売上.Top = 0.572441!
        Me.lbl売上.Width = 0.9251968!
        '
        'lbl原価決定済件数
        '
        Me.lbl原価決定済件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl原価決定済件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl原価決定済件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl原価決定済件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl原価決定済件数.Height = 0.2559055!
        Me.lbl原価決定済件数.HyperLink = Nothing
        Me.lbl原価決定済件数.Left = 9.881889!
        Me.lbl原価決定済件数.Name = "lbl原価決定済件数"
        Me.lbl原価決定済件数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7.5pt; text-align: center; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.lbl原価決定済件数.Text = "原価決定済件数"
        Me.lbl原価決定済件数.Top = 0.572441!
        Me.lbl原価決定済件数.Width = 0.7874016!
        '
        'lbl利益
        '
        Me.lbl利益.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益.Height = 0.2559055!
        Me.lbl利益.HyperLink = Nothing
        Me.lbl利益.Left = 6.417323!
        Me.lbl利益.Name = "lbl利益"
        Me.lbl利益.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl利益.Text = "利益"
        Me.lbl利益.Top = 0.5724409!
        Me.lbl利益.Width = 0.9448819!
        '
        'lbl固定経費
        '
        Me.lbl固定経費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl固定経費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl固定経費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl固定経費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl固定経費.Height = 0.2559055!
        Me.lbl固定経費.HyperLink = Nothing
        Me.lbl固定経費.Left = 5.511811!
        Me.lbl固定経費.Name = "lbl固定経費"
        Me.lbl固定経費.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl固定経費.Text = "固定経費"
        Me.lbl固定経費.Top = 0.572441!
        Me.lbl固定経費.Width = 0.9055118!
        '
        'grpFtr計
        '
        Me.grpFtr計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox19, Me.txtクレーム金額合計, Me.txtクレーム数合計, Me.txt版交換回数合計, Me.txt売上合計, Me.Label2, Me.txt粗利合計, Me.txt仕入合計, Me.txt原価決定済件数合計, Me.txt利益合計, Me.txt通数合計, Me.txt通数m合計, Me.txt固定経費合計})
        Me.grpFtr計.Height = 0.2755905!
        Me.grpFtr計.Name = "grpFtr計"
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Height = 0.2755905!
        Me.TextBox19.Left = 0.0!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox19.Text = Nothing
        Me.TextBox19.Top = 0.00000005960464!
        Me.TextBox19.Width = 0.984252!
        '
        'txtクレーム金額合計
        '
        Me.txtクレーム金額合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム金額合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム金額合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム金額合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム金額合計.Height = 0.2755905!
        Me.txtクレーム金額合計.Left = 8.326772!
        Me.txtクレーム金額合計.Name = "txtクレーム金額合計"
        Me.txtクレーム金額合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtクレーム金額合計.Text = "999,999,999"
        Me.txtクレーム金額合計.Top = 0.0!
        Me.txtクレーム金額合計.Width = 1.535433!
        '
        'txtクレーム数合計
        '
        Me.txtクレーム数合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム数合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム数合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム数合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム数合計.Height = 0.2755905!
        Me.txtクレーム数合計.Left = 7.34252!
        Me.txtクレーム数合計.Name = "txtクレーム数合計"
        Me.txtクレーム数合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtクレーム数合計.Text = "999"
        Me.txtクレーム数合計.Top = 0.0!
        Me.txtクレーム数合計.Width = 0.984252!
        '
        'txt版交換回数合計
        '
        Me.txt版交換回数合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版交換回数合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版交換回数合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版交換回数合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版交換回数合計.Height = 0.2755905!
        Me.txt版交換回数合計.Left = 1.850394!
        Me.txt版交換回数合計.Name = "txt版交換回数合計"
        Me.txt版交換回数合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt版交換回数合計.Text = "999回"
        Me.txt版交換回数合計.Top = 0.0000001192093!
        Me.txt版交換回数合計.Width = 0.9055118!
        '
        'txt売上合計
        '
        Me.txt売上合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上合計.Height = 0.2755905!
        Me.txt売上合計.Left = 2.755905!
        Me.txt売上合計.Name = "txt売上合計"
        Me.txt売上合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: left; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt売上合計.Text = "999,999,999"
        Me.txt売上合計.Top = 0.0000005066395!
        Me.txt売上合計.Width = 0.9251968!
        '
        'Label2
        '
        Me.Label2.Height = 0.1771654!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.3275591!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label2.Text = "＊合計"
        Me.Label2.Top = 0.05118111!
        Me.Label2.Width = 0.5905512!
        '
        'txt粗利合計
        '
        Me.txt粗利合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利合計.Height = 0.2755905!
        Me.txt粗利合計.Left = 4.586614!
        Me.txt粗利合計.Name = "txt粗利合計"
        Me.txt粗利合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt粗利合計.Text = "999,999,999"
        Me.txt粗利合計.Top = 0.0!
        Me.txt粗利合計.Width = 0.9055118!
        '
        'txt仕入合計
        '
        Me.txt仕入合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計.Height = 0.2755905!
        Me.txt仕入合計.Left = 3.681102!
        Me.txt仕入合計.Name = "txt仕入合計"
        Me.txt仕入合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入合計.Text = "999,999,999"
        Me.txt仕入合計.Top = 0.0!
        Me.txt仕入合計.Width = 0.9055118!
        '
        'txt原価決定済件数合計
        '
        Me.txt原価決定済件数合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原価決定済件数合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原価決定済件数合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原価決定済件数合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原価決定済件数合計.Height = 0.2755905!
        Me.txt原価決定済件数合計.Left = 9.862205!
        Me.txt原価決定済件数合計.Name = "txt原価決定済件数合計"
        Me.txt原価決定済件数合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt原価決定済件数合計.Text = "999"
        Me.txt原価決定済件数合計.Top = 0.0!
        Me.txt原価決定済件数合計.Width = 0.7874016!
        '
        'txt利益合計
        '
        Me.txt利益合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益合計.Height = 0.2755905!
        Me.txt利益合計.Left = 6.397638!
        Me.txt利益合計.Name = "txt利益合計"
        Me.txt利益合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt利益合計.Text = "999,999,999"
        Me.txt利益合計.Top = 0.0!
        Me.txt利益合計.Width = 0.9448819!
        '
        'txt通数合計
        '
        Me.txt通数合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数合計.Height = 0.1377953!
        Me.txt通数合計.Left = 0.984252!
        Me.txt通数合計.Name = "txt通数合計"
        Me.txt通数合計.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt通数合計.Text = "999,999,999通"
        Me.txt通数合計.Top = 0.0!
        Me.txt通数合計.Width = 0.8661417!
        '
        'txt通数m合計
        '
        Me.txt通数m合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m合計.Height = 0.1377953!
        Me.txt通数m合計.Left = 0.984252!
        Me.txt通数m合計.Name = "txt通数m合計"
        Me.txt通数m合計.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt通数m合計.Text = "999,999m"
        Me.txt通数m合計.Top = 0.1377953!
        Me.txt通数m合計.Width = 0.8661417!
        '
        'txt固定経費合計
        '
        Me.txt固定経費合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費合計.Height = 0.2755905!
        Me.txt固定経費合計.Left = 5.492126!
        Me.txt固定経費合計.Name = "txt固定経費合計"
        Me.txt固定経費合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt固定経費合計.Text = "999,999,999"
        Me.txt固定経費合計.Top = 0.0!
        Me.txt固定経費合計.Width = 0.9055118!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt利益分類計, Me.txt原価決定済件数分類計, Me.txtクレーム金額分類計, Me.txtクレーム数分類計, Me.txt売上分類計, Me.txt粗利分類計, Me.txt版交換回数分類計, Me.TextBox31, Me.txt仕入分類計, Me.Label3, Me.txt通数分類計, Me.txt通数m分類計, Me.txt仕固定経費分類計})
        Me.GroupFooter1.Height = 0.2755905!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'txt利益分類計
        '
        Me.txt利益分類計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益分類計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益分類計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益分類計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益分類計.Height = 0.2755905!
        Me.txt利益分類計.Left = 6.397638!
        Me.txt利益分類計.Name = "txt利益分類計"
        Me.txt利益分類計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt利益分類計.Text = "999,999,999"
        Me.txt利益分類計.Top = 0.0!
        Me.txt利益分類計.Width = 0.9448819!
        '
        'txt原価決定済件数分類計
        '
        Me.txt原価決定済件数分類計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原価決定済件数分類計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原価決定済件数分類計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原価決定済件数分類計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原価決定済件数分類計.Height = 0.2755905!
        Me.txt原価決定済件数分類計.Left = 9.862205!
        Me.txt原価決定済件数分類計.Name = "txt原価決定済件数分類計"
        Me.txt原価決定済件数分類計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt原価決定済件数分類計.Text = "999"
        Me.txt原価決定済件数分類計.Top = 0.0!
        Me.txt原価決定済件数分類計.Width = 0.7874016!
        '
        'txtクレーム金額分類計
        '
        Me.txtクレーム金額分類計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム金額分類計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム金額分類計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム金額分類計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム金額分類計.Height = 0.2755905!
        Me.txtクレーム金額分類計.Left = 8.326772!
        Me.txtクレーム金額分類計.Name = "txtクレーム金額分類計"
        Me.txtクレーム金額分類計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtクレーム金額分類計.Text = "999,999,999"
        Me.txtクレーム金額分類計.Top = 0.0!
        Me.txtクレーム金額分類計.Width = 1.535433!
        '
        'txtクレーム数分類計
        '
        Me.txtクレーム数分類計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム数分類計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム数分類計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム数分類計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム数分類計.Height = 0.2755905!
        Me.txtクレーム数分類計.Left = 7.34252!
        Me.txtクレーム数分類計.Name = "txtクレーム数分類計"
        Me.txtクレーム数分類計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtクレーム数分類計.Text = "999"
        Me.txtクレーム数分類計.Top = 0.0!
        Me.txtクレーム数分類計.Width = 0.984252!
        '
        'txt売上分類計
        '
        Me.txt売上分類計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上分類計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上分類計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上分類計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上分類計.Height = 0.2755905!
        Me.txt売上分類計.Left = 2.755905!
        Me.txt売上分類計.Name = "txt売上分類計"
        Me.txt売上分類計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: left; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt売上分類計.Text = "999,999,999"
        Me.txt売上分類計.Top = 0.0000005066395!
        Me.txt売上分類計.Width = 0.9251968!
        '
        'txt粗利分類計
        '
        Me.txt粗利分類計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利分類計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利分類計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利分類計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利分類計.Height = 0.2755905!
        Me.txt粗利分類計.Left = 4.586614!
        Me.txt粗利分類計.Name = "txt粗利分類計"
        Me.txt粗利分類計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt粗利分類計.Text = "999,999,999"
        Me.txt粗利分類計.Top = 0.0!
        Me.txt粗利分類計.Width = 0.9055118!
        '
        'txt版交換回数分類計
        '
        Me.txt版交換回数分類計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版交換回数分類計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版交換回数分類計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版交換回数分類計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版交換回数分類計.Height = 0.2755905!
        Me.txt版交換回数分類計.Left = 1.850394!
        Me.txt版交換回数分類計.Name = "txt版交換回数分類計"
        Me.txt版交換回数分類計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt版交換回数分類計.Text = "999回"
        Me.txt版交換回数分類計.Top = 0.0000001192093!
        Me.txt版交換回数分類計.Width = 0.9055118!
        '
        'TextBox31
        '
        Me.TextBox31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Height = 0.2755905!
        Me.TextBox31.Left = 0.0!
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox31.Text = Nothing
        Me.TextBox31.Top = 0.00000005960464!
        Me.TextBox31.Width = 0.984252!
        '
        'txt仕入分類計
        '
        Me.txt仕入分類計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入分類計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入分類計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入分類計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入分類計.Height = 0.2755905!
        Me.txt仕入分類計.Left = 3.681102!
        Me.txt仕入分類計.Name = "txt仕入分類計"
        Me.txt仕入分類計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入分類計.Text = "999,999,999"
        Me.txt仕入分類計.Top = 0.0!
        Me.txt仕入分類計.Width = 0.9055118!
        '
        'Label3
        '
        Me.Label3.Height = 0.1771654!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.3275591!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label3.Text = "＊分類計"
        Me.Label3.Top = 0.03070866!
        Me.Label3.Width = 0.5905512!
        '
        'txt通数分類計
        '
        Me.txt通数分類計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数分類計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数分類計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数分類計.Height = 0.1377953!
        Me.txt通数分類計.Left = 0.984252!
        Me.txt通数分類計.Name = "txt通数分類計"
        Me.txt通数分類計.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt通数分類計.Text = "999,999,999通"
        Me.txt通数分類計.Top = 0.0!
        Me.txt通数分類計.Width = 0.8661417!
        '
        'txt通数m分類計
        '
        Me.txt通数m分類計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m分類計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m分類計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m分類計.Height = 0.1377953!
        Me.txt通数m分類計.Left = 0.984252!
        Me.txt通数m分類計.Name = "txt通数m分類計"
        Me.txt通数m分類計.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt通数m分類計.Text = "999,999m"
        Me.txt通数m分類計.Top = 0.137795!
        Me.txt通数m分類計.Width = 0.8661417!
        '
        'txt仕固定経費分類計
        '
        Me.txt仕固定経費分類計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕固定経費分類計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕固定経費分類計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕固定経費分類計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕固定経費分類計.Height = 0.2755905!
        Me.txt仕固定経費分類計.Left = 5.492126!
        Me.txt仕固定経費分類計.Name = "txt仕固定経費分類計"
        Me.txt仕固定経費分類計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕固定経費分類計.Text = "999,999,999"
        Me.txt仕固定経費分類計.Top = 0.0!
        Me.txt仕固定経費分類計.Width = 0.9055118!
        '
        'MachineSchedule
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.70866!
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
        CType(Me.txt仕入, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtクレーム金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt機械名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt版交換回数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtクレーム数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt粗利, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt売上, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt原価決定済件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt利益, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数m, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt固定経費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者別未引当一覧表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblクレーム金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl版交換回数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl機械名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblクレーム数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl粗利, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl売上, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl原価決定済件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl利益, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl固定経費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtクレーム金額合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtクレーム数合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt版交換回数合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt売上合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt粗利合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt原価決定済件数合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt利益合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数m合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt固定経費合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt利益分類計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt原価決定済件数分類計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtクレーム金額分類計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtクレーム数分類計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt売上分類計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt粗利分類計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt版交換回数分類計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入分類計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数分類計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数m分類計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕固定経費分類計, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt仕入 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtクレーム金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt機械名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt版交換回数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtクレーム数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt粗利 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt売上 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt対象年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者別未引当一覧表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl仕入 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl版交換回数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl機械名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl通数 As DataDynamics.ActiveReports.Label
    Private WithEvents lblクレーム数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl粗利 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl売上 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txtクレーム金額合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtクレーム数合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt版交換回数合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt売上合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt粗利合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt原価決定済件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl原価決定済件数 As DataDynamics.ActiveReports.Label
    Private WithEvents lblクレーム金額 As DataDynamics.ActiveReports.Label
    Private WithEvents txt原価決定済件数合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt利益 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl利益 As DataDynamics.ActiveReports.Label
    Private WithEvents txt利益合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt通数m As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt固定経費 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl固定経費 As DataDynamics.ActiveReports.Label
    Private WithEvents txt通数合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt通数m合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt固定経費合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt利益分類計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt原価決定済件数分類計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtクレーム金額分類計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtクレーム数分類計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt売上分類計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt粗利分類計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt版交換回数分類計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox31 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入分類計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents txt通数分類計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt通数m分類計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕固定経費分類計 As DataDynamics.ActiveReports.TextBox
End Class
