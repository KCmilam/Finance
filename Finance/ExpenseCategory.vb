Imports System.Xml.Serialization

Public Class ExpenseCategory
    <XmlAttribute("Name")> Public Property Name As String
    <XmlElement("TransactionNames")> Public Property TransactionNames As New List(Of String)
    <XmlAttribute("MinAmount")> Public Property MinAmount As Decimal
    <XmlAttribute("MaxAmount")> Public Property MaxAmount As Decimal

    <XmlIgnore()> Public Property TotalOut_Custom As Decimal

    Public Sub New()

    End Sub

    Public Sub New(Name As String)
        Me.Name = Name
    End Sub

    Public Overrides Function ToString() As String
        Return Name
    End Function

    Public Function GetTransactions(Account As Account, Optional ByVal IgnoreDate As Boolean = False) As List(Of Transaction)
        Dim result As New List(Of Transaction)
        For Each mTransaction In Account.Transactions
            If (mTransaction.TransactionDate >= Account.StartDate And mTransaction.TransactionDate < Account.EndDate) Or IgnoreDate Then
                If Name = "All" Then
                    If (MinAmount = 0 And MaxAmount = 0) Or (mTransaction.Amount >= MinAmount And mTransaction.Amount <= MaxAmount) Then
                        result.Add(mTransaction)
                    End If
                Else
                    For Each mName As String In TransactionNames
                        If (MinAmount = 0 And MaxAmount = 0) Or (mTransaction.Amount >= MinAmount And mTransaction.Amount <= MaxAmount) Then
                            If mTransaction.Description.ToUpper.Contains(mName.ToUpper) Then
                                result.Add(mTransaction)
                            End If
                        End If
                    Next
                End If
            End If
        Next
        Return result
    End Function

    Public Function GetTransactions(Account As Account, StartDate As Date, EndDate As Date) As List(Of Transaction)
        Dim result As New List(Of Transaction)
        For Each mTransaction In Account.Transactions
            If (mTransaction.TransactionDate >= StartDate And mTransaction.TransactionDate < EndDate) Then
                If Name = "All" Then
                    If (MinAmount = 0 And MaxAmount = 0) Or (mTransaction.Amount >= MinAmount And mTransaction.Amount <= MaxAmount) Then
                        result.Add(mTransaction)
                    End If
                Else
                    For Each mName As String In TransactionNames
                        If (MinAmount = 0 And MaxAmount = 0) Or (mTransaction.Amount >= MinAmount And mTransaction.Amount <= MaxAmount) Then
                            If mTransaction.Description.ToUpper.Contains(mName.ToUpper) Then
                                result.Add(mTransaction)
                            End If
                        End If
                    Next
                End If
            End If
        Next
        Return result
    End Function

    Public Function GetTransactions(Grid As DataGridView) As List(Of Transaction)
        Dim result As New List(Of Transaction)
        For Each mRow As DataGridViewRow In Grid.Rows
            Dim mTrans As Transaction = mRow.DataBoundItem
            If mTrans IsNot Nothing Then
                If (MinAmount = 0 And MaxAmount = 0) Or (mTrans.Amount >= MinAmount And mTrans.Amount <= MaxAmount) Then
                    For Each mName As String In TransactionNames
                        If mTrans.Description.ToUpper.Contains(mName.ToUpper) Then
                            result.Add(mTrans)
                        End If
                    Next
                End If
            End If
        Next
        Return result
    End Function

    Public ReadOnly Property TotalOut(Account As Account, Optional ByVal StartDate As Date = Nothing, Optional ByVal EndDate As Date = Nothing) As Decimal
        Get
            Dim Total As Decimal = 0
            Dim mTransactions As List(Of Transaction) = Nothing
            If StartDate <> Nothing Then
                mTransactions = GetTransactions(Account, StartDate, EndDate)
            Else
                mTransactions = GetTransactions(Account)
            End If
            For Each mTrans As Transaction In mTransactions
                If mTrans.Amount < 0 Then Total += mTrans.Amount
            Next
            Return Total
        End Get
    End Property

    Public ReadOnly Property TotalOut(Grid As DataGridView) As Decimal
        Get
            Dim Total As Decimal = 0
            For Each mTrans As Transaction In GetTransactions(Grid)
                If mTrans.Amount < 0 Then Total += mTrans.Amount
            Next
            Return Total
        End Get
    End Property

    Public ReadOnly Property TotalIn(Account As Account) As Decimal
        Get
            Dim Total As Decimal = 0
            For Each mTrans As Transaction In GetTransactions(Account)
                If mTrans.Amount > 0 Then Total += mTrans.Amount
            Next
            Return Total
        End Get
    End Property
End Class
