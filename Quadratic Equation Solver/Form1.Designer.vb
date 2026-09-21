<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LblTitle = New Label()
        LblSubtitle = New Label()
        GrpResults = New GroupBox()
        LblResultText = New Label()
        GrpInputs = New GroupBox()
        TxtBoxC = New TextBox()
        TxtBoxB = New TextBox()
        TxtBoxA = New TextBox()
        LblC = New Label()
        LblB = New Label()
        LblA = New Label()
        BtnComputeRoots = New Button()
        BtnExit = New Button()
        BtnClear = New Button()
        GrpResults.SuspendLayout()
        GrpInputs.SuspendLayout()
        SuspendLayout()
        ' 
        ' LblTitle
        ' 
        LblTitle.Anchor = AnchorStyles.Top
        LblTitle.AutoSize = True
        LblTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblTitle.ForeColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        LblTitle.Location = New Point(252, 20)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(514, 54)
        LblTitle.TabIndex = 0
        LblTitle.Text = "Quadratic Equation Solver"
        ' 
        ' LblSubtitle
        ' 
        LblSubtitle.Anchor = AnchorStyles.Top
        LblSubtitle.AutoSize = True
        LblSubtitle.Font = New Font("Segoe UI", 14F, FontStyle.Italic)
        LblSubtitle.ForeColor = Color.Gray
        LblSubtitle.Location = New Point(376, 74)
        LblSubtitle.Name = "LblSubtitle"
        LblSubtitle.Size = New Size(245, 32)
        LblSubtitle.TabIndex = 1
        LblSubtitle.Text = "Solve ax² + bx + c = 0"
        ' 
        ' GrpResults
        ' 
        GrpResults.Controls.Add(LblResultText)
        GrpResults.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        GrpResults.Location = New Point(520, 140)
        GrpResults.Name = "GrpResults"
        GrpResults.Size = New Size(480, 300)
        GrpResults.TabIndex = 2
        GrpResults.TabStop = False
        GrpResults.Text = "Result Summary"
        ' 
        ' LblResultText
        ' 
        LblResultText.Dock = DockStyle.Fill
        LblResultText.Font = New Font("Consolas", 11F)
        LblResultText.Location = New Point(3, 30)
        LblResultText.Name = "LblResultText"
        LblResultText.Size = New Size(474, 267)
        LblResultText.TabIndex = 0
        LblResultText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GrpInputs
        ' 
        GrpInputs.Controls.Add(TxtBoxC)
        GrpInputs.Controls.Add(TxtBoxB)
        GrpInputs.Controls.Add(TxtBoxA)
        GrpInputs.Controls.Add(LblC)
        GrpInputs.Controls.Add(LblB)
        GrpInputs.Controls.Add(LblA)
        GrpInputs.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        GrpInputs.Location = New Point(40, 140)
        GrpInputs.Name = "GrpInputs"
        GrpInputs.Size = New Size(440, 300)
        GrpInputs.TabIndex = 3
        GrpInputs.TabStop = False
        GrpInputs.Text = "Coefficients"
        ' 
        ' TxtBoxC
        ' 
        TxtBoxC.Font = New Font("Segoe UI", 14F)
        TxtBoxC.Location = New Point(120, 210)
        TxtBoxC.Name = "TxtBoxC"
        TxtBoxC.Size = New Size(280, 39)
        TxtBoxC.TabIndex = 2
        ' 
        ' TxtBoxB
        ' 
        TxtBoxB.Font = New Font("Segoe UI", 14F)
        TxtBoxB.Location = New Point(120, 130)
        TxtBoxB.Name = "TxtBoxB"
        TxtBoxB.Size = New Size(280, 39)
        TxtBoxB.TabIndex = 1
        ' 
        ' TxtBoxA
        ' 
        TxtBoxA.Font = New Font("Segoe UI", 14F)
        TxtBoxA.Location = New Point(120, 50)
        TxtBoxA.Name = "TxtBoxA"
        TxtBoxA.Size = New Size(280, 39)
        TxtBoxA.TabIndex = 0
        ' 
        ' LblC
        ' 
        LblC.AutoSize = True
        LblC.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LblC.Location = New Point(40, 213)
        LblC.Name = "LblC"
        LblC.Size = New Size(33, 32)
        LblC.TabIndex = 0
        LblC.Text = "c:"
        ' 
        ' LblB
        ' 
        LblB.AutoSize = True
        LblB.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LblB.Location = New Point(40, 133)
        LblB.Name = "LblB"
        LblB.Size = New Size(36, 32)
        LblB.TabIndex = 0
        LblB.Text = "b:"
        ' 
        ' LblA
        ' 
        LblA.AutoSize = True
        LblA.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LblA.Location = New Point(40, 53)
        LblA.Name = "LblA"
        LblA.Size = New Size(34, 32)
        LblA.TabIndex = 0
        LblA.Text = "a:"
        ' 
        ' BtnComputeRoots
        ' 
        BtnComputeRoots.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        BtnComputeRoots.FlatStyle = FlatStyle.Flat
        BtnComputeRoots.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        BtnComputeRoots.ForeColor = Color.White
        BtnComputeRoots.Location = New Point(40, 470)
        BtnComputeRoots.Name = "BtnComputeRoots"
        BtnComputeRoots.Size = New Size(250, 60)
        BtnComputeRoots.TabIndex = 4
        BtnComputeRoots.Text = "Compute Roots"
        BtnComputeRoots.UseVisualStyleBackColor = False
        ' 
        ' BtnExit
        ' 
        BtnExit.BackColor = Color.Tomato
        BtnExit.FlatStyle = FlatStyle.Flat
        BtnExit.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        BtnExit.Location = New Point(750, 470)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(250, 60)
        BtnExit.TabIndex = 6
        BtnExit.Text = "Exit"
        BtnExit.UseVisualStyleBackColor = False
        ' 
        ' BtnClear
        ' 
        BtnClear.BackColor = Color.Silver
        BtnClear.FlatStyle = FlatStyle.Flat
        BtnClear.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        BtnClear.Location = New Point(395, 470)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(250, 60)
        BtnClear.TabIndex = 5
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1040, 570)
        Controls.Add(GrpResults)
        Controls.Add(BtnClear)
        Controls.Add(BtnExit)
        Controls.Add(BtnComputeRoots)
        Controls.Add(GrpInputs)
        Controls.Add(LblSubtitle)
        Controls.Add(LblTitle)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Professional Quadratic Solver"
        GrpResults.ResumeLayout(False)
        GrpInputs.ResumeLayout(False)
        GrpInputs.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents LblSubtitle As Label
    Friend WithEvents GrpResults As GroupBox
    Friend WithEvents GrpInputs As GroupBox
    Friend WithEvents TxtBoxC As TextBox
    Friend WithEvents TxtBoxB As TextBox
    Friend WithEvents TxtBoxA As TextBox
    Friend WithEvents LblC As Label
    Friend WithEvents LblB As Label
    Friend WithEvents LblA As Label
    Friend WithEvents BtnComputeRoots As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents LblResultText As Label
    Friend WithEvents BtnClear As Button

End Class
