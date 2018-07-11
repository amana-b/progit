<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class QuotationTotal
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(QuotationTotal))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt台紙名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt社内価格 = New DataDynamics.ActiveReports.TextBox()
        Me.txt摘要 = New DataDynamics.ActiveReports.TextBox()
        Me.txt紙名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt伝票No = New DataDynamics.ActiveReports.TextBox()
        Me.txt糊名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt紙CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt糊CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt台紙CD = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt入金明細表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl前残 = New DataDynamics.ActiveReports.Label()
        Me.lbl基準面付数 = New DataDynamics.ActiveReports.Label()
        Me.lblラベルサイズ巾 = New DataDynamics.ActiveReports.Label()
        Me.lbl積算日 = New DataDynamics.ActiveReports.Label()
        Me.txt積算日 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl勘定科目 = New DataDynamics.ActiveReports.Label()
        Me.lbl包装枚数 = New DataDynamics.ActiveReports.Label()
        Me.lblラベルサイズ面付流れ = New DataDynamics.ActiveReports.Label()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl積算No = New DataDynamics.ActiveReports.Label()
        Me.txt積算No = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.lbl商品名 = New DataDynamics.ActiveReports.Label()
        Me.lbl印刷色 = New DataDynamics.ActiveReports.Label()
        Me.txt得意先名1 = New DataDynamics.ActiveReports.TextBox()
        Me.txt品名1 = New DataDynamics.ActiveReports.TextBox()
        Me.txt角R = New DataDynamics.ActiveReports.TextBox()
        Me.lbl巻取 = New DataDynamics.ActiveReports.Label()
        Me.lbl一巻当り = New DataDynamics.ActiveReports.Label()
        Me.txt得意先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt巻取名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt出し方向名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt紙管 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl印刷場所 = New DataDynamics.ActiveReports.Label()
        Me.txt印刷場所 = New DataDynamics.ActiveReports.TextBox()
        Me.txt印刷場所CD = New DataDynamics.ActiveReports.TextBox()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.txtラベルサイズ巾 = New DataDynamics.ActiveReports.TextBox()
        Me.txtドブ = New DataDynamics.ActiveReports.TextBox()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.Label10 = New DataDynamics.ActiveReports.Label()
        Me.lblラベルサイズ流れ = New DataDynamics.ActiveReports.Label()
        Me.Label13 = New DataDynamics.ActiveReports.Label()
        Me.txtラベルサイズ流れ = New DataDynamics.ActiveReports.TextBox()
        Me.txtドブ2 = New DataDynamics.ActiveReports.TextBox()
        Me.lblラベルサイズ面付巾 = New DataDynamics.ActiveReports.Label()
        Me.lblラベルサイズギア数 = New DataDynamics.ActiveReports.Label()
        Me.txtラベルサイズ面付巾 = New DataDynamics.ActiveReports.TextBox()
        Me.txtギア数 = New DataDynamics.ActiveReports.TextBox()
        Me.Label18 = New DataDynamics.ActiveReports.Label()
        Me.txtラベルサイズ面付流れ = New DataDynamics.ActiveReports.TextBox()
        Me.Label14 = New DataDynamics.ActiveReports.Label()
        Me.txt流れ面数 = New DataDynamics.ActiveReports.TextBox()
        Me.ラベルサイズ基準面付数 = New DataDynamics.ActiveReports.TextBox()
        Me.lblラベルサイズ送りピッチ = New DataDynamics.ActiveReports.Label()
        Me.txt送りピッチ = New DataDynamics.ActiveReports.TextBox()
        Me.txt形状 = New DataDynamics.ActiveReports.TextBox()
        Me.lblｽﾘｯﾀｰ = New DataDynamics.ActiveReports.Label()
        Me.lblカット = New DataDynamics.ActiveReports.Label()
        Me.lbl紙 = New DataDynamics.ActiveReports.Label()
        Me.lbl必要巾 = New DataDynamics.ActiveReports.Label()
        Me.lbl出方 = New DataDynamics.ActiveReports.Label()
        Me.lbl紙管 = New DataDynamics.ActiveReports.Label()
        Me.lblｽﾘｯﾀｰ巾 = New DataDynamics.ActiveReports.Label()
        Me.lbl1ｼｰﾄ枚 = New DataDynamics.ActiveReports.Label()
        Me.lbl台紙 = New DataDynamics.ActiveReports.Label()
        Me.lbl糊 = New DataDynamics.ActiveReports.Label()
        Me.txt一巻当り = New DataDynamics.ActiveReports.TextBox()
        Me.txtｽﾘｯﾀｰ名 = New DataDynamics.ActiveReports.TextBox()
        Me.txtｽﾘｯﾀｰ巾 = New DataDynamics.ActiveReports.TextBox()
        Me.txt包装枚 = New DataDynamics.ActiveReports.TextBox()
        Me.txtカット3 = New DataDynamics.ActiveReports.TextBox()
        Me.txtカット1 = New DataDynamics.ActiveReports.TextBox()
        Me.lblメーカー名 = New DataDynamics.ActiveReports.Label()
        Me.lbl単価 = New DataDynamics.ActiveReports.Label()
        Me.lblラベルサイズドブ1 = New DataDynamics.ActiveReports.Label()
        Me.txtラベルサイズドブ1 = New DataDynamics.ActiveReports.TextBox()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.lblラベルサイズドブ2 = New DataDynamics.ActiveReports.Label()
        Me.txtラベルサイズドブ2 = New DataDynamics.ActiveReports.TextBox()
        Me.txtラベルサイズギア数 = New DataDynamics.ActiveReports.TextBox()
        Me.txtラベルサイズ送りピッチ = New DataDynamics.ActiveReports.TextBox()
        Me.lblラベルサイズ角R = New DataDynamics.ActiveReports.TextBox()
        Me.txtラベルサイズ角R = New DataDynamics.ActiveReports.TextBox()
        Me.txt品名2 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名2 = New DataDynamics.ActiveReports.TextBox()
        Me.txt入力担当CD = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.txt表 = New DataDynamics.ActiveReports.TextBox()
        Me.txt裏 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.Label11 = New DataDynamics.ActiveReports.Label()
        Me.Label16 = New DataDynamics.ActiveReports.Label()
        Me.txtカット2 = New DataDynamics.ActiveReports.TextBox()
        Me.Label19 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt備考1 = New DataDynamics.ActiveReports.TextBox()
        Me.SubReport1 = New DataDynamics.ActiveReports.SubReport()
        Me.lbl備考 = New DataDynamics.ActiveReports.Label()
        Me.txt備考2 = New DataDynamics.ActiveReports.TextBox()
        Me.txt備考3 = New DataDynamics.ActiveReports.TextBox()
        Me.txt備考4 = New DataDynamics.ActiveReports.TextBox()
        Me.txt備考5 = New DataDynamics.ActiveReports.TextBox()
        Me.txt備考6 = New DataDynamics.ActiveReports.TextBox()
        Me.txt備考7 = New DataDynamics.ActiveReports.TextBox()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt台紙名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt社内価格, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt摘要, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt紙名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt伝票No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt糊名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt紙CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt糊CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt台紙CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入金明細表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl前残, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl基準面付数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblラベルサイズ巾, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl積算日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt積算日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl勘定科目, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl包装枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblラベルサイズ面付流れ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl積算No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt積算No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl印刷色, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt品名1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt角R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl巻取, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl一巻当り, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt巻取名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt出し方向名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt紙管, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl印刷場所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt印刷場所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt印刷場所CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtラベルサイズ巾, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtドブ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblラベルサイズ流れ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtラベルサイズ流れ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtドブ2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblラベルサイズ面付巾, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblラベルサイズギア数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtラベルサイズ面付巾, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtギア数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtラベルサイズ面付流れ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt流れ面数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ラベルサイズ基準面付数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblラベルサイズ送りピッチ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt送りピッチ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt形状, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblｽﾘｯﾀｰ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblカット, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl紙, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl必要巾, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl出方, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl紙管, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblｽﾘｯﾀｰ巾, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl1ｼｰﾄ枚, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl台紙, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl糊, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt一巻当り, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtｽﾘｯﾀｰ名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtｽﾘｯﾀｰ巾, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt包装枚, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtカット3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtカット1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblメーカー名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblラベルサイズドブ1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtラベルサイズドブ1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblラベルサイズドブ2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtラベルサイズドブ2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtラベルサイズギア数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtラベルサイズ送りピッチ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblラベルサイズ角R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtラベルサイズ角R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt品名2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入力担当CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt裏, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtカット2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt備考1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl備考, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt備考2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt備考3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt備考4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt備考5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt備考6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt備考7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt台紙名, Me.txt社内価格, Me.txt摘要, Me.txt紙名, Me.txt伝票No, Me.txt糊名, Me.txt紙CD, Me.txt糊CD, Me.txt台紙CD})
        Me.Detail.Height = 0.2755905!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt台紙名
        '
        Me.txt台紙名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙名.Height = 0.2755905!
        Me.txt台紙名.Left = 2.637795!
        Me.txt台紙名.Name = "txt台紙名"
        Me.txt台紙名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txt台紙名.Text = "あああああ"
        Me.txt台紙名.Top = 0.0!
        Me.txt台紙名.Width = 1.003937!
        '
        'txt社内価格
        '
        Me.txt社内価格.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt社内価格.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt社内価格.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt社内価格.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt社内価格.Height = 0.2755905!
        Me.txt社内価格.Left = 5.984252!
        Me.txt社内価格.Name = "txt社内価格"
        Me.txt社内価格.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt社内価格.Text = "　@999.99/㎡"
        Me.txt社内価格.Top = 0.0!
        Me.txt社内価格.Width = 1.456693!
        '
        'txt摘要
        '
        Me.txt摘要.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Height = 0.2755905!
        Me.txt摘要.Left = 4.192913!
        Me.txt摘要.Name = "txt摘要"
        Me.txt摘要.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt摘要.Text = "あああああいいいいい"
        Me.txt摘要.Top = 0.0!
        Me.txt摘要.Width = 1.791339!
        '
        'txt紙名
        '
        Me.txt紙名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt紙名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙名.Height = 0.2755905!
        Me.txt紙名.Left = 0.0!
        Me.txt紙名.Name = "txt紙名"
        Me.txt紙名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txt紙名.Text = "あああああいいいいい"
        Me.txt紙名.Top = 0.0!
        Me.txt紙名.Width = 1.614173!
        '
        'txt伝票No
        '
        Me.txt伝票No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Height = 0.2755905!
        Me.txt伝票No.Left = 3.641732!
        Me.txt伝票No.Name = "txt伝票No"
        Me.txt伝票No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt伝票No.Text = "999mm"
        Me.txt伝票No.Top = 0.0!
        Me.txt伝票No.Width = 0.5511811!
        '
        'txt糊名
        '
        Me.txt糊名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊名.Height = 0.2755905!
        Me.txt糊名.Left = 1.614173!
        Me.txt糊名.Name = "txt糊名"
        Me.txt糊名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txt糊名.Text = "あああああ"
        Me.txt糊名.Top = 0.0!
        Me.txt糊名.Width = 1.023622!
        '
        'txt紙CD
        '
        Me.txt紙CD.Height = 0.1968504!
        Me.txt紙CD.Left = 1.384646!
        Me.txt紙CD.Name = "txt紙CD"
        Me.txt紙CD.Style = "background-color: Red; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; ve" & _
    "rtical-align: middle; ddo-char-set: 1"
        Me.txt紙CD.Text = "99"
        Me.txt紙CD.Top = 0.04094489!
        Me.txt紙CD.Width = 0.1968504!
        '
        'txt糊CD
        '
        Me.txt糊CD.Height = 0.1968504!
        Me.txt糊CD.Left = 2.407087!
        Me.txt糊CD.Name = "txt糊CD"
        Me.txt糊CD.Style = "background-color: Red; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; ve" & _
    "rtical-align: middle; ddo-char-set: 1"
        Me.txt糊CD.Text = "99"
        Me.txt糊CD.Top = 0.04094489!
        Me.txt糊CD.Width = 0.1968504!
        '
        'txt台紙CD
        '
        Me.txt台紙CD.Height = 0.1968504!
        Me.txt台紙CD.Left = 3.414961!
        Me.txt台紙CD.Name = "txt台紙CD"
        Me.txt台紙CD.Style = "background-color: Red; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; ve" & _
    "rtical-align: middle; ddo-char-set: 1"
        Me.txt台紙CD.Text = "99"
        Me.txt台紙CD.Top = 0.03779528!
        Me.txt台紙CD.Width = 0.1968504!
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNow, Me.txt頁})
        Me.PageFooter.Height = 0.2362205!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdr
        '
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt入金明細表, Me.lbl前残, Me.lbl基準面付数, Me.lblラベルサイズ巾, Me.lbl積算日, Me.txt積算日, Me.lbl勘定科目, Me.lbl包装枚数, Me.lblラベルサイズ面付流れ, Me.Label3, Me.TextBox5, Me.lbl積算No, Me.txt積算No, Me.Label2, Me.lbl商品名, Me.lbl印刷色, Me.txt得意先名1, Me.txt品名1, Me.txt角R, Me.lbl巻取, Me.lbl一巻当り, Me.txt得意先CD, Me.txt巻取名, Me.txt出し方向名, Me.txt紙管, Me.lbl印刷場所, Me.txt印刷場所, Me.txt印刷場所CD, Me.Label4, Me.txtラベルサイズ巾, Me.txtドブ, Me.Label5, Me.Label10, Me.lblラベルサイズ流れ, Me.Label13, Me.txtラベルサイズ流れ, Me.txtドブ2, Me.lblラベルサイズ面付巾, Me.lblラベルサイズギア数, Me.txtラベルサイズ面付巾, Me.txtギア数, Me.Label18, Me.txtラベルサイズ面付流れ, Me.Label14, Me.txt流れ面数, Me.ラベルサイズ基準面付数, Me.lblラベルサイズ送りピッチ, Me.txt送りピッチ, Me.txt形状, Me.lblｽﾘｯﾀｰ, Me.lblカット, Me.lbl紙, Me.lbl必要巾, Me.lbl出方, Me.lbl紙管, Me.lblｽﾘｯﾀｰ巾, Me.lbl1ｼｰﾄ枚, Me.lbl台紙, Me.lbl糊, Me.txt一巻当り, Me.txtｽﾘｯﾀｰ名, Me.txtｽﾘｯﾀｰ巾, Me.txt包装枚, Me.txtカット3, Me.txtカット1, Me.lblメーカー名, Me.lbl単価, Me.lblラベルサイズドブ1, Me.txtラベルサイズドブ1, Me.Label8, Me.lblラベルサイズドブ2, Me.txtラベルサイズドブ2, Me.txtラベルサイズギア数, Me.txtラベルサイズ送りピッチ, Me.lblラベルサイズ角R, Me.txtラベルサイズ角R, Me.txt品名2, Me.txt得意先名2, Me.txt入力担当CD, Me.Label1, Me.Label7, Me.txt表, Me.txt裏, Me.TextBox4, Me.Label11, Me.Label16, Me.txtカット2, Me.Label19})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 4.370079!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txt入金明細表
        '
        Me.txt入金明細表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt入金明細表.CharacterSpacing = 10.0!
        Me.txt入金明細表.Height = 0.307874!
        Me.txt入金明細表.Left = 0.0!
        Me.txt入金明細表.Name = "txt入金明細表"
        Me.txt入金明細表.Style = "font-family: ＭＳ 明朝; font-size: 16pt; font-weight: bold; text-align: center; verti" & _
    "cal-align: bottom; ddo-char-set: 1"
        Me.txt入金明細表.Text = "見積積算表"
        Me.txt入金明細表.Top = 0.0!
        Me.txt入金明細表.Width = 1.968504!
        '
        'lbl前残
        '
        Me.lbl前残.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl前残.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl前残.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl前残.Height = 0.3149606!
        Me.lbl前残.HyperLink = Nothing
        Me.lbl前残.Left = 0.0!
        Me.lbl前残.Name = "lbl前残"
        Me.lbl前残.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: justify; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.lbl前残.Text = "【仕上方法】"
        Me.lbl前残.Top = 3.267717!
        Me.lbl前残.Width = 7.440945!
        '
        'lbl基準面付数
        '
        Me.lbl基準面付数.Height = 0.3543307!
        Me.lbl基準面付数.HyperLink = Nothing
        Me.lbl基準面付数.Left = 6.141731!
        Me.lbl基準面付数.Name = "lbl基準面付数"
        Me.lbl基準面付数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl基準面付数.Text = "基準面付数"
        Me.lbl基準面付数.Top = 2.559055!
        Me.lbl基準面付数.Width = 0.7874016!
        '
        'lblラベルサイズ巾
        '
        Me.lblラベルサイズ巾.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lblラベルサイズ巾.Height = 0.3543307!
        Me.lblラベルサイズ巾.HyperLink = Nothing
        Me.lblラベルサイズ巾.Left = 0.0!
        Me.lblラベルサイズ巾.Name = "lblラベルサイズ巾"
        Me.lblラベルサイズ巾.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblラベルサイズ巾.Text = "巾"
        Me.lblラベルサイズ巾.Top = 2.559055!
        Me.lblラベルサイズ巾.Width = 0.472441!
        '
        'lbl積算日
        '
        Me.lbl積算日.Height = 0.1574803!
        Me.lbl積算日.HyperLink = Nothing
        Me.lbl積算日.Left = 3.466142!
        Me.lbl積算日.Name = "lbl積算日"
        Me.lbl積算日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbl積算日.Text = "積算年月日"
        Me.lbl積算日.Top = 0.05118111!
        Me.lbl積算日.Width = 0.7874016!
        '
        'txt積算日
        '
        Me.txt積算日.Height = 0.1574803!
        Me.txt積算日.Left = 3.466142!
        Me.txt積算日.Name = "txt積算日"
        Me.txt積算日.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txt積算日.Text = "YY/MM/DD"
        Me.txt積算日.Top = 0.2086614!
        Me.txt積算日.Width = 0.7874016!
        '
        'lbl勘定科目
        '
        Me.lbl勘定科目.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl勘定科目.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl勘定科目.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl勘定科目.Height = 0.2755905!
        Me.lbl勘定科目.HyperLink = Nothing
        Me.lbl勘定科目.Left = 0.0!
        Me.lbl勘定科目.Name = "lbl勘定科目"
        Me.lbl勘定科目.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: justify; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.lbl勘定科目.Text = "【ﾗﾍﾞﾙｻｲｽﾞ】"
        Me.lbl勘定科目.Top = 2.283465!
        Me.lbl勘定科目.Width = 7.440945!
        '
        'lbl包装枚数
        '
        Me.lbl包装枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl包装枚数.Height = 0.1968504!
        Me.lbl包装枚数.HyperLink = Nothing
        Me.lbl包装枚数.Left = 5.393702!
        Me.lbl包装枚数.Name = "lbl包装枚数"
        Me.lbl包装枚数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.lbl包装枚数.Text = "包装枚数"
        Me.lbl包装枚数.Top = 3.582677!
        Me.lbl包装枚数.Width = 2.047244!
        '
        'lblラベルサイズ面付流れ
        '
        Me.lblラベルサイズ面付流れ.Height = 0.3543307!
        Me.lblラベルサイズ面付流れ.HyperLink = Nothing
        Me.lblラベルサイズ面付流れ.Left = 4.488188!
        Me.lblラベルサイズ面付流れ.Name = "lblラベルサイズ面付流れ"
        Me.lblラベルサイズ面付流れ.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblラベルサイズ面付流れ.Text = "流れ"
        Me.lblラベルサイズ面付流れ.Top = 2.559055!
        Me.lblラベルサイズ面付流れ.Width = 0.3543307!
        '
        'Label3
        '
        Me.Label3.Height = 0.1574803!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 4.687402!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label3.Text = "担当者"
        Me.Label3.Top = 0.05118111!
        Me.Label3.Width = 0.9055118!
        '
        'TextBox5
        '
        Me.TextBox5.Height = 0.1574803!
        Me.TextBox5.Left = 4.687402!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox5.Text = "あああああ"
        Me.TextBox5.Top = 0.2086614!
        Me.TextBox5.Width = 0.9055118!
        '
        'lbl積算No
        '
        Me.lbl積算No.Height = 0.1574803!
        Me.lbl積算No.HyperLink = Nothing
        Me.lbl積算No.Left = 6.550394!
        Me.lbl積算No.Name = "lbl積算No"
        Me.lbl積算No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl積算No.Text = "積算No"
        Me.lbl積算No.Top = 0.01023622!
        Me.lbl積算No.Width = 0.8118109!
        '
        'txt積算No
        '
        Me.txt積算No.Height = 0.1968504!
        Me.txt積算No.Left = 6.550394!
        Me.txt積算No.Name = "txt積算No"
        Me.txt積算No.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: justify; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt積算No.Text = "123456"
        Me.txt積算No.Top = 0.1677165!
        Me.txt積算No.Width = 0.8118109!
        '
        'Label2
        '
        Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.Label2.Height = 0.6692914!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.0!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label2.Text = "ﾕｰｻﾞｰ名"
        Me.Label2.Top = 0.3937008!
        Me.Label2.Width = 0.472441!
        '
        'lbl商品名
        '
        Me.lbl商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl商品名.Height = 0.7480315!
        Me.lbl商品名.HyperLink = Nothing
        Me.lbl商品名.Left = 0.0!
        Me.lbl商品名.Name = "lbl商品名"
        Me.lbl商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl商品名.Text = "品名"
        Me.lbl商品名.Top = 1.062992!
        Me.lbl商品名.Width = 0.472441!
        '
        'lbl印刷色
        '
        Me.lbl印刷色.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl印刷色.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl印刷色.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl印刷色.Height = 0.472441!
        Me.lbl印刷色.HyperLink = Nothing
        Me.lbl印刷色.Left = 0.0!
        Me.lbl印刷色.Name = "lbl印刷色"
        Me.lbl印刷色.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl印刷色.Text = "印刷色"
        Me.lbl印刷色.Top = 1.811024!
        Me.lbl印刷色.Width = 0.472441!
        '
        'txt得意先名1
        '
        Me.txt得意先名1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt得意先名1.Height = 0.3346457!
        Me.txt得意先名1.Left = 0.472441!
        Me.txt得意先名1.Name = "txt得意先名1"
        Me.txt得意先名1.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: justify; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt得意先名1.Text = "あああああいいいいいうううううえええええおおおおおかかかかかきききききくくくくくけけけけけこここここ"
        Me.txt得意先名1.Top = 0.3937008!
        Me.txt得意先名1.Width = 3.543307!
        '
        'txt品名1
        '
        Me.txt品名1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt品名1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt品名1.Height = 0.3740157!
        Me.txt品名1.Left = 0.472441!
        Me.txt品名1.Name = "txt品名1"
        Me.txt品名1.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txt品名1.Text = "あああああいいいいいうううううえええええおおおおおかかかかかききききき"
        Me.txt品名1.Top = 1.062992!
        Me.txt品名1.Width = 6.968504!
        '
        'txt角R
        '
        Me.txt角R.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt角R.Height = 0.3543307!
        Me.txt角R.Left = 6.141732!
        Me.txt角R.Name = "txt角R"
        Me.txt角R.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt角R.Text = "角99.99R"
        Me.txt角R.Top = 2.913386!
        Me.txt角R.Width = 0.6692914!
        '
        'lbl巻取
        '
        Me.lbl巻取.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl巻取.Height = 0.1968504!
        Me.lbl巻取.HyperLink = Nothing
        Me.lbl巻取.Left = 0.0!
        Me.lbl巻取.Name = "lbl巻取"
        Me.lbl巻取.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl巻取.Text = "巻取"
        Me.lbl巻取.Top = 3.582677!
        Me.lbl巻取.Width = 0.511811!
        '
        'lbl一巻当り
        '
        Me.lbl一巻当り.Height = 0.1968504!
        Me.lbl一巻当り.HyperLink = Nothing
        Me.lbl一巻当り.Left = 1.889764!
        Me.lbl一巻当り.Name = "lbl一巻当り"
        Me.lbl一巻当り.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl一巻当り.Text = "一巻当り"
        Me.lbl一巻当り.Top = 3.582677!
        Me.lbl一巻当り.Width = 0.8267716!
        '
        'txt得意先CD
        '
        Me.txt得意先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt得意先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt得意先CD.Height = 0.6692914!
        Me.txt得意先CD.Left = 4.015748!
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: justify; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt得意先CD.Text = "(123456)"
        Me.txt得意先CD.Top = 0.3937008!
        Me.txt得意先CD.Width = 3.425197!
        '
        'txt巻取名
        '
        Me.txt巻取名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻取名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt巻取名.Height = 0.3937008!
        Me.txt巻取名.Left = 0.0!
        Me.txt巻取名.Name = "txt巻取名"
        Me.txt巻取名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt巻取名.Text = "999"
        Me.txt巻取名.Top = 3.779528!
        Me.txt巻取名.Width = 0.511811!
        '
        'txt出し方向名
        '
        Me.txt出し方向名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出し方向名.Height = 0.3937008!
        Me.txt出し方向名.Left = 0.511811!
        Me.txt出し方向名.Name = "txt出し方向名"
        Me.txt出し方向名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt出し方向名.Text = "あああ"
        Me.txt出し方向名.Top = 3.779528!
        Me.txt出し方向名.Width = 0.6692914!
        '
        'txt紙管
        '
        Me.txt紙管.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙管.Height = 0.3937008!
        Me.txt紙管.Left = 1.181102!
        Me.txt紙管.Name = "txt紙管"
        Me.txt紙管.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt紙管.Text = "999mm"
        Me.txt紙管.Top = 3.779528!
        Me.txt紙管.Width = 0.7086614!
        '
        'lbl印刷場所
        '
        Me.lbl印刷場所.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl印刷場所.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl印刷場所.Height = 0.472441!
        Me.lbl印刷場所.HyperLink = Nothing
        Me.lbl印刷場所.Left = 4.92126!
        Me.lbl印刷場所.Name = "lbl印刷場所"
        Me.lbl印刷場所.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl印刷場所.Text = "印刷場所"
        Me.lbl印刷場所.Top = 1.811024!
        Me.lbl印刷場所.Width = 0.7874016!
        '
        'txt印刷場所
        '
        Me.txt印刷場所.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt印刷場所.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt印刷場所.Height = 0.472441!
        Me.txt印刷場所.Left = 5.708662!
        Me.txt印刷場所.Name = "txt印刷場所"
        Me.txt印刷場所.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt印刷場所.Text = "あああああ"
        Me.txt印刷場所.Top = 1.811024!
        Me.txt印刷場所.Width = 1.259843!
        '
        'txt印刷場所CD
        '
        Me.txt印刷場所CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt印刷場所CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt印刷場所CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt印刷場所CD.Height = 0.472441!
        Me.txt印刷場所CD.Left = 6.968504!
        Me.txt印刷場所CD.Name = "txt印刷場所CD"
        Me.txt印刷場所CD.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt印刷場所CD.Text = "(12)"
        Me.txt印刷場所CD.Top = 1.811024!
        Me.txt印刷場所CD.Width = 0.472441!
        '
        'Label4
        '
        Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.Label4.Height = 0.3543307!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.0!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label4.Text = "ドブ"
        Me.Label4.Top = 2.913386!
        Me.Label4.Width = 0.472441!
        '
        'txtラベルサイズ巾
        '
        Me.txtラベルサイズ巾.Height = 0.3543307!
        Me.txtラベルサイズ巾.Left = 0.472441!
        Me.txtラベルサイズ巾.Name = "txtラベルサイズ巾"
        Me.txtラベルサイズ巾.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtラベルサイズ巾.Text = "999.99mm"
        Me.txtラベルサイズ巾.Top = 2.559055!
        Me.txtラベルサイズ巾.Width = 0.7480315!
        '
        'txtドブ
        '
        Me.txtドブ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtドブ.Height = 0.3543307!
        Me.txtドブ.Left = 0.472441!
        Me.txtドブ.Name = "txtドブ"
        Me.txtドブ.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtドブ.Text = "999.99mm"
        Me.txtドブ.Top = 2.913386!
        Me.txtドブ.Width = 0.7480315!
        '
        'Label5
        '
        Me.Label5.Height = 0.3543307!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 1.220472!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label5.Text = "×"
        Me.Label5.Top = 2.559055!
        Me.Label5.Width = 0.1968504!
        '
        'Label10
        '
        Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Height = 0.3543307!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 1.220472!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label10.Text = "×"
        Me.Label10.Top = 2.913386!
        Me.Label10.Width = 0.1968504!
        '
        'lblラベルサイズ流れ
        '
        Me.lblラベルサイズ流れ.Height = 0.3543307!
        Me.lblラベルサイズ流れ.HyperLink = Nothing
        Me.lblラベルサイズ流れ.Left = 1.417323!
        Me.lblラベルサイズ流れ.Name = "lblラベルサイズ流れ"
        Me.lblラベルサイズ流れ.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblラベルサイズ流れ.Text = "流れ"
        Me.lblラベルサイズ流れ.Top = 2.559055!
        Me.lblラベルサイズ流れ.Width = 0.472441!
        '
        'Label13
        '
        Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Height = 0.3543307!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 1.417323!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label13.Text = "ドブ"
        Me.Label13.Top = 2.913386!
        Me.Label13.Width = 0.472441!
        '
        'txtラベルサイズ流れ
        '
        Me.txtラベルサイズ流れ.Height = 0.3543307!
        Me.txtラベルサイズ流れ.Left = 1.889764!
        Me.txtラベルサイズ流れ.Name = "txtラベルサイズ流れ"
        Me.txtラベルサイズ流れ.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtラベルサイズ流れ.Text = "999.99mm"
        Me.txtラベルサイズ流れ.Top = 2.559055!
        Me.txtラベルサイズ流れ.Width = 0.7480313!
        '
        'txtドブ2
        '
        Me.txtドブ2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtドブ2.Height = 0.3543307!
        Me.txtドブ2.Left = 1.889764!
        Me.txtドブ2.Name = "txtドブ2"
        Me.txtドブ2.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtドブ2.Text = "999.99mm"
        Me.txtドブ2.Top = 2.913386!
        Me.txtドブ2.Width = 0.7480313!
        '
        'lblラベルサイズ面付巾
        '
        Me.lblラベルサイズ面付巾.Height = 0.3543307!
        Me.lblラベルサイズ面付巾.HyperLink = Nothing
        Me.lblラベルサイズ面付巾.Left = 2.637795!
        Me.lblラベルサイズ面付巾.Name = "lblラベルサイズ面付巾"
        Me.lblラベルサイズ面付巾.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblラベルサイズ面付巾.Text = "面付　巾"
        Me.lblラベルサイズ面付巾.Top = 2.559055!
        Me.lblラベルサイズ面付巾.Width = 0.9055118!
        '
        'lblラベルサイズギア数
        '
        Me.lblラベルサイズギア数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblラベルサイズギア数.Height = 0.3543307!
        Me.lblラベルサイズギア数.HyperLink = Nothing
        Me.lblラベルサイズギア数.Left = 2.637795!
        Me.lblラベルサイズギア数.Name = "lblラベルサイズギア数"
        Me.lblラベルサイズギア数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblラベルサイズギア数.Text = "ギア数"
        Me.lblラベルサイズギア数.Top = 2.913386!
        Me.lblラベルサイズギア数.Width = 0.9055118!
        '
        'txtラベルサイズ面付巾
        '
        Me.txtラベルサイズ面付巾.Height = 0.3543307!
        Me.txtラベルサイズ面付巾.Left = 3.543307!
        Me.txtラベルサイズ面付巾.Name = "txtラベルサイズ面付巾"
        Me.txtラベルサイズ面付巾.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtラベルサイズ面付巾.Text = "999列"
        Me.txtラベルサイズ面付巾.Top = 2.559055!
        Me.txtラベルサイズ面付巾.Width = 0.7480313!
        '
        'txtギア数
        '
        Me.txtギア数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtギア数.Height = 0.3543307!
        Me.txtギア数.Left = 3.543307!
        Me.txtギア数.Name = "txtギア数"
        Me.txtギア数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtギア数.Text = "999"
        Me.txtギア数.Top = 2.913386!
        Me.txtギア数.Width = 0.7480313!
        '
        'Label18
        '
        Me.Label18.Height = 0.3543307!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 4.291338!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label18.Text = "×"
        Me.Label18.Top = 2.559055!
        Me.Label18.Width = 0.1968504!
        '
        'txtラベルサイズ面付流れ
        '
        Me.txtラベルサイズ面付流れ.Height = 0.3543307!
        Me.txtラベルサイズ面付流れ.Left = 4.842519!
        Me.txtラベルサイズ面付流れ.Name = "txtラベルサイズ面付流れ"
        Me.txtラベルサイズ面付流れ.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtラベルサイズ面付流れ.Text = "999段"
        Me.txtラベルサイズ面付流れ.Top = 2.559055!
        Me.txtラベルサイズ面付流れ.Width = 0.472441!
        '
        'Label14
        '
        Me.Label14.Height = 0.3543307!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 5.31496!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label14.Text = "="
        Me.Label14.Top = 2.559055!
        Me.Label14.Width = 0.3149606!
        '
        'txt流れ面数
        '
        Me.txt流れ面数.Height = 0.3543307!
        Me.txt流れ面数.Left = 5.62992!
        Me.txt流れ面数.Name = "txt流れ面数"
        Me.txt流れ面数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt流れ面数.Text = "999面"
        Me.txt流れ面数.Top = 2.559055!
        Me.txt流れ面数.Width = 0.511811!
        '
        'ラベルサイズ基準面付数
        '
        Me.ラベルサイズ基準面付数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.ラベルサイズ基準面付数.Height = 0.3543307!
        Me.ラベルサイズ基準面付数.Left = 6.929133!
        Me.ラベルサイズ基準面付数.Name = "ラベルサイズ基準面付数"
        Me.ラベルサイズ基準面付数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.ラベルサイズ基準面付数.Text = "1面"
        Me.ラベルサイズ基準面付数.Top = 2.559055!
        Me.ラベルサイズ基準面付数.Width = 0.511811!
        '
        'lblラベルサイズ送りピッチ
        '
        Me.lblラベルサイズ送りピッチ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblラベルサイズ送りピッチ.Height = 0.3543307!
        Me.lblラベルサイズ送りピッチ.HyperLink = Nothing
        Me.lblラベルサイズ送りピッチ.Left = 4.291338!
        Me.lblラベルサイズ送りピッチ.Name = "lblラベルサイズ送りピッチ"
        Me.lblラベルサイズ送りピッチ.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblラベルサイズ送りピッチ.Text = "送りピッチ"
        Me.lblラベルサイズ送りピッチ.Top = 2.913386!
        Me.lblラベルサイズ送りピッチ.Width = 0.9055118!
        '
        'txt送りピッチ
        '
        Me.txt送りピッチ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt送りピッチ.Height = 0.3543307!
        Me.txt送りピッチ.Left = 5.19685!
        Me.txt送りピッチ.Name = "txt送りピッチ"
        Me.txt送りピッチ.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt送りピッチ.Text = "999.999mm"
        Me.txt送りピッチ.Top = 2.913386!
        Me.txt送りピッチ.Width = 0.9448819!
        '
        'txt形状
        '
        Me.txt形状.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt形状.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt形状.Height = 0.3543307!
        Me.txt形状.Left = 6.811023!
        Me.txt形状.Name = "txt形状"
        Me.txt形状.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt形状.Text = "あああ"
        Me.txt形状.Top = 2.913386!
        Me.txt形状.Width = 0.6299213!
        '
        'lblｽﾘｯﾀｰ
        '
        Me.lblｽﾘｯﾀｰ.Height = 0.1968504!
        Me.lblｽﾘｯﾀｰ.HyperLink = Nothing
        Me.lblｽﾘｯﾀｰ.Left = 2.716536!
        Me.lblｽﾘｯﾀｰ.Name = "lblｽﾘｯﾀｰ"
        Me.lblｽﾘｯﾀｰ.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblｽﾘｯﾀｰ.Text = "ｽﾘｯﾀｰ"
        Me.lblｽﾘｯﾀｰ.Top = 3.582677!
        Me.lblｽﾘｯﾀｰ.Width = 0.7480315!
        '
        'lblカット
        '
        Me.lblカット.Height = 0.1968504!
        Me.lblカット.HyperLink = Nothing
        Me.lblカット.Left = 4.251969!
        Me.lblカット.Name = "lblカット"
        Me.lblカット.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblカット.Text = "カット"
        Me.lblカット.Top = 3.582677!
        Me.lblカット.Width = 0.5511811!
        '
        'lbl紙
        '
        Me.lbl紙.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl紙.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl紙.Height = 0.1968504!
        Me.lbl紙.HyperLink = Nothing
        Me.lbl紙.Left = 0.0!
        Me.lbl紙.Name = "lbl紙"
        Me.lbl紙.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl紙.Text = "紙"
        Me.lbl紙.Top = 4.173228!
        Me.lbl紙.Width = 1.614173!
        '
        'lbl必要巾
        '
        Me.lbl必要巾.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl必要巾.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl必要巾.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl必要巾.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl必要巾.Height = 0.1968504!
        Me.lbl必要巾.HyperLink = Nothing
        Me.lbl必要巾.Left = 3.641732!
        Me.lbl必要巾.Name = "lbl必要巾"
        Me.lbl必要巾.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl必要巾.Text = "必要巾"
        Me.lbl必要巾.Top = 4.173229!
        Me.lbl必要巾.Width = 0.5511811!
        '
        'lbl出方
        '
        Me.lbl出方.Height = 0.1968504!
        Me.lbl出方.HyperLink = Nothing
        Me.lbl出方.Left = 0.511811!
        Me.lbl出方.Name = "lbl出方"
        Me.lbl出方.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl出方.Text = "出方"
        Me.lbl出方.Top = 3.582677!
        Me.lbl出方.Width = 0.6692914!
        '
        'lbl紙管
        '
        Me.lbl紙管.Height = 0.1968504!
        Me.lbl紙管.HyperLink = Nothing
        Me.lbl紙管.Left = 1.181102!
        Me.lbl紙管.Name = "lbl紙管"
        Me.lbl紙管.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl紙管.Text = "紙管"
        Me.lbl紙管.Top = 3.582677!
        Me.lbl紙管.Width = 0.7086614!
        '
        'lblｽﾘｯﾀｰ巾
        '
        Me.lblｽﾘｯﾀｰ巾.Height = 0.1968504!
        Me.lblｽﾘｯﾀｰ巾.HyperLink = Nothing
        Me.lblｽﾘｯﾀｰ巾.Left = 3.464567!
        Me.lblｽﾘｯﾀｰ巾.Name = "lblｽﾘｯﾀｰ巾"
        Me.lblｽﾘｯﾀｰ巾.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.lblｽﾘｯﾀｰ巾.Text = "ｽﾘｯﾀｰ巾"
        Me.lblｽﾘｯﾀｰ巾.Top = 3.582677!
        Me.lblｽﾘｯﾀｰ巾.Width = 0.7874016!
        '
        'lbl1ｼｰﾄ枚
        '
        Me.lbl1ｼｰﾄ枚.Height = 0.1968504!
        Me.lbl1ｼｰﾄ枚.HyperLink = Nothing
        Me.lbl1ｼｰﾄ枚.Left = 4.80315!
        Me.lbl1ｼｰﾄ枚.Name = "lbl1ｼｰﾄ枚"
        Me.lbl1ｼｰﾄ枚.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl1ｼｰﾄ枚.Text = "1ｼｰﾄ枚"
        Me.lbl1ｼｰﾄ枚.Top = 3.582678!
        Me.lbl1ｼｰﾄ枚.Width = 0.5905512!
        '
        'lbl台紙
        '
        Me.lbl台紙.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl台紙.Height = 0.1968504!
        Me.lbl台紙.HyperLink = Nothing
        Me.lbl台紙.Left = 2.637795!
        Me.lbl台紙.Name = "lbl台紙"
        Me.lbl台紙.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl台紙.Text = "台紙"
        Me.lbl台紙.Top = 4.173229!
        Me.lbl台紙.Width = 1.003937!
        '
        'lbl糊
        '
        Me.lbl糊.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl糊.Height = 0.1968504!
        Me.lbl糊.HyperLink = Nothing
        Me.lbl糊.Left = 1.614173!
        Me.lbl糊.Name = "lbl糊"
        Me.lbl糊.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl糊.Text = "糊"
        Me.lbl糊.Top = 4.173229!
        Me.lbl糊.Width = 1.023622!
        '
        'txt一巻当り
        '
        Me.txt一巻当り.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt一巻当り.Height = 0.3937008!
        Me.txt一巻当り.Left = 1.889764!
        Me.txt一巻当り.Name = "txt一巻当り"
        Me.txt一巻当り.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt一巻当り.Text = "999枚"
        Me.txt一巻当り.Top = 3.779528!
        Me.txt一巻当り.Width = 0.8267716!
        '
        'txtｽﾘｯﾀｰ名
        '
        Me.txtｽﾘｯﾀｰ名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txtｽﾘｯﾀｰ名.Height = 0.3937008!
        Me.txtｽﾘｯﾀｰ名.Left = 2.716535!
        Me.txtｽﾘｯﾀｰ名.Name = "txtｽﾘｯﾀｰ名"
        Me.txtｽﾘｯﾀｰ名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtｽﾘｯﾀｰ名.Text = "ああ"
        Me.txtｽﾘｯﾀｰ名.Top = 3.779528!
        Me.txtｽﾘｯﾀｰ名.Width = 0.7480315!
        '
        'txtｽﾘｯﾀｰ巾
        '
        Me.txtｽﾘｯﾀｰ巾.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txtｽﾘｯﾀｰ巾.Height = 0.3937008!
        Me.txtｽﾘｯﾀｰ巾.Left = 3.464567!
        Me.txtｽﾘｯﾀｰ巾.Name = "txtｽﾘｯﾀｰ巾"
        Me.txtｽﾘｯﾀｰ巾.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtｽﾘｯﾀｰ巾.Text = "999mm"
        Me.txtｽﾘｯﾀｰ巾.Top = 3.779528!
        Me.txtｽﾘｯﾀｰ巾.Width = 0.7874017!
        '
        'txt包装枚
        '
        Me.txt包装枚.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt包装枚.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt包装枚.Height = 0.3937008!
        Me.txt包装枚.Left = 5.393701!
        Me.txt包装枚.Name = "txt包装枚"
        Me.txt包装枚.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txt包装枚.Text = "999枚"
        Me.txt包装枚.Top = 3.777166!
        Me.txt包装枚.Width = 2.047244!
        '
        'txtカット3
        '
        Me.txtカット3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txtカット3.Height = 0.3937008!
        Me.txtカット3.Left = 4.803149!
        Me.txtカット3.Name = "txtカット3"
        Me.txtカット3.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtカット3.Text = "999枚"
        Me.txtカット3.Top = 3.777166!
        Me.txtカット3.Width = 0.5905512!
        '
        'txtカット1
        '
        Me.txtカット1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txtカット1.Height = 0.3937008!
        Me.txtカット1.Left = 4.251968!
        Me.txtカット1.Name = "txtカット1"
        Me.txtカット1.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtカット1.Text = "99"
        Me.txtカット1.Top = 3.779528!
        Me.txtカット1.Width = 0.1968504!
        '
        'lblメーカー名
        '
        Me.lblメーカー名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblメーカー名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblメーカー名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblメーカー名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lblメーカー名.Height = 0.1968504!
        Me.lblメーカー名.HyperLink = Nothing
        Me.lblメーカー名.Left = 4.192913!
        Me.lblメーカー名.Name = "lblメーカー名"
        Me.lblメーカー名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.lblメーカー名.Text = "　　メーカー名"
        Me.lblメーカー名.Top = 4.173229!
        Me.lblメーカー名.Width = 1.791339!
        '
        'lbl単価
        '
        Me.lbl単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl単価.Height = 0.1968504!
        Me.lbl単価.HyperLink = Nothing
        Me.lbl単価.Left = 5.984252!
        Me.lbl単価.Name = "lbl単価"
        Me.lbl単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.lbl単価.Text = "　　単価"
        Me.lbl単価.Top = 4.173229!
        Me.lbl単価.Width = 1.456693!
        '
        'lblラベルサイズドブ1
        '
        Me.lblラベルサイズドブ1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lblラベルサイズドブ1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lblラベルサイズドブ1.Height = 0.3543307!
        Me.lblラベルサイズドブ1.HyperLink = Nothing
        Me.lblラベルサイズドブ1.Left = 0.0000001192093!
        Me.lblラベルサイズドブ1.Name = "lblラベルサイズドブ1"
        Me.lblラベルサイズドブ1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblラベルサイズドブ1.Text = "ドブ"
        Me.lblラベルサイズドブ1.Top = 2.913386!
        Me.lblラベルサイズドブ1.Width = 0.472441!
        '
        'txtラベルサイズドブ1
        '
        Me.txtラベルサイズドブ1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txtラベルサイズドブ1.Height = 0.3543307!
        Me.txtラベルサイズドブ1.Left = 0.4724411!
        Me.txtラベルサイズドブ1.Name = "txtラベルサイズドブ1"
        Me.txtラベルサイズドブ1.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtラベルサイズドブ1.Text = "999.99mm"
        Me.txtラベルサイズドブ1.Top = 2.913386!
        Me.txtラベルサイズドブ1.Width = 0.7480313!
        '
        'Label8
        '
        Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.Label8.Height = 0.3543307!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 1.220472!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label8.Text = "×"
        Me.Label8.Top = 2.913386!
        Me.Label8.Width = 0.1968504!
        '
        'lblラベルサイズドブ2
        '
        Me.lblラベルサイズドブ2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lblラベルサイズドブ2.Height = 0.3543307!
        Me.lblラベルサイズドブ2.HyperLink = Nothing
        Me.lblラベルサイズドブ2.Left = 1.417323!
        Me.lblラベルサイズドブ2.Name = "lblラベルサイズドブ2"
        Me.lblラベルサイズドブ2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblラベルサイズドブ2.Text = "ドブ"
        Me.lblラベルサイズドブ2.Top = 2.913386!
        Me.lblラベルサイズドブ2.Width = 0.472441!
        '
        'txtラベルサイズドブ2
        '
        Me.txtラベルサイズドブ2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txtラベルサイズドブ2.Height = 0.3543307!
        Me.txtラベルサイズドブ2.Left = 1.889764!
        Me.txtラベルサイズドブ2.Name = "txtラベルサイズドブ2"
        Me.txtラベルサイズドブ2.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtラベルサイズドブ2.Text = "999.99mm"
        Me.txtラベルサイズドブ2.Top = 2.913386!
        Me.txtラベルサイズドブ2.Width = 0.7480313!
        '
        'txtラベルサイズギア数
        '
        Me.txtラベルサイズギア数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txtラベルサイズギア数.Height = 0.3543307!
        Me.txtラベルサイズギア数.Left = 3.543307!
        Me.txtラベルサイズギア数.Name = "txtラベルサイズギア数"
        Me.txtラベルサイズギア数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtラベルサイズギア数.Text = "999"
        Me.txtラベルサイズギア数.Top = 2.913386!
        Me.txtラベルサイズギア数.Width = 0.7480313!
        '
        'txtラベルサイズ送りピッチ
        '
        Me.txtラベルサイズ送りピッチ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txtラベルサイズ送りピッチ.Height = 0.3543307!
        Me.txtラベルサイズ送りピッチ.Left = 5.19685!
        Me.txtラベルサイズ送りピッチ.Name = "txtラベルサイズ送りピッチ"
        Me.txtラベルサイズ送りピッチ.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtラベルサイズ送りピッチ.Text = "999.999mm"
        Me.txtラベルサイズ送りピッチ.Top = 2.913386!
        Me.txtラベルサイズ送りピッチ.Width = 0.944882!
        '
        'lblラベルサイズ角R
        '
        Me.lblラベルサイズ角R.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lblラベルサイズ角R.Height = 0.3543307!
        Me.lblラベルサイズ角R.Left = 6.141732!
        Me.lblラベルサイズ角R.Name = "lblラベルサイズ角R"
        Me.lblラベルサイズ角R.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.lblラベルサイズ角R.Text = "角99.99R"
        Me.lblラベルサイズ角R.Top = 2.913386!
        Me.lblラベルサイズ角R.Width = 0.6692914!
        '
        'txtラベルサイズ角R
        '
        Me.txtラベルサイズ角R.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txtラベルサイズ角R.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txtラベルサイズ角R.Height = 0.3543307!
        Me.txtラベルサイズ角R.Left = 6.811023!
        Me.txtラベルサイズ角R.Name = "txtラベルサイズ角R"
        Me.txtラベルサイズ角R.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txtラベルサイズ角R.Text = "あああ"
        Me.txtラベルサイズ角R.Top = 2.913386!
        Me.txtラベルサイズ角R.Width = 0.6299213!
        '
        'txt品名2
        '
        Me.txt品名2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt品名2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt品名2.Height = 0.3740158!
        Me.txt品名2.Left = 0.472441!
        Me.txt品名2.Name = "txt品名2"
        Me.txt品名2.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: top; ddo-ch" & _
    "ar-set: 1"
        Me.txt品名2.Text = "あああああいいいいいうううううえええええおおおおおかかかかかききききき"
        Me.txt品名2.Top = 1.437008!
        Me.txt品名2.Width = 6.968507!
        '
        'txt得意先名2
        '
        Me.txt得意先名2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt得意先名2.Height = 0.3346457!
        Me.txt得意先名2.Left = 0.472441!
        Me.txt得意先名2.Name = "txt得意先名2"
        Me.txt得意先名2.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: justify; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt得意先名2.Text = "あああああいいいいいうううううえええええおおおおおかかかかかきききききくくくくくけけけけけこここここ"
        Me.txt得意先名2.Top = 0.7283465!
        Me.txt得意先名2.Width = 3.543307!
        '
        'txt入力担当CD
        '
        Me.txt入力担当CD.Height = 0.1574803!
        Me.txt入力担当CD.Left = 5.475591!
        Me.txt入力担当CD.Name = "txt入力担当CD"
        Me.txt入力担当CD.Style = "background-color: Red; font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; v" & _
    "ertical-align: bottom; ddo-char-set: 1"
        Me.txt入力担当CD.Text = "99"
        Me.txt入力担当CD.Top = 0.05275591!
        Me.txt入力担当CD.Visible = False
        Me.txt入力担当CD.Width = 0.1574803!
        '
        'Label1
        '
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.Label1.Height = 0.472441!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.472441!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label1.Text = "表"
        Me.Label1.Top = 1.811024!
        Me.Label1.Width = 0.3937008!
        '
        'Label7
        '
        Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.Label7.CharacterSpacing = 5.0!
        Me.Label7.Height = 0.472441!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 1.062992!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label7.Text = "C×裏"
        Me.Label7.Top = 1.811024!
        Me.Label7.Width = 0.5905512!
        '
        'txt表
        '
        Me.txt表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt表.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt表.Height = 0.472441!
        Me.txt表.Left = 0.8661418!
        Me.txt表.Name = "txt表"
        Me.txt表.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt表.Text = "99"
        Me.txt表.Top = 1.811024!
        Me.txt表.Width = 0.1968504!
        '
        'txt裏
        '
        Me.txt裏.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt裏.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt裏.Height = 0.472441!
        Me.txt裏.Left = 1.653543!
        Me.txt裏.Name = "txt裏"
        Me.txt裏.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt裏.Text = "99"
        Me.txt裏.Top = 1.811024!
        Me.txt裏.Width = 0.1968504!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.TextBox4.Height = 0.472441!
        Me.TextBox4.Left = 2.440945!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox4.Text = "99"
        Me.TextBox4.Top = 1.811024!
        Me.TextBox4.Width = 0.1968504!
        '
        'Label11
        '
        Me.Label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.Label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.Label11.CharacterSpacing = 5.0!
        Me.Label11.Height = 0.472441!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 1.850394!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label11.Text = "C=計"
        Me.Label11.Top = 1.811024!
        Me.Label11.Width = 0.5905511!
        '
        'Label16
        '
        Me.Label16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.Label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.Label16.CharacterSpacing = 5.0!
        Me.Label16.Height = 0.472441!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 2.637795!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.Label16.Text = "C"
        Me.Label16.Top = 1.811024!
        Me.Label16.Width = 0.5905511!
        '
        'txtカット2
        '
        Me.txtカット2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txtカット2.Height = 0.3937007!
        Me.txtカット2.Left = 4.606299!
        Me.txtカット2.Name = "txtカット2"
        Me.txtカット2.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtカット2.Text = "99"
        Me.txtカット2.Top = 3.779528!
        Me.txtカット2.Width = 0.1968504!
        '
        'Label19
        '
        Me.Label19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.Label19.Height = 0.3937008!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 4.448819!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label19.Text = "×"
        Me.Label19.Top = 3.779528!
        Me.Label19.Width = 0.1574803!
        '
        'grpFtr
        '
        Me.grpFtr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt備考1, Me.SubReport1, Me.lbl備考, Me.txt備考2, Me.txt備考3, Me.txt備考4, Me.txt備考5, Me.txt備考6, Me.txt備考7})
        Me.grpFtr.Height = 5.0!
        Me.grpFtr.Name = "grpFtr"
        '
        'txt備考1
        '
        Me.txt備考1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt備考1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt備考1.Height = 0.2165354!
        Me.txt備考1.Left = 0.0!
        Me.txt備考1.Name = "txt備考1"
        Me.txt備考1.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt備考1.Text = Nothing
        Me.txt備考1.Top = 0.2559055!
        Me.txt備考1.Width = 7.440945!
        '
        'SubReport1
        '
        Me.SubReport1.CloseBorder = False
        Me.SubReport1.Height = 3.228346!
        Me.SubReport1.Left = 0.0!
        Me.SubReport1.Name = "SubReport1"
        Me.SubReport1.Report = Nothing
        Me.SubReport1.ReportName = "SubReport1"
        Me.SubReport1.Top = 1.771654!
        Me.SubReport1.Width = 7.440945!
        '
        'lbl備考
        '
        Me.lbl備考.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl備考.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl備考.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl備考.Height = 0.2559055!
        Me.lbl備考.HyperLink = Nothing
        Me.lbl備考.Left = 0.0!
        Me.lbl備考.Name = "lbl備考"
        Me.lbl備考.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-ali" & _
    "gn: middle; ddo-char-set: 1"
        Me.lbl備考.Text = "【備考】"
        Me.lbl備考.Top = 0.0!
        Me.lbl備考.Width = 7.440945!
        '
        'txt備考2
        '
        Me.txt備考2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt備考2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt備考2.Height = 0.2165354!
        Me.txt備考2.Left = 0.0!
        Me.txt備考2.Name = "txt備考2"
        Me.txt備考2.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt備考2.Text = Nothing
        Me.txt備考2.Top = 0.472441!
        Me.txt備考2.Width = 7.440944!
        '
        'txt備考3
        '
        Me.txt備考3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt備考3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt備考3.Height = 0.2165354!
        Me.txt備考3.Left = 0.0!
        Me.txt備考3.Name = "txt備考3"
        Me.txt備考3.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt備考3.Text = Nothing
        Me.txt備考3.Top = 0.6889764!
        Me.txt備考3.Width = 7.440944!
        '
        'txt備考4
        '
        Me.txt備考4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt備考4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt備考4.Height = 0.2165354!
        Me.txt備考4.Left = 0.0!
        Me.txt備考4.Name = "txt備考4"
        Me.txt備考4.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt備考4.Text = Nothing
        Me.txt備考4.Top = 0.9055119!
        Me.txt備考4.Width = 7.440944!
        '
        'txt備考5
        '
        Me.txt備考5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt備考5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt備考5.Height = 0.2165354!
        Me.txt備考5.Left = 0.0!
        Me.txt備考5.Name = "txt備考5"
        Me.txt備考5.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt備考5.Text = Nothing
        Me.txt備考5.Top = 1.122047!
        Me.txt備考5.Width = 7.440944!
        '
        'txt備考6
        '
        Me.txt備考6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt備考6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt備考6.Height = 0.2165354!
        Me.txt備考6.Left = 0.0!
        Me.txt備考6.Name = "txt備考6"
        Me.txt備考6.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt備考6.Text = Nothing
        Me.txt備考6.Top = 1.338583!
        Me.txt備考6.Width = 7.440944!
        '
        'txt備考7
        '
        Me.txt備考7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt備考7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt備考7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt備考7.Height = 0.2165354!
        Me.txt備考7.Left = 0.0!
        Me.txt備考7.Name = "txt備考7"
        Me.txt備考7.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt備考7.Text = Nothing
        Me.txt備考7.Top = 1.555118!
        Me.txt備考7.Width = 7.440944!
        '
        'txtNow
        '
        Me.txtNow.Height = 0.1968504!
        Me.txtNow.Left = 5.629134!
        Me.txtNow.Name = "txtNow"
        Me.txtNow.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; text-justify: auto; verti" & _
    "cal-align: middle; ddo-char-set: 1"
        Me.txtNow.Text = "YY/MM/DD　00:00:00 作成"
        Me.txtNow.Top = 0.02047244!
        Me.txtNow.Width = 1.771654!
        '
        'txt頁
        '
        Me.txt頁.Height = 0.1968504!
        Me.txt頁.Left = 3.388189!
        Me.txt頁.Name = "txt頁"
        Me.txt頁.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; text-justify: auto; verti" & _
    "cal-align: middle; ddo-char-set: 1"
        Me.txt頁.Text = "頁"
        Me.txt頁.Top = 0.02047244!
        Me.txt頁.Width = 0.3795276!
        '
        'QuotationTotal
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.440945!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt台紙名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt社内価格, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt摘要, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt紙名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt伝票No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt糊名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt紙CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt糊CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt台紙CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入金明細表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl前残, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl基準面付数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblラベルサイズ巾, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl積算日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt積算日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl勘定科目, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl包装枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblラベルサイズ面付流れ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl積算No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt積算No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl印刷色, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt品名1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt角R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl巻取, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl一巻当り, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt巻取名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt出し方向名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt紙管, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl印刷場所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt印刷場所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt印刷場所CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtラベルサイズ巾, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtドブ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblラベルサイズ流れ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtラベルサイズ流れ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtドブ2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblラベルサイズ面付巾, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblラベルサイズギア数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtラベルサイズ面付巾, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtギア数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtラベルサイズ面付流れ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt流れ面数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ラベルサイズ基準面付数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblラベルサイズ送りピッチ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt送りピッチ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt形状, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblｽﾘｯﾀｰ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblカット, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl紙, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl必要巾, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl出方, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl紙管, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblｽﾘｯﾀｰ巾, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl1ｼｰﾄ枚, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl台紙, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl糊, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt一巻当り, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtｽﾘｯﾀｰ名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtｽﾘｯﾀｰ巾, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt包装枚, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtカット3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtカット1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblメーカー名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblラベルサイズドブ1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtラベルサイズドブ1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblラベルサイズドブ2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtラベルサイズドブ2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtラベルサイズギア数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtラベルサイズ送りピッチ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblラベルサイズ角R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtラベルサイズ角R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt品名2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入力担当CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt裏, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtカット2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt備考1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl備考, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt備考2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt備考3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt備考4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt備考5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt備考6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt備考7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt台紙名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt社内価格 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt摘要 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt紙名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt伝票No As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt入金明細表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl前残 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl基準面付数 As DataDynamics.ActiveReports.Label
    Private WithEvents lblラベルサイズ巾 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt備考1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl積算日 As DataDynamics.ActiveReports.Label
    Private WithEvents txt積算日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl勘定科目 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl包装枚数 As DataDynamics.ActiveReports.Label
    Private WithEvents lblラベルサイズ面付流れ As DataDynamics.ActiveReports.Label
    Private WithEvents txt糊名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl積算No As DataDynamics.ActiveReports.Label
    Private WithEvents txt積算No As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl印刷色 As DataDynamics.ActiveReports.Label
    Private WithEvents txt得意先名1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt品名1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt角R As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl巻取 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl一巻当り As DataDynamics.ActiveReports.Label
    Private WithEvents txt得意先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt出し方向名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt紙管 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl印刷場所 As DataDynamics.ActiveReports.Label
    Private WithEvents txt印刷場所 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt印刷場所CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents txtラベルサイズ巾 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtドブ As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Private WithEvents lblラベルサイズ流れ As DataDynamics.ActiveReports.Label
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents txtラベルサイズ流れ As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtドブ2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblラベルサイズ面付巾 As DataDynamics.ActiveReports.Label
    Private WithEvents lblラベルサイズギア数 As DataDynamics.ActiveReports.Label
    Private WithEvents txtラベルサイズ面付巾 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtギア数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label18 As DataDynamics.ActiveReports.Label
    Private WithEvents txtラベルサイズ面付流れ As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label14 As DataDynamics.ActiveReports.Label
    Private WithEvents txt流れ面数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ラベルサイズ基準面付数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblラベルサイズ送りピッチ As DataDynamics.ActiveReports.Label
    Private WithEvents txt送りピッチ As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt形状 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblｽﾘｯﾀｰ As DataDynamics.ActiveReports.Label
    Private WithEvents lblカット As DataDynamics.ActiveReports.Label
    Private WithEvents lbl紙 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl必要巾 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl出方 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl紙管 As DataDynamics.ActiveReports.Label
    Private WithEvents lblｽﾘｯﾀｰ巾 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl1ｼｰﾄ枚 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl台紙 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl糊 As DataDynamics.ActiveReports.Label
    Private WithEvents txt一巻当り As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtｽﾘｯﾀｰ名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtｽﾘｯﾀｰ巾 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt包装枚 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtカット3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtカット1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblメーカー名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl単価 As DataDynamics.ActiveReports.Label
    Private WithEvents SubReport1 As DataDynamics.ActiveReports.SubReport
    Private WithEvents lbl備考 As DataDynamics.ActiveReports.Label
    Private WithEvents lblラベルサイズドブ1 As DataDynamics.ActiveReports.Label
    Private WithEvents txtラベルサイズドブ1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents lblラベルサイズドブ2 As DataDynamics.ActiveReports.Label
    Private WithEvents txtラベルサイズドブ2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtラベルサイズギア数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtラベルサイズ送りピッチ As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblラベルサイズ角R As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtラベルサイズ角R As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt巻取名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt備考2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt備考3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt備考4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt備考5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt備考6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt備考7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt品名2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先名2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt入力担当CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents txt表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt裏 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label11 As DataDynamics.ActiveReports.Label
    Private WithEvents Label16 As DataDynamics.ActiveReports.Label
    Private WithEvents txtカット2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label19 As DataDynamics.ActiveReports.Label
    Private WithEvents txt紙CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt糊CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt台紙CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
End Class
