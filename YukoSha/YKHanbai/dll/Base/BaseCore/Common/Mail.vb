Imports System.Net.Mail

Namespace Common
    Public Class Mail
        Private Shared _lastError As String

        '''========================================================================================
        ''' <summary>ｴﾗｰﾒｯｾｰｼﾞ</summary>
        '''========================================================================================
        Public Shared ReadOnly Property LastError() As String
            Get
                Return _lastError
            End Get
        End Property

        '''========================================================================================
        ''' <summary>ﾒｰﾙ送信</summary>
        ''' <param name="MailFrom">送信ﾒｰﾙｱﾄﾞﾚｽ</param>
        ''' <param name="MailTo">受信ﾒｰﾙｱﾄﾞﾚｽ</param>
        ''' <param name="Subject">ﾀｲﾄﾙ</param>
        ''' <param name="Body">本文</param>
        ''' <returns>True:正常、False:異常</returns>
        '''========================================================================================
        Public Shared Function SendMail(ByVal MailFrom As String, ByVal MailTo As String, ByVal Subject As String, ByVal Body As String) As Boolean
            Dim addrFrom As MailAddress = New MailAddress(MailFrom)
            Dim addrTo As MailAddress = New MailAddress(MailTo)
            Dim msg As MailMessage = New MailMessage(addrFrom, addrTo)

            msg.Subject = Subject
            msg.Body = Body

            Try
                Dim client As SmtpClient = New SmtpClient(BaseCore.Common.Constant.SMTP)
                client.Send(msg)
            Catch ex As Exception
                _lastError = ex.Message
                Return False
            End Try

            Return True
        End Function
    End Class
End Namespace
