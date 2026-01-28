Public Class Form12
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim total As Decimal = 0

        For i As Integer = 0 To ListBox1.Items.Count - 1

            Dim itemText As String = ListBox1.Items(i).ToString()
            Dim parts() As String = itemText.Split("x")
            Dim item As String = parts(0).Trim()
            Dim qty As Integer = CInt(parts(1).Trim())



            If item.Contains("AU Shirt - Small") Then
                total += (339 * qty)
            ElseIf item.Contains("AU Shirt - Medium") Then
                total += (400 * qty)
            ElseIf item.Contains("AU Shirt - Large") Then
                total += (520 * qty)
            ElseIf item.Contains("AU Shirt - XL") Then
                total += (650 * qty)
            ElseIf item.Contains("AU Hoodie - Small") Then
                total += (990 * qty)
            ElseIf item.Contains("AU Hoodie - Medium") Then
                total += (1050 * qty)
            ElseIf item.Contains("AU Hoodie - Large") Then
                total += (1110 * qty)
            ElseIf item.Contains("AU Hoodie - XL") Then
                total += (1200 * qty)
            ElseIf item.Contains("Lanyard") Then
                total += (100 * qty)
            ElseIf item.Contains("NCAA Arellano Mug") Then
                total += (199 * qty)
            ElseIf item.Contains("Arellano Facemask") Then
                total += (90 * qty)
            ElseIf item.Contains("Arellano Cup") Then
                total += (250 * qty)
            ElseIf item.Contains("Arellano Wristband") Then
                total += (80 * qty)
            ElseIf item.Contains("Arellano Socks") Then
                total += (120 * qty)
            ElseIf item.Contains("Arellano Tumbler") Then
                total += (120 * qty)
            End If

        Next

        lblTotal.Text = "₱ " & total.ToString("#,##0.00")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim qty As Integer
        If Not Integer.TryParse(txtQty.Text, qty) Then qty = 1

        If CheckBox1.Checked Then
            ListBox1.Items.Add("AU Shirt - Small x" & qty)
        End If
        If CheckBox2.Checked Then
            ListBox1.Items.Add("AU Shirt - Medium x" & qty)
        End If
        If CheckBox3.Checked Then
            ListBox1.Items.Add("AU Shirt - Large x" & qty)
        End If
        If CheckBox4.Checked Then
            ListBox1.Items.Add("AU Shirt - XL x" & qty)
        End If
        If CheckBox8.Checked Then
            ListBox1.Items.Add("AU Hoodie - Small x" & qty)
        End If
        If CheckBox7.Checked Then
            ListBox1.Items.Add("AU Hoodie - Medium x" & qty)
        End If
        If CheckBox6.Checked Then
            ListBox1.Items.Add("AU Hoodie - Large x" & qty)
        End If
        If CheckBox5.Checked Then
            ListBox1.Items.Add("AU Hoodie - XL x" & qty)
        End If
        If CheckBox16.Checked Then
            ListBox1.Items.Add("Lanyard x" & qty)
        End If
        If CheckBox14.Checked Then
            ListBox1.Items.Add("NCAA Arellano Mug x" & qty)
        End If
        If CheckBox15.Checked Then
            ListBox1.Items.Add("Arellano Facemask x" & qty)
        End If
        If CheckBox13.Checked Then
            ListBox1.Items.Add("Arellano Cup x" & qty)
        End If
        If CheckBox12.Checked Then
            ListBox1.Items.Add("Arellano Wristband x" & qty)
        End If
        If CheckBox11.Checked Then
            ListBox1.Items.Add("Arellano Socks x" & qty)
        End If
        If CheckBox10.Checked Then
            ListBox1.Items.Add("Arellano Tumbler x" & qty)
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If ListBox1.SelectedIndex <> -1 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        Else
            MessageBox.Show("Please select an item to first.")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()

        lblTotal.Text = "₱ 0.00"
        lblChange.Text = "₱ 0.00"
        txtQty.Text = "1"
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim amountPaid As Decimal = 0
        Dim totalDue As Decimal = 0
        Dim cleanTotal As String = lblTotal.Text.Replace("₱ ", "").Replace(",", "")

        If Decimal.TryParse(cleanTotal, totalDue) Then
            If Decimal.TryParse(txtAmountTendered.Text, amountPaid) Then
                If amountPaid >= totalDue Then
                    Dim change As Decimal = amountPaid - totalDue
                    lblChange.Text = "₱ " & change.ToString("#,##0.00")
                    MessageBox.Show("Payment Successful!", "Success")
                Else
                    MessageBox.Show("Kulang ang iyong bayad.", "Error")
                End If
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form10.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class