Public Class Form1
    Private Sub btnCheckEligibility_Click(sender As Object, e As EventArgs) Handles btnCheckEligibility.Click
        Try
        Dim age As Integer = Convert.ToInt32(txtAge.Text)
        If age < 0 Then
            Throw New ArgumentException("Age cannot be negative.")
        End If
        If age >= 18 Then
            REM lblResult.Text = "You are eligible to vote."
            MessageBox.Show("You are eligible to vote.")
        Else
            REM lblResult.Text = "You are not eligible to vote."
            MessageBox.Show("You are not eligible to vote.")
        End If
        Catch ex As FormatException
        MessageBox.Show("Please enter a valid numeric age.", "Input Error", MessageBoxButtons.OK,
        MessageBoxIcon.Error )
        Catch ex As ArgumentException
        MessageBox.Show(ex.Message, "Age Error", MessageBoxButtons.OK, MessageBoxIcon.Error )
        Catch ex As Exception
        MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK,
        MessageBoxIcon.Error )
        End Try
    End Sub
End Class