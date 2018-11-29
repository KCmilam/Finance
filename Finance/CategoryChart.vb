
Public Class CategoryChart
    Dim Account As Account


    Public Sub New(Account As Account)
        InitializeComponent()
        Me.Account = Account
    End Sub

    Public Sub New(Account As Account, Grid As DataGridView)
        InitializeComponent()
        Me.Account = Account
    End Sub

    Public Sub LoadData(Grid As DataGridView)
        Dim mTable As New DataTable("Data")
        mTable.Columns.Add("Name")
        Dim NewColumn As New DataColumn("Value")
        NewColumn.DataType = System.Type.GetType("System.Double")
        mTable.Columns.Add(NewColumn)

        For Each mCat As ExpenseCategory In Account.ExpenseCategories
            If mCat.Name <> "All" Then
                Dim TransactionValue As Decimal = mCat.TotalOut(Grid)
                If TransactionValue <> 0 Then
                    Dim NewRow As DataRow = mTable.NewRow
                    NewRow("Name") = mCat.Name
                    NewRow("Value") = TransactionValue
                    mTable.Rows.Add(NewRow)
                End If
            End If
        Next

        Dim mDataView As New DataView(mTable)
        mDataView.Sort = "Value ASC"
        Chart1.Series("Categories").ChartType = DataVisualization.Charting.SeriesChartType.Pie
        Chart1.Series("Categories").IsValueShownAsLabel = True
        Chart1.Series("Categories").Points.DataBindXY(mDataView, "Name", mDataView, "Value")
    End Sub

    Public Sub LoadData(Optional ByVal StartDate As Date = Nothing, Optional ByVal EndDate As Date = Nothing)
        ' Add any initialization after the InitializeComponent() call.
        Dim mTable As New DataTable("Data")
        mTable.Columns.Add("Name")
        Dim NewColumn As New DataColumn("Value")
        NewColumn.DataType = System.Type.GetType("System.Double")
        mTable.Columns.Add(NewColumn)

        For Each mCat As ExpenseCategory In Account.ExpenseCategories
            If mCat.Name <> "All" Then
                Dim TransactionValue As Decimal = mCat.TotalOut(Account, StartDate, EndDate)
                If TransactionValue <> 0 Then
                    Dim NewRow As DataRow = mTable.NewRow
                    NewRow("Name") = mCat.Name
                    NewRow("Value") = TransactionValue
                    mTable.Rows.Add(NewRow)
                End If
            End If
        Next

        Dim mDataView As New DataView(mTable)
        mDataView.Sort = "Value ASC"
        Chart1.Series("Categories").ChartType = DataVisualization.Charting.SeriesChartType.Pie
        Chart1.Series("Categories").IsValueShownAsLabel = True
        Chart1.Series("Categories").Points.DataBindXY(mDataView, "Name", mDataView, "Value")
    End Sub

    Public Sub LoadData(ExpenseCategories As List(Of ExpenseCategory))
        Dim mTable As New DataTable("Data")
        mTable.Columns.Add("Name")
        Dim NewColumn As New DataColumn("Value")
        NewColumn.DataType = System.Type.GetType("System.Double")
        mTable.Columns.Add(NewColumn)

        For Each mCat As ExpenseCategory In ExpenseCategories
            If mCat.Name <> "All" Then
                Dim NewRow As DataRow = mTable.NewRow
                NewRow("Name") = mCat.Name
                NewRow("Value") = mCat.TotalOut_Custom
                mTable.Rows.Add(NewRow)
            End If
        Next

        Dim mDataView As New DataView(mTable)
        mDataView.Sort = "Value ASC"
        Chart1.Series("Categories").ChartType = DataVisualization.Charting.SeriesChartType.Pie
        Chart1.Series("Categories").IsValueShownAsLabel = True
        Chart1.Series("Categories").Points.DataBindXY(mDataView, "Name", mDataView, "Value")
    End Sub

End Class