Namespace Common
    Public Class Array
        Public Shared Sub Remove(ByRef TargetArray As String(), ByVal deleteIndex As Integer)
            '�ꎞ�ۊǗp�z��   
            Dim newArray As String()
            ReDim newArray(TargetArray.GetUpperBound(0) - 1)

            '�ꎞ�ۊǗp�z��ɂ��ׂĂ��R�s�[����   
            System.Array.Copy(TargetArray, 0, newArray, 0, deleteIndex)

            '�ꎞ�ۊǗp�z��ɍ폜�Ώۂ̗v�f�ȍ~�̒l���R�s�[����   
            System.Array.Copy(TargetArray, deleteIndex + 1, newArray, deleteIndex, TargetArray.GetUpperBound(0) - deleteIndex)

            '�I���W�i���̔z��̊i�[�̈���Ċ��蓖��   
            ReDim TargetArray(newArray.GetUpperBound(0))

            '�l����   
            TargetArray = newArray
        End Sub
    End Class
End Namespace
