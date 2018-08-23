Imports System.Net
Imports System.Net.Security
Imports System.IO

Namespace InvoiceClient
    Public Class GuiJSON
        Public Shared Function Send(ByVal pzUrl As String, ByVal pzData As String, ByVal pzAuthorization As String, ByVal pzMethod As String, ByVal pzContentType As String) As String
            Dim Req As HttpWebRequest = CType(WebRequest.Create(pzUrl), HttpWebRequest)
            Req.ContentType = pzContentType
            Req.Method = pzMethod
            Req.Headers.Add("Authorization", "Basic " & pzAuthorization)
            Req.Proxy = New WebProxy()

            If Not String.IsNullOrEmpty(pzData) Then

                Using streamWriter = New StreamWriter(Req.GetRequestStream())
                    Dim json As String = pzData
                    streamWriter.Write(json)
                    streamWriter.Flush()
                    streamWriter.Close()
                End Using
            End If

            InitiateSSLTrust()
            Dim httpResponse = CType(Req.GetResponse(), HttpWebResponse)
            Dim result = String.Empty

            Using streamReader = New StreamReader(httpResponse.GetResponseStream())
                result = streamReader.ReadToEnd()
            End Using

            Return result
        End Function

        Public Shared Sub InitiateSSLTrust()
            Try
                ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(Function() True)
            Catch ex As Exception
            End Try
        End Sub

        Public Shared Function Base64Encode(ByVal plainText As String) As String
            Dim plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText)
            Return System.Convert.ToBase64String(plainTextBytes)
        End Function

        Public Shared Function Base64Decode(ByVal base64EncodedData As String) As String
            Dim base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData)
            Return System.Text.Encoding.UTF8.GetString(base64EncodedBytes)
        End Function
    End Class
End Namespace
