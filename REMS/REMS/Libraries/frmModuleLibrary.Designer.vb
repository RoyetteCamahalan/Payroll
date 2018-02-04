<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModuleLibrary
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnpositive = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtgvModules = New System.Windows.Forms.DataGridView()
        Me.dtgv_header = New System.Windows.Forms.DataGridView()
        Me.selectall = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.modules = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.canadd = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.canedit = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.canview = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgvModules, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgv_header, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(640, 10)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(24, 20)
        Me.btnclose.TabIndex = 10
        Me.btnclose.Text = "X"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btnpositive
        '
        Me.btnpositive.BackColor = System.Drawing.Color.SteelBlue
        Me.btnpositive.FlatAppearance.BorderSize = 0
        Me.btnpositive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnpositive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpositive.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnpositive.ForeColor = System.Drawing.Color.White
        Me.btnpositive.Location = New System.Drawing.Point(569, 492)
        Me.btnpositive.Name = "btnpositive"
        Me.btnpositive.Size = New System.Drawing.Size(80, 35)
        Me.btnpositive.TabIndex = 9
        Me.btnpositive.Text = "Update"
        Me.btnpositive.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(2, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(335, 22)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "Royette Camahalan-User Privileges"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.dtgvModules)
        Me.Panel2.Controls.Add(Me.dtgv_header)
        Me.Panel2.Controls.Add(Me.btnpositive)
        Me.Panel2.Location = New System.Drawing.Point(4, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(660, 535)
        Me.Panel2.TabIndex = 18
        '
        'dtgvModules
        '
        Me.dtgvModules.AllowUserToAddRows = False
        Me.dtgvModules.AllowUserToDeleteRows = False
        Me.dtgvModules.AllowUserToResizeColumns = False
        Me.dtgvModules.AllowUserToResizeRows = False
        Me.dtgvModules.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgvModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvModules.ColumnHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvModules.DefaultCellStyle = DataGridViewCellStyle1
        Me.dtgvModules.Location = New System.Drawing.Point(10, 63)
        Me.dtgvModules.Name = "dtgvModules"
        Me.dtgvModules.RowHeadersVisible = False
        Me.dtgvModules.RowTemplate.Height = 30
        Me.dtgvModules.Size = New System.Drawing.Size(639, 425)
        Me.dtgvModules.TabIndex = 11
        '
        'dtgv_header
        '
        Me.dtgv_header.AllowUserToAddRows = False
        Me.dtgv_header.AllowUserToDeleteRows = False
        Me.dtgv_header.AllowUserToResizeColumns = False
        Me.dtgv_header.AllowUserToResizeRows = False
        Me.dtgv_header.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgv_header.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv_header.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgv_header.ColumnHeadersHeight = 19
        Me.dtgv_header.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgv_header.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.selectall, Me.modules, Me.canadd, Me.canedit, Me.canview})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgv_header.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgv_header.Location = New System.Drawing.Point(10, 24)
        Me.dtgv_header.Name = "dtgv_header"
        Me.dtgv_header.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dtgv_header.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgv_header.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dtgv_header.RowTemplate.Height = 20
        Me.dtgv_header.Size = New System.Drawing.Size(639, 40)
        Me.dtgv_header.TabIndex = 10
        '
        'selectall
        '
        Me.selectall.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.selectall.HeaderText = "Select All"
        Me.selectall.Name = "selectall"
        '
        'modules
        '
        Me.modules.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.modules.HeaderText = ""
        Me.modules.Name = "modules"
        Me.modules.Width = 237
        '
        'canadd
        '
        Me.canadd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.canadd.HeaderText = "canadd"
        Me.canadd.Name = "canadd"
        '
        'canedit
        '
        Me.canedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.canedit.HeaderText = "canedit"
        Me.canedit.Name = "canedit"
        '
        'canview
        '
        Me.canview.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.canview.HeaderText = "canview"
        Me.canview.Name = "canview"
        '
        'frmModuleLibrary
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(668, 582)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmModuleLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmployeeLibrary"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dtgvModules, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgv_header, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnpositive As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtgvModules As System.Windows.Forms.DataGridView
    Friend WithEvents dtgv_header As System.Windows.Forms.DataGridView
    Friend WithEvents selectall As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents modules As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents canadd As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents canedit As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents canview As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
