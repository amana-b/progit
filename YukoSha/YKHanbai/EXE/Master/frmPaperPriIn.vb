Public Class frmPaperPriIn
    Inherits BaseUI.BaseForm

#Region "ﾌﾚｰﾑﾜｰｸ"
    Private Frame As NodeCore.Frame.Master.PaperPriIn
#End Region

#Region "定型準備"
    '''========================================================================================
    '''  <summary>準備(ﾌｧﾝｸｼｮﾝ)</summary>
    ''' <param name="F01">F01ﾎﾞﾀﾝ名</param>
    ''' <param name="F02">F02ﾎﾞﾀﾝ名</param>
    ''' <param name="F03">F03ﾎﾞﾀﾝ名</param>
    ''' <param name="F04">F04ﾎﾞﾀﾝ名</param>
    ''' <param name="F05">F05ﾎﾞﾀﾝ名</param>
    ''' <param name="F06">F06ﾎﾞﾀﾝ名</param>
    ''' <param name="F07">F07ﾎﾞﾀﾝ名</param>
    ''' <param name="F08">F08ﾎﾞﾀﾝ名</param>
    ''' <param name="F09">F09ﾎﾞﾀﾝ名</param>
    ''' <param name="F10">F10ﾎﾞﾀﾝ名</param>
    ''' <param name="F11">F11ﾎﾞﾀﾝ名</param>
    ''' <param name="F12">F12ﾎﾞﾀﾝ名</param>
    '''========================================================================================
    Protected Overrides Sub FuncInitialize(ByRef ESC As String, ByRef F01 As String, ByRef F02 As String, ByRef F03 As String, ByRef F04 As String, ByRef F05 As String, ByRef F06 As String, ByRef F07 As String, ByRef F08 As String, ByRef F09 As String, ByRef F10 As String, ByRef F11 As String, ByRef F12 As String)
        F07 = "検索"
        F12 = "確定"

    End Sub

    '''========================================================================================
    '''  <summary>NodeDabataseの接続文字列の書き換え</summary>
    '''========================================================================================
    Protected Overrides Sub Provider()
        Dim Provider As New NodeDatabase.Provider           ' 接続文字列の書き換えを行っている
        Provider.ConnectionStringBase = System.Configuration.ConfigurationManager.AppSettings("ConnectionStringBase")
    End Sub

    '''========================================================================================
    '''  <summary>ｺﾝﾄﾛｰﾙの準備</summary>
    '''========================================================================================
    Protected Overrides Sub ControlInit()
        '----------------------------------------------------------------------
        ' ｶｽﾀﾑ定義
        '----------------------------------------------------------------------
        ' ﾗｼﾞｵﾎﾞﾀﾝ
        Me.opt登録.PropetyInitForm(BaseContents.Field.LockType.None)
        Me.opt修正.PropetyInitForm(BaseContents.Field.LockType.None)
        Me.opt削除.PropetyInitForm(BaseContents.Field.LockType.None)

        ' ﾃｷｽﾄﾎﾞｯｸｽ
        Me.txt仕入先CD.PropetyInitForm(BaseContents.Field.LockType.Key, True, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M仕入先, Me.txt仕入先CD.Name, Me.nam仕入先名.Name)
        Me.txt社内用紙CD.PropetyInitForm(BaseContents.Field.LockType.Key, True, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M紙, Me.txt社内用紙CD.Name, Me.nam社内用紙名.Name)
        Me.txt社内用糊CD.PropetyInitForm(BaseContents.Field.LockType.Key, True, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M糊, Me.txt社内用糊CD.Name, Me.nam社内用糊名.Name)
        Me.txt社内用台紙CD.PropetyInitForm(BaseContents.Field.LockType.Key, True, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M台紙, Me.txt社内用台紙CD.Name, Me.nam社内用台紙名.Name)
        Me.txt発注用紙CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M紙, Me.txt発注用紙CD.Name, Me.nam発注用紙名.Name)
        Me.txt発注用糊CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M糊, Me.txt発注用糊CD.Name, Me.nam発注用糊名.Name)
        Me.txt発注用台紙CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M台紙, Me.txt発注用台紙CD.Name, Me.nam発注用台紙名.Name)
        Me.txt社内単価.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt発注単価.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")

        ' ﾈｰﾑﾎﾞｯｸｽ
        Me.nam仕入先名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam社内用紙名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam社内用糊名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam社内用台紙名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam発注用紙名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam発注用糊名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam発注用台紙名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)

        ' ﾄﾞﾛｯﾌﾟﾀﾞｳﾝ
        Me.ddl単価区分.PropetyInitForm(BaseContents.Field.LockType.Data, True, NodeUI.List.Type.M区分_単価区分)

    End Sub

    '''========================================================================================
    '''  <summary>ﾌﾚｰﾑﾜｰｸの準備</summary>
    '''========================================================================================
    Protected Overrides Sub FrameInit()
        '-------------------------------------
        ' ｺﾝｽﾄﾗｸﾀ
        '-------------------------------------
        Frame = New NodeCore.Frame.Master.PaperPriIn(Me.Security, Me.Config)

        '-------------------------------------
        ' 紐付け
        '-------------------------------------
        Frame.Fields.Header.仕入先CD.Control = Me.txt仕入先CD
        Frame.Fields.Header.社内用紙CD.Control = Me.txt社内用紙CD
        Frame.Fields.Header.社内用糊CD.Control = Me.txt社内用糊CD
        Frame.Fields.Header.社内用台紙CD.Control = Me.txt社内用台紙CD
        Frame.Fields.Header.単位区分.Control = Me.ddl単価区分

        Frame.Fields.Header.発注用紙CD.Control = Me.txt発注用紙CD
        Frame.Fields.Header.発注用糊CD.Control = Me.txt発注用糊CD
        Frame.Fields.Header.発注用台紙CD.Control = Me.txt発注用台紙CD
        Frame.Fields.Header.社内単価.Control = Me.txt社内単価
        Frame.Fields.Header.発注単価.Control = Me.txt発注単価

        Frame.Fields.Header.処理登録.Control = Me.opt登録
        Frame.Fields.Header.処理修正.Control = Me.opt修正
        Frame.Fields.Header.処理削除.Control = Me.opt削除

        Frame.Fields.Header.仕入先名.Control = Me.nam仕入先名
        Frame.Fields.Header.社内用紙名.Control = Me.nam社内用紙名
        Frame.Fields.Header.社内用糊名.Control = Me.nam社内用糊名
        Frame.Fields.Header.社内用台紙名.Control = Me.nam社内用台紙名
        Frame.Fields.Header.発注用紙名.Control = Me.nam発注用紙名
        Frame.Fields.Header.発注用糊名.Control = Me.nam発注用糊名
        Frame.Fields.Header.発注用台紙名.Control = Me.nam発注用台紙名
    End Sub
#End Region

#Region "ﾍﾟｰｼﾞｲﾍﾞﾝﾄ"
    '''========================================================================================
    '''  <summary>ﾍﾟｰｼﾞﾛｰﾄﾞ</summary>
    '''========================================================================================
    Private Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        '----------------------------------------------------------------------
        ' 画面ｸﾘｱ
        '----------------------------------------------------------------------
        Frame.Clear()

        '----------------------------------------------------------------------
        ' ｷｰ部入力制御
        '----------------------------------------------------------------------
        Me.FormEnableKey()
    End Sub
#End Region

#Region "ﾕｰｻﾞｲﾍﾞﾝﾄ"

    '''========================================================================================
    '''  <summary>処理区分変更</summary>
    '''========================================================================================
    Private Sub opt処理区分_AfterUpdate(sender As Object, e As System.EventArgs) Handles opt削除.AfterUpdate, opt登録.AfterUpdate, opt修正.AfterUpdate
        '----------------------------------------------------------------------
        ' 画面ｸﾘｱ
        '----------------------------------------------------------------------
        Frame.Clear(False)

        '----------------------------------------------------------------------
        ' ｷｰ部入力制御
        '----------------------------------------------------------------------
        Me.FormEnableKey()

    End Sub

    ' '''========================================================================================
    ' '''  <summary>処理区分変更</summary>
    ' '''========================================================================================
    'Private Sub opt修正_AfterUpdate(sender As Object, e As System.EventArgs) Handles opt修正.AfterUpdate
    '    '----------------------------------------------------------------------
    '    ' 画面読み込み
    '    '----------------------------------------------------------------------
    '    Frame.Read()

    '    '----------------------------------------------------------------------
    '    ' ｷｰ部入力制御
    '    '----------------------------------------------------------------------
    '    Me.FormEnableKey()

    'End Sub

    '''========================================================================================
    ''' <summary>ｷｰ変更</summary>
    '''========================================================================================
    Private Sub ddl単価区分_AfterUpdate(sender As Object, e As System.EventArgs) Handles ddl単価区分.AfterUpdate
        '----------------------------------------------------------------------
        ' 該当ﾃﾞｰﾀ 読込
        '----------------------------------------------------------------------
        If Frame.Read() Then
            If Me.opt登録.Checked Then
                Me.FormEnableKey()
                MsgBox("既にマスタに登録済みです", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
                Exit Sub
            End If
        Else
            If Me.opt修正.Checked Or Me.opt削除.Checked Then
                If ddl単価区分.Text = "" Then
                    Exit Sub
                End If
                'If Frame.Exist() Then
                '    MsgBox("マスタに存在しません。", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
                '    Exit Sub
                'End If

                Me.FormEnableKey()
                MsgBox("マスタに登録がありません", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
                Exit Sub
            End If
        End If

        '----------------------------------------------------------------------
        ' ﾃﾞｰﾀ部入力制御
        '----------------------------------------------------------------------
        Me.FormEnableData()
    End Sub

    ' '''========================================================================================
    ' ''' <summary>ｷｰ変更_ﾏｽﾀﾁｪｯｸ</summary>
    ' '''========================================================================================
    'Private Sub txt仕入先_AfterUpdate(sender As Object, e As System.EventArgs) Handles txt仕入先CD.AfterUpdate
    '    If txt仕入先CD.Text <> "" Then
    '        If Frame.Mcheck仕入れ(txt仕入先CD.Text) = False Then
    '            Me.txt仕入先CD.Focus()
    '        End If
    '    End If
    'End Sub

    'Private Sub txt紙_AfterUpdate(sender As Object, e As System.EventArgs) Handles txt社内用紙CD.AfterUpdate, txt発注用紙CD.AfterUpdate
    '    If txt社内用紙CD.Text <> "" Then
    '        If Frame.Mcheck紙(txt社内用紙CD.Text) = False Then
    '            Me.txt社内用紙CD.Focus()
    '        End If
    '    End If

    '    If txt発注用紙CD.Text <> "" Then
    '        If Frame.Mcheck紙(txt発注用紙CD.Text) = False Then
    '            Me.txt発注用紙CD.Focus()
    '        End If
    '    End If
    'End Sub

    'Private Sub txt糊_AfterUpdate(sender As Object, e As System.EventArgs) Handles txt社内用糊CD.AfterUpdate, txt発注用糊CD.AfterUpdate
    '    If txt社内用糊CD.Text <> "" Then
    '        If Frame.Mcheck糊(txt社内用糊CD.Text) = False Then
    '            Me.txt社内用糊CD.Focus()
    '        End If
    '    End If

    '    If txt発注用糊CD.Text <> "" Then
    '        If Frame.Mcheck糊(txt発注用糊CD.Text) = False Then
    '            Me.txt発注用糊CD.Focus()
    '        End If
    '    End If
    'End Sub

    'Private Sub txt台紙_AfterUpdate(sender As Object, e As System.EventArgs) Handles txt社内用台紙CD.AfterUpdate, txt発注用台紙CD.AfterUpdate
    '    If txt社内用台紙CD.Text <> "" Then
    '        If Frame.Mcheck台紙(txt社内用台紙CD.Text) = False Then
    '            Me.txt社内用台紙CD.Focus()
    '        End If
    '    End If

    '    If txt発注用台紙CD.Text <> "" Then
    '        If Frame.Mcheck台紙(txt発注用台紙CD.Text) = False Then
    '            Me.txt発注用台紙CD.Focus()
    '        End If
    '    End If
    'End Sub

#End Region

#Region "ﾌｧﾝｸｼｮﾝ"
    '''========================================================================================
    '''  <summary>検索</summary>
    '''========================================================================================
    Protected Overrides Sub btnF07_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        '  ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF07_Click(sender, e)

        '----------------------------------------------------------------------
        '  ﾀﾞｲｱﾛｸﾞｵｰﾌﾟﾝ
        '----------------------------------------------------------------------
        Dialog.Common.Open(Me)
    End Sub

    '''========================================================================================
    '''  <summary>確定</summary>
    '''========================================================================================
    Protected Overrides Sub btnF12_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        '  ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF12_Click(sender, e)

        '----------------------------------------------------------------------
        '  ﾒｯｾｰｼﾞ
        '----------------------------------------------------------------------
        If Me.txt社内単価.Text < Me.txt発注単価.Text Then
            MessageBox.Show("発注単価が、社内単価を上回っています。", "警告", MessageBoxButtons.OK)
        End If

        '----------------------------------------------------------------------
        '  実行
        '----------------------------------------------------------------------
        Select Case True
            Case Me.opt登録.Checked Or Me.opt修正.Checked
                '-------------------------------------
                ' 保存
                '-------------------------------------
                ' 検査
                Select Case Frame.Valid_Write
                    Case NodeContents.ActionButton.ErrorLevel.Warning
                        CType(Frame.ControlError, System.Windows.Forms.Control).Focus()
                        If MsgBox(Frame.LastError, MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "警告") = MsgBoxResult.Cancel Then
                            Exit Sub
                        End If

                    Case NodeContents.ActionButton.ErrorLevel.Fatal
                        CType(Frame.ControlError, System.Windows.Forms.Control).Focus()
                        MsgBox(Frame.LastError, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
                        Exit Sub
                End Select

                ' 確認
                Select Case True
                    Case Me.opt登録.Checked
                        If MsgBox("登録しますか？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "確認") = MsgBoxResult.No Then
                            Exit Sub
                        End If
                    Case Me.opt修正.Checked
                        If MsgBox("修正しますか？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "確認") = MsgBoxResult.No Then
                            Exit Sub
                        End If
                End Select

                ' 実行
                Frame.Write()

            Case Me.opt削除.Checked
                '-------------------------------------
                ' 削除
                '-------------------------------------
                ' 検査
                Select Case Frame.Valid_Delete
                    Case NodeContents.ActionButton.ErrorLevel.Warning
                        CType(Frame.ControlError, System.Windows.Forms.Control).Focus()
                        If MsgBox(Frame.LastError, MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "警告") = MsgBoxResult.Cancel Then
                            Exit Sub
                        End If

                    Case NodeContents.ActionButton.ErrorLevel.Fatal
                        CType(Frame.ControlError, System.Windows.Forms.Control).Focus()
                        MsgBox(Frame.LastError, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
                        Exit Sub
                End Select

                ' 確認
                If MsgBox("削除しますか？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "確認") = MsgBoxResult.No Then
                    Exit Sub
                End If

                ' 実行
                Frame.Delete()
        End Select

        '-------------------------------------
        ' 画面ｸﾘｱ
        '-------------------------------------
        Frame.Clear()

        '-------------------------------------
        ' ｷｰ部入力制御
        '-------------------------------------
        Me.FormEnableKey()
    End Sub
#End Region

End Class
