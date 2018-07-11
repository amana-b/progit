Imports System.ComponentModel

Namespace Control
    Public Class GridView
        Inherits System.Windows.Forms.DataGridView

#Region "ﾌﾟﾛﾊﾟﾃｨ"
        '''========================================================================================
        '''  <summary>入力値にエラーかどうか(True:不正, False:正常)</summary>
        '''========================================================================================
        Private _IsError As Boolean = False                             '入力値にエラーかどうか(True:不正, False:正常)

        <Description("入力値にエラーかどうか(True:不正, False:正常)"), Category("カスタム")> _
        Public Property IsError() As Boolean
            Get
                Return Me._IsError
            End Get
            Set(ByVal Value As Boolean)
                Me._IsError = Value
            End Set
        End Property

        '''========================================================================================
        '''  <summary>必須項目かどうか(True:必須, False:未入力)</summary>
        '''========================================================================================
        Private _Required As Boolean = False                            '必須項目かどうか(True:必須, False:未入力)

        <Description("必須項目かどうか(True:必須, False:未入力)"), Category("カスタム")> _
        Public Property Required() As Boolean
            Get
                Return Me._Required
            End Get
            Set(ByVal Value As Boolean)
                Me._Required = Value
            End Set
        End Property

        '''========================================================================================
        '''  <summary>ﾏｽﾀﾒﾝﾃ画面の時のｷｰ部とﾃﾞｰﾀ部を指定する事によりﾛｯｸ/ｱﾝﾛｯｸを部品化利用(FormEnableKey,FormEnableData)</summary>
        '''========================================================================================
        Private _FieldLockType As BaseContents.Field.LockType = BaseContents.Field.LockType.None

        <Description("ﾏｽﾀﾒﾝﾃ画面の時のｷｰ部とﾃﾞｰﾀ部を指定する事によりﾛｯｸ/ｱﾝﾛｯｸを部品化利用(FormEnableKey,FormEnableData)"), Category("カスタム")> _
        Public Property FieldLockType() As BaseContents.Field.LockType
            Get
                Return Me._FieldLockType
            End Get
            Set(ByVal Value As BaseContents.Field.LockType)
                Me._FieldLockType = Value
            End Set
        End Property

        '''========================================================================================
        '''  <summary>ｸﾞﾘｯﾄﾞﾋﾞｭｰより取得したい列名の設定(列名をﾀﾌﾞ区切り)</summary>
        '''========================================================================================
        Private _DataKeyNames As String = ""

        <Description("ｸﾞﾘｯﾄﾞﾋﾞｭｰより取得したい列名の設定(ﾀﾌﾞ区切り)"), Category("カスタム")> _
        Public Property DataKeyNames() As String
            Get
                Return Me._DataKeyNames
            End Get
            Set(ByVal Value As String)
                Me._DataKeyNames = Value
            End Set
        End Property
#End Region

#Region "ｺﾝｽﾄﾗｸﾀ"
        '''========================================================================================
        '''  <summary>ｺﾝｽﾄﾗｸﾀ</summary>
        '''========================================================================================
        Public Sub New()
            '----------------------------------------------------------------------
            ' 初期値 設定
            '----------------------------------------------------------------------
            ' ﾌｫﾝﾄｻｲｽﾞ
            Me.Font = New System.Drawing.Font("ＭＳ ゴシック", 12)

            ' 列幅の自動調整
            Me.AutoSizeColumnsMode = Windows.Forms.DataGridViewAutoSizeColumnsMode.None

            ' 行高の自動調整 ※ｸﾞﾘｯﾄﾞ表示の速度が遅くなるためNone
            Me.AutoSizeRowsMode = Windows.Forms.DataGridViewAutoSizeRowsMode.None

            ' 行高を変更できないようにする
            Me.AllowUserToResizeRows = False

            ' 行追加不可にする
            Me.AllowUserToAddRows = False

            ' 行削除の禁止
            Me.AllowUserToDeleteRows = False

            ' 列を自動で生成されないようにする
            Me.AutoGenerateColumns = False

            ' 常に行選択
            Me.SelectionMode = Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        End Sub
#End Region

#Region "背景色"
        '''========================================================================================
        '''  <summary>ﾏｳｽが当たっている行に色を付ける</summary>
        '''========================================================================================
        Private Sub GridDataView_CellMouseMove(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Me.CellMouseMove
            Dim intCurRow As Integer = e.RowIndex
            For i As Integer = 0 To Me.RowCount - 1
                If Me.Rows(i).DefaultCellStyle.BackColor = Drawing.Color.PeachPuff Then
                    Continue For
                End If

                If i = intCurRow Then
                    Me.Rows(i).DefaultCellStyle.BackColor = Drawing.Color.PaleTurquoise
                Else
                    Me.Rows(i).DefaultCellStyle.BackColor = Drawing.Color.Empty
                End If
            Next
        End Sub

        '''========================================================================================
        ''' <summary>ｸﾞﾘｯﾄﾞｼﾝｸﾞﾙｸﾘｯｸ時に背景に色を付ける</summary>
        '''========================================================================================
        Private Sub GridDataView_Click(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Me.CellClick
            Dim intCurRow As Integer = e.RowIndex
            For i As Integer = 0 To Me.RowCount - 1
                If i = intCurRow Then
                    Me.Rows(i).DefaultCellStyle.BackColor = Drawing.Color.PeachPuff
                Else
                    Me.Rows(i).DefaultCellStyle.BackColor = Drawing.Color.Empty
                End If
            Next
        End Sub
#End Region

#Region "ﾌｫｰｶｽ"
        '''========================================================================================
        '''  <summary>ﾌｫｰｶｽ取得ｲﾍﾞﾝﾄ</summary>
        '''========================================================================================
        Protected Overrides Sub OnGotFocus(e As System.EventArgs)
            '----------------------------------------------------------------------
            ' 背景色を付ける
            '----------------------------------------------------------------------
            Me.BackColor = Drawing.Color.PeachPuff

            '----------------------------------------------------------------------
            ' ﾍﾞｰｽ処理
            '----------------------------------------------------------------------
            MyBase.OnGotFocus(e)
        End Sub

        '''========================================================================================
        '''  <summary>ﾌｫｰｶｽ喪失ｲﾍﾞﾝﾄ</summary>
        '''========================================================================================
        Protected Overrides Sub OnLostFocus(e As System.EventArgs)
            '----------------------------------------------------------------------
            ' 背景色を消す
            '----------------------------------------------------------------------
            Me.BackColor = Drawing.Color.Empty

            '----------------------------------------------------------------------
            ' ﾍﾞｰｽ処理
            '----------------------------------------------------------------------
            MyBase.OnLostFocus(e)
        End Sub
#End Region

#Region "ｷｰ押下"
        '''========================================================================================
        '''  <summary>ｷｰ押下ｲﾍﾞﾝﾄ</summary>
        '''========================================================================================
        Private Sub GridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
            '----------------------------------------------------------------------
            ' ｴﾝﾀｰｷｰで下の行に移動させない
            '----------------------------------------------------------------------
            If e.KeyCode = System.Windows.Forms.Keys.Enter Then
                e.Handled = True
            End If
        End Sub
#End Region

#Region "行NO"
        '''========================================================================================
        '''  <summary>ﾚｺｰﾄﾞｾﾚｸﾀに行NOを設定</summary>
        '''========================================================================================
        Private Sub GridView_RowPostPaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles Me.RowPostPaint
            If Me.RowHeadersVisible Then
                ' 行ﾍｯﾀﾞの列ﾍｯﾀﾞ
                If e.RowIndex = 0 Then
                    Me.TopLeftHeaderCell.Style.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                    Me.TopLeftHeaderCell.Value = "No"
                End If

                ' 行番号を描画する範囲を決定する
                Dim Rect As New System.Drawing.Rectangle(e.RowBounds.Left, e.RowBounds.Top, Me.RowHeadersWidth, e.RowBounds.Height)
                Rect.Inflate(-2, -2)

                ' 行番号を描画する
                System.Windows.Forms.TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, Rect, e.InheritedRowStyle.ForeColor, System.Windows.Forms.TextFormatFlags.Right Or System.Windows.Forms.TextFormatFlags.VerticalCenter)
            End If
        End Sub

        '''========================================================================================
        '''  <summary>ﾚｺｰﾄﾞｾﾚｸﾀにの背景色なし</summary>
        '''========================================================================================
        Private Sub GridView_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles Me.CellPainting
            If e.RowIndex >= 0 Then
                Me.RowHeadersDefaultCellStyle.SelectionBackColor = e.CellStyle.BackColor
            End If
        End Sub
#End Region
    End Class
End Namespace
