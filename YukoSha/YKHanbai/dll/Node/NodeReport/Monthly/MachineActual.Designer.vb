<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MachineActual
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MachineActual))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt社外クレーム通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txtクレーム金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt実績通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt機械名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt差異 = New DataDynamics.ActiveReports.TextBox()
        Me.txt社内クレーム通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt社外クレーム金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt1日当回転数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt残業時間 = New DataDynamics.ActiveReports.TextBox()
        Me.txt工場責任クレーム金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt実績通数m = New DataDynamics.ActiveReports.TextBox()
        Me.txt実質生産通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txtアイドル時間 = New DataDynamics.ActiveReports.TextBox()
        Me.txt実働時間 = New DataDynamics.ActiveReports.TextBox()
        Me.txt稼動時間 = New DataDynamics.ActiveReports.TextBox()
        Me.txt社内クレーム通数m = New DataDynamics.ActiveReports.TextBox()
        Me.txt工場責任クレーム通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt工場責任クレーム通数m = New DataDynamics.ActiveReports.TextBox()
        Me.txt実質生産通数m = New DataDynamics.ActiveReports.TextBox()
        Me.txt社外クレーム通数m = New DataDynamics.ActiveReports.TextBox()
        Me.txt件数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt日数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt月回転数 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt対象年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者別未引当一覧表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl差異 = New DataDynamics.ActiveReports.Label()
        Me.lbl社内クレーム = New DataDynamics.ActiveReports.Label()
        Me.lbl1日当回転数 = New DataDynamics.ActiveReports.Label()
        Me.lbl機械名 = New DataDynamics.ActiveReports.Label()
        Me.lblコーター = New DataDynamics.ActiveReports.Label()
        Me.lbl残業時間 = New DataDynamics.ActiveReports.Label()
        Me.lbl社外クレーム = New DataDynamics.ActiveReports.Label()
        Me.lbl実績数量 = New DataDynamics.ActiveReports.Label()
        Me.lbl総稼動時間 = New DataDynamics.ActiveReports.Label()
        Me.lbl工場責任クレーム = New DataDynamics.ActiveReports.Label()
        Me.lbl実質生産量 = New DataDynamics.ActiveReports.Label()
        Me.lbl対象日 = New DataDynamics.ActiveReports.Label()
        Me.lbl月回転数 = New DataDynamics.ActiveReports.Label()
        Me.lbl社外クレーム数 = New DataDynamics.ActiveReports.Label()
        Me.lbl日数 = New DataDynamics.ActiveReports.Label()
        Me.lbl工場責任クレーム数 = New DataDynamics.ActiveReports.Label()
        Me.lbl社外クレーム金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl件数 = New DataDynamics.ActiveReports.Label()
        Me.lbl工場責任クレーム金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl社内クレーム数 = New DataDynamics.ActiveReports.Label()
        Me.lbl社内クレーム金額 = New DataDynamics.ActiveReports.Label()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.Label10 = New DataDynamics.ActiveReports.Label()
        Me.Label11 = New DataDynamics.ActiveReports.Label()
        Me.Label13 = New DataDynamics.ActiveReports.Label()
        Me.lbl実働時間 = New DataDynamics.ActiveReports.Label()
        Me.lblアイドル時間 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr合計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.txt合計社外クレーム通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計社内クレーム金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計実績通数 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox27 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計差異 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計社内クレーム通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計社外クレーム金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計1日当回転数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計残業時間 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計工場クレーム金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計実質通数m = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計実質生産通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計アイドル時間 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計実働時間 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計総稼働時間 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計社内クレーム通数m = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計工場責任クレーム通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計工場責任クレーム通数m = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計実質生産通数m = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計社外クレーム通数m = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計件数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計日数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計月回転数 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.grpFtr小計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.txt小計社外クレーム通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計社内クレーム金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計実績通数 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計差異 = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計社内クレーム通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計社外クレーム金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計1日当回転数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計残業時間 = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計工場責任クレーム金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計実績通数m = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計実質生産通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計アイドル時間 = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計実働時間 = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計総稼働時間 = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計社内クレーム通数m = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計工場責任クレーム通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計工場責任クレーム通数m = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計実質生産通数m = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計社外クレーム通数m = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計件数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計日数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt小計月回転数 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt社外クレーム通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtクレーム金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt実績通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt機械名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt差異, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt社内クレーム通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt社外クレーム金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1日当回転数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt残業時間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt工場責任クレーム金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt実績通数m, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt実質生産通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtアイドル時間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt実働時間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt稼動時間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt社内クレーム通数m, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt工場責任クレーム通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt工場責任クレーム通数m, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt実質生産通数m, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt社外クレーム通数m, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt日数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt月回転数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者別未引当一覧表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl差異, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl社内クレーム, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl1日当回転数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl機械名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblコーター, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl残業時間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl社外クレーム, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl実績数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl総稼動時間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl工場責任クレーム, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl実質生産量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl対象日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl月回転数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl社外クレーム数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl日数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl工場責任クレーム数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl社外クレーム金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl工場責任クレーム金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl社内クレーム数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl社内クレーム金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl実働時間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblアイドル時間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計社外クレーム通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計社内クレーム金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計実績通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計差異, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計社内クレーム通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計社外クレーム金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計1日当回転数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計残業時間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計工場クレーム金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計実質通数m, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計実質生産通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計アイドル時間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計実働時間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計総稼働時間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計社内クレーム通数m, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計工場責任クレーム通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計工場責任クレーム通数m, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計実質生産通数m, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計社外クレーム通数m, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計日数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計月回転数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計社外クレーム通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計社内クレーム金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計実績通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計差異, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計社内クレーム通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計社外クレーム金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計1日当回転数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計残業時間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計工場責任クレーム金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計実績通数m, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計実質生産通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計アイドル時間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計実働時間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計総稼働時間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計社内クレーム通数m, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計工場責任クレーム通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計工場責任クレーム通数m, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計実質生産通数m, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計社外クレーム通数m, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計日数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計月回転数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt社外クレーム通数, Me.txtクレーム金額, Me.txt実績通数, Me.txt機械名, Me.txt差異, Me.txt社内クレーム通数, Me.txt社外クレーム金額, Me.txt1日当回転数, Me.txt残業時間, Me.txt工場責任クレーム金額, Me.txt実績通数m, Me.txt実質生産通数, Me.txtアイドル時間, Me.txt実働時間, Me.txt稼動時間, Me.txt社内クレーム通数m, Me.txt工場責任クレーム通数, Me.txt工場責任クレーム通数m, Me.txt実質生産通数m, Me.txt社外クレーム通数m, Me.txt件数, Me.txt日数, Me.txt月回転数})
        Me.Detail.Height = 0.2362205!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt社外クレーム通数
        '
        Me.txt社外クレーム通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt社外クレーム通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt社外クレーム通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt社外クレーム通数.Height = 0.1181102!
        Me.txt社外クレーム通数.Left = 4.212598!
        Me.txt社外クレーム通数.Name = "txt社外クレーム通数"
        Me.txt社外クレーム通数.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt社外クレーム通数.Text = "999,999,999通"
        Me.txt社外クレーム通数.Top = 0.0!
        Me.txt社外クレーム通数.Width = 0.7086614!
        '
        'txtクレーム金額
        '
        Me.txtクレーム金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtクレーム金額.Height = 0.2362205!
        Me.txtクレーム金額.Left = 8.425196!
        Me.txtクレーム金額.Name = "txtクレーム金額"
        Me.txtクレーム金額.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txtクレーム金額.Text = "999,999"
        Me.txtクレーム金額.Top = 0.0!
        Me.txtクレーム金額.Width = 0.6102362!
        '
        'txt実績通数
        '
        Me.txt実績通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt実績通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt実績通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt実績通数.Height = 0.1181102!
        Me.txt実績通数.Left = 2.283465!
        Me.txt実績通数.Name = "txt実績通数"
        Me.txt実績通数.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt実績通数.Text = "999,999,999通"
        Me.txt実績通数.Top = 0.0!
        Me.txt実績通数.Width = 0.8661417!
        '
        'txt機械名
        '
        Me.txt機械名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt機械名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt機械名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt機械名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt機械名.Height = 0.2362205!
        Me.txt機械名.Left = 0.0!
        Me.txt機械名.Name = "txt機械名"
        Me.txt機械名.Style = "font-family: ＭＳ 明朝; font-size: 7.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt機械名.Text = "あああああ"
        Me.txt機械名.Top = 0.00000005960464!
        Me.txt機械名.Width = 0.6299213!
        '
        'txt差異
        '
        Me.txt差異.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt差異.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt差異.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt差異.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt差異.Height = 0.2362205!
        Me.txt差異.Left = 3.149606!
        Me.txt差異.Name = "txt差異"
        Me.txt差異.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt差異.Text = "999,999,999"
        Me.txt差異.Top = 0.0!
        Me.txt差異.Width = 0.7086614!
        '
        'txt社内クレーム通数
        '
        Me.txt社内クレーム通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt社内クレーム通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt社内クレーム通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt社内クレーム通数.Height = 0.1181102!
        Me.txt社内クレーム通数.Left = 7.716536!
        Me.txt社内クレーム通数.Name = "txt社内クレーム通数"
        Me.txt社内クレーム通数.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt社内クレーム通数.Text = "999,999通"
        Me.txt社内クレーム通数.Top = 0.0!
        Me.txt社内クレーム通数.Width = 0.7086614!
        '
        'txt社外クレーム金額
        '
        Me.txt社外クレーム金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt社外クレーム金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt社外クレーム金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt社外クレーム金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt社外クレーム金額.Height = 0.2362205!
        Me.txt社外クレーム金額.Left = 4.92126!
        Me.txt社外クレーム金額.Name = "txt社外クレーム金額"
        Me.txt社外クレーム金額.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt社外クレーム金額.Text = "999,999"
        Me.txt社外クレーム金額.Top = 0.0!
        Me.txt社外クレーム金額.Width = 0.6692914!
        '
        'txt1日当回転数
        '
        Me.txt1日当回転数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt1日当回転数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt1日当回転数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt1日当回転数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt1日当回転数.Height = 0.2362205!
        Me.txt1日当回転数.Left = 0.6299213!
        Me.txt1日当回転数.Name = "txt1日当回転数"
        Me.txt1日当回転数.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt1日当回転数.Text = "999,999,999"
        Me.txt1日当回転数.Top = 0.0!
        Me.txt1日当回転数.Width = 0.7283465!
        '
        'txt残業時間
        '
        Me.txt残業時間.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt残業時間.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt残業時間.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt残業時間.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt残業時間.Height = 0.2362205!
        Me.txt残業時間.Left = 10.57087!
        Me.txt残業時間.Name = "txt残業時間"
        Me.txt残業時間.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt残業時間.Text = "99:99"
        Me.txt残業時間.Top = 0.0!
        Me.txt残業時間.Width = 0.5511808!
        '
        'txt工場責任クレーム金額
        '
        Me.txt工場責任クレーム金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt工場責任クレーム金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt工場責任クレーム金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt工場責任クレーム金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt工場責任クレーム金額.Height = 0.2362205!
        Me.txt工場責任クレーム金額.Left = 7.086614!
        Me.txt工場責任クレーム金額.Name = "txt工場責任クレーム金額"
        Me.txt工場責任クレーム金額.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt工場責任クレーム金額.Text = "999,999"
        Me.txt工場責任クレーム金額.Top = 0.0!
        Me.txt工場責任クレーム金額.Width = 0.6299213!
        '
        'txt実績通数m
        '
        Me.txt実績通数m.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt実績通数m.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt実績通数m.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt実績通数m.Height = 0.1181102!
        Me.txt実績通数m.Left = 2.283465!
        Me.txt実績通数m.Name = "txt実績通数m"
        Me.txt実績通数m.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt実績通数m.Text = "999,999m"
        Me.txt実績通数m.Top = 0.1181102!
        Me.txt実績通数m.Width = 0.8661417!
        '
        'txt実質生産通数
        '
        Me.txt実質生産通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt実質生産通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt実質生産通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt実質生産通数.Height = 0.1181102!
        Me.txt実質生産通数.Left = 5.590551!
        Me.txt実質生産通数.Name = "txt実質生産通数"
        Me.txt実質生産通数.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt実質生産通数.Text = "999,999,999通"
        Me.txt実質生産通数.Top = 0.0!
        Me.txt実質生産通数.Width = 0.7874016!
        '
        'txtアイドル時間
        '
        Me.txtアイドル時間.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtアイドル時間.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtアイドル時間.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtアイドル時間.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtアイドル時間.Height = 0.2362205!
        Me.txtアイドル時間.Left = 10.05905!
        Me.txtアイドル時間.Name = "txtアイドル時間"
        Me.txtアイドル時間.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txtアイドル時間.Text = "99:99"
        Me.txtアイドル時間.Top = 0.0!
        Me.txtアイドル時間.Width = 0.511811!
        '
        'txt実働時間
        '
        Me.txt実働時間.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt実働時間.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt実働時間.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt実働時間.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt実働時間.Height = 0.2362205!
        Me.txt実働時間.Left = 9.547243!
        Me.txt実働時間.Name = "txt実働時間"
        Me.txt実働時間.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt実働時間.Text = "99:99"
        Me.txt実働時間.Top = 0.0!
        Me.txt実働時間.Width = 0.511811!
        '
        'txt稼動時間
        '
        Me.txt稼動時間.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt稼動時間.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt稼動時間.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt稼動時間.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt稼動時間.Height = 0.2362205!
        Me.txt稼動時間.Left = 9.035432!
        Me.txt稼動時間.Name = "txt稼動時間"
        Me.txt稼動時間.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt稼動時間.Text = "99:99"
        Me.txt稼動時間.Top = 0.0!
        Me.txt稼動時間.Width = 0.511811!
        '
        'txt社内クレーム通数m
        '
        Me.txt社内クレーム通数m.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt社内クレーム通数m.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt社内クレーム通数m.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt社内クレーム通数m.Height = 0.1181103!
        Me.txt社内クレーム通数m.Left = 7.716535!
        Me.txt社内クレーム通数m.Name = "txt社内クレーム通数m"
        Me.txt社内クレーム通数m.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt社内クレーム通数m.Text = "999,999m"
        Me.txt社内クレーム通数m.Top = 0.1181102!
        Me.txt社内クレーム通数m.Width = 0.7086611!
        '
        'txt工場責任クレーム通数
        '
        Me.txt工場責任クレーム通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt工場責任クレーム通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt工場責任クレーム通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt工場責任クレーム通数.Height = 0.1181103!
        Me.txt工場責任クレーム通数.Left = 6.377953!
        Me.txt工場責任クレーム通数.Name = "txt工場責任クレーム通数"
        Me.txt工場責任クレーム通数.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt工場責任クレーム通数.Text = "999,999通"
        Me.txt工場責任クレーム通数.Top = 0.0!
        Me.txt工場責任クレーム通数.Width = 0.7086611!
        '
        'txt工場責任クレーム通数m
        '
        Me.txt工場責任クレーム通数m.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt工場責任クレーム通数m.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt工場責任クレーム通数m.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt工場責任クレーム通数m.Height = 0.1181103!
        Me.txt工場責任クレーム通数m.Left = 6.377953!
        Me.txt工場責任クレーム通数m.Name = "txt工場責任クレーム通数m"
        Me.txt工場責任クレーム通数m.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt工場責任クレーム通数m.Text = "999,999m"
        Me.txt工場責任クレーム通数m.Top = 0.1181103!
        Me.txt工場責任クレーム通数m.Width = 0.7086611!
        '
        'txt実質生産通数m
        '
        Me.txt実質生産通数m.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt実質生産通数m.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt実質生産通数m.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt実質生産通数m.Height = 0.1181103!
        Me.txt実質生産通数m.Left = 5.590551!
        Me.txt実質生産通数m.Name = "txt実質生産通数m"
        Me.txt実質生産通数m.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt実質生産通数m.Text = "999,999,999m"
        Me.txt実質生産通数m.Top = 0.1181102!
        Me.txt実質生産通数m.Width = 0.7874014!
        '
        'txt社外クレーム通数m
        '
        Me.txt社外クレーム通数m.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt社外クレーム通数m.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt社外クレーム通数m.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt社外クレーム通数m.Height = 0.1181103!
        Me.txt社外クレーム通数m.Left = 4.212598!
        Me.txt社外クレーム通数m.Name = "txt社外クレーム通数m"
        Me.txt社外クレーム通数m.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt社外クレーム通数m.Text = "999,999,999m"
        Me.txt社外クレーム通数m.Top = 0.115748!
        Me.txt社外クレーム通数m.Width = 0.7086611!
        '
        'txt件数
        '
        Me.txt件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt件数.Height = 0.2362205!
        Me.txt件数.Left = 3.858268!
        Me.txt件数.Name = "txt件数"
        Me.txt件数.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt件数.Text = "999,999"
        Me.txt件数.Top = 0.0!
        Me.txt件数.Width = 0.3543307!
        '
        'txt日数
        '
        Me.txt日数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt日数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt日数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt日数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt日数.Height = 0.2362205!
        Me.txt日数.Left = 1.358268!
        Me.txt日数.Name = "txt日数"
        Me.txt日数.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt日数.Text = "99"
        Me.txt日数.Top = 0.0!
        Me.txt日数.Width = 0.2165354!
        '
        'txt月回転数
        '
        Me.txt月回転数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月回転数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月回転数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月回転数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月回転数.Height = 0.2362205!
        Me.txt月回転数.Left = 1.574803!
        Me.txt月回転数.Name = "txt月回転数"
        Me.txt月回転数.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt月回転数.Text = "999,999,999"
        Me.txt月回転数.Top = 0.0!
        Me.txt月回転数.Width = 0.7086614!
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
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt対象年月, Me.txt担当者別未引当一覧表, Me.lbl差異, Me.lbl社内クレーム, Me.lbl1日当回転数, Me.lbl機械名, Me.lblコーター, Me.lbl残業時間, Me.lbl社外クレーム, Me.lbl実績数量, Me.lbl総稼動時間, Me.lbl工場責任クレーム, Me.lbl実質生産量, Me.lbl対象日, Me.lbl月回転数, Me.lbl社外クレーム数, Me.lbl日数, Me.lbl工場責任クレーム数, Me.lbl社外クレーム金額, Me.lbl件数, Me.lbl工場責任クレーム金額, Me.lbl社内クレーム数, Me.lbl社内クレーム金額, Me.Label8, Me.Label10, Me.Label11, Me.Label13, Me.lbl実働時間, Me.lblアイドル時間})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 1.123622!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txt対象年月
        '
        Me.txt対象年月.Height = 0.2362205!
        Me.txt対象年月.Left = 0.7874016!
        Me.txt対象年月.Name = "txt対象年月"
        Me.txt対象年月.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対象年月.Text = "YY/MM/DD～YY/MM/DD日迄"
        Me.txt対象年月.Top = 0.1968504!
        Me.txt対象年月.Width = 2.347638!
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
        Me.txt担当者別未引当一覧表.Text = "機械別実績表"
        Me.txt担当者別未引当一覧表.Top = 0.1133858!
        Me.txt担当者別未引当一覧表.Width = 3.228346!
        '
        'lbl差異
        '
        Me.lbl差異.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl差異.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl差異.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl差異.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl差異.Height = 0.5511811!
        Me.lbl差異.HyperLink = Nothing
        Me.lbl差異.Left = 3.149606!
        Me.lbl差異.Name = "lbl差異"
        Me.lbl差異.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl差異.Text = "(A) - (D)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "差"
        Me.lbl差異.Top = 0.572441!
        Me.lbl差異.Width = 0.7086614!
        '
        'lbl社内クレーム
        '
        Me.lbl社内クレーム.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社内クレーム.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社内クレーム.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社内クレーム.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社内クレーム.Height = 0.2755905!
        Me.lbl社内クレーム.HyperLink = Nothing
        Me.lbl社内クレーム.Left = 7.716536!
        Me.lbl社内クレーム.Name = "lbl社内クレーム"
        Me.lbl社内クレーム.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl社内クレーム.Text = "社内クレーム"
        Me.lbl社内クレーム.Top = 0.572441!
        Me.lbl社内クレーム.Width = 1.318898!
        '
        'lbl1日当回転数
        '
        Me.lbl1日当回転数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1日当回転数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1日当回転数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1日当回転数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1日当回転数.Height = 0.2755905!
        Me.lbl1日当回転数.HyperLink = Nothing
        Me.lbl1日当回転数.Left = 0.6299213!
        Me.lbl1日当回転数.Name = "lbl1日当回転数"
        Me.lbl1日当回転数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl1日当回転数.Text = "1日当回転数"
        Me.lbl1日当回転数.Top = 0.8480315!
        Me.lbl1日当回転数.Width = 0.7283465!
        '
        'lbl機械名
        '
        Me.lbl機械名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl機械名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl機械名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl機械名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl機械名.Height = 0.5511811!
        Me.lbl機械名.HyperLink = Nothing
        Me.lbl機械名.Left = 0.0!
        Me.lbl機械名.Name = "lbl機械名"
        Me.lbl機械名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl機械名.Text = "機械名"
        Me.lbl機械名.Top = 0.572441!
        Me.lbl機械名.Width = 0.6299213!
        '
        'lblコーター
        '
        Me.lblコーター.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblコーター.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblコーター.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblコーター.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblコーター.Height = 0.2755905!
        Me.lblコーター.HyperLink = Nothing
        Me.lblコーター.Left = 0.6299213!
        Me.lblコーター.Name = "lblコーター"
        Me.lblコーター.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lblコーター.Text = "(D)コーター"
        Me.lblコーター.Top = 0.572441!
        Me.lblコーター.Width = 1.653543!
        '
        'lbl残業時間
        '
        Me.lbl残業時間.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl残業時間.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl残業時間.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl残業時間.Height = 0.2755905!
        Me.lbl残業時間.HyperLink = Nothing
        Me.lbl残業時間.Left = 10.57087!
        Me.lbl残業時間.Name = "lbl残業時間"
        Me.lbl残業時間.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl残業時間.Text = "残業時間"
        Me.lbl残業時間.Top = 0.572441!
        Me.lbl残業時間.Width = 0.5511811!
        '
        'lbl社外クレーム
        '
        Me.lbl社外クレーム.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社外クレーム.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社外クレーム.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社外クレーム.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社外クレーム.Height = 0.2755905!
        Me.lbl社外クレーム.HyperLink = Nothing
        Me.lbl社外クレーム.Left = 4.212598!
        Me.lbl社外クレーム.Name = "lbl社外クレーム"
        Me.lbl社外クレーム.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl社外クレーム.Text = "(B)社外クレーム"
        Me.lbl社外クレーム.Top = 0.572441!
        Me.lbl社外クレーム.Width = 1.377953!
        '
        'lbl実績数量
        '
        Me.lbl実績数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl実績数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl実績数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl実績数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl実績数量.CharacterSpacing = 5.0!
        Me.lbl実績数量.Height = 0.5511811!
        Me.lbl実績数量.HyperLink = Nothing
        Me.lbl実績数量.Left = 2.283465!
        Me.lbl実績数量.Name = "lbl実績数量"
        Me.lbl実績数量.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl実績数量.Text = "(A)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "実績数量"
        Me.lbl実績数量.Top = 0.572441!
        Me.lbl実績数量.Width = 0.8661417!
        '
        'lbl総稼動時間
        '
        Me.lbl総稼動時間.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl総稼動時間.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl総稼動時間.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl総稼動時間.Height = 0.2755905!
        Me.lbl総稼動時間.HyperLink = Nothing
        Me.lbl総稼動時間.Left = 9.035433!
        Me.lbl総稼動時間.Name = "lbl総稼動時間"
        Me.lbl総稼動時間.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 6.5pt; text-align: center; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.lbl総稼動時間.Text = "総稼働時間"
        Me.lbl総稼動時間.Top = 0.572441!
        Me.lbl総稼動時間.Width = 0.511811!
        '
        'lbl工場責任クレーム
        '
        Me.lbl工場責任クレーム.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl工場責任クレーム.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl工場責任クレーム.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl工場責任クレーム.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl工場責任クレーム.Height = 0.2755905!
        Me.lbl工場責任クレーム.HyperLink = Nothing
        Me.lbl工場責任クレーム.Left = 6.377953!
        Me.lbl工場責任クレーム.Name = "lbl工場責任クレーム"
        Me.lbl工場責任クレーム.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl工場責任クレーム.Text = "工場責任クレーム"
        Me.lbl工場責任クレーム.Top = 0.5724409!
        Me.lbl工場責任クレーム.Width = 1.338583!
        '
        'lbl実質生産量
        '
        Me.lbl実質生産量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl実質生産量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl実質生産量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl実質生産量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl実質生産量.Height = 0.5511811!
        Me.lbl実質生産量.HyperLink = Nothing
        Me.lbl実質生産量.Left = 5.590551!
        Me.lbl実質生産量.Name = "lbl実質生産量"
        Me.lbl実質生産量.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl実質生産量.Text = "(A) - (B)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "実質生産量"
        Me.lbl実質生産量.Top = 0.572441!
        Me.lbl実質生産量.Width = 0.7874016!
        '
        'lbl対象日
        '
        Me.lbl対象日.Height = 0.2362205!
        Me.lbl対象日.HyperLink = Nothing
        Me.lbl対象日.Left = 0.0!
        Me.lbl対象日.Name = "lbl対象日"
        Me.lbl対象日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl対象日.Text = "対象日"
        Me.lbl対象日.Top = 0.1968504!
        Me.lbl対象日.Width = 0.7874016!
        '
        'lbl月回転数
        '
        Me.lbl月回転数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl月回転数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl月回転数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl月回転数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl月回転数.Height = 0.2755905!
        Me.lbl月回転数.HyperLink = Nothing
        Me.lbl月回転数.Left = 1.574803!
        Me.lbl月回転数.Name = "lbl月回転数"
        Me.lbl月回転数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl月回転数.Text = "月回転数"
        Me.lbl月回転数.Top = 0.8480316!
        Me.lbl月回転数.Width = 0.7086614!
        '
        'lbl社外クレーム数
        '
        Me.lbl社外クレーム数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社外クレーム数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社外クレーム数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社外クレーム数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社外クレーム数.Height = 0.2755905!
        Me.lbl社外クレーム数.HyperLink = Nothing
        Me.lbl社外クレーム数.Left = 4.212598!
        Me.lbl社外クレーム数.Name = "lbl社外クレーム数"
        Me.lbl社外クレーム数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl社外クレーム数.Text = "数量"
        Me.lbl社外クレーム数.Top = 0.8480316!
        Me.lbl社外クレーム数.Width = 0.7086614!
        '
        'lbl日数
        '
        Me.lbl日数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl日数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl日数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl日数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl日数.CharacterSpacing = 5.0!
        Me.lbl日数.Height = 0.2755905!
        Me.lbl日数.HyperLink = Nothing
        Me.lbl日数.Left = 1.358268!
        Me.lbl日数.Name = "lbl日数"
        Me.lbl日数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl日数.Text = "日" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "数"
        Me.lbl日数.Top = 0.8480315!
        Me.lbl日数.Width = 0.2165354!
        '
        'lbl工場責任クレーム数
        '
        Me.lbl工場責任クレーム数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl工場責任クレーム数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl工場責任クレーム数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl工場責任クレーム数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl工場責任クレーム数.Height = 0.2755905!
        Me.lbl工場責任クレーム数.HyperLink = Nothing
        Me.lbl工場責任クレーム数.Left = 6.377953!
        Me.lbl工場責任クレーム数.Name = "lbl工場責任クレーム数"
        Me.lbl工場責任クレーム数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl工場責任クレーム数.Text = "数量"
        Me.lbl工場責任クレーム数.Top = 0.8480315!
        Me.lbl工場責任クレーム数.Width = 0.7086614!
        '
        'lbl社外クレーム金額
        '
        Me.lbl社外クレーム金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社外クレーム金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社外クレーム金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社外クレーム金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社外クレーム金額.Height = 0.2755905!
        Me.lbl社外クレーム金額.HyperLink = Nothing
        Me.lbl社外クレーム金額.Left = 4.92126!
        Me.lbl社外クレーム金額.Name = "lbl社外クレーム金額"
        Me.lbl社外クレーム金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl社外クレーム金額.Text = "金額"
        Me.lbl社外クレーム金額.Top = 0.8480316!
        Me.lbl社外クレーム金額.Width = 0.6692914!
        '
        'lbl件数
        '
        Me.lbl件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl件数.Height = 0.5511811!
        Me.lbl件数.HyperLink = Nothing
        Me.lbl件数.Left = 3.858268!
        Me.lbl件数.Name = "lbl件数"
        Me.lbl件数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl件数.Text = "件数"
        Me.lbl件数.Top = 0.572441!
        Me.lbl件数.Width = 0.3543307!
        '
        'lbl工場責任クレーム金額
        '
        Me.lbl工場責任クレーム金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl工場責任クレーム金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl工場責任クレーム金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl工場責任クレーム金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl工場責任クレーム金額.Height = 0.2755905!
        Me.lbl工場責任クレーム金額.HyperLink = Nothing
        Me.lbl工場責任クレーム金額.Left = 7.086615!
        Me.lbl工場責任クレーム金額.Name = "lbl工場責任クレーム金額"
        Me.lbl工場責任クレーム金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl工場責任クレーム金額.Text = "金額"
        Me.lbl工場責任クレーム金額.Top = 0.8480315!
        Me.lbl工場責任クレーム金額.Width = 0.6299213!
        '
        'lbl社内クレーム数
        '
        Me.lbl社内クレーム数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社内クレーム数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社内クレーム数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社内クレーム数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社内クレーム数.Height = 0.2755905!
        Me.lbl社内クレーム数.HyperLink = Nothing
        Me.lbl社内クレーム数.Left = 7.716536!
        Me.lbl社内クレーム数.Name = "lbl社内クレーム数"
        Me.lbl社内クレーム数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl社内クレーム数.Text = "数量"
        Me.lbl社内クレーム数.Top = 0.8480315!
        Me.lbl社内クレーム数.Width = 0.7086614!
        '
        'lbl社内クレーム金額
        '
        Me.lbl社内クレーム金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社内クレーム金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社内クレーム金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社内クレーム金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社内クレーム金額.Height = 0.2755905!
        Me.lbl社内クレーム金額.HyperLink = Nothing
        Me.lbl社内クレーム金額.Left = 8.425198!
        Me.lbl社内クレーム金額.Name = "lbl社内クレーム金額"
        Me.lbl社内クレーム金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl社内クレーム金額.Text = "金額"
        Me.lbl社内クレーム金額.Top = 0.8480315!
        Me.lbl社内クレーム金額.Width = 0.6102362!
        '
        'Label8
        '
        Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label8.Height = 0.2755906!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 9.035434!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7.5pt; text-align: center; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.Label8.Text = "(時：分)"
        Me.Label8.Top = 0.8480315!
        Me.Label8.Width = 0.511811!
        '
        'Label10
        '
        Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Height = 0.2755906!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 9.547245!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7.5pt; text-align: center; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.Label10.Text = "(時：分)"
        Me.Label10.Top = 0.8480315!
        Me.Label10.Width = 0.511811!
        '
        'Label11
        '
        Me.Label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Height = 0.2755906!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 10.05906!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7.5pt; text-align: center; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.Label11.Text = "(時：分)"
        Me.Label11.Top = 0.8480315!
        Me.Label11.Width = 0.511811!
        '
        'Label13
        '
        Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Height = 0.2755905!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 10.57087!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7.5pt; text-align: center; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.Label13.Text = "(時：分)"
        Me.Label13.Top = 0.8480316!
        Me.Label13.Width = 0.5511811!
        '
        'lbl実働時間
        '
        Me.lbl実働時間.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl実働時間.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl実働時間.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl実働時間.Height = 0.2755906!
        Me.lbl実働時間.HyperLink = Nothing
        Me.lbl実働時間.Left = 9.547244!
        Me.lbl実働時間.Name = "lbl実働時間"
        Me.lbl実働時間.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7.5pt; text-align: center; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.lbl実働時間.Text = "実働時間"
        Me.lbl実働時間.Top = 0.5724409!
        Me.lbl実働時間.Width = 0.511811!
        '
        'lblアイドル時間
        '
        Me.lblアイドル時間.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblアイドル時間.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblアイドル時間.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblアイドル時間.Height = 0.2755906!
        Me.lblアイドル時間.HyperLink = Nothing
        Me.lblアイドル時間.Left = 10.05906!
        Me.lblアイドル時間.Name = "lblアイドル時間"
        Me.lblアイドル時間.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7.5pt; text-align: center; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.lblアイドル時間.Text = "ｱｲﾄﾞﾙ時間"
        Me.lblアイドル時間.Top = 0.5724409!
        Me.lblアイドル時間.Width = 0.511811!
        '
        'grpFtr合計
        '
        Me.grpFtr合計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label2, Me.txt合計社外クレーム通数, Me.txt合計社内クレーム金額, Me.txt合計実績通数, Me.TextBox27, Me.txt合計差異, Me.txt合計社内クレーム通数, Me.txt合計社外クレーム金額, Me.txt合計1日当回転数, Me.txt合計残業時間, Me.txt合計工場クレーム金額, Me.txt合計実質通数m, Me.txt合計実質生産通数, Me.txt合計アイドル時間, Me.txt合計実働時間, Me.txt合計総稼働時間, Me.txt合計社内クレーム通数m, Me.txt合計工場責任クレーム通数, Me.txt合計工場責任クレーム通数m, Me.txt合計実質生産通数m, Me.txt合計社外クレーム通数m, Me.txt合計件数, Me.txt合計日数, Me.txt合計月回転数})
        Me.grpFtr合計.Height = 0.2362205!
        Me.grpFtr合計.Name = "grpFtr合計"
        '
        'Label2
        '
        Me.Label2.Height = 0.1771654!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.1370079!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label2.Text = "＊合計"
        Me.Label2.Top = 0.03346457!
        Me.Label2.Width = 0.472441!
        '
        'txt合計社外クレーム通数
        '
        Me.txt合計社外クレーム通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社外クレーム通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社外クレーム通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社外クレーム通数.Height = 0.1181103!
        Me.txt合計社外クレーム通数.Left = 4.212599!
        Me.txt合計社外クレーム通数.Name = "txt合計社外クレーム通数"
        Me.txt合計社外クレーム通数.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計社外クレーム通数.Text = "999,999,999通"
        Me.txt合計社外クレーム通数.Top = 0.0!
        Me.txt合計社外クレーム通数.Width = 0.7086611!
        '
        'txt合計社内クレーム金額
        '
        Me.txt合計社内クレーム金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社内クレーム金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社内クレーム金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社内クレーム金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社内クレーム金額.Height = 0.2362205!
        Me.txt合計社内クレーム金額.Left = 8.425195!
        Me.txt合計社内クレーム金額.Name = "txt合計社内クレーム金額"
        Me.txt合計社内クレーム金額.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計社内クレーム金額.Text = "999,999"
        Me.txt合計社内クレーム金額.Top = 0.0!
        Me.txt合計社内クレーム金額.Width = 0.6102362!
        '
        'txt合計実績通数
        '
        Me.txt合計実績通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計実績通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計実績通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計実績通数.Height = 0.1181103!
        Me.txt合計実績通数.Left = 2.283465!
        Me.txt合計実績通数.Name = "txt合計実績通数"
        Me.txt合計実績通数.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計実績通数.Text = "999,999,999通"
        Me.txt合計実績通数.Top = 0.0!
        Me.txt合計実績通数.Width = 0.8661417!
        '
        'TextBox27
        '
        Me.TextBox27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Height = 0.2362205!
        Me.TextBox27.Left = 0.0!
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox27.Text = Nothing
        Me.TextBox27.Top = 0.00000005960464!
        Me.TextBox27.Width = 0.6299213!
        '
        'txt合計差異
        '
        Me.txt合計差異.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計差異.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計差異.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計差異.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計差異.Height = 0.2362205!
        Me.txt合計差異.Left = 3.149606!
        Me.txt合計差異.Name = "txt合計差異"
        Me.txt合計差異.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計差異.Text = "999,999,999"
        Me.txt合計差異.Top = 0.0!
        Me.txt合計差異.Width = 0.7086611!
        '
        'txt合計社内クレーム通数
        '
        Me.txt合計社内クレーム通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社内クレーム通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社内クレーム通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社内クレーム通数.Height = 0.1181103!
        Me.txt合計社内クレーム通数.Left = 7.716535!
        Me.txt合計社内クレーム通数.Name = "txt合計社内クレーム通数"
        Me.txt合計社内クレーム通数.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計社内クレーム通数.Text = "999,999通"
        Me.txt合計社内クレーム通数.Top = 0.0!
        Me.txt合計社内クレーム通数.Width = 0.7086611!
        '
        'txt合計社外クレーム金額
        '
        Me.txt合計社外クレーム金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社外クレーム金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社外クレーム金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社外クレーム金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社外クレーム金額.Height = 0.2362205!
        Me.txt合計社外クレーム金額.Left = 4.921259!
        Me.txt合計社外クレーム金額.Name = "txt合計社外クレーム金額"
        Me.txt合計社外クレーム金額.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計社外クレーム金額.Text = "999,999"
        Me.txt合計社外クレーム金額.Top = 0.0!
        Me.txt合計社外クレーム金額.Width = 0.6692914!
        '
        'txt合計1日当回転数
        '
        Me.txt合計1日当回転数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計1日当回転数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計1日当回転数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計1日当回転数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計1日当回転数.Height = 0.2362205!
        Me.txt合計1日当回転数.Left = 0.6299213!
        Me.txt合計1日当回転数.Name = "txt合計1日当回転数"
        Me.txt合計1日当回転数.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計1日当回転数.Text = "999,999,999"
        Me.txt合計1日当回転数.Top = 0.0!
        Me.txt合計1日当回転数.Width = 0.7283465!
        '
        'txt合計残業時間
        '
        Me.txt合計残業時間.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計残業時間.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計残業時間.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計残業時間.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計残業時間.Height = 0.2362205!
        Me.txt合計残業時間.Left = 10.57087!
        Me.txt合計残業時間.Name = "txt合計残業時間"
        Me.txt合計残業時間.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計残業時間.Text = "99:99"
        Me.txt合計残業時間.Top = 0.0!
        Me.txt合計残業時間.Width = 0.551181!
        '
        'txt合計工場クレーム金額
        '
        Me.txt合計工場クレーム金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計工場クレーム金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計工場クレーム金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計工場クレーム金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計工場クレーム金額.Height = 0.2362205!
        Me.txt合計工場クレーム金額.Left = 7.086611!
        Me.txt合計工場クレーム金額.Name = "txt合計工場クレーム金額"
        Me.txt合計工場クレーム金額.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計工場クレーム金額.Text = "999,999"
        Me.txt合計工場クレーム金額.Top = 0.0!
        Me.txt合計工場クレーム金額.Width = 0.6299213!
        '
        'txt合計実質通数m
        '
        Me.txt合計実質通数m.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計実質通数m.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計実質通数m.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計実質通数m.Height = 0.1181103!
        Me.txt合計実質通数m.Left = 2.283465!
        Me.txt合計実質通数m.Name = "txt合計実質通数m"
        Me.txt合計実質通数m.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計実質通数m.Text = "999,999m"
        Me.txt合計実質通数m.Top = 0.1181103!
        Me.txt合計実質通数m.Width = 0.8661417!
        '
        'txt合計実質生産通数
        '
        Me.txt合計実質生産通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計実質生産通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計実質生産通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計実質生産通数.Height = 0.1181103!
        Me.txt合計実質生産通数.Left = 5.590551!
        Me.txt合計実質生産通数.Name = "txt合計実質生産通数"
        Me.txt合計実質生産通数.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計実質生産通数.Text = "999,999,999通"
        Me.txt合計実質生産通数.Top = 0.0!
        Me.txt合計実質生産通数.Width = 0.7874014!
        '
        'txt合計アイドル時間
        '
        Me.txt合計アイドル時間.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計アイドル時間.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計アイドル時間.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計アイドル時間.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計アイドル時間.Height = 0.2362205!
        Me.txt合計アイドル時間.Left = 10.05906!
        Me.txt合計アイドル時間.Name = "txt合計アイドル時間"
        Me.txt合計アイドル時間.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計アイドル時間.Text = "99:99"
        Me.txt合計アイドル時間.Top = 0.0!
        Me.txt合計アイドル時間.Width = 0.511811!
        '
        'txt合計実働時間
        '
        Me.txt合計実働時間.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計実働時間.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計実働時間.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計実働時間.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計実働時間.Height = 0.2362205!
        Me.txt合計実働時間.Left = 9.547243!
        Me.txt合計実働時間.Name = "txt合計実働時間"
        Me.txt合計実働時間.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計実働時間.Text = "99:99"
        Me.txt合計実働時間.Top = 0.0!
        Me.txt合計実働時間.Width = 0.511811!
        '
        'txt合計総稼働時間
        '
        Me.txt合計総稼働時間.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計総稼働時間.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計総稼働時間.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計総稼働時間.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計総稼働時間.Height = 0.2362205!
        Me.txt合計総稼働時間.Left = 9.03543!
        Me.txt合計総稼働時間.Name = "txt合計総稼働時間"
        Me.txt合計総稼働時間.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計総稼働時間.Text = "99:99"
        Me.txt合計総稼働時間.Top = 0.0!
        Me.txt合計総稼働時間.Width = 0.511811!
        '
        'txt合計社内クレーム通数m
        '
        Me.txt合計社内クレーム通数m.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社内クレーム通数m.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社内クレーム通数m.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社内クレーム通数m.Height = 0.1181103!
        Me.txt合計社内クレーム通数m.Left = 7.716535!
        Me.txt合計社内クレーム通数m.Name = "txt合計社内クレーム通数m"
        Me.txt合計社内クレーム通数m.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計社内クレーム通数m.Text = "999,999m"
        Me.txt合計社内クレーム通数m.Top = 0.1181103!
        Me.txt合計社内クレーム通数m.Width = 0.7086611!
        '
        'txt合計工場責任クレーム通数
        '
        Me.txt合計工場責任クレーム通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計工場責任クレーム通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計工場責任クレーム通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計工場責任クレーム通数.Height = 0.1181103!
        Me.txt合計工場責任クレーム通数.Left = 6.377953!
        Me.txt合計工場責任クレーム通数.Name = "txt合計工場責任クレーム通数"
        Me.txt合計工場責任クレーム通数.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計工場責任クレーム通数.Text = "999,999通"
        Me.txt合計工場責任クレーム通数.Top = 0.0!
        Me.txt合計工場責任クレーム通数.Width = 0.7086611!
        '
        'txt合計工場責任クレーム通数m
        '
        Me.txt合計工場責任クレーム通数m.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計工場責任クレーム通数m.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計工場責任クレーム通数m.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計工場責任クレーム通数m.Height = 0.1181103!
        Me.txt合計工場責任クレーム通数m.Left = 6.377953!
        Me.txt合計工場責任クレーム通数m.Name = "txt合計工場責任クレーム通数m"
        Me.txt合計工場責任クレーム通数m.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計工場責任クレーム通数m.Text = "999,999m"
        Me.txt合計工場責任クレーム通数m.Top = 0.1181104!
        Me.txt合計工場責任クレーム通数m.Width = 0.7086611!
        '
        'txt合計実質生産通数m
        '
        Me.txt合計実質生産通数m.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計実質生産通数m.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計実質生産通数m.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計実質生産通数m.Height = 0.1181103!
        Me.txt合計実質生産通数m.Left = 5.590551!
        Me.txt合計実質生産通数m.Name = "txt合計実質生産通数m"
        Me.txt合計実質生産通数m.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計実質生産通数m.Text = "999,999,999m"
        Me.txt合計実質生産通数m.Top = 0.1181103!
        Me.txt合計実質生産通数m.Width = 0.7874014!
        '
        'txt合計社外クレーム通数m
        '
        Me.txt合計社外クレーム通数m.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社外クレーム通数m.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社外クレーム通数m.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計社外クレーム通数m.Height = 0.1181103!
        Me.txt合計社外クレーム通数m.Left = 4.212599!
        Me.txt合計社外クレーム通数m.Name = "txt合計社外クレーム通数m"
        Me.txt合計社外クレーム通数m.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計社外クレーム通数m.Text = "999,999,999m"
        Me.txt合計社外クレーム通数m.Top = 0.1157481!
        Me.txt合計社外クレーム通数m.Width = 0.7086611!
        '
        'txt合計件数
        '
        Me.txt合計件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計件数.Height = 0.2362205!
        Me.txt合計件数.Left = 3.858268!
        Me.txt合計件数.Name = "txt合計件数"
        Me.txt合計件数.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計件数.Text = "999,999"
        Me.txt合計件数.Top = 0.0!
        Me.txt合計件数.Width = 0.3543307!
        '
        'txt合計日数
        '
        Me.txt合計日数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計日数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計日数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計日数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計日数.Height = 0.2362205!
        Me.txt合計日数.Left = 1.358268!
        Me.txt合計日数.Name = "txt合計日数"
        Me.txt合計日数.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計日数.Text = "99"
        Me.txt合計日数.Top = 0.0!
        Me.txt合計日数.Width = 0.2165354!
        '
        'txt合計月回転数
        '
        Me.txt合計月回転数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計月回転数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計月回転数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計月回転数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計月回転数.Height = 0.2362205!
        Me.txt合計月回転数.Left = 1.574803!
        Me.txt合計月回転数.Name = "txt合計月回転数"
        Me.txt合計月回転数.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt合計月回転数.Text = "999,999,999"
        Me.txt合計月回転数.Top = 0.0!
        Me.txt合計月回転数.Width = 0.7086611!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'grpFtr小計
        '
        Me.grpFtr小計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label3, Me.txt小計社外クレーム通数, Me.txt小計社内クレーム金額, Me.txt小計実績通数, Me.TextBox4, Me.txt小計差異, Me.txt小計社内クレーム通数, Me.txt小計社外クレーム金額, Me.txt小計1日当回転数, Me.txt小計残業時間, Me.txt小計工場責任クレーム金額, Me.txt小計実績通数m, Me.txt小計実質生産通数, Me.txt小計アイドル時間, Me.txt小計実働時間, Me.txt小計総稼働時間, Me.txt小計社内クレーム通数m, Me.txt小計工場責任クレーム通数, Me.txt小計工場責任クレーム通数m, Me.txt小計実質生産通数m, Me.txt小計社外クレーム通数m, Me.txt小計件数, Me.txt小計日数, Me.txt小計月回転数})
        Me.grpFtr小計.Height = 0.2362205!
        Me.grpFtr小計.Name = "grpFtr小計"
        '
        'Label3
        '
        Me.Label3.Height = 0.1771654!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.1322835!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label3.Text = "＊小計"
        Me.Label3.Top = 0.03622048!
        Me.Label3.Width = 0.472441!
        '
        'txt小計社外クレーム通数
        '
        Me.txt小計社外クレーム通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社外クレーム通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社外クレーム通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社外クレーム通数.Height = 0.1181103!
        Me.txt小計社外クレーム通数.Left = 4.212599!
        Me.txt小計社外クレーム通数.Name = "txt小計社外クレーム通数"
        Me.txt小計社外クレーム通数.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計社外クレーム通数.Text = "999,999,999通"
        Me.txt小計社外クレーム通数.Top = 0.0!
        Me.txt小計社外クレーム通数.Width = 0.7086611!
        '
        'txt小計社内クレーム金額
        '
        Me.txt小計社内クレーム金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社内クレーム金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社内クレーム金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社内クレーム金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社内クレーム金額.Height = 0.2362205!
        Me.txt小計社内クレーム金額.Left = 8.425195!
        Me.txt小計社内クレーム金額.Name = "txt小計社内クレーム金額"
        Me.txt小計社内クレーム金額.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計社内クレーム金額.Text = "999,999"
        Me.txt小計社内クレーム金額.Top = 0.0!
        Me.txt小計社内クレーム金額.Width = 0.6102362!
        '
        'txt小計実績通数
        '
        Me.txt小計実績通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計実績通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計実績通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計実績通数.Height = 0.1181103!
        Me.txt小計実績通数.Left = 2.283465!
        Me.txt小計実績通数.Name = "txt小計実績通数"
        Me.txt小計実績通数.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計実績通数.Text = "999,999,999通"
        Me.txt小計実績通数.Top = 0.0!
        Me.txt小計実績通数.Width = 0.8661417!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Height = 0.2362205!
        Me.TextBox4.Left = 0.0!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.00000005960464!
        Me.TextBox4.Width = 0.6299213!
        '
        'txt小計差異
        '
        Me.txt小計差異.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計差異.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計差異.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計差異.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計差異.Height = 0.2362205!
        Me.txt小計差異.Left = 3.149606!
        Me.txt小計差異.Name = "txt小計差異"
        Me.txt小計差異.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計差異.Text = "999,999,999"
        Me.txt小計差異.Top = 0.0!
        Me.txt小計差異.Width = 0.7086611!
        '
        'txt小計社内クレーム通数
        '
        Me.txt小計社内クレーム通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社内クレーム通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社内クレーム通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社内クレーム通数.Height = 0.1181103!
        Me.txt小計社内クレーム通数.Left = 7.716535!
        Me.txt小計社内クレーム通数.Name = "txt小計社内クレーム通数"
        Me.txt小計社内クレーム通数.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計社内クレーム通数.Text = "999,999通"
        Me.txt小計社内クレーム通数.Top = 0.0!
        Me.txt小計社内クレーム通数.Width = 0.7086611!
        '
        'txt小計社外クレーム金額
        '
        Me.txt小計社外クレーム金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社外クレーム金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社外クレーム金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社外クレーム金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社外クレーム金額.Height = 0.2362205!
        Me.txt小計社外クレーム金額.Left = 4.921259!
        Me.txt小計社外クレーム金額.Name = "txt小計社外クレーム金額"
        Me.txt小計社外クレーム金額.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計社外クレーム金額.Text = "999,999"
        Me.txt小計社外クレーム金額.Top = 0.0!
        Me.txt小計社外クレーム金額.Width = 0.6692914!
        '
        'txt小計1日当回転数
        '
        Me.txt小計1日当回転数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計1日当回転数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計1日当回転数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計1日当回転数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計1日当回転数.Height = 0.2362205!
        Me.txt小計1日当回転数.Left = 0.6299213!
        Me.txt小計1日当回転数.Name = "txt小計1日当回転数"
        Me.txt小計1日当回転数.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計1日当回転数.Text = "999,999,999"
        Me.txt小計1日当回転数.Top = 0.0!
        Me.txt小計1日当回転数.Width = 0.7283465!
        '
        'txt小計残業時間
        '
        Me.txt小計残業時間.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計残業時間.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計残業時間.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計残業時間.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計残業時間.Height = 0.2362205!
        Me.txt小計残業時間.Left = 10.57087!
        Me.txt小計残業時間.Name = "txt小計残業時間"
        Me.txt小計残業時間.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計残業時間.Text = "99:99"
        Me.txt小計残業時間.Top = 0.0!
        Me.txt小計残業時間.Width = 0.551181!
        '
        'txt小計工場責任クレーム金額
        '
        Me.txt小計工場責任クレーム金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計工場責任クレーム金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計工場責任クレーム金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計工場責任クレーム金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計工場責任クレーム金額.Height = 0.2362205!
        Me.txt小計工場責任クレーム金額.Left = 7.086611!
        Me.txt小計工場責任クレーム金額.Name = "txt小計工場責任クレーム金額"
        Me.txt小計工場責任クレーム金額.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計工場責任クレーム金額.Text = "999,999"
        Me.txt小計工場責任クレーム金額.Top = 0.0!
        Me.txt小計工場責任クレーム金額.Width = 0.6299213!
        '
        'txt小計実績通数m
        '
        Me.txt小計実績通数m.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計実績通数m.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計実績通数m.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計実績通数m.Height = 0.1181103!
        Me.txt小計実績通数m.Left = 2.283465!
        Me.txt小計実績通数m.Name = "txt小計実績通数m"
        Me.txt小計実績通数m.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計実績通数m.Text = "999,999m"
        Me.txt小計実績通数m.Top = 0.1181103!
        Me.txt小計実績通数m.Width = 0.8661417!
        '
        'txt小計実質生産通数
        '
        Me.txt小計実質生産通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計実質生産通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計実質生産通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計実質生産通数.Height = 0.1181103!
        Me.txt小計実質生産通数.Left = 5.590551!
        Me.txt小計実質生産通数.Name = "txt小計実質生産通数"
        Me.txt小計実質生産通数.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計実質生産通数.Text = "999,999,999通"
        Me.txt小計実質生産通数.Top = 0.0!
        Me.txt小計実質生産通数.Width = 0.7874014!
        '
        'txt小計アイドル時間
        '
        Me.txt小計アイドル時間.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計アイドル時間.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計アイドル時間.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計アイドル時間.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計アイドル時間.Height = 0.2362205!
        Me.txt小計アイドル時間.Left = 10.05906!
        Me.txt小計アイドル時間.Name = "txt小計アイドル時間"
        Me.txt小計アイドル時間.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計アイドル時間.Text = "99:99"
        Me.txt小計アイドル時間.Top = 0.0!
        Me.txt小計アイドル時間.Width = 0.511811!
        '
        'txt小計実働時間
        '
        Me.txt小計実働時間.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計実働時間.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計実働時間.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計実働時間.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計実働時間.Height = 0.2362205!
        Me.txt小計実働時間.Left = 9.547243!
        Me.txt小計実働時間.Name = "txt小計実働時間"
        Me.txt小計実働時間.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計実働時間.Text = "99:99"
        Me.txt小計実働時間.Top = 0.0!
        Me.txt小計実働時間.Width = 0.511811!
        '
        'txt小計総稼働時間
        '
        Me.txt小計総稼働時間.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計総稼働時間.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計総稼働時間.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計総稼働時間.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計総稼働時間.Height = 0.2362205!
        Me.txt小計総稼働時間.Left = 9.03543!
        Me.txt小計総稼働時間.Name = "txt小計総稼働時間"
        Me.txt小計総稼働時間.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計総稼働時間.Text = "99:99"
        Me.txt小計総稼働時間.Top = 0.0!
        Me.txt小計総稼働時間.Width = 0.511811!
        '
        'txt小計社内クレーム通数m
        '
        Me.txt小計社内クレーム通数m.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社内クレーム通数m.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社内クレーム通数m.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社内クレーム通数m.Height = 0.1181103!
        Me.txt小計社内クレーム通数m.Left = 7.716535!
        Me.txt小計社内クレーム通数m.Name = "txt小計社内クレーム通数m"
        Me.txt小計社内クレーム通数m.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計社内クレーム通数m.Text = "999,999m"
        Me.txt小計社内クレーム通数m.Top = 0.1181103!
        Me.txt小計社内クレーム通数m.Width = 0.7086611!
        '
        'txt小計工場責任クレーム通数
        '
        Me.txt小計工場責任クレーム通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計工場責任クレーム通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計工場責任クレーム通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計工場責任クレーム通数.Height = 0.1181103!
        Me.txt小計工場責任クレーム通数.Left = 6.377953!
        Me.txt小計工場責任クレーム通数.Name = "txt小計工場責任クレーム通数"
        Me.txt小計工場責任クレーム通数.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計工場責任クレーム通数.Text = "999,999通"
        Me.txt小計工場責任クレーム通数.Top = 0.0!
        Me.txt小計工場責任クレーム通数.Width = 0.7086611!
        '
        'txt小計工場責任クレーム通数m
        '
        Me.txt小計工場責任クレーム通数m.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計工場責任クレーム通数m.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計工場責任クレーム通数m.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計工場責任クレーム通数m.Height = 0.1181103!
        Me.txt小計工場責任クレーム通数m.Left = 6.377953!
        Me.txt小計工場責任クレーム通数m.Name = "txt小計工場責任クレーム通数m"
        Me.txt小計工場責任クレーム通数m.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計工場責任クレーム通数m.Text = "999,999m"
        Me.txt小計工場責任クレーム通数m.Top = 0.1181104!
        Me.txt小計工場責任クレーム通数m.Width = 0.7086611!
        '
        'txt小計実質生産通数m
        '
        Me.txt小計実質生産通数m.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計実質生産通数m.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計実質生産通数m.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計実質生産通数m.Height = 0.1181103!
        Me.txt小計実質生産通数m.Left = 5.590551!
        Me.txt小計実質生産通数m.Name = "txt小計実質生産通数m"
        Me.txt小計実質生産通数m.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計実質生産通数m.Text = "999,999,999m"
        Me.txt小計実質生産通数m.Top = 0.1181103!
        Me.txt小計実質生産通数m.Width = 0.7874014!
        '
        'txt小計社外クレーム通数m
        '
        Me.txt小計社外クレーム通数m.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社外クレーム通数m.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社外クレーム通数m.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計社外クレーム通数m.Height = 0.1181103!
        Me.txt小計社外クレーム通数m.Left = 4.212599!
        Me.txt小計社外クレーム通数m.Name = "txt小計社外クレーム通数m"
        Me.txt小計社外クレーム通数m.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計社外クレーム通数m.Text = "999,999,999m"
        Me.txt小計社外クレーム通数m.Top = 0.1157481!
        Me.txt小計社外クレーム通数m.Width = 0.7086611!
        '
        'txt小計件数
        '
        Me.txt小計件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計件数.Height = 0.2362205!
        Me.txt小計件数.Left = 3.858268!
        Me.txt小計件数.Name = "txt小計件数"
        Me.txt小計件数.Style = "font-family: ＭＳ 明朝; font-size: 6pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計件数.Text = "999,999"
        Me.txt小計件数.Top = 0.0!
        Me.txt小計件数.Width = 0.3543307!
        '
        'txt小計日数
        '
        Me.txt小計日数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計日数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計日数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計日数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計日数.Height = 0.2362205!
        Me.txt小計日数.Left = 1.358268!
        Me.txt小計日数.Name = "txt小計日数"
        Me.txt小計日数.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計日数.Text = "99"
        Me.txt小計日数.Top = 0.0!
        Me.txt小計日数.Width = 0.2165354!
        '
        'txt小計月回転数
        '
        Me.txt小計月回転数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計月回転数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計月回転数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計月回転数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計月回転数.Height = 0.2362205!
        Me.txt小計月回転数.Left = 1.574803!
        Me.txt小計月回転数.Name = "txt小計月回転数"
        Me.txt小計月回転数.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt小計月回転数.Text = "999,999,999"
        Me.txt小計月回転数.Top = 0.0!
        Me.txt小計月回転数.Width = 0.7086611!
        '
        'MachineActual
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 11.14173!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr小計)
        Me.Sections.Add(Me.grpFtr合計)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt社外クレーム通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtクレーム金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt実績通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt機械名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt差異, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt社内クレーム通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt社外クレーム金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1日当回転数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt残業時間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt工場責任クレーム金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt実績通数m, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt実質生産通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtアイドル時間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt実働時間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt稼動時間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt社内クレーム通数m, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt工場責任クレーム通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt工場責任クレーム通数m, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt実質生産通数m, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt社外クレーム通数m, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt日数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt月回転数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者別未引当一覧表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl差異, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl社内クレーム, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl1日当回転数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl機械名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblコーター, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl残業時間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl社外クレーム, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl実績数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl総稼動時間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl工場責任クレーム, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl実質生産量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl対象日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl月回転数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl社外クレーム数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl日数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl工場責任クレーム数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl社外クレーム金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl工場責任クレーム金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl社内クレーム数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl社内クレーム金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl実働時間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblアイドル時間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計社外クレーム通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計社内クレーム金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計実績通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計差異, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計社内クレーム通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計社外クレーム金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計1日当回転数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計残業時間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計工場クレーム金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計実質通数m, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計実質生産通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計アイドル時間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計実働時間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計総稼働時間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計社内クレーム通数m, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計工場責任クレーム通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計工場責任クレーム通数m, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計実質生産通数m, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計社外クレーム通数m, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計日数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計月回転数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計社外クレーム通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計社内クレーム金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計実績通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計差異, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計社内クレーム通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計社外クレーム金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計1日当回転数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計残業時間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計工場責任クレーム金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計実績通数m, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計実質生産通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計アイドル時間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計実働時間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計総稼働時間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計社内クレーム通数m, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計工場責任クレーム通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計工場責任クレーム通数m, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計実質生産通数m, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計社外クレーム通数m, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計日数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計月回転数, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt社外クレーム通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtクレーム金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt実績通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt機械名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt差異 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt社内クレーム通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt社外クレーム金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt1日当回転数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt対象年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者別未引当一覧表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl差異 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl1日当回転数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl機械名 As DataDynamics.ActiveReports.Label
    Private WithEvents lblコーター As DataDynamics.ActiveReports.Label
    Private WithEvents lbl残業時間 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl社外クレーム As DataDynamics.ActiveReports.Label
    Private WithEvents lbl実績数量 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr合計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents txt残業時間 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl総稼動時間 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl社内クレーム As DataDynamics.ActiveReports.Label
    Private WithEvents txt工場責任クレーム金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl工場責任クレーム As DataDynamics.ActiveReports.Label
    Private WithEvents txt実績通数m As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt実質生産通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl実質生産量 As DataDynamics.ActiveReports.Label
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents grpFtr小計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl対象日 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl月回転数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl社外クレーム数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl日数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl工場責任クレーム数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl社外クレーム金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl件数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl工場責任クレーム金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl社内クレーム数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl社内クレーム金額 As DataDynamics.ActiveReports.Label
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Private WithEvents Label11 As DataDynamics.ActiveReports.Label
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl実働時間 As DataDynamics.ActiveReports.Label
    Private WithEvents lblアイドル時間 As DataDynamics.ActiveReports.Label
    Private WithEvents txtアイドル時間 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt実働時間 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt稼動時間 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt社内クレーム通数m As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt工場責任クレーム通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt工場責任クレーム通数m As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt実質生産通数m As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt社外クレーム通数m As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt日数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt月回転数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計社外クレーム通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計社内クレーム金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計実績通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox27 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計差異 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計社内クレーム通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計社外クレーム金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計1日当回転数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計残業時間 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計工場クレーム金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計実質通数m As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計実質生産通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計アイドル時間 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計実働時間 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計総稼働時間 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計社内クレーム通数m As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計工場責任クレーム通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計工場責任クレーム通数m As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計実質生産通数m As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計社外クレーム通数m As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計日数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計月回転数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計社外クレーム通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計社内クレーム金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計実績通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計差異 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計社内クレーム通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計社外クレーム金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計1日当回転数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計残業時間 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計工場責任クレーム金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計実績通数m As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計実質生産通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計アイドル時間 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計実働時間 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計総稼働時間 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計社内クレーム通数m As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計工場責任クレーム通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計工場責任クレーム通数m As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計実質生産通数m As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計社外クレーム通数m As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計日数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計月回転数 As DataDynamics.ActiveReports.TextBox
End Class
