<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayments))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelpassword = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dgvmain = New System.Windows.Forms.DataGridView()
        Me.lblshowing = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnPayments = New System.Windows.Forms.Button()
        Me.btnBanks = New System.Windows.Forms.Button()
        Me.panelbanks = New System.Windows.Forms.Panel()
        Me.panelpayments = New System.Windows.Forms.Panel()
        Me.panelaccounts = New System.Windows.Forms.Panel()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblcustomdate = New System.Windows.Forms.Label()
        Me.panelto = New System.Windows.Forms.Panel()
        Me.dtpendingdate = New System.Windows.Forms.DateTimePicker()
        Me.panelfrom = New System.Windows.Forms.Panel()
        Me.dtpinitialdate = New System.Windows.Forms.DateTimePicker()
        Me.lblperiod = New System.Windows.Forms.Label()
        Me.panelperiod = New System.Windows.Forms.Panel()
        Me.cmbPeriod = New System.Windows.Forms.ComboBox()
        Me.lblto = New System.Windows.Forms.Label()
        Me.btnLoan = New System.Windows.Forms.Button()
        Me.panelLoans = New System.Windows.Forms.Panel()
        Me.panelpassword.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvmain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelto.SuspendLayout()
        Me.panelfrom.SuspendLayout()
        Me.panelperiod.SuspendLayout()
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvmain.DefaultCellStyle = DataGridViewCellStyle2
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
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Peru
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Image)
        Me.btnView.Location = New System.Drawing.Point(983, 12)
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
        Me.btnNew.Location = New System.Drawing.Point(777, 12)
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
        Me.btnEdit.Location = New System.Drawing.Point(880, 12)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(97, 41)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "  Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnPayments
        '
        Me.btnPayments.BackColor = System.Drawing.Color.White
        Me.btnPayments.FlatAppearance.BorderSize = 0
        Me.btnPayments.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnPayments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayments.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnPayments.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnPayments.Location = New System.Drawing.Point(37, 12)
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.Size = New System.Drawing.Size(104, 31)
        Me.btnPayments.TabIndex = 38
        Me.btnPayments.Text = "Payments"
        Me.btnPayments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPayments.UseVisualStyleBackColor = False
        '
        'btnBanks
        '
        Me.btnBanks.BackColor = System.Drawing.Color.White
        Me.btnBanks.FlatAppearance.BorderSize = 0
        Me.btnBanks.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnBanks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBanks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBanks.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnBanks.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBanks.Location = New System.Drawing.Point(153, 12)
        Me.btnBanks.Name = "btnBanks"
        Me.btnBanks.Size = New System.Drawing.Size(104, 31)
        Me.btnBanks.TabIndex = 39
        Me.btnBanks.Text = "Banks"
        Me.btnBanks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBanks.UseVisualStyleBackColor = False
        '
        'panelbanks
        '
        Me.panelbanks.BackColor = System.Drawing.Color.SteelBlue
        Me.panelbanks.Location = New System.Drawing.Point(148, 6)
        Me.panelbanks.Name = "panelbanks"
        Me.panelbanks.Size = New System.Drawing.Size(114, 4)
        Me.panelbanks.TabIndex = 40
        Me.panelbanks.Visible = False
        '
        'panelpayments
        '
        Me.panelpayments.BackColor = System.Drawing.Color.SteelBlue
        Me.panelpayments.Location = New System.Drawing.Point(32, 6)
        Me.panelpayments.Name = "panelpayments"
        Me.panelpayments.Size = New System.Drawing.Size(114, 4)
        Me.panelpayments.TabIndex = 41
        Me.panelpayments.Visible = False
        '
        'panelaccounts
        '
        Me.panelaccounts.BackColor = System.Drawing.Color.SteelBlue
        Me.panelaccounts.Location = New System.Drawing.Point(264, 6)
        Me.panelaccounts.Name = "panelaccounts"
        Me.panelaccounts.Size = New System.Drawing.Size(114, 4)
        Me.panelaccounts.TabIndex = 45
        Me.panelaccounts.Visible = False
        '
        'btnAccount
        '
        Me.btnAccount.BackColor = System.Drawing.Color.White
        Me.btnAccount.FlatAppearance.BorderSize = 0
        Me.btnAccount.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccount.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAccount.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAccount.Location = New System.Drawing.Point(269, 12)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(104, 31)
        Me.btnAccount.TabIndex = 44
        Me.btnAccount.Text = "Accounts"
        Me.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccount.UseVisualStyleBackColor = False
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
        Me.btnPrint.TabIndex = 190
        Me.btnPrint.Text = "  Print"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'lblcustomdate
        '
        Me.lblcustomdate.AutoSize = True
        Me.lblcustomdate.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblcustomdate.Location = New System.Drawing.Point(278, 102)
        Me.lblcustomdate.Name = "lblcustomdate"
        Me.lblcustomdate.Size = New System.Drawing.Size(103, 17)
        Me.lblcustomdate.TabIndex = 192
        Me.lblcustomdate.Text = "Custom Date :"
        '
        'panelto
        '
        Me.panelto.BackColor = System.Drawing.Color.White
        Me.panelto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelto.Controls.Add(Me.dtpendingdate)
        Me.panelto.Location = New System.Drawing.Point(520, 95)
        Me.panelto.Name = "panelto"
        Me.panelto.Size = New System.Drawing.Size(113, 27)
        Me.panelto.TabIndex = 196
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
        'panelfrom
        '
        Me.panelfrom.BackColor = System.Drawing.Color.White
        Me.panelfrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelfrom.Controls.Add(Me.dtpinitialdate)
        Me.panelfrom.Location = New System.Drawing.Point(381, 95)
        Me.panelfrom.Name = "panelfrom"
        Me.panelfrom.Size = New System.Drawing.Size(113, 27)
        Me.panelfrom.TabIndex = 195
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
        'lblperiod
        '
        Me.lblperiod.AutoSize = True
        Me.lblperiod.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblperiod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblperiod.Location = New System.Drawing.Point(35, 101)
        Me.lblperiod.Name = "lblperiod"
        Me.lblperiod.Size = New System.Drawing.Size(58, 17)
        Me.lblperiod.TabIndex = 191
        Me.lblperiod.Text = "Period :"
        '
        'panelperiod
        '
        Me.panelperiod.BackColor = System.Drawing.Color.White
        Me.panelperiod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelperiod.Controls.Add(Me.cmbPeriod)
        Me.panelperiod.Location = New System.Drawing.Point(94, 95)
        Me.panelperiod.Name = "panelperiod"
        Me.panelperiod.Size = New System.Drawing.Size(175, 27)
        Me.panelperiod.TabIndex = 194
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
        'lblto
        '
        Me.lblto.AutoSize = True
        Me.lblto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblto.Location = New System.Drawing.Point(498, 101)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(23, 17)
        Me.lblto.TabIndex = 193
        Me.lblto.Text = "To"
        '
        'btnLoan
        '
        Me.btnLoan.BackColor = System.Drawing.Color.White
        Me.btnLoan.FlatAppearance.BorderSize = 0
        Me.btnLoan.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnLoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnLoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoan.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoan.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnLoan.Location = New System.Drawing.Point(376, 11)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Size = New System.Drawing.Size(131, 31)
        Me.btnLoan.TabIndex = 197
        Me.btnLoan.Text = "Loan Providers"
        Me.btnLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLoan.UseVisualStyleBackColor = False
        '
        'panelLoans
        '
        Me.panelLoans.BackColor = System.Drawing.Color.SteelBlue
        Me.panelLoans.Location = New System.Drawing.Point(380, 6)
        Me.panelLoans.Name = "panelLoans"
        Me.panelLoans.Size = New System.Drawing.Size(120, 4)
        Me.panelLoans.TabIndex = 198
        Me.panelLoans.Visible = False
        '
        'frmPayments
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1114, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLoan)
        Me.Controls.Add(Me.panelLoans)
        Me.Controls.Add(Me.lblcustomdate)
        Me.Controls.Add(Me.panelto)
        Me.Controls.Add(Me.panelfrom)
        Me.Controls.Add(Me.lblperiod)
        Me.Controls.Add(Me.panelperiod)
        Me.Controls.Add(Me.lblto)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnAccount)
        Me.Controls.Add(Me.panelaccounts)
        Me.Controls.Add(Me.panelpayments)
        Me.Controls.Add(Me.btnBanks)
        Me.Controls.Add(Me.btnPayments)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.lblshowing)
        Me.Controls.Add(Me.dgvmain)
        Me.Controls.Add(Me.panelpassword)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.panelbanks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmReservations"
        Me.panelpassword.ResumeLayout(False)
        Me.panelpassword.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvmain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelto.ResumeLayout(False)
        Me.panelfrom.ResumeLayout(False)
        Me.panelperiod.ResumeLayout(False)
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
    Friend WithEvents btnPayments As System.Windows.Forms.Button
    Friend WithEvents btnBanks As System.Windows.Forms.Button
    Friend WithEvents panelbanks As System.Windows.Forms.Panel
    Friend WithEvents panelpayments As System.Windows.Forms.Panel
    Friend WithEvents panelaccounts As System.Windows.Forms.Panel
    Friend WithEvents btnAccount As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lblcustomdate As System.Windows.Forms.Label
    Friend WithEvents panelto As System.Windows.Forms.Panel
    Friend WithEvents dtpendingdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents panelfrom As System.Windows.Forms.Panel
    Friend WithEvents dtpinitialdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblperiod As System.Windows.Forms.Label
    Friend WithEvents panelperiod As System.Windows.Forms.Panel
    Friend WithEvents cmbPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents lblto As System.Windows.Forms.Label
    Friend WithEvents btnLoan As System.Windows.Forms.Button
    Friend WithEvents panelLoans As System.Windows.Forms.Panel
End Class
