Public Class Form29
Private Sub rtbReceipt_Click(sender As Object, e As EventArgs) Handles Resibo.Click

    End Sub

    Private Sub Form29_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Resibo.Text = l.receiptText
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strPattern As String = ""
        For row As Integer = 1 To 3
            For col As Integer = 1 To 3
                strPattern &= (row * col) & "  "
            Next
            strPattern &= vbCrLf
        Next
        MsgBox(strPattern)

    End Sub
End Class