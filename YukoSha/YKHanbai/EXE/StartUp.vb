Public Class StartUp
    Shared Sub Main(ByVal args() As String)
        If args.Length = 0 Then
            Application.Run(New MenuEigyo)
        Else
            Select Case args(0)
                Case "Eigyo" : Application.Run(New MenuEigyo)
                Case "Gyomu" : Application.Run(New MenuEigyo)
                Case "Kojyo" : Application.Run(New MenuEigyo)
                Case "Keiri" : Application.Run(New MenuEigyo)
                Case "Yama" : Application.Run(New MenuEigyo)
                Case Else : Application.Run(New MenuEigyo)
            End Select
        End If
    End Sub
End Class
