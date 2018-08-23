<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.SpmDataSet = New SPM.spmDataSet()
        Me.SpmDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralInvoiceInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralInvoiceInfoTableAdapter = New SPM.spmDataSetTableAdapters.generalInvoiceInfoTableAdapter()
        Me.TransactionUuidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TemplateCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceSeriesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceIssuedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdjustmentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceNoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OriginalInvoiceIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdjustmentInvoiceTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OriginalInvoiceIssueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdditionalReferenceDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdditionalReferenceDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentStatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PaymentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentTypeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CusGetInvoiceRightDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BuyerIdTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuyerIdNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpmDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpmDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralInvoiceInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(23, 63)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(155, 44)
        Me.MetroButton1.TabIndex = 0
        Me.MetroButton1.Text = "MetroButton1"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.AutoGenerateColumns = False
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionUuidDataGridViewTextBoxColumn, Me.InvoiceTypeDataGridViewTextBoxColumn, Me.TemplateCodeDataGridViewTextBoxColumn, Me.InvoiceSeriesDataGridViewTextBoxColumn, Me.InvoiceIssuedDateDataGridViewTextBoxColumn, Me.CurrencyCodeDataGridViewTextBoxColumn, Me.AdjustmentTypeDataGridViewTextBoxColumn, Me.InvoiceNoDataGridViewTextBoxColumn, Me.InvoiceNoteDataGridViewTextBoxColumn, Me.OriginalInvoiceIdDataGridViewTextBoxColumn, Me.AdjustmentInvoiceTypeDataGridViewTextBoxColumn, Me.OriginalInvoiceIssueDateDataGridViewTextBoxColumn, Me.AdditionalReferenceDescDataGridViewTextBoxColumn, Me.AdditionalReferenceDateDataGridViewTextBoxColumn, Me.PaymentStatusDataGridViewCheckBoxColumn, Me.PaymentTypeDataGridViewTextBoxColumn, Me.PaymentTypeNameDataGridViewTextBoxColumn, Me.CusGetInvoiceRightDataGridViewCheckBoxColumn, Me.BuyerIdTypeDataGridViewTextBoxColumn, Me.BuyerIdNoDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn})
        Me.MetroGrid1.DataSource = Me.GeneralInvoiceInfoBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 159)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(754, 270)
        Me.MetroGrid1.TabIndex = 1
        '
        'SpmDataSet
        '
        Me.SpmDataSet.DataSetName = "spmDataSet"
        Me.SpmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpmDataSetBindingSource
        '
        Me.SpmDataSetBindingSource.DataSource = Me.SpmDataSet
        Me.SpmDataSetBindingSource.Position = 0
        '
        'GeneralInvoiceInfoBindingSource
        '
        Me.GeneralInvoiceInfoBindingSource.DataMember = "generalInvoiceInfo"
        Me.GeneralInvoiceInfoBindingSource.DataSource = Me.SpmDataSetBindingSource
        '
        'GeneralInvoiceInfoTableAdapter
        '
        Me.GeneralInvoiceInfoTableAdapter.ClearBeforeFill = True
        '
        'TransactionUuidDataGridViewTextBoxColumn
        '
        Me.TransactionUuidDataGridViewTextBoxColumn.DataPropertyName = "transactionUuid"
        Me.TransactionUuidDataGridViewTextBoxColumn.HeaderText = "transactionUuid"
        Me.TransactionUuidDataGridViewTextBoxColumn.Name = "TransactionUuidDataGridViewTextBoxColumn"
        '
        'InvoiceTypeDataGridViewTextBoxColumn
        '
        Me.InvoiceTypeDataGridViewTextBoxColumn.DataPropertyName = "invoiceType"
        Me.InvoiceTypeDataGridViewTextBoxColumn.HeaderText = "invoiceType"
        Me.InvoiceTypeDataGridViewTextBoxColumn.Name = "InvoiceTypeDataGridViewTextBoxColumn"
        '
        'TemplateCodeDataGridViewTextBoxColumn
        '
        Me.TemplateCodeDataGridViewTextBoxColumn.DataPropertyName = "templateCode"
        Me.TemplateCodeDataGridViewTextBoxColumn.HeaderText = "templateCode"
        Me.TemplateCodeDataGridViewTextBoxColumn.Name = "TemplateCodeDataGridViewTextBoxColumn"
        '
        'InvoiceSeriesDataGridViewTextBoxColumn
        '
        Me.InvoiceSeriesDataGridViewTextBoxColumn.DataPropertyName = "invoiceSeries"
        Me.InvoiceSeriesDataGridViewTextBoxColumn.HeaderText = "invoiceSeries"
        Me.InvoiceSeriesDataGridViewTextBoxColumn.Name = "InvoiceSeriesDataGridViewTextBoxColumn"
        '
        'InvoiceIssuedDateDataGridViewTextBoxColumn
        '
        Me.InvoiceIssuedDateDataGridViewTextBoxColumn.DataPropertyName = "invoiceIssuedDate"
        Me.InvoiceIssuedDateDataGridViewTextBoxColumn.HeaderText = "invoiceIssuedDate"
        Me.InvoiceIssuedDateDataGridViewTextBoxColumn.Name = "InvoiceIssuedDateDataGridViewTextBoxColumn"
        '
        'CurrencyCodeDataGridViewTextBoxColumn
        '
        Me.CurrencyCodeDataGridViewTextBoxColumn.DataPropertyName = "currencyCode"
        Me.CurrencyCodeDataGridViewTextBoxColumn.HeaderText = "currencyCode"
        Me.CurrencyCodeDataGridViewTextBoxColumn.Name = "CurrencyCodeDataGridViewTextBoxColumn"
        '
        'AdjustmentTypeDataGridViewTextBoxColumn
        '
        Me.AdjustmentTypeDataGridViewTextBoxColumn.DataPropertyName = "adjustmentType "
        Me.AdjustmentTypeDataGridViewTextBoxColumn.HeaderText = "adjustmentType "
        Me.AdjustmentTypeDataGridViewTextBoxColumn.Name = "AdjustmentTypeDataGridViewTextBoxColumn"
        '
        'InvoiceNoDataGridViewTextBoxColumn
        '
        Me.InvoiceNoDataGridViewTextBoxColumn.DataPropertyName = "invoiceNo"
        Me.InvoiceNoDataGridViewTextBoxColumn.HeaderText = "invoiceNo"
        Me.InvoiceNoDataGridViewTextBoxColumn.Name = "InvoiceNoDataGridViewTextBoxColumn"
        '
        'InvoiceNoteDataGridViewTextBoxColumn
        '
        Me.InvoiceNoteDataGridViewTextBoxColumn.DataPropertyName = "invoiceNote"
        Me.InvoiceNoteDataGridViewTextBoxColumn.HeaderText = "invoiceNote"
        Me.InvoiceNoteDataGridViewTextBoxColumn.Name = "InvoiceNoteDataGridViewTextBoxColumn"
        '
        'OriginalInvoiceIdDataGridViewTextBoxColumn
        '
        Me.OriginalInvoiceIdDataGridViewTextBoxColumn.DataPropertyName = "originalInvoiceId"
        Me.OriginalInvoiceIdDataGridViewTextBoxColumn.HeaderText = "originalInvoiceId"
        Me.OriginalInvoiceIdDataGridViewTextBoxColumn.Name = "OriginalInvoiceIdDataGridViewTextBoxColumn"
        '
        'AdjustmentInvoiceTypeDataGridViewTextBoxColumn
        '
        Me.AdjustmentInvoiceTypeDataGridViewTextBoxColumn.DataPropertyName = "adjustmentInvoiceType"
        Me.AdjustmentInvoiceTypeDataGridViewTextBoxColumn.HeaderText = "adjustmentInvoiceType"
        Me.AdjustmentInvoiceTypeDataGridViewTextBoxColumn.Name = "AdjustmentInvoiceTypeDataGridViewTextBoxColumn"
        '
        'OriginalInvoiceIssueDateDataGridViewTextBoxColumn
        '
        Me.OriginalInvoiceIssueDateDataGridViewTextBoxColumn.DataPropertyName = "originalInvoiceIssueDate"
        Me.OriginalInvoiceIssueDateDataGridViewTextBoxColumn.HeaderText = "originalInvoiceIssueDate"
        Me.OriginalInvoiceIssueDateDataGridViewTextBoxColumn.Name = "OriginalInvoiceIssueDateDataGridViewTextBoxColumn"
        '
        'AdditionalReferenceDescDataGridViewTextBoxColumn
        '
        Me.AdditionalReferenceDescDataGridViewTextBoxColumn.DataPropertyName = "additionalReferenceDesc "
        Me.AdditionalReferenceDescDataGridViewTextBoxColumn.HeaderText = "additionalReferenceDesc "
        Me.AdditionalReferenceDescDataGridViewTextBoxColumn.Name = "AdditionalReferenceDescDataGridViewTextBoxColumn"
        '
        'AdditionalReferenceDateDataGridViewTextBoxColumn
        '
        Me.AdditionalReferenceDateDataGridViewTextBoxColumn.DataPropertyName = "additionalReferenceDate"
        Me.AdditionalReferenceDateDataGridViewTextBoxColumn.HeaderText = "additionalReferenceDate"
        Me.AdditionalReferenceDateDataGridViewTextBoxColumn.Name = "AdditionalReferenceDateDataGridViewTextBoxColumn"
        '
        'PaymentStatusDataGridViewCheckBoxColumn
        '
        Me.PaymentStatusDataGridViewCheckBoxColumn.DataPropertyName = "paymentStatus"
        Me.PaymentStatusDataGridViewCheckBoxColumn.HeaderText = "paymentStatus"
        Me.PaymentStatusDataGridViewCheckBoxColumn.Name = "PaymentStatusDataGridViewCheckBoxColumn"
        '
        'PaymentTypeDataGridViewTextBoxColumn
        '
        Me.PaymentTypeDataGridViewTextBoxColumn.DataPropertyName = "paymentType"
        Me.PaymentTypeDataGridViewTextBoxColumn.HeaderText = "paymentType"
        Me.PaymentTypeDataGridViewTextBoxColumn.Name = "PaymentTypeDataGridViewTextBoxColumn"
        '
        'PaymentTypeNameDataGridViewTextBoxColumn
        '
        Me.PaymentTypeNameDataGridViewTextBoxColumn.DataPropertyName = "paymentTypeName"
        Me.PaymentTypeNameDataGridViewTextBoxColumn.HeaderText = "paymentTypeName"
        Me.PaymentTypeNameDataGridViewTextBoxColumn.Name = "PaymentTypeNameDataGridViewTextBoxColumn"
        '
        'CusGetInvoiceRightDataGridViewCheckBoxColumn
        '
        Me.CusGetInvoiceRightDataGridViewCheckBoxColumn.DataPropertyName = "cusGetInvoiceRight"
        Me.CusGetInvoiceRightDataGridViewCheckBoxColumn.HeaderText = "cusGetInvoiceRight"
        Me.CusGetInvoiceRightDataGridViewCheckBoxColumn.Name = "CusGetInvoiceRightDataGridViewCheckBoxColumn"
        '
        'BuyerIdTypeDataGridViewTextBoxColumn
        '
        Me.BuyerIdTypeDataGridViewTextBoxColumn.DataPropertyName = "buyerIdType"
        Me.BuyerIdTypeDataGridViewTextBoxColumn.HeaderText = "buyerIdType"
        Me.BuyerIdTypeDataGridViewTextBoxColumn.Name = "BuyerIdTypeDataGridViewTextBoxColumn"
        '
        'BuyerIdNoDataGridViewTextBoxColumn
        '
        Me.BuyerIdNoDataGridViewTextBoxColumn.DataPropertyName = "buyerIdNo"
        Me.BuyerIdNoDataGridViewTextBoxColumn.HeaderText = "buyerIdNo"
        Me.BuyerIdNoDataGridViewTextBoxColumn.Name = "BuyerIdNoDataGridViewTextBoxColumn"
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "userName"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "userName"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.MetroButton1)
        Me.Name = "Main"
        Me.Text = "E Invoice"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpmDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpmDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralInvoiceInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents SpmDataSetBindingSource As BindingSource
    Friend WithEvents SpmDataSet As spmDataSet
    Friend WithEvents GeneralInvoiceInfoBindingSource As BindingSource
    Friend WithEvents GeneralInvoiceInfoTableAdapter As spmDataSetTableAdapters.generalInvoiceInfoTableAdapter
    Friend WithEvents TransactionUuidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InvoiceTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TemplateCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InvoiceSeriesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InvoiceIssuedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrencyCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdjustmentTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InvoiceNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InvoiceNoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OriginalInvoiceIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdjustmentInvoiceTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OriginalInvoiceIssueDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdditionalReferenceDescDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdditionalReferenceDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentStatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PaymentTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentTypeNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CusGetInvoiceRightDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents BuyerIdTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuyerIdNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
