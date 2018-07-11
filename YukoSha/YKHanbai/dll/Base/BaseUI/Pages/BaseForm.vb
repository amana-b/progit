Public Class BaseForm
#Region "共通変数"
    Public Config As NodeCore.Common.Config
    Public Security As NodeCore.Common.Security

    Public CloseMessage As Boolean = True

    Public CurrentControl As System.Windows.Forms.Control
    Public CurrentTextBox As BaseUI.Control.TextBox
#End Region

#Region "ｲﾍﾞﾝﾄ定義"
    '''========================================================================================
    '''  <summary>NodeDabataseの接続文字列の書き換え</summary>
    '''========================================================================================
    Protected Overridable Sub Provider()
    End Sub

    '''========================================================================================
    '''  <summary>ｺﾝﾄﾛｰﾙの準備</summary>
    '''========================================================================================
    Protected Overridable Sub ControlInit()
    End Sub

    '''========================================================================================
    '''  <summary>ﾌﾚｰﾑﾜｰｸの準備</summary>
    '''========================================================================================
    Protected Overridable Sub FrameInit()
    End Sub

    '''========================================================================================
    '''  <summary>準備(ﾌｧﾝｸｼｮﾝ)</summary>
    ''' <param name="ESC">ESCﾎﾞﾀﾝ名</param>
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
    Protected Overridable Sub FuncInitialize(ByRef ESC As String _
                                           , ByRef F01 As String _
                                           , ByRef F02 As String _
                                           , ByRef F03 As String _
                                           , ByRef F04 As String _
                                           , ByRef F05 As String _
                                           , ByRef F06 As String _
                                           , ByRef F07 As String _
                                           , ByRef F08 As String _
                                           , ByRef F09 As String _
                                           , ByRef F10 As String _
                                           , ByRef F11 As String _
                                           , ByRef F12 As String _
                                            )
    End Sub
#End Region

#Region "ｲﾍﾞﾝﾄﾍﾟｰｼﾞ"
    '''========================================================================================
    '''  <summary>ﾍﾟｰｼﾞ開始(Load)</summary>
    '''========================================================================================
    Protected Overrides Sub OnLoad(e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ｳｨﾝﾄﾞｳｻｲｽﾞ 固定
        '----------------------------------------------------------------------
        Me.Size = New System.Drawing.Size(1024, 768)

        '----------------------------------------------------------------------
        ' ﾎﾞﾀﾝ位置をｻｲｽﾞに合わせる
        '----------------------------------------------------------------------
        Me.grpFunc.Dock = System.Windows.Forms.DockStyle.Bottom

        '----------------------------------------------------------------------
        ' ｷｰﾎﾞｰﾄﾞｲﾍﾞﾝﾄ を発生させる
        '----------------------------------------------------------------------
        Me.KeyPreview = True

        '----------------------------------------------------------------------
        ' ｻｲｽﾞ変更不可の直線ｳｨﾝﾄﾞｳに変更する
        '----------------------------------------------------------------------
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle

        '----------------------------------------------------------------------
        ' ｳｨﾝﾄﾞｳ位置
        '----------------------------------------------------------------------
        Me.Location = New System.Drawing.Point(0, 0)

        '----------------------------------------------------------------------
        ' NodeDabataseの接続文字列の書き換え
        '----------------------------------------------------------------------
        Me.Provider()

        '----------------------------------------------------------------------
        ' 環境情報 設定
        '----------------------------------------------------------------------
        ' Config
        Me.Config = New NodeCore.Common.Config

        ' Security
        Me.Security = New NodeCore.Common.Security

        ' CurrentTextBox
        Me.CurrentTextBox = New BaseUI.Control.TextBox
        Me.CurrentTextBox = Nothing

        ' ｸﾗｲｱﾝﾄ IPｱﾄﾞﾚｽ 設定
        Dim arrIPAddr() As System.Net.IPAddress = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName())
        For Each ip As System.Net.IPAddress In arrIPAddr
            If ip.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                Me.Security.IPAddr = ip.ToString
                Exit For
            End If
        Next

        '----------------------------------------------------------------------
        ' ESCｷｰ
        '----------------------------------------------------------------------
        Me.btnESC.Text = "閉じる"

        '----------------------------------------------------------------------
        ' 共通ｲﾍﾞﾝﾄ 呼出
        '----------------------------------------------------------------------
        Me.FuncInitialize(Me.btnESC.Text _
                        , Me.btnF01.Text _
                        , Me.btnF02.Text _
                        , Me.btnF03.Text _
                        , Me.btnF04.Text _
                        , Me.btnF05.Text _
                        , Me.btnF06.Text _
                        , Me.btnF07.Text _
                        , Me.btnF08.Text _
                        , Me.btnF09.Text _
                        , Me.btnF10.Text _
                        , Me.btnF11.Text _
                        , Me.btnF12.Text _
                         )

        Me.btnESC.Enabled = True
        Me.btnF01.Enabled = True
        Me.btnF02.Enabled = True
        Me.btnF03.Enabled = True
        Me.btnF04.Enabled = True
        Me.btnF05.Enabled = True
        Me.btnF06.Enabled = True
        Me.btnF07.Enabled = True
        Me.btnF08.Enabled = True
        Me.btnF09.Enabled = True
        Me.btnF10.Enabled = True
        Me.btnF11.Enabled = True
        Me.btnF12.Enabled = True

        If Me.btnESC.Text = "" Then Me.btnESC.Enabled = False
        If Me.btnF01.Text = "" Then Me.btnF01.Enabled = False
        If Me.btnF02.Text = "" Then Me.btnF02.Enabled = False
        If Me.btnF03.Text = "" Then Me.btnF03.Enabled = False
        If Me.btnF04.Text = "" Then Me.btnF04.Enabled = False
        If Me.btnF05.Text = "" Then Me.btnF05.Enabled = False
        If Me.btnF06.Text = "" Then Me.btnF06.Enabled = False
        If Me.btnF07.Text = "" Then Me.btnF07.Enabled = False
        If Me.btnF08.Text = "" Then Me.btnF08.Enabled = False
        If Me.btnF09.Text = "" Then Me.btnF09.Enabled = False
        If Me.btnF10.Text = "" Then Me.btnF10.Enabled = False
        If Me.btnF11.Text = "" Then Me.btnF11.Enabled = False
        If Me.btnF12.Text = "" Then Me.btnF12.Enabled = False

        '----------------------------------------------------------------------
        ' ｺﾝﾄﾛｰﾙの準備
        '----------------------------------------------------------------------
        Me.ControlInit()

        '----------------------------------------------------------------------
        ' ﾌﾚｰﾑﾜｰｸの準備
        '----------------------------------------------------------------------
        Me.FrameInit()

        '----------------------------------------------------------------------
        ' ｺﾝﾎﾞﾘｽﾄ設定
        '----------------------------------------------------------------------
        Me.ComboListSource(Me)

        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.OnLoad(e)
    End Sub

    '''========================================================================================
    '''  <summary>ﾍﾟｰｼﾞ終了(Closing)</summary>
    '''========================================================================================
    Protected Overrides Sub OnClosing(e As System.ComponentModel.CancelEventArgs)
        If CloseMessage Then
            If MsgBox(Me.Text & "を終了しますか？" & vbCrLf & "※現在編集中の内容は登録されません", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "プログラム終了確認") = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If

        MyBase.OnClosing(e)
    End Sub

    '''========================================================================================
    '''  <summary>ｷｰ押下</summary>
    '''========================================================================================
    Protected Overrides Sub OnKeyDown(e As System.Windows.Forms.KeyEventArgs)
        '----------------------------------------------------------------------
        '  ﾌｧﾝｸｼｮﾝｷｰ制御
        '----------------------------------------------------------------------
        Select Case e.KeyData
            Case System.Windows.Forms.Keys.Escape : Me.btnESC.PerformClick()
            Case System.Windows.Forms.Keys.F1 : Me.btnF01.PerformClick()
            Case System.Windows.Forms.Keys.F2 : Me.btnF02.PerformClick()
            Case System.Windows.Forms.Keys.F3 : Me.btnF03.PerformClick()
            Case System.Windows.Forms.Keys.F4 : Me.btnF04.PerformClick()
            Case System.Windows.Forms.Keys.F5 : Me.btnF05.PerformClick()
            Case System.Windows.Forms.Keys.F6 : Me.btnF06.PerformClick()
            Case System.Windows.Forms.Keys.F7 : Me.btnF07.PerformClick()
            Case System.Windows.Forms.Keys.F8 : Me.btnF08.PerformClick()
            Case System.Windows.Forms.Keys.F9 : Me.btnF09.PerformClick()
            Case System.Windows.Forms.Keys.F10 : Me.btnF10.PerformClick()
            Case System.Windows.Forms.Keys.F11 : Me.btnF11.PerformClick()
            Case System.Windows.Forms.Keys.F12 : Me.btnF12.PerformClick()
        End Select

        '----------------------------------------------------------------------
        '  Enterｷｰは次項目へ
        '----------------------------------------------------------------------
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            If e.Control = False Then
                Me.SelectNextControl(Me.ActiveControl, Not e.Shift, True, True, True)
            End If
        End If

        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.OnKeyDown(e)
    End Sub

    '''========================================================================================
    '''  <summary>ﾌｫｰｶｽ変更 ｲﾍﾞﾝﾄ</summary>
    '''========================================================================================
    Protected Overrides Sub UpdateDefaultButton()
        Select Case Me.ActiveControl.Name
            Case Me.btnF01.Name, Me.btnF02.Name, Me.btnF03.Name, Me.btnF04.Name, Me.btnF05.Name, Me.btnF06.Name _
               , Me.btnF07.Name, Me.btnF08.Name, Me.btnF09.Name, Me.btnF10.Name, Me.btnF11.Name, Me.btnF12.Name _
               , Me.btnESC.Name

            Case Else
                '----------------------------------------------------------------------
                '  ｶﾚﾝﾄｺﾝﾄﾛｰﾙの保存(ﾌｧﾝｸｼｮﾝﾎﾞﾀﾝ以外)
                '----------------------------------------------------------------------
                Me.CurrentControl = Me.ActiveControl

                '----------------------------------------------------------------------
                '  ｶﾚﾝﾄﾃｷｽﾄﾎﾞｯｸｽの保存
                '----------------------------------------------------------------------
                If BaseUI.Control.Tool.ControlType(Me.ActiveControl) = BaseContents.Field.ControlType.TextBox Then
                    Me.CurrentTextBox = Me.ActiveControl
                End If

                '----------------------------------------------------------------------
                '  ｶﾚﾝﾄがﾃｷｽﾄﾎﾞｯｸｽならﾍﾙﾌﾟﾀｲﾌﾟの設定に応じ、検索ﾎﾞﾀﾝを[有効/無効]に切り替える
                '----------------------------------------------------------------------
                If BaseUI.Control.Tool.ControlType(Me.ActiveControl) = BaseContents.Field.ControlType.TextBox Then
                    If CType(Me.ActiveControl, BaseUI.Control.TextBox).HelpType = NodeUI.Help.Type.None Then
                        If Me.btnF01.Text = "検索" Then Me.btnF01.Enabled = False
                        If Me.btnF02.Text = "検索" Then Me.btnF02.Enabled = False
                        If Me.btnF03.Text = "検索" Then Me.btnF03.Enabled = False
                        If Me.btnF04.Text = "検索" Then Me.btnF04.Enabled = False
                        If Me.btnF05.Text = "検索" Then Me.btnF05.Enabled = False
                        If Me.btnF06.Text = "検索" Then Me.btnF06.Enabled = False
                        If Me.btnF07.Text = "検索" Then Me.btnF07.Enabled = False
                        If Me.btnF08.Text = "検索" Then Me.btnF08.Enabled = False
                        If Me.btnF09.Text = "検索" Then Me.btnF09.Enabled = False
                        If Me.btnF10.Text = "検索" Then Me.btnF10.Enabled = False
                        If Me.btnF11.Text = "検索" Then Me.btnF11.Enabled = False
                        If Me.btnF12.Text = "検索" Then Me.btnF12.Enabled = False
                    Else
                        If Me.btnF01.Text = "検索" Then Me.btnF01.Enabled = True
                        If Me.btnF02.Text = "検索" Then Me.btnF02.Enabled = True
                        If Me.btnF03.Text = "検索" Then Me.btnF03.Enabled = True
                        If Me.btnF04.Text = "検索" Then Me.btnF04.Enabled = True
                        If Me.btnF05.Text = "検索" Then Me.btnF05.Enabled = True
                        If Me.btnF06.Text = "検索" Then Me.btnF06.Enabled = True
                        If Me.btnF07.Text = "検索" Then Me.btnF07.Enabled = True
                        If Me.btnF08.Text = "検索" Then Me.btnF08.Enabled = True
                        If Me.btnF09.Text = "検索" Then Me.btnF09.Enabled = True
                        If Me.btnF10.Text = "検索" Then Me.btnF10.Enabled = True
                        If Me.btnF11.Text = "検索" Then Me.btnF11.Enabled = True
                        If Me.btnF12.Text = "検索" Then Me.btnF12.Enabled = True
                    End If
                Else
                    If Me.btnF01.Text = "検索" Then Me.btnF01.Enabled = False
                    If Me.btnF02.Text = "検索" Then Me.btnF02.Enabled = False
                    If Me.btnF03.Text = "検索" Then Me.btnF03.Enabled = False
                    If Me.btnF04.Text = "検索" Then Me.btnF04.Enabled = False
                    If Me.btnF05.Text = "検索" Then Me.btnF05.Enabled = False
                    If Me.btnF06.Text = "検索" Then Me.btnF06.Enabled = False
                    If Me.btnF07.Text = "検索" Then Me.btnF07.Enabled = False
                    If Me.btnF08.Text = "検索" Then Me.btnF08.Enabled = False
                    If Me.btnF09.Text = "検索" Then Me.btnF09.Enabled = False
                    If Me.btnF10.Text = "検索" Then Me.btnF10.Enabled = False
                    If Me.btnF11.Text = "検索" Then Me.btnF11.Enabled = False
                    If Me.btnF12.Text = "検索" Then Me.btnF12.Enabled = False
                End If
        End Select

        '----------------------------------------------------------------------
        '  ﾍﾞｰｽ処理実行
        '----------------------------------------------------------------------
        MyBase.UpdateDefaultButton()
    End Sub
#End Region

#Region "ﾒｿｯﾄﾞ"
    '''========================================================================================
    '''  <summary>次項目へ</summary>
    '''========================================================================================
    Public Sub NextControl()
        Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
    End Sub
#End Region

#Region "ｲﾍﾞﾝﾄ発生(ﾌｧﾝｸｼｮﾝ)"
    '''========================================================================================
    '''  <summary>ﾌｧﾝｸｼｮﾝﾎﾞﾀﾝへﾌｫｰｶｽが移ってきたら即時に元のｺﾝﾄﾛｰﾙへ戻す</summary>
    '''========================================================================================
    Private Sub btnFxxEnter(sender As Object, e As System.EventArgs) Handles btnESC.Enter _
                                                                           , btnF01.Enter, btnF02.Enter, btnF03.Enter, btnF04.Enter _
                                                                           , btnF05.Enter, btnF06.Enter, btnF07.Enter, btnF08.Enter _
                                                                           , btnF09.Enter, btnF10.Enter, btnF11.Enter, btnF12.Enter
        Me.CurrentControl.Focus()
    End Sub

    '''========================================================================================
    '''  <summary>ｸﾘｯｸ ｲﾍﾞﾝﾄを発生させる</summary>
    '''========================================================================================
    Protected Overridable Sub btnF01_Click(sender As Object, e As System.EventArgs) Handles btnF01.Click
    End Sub

    Protected Overridable Sub btnF02_Click(sender As Object, e As System.EventArgs) Handles btnF02.Click
    End Sub

    Protected Overridable Sub btnF03_Click(sender As Object, e As System.EventArgs) Handles btnF03.Click
    End Sub

    Protected Overridable Sub btnF04_Click(sender As Object, e As System.EventArgs) Handles btnF04.Click
    End Sub

    Protected Overridable Sub btnF05_Click(sender As Object, e As System.EventArgs) Handles btnF05.Click
    End Sub

    Protected Overridable Sub btnF06_Click(sender As Object, e As System.EventArgs) Handles btnF06.Click
    End Sub

    Protected Overridable Sub btnF07_Click(sender As Object, e As System.EventArgs) Handles btnF07.Click
    End Sub

    Protected Overridable Sub btnF08_Click(sender As Object, e As System.EventArgs) Handles btnF08.Click
    End Sub

    Protected Overridable Sub btnF09_Click(sender As Object, e As System.EventArgs) Handles btnF09.Click
    End Sub

    Protected Overridable Sub btnF10_Click(sender As Object, e As System.EventArgs) Handles btnF10.Click
    End Sub

    Protected Overridable Sub btnF11_Click(sender As Object, e As System.EventArgs) Handles btnF11.Click
    End Sub

    Protected Overridable Sub btnF12_Click(sender As Object, e As System.EventArgs) Handles btnF12.Click
    End Sub

    Protected Overridable Sub btnESC_Click(sender As Object, e As System.EventArgs) Handles btnESC.Click
        Me.Close()
    End Sub
#End Region

#Region "ﾌｨｰﾙﾄﾞのﾛｯｸ/ｱﾝﾛｯｸ"
    '''========================================================================================
    '''  <summary>ﾛｯｸ/ｱﾝﾛｯｸ制御(ｷｰ項目のみ入力可能)</summary>
    '''========================================================================================
    Public Sub FormEnableKey()
        '----------------------------------------------------------------------
        ' ﾛｯｸ/ｱﾝﾛｯｸ制御(Data部をﾛｯｸ)
        '----------------------------------------------------------------------
        Me.FormEnable(Me, BaseContents.Field.LockType.Key)

        '----------------------------------------------------------------------
        ' LockTypeの状況に従い先頭のｺﾝﾄﾛｰﾙを求める
        '----------------------------------------------------------------------
        Dim ControlFocus As Windows.Forms.Control = Me.TopControl(Me, BaseContents.Field.LockType.Key)
        If Not ControlFocus Is Nothing Then
            ControlFocus.Focus()
        End If
    End Sub

    '''========================================================================================
    '''  <summary>ﾛｯｸ/ｱﾝﾛｯｸ制御(全ての項目が入力可能)</summary>
    '''========================================================================================
    Public Sub FormEnableData()
        '----------------------------------------------------------------------
        ' ｷｰ項目に未入力の項目があったらData部をﾛｯｸ
        '----------------------------------------------------------------------
        If IsKeyBlank(Me) Then
            Me.FormEnable(Me, BaseContents.Field.LockType.Key)  ' 登録時にｷｰが空白で検索がされるとData部が使用可能になってしまう対処
            Exit Sub
        End If

        '----------------------------------------------------------------------
        ' ﾛｯｸ/ｱﾝﾛｯｸ制御(Data部をｱﾝﾛｯｸ)
        '----------------------------------------------------------------------
        Me.FormEnable(Me, BaseContents.Field.LockType.Data)

        '----------------------------------------------------------------------
        ' LockTypeの状況に従い先頭のｺﾝﾄﾛｰﾙを求める
        '----------------------------------------------------------------------
        Dim ControlFocus As Windows.Forms.Control = Me.TopControl(Me, BaseContents.Field.LockType.Data)
        If Not ControlFocus Is Nothing Then
            'ControlFocus.Focus()
        End If
    End Sub

    '''========================================================================================
    '''  <summary>ｺﾝﾄﾛｰﾙのLockTypeを取得</summary>
    ''' <param name="ControlTarget">ｺﾝﾄﾛｰﾙ</param>
    '''========================================================================================
    Private Function GetLockType(ByVal ControlTarget As System.Windows.Forms.Control) As BaseContents.Field.LockType
        Dim LockTypeTarget As BaseContents.Field.LockType = BaseContents.Field.LockType.None

        Select Case BaseUI.Control.Tool.ControlType(ControlTarget)
            Case BaseContents.Field.ControlType.Button : LockTypeTarget = CType(ControlTarget, BaseUI.Control.Button).FieldLockType
            Case BaseContents.Field.ControlType.CheckBox : LockTypeTarget = CType(ControlTarget, BaseUI.Control.CheckBox).FieldLockType
            Case BaseContents.Field.ControlType.ComboBox : LockTypeTarget = CType(ControlTarget, BaseUI.Control.ComboBox).FieldLockType
            Case BaseContents.Field.ControlType.GridInput : LockTypeTarget = CType(ControlTarget, BaseUI.Control.GridInput).FieldLockType
            Case BaseContents.Field.ControlType.GridView : LockTypeTarget = CType(ControlTarget, BaseUI.Control.GridView).FieldLockType
            Case BaseContents.Field.ControlType.ListBox : LockTypeTarget = CType(ControlTarget, BaseUI.Control.ListBox).FieldLockType
            Case BaseContents.Field.ControlType.NameBox : LockTypeTarget = BaseContents.Field.LockType.None
            Case BaseContents.Field.ControlType.RadioButton : LockTypeTarget = CType(ControlTarget, BaseUI.Control.RadioButton).FieldLockType
            Case BaseContents.Field.ControlType.TextBox : LockTypeTarget = CType(ControlTarget, BaseUI.Control.TextBox).FieldLockType
        End Select

        Return LockTypeTarget
    End Function

    '''========================================================================================
    '''  <summary>ｷｰ項目を探し、1つでも空白のｺﾝﾄﾛｰﾙがあればTrueを返す</summary>
    '''========================================================================================
    Private Function IsKeyBlank(ByVal ControlTarget As System.Windows.Forms.Control, Optional ByRef blnBlank As Boolean = False) As Boolean
        '----------------------------------------------------------------------
        ' ｷｰ項目に空白あり
        '----------------------------------------------------------------------
        If blnBlank Then
            Return blnBlank
        End If

        '----------------------------------------------------------------------
        ' ｷｰ項目に空白あり
        '----------------------------------------------------------------------
        For Each ControlCurr As System.Windows.Forms.Control In ControlTarget.Controls
            '-------------------------------------
            ' TextBox, ComboBox, ListBoxのみ対象
            '-------------------------------------
            Select Case BaseUI.Control.Tool.ControlType(ControlCurr)
                Case BaseContents.Field.ControlType.Button
                Case BaseContents.Field.ControlType.CheckBox
                Case BaseContents.Field.ControlType.GridInput
                Case BaseContents.Field.ControlType.GridView
                Case BaseContents.Field.ControlType.NameBox
                Case BaseContents.Field.ControlType.RadioButton

                Case BaseContents.Field.ControlType.ComboBox
                    If CType(ControlCurr, BaseUI.Control.ComboBox).FieldLockType = BaseContents.Field.LockType.Key And CType(ControlCurr, BaseUI.Control.ComboBox).SelectedValue = "" Then
                        blnBlank = True
                    End If

                Case BaseContents.Field.ControlType.ListBox
                    If CType(ControlCurr, BaseUI.Control.ListBox).FieldLockType = BaseContents.Field.LockType.Key And CType(ControlCurr, BaseUI.Control.ListBox).SelectedValue = "" Then
                        blnBlank = True
                    End If

                Case BaseContents.Field.ControlType.TextBox
                    If CType(ControlCurr, BaseUI.Control.TextBox).FieldLockType = BaseContents.Field.LockType.Key And CType(ControlCurr, BaseUI.Control.TextBox).Text = "" Then
                        blnBlank = True
                    End If
            End Select

            '-------------------------------------
            ' 再帰(子ｺﾝﾄﾛｰﾙがあれば)
            '-------------------------------------
            If ControlCurr.Controls.Count > 0 Then
                Me.IsKeyBlank(ControlCurr, blnBlank)
            End If
        Next

        '----------------------------------------------------------------------
        ' 返却
        '----------------------------------------------------------------------
        Return blnBlank
    End Function

    '''========================================================================================
    '''  <summary>LockType=Dataの項目をﾛｯｸ/ｱﾝﾛｯｸ</summary>
    ''' <param name="ControlTarget">親ｺﾝﾄﾛｰﾙ</param>
    ''' <param name="Mode">Keyﾓｰﾄﾞ→Data項目をﾛｯｸ, Dataﾓｰﾄﾞ→Data項目をｱﾝﾛｯｸ</param>
    '''========================================================================================
    Private Sub FormEnable(ByVal ControlTarget As System.Windows.Forms.Control, ByVal Mode As BaseContents.Field.LockType)
        For Each ControlCurr As System.Windows.Forms.Control In ControlTarget.Controls
            '-------------------------------------
            ' ﾛｯｸﾀｲﾌﾟ取得
            '-------------------------------------
            Dim LockTypeChild As BaseContents.Field.LockType = Me.GetLockType(ControlCurr)

            '-------------------------------------
            ' LockType=Dataの項目をﾛｯｸ/ｱﾝﾛｯｸ
            ' (Keyﾓｰﾄﾞ→ﾛｯｸ, Dataﾓｰﾄﾞ→ｱﾝﾛｯｸ)
            '-------------------------------------
            If LockTypeChild = BaseContents.Field.LockType.Data Then
                Select Case Mode
                    Case BaseContents.Field.LockType.Key : ControlCurr.Enabled = False        ' ﾛｯｸ
                    Case BaseContents.Field.LockType.Data : ControlCurr.Enabled = True        ' ｱﾝﾛｯｸ
                End Select
            End If

            '-------------------------------------
            ' 再帰(子ｺﾝﾄﾛｰﾙがあれば)
            '-------------------------------------
            If ControlCurr.Controls.Count > 0 Then
                Me.FormEnable(ControlCurr, Mode)
            End If
        Next
    End Sub

    '''========================================================================================
    '''  <summary>LockTypeの状況に従い先頭のｺﾝﾄﾛｰﾙを求める</summary>
    ''' <param name="ControlTarget">親ｺﾝﾄﾛｰﾙ</param>
    ''' <param name="Mode">Keyﾓｰﾄﾞ→Data項目をﾛｯｸ, Dataﾓｰﾄﾞ→Data項目をｱﾝﾛｯｸ</param>
    ''' <param name="ParentIndexChain">階層ﾀﾌﾞｲﾝﾃﾞｯｸｽ</param>
    ''' <param name="ParentIndexMin">最小ﾀﾌﾞｲﾝﾃﾞｯｸｽ</param>
    ''' <param name="ControlMin">最小ｺﾝﾄﾛｰﾙ</param>
    '''========================================================================================
    Private Function TopControl(ByVal ControlTarget As System.Windows.Forms.Control _
                              , ByVal Mode As BaseContents.Field.LockType _
                              , Optional ByRef ParentIndexChain As String = "" _
                              , Optional ByRef ParentIndexMin As String = "" _
                              , Optional ByRef ControlMin As System.Windows.Forms.Control = Nothing _
                               ) As System.Windows.Forms.Control
        For Each ControlCurr As System.Windows.Forms.Control In ControlTarget.Controls
            '-------------------------------------
            ' 階層ﾀﾌﾞｲﾝﾃﾞｯｸｽ 生成
            '-------------------------------------
            Dim ParentIndexCurr As String = ""
            If ParentIndexChain <> "" Then
                ParentIndexCurr = ParentIndexChain & ","
            End If
            ParentIndexCurr &= Format(ControlCurr.TabIndex, "000000")

            '-------------------------------------
            ' 先頭ｺﾝﾄﾛｰﾙ 判定
            '-------------------------------------
            Try
                '-------------------------------------
                ' ｽｷｯﾌﾟ
                '-------------------------------------
                If Not ControlCurr.Enabled Then Exit Try ' 無効ｺﾝﾄﾛｰﾙ
                If Not ControlCurr.TabStop Then Exit Try ' ﾀﾌﾞｽﾄｯﾌﾟしない
                If Not ControlCurr.Visible Then Exit Try ' 非表示
                If Me.GetLockType(ControlCurr) <> Mode Then Exit Try ' ﾛｯｸﾀｲﾌﾟ不一致
                If ParentIndexMin <> "" And ParentIndexCurr > ParentIndexMin Then Exit Try ' 最小でない

                ParentIndexMin = ParentIndexCurr
                ControlMin = ControlCurr
            Catch ex As Exception
            End Try

            '-------------------------------------
            ' 再帰
            '-------------------------------------
            If ControlCurr.Controls.Count > 0 Then
                ControlMin = Me.TopControl(ControlCurr, Mode, ParentIndexCurr, ParentIndexMin, ControlMin)
            End If
        Next

        '----------------------------------------------------------------------
        ' 返却
        '----------------------------------------------------------------------
        Return ControlMin
    End Function
#End Region

#Region "ｺﾝﾎﾞﾎﾞｯｸｽﾃﾞｰﾀｿｰｽ設定"
    '''========================================================================================
    '''  <summary>画面上のｺﾝﾎﾞﾎﾞｯｸｽに対してListTypeに基づくﾃﾞｰﾀｿｰｽを設定する</summary>
    '''========================================================================================
    Private Sub ComboListSource(ByVal ControlTarget As System.Windows.Forms.Control)
        If ControlTarget.Controls.Count = 0 Then
            Exit Sub
        End If

        Dim ChildListType As New NodeUI.List.Type
        Dim ChildListSource As New NodeUI.List.Source
        For Each ControlChild As System.Windows.Forms.Control In ControlTarget.Controls
            ChildListType = NodeUI.List.Type.None

            Select Case BaseUI.Control.Tool.ControlType(ControlChild)
                Case BaseContents.Field.ControlType.ComboBox

                    ChildListType = CType(ControlChild, BaseUI.Control.ComboBox).ListType

                    CType(ControlChild, System.Windows.Forms.ComboBox).DisplayMember = ChildListSource.COLNAME_LIST_DISPLAY
                    CType(ControlChild, System.Windows.Forms.ComboBox).ValueMember = ChildListSource.COLNAME_LIST_VALUE
                    CType(ControlChild, System.Windows.Forms.ComboBox).DataSource = ChildListSource.Execute(ChildListType)
            End Select

            Me.ComboListSource(ControlChild)        '再帰
        Next
    End Sub
#End Region

#Region "画面のﾃｷｽﾄ項目を対象にStyleTextに合わせ書式整形する"
    '''========================================================================================
    '''  <summary>画面のﾃｷｽﾄ項目を対象にStyleTextに合わせ書式整形する</summary>
    '''========================================================================================
    Public Sub TextBoxFormat()
        Me.TextBoxFormat_Recursive(Me)
    End Sub

    '''========================================================================================
    '''  <summary>再帰処理</summary>
    '''========================================================================================
    Private Sub TextBoxFormat_Recursive(ByVal ControlTarget As System.Windows.Forms.Control)
        For Each ControlChild As System.Windows.Forms.Control In ControlTarget.Controls
            Try
                Select Case True
                    Case BaseUI.Control.Tool.ControlType(ControlChild) = BaseContents.Field.ControlType.TextBox
                        ' ﾃｷｽﾄﾎﾞｯｸｽにｷｬｽﾄ
                        Dim txtTarget As BaseUI.Control.TextBox = CType(ControlChild, BaseUI.Control.TextBox)

                        Select Case txtTarget.TextStyle
                            Case BaseContents.TextBox.TextStyle.Currency, BaseContents.TextBox.TextStyle.Number
                                txtTarget.Text = BaseCore.Common.Text.TextFormat(txtTarget.Text, txtTarget.StringLength, txtTarget.TextStyle, txtTarget.NumberMinor)

                            Case Else
                                Exit Try
                        End Select

                    Case BaseUI.Control.Tool.ControlType(ControlChild) = BaseContents.Field.ControlType.NameBox
                        ' ﾈｰﾑﾎﾞｯｸｽにｷｬｽﾄ
                        Dim namTarget As BaseUI.Control.NameBox = CType(ControlChild, BaseUI.Control.NameBox)

                        Select Case namTarget.TextStyle
                            Case BaseContents.TextBox.TextStyle.Currency, BaseContents.TextBox.TextStyle.Number
                                namTarget.Text = BaseCore.Common.Text.TextFormat(namTarget.Text, namTarget.StringLength, namTarget.TextStyle, namTarget.NumberMinor)

                            Case Else
                                Exit Try
                        End Select

                    Case Else
                        Exit Try
                End Select
            Catch ex As Exception
            End Try

            Me.TextBoxFormat_Recursive(ControlChild)        '再帰
        Next
    End Sub
#End Region

#Region "印刷ﾌﾟﾚﾋﾞｭｰの表示"
    '''========================================================================================
    '''  <summary>印刷ﾌﾟﾚﾋﾞｭｰ</summary>
    '''========================================================================================
    Public Sub ReportPreview(ByVal Report As DataDynamics.ActiveReports.ActiveReport)
        Dim frm As New BasePrint
        frm.BaseViewer.Document = Report.Document
        frm.ShowDialog()
    End Sub
#End Region
End Class
