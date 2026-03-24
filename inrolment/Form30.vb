Imports System.Data.SqlClient

Public Class Form30
    Dim connString As String = "Data Source=DESKTOP-EBN38MA;Initial Catalog=StoreDB;Integrated Security=True"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtItemName.Text) OrElse
       String.IsNullOrWhiteSpace(txtItemPrice.Text) OrElse
       cmbCategory.SelectedIndex = -1 OrElse
       cmbSubCategory.SelectedIndex = -1 Then

            MessageBox.Show("Please input Name, Price, and select a Category!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As New SqlConnection(connString)
                Dim sql As String = "INSERT INTO Products (ItemName, ItemPrice, Category, SubCategory) VALUES (@name, @price, @cat, @sub)"
                Dim cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@name", txtItemName.Text)
                cmd.Parameters.AddWithValue("@price", CDec(txtItemPrice.Text))
                cmd.Parameters.AddWithValue("@cat", cmbCategory.Text)
                cmd.Parameters.AddWithValue("@sub", cmbSubCategory.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                If cmbCategory.Text = "Stationery" Then
                    Form13.LoadStationeryItems()
                ElseIf cmbCategory.Text = "Uniform" Or cmbCategory.Text = "Books" Then
                    Form11.LoadUniBooksItems()
                    ElseIf cmbCategory.Text = "Merch" Then
                        Form12.LoadMerchItems()
                    End If


                    MessageBox.Show("Store Updated! Added to " & cmbCategory.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtItemName.Clear()
                txtItemPrice.Clear()
                cmbCategory.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Using conn As New SqlConnection(connString)
            Dim cmd As New SqlCommand("SELECT ProductId, ItemName, ItemPrice FROM Products", conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()

            conn.Open()
            adapter.Fill(table)
            dgvProducts.DataSource = table
        End Using
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgvProducts.SelectedRows.Count > 0 Then
            Dim id As Integer = dgvProducts.SelectedRows(0).Cells("ProductId").Value

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                Using conn As New SqlConnection(connString)
                    Dim cmd As New SqlCommand("DELETE FROM Products WHERE ProductId = @id", conn)
                    cmd.Parameters.AddWithValue("@id", id)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    btnView.PerformClick()
                    Form13.LoadStationeryItems()

                    MessageBox.Show("Item removed successfully!")
                End Using
            End If
        Else
            MessageBox.Show("Please select a row in the list first.")
        End If
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Using conn As New SqlConnection(connString)
            Dim sql As String = "SELECT ProductId, ItemName, ItemPrice, Category FROM Products " &
                               "WHERE ItemName LIKE @search"

            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text & "%")

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()

            Try
                conn.Open()
                adapter.Fill(table)
                dgvProducts.DataSource = table

                If table.Rows.Count = 0 Then
                    MessageBox.Show("No items found matching that name.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Error during search: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form13.Show()
        Me.Hide()
    End Sub

    Private Sub Form30_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProducts.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub
    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Form8.Show()
        Me.Hide()
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

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Form14.Show()
        Me.Hide()
    End Sub
End Class