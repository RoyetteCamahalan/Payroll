<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditInvoice_Library
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditInvoice_Library))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.changetype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.newlotid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Oldlotid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.downpayment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bankid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.checkno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.checkdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.dtp_payment_schedule = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtp_invoiceDate = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_interest = New System.Windows.Forms.TextBox()
        Me.txt_terms_payment = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_choose = New System.Windows.Forms.Button()
        Me.txt_Customer = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_choose_agent = New System.Windows.Forms.Button()
        Me.dtgv_Uplines = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_commission = New System.Windows.Forms.TextBox()
        Me.txt_agent = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_term_commission = New System.Windows.Forms.TextBox()
        Me.txt_com_at_down = New System.Windows.Forms.TextBox()
        Me.txt_com_percentage = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ts_add = New System.Windows.Forms.ToolStripButton()
        Me.dtgv_InvoiceDetails = New System.Windows.Forms.DataGridView()
        Me.lbl_Module = New System.Windows.Forms.Label()
        Me.Parcel_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lotid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.new_lotid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reserve_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dtgv_Uplines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dtgv_InvoiceDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.changetype, Me.newlotid, Me.Oldlotid, Me.downpayment, Me.bankid, Me.checkno, Me.checkdate, Me.amount})
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(9, 422)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1007, 129)
        Me.DataGridView1.TabIndex = 45
        Me.DataGridView1.Visible = False
        '
        'changetype
        '
        Me.changetype.HeaderText = "changetype"
        Me.changetype.Name = "changetype"
        '
        'newlotid
        '
        Me.newlotid.HeaderText = "newlotid"
        Me.newlotid.Name = "newlotid"
        '
        'Oldlotid
        '
        Me.Oldlotid.HeaderText = "oldlotid"
        Me.Oldlotid.Name = "Oldlotid"
        '
        'downpayment
        '
        Me.downpayment.HeaderText = "downpayment"
        Me.downpayment.Name = "downpayment"
        '
        'bankid
        '
        Me.bankid.HeaderText = "bankid"
        Me.bankid.Name = "bankid"
        '
        'checkno
        '
        Me.checkno.HeaderText = "checkno"
        Me.checkno.Name = "checkno"
        '
        'checkdate
        '
        Me.checkdate.HeaderText = "checkdate"
        Me.checkdate.Name = "checkdate"
        '
        'amount
        '
        Me.amount.HeaderText = "amount"
        Me.amount.Name = "amount"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(392, 97)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(52, 20)
        Me.TextBox9.TabIndex = 132
        Me.TextBox9.TabStop = False
        Me.TextBox9.Text = "Months"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(392, 71)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(52, 20)
        Me.TextBox8.TabIndex = 131
        Me.TextBox8.TabStop = False
        Me.TextBox8.Text = "%"
        '
        'dtp_payment_schedule
        '
        Me.dtp_payment_schedule.CustomFormat = "yyyy-MM-dd"
        Me.dtp_payment_schedule.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_payment_schedule.Location = New System.Drawing.Point(577, 68)
        Me.dtp_payment_schedule.Name = "dtp_payment_schedule"
        Me.dtp_payment_schedule.Size = New System.Drawing.Size(133, 20)
        Me.dtp_payment_schedule.TabIndex = 128
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(447, 73)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(114, 15)
        Me.Label17.TabIndex = 127
        Me.Label17.Text = "Payment Sched :"
        '
        'dtp_invoiceDate
        '
        Me.dtp_invoiceDate.CustomFormat = "yyyy-MM-dd"
        Me.dtp_invoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_invoiceDate.Location = New System.Drawing.Point(577, 43)
        Me.dtp_invoiceDate.Name = "dtp_invoiceDate"
        Me.dtp_invoiceDate.Size = New System.Drawing.Size(133, 20)
        Me.dtp_invoiceDate.TabIndex = 126
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(447, 45)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 15)
        Me.Label16.TabIndex = 125
        Me.Label16.Text = "Invoice Date :"
        '
        'txt_interest
        '
        Me.txt_interest.Location = New System.Drawing.Point(169, 71)
        Me.txt_interest.Name = "txt_interest"
        Me.txt_interest.Size = New System.Drawing.Size(221, 20)
        Me.txt_interest.TabIndex = 122
        Me.txt_interest.TabStop = False
        '
        'txt_terms_payment
        '
        Me.txt_terms_payment.Location = New System.Drawing.Point(169, 97)
        Me.txt_terms_payment.Name = "txt_terms_payment"
        Me.txt_terms_payment.Size = New System.Drawing.Size(221, 20)
        Me.txt_terms_payment.TabIndex = 121
        Me.txt_terms_payment.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(30, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 15)
        Me.Label14.TabIndex = 124
        Me.Label14.Text = "Delay Interest :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(30, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(130, 15)
        Me.Label15.TabIndex = 123
        Me.Label15.Text = "Terms of Payment :"
        '
        'btn_choose
        '
        Me.btn_choose.Location = New System.Drawing.Point(392, 42)
        Me.btn_choose.Name = "btn_choose"
        Me.btn_choose.Size = New System.Drawing.Size(52, 23)
        Me.btn_choose.TabIndex = 118
        Me.btn_choose.Text = "Change"
        Me.btn_choose.UseVisualStyleBackColor = True
        '
        'txt_Customer
        '
        Me.txt_Customer.Location = New System.Drawing.Point(169, 44)
        Me.txt_Customer.Name = "txt_Customer"
        Me.txt_Customer.ReadOnly = True
        Me.txt_Customer.Size = New System.Drawing.Size(221, 20)
        Me.txt_Customer.TabIndex = 117
        Me.txt_Customer.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(158, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 18)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 15)
        Me.Label7.TabIndex = 119
        Me.Label7.Text = "Customer :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(564, 47)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 18)
        Me.Label19.TabIndex = 130
        Me.Label19.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(564, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 18)
        Me.Label18.TabIndex = 129
        Me.Label18.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(158, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 18)
        Me.Label13.TabIndex = 134
        Me.Label13.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(157, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 18)
        Me.Label12.TabIndex = 133
        Me.Label12.Text = "*"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(725, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 262)
        Me.GroupBox1.TabIndex = 135
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commission Details"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(137, 3)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 18)
        Me.Label20.TabIndex = 117
        Me.Label20.Text = "*"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_choose_agent)
        Me.Panel3.Controls.Add(Me.dtgv_Uplines)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txt_commission)
        Me.Panel3.Controls.Add(Me.txt_agent)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txt_term_commission)
        Me.Panel3.Controls.Add(Me.txt_com_at_down)
        Me.Panel3.Controls.Add(Me.txt_com_percentage)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Panel3.Location = New System.Drawing.Point(8, 17)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(278, 239)
        Me.Panel3.TabIndex = 43
        '
        'btn_choose_agent
        '
        Me.btn_choose_agent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_choose_agent.Location = New System.Drawing.Point(155, 92)
        Me.btn_choose_agent.Name = "btn_choose_agent"
        Me.btn_choose_agent.Size = New System.Drawing.Size(53, 23)
        Me.btn_choose_agent.TabIndex = 116
        Me.btn_choose_agent.Text = "Choose"
        Me.btn_choose_agent.UseVisualStyleBackColor = True
        '
        'dtgv_Uplines
        '
        Me.dtgv_Uplines.AllowUserToAddRows = False
        Me.dtgv_Uplines.AllowUserToDeleteRows = False
        Me.dtgv_Uplines.AllowUserToOrderColumns = True
        Me.dtgv_Uplines.AllowUserToResizeRows = False
        Me.dtgv_Uplines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgv_Uplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_Uplines.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgv_Uplines.Location = New System.Drawing.Point(3, 133)
        Me.dtgv_Uplines.Name = "dtgv_Uplines"
        Me.dtgv_Uplines.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgv_Uplines.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgv_Uplines.Size = New System.Drawing.Size(272, 99)
        Me.dtgv_Uplines.TabIndex = 114
        Me.dtgv_Uplines.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label10.Location = New System.Drawing.Point(205, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 15)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "Com. :"
        '
        'txt_commission
        '
        Me.txt_commission.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.txt_commission.Location = New System.Drawing.Point(208, 93)
        Me.txt_commission.Name = "txt_commission"
        Me.txt_commission.Size = New System.Drawing.Size(67, 20)
        Me.txt_commission.TabIndex = 112
        Me.txt_commission.TabStop = False
        '
        'txt_agent
        '
        Me.txt_agent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.txt_agent.Location = New System.Drawing.Point(3, 94)
        Me.txt_agent.Name = "txt_agent"
        Me.txt_agent.Size = New System.Drawing.Size(152, 20)
        Me.txt_agent.TabIndex = 110
        Me.txt_agent.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label8.Location = New System.Drawing.Point(1, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 15)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "Agent :"
        '
        'txt_term_commission
        '
        Me.txt_term_commission.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.txt_term_commission.Location = New System.Drawing.Point(208, 52)
        Me.txt_term_commission.Name = "txt_term_commission"
        Me.txt_term_commission.Size = New System.Drawing.Size(67, 20)
        Me.txt_term_commission.TabIndex = 106
        Me.txt_term_commission.TabStop = False
        '
        'txt_com_at_down
        '
        Me.txt_com_at_down.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.txt_com_at_down.Location = New System.Drawing.Point(208, 27)
        Me.txt_com_at_down.Name = "txt_com_at_down"
        Me.txt_com_at_down.Size = New System.Drawing.Size(67, 20)
        Me.txt_com_at_down.TabIndex = 105
        Me.txt_com_at_down.TabStop = False
        '
        'txt_com_percentage
        '
        Me.txt_com_percentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.txt_com_percentage.Location = New System.Drawing.Point(208, 2)
        Me.txt_com_percentage.Name = "txt_com_percentage"
        Me.txt_com_percentage.Size = New System.Drawing.Size(67, 20)
        Me.txt_com_percentage.TabIndex = 104
        Me.txt_com_percentage.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label21.Location = New System.Drawing.Point(1, 57)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(133, 15)
        Me.Label21.TabIndex = 109
        Me.Label21.Text = "Terms of Commission :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label22.Location = New System.Drawing.Point(1, 28)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(174, 15)
        Me.Label22.TabIndex = 108
        Me.Label22.Text = "Commission at Downpayment:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label23.Location = New System.Drawing.Point(1, 117)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 15)
        Me.Label23.TabIndex = 115
        Me.Label23.Text = "Upline(s) :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label24.Location = New System.Drawing.Point(1, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(148, 15)
        Me.Label24.TabIndex = 107
        Me.Label24.Text = "Commission Percentage :"
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.Location = New System.Drawing.Point(922, 310)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(95, 33)
        Me.btn_cancel.TabIndex = 137
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.Location = New System.Drawing.Point(821, 310)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(95, 33)
        Me.btn_save.TabIndex = 136
        Me.btn_save.Text = "Save"
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(637, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(72, 33)
        Me.Panel1.TabIndex = 138
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_add})
        Me.ToolStrip1.Location = New System.Drawing.Point(-8, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(81, 25)
        Me.ToolStrip1.TabIndex = 1
        '
        'ts_add
        '
        Me.ts_add.Image = CType(resources.GetObject("ts_add.Image"), System.Drawing.Image)
        Me.ts_add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_add.Name = "ts_add"
        Me.ts_add.Size = New System.Drawing.Size(69, 22)
        Me.ts_add.Text = " Move   "
        '
        'dtgv_InvoiceDetails
        '
        Me.dtgv_InvoiceDetails.AllowUserToAddRows = False
        Me.dtgv_InvoiceDetails.AllowUserToDeleteRows = False
        Me.dtgv_InvoiceDetails.AllowUserToOrderColumns = True
        Me.dtgv_InvoiceDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv_InvoiceDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgv_InvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_InvoiceDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Parcel_Name, Me.Type, Me.Area, Me.Price, Me.Total, Me.lotid, Me.new_lotid, Me.reserve_id})
        Me.dtgv_InvoiceDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtgv_InvoiceDetails.Location = New System.Drawing.Point(33, 153)
        Me.dtgv_InvoiceDetails.Name = "dtgv_InvoiceDetails"
        Me.dtgv_InvoiceDetails.RowHeadersWidth = 20
        Me.dtgv_InvoiceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgv_InvoiceDetails.Size = New System.Drawing.Size(677, 182)
        Me.dtgv_InvoiceDetails.TabIndex = 139
        '
        'lbl_Module
        '
        Me.lbl_Module.AutoSize = True
        Me.lbl_Module.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Module.ForeColor = System.Drawing.Color.Red
        Me.lbl_Module.Location = New System.Drawing.Point(453, 9)
        Me.lbl_Module.Name = "lbl_Module"
        Me.lbl_Module.Size = New System.Drawing.Size(119, 24)
        Me.lbl_Module.TabIndex = 140
        Me.lbl_Module.Text = "Edit Invoice"
        '
        'Parcel_Name
        '
        Me.Parcel_Name.HeaderText = "Parcel Name"
        Me.Parcel_Name.Name = "Parcel_Name"
        Me.Parcel_Name.ReadOnly = True
        '
        'Type
        '
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'Area
        '
        Me.Area.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Area.HeaderText = "Area"
        Me.Area.Name = "Area"
        Me.Area.ReadOnly = True
        Me.Area.Width = 60
        '
        'Price
        '
        Me.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Price.HeaderText = "Price/Square Meter"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 80
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Total.HeaderText = "Total Cost"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 80
        '
        'lotid
        '
        Me.lotid.HeaderText = "lotid"
        Me.lotid.Name = "lotid"
        Me.lotid.Visible = False
        '
        'new_lotid
        '
        Me.new_lotid.HeaderText = "Column1"
        Me.new_lotid.Name = "new_lotid"
        Me.new_lotid.Visible = False
        '
        'reserve_id
        '
        Me.reserve_id.HeaderText = "Column1"
        Me.reserve_id.Name = "reserve_id"
        Me.reserve_id.Visible = False
        '
        'EditInvoice_Library
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 346)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_Module)
        Me.Controls.Add(Me.dtgv_InvoiceDetails)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.dtp_payment_schedule)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.dtp_invoiceDate)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_interest)
        Me.Controls.Add(Me.txt_terms_payment)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btn_choose)
        Me.Controls.Add(Me.txt_Customer)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "EditInvoice_Library"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dtgv_Uplines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dtgv_InvoiceDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents changetype As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents newlotid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Oldlotid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents downpayment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bankid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents checkno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents checkdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents dtp_payment_schedule As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtp_invoiceDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_interest As System.Windows.Forms.TextBox
    Friend WithEvents txt_terms_payment As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btn_choose As System.Windows.Forms.Button
    Friend WithEvents txt_Customer As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_choose_agent As System.Windows.Forms.Button
    Friend WithEvents dtgv_Uplines As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_commission As System.Windows.Forms.TextBox
    Friend WithEvents txt_agent As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_term_commission As System.Windows.Forms.TextBox
    Friend WithEvents txt_com_at_down As System.Windows.Forms.TextBox
    Friend WithEvents txt_com_percentage As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ts_add As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtgv_InvoiceDetails As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_Module As System.Windows.Forms.Label
    Friend WithEvents Parcel_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Area As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lotid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents new_lotid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents reserve_id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
