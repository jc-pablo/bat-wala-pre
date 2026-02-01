Public Class Form17
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        StartGame(18)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        StartGame(29)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        StartGame(40)
    End Sub

    Private Sub StartGame(difficultySpeed As Integer)
        Dim game As New Form18()
        game.GameSpeed = difficultySpeed
        game.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form16.Show()
        Me.Hide()
    End Sub

    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class