Public Class Category
    Dim Account As Account

    Public Sub New(Account As Account, Transaction As Transaction)
        InitializeComponent()
        Me.Account = Account

        For Each mCat As ExpenseCategory In Account.ExpenseCategories
            cbCategories.Items.Add(mCat)
        Next
        txbKey.Text = Transaction.Description
    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        For Each mCat As ExpenseCategory In Account.ExpenseCategories
            For Each mName As String In mCat.TransactionNames
                If mName.Contains(txbKey.Text) Then
                    MsgBox("Duplicate key detected in Category: " & mCat.Name)
                    Exit Sub
                End If
            Next
        Next

        Account.GetExpenseCategory(cbCategories.Text).TransactionNames.Add(txbKey.Text)
        Account.Save()

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class