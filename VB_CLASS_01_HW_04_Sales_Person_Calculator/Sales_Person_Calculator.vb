' Author: Keith Smith
' Date: 14 November 2018
' Description: This application takes in a name and a sales figure
' and creates a sales person object which calculates a single sales person's
' pay and commission while also keeping a running total of all sales figures

Public Class Sales_Person_Calculator
    ' Calculates a sales person's pay and commission based on the existing
    ' text box entries
    Private Sub PayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayToolStripMenuItem.Click
        ' Try to create the object instance and catch any error messages
        ' and display them to the user
        Try
            Dim SalesPersonInstance As New SalesPerson(NameTextBox.Text, SalesTextBox.Text)

            If SalesPersonInstance Is Nothing Then
                ' If we're here, then invalid numerical data was added and the creation
                ' of the salespersoninstance threw an exception and handled it so the
                ' salespersoninstance was not actually created.
            Else
                ' Otherwise, the SalesPersonInstance was created and we can update the
                ' textbox values with the properties from the created object
                ' Update the lower textboxes with the calculated values
                PayTextBox.Text = SalesPersonInstance.Pay
                CommissionTextBox.Text = SalesPersonInstance.Commission
            End If
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show(ex.Message, "Error Reported", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As FormatException
            MessageBox.Show("Enter numerical data.", "Error Reported", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    ' Displays a modal message box that shows running totals of all sales people's
    ' sales, pay, and commissions
    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        Dim TempString As String

        TempString = String.Format("{1}{2}{0}{3}{4}{0}{5}{6}",
                                    vbCrLf,
                                    "Total Sales: ",
                                    SalesPerson.TotalSales,
                                    "Total Pay: ",
                                    SalesPerson.TotalPay,
                                    "Total Commission: ",
                                    SalesPerson.TotalCommission)

        MessageBox.Show(TempString, "Running Totals", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    ' Exit the application
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' Clear all text boxes
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        NameTextBox.Clear()
        SalesTextBox.Clear()
        PayTextBox.Clear()
        CommissionTextBox.Clear()
    End Sub

    ' Displays an about window
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub
End Class
