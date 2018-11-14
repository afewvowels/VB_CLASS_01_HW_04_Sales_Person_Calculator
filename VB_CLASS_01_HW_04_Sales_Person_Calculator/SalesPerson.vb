' Author: Keith Smith
' Date: 14 November 2018
' Description: This class takes in string values and does all the conversion
' within the class properties and methods and outputs formatted string values that can
' be used directly in form elements.

Option Explicit On
Option Strict On

Public Class SalesPerson
    Private varNameString As String
    Private varWeeklySalesDecimal As Decimal
    Private varPayDecimal As Decimal

    Private Shared TotalSalesDecimal As Decimal
    Private Shared TotalCommissionDecimal As Decimal
    Private Shared TotalPayDecimal As Decimal

    Private Const COMMISSION_RATE_Decimal As Decimal = 0.15D
    Private Const BASE_SALARY_Decimal As Decimal = 250D
    Private Const QUOTA_Decimal As Decimal = 1000D

    Public Sub New(ByVal _SalesPersonName As String, ByVal _SalesPersonSales As String)
        ' Call property methods to validate incoming data and set the
        ' values of internal variables
        Name = _SalesPersonName
        WeeklySales = _SalesPersonSales

        ' Calculate pay variable
        FindPay()

        ' Update Running Totals
        TotalSalesDecimal += varWeeklySalesDecimal
        TotalCommissionDecimal += CalculateCommission(varWeeklySalesDecimal)
        TotalPayDecimal += varPayDecimal
    End Sub

    ' Properties
    ' Name property, takes in a string and validates that something
    ' has been entered ("" <- empty string throws an exception)
    Public Property Name As String
        Get
            Return varNameString
        End Get
        Set(inName As String)
            If (inName <> "") Then
                varNameString = inName
            Else
                Throw New ArgumentOutOfRangeException("Name field must not be empty")
            End If
        End Set
    End Property

    ' Property for adjusting the employee's weekly sales figures, takes
    ' in a string and validates the input, throws errors if bad data
    ' is provided
    Public Property WeeklySales As String
        Get
            Return varWeeklySalesDecimal.ToString("C")
        End Get
        Set(inSales As String)
            Dim tempSales As Decimal

            ' Catch exception in main application
            tempSales = Convert.ToDecimal(inSales)

            If (tempSales >= 0) Then
                varWeeklySalesDecimal = tempSales
            Else
                Throw New ArgumentOutOfRangeException("Weekly sales must be greaer than or equal to $0.00.")
            End If
        End Set
    End Property

    ' Read-only property that returns this employee's commission for the week
    Public ReadOnly Property Commission As String
        Get
            Return CalculateCommission(varWeeklySalesDecimal).ToString("C")
        End Get
    End Property

    ' Read-only property that returns weekly pay for the current employee
    ' as a currency formatted string
    Public ReadOnly Property Pay As String
        Get
            Return varPayDecimal.ToString("C")
        End Get
    End Property

    ' Shared, read-only property that returns total sales
    Public Shared ReadOnly Property TotalSales As String
        Get
            Return TotalSalesDecimal.ToString("C")
        End Get
    End Property

    ' Shared, read-only property that returns accumulated commisson
    Public Shared ReadOnly Property TotalCommission As String
        Get
            Return TotalCommissionDecimal.ToString("C")
        End Get
    End Property

    ' Shared, read-only property that returns accumulated pay
    Public Shared ReadOnly Property TotalPay As String
        Get
            Return TotalPayDecimal.ToString("C")
        End Get
    End Property

    ' Subroutines and Functions
    ' Subroutine that updates the weekly pay decimal with commission (if inPay crosses threshold,
    ' calculated in CalculateCommission(inPay) below
    Sub FindPay()
        varPayDecimal = CalculateCommission(varWeeklySalesDecimal) + BASE_SALARY_Decimal
    End Sub

    ' Function that returns the commission earned based on an incoming inPay variable and
    ' two constants: the quota that sales must be greater than and the commission rate applied
    ' to the incoming inPay variable.
    Function CalculateCommission(ByVal inSalesDecimal As Decimal) As Decimal
        If (inSalesDecimal > QUOTA_Decimal) Then
            Return inSalesDecimal * COMMISSION_RATE_Decimal
        Else
            Return 0D
        End If
    End Function
End Class
