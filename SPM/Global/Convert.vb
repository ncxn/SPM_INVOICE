Imports ConvertDB.vnConvert
Namespace SPM
    Public Class Convert

        Public Shared Function VNItoUNICODE(vnstr As String) As String
            Dim convertF As ConvertFont = New ConvertFont()
            Dim VNI As FontIndex = FontIndex.iVNI
            Dim UNI As FontIndex = FontIndex.iUNI
            convertF.Convert(vnstr, VNI, UNI)
            Return vnstr
        End Function
    End Class
End Namespace