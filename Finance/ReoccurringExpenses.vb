Public Class ReoccurringExpenses
    Dim Account As Account

    Public Sub New(Account As Account)
        InitializeComponent()
        Me.Account = Account
        ReoccurringBindingSource.DataSource = Account.ReoccurringTransactions
        ReoccurringBindingSource.ResetBindings(1)
    End Sub

    Private Sub cbExpense_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbExpense.SelectedValueChanged
        If cbExpense.SelectedItem IsNot Nothing Then
            Dim SelectedExpense As Transaction = cbExpense.SelectedItem
            txbAmount.Text = SelectedExpense.Amount
            dtpDate.Value = SelectedExpense.TransactionDate
            cbAfterPaycheck.Checked = SelectedExpense.ReoccurringAfterPaycheck
            chkEnabled.Checked = SelectedExpense.Enabled
        End If
    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Dim SelectedExpense As Transaction = cbExpense.SelectedItem
        SelectedExpense.Amount = txbAmount.Text
        SelectedExpense.TransactionDate = dtpDate.Value
        SelectedExpense.ReoccurringAfterPaycheck = cbAfterPaycheck.Checked
        SelectedExpense.Enabled = chkEnabled.Checked
        Account.Save()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Description As String = InputBox("Enter Expense Description", "Description", "")
        If Description <> "" Then
            Dim NewExpense As New Transaction(Description, 0, Date.Today, Enums.TransactionType.ACH_DEBIT, 0)
            Account.ReoccurringTransactions.Add(NewExpense)
            ReoccurringBindingSource.ResetBindings(1)
            cbExpense.SelectedItem = NewExpense
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Confirm Deletion", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Account.ReoccurringTransactions.Remove(cbExpense.SelectedItem)
            ReoccurringBindingSource.ResetBindings(1)
            Account.Save()
        End If
    End Sub
End Class