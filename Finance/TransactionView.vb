Public Class TransactionView

    Public Sub New(Transactions As List(Of Transaction))
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TransactionBindingSource.DataSource = Transactions
        TransactionBindingSource.ResetBindings(1)
    End Sub

End Class