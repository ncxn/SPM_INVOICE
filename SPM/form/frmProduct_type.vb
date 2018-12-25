
Public Class frmProduct_type

    Private Sub FrmProduct_type_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim mysql As New MYSQLSERVER
        Dim tb As New DataTable
        tb = mysql.Get_Table("Select * From product_type")

    End Sub

End Class