Public Class MenuBase
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
        Dim frm As New frmPaste()
        frm.Show()
    End Sub

    Private Sub btn0102_Click(sender As Object, e As System.EventArgs) Handles btn0102.Click
        Dim frm As New frmPaper()
        frm.Show()
    End Sub

    Private Sub btn0103_Click(sender As Object, e As System.EventArgs) Handles btn0103.Click
        Dim frm As New frmMount()
        frm.Show()
    End Sub

    Private Sub btn0104_Click(sender As Object, e As System.EventArgs) Handles btn0104.Click
        Dim frm As New frmPersonnel()
        frm.Show()
    End Sub

    Private Sub btn0105_Click(sender As Object, e As System.EventArgs) Handles btn0105.Click
        Dim frm As New frmMachine()
        frm.Show()
    End Sub

    Private Sub btn0106_Click(sender As Object, e As System.EventArgs) Handles btn0106.Click
        Dim frm As New frmPaperPriList()
        frm.Show()
    End Sub

    Private Sub btn0201_Click(sender As Object, e As System.EventArgs) Handles btn0201.Click

    End Sub

    Private Sub btn0202_Click(sender As Object, e As System.EventArgs) Handles btn0202.Click
        Dim frm As New frmPrintLoc()
        frm.Show()
    End Sub

    Private Sub btn0203_Click(sender As Object, e As System.EventArgs) Handles btn0203.Click
        Dim frm As New frmCustomer()
        frm.Show()
    End Sub

    Private Sub btn0204_Click(sender As Object, e As System.EventArgs) Handles btn0204.Click
        Dim frm As New frmCustomerOne()
        frm.Show()
    End Sub

    Private Sub btn0205_Click(sender As Object, e As System.EventArgs) Handles btn0205.Click
        Dim frm As New frmDelivery()
        frm.Show()
    End Sub

    Private Sub btn0206_Click(sender As Object, e As System.EventArgs) Handles btn0206.Click
        Dim frm As New frmPaperPriIn()
        frm.Show()
    End Sub

    Private Sub btn0301_Click(sender As Object, e As System.EventArgs) Handles btn0301.Click
        Dim frm As New frmItemName()
        frm.Show()
    End Sub

    Private Sub btn0302_Click(sender As Object, e As System.EventArgs) Handles btn0302.Click
        Dim frm As New frmDeliveryList()
        frm.Show()
    End Sub

    Private Sub btn0303_Click(sender As Object, e As System.EventArgs) Handles btn0303.Click
        Dim frm As New frmSupplier()
        frm.Show()
    End Sub

    Private Sub btn0304_Click(sender As Object, e As System.EventArgs) Handles btn0304.Click

    End Sub

    Private Sub btn0305_Click(sender As Object, e As System.EventArgs) Handles btn0305.Click

    End Sub

    Private Sub btn0306_Click(sender As Object, e As System.EventArgs) Handles btn0306.Click
        Dim frm As New frmOffSet()
        frm.Show()
    End Sub
#End Region
End Class