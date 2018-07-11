Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class SupplierList
    Inherits DataDynamics.ActiveReports.ActiveReport

    Public tbl特記 As NodeDatabase.DataSetView.V0仕入先特記DataTable

    '''========================================================================================
    ''' <SUMMARY>ﾚﾎﾟｰﾄｽﾀｰﾄ</SUMMARY>   
    '''========================================================================================
    Private Sub SupplierList_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        '------------------------------------------------------------------------------------------
        ' 変数定義
        '------------------------------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetView.V0仕入先詳細DataTable

        '------------------------------------------------------------------------------------------
        ' ﾀｲﾄﾙ 設定
        '------------------------------------------------------------------------------------------

        '------------------------------------------------------------------------------------------
        ' ｸﾞﾙｰﾌﾟ ﾍｯﾀﾞ
        '------------------------------------------------------------------------------------------
        Me.grpHdr仕入先CD.DataField = tbl.仕入先CDColumn.ColumnName
        Me.grpHdr仕入先CD.NewPage = NewPage.None
        Me.grpHdr仕入先CD.RepeatStyle = RepeatStyle.OnPageIncludeNoDetail  'OnPageIncludeNoDetail･･･改頁した新頁が合計行のみの印字でもﾍｯﾀﾞを印字
        Me.grpHdr仕入先CD.KeepTogether = True     ' ﾍｯﾀﾞの途中で改頁されない様に

        '------------------------------------------------------------------------------------------
        ' ｸﾞﾙｰﾌﾟ ﾌｯﾀ
        '------------------------------------------------------------------------------------------
        Me.grpFtr仕入先CD.NewPage = NewPage.After

        '------------------------------------------------------------------------------------------
        ' Detail
        '------------------------------------------------------------------------------------------
        'Detailにﾃﾞｰﾀが入っていなくてもﾍﾟｰｼﾞいっぱいになるまで繰返し表示
        Me.Detail.RepeatToFill = True

        'Header
        Me.txt仕入先CD.DataField = tbl.仕入先CDColumn.ColumnName
        Me.txt仕入先名.DataField = tbl.仕入先名Column.ColumnName
        Me.txt代表者役職_代表者名1.DataField = tbl.代表者役職_代表者名1Column.ColumnName
        Me.txt代表者役職_代表者名2.DataField = tbl.代表者役職_代表者名2Column.ColumnName

        'Detail
        Me.txtdtl本支店名.DataField = tbl.本支店名Column.ColumnName
        Me.txtdtl部署名.DataField = tbl.部署名Column.ColumnName
        Me.txtdtl郵便番号.DataField = tbl.郵便番号Column.ColumnName
        Me.txtdtl住所1.DataField = tbl.住所1Column.ColumnName
        Me.txtdtl住所2.DataField = tbl.住所2Column.ColumnName
        Me.txtdtl担当者名.DataField = tbl.担当者名Column.ColumnName
        Me.txtdtlTEL.DataField = tbl.TELColumn.ColumnName
        Me.txtdtlFAX.DataField = tbl.FAXColumn.ColumnName
        Me.txtdtl携帯.DataField = tbl.携帯Column.ColumnName
        Me.txtdtlメール.DataField = tbl.メールColumn.ColumnName
        Me.txtdtl行NO.DataField = tbl.行NOColumn.ColumnName

        '------------------------------------------------------------------------------------------
        ' ｻﾌﾞﾚﾎﾟｰﾄ
        '------------------------------------------------------------------------------------------
        Me.SubReport.Report = New NodeReport.SupplierListSub
        Me.SubReport.ReportName = "SupplierListSub"
        Me.SubReport.CanGrow = False
    End Sub

    '''========================================================================================
    ''' <SUMMARY>ｸﾞﾙｰﾌﾟﾍｯﾀﾞ</SUMMARY>   
    '''========================================================================================
    Private Sub grpHdr仕入先CD_Format(sender As Object, e As System.EventArgs) Handles grpHdr仕入先CD.Format
        '------------------------------------------------------------------------------------------
        ' 編集
        '------------------------------------------------------------------------------------------
        Select Case True
            Case Me.txt代表者役職_代表者名1.Text <> "" And Me.txt代表者役職_代表者名2.Text <> ""
                Me.txt代表者役職_代表者名.Text = Me.txt代表者役職_代表者名1.Text & vbCrLf & Me.txt代表者役職_代表者名2.Text
            Case Me.txt代表者役職_代表者名1.Text <> ""
                Me.txt代表者役職_代表者名.Text = Me.txt代表者役職_代表者名1.Text
            Case Me.txt代表者役職_代表者名2.Text <> ""
                Me.txt代表者役職_代表者名.Text = Me.txt代表者役職_代表者名2.Text
        End Select

        '------------------------------------------------------------------------------------------
        ' ｻﾌﾞﾚﾎﾟｰﾄ ﾃﾞｰﾀ ﾊﾞｲﾝﾄﾞ
        '------------------------------------------------------------------------------------------
        Dim row() As DataRow = tbl特記.Select(String.Format("{0} = {1}", tbl特記.仕入先CDColumn.ColumnName, Me.txt仕入先CD.Value))

        Me.SubReport.Report.DataSource = row
    End Sub

    '''========================================================================================
    ''' <SUMMARY>ﾃﾞｨﾃｨｰﾙ</SUMMARY>   
    '''========================================================================================
    Private Sub Detail_Format(sender As Object, e As System.EventArgs) Handles Detail.Format
        '------------------------------------------------------------------------------------------
        ' 詳細情報がなかった場合
        '------------------------------------------------------------------------------------------
        If Me.txtdtl行NO.Text = "" Then
            Me.lbldtlTEL.Visible = False
            Me.lbldtlFAX.Visible = False
            Me.lbldtl携帯.Visible = False
            Me.lbldtlメール.Visible = False
        Else
            Me.lbldtlTEL.Visible = True
            Me.lbldtlFAX.Visible = True
            Me.lbldtl携帯.Visible = True
            Me.lbldtlメール.Visible = True
        End If
    End Sub
End Class
