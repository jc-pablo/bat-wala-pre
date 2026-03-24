Imports System.IO
Imports System.Data.SqlClient
Public Class Form12
    Dim connString As String = "Data Source=DESKTOP-EBN38MA;Initial Catalog=StoreDB;Integrated Security=True"
    Public Sub LoadMerchItems()
        flpShirts.Controls.Clear()
        flpHoodies.Controls.Clear()
        flpMerch.Controls.Clear()

        Using conn As New SqlConnection(connString)
            Dim cmd As New SqlCommand("SELECT ItemName, ItemPrice, SubCategory FROM Products WHERE Category = 'Merch'", conn)
            conn.Open()
            Dim reader = cmd.ExecuteReader()

            While reader.Read()
                Dim itemName As String = reader("ItemName").ToString()
                Dim itemPrice As Decimal = CDec(reader("ItemPrice"))
                Dim subCat As String = reader("SubCategory").ToString()

                Dim chk As New CheckBox With {
                .Text = itemName & " ₱" & itemPrice.ToString("N0"),
                .AutoSize = True,
                .ForeColor = Color.White,
                .Margin = New Padding(5)
            }
                If subCat = "Shirts" Then
                    flpShirts.Controls.Add(chk)
                ElseIf subCat = "Hoodies" Then
                    flpHoodies.Controls.Add(chk)
                Else
                    flpMerch.Controls.Add(chk)
                End If
            End While
        End Using
    End Sub
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMerchItems()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim qty As Integer = 1
        If Not Integer.TryParse(txtQty.Text, qty) Then qty = 1
        Dim panels() As FlowLayoutPanel = {flpShirts, flpHoodies, flpMerch}

        For Each pnl In panels
            For Each ctrl As Control In pnl.Controls
                If TypeOf ctrl Is CheckBox Then
                    Dim chk = DirectCast(ctrl, CheckBox)
                    If chk.Checked Then
                        ListBox1.Items.Add(chk.Text & " x" & qty)
                        chk.Checked = False
                    End If
                End If
            Next
        Next
    End Sub
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        If ListBox1.Items.Count = 0 Then
            MessageBox.Show("Please add items to the cart first before computing.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim total As Decimal = 0

        For Each item As String In ListBox1.Items
            Try
                Dim startPrice As Integer = item.IndexOf("₱") + 1
                Dim endPrice As Integer = item.IndexOf(" x")
                Dim pricePart As Decimal = CDec(item.Substring(startPrice, endPrice - startPrice).Replace(",", "").Trim())
                Dim qtyPart As Integer = CInt(item.Split("x").Last().Trim())

                total += (pricePart * qtyPart)
            Catch ex As Exception
            End Try
        Next

        lblTotal.Text = "₱ " & total.ToString("#,##0.00")
    End Sub

    Private Sub GenerateReceipt()
        Dim receiptText As String = "ARELLANO MERCH SHOP" & vbCrLf &
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        Form2.Show()
        Me.Hide()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Form14.Show()
        Me.Hide()
    End Sub

    Private Sub flpShirts_Paint(sender As Object, e As PaintEventArgs) Handles flpShirts.Paint

    End Sub
End Class