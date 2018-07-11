Public Class Contents
    Public Enum Compare
        ''' <summary>‚È‚µ</summary>
        None

        ''' <summary>“™‚µ‚¢</summary>
        Equal

        ''' <summary>“™‚µ‚­‚È‚¢</summary>
        NotEqual

        ''' <summary>‚æ‚è¬‚³‚¢</summary>
        Less

        ''' <summary>ˆÈ‰º</summary>
        LessEqual

        ''' <summary>‚æ‚è‘å‚«‚¢</summary>
        Greater

        ''' <summary>ˆÈã</summary>
        GreaterEqual

        ''' <summary>‘O•ûˆê’v</summary>
        LikeFront

        ''' <summary>Œã•ûˆê’v</summary>
        LikeRear

        ''' <summary>’†ŠÔˆê’v</summary>
        LikeCenter

        ''' <summary>In</summary>
        WithIn

        ''' <summary>IsNull</summary>
        IsNull

        ''' <summary>IsNull</summary>
        IsNotNull

        ''' <summary>’¼Ú‹Lq</summary>
        Direct

        ''' <summary>½Ä±ÄŞ“™‚ÌÊß×Ò°À</summary>
        Parameter
    End Enum

    Public Enum EmptyHandle
        ''' <summary>‚È‚µ</summary>
        None

        ''' <summary>’l‚ª‹ó”’‚Ìê‡‚Å‚ài‚ÌğŒ‚ÉŠÜ‚ß‚é</summary>
        Where

        ''' <summary>’l‚ª‹ó”’‚Ìê‡‚Íi‚ÌğŒ‚ÉŠÜ‚ß‚È‚¢</summary>
        Skip
    End Enum
End Class
