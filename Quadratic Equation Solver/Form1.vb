Imports System.Numerics
Imports System.Text

Public Class Form1
    Private ReadOnly _solver As New QuadraticSolver()

    Private Sub BtnComputeRoots_Click(sender As Object, e As EventArgs) Handles BtnComputeRoots.Click
        ' Validation
        Dim a, b, c As Double
        Dim errors As New StringBuilder()

        If Not Double.TryParse(TxtBoxA.Text, a) Then
            errors.AppendLine("- Coefficient 'a' must be a valid number.")
        End If
        If Not Double.TryParse(TxtBoxB.Text, b) Then
            errors.AppendLine("- Coefficient 'b' must be a valid number.")
        End If
        If Not Double.TryParse(TxtBoxC.Text, c) Then
            errors.AppendLine("- Coefficient 'c' must be a valid number.")
        End If

        If errors.Length > 0 Then
            LblResultText.ForeColor = Color.Red
            LblResultText.Text = "Input Errors:" & Environment.NewLine & errors.ToString()
            Return
        End If

        ' Solve
        Dim result = _solver.Solve(a, b, c)

        ' Display
        LblResultText.ForeColor = Color.Black
        Dim sb As New StringBuilder()
        sb.AppendLine(result.Message)
        sb.AppendLine(New String("-"c, 20))

        If result.IsQuadratic Then
            For i As Integer = 0 To result.Roots.Length - 1
                Dim root = result.Roots(i)
                If root.Imaginary = 0 Then
                    sb.AppendLine($"x{i + 1} = {root.Real:N4}")
                Else
                    Dim sign = If(root.Imaginary > 0, "+", "-")
                    sb.AppendLine($"x{i + 1} = {root.Real:N4} {sign} {Math.Abs(root.Imaginary):N4}i")
                End If
            Next
        End If

        LblResultText.Text = sb.ToString()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtBoxA.Clear()
        TxtBoxB.Clear()
        TxtBoxC.Clear()
        LblResultText.Text = ""
        TxtBoxA.Focus()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub

End Class
