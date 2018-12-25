<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProduct_type
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim HeaderStateStyle1 As BrightIdeasSoftware.HeaderStateStyle = New BrightIdeasSoftware.HeaderStateStyle()
        Dim HeaderStateStyle2 As BrightIdeasSoftware.HeaderStateStyle = New BrightIdeasSoftware.HeaderStateStyle()
        Dim HeaderStateStyle3 As BrightIdeasSoftware.HeaderStateStyle = New BrightIdeasSoftware.HeaderStateStyle()
        Me.HeaderFormatStyle1 = New BrightIdeasSoftware.HeaderFormatStyle()
        Me.Grid_product_type = New DevExpress.XtraGrid.GridControl()
        Me.GridView_pruduct_type = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        Me.frmProduct_typeLayoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.Grid_product_type, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_pruduct_type, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmProduct_typeLayoutControl1ConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmProduct_typeLayoutControl1ConvertedLayout.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeaderFormatStyle1
        '
        Me.HeaderFormatStyle1.Hot = HeaderStateStyle1
        Me.HeaderFormatStyle1.Normal = HeaderStateStyle2
        Me.HeaderFormatStyle1.Pressed = HeaderStateStyle3
        '
        'Grid_product_type
        '
        Me.Grid_product_type.Location = New System.Drawing.Point(12, 12)
        Me.Grid_product_type.MainView = Me.GridView_pruduct_type
        Me.Grid_product_type.Name = "Grid_product_type"
        Me.Grid_product_type.Size = New System.Drawing.Size(776, 426)
        Me.Grid_product_type.TabIndex = 0
        Me.Grid_product_type.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_pruduct_type})
        '
        'GridView_pruduct_type
        '
        Me.GridView_pruduct_type.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.GridView_pruduct_type.GridControl = Me.Grid_product_type
        Me.GridView_pruduct_type.Name = "GridView_pruduct_type"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "GridColumn2"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "GridColumn3"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'frmProduct_typeLayoutControl1ConvertedLayout
        '
        Me.frmProduct_typeLayoutControl1ConvertedLayout.Controls.Add(Me.Grid_product_type)
        Me.frmProduct_typeLayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmProduct_typeLayoutControl1ConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmProduct_typeLayoutControl1ConvertedLayout.Name = "frmProduct_typeLayoutControl1ConvertedLayout"
        Me.frmProduct_typeLayoutControl1ConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmProduct_typeLayoutControl1ConvertedLayout.Size = New System.Drawing.Size(800, 450)
        Me.frmProduct_typeLayoutControl1ConvertedLayout.TabIndex = 1
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(800, 450)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Grid_product_type
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "Grid_product_typeitem"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(780, 430)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'frmProduct_type
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.frmProduct_typeLayoutControl1ConvertedLayout)
        Me.Name = "frmProduct_type"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhóm sản phẩm"
        CType(Me.Grid_product_type, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_pruduct_type, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmProduct_typeLayoutControl1ConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmProduct_typeLayoutControl1ConvertedLayout.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HeaderFormatStyle1 As BrightIdeasSoftware.HeaderFormatStyle
    Friend WithEvents Grid_product_type As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_pruduct_type As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents frmProduct_typeLayoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
