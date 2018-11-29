<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lvPaychecks = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsPaychecks = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEditReoccurring = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnViewPredicted = New System.Windows.Forms.Button()
        Me.btnParseFile = New System.Windows.Forms.Button()
        Me.btnMonthlyAverages = New System.Windows.Forms.Button()
        Me.cbCategories = New System.Windows.Forms.ComboBox()
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnViewChart = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dgvAccount = New System.Windows.Forms.DataGridView()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsAccount = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSimilarTransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetReoccurringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.cmsPaychecks.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsAccount.SuspendLayout()
        CType(Me.AccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvAccount)
        Me.SplitContainer1.Size = New System.Drawing.Size(1117, 736)
        Me.SplitContainer1.SplitterDistance = 276
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lvPaychecks)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 323)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(268, 324)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Paychecks"
        '
        'lvPaychecks
        '
        Me.lvPaychecks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvPaychecks.ContextMenuStrip = Me.cmsPaychecks
        Me.lvPaychecks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvPaychecks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvPaychecks.Location = New System.Drawing.Point(3, 16)
        Me.lvPaychecks.Name = "lvPaychecks"
        Me.lvPaychecks.Size = New System.Drawing.Size(262, 305)
        Me.lvPaychecks.TabIndex = 17
        Me.lvPaychecks.UseCompatibleStateImageBehavior = False
        Me.lvPaychecks.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 160
        '
        'cmsPaychecks
        '
        Me.cmsPaychecks.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.cmsPaychecks.Name = "cmsAccount"
        Me.cmsPaychecks.Size = New System.Drawing.Size(132, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.ToolStripMenuItem1.Text = "View Chart"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEditReoccurring)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 260)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(268, 57)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reocurring Expenses"
        '
        'btnEditReoccurring
        '
        Me.btnEditReoccurring.Location = New System.Drawing.Point(63, 19)
        Me.btnEditReoccurring.Name = "btnEditReoccurring"
        Me.btnEditReoccurring.Size = New System.Drawing.Size(143, 23)
        Me.btnEditReoccurring.TabIndex = 19
        Me.btnEditReoccurring.Text = "Edit Reoccurring Expenses"
        Me.btnEditReoccurring.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.btnParseFile)
        Me.GroupBox1.Controls.Add(Me.cbCategories)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpEndDate)
        Me.GroupBox1.Controls.Add(Me.dtpStartDate)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 251)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Load / View Data"
        '
        'btnViewPredicted
        '
        Me.btnViewPredicted.Location = New System.Drawing.Point(6, 16)
        Me.btnViewPredicted.Name = "btnViewPredicted"
        Me.btnViewPredicted.Size = New System.Drawing.Size(102, 23)
        Me.btnViewPredicted.TabIndex = 21
        Me.btnViewPredicted.Text = "View Predicted"
        Me.btnViewPredicted.UseVisualStyleBackColor = True
        '
        'btnParseFile
        '
        Me.btnParseFile.Location = New System.Drawing.Point(63, 19)
        Me.btnParseFile.Name = "btnParseFile"
        Me.btnParseFile.Size = New System.Drawing.Size(120, 23)
        Me.btnParseFile.TabIndex = 0
        Me.btnParseFile.Text = "Parse File"
        Me.btnParseFile.UseVisualStyleBackColor = True
        '
        'btnMonthlyAverages
        '
        Me.btnMonthlyAverages.Location = New System.Drawing.Point(6, 74)
        Me.btnMonthlyAverages.Name = "btnMonthlyAverages"
        Me.btnMonthlyAverages.Size = New System.Drawing.Size(75, 23)
        Me.btnMonthlyAverages.TabIndex = 20
        Me.btnMonthlyAverages.Text = "Month Avgs"
        Me.btnMonthlyAverages.UseVisualStyleBackColor = True
        '
        'cbCategories
        '
        Me.cbCategories.DataSource = Me.CategoriesBindingSource
        Me.cbCategories.FormattingEnabled = True
        Me.cbCategories.Location = New System.Drawing.Point(63, 48)
        Me.cbCategories.Name = "cbCategories"
        Me.cbCategories.Size = New System.Drawing.Size(194, 21)
        Me.cbCategories.TabIndex = 2
        '
        'CategoriesBindingSource
        '
        Me.CategoriesBindingSource.DataSource = GetType(Finance.ExpenseCategory)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Category:"
        '
        'btnViewChart
        '
        Me.btnViewChart.Location = New System.Drawing.Point(6, 45)
        Me.btnViewChart.Name = "btnViewChart"
        Me.btnViewChart.Size = New System.Drawing.Size(75, 23)
        Me.btnViewChart.TabIndex = 9
        Me.btnViewChart.Text = "View Chart"
        Me.btnViewChart.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Start Date:"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(6, 16)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 14
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "End Date:"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(63, 101)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(95, 20)
        Me.dtpEndDate.TabIndex = 13
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(63, 75)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(95, 20)
        Me.dtpStartDate.TabIndex = 12
        '
        'dgvAccount
        '
        Me.dgvAccount.AutoGenerateColumns = False
        Me.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAccount.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccount.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescriptionDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.TransactionDateDataGridViewTextBoxColumn, Me.TransactionTypeDataGridViewTextBoxColumn, Me.Balance})
        Me.dgvAccount.ContextMenuStrip = Me.cmsAccount
        Me.dgvAccount.DataSource = Me.AccountBindingSource
        Me.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAccount.Location = New System.Drawing.Point(0, 0)
        Me.dgvAccount.Name = "dgvAccount"
        Me.dgvAccount.Size = New System.Drawing.Size(837, 736)
        Me.dgvAccount.TabIndex = 0
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Width = 85
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.Width = 68
        '
        'TransactionDateDataGridViewTextBoxColumn
        '
        Me.TransactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate"
        Me.TransactionDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate"
        Me.TransactionDateDataGridViewTextBoxColumn.Name = "TransactionDateDataGridViewTextBoxColumn"
        Me.TransactionDateDataGridViewTextBoxColumn.Width = 111
        '
        'TransactionTypeDataGridViewTextBoxColumn
        '
        Me.TransactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType"
        Me.TransactionTypeDataGridViewTextBoxColumn.HeaderText = "TransactionType"
        Me.TransactionTypeDataGridViewTextBoxColumn.Name = "TransactionTypeDataGridViewTextBoxColumn"
        Me.TransactionTypeDataGridViewTextBoxColumn.Width = 112
        '
        'Balance
        '
        Me.Balance.DataPropertyName = "Balance"
        Me.Balance.HeaderText = "Balance"
        Me.Balance.Name = "Balance"
        Me.Balance.Width = 71
        '
        'cmsAccount
        '
        Me.cmsAccount.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToCategoryToolStripMenuItem, Me.ViewSimilarTransactionsToolStripMenuItem, Me.SetReoccurringToolStripMenuItem})
        Me.cmsAccount.Name = "cmsAccount"
        Me.cmsAccount.Size = New System.Drawing.Size(208, 70)
        '
        'AddToCategoryToolStripMenuItem
        '
        Me.AddToCategoryToolStripMenuItem.Name = "AddToCategoryToolStripMenuItem"
        Me.AddToCategoryToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.AddToCategoryToolStripMenuItem.Text = "Add to Category"
        '
        'ViewSimilarTransactionsToolStripMenuItem
        '
        Me.ViewSimilarTransactionsToolStripMenuItem.Name = "ViewSimilarTransactionsToolStripMenuItem"
        Me.ViewSimilarTransactionsToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ViewSimilarTransactionsToolStripMenuItem.Text = "View Similar Transactions"
        '
        'SetReoccurringToolStripMenuItem
        '
        Me.SetReoccurringToolStripMenuItem.Name = "SetReoccurringToolStripMenuItem"
        Me.SetReoccurringToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.SetReoccurringToolStripMenuItem.Text = "Set Reoccurring"
        '
        'AccountBindingSource
        '
        Me.AccountBindingSource.DataSource = GetType(Finance.Transaction)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "View Chart"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnViewPredicted)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Location = New System.Drawing.Point(144, 127)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(113, 103)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Predicted"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnViewChart)
        Me.GroupBox5.Controls.Add(Me.btnLoad)
        Me.GroupBox5.Controls.Add(Me.btnMonthlyAverages)
        Me.GroupBox5.Location = New System.Drawing.Point(53, 127)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(85, 103)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Actual"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 736)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Main"
        Me.Text = "Finance"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.cmsPaychecks.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsAccount.ResumeLayout(False)
        CType(Me.AccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnParseFile As System.Windows.Forms.Button
    Friend WithEvents AccountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dgvAccount As System.Windows.Forms.DataGridView
    Friend WithEvents cmsAccount As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbCategories As System.Windows.Forms.ComboBox
    Friend WithEvents CategoriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnViewChart As System.Windows.Forms.Button
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents lvPaychecks As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsPaychecks As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewSimilarTransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetReoccurringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEditReoccurring As System.Windows.Forms.Button
    Friend WithEvents btnMonthlyAverages As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnViewPredicted As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button1 As Button
End Class
