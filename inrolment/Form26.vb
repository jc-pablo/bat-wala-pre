Public Class Form26
    Dim hours As Integer


    Private Sub Risibo()
        ListBox1.Items.Add("--- Enrollment of Physical Activities Receipt ---")
    End Sub


    Private Sub Bayad(ByVal hrs As Integer, ByVal rate As Integer)
        Dim totalPay As Integer
        totalPay = hrs * rate
        ListBox1.Items.Add("Total Fee: " & totalPay)
        ListBox1.Items.Add("--------------------------")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Risibo()

        If RadioButton1.Checked = True Then
            hours = InputBox("How many hours for Mini Golf?", "Beginner", 2)
            ListBox1.Items.Add("Activity: Mini Golf")
            Bayad(hours, 300)

        ElseIf RadioButton2.Checked = True Then
            hours = InputBox("How many hours for Guided Stretching?", "Beginner", 2)
            ListBox1.Items.Add("Activity: Guided Stretching")
            Bayad(hours, 250)

        ElseIf RadioButton3.Checked = True Then
            hours = InputBox("How many hours for Indoor Rock Climbing", "Beginner", 2)
            ListBox1.Items.Add("Activity: Indoor Rock Climbing")
            Bayad(hours, 450)

        ElseIf RadioButton4.Checked = True Then
            hours = InputBox("How many hours for Dance Training", "Beginner", 2)
            ListBox1.Items.Add("Activity: Dance Training")
            Bayad(hours, 200)

        ElseIf RadioButton5.Checked = True Then
            hours = InputBox("How many hours for Photography", "Beginner", 2)
            ListBox1.Items.Add("Activity: Photography")
            Bayad(hours, 150)

        ElseIf RadioButton6.Checked = True Then
            hours = InputBox("How many hours for Theatre", "Beginner", 2)
            ListBox1.Items.Add("Activity: Theatre")
            Bayad(hours, 350)


        ElseIf RadioButton12.Checked = True Then
            hours = InputBox("How many hours for Basketball?", "Intermediate", 2)
            ListBox1.Items.Add("Activity: Basketball")
            Bayad(hours, 180)

        ElseIf RadioButton11.Checked = True Then
            hours = InputBox("How many hours for Swimming?", "Intermediate", 2)
            ListBox1.Items.Add("Activity: Swimming")
            Bayad(hours, 320)

        ElseIf RadioButton10.Checked = True Then
            hours = InputBox("How many hours for Football?", "Intermediate", 2)
            ListBox1.Items.Add("Activity: Football")
            Bayad(hours, 180)

        ElseIf RadioButton9.Checked = True Then
            hours = InputBox("How many hours for Martial Arts?", "Intermediate", 2)
            ListBox1.Items.Add("Activity: Martial Arts")
            Bayad(hours, 220)

        ElseIf RadioButton8.Checked = True Then
            hours = InputBox("How many hours for Obstacle Course?", "Intermediate", 2)
            ListBox1.Items.Add("Activity: Obstacle Course")
            Bayad(hours, 60)

        ElseIf RadioButton7.Checked = True Then
            hours = InputBox("How many hours for Archery", "Intermediate", 2)
            ListBox1.Items.Add("Activity: Archery")
            Bayad(hours, 330)

        ElseIf RadioButton18.Checked = True Then
            Dim baseAmount As Integer
            baseAmount = InputBox("Enter base registration fee:", "Professional", 1000)
            ListBox1.Items.Add("Activity: Track & Field")
            Bayad(1, ProFee(baseAmount))

        ElseIf RadioButton17.Checked = True Then
            Dim baseAmount As Integer
            baseAmount = InputBox("Enter base registration fee:", "Professional", 1000)
            ListBox1.Items.Add("Activity: Gymnastics")
            Bayad(1, ProFee(baseAmount))

        ElseIf RadioButton16.Checked = True Then
            Dim baseAmount As Integer
            baseAmount = InputBox("Enter base registration fee:", "Professional", 1000)
            ListBox1.Items.Add("Activity: Varsity Basketball")
            Bayad(1, ProFee(baseAmount))

        ElseIf RadioButton15.Checked = True Then
            Dim baseAmount As Integer
            baseAmount = InputBox("Enter base registration fee:", "Professional", 1000)
            ListBox1.Items.Add("Activity: Tournament Golf")
            Bayad(1, ProFee(baseAmount))

        ElseIf RadioButton14.Checked = True Then
            Dim baseAmount As Integer
            baseAmount = InputBox("Enter base registration fee:", "Professional", 1000)
            ListBox1.Items.Add("Activity: Professional Tennis")
            Bayad(1, ProFee(baseAmount))

        ElseIf RadioButton13.Checked = True Then
            Dim baseAmount As Integer
            baseAmount = InputBox("Enter base registration fee:", "Professional", 1000)
            ListBox1.Items.Add("Activity: Scout Camping")
            Bayad(1, ProFee(baseAmount))


        Else
            MsgBox("Please choose an activity first!")
        End If
    End Sub
    Private Function ProFee(ByRef total As Integer) As Integer
        total = total * 2
        Return total
    End Function

    Private Function FinalTotal() As Integer
        Dim allTotal As Integer = 0

        For i As Integer = 0 To ListBox1.Items.Count - 1
            Dim itemText As String = ListBox1.Items(i).ToString()

            If itemText.Contains("Total Fee:") Then
                Dim priceString As String = itemText.Replace("Total Fee: ", "").Trim()
                allTotal += Val(priceString)
            End If
        Next

        Return allTotal
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form27.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.Items.Count = 0 Then
            MsgBox("Your cart is empty!")
            Exit Sub
        End If
        Dim finalAmount As Integer = FinalTotal()


        ListBox1.Items.Add("==========================")
        ListBox1.Items.Add("FINAL TOTAL: " & finalAmount)
        ListBox1.Items.Add("==========================")

        MsgBox("Checkout Successful! Total amount to pay: P" & finalAmount)
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

    Private Sub Form26_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class