<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Flexible
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Flexible))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.lbl発送先 = New DataDynamics.ActiveReports.Label()
        Me.FlexibleSubDelivery = New DataDynamics.ActiveReports.SubReport()
        Me.lbl請求先 = New DataDynamics.ActiveReports.Label()
        Me.txt請求先CD = New DataDynamics.ActiveReports.TextBox()
        Me.FlexibleSubNote = New DataDynamics.ActiveReports.SubReport()
        Me.txt請求先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt製造者CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt製造者名 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl製造者 = New DataDynamics.ActiveReports.Label()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr作業No = New DataDynamics.ActiveReports.GroupHeader()
        Me.TextBox66 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox51 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox50 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox49 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox48 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl作業伝票 = New DataDynamics.ActiveReports.Label()
        Me.ｌｂｌ再版No = New DataDynamics.ActiveReports.Label()
        Me.txt再版No = New DataDynamics.ActiveReports.TextBox()
        Me.Barcode = New DataDynamics.ActiveReports.Barcode()
        Me.lbl顧客様No = New DataDynamics.ActiveReports.Label()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.lblユーザーNo = New DataDynamics.ActiveReports.Label()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.lbl本台帳番号 = New DataDynamics.ActiveReports.Label()
        Me.Label10 = New DataDynamics.ActiveReports.Label()
        Me.lbl枝番 = New DataDynamics.ActiveReports.Label()
        Me.txt顧客様No = New DataDynamics.ActiveReports.TextBox()
        Me.txtユーザーNp = New DataDynamics.ActiveReports.TextBox()
        Me.txt本台帳番号 = New DataDynamics.ActiveReports.TextBox()
        Me.txt枝番 = New DataDynamics.ActiveReports.TextBox()
        Me.lblユーザー名 = New DataDynamics.ActiveReports.Label()
        Me.txtユーザー名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl商品名 = New DataDynamics.ActiveReports.Label()
        Me.lbl受注日 = New DataDynamics.ActiveReports.Label()
        Me.txt受注日 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl納期 = New DataDynamics.ActiveReports.Label()
        Me.txt納期 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl顧客刃型番号 = New DataDynamics.ActiveReports.Label()
        Me.txt顧客刃型番号 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl受注数 = New DataDynamics.ActiveReports.Label()
        Me.txt受注数 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl単価 = New DataDynamics.ActiveReports.Label()
        Me.txt単価 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl金額 = New DataDynamics.ActiveReports.Label()
        Me.txt金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt原価 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl原価 = New DataDynamics.ActiveReports.Label()
        Me.Label18 = New DataDynamics.ActiveReports.Label()
        Me.lbl紙幅方向サイズ = New DataDynamics.ActiveReports.Label()
        Me.lbl流れ方向ｻｲｽﾞ = New DataDynamics.ActiveReports.Label()
        Me.lbl刃型線の角R = New DataDynamics.ActiveReports.Label()
        Me.lbl形状 = New DataDynamics.ActiveReports.Label()
        Me.lbl紙幅方向面付箋 = New DataDynamics.ActiveReports.Label()
        Me.lbl紙幅方向ﾄﾞﾌﾞ寸法 = New DataDynamics.ActiveReports.Label()
        Me.lbl流れ方向面付箋 = New DataDynamics.ActiveReports.Label()
        Me.lbl流れ方向ﾄﾞﾌﾞ寸法 = New DataDynamics.ActiveReports.Label()
        Me.lbl全体紙幅方向ｻｲｽﾞ = New DataDynamics.ActiveReports.Label()
        Me.lbl全体流れ方向ｻｲｽﾞ = New DataDynamics.ActiveReports.Label()
        Me.lbl輪転機 = New DataDynamics.ActiveReports.Label()
        Me.txt刃型サイズ紙幅方向 = New DataDynamics.ActiveReports.TextBox()
        Me.txt刃型サイズ一面流れ方向 = New DataDynamics.ActiveReports.TextBox()
        Me.txt刃型サイズ角 = New DataDynamics.ActiveReports.TextBox()
        Me.txt形状 = New DataDynamics.ActiveReports.TextBox()
        Me.txt面付紙幅方向面数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt面付紙幅方向ドブ寸法 = New DataDynamics.ActiveReports.TextBox()
        Me.txt面流れ方向面数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt面付流れ方向ドブ寸法 = New DataDynamics.ActiveReports.TextBox()
        Me.txt刃型サイズ全体紙幅方向 = New DataDynamics.ActiveReports.TextBox()
        Me.txt刃型サイズ全体流れ方向 = New DataDynamics.ActiveReports.TextBox()
        Me.lblギア数 = New DataDynamics.ActiveReports.Label()
        Me.txt刃型情報ギヤ数 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl板厚 = New DataDynamics.ActiveReports.Label()
        Me.txt刃型情報板厚 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl総円周 = New DataDynamics.ActiveReports.Label()
        Me.txt刃型情報総円周 = New DataDynamics.ActiveReports.TextBox()
        Me.txt刃型情報バリヤー = New DataDynamics.ActiveReports.TextBox()
        Me.lblバリヤー = New DataDynamics.ActiveReports.Label()
        Me.Label25 = New DataDynamics.ActiveReports.Label()
        Me.Label26 = New DataDynamics.ActiveReports.Label()
        Me.TextBox26 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox27 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox28 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox29 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox30 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox31 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox32 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox33 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox34 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox35 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox36 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox37 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox38 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox39 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox40 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox41 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox42 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox43 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox44 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox45 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox46 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox47 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox23 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox24 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox25 = New DataDynamics.ActiveReports.TextBox()
        Me.Label19 = New DataDynamics.ActiveReports.Label()
        Me.Label20 = New DataDynamics.ActiveReports.Label()
        Me.Label23 = New DataDynamics.ActiveReports.Label()
        Me.Label24 = New DataDynamics.ActiveReports.Label()
        Me.Label27 = New DataDynamics.ActiveReports.Label()
        Me.Label28 = New DataDynamics.ActiveReports.Label()
        Me.Label29 = New DataDynamics.ActiveReports.Label()
        Me.Label30 = New DataDynamics.ActiveReports.Label()
        Me.lbl反転CAD変型 = New DataDynamics.ActiveReports.Label()
        Me.lbl反転CAD = New DataDynamics.ActiveReports.Label()
        Me.lbl線端角の形状丸め = New DataDynamics.ActiveReports.Label()
        Me.Llbl刃型線の線幅 = New DataDynamics.ActiveReports.Label()
        Me.lbl原点の線幅 = New DataDynamics.ActiveReports.Label()
        Me.lblﾄﾝﾎﾞの線幅 = New DataDynamics.ActiveReports.Label()
        Me.lblセパレータ = New DataDynamics.ActiveReports.Label()
        Me.txt線幅刃型線 = New DataDynamics.ActiveReports.TextBox()
        Me.txt線幅原点 = New DataDynamics.ActiveReports.TextBox()
        Me.txt線幅ﾄﾝﾎﾞ = New DataDynamics.ActiveReports.TextBox()
        Me.txtセパレータ = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox52 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox53 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox54 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox55 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox56 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox57 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox58 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox59 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox60 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox61 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox62 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox63 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox64 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox65 = New DataDynamics.ActiveReports.TextBox()
        Me.Label31 = New DataDynamics.ActiveReports.Label()
        Me.Label32 = New DataDynamics.ActiveReports.Label()
        Me.TextBox67 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox68 = New DataDynamics.ActiveReports.TextBox()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.Label33 = New DataDynamics.ActiveReports.Label()
        Me.Shape2 = New DataDynamics.ActiveReports.Shape()
        Me.Shape3 = New DataDynamics.ActiveReports.Shape()
        Me.grpFtr作業No = New DataDynamics.ActiveReports.GroupFooter()
        CType(Me.lbl発送先, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl請求先, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt製造者CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt製造者名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl製造者, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl作業伝票, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ｌｂｌ再版No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt再版No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl顧客様No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblユーザーNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl本台帳番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl枝番, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt顧客様No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtユーザーNp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt本台帳番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt枝番, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblユーザー名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtユーザー名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl受注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl納期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt納期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl顧客刃型番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt顧客刃型番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt原価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl原価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl紙幅方向サイズ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl流れ方向ｻｲｽﾞ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl刃型線の角R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl形状, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl紙幅方向面付箋, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl紙幅方向ﾄﾞﾌﾞ寸法, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl流れ方向面付箋, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl流れ方向ﾄﾞﾌﾞ寸法, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl全体紙幅方向ｻｲｽﾞ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl全体流れ方向ｻｲｽﾞ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl輪転機, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt刃型サイズ紙幅方向, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt刃型サイズ一面流れ方向, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt刃型サイズ角, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt形状, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt面付紙幅方向面数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt面付紙幅方向ドブ寸法, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt面流れ方向面数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt面付流れ方向ドブ寸法, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt刃型サイズ全体紙幅方向, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt刃型サイズ全体流れ方向, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblギア数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt刃型情報ギヤ数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl板厚, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt刃型情報板厚, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl総円周, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt刃型情報総円周, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt刃型情報バリヤー, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblバリヤー, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl反転CAD変型, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl反転CAD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl線端角の形状丸め, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Llbl刃型線の線幅, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl原点の線幅, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblﾄﾝﾎﾞの線幅, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblセパレータ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt線幅刃型線, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt線幅原点, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt線幅ﾄﾝﾎﾞ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtセパレータ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lbl発送先, Me.FlexibleSubDelivery, Me.lbl請求先, Me.txt請求先CD, Me.FlexibleSubNote, Me.txt請求先名, Me.txt製造者CD, Me.txt製造者名, Me.lbl製造者})
        Me.Detail.Height = 1.771654!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'lbl発送先
        '
        Me.lbl発送先.Height = 0.1968504!
        Me.lbl発送先.HyperLink = Nothing
        Me.lbl発送先.Left = 0.0!
        Me.lbl発送先.Name = "lbl発送先"
        Me.lbl発送先.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.lbl発送先.Text = "【発送先】"
        Me.lbl発送先.Top = 0.1251969!
        Me.lbl発送先.Width = 0.9055118!
        '
        'FlexibleSubDelivery
        '
        Me.FlexibleSubDelivery.CloseBorder = False
        Me.FlexibleSubDelivery.Height = 0.9251968!
        Me.FlexibleSubDelivery.Left = 0.9204722!
        Me.FlexibleSubDelivery.Name = "FlexibleSubDelivery"
        Me.FlexibleSubDelivery.Report = Nothing
        Me.FlexibleSubDelivery.Top = 0.08189003!
        Me.FlexibleSubDelivery.Width = 3.031496!
        '
        'lbl請求先
        '
        Me.lbl請求先.Height = 0.1968504!
        Me.lbl請求先.HyperLink = Nothing
        Me.lbl請求先.Left = 0.0!
        Me.lbl請求先.Name = "lbl請求先"
        Me.lbl請求先.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.lbl請求先.Text = "【請求先】"
        Me.lbl請求先.Top = 1.149212!
        Me.lbl請求先.Width = 0.9055118!
        '
        'txt請求先CD
        '
        Me.txt請求先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先CD.Height = 0.3149606!
        Me.txt請求先CD.Left = 0.9204725!
        Me.txt請求先CD.Name = "txt請求先CD"
        Me.txt請求先CD.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt請求先CD.Text = "123"
        Me.txt請求先CD.Top = 1.089763!
        Me.txt請求先CD.Width = 0.5905512!
        '
        'FlexibleSubNote
        '
        Me.FlexibleSubNote.CloseBorder = False
        Me.FlexibleSubNote.Height = 1.692914!
        Me.FlexibleSubNote.Left = 4.162992!
        Me.FlexibleSubNote.Name = "FlexibleSubNote"
        Me.FlexibleSubNote.Report = Nothing
        Me.FlexibleSubNote.Top = 0.08188976!
        Me.FlexibleSubNote.Width = 3.070866!
        '
        'txt請求先名
        '
        Me.txt請求先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先名.Height = 0.3149606!
        Me.txt請求先名.Left = 1.511024!
        Me.txt請求先名.Name = "txt請求先名"
        Me.txt請求先名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt請求先名.Text = "あああああいいいいいううううう"
        Me.txt請求先名.Top = 1.089763!
        Me.txt請求先名.Width = 2.440945!
        '
        'txt製造者CD
        '
        Me.txt製造者CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt製造者CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt製造者CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt製造者CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt製造者CD.Height = 0.3149606!
        Me.txt製造者CD.Left = 0.9204725!
        Me.txt製造者CD.Name = "txt製造者CD"
        Me.txt製造者CD.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt製造者CD.Text = "123"
        Me.txt製造者CD.Top = 1.494488!
        Me.txt製造者CD.Width = 0.5905511!
        '
        'txt製造者名
        '
        Me.txt製造者名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt製造者名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt製造者名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt製造者名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt製造者名.Height = 0.3149606!
        Me.txt製造者名.Left = 1.511024!
        Me.txt製造者名.Name = "txt製造者名"
        Me.txt製造者名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt製造者名.Text = "あああああいいいいいううううう"
        Me.txt製造者名.Top = 1.494488!
        Me.txt製造者名.Width = 2.440945!
        '
        'lbl製造者
        '
        Me.lbl製造者.Height = 0.1968504!
        Me.lbl製造者.HyperLink = Nothing
        Me.lbl製造者.Left = 0.0!
        Me.lbl製造者.Name = "lbl製造者"
        Me.lbl製造者.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.lbl製造者.Text = "【製造者】"
        Me.lbl製造者.Top = 1.561417!
        Me.lbl製造者.Width = 0.9055118!
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdr作業No
        '
        Me.grpHdr作業No.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox66, Me.TextBox51, Me.TextBox50, Me.TextBox49, Me.TextBox48, Me.lbl作業伝票, Me.ｌｂｌ再版No, Me.txt再版No, Me.Barcode, Me.lbl顧客様No, Me.Label1, Me.lblユーザーNo, Me.Label7, Me.lbl本台帳番号, Me.Label10, Me.lbl枝番, Me.txt顧客様No, Me.txtユーザーNp, Me.txt本台帳番号, Me.txt枝番, Me.lblユーザー名, Me.txtユーザー名, Me.txt商品名, Me.lbl商品名, Me.lbl受注日, Me.txt受注日, Me.lbl納期, Me.txt納期, Me.lbl顧客刃型番号, Me.txt顧客刃型番号, Me.lbl受注数, Me.txt受注数, Me.lbl単価, Me.txt単価, Me.lbl金額, Me.txt金額, Me.txt原価, Me.lbl原価, Me.Label18, Me.lbl紙幅方向サイズ, Me.lbl流れ方向ｻｲｽﾞ, Me.lbl刃型線の角R, Me.lbl形状, Me.lbl紙幅方向面付箋, Me.lbl紙幅方向ﾄﾞﾌﾞ寸法, Me.lbl流れ方向面付箋, Me.lbl流れ方向ﾄﾞﾌﾞ寸法, Me.lbl全体紙幅方向ｻｲｽﾞ, Me.lbl全体流れ方向ｻｲｽﾞ, Me.lbl輪転機, Me.txt刃型サイズ紙幅方向, Me.txt刃型サイズ一面流れ方向, Me.txt刃型サイズ角, Me.txt形状, Me.txt面付紙幅方向面数, Me.txt面付紙幅方向ドブ寸法, Me.txt面流れ方向面数, Me.txt面付流れ方向ドブ寸法, Me.txt刃型サイズ全体紙幅方向, Me.txt刃型サイズ全体流れ方向, Me.lblギア数, Me.txt刃型情報ギヤ数, Me.lbl板厚, Me.txt刃型情報板厚, Me.lbl総円周, Me.txt刃型情報総円周, Me.txt刃型情報バリヤー, Me.lblバリヤー, Me.Label25, Me.Label26, Me.TextBox26, Me.TextBox27, Me.TextBox28, Me.TextBox29, Me.TextBox30, Me.TextBox31, Me.TextBox32, Me.TextBox33, Me.TextBox34, Me.TextBox35, Me.TextBox36, Me.TextBox37, Me.TextBox38, Me.TextBox39, Me.TextBox40, Me.TextBox41, Me.TextBox42, Me.TextBox43, Me.TextBox44, Me.TextBox45, Me.TextBox46, Me.TextBox47, Me.TextBox17, Me.TextBox23, Me.TextBox24, Me.TextBox25, Me.Label19, Me.Label20, Me.Label23, Me.Label24, Me.Label27, Me.Label28, Me.Label29, Me.Label30, Me.lbl反転CAD変型, Me.lbl反転CAD, Me.lbl線端角の形状丸め, Me.Llbl刃型線の線幅, Me.lbl原点の線幅, Me.lblﾄﾝﾎﾞの線幅, Me.lblセパレータ, Me.txt線幅刃型線, Me.txt線幅原点, Me.txt線幅ﾄﾝﾎﾞ, Me.txtセパレータ, Me.TextBox52, Me.TextBox53, Me.TextBox54, Me.TextBox55, Me.TextBox56, Me.TextBox57, Me.TextBox58, Me.TextBox59, Me.TextBox60, Me.TextBox61, Me.TextBox62, Me.TextBox63, Me.TextBox64, Me.TextBox65, Me.Label31, Me.Label32, Me.TextBox67, Me.TextBox68, Me.Label5, Me.Label33, Me.Shape2, Me.Shape3})
        Me.grpHdr作業No.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr作業No.Height = 8.83847!
        Me.grpHdr作業No.Name = "grpHdr作業No"
        Me.grpHdr作業No.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'TextBox66
        '
        Me.TextBox66.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox66.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox66.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox66.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox66.Height = 3.937008!
        Me.TextBox66.Left = 0.0!
        Me.TextBox66.Name = "TextBox66"
        Me.TextBox66.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox66.Text = Nothing
        Me.TextBox66.Top = 4.811811!
        Me.TextBox66.Width = 7.283465!
        '
        'TextBox51
        '
        Me.TextBox51.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox51.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox51.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox51.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox51.Height = 0.472441!
        Me.TextBox51.Left = 6.810237!
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox51.Text = Nothing
        Me.TextBox51.Top = 2.336221!
        Me.TextBox51.Width = 0.492126!
        '
        'TextBox50
        '
        Me.TextBox50.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox50.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox50.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox50.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox50.Height = 0.472441!
        Me.TextBox50.Left = 6.318111!
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox50.Text = Nothing
        Me.TextBox50.Top = 2.336221!
        Me.TextBox50.Width = 0.492126!
        '
        'TextBox49
        '
        Me.TextBox49.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox49.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox49.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox49.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox49.Height = 0.472441!
        Me.TextBox49.Left = 5.392914!
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox49.Text = Nothing
        Me.TextBox49.Top = 2.336222!
        Me.TextBox49.Width = 0.4625984!
        '
        'TextBox48
        '
        Me.TextBox48.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox48.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox48.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox48.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox48.Height = 0.472441!
        Me.TextBox48.Left = 5.855513!
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox48.Text = Nothing
        Me.TextBox48.Top = 2.336221!
        Me.TextBox48.Width = 0.4625984!
        '
        'lbl作業伝票
        '
        Me.lbl作業伝票.Height = 0.3937008!
        Me.lbl作業伝票.HyperLink = Nothing
        Me.lbl作業伝票.Left = 3.876772!
        Me.lbl作業伝票.Name = "lbl作業伝票"
        Me.lbl作業伝票.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 12pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.lbl作業伝票.Text = "作業伝票(ﾌﾚｷｼﾌﾞﾙ刃型)"
        Me.lbl作業伝票.Top = 0.0!
        Me.lbl作業伝票.Width = 1.934646!
        '
        'ｌｂｌ再版No
        '
        Me.ｌｂｌ再版No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ再版No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ再版No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ再版No.Height = 0.2362205!
        Me.ｌｂｌ再版No.HyperLink = Nothing
        Me.ｌｂｌ再版No.Left = 6.102363!
        Me.ｌｂｌ再版No.Name = "ｌｂｌ再版No"
        Me.ｌｂｌ再版No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.ｌｂｌ再版No.Text = "再版No"
        Me.ｌｂｌ再版No.Top = 0.6165355!
        Me.ｌｂｌ再版No.Width = 1.122047!
        '
        'txt再版No
        '
        Me.txt再版No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt再版No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt再版No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt再版No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt再版No.Height = 0.2362205!
        Me.txt再版No.Left = 6.102363!
        Me.txt再版No.Name = "txt再版No"
        Me.txt再版No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt再版No.Text = "123456"
        Me.txt再版No.Top = 0.852756!
        Me.txt再版No.Width = 1.122047!
        '
        'Barcode
        '
        Me.Barcode.CheckSumEnabled = False
        Me.Barcode.DataField = "ReportNoJudge"
        Me.Barcode.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Barcode.Height = 0.3937008!
        Me.Barcode.Left = 5.964567!
        Me.Barcode.Name = "Barcode"
        Me.Barcode.Style = DataDynamics.ActiveReports.BarCodeStyle.Code39
        Me.Barcode.Text = "Barcode"
        Me.Barcode.Top = 0.0!
        Me.Barcode.Width = 1.259843!
        '
        'lbl顧客様No
        '
        Me.lbl顧客様No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl顧客様No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl顧客様No.Height = 0.2362205!
        Me.lbl顧客様No.HyperLink = Nothing
        Me.lbl顧客様No.Left = 0.0!
        Me.lbl顧客様No.Name = "lbl顧客様No"
        Me.lbl顧客様No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: normal; text-align" & _
    ": center; vertical-align: middle; ddo-char-set: 1"
        Me.lbl顧客様No.Text = "顧客様No"
        Me.lbl顧客様No.Top = 0.0!
        Me.lbl顧客様No.Width = 0.8661417!
        '
        'Label1
        '
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Height = 0.5511811!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.8661417!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: normal; text-al" & _
    "ign: center; vertical-align: middle; ddo-char-set: 1"
        Me.Label1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "―"
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 0.2362205!
        '
        'lblユーザーNo
        '
        Me.lblユーザーNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblユーザーNo.Height = 0.2362205!
        Me.lblユーザーNo.HyperLink = Nothing
        Me.lblユーザーNo.Left = 1.102362!
        Me.lblユーザーNo.Name = "lblユーザーNo"
        Me.lblユーザーNo.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: normal; text-align" & _
    ": center; vertical-align: middle; ddo-char-set: 1"
        Me.lblユーザーNo.Text = "ユーザーNo"
        Me.lblユーザーNo.Top = 0.0!
        Me.lblユーザーNo.Width = 0.8661417!
        '
        'Label7
        '
        Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Height = 0.5511811!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 1.968504!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: normal; text-al" & _
    "ign: center; vertical-align: middle; ddo-char-set: 1"
        Me.Label7.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "―"
        Me.Label7.Top = 0.0!
        Me.Label7.Width = 0.2362205!
        '
        'lbl本台帳番号
        '
        Me.lbl本台帳番号.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl本台帳番号.Height = 0.2362205!
        Me.lbl本台帳番号.HyperLink = Nothing
        Me.lbl本台帳番号.Left = 2.204724!
        Me.lbl本台帳番号.Name = "lbl本台帳番号"
        Me.lbl本台帳番号.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: normal; text-align" & _
    ": center; vertical-align: middle; ddo-char-set: 1"
        Me.lbl本台帳番号.Text = "本台帳番号"
        Me.lbl本台帳番号.Top = 9.313226E-10!
        Me.lbl本台帳番号.Width = 0.8661417!
        '
        'Label10
        '
        Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Height = 0.5511811!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 3.070866!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: normal; text-al" & _
    "ign: center; vertical-align: middle; ddo-char-set: 1"
        Me.Label10.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "―"
        Me.Label10.Top = 0.0!
        Me.Label10.Width = 0.2362205!
        '
        'lbl枝番
        '
        Me.lbl枝番.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枝番.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枝番.Height = 0.2362205!
        Me.lbl枝番.HyperLink = Nothing
        Me.lbl枝番.Left = 3.307087!
        Me.lbl枝番.Name = "lbl枝番"
        Me.lbl枝番.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: normal; text-align" & _
    ": center; vertical-align: middle; ddo-char-set: 1"
        Me.lbl枝番.Text = "枝番"
        Me.lbl枝番.Top = 0.0!
        Me.lbl枝番.Width = 0.3937008!
        '
        'txt顧客様No
        '
        Me.txt顧客様No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客様No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客様No.Height = 0.3149606!
        Me.txt顧客様No.Left = 0.0!
        Me.txt顧客様No.Name = "txt顧客様No"
        Me.txt顧客様No.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.txt顧客様No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt顧客様No.Text = "1234"
        Me.txt顧客様No.Top = 0.2362205!
        Me.txt顧客様No.Width = 0.8661417!
        '
        'txtユーザーNp
        '
        Me.txtユーザーNp.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtユーザーNp.Height = 0.3149606!
        Me.txtユーザーNp.Left = 1.102362!
        Me.txtユーザーNp.Name = "txtユーザーNp"
        Me.txtユーザーNp.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.txtユーザーNp.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtユーザーNp.Text = "123456"
        Me.txtユーザーNp.Top = 0.2362205!
        Me.txtユーザーNp.Width = 0.8661417!
        '
        'txt本台帳番号
        '
        Me.txt本台帳番号.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt本台帳番号.Height = 0.3149606!
        Me.txt本台帳番号.Left = 2.204724!
        Me.txt本台帳番号.Name = "txt本台帳番号"
        Me.txt本台帳番号.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.txt本台帳番号.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt本台帳番号.Text = "123456"
        Me.txt本台帳番号.Top = 0.2362205!
        Me.txt本台帳番号.Width = 0.8661417!
        '
        'txt枝番
        '
        Me.txt枝番.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枝番.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枝番.Height = 0.3149606!
        Me.txt枝番.Left = 3.307087!
        Me.txt枝番.Name = "txt枝番"
        Me.txt枝番.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.txt枝番.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt枝番.Text = "12"
        Me.txt枝番.Top = 0.2362205!
        Me.txt枝番.Width = 0.3937008!
        '
        'lblユーザー名
        '
        Me.lblユーザー名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblユーザー名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblユーザー名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblユーザー名.Height = 0.2362205!
        Me.lblユーザー名.HyperLink = Nothing
        Me.lblユーザー名.Left = 0.0!
        Me.lblユーザー名.Name = "lblユーザー名"
        Me.lblユーザー名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lblユーザー名.Text = "ユ　ー　ザ　ー 名"
        Me.lblユーザー名.Top = 0.6165355!
        Me.lblユーザー名.Width = 2.42126!
        '
        'txtユーザー名
        '
        Me.txtユーザー名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtユーザー名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtユーザー名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtユーザー名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtユーザー名.Height = 0.2362205!
        Me.txtユーザー名.Left = 0.0!
        Me.txtユーザー名.Name = "txtユーザー名"
        Me.txtユーザー名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtユーザー名.Text = "あああああいいいいいううううう"
        Me.txtユーザー名.Top = 0.852756!
        Me.txtユーザー名.Width = 2.42126!
        '
        'txt商品名
        '
        Me.txt商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Height = 0.2362205!
        Me.txt商品名.Left = 0.0!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt商品名.Text = "あああああいいいいいううううう"
        Me.txt商品名.Top = 1.400394!
        Me.txt商品名.Width = 2.42126!
        '
        'lbl商品名
        '
        Me.lbl商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Height = 0.2362205!
        Me.lbl商品名.HyperLink = Nothing
        Me.lbl商品名.Left = 0.0!
        Me.lbl商品名.Name = "lbl商品名"
        Me.lbl商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl商品名.Text = "商　　品　　名"
        Me.lbl商品名.Top = 1.164173!
        Me.lbl商品名.Width = 2.42126!
        '
        'lbl受注日
        '
        Me.lbl受注日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注日.Height = 0.2362205!
        Me.lbl受注日.HyperLink = Nothing
        Me.lbl受注日.Left = 2.42126!
        Me.lbl受注日.Name = "lbl受注日"
        Me.lbl受注日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl受注日.Text = "受 注 日"
        Me.lbl受注日.Top = 0.6165355!
        Me.lbl受注日.Width = 0.7874016!
        '
        'txt受注日
        '
        Me.txt受注日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注日.Height = 0.2362205!
        Me.txt受注日.Left = 2.42126!
        Me.txt受注日.Name = "txt受注日"
        Me.txt受注日.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt受注日.Text = "YYYY/MM/DD"
        Me.txt受注日.Top = 0.852756!
        Me.txt受注日.Width = 0.7874016!
        '
        'lbl納期
        '
        Me.lbl納期.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納期.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納期.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納期.Height = 0.2362205!
        Me.lbl納期.HyperLink = Nothing
        Me.lbl納期.Left = 3.208662!
        Me.lbl納期.Name = "lbl納期"
        Me.lbl納期.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl納期.Text = "納　　期"
        Me.lbl納期.Top = 0.6165356!
        Me.lbl納期.Width = 1.181102!
        '
        'txt納期
        '
        Me.txt納期.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納期.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納期.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納期.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納期.Height = 0.2362205!
        Me.txt納期.Left = 3.208662!
        Me.txt納期.Name = "txt納期"
        Me.txt納期.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt納期.Text = "YYYY/MM/DD"
        Me.txt納期.Top = 0.8527561!
        Me.txt納期.Width = 1.181102!
        '
        'lbl顧客刃型番号
        '
        Me.lbl顧客刃型番号.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl顧客刃型番号.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl顧客刃型番号.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl顧客刃型番号.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl顧客刃型番号.Height = 0.2362205!
        Me.lbl顧客刃型番号.HyperLink = Nothing
        Me.lbl顧客刃型番号.Left = 4.389764!
        Me.lbl顧客刃型番号.Name = "lbl顧客刃型番号"
        Me.lbl顧客刃型番号.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl顧客刃型番号.Text = "顧客刃型番号"
        Me.lbl顧客刃型番号.Top = 0.6165355!
        Me.lbl顧客刃型番号.Width = 1.259843!
        '
        'txt顧客刃型番号
        '
        Me.txt顧客刃型番号.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客刃型番号.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客刃型番号.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客刃型番号.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客刃型番号.Height = 0.2362205!
        Me.txt顧客刃型番号.Left = 4.389764!
        Me.txt顧客刃型番号.Name = "txt顧客刃型番号"
        Me.txt顧客刃型番号.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt顧客刃型番号.Text = "12345678"
        Me.txt顧客刃型番号.Top = 0.852756!
        Me.txt顧客刃型番号.Width = 1.259843!
        '
        'lbl受注数
        '
        Me.lbl受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注数.Height = 0.2362205!
        Me.lbl受注数.HyperLink = Nothing
        Me.lbl受注数.Left = 2.42126!
        Me.lbl受注数.Name = "lbl受注数"
        Me.lbl受注数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl受注数.Text = "受　注　数"
        Me.lbl受注数.Top = 1.164173!
        Me.lbl受注数.Width = 1.259843!
        '
        'txt受注数
        '
        Me.txt受注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Height = 0.2362205!
        Me.txt受注数.Left = 2.42126!
        Me.txt受注数.Name = "txt受注数"
        Me.txt受注数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt受注数.Text = "99,999"
        Me.txt受注数.Top = 1.400394!
        Me.txt受注数.Width = 1.259843!
        '
        'lbl単価
        '
        Me.lbl単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Height = 0.2362205!
        Me.lbl単価.HyperLink = Nothing
        Me.lbl単価.Left = 3.681102!
        Me.lbl単価.Name = "lbl単価"
        Me.lbl単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl単価.Text = "単　　価"
        Me.lbl単価.Top = 1.164174!
        Me.lbl単価.Width = 1.102362!
        '
        'txt単価
        '
        Me.txt単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Height = 0.2362205!
        Me.txt単価.Left = 3.681102!
        Me.txt単価.Name = "txt単価"
        Me.txt単価.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt単価.Text = "9,999"
        Me.txt単価.Top = 1.400395!
        Me.txt単価.Width = 1.102362!
        '
        'lbl金額
        '
        Me.lbl金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Height = 0.2362205!
        Me.lbl金額.HyperLink = Nothing
        Me.lbl金額.Left = 4.783464!
        Me.lbl金額.Name = "lbl金額"
        Me.lbl金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl金額.Text = "金　　額"
        Me.lbl金額.Top = 1.164174!
        Me.lbl金額.Width = 1.299213!
        '
        'txt金額
        '
        Me.txt金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Height = 0.2362205!
        Me.txt金額.Left = 4.783464!
        Me.txt金額.Name = "txt金額"
        Me.txt金額.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt金額.Text = "99,9999"
        Me.txt金額.Top = 1.400394!
        Me.txt金額.Width = 1.299213!
        '
        'txt原価
        '
        Me.txt原価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原価.Height = 0.2362205!
        Me.txt原価.Left = 6.082677!
        Me.txt原価.Name = "txt原価"
        Me.txt原価.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt原価.Text = "999,999"
        Me.txt原価.Top = 1.400393!
        Me.txt原価.Width = 1.220472!
        '
        'lbl原価
        '
        Me.lbl原価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl原価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl原価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl原価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl原価.Height = 0.2362205!
        Me.lbl原価.HyperLink = Nothing
        Me.lbl原価.Left = 6.082677!
        Me.lbl原価.Name = "lbl原価"
        Me.lbl原価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl原価.Text = "原　　価"
        Me.lbl原価.Top = 1.164172!
        Me.lbl原価.Width = 1.220472!
        '
        'Label18
        '
        Me.Label18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Height = 0.2755905!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 0.0!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label18.Text = "機械種"
        Me.Label18.Top = 1.864567!
        Me.Label18.Width = 1.437008!
        '
        'lbl紙幅方向サイズ
        '
        Me.lbl紙幅方向サイズ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙幅方向サイズ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙幅方向サイズ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙幅方向サイズ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙幅方向サイズ.Height = 0.2362205!
        Me.lbl紙幅方向サイズ.HyperLink = Nothing
        Me.lbl紙幅方向サイズ.Left = 0.0!
        Me.lbl紙幅方向サイズ.Name = "lbl紙幅方向サイズ"
        Me.lbl紙幅方向サイズ.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl紙幅方向サイズ.Text = "紙幅方向ｻｲｽﾞ(一面)"
        Me.lbl紙幅方向サイズ.Top = 2.140158!
        Me.lbl紙幅方向サイズ.Width = 1.437008!
        '
        'lbl流れ方向ｻｲｽﾞ
        '
        Me.lbl流れ方向ｻｲｽﾞ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl流れ方向ｻｲｽﾞ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl流れ方向ｻｲｽﾞ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl流れ方向ｻｲｽﾞ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl流れ方向ｻｲｽﾞ.Height = 0.3149606!
        Me.lbl流れ方向ｻｲｽﾞ.HyperLink = Nothing
        Me.lbl流れ方向ｻｲｽﾞ.Left = 0.0!
        Me.lbl流れ方向ｻｲｽﾞ.Name = "lbl流れ方向ｻｲｽﾞ"
        Me.lbl流れ方向ｻｲｽﾞ.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl流れ方向ｻｲｽﾞ.Text = "流れ方向ｻｲｽﾞ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ﾊﾞﾘﾔｰ後一面)"
        Me.lbl流れ方向ｻｲｽﾞ.Top = 2.376378!
        Me.lbl流れ方向ｻｲｽﾞ.Width = 1.437008!
        '
        'lbl刃型線の角R
        '
        Me.lbl刃型線の角R.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl刃型線の角R.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl刃型線の角R.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl刃型線の角R.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl刃型線の角R.Height = 0.2559055!
        Me.lbl刃型線の角R.HyperLink = Nothing
        Me.lbl刃型線の角R.Left = 0.0!
        Me.lbl刃型線の角R.Name = "lbl刃型線の角R"
        Me.lbl刃型線の角R.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl刃型線の角R.Text = "刃型線の角R"
        Me.lbl刃型線の角R.Top = 2.691339!
        Me.lbl刃型線の角R.Width = 1.437008!
        '
        'lbl形状
        '
        Me.lbl形状.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl形状.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl形状.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl形状.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl形状.Height = 0.2559055!
        Me.lbl形状.HyperLink = Nothing
        Me.lbl形状.Left = 0.0!
        Me.lbl形状.Name = "lbl形状"
        Me.lbl形状.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl形状.Text = "形　　状"
        Me.lbl形状.Top = 2.947245!
        Me.lbl形状.Width = 1.437008!
        '
        'lbl紙幅方向面付箋
        '
        Me.lbl紙幅方向面付箋.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙幅方向面付箋.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙幅方向面付箋.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙幅方向面付箋.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙幅方向面付箋.Height = 0.2362205!
        Me.lbl紙幅方向面付箋.HyperLink = Nothing
        Me.lbl紙幅方向面付箋.Left = 0.0!
        Me.lbl紙幅方向面付箋.Name = "lbl紙幅方向面付箋"
        Me.lbl紙幅方向面付箋.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl紙幅方向面付箋.Text = "紙幅方向面付箋"
        Me.lbl紙幅方向面付箋.Top = 3.20315!
        Me.lbl紙幅方向面付箋.Width = 1.437008!
        '
        'lbl紙幅方向ﾄﾞﾌﾞ寸法
        '
        Me.lbl紙幅方向ﾄﾞﾌﾞ寸法.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙幅方向ﾄﾞﾌﾞ寸法.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙幅方向ﾄﾞﾌﾞ寸法.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙幅方向ﾄﾞﾌﾞ寸法.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙幅方向ﾄﾞﾌﾞ寸法.Height = 0.2362205!
        Me.lbl紙幅方向ﾄﾞﾌﾞ寸法.HyperLink = Nothing
        Me.lbl紙幅方向ﾄﾞﾌﾞ寸法.Left = 0.0!
        Me.lbl紙幅方向ﾄﾞﾌﾞ寸法.Name = "lbl紙幅方向ﾄﾞﾌﾞ寸法"
        Me.lbl紙幅方向ﾄﾞﾌﾞ寸法.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl紙幅方向ﾄﾞﾌﾞ寸法.Text = "紙幅方向ﾄﾞﾌﾞ寸法"
        Me.lbl紙幅方向ﾄﾞﾌﾞ寸法.Top = 3.439371!
        Me.lbl紙幅方向ﾄﾞﾌﾞ寸法.Width = 1.437008!
        '
        'lbl流れ方向面付箋
        '
        Me.lbl流れ方向面付箋.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl流れ方向面付箋.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl流れ方向面付箋.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl流れ方向面付箋.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl流れ方向面付箋.Height = 0.2362205!
        Me.lbl流れ方向面付箋.HyperLink = Nothing
        Me.lbl流れ方向面付箋.Left = 0.0!
        Me.lbl流れ方向面付箋.Name = "lbl流れ方向面付箋"
        Me.lbl流れ方向面付箋.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl流れ方向面付箋.Text = "流れ方向面付箋"
        Me.lbl流れ方向面付箋.Top = 3.675591!
        Me.lbl流れ方向面付箋.Width = 1.437008!
        '
        'lbl流れ方向ﾄﾞﾌﾞ寸法
        '
        Me.lbl流れ方向ﾄﾞﾌﾞ寸法.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl流れ方向ﾄﾞﾌﾞ寸法.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl流れ方向ﾄﾞﾌﾞ寸法.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl流れ方向ﾄﾞﾌﾞ寸法.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl流れ方向ﾄﾞﾌﾞ寸法.Height = 0.2362205!
        Me.lbl流れ方向ﾄﾞﾌﾞ寸法.HyperLink = Nothing
        Me.lbl流れ方向ﾄﾞﾌﾞ寸法.Left = 0.0!
        Me.lbl流れ方向ﾄﾞﾌﾞ寸法.Name = "lbl流れ方向ﾄﾞﾌﾞ寸法"
        Me.lbl流れ方向ﾄﾞﾌﾞ寸法.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl流れ方向ﾄﾞﾌﾞ寸法.Text = "流れ方向ﾄﾞﾌﾞ寸法"
        Me.lbl流れ方向ﾄﾞﾌﾞ寸法.Top = 3.911812!
        Me.lbl流れ方向ﾄﾞﾌﾞ寸法.Width = 1.437008!
        '
        'lbl全体紙幅方向ｻｲｽﾞ
        '
        Me.lbl全体紙幅方向ｻｲｽﾞ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl全体紙幅方向ｻｲｽﾞ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl全体紙幅方向ｻｲｽﾞ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl全体紙幅方向ｻｲｽﾞ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl全体紙幅方向ｻｲｽﾞ.Height = 0.2362205!
        Me.lbl全体紙幅方向ｻｲｽﾞ.HyperLink = Nothing
        Me.lbl全体紙幅方向ｻｲｽﾞ.Left = 0.0!
        Me.lbl全体紙幅方向ｻｲｽﾞ.Name = "lbl全体紙幅方向ｻｲｽﾞ"
        Me.lbl全体紙幅方向ｻｲｽﾞ.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl全体紙幅方向ｻｲｽﾞ.Text = "紙幅方向ｻｲｽﾞ(全体)"
        Me.lbl全体紙幅方向ｻｲｽﾞ.Top = 4.148033!
        Me.lbl全体紙幅方向ｻｲｽﾞ.Width = 1.437008!
        '
        'lbl全体流れ方向ｻｲｽﾞ
        '
        Me.lbl全体流れ方向ｻｲｽﾞ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl全体流れ方向ｻｲｽﾞ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl全体流れ方向ｻｲｽﾞ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl全体流れ方向ｻｲｽﾞ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl全体流れ方向ｻｲｽﾞ.Height = 0.3346457!
        Me.lbl全体流れ方向ｻｲｽﾞ.HyperLink = Nothing
        Me.lbl全体流れ方向ｻｲｽﾞ.Left = 0.0!
        Me.lbl全体流れ方向ｻｲｽﾞ.Name = "lbl全体流れ方向ｻｲｽﾞ"
        Me.lbl全体流れ方向ｻｲｽﾞ.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl全体流れ方向ｻｲｽﾞ.Text = "流れ方向ｻｲｽﾞ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ﾊﾞﾘﾔｰ後全体)"
        Me.lbl全体流れ方向ｻｲｽﾞ.Top = 4.384252!
        Me.lbl全体流れ方向ｻｲｽﾞ.Width = 1.437008!
        '
        'lbl輪転機
        '
        Me.lbl輪転機.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl輪転機.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl輪転機.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl輪転機.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl輪転機.Height = 0.2755905!
        Me.lbl輪転機.HyperLink = Nothing
        Me.lbl輪転機.Left = 1.437008!
        Me.lbl輪転機.Name = "lbl輪転機"
        Me.lbl輪転機.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl輪転機.Text = "輪転機"
        Me.lbl輪転機.Top = 1.864567!
        Me.lbl輪転機.Width = 0.9645669!
        '
        'txt刃型サイズ紙幅方向
        '
        Me.txt刃型サイズ紙幅方向.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ紙幅方向.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ紙幅方向.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ紙幅方向.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ紙幅方向.Height = 0.2362205!
        Me.txt刃型サイズ紙幅方向.Left = 1.437008!
        Me.txt刃型サイズ紙幅方向.Name = "txt刃型サイズ紙幅方向"
        Me.txt刃型サイズ紙幅方向.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt刃型サイズ紙幅方向.Text = "134.00mm"
        Me.txt刃型サイズ紙幅方向.Top = 2.140158!
        Me.txt刃型サイズ紙幅方向.Width = 0.9645669!
        '
        'txt刃型サイズ一面流れ方向
        '
        Me.txt刃型サイズ一面流れ方向.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ一面流れ方向.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ一面流れ方向.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ一面流れ方向.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ一面流れ方向.Height = 0.3149606!
        Me.txt刃型サイズ一面流れ方向.Left = 1.437008!
        Me.txt刃型サイズ一面流れ方向.Name = "txt刃型サイズ一面流れ方向"
        Me.txt刃型サイズ一面流れ方向.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt刃型サイズ一面流れ方向.Text = "130.89mm"
        Me.txt刃型サイズ一面流れ方向.Top = 2.376378!
        Me.txt刃型サイズ一面流れ方向.Width = 0.9645669!
        '
        'txt刃型サイズ角
        '
        Me.txt刃型サイズ角.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ角.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ角.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ角.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ角.Height = 0.2559055!
        Me.txt刃型サイズ角.Left = 1.437008!
        Me.txt刃型サイズ角.Name = "txt刃型サイズ角"
        Me.txt刃型サイズ角.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt刃型サイズ角.Text = "4.5R"
        Me.txt刃型サイズ角.Top = 2.691339!
        Me.txt刃型サイズ角.Width = 0.9645669!
        '
        'txt形状
        '
        Me.txt形状.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt形状.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt形状.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt形状.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt形状.Height = 0.2559055!
        Me.txt形状.Left = 1.437008!
        Me.txt形状.Name = "txt形状"
        Me.txt形状.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt形状.Text = "長方形"
        Me.txt形状.Top = 2.947244!
        Me.txt形状.Width = 0.9645669!
        '
        'txt面付紙幅方向面数
        '
        Me.txt面付紙幅方向面数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt面付紙幅方向面数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt面付紙幅方向面数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt面付紙幅方向面数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt面付紙幅方向面数.Height = 0.2362205!
        Me.txt面付紙幅方向面数.Left = 1.437008!
        Me.txt面付紙幅方向面数.Name = "txt面付紙幅方向面数"
        Me.txt面付紙幅方向面数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt面付紙幅方向面数.Text = "1面"
        Me.txt面付紙幅方向面数.Top = 3.20315!
        Me.txt面付紙幅方向面数.Width = 0.9645669!
        '
        'txt面付紙幅方向ドブ寸法
        '
        Me.txt面付紙幅方向ドブ寸法.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt面付紙幅方向ドブ寸法.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt面付紙幅方向ドブ寸法.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt面付紙幅方向ドブ寸法.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt面付紙幅方向ドブ寸法.Height = 0.2362205!
        Me.txt面付紙幅方向ドブ寸法.Left = 1.437008!
        Me.txt面付紙幅方向ドブ寸法.Name = "txt面付紙幅方向ドブ寸法"
        Me.txt面付紙幅方向ドブ寸法.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt面付紙幅方向ドブ寸法.Text = "99,999"
        Me.txt面付紙幅方向ドブ寸法.Top = 3.43937!
        Me.txt面付紙幅方向ドブ寸法.Width = 0.9645669!
        '
        'txt面流れ方向面数
        '
        Me.txt面流れ方向面数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt面流れ方向面数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt面流れ方向面数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt面流れ方向面数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt面流れ方向面数.Height = 0.2362205!
        Me.txt面流れ方向面数.Left = 1.437008!
        Me.txt面流れ方向面数.Name = "txt面流れ方向面数"
        Me.txt面流れ方向面数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt面流れ方向面数.Text = "2面"
        Me.txt面流れ方向面数.Top = 3.675591!
        Me.txt面流れ方向面数.Width = 0.9645669!
        '
        'txt面付流れ方向ドブ寸法
        '
        Me.txt面付流れ方向ドブ寸法.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt面付流れ方向ドブ寸法.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt面付流れ方向ドブ寸法.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt面付流れ方向ドブ寸法.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt面付流れ方向ドブ寸法.Height = 0.2362205!
        Me.txt面付流れ方向ドブ寸法.Left = 1.437008!
        Me.txt面付流れ方向ドブ寸法.Name = "txt面付流れ方向ドブ寸法"
        Me.txt面付流れ方向ドブ寸法.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt面付流れ方向ドブ寸法.Text = "2.938mm"
        Me.txt面付流れ方向ドブ寸法.Top = 3.911811!
        Me.txt面付流れ方向ドブ寸法.Width = 0.9645669!
        '
        'txt刃型サイズ全体紙幅方向
        '
        Me.txt刃型サイズ全体紙幅方向.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ全体紙幅方向.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ全体紙幅方向.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ全体紙幅方向.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ全体紙幅方向.Height = 0.2362205!
        Me.txt刃型サイズ全体紙幅方向.Left = 1.437008!
        Me.txt刃型サイズ全体紙幅方向.Name = "txt刃型サイズ全体紙幅方向"
        Me.txt刃型サイズ全体紙幅方向.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt刃型サイズ全体紙幅方向.Text = "134.000mm"
        Me.txt刃型サイズ全体紙幅方向.Top = 4.148031!
        Me.txt刃型サイズ全体紙幅方向.Width = 0.9645669!
        '
        'txt刃型サイズ全体流れ方向
        '
        Me.txt刃型サイズ全体流れ方向.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ全体流れ方向.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ全体流れ方向.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ全体流れ方向.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型サイズ全体流れ方向.Height = 0.3346457!
        Me.txt刃型サイズ全体流れ方向.Left = 1.437008!
        Me.txt刃型サイズ全体流れ方向.Name = "txt刃型サイズ全体流れ方向"
        Me.txt刃型サイズ全体流れ方向.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt刃型サイズ全体流れ方向.Text = "264.695mm"
        Me.txt刃型サイズ全体流れ方向.Top = 4.384252!
        Me.txt刃型サイズ全体流れ方向.Width = 0.9645669!
        '
        'lblギア数
        '
        Me.lblギア数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblギア数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblギア数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblギア数.Height = 0.2362205!
        Me.lblギア数.HyperLink = Nothing
        Me.lblギア数.Left = 3.46378!
        Me.lblギア数.Name = "lblギア数"
        Me.lblギア数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lblギア数.Text = "ｷﾞｱ数"
        Me.lblギア数.Top = 1.863781!
        Me.lblギア数.Width = 0.9645669!
        '
        'txt刃型情報ギヤ数
        '
        Me.txt刃型情報ギヤ数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型情報ギヤ数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型情報ギヤ数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型情報ギヤ数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型情報ギヤ数.Height = 0.2362205!
        Me.txt刃型情報ギヤ数.Left = 3.46378!
        Me.txt刃型情報ギヤ数.Name = "txt刃型情報ギヤ数"
        Me.txt刃型情報ギヤ数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt刃型情報ギヤ数.Text = "85ｷﾞﾔ"
        Me.txt刃型情報ギヤ数.Top = 2.100001!
        Me.txt刃型情報ギヤ数.Width = 0.9645669!
        '
        'lbl板厚
        '
        Me.lbl板厚.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl板厚.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl板厚.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl板厚.Height = 0.2362205!
        Me.lbl板厚.HyperLink = Nothing
        Me.lbl板厚.Left = 4.428347!
        Me.lbl板厚.Name = "lbl板厚"
        Me.lbl板厚.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl板厚.Text = "板厚"
        Me.lbl板厚.Top = 1.863781!
        Me.lbl板厚.Width = 0.9645669!
        '
        'txt刃型情報板厚
        '
        Me.txt刃型情報板厚.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型情報板厚.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型情報板厚.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型情報板厚.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型情報板厚.Height = 0.2362205!
        Me.txt刃型情報板厚.Left = 4.428347!
        Me.txt刃型情報板厚.Name = "txt刃型情報板厚"
        Me.txt刃型情報板厚.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt刃型情報板厚.Text = "0.430mm"
        Me.txt刃型情報板厚.Top = 2.100002!
        Me.txt刃型情報板厚.Width = 0.9645669!
        '
        'lbl総円周
        '
        Me.lbl総円周.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl総円周.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl総円周.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl総円周.Height = 0.2362205!
        Me.lbl総円周.HyperLink = Nothing
        Me.lbl総円周.Left = 5.392914!
        Me.lbl総円周.Name = "lbl総円周"
        Me.lbl総円周.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl総円周.Text = "総円周"
        Me.lbl総円周.Top = 1.863781!
        Me.lbl総円周.Width = 0.9251968!
        '
        'txt刃型情報総円周
        '
        Me.txt刃型情報総円周.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型情報総円周.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型情報総円周.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型情報総円周.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型情報総円周.Height = 0.2362205!
        Me.txt刃型情報総円周.Left = 5.392914!
        Me.txt刃型情報総円周.Name = "txt刃型情報総円周"
        Me.txt刃型情報総円周.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt刃型情報総円周.Text = "269.875mm"
        Me.txt刃型情報総円周.Top = 2.100002!
        Me.txt刃型情報総円周.Width = 0.9251968!
        '
        'txt刃型情報バリヤー
        '
        Me.txt刃型情報バリヤー.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型情報バリヤー.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型情報バリヤー.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型情報バリヤー.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型情報バリヤー.Height = 0.2362205!
        Me.txt刃型情報バリヤー.Left = 6.31811!
        Me.txt刃型情報バリヤー.Name = "txt刃型情報バリヤー"
        Me.txt刃型情報バリヤー.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt刃型情報バリヤー.Text = "99.16%"
        Me.txt刃型情報バリヤー.Top = 2.1!
        Me.txt刃型情報バリヤー.Width = 0.984252!
        '
        'lblバリヤー
        '
        Me.lblバリヤー.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblバリヤー.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblバリヤー.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblバリヤー.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblバリヤー.Height = 0.2362205!
        Me.lblバリヤー.HyperLink = Nothing
        Me.lblバリヤー.Left = 6.31811!
        Me.lblバリヤー.Name = "lblバリヤー"
        Me.lblバリヤー.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lblバリヤー.Text = "ﾊﾞﾘﾔｰ"
        Me.lblバリヤー.Top = 1.863779!
        Me.lblバリヤー.Width = 0.984252!
        '
        'Label25
        '
        Me.Label25.Height = 0.1574803!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 2.392914!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label25.Text = "作成者"
        Me.Label25.Top = 1.717717!
        Me.Label25.Width = 0.472441!
        '
        'Label26
        '
        Me.Label26.Height = 0.1574803!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 2.865355!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label26.Text = "ｵﾍﾟﾚｰﾀ"
        Me.Label26.Top = 1.717717!
        Me.Label26.Width = 0.472441!
        '
        'TextBox26
        '
        Me.TextBox26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.Height = 0.2755905!
        Me.TextBox26.Left = 2.401575!
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox26.Text = Nothing
        Me.TextBox26.Top = 1.864566!
        Me.TextBox26.Width = 0.472441!
        '
        'TextBox27
        '
        Me.TextBox27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Height = 0.2755905!
        Me.TextBox27.Left = 2.874016!
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox27.Text = Nothing
        Me.TextBox27.Top = 1.864566!
        Me.TextBox27.Width = 0.472441!
        '
        'TextBox28
        '
        Me.TextBox28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Height = 0.2362205!
        Me.TextBox28.Left = 2.401575!
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox28.Text = Nothing
        Me.TextBox28.Top = 2.140157!
        Me.TextBox28.Width = 0.472441!
        '
        'TextBox29
        '
        Me.TextBox29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Height = 0.2362205!
        Me.TextBox29.Left = 2.874016!
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox29.Text = Nothing
        Me.TextBox29.Top = 2.140157!
        Me.TextBox29.Width = 0.472441!
        '
        'TextBox30
        '
        Me.TextBox30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Height = 0.3149606!
        Me.TextBox30.Left = 2.401575!
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox30.Text = Nothing
        Me.TextBox30.Top = 2.376378!
        Me.TextBox30.Width = 0.472441!
        '
        'TextBox31
        '
        Me.TextBox31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Height = 0.3149606!
        Me.TextBox31.Left = 2.874016!
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox31.Text = Nothing
        Me.TextBox31.Top = 2.376378!
        Me.TextBox31.Width = 0.472441!
        '
        'TextBox32
        '
        Me.TextBox32.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Height = 0.2559055!
        Me.TextBox32.Left = 2.401575!
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox32.Text = Nothing
        Me.TextBox32.Top = 2.691338!
        Me.TextBox32.Width = 0.472441!
        '
        'TextBox33
        '
        Me.TextBox33.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Height = 0.2559055!
        Me.TextBox33.Left = 2.874016!
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox33.Text = Nothing
        Me.TextBox33.Top = 2.691338!
        Me.TextBox33.Width = 0.472441!
        '
        'TextBox34
        '
        Me.TextBox34.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Height = 0.2559055!
        Me.TextBox34.Left = 2.401575!
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox34.Text = Nothing
        Me.TextBox34.Top = 2.947244!
        Me.TextBox34.Width = 0.472441!
        '
        'TextBox35
        '
        Me.TextBox35.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Height = 0.2559055!
        Me.TextBox35.Left = 2.874016!
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox35.Text = Nothing
        Me.TextBox35.Top = 2.947244!
        Me.TextBox35.Width = 0.472441!
        '
        'TextBox36
        '
        Me.TextBox36.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox36.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox36.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox36.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox36.Height = 0.2362205!
        Me.TextBox36.Left = 2.401575!
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox36.Text = Nothing
        Me.TextBox36.Top = 3.203149!
        Me.TextBox36.Width = 0.472441!
        '
        'TextBox37
        '
        Me.TextBox37.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox37.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox37.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox37.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox37.Height = 0.2362205!
        Me.TextBox37.Left = 2.874016!
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox37.Text = Nothing
        Me.TextBox37.Top = 3.203149!
        Me.TextBox37.Width = 0.472441!
        '
        'TextBox38
        '
        Me.TextBox38.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.Height = 0.2362205!
        Me.TextBox38.Left = 2.401575!
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox38.Text = Nothing
        Me.TextBox38.Top = 3.43937!
        Me.TextBox38.Width = 0.472441!
        '
        'TextBox39
        '
        Me.TextBox39.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox39.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox39.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox39.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox39.Height = 0.2362205!
        Me.TextBox39.Left = 2.874016!
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox39.Text = Nothing
        Me.TextBox39.Top = 3.43937!
        Me.TextBox39.Width = 0.472441!
        '
        'TextBox40
        '
        Me.TextBox40.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.Height = 0.2362205!
        Me.TextBox40.Left = 2.401575!
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox40.Text = Nothing
        Me.TextBox40.Top = 3.675591!
        Me.TextBox40.Width = 0.472441!
        '
        'TextBox41
        '
        Me.TextBox41.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.Height = 0.2362205!
        Me.TextBox41.Left = 2.874016!
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox41.Text = Nothing
        Me.TextBox41.Top = 3.675591!
        Me.TextBox41.Width = 0.472441!
        '
        'TextBox42
        '
        Me.TextBox42.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox42.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox42.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox42.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox42.Height = 0.2362205!
        Me.TextBox42.Left = 2.401575!
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox42.Text = Nothing
        Me.TextBox42.Top = 3.911811!
        Me.TextBox42.Width = 0.472441!
        '
        'TextBox43
        '
        Me.TextBox43.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox43.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox43.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox43.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox43.Height = 0.2362205!
        Me.TextBox43.Left = 2.874016!
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox43.Text = Nothing
        Me.TextBox43.Top = 3.911811!
        Me.TextBox43.Width = 0.472441!
        '
        'TextBox44
        '
        Me.TextBox44.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox44.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox44.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox44.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox44.Height = 0.2362205!
        Me.TextBox44.Left = 2.401575!
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox44.Text = Nothing
        Me.TextBox44.Top = 4.148032!
        Me.TextBox44.Width = 0.472441!
        '
        'TextBox45
        '
        Me.TextBox45.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox45.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox45.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox45.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox45.Height = 0.2362205!
        Me.TextBox45.Left = 2.874016!
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox45.Text = Nothing
        Me.TextBox45.Top = 4.148032!
        Me.TextBox45.Width = 0.472441!
        '
        'TextBox46
        '
        Me.TextBox46.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox46.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox46.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox46.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox46.Height = 0.3346457!
        Me.TextBox46.Left = 2.401575!
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox46.Text = Nothing
        Me.TextBox46.Top = 4.384252!
        Me.TextBox46.Width = 0.472441!
        '
        'TextBox47
        '
        Me.TextBox47.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox47.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox47.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox47.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox47.Height = 0.3346457!
        Me.TextBox47.Left = 2.874016!
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox47.Text = Nothing
        Me.TextBox47.Top = 4.384252!
        Me.TextBox47.Width = 0.472441!
        '
        'TextBox17
        '
        Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Height = 0.472441!
        Me.TextBox17.Left = 3.946064!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox17.Text = Nothing
        Me.TextBox17.Top = 2.336221!
        Me.TextBox17.Width = 0.4822835!
        '
        'TextBox23
        '
        Me.TextBox23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Height = 0.472441!
        Me.TextBox23.Left = 3.46378!
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox23.Text = Nothing
        Me.TextBox23.Top = 2.336221!
        Me.TextBox23.Width = 0.4822835!
        '
        'TextBox24
        '
        Me.TextBox24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Height = 0.472441!
        Me.TextBox24.Left = 4.910631!
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox24.Text = Nothing
        Me.TextBox24.Top = 2.336222!
        Me.TextBox24.Width = 0.4822835!
        '
        'TextBox25
        '
        Me.TextBox25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Height = 0.472441!
        Me.TextBox25.Left = 4.428347!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox25.Text = Nothing
        Me.TextBox25.Top = 2.336222!
        Me.TextBox25.Width = 0.4822835!
        '
        'Label19
        '
        Me.Label19.Height = 0.1574803!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 3.484252!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label19.Text = "作成者"
        Me.Label19.Top = 2.32441!
        Me.Label19.Width = 0.4330709!
        '
        'Label20
        '
        Me.Label20.Height = 0.1574803!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 3.966929!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label20.Text = "ｵﾍﾟﾚｰﾀ"
        Me.Label20.Top = 2.32441!
        Me.Label20.Width = 0.4330709!
        '
        'Label23
        '
        Me.Label23.Height = 0.1574803!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 6.350788!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label23.Text = "作成者"
        Me.Label23.Top = 2.325197!
        Me.Label23.Width = 0.4330709!
        '
        'Label24
        '
        Me.Label24.Height = 0.1574803!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 6.833465!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label24.Text = "ｵﾍﾟﾚｰﾀ"
        Me.Label24.Top = 2.325197!
        Me.Label24.Width = 0.4330709!
        '
        'Label27
        '
        Me.Label27.Height = 0.1574803!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 5.40315!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label27.Text = "作成者"
        Me.Label27.Top = 2.325984!
        Me.Label27.Width = 0.4330709!
        '
        'Label28
        '
        Me.Label28.Height = 0.1574803!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 5.865355!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label28.Text = "ｵﾍﾟﾚｰﾀ"
        Me.Label28.Top = 2.325984!
        Me.Label28.Width = 0.4330709!
        '
        'Label29
        '
        Me.Label29.Height = 0.1574803!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 4.455906!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label29.Text = "作成者"
        Me.Label29.Top = 2.322047!
        Me.Label29.Width = 0.4330709!
        '
        'Label30
        '
        Me.Label30.Height = 0.1574803!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 4.928347!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label30.Text = "ｵﾍﾟﾚｰﾀ"
        Me.Label30.Top = 2.322047!
        Me.Label30.Width = 0.4330709!
        '
        'lbl反転CAD変型
        '
        Me.lbl反転CAD変型.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl反転CAD変型.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl反転CAD変型.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl反転CAD変型.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl反転CAD変型.Height = 0.2362205!
        Me.lbl反転CAD変型.HyperLink = Nothing
        Me.lbl反転CAD変型.Left = 3.46378!
        Me.lbl反転CAD変型.Name = "lbl反転CAD変型"
        Me.lbl反転CAD変型.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-ali" & _
    "gn: bottom; ddo-char-set: 1"
        Me.lbl反転CAD変型.Text = "　反転CAD(変型)"
        Me.lbl反転CAD変型.Top = 3.062205!
        Me.lbl反転CAD変型.Width = 2.854331!
        '
        'lbl反転CAD
        '
        Me.lbl反転CAD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl反転CAD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl反転CAD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl反転CAD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl反転CAD.Height = 0.2362205!
        Me.lbl反転CAD.HyperLink = Nothing
        Me.lbl反転CAD.Left = 3.46378!
        Me.lbl反転CAD.Name = "lbl反転CAD"
        Me.lbl反転CAD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-ali" & _
    "gn: bottom; ddo-char-set: 1"
        Me.lbl反転CAD.Text = "　反転CAD→illusrator"
        Me.lbl反転CAD.Top = 3.298425!
        Me.lbl反転CAD.Width = 2.854331!
        '
        'lbl線端角の形状丸め
        '
        Me.lbl線端角の形状丸め.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl線端角の形状丸め.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl線端角の形状丸め.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl線端角の形状丸め.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl線端角の形状丸め.Height = 0.2362205!
        Me.lbl線端角の形状丸め.HyperLink = Nothing
        Me.lbl線端角の形状丸め.Left = 3.46378!
        Me.lbl線端角の形状丸め.Name = "lbl線端角の形状丸め"
        Me.lbl線端角の形状丸め.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-ali" & _
    "gn: bottom; ddo-char-set: 1"
        Me.lbl線端角の形状丸め.Text = "　線端・角の形状(丸め)"
        Me.lbl線端角の形状丸め.Top = 3.534646!
        Me.lbl線端角の形状丸め.Width = 2.854331!
        '
        'Llbl刃型線の線幅
        '
        Me.Llbl刃型線の線幅.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Llbl刃型線の線幅.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Llbl刃型線の線幅.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Llbl刃型線の線幅.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Llbl刃型線の線幅.Height = 0.2362205!
        Me.Llbl刃型線の線幅.HyperLink = Nothing
        Me.Llbl刃型線の線幅.Left = 3.46378!
        Me.Llbl刃型線の線幅.Name = "Llbl刃型線の線幅"
        Me.Llbl刃型線の線幅.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.Llbl刃型線の線幅.Text = "刃型線の線幅"
        Me.Llbl刃型線の線幅.Top = 3.770866!
        Me.Llbl刃型線の線幅.Width = 1.338583!
        '
        'lbl原点の線幅
        '
        Me.lbl原点の線幅.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl原点の線幅.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl原点の線幅.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl原点の線幅.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl原点の線幅.Height = 0.2362205!
        Me.lbl原点の線幅.HyperLink = Nothing
        Me.lbl原点の線幅.Left = 3.46378!
        Me.lbl原点の線幅.Name = "lbl原点の線幅"
        Me.lbl原点の線幅.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl原点の線幅.Text = "原点の線幅"
        Me.lbl原点の線幅.Top = 4.007087!
        Me.lbl原点の線幅.Width = 1.338583!
        '
        'lblﾄﾝﾎﾞの線幅
        '
        Me.lblﾄﾝﾎﾞの線幅.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblﾄﾝﾎﾞの線幅.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblﾄﾝﾎﾞの線幅.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblﾄﾝﾎﾞの線幅.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblﾄﾝﾎﾞの線幅.Height = 0.2362205!
        Me.lblﾄﾝﾎﾞの線幅.HyperLink = Nothing
        Me.lblﾄﾝﾎﾞの線幅.Left = 3.46378!
        Me.lblﾄﾝﾎﾞの線幅.Name = "lblﾄﾝﾎﾞの線幅"
        Me.lblﾄﾝﾎﾞの線幅.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lblﾄﾝﾎﾞの線幅.Text = "ﾄﾝﾎﾞの線幅"
        Me.lblﾄﾝﾎﾞの線幅.Top = 4.243307!
        Me.lblﾄﾝﾎﾞの線幅.Width = 1.338583!
        '
        'lblセパレータ
        '
        Me.lblセパレータ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblセパレータ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblセパレータ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblセパレータ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblセパレータ.Height = 0.2362205!
        Me.lblセパレータ.HyperLink = Nothing
        Me.lblセパレータ.Left = 3.46378!
        Me.lblセパレータ.Name = "lblセパレータ"
        Me.lblセパレータ.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lblセパレータ.Text = "セパレータ"
        Me.lblセパレータ.Top = 4.479527!
        Me.lblセパレータ.Width = 1.338583!
        '
        'txt線幅刃型線
        '
        Me.txt線幅刃型線.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt線幅刃型線.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt線幅刃型線.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt線幅刃型線.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt線幅刃型線.Height = 0.2362205!
        Me.txt線幅刃型線.Left = 4.802362!
        Me.txt線幅刃型線.Name = "txt線幅刃型線"
        Me.txt線幅刃型線.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt線幅刃型線.Text = "0.53mm"
        Me.txt線幅刃型線.Top = 3.770866!
        Me.txt線幅刃型線.Width = 1.515748!
        '
        'txt線幅原点
        '
        Me.txt線幅原点.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt線幅原点.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt線幅原点.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt線幅原点.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt線幅原点.Height = 0.2362205!
        Me.txt線幅原点.Left = 4.802362!
        Me.txt線幅原点.Name = "txt線幅原点"
        Me.txt線幅原点.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt線幅原点.Text = "0.35mm"
        Me.txt線幅原点.Top = 4.007087!
        Me.txt線幅原点.Width = 1.515748!
        '
        'txt線幅ﾄﾝﾎﾞ
        '
        Me.txt線幅ﾄﾝﾎﾞ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt線幅ﾄﾝﾎﾞ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt線幅ﾄﾝﾎﾞ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt線幅ﾄﾝﾎﾞ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt線幅ﾄﾝﾎﾞ.Height = 0.2362205!
        Me.txt線幅ﾄﾝﾎﾞ.Left = 4.802362!
        Me.txt線幅ﾄﾝﾎﾞ.Name = "txt線幅ﾄﾝﾎﾞ"
        Me.txt線幅ﾄﾝﾎﾞ.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt線幅ﾄﾝﾎﾞ.Text = "0.18mm"
        Me.txt線幅ﾄﾝﾎﾞ.Top = 4.243307!
        Me.txt線幅ﾄﾝﾎﾞ.Width = 1.515748!
        '
        'txtセパレータ
        '
        Me.txtセパレータ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtセパレータ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtセパレータ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtセパレータ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtセパレータ.Height = 0.2362205!
        Me.txtセパレータ.Left = 4.802362!
        Me.txtセパレータ.Name = "txtセパレータ"
        Me.txtセパレータ.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txtセパレータ.Text = "　８K青"
        Me.txtセパレータ.Top = 4.479527!
        Me.txtセパレータ.Width = 1.515748!
        '
        'TextBox52
        '
        Me.TextBox52.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox52.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox52.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox52.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox52.Height = 0.2362205!
        Me.TextBox52.Left = 6.810236!
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox52.Text = Nothing
        Me.TextBox52.Top = 4.007086!
        Me.TextBox52.Width = 0.492126!
        '
        'TextBox53
        '
        Me.TextBox53.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox53.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox53.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox53.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox53.Height = 0.2362205!
        Me.TextBox53.Left = 6.31811!
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox53.Text = Nothing
        Me.TextBox53.Top = 4.007086!
        Me.TextBox53.Width = 0.492126!
        '
        'TextBox54
        '
        Me.TextBox54.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox54.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox54.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox54.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox54.Height = 0.2362205!
        Me.TextBox54.Left = 6.810236!
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox54.Text = Nothing
        Me.TextBox54.Top = 4.243306!
        Me.TextBox54.Width = 0.492126!
        '
        'TextBox55
        '
        Me.TextBox55.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox55.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox55.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox55.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox55.Height = 0.2362205!
        Me.TextBox55.Left = 6.31811!
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox55.Text = Nothing
        Me.TextBox55.Top = 4.243306!
        Me.TextBox55.Width = 0.492126!
        '
        'TextBox56
        '
        Me.TextBox56.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox56.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox56.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox56.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox56.Height = 0.2362205!
        Me.TextBox56.Left = 6.810236!
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox56.Text = Nothing
        Me.TextBox56.Top = 4.479527!
        Me.TextBox56.Width = 0.492126!
        '
        'TextBox57
        '
        Me.TextBox57.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox57.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox57.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox57.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox57.Height = 0.2362205!
        Me.TextBox57.Left = 6.31811!
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox57.Text = Nothing
        Me.TextBox57.Top = 4.479527!
        Me.TextBox57.Width = 0.492126!
        '
        'TextBox58
        '
        Me.TextBox58.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox58.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox58.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox58.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox58.Height = 0.2362205!
        Me.TextBox58.Left = 6.810236!
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox58.Text = Nothing
        Me.TextBox58.Top = 3.534645!
        Me.TextBox58.Width = 0.492126!
        '
        'TextBox59
        '
        Me.TextBox59.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox59.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox59.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox59.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox59.Height = 0.2362205!
        Me.TextBox59.Left = 6.31811!
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox59.Text = Nothing
        Me.TextBox59.Top = 3.534645!
        Me.TextBox59.Width = 0.492126!
        '
        'TextBox60
        '
        Me.TextBox60.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox60.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox60.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox60.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox60.Height = 0.2362205!
        Me.TextBox60.Left = 6.810236!
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox60.Text = Nothing
        Me.TextBox60.Top = 3.770866!
        Me.TextBox60.Width = 0.492126!
        '
        'TextBox61
        '
        Me.TextBox61.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox61.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox61.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox61.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox61.Height = 0.2362205!
        Me.TextBox61.Left = 6.31811!
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox61.Text = Nothing
        Me.TextBox61.Top = 3.770866!
        Me.TextBox61.Width = 0.492126!
        '
        'TextBox62
        '
        Me.TextBox62.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox62.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox62.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox62.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox62.Height = 0.2362205!
        Me.TextBox62.Left = 6.810236!
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox62.Text = Nothing
        Me.TextBox62.Top = 3.062204!
        Me.TextBox62.Width = 0.492126!
        '
        'TextBox63
        '
        Me.TextBox63.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox63.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox63.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox63.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox63.Height = 0.2362205!
        Me.TextBox63.Left = 6.31811!
        Me.TextBox63.Name = "TextBox63"
        Me.TextBox63.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox63.Text = Nothing
        Me.TextBox63.Top = 3.062204!
        Me.TextBox63.Width = 0.492126!
        '
        'TextBox64
        '
        Me.TextBox64.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox64.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox64.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox64.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox64.Height = 0.2362205!
        Me.TextBox64.Left = 6.810236!
        Me.TextBox64.Name = "TextBox64"
        Me.TextBox64.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox64.Text = Nothing
        Me.TextBox64.Top = 3.298425!
        Me.TextBox64.Width = 0.492126!
        '
        'TextBox65
        '
        Me.TextBox65.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox65.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox65.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox65.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox65.Height = 0.2362205!
        Me.TextBox65.Left = 6.31811!
        Me.TextBox65.Name = "TextBox65"
        Me.TextBox65.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox65.Text = Nothing
        Me.TextBox65.Top = 3.298425!
        Me.TextBox65.Width = 0.492126!
        '
        'Label31
        '
        Me.Label31.Height = 0.1574803!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 6.336615!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label31.Text = "作成者"
        Me.Label31.Top = 2.888189!
        Me.Label31.Width = 0.472441!
        '
        'Label32
        '
        Me.Label32.Height = 0.1574803!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 6.809055!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label32.Text = "ｵﾍﾟﾚｰﾀ"
        Me.Label32.Top = 2.888189!
        Me.Label32.Width = 0.472441!
        '
        'TextBox67
        '
        Me.TextBox67.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox67.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox67.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox67.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox67.Height = 0.3149606!
        Me.TextBox67.Left = 6.766142!
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox67.Text = Nothing
        Me.TextBox67.Top = 4.811024!
        Me.TextBox67.Width = 0.511811!
        '
        'TextBox68
        '
        Me.TextBox68.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox68.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox68.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox68.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox68.Height = 0.3149606!
        Me.TextBox68.Left = 6.254332!
        Me.TextBox68.Name = "TextBox68"
        Me.TextBox68.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox68.Text = Nothing
        Me.TextBox68.Top = 4.811024!
        Me.TextBox68.Width = 0.511811!
        '
        'Label5
        '
        Me.Label5.Height = 0.1574803!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 6.36693!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label5.Text = "月 　日"
        Me.Label5.Top = 4.981103!
        Me.Label5.Width = 0.4330709!
        '
        'Label33
        '
        Me.Label33.Height = 0.1574803!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 6.32441!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label33.Text = "確　認"
        Me.Label33.Top = 4.844095!
        Me.Label33.Width = 0.3937008!
        '
        'Shape2
        '
        Me.Shape2.Height = 3.041733!
        Me.Shape2.Left = 0.6980315!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = 9.999999!
        Me.Shape2.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
        Me.Shape2.Top = 5.385434!
        Me.Shape2.Width = 2.874803!
        '
        'Shape3
        '
        Me.Shape3.Height = 3.041734!
        Me.Shape3.Left = 3.90315!
        Me.Shape3.Name = "Shape3"
        Me.Shape3.RoundingRadius = 9.999999!
        Me.Shape3.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
        Me.Shape3.Top = 5.375197!
        Me.Shape3.Width = 2.874803!
        '
        'grpFtr作業No
        '
        Me.grpFtr作業No.Height = 0.0!
        Me.grpFtr作業No.Name = "grpFtr作業No"
        '
        'Flexible
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 8.385433!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr作業No)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr作業No)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lbl発送先, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl請求先, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt製造者CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt製造者名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl製造者, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl作業伝票, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ｌｂｌ再版No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt再版No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl顧客様No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblユーザーNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl本台帳番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl枝番, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt顧客様No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtユーザーNp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt本台帳番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt枝番, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblユーザー名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtユーザー名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl受注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl納期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt納期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl顧客刃型番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt顧客刃型番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt原価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl原価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl紙幅方向サイズ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl流れ方向ｻｲｽﾞ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl刃型線の角R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl形状, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl紙幅方向面付箋, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl紙幅方向ﾄﾞﾌﾞ寸法, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl流れ方向面付箋, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl流れ方向ﾄﾞﾌﾞ寸法, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl全体紙幅方向ｻｲｽﾞ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl全体流れ方向ｻｲｽﾞ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl輪転機, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt刃型サイズ紙幅方向, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt刃型サイズ一面流れ方向, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt刃型サイズ角, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt形状, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt面付紙幅方向面数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt面付紙幅方向ドブ寸法, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt面流れ方向面数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt面付流れ方向ドブ寸法, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt刃型サイズ全体紙幅方向, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt刃型サイズ全体流れ方向, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblギア数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt刃型情報ギヤ数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl板厚, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt刃型情報板厚, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl総円周, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt刃型情報総円周, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt刃型情報バリヤー, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblバリヤー, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl反転CAD変型, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl反転CAD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl線端角の形状丸め, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Llbl刃型線の線幅, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl原点の線幅, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblﾄﾝﾎﾞの線幅, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblセパレータ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt線幅刃型線, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt線幅原点, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt線幅ﾄﾝﾎﾞ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtセパレータ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents lbl発送先 As DataDynamics.ActiveReports.Label
    Private WithEvents FlexibleSubDelivery As DataDynamics.ActiveReports.SubReport
    Private WithEvents lbl請求先 As DataDynamics.ActiveReports.Label
    Private WithEvents txt請求先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents FlexibleSubNote As DataDynamics.ActiveReports.SubReport
    Private WithEvents txt請求先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt製造者CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt製造者名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl製造者 As DataDynamics.ActiveReports.Label
    Private WithEvents grpHdr作業No As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents TextBox66 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox51 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox50 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox49 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox48 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lbl作業伝票 As DataDynamics.ActiveReports.Label
    Private WithEvents ｌｂｌ再版No As DataDynamics.ActiveReports.Label
    Private WithEvents txt再版No As DataDynamics.ActiveReports.TextBox
    Private WithEvents Barcode As DataDynamics.ActiveReports.Barcode
    Private WithEvents lbl顧客様No As DataDynamics.ActiveReports.Label
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents lblユーザーNo As DataDynamics.ActiveReports.Label
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl本台帳番号 As DataDynamics.ActiveReports.Label
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl枝番 As DataDynamics.ActiveReports.Label
    Private WithEvents txt顧客様No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtユーザーNp As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt本台帳番号 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt枝番 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblユーザー名 As DataDynamics.ActiveReports.Label
    Private WithEvents txtユーザー名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl受注日 As DataDynamics.ActiveReports.Label
    Private WithEvents txt受注日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl納期 As DataDynamics.ActiveReports.Label
    Private WithEvents txt納期 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl顧客刃型番号 As DataDynamics.ActiveReports.Label
    Private WithEvents txt顧客刃型番号 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl受注数 As DataDynamics.ActiveReports.Label
    Private WithEvents txt受注数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl単価 As DataDynamics.ActiveReports.Label
    Private WithEvents txt単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl金額 As DataDynamics.ActiveReports.Label
    Private WithEvents txt金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt原価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl原価 As DataDynamics.ActiveReports.Label
    Private WithEvents Label18 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl紙幅方向サイズ As DataDynamics.ActiveReports.Label
    Private WithEvents lbl流れ方向ｻｲｽﾞ As DataDynamics.ActiveReports.Label
    Private WithEvents lbl刃型線の角R As DataDynamics.ActiveReports.Label
    Private WithEvents lbl形状 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl紙幅方向面付箋 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl紙幅方向ﾄﾞﾌﾞ寸法 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl流れ方向面付箋 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl流れ方向ﾄﾞﾌﾞ寸法 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl全体紙幅方向ｻｲｽﾞ As DataDynamics.ActiveReports.Label
    Private WithEvents lbl全体流れ方向ｻｲｽﾞ As DataDynamics.ActiveReports.Label
    Private WithEvents lbl輪転機 As DataDynamics.ActiveReports.Label
    Private WithEvents txt刃型サイズ紙幅方向 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt刃型サイズ一面流れ方向 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt刃型サイズ角 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt形状 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt面付紙幅方向面数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt面付紙幅方向ドブ寸法 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt面流れ方向面数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt面付流れ方向ドブ寸法 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt刃型サイズ全体紙幅方向 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt刃型サイズ全体流れ方向 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblギア数 As DataDynamics.ActiveReports.Label
    Private WithEvents txt刃型情報ギヤ数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl板厚 As DataDynamics.ActiveReports.Label
    Private WithEvents txt刃型情報板厚 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl総円周 As DataDynamics.ActiveReports.Label
    Private WithEvents txt刃型情報総円周 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt刃型情報バリヤー As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblバリヤー As DataDynamics.ActiveReports.Label
    Private WithEvents Label25 As DataDynamics.ActiveReports.Label
    Private WithEvents Label26 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox26 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox27 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox28 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox29 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox30 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox31 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox32 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox33 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox34 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox35 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox36 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox37 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox38 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox39 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox40 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox41 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox42 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox43 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox44 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox45 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox46 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox47 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox23 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox24 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox25 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label19 As DataDynamics.ActiveReports.Label
    Private WithEvents Label20 As DataDynamics.ActiveReports.Label
    Private WithEvents Label23 As DataDynamics.ActiveReports.Label
    Private WithEvents Label24 As DataDynamics.ActiveReports.Label
    Private WithEvents Label27 As DataDynamics.ActiveReports.Label
    Private WithEvents Label28 As DataDynamics.ActiveReports.Label
    Private WithEvents Label29 As DataDynamics.ActiveReports.Label
    Private WithEvents Label30 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl反転CAD変型 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl反転CAD As DataDynamics.ActiveReports.Label
    Private WithEvents lbl線端角の形状丸め As DataDynamics.ActiveReports.Label
    Private WithEvents Llbl刃型線の線幅 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl原点の線幅 As DataDynamics.ActiveReports.Label
    Private WithEvents lblﾄﾝﾎﾞの線幅 As DataDynamics.ActiveReports.Label
    Private WithEvents lblセパレータ As DataDynamics.ActiveReports.Label
    Private WithEvents txt線幅刃型線 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt線幅原点 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt線幅ﾄﾝﾎﾞ As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtセパレータ As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox52 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox53 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox54 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox55 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox56 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox57 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox58 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox59 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox60 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox61 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox62 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox63 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox64 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox65 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label31 As DataDynamics.ActiveReports.Label
    Private WithEvents Label32 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox67 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox68 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents Label33 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr作業No As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents Shape2 As DataDynamics.ActiveReports.Shape
    Private WithEvents Shape3 As DataDynamics.ActiveReports.Shape
End Class
