Public Class Contents
    Public Enum Compare
        ''' <summary>なし</summary>
        None

        ''' <summary>等しい</summary>
        Equal

        ''' <summary>等しくない</summary>
        NotEqual

        ''' <summary>より小さい</summary>
        Less

        ''' <summary>以下</summary>
        LessEqual

        ''' <summary>より大きい</summary>
        Greater

        ''' <summary>以上</summary>
        GreaterEqual

        ''' <summary>前方一致</summary>
        LikeFront

        ''' <summary>後方一致</summary>
        LikeRear

        ''' <summary>中間一致</summary>
        LikeCenter

        ''' <summary>In</summary>
        WithIn

        ''' <summary>IsNull</summary>
        IsNull

        ''' <summary>IsNull</summary>
        IsNotNull

        ''' <summary>直接記述</summary>
        Direct

        ''' <summary>ｽﾄｱﾄﾞ等のﾊﾟﾗﾒｰﾀ</summary>
        Parameter
    End Enum

    Public Enum EmptyHandle
        ''' <summary>なし</summary>
        None

        ''' <summary>値が空白の場合でも絞込の条件に含める</summary>
        Where

        ''' <summary>値が空白の場合は絞込の条件に含めない</summary>
        Skip
    End Enum
End Class
