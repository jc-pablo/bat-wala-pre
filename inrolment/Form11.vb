Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header

Public Class Form11

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim total As Decimal = 0

        For i As Integer = 0 To ListBox1.Items.Count - 1

            Dim itemText As String = ListBox1.Items(i).ToString()
            Dim parts() As String = itemText.Split("x")
            Dim item As String = parts(0).Trim()
            Dim qty As Integer = CInt(parts(1).Trim())



            If item.Contains("Regular Uniform - Small") Then
                total += (950 * qty)
            ElseIf item.Contains("Regular Uniform - Medium") Then
                total += (1050 * qty)
            ElseIf item.Contains("Regular Uniform - Large") Then
                total += (1150 * qty)
            ElseIf item.Contains("Regular Uniform - XL") Then
                total += (1250 * qty)
            ElseIf item.Contains("PE Uniform - Small") Then
                total += (650 * qty)
            ElseIf item.Contains("PE Uniform - Medium") Then
                total += (750 * qty)
            ElseIf item.Contains("PE Uniform - Large") Then
                total += (850 * qty)
            ElseIf item.Contains("PE Uniform - XL") Then
                total += (950 * qty)
            ElseIf item.Contains("Kinder Set") Then
                total += (3000 * qty)
            ElseIf item.Contains("Grade 1 Set") Then
                total += (4000 * qty)
            ElseIf item.Contains("Grade 2 Set") Then
                total += (4500 * qty)
            ElseIf item.Contains("Grade 3 Set") Then
                total += (4500 * qty)
            ElseIf item.Contains("Grade 4 Set") Then
                total += (4950 * qty)
            ElseIf item.Contains("Grade 5 Set") Then
                total += (5000 * qty)
            ElseIf item.Contains("Grade 6 Set") Then
                total += (5150 * qty)
            End If
        Next

        lblTotal.Text = "₱ " & total.ToString("#,##0.00")
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim qty As Integer
        If Not Integer.TryParse(txtQty.Text, qty) Then qty = 1

        If CheckBox1.Checked Then
            ListBox1.Items.Add("Regular Uniform - Small x" & qty)
        End If
        If CheckBox2.Checked Then
            ListBox1.Items.Add("Regular Uniform - Medium x" & qty)
        End If
        If CheckBox3.Checked Then
            ListBox1.Items.Add("Regular Uniform - Large x" & qty)
        End If
        If CheckBox4.Checked Then
            ListBox1.Items.Add("Regular Uniform - XL x" & qty)
        End If
        If CheckBox8.Checked Then
            ListBox1.Items.Add("PE Uniform - Small x" & qty)
        End If
        If CheckBox7.Checked Then
            ListBox1.Items.Add("PE Uniform - Medium x" & qty)
        End If
        If CheckBox6.Checked Then
            ListBox1.Items.Add("PE Uniform - Large x" & qty)
        End If
        If CheckBox5.Checked Then
            ListBox1.Items.Add("PE Uniform - XL x" & qty)
        End If
        If CheckBox16.Checked Then
            ListBox1.Items.Add("Kinder Set x" & qty)
        End If
        If CheckBox14.Checked Then
            ListBox1.Items.Add("Grade 1 Set x" & qty)
        End If
        If CheckBox15.Checked Then
            ListBox1.Items.Add("Grade 2 Set x" & qty)
        End If
        If CheckBox13.Checked Then
            ListBox1.Items.Add("Grade 3 Set x" & qty)
        End If
        If CheckBox12.Checked Then
            ListBox1.Items.Add("Grade 4 Set x" & qty)
        End If
        If CheckBox11.Checked Then
            ListBox1.Items.Add("Grade 5 Set x" & qty)
        End If
        If CheckBox10.Checked Then
            ListBox1.Items.Add("Grade 6 Set x" & qty)
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
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form10.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form4.Show()
        Me.Hide()
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

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class