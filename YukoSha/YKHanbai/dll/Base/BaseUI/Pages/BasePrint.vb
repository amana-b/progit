Public Class BasePrint

#Region "ｲﾍﾞﾝﾄﾍﾟｰｼﾞ"
    '''========================================================================================
    '''  <summary>ﾍﾟｰｼﾞ開始(Load)</summary>
    '''========================================================================================
    Protected Overrides Sub OnLoad(e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ﾀｲﾄﾙ
        '----------------------------------------------------------------------
        Me.Text = Me.BaseViewer.Document.Name

        '----------------------------------------------------------------------
        ' Viewerｺﾝﾄﾛｰﾙのﾌﾟﾛﾊﾟﾃｨ設定
        '----------------------------------------------------------------------
        ' 画面ﾌｫｰﾑｻｲｽﾞにあわせてViewerｺﾝﾄﾛｰﾙのｻｲｽﾞを変化
        Me.BaseViewer.Dock = Windows.Forms.DockStyle.Fill

        ' 画面ﾌｫｰﾑｻｲｽﾞにあわせて表示倍率の調整
        Me.BaseViewer.ReportViewer.Zoom = -1

        ' ﾙｰﾗｰの表示なし
        Me.BaseViewer.ReportViewer.RulerVisible = False
    End Sub
#End Region
End Class