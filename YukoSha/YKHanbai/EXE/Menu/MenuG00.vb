Public Class MenuG00
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
        ' ﾒﾆｭｰ標題
        '----------------------------------------------------------------------
        Me.lblメニュー標題.Text = "ラベル印刷業総合管理システム"

        '----------------------------------------------------------------------
        ' ﾎﾞﾀﾝ 有効/無効
        '----------------------------------------------------------------------
        Me.btn0101.Visible = True
        Me.btn0102.Visible = True
        Me.btn0103.Visible = True
        Me.btn0104.Visible = True
        Me.btn0105.Visible = False
        Me.btn0106.Visible = True

        Me.btn0201.Visible = True
        Me.btn0202.Visible = True
        Me.btn0203.Visible = True
        Me.btn0204.Visible = True
        Me.btn0205.Visible = True
        Me.btn0206.Visible = False

        Me.btn0201.Visible = True
        Me.btn0202.Visible = True
        Me.btn0203.Visible = False
        Me.btn0204.Visible = True
        Me.btn0205.Visible = False
        Me.btn0206.Visible = False

        Me.btn0101.Text = "受注処理"
        Me.btn0102.Text = "日次処理"
        Me.btn0103.Text = "締日処理"
        Me.btn0104.Text = "月次処理"
        Me.btn0105.Text = ""
        Me.btn0106.Text = "随時処理･問合せ"

        Me.btn0201.Text = "工程管理"
        Me.btn0202.Text = "見積処理"
        Me.btn0203.Text = "コーセー関連"
        Me.btn0204.Text = "ヤマト運輸関連"
        Me.btn0205.Text = "刃型管理"
        Me.btn0206.Text = ""

        Me.btn0301.Text = "マスタ保守／コード表"
        Me.btn0302.Text = "*特殊帳票ﾌﾟﾘﾝﾀ設定"
        Me.btn0303.Text = ""
        Me.btn0304.Text = "出荷ﾁｪｯｸ関連"
        Me.btn0305.Text = ""
        Me.btn0206.Text = ""

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
        Dim frm As New frmPaper()
        frm.Show()
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
        Dim frm As New MenuG01Master()
        frm.lblメニュー標題.Text = CType(sender, BaseUI.Control.Button).Text
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
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