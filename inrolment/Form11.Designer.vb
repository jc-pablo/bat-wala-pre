<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form11))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.txtAmountTendered = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.btnResip = New System.Windows.Forms.Button()
        Me.btnClearFile = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.flpRegular = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpPE = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpBooks = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala Text", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 45)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Regular Uniform"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Nirmala Text", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(14, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 45)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PE Uniform"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(3, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(289, 184)
        Me.ListBox1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(88, 16)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(74, 25)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.Text = "₱ 0.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(25, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Cash:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(25, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Change:"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.BackColor = System.Drawing.Color.Transparent
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.White
        Me.lblChange.Location = New System.Drawing.Point(113, 152)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(74, 25)
        Me.lblChange.TabIndex = 17
        Me.lblChange.Text = "₱ 0.00"
        '
        'txtAmountTendered
        '
        Me.txtAmountTendered.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountTendered.Location = New System.Drawing.Point(108, 85)
        Me.txtAmountTendered.Name = "txtAmountTendered"
        Me.txtAmountTendered.Size = New System.Drawing.Size(88, 29)
        Me.txtAmountTendered.TabIndex = 18
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.Silver
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.Color.White
        Me.btnCompute.Location = New System.Drawing.Point(220, 18)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(95, 37)
        Me.btnCompute.TabIndex = 19
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.Silver
        Me.btnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.White
        Me.btnPay.Location = New System.Drawing.Point(220, 85)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(90, 32)
        Me.btnPay.TabIndex = 20
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.flpPE)
        Me.Panel1.Controls.Add(Me.flpRegular)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1049, 212)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 520)
        Me.Panel1.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnPay)
        Me.Panel2.Controls.Add(Me.btnCompute)
        Me.Panel2.Controls.Add(Me.txtAmountTendered)
        Me.Panel2.Controls.Add(Me.lblChange)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(1443, 798)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(324, 191)
        Me.Panel2.TabIndex = 22
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.ListBox1)
        Me.Panel3.Location = New System.Drawing.Point(1071, 801)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(307, 188)
        Me.Panel3.TabIndex = 23
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(94, 66)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(100, 25)
        Me.LinkLabel1.TabIndex = 24
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "About Us"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel2.Location = New System.Drawing.Point(323, 66)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(63, 25)
        Me.LinkLabel2.TabIndex = 25
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Store"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.LinkColor = System.Drawing.Color.White
        Me.LinkLabel3.Location = New System.Drawing.Point(504, 66)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(112, 25)
        Me.LinkLabel3.TabIndex = 26
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "View Fees"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.LinkColor = System.Drawing.Color.White
        Me.LinkLabel4.Location = New System.Drawing.Point(731, 66)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(179, 25)
        Me.LinkLabel4.TabIndex = 27
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Enroll && Activities"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Nirmala Text", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(1556, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 45)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Books"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gold
        Me.Label9.Location = New System.Drawing.Point(69, 464)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(199, 29)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "No. of Quantity: "
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(289, 464)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(68, 31)
        Me.txtQty.TabIndex = 29
        Me.txtQty.Text = "1"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Silver
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(184, 390)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(123, 39)
        Me.btnRemove.TabIndex = 30
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Silver
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(344, 390)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(123, 39)
        Me.btnClear.TabIndex = 31
        Me.btnClear.Text = "Clear All"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Silver
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(26, 390)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(123, 39)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add To Cart"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.flpBooks)
        Me.Panel4.Controls.Add(Me.btnClear)
        Me.Panel4.Controls.Add(Me.btnRemove)
        Me.Panel4.Controls.Add(Me.txtQty)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.btnAdd)
        Me.Panel4.Location = New System.Drawing.Point(1323, 223)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(484, 521)
        Me.Panel4.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.LinkLabel5)
        Me.Panel5.Controls.Add(Me.LinkLabel4)
        Me.Panel5.Controls.Add(Me.LinkLabel3)
        Me.Panel5.Controls.Add(Me.LinkLabel2)
        Me.Panel5.Controls.Add(Me.LinkLabel1)
        Me.Panel5.Location = New System.Drawing.Point(675, 21)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1188, 155)
        Me.Panel5.TabIndex = 28
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel5.LinkColor = System.Drawing.Color.White
        Me.LinkLabel5.Location = New System.Drawing.Point(999, 66)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(78, 25)
        Me.LinkLabel5.TabIndex = 28
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Library"
        '
        'btnResip
        '
        Me.btnResip.BackColor = System.Drawing.Color.Silver
        Me.btnResip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResip.ForeColor = System.Drawing.Color.White
        Me.btnResip.Location = New System.Drawing.Point(1660, 1010)
        Me.btnResip.Name = "btnResip"
        Me.btnResip.Size = New System.Drawing.Size(123, 39)
        Me.btnResip.TabIndex = 32
        Me.btnResip.Text = "RECEIPT"
        Me.btnResip.UseVisualStyleBackColor = False
        '
        'btnClearFile
        '
        Me.btnClearFile.BackColor = System.Drawing.Color.Silver
        Me.btnClearFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFile.ForeColor = System.Drawing.Color.White
        Me.btnClearFile.Location = New System.Drawing.Point(1789, 1010)
        Me.btnClearFile.Name = "btnClearFile"
        Me.btnClearFile.Size = New System.Drawing.Size(123, 39)
        Me.btnClearFile.TabIndex = 33
        Me.btnClearFile.Text = "CLEARFILE"
        Me.btnClearFile.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1551, 1010)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 37)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "ADMIN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'flpRegular
        '
        Me.flpRegular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flpRegular.Location = New System.Drawing.Point(8, 46)
        Me.flpRegular.Name = "flpRegular"
        Me.flpRegular.Size = New System.Drawing.Size(255, 210)
        Me.flpRegular.TabIndex = 6
        '
        'flpPE
        '
        Me.flpPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flpPE.Location = New System.Drawing.Point(11, 304)
        Me.flpPE.Name = "flpPE"
        Me.flpPE.Size = New System.Drawing.Size(252, 210)
        Me.flpPE.TabIndex = 7
        '
        'flpBooks
        '
        Me.flpBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flpBooks.Location = New System.Drawing.Point(134, 40)
        Me.flpBooks.Name = "flpBooks"
        Me.flpBooks.Size = New System.Drawing.Size(326, 344)
        Me.flpBooks.TabIndex = 7
        '
        'Form11
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1061)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnClearFile)
        Me.Controls.Add(Me.btnResip)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form11"
        Me.Text = "₱ 0.00"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents txtAmountTendered As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents btnResip As Button
    Friend WithEvents btnClearFile As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents flpPE As FlowLayoutPanel
    Friend WithEvents flpRegular As FlowLayoutPanel
    Friend WithEvents flpBooks As FlowLayoutPanel
End Class
