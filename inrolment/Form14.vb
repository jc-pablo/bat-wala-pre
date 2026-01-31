Public Class Form14
    Dim dtLibrary As New DataTable
    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        If CheckedListBox1.Items.Count = 0 Then
            MessageBox.Show("Please add items to your list first.")
            Return
        End If

        For Each item In CheckedListBox1.Items

            For Each row As DataRow In dtLibrary.Rows
                If row("BOOK TITLE").ToString() = item.ToString() Then
                    If row("CATEGORY").ToString() = "Supplies" Then
                        Dim currentQty As Integer = CInt(row("QTY"))
                        If currentQty > 0 Then
                            row("QTY") = currentQty - 1
                            If CInt(row("QTY")) = 0 Then row("STATUS") = "Out of Stock"
                        Else
                            MessageBox.Show(item.ToString() & " is out of stock!")
                            Continue For
                        End If
                    Else
                        row("STATUS") = "Borrowed"
                    End If
                End If
            Next
        Next

        CheckedListBox1.Items.Clear()
        MessageBox.Show("Items successfully borrowed! Please return by " & DateTimePicker2.Value.ToString("hh:mm tt"),
                "Borrow Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateDashboard()
        DateTimePicker2.Value = DateTime.Now
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        For Each row As DataGridViewRow In dtLib.Rows
            Dim isSelected As Boolean = False
            If Not IsDBNull(row.Cells("SELECT").Value) Then
                isSelected = Convert.ToBoolean(row.Cells("SELECT").Value)
            End If

            If isSelected Then
                Dim itemName As String = row.Cells("BOOK TITLE").Value.ToString()

                If Not CheckedListBox1.Items.Contains(itemName) Then
                    CheckedListBox1.Items.Add(itemName, True)
                End If

                row.Cells("SELECT").Value = False
            End If
        Next
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim itemsToRemove As New List(Of Object)
        For Each checkedItem In CheckedListBox1.CheckedItems
            itemsToRemove.Add(checkedItem)
        Next

        For Each item In itemsToRemove
            CheckedListBox1.Items.Remove(item)
            For Each row As DataGridViewRow In dtLib.Rows
                If row.Cells("BOOK TITLE").Value.ToString() = item.ToString() Then
                    row.Cells("SELECT").Value = False
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtLibrary.Columns.Add("SELECT", GetType(Boolean))
        dtLibrary.Columns.Add("BOOK TITLE")
        dtLibrary.Columns.Add("AUTHOR")
        dtLibrary.Columns.Add("DATE PUBLISHED")
        dtLibrary.Columns.Add("STATUS")
        dtLibrary.Columns.Add("CATEGORY")
        dtLibrary.Columns.Add("QTY", GetType(Integer))


        dtLibrary.Rows.Add(False, "A History of the Philippines for Young Readers", "Gregorio F. Zaide", "1983", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "Animal Math: Cheetah Math", "Ann WhiteheadNagda", "2007", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "Berenstain Bears and the Spelling Bee", "Stan & Jan Berenstain", "1983", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "Charlotte's Web", "Elwyn Brooks White", "1952", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "Diary Of A Wimpy Kid", "Jeff Kinney", "2007", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "Each Kindness", "Jacqueline Woodson", "2012", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "Flat Stanley", "Jeff Brown", "1964", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "Have You Filled a Bucket Today?", "Carol McCloud", "2006", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "Math Curse", "Jon Scieszka", "1995", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "Murderous Maths", "Jon Scieszka", "1995", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "Our National Heroes: Stories of Rizal, Bonifacio, and Mabini", "Lamberto Antonio", "2010", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "Sandangaw (A Waray Tale)", "Voltaire Q. Oyzon", "2025", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "Science Verse", "Jon Scieszka", "2004", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "Stand in My Shoes: Kids Learning About Empathy", "Bob Sornson", "1996", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "The Berenstain Bears and the Spelling Bee", "S. Berenstain & J. Berenstain", "1983", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "The Boxcar Children", "Gertrude Chandler Warner", "1924", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "The Magic School Bus Inside the Human Body", "Joanna Cole", "1989", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "Under the Sea", "Anna Milbourne", "2013", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "Values Formation for Filipino Children", "DepEd-aligned reading", "2017", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "Where the Wild Things Are", "Maurice Bernard Sendak", "1963", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "Xander’s Panda Party", "Linda Sue Park", "2015", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "You Are Special", "Max Lucado", "1997", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "Zoo-ology", "Ben Newman", "2017", "Available", "Book", 1)
        dtLibrary.Rows.Add(False, "Pencil", "", "", "Available", "Supplies", 20)
        dtLibrary.Rows.Add(False, "Eraser", "", "", "Available", "Supplies", 16)
        dtLibrary.Rows.Add(False, "Crayons (24 Colors)", "", "", "Available", "Supplies", 7)
        dtLibrary.Rows.Add(False, "Watercolor Paint", "", "", "Available", "Supplies", 5)
        dtLibrary.Rows.Add(False, "Glue Stick", "", "", "Available", "Supplies", 12)
        dtLibrary.Rows.Add(False, "Safety Scissors", "", "", "Available", "Supplies", 9)
        dtLibrary.Rows.Add(False, "Plastic Ruler", "", "", "Available", "Supplies", 15)
        dtLibrary.Rows.Add(False, "Notebook", "", "", "Available", "Supplies", 8)
        dtLibrary.Rows.Add(False, "Pad Papers", "", "", "Available", "Supplies", 60)
        dtLibrary.Rows.Add(False, "Pencil Sharpener", "", "", "Available", "Supplies", 4)
        dtLibrary.Rows.Add(False, "Calculator", "", "", "Available", "Supplies", 3)
        dtLibrary.Rows.Add(False, "Sketch Pad", "", "", "Available", "Supplies", 6)
        dtLibrary.Rows.Add(False, "Highlighters", "", "", "Available", "Supplies", 30)
        dtLibrary.Rows.Add(False, "Whiteboard", "", "", "Available", "Supplies", 15)
        dtLibrary.Rows.Add(False, "Whiteboard Markers", "", "", "Available", "Supplies", 15)
        dtLibrary.Rows.Add(False, "Flashcards", "", "", "Available", "Supplies", 40)
        dtLibrary.Rows.Add(False, "Chalk", "", "", "Available", "Supplies", 50)





        dtLib.DataSource = dtLibrary
        dtLib.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dtLib.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dtLib.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dtLib.AllowUserToAddRows = False
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
    End Sub

    Private Sub rbBooks_CheckedChanged(sender As Object, e As EventArgs) Handles rbBooks.CheckedChanged
        If DirectCast(sender, RadioButton).Checked Then
            UpdateCategoryFilter()


            If rbBooks.Checked Then
                dtLib.Columns("BOOK TITLE").HeaderText = "BOOK TITLE"
                dtLib.Columns("AUTHOR").Visible = True
            Else
                dtLib.Columns("BOOK TITLE").HeaderText = "ITEM NAME"
                dtLib.Columns("AUTHOR").Visible = False
            End If
        End If
    End Sub

    Private Sub rbSupplies_CheckedChanged(sender As Object, e As EventArgs) Handles rbSupplies.CheckedChanged
        If rbSupplies.Checked Then
            dtLibrary.DefaultView.RowFilter = "CATEGORY = 'Supplies'"

            dtLib.Columns("BOOK TITLE").HeaderText = "ITEM NAME"
            dtLib.Columns("AUTHOR").Visible = False
            dtLib.Columns("DATE PUBLISHED").Visible = False
        End If
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchValue As String = txtSearch.Text.Trim().Replace("'", "''")

        Try
            If String.IsNullOrEmpty(searchValue) Then
                UpdateCategoryFilter()
            Else
                Dim filter As String = String.Format("[BOOK TITLE] LIKE '%{0}%' OR AUTHOR LIKE '%{0}%'", searchValue)
                If rbBooks.Checked Then
                    dtLibrary.DefaultView.RowFilter = "(" & filter & ") AND CATEGORY = 'Book'"
                ElseIf rbSupplies.Checked Then
                    dtLibrary.DefaultView.RowFilter = "(" & filter & ") AND CATEGORY = 'Supplies'"
                End If
            End If
        Catch ex As Exception
            dtLibrary.DefaultView.RowFilter = ""
        End Try
    End Sub

    Private Sub UpdateCategoryFilter()
        Dim category As String = If(rbBooks.Checked, "Book", "Supplies")
        Dim searchValue As String = txtSearch.Text.Trim().Replace("'", "''")

        If String.IsNullOrEmpty(searchValue) Then
            dtLibrary.DefaultView.RowFilter = "CATEGORY = '" & category & "'"
        Else
            dtLibrary.DefaultView.RowFilter = String.Format("CATEGORY = '{0}' AND ([BOOK TITLE] LIKE '%{1}%' OR AUTHOR LIKE '%{1}%')", category, searchValue)
        End If
    End Sub
    Private Sub UpdateDashboard()
        Dim totalBooks As Integer = dtLibrary.Compute("COUNT([BOOK TITLE])", "CATEGORY = 'Book'")
        Dim borrowedBooks As Integer = dtLibrary.Compute("COUNT([BOOK TITLE])", "CATEGORY = 'Book' AND STATUS = 'Borrowed'")
        Dim availableBooks As Integer = totalBooks - borrowedBooks

        lblTotal.Text = "" & totalBooks
        lblAvailable.Text = "" & availableBooks
        lblBorrowed.Text = "" & borrowedBooks
    End Sub
    Private Sub dtLib_DataBindingComplete(sender As Object, e As EventArgs) Handles dtLib.DataBindingComplete
        For Each row As DataGridViewRow In dtLib.Rows
            If row.IsNewRow Then Continue For
            If row.Cells("STATUS").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("STATUS").Value) Then

                Dim statusValue As String = row.Cells("STATUS").Value.ToString()

                If statusValue = "Borrowed" Then
                    row.DefaultCellStyle.ForeColor = Color.Red
                ElseIf statusValue = "Available" Then
                    row.DefaultCellStyle.ForeColor = Color.Black
                ElseIf statusValue = "Out of Stock" Then
                    row.DefaultCellStyle.ForeColor = Color.Gray
                End If

            End If
        Next

    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If CheckedListBox1.CheckedItems.Count = 0 Then
            MessageBox.Show("Please select the item(s) you wish to return.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim deadline As DateTime = DateTimePicker2.Value
        Dim currentTime As DateTime = DateTime.Now
        Dim isLate As Boolean = (currentTime > deadline)

        If currentTime > deadline.AddMinutes(1) Then
            isLate = True
        Else
            isLate = False
        End If
        For i As Integer = CheckedListBox1.CheckedItems.Count - 1 To 0 Step -1
            Dim itemName As String = CheckedListBox1.CheckedItems(i).ToString()

            For Each row As DataRow In dtLibrary.Rows
                If row("BOOK TITLE").ToString() = itemName Then
                    If row("CATEGORY").ToString() = "Supplies" Then
                        row("QTY") = CInt(row("QTY")) + 1
                        If CInt(row("QTY")) > 0 Then row("STATUS") = "Available"
                    Else
                        row("STATUS") = "Available"
                    End If
                End If
            Next
            CheckedListBox1.Items.RemoveAt(i)
        Next

        UpdateDashboard()
        dtLib.Refresh()

        If isLate Then
            MessageBox.Show("The return deadline has passed. Please return items promptly next time!", "Return Overdue", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Thank you for returning the items on time!", "Return Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form5.Show()
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
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form15.Show()
        Me.Hide()
    End Sub
End Class

