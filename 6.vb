Public Class Form1
    Dim filePath As String = "C:\Users\DELL\Desktop\fh.txt"
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Try
        If System.IO.File.Exists(filePath) Then
            txtFileContent.Text = System.IO.File.ReadAllText(filePath)
            MessageBox.Show("File content loaded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error )
        End If
        Catch ex As Exception
        MessageBox.Show("Error reading the file: " & ex.Message, "Error", MessageBoxButtons.OK,
        MessageBoxIcon.Error )
        End Try
    End Sub
    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Try
        If System.IO.File.Exists(filePath) Then
            System.IO.File.WriteAllText(filePath, txtFileContent.Text)
            MessageBox.Show("File content modified.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error )
        End If
        Catch ex As Exception
        MessageBox.Show("Error modifying the file: " & ex.Message, "Error", MessageBoxButtons.OK,
        MessageBoxIcon.Error )
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
        If System.IO.File.Exists(filePath) Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the file?",
            "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                System.IO.File.Delete(filePath)
                txtFileContent.Clear() ' Clear the TextBox
                MessageBox.Show("File deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error )
        End If
        Catch ex As Exception
        MessageBox.Show("Error deleting the file: " & ex.Message, "Error", MessageBoxButtons.OK,
        MessageBoxIcon.Error )
        End Try
    End Sub
End Class