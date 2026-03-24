<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form30
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form30))
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtItemPrice = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.cmbSubCategory = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProducts.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProducts.Location = New System.Drawing.Point(1073, 291)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.Size = New System.Drawing.Size(721, 651)
        Me.dgvProducts.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(772, 866)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(149, 56)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.BackgroundImage = CType(resources.GetObject("btnView.BackgroundImage"), System.Drawing.Image)
        Me.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(770, 543)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(149, 56)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "VIEW"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.BackgroundImage = CType(resources.GetObject("btnRemove.BackgroundImage"), System.Drawing.Image)
        Me.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(770, 928)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(149, 57)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "REMOVE"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.SystemColors.Menu
        Me.txtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Location = New System.Drawing.Point(745, 646)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(174, 31)
        Me.txtItemName.TabIndex = 4
        '
        'txtItemPrice
        '
        Me.txtItemPrice.BackColor = System.Drawing.SystemColors.Menu
        Me.txtItemPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemPrice.Location = New System.Drawing.Point(747, 736)
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.Size = New System.Drawing.Size(174, 31)
        Me.txtItemPrice.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(770, 463)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 62)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "STORE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(732, 614)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Item Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(732, 704)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Item Price:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.LinkLabel5)
        Me.Panel5.Controls.Add(Me.LinkLabel4)
        Me.Panel5.Controls.Add(Me.LinkLabel3)
        Me.Panel5.Controls.Add(Me.LinkLabel2)
        Me.Panel5.Controls.Add(Me.LinkLabel1)
        Me.Panel5.Location = New System.Drawing.Point(671, 26)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1188, 155)
        Me.Panel5.TabIndex = 39
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel5.LinkColor = System.Drawing.Color.White
        Me.LinkLabel5.Location = New System.Drawing.Point(940, 66)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(78, 25)
        Me.LinkLabel5.TabIndex = 39
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Library"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.LinkColor = System.Drawing.Color.White
        Me.LinkLabel4.Location = New System.Drawing.Point(707, 66)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(115, 25)
        Me.LinkLabel4.TabIndex = 27
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Enroll Now"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.LinkColor = System.Drawing.Color.White
        Me.LinkLabel3.Location = New System.Drawing.Point(484, 66)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(112, 25)
        Me.LinkLabel3.TabIndex = 26
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "View Fees"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel2.Location = New System.Drawing.Point(288, 66)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(63, 25)
        Me.LinkLabel2.TabIndex = 25
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Store"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(77, 66)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(100, 25)
        Me.LinkLabel1.TabIndex = 24
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "About Us"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(1073, 240)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(544, 35)
        Me.txtSearch.TabIndex = 41
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(1643, 232)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(151, 53)
        Me.btnSearch.TabIndex = 40
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.SystemColors.Menu
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Stationery", "Merch", "Uniform", "Books"})
        Me.cmbCategory.Location = New System.Drawing.Point(629, 808)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(153, 32)
        Me.cmbCategory.TabIndex = 42
        '
        'cmbSubCategory
        '
        Me.cmbSubCategory.BackColor = System.Drawing.SystemColors.Menu
        Me.cmbSubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubCategory.FormattingEnabled = True
        Me.cmbSubCategory.Items.AddRange(New Object() {"General", "Shirts", "Hoodies", "Regular", "PE", "Set"})
        Me.cmbSubCategory.Location = New System.Drawing.Point(788, 808)
        Me.cmbSubCategory.Name = "cmbSubCategory"
        Me.cmbSubCategory.Size = New System.Drawing.Size(166, 32)
        Me.cmbSubCategory.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(624, 776)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 29)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Category:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(783, 776)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 29)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "SubCategory:"
        '
        'Form30
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1061)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbSubCategory)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtItemPrice)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvProducts)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form30"
        Me.Text = "Form30"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtItemPrice As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents cmbSubCategory As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
