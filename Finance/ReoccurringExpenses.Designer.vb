<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReoccurringExpenses
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
        Me.cbExpense = New System.Windows.Forms.ComboBox()
        Me.ReoccurringBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cbAfterPaycheck = New System.Windows.Forms.CheckBox()
        Me.chkEnabled = New System.Windows.Forms.CheckBox()
        CType(Me.ReoccurringBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbExpense
        '
        Me.cbExpense.DataSource = Me.ReoccurringBindingSource
        Me.cbExpense.FormattingEnabled = True
        Me.cbExpense.Location = New System.Drawing.Point(65, 12)
        Me.cbExpense.Name = "cbExpense"
        Me.cbExpense.Size = New System.Drawing.Size(357, 21)
        Me.cbExpense.TabIndex = 0
        '
        'ReoccurringBindingSource
        '
        Me.ReoccurringBindingSource.DataSource = GetType(Finance.Transaction)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Expense:"
        '
        'txbAmount
        '
        Me.txbAmount.Location = New System.Drawing.Point(65, 39)
        Me.txbAmount.Name = "txbAmount"
        Me.txbAmount.Size = New System.Drawing.Size(100, 20)
        Me.txbAmount.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Amount:"
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(65, 65)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(95, 20)
        Me.dtpDate.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Date:"
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(382, 63)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(75, 23)
        Me.btnOkay.TabIndex = 15
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(301, 63)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(428, 10)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(29, 23)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cbAfterPaycheck
        '
        Me.cbAfterPaycheck.AutoSize = True
        Me.cbAfterPaycheck.Location = New System.Drawing.Point(179, 41)
        Me.cbAfterPaycheck.Name = "cbAfterPaycheck"
        Me.cbAfterPaycheck.Size = New System.Drawing.Size(160, 17)
        Me.cbAfterPaycheck.TabIndex = 18
        Me.cbAfterPaycheck.Text = "Reoccurring After Paycheck"
        Me.cbAfterPaycheck.UseVisualStyleBackColor = True
        '
        'chkEnabled
        '
        Me.chkEnabled.AutoSize = True
        Me.chkEnabled.Location = New System.Drawing.Point(179, 65)
        Me.chkEnabled.Name = "chkEnabled"
        Me.chkEnabled.Size = New System.Drawing.Size(65, 17)
        Me.chkEnabled.TabIndex = 19
        Me.chkEnabled.Text = "Enabled"
        Me.chkEnabled.UseVisualStyleBackColor = True
        '
        'ReoccurringExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(466, 97)
        Me.Controls.Add(Me.chkEnabled)
        Me.Controls.Add(Me.cbAfterPaycheck)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbExpense)
        Me.Name = "ReoccurringExpenses"
        Me.Text = "Reoccurring Expenses"
        CType(Me.ReoccurringBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbExpense As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txbAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents ReoccurringBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents cbAfterPaycheck As System.Windows.Forms.CheckBox
    Friend WithEvents chkEnabled As CheckBox
End Class
