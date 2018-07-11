'Imports System.IO
Imports ICSharpCode.SharpZipLib

Namespace Common
    Public Class ZipManager
        Private _lastError As String = ""

        Public ReadOnly Property LastError() As String
            Get
                Return _lastError
            End Get
        End Property

        '''========================================================================================
        ''' <summary>ZIPファイルを作成します。</summary>
        ''' <param name="ZipFileName">作成するZIPファイルの名前をパス付きで指定します。</param>
        ''' <param name="CompFileNames">圧縮するファイル名を配列で指定します。</param>
        ''' <param name="password">暗号化する場合はパスワードを指定します。</param>
        ''' <returns>True:成功、False:失敗</returns>
        '''========================================================================================
        Public Function Compless(ByVal ZipFileName As String, ByVal CompFileNames As String(), Optional ByVal password As String = "") As Boolean
            Dim arrCompFileNames As New ArrayList

            For Each strFileName As String In CompFileNames
                arrCompFileNames.Add(strFileName)
            Next

            Return Me.Compless(ZipFileName, arrCompFileNames, password)
        End Function

        Public Function Compless(ByVal ZipFileName As String, ByVal CompFileNames As ArrayList, Optional ByVal password As String = "") As Boolean
            Dim crc As New Checksums.Crc32
            Dim writer As New System.IO.FileStream(ZipFileName, System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.Write)
            Dim zos As New Zip.ZipOutputStream(writer)

            zos.SetLevel(6)
            zos.Password = password

            Dim file As String
            For Each file In CompFileNames
                Try
                    Dim f As String = System.IO.Path.GetFileName(file)
                    Dim ze As New Zip.ZipEntry(f)
                    Dim fs As New System.IO.FileStream( _
                                    file, System.IO.FileMode.Open, _
                                    System.IO.FileAccess.Read, System.IO.FileShare.Read)
                    Dim buffer(fs.Length - 1) As Byte
                    fs.Read(buffer, 0, buffer.Length)
                    fs.Close()

                    crc.Reset()
                    crc.Update(buffer)
                    ze.Crc = crc.Value
                    ze.Size = buffer.Length
                    ze.DateTime = DateTime.Now

                    zos.PutNextEntry(ze)
                    zos.Write(buffer, 0, buffer.Length)
                Catch ex As Exception
                    _lastError = ex.Message
                    zos.Close()
                    writer.Close()
                    Return False
                End Try
            Next file

            zos.Close()
            writer.Close()

            Return True
        End Function

        '''========================================================================================
        ''' <summary>ZIPファイルを解凍します。</summary>
        ''' <param name="ZipFileName">解凍するZIPファイルの名前をパス付きで指定します。</param>
        ''' <param name="MeltPath">解凍先のパスを指定します。</param>
        ''' <param name="password">暗号化されているZIPファイルを解凍する場合はパスワードを指定します。</param>
        ''' <returns>True:成功、False:失敗</returns>
        '''========================================================================================
        Public Function Melt(ByVal ZipFileName As String, ByVal MeltPath As String, Optional ByVal password As String = "") As Boolean
            Dim fs As New System.IO.FileStream( _
                ZipFileName, System.IO.FileMode.Open, _
                System.IO.FileAccess.Read, System.IO.FileShare.Read)
            Dim zis As New Zip.ZipInputStream(fs)

            zis.Password = password

            Dim ze As Zip.ZipEntry
            While True
                Try
                    ze = zis.GetNextEntry()
                    If ze Is Nothing Then
                        Exit While
                    End If

                    If Not ze.IsDirectory Then
                        Dim fileName As String = System.IO.Path.GetFileName(ze.Name)
                        Dim destDir As String = System.IO.Path.Combine( _
                            MeltPath, System.IO.Path.GetDirectoryName(ze.Name))
                        System.IO.Directory.CreateDirectory(destDir)
                        Dim destPath As String = _
                            System.IO.Path.Combine(destDir, fileName)

                        Dim writer As New System.IO.FileStream( _
                            destPath, System.IO.FileMode.Create, _
                            System.IO.FileAccess.Write, System.IO.FileShare.Write)
                        Dim buffer(2047) As Byte
                        Dim len As Integer
                        While True
                            len = zis.Read(buffer, 0, buffer.Length)
                            If len <= 0 Then
                                Exit While
                            End If
                            writer.Write(buffer, 0, len)
                        End While

                        writer.Close()
                    End If
                Catch ex As Exception
                    _lastError = ex.Message
                    zis.Close()
                    fs.Close()
                    Return False
                End Try
            End While

            zis.Close()
            fs.Close()

            Return True
        End Function
    End Class
End Namespace
