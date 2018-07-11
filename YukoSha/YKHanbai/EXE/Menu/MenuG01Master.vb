Public Class MenuG01Master
#Region "ｲﾍﾞﾝﾄﾍﾟｰｼﾞ"
    '''========================================================================================
    '''  <summary>ﾍﾟｰｼﾞ開始(Load)</summary>
    '''========================================================================================
    Protected Overrides Sub OnLoad(e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ｳｨﾝﾄﾞｳｻｲｽﾞ 固定
        '----------------------------------------------------------------------
        Me.Size = New System.Drawing.Size(800, 600)

        '----------------------------------------------------------------------
        ' ｷｰﾎﾞｰﾄﾞｲﾍﾞﾝﾄ を発生させる
        '----------------------------------------------------------------------
        Me.KeyPreview = True

        '----------------------------------------------------------------------
        ' ﾎﾞﾀﾝ 有効/無効
        '----------------------------------------------------------------------
        Me.btn0101.Visible = True
        Me.btn0102.Visible = True
        Me.btn0103.Visible = True
        Me.btn0104.Visible = True
        Me.btn0105.Visible = True
        Me.btn0106.Visible = True

        Me.btn0201.Visible = True
        Me.btn0202.Visible = True
        Me.btn0203.Visible = True
        Me.btn0204.Visible = True
        Me.btn0205.Visible = True
        Me.btn0206.Visible = True

        Me.btn0201.Visible = True
        Me.btn0202.Visible = False
        Me.btn0203.Visible = True
        Me.btn0204.Visible = True
        Me.btn0205.Visible = True
        Me.btn0206.Visible = True

        Me.btn0101.Text = "*紙マスタ保守"
        Me.btn0102.Text = "*糊マスタ保守"
        Me.btn0103.Text = "*台紙ﾏｽﾀ保守"
        Me.btn0104.Text = "*担当者ﾏｽﾀ保守"
        Me.btn0105.Text = "*機械ﾏｽﾀ保守"
        Me.btn0106.Text = "*大分類ﾏｽﾀ保守"

        Me.btn0201.Text = "*小分類ﾏｽﾀ保守"
        Me.btn0202.Text = "*印刷場所ﾏｽﾀ保守"
        Me.btn0203.Text = "*得意先ﾏｽﾀ保守"
        Me.btn0204.Text = "*得意先(個人用)ﾏｽﾀ保守"
        Me.btn0205.Text = "*出荷先ﾏｽﾀ保守"
        Me.btn0206.Text = "*仕入先ﾏｽﾀ保守"

        Me.btn0301.Text = "*品名ﾏｽﾀ保守"
        Me.btn0302.Text = ""
        Me.btn0303.Text = "各種残高設定関連"
        Me.btn0304.Text = "ヤマト運輸関連"
        Me.btn0305.Text = "各種コード表関連"
        Me.btn0306.Text = "紙価格関連"

        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.OnLoad(e)
    End Sub
#End Region

    Private _title As String


    '<Obsolete("ShowDialog(title As String)を使用してください。", True)> _
    'Public Overloads Function ShowDialog() As DialogResult
    '    _title = "" ' デフォルト値を設定
    '    Return MyBase.ShowDialog
    'End Function

#Region "ﾎﾞﾀﾝ ｲﾍﾞﾝﾄ"
    Private Sub btn0101_Click(sender As Object, e As System.EventArgs) Handles btn0101.Click
    End Sub

    Private Sub btn0102_Click(sender As Object, e As System.EventArgs) Handles btn0102.Click
    End Sub

    Private Sub btn0103_Click(sender As Object, e As System.EventArgs) Handles btn0103.Click
    End Sub

    Private Sub btn0104_Click(sender As Object, e As System.EventArgs) Handles btn0104.Click
    End Sub

    Private Sub btn0105_Click(sender As Object, e As System.EventArgs) Handles btn0105.Click
    End Sub

    Private Sub btn0106_Click(sender As Object, e As System.EventArgs) Handles btn0106.Click
    End Sub

    Private Sub btn0201_Click(sender As Object, e As System.EventArgs) Handles btn0201.Click
    End Sub

    Private Sub btn0202_Click(sender As Object, e As System.EventArgs) Handles btn0202.Click
    End Sub

    Private Sub btn0203_Click(sender As Object, e As System.EventArgs) Handles btn0203.Click
    End Sub

    Private Sub btn0204_Click(sender As Object, e As System.EventArgs) Handles btn0204.Click
    End Sub

    Private Sub btn0205_Click(sender As Object, e As System.EventArgs) Handles btn0205.Click
    End Sub

    Private Sub btn0206_Click(sender As Object, e As System.EventArgs) Handles btn0206.Click
    End Sub

    Private Sub btn0301_Click(sender As Object, e As System.EventArgs) Handles btn0301.Click
    End Sub

    Private Sub btn0302_Click(sender As Object, e As System.EventArgs) Handles btn0302.Click
    End Sub

    Private Sub btn0303_Click(sender As Object, e As System.EventArgs) Handles btn0303.Click
    End Sub

    Private Sub btn0304_Click(sender As Object, e As System.EventArgs) Handles btn0304.Click
    End Sub

    Private Sub btn0305_Click(sender As Object, e As System.EventArgs) Handles btn0305.Click
    End Sub

    Private Sub btn0306_Click(sender As Object, e As System.EventArgs) Handles btn0306.Click
    End Sub
#End Region
End Class