Imports System.ComponentModel

Namespace Control
    Public Class RadioButton
        Inherits System.Windows.Forms.RadioButton

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
        '''  <summary>変更</summary>
        '''========================================================================================
        Protected Overrides Sub OnCheckedChanged(e As System.EventArgs)
            '----------------------------------------------------------------------
            ' 変更後ｲﾍﾞﾝﾄを発生させる
            '----------------------------------------------------------------------
            RaiseEvent AfterUpdate(Me, e)

            '----------------------------------------------------------------------
            ' ﾍﾞｰｽ処理
            '----------------------------------------------------------------------
            MyBase.OnCheckedChanged(e)
        End Sub
#End Region

#Region "ﾕｰｻﾞ部品"
        '''========================================================================================
        '''  <summary>ﾌﾟﾛﾊﾟﾃｨの初期化(ﾌｫｰﾑ)</summary>
        '''========================================================================================
        Public Sub PropetyInitForm(InitLockType As BaseContents.Field.LockType)
            Me.FieldLockType = InitLockType
        End Sub

        '''========================================================================================
        '''  <summary>ﾌﾟﾛﾊﾟﾃｨの初期化(ﾀﾞｲｱﾛｸﾞ)</summary>
        '''========================================================================================
        Public Sub PropetyInitDialog()
            Me.FieldLockType = BaseContents.Field.LockType.None
        End Sub
#End Region
    End Class
End Namespace
