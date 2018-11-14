<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales_Person_Calculator
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
        Me.SalesPersonGroupBox = New System.Windows.Forms.GroupBox()
        Me.SalesTextBox = New System.Windows.Forms.TextBox()
        Me.SalesLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.CommissionTextBox = New System.Windows.Forms.TextBox()
        Me.CommissionLabel = New System.Windows.Forms.Label()
        Me.PayTextBox = New System.Windows.Forms.TextBox()
        Me.AmountPaidLabel = New System.Windows.Forms.Label()
        Me.SalaryGroupBox = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesPersonGroupBox.SuspendLayout()
        Me.SalaryGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SalesPersonGroupBox
        '
        Me.SalesPersonGroupBox.Controls.Add(Me.SalesTextBox)
        Me.SalesPersonGroupBox.Controls.Add(Me.SalesLabel)
        Me.SalesPersonGroupBox.Controls.Add(Me.NameTextBox)
        Me.SalesPersonGroupBox.Controls.Add(Me.NameLabel)
        Me.SalesPersonGroupBox.Location = New System.Drawing.Point(26, 74)
        Me.SalesPersonGroupBox.Name = "SalesPersonGroupBox"
        Me.SalesPersonGroupBox.Size = New System.Drawing.Size(553, 196)
        Me.SalesPersonGroupBox.TabIndex = 0
        Me.SalesPersonGroupBox.TabStop = False
        Me.SalesPersonGroupBox.Text = "Employee Info"
        '
        'SalesTextBox
        '
        Me.SalesTextBox.Location = New System.Drawing.Point(226, 110)
        Me.SalesTextBox.Name = "SalesTextBox"
        Me.SalesTextBox.Size = New System.Drawing.Size(159, 31)
        Me.SalesTextBox.TabIndex = 3
        '
        'SalesLabel
        '
        Me.SalesLabel.AutoSize = True
        Me.SalesLabel.Location = New System.Drawing.Point(65, 110)
        Me.SalesLabel.Name = "SalesLabel"
        Me.SalesLabel.Size = New System.Drawing.Size(149, 25)
        Me.SalesLabel.TabIndex = 2
        Me.SalesLabel.Text = "Weekly Sales:"
        Me.SalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(226, 56)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(282, 31)
        Me.NameTextBox.TabIndex = 1
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(44, 56)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(175, 25)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Employee Name:"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CommissionTextBox
        '
        Me.CommissionTextBox.Enabled = False
        Me.CommissionTextBox.Location = New System.Drawing.Point(226, 110)
        Me.CommissionTextBox.Name = "CommissionTextBox"
        Me.CommissionTextBox.Size = New System.Drawing.Size(159, 31)
        Me.CommissionTextBox.TabIndex = 3
        '
        'CommissionLabel
        '
        Me.CommissionLabel.AutoSize = True
        Me.CommissionLabel.Location = New System.Drawing.Point(69, 110)
        Me.CommissionLabel.Name = "CommissionLabel"
        Me.CommissionLabel.Size = New System.Drawing.Size(135, 25)
        Me.CommissionLabel.TabIndex = 2
        Me.CommissionLabel.Text = "Commission:"
        Me.CommissionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PayTextBox
        '
        Me.PayTextBox.Enabled = False
        Me.PayTextBox.Location = New System.Drawing.Point(226, 56)
        Me.PayTextBox.Name = "PayTextBox"
        Me.PayTextBox.Size = New System.Drawing.Size(159, 31)
        Me.PayTextBox.TabIndex = 1
        '
        'AmountPaidLabel
        '
        Me.AmountPaidLabel.AutoSize = True
        Me.AmountPaidLabel.Location = New System.Drawing.Point(62, 56)
        Me.AmountPaidLabel.Name = "AmountPaidLabel"
        Me.AmountPaidLabel.Size = New System.Drawing.Size(140, 25)
        Me.AmountPaidLabel.TabIndex = 0
        Me.AmountPaidLabel.Text = "Amount Paid:"
        Me.AmountPaidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SalaryGroupBox
        '
        Me.SalaryGroupBox.Controls.Add(Me.CommissionTextBox)
        Me.SalaryGroupBox.Controls.Add(Me.CommissionLabel)
        Me.SalaryGroupBox.Controls.Add(Me.PayTextBox)
        Me.SalaryGroupBox.Controls.Add(Me.AmountPaidLabel)
        Me.SalaryGroupBox.Location = New System.Drawing.Point(26, 292)
        Me.SalaryGroupBox.Name = "SalaryGroupBox"
        Me.SalaryGroupBox.Size = New System.Drawing.Size(553, 196)
        Me.SalaryGroupBox.TabIndex = 4
        Me.SalaryGroupBox.TabStop = False
        Me.SalaryGroupBox.Text = "Salary Info"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(697, 42)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PayToolStripMenuItem, Me.SummaryToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(64, 38)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PayToolStripMenuItem
        '
        Me.PayToolStripMenuItem.Name = "PayToolStripMenuItem"
        Me.PayToolStripMenuItem.Size = New System.Drawing.Size(324, 38)
        Me.PayToolStripMenuItem.Text = "&Pay"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(324, 38)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(324, 38)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(67, 38)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(324, 38)
        Me.ClearToolStripMenuItem.Text = "Clea&r"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(77, 38)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(324, 38)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'Sales_Person_Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 515)
        Me.Controls.Add(Me.SalaryGroupBox)
        Me.Controls.Add(Me.SalesPersonGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Sales_Person_Calculator"
        Me.Text = "Sales Person Calculator"
        Me.SalesPersonGroupBox.ResumeLayout(False)
        Me.SalesPersonGroupBox.PerformLayout()
        Me.SalaryGroupBox.ResumeLayout(False)
        Me.SalaryGroupBox.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SalesPersonGroupBox As GroupBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents SalesTextBox As TextBox
    Friend WithEvents SalesLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents CommissionTextBox As TextBox
    Friend WithEvents CommissionLabel As Label
    Friend WithEvents PayTextBox As TextBox
    Friend WithEvents AmountPaidLabel As Label
    Friend WithEvents SalaryGroupBox As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
