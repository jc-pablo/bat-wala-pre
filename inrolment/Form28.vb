Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form28
    Dim kinderTeachers(2), kinderSubs(2) As String
    Dim G1Teachers(4), G1Subs(4), G2Teachers(4), G2Subs(4), G3Teachers(5), G3Subs(5), G4Teachers(6), G4Subs(6), G5Teachers(6), G5Subs(6), G6Teachers(6), G6Subs(6) As String
    Dim palit As Integer = -1

    'Grade Levels
    Private Sub BtnKinder_Click(sender As Object, e As EventArgs) Handles BtnKinder.Click
        CheckedListBox1.Items.Clear()
        CheckedListBox2.Items.Clear()
        dgvFaculty.Rows.Clear()
        CheckedListBox1.Tag = "Kinder"

        kinderTeachers(0) = "Teacher Luna"
        kinderTeachers(1) = "Teacher Santos"
        kinderTeachers(2) = "Teacher Reyes"

        kinderSubs(0) = "Reading Writing"
        kinderSubs(1) = "Mathematics"
        kinderSubs(2) = "Music/Arts & Values"

        For i = 0 To 2
            CheckedListBox1.Items.Add(kinderTeachers(i))
            CheckedListBox2.Items.Add(kinderSubs(i))
            dgvFaculty.Rows.Add("KINDER", kinderTeachers(i), kinderSubs(i), "Available")
            cmbSubjects.Items.Add(kinderSubs(i))
        Next

        cmbSubjects.Items.Clear()
        cmbSubjects.Items.Add("Personal Development")
        cmbSubjects.Items.Add("Language Development")
        cmbSubjects.Items.Add("Social Development")
        cmbSubjects.Items.Add("Science")
        cmbSubjects.Items.Add("Physical Development")
    End Sub

    Private Sub BtnGrade1_Click(sender As Object, e As EventArgs) Handles BtnGrade1.Click
        CheckedListBox1.Items.Clear()
        CheckedListBox2.Items.Clear()
        dgvFaculty.Rows.Clear()
        CheckedListBox1.Tag = "Grade 1"
        G1Teachers(0) = "Ms. Elena M. Dela Cruz"
        G1Teachers(1) = "Mr. JohnRey Bautista"
        G1Teachers(2) = "Ms. Josefina A. Mendoza"
        G1Teachers(3) = "Mr. Fernando G. Garcia"
        G1Teachers(4) = "Ms. Maria Victoria L. Reyes "

        G1Subs(0) = "Mathematics 1"
        G1Subs(1) = "English 1"
        G1Subs(2) = "Filipino 1 & Mother Tongue 1)"
        G1Subs(3) = "Araling Panlipunan 1"
        G1Subs(4) = "MAPEH 1 & EsP 1"
        For i = 0 To 4
            CheckedListBox1.Items.Add(G1Teachers(i))
            CheckedListBox2.Items.Add(G1Subs(i))
            dgvFaculty.Rows.Add("Grade 1", G1Teachers(i), G1Subs(i), "Available")
            cmbSubjects.Items.Add(G1Subs(i))
        Next

        cmbSubjects.Items.Clear()
        cmbSubjects.Items.Add("Basic Mathematics 1")
        cmbSubjects.Items.Add("Reading Comprehension")
        cmbSubjects.Items.Add("Aklat Filipino 1")
        cmbSubjects.Items.Add("History 1")
        cmbSubjects.Items.Add("Musical 1")
    End Sub
    Private Sub BtnGrade2_Click(sender As Object, e As EventArgs) Handles BtnGrade2.Click
        CheckedListBox1.Items.Clear()
        CheckedListBox2.Items.Clear()
        dgvFaculty.Rows.Clear()
        CheckedListBox1.Tag = "Grade 2"
        G2Teachers(0) = "Ms. Elena M. Dela Cruz"
        G2Teachers(1) = "Mr. JohnRey Bautista"
        G2Teachers(2) = "Ms. Josefina A. Mendoza"
        G2Teachers(3) = "Mr. Fernando G. Garcia"
        G2Teachers(4) = "Ms. Maria Victoria L. Reyes "

        G2Subs(0) = "Mathematics 2"
        G2Subs(1) = "English 2"
        G2Subs(2) = "Filipino 2 & Mother Tongue 2)"
        G2Subs(3) = "Araling Panlipunan 2"
        G2Subs(4) = "MAPEH 2 & EsP 2"
        For i = 0 To 4
            CheckedListBox1.Items.Add(G2Teachers(i))
            CheckedListBox2.Items.Add(G2Subs(i))
            dgvFaculty.Rows.Add("Grade 2", G2Teachers(i), G2Subs(i), "Available")
            cmbSubjects.Items.Add(G2Subs(i))
        Next

        cmbSubjects.Items.Clear()
        cmbSubjects.Items.Add("Science 2")
        cmbSubjects.Items.Add("Basic Mathematics 2")
        cmbSubjects.Items.Add("Makabansa 2")
        cmbSubjects.Items.Add("GMRC 2")
        cmbSubjects.Items.Add("Values 2")
    End Sub
    Private Sub BtnGrade3_Click(sender As Object, e As EventArgs) Handles BtnGrade3.Click
        CheckedListBox1.Items.Clear()
        CheckedListBox2.Items.Clear()
        dgvFaculty.Rows.Clear()
        CheckedListBox1.Tag = "Grade 3"
        G3Teachers(0) = "Ms. Elena M. Dela Cruz"
        G3Teachers(1) = "Mr. JohnRey Bautista"
        G3Teachers(2) = "Ms. Josefina A. Mendoza"
        G3Teachers(3) = "Mr. Fernando G. Garcia"
        G3Teachers(4) = "Ms. Maria Victoria L. Reyes "
        G3Teachers(5) = "Ms. Corazon S. Santos"

        G3Subs(0) = "Mathematics 3"
        G3Subs(1) = "English 3"
        G3Subs(2) = "Filipino 3 & Mother Tongue 3)"
        G3Subs(3) = "Araling Panlipunan 3"
        G3Subs(4) = "MAPEH 3 & EsP 3"
        G3Subs(5) = "Science 3"
        For i = 0 To 5
            CheckedListBox1.Items.Add(G3Teachers(i))
            CheckedListBox2.Items.Add(G3Subs(i))
            dgvFaculty.Rows.Add("Grade 3", G3Teachers(i), G3Subs(i), "Available")
            cmbSubjects.Items.Add(G3Subs(i))
        Next

        cmbSubjects.Items.Clear()
        cmbSubjects.Items.Add("Geometry 3")
        cmbSubjects.Items.Add("Basic English 3")
        cmbSubjects.Items.Add("GMRC 3")
        cmbSubjects.Items.Add("Geography 3")
        cmbSubjects.Items.Add("Health 3")
    End Sub

    Private Sub BtnGrade4_Click(sender As Object, e As EventArgs) Handles BtnGrade4.Click
        CheckedListBox1.Items.Clear()
        CheckedListBox2.Items.Clear()
        dgvFaculty.Rows.Clear()
        CheckedListBox1.Tag = "Grade 4"
        G4Teachers(0) = "Ms. Elena M. Dela Cruz"
        G4Teachers(1) = "Mr. JohnRey Bautista"
        G4Teachers(2) = "Ms. Josefina A. Mendoza"
        G4Teachers(3) = "Mr. Fernando G. Garcia"
        G4Teachers(4) = "Ms. Maria Victoria L. Reyes "
        G4Teachers(5) = "Ms. Corazon S. Santos"
        G4Teachers(6) = "Ms. Teresita D. Luna"

        G4Subs(0) = "Mathematics 4"
        G4Subs(1) = "English 4"
        G4Subs(2) = "Filipino 4 & Mother Tongue 4)"
        G4Subs(3) = "Araling Panlipunan 4"
        G4Subs(4) = "MAPEH 4 & EsP 4"
        G4Subs(5) = "Science 4"
        G4Subs(6) = "EPP 4"
        For i = 0 To 6
            CheckedListBox1.Items.Add(G4Teachers(i))
            CheckedListBox2.Items.Add(G4Subs(i))
            dgvFaculty.Rows.Add("Grade 4", G4Teachers(i), G4Subs(i), "Available")
            cmbSubjects.Items.Add(G4Subs(i))
        Next

        cmbSubjects.Items.Clear()
        cmbSubjects.Items.Add("EPP 4")
        cmbSubjects.Items.Add("GMRC 4")
        cmbSubjects.Items.Add("MATATAG 4")
        cmbSubjects.Items.Add("TLE 4")
        cmbSubjects.Items.Add("Agriculture 4")
        cmbSubjects.Items.Add("Physical Education    4")
    End Sub
    Private Sub BtnGrade5_Click(sender As Object, e As EventArgs) Handles BtnGrade5.Click
        CheckedListBox1.Items.Clear()
        CheckedListBox2.Items.Clear()
        dgvFaculty.Rows.Clear()
        CheckedListBox1.Tag = "Grade 5"
        G5Teachers(0) = "Ms. Elena M. Dela Cruz"
        G5Teachers(1) = "Mr. JohnRey Bautista"
        G5Teachers(2) = "Ms. Josefina A. Mendoza"
        G5Teachers(3) = "Mr. Fernando G. Garcia"
        G5Teachers(4) = "Ms. Maria Victoria L. Reyes "
        G5Teachers(5) = "Ms. Corazon S. Santos"
        G5Teachers(6) = "Ms. Teresita D. Luna"

        G5Subs(0) = "Mathematics 5"
        G5Subs(1) = "English 5"
        G5Subs(2) = "Filipino 5 & Mother Tongue 5)"
        G5Subs(3) = "Araling Panlipunan 5"
        G5Subs(4) = "MAPEH 5 & EsP 5"
        G5Subs(5) = "Science 5"
        G5Subs(6) = "EPP 5"
        For i = 0 To 6
            CheckedListBox1.Items.Add(G5Teachers(i))
            CheckedListBox2.Items.Add(G5Subs(i))
            dgvFaculty.Rows.Add("Grade 5", G5Teachers(i), G5Subs(i), "Available")
            cmbSubjects.Items.Add(G5Subs(i))
        Next

        cmbSubjects.Items.Clear()
        cmbSubjects.Items.Add("Reading and Literacy 5")
        cmbSubjects.Items.Add("Leanguage 5")
        cmbSubjects.Items.Add("Makabansa 5")
        cmbSubjects.Items.Add("GMRC 5")
        cmbSubjects.Items.Add("Arts 5")
    End Sub
    Private Sub BtnGrade6_Click(sender As Object, e As EventArgs) Handles BtnGrade6.Click
        CheckedListBox1.Items.Clear()
        CheckedListBox2.Items.Clear()
        dgvFaculty.Rows.Clear()
        CheckedListBox1.Tag = "Grade 6"
        G6Teachers(0) = "Ms. Elena M. Dela Cruz"
        G6Teachers(1) = "Mr. JohnRey Bautista"
        G6Teachers(2) = "Ms. Josefina A. Mendoza"
        G6Teachers(3) = "Mr. Fernando G. Garcia"
        G6Teachers(4) = "Ms. Maria Victoria L. Reyes "
        G6Teachers(5) = "Ms. Corazon S. Santos"
        G6Teachers(6) = "Ms. Teresita D. Luna"

        G6Subs(0) = "Mathematics 6"
        G6Subs(1) = "English 6"
        G6Subs(2) = "Filipino 6 & Mother Tongue 6)"
        G6Subs(3) = "Araling Panlipunan 6"
        G6Subs(4) = "MAPEH 6 & EsP 6"
        G6Subs(5) = "Science 6"
        G6Subs(6) = "EPP 6"
        For i = 0 To 6
            CheckedListBox1.Items.Add(G6Teachers(i))
            CheckedListBox2.Items.Add(G6Subs(i))
            dgvFaculty.Rows.Add("Grade 6", G6Teachers(i), G6Subs(i), "Available")
            cmbSubjects.Items.Add(G6Subs(i))
        Next

        cmbSubjects.Items.Clear()
        cmbSubjects.Items.Add("Statistics 6")
        cmbSubjects.Items.Add("ICT 6")
        cmbSubjects.Items.Add("Literature 6")
        cmbSubjects.Items.Add("Home Economics 6")
        cmbSubjects.Items.Add("Communication 6")
    End Sub

    'DataGrid
    Private Sub Form28_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvFaculty.Columns.Clear()
        dgvFaculty.Columns.Add("Level", "Level")
        dgvFaculty.Columns.Add("Teacher", "Teacher Name")
        dgvFaculty.Columns.Add("Subject", "Subject")
        dgvFaculty.Columns.Add("Status", "Status")
        dgvFaculty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvFaculty.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvFaculty.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvFaculty.AllowUserToAddRows = False
    End Sub

    'Part Timers
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        CheckedListBox1.Items.Clear()
        CheckedListBox1.Tag = "Part Timer"

        CheckedListBox1.Items.Add("Mr. Ricardo Dalisay (Sub)")
        CheckedListBox1.Items.Add("Ms. Luningning Santos (Sub)")
        CheckedListBox1.Items.Add("Mr. Jose Rizal (Sub)")

    End Sub

    'CheckedListBoxes
    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Dim i As Integer = CheckedListBox1.SelectedIndex

        If i <> -1 Then
            TextBoxTeacher.Text = CheckedListBox1.Items(i).ToString()

            If CheckedListBox1.Tag.ToString() <> "Part Timer" Then
                palit = i

                If i < CheckedListBox2.Items.Count Then
                    TextBoxSubject.Text = CheckedListBox2.Items(i).ToString()
                End If
            End If

            dgvFaculty.ClearSelection()
            If i < dgvFaculty.Rows.Count Then
                dgvFaculty.Rows(i).Selected = True
            End If
        End If
    End Sub

    Private Sub CheckedListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox2.SelectedIndexChanged
        Dim i As Integer = CheckedListBox2.SelectedIndex

        If i <> -1 Then
            If i < CheckedListBox1.Items.Count Then
                CheckedListBox1.SelectedIndex = i
            End If
            dgvFaculty.ClearSelection()
            If i < dgvFaculty.Rows.Count Then
                dgvFaculty.Rows(i).Selected = True
            End If

            cmbSubjects.Text = CheckedListBox2.Items(i).ToString()
        End If
    End Sub

    'Change Teachers
    Private Sub BtnChangeTeacher_Click(sender As Object, e As EventArgs) Handles BtnChangeTeacher.Click
        If String.IsNullOrWhiteSpace(txtReason.Text) Then
            MsgBox("Please type a reason first (e.g., On Leave, Sick, Meeting)!")
            txtReason.Focus()
            Return
        End If

        If palit = -1 Then
            MsgBox("Please select a regular teacher from the list first.")
            Return
        End If

        If CheckedListBox1.Tag.ToString() = "Part Timer" Then
            Dim userReason As String = txtReason.Text
            dgvFaculty.Rows(palit).Cells(3).Value = userReason
            dgvFaculty.Rows(palit).DefaultCellStyle.BackColor = Color.MistyRose
            dgvFaculty.Rows(palit).Cells(3).Style.ForeColor = Color.Red

            Dim replacementName As String = TextBoxTeacher.Text
            Dim currentLevel As String = dgvFaculty.Rows(palit).Cells(0).Value.ToString()
            Dim currentSubject As String = dgvFaculty.Rows(palit).Cells(2).Value.ToString()
            dgvFaculty.Rows.Add(currentLevel, replacementName, currentSubject, "Replacement")

            Dim lastRowIndex As Integer = dgvFaculty.Rows.Count - 1
            dgvFaculty.Rows(lastRowIndex).DefaultCellStyle.BackColor = Color.LightCyan
            dgvFaculty.Rows(lastRowIndex).Cells(2).Style.ForeColor = Color.Blue
            MsgBox("Status updated to '" & userReason & "' and replacement assigned!")

            txtReason.Clear()
            palit = -1
            TextBoxTeacher.Text = ""
            TextBoxSubject.Text = ""

        Else
            MsgBox("Please click the 'Part-Timers' button first and select a substitute teacher.")
        End If
    End Sub

    'Change Subjects
    Private Sub BtnChangeSubject_Click(sender As Object, e As EventArgs) Handles BtnChangeSubject.Click
        Dim i As Integer = CheckedListBox2.SelectedIndex

        If i = -1 Then
            MsgBox("Select Subject first.")
            Return
        End If

        If cmbSubjects.SelectedIndex = -1 Then
            MsgBox("Select Subject in Combo Box.")
            Return
        End If

        Dim teacherName As String = ""
        If i < CheckedListBox1.Items.Count Then
            teacherName = CheckedListBox1.Items(i).ToString()
        Else
            teacherName = TextBoxTeacher.Text
        End If
        Dim currentLevel As String = CheckedListBox1.Tag.ToString()
        Dim newSub As String = cmbSubjects.SelectedItem.ToString()

        If i < dgvFaculty.Rows.Count Then
            dgvFaculty.Rows(i).Cells(3).Value = "Subject Changed"
            dgvFaculty.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
        End If

        dgvFaculty.Rows.Add(currentLevel, teacherName, newSub, "New Schedule")

        Dim lastRow As Integer = dgvFaculty.Rows.Count - 1
        dgvFaculty.Rows(lastRow).DefaultCellStyle.BackColor = Color.Honeydew
        dgvFaculty.Rows(lastRow).Cells(3).Style.ForeColor = Color.DarkGreen

        MsgBox("Subject updated for " & teacherName)
        cmbSubjects.SelectedIndex = -1
    End Sub

    'Clear Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgvFaculty.Rows.Clear()
        CheckedListBox1.Items.Clear()
        CheckedListBox2.Items.Clear()
        cmbSubjects.Items.Clear()
        TextBoxSubject.Text = ""
        TextBoxTeacher.Text = ""
    End Sub

    'Remove Button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dgvFaculty.SelectedRows.Count > 0 Then

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove the selected row?",
                                                     "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                For Each row As DataGridViewRow In dgvFaculty.SelectedRows
                    If Not row.IsNewRow Then
                        dgvFaculty.Rows.Remove(row)
                    End If
                Next

                MsgBox("Record removed successfully.")
            End If
        Else
            MsgBox("Please select a full row in the DataGrid to remove.")
        End If
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
