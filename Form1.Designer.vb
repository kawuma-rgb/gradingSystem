<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gradingSystem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnEvaluate = New Button()
        txtMarks = New TextBox()
        lblMarks = New Label()
        lblGrades = New Label()
        SuspendLayout()
        ' 
        ' btnEvaluate
        ' 
        btnEvaluate.Location = New Point(384, 249)
        btnEvaluate.Name = "btnEvaluate"
        btnEvaluate.Size = New Size(75, 23)
        btnEvaluate.TabIndex = 0
        btnEvaluate.Text = "Evaluate"
        btnEvaluate.UseVisualStyleBackColor = True
        ' 
        ' txtMarks
        ' 
        txtMarks.Location = New Point(324, 156)
        txtMarks.Name = "txtMarks"
        txtMarks.Size = New Size(182, 23)
        txtMarks.TabIndex = 1
        ' 
        ' lblMarks
        ' 
        lblMarks.AutoSize = True
        lblMarks.Font = New Font("Segoe UI", 16F)
        lblMarks.Location = New Point(147, 154)
        lblMarks.Name = "lblMarks"
        lblMarks.Size = New Size(127, 30)
        lblMarks.TabIndex = 2
        lblMarks.Text = "Enter marks"
        ' 
        ' lblGrades
        ' 
        lblGrades.AutoSize = True
        lblGrades.Font = New Font("Segoe UI", 16F)
        lblGrades.Location = New Point(147, 201)
        lblGrades.Name = "lblGrades"
        lblGrades.Size = New Size(81, 30)
        lblGrades.TabIndex = 3
        lblGrades.Text = "Grades"
        ' 
        ' gradingSystem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblGrades)
        Controls.Add(lblMarks)
        Controls.Add(txtMarks)
        Controls.Add(btnEvaluate)
        Name = "gradingSystem"
        Text = "gradingSystem"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEvaluate As Button
    Friend WithEvents txtMarks As TextBox
    Friend WithEvents lblMarks As Label
    Friend WithEvents lblGrades As Label

End Class
