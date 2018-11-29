Imports System.Xml.Serialization
Imports System.IO
Imports System.Text.RegularExpressions


Public Class Account
    <XmlAttribute("Name")> Public Property Name As String
    <XmlElement("ExpenseCategories")> Public Property ExpenseCategories As New List(Of ExpenseCategory)
    <XmlElement("ReoccurringTransactions")> Public Property ReoccurringTransactions As New List(Of Transaction)

    <XmlIgnore> Public Property Transactions As New List(Of Transaction)
    <XmlIgnore> Public Property DisplayTransactions As New List(Of Transaction)
    <XmlIgnore()> Public Property SelectedCategory As String = "All"
    <XmlIgnore()> Public Property StartDate As Date
    <XmlIgnore()> Public Property EndDate As Date

    Public Sub New()
    End Sub

    Public Sub New(Name As String)
        Me.Name = Name
    End Sub

    Public Sub Save()
        Dim TextWriter As New Xml.XmlTextWriter(My.Application.Info.DirectoryPath & "\Account.xml", Nothing)
        TextWriter.Formatting = Xml.Formatting.Indented
        Dim Serializer As New XmlSerializer(GetType(Account))
        Try
            Serializer.Serialize(TextWriter, Me)
        Catch ex As Exception
            MsgBox("Error saving account: " & ex.Message)
        End Try
        TextWriter.Close()
    End Sub

    Public Shared Function Open() As Account
        Dim TextReader As Xml.XmlTextReader = Nothing
        Dim Serializer As New XmlSerializer(GetType(Account))
        Try
            TextReader = New Xml.XmlTextReader(My.Application.Info.DirectoryPath & "\Account.xml")

            If Serializer.CanDeserialize(TextReader) Then
                Open = Serializer.Deserialize(TextReader)
                TextReader.Close()
            Else
                Open = Nothing
                TextReader.Close()
            End If
        Catch ex As Exception
            TextReader.Close()
            Throw New NotSupportedException("Unable to read unit account file: " & vbLf & My.Application.Info.DirectoryPath & "\Account.xml" & vbLf & ex.Message)
        End Try
    End Function

    Public Sub ParseFile(FileName As String)
        Dim sr As New StreamReader(FileName)
        Do While sr.Peek() >= 0

            Dim line As String = sr.ReadLine
            line = line.Replace("Nortek,", "Nortek")
            line = Regex.Replace(line, "  \d\d/\d\d", "").Trim
            If line.Contains(",") Then
                Dim Raw As String() = line.Split(",")
                If Raw.Count >= 6 AndAlso IsNumeric(Raw(3)) Then
                    AddTransaction(Regex.Replace(Raw(2), "\d\d/\d\d", "").Replace("""", "").Trim, Val(Raw(3).Trim), Raw(1).Trim, System.Enum.Parse(GetType(Enums.TransactionType), Raw(4).Trim), Val(Raw(5)))
                    Transactions(Transactions.Count - 1).Balance = 0
                End If
            End If
        Loop

        'Complete pending balance
        Dim EndOfPendingIndex As Integer = 0
        For i As Integer = 0 To Transactions.Count - 1
            If Transactions(i).Balance <> 0 Then
                EndOfPendingIndex = i
                Exit For
            End If
        Next


        For i As Integer = EndOfPendingIndex - 1 To 0 Step -1
            Transactions(i).Balance = Transactions(i + 1).Balance + Transactions(i).Amount
        Next
    End Sub

    Public Function GetExpenseCategory(Name As String) As ExpenseCategory
        For Each mCat As ExpenseCategory In ExpenseCategories
            If mCat.Name.ToUpper = Name.ToUpper Then
                Return mCat
            End If
        Next

        Dim NewExpenseCategory As New ExpenseCategory(Name)
        ExpenseCategories.Add(NewExpenseCategory)
        Return NewExpenseCategory
    End Function

    Public Function ExpenseCategoryExists(Name As String) As Boolean
        For Each mCat As ExpenseCategory In ExpenseCategories
            For Each mName As String In mCat.TransactionNames
                Try
                    If Name.ToUpper.Contains(mName.ToUpper) Then
                        Return True
                    End If
                Catch

                End Try
            Next
        Next
        Return False
    End Function

    Public Function AddTransaction(Description As String, Amount As Decimal, TransDate As Date, TransType As Enums.TransactionType, Balance As Decimal) As Transaction
        Dim NewTransaction As New Transaction(Description, Amount, TransDate, TransType, Balance)
        Transactions.Add(NewTransaction)
        Return NewTransaction
    End Function

    <XmlIgnore()> Public ReadOnly Property GetNortekPaychecks(Optional ByVal IgnoreDate As Boolean = False) As List(Of Transaction)
        Get
            Return GetExpenseCategory("Nortek Income").GetTransactions(Me, IgnoreDate)
        End Get
    End Property

    Public Function GetSimiliarTransactions(Transaction As Transaction) As List(Of Transaction)
        Dim result As New List(Of Transaction)

        For Each mTrans In Transactions
            If mTrans.Description = Transaction.Description Then
                result.Add(mTrans)
            End If
        Next

        Return result
    End Function

    Public Function IsReoccurring(Transaction As Transaction) As Boolean
        For Each mTrans As Transaction In ReoccurringTransactions
            If mTrans.Description = Transaction.Description Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function GetMonthlyAverages() As List(Of ExpenseCategory)
        Dim result As New List(Of ExpenseCategory)

        Dim StartDate As Date = Transactions(Transactions.Count - 1).TransactionDate
        Dim EndDate As Date = Transactions(0).TransactionDate

        Dim NumMonths As Integer = Math.Round(DateDiff(DateInterval.Month, StartDate, EndDate), 0)

        For Each mCat As ExpenseCategory In ExpenseCategories
            Dim MonthStart As Date = StartDate
            Dim Total As Decimal = 0
            For i As Integer = 0 To NumMonths - 1
                Total += mCat.TotalOut(Me, MonthStart, MonthStart.AddMonths(1))
                MonthStart = MonthStart.AddMonths(1)
            Next
            Dim newCat As New ExpenseCategory(mCat.Name)
            newCat.TotalOut_Custom = Total \ NumMonths
            result.Add(newCat)
        Next

        Return result
    End Function

#Region "Predictions"
    <XmlIgnore()> Public ReadOnly Property FutureNortekPaychecks(Optional ByVal StartDate As Date = Nothing) As List(Of Transaction)
        Get
            Dim PastPaychecks As List(Of Transaction) = GetNortekPaychecks(True)
            If PastPaychecks.Count > 0 Then
                Dim FuturePaychecks As New List(Of Transaction)
                Dim LastPayCheck As Transaction = PastPaychecks(0)
                If StartDate <> Nothing Then
                    For Each mPaycheck As Transaction In PastPaychecks
                        If mPaycheck.TransactionDate <= StartDate Then
                            LastPayCheck = mPaycheck
                            Exit For
                        End If
                    Next
                End If
                Dim LastPaycheckDate As Date = LastPayCheck.TransactionDate
                For i As Integer = 0 To 54
                    FuturePaychecks.Add(New Transaction(LastPayCheck.Description, LastPayCheck.Amount, LastPaycheckDate.AddDays(14), LastPayCheck.TransactionType, 0))
                    LastPaycheckDate = FuturePaychecks(FuturePaychecks.Count - 1).TransactionDate
                Next
                Return FuturePaychecks
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public Sub AddReoccurringTransaction(Transaction As Transaction)
        Dim mTrans As Transaction = Transaction.Clone
        ReoccurringTransactions.Add(Transaction.Clone)
    End Sub

    Public Sub RemoveReoccurringTransaction(Transaction As Transaction)
        For Each mTrans In ReoccurringTransactions
            If mTrans.Description = Transaction.Description Then
                ReoccurringTransactions.Remove(mTrans)
                Exit For
            End If
        Next
    End Sub

    Public Function GetFutureExpenses(TargetDate As Date, Optional ByVal StartDate As Date = Nothing) As List(Of Transaction)
        Dim result As New List(Of Transaction)

        Dim CurrentDate As Date = Transactions(0).TransactionDate
        If StartDate <> Nothing Then CurrentDate = StartDate
        Dim NumOfMonths As Integer = DateDiff(DateInterval.Month, CurrentDate, TargetDate)
        For Each mTrans As Transaction In ReoccurringTransactions
            If mTrans.Enabled Then
                If Not mTrans.ReoccurringAfterPaycheck Then
                    For i As Integer = 0 To NumOfMonths
                        Dim FutureDate As Date = New Date(CurrentDate.Year, CurrentDate.Month, mTrans.TransactionDate.Day).AddMonths(i)
                        If FutureDate >= CurrentDate And FutureDate <= TargetDate Then
                            Dim ReoccurrTrans As Transaction = mTrans.Clone
                            ReoccurrTrans.TransactionDate = FutureDate.AddHours(1)
                            result.Add(ReoccurrTrans)
                        End If
                    Next
                End If
            End If
        Next

        Return result
    End Function

    Public Function GetPredictedTransactions(TargetDate As Date, Optional ByVal StartDate As Date = Nothing) As List(Of Transaction)
        Dim result As New List(Of Transaction)

        Dim CurrentDate As Date = Transactions(0).TransactionDate
        If StartDate <> Nothing Then CurrentDate = StartDate

        For Each Paycheck In FutureNortekPaychecks(StartDate)
            If Paycheck.TransactionDate >= CurrentDate And Paycheck.TransactionDate <= TargetDate Then
                result.Add(Paycheck)

                'apply expenses defined as after paycheck
                For Each mTrans As Transaction In ReoccurringTransactions
                    If mTrans.ReoccurringAfterPaycheck Then
                        Dim PaycheckExpense As Transaction = mTrans.Clone
                        PaycheckExpense.TransactionDate = Paycheck.TransactionDate.AddDays(1)
                        result.Add(PaycheckExpense)
                    End If
                Next
            End If
        Next

        For Each ReoccurrTrans As Transaction In GetFutureExpenses(TargetDate, StartDate)
            result.Add(ReoccurrTrans)
        Next

        result.Sort(Function(x, y) y.TransactionDate.CompareTo(x.TransactionDate))
        Dim Balance As Decimal = Transactions(0).Balance
        If StartDate <> Nothing Then
            For Each mTransaction As Transaction In Transactions
                If mTransaction.TransactionDate < StartDate Then
                    Balance = mTransaction.Balance
                    Exit For
                End If
            Next
        End If
        result(result.Count - 1).Balance = Balance + result(result.Count - 1).Amount

        For i As Integer = result.Count - 2 To 0 Step -1
            result(i).Balance = result(i + 1).Balance + result(i).Amount
        Next

        Return result
    End Function

#End Region
End Class
