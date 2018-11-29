<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Category
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
        Me.cbCategories = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbKey = New System.Windows.Forms.TextBox()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbCategories
        '
        Me.cbCategories.FormattingEnabled = True
        Me.cbCategories.Location = New System.Drawing.Point(70, 10)
        Me.cbCategories.Name = "cbCategories"
        Me.cbCategories.Size = New System.Drawing.Size(259, 21)
        Me.cbCategories.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Category:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Key:"
        '
        'txbKey
        '
        Me.txbKey.Location = New System.Drawing.Point(70, 37)
        Me.txbKey.Name = "txbKey"
        Me.txbKey.Size = New System.Drawing.Size(259, 20)
        Me.txbKey.TabIndex = 3
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(254, 64)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(75, 23)
        Me.btnOkay.TabIndex = 4
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 99)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.txbKey)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbCategories)
        Me.Name = "Category"
        Me.Text = "Category"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbCategories As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txbKey As System.Windows.Forms.TextBox
    Friend WithEvents btnOkay As System.Windows.Forms.Button
End Class
