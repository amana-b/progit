<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DepartmentSalesPurchase
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DepartmentSalesPurchase))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt当月仕入金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt累計経費金額 = New DataDynamics.ActiveReports.TextBox()
        Me.tx当月売上金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月固定経費 = New DataDynamics.ActiveReports.TextBox()
        Me.txt部門名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月経費金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt累計仕入金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月人件費 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月粗利 = New DataDynamics.ActiveReports.TextBox()
        Me.txt累計人件費 = New DataDynamics.ActiveReports.TextBox()
        Me.txt累計粗利 = New DataDynamics.ActiveReports.TextBox()
        Me.txt累計固定経費 = New DataDynamics.ActiveReports.TextBox()
        Me.txt累計売上金額 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt対象年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt部門別売上仕入集計表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl累計 = New DataDynamics.ActiveReports.Label()
        Me.lbl当月 = New DataDynamics.ActiveReports.Label()
        Me.lbl部門名 = New DataDynamics.ActiveReports.Label()
        Me.lbl当月売上金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl累計売上金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl当月仕入金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl当月人件費 = New DataDynamics.ActiveReports.Label()
        Me.lbl当月粗利 = New DataDynamics.ActiveReports.Label()
        Me.lbl当月経費金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl当月固定経費 = New DataDynamics.ActiveReports.Label()
        Me.lbl累計仕入金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl累計経費金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl累計人件費 = New DataDynamics.ActiveReports.Label()
        Me.lbl累計固定経費 = New DataDynamics.ActiveReports.Label()
        Me.lbl累計粗利 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt累計経費合計金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt累計仕入合計金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月固定経費合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月経費合計金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月粗利合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月売上合計金額 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月人件費合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月仕入合計金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt累計人件費合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt固定経費合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt累計粗利合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt累計売上合計金額 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt当月仕入金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt累計経費金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tx当月売上金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月固定経費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt部門名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月経費金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt累計仕入金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月人件費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月粗利, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt累計人件費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt累計粗利, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt累計固定経費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt累計売上金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt部門別売上仕入集計表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl累計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl当月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl部門名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl当月売上金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl累計売上金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl当月仕入金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl当月人件費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl当月粗利, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl当月経費金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl当月固定経費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl累計仕入金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl累計経費金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl累計人件費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl累計固定経費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl累計粗利, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt累計経費合計金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt累計仕入合計金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月固定経費合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月経費合計金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月粗利合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月売上合計金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月人件費合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月仕入合計金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt累計人件費合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt固定経費合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt累計粗利合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt累計売上合計金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt当月仕入金額, Me.txt累計経費金額, Me.tx当月売上金額, Me.txt当月固定経費, Me.txt部門名, Me.txt当月経費金額, Me.txt累計仕入金額, Me.txt当月人件費, Me.txt当月粗利, Me.txt累計人件費, Me.txt累計粗利, Me.txt累計固定経費, Me.txt累計売上金額})
        Me.Detail.Height = 0.2755905!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt当月仕入金額
        '
        Me.txt当月仕入金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月仕入金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月仕入金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月仕入金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月仕入金額.Height = 0.2755905!
        Me.txt当月仕入金額.Left = 1.811024!
        Me.txt当月仕入金額.Name = "txt当月仕入金額"
        Me.txt当月仕入金額.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月仕入金額.Text = "999,999,999"
        Me.txt当月仕入金額.Top = 3.552714E-15!
        Me.txt当月仕入金額.Width = 0.9448819!
        '
        'txt累計経費金額
        '
        Me.txt累計経費金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計経費金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計経費金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計経費金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計経費金額.Height = 0.2755905!
        Me.txt累計経費金額.Left = 7.795276!
        Me.txt累計経費金額.Name = "txt累計経費金額"
        Me.txt累計経費金額.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt累計経費金額.Text = "999,999,999"
        Me.txt累計経費金額.Top = 0.000001132488!
        Me.txt累計経費金額.Width = 0.7480315!
        '
        'tx当月売上金額
        '
        Me.tx当月売上金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.tx当月売上金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.tx当月売上金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.tx当月売上金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.tx当月売上金額.CanGrow = False
        Me.tx当月売上金額.Height = 0.2755905!
        Me.tx当月売上金額.Left = 0.8661417!
        Me.tx当月売上金額.Name = "tx当月売上金額"
        Me.tx当月売上金額.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.tx当月売上金額.Text = "999,999,999"
        Me.tx当月売上金額.Top = 0.000000178814!
        Me.tx当月売上金額.Width = 0.9448819!
        '
        'txt当月固定経費
        '
        Me.txt当月固定経費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月固定経費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月固定経費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月固定経費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月固定経費.Height = 0.2755905!
        Me.txt当月固定経費.Left = 4.232284!
        Me.txt当月固定経費.Name = "txt当月固定経費"
        Me.txt当月固定経費.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月固定経費.Text = "999,999,999"
        Me.txt当月固定経費.Top = 0.0000002980233!
        Me.txt当月固定経費.Width = 0.7283465!
        '
        'txt部門名
        '
        Me.txt部門名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt部門名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt部門名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt部門名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt部門名.Height = 0.2755905!
        Me.txt部門名.Left = 0.0!
        Me.txt部門名.Name = "txt部門名"
        Me.txt部門名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt部門名.Text = "あああああ"
        Me.txt部門名.Top = 0.00000005960464!
        Me.txt部門名.Width = 0.8661417!
        '
        'txt当月経費金額
        '
        Me.txt当月経費金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月経費金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月経費金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月経費金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月経費金額.Height = 0.2755905!
        Me.txt当月経費金額.Left = 2.755906!
        Me.txt当月経費金額.Name = "txt当月経費金額"
        Me.txt当月経費金額.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月経費金額.Text = "999,999,999"
        Me.txt当月経費金額.Top = 0.0000001192093!
        Me.txt当月経費金額.Width = 0.7480315!
        '
        'txt累計仕入金額
        '
        Me.txt累計仕入金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計仕入金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計仕入金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計仕入金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計仕入金額.Height = 0.2755905!
        Me.txt累計仕入金額.Left = 6.850394!
        Me.txt累計仕入金額.Name = "txt累計仕入金額"
        Me.txt累計仕入金額.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt累計仕入金額.Text = "999,999,999"
        Me.txt累計仕入金額.Top = 0.0000002980233!
        Me.txt累計仕入金額.Width = 0.9448819!
        '
        'txt当月人件費
        '
        Me.txt当月人件費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月人件費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月人件費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月人件費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月人件費.Height = 0.2755905!
        Me.txt当月人件費.Left = 3.503937!
        Me.txt当月人件費.Name = "txt当月人件費"
        Me.txt当月人件費.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月人件費.Text = "999,999,999"
        Me.txt当月人件費.Top = 0.0000002980233!
        Me.txt当月人件費.Width = 0.7283465!
        '
        'txt当月粗利
        '
        Me.txt当月粗利.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月粗利.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月粗利.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月粗利.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月粗利.Height = 0.2755905!
        Me.txt当月粗利.Left = 4.96063!
        Me.txt当月粗利.Name = "txt当月粗利"
        Me.txt当月粗利.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月粗利.Text = "999,999,999"
        Me.txt当月粗利.Top = 0.0000005066395!
        Me.txt当月粗利.Width = 0.9448819!
        '
        'txt累計人件費
        '
        Me.txt累計人件費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計人件費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計人件費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計人件費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計人件費.Height = 0.2755905!
        Me.txt累計人件費.Left = 8.543307!
        Me.txt累計人件費.Name = "txt累計人件費"
        Me.txt累計人件費.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt累計人件費.Text = "999,999,999"
        Me.txt累計人件費.Top = 3.552714E-15!
        Me.txt累計人件費.Width = 0.7283465!
        '
        'txt累計粗利
        '
        Me.txt累計粗利.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計粗利.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計粗利.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計粗利.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計粗利.Height = 0.2755905!
        Me.txt累計粗利.Left = 10.0!
        Me.txt累計粗利.Name = "txt累計粗利"
        Me.txt累計粗利.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt累計粗利.Text = "999,999,999"
        Me.txt累計粗利.Top = 3.552714E-15!
        Me.txt累計粗利.Width = 0.9448819!
        '
        'txt累計固定経費
        '
        Me.txt累計固定経費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計固定経費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計固定経費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計固定経費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計固定経費.Height = 0.2755905!
        Me.txt累計固定経費.Left = 9.271654!
        Me.txt累計固定経費.Name = "txt累計固定経費"
        Me.txt累計固定経費.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt累計固定経費.Text = "999,999,999"
        Me.txt累計固定経費.Top = 3.552714E-15!
        Me.txt累計固定経費.Width = 0.7283465!
        '
        'txt累計売上金額
        '
        Me.txt累計売上金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計売上金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計売上金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計売上金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計売上金額.Height = 0.2755906!
        Me.txt累計売上金額.Left = 5.905512!
        Me.txt累計売上金額.Name = "txt累計売上金額"
        Me.txt累計売上金額.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt累計売上金額.Text = "999,999,999"
        Me.txt累計売上金額.Top = 0.0!
        Me.txt累計売上金額.Width = 0.944882!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNow, Me.txt頁})
        Me.PageHeader.Height = 0.2755905!
        Me.PageHeader.Name = "PageHeader"
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
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdr
        '
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt対象年月, Me.txt部門別売上仕入集計表, Me.lbl累計, Me.lbl当月, Me.lbl部門名, Me.lbl当月売上金額, Me.lbl累計売上金額, Me.lbl当月仕入金額, Me.lbl当月人件費, Me.lbl当月粗利, Me.lbl当月経費金額, Me.lbl当月固定経費, Me.lbl累計仕入金額, Me.lbl累計経費金額, Me.lbl累計人件費, Me.lbl累計固定経費, Me.lbl累計粗利})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.972441!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txt対象年月
        '
        Me.txt対象年月.Height = 0.2362205!
        Me.txt対象年月.Left = 0.0!
        Me.txt対象年月.Name = "txt対象年月"
        Me.txt対象年月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt対象年月.Text = "YY/MM月分"
        Me.txt対象年月.Top = 0.0!
        Me.txt対象年月.Width = 1.181102!
        '
        'txt部門別売上仕入集計表
        '
        Me.txt部門別売上仕入集計表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt部門別売上仕入集計表.CharacterSpacing = 3.0!
        Me.txt部門別売上仕入集計表.Height = 0.3484252!
        Me.txt部門別売上仕入集計表.Left = 3.305512!
        Me.txt部門別売上仕入集計表.Name = "txt部門別売上仕入集計表"
        Me.txt部門別売上仕入集計表.Style = "font-family: ＭＳ Ｐゴシック; font-size: 14pt; font-weight: bold; text-align: center; ve" & _
    "rtical-align: bottom; ddo-char-set: 1"
        Me.txt部門別売上仕入集計表.Text = "部門別売上・仕入集計表"
        Me.txt部門別売上仕入集計表.Top = 0.0!
        Me.txt部門別売上仕入集計表.Width = 3.031496!
        '
        'lbl累計
        '
        Me.lbl累計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計.Height = 0.2362205!
        Me.lbl累計.HyperLink = Nothing
        Me.lbl累計.Left = 5.905512!
        Me.lbl累計.Name = "lbl累計"
        Me.lbl累計.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl累計.Text = "累計"
        Me.lbl累計.Top = 0.480315!
        Me.lbl累計.Width = 5.03937!
        '
        'lbl当月
        '
        Me.lbl当月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月.Height = 0.2362205!
        Me.lbl当月.HyperLink = Nothing
        Me.lbl当月.Left = 0.866142!
        Me.lbl当月.Name = "lbl当月"
        Me.lbl当月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl当月.Text = "当月"
        Me.lbl当月.Top = 0.480315!
        Me.lbl当月.Width = 5.03937!
        '
        'lbl部門名
        '
        Me.lbl部門名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl部門名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl部門名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl部門名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl部門名.Height = 0.492126!
        Me.lbl部門名.HyperLink = Nothing
        Me.lbl部門名.Left = 0.0000002384186!
        Me.lbl部門名.Name = "lbl部門名"
        Me.lbl部門名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl部門名.Text = "部門名"
        Me.lbl部門名.Top = 0.480315!
        Me.lbl部門名.Width = 0.8661417!
        '
        'lbl当月売上金額
        '
        Me.lbl当月売上金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月売上金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月売上金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月売上金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月売上金額.Height = 0.2559055!
        Me.lbl当月売上金額.HyperLink = Nothing
        Me.lbl当月売上金額.Left = 0.866142!
        Me.lbl当月売上金額.Name = "lbl当月売上金額"
        Me.lbl当月売上金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl当月売上金額.Text = "売上金額"
        Me.lbl当月売上金額.Top = 0.7165354!
        Me.lbl当月売上金額.Width = 0.9448819!
        '
        'lbl累計売上金額
        '
        Me.lbl累計売上金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計売上金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計売上金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計売上金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計売上金額.Height = 0.2559055!
        Me.lbl累計売上金額.HyperLink = Nothing
        Me.lbl累計売上金額.Left = 5.905512!
        Me.lbl累計売上金額.Name = "lbl累計売上金額"
        Me.lbl累計売上金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl累計売上金額.Text = "売上金額"
        Me.lbl累計売上金額.Top = 0.7165355!
        Me.lbl累計売上金額.Width = 0.9448819!
        '
        'lbl当月仕入金額
        '
        Me.lbl当月仕入金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月仕入金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月仕入金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月仕入金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月仕入金額.Height = 0.2559055!
        Me.lbl当月仕入金額.HyperLink = Nothing
        Me.lbl当月仕入金額.Left = 1.811024!
        Me.lbl当月仕入金額.Name = "lbl当月仕入金額"
        Me.lbl当月仕入金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl当月仕入金額.Text = "仕入金額"
        Me.lbl当月仕入金額.Top = 0.7165354!
        Me.lbl当月仕入金額.Width = 0.9448819!
        '
        'lbl当月人件費
        '
        Me.lbl当月人件費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月人件費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月人件費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月人件費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月人件費.Height = 0.2559055!
        Me.lbl当月人件費.HyperLink = Nothing
        Me.lbl当月人件費.Left = 3.503937!
        Me.lbl当月人件費.Name = "lbl当月人件費"
        Me.lbl当月人件費.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl当月人件費.Text = "人件費"
        Me.lbl当月人件費.Top = 0.7165354!
        Me.lbl当月人件費.Width = 0.7283465!
        '
        'lbl当月粗利
        '
        Me.lbl当月粗利.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月粗利.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月粗利.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月粗利.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月粗利.Height = 0.2559055!
        Me.lbl当月粗利.HyperLink = Nothing
        Me.lbl当月粗利.Left = 4.96063!
        Me.lbl当月粗利.Name = "lbl当月粗利"
        Me.lbl当月粗利.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl当月粗利.Text = "粗利"
        Me.lbl当月粗利.Top = 0.7165355!
        Me.lbl当月粗利.Width = 0.9448819!
        '
        'lbl当月経費金額
        '
        Me.lbl当月経費金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月経費金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月経費金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月経費金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月経費金額.Height = 0.2559055!
        Me.lbl当月経費金額.HyperLink = Nothing
        Me.lbl当月経費金額.Left = 2.755906!
        Me.lbl当月経費金額.Name = "lbl当月経費金額"
        Me.lbl当月経費金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl当月経費金額.Text = "経費金額"
        Me.lbl当月経費金額.Top = 0.7165354!
        Me.lbl当月経費金額.Width = 0.7480315!
        '
        'lbl当月固定経費
        '
        Me.lbl当月固定経費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月固定経費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月固定経費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月固定経費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月固定経費.Height = 0.2559055!
        Me.lbl当月固定経費.HyperLink = Nothing
        Me.lbl当月固定経費.Left = 4.232284!
        Me.lbl当月固定経費.Name = "lbl当月固定経費"
        Me.lbl当月固定経費.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl当月固定経費.Text = "固定経費"
        Me.lbl当月固定経費.Top = 0.7165355!
        Me.lbl当月固定経費.Width = 0.7283465!
        '
        'lbl累計仕入金額
        '
        Me.lbl累計仕入金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計仕入金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計仕入金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計仕入金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計仕入金額.Height = 0.2559055!
        Me.lbl累計仕入金額.HyperLink = Nothing
        Me.lbl累計仕入金額.Left = 6.850394!
        Me.lbl累計仕入金額.Name = "lbl累計仕入金額"
        Me.lbl累計仕入金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl累計仕入金額.Text = "仕入金額"
        Me.lbl累計仕入金額.Top = 0.7165355!
        Me.lbl累計仕入金額.Width = 0.9448819!
        '
        'lbl累計経費金額
        '
        Me.lbl累計経費金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計経費金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計経費金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計経費金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計経費金額.Height = 0.2559055!
        Me.lbl累計経費金額.HyperLink = Nothing
        Me.lbl累計経費金額.Left = 7.795276!
        Me.lbl累計経費金額.Name = "lbl累計経費金額"
        Me.lbl累計経費金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl累計経費金額.Text = "経費金額"
        Me.lbl累計経費金額.Top = 0.7165354!
        Me.lbl累計経費金額.Width = 0.7480315!
        '
        'lbl累計人件費
        '
        Me.lbl累計人件費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計人件費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計人件費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計人件費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計人件費.Height = 0.2559055!
        Me.lbl累計人件費.HyperLink = Nothing
        Me.lbl累計人件費.Left = 8.543307!
        Me.lbl累計人件費.Name = "lbl累計人件費"
        Me.lbl累計人件費.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl累計人件費.Text = "人件費"
        Me.lbl累計人件費.Top = 0.7165354!
        Me.lbl累計人件費.Width = 0.7283465!
        '
        'lbl累計固定経費
        '
        Me.lbl累計固定経費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計固定経費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計固定経費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計固定経費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計固定経費.Height = 0.2559055!
        Me.lbl累計固定経費.HyperLink = Nothing
        Me.lbl累計固定経費.Left = 9.271654!
        Me.lbl累計固定経費.Name = "lbl累計固定経費"
        Me.lbl累計固定経費.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl累計固定経費.Text = "固定経費"
        Me.lbl累計固定経費.Top = 0.7165354!
        Me.lbl累計固定経費.Width = 0.7283465!
        '
        'lbl累計粗利
        '
        Me.lbl累計粗利.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計粗利.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計粗利.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計粗利.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計粗利.Height = 0.2559055!
        Me.lbl累計粗利.HyperLink = Nothing
        Me.lbl累計粗利.Left = 10.0!
        Me.lbl累計粗利.Name = "lbl累計粗利"
        Me.lbl累計粗利.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl累計粗利.Text = "粗利"
        Me.lbl累計粗利.Top = 0.7165354!
        Me.lbl累計粗利.Width = 0.9448819!
        '
        'grpFtr計
        '
        Me.grpFtr計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt累計経費合計金額, Me.txt累計仕入合計金額, Me.txt当月固定経費合計, Me.txt当月経費合計金額, Me.txt当月粗利合計, Me.txt当月売上合計金額, Me.Label2, Me.TextBox19, Me.txt当月人件費合計, Me.txt当月仕入合計金額, Me.txt累計人件費合計, Me.txt固定経費合計, Me.txt累計粗利合計, Me.txt累計売上合計金額})
        Me.grpFtr計.Height = 0.2755905!
        Me.grpFtr計.Name = "grpFtr計"
        '
        'txt累計経費合計金額
        '
        Me.txt累計経費合計金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計経費合計金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計経費合計金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計経費合計金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計経費合計金額.Height = 0.2755905!
        Me.txt累計経費合計金額.Left = 7.795276!
        Me.txt累計経費合計金額.Name = "txt累計経費合計金額"
        Me.txt累計経費合計金額.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt累計経費合計金額.Text = "999,999,999"
        Me.txt累計経費合計金額.Top = 3.552714E-15!
        Me.txt累計経費合計金額.Width = 0.7480315!
        '
        'txt累計仕入合計金額
        '
        Me.txt累計仕入合計金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計仕入合計金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計仕入合計金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計仕入合計金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計仕入合計金額.Height = 0.2755905!
        Me.txt累計仕入合計金額.Left = 6.850394!
        Me.txt累計仕入合計金額.Name = "txt累計仕入合計金額"
        Me.txt累計仕入合計金額.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt累計仕入合計金額.Text = "999,999,999"
        Me.txt累計仕入合計金額.Top = 0.0000002980233!
        Me.txt累計仕入合計金額.Width = 0.9448819!
        '
        'txt当月固定経費合計
        '
        Me.txt当月固定経費合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月固定経費合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月固定経費合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月固定経費合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月固定経費合計.Height = 0.2755905!
        Me.txt当月固定経費合計.Left = 4.232284!
        Me.txt当月固定経費合計.Name = "txt当月固定経費合計"
        Me.txt当月固定経費合計.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月固定経費合計.Text = "999,999,999"
        Me.txt当月固定経費合計.Top = 0.0000002980233!
        Me.txt当月固定経費合計.Width = 0.7283465!
        '
        'txt当月経費合計金額
        '
        Me.txt当月経費合計金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月経費合計金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月経費合計金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月経費合計金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月経費合計金額.Height = 0.2755905!
        Me.txt当月経費合計金額.Left = 2.755906!
        Me.txt当月経費合計金額.Name = "txt当月経費合計金額"
        Me.txt当月経費合計金額.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月経費合計金額.Text = "999,999,999" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt当月経費合計金額.Top = 0.0000001192093!
        Me.txt当月経費合計金額.Width = 0.7480315!
        '
        'txt当月粗利合計
        '
        Me.txt当月粗利合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月粗利合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月粗利合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月粗利合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月粗利合計.Height = 0.2755905!
        Me.txt当月粗利合計.Left = 4.96063!
        Me.txt当月粗利合計.Name = "txt当月粗利合計"
        Me.txt当月粗利合計.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月粗利合計.Text = "999,999,999"
        Me.txt当月粗利合計.Top = 0.0000005066395!
        Me.txt当月粗利合計.Width = 0.9448819!
        '
        'txt当月売上合計金額
        '
        Me.txt当月売上合計金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月売上合計金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月売上合計金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月売上合計金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月売上合計金額.Height = 0.2755905!
        Me.txt当月売上合計金額.Left = 0.8661417!
        Me.txt当月売上合計金額.Name = "txt当月売上合計金額"
        Me.txt当月売上合計金額.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月売上合計金額.Text = "999,999,999"
        Me.txt当月売上合計金額.Top = 0.0!
        Me.txt当月売上合計金額.Width = 0.9448819!
        '
        'Label2
        '
        Me.Label2.Height = 0.1968504!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.115748!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "center; vertical-align: bottom; ddo-char-set: 1"
        Me.Label2.Text = "＊合計"
        Me.Label2.Top = 0.0480315!
        Me.Label2.Width = 0.6519687!
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
        Me.TextBox19.Width = 0.8661417!
        '
        'txt当月人件費合計
        '
        Me.txt当月人件費合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月人件費合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月人件費合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月人件費合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月人件費合計.Height = 0.2755905!
        Me.txt当月人件費合計.Left = 3.503937!
        Me.txt当月人件費合計.Name = "txt当月人件費合計"
        Me.txt当月人件費合計.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月人件費合計.Text = "999,999,999"
        Me.txt当月人件費合計.Top = 3.552714E-15!
        Me.txt当月人件費合計.Width = 0.7283465!
        '
        'txt当月仕入合計金額
        '
        Me.txt当月仕入合計金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月仕入合計金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月仕入合計金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月仕入合計金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月仕入合計金額.Height = 0.2755905!
        Me.txt当月仕入合計金額.Left = 1.811024!
        Me.txt当月仕入合計金額.Name = "txt当月仕入合計金額"
        Me.txt当月仕入合計金額.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月仕入合計金額.Text = "999,999,999"
        Me.txt当月仕入合計金額.Top = 3.552714E-15!
        Me.txt当月仕入合計金額.Width = 0.9448819!
        '
        'txt累計人件費合計
        '
        Me.txt累計人件費合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計人件費合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計人件費合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計人件費合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計人件費合計.Height = 0.2755905!
        Me.txt累計人件費合計.Left = 8.543307!
        Me.txt累計人件費合計.Name = "txt累計人件費合計"
        Me.txt累計人件費合計.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt累計人件費合計.Text = "999,999,999"
        Me.txt累計人件費合計.Top = 3.552714E-15!
        Me.txt累計人件費合計.Width = 0.7283465!
        '
        'txt固定経費合計
        '
        Me.txt固定経費合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費合計.Height = 0.2755905!
        Me.txt固定経費合計.Left = 9.271654!
        Me.txt固定経費合計.Name = "txt固定経費合計"
        Me.txt固定経費合計.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt固定経費合計.Text = "999,999,999"
        Me.txt固定経費合計.Top = 3.552714E-15!
        Me.txt固定経費合計.Width = 0.7283465!
        '
        'txt累計粗利合計
        '
        Me.txt累計粗利合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計粗利合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計粗利合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計粗利合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計粗利合計.Height = 0.2755905!
        Me.txt累計粗利合計.Left = 10.0!
        Me.txt累計粗利合計.Name = "txt累計粗利合計"
        Me.txt累計粗利合計.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt累計粗利合計.Text = "999,999,999"
        Me.txt累計粗利合計.Top = 3.552714E-15!
        Me.txt累計粗利合計.Width = 0.9448819!
        '
        'txt累計売上合計金額
        '
        Me.txt累計売上合計金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計売上合計金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計売上合計金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計売上合計金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt累計売上合計金額.Height = 0.2755906!
        Me.txt累計売上合計金額.Left = 5.905512!
        Me.txt累計売上合計金額.Name = "txt累計売上合計金額"
        Me.txt累計売上合計金額.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt累計売上合計金額.Text = "999,999,999"
        Me.txt累計売上合計金額.Top = 0.0!
        Me.txt累計売上合計金額.Width = 0.944882!
        '
        'DepartmentSalesPurchase
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.94488!
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
        CType(Me.txt当月仕入金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt累計経費金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tx当月売上金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月固定経費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt部門名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月経費金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt累計仕入金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月人件費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月粗利, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt累計人件費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt累計粗利, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt累計固定経費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt累計売上金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt部門別売上仕入集計表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl累計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl当月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl部門名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl当月売上金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl累計売上金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl当月仕入金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl当月人件費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl当月粗利, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl当月経費金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl当月固定経費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl累計仕入金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl累計経費金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl累計人件費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl累計固定経費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl累計粗利, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt累計経費合計金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt累計仕入合計金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月固定経費合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月経費合計金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月粗利合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月売上合計金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月人件費合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月仕入合計金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt累計人件費合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt固定経費合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt累計粗利合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt累計売上合計金額, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt当月仕入金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt累計経費金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents tx当月売上金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当月固定経費 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt部門名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当月経費金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt累計仕入金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当月人件費 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当月粗利 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt対象年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt部門別売上仕入集計表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl累計 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl当月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl部門名 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt累計経費合計金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt累計仕入合計金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当月固定経費合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当月経費合計金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当月粗利合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当月売上合計金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当月人件費合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当月仕入合計金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt累計人件費 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt累計粗利 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt累計固定経費 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt累計人件費合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt固定経費合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt累計粗利合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl当月売上金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl累計売上金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl当月仕入金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl当月人件費 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl当月粗利 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl当月経費金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl当月固定経費 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl累計仕入金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl累計経費金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl累計人件費 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl累計固定経費 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl累計粗利 As DataDynamics.ActiveReports.Label
    Private WithEvents txt累計売上金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt累計売上合計金額 As DataDynamics.ActiveReports.TextBox
End Class
