<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form29
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form29))
        Me.Resibo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Resibo
        '
        Me.Resibo.BackColor = System.Drawing.Color.Transparent
        Me.Resibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resibo.Location = New System.Drawing.Point(12, 230)
        Me.Resibo.Name = "Resibo"
        Me.Resibo.Size = New System.Drawing.Size(556, 512)
        Me.Resibo.TabIndex = 0
        Me.Resibo.Text = "Resibo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(75, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form29
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(593, 897)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Resibo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form29"
        Me.Text = "Form29"
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents Resibo As Label
    Friend WithEvents Button1 As Button
End Class
