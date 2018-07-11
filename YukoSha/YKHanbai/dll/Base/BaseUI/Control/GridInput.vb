Imports System.ComponentModel

Namespace Control
    Public Class GridInput
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
        '''  <summary>入力項目の先頭</summary>
        '''========================================================================================
        Private WithEvents _TextBoxAddTop As BaseUI.Control.TextBox

        <Description("入力項目の先頭"), Category("カスタム")> _
        Public Property TextBoxAddTop() As BaseUI.Control.TextBox
            Get
                Return Me._TextBoxAddTop
            End Get
            Set(ByVal Value As BaseUI.Control.TextBox)
                Me._TextBoxAddTop = Value
            End Set
        End Property

        '''========================================================================================
        '''  <summary>入力項目の末尾</summary>
        '''========================================================================================
        Private WithEvents _TextBoxAddBtm As BaseUI.Control.TextBox

        <Description("入力項目の末尾"), Category("カスタム")> _
        Public Property TextBoxAddBtm() As BaseUI.Control.TextBox
            Get
                Return Me._TextBoxAddBtm
            End Get
            Set(ByVal Value As BaseUI.Control.TextBox)
                Me._TextBoxAddBtm = Value
            End Set
        End Property

        '''========================================================================================
        '''  <summary>行挿入のﾎﾞﾀﾝ</summary>
        '''========================================================================================
        Private WithEvents _ButtonInsert As BaseUI.Control.Button

        <Description("行挿入のﾎﾞﾀﾝ"), Category("カスタム")> _
        Public Property ButtonInsert() As BaseUI.Control.Button
            Get
                Return Me._ButtonInsert
            End Get
            Set(ByVal Value As BaseUI.Control.Button)
                Me._ButtonInsert = Value
            End Set
        End Property

        '''========================================================================================
        '''  <summary>行削除のﾎﾞﾀﾝ</summary>
        '''========================================================================================
        Private WithEvents _ButtonDelete As BaseUI.Control.Button

        <Description("行挿入のﾎﾞﾀﾝ"), Category("カスタム")> _
        Public Property ButtonDelete() As BaseUI.Control.Button
            Get
                Return Me._ButtonDelete
            End Get
            Set(ByVal Value As BaseUI.Control.Button)
                Me._ButtonDelete = Value
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

            ' 複数行選択できないようにする
            Me.MultiSelect = False

            ' 行高を変更できないようにする
            Me.AllowUserToResizeRows = False

            ' 行追加を不可にする
            Me.AllowUserToAddRows = False

            ' 選択は1行まるごと
            Me.SelectionMode = Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        End Sub
#End Region

#Region "ｲﾍﾞﾝﾄ"
        '''========================================================================================
        '''  <summary>行選択</summary>
        '''========================================================================================
        Protected Overrides Sub OnSelectionChanged(e As System.EventArgs)
            MyBase.OnSelectionChanged(e)

            ' 先頭項目へﾌｫｰｶｽ移動
            If (Not Me.TextBoxAddTop Is Nothing) And (Me.TextBoxAddTop.Enabled) Then
                Me.TextBoxAddTop.Focus()
                Me.TextBoxAddTop.SelectAll()
            End If
        End Sub

        '''========================================================================================
        '''  <summary>初期化</summary>
        '''========================================================================================
        Public Event Setting(ByRef TextBoxAddTop As BaseUI.Control.TextBox, ByRef TextBoxAddBtm As BaseUI.Control.TextBox, ByRef ButtonInsert As BaseUI.Control.Button, ByRef ButtonDelete As BaseUI.Control.Button)
        Private Sub GridInput_HandleCreated(sender As Object, e As System.EventArgs) Handles Me.HandleCreated
            RaiseEvent Setting(Me.TextBoxAddTop, Me.TextBoxAddBtm, Me.ButtonInsert, Me.ButtonDelete)
        End Sub

        '''========================================================================================
        '''  <summary>ｶﾚﾝﾄ行 設定</summary>
        '''========================================================================================
        Private Sub CurrrentRowSelect(RowIndex As Integer)
            If RowIndex = -1 Then
                Exit Sub
            End If

            ' ｶﾚﾝﾄ行 選択
            Me.CurrentCell = Me.Rows(RowIndex).Cells(0)

            ' 行選択 ｲﾍﾞﾝﾄ実行(上記ｽﾃｯﾌﾟでも[SelectionChanged]ｲﾍﾞﾝﾄは発生するが、CurrentRow.Indexが先頭行なので再度ｲﾍﾞﾝﾄ発生させる)
            Me.OnSelectionChanged(System.EventArgs.Empty)
        End Sub

        '''========================================================================================
        '''  <summary>ﾊﾞｲﾝﾄﾞ</summary>
        '''========================================================================================
        Public Event DataBind()
        Public Event RowBind(ByVal RowIndex As Integer)

        '''========================================================================================
        '''  <summary>Enterｷｰで行更新</summary>
        '''========================================================================================
        Public Event RowUpdateValid(ByRef IsError As Boolean)
        Public Event RowUpdateExecute(ByVal RowIndex As Integer)

        Private Sub _TextBoxAddBtm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles _TextBoxAddBtm.KeyDown
            '----------------------------------------------------------------------
            ' 変更不可なら即終了
            '----------------------------------------------------------------------
            If Me.Enabled = False Then
                Exit Sub
            End If

            '----------------------------------------------------------------------
            ' ｲﾝﾃﾞｯｸｽ算出
            '----------------------------------------------------------------------
            Dim RowIndex As Integer = 0

            ' ｶﾚﾝﾄ行の次行
            If Not Me.CurrentRow Is Nothing Then
                RowIndex = Me.CurrentRow.Index + 1
            End If

            ' 最終行以上なら最終行に
            If RowIndex > Me.Rows.Count - 1 Then
                RowIndex = Me.Rows.Count - 1
            End If

            '----------------------------------------------------------------------
            ' Enterｷｰ以外 ｽｷｯﾌﾟ
            '----------------------------------------------------------------------
            If e.KeyCode <> Windows.Forms.Keys.Enter Then
                Exit Sub
            End If

            '----------------------------------------------------------------------
            ' 行更新
            '----------------------------------------------------------------------
            ' 検査
            Dim IsError As Integer = False
            RaiseEvent RowUpdateValid(IsError)

            ' 行挿入 実行
            If Not IsError Then
                ' 行更新(ﾌﾚｰﾑﾜｰｸ側)
                RaiseEvent RowUpdateExecute(Me.CurrentRow.Index)

                ' 行更新(ｸﾞﾘｯﾄﾞ側)
                RaiseEvent RowBind(Me.CurrentRow.Index)

                ' 次行をｶﾚﾝﾄ行にする
                Me.CurrrentRowSelect(RowIndex)

                ' 先頭項目へﾌｫｰｶｽ移動
                If (Not Me.TextBoxAddTop Is Nothing) And (Me.TextBoxAddTop.Enabled) Then
                    Me.TextBoxAddTop.Focus()
                    Me.TextBoxAddTop.SelectAll()
                End If
            End If
        End Sub

        '''========================================================================================
        '''  <summary>行追加ﾎﾞﾀﾝ ｸﾘｯｸ</summary>
        '''========================================================================================
        Public Event RowInsert(ByVal RowIndex As Integer)
        Private Sub _ButtonInsert_Click(sender As Object, e As System.EventArgs) Handles _ButtonInsert.Click
            '----------------------------------------------------------------------
            ' 変更不可なら即終了
            '----------------------------------------------------------------------
            If Me.Enabled = False Then
                Exit Sub
            End If

            '----------------------------------------------------------------------
            ' ｲﾝﾃﾞｯｸｽ算出
            '----------------------------------------------------------------------
            Dim RowIndex As Integer = 0

            ' ﾃﾞｨﾌｫﾙﾄは最終行
            If Me.Rows.Count > 0 Then
                RowIndex = Me.Rows.Count - 1
            End If

            ' ｶﾚﾝﾄ行 取得
            If Not Me.CurrentRow Is Nothing Then
                RowIndex = Me.CurrentRow.Index
            End If

            '----------------------------------------------------------------------
            ' 行挿入(ﾌﾚｰﾑﾜｰｸ側)
            '----------------------------------------------------------------------
            RaiseEvent RowInsert(RowIndex)

            '----------------------------------------------------------------------
            ' 行挿入(ｸﾞﾘｯﾄﾞ側)
            '----------------------------------------------------------------------
            Me.Rows.Insert(RowIndex)
            RaiseEvent RowBind(RowIndex)

            '----------------------------------------------------------------------
            ' ｶﾚﾝﾄ行選択
            '----------------------------------------------------------------------
            Me.CurrrentRowSelect(RowIndex)

            '----------------------------------------------------------------------
            ' 先頭項目へﾌｫｰｶｽ移動
            '----------------------------------------------------------------------
            If (Not Me.TextBoxAddTop Is Nothing) And (Me.TextBoxAddTop.Enabled) Then
                Me.TextBoxAddTop.Focus()
                Me.TextBoxAddTop.SelectAll()
            End If
        End Sub

        '''========================================================================================
        '''  <summary>行削除ﾎﾞﾀﾝ ｸﾘｯｸ</summary>
        '''========================================================================================
        Public Event RowDelete(ByVal RowIndex As Integer)
        Private Sub _ButtonDelete_Click(sender As Object, e As System.EventArgs) Handles _ButtonDelete.Click
            '----------------------------------------------------------------------
            ' 変更不可なら即終了
            '----------------------------------------------------------------------
            If Me.Enabled = False Then
                Exit Sub
            End If

            '----------------------------------------------------------------------
            ' ｾﾞﾛ行なら即終了
            '----------------------------------------------------------------------
            Dim RowIndex As Integer = Me.Rows.Count - 1
            If RowIndex = -1 Then
                Exit Sub
            End If

            '----------------------------------------------------------------------
            ' ｶﾚﾝﾄ行 取得
            '----------------------------------------------------------------------
            If Not Me.CurrentRow Is Nothing Then
                RowIndex = Me.CurrentRow.Index
            End If

            '----------------------------------------------------------------------
            ' 行削除(ﾌﾚｰﾑﾜｰｸ側)
            '----------------------------------------------------------------------
            RaiseEvent RowDelete(RowIndex)

            '----------------------------------------------------------------------
            ' 行削除(ｸﾞﾘｯﾄﾞ側)
            '----------------------------------------------------------------------
            Me.Rows.RemoveAt(RowIndex)

            '----------------------------------------------------------------------
            ' ｶﾚﾝﾄ行選択
            '----------------------------------------------------------------------
            ' 最終行を削除したら、現在の最終行をｶﾚﾝﾄ行とする
            If RowIndex > Me.Rows.Count - 1 Then
                RowIndex = Me.Rows.Count - 1
            End If

            Me.CurrrentRowSelect(RowIndex)

            '----------------------------------------------------------------------
            ' 先頭項目へﾌｫｰｶｽ移動
            '----------------------------------------------------------------------
            If (Not Me.TextBoxAddTop Is Nothing) And (Me.TextBoxAddTop.Enabled) Then
                Me.TextBoxAddTop.Focus()
                Me.TextBoxAddTop.SelectAll()
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
