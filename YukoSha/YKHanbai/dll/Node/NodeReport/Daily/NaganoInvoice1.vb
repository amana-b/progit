Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class NaganoInvoice1
    Inherits DataDynamics.ActiveReports.ActiveReport

    Public tbl特記 As NodeDatabase.DataSetView.V0得意先特記DataTable

    '''========================================================================================
    ''' <SUMMARY>ﾚﾎﾟｰﾄｽﾀｰﾄ</SUMMARY>   
    '''========================================================================================
    Private Sub NaganoInvoice1_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        '------------------------------------------------------------------------------------------
        ' 変数定義
        '------------------------------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetFunc.F0得意先詳細DataTable

        '------------------------------------------------------------------------------------------
        ' ﾀｲﾄﾙ 設定
        '------------------------------------------------------------------------------------------
        Me.lbl請求明細書.Text = "顧  客  台  帳"

        '------------------------------------------------------------------------------------------
        ' ｸﾞﾙｰﾌﾟ ﾍｯﾀﾞ
        '------------------------------------------------------------------------------------------
        Me.grpHdr.DataField = tbl.得意先CDColumn.ColumnName
        Me.grpHdr.NewPage = NewPage.None
        Me.grpHdr.RepeatStyle = RepeatStyle.OnPageIncludeNoDetail  'OnPageIncludeNoDetail･･･改頁した新頁が合計行のみの印字でもﾍｯﾀﾞを印字
        Me.grpHdr.KeepTogether = True     ' ﾍｯﾀﾞの途中で改頁されない様に

        '------------------------------------------------------------------------------------------
        ' ｸﾞﾙｰﾌﾟ ﾌｯﾀ
        '------------------------------------------------------------------------------------------
        Me.grpFtr.NewPage = NewPage.After

        '------------------------------------------------------------------------------------------
        ' Detail
        '------------------------------------------------------------------------------------------
        'Detailにﾃﾞｰﾀが入っていなくてもﾍﾟｰｼﾞいっぱいになるまで繰返し表示
        Me.Detail.RepeatToFill = True

        'Header
        'Me.txt得意先CD.DataField = tbl.得意先CDColumn.ColumnName
        'Me.txt得意先名.DataField = tbl.得意先名Column.ColumnName
        'Me.txt作業No.DataField = tbl.自社担当者名Column.ColumnName
        'Me.txt代表者役職_代表者名1.DataField = tbl.代表者役職_代表者名1Column.ColumnName
        'Me.txt代表者役職_代表者名2.DataField = tbl.代表者役職_代表者名2Column.ColumnName
        'Me.txt締日名.DataField = tbl.締日名Column.ColumnName

        'Me.txt回収条件以上設定金額.DataField = tbl.回収条件設定金額Column.ColumnName
        'Me.txt回収条件以上回収月名.DataField = tbl.回収条件以上回収月名Column.ColumnName
        'Me.txt回収条件以上回収日名.DataField = tbl.回収条件以上回収日名Column.ColumnName
        'Me.txt回収条件以上回収方法名.DataField = tbl.回収条件以上回収方法名Column.ColumnName
        'Me.txt回収条件未満設定金額.DataField = tbl.回収条件設定金額Column.ColumnName
        'Me.txt回収条件未満回収月名.DataField = tbl.回収条件未満回収月名Column.ColumnName
        'Me.txt回収条件未満回収日名.DataField = tbl.回収条件未満回収日名Column.ColumnName
        'Me.txt回収条件未満回収方法名.DataField = tbl.回収条件未満回収方法名Column.ColumnName

        'Detail
        'Me.txtdtl本支店名.DataField = tbl.本支店名Column.ColumnName
        'Me.txtdtl部署名.DataField = tbl.部署名Column.ColumnName
        'Me.txtdtl郵便番号.DataField = tbl.郵便番号Column.ColumnName
        'Me.txtdtl住所1.DataField = tbl.住所1Column.ColumnName
        'Me.txtdtl住所2.DataField = tbl.住所2Column.ColumnName
        'Me.txtdtl担当者名.DataField = tbl.担当者名Column.ColumnName
        'Me.txtdtlTEL.DataField = tbl.TELColumn.ColumnName
        'Me.txtdtlFAX.DataField = tbl.FAXColumn.ColumnName
        'Me.txtdtl携帯.DataField = tbl.携帯Column.ColumnName
        'Me.txtdtlメール.DataField = tbl.メールColumn.ColumnName
        'Me.txtdtl行NO.DataField = tbl.行NOColumn.ColumnName

        '------------------------------------------------------------------------------------------
        ' ｻﾌﾞﾚﾎﾟｰﾄ
        '------------------------------------------------------------------------------------------
        'Me.SubSubReport.Report = New NodeReport.CustomerListSub
        'Me.SubSubReport.ReportName = "CustomerListSub"
        'Me.SubSubReport.CanGrow = False
    End Sub

    '''========================================================================================
    ''' <SUMMARY>ｸﾞﾙｰﾌﾟﾍｯﾀﾞ</SUMMARY>   
    '''========================================================================================
    Private Sub grpHdr得意先CD_Format(sender As Object, e As System.EventArgs) Handles grpHdr.Format
        '------------------------------------------------------------------------------------------
        ' 編集
        '------------------------------------------------------------------------------------------
        'Me.txt回収条件以上.Text = Me.txt回収条件以上回収月名.Value & " " & Me.txt回収条件以上回収日名.Value & " " & Me.txt回収条件以上回収方法名.Value
        'Me.txt回収条件未満.Text = Me.txt回収条件未満回収月名.Value & " " & Me.txt回収条件未満回収日名.Value & " " & Me.txt回収条件未満回収方法名.Value

        'Select Case True
        'Case Me.txt代表者役職_代表者名1.Text <> "" And Me.txt代表者役職_代表者名2.Text <> ""
        'Me.txt代表者役職_代表者名.Text = Me.txt代表者役職_代表者名1.Text & vbCrLf & Me.txt代表者役職_代表者名2.Text
        'Case Me.txt代表者役職_代表者名1.Text <> ""
        'Me.txt代表者役職_代表者名.Text = Me.txt代表者役職_代表者名1.Text
        'Case Me.txt代表者役職_代表者名2.Text <> ""
        'Me.txt代表者役職_代表者名.Text = Me.txt代表者役職_代表者名2.Text
        'End Select

        '------------------------------------------------------------------------------------------
        ' ｻﾌﾞﾚﾎﾟｰﾄ ﾃﾞｰﾀ ﾊﾞｲﾝﾄﾞ
        '------------------------------------------------------------------------------------------
        'Dim row() As DataRow = tbl特記.Select(String.Format("{0} = {1}", tbl特記.得意先CDColumn.ColumnName, Me.txt得意先CD.Value))

        'Me.SubReport.Report.DataSource = row
    End Sub

    '''========================================================================================
    ''' <SUMMARY>ﾃﾞｨﾃｨｰﾙﾍｯﾀﾞ</SUMMARY>   
    '''========================================================================================
    Private Sub Detail_Format(sender As Object, e As System.EventArgs) Handles Detail.Format
        '------------------------------------------------------------------------------------------
        ' 詳細情報がなかった場合
        '------------------------------------------------------------------------------------------
        'If Me.txtdtl行NO.Text = "" Then
        'Me.lbldtlTEL.Visible = False
        'Me.lbldtlFAX.Visible = False
        'Me.lbldtl携帯.Visible = False
        'Me.lbldtlメール.Visible = False
        'Else
        'Me.lbldtlTEL.Visible = True
        'Me.lbldtlFAX.Visible = True
        'Me.lbldtl携帯.Visible = True
        'Me.lbldtlメール.Visible = True
        'End If
    End Sub

    Private Sub grpFtr得意先CD_Format(sender As System.Object, e As System.EventArgs) Handles grpFtr.Format

    End Sub

    Private Sub PageHeader_Format(sender As System.Object, e As System.EventArgs) Handles PageHeader.Format

    End Sub


    Private Sub PageFooter_Format(sender As System.Object, e As System.EventArgs) Handles PageFooter.Format

    End Sub
End Class
