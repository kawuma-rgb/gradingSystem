Public Class gradingSystem
    Private Sub gradingSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click

        Dim marks As Integer
        If Not Integer.TryParse(txtMarks.Text, marks) Then
            MessageBox.Show("Please Enter Valid Numeric value for marks")
            Exit Sub
        End If
        If marks > 100 Then
            MessageBox.Show("Wrong entry, please re-enter the marks")
            Exit Sub
        End If
        Select Case marks
            Case 90 To 100
                lblGrades.Text = "Grades:                Excellent"
            Case 80 To 89
                lblGrades.Text = "Grades:                Invalid Marks"
            Case 70 To 79
                lblGrades.Text = "Grades:                 Good"
            Case 60 To 69
                lblGrades.Text = "Grades:                 Medium"
            Case 50 To 59
                lblGrades.Text = "Grades:                 Pass"
            Case 0 To 49
                lblGrades.Text = "Grades:                 Fail"
            Case Else
                lblGrades.Text = "Grades:                 Invalid Marks"


        End Select


    End Sub
End Class
