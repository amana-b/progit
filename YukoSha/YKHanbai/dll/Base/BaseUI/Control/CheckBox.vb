Imports System.ComponentModel

Namespace Control
    Public Class CheckBox
        Inherits System.Windows.Forms.CheckBox

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
        End Sub
#End Region

#Region "ｲﾍﾞﾝﾄ"
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
        Protected Overrides Sub OnCheckedChanged(e As System.EventArgs)
            '----------------------------------------------------------------------
            ' 変更ﾌﾗｸﾞ On
            '----------------------------------------------------------------------
            IsChanged = True

            '----------------------------------------------------------------------
            ' ﾍﾞｰｽ処理
            '----------------------------------------------------------------------
            MyBase.OnCheckedChanged(e)
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
        Public Sub PropetyInitForm(InitLockType As BaseContents.Field.LockType)
            Me.FieldLockType = InitLockType
            Me.Required = False
        End Sub

        '''========================================================================================
        '''  <summary>ﾌﾟﾛﾊﾟﾃｨの初期化(ﾀﾞｲｱﾛｸﾞ)</summary>
        '''========================================================================================
        Public Sub PropetyInitDialog()
            Me.FieldLockType = BaseContents.Field.LockType.None
            Me.Required = False
        End Sub
#End Region
    End Class
End Namespace
