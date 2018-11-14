' Author: Keith Smith
' Date: 14 November 2018
' Description: This class takes in string values and does all the conversion
' within the class properties and methods and outputs formatted string values that can
' be used directly in form elements.

Option Explicit On
Option Strict On

Public Class SalesPerson
    Private varName As String
    Private varWeeklySales As Decimal

    Private Shared TotalSalesDecimal As Decimal
    Private Shared TotalCommissionDecimal As Decimal
    Private Shared TotalPayDecimal As Decimal

    Private Const COMMISSION_RATE_Decimal As Decimal = 0.15D
    Private Const BASE_SALARY_Decimal As Decimal = 250D
    Private Const QUOTA_Decimal As Decimal = 1000D

    Public Sub New(ByVal _SalesPersonName As String, ByVal _SalesPersonSales As Decimal)

    End Sub

    ' Properties
    Public Property Name As String
        Get
            Return varName
        End Get
        Set(inName As String)
            If (inName <> "") Then
                varName = inName
            Else
                Throw New ArgumentOutOfRangeException("Name field must not be empty")
            End If
        End Set
    End Property

    Public Property WeeklySales As String
        Get
            Return varWeeklySales.ToString("C")
        End Get
        Set(inSales As String)
            Dim tempSales As Decimal
            Try
                tempSales = Convert.ToDecimal(inSales)

                If (tempSales >= 0) Then
                    varWeeklySales = tempSales
                Else
                    Throw New ArgumentOutOfRangeException("Weekly sales must be greaer than or equal to $0.00.")
                End If
            Catch ex As Exception
                MessageBox.Show("Must enter numerical data", "Bad Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Set
    End Property

    Public ReadOnly Property Commission As Decimal
        Get
            If (varWeeklySales > QUOTA_Decimal) Then
                Return varWeeklySales * COMMISSION_RATE_Decimal
            Else
                Return 0D
            End If
        End Get
    End Property

    Public ReadOnly Property Pay As Decimal
        Get
            Return (varWeeklySales * COMMISSION_RATE_Decimal) + BASE_SALARY_Decimal
        End Get
    End Property

    Public Shared ReadOnly Property TotalSales As Decimal
        Get
            Return TotalSalesDecimal
        End Get
    End Property

    Public Shared ReadOnly Property TotalCommission As Decimal
        Get
            Return TotalCommissionDecimal
        End Get
    End Property

    Public Shared ReadOnly Property TotalPay As Decimal
        Get
            Return TotalPayDecimal
        End Get
    End Property
End Class
