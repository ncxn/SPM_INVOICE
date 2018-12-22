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
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.FOV_product_type = New BrightIdeasSoftware.FastDataListView()
        Me.OlvColumn0 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        CType(Me.FOV_product_type, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "product_type_parent"
        Me.OlvColumn3.AspectToStringFormat = "{0}"
        Me.OlvColumn3.Text = "Cấp"
        Me.OlvColumn3.UseInitialLetterForGroup = True
        Me.OlvColumn3.Width = 126
        '
        'FOV_product_type
        '
        Me.FOV_product_type.AllColumns.Add(Me.OlvColumn0)
        Me.FOV_product_type.AllColumns.Add(Me.OlvColumn1)
        Me.FOV_product_type.AllColumns.Add(Me.OlvColumn2)
        Me.FOV_product_type.AllColumns.Add(Me.OlvColumn3)
        Me.FOV_product_type.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FOV_product_type.AutoGenerateColumns = False
        Me.FOV_product_type.CellEditUseWholeCell = False
        Me.FOV_product_type.CheckBoxes = True
        Me.FOV_product_type.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn0, Me.OlvColumn1, Me.OlvColumn2, Me.OlvColumn3})
        Me.FOV_product_type.Cursor = System.Windows.Forms.Cursors.Default
        Me.FOV_product_type.DataSource = Nothing
        Me.FOV_product_type.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FOV_product_type.EmptyListMsg = "Chưa có danh mục"
        Me.FOV_product_type.EmptyListMsgFont = New System.Drawing.Font("MS Outlook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.FOV_product_type.FullRowSelect = True
        Me.FOV_product_type.Location = New System.Drawing.Point(0, 0)
        Me.FOV_product_type.Name = "FOV_product_type"
        Me.FOV_product_type.ShowImagesOnSubItems = True
        Me.FOV_product_type.Size = New System.Drawing.Size(800, 450)
        Me.FOV_product_type.SortGroupItemsByPrimaryColumn = False
        Me.FOV_product_type.TabIndex = 0
        Me.FOV_product_type.UseCompatibleStateImageBehavior = False
        Me.FOV_product_type.UseFiltering = True
        Me.FOV_product_type.UseSubItemCheckBoxes = True
        Me.FOV_product_type.View = System.Windows.Forms.View.Details
        Me.FOV_product_type.VirtualMode = True
        '
        'OlvColumn0
        '
        Me.OlvColumn0.AspectName = "product_type_code"
        Me.OlvColumn0.Groupable = False
        Me.OlvColumn0.Text = "Mã nhóm"
        Me.OlvColumn0.Width = 103
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "product_type_describe"
        Me.OlvColumn1.Groupable = False
        Me.OlvColumn1.Text = "Nhóm sản phẩm"
        Me.OlvColumn1.Width = 238
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "product_type_active"
        Me.OlvColumn2.CheckBoxes = True
        Me.OlvColumn2.Groupable = False
        Me.OlvColumn2.Text = "Sử dụng"
        Me.OlvColumn2.Width = 171
        '
        'frmProduct_type
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FOV_product_type)
        Me.Name = "frmProduct_type"
        Me.Text = "Nhóm sản phẩm"
        CType(Me.FOV_product_type, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FOV_product_type As BrightIdeasSoftware.FastDataListView
    Friend WithEvents OlvColumn0 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
End Class
