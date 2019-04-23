Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Public Class Product
    Private Sub Product_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim conn As SqlConnection = Mssqlserver.GetDBConnection()
        conn.Open()
        Dim da As SqlDataAdapter = New SqlDataAdapter("Select ma, ten from mavt where len(ma) = 14 order by ma", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        For Each Row In dt.Rows
            Row("ten") = SPM.Convert.VNItoUNICODE(Row("ten").ToString)
        Next
        GridProduct.DataSource = dt

    End Sub

    Private Sub LKEnhom_GotFocus(sender As Object, e As EventArgs) Handles LKEnhom.GotFocus
        Dim Nhoms As List(Of Nhom) = New List(Of Nhom)()
        Nhoms.Add(New Nhom() With {
            .MaNhom = "01",
            .TenNhom = "Vitamin khoáng chất"
        })
        Nhoms.Add(New Nhom() With {
            .MaNhom = "02",
            .TenNhom = "Giảm đau, hạ nhiệt, kháng viêm, dị ứng"
        })
        Nhoms.Add(New Nhom() With {
            .MaNhom = "03",
            .TenNhom = "Tim mạch, thần kinh,tuần hoàn não"
        })
        Nhoms.Add(New Nhom() With {
            .MaNhom = "04",
            .TenNhom = "Kháng nấm"
        })
        Nhoms.Add(New Nhom() With {
            .MaNhom = "05",
            .TenNhom = "Kháng sinh"
        })
        Nhoms.Add(New Nhom() With {
            .MaNhom = "06",
            .TenNhom = "Tiêu hóa, thận niệu"
        })
        Nhoms.Add(New Nhom() With {
            .MaNhom = "07",
            .TenNhom = "Giảm ho, long đàm, hô hấp"
        })
        Nhoms.Add(New Nhom() With {
            .MaNhom = "08",
            .TenNhom = "Tẩy giun"
        })
        LKEnhom.Properties.DataSource = Nhoms
        LKEnhom.Properties.ValueMember = "MaNhom"
        LKEnhom.Properties.DisplayMember = "TenNhom"
        'AddHandler LKEnhom.CustomDisplayText, AddressOf LKEnhom_CustomDisplayText

    End Sub

    Private Sub LKEnhom_CustomDisplayText(sender As Object, e As CustomDisplayTextEventArgs) Handles LKEnhom.CustomDisplayText
        Dim lookUpEdit As LookUpEdit = TryCast(sender, LookUpEdit)
        Dim nhoms As Nhom = TryCast(lookUpEdit.Properties.GetDataSourceRowByKeyValue(e.Value), Nhom)
        If nhoms IsNot Nothing Then
            e.DisplayText = nhoms.MaNhom & ", " & nhoms.TenNhom
        End If
    End Sub

    Private Sub LKEnhom_EditValueChanged(sender As Object, e As EventArgs) Handles LKEnhom.EditValueChanged
        txtTen.Text = LKEnhom.Text
    End Sub

    Public Class Nhom
        Public Property MaNhom As String
        Public Property TenNhom As String
    End Class
End Class