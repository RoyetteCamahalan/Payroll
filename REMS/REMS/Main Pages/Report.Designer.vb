<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.pctr_searchagent = New System.Windows.Forms.PictureBox()
        Me.txt_agent = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btn_direct_cust = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnviewvoucherdetails = New System.Windows.Forms.Button()
        Me.dtgvvouchers = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_agent2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rdbtn_property = New System.Windows.Forms.RadioButton()
        Me.rdbtn_customer = New System.Windows.Forms.RadioButton()
        Me.rdbtn_agent = New System.Windows.Forms.RadioButton()
        Me.btn_viewcandidate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_display_available = New System.Windows.Forms.Button()
        Me.cmbproperty = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pctr_searchagent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvvouchers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_search)
        Me.GroupBox1.Controls.Add(Me.pctr_searchagent)
        Me.GroupBox1.Controls.Add(Me.txt_agent)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.btn_direct_cust)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btnviewvoucherdetails)
        Me.GroupBox1.Controls.Add(Me.dtgvvouchers)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 325)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COMMISSION"
        '
        'txt_search
        '
        Me.txt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txt_search.Location = New System.Drawing.Point(30, 56)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_search.Size = New System.Drawing.Size(203, 20)
        Me.txt_search.TabIndex = 156
        '
        'pctr_searchagent
        '
        Me.pctr_searchagent.Image = Global.IRES.My.Resources.Resources.search_glyph
        Me.pctr_searchagent.Location = New System.Drawing.Point(299, 26)
        Me.pctr_searchagent.Name = "pctr_searchagent"
        Me.pctr_searchagent.Size = New System.Drawing.Size(19, 18)
        Me.pctr_searchagent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctr_searchagent.TabIndex = 155
        Me.pctr_searchagent.TabStop = False
        '
        'txt_agent
        '
        Me.txt_agent.Location = New System.Drawing.Point(98, 25)
        Me.txt_agent.Name = "txt_agent"
        Me.txt_agent.ReadOnly = True
        Me.txt_agent.Size = New System.Drawing.Size(221, 20)
        Me.txt_agent.TabIndex = 154
        Me.txt_agent.TabStop = False
        '
        'Button7
        '
        Me.Button7.AutoEllipsis = True
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(327, 251)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(137, 37)
        Me.Button7.TabIndex = 33
        Me.Button7.Text = "Lots Sold"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btn_direct_cust
        '
        Me.btn_direct_cust.AutoEllipsis = True
        Me.btn_direct_cust.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_direct_cust.Location = New System.Drawing.Point(176, 251)
        Me.btn_direct_cust.Name = "btn_direct_cust"
        Me.btn_direct_cust.Size = New System.Drawing.Size(133, 37)
        Me.btn_direct_cust.TabIndex = 32
        Me.btn_direct_cust.Text = "Direct Customers"
        Me.btn_direct_cust.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.AutoEllipsis = True
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(30, 251)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(128, 37)
        Me.Button5.TabIndex = 31
        Me.Button5.Text = "Indirect Customers"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.AutoEllipsis = True
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(327, 203)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 37)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "All Commission"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoEllipsis = True
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(176, 203)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 37)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Payable Commission"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnviewvoucherdetails
        '
        Me.btnviewvoucherdetails.AutoEllipsis = True
        Me.btnviewvoucherdetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnviewvoucherdetails.Location = New System.Drawing.Point(30, 203)
        Me.btnviewvoucherdetails.Name = "btnviewvoucherdetails"
        Me.btnviewvoucherdetails.Size = New System.Drawing.Size(128, 37)
        Me.btnviewvoucherdetails.TabIndex = 28
        Me.btnviewvoucherdetails.Text = "View Details"
        Me.btnviewvoucherdetails.UseVisualStyleBackColor = False
        '
        'dtgvvouchers
        '
        Me.dtgvvouchers.AllowUserToAddRows = False
        Me.dtgvvouchers.AllowUserToDeleteRows = False
        Me.dtgvvouchers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgvvouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvvouchers.Location = New System.Drawing.Point(30, 78)
        Me.dtgvvouchers.Name = "dtgvvouchers"
        Me.dtgvvouchers.ReadOnly = True
        Me.dtgvvouchers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvvouchers.Size = New System.Drawing.Size(434, 119)
        Me.dtgvvouchers.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Agent:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmb_agent2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.rdbtn_property)
        Me.GroupBox2.Controls.Add(Me.rdbtn_customer)
        Me.GroupBox2.Controls.Add(Me.rdbtn_agent)
        Me.GroupBox2.Controls.Add(Me.btn_viewcandidate)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btn_display_available)
        Me.GroupBox2.Controls.Add(Me.cmbproperty)
        Me.GroupBox2.Location = New System.Drawing.Point(547, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(512, 393)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "No Date Range"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 153)
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
        Me.cmb_agent2.Location = New System.Drawing.Point(192, 153)
        Me.cmb_agent2.Name = "cmb_agent2"
        Me.cmb_agent2.Size = New System.Drawing.Size(208, 21)
        Me.cmb_agent2.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.AutoEllipsis = True
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(249, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 32)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Print Collectables"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'rdbtn_property
        '
        Me.rdbtn_property.AutoSize = True
        Me.rdbtn_property.Location = New System.Drawing.Point(314, 197)
        Me.rdbtn_property.Name = "rdbtn_property"
        Me.rdbtn_property.Size = New System.Drawing.Size(70, 19)
        Me.rdbtn_property.TabIndex = 37
        Me.rdbtn_property.Text = "Property"
        Me.rdbtn_property.UseVisualStyleBackColor = True
        '
        'rdbtn_customer
        '
        Me.rdbtn_customer.AutoSize = True
        Me.rdbtn_customer.Location = New System.Drawing.Point(239, 197)
        Me.rdbtn_customer.Name = "rdbtn_customer"
        Me.rdbtn_customer.Size = New System.Drawing.Size(78, 19)
        Me.rdbtn_customer.TabIndex = 36
        Me.rdbtn_customer.Text = "Customer"
        Me.rdbtn_customer.UseVisualStyleBackColor = True
        '
        'rdbtn_agent
        '
        Me.rdbtn_agent.AutoSize = True
        Me.rdbtn_agent.Checked = True
        Me.rdbtn_agent.Location = New System.Drawing.Point(176, 197)
        Me.rdbtn_agent.Name = "rdbtn_agent"
        Me.rdbtn_agent.Size = New System.Drawing.Size(56, 19)
        Me.rdbtn_agent.TabIndex = 35
        Me.rdbtn_agent.TabStop = True
        Me.rdbtn_agent.Text = "Agent"
        Me.rdbtn_agent.UseVisualStyleBackColor = True
        '
        'btn_viewcandidate
        '
        Me.btn_viewcandidate.AutoEllipsis = True
        Me.btn_viewcandidate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_viewcandidate.Location = New System.Drawing.Point(59, 220)
        Me.btn_viewcandidate.Name = "btn_viewcandidate"
        Me.btn_viewcandidate.Size = New System.Drawing.Size(174, 32)
        Me.btn_viewcandidate.TabIndex = 34
        Me.btn_viewcandidate.Text = "View Forfeiting Candidate"
        Me.btn_viewcandidate.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(82, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Sort Report by:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(66, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Filter By Property:"
        '
        'btn_display_available
        '
        Me.btn_display_available.AutoEllipsis = True
        Me.btn_display_available.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_display_available.Location = New System.Drawing.Point(157, 102)
        Me.btn_display_available.Name = "btn_display_available"
        Me.btn_display_available.Size = New System.Drawing.Size(165, 32)
        Me.btn_display_available.TabIndex = 31
        Me.btn_display_available.Text = "View Available Lot"
        Me.btn_display_available.UseVisualStyleBackColor = False
        '
        'cmbproperty
        '
        Me.cmbproperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbproperty.FormattingEnabled = True
        Me.cmbproperty.Location = New System.Drawing.Point(192, 62)
        Me.cmbproperty.Name = "cmbproperty"
        Me.cmbproperty.Size = New System.Drawing.Size(208, 21)
        Me.cmbproperty.TabIndex = 3
        '
        'Report
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1138, 597)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Report"
        Me.Text = "Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pctr_searchagent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvvouchers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btn_direct_cust As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnviewvoucherdetails As System.Windows.Forms.Button
    Friend WithEvents dtgvvouchers As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_agent2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents rdbtn_property As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtn_customer As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtn_agent As System.Windows.Forms.RadioButton
    Friend WithEvents btn_viewcandidate As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_display_available As System.Windows.Forms.Button
    Friend WithEvents cmbproperty As System.Windows.Forms.ComboBox
    Friend WithEvents txt_agent As System.Windows.Forms.TextBox
    Friend WithEvents pctr_searchagent As System.Windows.Forms.PictureBox
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
End Class
