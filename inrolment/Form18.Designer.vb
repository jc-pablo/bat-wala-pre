<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form18
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form18))
        Me.player = New System.Windows.Forms.PictureBox()
        Me.meteor = New System.Windows.Forms.PictureBox()
        Me.lblscore = New System.Windows.Forms.Label()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.meteor2 = New System.Windows.Forms.PictureBox()
        Me.meteor3 = New System.Windows.Forms.PictureBox()
        Me.blackhole = New System.Windows.Forms.PictureBox()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meteor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meteor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meteor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blackhole, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'player
        '
        Me.player.BackColor = System.Drawing.Color.Transparent
        Me.player.BackgroundImage = CType(resources.GetObject("player.BackgroundImage"), System.Drawing.Image)
        Me.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.player.Location = New System.Drawing.Point(895, 625)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(150, 315)
        Me.player.TabIndex = 0
        Me.player.TabStop = False
        '
        'meteor
        '
        Me.meteor.BackColor = System.Drawing.Color.Transparent
        Me.meteor.BackgroundImage = CType(resources.GetObject("meteor.BackgroundImage"), System.Drawing.Image)
        Me.meteor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.meteor.Location = New System.Drawing.Point(1094, -7)
        Me.meteor.Name = "meteor"
        Me.meteor.Size = New System.Drawing.Size(188, 205)
        Me.meteor.TabIndex = 1
        Me.meteor.TabStop = False
        '
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.BackColor = System.Drawing.Color.Transparent
        Me.lblscore.Font = New System.Drawing.Font("Stencil", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore.ForeColor = System.Drawing.Color.Maroon
        Me.lblscore.Location = New System.Drawing.Point(858, 965)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(222, 57)
        Me.lblscore.TabIndex = 2
        Me.lblscore.Text = "Score:0"
        '
        'gameTimer
        '
        Me.gameTimer.Enabled = True
        Me.gameTimer.Interval = 20
        '
        'meteor2
        '
        Me.meteor2.BackColor = System.Drawing.Color.Transparent
        Me.meteor2.BackgroundImage = CType(resources.GetObject("meteor2.BackgroundImage"), System.Drawing.Image)
        Me.meteor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.meteor2.Location = New System.Drawing.Point(884, 58)
        Me.meteor2.Name = "meteor2"
        Me.meteor2.Size = New System.Drawing.Size(196, 202)
        Me.meteor2.TabIndex = 3
        Me.meteor2.TabStop = False
        '
        'meteor3
        '
        Me.meteor3.BackColor = System.Drawing.Color.Transparent
        Me.meteor3.BackgroundImage = CType(resources.GetObject("meteor3.BackgroundImage"), System.Drawing.Image)
        Me.meteor3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.meteor3.Location = New System.Drawing.Point(1486, -7)
        Me.meteor3.Name = "meteor3"
        Me.meteor3.Size = New System.Drawing.Size(144, 170)
        Me.meteor3.TabIndex = 4
        Me.meteor3.TabStop = False
        '
        'blackhole
        '
        Me.blackhole.BackColor = System.Drawing.Color.Transparent
        Me.blackhole.BackgroundImage = CType(resources.GetObject("blackhole.BackgroundImage"), System.Drawing.Image)
        Me.blackhole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.blackhole.Location = New System.Drawing.Point(242, -15)
        Me.blackhole.Name = "blackhole"
        Me.blackhole.Size = New System.Drawing.Size(343, 275)
        Me.blackhole.TabIndex = 5
        Me.blackhole.TabStop = False
        '
        'Form18
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1061)
        Me.Controls.Add(Me.blackhole)
        Me.Controls.Add(Me.meteor3)
        Me.Controls.Add(Me.meteor2)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.meteor)
        Me.Controls.Add(Me.player)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form18"
        Me.Text = "Form18"
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meteor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meteor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meteor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blackhole, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents player As PictureBox
    Friend WithEvents meteor As PictureBox
    Friend WithEvents lblscore As Label
    Friend WithEvents gameTimer As Timer
    Friend WithEvents meteor2 As PictureBox
    Friend WithEvents meteor3 As PictureBox
    Friend WithEvents blackhole As PictureBox
End Class
