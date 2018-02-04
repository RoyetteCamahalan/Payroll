<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpenses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExpenses))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelpassword = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dgvmain = New System.Windows.Forms.DataGridView()
        Me.lblshowing = New System.Windows.Forms.Label()
        Me.btnExpenses = New System.Windows.Forms.Button()
        Me.btnExpensesTypes = New System.Windows.Forms.Button()
        Me.panelexpensetype = New System.Windows.Forms.Panel()
        Me.panelexpenses = New System.Windows.Forms.Panel()
        Me.panelvendors = New System.Windows.Forms.Panel()
        Me.btnVendors = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAccounts = New System.Windows.Forms.Button()
        Me.panelaccounts = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtpendingdate = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpinitialdate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelfname = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelperiod = New System.Windows.Forms.Panel()
        Me.cmbPeriod = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelpassword.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvmain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panelperiod.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelpassword
        '
        Me.panelpassword.BackColor = System.Drawing.Color.White
        Me.panelpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelpassword.Controls.Add(Me.txtSearch)
        Me.panelpassword.Controls.Add(Me.PictureBox2)
        Me.panelpassword.Location = New System.Drawing.Point(806, 71)
        Me.panelpassword.Name = "panelpassword"
        Me.panelpassword.Size = New System.Drawing.Size(274, 36)
        Me.panelpassword.TabIndex = 9
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(3, 8)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(235, 19)
        Me.txtSearch.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(241, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(742, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 18)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Search :"
        '
        'dgvmain
        '
        Me.dgvmain.AllowUserToAddRows = False
        Me.dgvmain.AllowUserToDeleteRows = False
        Me.dgvmain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvmain.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvmain.Location = New System.Drawing.Point(37, 128)
        Me.dgvmain.Name = "dgvmain"
        Me.dgvmain.ReadOnly = True
        Me.dgvmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvmain.Size = New System.Drawing.Size(1041, 387)
        Me.dgvmain.TabIndex = 35
        '
        'lblshowing
        '
        Me.lblshowing.AutoSize = True
        Me.lblshowing.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblshowing.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblshowing.Location = New System.Drawing.Point(34, 518)
        Me.lblshowing.Name = "lblshowing"
        Me.lblshowing.Size = New System.Drawing.Size(146, 16)
        Me.lblshowing.TabIndex = 36
        Me.lblshowing.Text = "Showing top 100 rows"
        '
        'btnExpenses
        '
        Me.btnExpenses.BackColor = System.Drawing.Color.White
        Me.btnExpenses.FlatAppearance.BorderSize = 0
        Me.btnExpenses.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnExpenses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnExpenses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpenses.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnExpenses.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnExpenses.Location = New System.Drawing.Point(37, 12)
        Me.btnExpenses.Name = "btnExpenses"
        Me.btnExpenses.Size = New System.Drawing.Size(124, 31)
        Me.btnExpenses.TabIndex = 38
        Me.btnExpenses.Text = "Expenses"
        Me.btnExpenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExpenses.UseVisualStyleBackColor = False
        '
        'btnExpensesTypes
        '
        Me.btnExpensesTypes.BackColor = System.Drawing.Color.White
        Me.btnExpensesTypes.FlatAppearance.BorderSize = 0
        Me.btnExpensesTypes.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnExpensesTypes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnExpensesTypes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnExpensesTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpensesTypes.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnExpensesTypes.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnExpensesTypes.Location = New System.Drawing.Point(310, 12)
        Me.btnExpensesTypes.Name = "btnExpensesTypes"
        Me.btnExpensesTypes.Size = New System.Drawing.Size(124, 31)
        Me.btnExpensesTypes.TabIndex = 39
        Me.btnExpensesTypes.Text = "Expense Types"
        Me.btnExpensesTypes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExpensesTypes.UseVisualStyleBackColor = False
        '
        'panelexpensetype
        '
        Me.panelexpensetype.BackColor = System.Drawing.Color.SteelBlue
        Me.panelexpensetype.Location = New System.Drawing.Point(304, 6)
        Me.panelexpensetype.Name = "panelexpensetype"
        Me.panelexpensetype.Size = New System.Drawing.Size(134, 4)
        Me.panelexpensetype.TabIndex = 40
        Me.panelexpensetype.Visible = False
        '
        'panelexpenses
        '
        Me.panelexpenses.BackColor = System.Drawing.Color.SteelBlue
        Me.panelexpenses.Location = New System.Drawing.Point(32, 6)
        Me.panelexpenses.Name = "panelexpenses"
        Me.panelexpenses.Size = New System.Drawing.Size(134, 4)
        Me.panelexpenses.TabIndex = 41
        Me.panelexpenses.Visible = False
        '
        'panelvendors
        '
        Me.panelvendors.BackColor = System.Drawing.Color.SteelBlue
        Me.panelvendors.Location = New System.Drawing.Point(440, 6)
        Me.panelvendors.Name = "panelvendors"
        Me.panelvendors.Size = New System.Drawing.Size(134, 4)
        Me.panelvendors.TabIndex = 45
        Me.panelvendors.Visible = False
        '
        'btnVendors
        '
        Me.btnVendors.BackColor = System.Drawing.Color.White
        Me.btnVendors.FlatAppearance.BorderSize = 0
        Me.btnVendors.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnVendors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnVendors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnVendors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVendors.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnVendors.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnVendors.Location = New System.Drawing.Point(440, 12)
        Me.btnVendors.Name = "btnVendors"
        Me.btnVendors.Size = New System.Drawing.Size(124, 31)
        Me.btnVendors.TabIndex = 44
        Me.btnVendors.Text = "Vendors"
        Me.btnVendors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVendors.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Peru
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Image)
        Me.btnView.Location = New System.Drawing.Point(881, 12)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(97, 41)
        Me.btnView.TabIndex = 37
        Me.btnView.Text = " View"
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(675, 12)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(97, 41)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = " Add New"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(778, 12)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(97, 41)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "  Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAccounts
        '
        Me.btnAccounts.BackColor = System.Drawing.Color.White
        Me.btnAccounts.FlatAppearance.BorderSize = 0
        Me.btnAccounts.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnAccounts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnAccounts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccounts.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAccounts.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAccounts.Location = New System.Drawing.Point(168, 12)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(124, 31)
        Me.btnAccounts.TabIndex = 46
        Me.btnAccounts.Text = "Accounts"
        Me.btnAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccounts.UseVisualStyleBackColor = False
        '
        'panelaccounts
        '
        Me.panelaccounts.BackColor = System.Drawing.Color.SteelBlue
        Me.panelaccounts.Location = New System.Drawing.Point(168, 6)
        Me.panelaccounts.Name = "panelaccounts"
        Me.panelaccounts.Size = New System.Drawing.Size(134, 4)
        Me.panelaccounts.TabIndex = 47
        Me.panelaccounts.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Peru
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(983, 12)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(97, 41)
        Me.btnPrint.TabIndex = 189
        Me.btnPrint.Text = "  Print"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(247, 10)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(103, 17)
        Me.Label19.TabIndex = 192
        Me.Label19.Text = "Custom Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(247, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 193
        Me.Label2.Text = "Custom Date :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.dtpendingdate)
        Me.Panel3.Location = New System.Drawing.Point(489, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(113, 27)
        Me.Panel3.TabIndex = 200
        '
        'dtpendingdate
        '
        Me.dtpendingdate.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpendingdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpendingdate.Location = New System.Drawing.Point(-1, 0)
        Me.dtpendingdate.Name = "dtpendingdate"
        Me.dtpendingdate.Size = New System.Drawing.Size(113, 25)
        Me.dtpendingdate.TabIndex = 176
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(4, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 17)
        Me.Label18.TabIndex = 191
        Me.Label18.Text = "Period :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.dtpinitialdate)
        Me.Panel2.Location = New System.Drawing.Point(350, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(113, 27)
        Me.Panel2.TabIndex = 199
        '
        'dtpinitialdate
        '
        Me.dtpinitialdate.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpinitialdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpinitialdate.Location = New System.Drawing.Point(-1, 0)
        Me.dtpinitialdate.Name = "dtpinitialdate"
        Me.dtpinitialdate.Size = New System.Drawing.Size(113, 25)
        Me.dtpinitialdate.TabIndex = 175
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 190
        Me.Label1.Text = "Period :"
        '
        'panelfname
        '
        Me.panelfname.BackColor = System.Drawing.Color.White
        Me.panelfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelfname.Location = New System.Drawing.Point(63, 3)
        Me.panelfname.Name = "panelfname"
        Me.panelfname.Size = New System.Drawing.Size(175, 27)
        Me.panelfname.TabIndex = 196
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(467, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(23, 17)
        Me.Label16.TabIndex = 195
        Me.Label16.Text = "To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(467, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 17)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "To"
        '
        'panelperiod
        '
        Me.panelperiod.Controls.Add(Me.Panel1)
        Me.panelperiod.Controls.Add(Me.Label19)
        Me.panelperiod.Controls.Add(Me.Label2)
        Me.panelperiod.Controls.Add(Me.panelfname)
        Me.panelperiod.Controls.Add(Me.Panel3)
        Me.panelperiod.Controls.Add(Me.Label1)
        Me.panelperiod.Controls.Add(Me.Panel2)
        Me.panelperiod.Controls.Add(Me.Label18)
        Me.panelperiod.Controls.Add(Me.Label3)
        Me.panelperiod.Controls.Add(Me.Label16)
        Me.panelperiod.Location = New System.Drawing.Point(35, 93)
        Me.panelperiod.Name = "panelperiod"
        Me.panelperiod.Size = New System.Drawing.Size(605, 37)
        Me.panelperiod.TabIndex = 202
        '
        'cmbPeriod
        '
        Me.cmbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPeriod.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.cmbPeriod.FormattingEnabled = True
        Me.cmbPeriod.Items.AddRange(New Object() {"Today", "This Week-To-Date", "This Month-To-Date", "This Quarter-To-Date", "This Year-to-Date", "Custom Date"})
        Me.cmbPeriod.Location = New System.Drawing.Point(-1, 0)
        Me.cmbPeriod.Name = "cmbPeriod"
        Me.cmbPeriod.Size = New System.Drawing.Size(175, 25)
        Me.cmbPeriod.TabIndex = 174
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmbPeriod)
        Me.Panel1.Location = New System.Drawing.Point(63, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(175, 27)
        Me.Panel1.TabIndex = 197
        '
        'frmExpenses
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1114, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnAccounts)
        Me.Controls.Add(Me.panelaccounts)
        Me.Controls.Add(Me.btnVendors)
        Me.Controls.Add(Me.panelvendors)
        Me.Controls.Add(Me.panelexpenses)
        Me.Controls.Add(Me.btnExpensesTypes)
        Me.Controls.Add(Me.btnExpenses)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.lblshowing)
        Me.Controls.Add(Me.dgvmain)
        Me.Controls.Add(Me.panelpassword)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.panelexpensetype)
        Me.Controls.Add(Me.panelperiod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmExpenses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmReservations"
        Me.panelpassword.ResumeLayout(False)
        Me.panelpassword.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvmain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.panelperiod.ResumeLayout(False)
        Me.panelperiod.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents panelpassword As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dgvmain As System.Windows.Forms.DataGridView
    Friend WithEvents lblshowing As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnExpenses As System.Windows.Forms.Button
    Friend WithEvents btnExpensesTypes As System.Windows.Forms.Button
    Friend WithEvents panelexpensetype As System.Windows.Forms.Panel
    Friend WithEvents panelexpenses As System.Windows.Forms.Panel
    Friend WithEvents panelvendors As System.Windows.Forms.Panel
    Friend WithEvents btnVendors As System.Windows.Forms.Button
    Friend WithEvents btnAccounts As System.Windows.Forms.Button
    Friend WithEvents panelaccounts As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dtpendingdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtpinitialdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panelfname As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panelperiod As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbPeriod As System.Windows.Forms.ComboBox
End Class
