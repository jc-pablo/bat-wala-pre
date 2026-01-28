Public Class Form2
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Please enter the Applicant Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Please enter the Gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox2.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MessageBox.Show("Please enter the Grade Level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox3.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBox4.Text) Then
            MessageBox.Show("Please enter the Contact Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox4.Focus()
            Return
        End If

        MessageBox.Show("Proceeding...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class