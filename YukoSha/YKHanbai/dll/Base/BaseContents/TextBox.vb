Public Class TextBox
    Public Enum TextStyle
        ''' <summary>指定なし</summary>
        None

        '''' <summary>数字</summary>
        Number

        ''' <summary>数字(ｶﾝﾏ編集)</summary>
        Currency

        ''' <summary>ｺｰﾄﾞ値(ｾﾞﾛﾊﾟﾃﾞｨﾝｸﾞする)</summary>
        Code

        ''' <summary>日付</summary>
        YYYYMMDD

        ''' <summary>時刻</summary>
        Time

        ''' <summary>日付+時刻(yyyy/mm/dd hh:mm:ss)</summary>
        DateTimeF

        ''' <summary>日付+時刻(yyyy/mm/dd hh:mm:ss)</summary>
        DateTimeT

        ''' <summary>日付+時刻(yyyy/mm/dd hh:mm)</summary>
        DateTimeMinute

        ''' <summary>年月</summary>
        YYYYMM

        ''' <summary>郵便番号</summary>
        Post
    End Enum
End Class
