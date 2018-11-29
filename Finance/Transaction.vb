Imports System.Xml.Serialization

Public Class Transaction
    <xmlattribute("Description")> Public Property Description As String
    <XmlAttribute("Amount")> Public Property Amount As Decimal
    <XmlAttribute("Date")> Public Property TransactionDate As Date
    <XmlAttribute("Type")> Public Property TransactionType As Enums.TransactionType
    <XmlAttribute("Balance")> Public Property Balance As Decimal
    <XmlAttribute("ReoccurringAfterPaycheck")> Public Property ReoccurringAfterPaycheck As Boolean
    <XmlAttribute("Enabled")> Public Property Enabled As Boolean = True

    Public Sub New()

    End Sub

    Public Sub New(Description As String, Amount As Decimal, TransDate As Date, TransType As Enums.TransactionType, Balance As Decimal)
        Me.Description = Description
        Me.Amount = Amount
        Me.TransactionDate = TransDate
        Me.TransactionType = TransType
        Me.Balance = Balance
    End Sub

    Public Function Clone() As Transaction
        Return New Transaction(Description, Amount, TransactionDate, TransactionType, 0)
    End Function

    Public Overrides Function ToString() As String
        Return Description
    End Function
End Class
