Imports System.ComponentModel

Namespace Control
    Public Class ComboBox
        Inherits System.Windows.Forms.ComboBox

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
        '''  <summary>ﾘｽﾄ ﾀｲﾌﾟ</summary>
        '''========================================================================================
        Private _ListType As NodeUI.List.Type = NodeUI.List.Type.None

        <Description("ﾘｽﾄ ﾀｲﾌﾟ"), Category("カスタム")> _
        Public Property ListType() As NodeUI.List.Type
            Get
                Return Me._ListType
            End Get
            Set(ByVal Value As NodeUI.List.Type)
                Me._ListType = Value
            End Set
        End Property

        '''========================================================================================
        '''  <summary>ﾌｫｰｶｽ取得時、自動ﾄﾞﾛｯﾌﾟﾀﾞｳﾝ機能を使用するか(True:使用する,False:使用しない)</summary>
        '''========================================================================================
        Private _AutoDropDown As Boolean = True

        <Description("ﾌｫｰｶｽ取得時、自動ﾄﾞﾛｯﾌﾟﾀﾞｳﾝ機能を使用するか(True:使用する, False:使用しない)"), Category("カスタム")> _
        Public Property AutoDropDown() As Boolean
            Get
                Return Me._AutoDropDown
            End Get
            Set(ByVal Value As Boolean)
                Me._AutoDropDown = Value
            End Set
        End Property

        '''========================================================================================
        '''  <summary>Nothing等の値設定のｴﾗｰ回避</summary>
        '''========================================================================================
        Public Shadows Property SelectedValue() As Object
            Get
                Return MyBase.SelectedValue
            End Get
            Set(ByVal Value As Object)
                Try
                    MyBase.SelectedValue = Value
                Catch ex As Exception
                End Try
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

            ' ﾘｽﾄ値以外の入力を許可しない
            Me.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
        End Sub
#End Region

#Region "ｲﾍﾞﾝﾄ"
        '''========================================================================================
        '''  <summary>ﾌｫｰｶｽ取得ｲﾍﾞﾝﾄ</summary>
        '''========================================================================================
        Protected Overrides Sub OnGotFocus(e As System.EventArgs)
            '----------------------------------------------------------------------
            ' 背景色を付ける
            '----------------------------------------------------------------------
            Me.BackColor = Drawing.Color.PeachPuff

            '----------------------------------------------------------------------
            ' 自動ﾄﾞﾛｯﾌﾟﾀﾞｳﾝ
            '----------------------------------------------------------------------
            If Me.AutoDropDown Then
                Me.DroppedDown = True
            End If

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
        Protected Overrides Sub OnSelectedValueChanged(e As System.EventArgs)
            '----------------------------------------------------------------------
            ' 変更ﾌﾗｸﾞ On
            '----------------------------------------------------------------------
            IsChanged = True

            '----------------------------------------------------------------------
            ' ﾍﾞｰｽ処理
            '----------------------------------------------------------------------
            MyBase.OnSelectedValueChanged(e)
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
        '''  <summary>ﾌﾟﾛﾊﾟﾃｨの初期化(ﾌｫｰﾑ)</summary>
        '''========================================================================================
        Public Sub PropetyInitForm(InitLockType As BaseContents.Field.LockType _
                                 , InitRequired As Boolean _
                                 , InitListType As NodeUI.List.Type _
                                  )
            Me.FieldLockType = InitLockType
            Me.Required = InitRequired
            Me.ListType = InitListType
        End Sub

        '''========================================================================================
        '''  <summary>ﾌﾟﾛﾊﾟﾃｨの初期化(ﾀﾞｲｱﾛｸﾞ)</summary>
        '''========================================================================================
        Public Sub PropetyInitDialog(InitListType As NodeUI.List.Type)
            Me.FieldLockType = BaseContents.Field.LockType.None
            Me.Required = False
            Me.ListType = InitListType
        End Sub
#End Region
    End Class
End Namespace
