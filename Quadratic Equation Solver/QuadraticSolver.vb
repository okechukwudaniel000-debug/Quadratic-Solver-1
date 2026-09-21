Imports System.Numerics

Public Class QuadraticSolver
    Public Structure SolverResult
        Public Property Roots As Complex()
        Public Property IsQuadratic As Boolean
        Public Property Message As String
    End Structure

    Public Function Solve(a As Double, b As Double, c As Double) As SolverResult
        Dim result As New SolverResult With {
            .IsQuadratic = True,
            .Roots = Array.Empty(Of Complex)()
        }

        If a = 0 Then
            result.IsQuadratic = False
            result.Message = "Not a quadratic equation (a cannot be 0)."
            Return result
        End If

        Dim discriminant As Double = (b * b) - (4 * a * c)

        If discriminant > 0 Then
            Dim x1 As Double = (-b + Math.Sqrt(discriminant)) / (2 * a)
            Dim x2 As Double = (-b - Math.Sqrt(discriminant)) / (2 * a)
            result.Roots = {New Complex(x1, 0), New Complex(x2, 0)}
            result.Message = "Two Real Roots"
        ElseIf discriminant = 0 Then
            Dim x As Double = -b / (2 * a)
            result.Roots = {New Complex(x, 0)}
            result.Message = "One Real (Double) Root"
        Else
            Dim realPart As Double = -b / (2 * a)
            Dim imaginaryPart As Double = Math.Sqrt(-discriminant) / (2 * a)
            result.Roots = {
                New Complex(realPart, imaginaryPart),
                New Complex(realPart, -imaginaryPart)
            }
            result.Message = "Two Complex Roots"
        End If

        Return result
    End Function
End Class
