Public Class MenuList
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
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.OnLoad(e)
    End Sub
#End Region

#Region "ﾎﾞﾀﾝ ｲﾍﾞﾝﾄ"
    Private Sub btn0101_Click(sender As Object, e As System.EventArgs) Handles btn0101.Click

    End Sub

    Private Sub btn0102_Click(sender As Object, e As System.EventArgs) Handles btn0102.Click

    End Sub

    Private Sub btn0103_Click(sender As Object, e As System.EventArgs) Handles btn0103.Click
        Dim frm As New frmDeliveryList()
        frm.Show()
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