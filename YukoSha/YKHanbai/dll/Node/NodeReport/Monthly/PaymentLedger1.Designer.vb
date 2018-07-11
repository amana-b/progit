<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PaymentLedger1
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PaymentLedger1))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt伝票区分 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当月残高 = New DataDynamics.ActiveReports.TextBox()
        Me.txt伝票No = New DataDynamics.ActiveReports.TextBox()
        Me.txt単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txt対象年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名摘要 = New DataDynamics.ActiveReports.TextBox()
        Me.txt出金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt数量 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt納入場所 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.txt繰越残高 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtHdr対象年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入先元帳 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl伝票区分 = New DataDynamics.ActiveReports.Label()
        Me.lbl当月残高 = New DataDynamics.ActiveReports.Label()
        Me.lbl伝票No = New DataDynamics.ActiveReports.Label()
        Me.lbl商品名摘要 = New DataDynamics.ActiveReports.Label()
        Me.lbl対象年月 = New DataDynamics.ActiveReports.Label()
        Me.lbl単価 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr対象年月 = New DataDynamics.ActiveReports.Label()
        Me.lbl出金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl数量 = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl納入場所 = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入先 = New DataDynamics.ActiveReports.Label()
        Me.txt仕入先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入先名 = New DataDynamics.ActiveReports.TextBox()
        Me.grpFtr計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt当月残高合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt出金合計金額 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入金額合計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        CType(Me.txt伝票区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt伝票No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名摘要, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt出金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt納入場所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt繰越残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先元帳, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl伝票区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl当月残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl伝票No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl商品名摘要, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl出金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl納入場所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入先, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当月残高合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt出金合計金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入金額合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt伝票区分, Me.txt当月残高, Me.txt伝票No, Me.txt単価, Me.txt対象年月, Me.txt商品名摘要, Me.txt出金額, Me.txt数量, Me.txt仕入金額, Me.txt納入場所, Me.TextBox1, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox13, Me.txt繰越残高, Me.Label2})
        Me.Detail.Height = 0.4330709!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt伝票区分
        '
        Me.txt伝票区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票区分.Height = 0.2165354!
        Me.txt伝票区分.Left = 1.141732!
        Me.txt伝票区分.Name = "txt伝票区分"
        Me.txt伝票区分.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt伝票区分.Text = "あああ"
        Me.txt伝票区分.Top = 0.2165354!
        Me.txt伝票区分.Width = 0.7086614!
        '
        'txt当月残高
        '
        Me.txt当月残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高.Height = 0.2165354!
        Me.txt当月残高.Left = 9.488189!
        Me.txt当月残高.Name = "txt当月残高"
        Me.txt当月残高.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月残高.Text = "999,999,999"
        Me.txt当月残高.Top = 0.2165368!
        Me.txt当月残高.Width = 0.8661417!
        '
        'txt伝票No
        '
        Me.txt伝票No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Height = 0.2165354!
        Me.txt伝票No.Left = 0.5905513!
        Me.txt伝票No.Name = "txt伝票No"
        Me.txt伝票No.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt伝票No.Text = "123456"
        Me.txt伝票No.Top = 0.2165356!
        Me.txt伝票No.Width = 0.5511811!
        '
        'txt単価
        '
        Me.txt単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Height = 0.2165354!
        Me.txt単価.Left = 6.791338!
        Me.txt単価.Name = "txt単価"
        Me.txt単価.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt単価.Text = "999.99"
        Me.txt単価.Top = 0.216536!
        Me.txt単価.Width = 0.9448819!
        '
        'txt対象年月
        '
        Me.txt対象年月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対象年月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対象年月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対象年月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対象年月.Height = 0.2165354!
        Me.txt対象年月.Left = 0.0000001192093!
        Me.txt対象年月.Name = "txt対象年月"
        Me.txt対象年月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt対象年月.Text = "YY/MM/DD"
        Me.txt対象年月.Top = 0.2165355!
        Me.txt対象年月.Width = 0.5905512!
        '
        'txt商品名摘要
        '
        Me.txt商品名摘要.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名摘要.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名摘要.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名摘要.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名摘要.Height = 0.2165354!
        Me.txt商品名摘要.Left = 1.850394!
        Me.txt商品名摘要.Name = "txt商品名摘要"
        Me.txt商品名摘要.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: justify; vertical-align: bottom" & _
    "; ddo-char-set: 1"
        Me.txt商品名摘要.Text = "あああああいいいいいうううううえええええ"
        Me.txt商品名摘要.Top = 0.2165358!
        Me.txt商品名摘要.Width = 3.011811!
        '
        'txt出金額
        '
        Me.txt出金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出金額.Height = 0.2165354!
        Me.txt出金額.Left = 8.622047!
        Me.txt出金額.Name = "txt出金額"
        Me.txt出金額.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt出金額.Text = "999,999,999"
        Me.txt出金額.Top = 0.2165361!
        Me.txt出金額.Width = 0.8661417!
        '
        'txt数量
        '
        Me.txt数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Height = 0.2165354!
        Me.txt数量.Left = 5.964567!
        Me.txt数量.Name = "txt数量"
        Me.txt数量.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt数量.Text = "999,999"
        Me.txt数量.Top = 0.216536!
        Me.txt数量.Width = 0.8267716!
        '
        'txt仕入金額
        '
        Me.txt仕入金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入金額.Height = 0.2165354!
        Me.txt仕入金額.Left = 7.73622!
        Me.txt仕入金額.Name = "txt仕入金額"
        Me.txt仕入金額.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入金額.Text = "999,999,999"
        Me.txt仕入金額.Top = 0.2165361!
        Me.txt仕入金額.Width = 0.8858268!
        '
        'txt納入場所
        '
        Me.txt納入場所.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納入場所.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納入場所.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納入場所.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納入場所.Height = 0.2165354!
        Me.txt納入場所.Left = 4.862205!
        Me.txt納入場所.Name = "txt納入場所"
        Me.txt納入場所.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: left; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt納入場所.Text = "あああああ"
        Me.txt納入場所.Top = 0.2165357!
        Me.txt納入場所.Width = 1.102362!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.2165354!
        Me.TextBox1.Left = 0.0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.00000005960464!
        Me.TextBox1.Width = 0.5905511!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Height = 0.2165354!
        Me.TextBox5.Left = 0.5905511!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0.0000001788139!
        Me.TextBox5.Width = 0.551181!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Height = 0.2165354!
        Me.TextBox6.Left = 1.141732!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 0.7086611!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Height = 0.2165354!
        Me.TextBox7.Left = 1.850394!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: justify; vertical-align: bottom" & _
    "; ddo-char-set: 1"
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0.0000003576279!
        Me.TextBox7.Width = 3.011811!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Height = 0.2165354!
        Me.TextBox9.Left = 4.862205!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: left; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0.0000002384186!
        Me.TextBox9.Width = 1.102362!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Height = 0.2165354!
        Me.TextBox10.Left = 5.964566!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox10.Text = Nothing
        Me.TextBox10.Top = 0.0000005364418!
        Me.TextBox10.Width = 0.8267716!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Height = 0.2165354!
        Me.TextBox11.Left = 6.791338!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 0.0000005364418!
        Me.TextBox11.Width = 0.944882!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Height = 0.2165354!
        Me.TextBox12.Left = 7.736222!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox12.Text = Nothing
        Me.TextBox12.Top = 0.0000007152557!
        Me.TextBox12.Width = 0.8858271!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Height = 0.2165354!
        Me.TextBox13.Left = 8.622048!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox13.Text = Nothing
        Me.TextBox13.Top = 0.0000005364418!
        Me.TextBox13.Width = 0.8661417!
        '
        'txt繰越残高
        '
        Me.txt繰越残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt繰越残高.Height = 0.2165354!
        Me.txt繰越残高.Left = 9.488188!
        Me.txt繰越残高.Name = "txt繰越残高"
        Me.txt繰越残高.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt繰越残高.Text = "999,999,999"
        Me.txt繰越残高.Top = 0.000001370907!
        Me.txt繰越残高.Width = 0.8661417!
        '
        'Label2
        '
        Me.Label2.Height = 0.2362205!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 8.637009!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label2.Text = "前月より繰越"
        Me.Label2.Top = 0.02047244!
        Me.Label2.Width = 0.8661417!
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
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtHdr対象年月, Me.txt仕入先元帳, Me.lbl伝票区分, Me.lbl当月残高, Me.lbl伝票No, Me.lbl商品名摘要, Me.lbl対象年月, Me.lbl単価, Me.lblHdr対象年月, Me.lbl出金額, Me.lbl数量, Me.lbl仕入金額, Me.lbl納入場所, Me.lbl仕入先, Me.txt仕入先CD, Me.txt仕入先名})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 1.318898!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txtHdr対象年月
        '
        Me.txtHdr対象年月.Height = 0.2362205!
        Me.txtHdr対象年月.Left = 0.7874014!
        Me.txtHdr対象年月.Name = "txtHdr対象年月"
        Me.txtHdr対象年月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtHdr対象年月.Text = "YY/MM月分"
        Me.txtHdr対象年月.Top = 0.0!
        Me.txtHdr対象年月.Width = 1.181102!
        '
        'txt仕入先元帳
        '
        Me.txt仕入先元帳.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt仕入先元帳.CharacterSpacing = 10.0!
        Me.txt仕入先元帳.Height = 0.2755905!
        Me.txt仕入先元帳.Left = 4.125197!
        Me.txt仕入先元帳.Name = "txt仕入先元帳"
        Me.txt仕入先元帳.Style = "font-family: ＭＳ Ｐゴシック; font-size: 14pt; font-weight: bold; text-align: center; ve" & _
    "rtical-align: bottom; ddo-char-set: 1"
        Me.txt仕入先元帳.Text = "仕入先 元帳"
        Me.txt仕入先元帳.Top = 0.0!
        Me.txt仕入先元帳.Width = 2.72559!
        '
        'lbl伝票区分
        '
        Me.lbl伝票区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票区分.Height = 0.2755905!
        Me.lbl伝票区分.HyperLink = Nothing
        Me.lbl伝票区分.Left = 1.141732!
        Me.lbl伝票区分.Name = "lbl伝票区分"
        Me.lbl伝票区分.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl伝票区分.Text = "伝票区分"
        Me.lbl伝票区分.Top = 1.043307!
        Me.lbl伝票区分.Width = 0.7086614!
        '
        'lbl当月残高
        '
        Me.lbl当月残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当月残高.Height = 0.2755905!
        Me.lbl当月残高.HyperLink = Nothing
        Me.lbl当月残高.Left = 9.488189!
        Me.lbl当月残高.Name = "lbl当月残高"
        Me.lbl当月残高.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl当月残高.Text = "当月残高"
        Me.lbl当月残高.Top = 1.043307!
        Me.lbl当月残高.Width = 0.8661413!
        '
        'lbl伝票No
        '
        Me.lbl伝票No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Height = 0.2755905!
        Me.lbl伝票No.HyperLink = Nothing
        Me.lbl伝票No.Left = 0.5905514!
        Me.lbl伝票No.Name = "lbl伝票No"
        Me.lbl伝票No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl伝票No.Text = "伝票No"
        Me.lbl伝票No.Top = 1.043307!
        Me.lbl伝票No.Width = 0.5511811!
        '
        'lbl商品名摘要
        '
        Me.lbl商品名摘要.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名摘要.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名摘要.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名摘要.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名摘要.CharacterSpacing = 10.0!
        Me.lbl商品名摘要.Height = 0.2755905!
        Me.lbl商品名摘要.HyperLink = Nothing
        Me.lbl商品名摘要.Left = 1.850394!
        Me.lbl商品名摘要.Name = "lbl商品名摘要"
        Me.lbl商品名摘要.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbl商品名摘要.Text = "　　 商品名/摘要"
        Me.lbl商品名摘要.Top = 1.043307!
        Me.lbl商品名摘要.Width = 3.011811!
        '
        'lbl対象年月
        '
        Me.lbl対象年月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl対象年月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl対象年月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl対象年月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl対象年月.Height = 0.2755905!
        Me.lbl対象年月.HyperLink = Nothing
        Me.lbl対象年月.Left = 0.0000002384186!
        Me.lbl対象年月.Name = "lbl対象年月"
        Me.lbl対象年月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl対象年月.Text = "年月日"
        Me.lbl対象年月.Top = 1.043307!
        Me.lbl対象年月.Width = 0.5905512!
        '
        'lbl単価
        '
        Me.lbl単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.CharacterSpacing = 10.0!
        Me.lbl単価.Height = 0.2755905!
        Me.lbl単価.HyperLink = Nothing
        Me.lbl単価.Left = 6.791339!
        Me.lbl単価.Name = "lbl単価"
        Me.lbl単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl単価.Text = "単価"
        Me.lbl単価.Top = 1.043307!
        Me.lbl単価.Width = 0.9448819!
        '
        'lblHdr対象年月
        '
        Me.lblHdr対象年月.Height = 0.2362205!
        Me.lblHdr対象年月.HyperLink = Nothing
        Me.lblHdr対象年月.Left = 0.0!
        Me.lblHdr対象年月.Name = "lblHdr対象年月"
        Me.lblHdr対象年月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdr対象年月.Text = "対象年月"
        Me.lblHdr対象年月.Top = 0.0!
        Me.lblHdr対象年月.Width = 0.7874014!
        '
        'lbl出金額
        '
        Me.lbl出金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出金額.CharacterSpacing = 1.0!
        Me.lbl出金額.Height = 0.2755905!
        Me.lbl出金額.HyperLink = Nothing
        Me.lbl出金額.Left = 8.622047!
        Me.lbl出金額.Name = "lbl出金額"
        Me.lbl出金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl出金額.Text = "出金額"
        Me.lbl出金額.Top = 1.043307!
        Me.lbl出金額.Width = 0.8661413!
        '
        'lbl数量
        '
        Me.lbl数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.CharacterSpacing = 10.0!
        Me.lbl数量.Height = 0.2755905!
        Me.lbl数量.HyperLink = Nothing
        Me.lbl数量.Left = 5.964567!
        Me.lbl数量.Name = "lbl数量"
        Me.lbl数量.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl数量.Text = "数量"
        Me.lbl数量.Top = 1.043307!
        Me.lbl数量.Width = 0.8267716!
        '
        'lbl仕入金額
        '
        Me.lbl仕入金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入金額.CharacterSpacing = 5.0!
        Me.lbl仕入金額.Height = 0.2755905!
        Me.lbl仕入金額.HyperLink = Nothing
        Me.lbl仕入金額.Left = 7.736221!
        Me.lbl仕入金額.Name = "lbl仕入金額"
        Me.lbl仕入金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl仕入金額.Text = "仕入金額"
        Me.lbl仕入金額.Top = 1.043307!
        Me.lbl仕入金額.Width = 0.8858268!
        '
        'lbl納入場所
        '
        Me.lbl納入場所.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納入場所.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納入場所.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納入場所.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納入場所.CharacterSpacing = 3.0!
        Me.lbl納入場所.Height = 0.2755905!
        Me.lbl納入場所.HyperLink = Nothing
        Me.lbl納入場所.Left = 4.862205!
        Me.lbl納入場所.Name = "lbl納入場所"
        Me.lbl納入場所.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl納入場所.Text = "納入場所"
        Me.lbl納入場所.Top = 1.043307!
        Me.lbl納入場所.Width = 1.102362!
        '
        'lbl仕入先
        '
        Me.lbl仕入先.Height = 0.2362205!
        Me.lbl仕入先.HyperLink = Nothing
        Me.lbl仕入先.Left = 0.0!
        Me.lbl仕入先.Name = "lbl仕入先"
        Me.lbl仕入先.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl仕入先.Text = "仕入先"
        Me.lbl仕入先.Top = 0.5409449!
        Me.lbl仕入先.Width = 0.7874014!
        '
        'txt仕入先CD
        '
        Me.txt仕入先CD.Height = 0.2362205!
        Me.txt仕入先CD.Left = 0.7874014!
        Me.txt仕入先CD.Name = "txt仕入先CD"
        Me.txt仕入先CD.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt仕入先CD.Text = "123456"
        Me.txt仕入先CD.Top = 0.5409449!
        Me.txt仕入先CD.Width = 0.5905512!
        '
        'txt仕入先名
        '
        Me.txt仕入先名.Height = 0.2362205!
        Me.txt仕入先名.Left = 1.433071!
        Me.txt仕入先名.Name = "txt仕入先名"
        Me.txt仕入先名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt仕入先名.Text = "あああああいいいいいううううう"
        Me.txt仕入先名.Top = 0.5409449!
        Me.txt仕入先名.Width = 2.826772!
        '
        'grpFtr計
        '
        Me.grpFtr計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt当月残高合計, Me.txt出金合計金額, Me.TextBox4, Me.TextBox2, Me.txt仕入金額合計, Me.TextBox17, Me.TextBox19, Me.TextBox3, Me.TextBox, Me.TextBox8, Me.Label1})
        Me.grpFtr計.Height = 0.2165354!
        Me.grpFtr計.Name = "grpFtr計"
        '
        'txt当月残高合計
        '
        Me.txt当月残高合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当月残高合計.Height = 0.2165354!
        Me.txt当月残高合計.Left = 9.488189!
        Me.txt当月残高合計.Name = "txt当月残高合計"
        Me.txt当月残高合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当月残高合計.Text = "999,999,999"
        Me.txt当月残高合計.Top = 0.0000002384186!
        Me.txt当月残高合計.Width = 0.8661417!
        '
        'txt出金合計金額
        '
        Me.txt出金合計金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出金合計金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出金合計金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出金合計金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出金合計金額.Height = 0.2165354!
        Me.txt出金合計金額.Left = 8.622047!
        Me.txt出金合計金額.Name = "txt出金合計金額"
        Me.txt出金合計金額.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt出金合計金額.Text = "999,999,999"
        Me.txt出金合計金額.Top = 0.0000005364419!
        Me.txt出金合計金額.Width = 0.8661417!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Height = 0.2165354!
        Me.TextBox4.Left = 6.791338!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.0000005364419!
        Me.TextBox4.Width = 0.9448819!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Height = 0.2165354!
        Me.TextBox2.Left = 1.850394!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0000003576279!
        Me.TextBox2.Width = 3.011811!
        '
        'txt仕入金額合計
        '
        Me.txt仕入金額合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入金額合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入金額合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入金額合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入金額合計.Height = 0.2165354!
        Me.txt仕入金額合計.Left = 7.73622!
        Me.txt仕入金額合計.Name = "txt仕入金額合計"
        Me.txt仕入金額合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入金額合計.Text = "999,999,999"
        Me.txt仕入金額合計.Top = 0.0000007450581!
        Me.txt仕入金額合計.Width = 0.8858268!
        '
        'TextBox17
        '
        Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Height = 0.2165354!
        Me.TextBox17.Left = 0.5905512!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox17.Text = Nothing
        Me.TextBox17.Top = 0.0!
        Me.TextBox17.Width = 0.5511811!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Height = 0.2165354!
        Me.TextBox19.Left = 0.0!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox19.Text = Nothing
        Me.TextBox19.Top = 0.00000005960464!
        Me.TextBox19.Width = 0.5905512!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.2165354!
        Me.TextBox3.Left = 5.964567!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0000002384186!
        Me.TextBox3.Width = 0.8267716!
        '
        'TextBox
        '
        Me.TextBox.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox.Height = 0.2165354!
        Me.TextBox.Left = 1.141732!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox.Text = Nothing
        Me.TextBox.Top = 0.0!
        Me.TextBox.Width = 0.7086614!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Height = 0.2165354!
        Me.TextBox8.Left = 4.862205!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.0000002384186!
        Me.TextBox8.Width = 1.102362!
        '
        'Label1
        '
        Me.Label1.Height = 0.1771654!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 6.90315!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label1.Text = "＊仕入先計"
        Me.Label1.Top = 0.02047244!
        Me.Label1.Width = 0.7874014!
        '
        'PaymentLedger1
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.35433!
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
        CType(Me.txt伝票区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt伝票No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名摘要, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt出金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt納入場所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt繰越残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先元帳, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl伝票区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl当月残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl伝票No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl商品名摘要, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl出金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl納入場所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入先, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当月残高合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt出金合計金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入金額合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt伝票区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当月残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt伝票No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt対象年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名摘要 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt出金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt数量 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txtHdr対象年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先元帳 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl伝票区分 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl伝票No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl商品名摘要 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl対象年月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl単価 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr対象年月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl出金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl数量 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl仕入金額 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt当月残高合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt出金合計金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入金額合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt納入場所 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl納入場所 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl当月残高 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl仕入先 As DataDynamics.ActiveReports.Label
    Private WithEvents txt仕入先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt繰越残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
End Class
