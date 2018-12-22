'Imports SPM.VBMySQL

Public Class Main : Inherits MetroFramework.Forms.MetroForm

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmProduct_type.Show()
    End Sub

    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick
        MessageBox.Show(MetroGrid1.CurrentCell.Value.ToString)
    End Sub
End Class
