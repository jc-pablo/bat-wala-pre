Public Class Form21

    Dim p1Up, p1Down, p1Left, p1Right As Boolean
    Dim p2Up, p2Down, p2Left, p2Right As Boolean

    Dim playerSpeed As Integer = 8
    Dim bulletSpeed As Integer = 15
    Dim rand As New Random()

    Dim blachol3SpeedX As Integer = 5
    Dim blachol3SpeedY As Integer = 5
    Dim blachol3SpawnTimer As Integer = 0

    Dim originalFormLocation As Point
    Dim isInitialLocationSaved As Boolean = False

    Dim gameStartTime As Integer = 0
    Dim blackHoleAllowed As Boolean = False
    Dim originalBHSize As New Size(50, 50)

    Dim shakeTime As Integer = 0

    Private Sub Form21_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        originalBHSize = blachol3.Size
    End Sub

    Private Sub Form21_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.W Then p1Up = True
        If e.KeyCode = Keys.S Then p1Down = True
        If e.KeyCode = Keys.A Then p1Left = True
        If e.KeyCode = Keys.D Then p1Right = True
        If e.KeyCode = Keys.Space Then Shoot(bala1, player1, "P1")

        If e.KeyCode = Keys.Up Then p2Up = True
        If e.KeyCode = Keys.Down Then p2Down = True
        If e.KeyCode = Keys.Left Then p2Left = True
        If e.KeyCode = Keys.Right Then p2Right = True
        If e.KeyCode = Keys.Enter Then Shoot(bala2, player2, "P2")
    End Sub

    Private Sub Form21_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.W Then p1Up = False
        If e.KeyCode = Keys.S Then p1Down = False
        If e.KeyCode = Keys.A Then p1Left = False
        If e.KeyCode = Keys.D Then p1Right = False

        If e.KeyCode = Keys.Up Then p2Up = False
        If e.KeyCode = Keys.Down Then p2Down = False
        If e.KeyCode = Keys.Left Then p2Left = False
        If e.KeyCode = Keys.Right Then p2Right = False
    End Sub

    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick

        If p1Up And player1.Top > 0 Then player1.Top -= playerSpeed
        If p1Down And player1.Top < Me.ClientSize.Height - player1.Height Then player1.Top += playerSpeed
        If p1Left And player1.Left > 0 Then player1.Left -= playerSpeed
        If p1Right And player1.Left < Me.ClientSize.Width - player1.Width Then player1.Left += playerSpeed

        If p2Up And player2.Top > 0 Then player2.Top -= playerSpeed
        If p2Down And player2.Top < Me.ClientSize.Height - player2.Height Then player2.Top += playerSpeed
        If p2Left And player2.Left > 0 Then player2.Left -= playerSpeed
        If p2Right And player2.Left < Me.ClientSize.Width - player2.Width Then player2.Left += playerSpeed

        If bala1.Visible Then bala1.Left += bulletSpeed
        If bala2.Visible Then bala2.Left -= bulletSpeed
        If bala1.Left > Me.Width Then bala1.Visible = False
        If bala2.Left < 0 Then bala2.Visible = False

        If blachol3.Visible Then
            blachol3.Left += blachol3SpeedX
            blachol3.Top += blachol3SpeedY

            If blachol3.Left < 0 Or blachol3.Right > Me.ClientSize.Width Then blachol3SpeedX *= -1
            If blachol3.Top < 0 Or blachol3.Bottom > Me.ClientSize.Height Then blachol3SpeedY *= -1

            If Not isInitialLocationSaved Then
                originalFormLocation = Me.Location
                isInitialLocationSaved = True
            End If
            Me.Left = originalFormLocation.X + rand.Next(-3, 4)
            Me.Top = originalFormLocation.Y + rand.Next(-3, 4)

            If player1.Visible Then
                If player1.Left < blachol3.Left Then player1.Left += 2 Else player1.Left -= 2
                If player1.Top < blachol3.Top Then player1.Top += 2 Else player1.Top -= 2
            End If
            If player2.Visible Then
                If player2.Left < blachol3.Left Then player2.Left += 2 Else player2.Left -= 2
                If player2.Top < blachol3.Top Then player2.Top += 2 Else player2.Top -= 2
            End If

            If player1.Bounds.IntersectsWith(blachol3.Bounds) And player1.Visible Then
                player1.Visible = False
                EndGame("PLAYER 1 WAS CONSUMED!")
            End If
            If player2.Bounds.IntersectsWith(blachol3.Bounds) And player2.Visible Then
                player2.Visible = False
                EndGame("PLAYER 2 WAS CONSUMED!")
            End If
        Else
            If isInitialLocationSaved Then
                Me.Location = originalFormLocation
                isInitialLocationSaved = False
            End If
        End If

        If blackHoleAllowed = False Then
            gameStartTime += 1
            If gameStartTime > 800 Then
                blackHoleAllowed = True
                blachol3SpawnTimer = 0
            End If
        End If

        If blackHoleAllowed Then
            blachol3SpawnTimer += 1
            If blachol3SpawnTimer > 30 And Not blachol3.Visible Then
                blachol3.Size = originalBHSize
                blachol3.Location = New Point(rand.Next(50, Me.ClientSize.Width - 100), rand.Next(50, Me.ClientSize.Height - 100))
                blachol3.Visible = True
            ElseIf blachol3SpawnTimer > 150 Then
                blachol3.Visible = False
                blachol3SpawnTimer = 0
            End If
        End If

        If bala1.Bounds.IntersectsWith(player2.Bounds) And bala1.Visible And player2.Visible Then
            player2.Visible = False : bala1.Visible = False : SpawnTreasure(player2.Location)
        End If
        If bala2.Bounds.IntersectsWith(player1.Bounds) And bala2.Visible And player1.Visible Then
            player1.Visible = False : bala2.Visible = False : SpawnTreasure(player1.Location)
        End If

        If Treasure.Visible Then
            If player1.Bounds.IntersectsWith(Treasure.Bounds) And player1.Visible Then EndGame("PLAYER 1 WON THE TREASURE!")
            If player2.Bounds.IntersectsWith(Treasure.Bounds) And player2.Visible Then EndGame("PLAYER 2 WON THE TREASURE")
        End If
    End Sub

    Private Sub Shoot(b As PictureBox, p As PictureBox, tag As String)
        If b.Visible = False Then
            b.Location = New Point(p.Left + (p.Width / 2), p.Top + (p.Height / 2))
            b.Visible = True
        End If
    End Sub

    Private Sub SpawnTreasure(loc As Point)
        Treasure.Location = loc
        Treasure.Visible = True
        Treasure.BringToFront()
    End Sub

    Private Sub EndGame(msg As String)
        gameTimer.Stop()
        MessageBox.Show(msg)

        Form20.Show()
        Me.Close()
    End Sub

    Private Sub StartShake(duration As Integer)
        shakeTime = duration
        originalFormLocation = Me.Location
    End Sub
End Class