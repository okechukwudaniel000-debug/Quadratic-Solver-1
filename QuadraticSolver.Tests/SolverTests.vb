Imports System.Numerics
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Quadratic_Equation_Solver

<TestClass>
Public Class SolverTests
    Private ReadOnly _solver As New Quadratic_Equation_Solver.QuadraticSolver()

    <TestMethod>
    Public Sub Solve_TwoRealRoots_ReturnsCorrectRoots()
        ' x^2 - 5x + 6 = 0 => (x-2)(x-3) = 0
        Dim result = _solver.Solve(1, -5, 6)
        Assert.IsTrue(result.IsQuadratic)
        Assert.AreEqual(2, result.Roots.Length)
        Assert.AreEqual(3.0, result.Roots(0).Real, 0.0001)
        Assert.AreEqual(2.0, result.Roots(1).Real, 0.0001)
    End Sub

    <TestMethod>
    Public Sub Solve_OneRealRoot_ReturnsOneRoot()
        ' x^2 - 4x + 4 = 0 => (x-2)^2 = 0
        Dim result = _solver.Solve(1, -4, 4)
        Assert.IsTrue(result.IsQuadratic)
        Assert.AreEqual(1, result.Roots.Length)
        Assert.AreEqual(2.0, result.Roots(0).Real, 0.0001)
    End Sub

    <TestMethod>
    Public Sub Solve_ComplexRoots_ReturnsCorrectComplexRoots()
        ' x^2 + 1 = 0 => x = +/- i
        Dim result = _solver.Solve(1, 0, 1)
        Assert.IsTrue(result.IsQuadratic)
        Assert.AreEqual(2, result.Roots.Length)
        Assert.AreEqual(0.0, result.Roots(0).Real, 0.0001)
        Assert.AreEqual(1.0, result.Roots(0).Imaginary, 0.0001)
        Assert.AreEqual(0.0, result.Roots(1).Real, 0.0001)
        Assert.AreEqual(-1.0, result.Roots(1).Imaginary, 0.0001)
    End Sub

    <TestMethod>
    Public Sub Solve_NotQuadratic_ReturnsFalse()
        Dim result = _solver.Solve(0, 1, 1)
        Assert.IsFalse(result.IsQuadratic)
        Assert.AreEqual("Not a quadratic equation (a cannot be 0).", result.Message)
    End Sub
End Class
