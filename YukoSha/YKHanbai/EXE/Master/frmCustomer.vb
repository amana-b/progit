Public Class frmCustomer
    Inherits BaseUI.BaseForm

#Region "ﾌﾚｰﾑﾜｰｸ"
    Public Frame As NodeCore.Frame.Master.Customer
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
        F10 = "台帳印字"
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
        Me.txt得意先CD.PropetyInitForm(BaseContents.Field.LockType.Key, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M得意先, Me.txt得意先CD.Name, "")
        Me.txt得意先名.PropetyInitForm(BaseContents.Field.LockType.Data, True, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txtカナ名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt郵便番号.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Post, NodeUI.Help.Type.None, "", "")
        Me.txt住所1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt住所2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txtTEL.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txtFAX.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt請求書用得意先名1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt請求書用得意先名2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt役職_担当者名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt代表者役職_代表者名1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt代表者役職_代表者名2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt自社担当者CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M担当者, Me.txt自社担当者CD.Name, Me.nam自社担当者名.Name)
        Me.txt締日.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txt重要度.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M区分_重要度, Me.txt重要度.Name, Me.nam重要度名.Name)
        Me.txt御客様NO.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txt集計用得意先CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M得意先, Me.txt集計用得意先CD.Name, Me.nam集計用得意先名.Name)
        Me.txt表示振替用得意先CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M得意先, Me.txt表示振替用得意先CD.Name, Me.nam表示振替用得意先名.Name)
        Me.txt仮伝パターンCD.PropetyInitForm(BaseContents.Field.LockType.Data, True, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M売伝パターン, Me.txt仮伝パターンCD.Name, Me.nam仮伝パターン名.Name)
        Me.txt売伝パターンCD.PropetyInitForm(BaseContents.Field.LockType.Data, True, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M売伝パターン, Me.txt売伝パターンCD.Name, Me.nam売伝パターン名.Name)
        Me.txt回収条件設定金額.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt回収条件以上回収月.PropetyInitForm(BaseContents.Field.LockType.Data, True, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txt回収条件以上回収日.PropetyInitForm(BaseContents.Field.LockType.Data, True, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txt回収条件未満回収月.PropetyInitForm(BaseContents.Field.LockType.Data, True, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txt回収条件未満回収日.PropetyInitForm(BaseContents.Field.LockType.Data, True, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")

        ' ﾈｰﾑﾎﾞｯｸｽ
        Me.nam仮伝パターン名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam自社担当者名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam集計用得意先名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam重要度名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam売伝パターン名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam表示振替用得意先名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)

        ' ﾄﾞﾛｯﾌﾟﾀﾞｳﾝ
        Me.ddl請求書発行区分.PropetyInitForm(BaseContents.Field.LockType.Data, True, NodeUI.List.Type.M区分_請求書発行区分)
        Me.ddl消費税区分.PropetyInitForm(BaseContents.Field.LockType.Data, True, NodeUI.List.Type.M区分_消費税区分)
        Me.ddl回収条件以上回収方法.PropetyInitForm(BaseContents.Field.LockType.Data, True, NodeUI.List.Type.M区分_回収方法)
        Me.ddl回収条件未満回収方法.PropetyInitForm(BaseContents.Field.LockType.Data, True, NodeUI.List.Type.M区分_回収方法)

    End Sub

    '''========================================================================================
    '''  <summary>ﾌﾚｰﾑﾜｰｸの準備</summary>
    '''========================================================================================
    Protected Overrides Sub FrameInit()
        '-------------------------------------
        ' ｺﾝｽﾄﾗｸﾀ
        '-------------------------------------
        Frame = New NodeCore.Frame.Master.Customer(Me.Security, Me.Config)

        '-------------------------------------
        ' 紐付け
        '-------------------------------------
        Frame.Fields.Header.得意先CD.Control = Me.txt得意先CD
        Frame.Fields.Header.請求書用得意先名1.Control = Me.txt請求書用得意先名1
        Frame.Fields.Header.請求書用得意先名2.Control = Me.txt請求書用得意先名2
        Frame.Fields.Header.カナ名.Control = Me.txtカナ名
        Frame.Fields.Header.郵便番号.Control = Me.txt郵便番号
        Frame.Fields.Header.住所1.Control = Me.txt住所1
        Frame.Fields.Header.住所2.Control = Me.txt住所2
        Frame.Fields.Header.TEL.Control = Me.txtTEL
        Frame.Fields.Header.役職_担当者名.Control = Me.txt役職_担当者名
        Frame.Fields.Header.代表者役職_代表者名1.Control = Me.txt代表者役職_代表者名1
        Frame.Fields.Header.自社担当者CD.Control = Me.txt自社担当者CD
        Frame.Fields.Header.仮伝パターンCD.Control = Me.txt仮伝パターンCD
        Frame.Fields.Header.売伝パターンCD.Control = Me.txt売伝パターンCD
        Frame.Fields.Header.消費税区分.Control = Me.ddl消費税区分
        Frame.Fields.Header.締日.Control = Me.txt締日
        Frame.Fields.Header.回収条件設定金額.Control = Me.txt回収条件設定金額
        Frame.Fields.Header.回収条件以上回収月.Control = Me.txt回収条件以上回収月
        Frame.Fields.Header.回収条件以上回収日.Control = Me.txt回収条件以上回収日
        Frame.Fields.Header.回収条件以上回収方法.Control = Me.ddl回収条件以上回収方法
        Frame.Fields.Header.回収条件未満回収月.Control = Me.txt回収条件未満回収月
        Frame.Fields.Header.回収条件未満回収日.Control = Me.txt回収条件未満回収日
        Frame.Fields.Header.回収条件未満回収方法.Control = Me.ddl回収条件未満回収方法
        Frame.Fields.Header.請求書発行区分.Control = Me.ddl請求書発行区分
        Frame.Fields.Header.集計用得意先CD.Control = Me.txt集計用得意先CD
        Frame.Fields.Header.表示振替用得意先CD.Control = Me.txt表示振替用得意先CD
        Frame.Fields.Header.重要度.Control = Me.txt重要度
        Frame.Fields.Header.御客様NO.Control = Me.txt御客様NO
        Frame.Fields.Header.FAX.Control = Me.txtFAX
        Frame.Fields.Header.代表者役職_代表者名2.Control = Me.txt代表者役職_代表者名2
        Frame.Fields.Header.得意先名.Control = Me.txt得意先名

        Frame.Fields.Header.処理登録.Control = Me.opt登録
        Frame.Fields.Header.処理修正.Control = Me.opt修正
        Frame.Fields.Header.処理削除.Control = Me.opt削除

        Frame.Fields.Header.自社担当者名.Control = Me.nam自社担当者名
        Frame.Fields.Header.仮伝パターン名.Control = Me.nam仮伝パターン名
        Frame.Fields.Header.売伝パターン名.Control = Me.nam売伝パターン名
        Frame.Fields.Header.集計用得意先名.Control = Me.nam集計用得意先名
        Frame.Fields.Header.表示振替用得意先名.Control = Me.nam表示振替用得意先名
        Frame.Fields.Header.重要度名.Control = Me.nam重要度名
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
    Private Sub txt得意先CD_AfterUpdate(sender As Object, e As System.EventArgs) Handles txt得意先CD.AfterUpdate
        '----------------------------------------------------------------------
        ' 該当ﾃﾞｰﾀ 読込
        '----------------------------------------------------------------------
        Frame.Clear(False)
        If Frame.Read() Then
            If Me.opt登録.Checked Then
                Me.Frame.Clear(False)
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
    ''' <summary>更新後処理</summary>
    '''========================================================================================
    Private Sub txt自社担当者CD_AfterUpdate(sender As System.Object, e As System.EventArgs) Handles txt自社担当者CD.AfterUpdate
        If Not Frame.Exist_Custom(1, Me.txt自社担当者CD.Text) Then
            MsgBox(Frame.LastError, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
            Me.txt自社担当者CD.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txt締日_AfterUpdate(sender As System.Object, e As System.EventArgs) Handles txt締日.AfterUpdate
        If Not Frame.Exist_Custom(2, Me.txt締日.Text) Then
            MsgBox(Frame.LastError, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
            Me.txt締日.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txt重要度_AfterUpdate(sender As System.Object, e As System.EventArgs) Handles txt重要度.AfterUpdate
        If Not Frame.Exist_Custom(3, Me.txt重要度.Text) Then
            MsgBox(Frame.LastError, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
            Me.txt重要度.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txt集計用得意先CD_AfterUpdate(sender As System.Object, e As System.EventArgs) Handles txt集計用得意先CD.AfterUpdate
        If Not Frame.Exist_Custom(4, Me.txt集計用得意先CD.Text) Then
            MsgBox(Frame.LastError, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
            Me.txt集計用得意先CD.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txt表示振替用得意先CD_AfterUpdate(sender As System.Object, e As System.EventArgs) Handles txt表示振替用得意先CD.AfterUpdate
        If Not Frame.Exist_Custom(4, Me.txt表示振替用得意先CD.Text) Then
            MsgBox(Frame.LastError, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
            Me.txt表示振替用得意先CD.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txt仮伝パターンCD_AfterUpdate(sender As System.Object, e As System.EventArgs) Handles txt仮伝パターンCD.AfterUpdate
        If Not Frame.Exist_Custom(5, Me.txt仮伝パターンCD.Text) Then
            MsgBox(Frame.LastError, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
            Me.txt仮伝パターンCD.Focus()
            Exit Sub
        End If

        If Me.txt仮伝パターンCD.Text <> "00" And _
           Me.txt仮伝パターンCD.Text <> "34" And _
          (Me.txt仮伝パターンCD.Text < "90" Or Me.txt仮伝パターンCD.Text > "99") Then
            MsgBox("仮伝ﾊﾟﾀｰﾝｺｰﾄﾞが00,34又は90～99の範囲ではありません", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
            Me.txt仮伝パターンCD.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txt売伝パターンCD_AfterUpdate(sender As System.Object, e As System.EventArgs) Handles txt売伝パターンCD.AfterUpdate
        If Not Frame.Exist_Custom(5, Me.txt売伝パターンCD.Text) Then
            MsgBox(Frame.LastError, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
            Me.txt売伝パターンCD.Focus()
            Exit Sub
        End If

        If Me.txt売伝パターンCD.Text = "34" Or _
          (Me.txt売伝パターンCD.Text < "00" Or Me.txt売伝パターンCD.Text > "89") Then
            MsgBox("売伝ﾊﾟﾀｰﾝｺｰﾄﾞが00～89(但し34は除く)の範囲ではありません", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
            Me.txt売伝パターンCD.Focus()
            Exit Sub
        End If
    End Sub

    '''========================================================================================
    ''' <summary>ﾌｫｰｶｽ消失時</summary>
    '''========================================================================================
    Private Sub txt重要度_LostFocus(sender As Object, e As System.EventArgs) Handles txt重要度.LostFocus
        If Me.txt重要度.Text = "" Then
            Me.txt重要度.Text = NodeContents.Constant.CodeValue.重要度.ランクなし
            Me.nam重要度名.Text = (New NodeUI.Help.Names).Execute(Me.txt重要度.HelpType, Me.txt重要度.Text)
        End If
    End Sub

    '''========================================================================================
    ''' <summary>詳細情報ｵｰﾌﾟﾝ</summary>
    '''========================================================================================
    Private Sub btn詳細情報_Click(sender As System.Object, e As System.EventArgs) Handles btn詳細情報.Click
        Dim frm As New frmCustomerDetail()
        frm.ShowDialog(Me)
    End Sub
#End Region

#Region "ﾌｧﾝｸｼｮﾝ"
#Region "検索"
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
#End Region

#Region "印刷"
    '''========================================================================================
    '''  <summary>印刷</summary>
    '''========================================================================================
    Protected Overrides Sub btnF10_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF10_Click(sender, e)

        '----------------------------------------------------------------------
        ' ﾀﾞｲｱﾛｸﾞｵｰﾌﾟﾝ
        '----------------------------------------------------------------------
        Dim frm As New frmCustomerPrint()
        frm.ShowDialog(Me)
    End Sub
#End Region

#Region "確定"
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
#End Region
End Class
