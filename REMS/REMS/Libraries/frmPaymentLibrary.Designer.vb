<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentLibrary
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentLibrary))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.txtOrNo = New System.Windows.Forms.TextBox()
        Me.txtOrDate = New System.Windows.Forms.TextBox()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.chargeid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lotname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chargedate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.formonth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.interestamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paymentdetailid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNet = New System.Windows.Forms.TextBox()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.panelor = New System.Windows.Forms.Panel()
        Me.panelcustomer = New System.Windows.Forms.Panel()
        Me.pctrSearchCustomer = New System.Windows.Forms.PictureBox()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnpositive = New System.Windows.Forms.Button()
        Me.pctrPayment = New System.Windows.Forms.PictureBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtEncodedby = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.panelor.SuspendLayout()
        Me.panelcustomer.SuspendLayout()
        CType(Me.pctrSearchCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctrPayment, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "Customer:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "OR No.:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 178
        Me.Label6.Text = "OR Date:"
        '
        'txtCustomer
        '
        Me.txtCustomer.BackColor = System.Drawing.Color.White
        Me.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustomer.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCustomer.Location = New System.Drawing.Point(4, 4)
        Me.txtCustomer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCustomer.MaxLength = 25
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(289, 19)
        Me.txtCustomer.TabIndex = 179
        '
        'txtOrNo
        '
        Me.txtOrNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOrNo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtOrNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtOrNo.Location = New System.Drawing.Point(2, 4)
        Me.txtOrNo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtOrNo.MaxLength = 25
        Me.txtOrNo.Name = "txtOrNo"
        Me.txtOrNo.Size = New System.Drawing.Size(310, 19)
        Me.txtOrNo.TabIndex = 185
        '
        'txtOrDate
        '
        Me.txtOrDate.BackColor = System.Drawing.Color.White
        Me.txtOrDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOrDate.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtOrDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtOrDate.Location = New System.Drawing.Point(3, 4)
        Me.txtOrDate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtOrDate.MaxLength = 25
        Me.txtOrDate.Name = "txtOrDate"
        Me.txtOrDate.ReadOnly = True
        Me.txtOrDate.Size = New System.Drawing.Size(312, 19)
        Me.txtOrDate.TabIndex = 186
        '
        'dgvItems
        '
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.AllowUserToDeleteRows = False
        Me.dgvItems.AllowUserToResizeColumns = False
        Me.dgvItems.AllowUserToResizeRows = False
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
        Me.dgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chargeid, Me.lotname, Me.chargedate, Me.formonth, Me.amount, Me.interestamount, Me.balance, Me.tender, Me.paymentdetailid})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 9.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItems.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvItems.Location = New System.Drawing.Point(8, 157)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.RowHeadersVisible = False
        Me.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItems.Size = New System.Drawing.Size(883, 214)
        Me.dgvItems.TabIndex = 187
        '
        'chargeid
        '
        Me.chargeid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MediumSeaGreen
        Me.chargeid.DefaultCellStyle = DataGridViewCellStyle2
        Me.chargeid.HeaderText = "Charge ID"
        Me.chargeid.Name = "chargeid"
        Me.chargeid.ReadOnly = True
        Me.chargeid.Visible = False
        Me.chargeid.Width = 80
        '
        'lotname
        '
        Me.lotname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lotname.DefaultCellStyle = DataGridViewCellStyle3
        Me.lotname.HeaderText = "Lot Name"
        Me.lotname.Name = "lotname"
        Me.lotname.ReadOnly = True
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
        Me.chargedate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chargedate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'formonth
        '
        Me.formonth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.MediumSeaGreen
        Me.formonth.DefaultCellStyle = DataGridViewCellStyle5
        Me.formonth.HeaderText = "For the Month of"
        Me.formonth.Name = "formonth"
        Me.formonth.ReadOnly = True
        Me.formonth.Width = 120
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
        Me.amount.Width = 110
        '
        'interestamount
        '
        Me.interestamount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.MediumSeaGreen
        Me.interestamount.DefaultCellStyle = DataGridViewCellStyle7
        Me.interestamount.HeaderText = "Interest Amount"
        Me.interestamount.Name = "interestamount"
        Me.interestamount.ReadOnly = True
        Me.interestamount.Width = 110
        '
        'balance
        '
        Me.balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.MediumSeaGreen
        Me.balance.DefaultCellStyle = DataGridViewCellStyle8
        Me.balance.HeaderText = "Balance"
        Me.balance.Name = "balance"
        Me.balance.ReadOnly = True
        Me.balance.Width = 130
        '
        'tender
        '
        Me.tender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LimeGreen
        Me.tender.DefaultCellStyle = DataGridViewCellStyle9
        Me.tender.HeaderText = "Tender"
        Me.tender.Name = "tender"
        Me.tender.Width = 130
        '
        'paymentdetailid
        '
        Me.paymentdetailid.HeaderText = "Column1"
        Me.paymentdetailid.Name = "paymentdetailid"
        Me.paymentdetailid.Visible = False
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
        'txtPayment
        '
        Me.txtPayment.Enabled = False
        Me.txtPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayment.Location = New System.Drawing.Point(786, 404)
        Me.txtPayment.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPayment.MaxLength = 25
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.ReadOnly = True
        Me.txtPayment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPayment.Size = New System.Drawing.Size(105, 21)
        Me.txtPayment.TabIndex = 198
        Me.txtPayment.Text = "0.00"
        Me.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(696, 406)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 16)
        Me.Label11.TabIndex = 200
        Me.Label11.Text = "Payment:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(704, 430)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 202
        Me.Label12.Text = "Change:"
        '
        'txtChange
        '
        Me.txtChange.Enabled = False
        Me.txtChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.Location = New System.Drawing.Point(763, 428)
        Me.txtChange.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtChange.MaxLength = 25
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtChange.Size = New System.Drawing.Size(128, 21)
        Me.txtChange.TabIndex = 201
        Me.txtChange.Text = "0.00"
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.panelor)
        Me.Panel1.Controls.Add(Me.panelcustomer)
        Me.Panel1.Controls.Add(Me.btnRemoveItem)
        Me.Panel1.Controls.Add(Me.btnAddItem)
        Me.Panel1.Controls.Add(Me.btnpositive)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtChange)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.pctrPayment)
        Me.Panel1.Controls.Add(Me.txtNet)
        Me.Panel1.Controls.Add(Me.txtPayment)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dgvItems)
        Me.Panel1.Location = New System.Drawing.Point(5, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 516)
        Me.Panel1.TabIndex = 206
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.txtOrDate)
        Me.Panel6.Location = New System.Drawing.Point(98, 85)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(318, 29)
        Me.Panel6.TabIndex = 215
        '
        'panelor
        '
        Me.panelor.BackColor = System.Drawing.Color.White
        Me.panelor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelor.Controls.Add(Me.txtOrNo)
        Me.panelor.Location = New System.Drawing.Point(98, 50)
        Me.panelor.Name = "panelor"
        Me.panelor.Size = New System.Drawing.Size(318, 29)
        Me.panelor.TabIndex = 214
        '
        'panelcustomer
        '
        Me.panelcustomer.BackColor = System.Drawing.Color.White
        Me.panelcustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelcustomer.Controls.Add(Me.pctrSearchCustomer)
        Me.panelcustomer.Controls.Add(Me.txtCustomer)
        Me.panelcustomer.Location = New System.Drawing.Point(98, 15)
        Me.panelcustomer.Name = "panelcustomer"
        Me.panelcustomer.Size = New System.Drawing.Size(318, 29)
        Me.panelcustomer.TabIndex = 211
        '
        'pctrSearchCustomer
        '
        Me.pctrSearchCustomer.BackColor = System.Drawing.Color.White
        Me.pctrSearchCustomer.Image = Global.IRES.My.Resources.Resources.search_glyph
        Me.pctrSearchCustomer.Location = New System.Drawing.Point(291, 1)
        Me.pctrSearchCustomer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pctrSearchCustomer.Name = "pctrSearchCustomer"
        Me.pctrSearchCustomer.Size = New System.Drawing.Size(24, 24)
        Me.pctrSearchCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrSearchCustomer.TabIndex = 184
        Me.pctrSearchCustomer.TabStop = False
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
        Me.btnpositive.Location = New System.Drawing.Point(762, 464)
        Me.btnpositive.Name = "btnpositive"
        Me.btnpositive.Size = New System.Drawing.Size(130, 43)
        Me.btnpositive.TabIndex = 205
        Me.btnpositive.Text = "Done"
        Me.btnpositive.UseVisualStyleBackColor = False
        '
        'pctrPayment
        '
        Me.pctrPayment.BackColor = System.Drawing.Color.Peru
        Me.pctrPayment.Image = Global.IRES.My.Resources.Resources.ic_add16_16
        Me.pctrPayment.Location = New System.Drawing.Point(763, 406)
        Me.pctrPayment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pctrPayment.Name = "pctrPayment"
        Me.pctrPayment.Size = New System.Drawing.Size(19, 19)
        Me.pctrPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrPayment.TabIndex = 199
        Me.pctrPayment.TabStop = False
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
        Me.lblTitle.Size = New System.Drawing.Size(177, 22)
        Me.lblTitle.TabIndex = 208
        Me.lblTitle.Text = "Add New Payment"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtEncodedby)
        Me.Panel2.Location = New System.Drawing.Point(98, 482)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(318, 29)
        Me.Panel2.TabIndex = 217
        '
        'txtEncodedby
        '
        Me.txtEncodedby.BackColor = System.Drawing.Color.White
        Me.txtEncodedby.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEncodedby.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtEncodedby.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEncodedby.Location = New System.Drawing.Point(3, 4)
        Me.txtEncodedby.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtEncodedby.MaxLength = 25
        Me.txtEncodedby.Name = "txtEncodedby"
        Me.txtEncodedby.ReadOnly = True
        Me.txtEncodedby.Size = New System.Drawing.Size(312, 19)
        Me.txtEncodedby.TabIndex = 186
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 488)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 216
        Me.Label2.Text = "Encoded By:"
        '
        'frmPaymentLibrary
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(910, 560)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPaymentLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.panelor.ResumeLayout(False)
        Me.panelor.PerformLayout()
        Me.panelcustomer.ResumeLayout(False)
        Me.panelcustomer.PerformLayout()
        CType(Me.pctrSearchCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctrPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents pctrSearchCustomer As System.Windows.Forms.PictureBox
    Friend WithEvents txtOrNo As System.Windows.Forms.TextBox
    Friend WithEvents txtOrDate As System.Windows.Forms.TextBox
    Friend WithEvents dgvItems As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNet As System.Windows.Forms.TextBox
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents pctrPayment As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnpositive As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents panelor As System.Windows.Forms.Panel
    Friend WithEvents panelcustomer As System.Windows.Forms.Panel
    Friend WithEvents chargeid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lotname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chargedate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents formonth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents interestamount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents paymentdetailid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtEncodedby As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
