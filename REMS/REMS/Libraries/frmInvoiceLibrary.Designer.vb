<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoiceLibrary
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoiceLibrary))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.txtOrNo = New System.Windows.Forms.TextBox()
        Me.txtOrDate = New System.Windows.Forms.TextBox()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.lotid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lotname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.netcommissionable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adcom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compercentage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reservationfee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tempreservefee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNet = New System.Windows.Forms.TextBox()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.txt_term_commission = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtpercentageoverterm = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblloansource = New System.Windows.Forms.Label()
        Me.panelloansouce = New System.Windows.Forms.Panel()
        Me.cmbloansource = New System.Windows.Forms.ComboBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.dtpinvoicedate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.dtpexpiration = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtpaymentterm = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtinterest = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvmain = New System.Windows.Forms.DataGridView()
        Me.panelagent = New System.Windows.Forms.Panel()
        Me.txtAgent = New System.Windows.Forms.TextBox()
        Me.pctrSearchAgent = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.panelor = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.panelcustomer = New System.Windows.Forms.Panel()
        Me.pctrSearchCustomer = New System.Windows.Forms.PictureBox()
        Me.panelbirthdate = New System.Windows.Forms.Panel()
        Me.dtppaymentsched = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnpositive = New System.Windows.Forms.Button()
        Me.pctrPayment = New System.Windows.Forms.PictureBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.panelloansouce.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.dgvmain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelagent.SuspendLayout()
        CType(Me.pctrSearchAgent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.panelor.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.panelcustomer.SuspendLayout()
        CType(Me.pctrSearchCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelbirthdate.SuspendLayout()
        CType(Me.pctrPayment, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label3.Location = New System.Drawing.Point(436, 21)
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
        Me.Label6.Location = New System.Drawing.Point(436, 57)
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
        Me.txtCustomer.Size = New System.Drawing.Size(278, 19)
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
        Me.txtOrNo.Size = New System.Drawing.Size(195, 19)
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
        Me.txtOrDate.Size = New System.Drawing.Size(196, 19)
        Me.txtOrDate.TabIndex = 186
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
        Me.dgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lotid, Me.lotname, Me.Price, Me.discount, Me.totalprice, Me.loan, Me.netcommissionable, Me.adcom, Me.compercentage, Me.reservationfee, Me.tempreservefee})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 9.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItems.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvItems.Location = New System.Drawing.Point(8, 172)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.RowHeadersVisible = False
        Me.dgvItems.Size = New System.Drawing.Size(1003, 214)
        Me.dgvItems.TabIndex = 187
        '
        'lotid
        '
        Me.lotid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.lotid.HeaderText = "Lot ID"
        Me.lotid.Name = "lotid"
        Me.lotid.ReadOnly = True
        Me.lotid.Visible = False
        Me.lotid.Width = 80
        '
        'lotname
        '
        Me.lotname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.lotname.HeaderText = "Lot Name"
        Me.lotname.Name = "lotname"
        Me.lotname.ReadOnly = True
        Me.lotname.Width = 200
        '
        'Price
        '
        Me.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        Me.Price.DefaultCellStyle = DataGridViewCellStyle2
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'discount
        '
        Me.discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LimeGreen
        Me.discount.DefaultCellStyle = DataGridViewCellStyle3
        Me.discount.HeaderText = "Discount"
        Me.discount.Name = "discount"
        Me.discount.Width = 70
        '
        'totalprice
        '
        Me.totalprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.totalprice.DefaultCellStyle = DataGridViewCellStyle4
        Me.totalprice.HeaderText = "Final Price"
        Me.totalprice.Name = "totalprice"
        Me.totalprice.ReadOnly = True
        '
        'loan
        '
        Me.loan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LimeGreen
        Me.loan.DefaultCellStyle = DataGridViewCellStyle5
        Me.loan.HeaderText = "Loan Covered"
        Me.loan.Name = "loan"
        Me.loan.Width = 120
        '
        'netcommissionable
        '
        Me.netcommissionable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LimeGreen
        Me.netcommissionable.DefaultCellStyle = DataGridViewCellStyle6
        Me.netcommissionable.HeaderText = "Commissionable Amount"
        Me.netcommissionable.Name = "netcommissionable"
        Me.netcommissionable.Width = 110
        '
        'adcom
        '
        Me.adcom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LimeGreen
        Me.adcom.DefaultCellStyle = DataGridViewCellStyle7
        Me.adcom.HeaderText = "Advance Commission"
        Me.adcom.Name = "adcom"
        '
        'compercentage
        '
        Me.compercentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LimeGreen
        Me.compercentage.DefaultCellStyle = DataGridViewCellStyle8
        Me.compercentage.HeaderText = "Commission Percentage"
        Me.compercentage.Name = "compercentage"
        '
        'reservationfee
        '
        Me.reservationfee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LimeGreen
        Me.reservationfee.DefaultCellStyle = DataGridViewCellStyle9
        Me.reservationfee.HeaderText = "Reservation Fee"
        Me.reservationfee.Name = "reservationfee"
        '
        'tempreservefee
        '
        Me.tempreservefee.HeaderText = "Column1"
        Me.tempreservefee.Name = "tempreservefee"
        Me.tempreservefee.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(812, 399)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 197
        Me.Label10.Text = "Net Total:"
        '
        'txtNet
        '
        Me.txtNet.Enabled = False
        Me.txtNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNet.Location = New System.Drawing.Point(883, 396)
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
        Me.txtPayment.Location = New System.Drawing.Point(906, 421)
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
        Me.Label11.Location = New System.Drawing.Point(816, 423)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 16)
        Me.Label11.TabIndex = 200
        Me.Label11.Text = "Payment:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(824, 447)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 202
        Me.Label12.Text = "Change:"
        '
        'txtChange
        '
        Me.txtChange.Enabled = False
        Me.txtChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.Location = New System.Drawing.Point(883, 445)
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
        'txt_term_commission
        '
        Me.txt_term_commission.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_term_commission.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_term_commission.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_term_commission.Location = New System.Drawing.Point(4, 4)
        Me.txt_term_commission.Name = "txt_term_commission"
        Me.txt_term_commission.Size = New System.Drawing.Size(234, 19)
        Me.txt_term_commission.TabIndex = 106
        Me.txt_term_commission.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(5, 441)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 16)
        Me.Label16.TabIndex = 109
        Me.Label16.Text = "Commission Term:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(9, 486)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(87, 16)
        Me.Label19.TabIndex = 107
        Me.Label19.Text = "%  over Term:"
        '
        'txtpercentageoverterm
        '
        Me.txtpercentageoverterm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpercentageoverterm.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtpercentageoverterm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpercentageoverterm.Location = New System.Drawing.Point(3, 4)
        Me.txtpercentageoverterm.Name = "txtpercentageoverterm"
        Me.txtpercentageoverterm.Size = New System.Drawing.Size(235, 19)
        Me.txtpercentageoverterm.TabIndex = 104
        Me.txtpercentageoverterm.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.lblloansource)
        Me.Panel1.Controls.Add(Me.panelloansouce)
        Me.Panel1.Controls.Add(Me.Panel11)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dgvmain)
        Me.Panel1.Controls.Add(Me.panelagent)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.panelor)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.panelcustomer)
        Me.Panel1.Controls.Add(Me.panelbirthdate)
        Me.Panel1.Controls.Add(Me.Label9)
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
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dgvItems)
        Me.Panel1.Location = New System.Drawing.Point(5, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1023, 537)
        Me.Panel1.TabIndex = 206
        '
        'lblloansource
        '
        Me.lblloansource.AutoSize = True
        Me.lblloansource.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lblloansource.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblloansource.Location = New System.Drawing.Point(3, 122)
        Me.lblloansource.Name = "lblloansource"
        Me.lblloansource.Size = New System.Drawing.Size(85, 16)
        Me.lblloansource.TabIndex = 230
        Me.lblloansource.Text = "Loan Source:"
        '
        'panelloansouce
        '
        Me.panelloansouce.BackColor = System.Drawing.Color.White
        Me.panelloansouce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelloansouce.Controls.Add(Me.cmbloansource)
        Me.panelloansouce.Location = New System.Drawing.Point(98, 117)
        Me.panelloansouce.Name = "panelloansouce"
        Me.panelloansouce.Size = New System.Drawing.Size(308, 27)
        Me.panelloansouce.TabIndex = 229
        '
        'cmbloansource
        '
        Me.cmbloansource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbloansource.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.cmbloansource.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.cmbloansource.FormattingEnabled = True
        Me.cmbloansource.Location = New System.Drawing.Point(-1, 0)
        Me.cmbloansource.Name = "cmbloansource"
        Me.cmbloansource.Size = New System.Drawing.Size(308, 25)
        Me.cmbloansource.TabIndex = 0
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.dtpinvoicedate)
        Me.Panel11.Location = New System.Drawing.Point(828, 15)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(183, 29)
        Me.Panel11.TabIndex = 226
        '
        'dtpinvoicedate
        '
        Me.dtpinvoicedate.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpinvoicedate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpinvoicedate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpinvoicedate.Enabled = False
        Me.dtpinvoicedate.Font = New System.Drawing.Font("Arial", 12.5!)
        Me.dtpinvoicedate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpinvoicedate.Location = New System.Drawing.Point(-1, 0)
        Me.dtpinvoicedate.Name = "dtpinvoicedate"
        Me.dtpinvoicedate.Size = New System.Drawing.Size(183, 27)
        Me.dtpinvoicedate.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(747, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 16)
        Me.Label8.TabIndex = 227
        Me.Label8.Text = "Invoice Date:"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.dtpexpiration)
        Me.Panel10.Location = New System.Drawing.Point(828, 49)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(183, 29)
        Me.Panel10.TabIndex = 224
        '
        'dtpexpiration
        '
        Me.dtpexpiration.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpexpiration.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpexpiration.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpexpiration.Enabled = False
        Me.dtpexpiration.Font = New System.Drawing.Font("Arial", 12.5!)
        Me.dtpexpiration.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpexpiration.Location = New System.Drawing.Point(-1, 0)
        Me.dtpexpiration.Name = "dtpexpiration"
        Me.dtpexpiration.Size = New System.Drawing.Size(183, 27)
        Me.dtpexpiration.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(747, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 225
        Me.Label7.Text = "Expiration:"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.txtpaymentterm)
        Me.Panel8.Location = New System.Drawing.Point(98, 83)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(308, 29)
        Me.Panel8.TabIndex = 223
        '
        'txtpaymentterm
        '
        Me.txtpaymentterm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpaymentterm.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtpaymentterm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpaymentterm.Location = New System.Drawing.Point(3, 4)
        Me.txtpaymentterm.Name = "txtpaymentterm"
        Me.txtpaymentterm.Size = New System.Drawing.Size(300, 19)
        Me.txtpaymentterm.TabIndex = 104
        Me.txtpaymentterm.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.txtinterest)
        Me.Panel9.Location = New System.Drawing.Point(98, 50)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(308, 29)
        Me.Panel9.TabIndex = 222
        '
        'txtinterest
        '
        Me.txtinterest.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtinterest.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtinterest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtinterest.Location = New System.Drawing.Point(4, 4)
        Me.txtinterest.Name = "txtinterest"
        Me.txtinterest.Size = New System.Drawing.Size(299, 19)
        Me.txtinterest.TabIndex = 106
        Me.txtinterest.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 220
        Me.Label4.Text = "Payment Term:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(3, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 221
        Me.Label5.Text = "Interest %:"
        '
        'dgvmain
        '
        Me.dgvmain.AllowUserToAddRows = False
        Me.dgvmain.AllowUserToDeleteRows = False
        Me.dgvmain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvmain.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvmain.Location = New System.Drawing.Point(384, 396)
        Me.dgvmain.Name = "dgvmain"
        Me.dgvmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvmain.Size = New System.Drawing.Size(415, 123)
        Me.dgvmain.TabIndex = 219
        '
        'panelagent
        '
        Me.panelagent.BackColor = System.Drawing.Color.White
        Me.panelagent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelagent.Controls.Add(Me.txtAgent)
        Me.panelagent.Controls.Add(Me.pctrSearchAgent)
        Me.panelagent.Location = New System.Drawing.Point(53, 396)
        Me.panelagent.Name = "panelagent"
        Me.panelagent.Size = New System.Drawing.Size(310, 29)
        Me.panelagent.TabIndex = 218
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
        Me.txtAgent.Size = New System.Drawing.Size(271, 19)
        Me.txtAgent.TabIndex = 179
        '
        'pctrSearchAgent
        '
        Me.pctrSearchAgent.BackColor = System.Drawing.Color.White
        Me.pctrSearchAgent.Image = Global.IRES.My.Resources.Resources.search_glyph
        Me.pctrSearchAgent.Location = New System.Drawing.Point(282, 1)
        Me.pctrSearchAgent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pctrSearchAgent.Name = "pctrSearchAgent"
        Me.pctrSearchAgent.Size = New System.Drawing.Size(24, 24)
        Me.pctrSearchAgent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrSearchAgent.TabIndex = 184
        Me.pctrSearchAgent.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 403)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 216
        Me.Label2.Text = "Agent:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.txtOrDate)
        Me.Panel6.Location = New System.Drawing.Point(517, 49)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(203, 29)
        Me.Panel6.TabIndex = 215
        '
        'panelor
        '
        Me.panelor.BackColor = System.Drawing.Color.White
        Me.panelor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelor.Controls.Add(Me.txtOrNo)
        Me.panelor.Location = New System.Drawing.Point(517, 14)
        Me.panelor.Name = "panelor"
        Me.panelor.Size = New System.Drawing.Size(203, 29)
        Me.panelor.TabIndex = 214
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtpercentageoverterm)
        Me.Panel4.Location = New System.Drawing.Point(120, 479)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(243, 29)
        Me.Panel4.TabIndex = 213
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txt_term_commission)
        Me.Panel3.Location = New System.Drawing.Point(120, 438)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(243, 29)
        Me.Panel3.TabIndex = 212
        '
        'panelcustomer
        '
        Me.panelcustomer.BackColor = System.Drawing.Color.White
        Me.panelcustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelcustomer.Controls.Add(Me.pctrSearchCustomer)
        Me.panelcustomer.Controls.Add(Me.txtCustomer)
        Me.panelcustomer.Location = New System.Drawing.Point(98, 15)
        Me.panelcustomer.Name = "panelcustomer"
        Me.panelcustomer.Size = New System.Drawing.Size(308, 29)
        Me.panelcustomer.TabIndex = 211
        '
        'pctrSearchCustomer
        '
        Me.pctrSearchCustomer.BackColor = System.Drawing.Color.White
        Me.pctrSearchCustomer.Image = Global.IRES.My.Resources.Resources.search_glyph
        Me.pctrSearchCustomer.Location = New System.Drawing.Point(280, 1)
        Me.pctrSearchCustomer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pctrSearchCustomer.Name = "pctrSearchCustomer"
        Me.pctrSearchCustomer.Size = New System.Drawing.Size(24, 24)
        Me.pctrSearchCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrSearchCustomer.TabIndex = 184
        Me.pctrSearchCustomer.TabStop = False
        '
        'panelbirthdate
        '
        Me.panelbirthdate.BackColor = System.Drawing.Color.White
        Me.panelbirthdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelbirthdate.Controls.Add(Me.dtppaymentsched)
        Me.panelbirthdate.Location = New System.Drawing.Point(539, 84)
        Me.panelbirthdate.Name = "panelbirthdate"
        Me.panelbirthdate.Size = New System.Drawing.Size(181, 29)
        Me.panelbirthdate.TabIndex = 208
        '
        'dtppaymentsched
        '
        Me.dtppaymentsched.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtppaymentsched.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtppaymentsched.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtppaymentsched.Font = New System.Drawing.Font("Arial", 12.5!)
        Me.dtppaymentsched.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtppaymentsched.Location = New System.Drawing.Point(-1, 0)
        Me.dtppaymentsched.Name = "dtppaymentsched"
        Me.dtppaymentsched.Size = New System.Drawing.Size(181, 27)
        Me.dtppaymentsched.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(436, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 16)
        Me.Label9.TabIndex = 209
        Me.Label9.Text = "Payment Sched:"
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.BackColor = System.Drawing.Color.Firebrick
        Me.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnRemoveItem.ForeColor = System.Drawing.Color.White
        Me.btnRemoveItem.Image = CType(resources.GetObject("btnRemoveItem.Image"), System.Drawing.Image)
        Me.btnRemoveItem.Location = New System.Drawing.Point(910, 125)
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
        Me.btnAddItem.Location = New System.Drawing.Point(808, 125)
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
        Me.btnpositive.Location = New System.Drawing.Point(881, 486)
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
        Me.pctrPayment.Location = New System.Drawing.Point(883, 423)
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
        Me.btnclose.Location = New System.Drawing.Point(1004, 8)
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
        Me.lblTitle.Size = New System.Drawing.Size(207, 22)
        Me.lblTitle.TabIndex = 208
        Me.lblTitle.Text = "Add New Reservation"
        '
        'frmInvoiceLibrary
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(1033, 581)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInvoiceLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelloansouce.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.dgvmain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelagent.ResumeLayout(False)
        Me.panelagent.PerformLayout()
        CType(Me.pctrSearchAgent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.panelor.ResumeLayout(False)
        Me.panelor.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.panelcustomer.ResumeLayout(False)
        Me.panelcustomer.PerformLayout()
        CType(Me.pctrSearchCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelbirthdate.ResumeLayout(False)
        CType(Me.pctrPayment, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txt_term_commission As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtpercentageoverterm As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnpositive As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents panelbirthdate As System.Windows.Forms.Panel
    Friend WithEvents dtppaymentsched As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents panelor As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents panelcustomer As System.Windows.Forms.Panel
    Friend WithEvents panelagent As System.Windows.Forms.Panel
    Friend WithEvents txtAgent As System.Windows.Forms.TextBox
    Friend WithEvents pctrSearchAgent As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvmain As System.Windows.Forms.DataGridView
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents txtpaymentterm As System.Windows.Forms.TextBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents txtinterest As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents dtpexpiration As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents dtpinvoicedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lotid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lotname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalprice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents loan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents netcommissionable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents adcom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents compercentage As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents reservationfee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tempreservefee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblloansource As System.Windows.Forms.Label
    Friend WithEvents panelloansouce As System.Windows.Forms.Panel
    Friend WithEvents cmbloansource As System.Windows.Forms.ComboBox
End Class
