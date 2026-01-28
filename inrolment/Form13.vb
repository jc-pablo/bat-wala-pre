Public Class Form13
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim total As Decimal = 0

        For i As Integer = 0 To ListBox1.Items.Count - 1

            Dim itemText As String = ListBox1.Items(i).ToString()
            Dim parts() As String = itemText.Split("x")
            Dim item As String = parts(0).Trim()
            Dim qty As Integer = CInt(parts(1).Trim())

            If item.Contains("AU Notebook") Then
                total += (120 * qty)
            ElseIf item.Contains("AU Planner") Then
                total += (300 * qty)
            ElseIf item.Contains("AU Sticky Notes") Then
                total += (80 * qty)
            ElseIf item.Contains("AU Eraser") Then
                total += (20 * qty)
            ElseIf item.Contains("AU Pad Paper") Then
                total += (50 * qty)
            ElseIf item.Contains("AU Pencil") Then
                total += (15 * qty)
            ElseIf item.Contains("AU Ballpen") Then
                total += (18 * qty)
            End If

        Next

        lblTotal.Text = "₱ " & total.ToString("#,##0.00")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim qty As Integer
        If Not Integer.TryParse(txtQty.Text, qty) Then qty = 1

        If CheckBox16.Checked Then
            ListBox1.Items.Add("AU Notebook x" & qty)
        End If
        If CheckBox14.Checked Then
            ListBox1.Items.Add("AU Planner x" & qty)
        End If
        If CheckBox15.Checked Then
            ListBox1.Items.Add("AU Sticky Notes x" & qty)
        End If
        If CheckBox13.Checked Then
            ListBox1.Items.Add("AU Eraser x" & qty)
        End If
        If CheckBox12.Checked Then
            ListBox1.Items.Add("AU Pad Paper x" & qty)
        End If
        If CheckBox11.Checked Then
            ListBox1.Items.Add("AU Pencil x" & qty)
        End If
        If CheckBox10.Checked Then
            ListBox1.Items.Add("AU Ballpen x" & qty)
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

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form4.Show()
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

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form10.Show()
        Me.Hide()
    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class