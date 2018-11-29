<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionView
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
        Me.dgvAccount = New System.Windows.Forms.DataGridView()
        Me.TransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAccount
        '
        Me.dgvAccount.AutoGenerateColumns = False
        Me.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAccount.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccount.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescriptionDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.TransactionDateDataGridViewTextBoxColumn, Me.TransactionTypeDataGridViewTextBoxColumn, Me.BalanceDataGridViewTextBoxColumn})
        Me.dgvAccount.DataSource = Me.TransactionBindingSource
        Me.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAccount.Location = New System.Drawing.Point(0, 0)
        Me.dgvAccount.Name = "dgvAccount"
        Me.dgvAccount.Size = New System.Drawing.Size(989, 613)
        Me.dgvAccount.TabIndex = 1
        '
        'TransactionBindingSource
        '
        Me.TransactionBindingSource.DataSource = GetType(Finance.Transaction)
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
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        Me.BalanceDataGridViewTextBoxColumn.Width = 71
        '
        'TransactionView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 613)
        Me.Controls.Add(Me.dgvAccount)
        Me.Name = "TransactionView"
        Me.Text = "Transaction View"
        CType(Me.dgvAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAccount As DataGridView
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransactionDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransactionTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransactionBindingSource As BindingSource
End Class
