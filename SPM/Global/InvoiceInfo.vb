Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace InvoiceClient
    Public Class InvoiceInfo
        Public Property uuId As String
        Public Property templateCode As String
        Public Property invoiceSeries As String
        Public Property invoiceIssuedDate As String
        Public Property invoiceType As String
        Public Property currencyCode As String
        Public Property adjustmentType As String
        Public Property paymentStatus As String
        Public Property paymentType As String
        Public Property paymentTypeName As String
        Public Property cusGetInvoiceRight As String
        Public Property buyerIdNo As String
        Public Property buyerIdType As String
        Public Property invoiceNote As String
        Public Property adjustmentInvoiceType As String
        Public Property originalInvoiceId As String
        Public Property originalInvoiceIssueDate As String
        Public Property additionalReferenceDesc As String
        Public Property additionalReferenceDate As String
    End Class

    Public Class BuyerInfo
        Public Property buyerName As String
        Public Property buyerLegalName As String
        Public Property buyerTaxCode As String
        Public Property buyerAddressLine As String
        Public Property buyerPhoneNumber As String
        Public Property buyerEmail As String
        Public Property buyerIdNo As String
        Public Property buyerIdType As String
    End Class

    Public Class SellerInfo
        Public Property sellerLegalName As String
        Public Property sellerTaxCode As String
        Public Property sellerAddressLine As String
        Public Property sellerPhoneNumber As String
        Public Property sellerEmail As String
        Public Property sellerBankName As String
        Public Property sellerBankAccount As String
    End Class

    Public Class ItemInfo
        Public Property lineNumber As String
        Public Property itemCode As String
        Public Property itemName As String
        Public Property unitName As String
        Public Property unitPrice As String
        Public Property quantity As String
        Public Property itemTotalAmountWithoutTax As String
        Public Property taxPercentage As String
        Public Property taxAmount As String
        Public Property discount As String
        Public Property itemDiscount As String
        Public Property adjustmentTaxAmount As String
        Public Property isIncreaseItem As String
    End Class

    Public Class ZipFileResponse
        Public Property errorCode As String
        Public Property description As String
        Public Property fileName As String
        Public Property fileToBytes As Byte()
        Public Property paymentStatus As Boolean
    End Class

    Public Class GetFileRequest
        Public Property invoiceNo As String
        Public Property fileType As String
        Public Property strIssueDate As String
        Public Property additionalReferenceDesc As String
        Public Property additionalReferenceDate As String
        Public Property pattern As String
        Public Property transactionUuid As String
    End Class

    Public Class PDFFileResponse
        Public Property errorCode As String
        Public Property description As String
        Public Property fileName As String
        Public Property fileToBytes As Byte()
    End Class

    Public Class SummarizeInfo
        Public Property sumOfTotalLineAmountWithoutTax As String
        Public Property totalAmountWithoutTax As String
        Public Property totalTaxAmount As String
        Public Property totalAmountWithTax As String
        Public Property totalAmountWithTaxInWords As String
        Public Property discountAmount As String
        Public Property settlementDiscountAmount As String
        Public Property taxPercentage As String
    End Class

    Public Class TaxBreakdowns
        Public Property taxPercentage As String
        Public Property taxableAmount As String
        Public Property taxAmount As String
    End Class
End Namespace
