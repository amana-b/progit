Public Class Contents
    Public Enum Compare
        ''' <summary>�Ȃ�</summary>
        None

        ''' <summary>������</summary>
        Equal

        ''' <summary>�������Ȃ�</summary>
        NotEqual

        ''' <summary>��菬����</summary>
        Less

        ''' <summary>�ȉ�</summary>
        LessEqual

        ''' <summary>���傫��</summary>
        Greater

        ''' <summary>�ȏ�</summary>
        GreaterEqual

        ''' <summary>�O����v</summary>
        LikeFront

        ''' <summary>�����v</summary>
        LikeRear

        ''' <summary>���Ԉ�v</summary>
        LikeCenter

        ''' <summary>In</summary>
        WithIn

        ''' <summary>IsNull</summary>
        IsNull

        ''' <summary>IsNull</summary>
        IsNotNull

        ''' <summary>���ڋL�q</summary>
        Direct

        ''' <summary>�ı�ޓ������Ұ�</summary>
        Parameter
    End Enum

    Public Enum EmptyHandle
        ''' <summary>�Ȃ�</summary>
        None

        ''' <summary>�l���󔒂̏ꍇ�ł��i���̏����Ɋ܂߂�</summary>
        Where

        ''' <summary>�l���󔒂̏ꍇ�͍i���̏����Ɋ܂߂Ȃ�</summary>
        Skip
    End Enum
End Class
