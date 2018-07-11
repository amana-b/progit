Public Class frmYamatoType
    Inherits BaseUI.BaseForm

#Region "ﾌﾚｰﾑﾜｰｸ"
    Private Frame As NodeCore.Frame.Master.YamatoDate
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
        F06 = "区分名複写"
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
        Me.txtヤマト区分.PropetyInitForm(BaseContents.Field.LockType.Key, True, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.Mヤマト区分, Me.txtヤマト区分.Name, Me.txtヤマト区分名.Name)
        Me.txtヤマト区分名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt略称.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txt入数.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt最大ケース数.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt受注単価.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt品名CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.M品名, Me.txt品名CD.Name, Me.nam品名.Name)
        Me.txt光村印刷得意先CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M得意先, Me.txt光村印刷得意先CD.Name, Me.nam光村印刷得意先名.Name)
        Me.txt光村印刷出荷先CD.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.M出荷先, Me.txt光村印刷得意先CD.Name & vbTab & Me.txt光村印刷出荷先CD.Name, Me.nam光村印刷出荷先名.Name)
        Me.txt材料請求時単価.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Currency, NodeUI.Help.Type.None, "", "")
        Me.txt材料請求時品名.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.On, BaseContents.TextBox.TextStyle.None, NodeUI.Help.Type.None, "", "")
        Me.txtバーコード開始No1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txtバーコード開始No2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txtバーコード開始No3.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txtバーコード終了No1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txtバーコード終了No2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txtバーコード終了No3.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txtバーコード次回No1.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txtバーコード次回No2.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")
        Me.txtバーコード次回No3.PropetyInitForm(BaseContents.Field.LockType.Data, False, Windows.Forms.ImeMode.Disable, BaseContents.TextBox.TextStyle.Code, NodeUI.Help.Type.None, "", "")

        ' ﾈｰﾑﾎﾞｯｸｽ
        Me.nam品名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam光村印刷得意先名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)
        Me.nam光村印刷出荷先名.PropetyInitForm(BaseContents.TextBox.TextStyle.None)

        ' ﾄﾞﾛｯﾌﾟﾀﾞｳﾝ
        Me.ddl種別内訳区分.PropetyInitForm(BaseContents.Field.LockType.Data, False, NodeUI.List.Type.M区分_種別内訳区分)

    End Sub

    '''========================================================================================
    '''  <summary>ﾌﾚｰﾑﾜｰｸの準備</summary>
    '''========================================================================================
    Protected Overrides Sub FrameInit()
        '-------------------------------------
        ' ｺﾝｽﾄﾗｸﾀ
        '-------------------------------------
        Frame = New NodeCore.Frame.Master.YamatoDate(Me.Security, Me.Config)

        '-------------------------------------
        ' 紐付け
        '-------------------------------------
        Frame.Fields.Header.ヤマト区分.Control = Me.txtヤマト区分
        Frame.Fields.Header.ヤマト区分名.Control = Me.txtヤマト区分名
        Frame.Fields.Header.略称.Control = Me.txt略称
        Frame.Fields.Header.種別内訳区分.Control = Me.ddl種別内訳区分
        Frame.Fields.Header.入数.Control = Me.txt入数
        Frame.Fields.Header.最大ケース数.Control = Me.txt最大ケース数
        Frame.Fields.Header.受注単価.Control = Me.txt受注単価
        Frame.Fields.Header.品名CD.Control = Me.txt品名CD
        Frame.Fields.Header.品名.Control = Me.nam品名
        Frame.Fields.Header.光村印刷出荷先CD.Control = Me.txt光村印刷出荷先CD
        Frame.Fields.Header.光村印刷出荷先名.Control = Me.nam光村印刷出荷先名
        Frame.Fields.Header.光村印刷得意先CD.Control = Me.txt光村印刷得意先CD
        Frame.Fields.Header.光村印刷得意先名.Control = Me.nam光村印刷得意先名
        Frame.Fields.Header.材料請求時単価.Control = Me.txt材料請求時単価
        Frame.Fields.Header.材料請求時品名.Control = Me.txt材料請求時品名
        Frame.Fields.Header.クロネコメール便バーコード開始NO1.Control = Me.txtバーコード開始No1
        Frame.Fields.Header.クロネコメール便バーコード開始NO2.Control = Me.txtバーコード開始No2
        Frame.Fields.Header.クロネコメール便バーコード開始NO3.Control = Me.txtバーコード開始No3
        Frame.Fields.Header.クロネコメール便バーコード終了NO1.Control = Me.txtバーコード終了No1
        Frame.Fields.Header.クロネコメール便バーコード終了NO2.Control = Me.txtバーコード終了No2
        Frame.Fields.Header.クロネコメール便バーコード終了NO3.Control = Me.txtバーコード終了No3
        Frame.Fields.Header.クロネコメール便バーコード次回発番NO1.Control = Me.txtバーコード次回No1
        Frame.Fields.Header.クロネコメール便バーコード次回発番NO2.Control = Me.txtバーコード次回No2
        Frame.Fields.Header.クロネコメール便バーコード次回発番NO3.Control = Me.txtバーコード次回No3

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

        Me.btnF06.Enabled = False

        '----------------------------------------------------------------------
        ' ｷｰ部入力制御
        '----------------------------------------------------------------------
        Me.FormEnableKey()
    End Sub

    '''========================================================================================
    ''' <summary>ｷｰ変更</summary>
    '''========================================================================================
    Private Sub txtヤマト区分_AfterUpdate(sender As Object, e As System.EventArgs) Handles txtヤマト区分.AfterUpdate
        '----------------------------------------------------------------------
        ' 該当ﾃﾞｰﾀ 読込
        '----------------------------------------------------------------------
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
        Me.FormEnableData_Unique()

    End Sub

    Private Sub txt品名CD_AfterUpdate(sender As Object, e As System.EventArgs) Handles txt品名CD.AfterUpdate
        '----------------------------------------------------------------------
        ' 変数定義
        '----------------------------------------------------------------------
        Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0ヤマト区分TableAdapter
        Dim tbl As New NodeDatabase.DataSetView.V0ヤマト区分DataTable
        Dim qry As New Collection

        '----------------------------------------------------------------------
        ' 条件設定
        '----------------------------------------------------------------------
        qry.Clear()
        qry.Add(New BaseDatabase.Condition(tbl.ヤマト区分Column.ColumnName, Me.txtヤマト区分.Text, BaseDatabase.Contents.Compare.Equal))

        '----------------------------------------------------------------------
        ' 読込
        '----------------------------------------------------------------------
        tbl = ada.SelectByCommon(qry)
        If tbl.Count = 0 Then
            If Me.txt品名CD.Text <> Nothing Then
                Me.txt品名CD.Focus()
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
        Me.FormEnableData_Unique()
    End Sub

    Private Sub txt光村印刷得意先CD_AfterUpdate(sender As Object, e As System.EventArgs) Handles txt光村印刷得意先CD.AfterUpdate
        '----------------------------------------------------------------------
        ' 変数定義
        '----------------------------------------------------------------------
        Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0得意先TableAdapter
        Dim tbl As New NodeDatabase.DataSetView.V0得意先DataTable
        Dim qry As New Collection

        '----------------------------------------------------------------------
        ' 条件設定
        '----------------------------------------------------------------------
        qry.Clear()
        qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Me.txt光村印刷得意先CD.Text, BaseDatabase.Contents.Compare.Equal))

        '----------------------------------------------------------------------
        ' 読込
        '----------------------------------------------------------------------
        tbl = ada.SelectByCommon(qry)
        If tbl.Count = 0 Then
            If Me.txt光村印刷得意先CD.Text <> Nothing Then
                Me.txt光村印刷得意先CD.Focus()
                MsgBox("マスタに登録がありません", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
                Exit Sub
            End If
        End If

        '----------------------------------------------------------------------
        ' ﾃﾞｰﾀ部入力制御
        '----------------------------------------------------------------------
        Me.FormEnableData()
        Me.FormEnableData_Unique()
    End Sub

    Private Sub txt光村印刷出荷先CD_AfterUpdate(sender As Object, e As System.EventArgs) Handles txt光村印刷出荷先CD.AfterUpdate
        '----------------------------------------------------------------------
        ' 変数定義
        '----------------------------------------------------------------------
        Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0出荷先TableAdapter
        Dim tbl As New NodeDatabase.DataSetView.V0出荷先DataTable
        Dim qry As New Collection

        '----------------------------------------------------------------------
        ' 条件設定
        '----------------------------------------------------------------------
        qry.Clear()
        qry.Add(New BaseDatabase.Condition(tbl.出荷先CDColumn.ColumnName, Me.txt光村印刷出荷先CD.Text, BaseDatabase.Contents.Compare.Equal))
        qry.Add(New BaseDatabase.Condition(tbl.得意先CDColumn.ColumnName, Me.txt光村印刷得意先CD.Text, BaseDatabase.Contents.Compare.Equal))

        '----------------------------------------------------------------------
        ' 読込
        '----------------------------------------------------------------------
        tbl = ada.SelectByCommon(qry)
        If tbl.Count = 0 Then
            If Me.txt光村印刷出荷先CD.Text <> Nothing Then
                Me.txt光村印刷出荷先CD.Focus()
                MsgBox("マスタに登録がありません", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "エラー")
                Exit Sub
            End If
        End If

        '----------------------------------------------------------------------
        ' ﾃﾞｰﾀ部入力制御
        '----------------------------------------------------------------------
        Me.FormEnableData()
    End Sub

    Private Sub ddl種別内訳区分_AfterUpdate(sender As Object, e As System.EventArgs) Handles ddl種別内訳区分.AfterUpdate
        '----------------------------------------------------------------------
        ' 変数定義
        '----------------------------------------------------------------------

        '----------------------------------------------------------------------
        ' 条件設定
        '----------------------------------------------------------------------

        '----------------------------------------------------------------------
        ' 読込
        '----------------------------------------------------------------------

        '----------------------------------------------------------------------
        ' ﾃｷｽﾄﾎﾞｯｸｽ 書式適用
        '----------------------------------------------------------------------

        '----------------------------------------------------------------------
        ' ﾃﾞｰﾀ部入力制御
        '----------------------------------------------------------------------
        Me.FormEnableData()
        Me.FormEnableData_Unique()
    End Sub

    '''========================================================================================
    '''  <summary>複写 有効化</summary>
    '''========================================================================================
    Private Sub txt略称_GotFocus(sender As Object, e As System.EventArgs) Handles txt略称.GotFocus
        If BaseUI.Control.Tool.ControlType(Me.ActiveControl) = BaseContents.Field.ControlType.TextBox Then
            Me.btnF06.Enabled = True
        End If
    End Sub

    '''========================================================================================
    '''  <summary>複写 無効化</summary>
    '''========================================================================================
    Private Sub txt略称_Leave(sender As Object, e As System.EventArgs) Handles txt略称.Leave
        If Me.txt略称.Focused = False Then
            If BaseUI.Control.Tool.ControlType(Me.ActiveControl) = BaseContents.Field.ControlType.TextBox Then
                Me.btnF06.Enabled = False
            End If
        End If
    End Sub

    '''========================================================================================
    '''  <summary>項目制御</summary>
    '''========================================================================================
    Private Sub FormEnableData_Unique()
        '出荷先CD制御
        If Not Me.txt光村印刷得意先CD.Text = Nothing Then
            Me.txt光村印刷出荷先CD.Enabled = True
        Else
            Me.txt光村印刷出荷先CD.Enabled = False
            Me.txt光村印刷出荷先CD.Text = Nothing
            Me.nam光村印刷出荷先名.Text = Nothing
        End If

        '品名CD制御
        If Me.ddl種別内訳区分.SelectedValue = NodeContents.Constant.CodeValue.種別内訳区分.内訳無し Then
            Me.txt品名CD.Enabled = True
        Else
            Me.txt品名CD.Enabled = False
            Me.txt品名CD.Text = Nothing
            Me.nam品名.Text = Nothing
        End If
    End Sub
#End Region

#Region "ﾌｧﾝｸｼｮﾝ"
    '''========================================================================================
    '''  <summary>区分名複写</summary>
    '''========================================================================================
    Protected Overrides Sub btnF06_Click(sender As Object, e As System.EventArgs)
        '----------------------------------------------------------------------
        ' ﾍﾞｰｽ処理
        '----------------------------------------------------------------------
        MyBase.btnF06_Click(sender, e)

        '----------------------------------------------------------------------
        ' 区分名複写
        '----------------------------------------------------------------------
        '区分名が8文字以下の場合、Substringのエラーを回避するために空白を入れる。その後、空白を除く。
        Frame.Fields.Header.略称.Value = Replace(Frame.Fields.Header.ヤマト区分名.Value.ToString.PadRight(4, "　").ToString.Substring(0, 4), "　", "")
    End Sub

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
