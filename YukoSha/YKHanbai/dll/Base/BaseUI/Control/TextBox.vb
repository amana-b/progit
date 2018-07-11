Imports System.ComponentModel

Namespace Control
    Public Class TextBox
        Inherits System.Windows.Forms.TextBox

#Region "変数定義"
        Private IsChanged As Boolean
#End Region

#Region "ｲﾍﾞﾝﾄ定義"
        '''========================================================================================
        '''  <summary>ﾃｷｽﾄ変更ｲﾍﾞﾝﾄ</summary>
        '''========================================================================================
        Public Event AfterUpdate(sender As Object, e As System.EventArgs)
#End Region

#Region "ﾌﾟﾛﾊﾟﾃｨ"
        '''========================================================================================
        '''  <summary>入力値にエラーかどうか(True:不正, False:正常)</summary>
        '''========================================================================================
        Private _IsError As Boolean = False

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
        Private _Required As Boolean = False

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
        '''  <summary>書式(Code, YYYYMMDD, Number)</summary>
        '''========================================================================================
        Private _TextStyle As BaseContents.TextBox.TextStyle = BaseContents.TextBox.TextStyle.None

        <Description("書式(Code, YYYYMMDD, Number)"), Category("カスタム")> _
        Public Property TextStyle() As BaseContents.TextBox.TextStyle
            Get
                Return Me._TextStyle
            End Get
            Set(ByVal Value As BaseContents.TextBox.TextStyle)
                Me._TextStyle = Value
            End Set
        End Property

        '''========================================================================================
        '''  <summary>整数桁数</summary>
        '''========================================================================================
        Private _NumberMajor As Integer

        <Description("整数桁数"), DefaultValue(0), Category("カスタム")> _
        Public Overridable Property NumberMajor() As Integer
            Get
                Return Me._NumberMajor
            End Get

            Set(value As Integer)
                Me._NumberMajor = value
            End Set
        End Property

        '''========================================================================================
        '''  <summary>小数桁数</summary>
        '''========================================================================================
        Private _NumberMinor As Integer

        <Description("小数桁数"), DefaultValue(0), Category("カスタム")> _
        Public Overridable Property NumberMinor() As Integer
            Get
                Return Me._NumberMinor
            End Get

            Set(value As Integer)
                Me._NumberMinor = value
            End Set
        End Property

        '''========================================================================================
        '''  <summary>ﾃｷｽﾄﾎﾞｯｸｽの長さ(ﾊﾞｲﾄ単位)</summary>
        '''========================================================================================
        Private _StringLength As Integer

        <Description("最大文字バイト数"), DefaultValue(65535), Category("カスタム")> _
        Public Overridable Property StringLength() As Integer
            Get
                If Me._StringLength <> -1 Then
                    Return Me._StringLength
                Else

                    Select Case Me.TextStyle
                        Case BaseContents.TextBox.TextStyle.Currency
                            Dim intDiv As Integer = 0
                            Dim intRem As Integer = 0

                            intDiv = Math.DivRem(CInt(Me.NumberMajor) - 1, 3, intRem)

                            If CInt(Me.NumberMinor) = 0 Then
                                Return CInt(Me.NumberMajor) + intDiv                               '+intDivはｶﾝﾏ数
                            Else
                                Return CInt(Me.NumberMajor) + intDiv + CInt(Me.NumberMinor) + 1    '+intDivはｶﾝﾏ数、+1は小数点
                            End If

                        Case BaseContents.TextBox.TextStyle.Number
                            Return CInt(Me.NumberMajor) + CInt(Me.NumberMajor) + 1      '+ 1は小数点

                        Case Else
                            Return Me.NumberMajor + Me.NumberMinor
                    End Select
                End If
            End Get

            Set(value As Integer)
                If Me._StringLength <> value Then
                    Me._StringLength = value
                End If
            End Set
        End Property

        '''========================================================================================
        '''  <summary>ﾍﾙﾌﾟ ﾀｲﾌﾟ</summary>
        '''========================================================================================
        Private _HelpType As NodeUI.Help.Type = NodeUI.Help.Type.None

        <Description("ﾍﾙﾌﾟ ﾀｲﾌﾟ"), Category("カスタム")> _
        Public Property HelpType() As NodeUI.Help.Type
            Get
                Return Me._HelpType
            End Get
            Set(ByVal Value As NodeUI.Help.Type)
                Me._HelpType = Value
            End Set
        End Property

        '''========================================================================================
        '''  <summary>ﾍﾙﾌﾟ ｷｰ項目</summary>
        '''========================================================================================
        Private _HelpKeys As String = ""

        <Description("ﾍﾙﾌﾟ ｷｰ項目"), Category("カスタム")> _
        Public Property HelpKeys() As String
            Get
                Return Me._HelpKeys
            End Get
            Set(ByVal Value As String)
                Me._HelpKeys = Value
            End Set
        End Property

        '''========================================================================================
        '''  <summary>ﾍﾙﾌﾟ 関連項目</summary>
        '''========================================================================================
        Private _HelpLink As String = ""

        <Description("ﾍﾙﾌﾟ 関連項目"), Category("カスタム")> _
        Public Property HelpLink() As String
            Get
                Return Me._HelpLink
            End Get
            Set(ByVal Value As String)
                Me._HelpLink = Value
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

            ' 最大文字長
            Me.StringLength = 65535
        End Sub
#End Region

#Region "ｲﾍﾞﾝﾄ"
        '''========================================================================================
        '''  <summary>ｳｨﾝﾄﾞｳ ﾌﾟﾛｾｽ</summary>
        '''========================================================================================
        Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
            '----------------------------------------------------------------------
            ' StringLength
            '----------------------------------------------------------------------
            Const WM_CHAR As Integer = &H102
            Const WM_PASTE As Integer = &H302

            Select Case m.Msg
                Case WM_CHAR
                    ' 文字入力
                    Dim eKeyPress As New System.Windows.Forms.KeyPressEventArgs(Microsoft.VisualBasic.ChrW(m.WParam.ToInt32()))
                    Me.StringLengthOnChar(eKeyPress)

                    If eKeyPress.Handled Then
                        Return
                    End If

                Case WM_PASTE
                    ' ﾍﾟｰｽﾄ
                    If Me.MaxLength * 2 > Me.StringLength Then
                        Me.StringLengthOnPaste(New System.EventArgs())
                        Return
                    End If
            End Select

            '----------------------------------------------------------------------
            ' ﾍﾞｰｽ処理
            '----------------------------------------------------------------------
            MyBase.WndProc(m)
        End Sub

        '''========================================================================================
        '''  <summary>ｸﾘｴｲﾄ</summary>
        '''========================================================================================
        Protected Overrides Sub CreateHandle()
            '----------------------------------------------------------------------
            ' 書式が数字形式なら右詰めにする
            '----------------------------------------------------------------------
            Select Case Me.TextStyle
                Case BaseContents.TextBox.TextStyle.Currency, BaseContents.TextBox.TextStyle.Number
                    Me.TextAlign = Windows.Forms.HorizontalAlignment.Right
            End Select

            '----------------------------------------------------------------------
            ' Enableの色変更
            '----------------------------------------------------------------------
            If Not Me.Enabled Then
                Me.BackColor = Me.BackColor     ' 背景色を灰色にしない
            End If

            '----------------------------------------------------------------------
            ' ﾍﾞｰｽ処理
            '----------------------------------------------------------------------
            MyBase.CreateHandle()
        End Sub

        '''========================================================================================
        '''  <summary>ﾌｫｰｶｽ取得</summary>
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
        '''  <summary>ﾌｫｰｶｽ喪失</summary>
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

        '''========================================================================================
        '''  <summary>開始</summary>
        '''========================================================================================
        Protected Overrides Sub OnEnter(e As System.EventArgs)
            '----------------------------------------------------------------------
            ' 変更ﾌﾗｸﾞ Off
            '----------------------------------------------------------------------
            IsChanged = False

            '----------------------------------------------------------------------
            ' ﾍﾞｰｽ処理
            '----------------------------------------------------------------------
            MyBase.OnEnter(e)
        End Sub

        '''========================================================================================
        '''  <summary>変更</summary>
        '''========================================================================================
        Protected Overrides Sub OnTextChanged(e As System.EventArgs)
            '----------------------------------------------------------------------
            ' 変更ﾌﾗｸﾞ On
            '----------------------------------------------------------------------
            IsChanged = True

            '----------------------------------------------------------------------
            ' ﾍﾞｰｽ処理
            '----------------------------------------------------------------------
            MyBase.OnTextChanged(e)
        End Sub

        '''========================================================================================
        '''  <summary>終了</summary>
        '''========================================================================================
        Protected Overrides Sub OnLeave(e As System.EventArgs)
            '----------------------------------------------------------------------
            ' 変更があったら
            '----------------------------------------------------------------------
            If IsChanged Then
                '----------------------------------------------------------------------
                ' 変更ﾌﾗｸﾞ Off
                '----------------------------------------------------------------------
                IsChanged = False

                '----------------------------------------------------------------------
                ' 書式にあわせ成型する
                '----------------------------------------------------------------------
                Me.Text = BaseCore.Common.Text.TextFormat(Me.Text, Me.StringLength, Me.TextStyle, Me.NumberMinor)

                '----------------------------------------------------------------------
                ' 名称類を表示する
                '----------------------------------------------------------------------
                Me.HelpViewer()

                '----------------------------------------------------------------------
                ' 変更後ｲﾍﾞﾝﾄを発生させる
                '----------------------------------------------------------------------
                RaiseEvent AfterUpdate(Me, e)
            End If

            '----------------------------------------------------------------------
            ' ﾍﾞｰｽ処理
            '----------------------------------------------------------------------
            MyBase.OnLeave(e)
        End Sub
#End Region

#Region "ﾕｰｻﾞ部品"
        '''========================================================================================
        '''  <summary>StringLength判定(文字入力)</summary>
        '''========================================================================================
        Private Sub StringLengthOnChar(ByVal e As System.Windows.Forms.KeyPressEventArgs)
            If Char.IsControl(e.KeyChar) Then
                Return
            End If

            Dim sjisEncoding As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")
            Dim textByteCount As Integer = sjisEncoding.GetByteCount(Me.Text)
            Dim inputByteCount As Integer = sjisEncoding.GetByteCount(e.KeyChar.ToString())
            Dim selectedTextByteCount As Integer = sjisEncoding.GetByteCount(Me.SelectedText)

            If textByteCount + inputByteCount - selectedTextByteCount > Me.StringLength Then
                e.Handled = True
            End If
        End Sub

        '''========================================================================================
        '''  <summary>StringLength判定(ﾍﾟｰｽﾄ)</summary>
        '''========================================================================================
        Private Sub StringLengthOnPaste(ByVal e As System.EventArgs)
            Dim clipboardText As Object = System.Windows.Forms.Clipboard.GetDataObject().GetData(System.Windows.Forms.DataFormats.Text)

            If clipboardText Is Nothing Then
                Return
            End If

            Dim sjisEncoding As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")
            Dim inputText As String = clipboardText.ToString()
            Dim textByteCount As Integer = sjisEncoding.GetByteCount(Me.Text)
            Dim inputByteCount As Integer = sjisEncoding.GetByteCount(inputText)
            Dim selectedTextByteCount As Integer = sjisEncoding.GetByteCount(Me.SelectedText)
            Dim remainByteCount As Integer = Me.StringLength - (textByteCount - selectedTextByteCount)

            If remainByteCount <= 0 Then
                Return
            End If

            If remainByteCount >= inputByteCount Then
                Me.SelectedText = inputText
            Else
                Me.SelectedText = inputText.Substring(0, remainByteCount)
            End If
        End Sub

        '''========================================================================================
        '''  <summary>値変更時に関連項目を表示する</summary>
        '''========================================================================================
        Private Sub HelpViewer()
            '----------------------------------------------------------------------
            ' ﾍﾙﾌﾟﾀｲﾌﾟ無しはｽｷｯﾌﾟ
            '----------------------------------------------------------------------
            If HelpType = NodeUI.Help.Type.None Then
                Exit Sub
            End If

            '----------------------------------------------------------------------
            ' ｷｰ値 取得
            '----------------------------------------------------------------------
            Dim strKeysValue As String = Me.HelpGetValue(Me.HelpKeys)

            '----------------------------------------------------------------------
            ' 名称類 設定
            '----------------------------------------------------------------------
            If Me.HelpLink <> "" Then
                ' 名称類 取得
                Dim strLinkValue As String

                strLinkValue = (New NodeUI.Help.Names).Execute(Me.HelpType, strKeysValue)

                ' 名称類 設定
                Me.HelpSetValue(Me.HelpLink, strLinkValue)
            End If
        End Sub

        '''========================================================================================
        '''  <summary>ﾍﾙﾌﾟｷｰの値を取得</summary>
        '''========================================================================================
        Public Function HelpGetValue(Names As String) As String
            '----------------------------------------------------------------------
            ' ｷｰ値 取得
            '----------------------------------------------------------------------
            Dim strKeysValue As String = ""
            Dim strDelim As String = ""

            For Each ID As String In Names.Split(vbTab)
                Dim arrControl() As System.Windows.Forms.Control = Me.FindForm.Controls.Find(ID, True)
                If arrControl.Length = 0 Then
                    Continue For
                End If

                strKeysValue &= strDelim & BaseUI.Control.Tool.GetValue(arrControl(0))
                strDelim = vbTab
            Next

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return strKeysValue
        End Function

        '''========================================================================================
        '''  <summary>ｺﾝﾄﾛｰﾙ名からｺﾝﾄﾛｰﾙ本体を割り出し、値を設定する。</summary>
        '''========================================================================================
        Public Sub HelpSetValue(Names As String, Values As String)
            Dim arrValue() As String = Values.Split(vbTab)

            ' 名称類 設定
            Dim i As Integer = 0
            For Each ID As String In Names.Split(vbTab)
                Dim arrControl() As System.Windows.Forms.Control = Me.FindForm.Controls.Find(ID, True)
                If arrControl.Length = 0 Then
                    Continue For
                End If

                If i >= arrValue.Length Then
                    Exit For
                End If

                BaseUI.Control.Tool.SetValue(arrControl(0), arrValue(i))
                i += 1
            Next
        End Sub

        '''========================================================================================
        '''  <summary>ﾌﾟﾛﾊﾟﾃｨの初期化(ﾌｫｰﾑ)</summary>
        '''========================================================================================
        Public Sub PropetyInitForm(InitLockType As BaseContents.Field.LockType _
                                 , InitRequired As Boolean _
                                 , InitImeMode As Windows.Forms.ImeMode _
                                 , InitTextStyle As BaseContents.TextBox.TextStyle _
                                 , InitHelpType As NodeUI.Help.Type _
                                 , InitHelpKeys As String _
                                 , InitHelpLink As String _
                                  )
            Me.FieldLockType = InitLockType
            Me.Required = InitRequired
            Me.ImeMode = InitImeMode
            Me.TextStyle = InitTextStyle
            Me.HelpType = InitHelpType
            Me.HelpKeys = InitHelpKeys
            Me.HelpLink = InitHelpLink

            Select Case Me.TextStyle
                Case BaseContents.TextBox.TextStyle.Currency, BaseContents.TextBox.TextStyle.Number
                    Me.TextAlign = Windows.Forms.HorizontalAlignment.Right

                Case Else
                    Me.TextAlign = Windows.Forms.HorizontalAlignment.Left
            End Select
        End Sub

        '''========================================================================================
        '''  <summary>ﾌﾟﾛﾊﾟﾃｨの初期化(ﾀﾞｲｱﾛｸﾞ)</summary>
        '''========================================================================================
        Public Sub PropetyInitDialog(InitImeMode As Windows.Forms.ImeMode _
                                   , InitTextStyle As BaseContents.TextBox.TextStyle _
                                   , InitHelpType As NodeUI.Help.Type _
                                   , InitHelpKeys As String _
                                   , InitHelpLink As String _
                                   , StringLength As Integer _
                                   , NumberMajor As Integer _
                                   , NumberMinor As Integer _
                                    )

            Me.FieldLockType = BaseContents.Field.LockType.None
            Me.Required = False
            Me.ImeMode = InitImeMode
            Me.TextStyle = InitTextStyle
            Me.HelpType = InitHelpType
            Me.HelpKeys = InitHelpKeys
            Me.HelpLink = InitHelpLink
            Select Case Me.TextStyle
                Case BaseContents.TextBox.TextStyle.Currency, BaseContents.TextBox.TextStyle.Number
                    Me.NumberMajor = NumberMajor
                    Me.NumberMinor = NumberMinor

                Case Else
                    Me.StringLength = StringLength
            End Select

            Select Case Me.TextStyle
                Case BaseContents.TextBox.TextStyle.Currency, BaseContents.TextBox.TextStyle.Number
                    Me.TextAlign = Windows.Forms.HorizontalAlignment.Right

                Case Else
                    Me.TextAlign = Windows.Forms.HorizontalAlignment.Left
            End Select
        End Sub
#End Region
    End Class
End Namespace
