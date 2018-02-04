<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportsform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reportsform))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.dtgvvouchers = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbagent = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_agent2 = New System.Windows.Forms.ComboBox()
        Me.rdbtn_property = New System.Windows.Forms.RadioButton()
        Me.rdbtn_customer = New System.Windows.Forms.RadioButton()
        Me.rdbtn_agent = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbproperty = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btn_view_available = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_forfeit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_details = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AllCommissionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndirectCustumersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LotsSoldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.dtgvvouchers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(280, 61)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(101, 20)
        Me.DateTimePicker1.TabIndex = 8
        Me.DateTimePicker1.Value = New Date(2014, 4, 1, 0, 0, 0, 0)
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(55, 61)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 6
        '
        'dtgvvouchers
        '
        Me.dtgvvouchers.AllowUserToAddRows = False
        Me.dtgvvouchers.AllowUserToDeleteRows = False
        Me.dtgvvouchers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgvvouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvvouchers.Location = New System.Drawing.Point(55, 87)
        Me.dtgvvouchers.Name = "dtgvvouchers"
        Me.dtgvvouchers.ReadOnly = True
        Me.dtgvvouchers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvvouchers.Size = New System.Drawing.Size(1024, 241)
        Me.dtgvvouchers.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(439, -16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Agent:"
        '
        'cmbagent
        '
        Me.cmbagent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbagent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbagent.FormattingEnabled = True
        Me.cmbagent.Location = New System.Drawing.Point(511, -22)
        Me.cmbagent.Name = "cmbagent"
        Me.cmbagent.Size = New System.Drawing.Size(236, 21)
        Me.cmbagent.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Filter By Agent:"
        '
        'cmb_agent2
        '
        Me.cmb_agent2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_agent2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_agent2.FormattingEnabled = True
        Me.cmb_agent2.Items.AddRange(New Object() {"All Agent"})
        Me.cmb_agent2.Location = New System.Drawing.Point(135, 116)
        Me.cmb_agent2.Name = "cmb_agent2"
        Me.cmb_agent2.Size = New System.Drawing.Size(208, 21)
        Me.cmb_agent2.TabIndex = 38
        '
        'rdbtn_property
        '
        Me.rdbtn_property.AutoSize = True
        Me.rdbtn_property.Location = New System.Drawing.Point(248, 155)
        Me.rdbtn_property.Name = "rdbtn_property"
        Me.rdbtn_property.Size = New System.Drawing.Size(64, 17)
        Me.rdbtn_property.TabIndex = 37
        Me.rdbtn_property.Text = "Property"
        Me.rdbtn_property.UseVisualStyleBackColor = True
        '
        'rdbtn_customer
        '
        Me.rdbtn_customer.AutoSize = True
        Me.rdbtn_customer.Location = New System.Drawing.Point(173, 155)
        Me.rdbtn_customer.Name = "rdbtn_customer"
        Me.rdbtn_customer.Size = New System.Drawing.Size(69, 17)
        Me.rdbtn_customer.TabIndex = 36
        Me.rdbtn_customer.Text = "Customer"
        Me.rdbtn_customer.UseVisualStyleBackColor = True
        '
        'rdbtn_agent
        '
        Me.rdbtn_agent.AutoSize = True
        Me.rdbtn_agent.Checked = True
        Me.rdbtn_agent.Location = New System.Drawing.Point(110, 155)
        Me.rdbtn_agent.Name = "rdbtn_agent"
        Me.rdbtn_agent.Size = New System.Drawing.Size(53, 17)
        Me.rdbtn_agent.TabIndex = 35
        Me.rdbtn_agent.TabStop = True
        Me.rdbtn_agent.Text = "Agent"
        Me.rdbtn_agent.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Filter By Property:"
        '
        'cmbproperty
        '
        Me.cmbproperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbproperty.FormattingEnabled = True
        Me.cmbproperty.Location = New System.Drawing.Point(135, 73)
        Me.cmbproperty.Name = "cmbproperty"
        Me.cmbproperty.Size = New System.Drawing.Size(208, 21)
        Me.cmbproperty.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ToolStrip2)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(90, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(253, 33)
        Me.Panel1.TabIndex = 35
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_view_available, Me.ToolStripSeparator3, Me.btn_forfeit, Me.ToolStripSeparator4, Me.ToolStripButton3})
        Me.ToolStrip2.Location = New System.Drawing.Point(-7, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(257, 25)
        Me.ToolStrip2.TabIndex = 1
        '
        'btn_view_available
        '
        Me.btn_view_available.Image = CType(resources.GetObject("btn_view_available.Image"), System.Drawing.Image)
        Me.btn_view_available.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_view_available.Name = "btn_view_available"
        Me.btn_view_available.Size = New System.Drawing.Size(103, 22)
        Me.btn_view_available.Text = "Available Lots "
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btn_forfeit
        '
        Me.btn_forfeit.Image = CType(resources.GetObject("btn_forfeit.Image"), System.Drawing.Image)
        Me.btn_forfeit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_forfeit.Name = "btn_forfeit"
        Me.btn_forfeit.Size = New System.Drawing.Size(78, 22)
        Me.btn_forfeit.Text = "Forfeiting"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton3.Text = "Print"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Location = New System.Drawing.Point(830, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(237, 33)
        Me.Panel2.TabIndex = 36
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_details, Me.ToolStripSeparator1, Me.ToolStripButton5, Me.ToolStripSeparator2, Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(-7, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(253, 25)
        Me.ToolStrip1.TabIndex = 1
        '
        'btn_details
        '
        Me.btn_details.Image = CType(resources.GetObject("btn_details.Image"), System.Drawing.Image)
        Me.btn_details.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_details.Name = "btn_details"
        Me.btn_details.Size = New System.Drawing.Size(62, 22)
        Me.btn_details.Text = "Details"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(138, 22)
        Me.ToolStripButton5.Text = "Payable Commission"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllCommissionToolStripMenuItem, Me.DirectCustomersToolStripMenuItem, Me.IndirectCustumersToolStripMenuItem, Me.LotsSoldToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        '
        'AllCommissionToolStripMenuItem
        '
        Me.AllCommissionToolStripMenuItem.Name = "AllCommissionToolStripMenuItem"
        Me.AllCommissionToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.AllCommissionToolStripMenuItem.Text = "All Commission"
        '
        'DirectCustomersToolStripMenuItem
        '
        Me.DirectCustomersToolStripMenuItem.Name = "DirectCustomersToolStripMenuItem"
        Me.DirectCustomersToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DirectCustomersToolStripMenuItem.Text = "Direct Customers"
        '
        'IndirectCustumersToolStripMenuItem
        '
        Me.IndirectCustumersToolStripMenuItem.Name = "IndirectCustumersToolStripMenuItem"
        Me.IndirectCustumersToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.IndirectCustumersToolStripMenuItem.Text = "Indirect Custumers"
        '
        'LotsSoldToolStripMenuItem
        '
        Me.LotsSoldToolStripMenuItem.Name = "LotsSoldToolStripMenuItem"
        Me.LotsSoldToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.LotsSoldToolStripMenuItem.Text = "Lots Sold"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbproperty)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.rdbtn_property)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.rdbtn_customer)
        Me.GroupBox2.Controls.Add(Me.cmb_agent2)
        Me.GroupBox2.Controls.Add(Me.rdbtn_agent)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(55, 351)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(355, 201)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        '
        'reportsform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 597)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.dtgvvouchers)
        Me.Controls.Add(Me.cmbagent)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reportsform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reportsform"
        CType(Me.dtgvvouchers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbagent As System.Windows.Forms.ComboBox
    Friend WithEvents dtgvvouchers As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbproperty As System.Windows.Forms.ComboBox
    Friend WithEvents rdbtn_property As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtn_customer As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtn_agent As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_agent2 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_view_available As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_forfeit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_details As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents AllCommissionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DirectCustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndirectCustumersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LotsSoldToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
