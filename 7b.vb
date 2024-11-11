Public Class Form1
    Private Sub btnCheckStatus_Click(sender As Object, e As EventArgs) Handles btnCheckStatus.Click
        Try
            Dim studentID As String = txtStudentID.Text
            If String.IsNullOrEmpty(studentID) Then
                Throw New ArgumentException("Student ID cannot be empty.")
            End If
            Dim enrolledStudentIDs As New List(Of String) From {"12345", "67890", "54321"}
            If enrolledStudentIDs.Contains(studentID) Then
                MessageBox.Show("Student is enrolled.")
            Else
                MessageBox.Show("Student is not enrolled.")
            End If
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
    End Sub
End Class