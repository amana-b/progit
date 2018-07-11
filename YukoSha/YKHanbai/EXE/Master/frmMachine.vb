Public Class frmMachine
    Inherits BaseUI.BaseForm

#Region "ﾌﾚｰﾑﾜｰｸ"
    Private Frame As NodeCore.Frame.Master.Machine
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
        Me.txt機械CD.PropetyInitForm(BaseContents.Field.LockType.Key, True, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M機械, Me.txt機械CD.Name, "")
        Me.txt機械名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt分類コード.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt担当者コード.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M担当者, Me.txt担当者コード.Name, Me.nam担当者名.Name)
        Me.txt固定経費平圧条件.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt固定経費平圧金額.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt固定経費平圧条件外一通あたり金額.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt固定経費輪転条件.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt固定経費輪転金額.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt固定経費輪転条件外一通あたり金額.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txtコーター日数.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Number, NodeUI.Help.Type.None, "", "")
        Me.txtコーター回転数.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")

        ' ﾈｰﾑﾎﾞｯｸｽ
        Me.nam担当者名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)

        ' ﾄﾞﾛｯﾌﾟﾀﾞｳﾝ
        Me.ddl機械区分.PropetyInitForm(BaseContents.Field.LockType.Data, True, NodeUI.List.Type.M区分_機械区分)
        Me.ddl機械種別.PropetyInitForm(BaseContents.Field.LockType.Data, True, NodeUI.List.Type.M区分_機械種別区分)

    End Sub

    '''========================================================================================
    '''  <summary>ﾌﾚｰﾑﾜｰｸの準備</summary>
    '''========================================================================================
    Protected Overrides Sub FrameInit()
        '-------------------------------------
        ' ｺﾝｽﾄﾗｸﾀ
        '-------------------------------------
        Frame = New NodeCore.Frame.Master.Machine(Me.Security, Me.Config)

        '-------------------------------------
        ' 紐付け
        '-------------------------------------
        Frame.Fields.Header.機械CD.Control = Me.txt機械CD
        Frame.Fields.Header.機械名.Control = Me.txt機械名
        Frame.Fields.Header.固定経費平圧金額.Control = Me.txt固定経費平圧金額
        Frame.Fields.Header.固定経費平圧条件外一通あたり金額.Control = Me.txt固定経費平圧条件外一通あたり金額
        Frame.Fields.Header.機械区分.Control = Me.ddl機械区分
        Frame.Fields.Header.担当者CD.Control = Me.txt担当者コード
        Frame.Fields.Header.コーター回転数.Control = Me.txtコーター回転数
        Frame.Fields.Header.コーター日数.Control = Me.txtコーター日数
        Frame.Fields.Header.分類CD.Control = Me.txt分類コード
        Frame.Fields.Header.機械種別区分.Control = Me.ddl機械種別
        Frame.Fields.Header.固定経費平圧条件.Control = Me.txt固定経費平圧条件
        Frame.Fields.Header.固定経費輪転条件.Control = Me.txt固定経費輪転条件
        Frame.Fields.Header.固定経費輪転金額.Control = Me.txt固定経費輪転金額
        Frame.Fields.Header.固定経費輪転条件外一通あたり金額.Control = Me.txt固定経費輪転条件外一通あたり金額
        Frame.Fields.Header.担当者名.Control = Me.nam担当者名

        Frame.Fields.Header.処理登録.Control = Me.opt登録
        Frame.Fields.Header.処理修正.Control = Me.opt修正
        Frame.Fields.Header.処理削除.Control = Me.opt削除
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
    Private Sub opt処理区分_AfterUpdate(sender As Object, e As System.EventArgs) Handles opt登録.AfterUpdate, opt修正.AfterUpdate, opt削除.AfterUpdate
        '----------------------------------------------------------------------
        ' 画面ｸﾘｱ
        '----------------------------------------------------------------------
        Frame.Clear(False)

        '----------------------------------------------------------------------
        ' ｷｰ部入力制御
        '----------------------------------------------------------------------
        Me.FormEnableKey()
    End Sub

    '''========================================================================================
    ''' <summary>ｷｰ変更</summary>
    '''========================================================================================
    Private Sub txt機械CD_AfterUpdate(sender As Object, e As System.EventArgs) Handles txt機械CD.AfterUpdate
        '----------------------------------------------------------------------
        ' 得意先 存在確認
        '----------------------------------------------------------------------
        If Not Frame.Exist() Then
            MsgBox("機械マスタに存在しません。", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
            Me.txt機械CD.Focus()
            Exit Sub
        End If

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
                Me.FormEnableKey()
                MsgBox("マスタに登録がありません", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
                Exit Sub
            End If
        End If

        '----------------------------------------------------------------------
        ' ﾃｷｽﾄﾎﾞｯｸｽ 書式適用
        '----------------------------------------------------------------------
        Me.TextBoxFormat()

        '----------------------------------------------------------------------
        ' ﾃﾞｰﾀ部入力制御
        '----------------------------------------------------------------------
        Me.FormEnableData()
    End Sub

    '''========================================================================================
    ''' <summary>固定経費入力制御</summary>
    '''========================================================================================
    Private Sub ddl機械種別_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ddl機械種別.KeyDown
        ' 「機械種別区分」上でEnterｷｰが押下された場合のみ、固定経費の入力制御を行う
        If e.KeyCode = System.Windows.Forms.Keys.Return Then
            If Me.ddl機械種別.SelectedValue = NodeContents.Constant.CodeValue.機械種別区分.平圧機 Then
                Me.grp固定経費算出条件平圧.Enabled = True
                Me.grp固定経費算出条件輪転.Enabled = False
                Me.txt固定経費平圧条件.Focus()
            Else
                Me.grp固定経費算出条件平圧.Enabled = False
                Me.grp固定経費算出条件輪転.Enabled = True
                Me.txt固定経費輪転条件.Focus()
            End If
        End If
    End Sub
#End Region

#Region "ﾌｧﾝｸｼｮﾝ"
    '''========================================================================================
    '''  <summary>検索</summary>
    '''========================================================================================
    Protected Overrides Sub btnF07_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF07_Click(sender, e)

        '----------------------------------------------------------------------
        ' ﾀﾞｲｱﾛｸﾞｵｰﾌﾟﾝ
        '----------------------------------------------------------------------
        Dialog.Common.Open(Me)
    End Sub

    '''========================================================================================
    '''  <summary>確定</summary>
    '''========================================================================================
    Protected Overrides Sub btnF12_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF12_Click(sender, e)

        '----------------------------------------------------------------------
        ' 実行
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
