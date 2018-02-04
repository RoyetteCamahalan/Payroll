<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.paneluname = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btn_showallagents = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnPrintPayableCommission = New System.Windows.Forms.Button()
        Me.panelagent = New System.Windows.Forms.Panel()
        Me.txtAgent = New System.Windows.Forms.TextBox()
        Me.pctrSearchAgent = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCommission = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.panelpropertycmb = New System.Windows.Forms.Panel()
        Me.cmbproperties = New System.Windows.Forms.ComboBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnAmountDue = New System.Windows.Forms.Button()
        Me.Button32 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.Button39 = New System.Windows.Forms.Button()
        Me.Button40 = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button41 = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.crtsales = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button37 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.paneluname.SuspendLayout()
        Me.panelagent.SuspendLayout()
        CType(Me.pctrSearchAgent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.panelpropertycmb.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        CType(Me.crtsales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'paneluname
        '
        Me.paneluname.BackColor = System.Drawing.Color.White
        Me.paneluname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneluname.Controls.Add(Me.Button7)
        Me.paneluname.Controls.Add(Me.btn_showallagents)
        Me.paneluname.Controls.Add(Me.Button1)
        Me.paneluname.Controls.Add(Me.Button5)
        Me.paneluname.Controls.Add(Me.Button4)
        Me.paneluname.Controls.Add(Me.Button3)
        Me.paneluname.Controls.Add(Me.Button2)
        Me.paneluname.Controls.Add(Me.btnPrintPayableCommission)
        Me.paneluname.Controls.Add(Me.panelagent)
        Me.paneluname.Controls.Add(Me.Label2)
        Me.paneluname.Controls.Add(Me.btnCommission)
        Me.paneluname.Location = New System.Drawing.Point(10, 204)
        Me.paneluname.Name = "paneluname"
        Me.paneluname.Size = New System.Drawing.Size(334, 329)
        Me.paneluname.TabIndex = 181
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.SteelBlue
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(14, 246)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(97, 68)
        Me.Button7.TabIndex = 228
        Me.Button7.Text = "Customer Collectable"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btn_showallagents
        '
        Me.btn_showallagents.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_showallagents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_showallagents.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_showallagents.ForeColor = System.Drawing.Color.White
        Me.btn_showallagents.Location = New System.Drawing.Point(220, 84)
        Me.btn_showallagents.Name = "btn_showallagents"
        Me.btn_showallagents.Size = New System.Drawing.Size(97, 68)
        Me.btn_showallagents.TabIndex = 227
        Me.btn_showallagents.Text = "Show All Agents"
        Me.btn_showallagents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_showallagents.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(220, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 68)
        Me.Button1.TabIndex = 222
        Me.Button1.Text = "Show Paid Commission"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.SteelBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(117, 246)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(97, 68)
        Me.Button5.TabIndex = 226
        Me.Button5.Text = "Lots Sold"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SteelBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(117, 164)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(97, 68)
        Me.Button4.TabIndex = 225
        Me.Button4.Text = "Indirect Customers"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SteelBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(14, 164)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 68)
        Me.Button3.TabIndex = 224
        Me.Button3.Text = "Direct Customers"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(117, 84)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 68)
        Me.Button2.TabIndex = 223
        Me.Button2.Text = "Show Downlines"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnPrintPayableCommission
        '
        Me.btnPrintPayableCommission.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPrintPayableCommission.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintPayableCommission.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnPrintPayableCommission.ForeColor = System.Drawing.Color.White
        Me.btnPrintPayableCommission.Location = New System.Drawing.Point(14, 84)
        Me.btnPrintPayableCommission.Name = "btnPrintPayableCommission"
        Me.btnPrintPayableCommission.Size = New System.Drawing.Size(97, 68)
        Me.btnPrintPayableCommission.TabIndex = 221
        Me.btnPrintPayableCommission.Text = "Payable Commission"
        Me.btnPrintPayableCommission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrintPayableCommission.UseVisualStyleBackColor = False
        '
        'panelagent
        '
        Me.panelagent.BackColor = System.Drawing.Color.White
        Me.panelagent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelagent.Controls.Add(Me.txtAgent)
        Me.panelagent.Controls.Add(Me.pctrSearchAgent)
        Me.panelagent.Location = New System.Drawing.Point(61, 39)
        Me.panelagent.Name = "panelagent"
        Me.panelagent.Size = New System.Drawing.Size(259, 29)
        Me.panelagent.TabIndex = 220
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
        Me.txtAgent.Size = New System.Drawing.Size(221, 19)
        Me.txtAgent.TabIndex = 179
        '
        'pctrSearchAgent
        '
        Me.pctrSearchAgent.BackColor = System.Drawing.Color.White
        Me.pctrSearchAgent.Image = Global.IRES.My.Resources.Resources.search_glyph
        Me.pctrSearchAgent.Location = New System.Drawing.Point(232, 1)
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
        Me.Label2.Location = New System.Drawing.Point(16, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 219
        Me.Label2.Text = "Agent:"
        '
        'btnCommission
        '
        Me.btnCommission.BackColor = System.Drawing.Color.White
        Me.btnCommission.FlatAppearance.BorderSize = 0
        Me.btnCommission.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnCommission.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnCommission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnCommission.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommission.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnCommission.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnCommission.Location = New System.Drawing.Point(2, 2)
        Me.btnCommission.Name = "btnCommission"
        Me.btnCommission.Size = New System.Drawing.Size(123, 31)
        Me.btnCommission.TabIndex = 39
        Me.btnCommission.Text = "Agent Reports"
        Me.btnCommission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCommission.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Button21)
        Me.Panel8.Controls.Add(Me.Button14)
        Me.Panel8.Controls.Add(Me.panelpropertycmb)
        Me.Panel8.Controls.Add(Me.Button13)
        Me.Panel8.Controls.Add(Me.Button16)
        Me.Panel8.Controls.Add(Me.Button19)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.Button20)
        Me.Panel8.Location = New System.Drawing.Point(350, 204)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(334, 329)
        Me.Panel8.TabIndex = 188
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.SteelBlue
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button21.ForeColor = System.Drawing.Color.White
        Me.Button21.Location = New System.Drawing.Point(118, 164)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(97, 68)
        Me.Button21.TabIndex = 232
        Me.Button21.Text = "Show Forfeited"
        Me.Button21.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button21.UseVisualStyleBackColor = False
        '
        'panelpropertycmb
        '
        Me.panelpropertycmb.BackColor = System.Drawing.Color.White
        Me.panelpropertycmb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelpropertycmb.Controls.Add(Me.cmbproperties)
        Me.panelpropertycmb.Location = New System.Drawing.Point(74, 41)
        Me.panelpropertycmb.Name = "panelpropertycmb"
        Me.panelpropertycmb.Size = New System.Drawing.Size(243, 27)
        Me.panelpropertycmb.TabIndex = 229
        '
        'cmbproperties
        '
        Me.cmbproperties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbproperties.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.cmbproperties.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.cmbproperties.FormattingEnabled = True
        Me.cmbproperties.Location = New System.Drawing.Point(-1, 0)
        Me.cmbproperties.Name = "cmbproperties"
        Me.cmbproperties.Size = New System.Drawing.Size(243, 25)
        Me.cmbproperties.TabIndex = 0
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.SteelBlue
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button13.ForeColor = System.Drawing.Color.White
        Me.Button13.Location = New System.Drawing.Point(14, 164)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(97, 68)
        Me.Button13.TabIndex = 227
        Me.Button13.Text = "Show Paid"
        Me.Button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.SteelBlue
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button16.ForeColor = System.Drawing.Color.White
        Me.Button16.Location = New System.Drawing.Point(220, 84)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(97, 68)
        Me.Button16.TabIndex = 225
        Me.Button16.Text = "Show Invoiced"
        Me.Button16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 219
        Me.Label1.Text = "Property:"
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.White
        Me.Button20.FlatAppearance.BorderSize = 0
        Me.Button20.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Button20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button20.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Button20.Location = New System.Drawing.Point(2, 2)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(150, 31)
        Me.Button20.TabIndex = 39
        Me.Button20.Text = "Property Reports"
        Me.Button20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.btnAmountDue)
        Me.Panel9.Controls.Add(Me.Button32)
        Me.Panel9.Controls.Add(Me.Button22)
        Me.Panel9.Controls.Add(Me.Button23)
        Me.Panel9.Controls.Add(Me.Button24)
        Me.Panel9.Controls.Add(Me.Button25)
        Me.Panel9.Controls.Add(Me.Button26)
        Me.Panel9.Controls.Add(Me.Button28)
        Me.Panel9.Controls.Add(Me.Button29)
        Me.Panel9.Controls.Add(Me.Button30)
        Me.Panel9.Controls.Add(Me.Button31)
        Me.Panel9.Location = New System.Drawing.Point(690, 204)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(414, 193)
        Me.Panel9.TabIndex = 189
        '
        'btnAmountDue
        '
        Me.btnAmountDue.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAmountDue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAmountDue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAmountDue.ForeColor = System.Drawing.Color.White
        Me.btnAmountDue.Location = New System.Drawing.Point(3, 136)
        Me.btnAmountDue.Name = "btnAmountDue"
        Me.btnAmountDue.Size = New System.Drawing.Size(97, 46)
        Me.btnAmountDue.TabIndex = 234
        Me.btnAmountDue.Text = "Show Due Collectables"
        Me.btnAmountDue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAmountDue.UseVisualStyleBackColor = False
        '
        'Button32
        '
        Me.Button32.BackColor = System.Drawing.Color.SteelBlue
        Me.Button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button32.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button32.ForeColor = System.Drawing.Color.White
        Me.Button32.Location = New System.Drawing.Point(3, 84)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(97, 46)
        Me.Button32.TabIndex = 233
        Me.Button32.Text = "Show Bank To Bank"
        Me.Button32.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button32.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.SteelBlue
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button22.ForeColor = System.Drawing.Color.White
        Me.Button22.Location = New System.Drawing.Point(312, 84)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(97, 46)
        Me.Button22.TabIndex = 232
        Me.Button22.Text = "Show Sales Without Loan"
        Me.Button22.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.Color.SteelBlue
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button23.ForeColor = System.Drawing.Color.White
        Me.Button23.Location = New System.Drawing.Point(106, 84)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(97, 46)
        Me.Button23.TabIndex = 231
        Me.Button23.Text = "Show Forfeited"
        Me.Button23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button23.UseVisualStyleBackColor = False
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.Color.SteelBlue
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button24.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button24.ForeColor = System.Drawing.Color.White
        Me.Button24.Location = New System.Drawing.Point(209, 32)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(97, 46)
        Me.Button24.TabIndex = 230
        Me.Button24.Text = "Show Interest Charges"
        Me.Button24.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button24.UseVisualStyleBackColor = False
        '
        'Button25
        '
        Me.Button25.BackColor = System.Drawing.Color.SteelBlue
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button25.ForeColor = System.Drawing.Color.White
        Me.Button25.Location = New System.Drawing.Point(312, 136)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(97, 46)
        Me.Button25.TabIndex = 228
        Me.Button25.Text = "Show Sales With Loan"
        Me.Button25.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button25.UseVisualStyleBackColor = False
        '
        'Button26
        '
        Me.Button26.BackColor = System.Drawing.Color.SteelBlue
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button26.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button26.ForeColor = System.Drawing.Color.White
        Me.Button26.Location = New System.Drawing.Point(209, 84)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(97, 46)
        Me.Button26.TabIndex = 227
        Me.Button26.Text = "Show Forfeiting List"
        Me.Button26.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button26.UseVisualStyleBackColor = False
        '
        'Button28
        '
        Me.Button28.BackColor = System.Drawing.Color.SteelBlue
        Me.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button28.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button28.ForeColor = System.Drawing.Color.White
        Me.Button28.Location = New System.Drawing.Point(312, 32)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(97, 46)
        Me.Button28.TabIndex = 224
        Me.Button28.Text = "Sales Per Property"
        Me.Button28.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button28.UseVisualStyleBackColor = False
        '
        'Button29
        '
        Me.Button29.BackColor = System.Drawing.Color.SteelBlue
        Me.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button29.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button29.ForeColor = System.Drawing.Color.White
        Me.Button29.Location = New System.Drawing.Point(106, 32)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(97, 46)
        Me.Button29.TabIndex = 223
        Me.Button29.Text = "Refunded Sales"
        Me.Button29.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button29.UseVisualStyleBackColor = False
        '
        'Button30
        '
        Me.Button30.BackColor = System.Drawing.Color.SteelBlue
        Me.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button30.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button30.ForeColor = System.Drawing.Color.White
        Me.Button30.Location = New System.Drawing.Point(3, 32)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(97, 46)
        Me.Button30.TabIndex = 221
        Me.Button30.Text = "Collection Report"
        Me.Button30.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button30.UseVisualStyleBackColor = False
        '
        'Button31
        '
        Me.Button31.BackColor = System.Drawing.Color.White
        Me.Button31.FlatAppearance.BorderSize = 0
        Me.Button31.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Button31.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button31.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button31.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Button31.Location = New System.Drawing.Point(2, 2)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(162, 31)
        Me.Button31.TabIndex = 39
        Me.Button31.Text = "Sales and Expenses"
        Me.Button31.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button31.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.Button34)
        Me.Panel10.Controls.Add(Me.Button39)
        Me.Panel10.Controls.Add(Me.Button40)
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Controls.Add(Me.Label3)
        Me.Panel10.Controls.Add(Me.Button41)
        Me.Panel10.Location = New System.Drawing.Point(690, 403)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(414, 130)
        Me.Panel10.TabIndex = 190
        '
        'Button34
        '
        Me.Button34.BackColor = System.Drawing.Color.SteelBlue
        Me.Button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button34.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button34.ForeColor = System.Drawing.Color.White
        Me.Button34.Location = New System.Drawing.Point(294, 69)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(97, 46)
        Me.Button34.TabIndex = 227
        Me.Button34.Text = "Show Payments"
        Me.Button34.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button34.UseVisualStyleBackColor = False
        '
        'Button39
        '
        Me.Button39.BackColor = System.Drawing.Color.SteelBlue
        Me.Button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button39.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button39.ForeColor = System.Drawing.Color.White
        Me.Button39.Location = New System.Drawing.Point(162, 69)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(97, 46)
        Me.Button39.TabIndex = 223
        Me.Button39.Text = "Show Properties"
        Me.Button39.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button39.UseVisualStyleBackColor = False
        '
        'Button40
        '
        Me.Button40.BackColor = System.Drawing.Color.SteelBlue
        Me.Button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button40.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button40.ForeColor = System.Drawing.Color.White
        Me.Button40.Location = New System.Drawing.Point(28, 69)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(97, 46)
        Me.Button40.TabIndex = 221
        Me.Button40.Text = "Show Payable"
        Me.Button40.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button40.UseVisualStyleBackColor = False
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.PictureBox1)
        Me.Panel11.Controls.Add(Me.txtCustomer)
        Me.Panel11.Location = New System.Drawing.Point(80, 34)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(311, 29)
        Me.Panel11.TabIndex = 220
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.IRES.My.Resources.Resources.search_glyph
        Me.PictureBox1.Location = New System.Drawing.Point(283, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 184
        Me.PictureBox1.TabStop = False
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
        Me.txtCustomer.Size = New System.Drawing.Size(281, 19)
        Me.txtCustomer.TabIndex = 179
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 219
        Me.Label3.Text = "Customer:"
        '
        'Button41
        '
        Me.Button41.BackColor = System.Drawing.Color.White
        Me.Button41.FlatAppearance.BorderSize = 0
        Me.Button41.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Button41.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button41.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button41.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button41.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Button41.Location = New System.Drawing.Point(2, 2)
        Me.Button41.Name = "Button41"
        Me.Button41.Size = New System.Drawing.Size(150, 31)
        Me.Button41.TabIndex = 39
        Me.Button41.Text = "Customer Reports"
        Me.Button41.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button41.UseVisualStyleBackColor = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.crtsales)
        Me.Panel12.Controls.Add(Me.Button37)
        Me.Panel12.Location = New System.Drawing.Point(10, 12)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1094, 186)
        Me.Panel12.TabIndex = 191
        '
        'crtsales
        '
        ChartArea1.Name = "ChartArea1"
        Me.crtsales.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.crtsales.Legends.Add(Legend1)
        Me.crtsales.Location = New System.Drawing.Point(3, 28)
        Me.crtsales.Name = "crtsales"
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Color = System.Drawing.Color.SteelBlue
        Series1.Legend = "Legend1"
        Series1.LegendText = "Sales"
        Series1.Name = "srsSales"
        Series2.BorderWidth = 2
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Color = System.Drawing.Color.Firebrick
        Series2.Legend = "Legend1"
        Series2.LegendText = "Expenses"
        Series2.Name = "srsExpense"
        Me.crtsales.Series.Add(Series1)
        Me.crtsales.Series.Add(Series2)
        Me.crtsales.Size = New System.Drawing.Size(1086, 153)
        Me.crtsales.TabIndex = 40
        Me.crtsales.Text = "Chart1"
        '
        'Button37
        '
        Me.Button37.BackColor = System.Drawing.Color.White
        Me.Button37.FlatAppearance.BorderSize = 0
        Me.Button37.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Button37.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button37.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button37.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button37.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Button37.Location = New System.Drawing.Point(2, 2)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(140, 31)
        Me.Button37.TabIndex = 39
        Me.Button37.Text = "Sales Reports"
        Me.Button37.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button37.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.SteelBlue
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button14.ForeColor = System.Drawing.Color.White
        Me.Button14.Location = New System.Drawing.Point(118, 84)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(97, 68)
        Me.Button14.TabIndex = 230
        Me.Button14.Text = "Show Reserved"
        Me.Button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.SteelBlue
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button19.ForeColor = System.Drawing.Color.White
        Me.Button19.Location = New System.Drawing.Point(14, 84)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(97, 68)
        Me.Button19.TabIndex = 221
        Me.Button19.Text = "Show Available"
        Me.Button19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button19.UseVisualStyleBackColor = False
        '
        'frmReports
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1114, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.paneluname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmReservations"
        Me.paneluname.ResumeLayout(False)
        Me.paneluname.PerformLayout()
        Me.panelagent.ResumeLayout(False)
        Me.panelagent.PerformLayout()
        CType(Me.pctrSearchAgent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.panelpropertycmb.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        CType(Me.crtsales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents paneluname As System.Windows.Forms.Panel
    Friend WithEvents btnCommission As System.Windows.Forms.Button
    Friend WithEvents panelagent As System.Windows.Forms.Panel
    Friend WithEvents txtAgent As System.Windows.Forms.TextBox
    Friend WithEvents pctrSearchAgent As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPrintPayableCommission As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btn_showallagents As System.Windows.Forms.Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents panelpropertycmb As System.Windows.Forms.Panel
    Friend WithEvents cmbproperties As System.Windows.Forms.ComboBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents Button39 As System.Windows.Forms.Button
    Friend WithEvents Button40 As System.Windows.Forms.Button
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button41 As System.Windows.Forms.Button
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Button37 As System.Windows.Forms.Button
    Friend WithEvents crtsales As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnAmountDue As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
End Class
