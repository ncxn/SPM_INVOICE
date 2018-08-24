Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace InvoiceClient
    Public Class Docso
        Public Shared Function DocSoThanhChu(ByVal number As String) As String
            Dim strReturn As String = ""
            Dim s As String = number

            While s.Length > 0 AndAlso s.Substring(0, 1) = "0"
                s = s.Substring(1)
            End While

            Dim so As String() = New String() {"không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín"}
            Dim hang As String() = New String() {"", "nghìn", "triệu", "tỷ"}
            Dim i, j, donvi, chuc, tram As Integer
            Dim booAm As Boolean = False
            Dim decS As Decimal = 0

            Try
                decS = Convert.ToDecimal(s.ToString())
            Catch
            End Try

            If decS < 0 Then
                decS = -decS
                booAm = True
            End If

            i = s.Length

            If i = 0 Then
                strReturn = so(0) & strReturn
            Else
                j = 0

                While i > 0
                    donvi = Convert.ToInt32(s.Substring(i - 1, 1))
                    i -= 1

                    If i > 0 Then
                        chuc = Convert.ToInt32(s.Substring(i - 1, 1))
                    Else
                        chuc = -1
                    End If

                    i -= 1

                    If i > 0 Then
                        tram = Convert.ToInt32(s.Substring(i - 1, 1))
                    Else
                        tram = -1
                    End If

                    i -= 1
                    If (donvi > 0) OrElse (chuc > 0) OrElse (tram > 0) OrElse (j = 3) Then strReturn = hang(j) & strReturn
                    j += 1
                    If j > 3 Then j = 1

                    If (donvi = 1) AndAlso (chuc > 1) Then
                        strReturn = "mốt " & strReturn
                    Else

                        If (donvi = 5) AndAlso (chuc > 0) Then
                            strReturn = "lăm " & strReturn
                        ElseIf donvi > 0 Then
                            strReturn = so(donvi) & " " & strReturn
                        End If
                    End If

                    If chuc < 0 Then
                        Exit While
                    Else
                        If (chuc = 0) AndAlso (donvi > 0) Then strReturn = "linh " & strReturn
                        If chuc = 1 Then strReturn = "mười " & strReturn
                        If chuc > 1 Then strReturn = so(chuc) & " mươi " & strReturn
                    End If

                    If tram < 0 Then
                        Exit While
                    Else
                        If (tram > 0) OrElse (chuc > 0) OrElse (donvi > 0) Then strReturn = so(tram) & " trăm " & strReturn
                    End If

                    strReturn = " " & strReturn
                End While
            End If

            If booAm Then strReturn = "Âm " & strReturn
            Dim result As String = strReturn.Trim().Substring(0, 1).ToUpper() & strReturn.Trim().Substring(1) & " đồng chẵn"
            Return result
        End Function

    End Class
End Namespace
