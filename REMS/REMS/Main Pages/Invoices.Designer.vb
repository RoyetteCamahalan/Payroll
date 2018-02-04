<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoices))
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ts_add = New System.Windows.Forms.ToolStripButton()
        Me.ts_edit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_printings = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ts_print_contract = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_print_payment_sched = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtgv_Invoices = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_encodedBy = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_interest = New System.Windows.Forms.TextBox()
        Me.txt_terms_payment = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtgv_Uplines = New System.Windows.Forms.DataGridView()
        Me.txt_term_commission = New System.Windows.Forms.TextBox()
        Me.txt_com_at_down = New System.Windows.Forms.TextBox()
        Me.txt_com_percentage = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtgv_InvoiceDetails = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ts_print_history = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_options = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ts_forfeit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_refund = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgv_Invoices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dtgv_Uplines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgv_InvoiceDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_search
        '
        Me.txt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txt_search.Location = New System.Drawing.Point(55, 50)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_search.Size = New System.Drawing.Size(274, 20)
        Me.txt_search.TabIndex = 4
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_add, Me.ToolStripSeparator1, Me.ts_edit, Me.ToolStripSeparator2, Me.ts_printings})
        Me.ToolStrip1.Location = New System.Drawing.Point(-7, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(236, 25)
        Me.ToolStrip1.TabIndex = 1
        '
        'ts_add
        '
        Me.ts_add.Image = CType(resources.GetObject("ts_add.Image"), System.Drawing.Image)
        Me.ts_add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_add.Name = "ts_add"
        Me.ts_add.Size = New System.Drawing.Size(61, 22)
        Me.ts_add.Text = "  Add  "
        '
        'ts_edit
        '
        Me.ts_edit.Image = CType(resources.GetObject("ts_edit.Image"), System.Drawing.Image)
        Me.ts_edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_edit.Name = "ts_edit"
        Me.ts_edit.Size = New System.Drawing.Size(59, 22)
        Me.ts_edit.Text = "  Edit  "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ts_printings
        '
        Me.ts_printings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_print_contract, Me.ts_print_payment_sched})
        Me.ts_printings.Image = CType(resources.GetObject("ts_printings.Image"), System.Drawing.Image)
        Me.ts_printings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_printings.Name = "ts_printings"
        Me.ts_printings.Size = New System.Drawing.Size(61, 22)
        Me.ts_printings.Text = "Print"
        '
        'ts_print_contract
        '
        Me.ts_print_contract.Image = CType(resources.GetObject("ts_print_contract.Image"), System.Drawing.Image)
        Me.ts_print_contract.Name = "ts_print_contract"
        Me.ts_print_contract.Size = New System.Drawing.Size(172, 22)
        Me.ts_print_contract.Text = "Contract"
        '
        'ts_print_payment_sched
        '
        Me.ts_print_payment_sched.Image = CType(resources.GetObject("ts_print_payment_sched.Image"), System.Drawing.Image)
        Me.ts_print_payment_sched.Name = "ts_print_payment_sched"
        Me.ts_print_payment_sched.Size = New System.Drawing.Size(172, 22)
        Me.ts_print_payment_sched.Text = "Payment Schedule"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(605, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(196, 33)
        Me.Panel1.TabIndex = 1
        '
        'dtgv_Invoices
        '
        Me.dtgv_Invoices.AllowUserToAddRows = False
        Me.dtgv_Invoices.AllowUserToDeleteRows = False
        Me.dtgv_Invoices.AllowUserToOrderColumns = True
        Me.dtgv_Invoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_Invoices.Location = New System.Drawing.Point(55, 77)
        Me.dtgv_Invoices.Name = "dtgv_Invoices"
        Me.dtgv_Invoices.ReadOnly = True
        Me.dtgv_Invoices.RowHeadersWidth = 40
        Me.dtgv_Invoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgv_Invoices.Size = New System.Drawing.Size(744, 237)
        Me.dtgv_Invoices.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_encodedBy)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_interest)
        Me.GroupBox1.Controls.Add(Me.txt_terms_payment)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(805, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 186)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Details"
        '
        'txt_encodedBy
        '
        Me.txt_encodedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.txt_encodedBy.Location = New System.Drawing.Point(18, 145)
        Me.txt_encodedBy.Name = "txt_encodedBy"
        Me.txt_encodedBy.ReadOnly = True
        Me.txt_encodedBy.Size = New System.Drawing.Size(240, 20)
        Me.txt_encodedBy.TabIndex = 96
        Me.txt_encodedBy.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label1.Location = New System.Drawing.Point(16, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Encoded By :"
        '
        'txt_interest
        '
        Me.txt_interest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.txt_interest.Location = New System.Drawing.Point(18, 92)
        Me.txt_interest.Name = "txt_interest"
        Me.txt_interest.ReadOnly = True
        Me.txt_interest.Size = New System.Drawing.Size(240, 20)
        Me.txt_interest.TabIndex = 91
        Me.txt_interest.TabStop = False
        '
        'txt_terms_payment
        '
        Me.txt_terms_payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.txt_terms_payment.Location = New System.Drawing.Point(19, 44)
        Me.txt_terms_payment.Name = "txt_terms_payment"
        Me.txt_terms_payment.ReadOnly = True
        Me.txt_terms_payment.Size = New System.Drawing.Size(239, 20)
        Me.txt_terms_payment.TabIndex = 90
        Me.txt_terms_payment.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label3.Location = New System.Drawing.Point(16, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 15)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Monthly Delay Interest :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label2.Location = New System.Drawing.Point(16, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 15)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Terms of Payment :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(805, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(276, 305)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Commission Details"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dtgv_Uplines)
        Me.Panel3.Controls.Add(Me.txt_term_commission)
        Me.Panel3.Controls.Add(Me.txt_com_at_down)
        Me.Panel3.Controls.Add(Me.txt_com_percentage)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Panel3.Location = New System.Drawing.Point(4, 20)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(264, 279)
        Me.Panel3.TabIndex = 43
        '
        'dtgv_Uplines
        '
        Me.dtgv_Uplines.AllowUserToAddRows = False
        Me.dtgv_Uplines.AllowUserToDeleteRows = False
        Me.dtgv_Uplines.AllowUserToResizeColumns = False
        Me.dtgv_Uplines.AllowUserToResizeRows = False
        Me.dtgv_Uplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_Uplines.Location = New System.Drawing.Point(8, 115)
        Me.dtgv_Uplines.Name = "dtgv_Uplines"
        Me.dtgv_Uplines.ReadOnly = True
        Me.dtgv_Uplines.RowHeadersVisible = False
        Me.dtgv_Uplines.Size = New System.Drawing.Size(253, 157)
        Me.dtgv_Uplines.TabIndex = 114
        Me.dtgv_Uplines.TabStop = False
        '
        'txt_term_commission
        '
        Me.txt_term_commission.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.txt_term_commission.Location = New System.Drawing.Point(181, 65)
        Me.txt_term_commission.Name = "txt_term_commission"
        Me.txt_term_commission.ReadOnly = True
        Me.txt_term_commission.Size = New System.Drawing.Size(80, 20)
        Me.txt_term_commission.TabIndex = 106
        Me.txt_term_commission.TabStop = False
        '
        'txt_com_at_down
        '
        Me.txt_com_at_down.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.txt_com_at_down.Location = New System.Drawing.Point(181, 36)
        Me.txt_com_at_down.Name = "txt_com_at_down"
        Me.txt_com_at_down.ReadOnly = True
        Me.txt_com_at_down.Size = New System.Drawing.Size(80, 20)
        Me.txt_com_at_down.TabIndex = 105
        Me.txt_com_at_down.TabStop = False
        '
        'txt_com_percentage
        '
        Me.txt_com_percentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.txt_com_percentage.Location = New System.Drawing.Point(181, 8)
        Me.txt_com_percentage.Name = "txt_com_percentage"
        Me.txt_com_percentage.ReadOnly = True
        Me.txt_com_percentage.Size = New System.Drawing.Size(80, 20)
        Me.txt_com_percentage.TabIndex = 104
        Me.txt_com_percentage.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label5.Location = New System.Drawing.Point(6, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 15)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Terms of Commission :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label6.Location = New System.Drawing.Point(6, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 15)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Commission at Downpayment:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label11.Location = New System.Drawing.Point(6, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 15)
        Me.Label11.TabIndex = 115
        Me.Label11.Text = "Agent(s) :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label7.Location = New System.Drawing.Point(6, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 15)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "Commission Percentage :"
        '
        'dtgv_InvoiceDetails
        '
        Me.dtgv_InvoiceDetails.AllowUserToAddRows = False
        Me.dtgv_InvoiceDetails.AllowUserToDeleteRows = False
        Me.dtgv_InvoiceDetails.AllowUserToOrderColumns = True
        Me.dtgv_InvoiceDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgv_InvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_InvoiceDetails.Location = New System.Drawing.Point(55, 354)
        Me.dtgv_InvoiceDetails.Name = "dtgv_InvoiceDetails"
        Me.dtgv_InvoiceDetails.ReadOnly = True
        Me.dtgv_InvoiceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgv_InvoiceDetails.Size = New System.Drawing.Size(744, 231)
        Me.dtgv_InvoiceDetails.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(51, 332)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 24)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Invoice Details"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ToolStrip2)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Location = New System.Drawing.Point(596, 320)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(203, 33)
        Me.Panel2.TabIndex = 3
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_print_history, Me.ToolStripSeparator3, Me.ts_options})
        Me.ToolStrip2.Location = New System.Drawing.Point(-7, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(211, 25)
        Me.ToolStrip2.TabIndex = 1
        '
        'ts_print_history
        '
        Me.ts_print_history.Image = CType(resources.GetObject("ts_print_history.Image"), System.Drawing.Image)
        Me.ts_print_history.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_print_history.Name = "ts_print_history"
        Me.ts_print_history.Size = New System.Drawing.Size(115, 22)
        Me.ts_print_history.Text = "Payment History"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ts_options
        '
        Me.ts_options.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_forfeit, Me.ts_refund})
        Me.ts_options.Image = CType(resources.GetObject("ts_options.Image"), System.Drawing.Image)
        Me.ts_options.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_options.Name = "ts_options"
        Me.ts_options.Size = New System.Drawing.Size(78, 22)
        Me.ts_options.Text = "Options"
        '
        'ts_forfeit
        '
        Me.ts_forfeit.Image = CType(resources.GetObject("ts_forfeit.Image"), System.Drawing.Image)
        Me.ts_forfeit.Name = "ts_forfeit"
        Me.ts_forfeit.Size = New System.Drawing.Size(175, 22)
        Me.ts_forfeit.Text = "Forfeit"
        '
        'ts_refund
        '
        Me.ts_refund.Image = CType(resources.GetObject("ts_refund.Image"), System.Drawing.Image)
        Me.ts_refund.Name = "ts_refund"
        Me.ts_refund.Size = New System.Drawing.Size(175, 22)
        Me.ts_refund.Text = "Forfeit with Refund"
        '
        'Invoices
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1138, 597)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dtgv_InvoiceDetails)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtgv_Invoices)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Invoices"
        Me.Text = "Invoices"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgv_Invoices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dtgv_Uplines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgv_InvoiceDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents ts_edit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_add As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtgv_Invoices As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtgv_InvoiceDetails As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_options As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ts_forfeit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_refund As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_printings As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ts_print_contract As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_print_payment_sched As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_print_history As System.Windows.Forms.ToolStripButton
    Friend WithEvents txt_encodedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_interest As System.Windows.Forms.TextBox
    Friend WithEvents txt_terms_payment As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dtgv_Uplines As System.Windows.Forms.DataGridView
    Friend WithEvents txt_term_commission As System.Windows.Forms.TextBox
    Friend WithEvents txt_com_at_down As System.Windows.Forms.TextBox
    Friend WithEvents txt_com_percentage As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
