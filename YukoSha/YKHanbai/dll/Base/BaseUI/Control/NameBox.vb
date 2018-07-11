Imports System.ComponentModel

Namespace Control
    Public Class NameBox
        Inherits System.Windows.Forms.Label

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

            ' 境界線ｽﾀｲﾙ
            Me.BorderStyle = Windows.Forms.BorderStyle.Fixed3D

            ' 内余白
            Me.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        End Sub
#End Region

#Region "ﾌﾟﾛﾊﾟﾃｨ"
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
#End Region

#Region "AutoSizeのﾃﾞｨﾌｫﾙﾄをFalse"
        '''========================================================================================
        '''  <summary>ｺﾝｽﾄﾗｸﾀでFalseでは、ﾃﾞｻﾞｲﾅｰ画面で勝手にTrueにされてしまう対応</summary>
        '''========================================================================================
        Private _AutoSize As Boolean = False

        <DefaultValue(GetType(Boolean), "False")> _
        Public Overridable Shadows Property AutoSize As Boolean
            Get
                Return _AutoSize
            End Get
            Set(value As Boolean)
                _AutoSize = value
                MyBase.AutoSize = value
            End Set
        End Property

        Protected Overrides Sub InitLayout()
            MyBase.InitLayout()
            MyBase.AutoSize = _AutoSize
        End Sub
#End Region

#Region "ｲﾍﾞﾝﾄ"
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
            ' ﾍﾞｰｽ処理
            '----------------------------------------------------------------------
            MyBase.CreateHandle()
        End Sub
#End Region

#Region "ﾕｰｻﾞ部品"
        '''========================================================================================
        '''  <summary>ﾌﾟﾛﾊﾟﾃｨの初期化(ﾌｫｰﾑ)</summary>
        '''========================================================================================
        Public Sub PropetyInitForm(InitTextStyle As BaseContents.TextBox.TextStyle)
            Me.TextStyle = InitTextStyle

            Select Case Me.TextStyle
                Case BaseContents.TextBox.TextStyle.Currency, BaseContents.TextBox.TextStyle.Number
                    Me.TextAlign = System.Drawing.ContentAlignment.MiddleRight

                Case Else
                    Me.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            End Select
        End Sub

        '''========================================================================================
        '''  <summary>ﾌﾟﾛﾊﾟﾃｨの初期化(ﾀﾞｲｱﾛｸﾞ)</summary>
        '''========================================================================================
        Public Sub PropetyInitDialog(InitTextStyle As BaseContents.TextBox.TextStyle)
            Me.TextStyle = InitTextStyle

            Select Case Me.TextStyle
                Case BaseContents.TextBox.TextStyle.Currency, BaseContents.TextBox.TextStyle.Number
                    Me.TextAlign = System.Drawing.ContentAlignment.MiddleRight

                Case Else
                    Me.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            End Select
        End Sub
#End Region
    End Class
End Namespace
