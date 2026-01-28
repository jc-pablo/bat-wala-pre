Public Class Form8

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim totalFee As Decimal = 0D
        Dim discount As Decimal = 0D
        Dim finalTotal As Decimal = 0D

        If CheckBox10.Checked Then totalFee += 28000D
        If CheckBox11.Checked Then totalFee += 32000D
        If CheckBox12.Checked Then totalFee += 32000D
        If CheckBox13.Checked Then totalFee += 34000D
        If CheckBox14.Checked Then totalFee += 34000D
        If CheckBox15.Checked Then totalFee += 36000D
        If CheckBox16.Checked Then totalFee += 36000D

        If CheckBox17.Checked Then totalFee += 6600D

        If CheckBox9.Checked Then
            discount = totalFee * 0.1D
        End If

        finalTotal = totalFee - discount

        lblPay1.Text = "₱ " & totalFee.ToString("#,##0.00")
        lblPay2.Text = "₱ " & discount.ToString("#,##0.00")
        lblPay3.Text = "₱ " & finalTotal.ToString("#,##0.00")
    End Sub
    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False
        CheckBox16.Checked = False
        CheckBox17.Checked = False
        lblPay1.Text = "₱ 0.00"
        lblPay2.Text = "₱ 0.00"
        lblPay3.Text = "₱ 0.00"

        txtAmount.Clear()
        lblChange.Text = "₱ 0.00"
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim studentName As String = txtName.Text

        If lblPay3.Text = "" Or lblPay3.Text = "₱ 0.00" Then
            MessageBox.Show("Please compute a total before saving.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(studentName) Then
            MessageBox.Show("Please enter the customer's name first.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtName.Focus()
            Exit Sub
        End If

        Dim summary As String = "Welcome To Arellano University!." & vbCrLf &
                            "----------------------------" & vbCrLf &
                            "Student: " & studentName & vbCrLf &
                            "----------------------------" & vbCrLf &
                            "Total Fee: " & lblPay1.Text & vbCrLf &
                            "Discount:    " & lblPay2.Text & vbCrLf &
                            "Paid:   " & lblPay3.Text & vbCrLf &
                            "----------------------------" & vbCrLf &
                            "Date: " & DateTime.Now.ToShortDateString()
        MessageBox.Show(summary, "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim paid As Decimal = 0D
        Dim totaltoPay As Decimal = 0D
        Dim change As Decimal = 0D

        Dim cleanTotal As String = lblPay3.Text.Replace("₱ ", "").Replace(",", "")

        If Decimal.TryParse(cleanTotal, totaltoPay) Then
            If Decimal.TryParse(txtAmount.Text, paid) Then
                If paid >= totaltoPay Then

                    change = paid - totaltoPay


                    lblChange.Text = "₱ " & change.ToString("#,##0.00")

                    MessageBox.Show("Payment Received. Thank you!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                    Dim lack As Decimal = totaltoPay - paid
                    MessageBox.Show("Insufficient funds. You still need ₱ " & lack.ToString("N2"), "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Please enter a valid amount in the payment box.", "Input Error")
            End If
        Else
            MessageBox.Show("Please compute the total before making a payment.", "System Message")
        End If
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class