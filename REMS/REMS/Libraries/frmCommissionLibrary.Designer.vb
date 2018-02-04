<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommissionLibrary
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommissionLibrary))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAgent = New System.Windows.Forms.TextBox()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.compaymentid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lotname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chargedate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.formonth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cashout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chargeid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNet = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dtpbirthdate = New System.Windows.Forms.DateTimePicker()
        Me.panelvoucher = New System.Windows.Forms.Panel()
        Me.txtVoucherNo = New System.Windows.Forms.TextBox()
        Me.panelagent = New System.Windows.Forms.Panel()
        Me.pctrAgent = New System.Windows.Forms.PictureBox()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnpositive = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txttaxpercentage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.panelvoucher.SuspendLayout()
        Me.panelagent.SuspendLayout()
        CType(Me.pctrAgent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "Agent:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 178
        Me.Label6.Text = "Date:"
        '
        'txtAgent
        '
        Me.txtAgent.BackColor = System.Drawing.Color.White
        Me.txtAgent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAgent.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtAgent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAgent.Location = New System.Drawing.Point(4, 4)
        Me.txtAgent.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAgent.MaxLength = 25
        Me.txtAgent.Name = "txtAgent"
        Me.txtAgent.ReadOnly = True
        Me.txtAgent.Size = New System.Drawing.Size(289, 19)
        Me.txtAgent.TabIndex = 179
        '
        'dgvItems
        '
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.AllowUserToDeleteRows = False
        Me.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.compaymentid, Me.customer, Me.lotname, Me.chargedate, Me.formonth, Me.amount, Me.cashout, Me.chargeid})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 9.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItems.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvItems.Location = New System.Drawing.Point(8, 157)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.RowHeadersVisible = False
        Me.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItems.Size = New System.Drawing.Size(883, 214)
        Me.dgvItems.TabIndex = 187
        '
        'compaymentid
        '
        Me.compaymentid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.compaymentid.HeaderText = "Compaymentid"
        Me.compaymentid.Name = "compaymentid"
        Me.compaymentid.ReadOnly = True
        Me.compaymentid.Visible = False
        Me.compaymentid.Width = 80
        '
        'customer
        '
        Me.customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MediumSeaGreen
        Me.customer.DefaultCellStyle = DataGridViewCellStyle2
        Me.customer.HeaderText = "Customer Name"
        Me.customer.Name = "customer"
        Me.customer.ReadOnly = True
        Me.customer.Width = 180
        '
        'lotname
        '
        Me.lotname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lotname.DefaultCellStyle = DataGridViewCellStyle3
        Me.lotname.HeaderText = "Lot Name"
        Me.lotname.Name = "lotname"
        Me.lotname.ReadOnly = True
        Me.lotname.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.lotname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.lotname.Width = 180
        '
        'chargedate
        '
        Me.chargedate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.MediumSeaGreen
        Me.chargedate.DefaultCellStyle = DataGridViewCellStyle4
        Me.chargedate.HeaderText = "Date"
        Me.chargedate.Name = "chargedate"
        Me.chargedate.ReadOnly = True
        '
        'formonth
        '
        Me.formonth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.MediumSeaGreen
        Me.formonth.DefaultCellStyle = DataGridViewCellStyle5
        Me.formonth.HeaderText = "For The Month of"
        Me.formonth.Name = "formonth"
        Me.formonth.ReadOnly = True
        Me.formonth.Width = 130
        '
        'amount
        '
        Me.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.MediumSeaGreen
        Me.amount.DefaultCellStyle = DataGridViewCellStyle6
        Me.amount.HeaderText = "Amount"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        Me.amount.Width = 140
        '
        'cashout
        '
        Me.cashout.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.MediumSeaGreen
        Me.cashout.DefaultCellStyle = DataGridViewCellStyle7
        Me.cashout.HeaderText = "Cash Out"
        Me.cashout.Name = "cashout"
        Me.cashout.Width = 150
        '
        'chargeid
        '
        Me.chargeid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        Me.chargeid.DefaultCellStyle = DataGridViewCellStyle8
        Me.chargeid.HeaderText = "chargeid"
        Me.chargeid.Name = "chargeid"
        Me.chargeid.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(692, 382)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 197
        Me.Label10.Text = "Net Total:"
        '
        'txtNet
        '
        Me.txtNet.Enabled = False
        Me.txtNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNet.Location = New System.Drawing.Point(763, 379)
        Me.txtNet.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNet.MaxLength = 25
        Me.txtNet.Name = "txtNet"
        Me.txtNet.ReadOnly = True
        Me.txtNet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNet.Size = New System.Drawing.Size(128, 21)
        Me.txtNet.TabIndex = 196
        Me.txtNet.Text = "0.00"
        Me.txtNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.panelvoucher)
        Me.Panel1.Controls.Add(Me.panelagent)
        Me.Panel1.Controls.Add(Me.btnRemoveItem)
        Me.Panel1.Controls.Add(Me.btnAddItem)
        Me.Panel1.Controls.Add(Me.btnpositive)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtNet)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dgvItems)
        Me.Panel1.Location = New System.Drawing.Point(5, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 464)
        Me.Panel1.TabIndex = 206
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.dtpbirthdate)
        Me.Panel6.Location = New System.Drawing.Point(98, 85)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(318, 29)
        Me.Panel6.TabIndex = 215
        '
        'dtpbirthdate
        '
        Me.dtpbirthdate.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpbirthdate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpbirthdate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpbirthdate.Font = New System.Drawing.Font("Arial", 12.5!)
        Me.dtpbirthdate.Location = New System.Drawing.Point(-1, 0)
        Me.dtpbirthdate.Name = "dtpbirthdate"
        Me.dtpbirthdate.Size = New System.Drawing.Size(319, 27)
        Me.dtpbirthdate.TabIndex = 1
        '
        'panelvoucher
        '
        Me.panelvoucher.BackColor = System.Drawing.Color.White
        Me.panelvoucher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelvoucher.Controls.Add(Me.txtVoucherNo)
        Me.panelvoucher.Location = New System.Drawing.Point(98, 50)
        Me.panelvoucher.Name = "panelvoucher"
        Me.panelvoucher.Size = New System.Drawing.Size(318, 29)
        Me.panelvoucher.TabIndex = 214
        '
        'txtVoucherNo
        '
        Me.txtVoucherNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVoucherNo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtVoucherNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtVoucherNo.Location = New System.Drawing.Point(2, 4)
        Me.txtVoucherNo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtVoucherNo.MaxLength = 25
        Me.txtVoucherNo.Name = "txtVoucherNo"
        Me.txtVoucherNo.ReadOnly = True
        Me.txtVoucherNo.Size = New System.Drawing.Size(313, 19)
        Me.txtVoucherNo.TabIndex = 185
        '
        'panelagent
        '
        Me.panelagent.BackColor = System.Drawing.Color.White
        Me.panelagent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelagent.Controls.Add(Me.pctrAgent)
        Me.panelagent.Controls.Add(Me.txtAgent)
        Me.panelagent.Location = New System.Drawing.Point(98, 15)
        Me.panelagent.Name = "panelagent"
        Me.panelagent.Size = New System.Drawing.Size(318, 29)
        Me.panelagent.TabIndex = 211
        '
        'pctrAgent
        '
        Me.pctrAgent.BackColor = System.Drawing.Color.White
        Me.pctrAgent.Image = Global.IRES.My.Resources.Resources.search_glyph
        Me.pctrAgent.Location = New System.Drawing.Point(291, 1)
        Me.pctrAgent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pctrAgent.Name = "pctrAgent"
        Me.pctrAgent.Size = New System.Drawing.Size(24, 24)
        Me.pctrAgent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrAgent.TabIndex = 184
        Me.pctrAgent.TabStop = False
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.BackColor = System.Drawing.Color.Firebrick
        Me.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnRemoveItem.ForeColor = System.Drawing.Color.White
        Me.btnRemoveItem.Image = CType(resources.GetObject("btnRemoveItem.Image"), System.Drawing.Image)
        Me.btnRemoveItem.Location = New System.Drawing.Point(790, 115)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(101, 41)
        Me.btnRemoveItem.TabIndex = 207
        Me.btnRemoveItem.Text = "Remove"
        Me.btnRemoveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemoveItem.UseVisualStyleBackColor = False
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.Image = CType(resources.GetObject("btnAddItem.Image"), System.Drawing.Image)
        Me.btnAddItem.Location = New System.Drawing.Point(688, 115)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(101, 41)
        Me.btnAddItem.TabIndex = 206
        Me.btnAddItem.Text = " Add New"
        Me.btnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'btnpositive
        '
        Me.btnpositive.BackColor = System.Drawing.Color.SteelBlue
        Me.btnpositive.FlatAppearance.BorderSize = 0
        Me.btnpositive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnpositive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpositive.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnpositive.ForeColor = System.Drawing.Color.White
        Me.btnpositive.Location = New System.Drawing.Point(762, 411)
        Me.btnpositive.Name = "btnpositive"
        Me.btnpositive.Size = New System.Drawing.Size(130, 43)
        Me.btnpositive.TabIndex = 205
        Me.btnpositive.Text = "Done"
        Me.btnpositive.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "Voucher No.:"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(878, 7)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(24, 20)
        Me.btnclose.TabIndex = 207
        Me.btnclose.Text = "X"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(6, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(212, 22)
        Me.lblTitle.TabIndex = 208
        Me.lblTitle.Text = "Add New Commission"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txttaxpercentage)
        Me.Panel2.Location = New System.Drawing.Point(98, 119)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(318, 29)
        Me.Panel2.TabIndex = 217
        '
        'txttaxpercentage
        '
        Me.txttaxpercentage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttaxpercentage.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txttaxpercentage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txttaxpercentage.Location = New System.Drawing.Point(2, 4)
        Me.txttaxpercentage.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txttaxpercentage.MaxLength = 25
        Me.txttaxpercentage.Name = "txttaxpercentage"
        Me.txttaxpercentage.ReadOnly = True
        Me.txttaxpercentage.Size = New System.Drawing.Size(313, 19)
        Me.txttaxpercentage.TabIndex = 185
        Me.txttaxpercentage.Text = "10"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 216
        Me.Label2.Text = "Tax Percentage:"
        '
        'frmCommissionLibrary
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(910, 508)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCommissionLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.panelvoucher.ResumeLayout(False)
        Me.panelvoucher.PerformLayout()
        Me.panelagent.ResumeLayout(False)
        Me.panelagent.PerformLayout()
        CType(Me.pctrAgent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAgent As System.Windows.Forms.TextBox
    Friend WithEvents pctrAgent As System.Windows.Forms.PictureBox
    Friend WithEvents dgvItems As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNet As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnpositive As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents panelagent As System.Windows.Forms.Panel
    Friend WithEvents panelvoucher As System.Windows.Forms.Panel
    Friend WithEvents txtVoucherNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents compaymentid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lotname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chargedate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents formonth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cashout As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chargeid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpbirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txttaxpercentage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
