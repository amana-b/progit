<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class StuffCustomerPrfMng
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(StuffCustomerPrfMng))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt仕入 = New DataDynamics.ActiveReports.TextBox()
        Me.txt粗利 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt諸経費 = New DataDynamics.ActiveReports.TextBox()
        Me.txt作業No = New DataDynamics.ActiveReports.TextBox()
        Me.txt売上 = New DataDynamics.ActiveReports.TextBox()
        Me.txt固定経費 = New DataDynamics.ActiveReports.TextBox()
        Me.txt利益 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数m = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入運賃他 = New DataDynamics.ActiveReports.TextBox()
        Me.txt利益率 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt対象年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者別未引当一覧表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl仕入 = New DataDynamics.ActiveReports.Label()
        Me.lbl粗利 = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先名 = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先CD = New DataDynamics.ActiveReports.Label()
        Me.lbl通数 = New DataDynamics.ActiveReports.Label()
        Me.lbl諸経費 = New DataDynamics.ActiveReports.Label()
        Me.lbl作業No = New DataDynamics.ActiveReports.Label()
        Me.lbl売上 = New DataDynamics.ActiveReports.Label()
        Me.lbl固定経費 = New DataDynamics.ActiveReports.Label()
        Me.lbl利益 = New DataDynamics.ActiveReports.Label()
        Me.lbl担当者 = New DataDynamics.ActiveReports.Label()
        Me.txt担当者CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者名 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl仕入運賃他 = New DataDynamics.ActiveReports.Label()
        Me.lbl利益率 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt粗利合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt諸経費合計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.txt売上合計 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt固定経費合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt利益合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数m合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入運賃他合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt利益率合計 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt利益担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt固定経費担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt粗利担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt諸経費担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt売上担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox29 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox30 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox31 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.txt通数担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数m担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入運賃他担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt利益率担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupHeader2 = New DataDynamics.ActiveReports.GroupHeader()
        Me.GroupFooter2 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt利益得意先計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt固定経費得意計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt粗利得意先計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt諸経費得意先計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt売上得意先計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入得意先計 = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.txt通数得意先計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数m得意先計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入運賃他得意先計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt利益率得意先計 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt仕入, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt粗利, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt諸経費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt売上, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt固定経費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt利益, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数m, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入運賃他, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt利益率, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者別未引当一覧表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl粗利, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl諸経費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl売上, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl固定経費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl利益, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl担当者, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入運賃他, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl利益率, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt粗利合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt諸経費合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt売上合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt固定経費合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt利益合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数m合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入運賃他合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt利益率合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt利益担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt固定経費担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt粗利担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt諸経費担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt売上担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数m担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入運賃他担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt利益率担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt利益得意先計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt固定経費得意計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt粗利得意先計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt諸経費得意先計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt売上得意先計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入得意先計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数得意先計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数m得意先計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入運賃他得意先計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt利益率得意先計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt仕入, Me.txt粗利, Me.txt通数, Me.txt得意先CD, Me.txt得意先名, Me.txt諸経費, Me.txt作業No, Me.txt売上, Me.txt固定経費, Me.txt利益, Me.txt通数m, Me.txt仕入運賃他, Me.txt利益率})
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
        Me.txt仕入.Left = 4.80315!
        Me.txt仕入.Name = "txt仕入"
        Me.txt仕入.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt仕入.Text = "999,999,999"
        Me.txt仕入.Top = 0.0!
        Me.txt仕入.Width = 0.8661417!
        '
        'txt粗利
        '
        Me.txt粗利.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利.Height = 0.2755905!
        Me.txt粗利.Left = 7.401575!
        Me.txt粗利.Name = "txt粗利"
        Me.txt粗利.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt粗利.Text = "999,999,999"
        Me.txt粗利.Top = 0.000001132488!
        Me.txt粗利.Width = 0.9055118!
        '
        'txt通数
        '
        Me.txt通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数.Height = 0.1377953!
        Me.txt通数.Left = 3.070866!
        Me.txt通数.Name = "txt通数"
        Me.txt通数.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt通数.Text = "999,999,999通"
        Me.txt通数.Top = 0.0000002980233!
        Me.txt通数.Width = 0.8661417!
        '
        'txt得意先CD
        '
        Me.txt得意先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Height = 0.2755905!
        Me.txt得意先CD.Left = 0.0!
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt得意先CD.Text = "123456"
        Me.txt得意先CD.Top = 0.00000005960464!
        Me.txt得意先CD.Width = 0.5905512!
        '
        'txt得意先名
        '
        Me.txt得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Height = 0.2755905!
        Me.txt得意先名.Left = 0.5905512!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: justify; vertical-align: bottom" & _
    "; ddo-char-set: 1"
        Me.txt得意先名.Text = "あああああいいい"
        Me.txt得意先名.Top = 0.0000001192093!
        Me.txt得意先名.Width = 2.007874!
        '
        'txt諸経費
        '
        Me.txt諸経費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費.Height = 0.2755905!
        Me.txt諸経費.Left = 6.535433!
        Me.txt諸経費.Name = "txt諸経費"
        Me.txt諸経費.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt諸経費.Text = "999,999,999"
        Me.txt諸経費.Top = 0.0000002980233!
        Me.txt諸経費.Width = 0.8661417!
        '
        'txt作業No
        '
        Me.txt作業No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Height = 0.2755905!
        Me.txt作業No.Left = 2.598425!
        Me.txt作業No.Name = "txt作業No"
        Me.txt作業No.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt作業No.Text = "123456"
        Me.txt作業No.Top = 0.0000002980233!
        Me.txt作業No.Width = 0.472441!
        '
        'txt売上
        '
        Me.txt売上.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上.Height = 0.2755905!
        Me.txt売上.Left = 3.937008!
        Me.txt売上.Name = "txt売上"
        Me.txt売上.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt売上.Text = "999,999,999"
        Me.txt売上.Top = 0.0000005066395!
        Me.txt売上.Width = 0.8661417!
        '
        'txt固定経費
        '
        Me.txt固定経費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費.Height = 0.2755905!
        Me.txt固定経費.Left = 8.307087!
        Me.txt固定経費.Name = "txt固定経費"
        Me.txt固定経費.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt固定経費.Text = "999,999,999"
        Me.txt固定経費.Top = 0.0!
        Me.txt固定経費.Width = 0.9055118!
        '
        'txt利益
        '
        Me.txt利益.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益.Height = 0.2755905!
        Me.txt利益.Left = 9.212599!
        Me.txt利益.Name = "txt利益"
        Me.txt利益.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt利益.Text = "999,999,999"
        Me.txt利益.Top = 0.0!
        Me.txt利益.Width = 0.9055119!
        '
        'txt通数m
        '
        Me.txt通数m.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m.Height = 0.1377953!
        Me.txt通数m.Left = 3.070866!
        Me.txt通数m.Name = "txt通数m"
        Me.txt通数m.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt通数m.Text = "999,999m"
        Me.txt通数m.Top = 0.1377956!
        Me.txt通数m.Width = 0.8661417!
        '
        'txt仕入運賃他
        '
        Me.txt仕入運賃他.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他.Height = 0.2755906!
        Me.txt仕入運賃他.Left = 5.669291!
        Me.txt仕入運賃他.Name = "txt仕入運賃他"
        Me.txt仕入運賃他.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt仕入運賃他.Text = "999,999,999"
        Me.txt仕入運賃他.Top = 0.0!
        Me.txt仕入運賃他.Width = 0.8661417!
        '
        'txt利益率
        '
        Me.txt利益率.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率.Height = 0.2755905!
        Me.txt利益率.Left = 10.11811!
        Me.txt利益率.Name = "txt利益率"
        Me.txt利益率.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt利益率.Text = "999.99"
        Me.txt利益率.Top = 0.0!
        Me.txt利益率.Width = 0.8267716!
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
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt対象年月, Me.txt担当者別未引当一覧表, Me.lbl仕入, Me.lbl粗利, Me.lbl得意先名, Me.lbl得意先CD, Me.lbl通数, Me.lbl諸経費, Me.lbl作業No, Me.lbl売上, Me.lbl固定経費, Me.lbl利益, Me.lbl担当者, Me.txt担当者CD, Me.txt担当者名, Me.lbl仕入運賃他, Me.lbl利益率})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.9204725!
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
        Me.txt担当者別未引当一覧表.Height = 0.2362205!
        Me.txt担当者別未引当一覧表.Left = 4.514174!
        Me.txt担当者別未引当一覧表.Name = "txt担当者別未引当一覧表"
        Me.txt担当者別未引当一覧表.Style = "font-family: ＭＳ Ｐゴシック; font-size: 14pt; font-weight: bold; text-align: center; ve" & _
    "rtical-align: bottom; ddo-char-set: 1"
        Me.txt担当者別未引当一覧表.Text = "担当者別得意先別利益管理表"
        Me.txt担当者別未引当一覧表.Top = 0.1968504!
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
        Me.lbl仕入.Left = 4.80315!
        Me.lbl仕入.Name = "lbl仕入"
        Me.lbl仕入.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl仕入.Text = "仕入"
        Me.lbl仕入.Top = 0.664567!
        Me.lbl仕入.Width = 0.8661417!
        '
        'lbl粗利
        '
        Me.lbl粗利.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Height = 0.2559055!
        Me.lbl粗利.HyperLink = Nothing
        Me.lbl粗利.Left = 7.401575!
        Me.lbl粗利.Name = "lbl粗利"
        Me.lbl粗利.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl粗利.Text = "粗利"
        Me.lbl粗利.Top = 0.664567!
        Me.lbl粗利.Width = 0.8661417!
        '
        'lbl得意先名
        '
        Me.lbl得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.CharacterSpacing = 5.0!
        Me.lbl得意先名.Height = 0.2559055!
        Me.lbl得意先名.HyperLink = Nothing
        Me.lbl得意先名.Left = 0.5905512!
        Me.lbl得意先名.Name = "lbl得意先名"
        Me.lbl得意先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbl得意先名.Text = "得意先名"
        Me.lbl得意先名.Top = 0.664567!
        Me.lbl得意先名.Width = 2.007874!
        '
        'lbl得意先CD
        '
        Me.lbl得意先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Height = 0.2559055!
        Me.lbl得意先CD.HyperLink = Nothing
        Me.lbl得意先CD.Left = 0.0!
        Me.lbl得意先CD.Name = "lbl得意先CD"
        Me.lbl得意先CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7.5pt; text-align: center; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.lbl得意先CD.Text = "得意先ｺｰﾄﾞ"
        Me.lbl得意先CD.Top = 0.664567!
        Me.lbl得意先CD.Width = 0.5905512!
        '
        'lbl通数
        '
        Me.lbl通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl通数.Height = 0.2559055!
        Me.lbl通数.HyperLink = Nothing
        Me.lbl通数.Left = 3.070866!
        Me.lbl通数.Name = "lbl通数"
        Me.lbl通数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl通数.Text = "通数/m数"
        Me.lbl通数.Top = 0.664567!
        Me.lbl通数.Width = 0.8661417!
        '
        'lbl諸経費
        '
        Me.lbl諸経費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl諸経費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl諸経費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl諸経費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl諸経費.Height = 0.2559055!
        Me.lbl諸経費.HyperLink = Nothing
        Me.lbl諸経費.Left = 6.535433!
        Me.lbl諸経費.Name = "lbl諸経費"
        Me.lbl諸経費.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl諸経費.Text = "諸経費"
        Me.lbl諸経費.Top = 0.664567!
        Me.lbl諸経費.Width = 0.8661417!
        '
        'lbl作業No
        '
        Me.lbl作業No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Height = 0.2559055!
        Me.lbl作業No.HyperLink = Nothing
        Me.lbl作業No.Left = 2.598425!
        Me.lbl作業No.Name = "lbl作業No"
        Me.lbl作業No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl作業No.Text = "作業No"
        Me.lbl作業No.Top = 0.664567!
        Me.lbl作業No.Width = 0.472441!
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
        Me.lbl売上.Left = 3.937008!
        Me.lbl売上.Name = "lbl売上"
        Me.lbl売上.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl売上.Text = "売上"
        Me.lbl売上.Top = 0.664567!
        Me.lbl売上.Width = 0.8661417!
        '
        'lbl固定経費
        '
        Me.lbl固定経費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl固定経費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl固定経費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl固定経費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl固定経費.Height = 0.2559055!
        Me.lbl固定経費.HyperLink = Nothing
        Me.lbl固定経費.Left = 8.267716!
        Me.lbl固定経費.Name = "lbl固定経費"
        Me.lbl固定経費.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl固定経費.Text = "固定経費"
        Me.lbl固定経費.Top = 0.664567!
        Me.lbl固定経費.Width = 0.9055118!
        '
        'lbl利益
        '
        Me.lbl利益.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益.Height = 0.2559055!
        Me.lbl利益.HyperLink = Nothing
        Me.lbl利益.Left = 9.173228!
        Me.lbl利益.Name = "lbl利益"
        Me.lbl利益.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl利益.Text = "利益"
        Me.lbl利益.Top = 0.6645669!
        Me.lbl利益.Width = 0.9055118!
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
        'lbl仕入運賃他
        '
        Me.lbl仕入運賃他.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入運賃他.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入運賃他.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入運賃他.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入運賃他.Height = 0.2559055!
        Me.lbl仕入運賃他.HyperLink = Nothing
        Me.lbl仕入運賃他.Left = 5.669291!
        Me.lbl仕入運賃他.Name = "lbl仕入運賃他"
        Me.lbl仕入運賃他.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl仕入運賃他.Text = "仕入(運賃他)"
        Me.lbl仕入運賃他.Top = 0.664567!
        Me.lbl仕入運賃他.Width = 0.8661417!
        '
        'lbl利益率
        '
        Me.lbl利益率.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益率.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益率.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益率.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益率.Height = 0.2559055!
        Me.lbl利益率.HyperLink = Nothing
        Me.lbl利益率.Left = 10.07874!
        Me.lbl利益率.Name = "lbl利益率"
        Me.lbl利益率.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl利益率.Text = "利益率％"
        Me.lbl利益率.Top = 0.6645669!
        Me.lbl利益率.Width = 0.8267716!
        '
        'grpFtr計
        '
        Me.grpFtr計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt粗利合計, Me.txt諸経費合計, Me.TextBox11, Me.txt売上合計, Me.Label2, Me.TextBox19, Me.TextBox2, Me.txt仕入合計, Me.txt固定経費合計, Me.txt利益合計, Me.txt通数合計, Me.txt通数m合計, Me.txt仕入運賃他合計, Me.txt利益率合計})
        Me.grpFtr計.Height = 0.2755905!
        Me.grpFtr計.Name = "grpFtr計"
        '
        'txt粗利合計
        '
        Me.txt粗利合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利合計.Height = 0.2755905!
        Me.txt粗利合計.Left = 7.401575!
        Me.txt粗利合計.Name = "txt粗利合計"
        Me.txt粗利合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt粗利合計.Text = "999,999,999"
        Me.txt粗利合計.Top = 0.0!
        Me.txt粗利合計.Width = 0.9055118!
        '
        'txt諸経費合計
        '
        Me.txt諸経費合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費合計.Height = 0.2755905!
        Me.txt諸経費合計.Left = 6.535433!
        Me.txt諸経費合計.Name = "txt諸経費合計"
        Me.txt諸経費合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt諸経費合計.Text = "999,999,999"
        Me.txt諸経費合計.Top = 0.0!
        Me.txt諸経費合計.Width = 0.8661417!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Height = 0.2755905!
        Me.TextBox11.Left = 0.5905512!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 0.0000001192093!
        Me.TextBox11.Width = 2.007874!
        '
        'txt売上合計
        '
        Me.txt売上合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上合計.Height = 0.2755905!
        Me.txt売上合計.Left = 3.937008!
        Me.txt売上合計.Name = "txt売上合計"
        Me.txt売上合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: left; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt売上合計.Text = "999,999,999"
        Me.txt売上合計.Top = 0.0000005066395!
        Me.txt売上合計.Width = 0.8661417!
        '
        'Label2
        '
        Me.Label2.Height = 0.1771654!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 1.603148!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label2.Text = "＊合計"
        Me.Label2.Top = 0.05118112!
        Me.Label2.Width = 0.7874016!
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
        Me.TextBox19.Width = 0.5905512!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Height = 0.2755905!
        Me.TextBox2.Left = 2.598425!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 0.472441!
        '
        'txt仕入合計
        '
        Me.txt仕入合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計.Height = 0.2755905!
        Me.txt仕入合計.Left = 4.80315!
        Me.txt仕入合計.Name = "txt仕入合計"
        Me.txt仕入合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入合計.Text = "999,999,999"
        Me.txt仕入合計.Top = 0.0!
        Me.txt仕入合計.Width = 0.8661417!
        '
        'txt固定経費合計
        '
        Me.txt固定経費合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費合計.Height = 0.2755905!
        Me.txt固定経費合計.Left = 8.307087!
        Me.txt固定経費合計.Name = "txt固定経費合計"
        Me.txt固定経費合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt固定経費合計.Text = "999,999,999"
        Me.txt固定経費合計.Top = 0.0!
        Me.txt固定経費合計.Width = 0.9055118!
        '
        'txt利益合計
        '
        Me.txt利益合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益合計.Height = 0.2755905!
        Me.txt利益合計.Left = 9.212599!
        Me.txt利益合計.Name = "txt利益合計"
        Me.txt利益合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt利益合計.Text = "999,999,999"
        Me.txt利益合計.Top = 0.0!
        Me.txt利益合計.Width = 0.9055118!
        '
        'txt通数合計
        '
        Me.txt通数合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数合計.Height = 0.1377953!
        Me.txt通数合計.Left = 3.070866!
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
        Me.txt通数m合計.Left = 3.070866!
        Me.txt通数m合計.Name = "txt通数m合計"
        Me.txt通数m合計.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt通数m合計.Text = "999,999m"
        Me.txt通数m合計.Top = 0.137795!
        Me.txt通数m合計.Width = 0.8661417!
        '
        'txt仕入運賃他合計
        '
        Me.txt仕入運賃他合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他合計.Height = 0.2755906!
        Me.txt仕入運賃他合計.Left = 5.669291!
        Me.txt仕入運賃他合計.Name = "txt仕入運賃他合計"
        Me.txt仕入運賃他合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入運賃他合計.Text = "999,999,999"
        Me.txt仕入運賃他合計.Top = 0.0!
        Me.txt仕入運賃他合計.Width = 0.8661417!
        '
        'txt利益率合計
        '
        Me.txt利益率合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率合計.Height = 0.2755905!
        Me.txt利益率合計.Left = 10.11811!
        Me.txt利益率合計.Name = "txt利益率合計"
        Me.txt利益率合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt利益率合計.Text = "999.99"
        Me.txt利益率合計.Top = 0.0!
        Me.txt利益率合計.Width = 0.8267716!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt利益担当者計, Me.txt固定経費担当者計, Me.txt粗利担当者計, Me.txt諸経費担当者計, Me.txt売上担当者計, Me.TextBox29, Me.TextBox30, Me.TextBox31, Me.txt仕入担当者計, Me.Label3, Me.txt通数担当者計, Me.txt通数m担当者計, Me.txt仕入運賃他担当者計, Me.txt利益率担当者計})
        Me.GroupFooter1.Height = 0.2755905!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'txt利益担当者計
        '
        Me.txt利益担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益担当者計.Height = 0.2755905!
        Me.txt利益担当者計.Left = 9.212599!
        Me.txt利益担当者計.Name = "txt利益担当者計"
        Me.txt利益担当者計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt利益担当者計.Text = "999,999,999"
        Me.txt利益担当者計.Top = 0.0!
        Me.txt利益担当者計.Width = 0.9055118!
        '
        'txt固定経費担当者計
        '
        Me.txt固定経費担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費担当者計.Height = 0.2755905!
        Me.txt固定経費担当者計.Left = 8.307087!
        Me.txt固定経費担当者計.Name = "txt固定経費担当者計"
        Me.txt固定経費担当者計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt固定経費担当者計.Text = "999,999,999"
        Me.txt固定経費担当者計.Top = 0.0!
        Me.txt固定経費担当者計.Width = 0.9055118!
        '
        'txt粗利担当者計
        '
        Me.txt粗利担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利担当者計.Height = 0.2755905!
        Me.txt粗利担当者計.Left = 7.401576!
        Me.txt粗利担当者計.Name = "txt粗利担当者計"
        Me.txt粗利担当者計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt粗利担当者計.Text = "999,999,999"
        Me.txt粗利担当者計.Top = 0.0!
        Me.txt粗利担当者計.Width = 0.9055118!
        '
        'txt諸経費担当者計
        '
        Me.txt諸経費担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費担当者計.Height = 0.2755905!
        Me.txt諸経費担当者計.Left = 6.535434!
        Me.txt諸経費担当者計.Name = "txt諸経費担当者計"
        Me.txt諸経費担当者計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt諸経費担当者計.Text = "999,999,999"
        Me.txt諸経費担当者計.Top = 0.0!
        Me.txt諸経費担当者計.Width = 0.8661417!
        '
        'txt売上担当者計
        '
        Me.txt売上担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上担当者計.Height = 0.2755906!
        Me.txt売上担当者計.Left = 3.937008!
        Me.txt売上担当者計.Name = "txt売上担当者計"
        Me.txt売上担当者計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: left; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt売上担当者計.Text = "999,999,999"
        Me.txt売上担当者計.Top = 0.0000005066395!
        Me.txt売上担当者計.Width = 0.8661417!
        '
        'TextBox29
        '
        Me.TextBox29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Height = 0.2755906!
        Me.TextBox29.Left = 2.598426!
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox29.Text = Nothing
        Me.TextBox29.Top = 0.0!
        Me.TextBox29.Width = 0.472441!
        '
        'TextBox30
        '
        Me.TextBox30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Height = 0.2755906!
        Me.TextBox30.Left = 0.5905511!
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox30.Text = Nothing
        Me.TextBox30.Top = 0.0000001192093!
        Me.TextBox30.Width = 2.007874!
        '
        'TextBox31
        '
        Me.TextBox31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Height = 0.2755906!
        Me.TextBox31.Left = 0.0!
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox31.Text = Nothing
        Me.TextBox31.Top = 0.00000005960464!
        Me.TextBox31.Width = 0.5905511!
        '
        'txt仕入担当者計
        '
        Me.txt仕入担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入担当者計.Height = 0.2755906!
        Me.txt仕入担当者計.Left = 4.80315!
        Me.txt仕入担当者計.Name = "txt仕入担当者計"
        Me.txt仕入担当者計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入担当者計.Text = "999,999,999"
        Me.txt仕入担当者計.Top = 0.0!
        Me.txt仕入担当者計.Width = 0.8661417!
        '
        'Label3
        '
        Me.Label3.Height = 0.1771654!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 1.577165!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label3.Text = "＊担当者計"
        Me.Label3.Top = 0.03070866!
        Me.Label3.Width = 0.7874014!
        '
        'txt通数担当者計
        '
        Me.txt通数担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数担当者計.Height = 0.1377953!
        Me.txt通数担当者計.Left = 3.070867!
        Me.txt通数担当者計.Name = "txt通数担当者計"
        Me.txt通数担当者計.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt通数担当者計.Text = "999,999,999通"
        Me.txt通数担当者計.Top = 0.0!
        Me.txt通数担当者計.Width = 0.8661417!
        '
        'txt通数m担当者計
        '
        Me.txt通数m担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m担当者計.Height = 0.1377953!
        Me.txt通数m担当者計.Left = 3.070867!
        Me.txt通数m担当者計.Name = "txt通数m担当者計"
        Me.txt通数m担当者計.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt通数m担当者計.Text = "999,999m"
        Me.txt通数m担当者計.Top = 0.137795!
        Me.txt通数m担当者計.Width = 0.8661417!
        '
        'txt仕入運賃他担当者計
        '
        Me.txt仕入運賃他担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他担当者計.Height = 0.2755906!
        Me.txt仕入運賃他担当者計.Left = 5.669292!
        Me.txt仕入運賃他担当者計.Name = "txt仕入運賃他担当者計"
        Me.txt仕入運賃他担当者計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入運賃他担当者計.Text = "999,999,999"
        Me.txt仕入運賃他担当者計.Top = 0.0!
        Me.txt仕入運賃他担当者計.Width = 0.8661417!
        '
        'txt利益率担当者計
        '
        Me.txt利益率担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率担当者計.Height = 0.2755905!
        Me.txt利益率担当者計.Left = 10.11811!
        Me.txt利益率担当者計.Name = "txt利益率担当者計"
        Me.txt利益率担当者計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt利益率担当者計.Text = "999.99"
        Me.txt利益率担当者計.Top = 0.0!
        Me.txt利益率担当者計.Width = 0.8267716!
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Height = 0.0!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt利益得意先計, Me.txt固定経費得意計, Me.txt粗利得意先計, Me.txt諸経費得意先計, Me.txt売上得意先計, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.txt仕入得意先計, Me.Label1, Me.txt通数得意先計, Me.txt通数m得意先計, Me.txt仕入運賃他得意先計, Me.txt利益率得意先計})
        Me.GroupFooter2.Height = 0.2755905!
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'txt利益得意先計
        '
        Me.txt利益得意先計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益得意先計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益得意先計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益得意先計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益得意先計.Height = 0.2755905!
        Me.txt利益得意先計.Left = 9.212599!
        Me.txt利益得意先計.Name = "txt利益得意先計"
        Me.txt利益得意先計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt利益得意先計.Text = "999,999,999"
        Me.txt利益得意先計.Top = 0.0!
        Me.txt利益得意先計.Width = 0.9055118!
        '
        'txt固定経費得意計
        '
        Me.txt固定経費得意計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費得意計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費得意計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費得意計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費得意計.Height = 0.2755905!
        Me.txt固定経費得意計.Left = 8.307087!
        Me.txt固定経費得意計.Name = "txt固定経費得意計"
        Me.txt固定経費得意計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt固定経費得意計.Text = "999,999,999"
        Me.txt固定経費得意計.Top = 0.0!
        Me.txt固定経費得意計.Width = 0.9055118!
        '
        'txt粗利得意先計
        '
        Me.txt粗利得意先計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利得意先計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利得意先計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利得意先計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt粗利得意先計.Height = 0.2755905!
        Me.txt粗利得意先計.Left = 7.401576!
        Me.txt粗利得意先計.Name = "txt粗利得意先計"
        Me.txt粗利得意先計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt粗利得意先計.Text = "999,999,999"
        Me.txt粗利得意先計.Top = 0.0!
        Me.txt粗利得意先計.Width = 0.9055118!
        '
        'txt諸経費得意先計
        '
        Me.txt諸経費得意先計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費得意先計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費得意先計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費得意先計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt諸経費得意先計.Height = 0.2755905!
        Me.txt諸経費得意先計.Left = 6.535434!
        Me.txt諸経費得意先計.Name = "txt諸経費得意先計"
        Me.txt諸経費得意先計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt諸経費得意先計.Text = "999,999,999"
        Me.txt諸経費得意先計.Top = 0.0000002980233!
        Me.txt諸経費得意先計.Width = 0.8661417!
        '
        'txt売上得意先計
        '
        Me.txt売上得意先計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上得意先計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上得意先計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上得意先計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上得意先計.Height = 0.2755906!
        Me.txt売上得意先計.Left = 3.937008!
        Me.txt売上得意先計.Name = "txt売上得意先計"
        Me.txt売上得意先計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: left; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt売上得意先計.Text = "999,999,999"
        Me.txt売上得意先計.Top = 0.0000005066395!
        Me.txt売上得意先計.Width = 0.8661417!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Height = 0.2755906!
        Me.TextBox7.Left = 2.598426!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 0.472441!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Height = 0.2755906!
        Me.TextBox8.Left = 0.5905511!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.0000001192093!
        Me.TextBox8.Width = 2.007874!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Height = 0.2755906!
        Me.TextBox9.Left = 0.0!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0.00000005960464!
        Me.TextBox9.Width = 0.5905511!
        '
        'txt仕入得意先計
        '
        Me.txt仕入得意先計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入得意先計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入得意先計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入得意先計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入得意先計.Height = 0.2755906!
        Me.txt仕入得意先計.Left = 4.80315!
        Me.txt仕入得意先計.Name = "txt仕入得意先計"
        Me.txt仕入得意先計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入得意先計.Text = "999,999,999"
        Me.txt仕入得意先計.Top = 0.0!
        Me.txt仕入得意先計.Width = 0.8661417!
        '
        'Label1
        '
        Me.Label1.Height = 0.1771654!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 1.577165!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label1.Text = "＊得意先計"
        Me.Label1.Top = 0.03070866!
        Me.Label1.Width = 0.7874014!
        '
        'txt通数得意先計
        '
        Me.txt通数得意先計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数得意先計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数得意先計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数得意先計.Height = 0.1377953!
        Me.txt通数得意先計.Left = 3.070867!
        Me.txt通数得意先計.Name = "txt通数得意先計"
        Me.txt通数得意先計.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt通数得意先計.Text = "999,999,999通"
        Me.txt通数得意先計.Top = 0.0!
        Me.txt通数得意先計.Width = 0.8661417!
        '
        'txt通数m得意先計
        '
        Me.txt通数m得意先計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m得意先計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m得意先計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m得意先計.Height = 0.1377953!
        Me.txt通数m得意先計.Left = 3.070867!
        Me.txt通数m得意先計.Name = "txt通数m得意先計"
        Me.txt通数m得意先計.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt通数m得意先計.Text = "999,999m"
        Me.txt通数m得意先計.Top = 0.137795!
        Me.txt通数m得意先計.Width = 0.8661417!
        '
        'txt仕入運賃他得意先計
        '
        Me.txt仕入運賃他得意先計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他得意先計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他得意先計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他得意先計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他得意先計.Height = 0.2755906!
        Me.txt仕入運賃他得意先計.Left = 5.669292!
        Me.txt仕入運賃他得意先計.Name = "txt仕入運賃他得意先計"
        Me.txt仕入運賃他得意先計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入運賃他得意先計.Text = "999,999,999"
        Me.txt仕入運賃他得意先計.Top = 0.0!
        Me.txt仕入運賃他得意先計.Width = 0.8661417!
        '
        'txt利益率得意先計
        '
        Me.txt利益率得意先計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率得意先計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率得意先計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率得意先計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率得意先計.Height = 0.2755905!
        Me.txt利益率得意先計.Left = 10.11811!
        Me.txt利益率得意先計.Name = "txt利益率得意先計"
        Me.txt利益率得意先計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt利益率得意先計.Text = "999.99"
        Me.txt利益率得意先計.Top = 0.00000002980232!
        Me.txt利益率得意先計.Width = 0.8267716!
        '
        'StuffCustomerPrfMng
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
        CType(Me.txt仕入, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt粗利, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt諸経費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt売上, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt固定経費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt利益, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数m, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入運賃他, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt利益率, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者別未引当一覧表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl粗利, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl諸経費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl売上, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl固定経費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl利益, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl担当者, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入運賃他, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl利益率, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt粗利合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt諸経費合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt売上合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt固定経費合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt利益合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数m合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入運賃他合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt利益率合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt利益担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt固定経費担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt粗利担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt諸経費担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt売上担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数m担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入運賃他担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt利益率担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt利益得意先計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt固定経費得意計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt粗利得意先計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt諸経費得意先計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt売上得意先計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入得意先計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数得意先計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数m得意先計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入運賃他得意先計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt利益率得意先計, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt粗利 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt諸経費 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt作業No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt売上 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt対象年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者別未引当一覧表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl仕入 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先CD As DataDynamics.ActiveReports.Label
    Private WithEvents lbl通数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl諸経費 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl作業No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl売上 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt粗利合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt諸経費合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt売上合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt固定経費 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl固定経費 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl粗利 As DataDynamics.ActiveReports.Label
    Private WithEvents txt固定経費合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt利益 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl利益 As DataDynamics.ActiveReports.Label
    Private WithEvents txt利益合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl担当者 As DataDynamics.ActiveReports.Label
    Private WithEvents txt担当者CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt通数m As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入運賃他 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl仕入運賃他 As DataDynamics.ActiveReports.Label
    Private WithEvents txt通数合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt通数m合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入運賃他合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt利益担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt固定経費担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt粗利担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt諸経費担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt売上担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox29 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox30 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox31 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents txt通数担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt通数m担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入運賃他担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader2 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents GroupFooter2 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt利益得意先計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt固定経費得意計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt粗利得意先計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt諸経費得意先計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt売上得意先計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入得意先計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents txt通数得意先計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt通数m得意先計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入運賃他得意先計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt利益率 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl利益率 As DataDynamics.ActiveReports.Label
    Private WithEvents txt利益率合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt利益率担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt利益率得意先計 As DataDynamics.ActiveReports.TextBox
End Class
