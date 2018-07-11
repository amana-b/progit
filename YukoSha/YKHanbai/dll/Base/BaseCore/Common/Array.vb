Namespace Common
    Public Class Array
        Public Shared Sub Remove(ByRef TargetArray As String(), ByVal deleteIndex As Integer)
            '一時保管用配列   
            Dim newArray As String()
            ReDim newArray(TargetArray.GetUpperBound(0) - 1)

            '一時保管用配列にすべてをコピーする   
            System.Array.Copy(TargetArray, 0, newArray, 0, deleteIndex)

            '一時保管用配列に削除対象の要素以降の値をコピーする   
            System.Array.Copy(TargetArray, deleteIndex + 1, newArray, deleteIndex, TargetArray.GetUpperBound(0) - deleteIndex)

            'オリジナルの配列の格納領域を再割り当て   
            ReDim TargetArray(newArray.GetUpperBound(0))

            '値を代入   
            TargetArray = newArray
        End Sub
    End Class
End Namespace
