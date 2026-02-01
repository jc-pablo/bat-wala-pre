<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form21
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form21))
        Me.player1 = New System.Windows.Forms.PictureBox()
        Me.player2 = New System.Windows.Forms.PictureBox()
        Me.bala2 = New System.Windows.Forms.PictureBox()
        Me.bala1 = New System.Windows.Forms.PictureBox()
        Me.Treasure = New System.Windows.Forms.PictureBox()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.blachol3 = New System.Windows.Forms.PictureBox()
        CType(Me.player1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bala2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bala1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Treasure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blachol3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'player1
        '
        Me.player1.BackColor = System.Drawing.Color.Transparent
        Me.player1.BackgroundImage = CType(resources.GetObject("player1.BackgroundImage"), System.Drawing.Image)
        Me.player1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.player1.Location = New System.Drawing.Point(138, 763)
        Me.player1.Name = "player1"
        Me.player1.Size = New System.Drawing.Size(168, 189)
        Me.player1.TabIndex = 0
        Me.player1.TabStop = False
        '
        'player2
        '
        Me.player2.BackColor = System.Drawing.Color.Transparent
        Me.player2.BackgroundImage = CType(resources.GetObject("player2.BackgroundImage"), System.Drawing.Image)
        Me.player2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.player2.Location = New System.Drawing.Point(1547, 779)
        Me.player2.Name = "player2"
        Me.player2.Size = New System.Drawing.Size(169, 158)
        Me.player2.TabIndex = 1
        Me.player2.TabStop = False
        '
        'bala2
        '
        Me.bala2.BackColor = System.Drawing.Color.Transparent
        Me.bala2.BackgroundImage = CType(resources.GetObject("bala2.BackgroundImage"), System.Drawing.Image)
        Me.bala2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bala2.Location = New System.Drawing.Point(1489, 822)
        Me.bala2.Name = "bala2"
        Me.bala2.Size = New System.Drawing.Size(52, 58)
        Me.bala2.TabIndex = 2
        Me.bala2.TabStop = False
        Me.bala2.Visible = False
        '
        'bala1
        '
        Me.bala1.BackColor = System.Drawing.Color.Transparent
        Me.bala1.BackgroundImage = CType(resources.GetObject("bala1.BackgroundImage"), System.Drawing.Image)
        Me.bala1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bala1.Location = New System.Drawing.Point(312, 831)
        Me.bala1.Name = "bala1"
        Me.bala1.Size = New System.Drawing.Size(50, 49)
        Me.bala1.TabIndex = 3
        Me.bala1.TabStop = False
        Me.bala1.Visible = False
        '
        'Treasure
        '
        Me.Treasure.BackColor = System.Drawing.Color.Transparent
        Me.Treasure.BackgroundImage = CType(resources.GetObject("Treasure.BackgroundImage"), System.Drawing.Image)
        Me.Treasure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Treasure.Location = New System.Drawing.Point(842, 561)
        Me.Treasure.Name = "Treasure"
        Me.Treasure.Size = New System.Drawing.Size(298, 258)
        Me.Treasure.TabIndex = 4
        Me.Treasure.TabStop = False
        Me.Treasure.Visible = False
        '
        'gameTimer
        '
        Me.gameTimer.Enabled = True
        Me.gameTimer.Interval = 20
        '
        'blachol3
        '
        Me.blachol3.BackColor = System.Drawing.Color.Transparent
        Me.blachol3.BackgroundImage = CType(resources.GetObject("blachol3.BackgroundImage"), System.Drawing.Image)
        Me.blachol3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.blachol3.Location = New System.Drawing.Point(417, 148)
        Me.blachol3.Name = "blachol3"
        Me.blachol3.Size = New System.Drawing.Size(485, 239)
        Me.blachol3.TabIndex = 5
        Me.blachol3.TabStop = False
        Me.blachol3.Visible = False
        '
        'Form21
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1061)
        Me.Controls.Add(Me.blachol3)
        Me.Controls.Add(Me.Treasure)
        Me.Controls.Add(Me.bala1)
        Me.Controls.Add(Me.bala2)
        Me.Controls.Add(Me.player2)
        Me.Controls.Add(Me.player1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "Form21"
        Me.Text = "Form21"
        CType(Me.player1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bala2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bala1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Treasure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blachol3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents player1 As PictureBox
    Friend WithEvents player2 As PictureBox
    Friend WithEvents bala2 As PictureBox
    Friend WithEvents bala1 As PictureBox
    Friend WithEvents Treasure As PictureBox
    Friend WithEvents gameTimer As Timer
    Friend WithEvents blachol3 As PictureBox
End Class
