<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LKEnhom = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTen = New DevExpress.XtraEditors.TextEdit()
        Me.CbNhom = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GridProduct = New DevExpress.XtraGrid.GridControl()
        Me.GVProduct = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ten = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.LKEnhom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbNhom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GridProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LKEnhom)
        Me.PanelControl1.Controls.Add(Me.txtTen)
        Me.PanelControl1.Controls.Add(Me.CbNhom)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(266, 384)
        Me.PanelControl1.TabIndex = 1
        '
        'LKEnhom
        '
        Me.LKEnhom.Location = New System.Drawing.Point(12, 157)
        Me.LKEnhom.Name = "LKEnhom"
        Me.LKEnhom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.LKEnhom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LKEnhom.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNhom", "Mã nhóm", 10, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNhom", "Tên nhóm")})
        Me.LKEnhom.Size = New System.Drawing.Size(248, 22)
        Me.LKEnhom.TabIndex = 2
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(12, 94)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(248, 20)
        Me.txtTen.TabIndex = 1
        '
        'CbNhom
        '
        Me.CbNhom.Location = New System.Drawing.Point(12, 48)
        Me.CbNhom.Name = "CbNhom"
        Me.CbNhom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbNhom.Size = New System.Drawing.Size(248, 20)
        Me.CbNhom.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GridProduct)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(266, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(503, 384)
        Me.PanelControl2.TabIndex = 2
        '
        'GridProduct
        '
        Me.GridProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridProduct.Location = New System.Drawing.Point(2, 2)
        Me.GridProduct.MainView = Me.GVProduct
        Me.GridProduct.Name = "GridProduct"
        Me.GridProduct.Size = New System.Drawing.Size(499, 380)
        Me.GridProduct.TabIndex = 0
        Me.GridProduct.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVProduct})
        '
        'GVProduct
        '
        Me.GVProduct.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ma, Me.ten})
        Me.GVProduct.GridControl = Me.GridProduct
        Me.GVProduct.Name = "GVProduct"
        '
        'ma
        '
        Me.ma.Caption = "Mã vật tư"
        Me.ma.FieldName = "ma"
        Me.ma.Name = "ma"
        Me.ma.Visible = True
        Me.ma.VisibleIndex = 0
        '
        'ten
        '
        Me.ten.Caption = "Tên vật tư"
        Me.ten.FieldName = "ten"
        Me.ten.Name = "ten"
        Me.ten.Visible = True
        Me.ten.VisibleIndex = 1
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 384)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "Product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.LKEnhom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbNhom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GridProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridProduct As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVProduct As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CbNhom As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtTen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LKEnhom As DevExpress.XtraEditors.LookUpEdit
End Class
