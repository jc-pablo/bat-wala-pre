Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form27
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        If ListBox1.Items.Count = 0 Then
            MessageBox.Show("Please add items to the cart first before computing.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim total As Decimal = 0

        For i As Integer = 0 To ListBox1.Items.Count - 1

            Dim itemText As String = ListBox1.Items(i).ToString()
            Dim parts() As String = itemText.Split("x")
            Dim item As String = parts(0).Trim()
            Dim qty As Integer = CInt(parts(1).Trim())

            If item.Contains("Jersey All Sizes") Then
                total += (1200 * qty)
            ElseIf item.Contains("Martial Arts Uniform All Sizes") Then
                total += (1800 * qty)
            ElseIf item.Contains("Knee Pads") Then
                total += (450 * qty)
            ElseIf item.Contains("Mouth Guard") Then
                total += (300 * qty)
            ElseIf item.Contains("Sports Gloves") Then
                total += (400 * qty)
            ElseIf item.Contains("Tennis rackets") Then
                total += (2100 * qty)
            ElseIf item.Contains("Golf Ball Set") Then
                total += (600 * qty)
            ElseIf item.Contains("Sports Bag") Then
                total += (1800 * qty)
            ElseIf item.Contains("Stopwatch/Timer") Then
                total += (800 * qty)
            ElseIf item.Contains("Climbing Chalk Bag") Then
                total += (800 * qty)
            ElseIf item.Contains("Dance/Gymanstics Leotards") Then
                total += (1500 * qty)
            ElseIf item.Contains("Sports Socks (pair)") Then
                total += (320 * qty)
            ElseIf item.Contains("Cleats") Then
                total += (2800 * qty)
            ElseIf item.Contains("Practice Tees") Then
                total += (499 * qty)
            End If

        Next

        lblTotal.Text = "₱ " & total.ToString("#,##0.00")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim qty As Integer
        If Not Integer.TryParse(txtQty.Text, qty) Then qty = 1

        If CheckBox22.Checked Then
            ListBox1.Items.Add("Jersey All Sizes x" & qty)
        End If
        If CheckBox21.Checked Then
            ListBox1.Items.Add("Martial Arts Uniform All Sizes x" & qty)
        End If
        If CheckBox20.Checked Then
            ListBox1.Items.Add("Knee Pads x" & qty)
        End If
        If CheckBox19.Checked Then
            ListBox1.Items.Add("Mouth Guard x" & qty)
        End If
        If CheckBox18.Checked Then
            ListBox1.Items.Add("Sports Gloves x" & qty)
        End If
        If CheckBox17.Checked Then
            ListBox1.Items.Add("Tennis rackets x" & qty)
        End If
        If CheckBox9.Checked Then
            ListBox1.Items.Add("Golf Ball Set x" & qty)
        End If
        If CheckBox1.Checked Then
            ListBox1.Items.Add("Sports Bag x" & qty)
        End If
        If CheckBox3.Checked Then
            ListBox1.Items.Add("Stopwatch/Timer x" & qty)
        End If
        If CheckBox2.Checked Then
            ListBox1.Items.Add("Climbing Chalk Bag x" & qty)
        End If
        If CheckBox14.Checked Then
            ListBox1.Items.Add("Dance/Gymanstics Leotards x" & qty)
        End If
        If CheckBox13.Checked Then
            ListBox1.Items.Add("Sports Socks (pair) x" & qty)
        End If
        If CheckBox12.Checked Then
            ListBox1.Items.Add("Cleats x" & qty)
        End If
        If CheckBox11.Checked Then
            ListBox1.Items.Add("Practice Tees x" & qty)
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
                    MessageBox.Show("Insufficient Payment.", "Error")
                End If
            End If
        End If
    End Sub
    Private Sub GenerateReceipt()
        Dim receiptText As String = "ARELLANO EXTRACURRICULAR SHOP" & vbCrLf &
                                "Official Receipt" & vbCrLf &
                                "----------------------------" & vbCrLf &
                                "Items:" & vbCrLf
        For Each item In ListBox1.Items
            receiptText &= " > " & item.ToString() & vbCrLf
        Next

        receiptText &= "----------------------------" & vbCrLf &
                   "Total Due: " & lblTotal.Text & vbCrLf &
                   "Cash:      ₱ " & CDec(txtAmountTendered.Text).ToString("#,##0.00") & vbCrLf &
                   "Change:    " & lblChange.Text & vbCrLf &
                   "----------------------------" & vbCrLf &
                   "Date: " & DateTime.Now.ToString() & vbCrLf &
                   "============================" & vbCrLf

        Dim fileNum As Integer = FreeFile()
        Try
            FileOpen(fileNum, "ShopReceipts.txt", OpenMode.Append)
            PrintLine(fileNum, receiptText)
            FileClose(fileNum)
            l.receiptText = receiptText

            Form29.Resibo.Text = l.receiptText
            Form29.Show()

        Catch ex As Exception
            FileClose(fileNum)
            MessageBox.Show("Error saving receipt: " & ex.Message)
        End Try
    End Sub
    Private Sub btnResip_Click(sender As Object, e As EventArgs) Handles btnResip.Click
        GenerateReceipt()
    End Sub
    Private Sub btnClearFile_Click(sender As Object, e As EventArgs) Handles btnClearFile.Click
        Dim fileNum As Integer = FreeFile()
        Try
            FileOpen(fileNum, "ShopReceipts.txt", OpenMode.Output)
            FileClose(fileNum)

            MessageBox.Show("All records have been deleted!", "File Cleared")
        Catch ex As Exception
            MessageBox.Show("Error clearing file: " & ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pass As String = "admin123"
        Dim adminInput As String = InputBox("Please enter the admin password:", "Security Check")
        If adminInput = pass Then
            MessageBox.Show("Access Granted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form30.Show()
            Me.Hide()
        ElseIf adminInput = "" Then
            Exit Sub
        Else
            MessageBox.Show("Incorrect Password. Access denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Form14.Show()
        Me.Hide()
    End Sub

    Private Sub Form27_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class