Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class SupplierListSub
    Inherits DataDynamics.ActiveReports.ActiveReport
    '''========================================================================================
    ''' <SUMMARY>ﾚﾎﾟｰﾄｽﾀｰﾄ</SUMMARY>   
    '''========================================================================================
    Private Sub SupplierListSub_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        '------------------------------------------------------------------------------------------
        ' 変数定義
        '------------------------------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetFunc.F0仕入先特記DataTable

        '------------------------------------------------------------------------------------------
        ' ﾍﾟｰｼﾞ 設定
        '------------------------------------------------------------------------------------------
        'Detail
        Me.txtdtl特記事項.DataField = tbl.特記事項Column.ColumnName
    End Sub
End Class
