
Imports Newtonsoft.Json
Imports SPM

Public Class Main : Inherits MetroFramework.Forms.MetroForm

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim ds As New spmDataSet
        Dim da As New spmDataSetTableAdapters.generalInvoiceInfoTableAdapter

        da.Fill(ds.generalInvoiceInfo)
        Dim json As String = JsonConvert.SerializeObject(ds, Formatting.Indented)
        MessageBox.Show(json)
    End Sub
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpmDataSet.generalInvoiceInfo' table. You can move, or remove it, as needed.
        Me.GeneralInvoiceInfoTableAdapter.Fill(Me.SpmDataSet.generalInvoiceInfo)

    End Sub
End Class
