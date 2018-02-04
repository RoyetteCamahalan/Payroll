<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesReports
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.paneldaterange = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.dtpendingdate = New System.Windows.Forms.DateTimePicker()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dtpinitialdate = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmbPeriod = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cmbReport = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.crptviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.paneldaterange.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnReload)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.crptviewer)
        Me.Panel1.Location = New System.Drawing.Point(4, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1336, 662)
        Me.Panel1.TabIndex = 0
        '
        'btnReload
        '
        Me.btnReload.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReload.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnReload.ForeColor = System.Drawing.Color.White
        Me.btnReload.Location = New System.Drawing.Point(5, 612)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(265, 46)
        Me.btnReload.TabIndex = 234
        Me.btnReload.Text = "Reload"
        Me.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.paneldaterange)
        Me.Panel2.Location = New System.Drawing.Point(3, 116)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(265, 458)
        Me.Panel2.TabIndex = 192
        '
        'paneldaterange
        '
        Me.paneldaterange.BackColor = System.Drawing.Color.White
        Me.paneldaterange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneldaterange.Controls.Add(Me.Panel7)
        Me.paneldaterange.Controls.Add(Me.Panel6)
        Me.paneldaterange.Controls.Add(Me.Label18)
        Me.paneldaterange.Controls.Add(Me.Panel3)
        Me.paneldaterange.Controls.Add(Me.Label16)
        Me.paneldaterange.Controls.Add(Me.Button11)
        Me.paneldaterange.Controls.Add(Me.Label19)
        Me.paneldaterange.Dock = System.Windows.Forms.DockStyle.Top
        Me.paneldaterange.Location = New System.Drawing.Point(0, 0)
        Me.paneldaterange.Name = "paneldaterange"
        Me.paneldaterange.Size = New System.Drawing.Size(265, 129)
        Me.paneldaterange.TabIndex = 188
        Me.paneldaterange.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.dtpendingdate)
        Me.Panel7.Location = New System.Drawing.Point(62, 94)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(197, 27)
        Me.Panel7.TabIndex = 192
        '
        'dtpendingdate
        '
        Me.dtpendingdate.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpendingdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpendingdate.Location = New System.Drawing.Point(-1, 0)
        Me.dtpendingdate.Name = "dtpendingdate"
        Me.dtpendingdate.Size = New System.Drawing.Size(197, 25)
        Me.dtpendingdate.TabIndex = 176
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.dtpinitialdate)
        Me.Panel6.Location = New System.Drawing.Point(62, 64)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(197, 27)
        Me.Panel6.TabIndex = 191
        '
        'dtpinitialdate
        '
        Me.dtpinitialdate.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpinitialdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpinitialdate.Location = New System.Drawing.Point(-1, 0)
        Me.dtpinitialdate.Name = "dtpinitialdate"
        Me.dtpinitialdate.Size = New System.Drawing.Size(197, 25)
        Me.dtpinitialdate.TabIndex = 175
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(4, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 17)
        Me.Label18.TabIndex = 186
        Me.Label18.Text = "Period :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.cmbPeriod)
        Me.Panel3.Location = New System.Drawing.Point(63, 23)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(196, 27)
        Me.Panel3.TabIndex = 190
        '
        'cmbPeriod
        '
        Me.cmbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPeriod.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.cmbPeriod.FormattingEnabled = True
        Me.cmbPeriod.Items.AddRange(New Object() {"Today", "This Week-To-Date", "This Month-To-Date", "This Quarter-To-Date", "This Year-to-Date", "Custom Date"})
        Me.cmbPeriod.Location = New System.Drawing.Point(-1, 0)
        Me.cmbPeriod.Name = "cmbPeriod"
        Me.cmbPeriod.Size = New System.Drawing.Size(196, 25)
        Me.cmbPeriod.TabIndex = 174
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(31, 99)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 17)
        Me.Label16.TabIndex = 188
        Me.Label16.Text = "To :"
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button11.Location = New System.Drawing.Point(-1, -1)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(123, 31)
        Me.Button11.TabIndex = 193
        Me.Button11.Text = "Date Range"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(11, 69)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 17)
        Me.Label19.TabIndex = 187
        Me.Label19.Text = "From :"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.cmbReport)
        Me.Panel5.Location = New System.Drawing.Point(8, 83)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(260, 27)
        Me.Panel5.TabIndex = 191
        '
        'cmbReport
        '
        Me.cmbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReport.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.cmbReport.FormattingEnabled = True
        Me.cmbReport.Items.AddRange(New Object() {"Today", "This Week-To-Date", "This Month-To-Date", "This Quarter-To-Date", "This Year-to-Date", "Custom Date"})
        Me.cmbReport.Location = New System.Drawing.Point(-1, 0)
        Me.cmbReport.Name = "cmbReport"
        Me.cmbReport.Size = New System.Drawing.Size(260, 25)
        Me.cmbReport.TabIndex = 174
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Select Report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(52, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 26)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Sales Reports"
        '
        'crptviewer
        '
        Me.crptviewer.ActiveViewIndex = -1
        Me.crptviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crptviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crptviewer.Location = New System.Drawing.Point(274, 0)
        Me.crptviewer.Name = "crptviewer"
        Me.crptviewer.ShowGroupTreeButton = False
        Me.crptviewer.ShowParameterPanelButton = False
        Me.crptviewer.ShowRefreshButton = False
        Me.crptviewer.Size = New System.Drawing.Size(1060, 662)
        Me.crptviewer.TabIndex = 0
        Me.crptviewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(4, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(1328, 22)
        Me.lblTitle.TabIndex = 18
        Me.lblTitle.Text = "General Report Look Up"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(1316, 9)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(24, 20)
        Me.btnclose.TabIndex = 19
        Me.btnclose.Text = "X"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'frmSalesReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1344, 709)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSalesReports"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.paneldaterange.ResumeLayout(False)
        Me.paneldaterange.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents crptviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents cmbReport As System.Windows.Forms.ComboBox
    Friend WithEvents btnReload As System.Windows.Forms.Button
    Friend WithEvents paneldaterange As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents dtpendingdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents dtpinitialdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmbPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
