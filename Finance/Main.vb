Public Class Main

    Public Account As New Account

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\Account.xml") Then
            Account = Account.Open()
        End If

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\Chase All.CSV") Then
            ParseAndLoadFile(My.Application.Info.DirectoryPath & "\Chase All.CSV")
        End If

        AccountBindingSource.DataSource = Account.DisplayTransactions
        CategoriesBindingSource.DataSource = Account.ExpenseCategories
    End Sub

    Private Sub btnParseFile_Click(sender As Object, e As EventArgs) Handles btnParseFile.Click
        Dim OpenFileDialog As New OpenFileDialog
        If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                ParseAndLoadFile(OpenFileDialog.FileName)
            Catch ex As Exception
                MsgBox("Error parsing file" & vbCrLf & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ParseAndLoadFile(File As String)
        Account.Transactions.Clear()
        Account.ParseFile(File)
        dtpStartDate.Value = Account.Transactions(Account.Transactions.Count - 1).TransactionDate
        Account.StartDate = dtpStartDate.Value
        Account.EndDate = dtpEndDate.Value
        Account.DisplayTransactions = Account.GetExpenseCategory("All").GetTransactions(Account)
        RefreshTransactionDisplay()
        HighlightCategories()
        LoadPaychecks()
    End Sub

    Private Sub AddToCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToCategoryToolStripMenuItem.Click
        If dgvAccount.SelectedRows.Count > 0 Then
            Dim mCat As New Category(Account, dgvAccount.SelectedRows(0).DataBoundItem)
            If mCat.ShowDialog() = Windows.Forms.DialogResult.OK Then
                CategoriesBindingSource.ResetBindings(1)
            End If
        End If
    End Sub

    Private Sub ViewSimilarTransactionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSimilarTransactionsToolStripMenuItem.Click
        If dgvAccount.SelectedRows.Count > 0 Then
            Account.DisplayTransactions = Account.GetSimiliarTransactions(dgvAccount.SelectedRows(0).DataBoundItem)
            RefreshTransactionDisplay()
        End If
    End Sub

    Private Sub HighlightCategories()
        For Each mRow As DataGridViewRow In dgvAccount.Rows
            Dim Transaction As Transaction = mRow.DataBoundItem
            If Transaction IsNot Nothing Then
                If Not Account.ExpenseCategoryExists(Transaction.Description) Then
                    mRow.DefaultCellStyle.BackColor = Color.Yellow
                End If

                If Account.IsReoccurring(Transaction) Then
                    mRow.DefaultCellStyle.BackColor = Color.LightBlue
                End If

                If Transaction.TransactionDate > Account.Transactions(0).TransactionDate Then
                    mRow.DefaultCellStyle.BackColor = Color.LightGray
                End If
            End If
        Next
    End Sub

    Private Sub btnViewChart_Click(sender As Object, e As EventArgs) Handles btnViewChart.Click
        Dim Charter As New CategoryChart(Account, dgvAccount)
        Charter.LoadData(dgvAccount)
        Charter.Show()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Account.SelectedCategory = cbCategories.Text
        Account.StartDate = dtpStartDate.Value
        Account.EndDate = dtpEndDate.Value
        Account.DisplayTransactions = Account.GetExpenseCategory(cbCategories.Text).GetTransactions(Account)
        'get predicted transactions
        If DateDiff(DateInterval.Day, Date.Today, Account.EndDate) > 0 Then
            Account.DisplayTransactions.InsertRange(0, Account.GetPredictedTransactions(Account.EndDate))
        End If
        RefreshTransactionDisplay()

        HighlightCategories()

        LoadPaychecks()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If lvPaychecks.SelectedItems.Count = 1 AndAlso lvPaychecks.Items.IndexOf(lvPaychecks.SelectedItems(0)) <> 0 Then
            Dim Charter As New CategoryChart(Account)
            Charter.LoadData(CType(lvPaychecks.SelectedItems(0).Tag, Transaction).TransactionDate,
                             CType(lvPaychecks.Items(lvPaychecks.Items.IndexOf(lvPaychecks.SelectedItems(0)) - 1).Tag, Transaction).TransactionDate)
            Charter.Show()
        End If
    End Sub

    Private Sub lvPaychecks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPaychecks.SelectedIndexChanged
        If lvPaychecks.SelectedItems.Count = 1 AndAlso lvPaychecks.Items.IndexOf(lvPaychecks.SelectedItems(0)) <> 0 Then
            Dim StartDate As Date = CType(lvPaychecks.SelectedItems(0).Tag, Transaction).TransactionDate
            Dim EndDate As Date = CType(lvPaychecks.Items(lvPaychecks.Items.IndexOf(lvPaychecks.SelectedItems(0)) - 1).Tag, Transaction).TransactionDate

            Account.SelectedCategory = "All"
            Account.StartDate = StartDate
            Account.EndDate = EndDate
            Account.DisplayTransactions = Account.GetExpenseCategory("All").GetTransactions(Account)
            RefreshTransactionDisplay()
        End If
    End Sub

    Private Sub LoadPaychecks()
        lvPaychecks.Items.Clear()
        For Each mTrans As Transaction In Account.GetNortekPaychecks
            With lvPaychecks.Items.Add(mTrans.TransactionDate.ToShortDateString)
                .Tag = mTrans
            End With
        Next
    End Sub

    Public Sub RefreshTransactionDisplay()
        AccountBindingSource.DataSource = Account.DisplayTransactions
        AccountBindingSource.ResetBindings(1)
    End Sub

    Private Sub SetReoccurringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetReoccurringToolStripMenuItem.Click
        If dgvAccount.SelectedRows.Count > 0 Then
            Account.AddReoccurringTransaction(dgvAccount.SelectedRows(0).DataBoundItem)
            Account.Save()
        End If
    End Sub

    Private Sub btnEditReoccurring_Click(sender As Object, e As EventArgs) Handles btnEditReoccurring.Click
        If Account IsNot Nothing Then
            Dim EditReoccur As New ReoccurringExpenses(Account)
            EditReoccur.Show()
        End If
    End Sub

    Private Sub btnMonthlyAverages_Click(sender As Object, e As EventArgs) Handles btnMonthlyAverages.Click
        Dim Charter As New CategoryChart(Account, dgvAccount)
        Charter.LoadData(Account.GetMonthlyAverages)
        Charter.Show()
    End Sub

    Private Sub btnLoadPredicted_Click(sender As Object, e As EventArgs) Handles btnViewPredicted.Click
        Dim PredictedTransactions As New TransactionView(Account.GetPredictedTransactions(dtpEndDate.Value, dtpStartDate.Value))
        PredictedTransactions.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim PredictedTransactions As New TransactionView(Account.GetPredictedTransactions(dtpEndDate.Value, dtpStartDate.Value))

        Dim Charter As New CategoryChart(Account, PredictedTransactions.dgvAccount)
        Charter.LoadData(Account.GetMonthlyAverages)
        Charter.Show()
    End Sub
End Class
