Public Class Form18
    Public GameSpeed As Integer
    Dim score As Integer = 0
    Dim rand As New Random()

    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        player.Top = Me.ClientSize.Height - 410

        meteor.Top = -50
        meteor2.Top = -200

        player.Visible = True
        meteor.BringToFront()
        meteor2.BringToFront()
        lblscore.BringToFront()

    End Sub

    Private Sub Form18_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        player.Left = e.X - (player.Width / 2)
    End Sub

    Private Sub Fom18Timer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        meteor.Top += GameSpeed + 5
        meteor2.Top += GameSpeed + 5
        meteor3.Top += GameSpeed + 10
        blackhole.Top += GameSpeed + 14

        Dim playerHitbox As New Rectangle(player.Left + 15, player.Top + 15, player.Width - 30, player.Height - 30)
        Dim meteor1Hitbox As New Rectangle(meteor.Left + 10, meteor.Top + 10, meteor.Width - 20, meteor.Height - 20)
        Dim meteor2Hitbox As New Rectangle(meteor2.Left + 10, meteor2.Top + 10, meteor2.Width - 20, meteor2.Height - 20)

        If playerHitbox.IntersectsWith(meteor1Hitbox) Or playerHitbox.IntersectsWith(meteor2Hitbox) Then
            gameTimer.Stop()
            MessageBox.Show("Boom! Game Over. Score: " & score)
            Form17.Show()
            Me.Close()
        End If

        If meteor.Top > Me.ClientSize.Height Then
            ResetMeteor(meteor, -100)
        End If

        If meteor2.Top > Me.ClientSize.Height Then
            ResetMeteor(meteor2, -400)
        End If

        If meteor3.Top > Me.ClientSize.Height Then
            ResetMeteor(meteor3, -700)
        End If

        If blackhole.Top > Me.ClientSize.Height Then
            ResetMeteor(blackhole, -1000)
        End If

        If GameSpeed = 29 Then
            If meteor.Top > Me.ClientSize.Height / 2 Then
                meteor.Top += 5
            End If
        End If

        If GameSpeed >= 40 Then
            If Math.Abs(player.Top - meteor.Top) < 100 Then
                Me.Left += rand.Next(-11, 12)
                Me.Top += rand.Next(-8, 9)
            Else
            End If
        End If

        If player.Bounds.IntersectsWith(meteor.Bounds) Or
       player.Bounds.IntersectsWith(meteor2.Bounds) Or
       player.Bounds.IntersectsWith(meteor3.Bounds) Or
       player.Bounds.IntersectsWith(blackhole.Bounds) Then

            gameTimer.Stop()
            MessageBox.Show("Game Over! Score: " & score)
            Form17.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ResetMeteor(m As PictureBox, startTop As Integer)
        score += 1
        lblscore.Text = "Score: " & score
        m.Top = startTop
        m.Left = rand.Next(0, Me.ClientSize.Width - m.Width)
    End Sub

    Private Sub blackhole_Click(sender As Object, e As EventArgs) Handles blackhole.Click

    End Sub
End Class