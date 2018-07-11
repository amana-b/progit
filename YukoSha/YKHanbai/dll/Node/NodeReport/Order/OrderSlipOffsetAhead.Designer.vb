<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class OrderSlipOffsetAhead
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(OrderSlipOffsetAhead))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt行番 = New DataDynamics.ActiveReports.TextBox()
        Me.txt工程区分 = New DataDynamics.ActiveReports.TextBox()
        Me.txt発注日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt納期 = New DataDynamics.ActiveReports.TextBox()
        Me.txt発注数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt発注単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txt発注金額 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr作業No = New DataDynamics.ActiveReports.GroupHeader()
        Me.lblTitle = New DataDynamics.ActiveReports.Label()
        Me.lbl行番 = New DataDynamics.ActiveReports.Label()
        Me.lbl工程区分 = New DataDynamics.ActiveReports.Label()
        Me.lbl発注数 = New DataDynamics.ActiveReports.Label()
        Me.lbl発注金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl発注日 = New DataDynamics.ActiveReports.Label()
        Me.ｌｂｌHdr作業No = New DataDynamics.ActiveReports.Label()
        Me.txt作業No = New DataDynamics.ActiveReports.TextBox()
        Me.Barcode = New DataDynamics.ActiveReports.Barcode()
        Me.lblHdr顧客様No = New DataDynamics.ActiveReports.Label()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.lblHdrユーザーNo = New DataDynamics.ActiveReports.Label()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr本台帳番号 = New DataDynamics.ActiveReports.Label()
        Me.Label10 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr枝番 = New DataDynamics.ActiveReports.Label()
        Me.txtHdr顧客様No = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdrユーザーNp = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdr本台帳番号 = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdr枝番 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHdr発注先名 = New DataDynamics.ActiveReports.Label()
        Me.txtHdr発注先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHdr商品名 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr抜型番号 = New DataDynamics.ActiveReports.Label()
        Me.txt抜型番号 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHdr顧客商品No = New DataDynamics.ActiveReports.Label()
        Me.txt顧客商品No = New DataDynamics.ActiveReports.TextBox()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.lbl発注単価 = New DataDynamics.ActiveReports.Label()
        Me.lbl納期 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr工程区分 = New DataDynamics.ActiveReports.Label()
        Me.txtHdr工程区分 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHdr客先納期 = New DataDynamics.ActiveReports.Label()
        Me.txtHrd客先納期 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHrd受注日 = New DataDynamics.ActiveReports.Label()
        Me.txtHrd受注日 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHrdユーザー名 = New DataDynamics.ActiveReports.Label()
        Me.txtHrdユーザー名 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHdr受注数 = New DataDynamics.ActiveReports.Label()
        Me.txt受注数 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHdr受注単価 = New DataDynamics.ActiveReports.Label()
        Me.txt受注単価 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHdr受注金額 = New DataDynamics.ActiveReports.Label()
        Me.txt受注金額 = New DataDynamics.ActiveReports.TextBox()
        Me.grpFtr作業No = New DataDynamics.ActiveReports.GroupFooter()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Label14 = New DataDynamics.ActiveReports.Label()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl材料 = New DataDynamics.ActiveReports.Label()
        Me.lbl版 = New DataDynamics.ActiveReports.Label()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.lblデザイン = New DataDynamics.ActiveReports.Label()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl印刷 = New DataDynamics.ActiveReports.Label()
        Me.lbl折 = New DataDynamics.ActiveReports.Label()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl貼 = New DataDynamics.ActiveReports.Label()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox()
        Me.lblヌキ = New DataDynamics.ActiveReports.Label()
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox()
        Me.lblその他 = New DataDynamics.ActiveReports.Label()
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox()
        Me.lblその他1 = New DataDynamics.ActiveReports.Label()
        Me.txt発送元 = New DataDynamics.ActiveReports.TextBox()
        Me.SubSubReport = New DataDynamics.ActiveReports.SubReport()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl行 = New DataDynamics.ActiveReports.Label()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.Label11 = New DataDynamics.ActiveReports.Label()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.Label18 = New DataDynamics.ActiveReports.Label()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox23 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox24 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox25 = New DataDynamics.ActiveReports.TextBox()
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
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Label19 = New DataDynamics.ActiveReports.Label()
        Me.TextBox43 = New DataDynamics.ActiveReports.TextBox()
        Me.Label20 = New DataDynamics.ActiveReports.Label()
        Me.TextBox44 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox45 = New DataDynamics.ActiveReports.TextBox()
        Me.Label23 = New DataDynamics.ActiveReports.Label()
        Me.TextBox46 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox47 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox48 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox49 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox50 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox51 = New DataDynamics.ActiveReports.TextBox()
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
        Me.TextBox66 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox67 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox68 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox69 = New DataDynamics.ActiveReports.TextBox()
        Me.Line46 = New DataDynamics.ActiveReports.Line()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.Line2 = New DataDynamics.ActiveReports.Line()
        Me.Line3 = New DataDynamics.ActiveReports.Line()
        Me.Line4 = New DataDynamics.ActiveReports.Line()
        Me.Line5 = New DataDynamics.ActiveReports.Line()
        Me.Line6 = New DataDynamics.ActiveReports.Line()
        Me.Line7 = New DataDynamics.ActiveReports.Line()
        Me.Line8 = New DataDynamics.ActiveReports.Line()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox70 = New DataDynamics.ActiveReports.TextBox()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Label13 = New DataDynamics.ActiveReports.Label()
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox()
        Me.Label15 = New DataDynamics.ActiveReports.Label()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox()
        Me.Label16 = New DataDynamics.ActiveReports.Label()
        Me.Label17 = New DataDynamics.ActiveReports.Label()
        Me.TextBox72 = New DataDynamics.ActiveReports.TextBox()
        Me.Label21 = New DataDynamics.ActiveReports.Label()
        Me.TextBox73 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox74 = New DataDynamics.ActiveReports.TextBox()
        Me.Label22 = New DataDynamics.ActiveReports.Label()
        Me.TextBox75 = New DataDynamics.ActiveReports.TextBox()
        Me.Label24 = New DataDynamics.ActiveReports.Label()
        Me.TextBox76 = New DataDynamics.ActiveReports.TextBox()
        Me.Label25 = New DataDynamics.ActiveReports.Label()
        Me.Line10 = New DataDynamics.ActiveReports.Line()
        Me.Line9 = New DataDynamics.ActiveReports.Line()
        Me.Line11 = New DataDynamics.ActiveReports.Line()
        Me.Line12 = New DataDynamics.ActiveReports.Line()
        Me.Line13 = New DataDynamics.ActiveReports.Line()
        Me.Line14 = New DataDynamics.ActiveReports.Line()
        Me.Line15 = New DataDynamics.ActiveReports.Line()
        Me.Line16 = New DataDynamics.ActiveReports.Line()
        Me.TextBox77 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox78 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox79 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox80 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox81 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox82 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox83 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox84 = New DataDynamics.ActiveReports.TextBox()
        Me.Line17 = New DataDynamics.ActiveReports.Line()
        Me.Line18 = New DataDynamics.ActiveReports.Line()
        Me.Line19 = New DataDynamics.ActiveReports.Line()
        Me.Line20 = New DataDynamics.ActiveReports.Line()
        Me.Line21 = New DataDynamics.ActiveReports.Line()
        Me.Line22 = New DataDynamics.ActiveReports.Line()
        Me.Line23 = New DataDynamics.ActiveReports.Line()
        Me.Line24 = New DataDynamics.ActiveReports.Line()
        Me.Label26 = New DataDynamics.ActiveReports.Label()
        Me.TextBox85 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox86 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt行番, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt工程区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt納期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発注単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発注金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl行番, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl工程区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl発注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl発注金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl発注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ｌｂｌHdr作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr顧客様No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdrユーザーNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr本台帳番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr枝番, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr顧客様No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdrユーザーNp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr本台帳番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr枝番, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr発注先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr発注先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr抜型番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt抜型番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr顧客商品No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt顧客商品No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl発注単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl納期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr工程区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr工程区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr客先納期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHrd客先納期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHrd受注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHrd受注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHrdユーザー名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHrdユーザー名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr受注単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr受注金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl材料, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl版, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblデザイン, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl印刷, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl折, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl貼, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblヌキ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblその他, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblその他1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発送元, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl行, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox51, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.TextBox66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox70, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox72, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox73, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox75, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox76, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox77, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox78, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox79, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox80, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox82, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox83, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox84, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox85, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox86, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt行番, Me.txt工程区分, Me.txt発注日, Me.txt納期, Me.txt発注数, Me.txt発注単価, Me.txt発注金額})
        Me.Detail.Height = 0.2362212!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'txt行番
        '
        Me.txt行番.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt行番.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt行番.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt行番.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt行番.Height = 0.2362205!
        Me.txt行番.Left = 0.0!
        Me.txt行番.Name = "txt行番"
        Me.txt行番.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt行番.Text = "00"
        Me.txt行番.Top = 0.0000007152557!
        Me.txt行番.Width = 0.2165354!
        '
        'txt工程区分
        '
        Me.txt工程区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt工程区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt工程区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt工程区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt工程区分.Height = 0.2362205!
        Me.txt工程区分.Left = 0.2165354!
        Me.txt工程区分.Name = "txt工程区分"
        Me.txt工程区分.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt工程区分.Text = "ああ"
        Me.txt工程区分.Top = 0.0!
        Me.txt工程区分.Width = 0.984252!
        '
        'txt発注日
        '
        Me.txt発注日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Height = 0.2362205!
        Me.txt発注日.Left = 1.200787!
        Me.txt発注日.Name = "txt発注日"
        Me.txt発注日.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt発注日.Text = "YY/MM/DD"
        Me.txt発注日.Top = 0.0!
        Me.txt発注日.Width = 1.062992!
        '
        'txt納期
        '
        Me.txt納期.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納期.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納期.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納期.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納期.Height = 0.2362205!
        Me.txt納期.Left = 2.26378!
        Me.txt納期.Name = "txt納期"
        Me.txt納期.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt納期.Text = "YY/MM/DD"
        Me.txt納期.Top = 0.0!
        Me.txt納期.Width = 1.003937!
        '
        'txt発注数
        '
        Me.txt発注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注数.Height = 0.2362205!
        Me.txt発注数.Left = 3.267717!
        Me.txt発注数.Name = "txt発注数"
        Me.txt発注数.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt発注数.Text = "99枚"
        Me.txt発注数.Top = 0.0!
        Me.txt発注数.Width = 1.397638!
        '
        'txt発注単価
        '
        Me.txt発注単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注単価.Height = 0.2362205!
        Me.txt発注単価.Left = 4.665355!
        Me.txt発注単価.Name = "txt発注単価"
        Me.txt発注単価.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt発注単価.Text = "999,999.00"
        Me.txt発注単価.Top = 0.0!
        Me.txt発注単価.Width = 1.259843!
        '
        'txt発注金額
        '
        Me.txt発注金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注金額.Height = 0.2362205!
        Me.txt発注金額.Left = 5.925197!
        Me.txt発注金額.Name = "txt発注金額"
        Me.txt発注金額.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt発注金額.Text = "999,999,999円"
        Me.txt発注金額.Top = 0.0!
        Me.txt発注金額.Width = 1.377953!
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
        Me.grpHdr作業No.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitle, Me.lbl行番, Me.lbl工程区分, Me.lbl発注数, Me.lbl発注金額, Me.lbl発注日, Me.ｌｂｌHdr作業No, Me.txt作業No, Me.Barcode, Me.lblHdr顧客様No, Me.Label1, Me.lblHdrユーザーNo, Me.Label7, Me.lblHdr本台帳番号, Me.Label10, Me.lblHdr枝番, Me.txtHdr顧客様No, Me.txtHdrユーザーNp, Me.txtHdr本台帳番号, Me.txtHdr枝番, Me.lblHdr発注先名, Me.txtHdr発注先名, Me.txt商品名, Me.lblHdr商品名, Me.lblHdr抜型番号, Me.txt抜型番号, Me.lblHdr顧客商品No, Me.txt顧客商品No, Me.Label5, Me.lbl発注単価, Me.lbl納期, Me.lblHdr工程区分, Me.txtHdr工程区分, Me.lblHdr客先納期, Me.txtHrd客先納期, Me.lblHrd受注日, Me.txtHrd受注日, Me.lblHrdユーザー名, Me.txtHrdユーザー名, Me.lblHdr受注数, Me.txt受注数, Me.lblHdr受注単価, Me.txt受注単価, Me.lblHdr受注金額, Me.txt受注金額})
        Me.grpHdr作業No.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr作業No.Height = 2.572725!
        Me.grpHdr作業No.Name = "grpHdr作業No"
        Me.grpHdr作業No.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'lblTitle
        '
        Me.lblTitle.Height = 0.3937008!
        Me.lblTitle.HyperLink = Nothing
        Me.lblTitle.Left = 3.858268!
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 13pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.lblTitle.Text = "オフセット発注伝票(控)"
        Me.lblTitle.Top = 0.0!
        Me.lblTitle.Width = 2.051181!
        '
        'lbl行番
        '
        Me.lbl行番.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl行番.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl行番.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl行番.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl行番.Height = 0.2362205!
        Me.lbl行番.HyperLink = Nothing
        Me.lbl行番.Left = 0.0!
        Me.lbl行番.Name = "lbl行番"
        Me.lbl行番.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl行番.Text = ""
        Me.lbl行番.Top = 2.325591!
        Me.lbl行番.Width = 0.2165354!
        '
        'lbl工程区分
        '
        Me.lbl工程区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl工程区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl工程区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl工程区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl工程区分.Height = 0.2362205!
        Me.lbl工程区分.HyperLink = Nothing
        Me.lbl工程区分.Left = 0.2165354!
        Me.lbl工程区分.Name = "lbl工程区分"
        Me.lbl工程区分.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl工程区分.Text = " 工　程"
        Me.lbl工程区分.Top = 2.325591!
        Me.lbl工程区分.Width = 0.984252!
        '
        'lbl発注数
        '
        Me.lbl発注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注数.Height = 0.2362205!
        Me.lbl発注数.HyperLink = Nothing
        Me.lbl発注数.Left = 3.267717!
        Me.lbl発注数.Name = "lbl発注数"
        Me.lbl発注数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl発注数.Text = "発 注 数"
        Me.lbl発注数.Top = 2.325592!
        Me.lbl発注数.Width = 1.397638!
        '
        'lbl発注金額
        '
        Me.lbl発注金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注金額.Height = 0.2362205!
        Me.lbl発注金額.HyperLink = Nothing
        Me.lbl発注金額.Left = 5.925197!
        Me.lbl発注金額.Name = "lbl発注金額"
        Me.lbl発注金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl発注金額.Text = "発　注　金　額"
        Me.lbl発注金額.Top = 2.325591!
        Me.lbl発注金額.Width = 1.377953!
        '
        'lbl発注日
        '
        Me.lbl発注日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注日.Height = 0.2362205!
        Me.lbl発注日.HyperLink = Nothing
        Me.lbl発注日.Left = 1.200787!
        Me.lbl発注日.Name = "lbl発注日"
        Me.lbl発注日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl発注日.Text = "発　注　日"
        Me.lbl発注日.Top = 2.325591!
        Me.lbl発注日.Width = 1.062992!
        '
        'ｌｂｌHdr作業No
        '
        Me.ｌｂｌHdr作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌHdr作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌHdr作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌHdr作業No.Height = 0.2362205!
        Me.ｌｂｌHdr作業No.HyperLink = Nothing
        Me.ｌｂｌHdr作業No.Left = 6.583465!
        Me.ｌｂｌHdr作業No.Name = "ｌｂｌHdr作業No"
        Me.ｌｂｌHdr作業No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.ｌｂｌHdr作業No.Text = "作業No"
        Me.ｌｂｌHdr作業No.Top = 1.087402!
        Me.ｌｂｌHdr作業No.Width = 0.7283465!
        '
        'txt作業No
        '
        Me.txt作業No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Height = 0.2362205!
        Me.txt作業No.Left = 6.583465!
        Me.txt作業No.Name = "txt作業No"
        Me.txt作業No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt作業No.Text = "123456"
        Me.txt作業No.Top = 1.323623!
        Me.txt作業No.Width = 0.7283465!
        '
        'Barcode
        '
        Me.Barcode.CheckSumEnabled = False
        Me.Barcode.DataField = "ReportNoJudge"
        Me.Barcode.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Barcode.Height = 0.3937008!
        Me.Barcode.Left = 6.015749!
        Me.Barcode.Name = "Barcode"
        Me.Barcode.Style = DataDynamics.ActiveReports.BarCodeStyle.Code39
        Me.Barcode.Text = "Barcode"
        Me.Barcode.Top = 0.0!
        Me.Barcode.Width = 1.259843!
        '
        'lblHdr顧客様No
        '
        Me.lblHdr顧客様No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr顧客様No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr顧客様No.Height = 0.2362205!
        Me.lblHdr顧客様No.HyperLink = Nothing
        Me.lblHdr顧客様No.Left = 0.0!
        Me.lblHdr顧客様No.Name = "lblHdr顧客様No"
        Me.lblHdr顧客様No.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: normal; text-ali" & _
    "gn: center; vertical-align: middle; ddo-char-set: 1"
        Me.lblHdr顧客様No.Text = "顧客様No"
        Me.lblHdr顧客様No.Top = 0.0!
        Me.lblHdr顧客様No.Width = 0.8661417!
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
    "ign: center; vertical-align: bottom; ddo-char-set: 1"
        Me.Label1.Text = "―"
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 0.2362205!
        '
        'lblHdrユーザーNo
        '
        Me.lblHdrユーザーNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdrユーザーNo.Height = 0.2362205!
        Me.lblHdrユーザーNo.HyperLink = Nothing
        Me.lblHdrユーザーNo.Left = 1.102362!
        Me.lblHdrユーザーNo.Name = "lblHdrユーザーNo"
        Me.lblHdrユーザーNo.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: normal; text-ali" & _
    "gn: center; vertical-align: middle; ddo-char-set: 1"
        Me.lblHdrユーザーNo.Text = "ユーザーNo"
        Me.lblHdrユーザーNo.Top = 0.0!
        Me.lblHdrユーザーNo.Width = 0.8661417!
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
    "ign: center; vertical-align: bottom; ddo-char-set: 1"
        Me.Label7.Text = "―"
        Me.Label7.Top = 0.0!
        Me.Label7.Width = 0.2362205!
        '
        'lblHdr本台帳番号
        '
        Me.lblHdr本台帳番号.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr本台帳番号.Height = 0.2362205!
        Me.lblHdr本台帳番号.HyperLink = Nothing
        Me.lblHdr本台帳番号.Left = 2.204724!
        Me.lblHdr本台帳番号.Name = "lblHdr本台帳番号"
        Me.lblHdr本台帳番号.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: normal; text-ali" & _
    "gn: center; vertical-align: middle; ddo-char-set: 1"
        Me.lblHdr本台帳番号.Text = "本台帳番号"
        Me.lblHdr本台帳番号.Top = 9.313226E-10!
        Me.lblHdr本台帳番号.Width = 0.8661417!
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
    "ign: center; vertical-align: bottom; ddo-char-set: 1"
        Me.Label10.Text = "―"
        Me.Label10.Top = 0.0!
        Me.Label10.Width = 0.2362205!
        '
        'lblHdr枝番
        '
        Me.lblHdr枝番.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr枝番.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr枝番.Height = 0.2362205!
        Me.lblHdr枝番.HyperLink = Nothing
        Me.lblHdr枝番.Left = 3.307087!
        Me.lblHdr枝番.Name = "lblHdr枝番"
        Me.lblHdr枝番.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: normal; text-ali" & _
    "gn: center; vertical-align: middle; ddo-char-set: 1"
        Me.lblHdr枝番.Text = "枝番"
        Me.lblHdr枝番.Top = 0.0!
        Me.lblHdr枝番.Width = 0.3937008!
        '
        'txtHdr顧客様No
        '
        Me.txtHdr顧客様No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr顧客様No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr顧客様No.Height = 0.3149606!
        Me.txtHdr顧客様No.Left = 0.0!
        Me.txtHdr顧客様No.Name = "txtHdr顧客様No"
        Me.txtHdr顧客様No.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.txtHdr顧客様No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtHdr顧客様No.Text = "1234"
        Me.txtHdr顧客様No.Top = 0.2362205!
        Me.txtHdr顧客様No.Width = 0.8661417!
        '
        'txtHdrユーザーNp
        '
        Me.txtHdrユーザーNp.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdrユーザーNp.Height = 0.3149606!
        Me.txtHdrユーザーNp.Left = 1.102362!
        Me.txtHdrユーザーNp.Name = "txtHdrユーザーNp"
        Me.txtHdrユーザーNp.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.txtHdrユーザーNp.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtHdrユーザーNp.Text = "123456"
        Me.txtHdrユーザーNp.Top = 0.2362205!
        Me.txtHdrユーザーNp.Width = 0.8661417!
        '
        'txtHdr本台帳番号
        '
        Me.txtHdr本台帳番号.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr本台帳番号.Height = 0.3149606!
        Me.txtHdr本台帳番号.Left = 2.204724!
        Me.txtHdr本台帳番号.Name = "txtHdr本台帳番号"
        Me.txtHdr本台帳番号.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.txtHdr本台帳番号.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtHdr本台帳番号.Text = "123456"
        Me.txtHdr本台帳番号.Top = 0.2362205!
        Me.txtHdr本台帳番号.Width = 0.8661417!
        '
        'txtHdr枝番
        '
        Me.txtHdr枝番.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr枝番.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr枝番.Height = 0.3149606!
        Me.txtHdr枝番.Left = 3.307087!
        Me.txtHdr枝番.Name = "txtHdr枝番"
        Me.txtHdr枝番.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.txtHdr枝番.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtHdr枝番.Text = "12"
        Me.txtHdr枝番.Top = 0.2362205!
        Me.txtHdr枝番.Width = 0.3937008!
        '
        'lblHdr発注先名
        '
        Me.lblHdr発注先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注先名.Height = 0.2362205!
        Me.lblHdr発注先名.HyperLink = Nothing
        Me.lblHdr発注先名.Left = 0.0!
        Me.lblHdr発注先名.Name = "lblHdr発注先名"
        Me.lblHdr発注先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lblHdr発注先名.Text = "発 注 先 名"
        Me.lblHdr発注先名.Top = 1.087402!
        Me.lblHdr発注先名.Width = 2.401575!
        '
        'txtHdr発注先名
        '
        Me.txtHdr発注先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注先名.Height = 0.2362205!
        Me.txtHdr発注先名.Left = 0.0!
        Me.txtHdr発注先名.Name = "txtHdr発注先名"
        Me.txtHdr発注先名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtHdr発注先名.Text = "あああああいいいいいううううう"
        Me.txtHdr発注先名.Top = 1.323623!
        Me.txtHdr発注先名.Width = 2.401575!
        '
        'txt商品名
        '
        Me.txt商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Height = 0.2362205!
        Me.txt商品名.Left = 2.401575!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt商品名.Text = "あああああいいいいいううう"
        Me.txt商品名.Top = 1.323623!
        Me.txt商品名.Width = 2.086614!
        '
        'lblHdr商品名
        '
        Me.lblHdr商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr商品名.Height = 0.2362205!
        Me.lblHdr商品名.HyperLink = Nothing
        Me.lblHdr商品名.Left = 2.401575!
        Me.lblHdr商品名.Name = "lblHdr商品名"
        Me.lblHdr商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lblHdr商品名.Text = "商　　品　　名"
        Me.lblHdr商品名.Top = 1.087402!
        Me.lblHdr商品名.Width = 2.086614!
        '
        'lblHdr抜型番号
        '
        Me.lblHdr抜型番号.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr抜型番号.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr抜型番号.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr抜型番号.Height = 0.2362205!
        Me.lblHdr抜型番号.HyperLink = Nothing
        Me.lblHdr抜型番号.Left = 5.734646!
        Me.lblHdr抜型番号.Name = "lblHdr抜型番号"
        Me.lblHdr抜型番号.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lblHdr抜型番号.Text = "抜型番号"
        Me.lblHdr抜型番号.Top = 1.087402!
        Me.lblHdr抜型番号.Width = 0.7874016!
        '
        'txt抜型番号
        '
        Me.txt抜型番号.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt抜型番号.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt抜型番号.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt抜型番号.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt抜型番号.Height = 0.2362205!
        Me.txt抜型番号.Left = 5.734646!
        Me.txt抜型番号.Name = "txt抜型番号"
        Me.txt抜型番号.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt抜型番号.Text = "123456"
        Me.txt抜型番号.Top = 1.323623!
        Me.txt抜型番号.Width = 0.7874016!
        '
        'lblHdr顧客商品No
        '
        Me.lblHdr顧客商品No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr顧客商品No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr顧客商品No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr顧客商品No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr顧客商品No.Height = 0.2362205!
        Me.lblHdr顧客商品No.HyperLink = Nothing
        Me.lblHdr顧客商品No.Left = 4.488189!
        Me.lblHdr顧客商品No.Name = "lblHdr顧客商品No"
        Me.lblHdr顧客商品No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lblHdr顧客商品No.Text = "顧客商品No"
        Me.lblHdr顧客商品No.Top = 1.087402!
        Me.lblHdr顧客商品No.Width = 1.181102!
        '
        'txt顧客商品No
        '
        Me.txt顧客商品No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客商品No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客商品No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客商品No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客商品No.Height = 0.2362205!
        Me.txt顧客商品No.Left = 4.488189!
        Me.txt顧客商品No.Name = "txt顧客商品No"
        Me.txt顧客商品No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt顧客商品No.Text = "12345678"
        Me.txt顧客商品No.Top = 1.323623!
        Me.txt顧客商品No.Width = 1.181102!
        '
        'Label5
        '
        Me.Label5.Height = 0.1968504!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.0!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.Label5.Text = "【発注内訳】"
        Me.Label5.Top = 2.105119!
        Me.Label5.Width = 0.9204725!
        '
        'lbl発注単価
        '
        Me.lbl発注単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注単価.Height = 0.2362205!
        Me.lbl発注単価.HyperLink = Nothing
        Me.lbl発注単価.Left = 4.665355!
        Me.lbl発注単価.Name = "lbl発注単価"
        Me.lbl発注単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl発注単価.Text = "発注単価"
        Me.lbl発注単価.Top = 2.325592!
        Me.lbl発注単価.Width = 1.259843!
        '
        'lbl納期
        '
        Me.lbl納期.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納期.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納期.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納期.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納期.Height = 0.2362205!
        Me.lbl納期.HyperLink = Nothing
        Me.lbl納期.Left = 2.26378!
        Me.lbl納期.Name = "lbl納期"
        Me.lbl納期.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl納期.Text = "納　　期"
        Me.lbl納期.Top = 2.325198!
        Me.lbl納期.Width = 1.003937!
        '
        'lblHdr工程区分
        '
        Me.lblHdr工程区分.Height = 0.2755905!
        Me.lblHdr工程区分.HyperLink = Nothing
        Me.lblHdr工程区分.Left = 0.0!
        Me.lblHdr工程区分.Name = "lblHdr工程区分"
        Me.lblHdr工程区分.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 14pt; font-weight: normal; text-al" & _
    "ign: center; vertical-align: middle; ddo-char-set: 1"
        Me.lblHdr工程区分.Text = "工程："
        Me.lblHdr工程区分.Top = 0.5905512!
        Me.lblHdr工程区分.Width = 0.6692914!
        '
        'txtHdr工程区分
        '
        Me.txtHdr工程区分.Height = 0.2755905!
        Me.txtHdr工程区分.Left = 0.6692914!
        Me.txtHdr工程区分.Name = "txtHdr工程区分"
        Me.txtHdr工程区分.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.txtHdr工程区分.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txtHdr工程区分.Text = "ああ"
        Me.txtHdr工程区分.Top = 0.5905512!
        Me.txtHdr工程区分.Width = 0.6692914!
        '
        'lblHdr客先納期
        '
        Me.lblHdr客先納期.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr客先納期.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr客先納期.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr客先納期.Height = 0.1968504!
        Me.lblHdr客先納期.HyperLink = Nothing
        Me.lblHdr客先納期.Left = 3.267717!
        Me.lblHdr客先納期.Name = "lblHdr客先納期"
        Me.lblHdr客先納期.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHdr客先納期.Text = "客先納期"
        Me.lblHdr客先納期.Top = 1.607874!
        Me.lblHdr客先納期.Width = 1.220472!
        '
        'txtHrd客先納期
        '
        Me.txtHrd客先納期.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd客先納期.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd客先納期.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd客先納期.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd客先納期.Height = 0.1968504!
        Me.txtHrd客先納期.Left = 3.267717!
        Me.txtHrd客先納期.Name = "txtHrd客先納期"
        Me.txtHrd客先納期.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txtHrd客先納期.Text = "YYYY/MM/DD"
        Me.txtHrd客先納期.Top = 1.804724!
        Me.txtHrd客先納期.Width = 1.220472!
        '
        'lblHrd受注日
        '
        Me.lblHrd受注日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrd受注日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrd受注日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrd受注日.Height = 0.1968504!
        Me.lblHrd受注日.HyperLink = Nothing
        Me.lblHrd受注日.Left = 2.440946!
        Me.lblHrd受注日.Name = "lblHrd受注日"
        Me.lblHrd受注日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHrd受注日.Text = "受 注 日"
        Me.lblHrd受注日.Top = 1.607874!
        Me.lblHrd受注日.Width = 0.8267716!
        '
        'txtHrd受注日
        '
        Me.txtHrd受注日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd受注日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd受注日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd受注日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd受注日.Height = 0.1968504!
        Me.txtHrd受注日.Left = 2.440946!
        Me.txtHrd受注日.Name = "txtHrd受注日"
        Me.txtHrd受注日.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHrd受注日.Text = "YYYY/MM/DD"
        Me.txtHrd受注日.Top = 1.804724!
        Me.txtHrd受注日.Width = 0.8267716!
        '
        'lblHrdユーザー名
        '
        Me.lblHrdユーザー名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrdユーザー名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrdユーザー名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrdユーザー名.Height = 0.1968504!
        Me.lblHrdユーザー名.HyperLink = Nothing
        Me.lblHrdユーザー名.Left = 0.0000004768372!
        Me.lblHrdユーザー名.Name = "lblHrdユーザー名"
        Me.lblHrdユーザー名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHrdユーザー名.Text = "ユ　ー　ザ　ー 名"
        Me.lblHrdユーザー名.Top = 1.607874!
        Me.lblHrdユーザー名.Width = 2.440945!
        '
        'txtHrdユーザー名
        '
        Me.txtHrdユーザー名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrdユーザー名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrdユーザー名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrdユーザー名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrdユーザー名.Height = 0.1968504!
        Me.txtHrdユーザー名.Left = 0.0000004768372!
        Me.txtHrdユーザー名.Name = "txtHrdユーザー名"
        Me.txtHrdユーザー名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHrdユーザー名.Text = "あああああいいいいいううううう"
        Me.txtHrdユーザー名.Top = 1.804724!
        Me.txtHrdユーザー名.Width = 2.440945!
        '
        'lblHdr受注数
        '
        Me.lblHdr受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注数.Height = 0.1968504!
        Me.lblHdr受注数.HyperLink = Nothing
        Me.lblHdr受注数.Left = 4.488189!
        Me.lblHdr受注数.Name = "lblHdr受注数"
        Me.lblHdr受注数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHdr受注数.Text = "受　注　数"
        Me.lblHdr受注数.Top = 1.607874!
        Me.lblHdr受注数.Width = 0.8267716!
        '
        'txt受注数
        '
        Me.txt受注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Height = 0.1968504!
        Me.txt受注数.Left = 4.488189!
        Me.txt受注数.Name = "txt受注数"
        Me.txt受注数.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt受注数.Text = "999,999枚"
        Me.txt受注数.Top = 1.804724!
        Me.txt受注数.Width = 0.8267716!
        '
        'lblHdr受注単価
        '
        Me.lblHdr受注単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注単価.Height = 0.1968504!
        Me.lblHdr受注単価.HyperLink = Nothing
        Me.lblHdr受注単価.Left = 5.31496!
        Me.lblHdr受注単価.Name = "lblHdr受注単価"
        Me.lblHdr受注単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHdr受注単価.Text = "受 注 単 価"
        Me.lblHdr受注単価.Top = 1.607874!
        Me.lblHdr受注単価.Width = 0.9055118!
        '
        'txt受注単価
        '
        Me.txt受注単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注単価.Height = 0.1968504!
        Me.txt受注単価.Left = 5.31496!
        Me.txt受注単価.Name = "txt受注単価"
        Me.txt受注単価.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt受注単価.Text = "999,999.00"
        Me.txt受注単価.Top = 1.804724!
        Me.txt受注単価.Width = 0.9055118!
        '
        'lblHdr受注金額
        '
        Me.lblHdr受注金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注金額.Height = 0.1968504!
        Me.lblHdr受注金額.HyperLink = Nothing
        Me.lblHdr受注金額.Left = 6.220472!
        Me.lblHdr受注金額.Name = "lblHdr受注金額"
        Me.lblHdr受注金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHdr受注金額.Text = "受 注 金 額"
        Me.lblHdr受注金額.Top = 1.607874!
        Me.lblHdr受注金額.Width = 1.062992!
        '
        'txt受注金額
        '
        Me.txt受注金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注金額.Height = 0.1968504!
        Me.txt受注金額.Left = 6.220472!
        Me.txt受注金額.Name = "txt受注金額"
        Me.txt受注金額.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt受注金額.Text = "999,999"
        Me.txt受注金額.Top = 1.804724!
        Me.txt受注金額.Width = 1.062992!
        '
        'grpFtr作業No
        '
        Me.grpFtr作業No.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label2, Me.Label14, Me.TextBox1, Me.lbl材料, Me.lbl版, Me.TextBox2, Me.lblデザイン, Me.TextBox4, Me.TextBox5, Me.lbl印刷, Me.lbl折, Me.TextBox12, Me.lbl貼, Me.TextBox13, Me.TextBox14, Me.lblヌキ, Me.TextBox15, Me.lblその他, Me.TextBox16, Me.lblその他1, Me.txt発送元, Me.SubSubReport, Me.TextBox3, Me.lbl行, Me.Label8, Me.TextBox6, Me.Label11, Me.TextBox7, Me.TextBox8, Me.Label18, Me.TextBox10, Me.TextBox11, Me.TextBox17, Me.TextBox20, Me.TextBox22, Me.TextBox23, Me.TextBox24, Me.TextBox25, Me.TextBox26, Me.TextBox27, Me.TextBox28, Me.TextBox29, Me.TextBox30, Me.TextBox31, Me.TextBox32, Me.TextBox33, Me.TextBox34, Me.TextBox35, Me.TextBox36, Me.TextBox37, Me.TextBox38, Me.TextBox39, Me.TextBox40, Me.TextBox41, Me.TextBox42, Me.Label3, Me.Label19, Me.TextBox43, Me.Label20, Me.TextBox44, Me.TextBox45, Me.Label23, Me.TextBox46, Me.TextBox47, Me.TextBox48, Me.TextBox49, Me.TextBox50, Me.TextBox51, Me.TextBox52, Me.TextBox53, Me.TextBox54, Me.TextBox55, Me.TextBox56, Me.TextBox57, Me.TextBox58, Me.TextBox59, Me.TextBox60, Me.TextBox61, Me.TextBox62, Me.TextBox63, Me.TextBox64, Me.TextBox65, Me.TextBox66, Me.TextBox67, Me.TextBox68, Me.TextBox69, Me.Line46, Me.Line1, Me.Line2, Me.Line3, Me.Line4, Me.Line5, Me.Line6, Me.Line7, Me.Line8, Me.TextBox9, Me.TextBox70, Me.Label4, Me.Label13, Me.TextBox18, Me.Label15, Me.TextBox19, Me.TextBox21, Me.Label16, Me.Label17, Me.TextBox72, Me.Label21, Me.TextBox73, Me.TextBox74, Me.Label22, Me.TextBox75, Me.Label24, Me.TextBox76, Me.Label25, Me.Line10, Me.Line9, Me.Line11, Me.Line12, Me.Line13, Me.Line14, Me.Line15, Me.Line16, Me.TextBox77, Me.TextBox78, Me.TextBox79, Me.TextBox80, Me.TextBox81, Me.TextBox82, Me.TextBox83, Me.TextBox84, Me.Line17, Me.Line18, Me.Line19, Me.Line20, Me.Line21, Me.Line22, Me.Line23, Me.Line24, Me.Label26, Me.TextBox85, Me.TextBox86})
        Me.grpFtr作業No.Height = 6.658046!
        Me.grpFtr作業No.Name = "grpFtr作業No"
        '
        'Label2
        '
        Me.Label2.Height = 0.1968504!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.0!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.Label2.Text = "【印刷方法】"
        Me.Label2.Top = 0.04251969!
        Me.Label2.Width = 0.9204725!
        '
        'Label14
        '
        Me.Label14.Height = 0.1968504!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 0.0!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.Label14.Text = "【仕上方法】"
        Me.Label14.Top = 3.146457!
        Me.Label14.Width = 0.9204725!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.5905512!
        Me.TextBox1.Left = 0.0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: top; ddo-c" & _
    "har-set: 1"
        Me.TextBox1.Text = "　　月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　　日"
        Me.TextBox1.Top = 2.476378!
        Me.TextBox1.Width = 0.8149606!
        '
        'lbl材料
        '
        Me.lbl材料.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl材料.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl材料.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl材料.Height = 0.1968504!
        Me.lbl材料.HyperLink = Nothing
        Me.lbl材料.Left = 0.0!
        Me.lbl材料.Name = "lbl材料"
        Me.lbl材料.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl材料.Text = "材　 料"
        Me.lbl材料.Top = 2.279528!
        Me.lbl材料.Width = 0.8149606!
        '
        'lbl版
        '
        Me.lbl版.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版.Height = 0.1968504!
        Me.lbl版.HyperLink = Nothing
        Me.lbl版.Left = 0.8149606!
        Me.lbl版.Name = "lbl版"
        Me.lbl版.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl版.Text = "版"
        Me.lbl版.Top = 2.279528!
        Me.lbl版.Width = 0.8149606!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Height = 0.5905512!
        Me.TextBox2.Left = 0.8149606!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox2.Text = "　　月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　　日"
        Me.TextBox2.Top = 2.476379!
        Me.TextBox2.Width = 0.8149606!
        '
        'lblデザイン
        '
        Me.lblデザイン.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblデザイン.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblデザイン.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblデザイン.Height = 0.1968504!
        Me.lblデザイン.HyperLink = Nothing
        Me.lblデザイン.Left = 1.629921!
        Me.lblデザイン.Name = "lblデザイン"
        Me.lblデザイン.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lblデザイン.Text = "デザイン"
        Me.lblデザイン.Top = 2.279528!
        Me.lblデザイン.Width = 0.8149606!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Height = 0.5905512!
        Me.TextBox4.Left = 1.629921!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox4.Text = "　　月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　　日"
        Me.TextBox4.Top = 2.476379!
        Me.TextBox4.Width = 0.8149606!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Height = 0.5905512!
        Me.TextBox5.Left = 2.444882!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox5.Text = "　　月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　　日"
        Me.TextBox5.Top = 2.476378!
        Me.TextBox5.Width = 0.8149606!
        '
        'lbl印刷
        '
        Me.lbl印刷.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl印刷.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl印刷.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl印刷.Height = 0.1968504!
        Me.lbl印刷.HyperLink = Nothing
        Me.lbl印刷.Left = 2.444882!
        Me.lbl印刷.Name = "lbl印刷"
        Me.lbl印刷.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; text-justi" & _
    "fy: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.lbl印刷.Text = "印　　刷"
        Me.lbl印刷.Top = 2.279528!
        Me.lbl印刷.Width = 0.8149606!
        '
        'lbl折
        '
        Me.lbl折.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl折.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl折.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl折.Height = 0.1968504!
        Me.lbl折.HyperLink = Nothing
        Me.lbl折.Left = 3.259842!
        Me.lbl折.Name = "lbl折"
        Me.lbl折.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl折.Text = "折"
        Me.lbl折.Top = 2.279529!
        Me.lbl折.Width = 0.8149606!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Height = 0.5905512!
        Me.TextBox12.Left = 3.259842!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox12.Text = "　　月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　　日"
        Me.TextBox12.Top = 2.476379!
        Me.TextBox12.Width = 0.8149606!
        '
        'lbl貼
        '
        Me.lbl貼.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl貼.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl貼.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl貼.Height = 0.1968504!
        Me.lbl貼.HyperLink = Nothing
        Me.lbl貼.Left = 4.074803!
        Me.lbl貼.Name = "lbl貼"
        Me.lbl貼.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl貼.Text = "貼"
        Me.lbl貼.Top = 2.279529!
        Me.lbl貼.Width = 0.8149606!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Height = 0.5905512!
        Me.TextBox13.Left = 4.074803!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox13.Text = "　　月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　　日"
        Me.TextBox13.Top = 2.476379!
        Me.TextBox13.Width = 0.8149606!
        '
        'TextBox14
        '
        Me.TextBox14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Height = 0.5905512!
        Me.TextBox14.Left = 4.889763!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox14.Text = "　　月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　　日"
        Me.TextBox14.Top = 2.476379!
        Me.TextBox14.Width = 0.8149606!
        '
        'lblヌキ
        '
        Me.lblヌキ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblヌキ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblヌキ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblヌキ.Height = 0.1968504!
        Me.lblヌキ.HyperLink = Nothing
        Me.lblヌキ.Left = 4.889763!
        Me.lblヌキ.Name = "lblヌキ"
        Me.lblヌキ.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; text-justi" & _
    "fy: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.lblヌキ.Text = "ヌキ"
        Me.lblヌキ.Top = 2.279529!
        Me.lblヌキ.Width = 0.8149606!
        '
        'TextBox15
        '
        Me.TextBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Height = 0.5905512!
        Me.TextBox15.Left = 5.704724!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox15.Text = "　　月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　　日"
        Me.TextBox15.Top = 2.476379!
        Me.TextBox15.Width = 0.8149606!
        '
        'lblその他
        '
        Me.lblその他.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblその他.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblその他.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblその他.Height = 0.1968504!
        Me.lblその他.HyperLink = Nothing
        Me.lblその他.Left = 5.704724!
        Me.lblその他.Name = "lblその他"
        Me.lblその他.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; text-justi" & _
    "fy: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.lblその他.Text = "その他"
        Me.lblその他.Top = 2.279528!
        Me.lblその他.Width = 0.8149606!
        '
        'TextBox16
        '
        Me.TextBox16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Height = 0.5905512!
        Me.TextBox16.Left = 6.519684!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox16.Text = "　　月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　　日"
        Me.TextBox16.Top = 2.476379!
        Me.TextBox16.Width = 0.8149606!
        '
        'lblその他1
        '
        Me.lblその他1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblその他1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblその他1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblその他1.Height = 0.1968504!
        Me.lblその他1.HyperLink = Nothing
        Me.lblその他1.Left = 6.519684!
        Me.lblその他1.Name = "lblその他1"
        Me.lblその他1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; text-justi" & _
    "fy: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.lblその他1.Text = "その他"
        Me.lblその他1.Top = 2.279528!
        Me.lblその他1.Width = 0.8149606!
        '
        'txt発送元
        '
        Me.txt発送元.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送元.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送元.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送元.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送元.Height = 0.3149606!
        Me.txt発送元.Left = 0.0!
        Me.txt発送元.Name = "txt発送元"
        Me.txt発送元.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt発送元.Text = "　　シートカット　　　　　　　　　　　　　枚"
        Me.txt発送元.Top = 3.419291!
        Me.txt発送元.Width = 3.582677!
        '
        'SubSubReport
        '
        Me.SubSubReport.CloseBorder = False
        Me.SubSubReport.Height = 1.929134!
        Me.SubSubReport.Left = 3.731496!
        Me.SubSubReport.Name = "SubSubReport"
        Me.SubSubReport.Report = Nothing
        Me.SubSubReport.Top = 3.419291!
        Me.SubSubReport.Width = 3.523622!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.2362205!
        Me.TextBox3.Left = 0.0!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox3.Text = "1"
        Me.TextBox3.Top = 0.553937!
        Me.TextBox3.Width = 0.3149606!
        '
        'lbl行
        '
        Me.lbl行.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl行.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl行.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl行.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl行.Height = 0.2559055!
        Me.lbl行.HyperLink = Nothing
        Me.lbl行.Left = 0.0!
        Me.lbl行.Name = "lbl行"
        Me.lbl行.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl行.Text = ""
        Me.lbl行.Top = 0.2980315!
        Me.lbl行.Width = 0.3149606!
        '
        'Label8
        '
        Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label8.Height = 0.2559055!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 0.3149606!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.Label8.Text = "工程"
        Me.Label8.Top = 0.2980315!
        Me.Label8.Width = 0.8070866!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Height = 0.2362205!
        Me.TextBox6.Left = 0.3149606!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox6.Text = "デザイン"
        Me.TextBox6.Top = 0.553937!
        Me.TextBox6.Width = 0.8070866!
        '
        'Label11
        '
        Me.Label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Height = 0.2559055!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 1.122047!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.Label11.Text = "号機"
        Me.Label11.Top = 0.2980315!
        Me.Label11.Width = 0.7480315!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Height = 0.2362205!
        Me.TextBox7.Left = 1.122047!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0.553937!
        Me.TextBox7.Width = 0.7480315!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Height = 0.2362205!
        Me.TextBox8.Left = 1.870079!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.553937!
        Me.TextBox8.Width = 1.692913!
        '
        'Label18
        '
        Me.Label18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Height = 0.2559055!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 1.870079!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; text-justi" & _
    "fy: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.Label18.Text = "価格"
        Me.Label18.Top = 0.2980315!
        Me.Label18.Width = 1.692914!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Height = 0.2362205!
        Me.TextBox10.Left = 0.0!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox10.Text = "2"
        Me.TextBox10.Top = 0.7901575!
        Me.TextBox10.Width = 0.3149606!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Height = 0.2362205!
        Me.TextBox11.Left = 0.3149606!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox11.Text = "版下"
        Me.TextBox11.Top = 0.7901575!
        Me.TextBox11.Width = 0.8070866!
        '
        'TextBox17
        '
        Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Height = 0.2362205!
        Me.TextBox17.Left = 1.122047!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox17.Text = Nothing
        Me.TextBox17.Top = 0.7901575!
        Me.TextBox17.Width = 0.7480313!
        '
        'TextBox20
        '
        Me.TextBox20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Height = 0.2362205!
        Me.TextBox20.Left = 1.870078!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox20.Text = Nothing
        Me.TextBox20.Top = 0.7901575!
        Me.TextBox20.Width = 1.692913!
        '
        'TextBox22
        '
        Me.TextBox22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Height = 0.2362205!
        Me.TextBox22.Left = 0.0!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox22.Text = "3"
        Me.TextBox22.Top = 1.026378!
        Me.TextBox22.Width = 0.3149606!
        '
        'TextBox23
        '
        Me.TextBox23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Height = 0.2362205!
        Me.TextBox23.Left = 0.3149606!
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox23.Text = "校正"
        Me.TextBox23.Top = 1.026378!
        Me.TextBox23.Width = 0.8070866!
        '
        'TextBox24
        '
        Me.TextBox24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Height = 0.2362205!
        Me.TextBox24.Left = 1.122047!
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox24.Text = Nothing
        Me.TextBox24.Top = 1.026378!
        Me.TextBox24.Width = 0.7480313!
        '
        'TextBox25
        '
        Me.TextBox25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Height = 0.2362205!
        Me.TextBox25.Left = 1.870078!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox25.Text = Nothing
        Me.TextBox25.Top = 1.026378!
        Me.TextBox25.Width = 1.692913!
        '
        'TextBox26
        '
        Me.TextBox26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.Height = 0.2362205!
        Me.TextBox26.Left = 0.0!
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox26.Text = "4"
        Me.TextBox26.Top = 1.262598!
        Me.TextBox26.Width = 0.3149606!
        '
        'TextBox27
        '
        Me.TextBox27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Height = 0.2362205!
        Me.TextBox27.Left = 0.3149606!
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox27.Text = "版代"
        Me.TextBox27.Top = 1.262598!
        Me.TextBox27.Width = 0.8070866!
        '
        'TextBox28
        '
        Me.TextBox28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Height = 0.2362205!
        Me.TextBox28.Left = 1.122047!
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox28.Text = Nothing
        Me.TextBox28.Top = 1.262598!
        Me.TextBox28.Width = 0.7480313!
        '
        'TextBox29
        '
        Me.TextBox29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Height = 0.2362205!
        Me.TextBox29.Left = 1.870078!
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox29.Text = Nothing
        Me.TextBox29.Top = 1.262598!
        Me.TextBox29.Width = 1.692913!
        '
        'TextBox30
        '
        Me.TextBox30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Height = 0.2362205!
        Me.TextBox30.Left = 0.0!
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox30.Text = "5"
        Me.TextBox30.Top = 1.498819!
        Me.TextBox30.Width = 0.3149606!
        '
        'TextBox31
        '
        Me.TextBox31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Height = 0.2362205!
        Me.TextBox31.Left = 0.3149606!
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox31.Text = "印刷"
        Me.TextBox31.Top = 1.498819!
        Me.TextBox31.Width = 0.8070866!
        '
        'TextBox32
        '
        Me.TextBox32.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Height = 0.2362205!
        Me.TextBox32.Left = 1.122047!
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox32.Text = Nothing
        Me.TextBox32.Top = 1.498819!
        Me.TextBox32.Width = 0.7480313!
        '
        'TextBox33
        '
        Me.TextBox33.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Height = 0.2362205!
        Me.TextBox33.Left = 1.870078!
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox33.Text = Nothing
        Me.TextBox33.Top = 1.498819!
        Me.TextBox33.Width = 1.692913!
        '
        'TextBox34
        '
        Me.TextBox34.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Height = 0.2362205!
        Me.TextBox34.Left = 0.0!
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox34.Text = "6"
        Me.TextBox34.Top = 1.735039!
        Me.TextBox34.Width = 0.3149606!
        '
        'TextBox35
        '
        Me.TextBox35.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Height = 0.2362205!
        Me.TextBox35.Left = 0.3149606!
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox35.Text = "断裁"
        Me.TextBox35.Top = 1.735039!
        Me.TextBox35.Width = 0.8070866!
        '
        'TextBox36
        '
        Me.TextBox36.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox36.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox36.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox36.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox36.Height = 0.2362205!
        Me.TextBox36.Left = 1.122047!
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox36.Text = Nothing
        Me.TextBox36.Top = 1.735039!
        Me.TextBox36.Width = 0.7480313!
        '
        'TextBox37
        '
        Me.TextBox37.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox37.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox37.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox37.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox37.Height = 0.2362205!
        Me.TextBox37.Left = 1.870078!
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox37.Text = Nothing
        Me.TextBox37.Top = 1.735039!
        Me.TextBox37.Width = 1.692913!
        '
        'TextBox38
        '
        Me.TextBox38.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox38.Height = 0.2362205!
        Me.TextBox38.Left = 0.0!
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox38.Text = "7"
        Me.TextBox38.Top = 1.97126!
        Me.TextBox38.Width = 0.3149606!
        '
        'TextBox39
        '
        Me.TextBox39.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox39.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox39.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox39.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox39.Height = 0.2362205!
        Me.TextBox39.Left = 0.3149606!
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox39.Text = "ヌキ"
        Me.TextBox39.Top = 1.97126!
        Me.TextBox39.Width = 0.8070866!
        '
        'TextBox40
        '
        Me.TextBox40.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.Height = 0.2362205!
        Me.TextBox40.Left = 1.122047!
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox40.Text = Nothing
        Me.TextBox40.Top = 1.97126!
        Me.TextBox40.Width = 0.7480313!
        '
        'TextBox41
        '
        Me.TextBox41.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.Height = 0.2362205!
        Me.TextBox41.Left = 1.870078!
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox41.Text = Nothing
        Me.TextBox41.Top = 1.97126!
        Me.TextBox41.Width = 1.692913!
        '
        'TextBox42
        '
        Me.TextBox42.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox42.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox42.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox42.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox42.Height = 0.2362205!
        Me.TextBox42.Left = 3.741733!
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox42.Text = "8"
        Me.TextBox42.Top = 0.5543302!
        Me.TextBox42.Width = 0.3149606!
        '
        'Label3
        '
        Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Height = 0.2559055!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 3.741733!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.Label3.Text = ""
        Me.Label3.Top = 0.2984246!
        Me.Label3.Width = 0.3149606!
        '
        'Label19
        '
        Me.Label19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Height = 0.2559055!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 4.056694!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.Label19.Text = "工程"
        Me.Label19.Top = 0.2984246!
        Me.Label19.Width = 0.8070868!
        '
        'TextBox43
        '
        Me.TextBox43.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox43.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox43.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox43.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox43.Height = 0.2362205!
        Me.TextBox43.Left = 4.056694!
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox43.Text = "折"
        Me.TextBox43.Top = 0.5543302!
        Me.TextBox43.Width = 0.8070868!
        '
        'Label20
        '
        Me.Label20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label20.Height = 0.2559055!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 4.86378!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.Label20.Text = "号機"
        Me.Label20.Top = 0.2984246!
        Me.Label20.Width = 0.7480313!
        '
        'TextBox44
        '
        Me.TextBox44.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox44.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox44.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox44.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox44.Height = 0.2362205!
        Me.TextBox44.Left = 4.86378!
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox44.Text = Nothing
        Me.TextBox44.Top = 0.5543302!
        Me.TextBox44.Width = 0.7480313!
        '
        'TextBox45
        '
        Me.TextBox45.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox45.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox45.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox45.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox45.Height = 0.2362205!
        Me.TextBox45.Left = 5.611812!
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox45.Text = Nothing
        Me.TextBox45.Top = 0.5543302!
        Me.TextBox45.Width = 1.692913!
        '
        'Label23
        '
        Me.Label23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Height = 0.2559055!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 5.611812!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; text-justi" & _
    "fy: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.Label23.Text = "価格"
        Me.Label23.Top = 0.2984246!
        Me.Label23.Width = 1.692913!
        '
        'TextBox46
        '
        Me.TextBox46.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox46.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox46.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox46.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox46.Height = 0.2362205!
        Me.TextBox46.Left = 3.741733!
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox46.Text = "9"
        Me.TextBox46.Top = 0.7905508!
        Me.TextBox46.Width = 0.3149606!
        '
        'TextBox47
        '
        Me.TextBox47.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox47.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox47.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox47.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox47.Height = 0.2362205!
        Me.TextBox47.Left = 4.056694!
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox47.Text = "貼"
        Me.TextBox47.Top = 0.7905508!
        Me.TextBox47.Width = 0.8070868!
        '
        'TextBox48
        '
        Me.TextBox48.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox48.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox48.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox48.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox48.Height = 0.2362205!
        Me.TextBox48.Left = 4.86378!
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox48.Text = Nothing
        Me.TextBox48.Top = 0.7905508!
        Me.TextBox48.Width = 0.7480313!
        '
        'TextBox49
        '
        Me.TextBox49.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox49.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox49.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox49.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox49.Height = 0.2362205!
        Me.TextBox49.Left = 5.611812!
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox49.Text = Nothing
        Me.TextBox49.Top = 0.7905508!
        Me.TextBox49.Width = 1.692913!
        '
        'TextBox50
        '
        Me.TextBox50.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox50.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox50.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox50.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox50.Height = 0.2362205!
        Me.TextBox50.Left = 3.741733!
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox50.Text = "10"
        Me.TextBox50.Top = 1.026771!
        Me.TextBox50.Width = 0.3149606!
        '
        'TextBox51
        '
        Me.TextBox51.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox51.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox51.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox51.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox51.Height = 0.2362205!
        Me.TextBox51.Left = 4.056694!
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox51.Text = "箔押"
        Me.TextBox51.Top = 1.026771!
        Me.TextBox51.Width = 0.8070868!
        '
        'TextBox52
        '
        Me.TextBox52.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox52.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox52.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox52.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox52.Height = 0.2362205!
        Me.TextBox52.Left = 4.86378!
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox52.Text = Nothing
        Me.TextBox52.Top = 1.026771!
        Me.TextBox52.Width = 0.7480313!
        '
        'TextBox53
        '
        Me.TextBox53.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox53.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox53.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox53.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox53.Height = 0.2362205!
        Me.TextBox53.Left = 5.611812!
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox53.Text = Nothing
        Me.TextBox53.Top = 1.026771!
        Me.TextBox53.Width = 1.692913!
        '
        'TextBox54
        '
        Me.TextBox54.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox54.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox54.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox54.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox54.Height = 0.2362205!
        Me.TextBox54.Left = 3.741733!
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox54.Text = "11"
        Me.TextBox54.Top = 1.262991!
        Me.TextBox54.Width = 0.3149606!
        '
        'TextBox55
        '
        Me.TextBox55.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox55.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox55.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox55.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox55.Height = 0.2362205!
        Me.TextBox55.Left = 4.056694!
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox55.Text = "表面加工"
        Me.TextBox55.Top = 1.262991!
        Me.TextBox55.Width = 0.8070868!
        '
        'TextBox56
        '
        Me.TextBox56.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox56.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox56.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox56.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox56.Height = 0.2362205!
        Me.TextBox56.Left = 4.86378!
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox56.Text = Nothing
        Me.TextBox56.Top = 1.262991!
        Me.TextBox56.Width = 0.7480313!
        '
        'TextBox57
        '
        Me.TextBox57.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox57.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox57.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox57.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox57.Height = 0.2362205!
        Me.TextBox57.Left = 5.611812!
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox57.Text = Nothing
        Me.TextBox57.Top = 1.262991!
        Me.TextBox57.Width = 1.692913!
        '
        'TextBox58
        '
        Me.TextBox58.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox58.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox58.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox58.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox58.Height = 0.2362205!
        Me.TextBox58.Left = 3.741733!
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox58.Text = "12"
        Me.TextBox58.Top = 1.499212!
        Me.TextBox58.Width = 0.3149606!
        '
        'TextBox59
        '
        Me.TextBox59.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox59.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox59.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox59.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox59.Height = 0.2362205!
        Me.TextBox59.Left = 4.056694!
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox59.Text = "その他"
        Me.TextBox59.Top = 1.499212!
        Me.TextBox59.Width = 0.8070868!
        '
        'TextBox60
        '
        Me.TextBox60.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox60.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox60.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox60.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox60.Height = 0.2362205!
        Me.TextBox60.Left = 4.86378!
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox60.Text = Nothing
        Me.TextBox60.Top = 1.499212!
        Me.TextBox60.Width = 0.7480313!
        '
        'TextBox61
        '
        Me.TextBox61.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox61.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox61.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox61.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox61.Height = 0.2362205!
        Me.TextBox61.Left = 5.611812!
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox61.Text = Nothing
        Me.TextBox61.Top = 1.499212!
        Me.TextBox61.Width = 1.692913!
        '
        'TextBox62
        '
        Me.TextBox62.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox62.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox62.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox62.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox62.Height = 0.2362205!
        Me.TextBox62.Left = 3.741733!
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox62.Text = "13"
        Me.TextBox62.Top = 1.735432!
        Me.TextBox62.Width = 0.3149606!
        '
        'TextBox63
        '
        Me.TextBox63.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox63.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox63.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox63.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox63.Height = 0.2362205!
        Me.TextBox63.Left = 4.056694!
        Me.TextBox63.Name = "TextBox63"
        Me.TextBox63.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox63.Text = Nothing
        Me.TextBox63.Top = 1.735432!
        Me.TextBox63.Width = 0.8070868!
        '
        'TextBox64
        '
        Me.TextBox64.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox64.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox64.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox64.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox64.Height = 0.2362205!
        Me.TextBox64.Left = 4.86378!
        Me.TextBox64.Name = "TextBox64"
        Me.TextBox64.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox64.Text = Nothing
        Me.TextBox64.Top = 1.735432!
        Me.TextBox64.Width = 0.7480313!
        '
        'TextBox65
        '
        Me.TextBox65.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox65.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox65.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox65.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox65.Height = 0.2362205!
        Me.TextBox65.Left = 5.611812!
        Me.TextBox65.Name = "TextBox65"
        Me.TextBox65.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox65.Text = Nothing
        Me.TextBox65.Top = 1.735432!
        Me.TextBox65.Width = 1.692913!
        '
        'TextBox66
        '
        Me.TextBox66.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox66.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox66.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox66.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox66.Height = 0.2362205!
        Me.TextBox66.Left = 3.741733!
        Me.TextBox66.Name = "TextBox66"
        Me.TextBox66.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox66.Text = "14"
        Me.TextBox66.Top = 1.971653!
        Me.TextBox66.Width = 0.3149606!
        '
        'TextBox67
        '
        Me.TextBox67.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox67.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox67.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox67.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox67.Height = 0.2362205!
        Me.TextBox67.Left = 4.056694!
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox67.Text = Nothing
        Me.TextBox67.Top = 1.971653!
        Me.TextBox67.Width = 0.8070868!
        '
        'TextBox68
        '
        Me.TextBox68.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox68.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox68.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox68.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox68.Height = 0.2362205!
        Me.TextBox68.Left = 4.86378!
        Me.TextBox68.Name = "TextBox68"
        Me.TextBox68.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox68.Text = Nothing
        Me.TextBox68.Top = 1.971653!
        Me.TextBox68.Width = 0.7480313!
        '
        'TextBox69
        '
        Me.TextBox69.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox69.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox69.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox69.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox69.Height = 0.2362205!
        Me.TextBox69.Left = 5.611812!
        Me.TextBox69.Name = "TextBox69"
        Me.TextBox69.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox69.Text = Nothing
        Me.TextBox69.Top = 1.971653!
        Me.TextBox69.Width = 1.692913!
        '
        'Line46
        '
        Me.Line46.Height = 0.3421261!
        Me.Line46.Left = 0.2165354!
        Me.Line46.LineWeight = 0.0!
        Me.Line46.Name = "Line46"
        Me.Line46.Top = 2.625197!
        Me.Line46.Width = 0.2787402!
        Me.Line46.X1 = 0.4952756!
        Me.Line46.X2 = 0.2165354!
        Me.Line46.Y1 = 2.625197!
        Me.Line46.Y2 = 2.967323!
        '
        'Line1
        '
        Me.Line1.Height = 0.3421252!
        Me.Line1.Left = 1.834646!
        Me.Line1.LineWeight = 0.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 2.634647!
        Me.Line1.Width = 0.2787411!
        Me.Line1.X1 = 2.113387!
        Me.Line1.X2 = 1.834646!
        Me.Line1.Y1 = 2.634647!
        Me.Line1.Y2 = 2.976772!
        '
        'Line2
        '
        Me.Line2.Height = 0.3421252!
        Me.Line2.Left = 1.019686!
        Me.Line2.LineWeight = 0.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 2.634647!
        Me.Line2.Width = 0.27874!
        Me.Line2.X1 = 1.298426!
        Me.Line2.X2 = 1.019686!
        Me.Line2.Y1 = 2.634647!
        Me.Line2.Y2 = 2.976772!
        '
        'Line3
        '
        Me.Line3.Height = 0.3421261!
        Me.Line3.Left = 2.649607!
        Me.Line3.LineWeight = 0.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 2.634645!
        Me.Line3.Width = 0.2787402!
        Me.Line3.X1 = 2.928347!
        Me.Line3.X2 = 2.649607!
        Me.Line3.Y1 = 2.634645!
        Me.Line3.Y2 = 2.976771!
        '
        'Line4
        '
        Me.Line4.Height = 0.3421261!
        Me.Line4.Left = 3.464568!
        Me.Line4.LineWeight = 0.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 2.634646!
        Me.Line4.Width = 0.2787402!
        Me.Line4.X1 = 3.743308!
        Me.Line4.X2 = 3.464568!
        Me.Line4.Y1 = 2.634646!
        Me.Line4.Y2 = 2.976772!
        '
        'Line5
        '
        Me.Line5.Height = 0.3421261!
        Me.Line5.Left = 4.279528!
        Me.Line5.LineWeight = 0.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 2.634646!
        Me.Line5.Width = 0.2787409!
        Me.Line5.X1 = 4.558269!
        Me.Line5.X2 = 4.279528!
        Me.Line5.Y1 = 2.634646!
        Me.Line5.Y2 = 2.976772!
        '
        'Line6
        '
        Me.Line6.Height = 0.3421261!
        Me.Line6.Left = 5.094489!
        Me.Line6.LineWeight = 0.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 2.634646!
        Me.Line6.Width = 0.2787399!
        Me.Line6.X1 = 5.373229!
        Me.Line6.X2 = 5.094489!
        Me.Line6.Y1 = 2.634646!
        Me.Line6.Y2 = 2.976772!
        '
        'Line7
        '
        Me.Line7.Height = 0.3421261!
        Me.Line7.Left = 5.909449!
        Me.Line7.LineWeight = 0.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 2.634646!
        Me.Line7.Width = 0.2787409!
        Me.Line7.X1 = 6.18819!
        Me.Line7.X2 = 5.909449!
        Me.Line7.Y1 = 2.634646!
        Me.Line7.Y2 = 2.976772!
        '
        'Line8
        '
        Me.Line8.Height = 0.3421261!
        Me.Line8.Left = 6.72441!
        Me.Line8.LineWeight = 0.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 2.634646!
        Me.Line8.Width = 0.2787399!
        Me.Line8.X1 = 7.00315!
        Me.Line8.X2 = 6.72441!
        Me.Line8.Y1 = 2.634646!
        Me.Line8.Y2 = 2.976772!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Height = 0.3149606!
        Me.TextBox9.Left = 0.0!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.TextBox9.Text = "　　段ボール1ヶ　　　　　　　枚"
        Me.TextBox9.Top = 4.049212!
        Me.TextBox9.Width = 3.582677!
        '
        'TextBox70
        '
        Me.TextBox70.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox70.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox70.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox70.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox70.Height = 0.3149606!
        Me.TextBox70.Left = 0.0!
        Me.TextBox70.Name = "TextBox70"
        Me.TextBox70.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.TextBox70.Text = "　　包 装 単 位"
        Me.TextBox70.Top = 3.734252!
        Me.TextBox70.Width = 3.582677!
        '
        'Label4
        '
        Me.Label4.Height = 0.1968504!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 3.740945!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.Label4.Text = "【注意事項】"
        Me.Label4.Top = 3.166929!
        Me.Label4.Width = 0.9204722!
        '
        'Label13
        '
        Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Height = 0.1968504!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.3173229!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.Label13.Text = "色見本"
        Me.Label13.Top = 5.452363!
        Me.Label13.Width = 0.9055118!
        '
        'TextBox18
        '
        Me.TextBox18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Height = 0.472441!
        Me.TextBox18.Left = 0.3173229!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox18.Text = "　　 月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　 　日"
        Me.TextBox18.Top = 5.649213!
        Me.TextBox18.Width = 0.9055118!
        '
        'Label15
        '
        Me.Label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Height = 0.1968504!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 1.222835!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.Label15.Text = "ポジ"
        Me.Label15.Top = 5.452363!
        Me.Label15.Width = 0.8858268!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Height = 0.472441!
        Me.TextBox19.Left = 1.222835!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox19.Text = "　　 月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　 　日"
        Me.TextBox19.Top = 5.649213!
        Me.TextBox19.Width = 0.8858268!
        '
        'TextBox21
        '
        Me.TextBox21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Height = 0.472441!
        Me.TextBox21.Left = 2.108663!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox21.Text = "　　 月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　 　日"
        Me.TextBox21.Top = 5.649212!
        Me.TextBox21.Width = 0.8661417!
        '
        'Label16
        '
        Me.Label16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Height = 0.1968504!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 2.108663!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; text-justi" & _
    "fy: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.Label16.Text = "標準見本"
        Me.Label16.Top = 5.452363!
        Me.Label16.Width = 0.8661417!
        '
        'Label17
        '
        Me.Label17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Height = 0.1968504!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 2.974804!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.Label17.Text = "型"
        Me.Label17.Top = 5.452363!
        Me.Label17.Width = 0.8661417!
        '
        'TextBox72
        '
        Me.TextBox72.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox72.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox72.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox72.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox72.Height = 0.472441!
        Me.TextBox72.Left = 2.974804!
        Me.TextBox72.Name = "TextBox72"
        Me.TextBox72.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox72.Text = "　　 月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　 　日"
        Me.TextBox72.Top = 5.649212!
        Me.TextBox72.Width = 0.8661417!
        '
        'Label21
        '
        Me.Label21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label21.Height = 0.1968504!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 3.840946!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.Label21.Text = "フィルム"
        Me.Label21.Top = 5.452363!
        Me.Label21.Width = 0.8661417!
        '
        'TextBox73
        '
        Me.TextBox73.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox73.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox73.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox73.Height = 0.472441!
        Me.TextBox73.Left = 3.840946!
        Me.TextBox73.Name = "TextBox73"
        Me.TextBox73.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox73.Text = "　　 月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　 　日"
        Me.TextBox73.Top = 5.649212!
        Me.TextBox73.Width = 0.8661417!
        '
        'TextBox74
        '
        Me.TextBox74.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox74.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox74.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox74.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox74.Height = 0.472441!
        Me.TextBox74.Left = 4.707088!
        Me.TextBox74.Name = "TextBox74"
        Me.TextBox74.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox74.Text = "　　 月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　 　日"
        Me.TextBox74.Top = 5.649212!
        Me.TextBox74.Width = 0.8661417!
        '
        'Label22
        '
        Me.Label22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label22.Height = 0.1968504!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 4.707088!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; text-justi" & _
    "fy: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.Label22.Text = ""
        Me.Label22.Top = 5.452363!
        Me.Label22.Width = 0.8661417!
        '
        'TextBox75
        '
        Me.TextBox75.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox75.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox75.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox75.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox75.Height = 0.472441!
        Me.TextBox75.Left = 5.57323!
        Me.TextBox75.Name = "TextBox75"
        Me.TextBox75.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox75.Text = "　　 月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　 　日"
        Me.TextBox75.Top = 5.649212!
        Me.TextBox75.Width = 0.8661417!
        '
        'Label24
        '
        Me.Label24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label24.Height = 0.1968504!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 5.57323!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; text-justi" & _
    "fy: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.Label24.Text = ""
        Me.Label24.Top = 5.452363!
        Me.Label24.Width = 0.8661417!
        '
        'TextBox76
        '
        Me.TextBox76.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox76.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox76.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox76.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox76.Height = 0.472441!
        Me.TextBox76.Left = 6.439372!
        Me.TextBox76.Name = "TextBox76"
        Me.TextBox76.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox76.Text = "　　 月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　 　日"
        Me.TextBox76.Top = 5.649212!
        Me.TextBox76.Width = 0.8661417!
        '
        'Label25
        '
        Me.Label25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label25.Height = 0.1968504!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 6.439372!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; text-justi" & _
    "fy: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.Label25.Text = ""
        Me.Label25.Top = 5.452362!
        Me.Label25.Width = 0.8661417!
        '
        'Line10
        '
        Me.Line10.Height = 0.3318896!
        Me.Line10.Left = 0.5830708!
        Me.Line10.LineWeight = 0.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 5.725591!
        Me.Line10.Width = 0.299606!
        Me.Line10.X1 = 0.8826768!
        Me.Line10.X2 = 0.5830708!
        Me.Line10.Y1 = 5.725591!
        Me.Line10.Y2 = 6.057481!
        '
        'Line9
        '
        Me.Line9.Height = 0.3318911!
        Me.Line9.Left = 1.488978!
        Me.Line9.LineWeight = 0.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 5.728741!
        Me.Line9.Width = 0.299606!
        Me.Line9.X1 = 1.788584!
        Me.Line9.X2 = 1.488978!
        Me.Line9.Y1 = 5.728741!
        Me.Line9.Y2 = 6.060632!
        '
        'Line11
        '
        Me.Line11.Height = 0.3318911!
        Me.Line11.Left = 2.374804!
        Me.Line11.LineWeight = 0.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 5.728741!
        Me.Line11.Width = 0.299607!
        Me.Line11.X1 = 2.674411!
        Me.Line11.X2 = 2.374804!
        Me.Line11.Y1 = 5.728741!
        Me.Line11.Y2 = 6.060632!
        '
        'Line12
        '
        Me.Line12.Height = 0.3318911!
        Me.Line12.Left = 3.240946!
        Me.Line12.LineWeight = 0.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 5.728741!
        Me.Line12.Width = 0.299607!
        Me.Line12.X1 = 3.540553!
        Me.Line12.X2 = 3.240946!
        Me.Line12.Y1 = 5.728741!
        Me.Line12.Y2 = 6.060632!
        '
        'Line13
        '
        Me.Line13.Height = 0.3318911!
        Me.Line13.Left = 4.107088!
        Me.Line13.LineWeight = 0.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 5.728741!
        Me.Line13.Width = 0.2996058!
        Me.Line13.X1 = 4.406694!
        Me.Line13.X2 = 4.107088!
        Me.Line13.Y1 = 5.728741!
        Me.Line13.Y2 = 6.060632!
        '
        'Line14
        '
        Me.Line14.Height = 0.3318911!
        Me.Line14.Left = 4.97323!
        Me.Line14.LineWeight = 0.0!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 5.728741!
        Me.Line14.Width = 0.2996063!
        Me.Line14.X1 = 5.272836!
        Me.Line14.X2 = 4.97323!
        Me.Line14.Y1 = 5.728741!
        Me.Line14.Y2 = 6.060632!
        '
        'Line15
        '
        Me.Line15.Height = 0.3318911!
        Me.Line15.Left = 5.839372!
        Me.Line15.LineWeight = 0.0!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 5.728741!
        Me.Line15.Width = 0.2996058!
        Me.Line15.X1 = 6.138978!
        Me.Line15.X2 = 5.839372!
        Me.Line15.Y1 = 5.728741!
        Me.Line15.Y2 = 6.060632!
        '
        'Line16
        '
        Me.Line16.Height = 0.3318896!
        Me.Line16.Left = 6.705513!
        Me.Line16.LineWeight = 0.0!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 5.728741!
        Me.Line16.Width = 0.2996068!
        Me.Line16.X1 = 7.00512!
        Me.Line16.X2 = 6.705513!
        Me.Line16.Y1 = 5.728741!
        Me.Line16.Y2 = 6.060631!
        '
        'TextBox77
        '
        Me.TextBox77.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox77.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox77.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox77.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox77.Height = 0.472441!
        Me.TextBox77.Left = 0.3173229!
        Me.TextBox77.Name = "TextBox77"
        Me.TextBox77.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox77.Text = "　　 月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　 　日"
        Me.TextBox77.Top = 6.127953!
        Me.TextBox77.Width = 0.9055118!
        '
        'TextBox78
        '
        Me.TextBox78.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox78.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox78.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox78.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox78.Height = 0.472441!
        Me.TextBox78.Left = 1.222835!
        Me.TextBox78.Name = "TextBox78"
        Me.TextBox78.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox78.Text = "　　 月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　 　日"
        Me.TextBox78.Top = 6.127953!
        Me.TextBox78.Width = 0.8858271!
        '
        'TextBox79
        '
        Me.TextBox79.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox79.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox79.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox79.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox79.Height = 0.472441!
        Me.TextBox79.Left = 2.108663!
        Me.TextBox79.Name = "TextBox79"
        Me.TextBox79.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox79.Text = "　　 月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　 　日"
        Me.TextBox79.Top = 6.127953!
        Me.TextBox79.Width = 0.8661417!
        '
        'TextBox80
        '
        Me.TextBox80.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox80.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox80.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox80.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox80.Height = 0.472441!
        Me.TextBox80.Left = 2.974804!
        Me.TextBox80.Name = "TextBox80"
        Me.TextBox80.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox80.Text = "　　 月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　 　日"
        Me.TextBox80.Top = 6.127953!
        Me.TextBox80.Width = 0.8661417!
        '
        'TextBox81
        '
        Me.TextBox81.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox81.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox81.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox81.Height = 0.472441!
        Me.TextBox81.Left = 3.840946!
        Me.TextBox81.Name = "TextBox81"
        Me.TextBox81.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox81.Text = "　　 月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　 　日"
        Me.TextBox81.Top = 6.127953!
        Me.TextBox81.Width = 0.8661417!
        '
        'TextBox82
        '
        Me.TextBox82.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox82.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox82.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox82.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox82.Height = 0.472441!
        Me.TextBox82.Left = 4.707088!
        Me.TextBox82.Name = "TextBox82"
        Me.TextBox82.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox82.Text = "　　 月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　 　日"
        Me.TextBox82.Top = 6.127953!
        Me.TextBox82.Width = 0.8661417!
        '
        'TextBox83
        '
        Me.TextBox83.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox83.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox83.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox83.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox83.Height = 0.472441!
        Me.TextBox83.Left = 5.57323!
        Me.TextBox83.Name = "TextBox83"
        Me.TextBox83.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox83.Text = "　　 月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　 　日"
        Me.TextBox83.Top = 6.127953!
        Me.TextBox83.Width = 0.8661417!
        '
        'TextBox84
        '
        Me.TextBox84.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox84.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox84.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox84.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox84.Height = 0.472441!
        Me.TextBox84.Left = 6.439372!
        Me.TextBox84.Name = "TextBox84"
        Me.TextBox84.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.TextBox84.Text = "　　 月" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　 　日"
        Me.TextBox84.Top = 6.127953!
        Me.TextBox84.Width = 0.8661417!
        '
        'Line17
        '
        Me.Line17.Height = 0.3318911!
        Me.Line17.Left = 0.5830708!
        Me.Line17.LineWeight = 0.0!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 6.204331!
        Me.Line17.Width = 0.299606!
        Me.Line17.X1 = 0.8826768!
        Me.Line17.X2 = 0.5830708!
        Me.Line17.Y1 = 6.204331!
        Me.Line17.Y2 = 6.536222!
        '
        'Line18
        '
        Me.Line18.Height = 0.3318911!
        Me.Line18.Left = 1.488978!
        Me.Line18.LineWeight = 0.0!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 6.207481!
        Me.Line18.Width = 0.299606!
        Me.Line18.X1 = 1.788584!
        Me.Line18.X2 = 1.488978!
        Me.Line18.Y1 = 6.207481!
        Me.Line18.Y2 = 6.539372!
        '
        'Line19
        '
        Me.Line19.Height = 0.3318911!
        Me.Line19.Left = 2.374805!
        Me.Line19.LineWeight = 0.0!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 6.207481!
        Me.Line19.Width = 0.2996061!
        Me.Line19.X1 = 2.674411!
        Me.Line19.X2 = 2.374805!
        Me.Line19.Y1 = 6.207481!
        Me.Line19.Y2 = 6.539372!
        '
        'Line20
        '
        Me.Line20.Height = 0.3318911!
        Me.Line20.Left = 3.240947!
        Me.Line20.LineWeight = 0.0!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 6.207481!
        Me.Line20.Width = 0.2996061!
        Me.Line20.X1 = 3.540553!
        Me.Line20.X2 = 3.240947!
        Me.Line20.Y1 = 6.207481!
        Me.Line20.Y2 = 6.539372!
        '
        'Line21
        '
        Me.Line21.Height = 0.3318911!
        Me.Line21.Left = 4.107088!
        Me.Line21.LineWeight = 0.0!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 6.207481!
        Me.Line21.Width = 0.2996058!
        Me.Line21.X1 = 4.406694!
        Me.Line21.X2 = 4.107088!
        Me.Line21.Y1 = 6.207481!
        Me.Line21.Y2 = 6.539372!
        '
        'Line22
        '
        Me.Line22.Height = 0.3318911!
        Me.Line22.Left = 4.97323!
        Me.Line22.LineWeight = 0.0!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 6.207481!
        Me.Line22.Width = 0.2996073!
        Me.Line22.X1 = 5.272837!
        Me.Line22.X2 = 4.97323!
        Me.Line22.Y1 = 6.207481!
        Me.Line22.Y2 = 6.539372!
        '
        'Line23
        '
        Me.Line23.Height = 0.3318911!
        Me.Line23.Left = 5.839372!
        Me.Line23.LineWeight = 0.0!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 6.207481!
        Me.Line23.Width = 0.2996058!
        Me.Line23.X1 = 6.138978!
        Me.Line23.X2 = 5.839372!
        Me.Line23.Y1 = 6.207481!
        Me.Line23.Y2 = 6.539372!
        '
        'Line24
        '
        Me.Line24.Height = 0.3318901!
        Me.Line24.Left = 6.705513!
        Me.Line24.LineWeight = 0.0!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 6.207481!
        Me.Line24.Width = 0.2996068!
        Me.Line24.X1 = 7.00512!
        Me.Line24.X2 = 6.705513!
        Me.Line24.Y1 = 6.207481!
        Me.Line24.Y2 = 6.539371!
        '
        'Label26
        '
        Me.Label26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label26.Height = 0.1968504!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 0.0!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.Label26.Text = ""
        Me.Label26.Top = 5.452362!
        Me.Label26.Width = 0.3149606!
        '
        'TextBox85
        '
        Me.TextBox85.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox85.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox85.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox85.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox85.Height = 0.472441!
        Me.TextBox85.Left = 0.0!
        Me.TextBox85.Name = "TextBox85"
        Me.TextBox85.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox85.Text = "出"
        Me.TextBox85.Top = 5.649212!
        Me.TextBox85.Width = 0.3149606!
        '
        'TextBox86
        '
        Me.TextBox86.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox86.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox86.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox86.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox86.Height = 0.472441!
        Me.TextBox86.Left = 0.0!
        Me.TextBox86.Name = "TextBox86"
        Me.TextBox86.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox86.Text = "入"
        Me.TextBox86.Top = 6.127953!
        Me.TextBox86.Width = 0.3149606!
        '
        'OrderSlipOffsetAhead
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.322835!
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
        CType(Me.txt行番, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt工程区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt納期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発注単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発注金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl行番, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl工程区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl発注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl発注金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl発注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ｌｂｌHdr作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr顧客様No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdrユーザーNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr本台帳番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr枝番, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr顧客様No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdrユーザーNp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr本台帳番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr枝番, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr発注先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr発注先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr抜型番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt抜型番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr顧客商品No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt顧客商品No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl発注単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl納期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr工程区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr工程区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr客先納期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHrd客先納期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHrd受注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHrd受注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHrdユーザー名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHrdユーザー名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr受注単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr受注金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl材料, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl版, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblデザイン, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl印刷, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl折, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl貼, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblヌキ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblその他, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblその他1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発送元, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl行, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox51, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.TextBox66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox70, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox72, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox73, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox75, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox76, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox77, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox78, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox79, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox80, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox82, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox83, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox84, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox85, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox86, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt行番 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt工程区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt発注日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt納期 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt発注数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt発注単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt発注金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr作業No As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents lblTitle As DataDynamics.ActiveReports.Label
    Friend WithEvents lbl行番 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl工程区分 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl発注数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl発注金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl発注日 As DataDynamics.ActiveReports.Label
    Private WithEvents ｌｂｌHdr作業No As DataDynamics.ActiveReports.Label
    Private WithEvents txt作業No As DataDynamics.ActiveReports.TextBox
    Private WithEvents Barcode As DataDynamics.ActiveReports.Barcode
    Private WithEvents lblHdr顧客様No As DataDynamics.ActiveReports.Label
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdrユーザーNo As DataDynamics.ActiveReports.Label
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr本台帳番号 As DataDynamics.ActiveReports.Label
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr枝番 As DataDynamics.ActiveReports.Label
    Private WithEvents txtHdr顧客様No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdrユーザーNp As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr本台帳番号 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr枝番 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHdr発注先名 As DataDynamics.ActiveReports.Label
    Private WithEvents txtHdr発注先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHdr商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr抜型番号 As DataDynamics.ActiveReports.Label
    Private WithEvents txt抜型番号 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHdr顧客商品No As DataDynamics.ActiveReports.Label
    Private WithEvents txt顧客商品No As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl発注単価 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl納期 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr工程区分 As DataDynamics.ActiveReports.Label
    Private WithEvents txtHdr工程区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpFtr作業No As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents Label14 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl材料 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl版 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblデザイン As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl印刷 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl折 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl貼 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblヌキ As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblその他 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox16 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblその他1 As DataDynamics.ActiveReports.Label
    Private WithEvents txt発送元 As DataDynamics.ActiveReports.TextBox
    Private WithEvents SubSubReport As DataDynamics.ActiveReports.SubReport
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl行 As DataDynamics.ActiveReports.Label
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label11 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label18 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox23 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox24 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox25 As DataDynamics.ActiveReports.TextBox
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
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Label19 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox43 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label20 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox44 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox45 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label23 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox46 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox47 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox48 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox49 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox50 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox51 As DataDynamics.ActiveReports.TextBox
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
    Private WithEvents TextBox66 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox67 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox68 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox69 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line46 As DataDynamics.ActiveReports.Line
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Private WithEvents Line3 As DataDynamics.ActiveReports.Line
    Private WithEvents Line4 As DataDynamics.ActiveReports.Line
    Private WithEvents Line5 As DataDynamics.ActiveReports.Line
    Private WithEvents Line6 As DataDynamics.ActiveReports.Line
    Private WithEvents Line7 As DataDynamics.ActiveReports.Line
    Private WithEvents Line8 As DataDynamics.ActiveReports.Line
    Private WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox70 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label15 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label16 As DataDynamics.ActiveReports.Label
    Private WithEvents Label17 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox72 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label21 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox73 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox74 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label22 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox75 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label24 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox76 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label25 As DataDynamics.ActiveReports.Label
    Private WithEvents Line10 As DataDynamics.ActiveReports.Line
    Private WithEvents Line9 As DataDynamics.ActiveReports.Line
    Private WithEvents Line11 As DataDynamics.ActiveReports.Line
    Private WithEvents Line12 As DataDynamics.ActiveReports.Line
    Private WithEvents Line13 As DataDynamics.ActiveReports.Line
    Private WithEvents Line14 As DataDynamics.ActiveReports.Line
    Private WithEvents Line15 As DataDynamics.ActiveReports.Line
    Private WithEvents Line16 As DataDynamics.ActiveReports.Line
    Private WithEvents TextBox77 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox78 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox79 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox80 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox81 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox82 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox83 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox84 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line17 As DataDynamics.ActiveReports.Line
    Private WithEvents Line18 As DataDynamics.ActiveReports.Line
    Private WithEvents Line19 As DataDynamics.ActiveReports.Line
    Private WithEvents Line20 As DataDynamics.ActiveReports.Line
    Private WithEvents Line21 As DataDynamics.ActiveReports.Line
    Private WithEvents Line22 As DataDynamics.ActiveReports.Line
    Private WithEvents Line23 As DataDynamics.ActiveReports.Line
    Private WithEvents Line24 As DataDynamics.ActiveReports.Line
    Private WithEvents Label26 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox85 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox86 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHdr客先納期 As DataDynamics.ActiveReports.Label
    Private WithEvents txtHrd客先納期 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHrd受注日 As DataDynamics.ActiveReports.Label
    Private WithEvents txtHrd受注日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHrdユーザー名 As DataDynamics.ActiveReports.Label
    Private WithEvents txtHrdユーザー名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHdr受注数 As DataDynamics.ActiveReports.Label
    Private WithEvents txt受注数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHdr受注単価 As DataDynamics.ActiveReports.Label
    Private WithEvents txt受注単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHdr受注金額 As DataDynamics.ActiveReports.Label
    Private WithEvents txt受注金額 As DataDynamics.ActiveReports.TextBox
End Class
