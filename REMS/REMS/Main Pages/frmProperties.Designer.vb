<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProperties
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProperties))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelpassword = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dgvmain = New System.Windows.Forms.DataGridView()
        Me.lblshowing = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnMenuLots = New System.Windows.Forms.Button()
        Me.btnMenuProperties = New System.Windows.Forms.Button()
        Me.panelproperty = New System.Windows.Forms.Panel()
        Me.panellots = New System.Windows.Forms.Panel()
        Me.lblproperty = New System.Windows.Forms.Label()
        Me.panelpropertycmb = New System.Windows.Forms.Panel()
        Me.cmbproperties = New System.Windows.Forms.ComboBox()
        Me.btnMenuType = New System.Windows.Forms.Button()
        Me.paneltype = New System.Windows.Forms.Panel()
        Me.panelpassword.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvmain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelpropertycmb.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelpassword
        '
        Me.panelpassword.BackColor = System.Drawing.Color.White
        Me.panelpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelpassword.Controls.Add(Me.txtSearch)
        Me.panelpassword.Controls.Add(Me.PictureBox2)
        Me.panelpassword.Location = New System.Drawing.Point(806, 71)
        Me.panelpassword.Name = "panelpassword"
        Me.panelpassword.Size = New System.Drawing.Size(274, 36)
        Me.panelpassword.TabIndex = 9
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(3, 8)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(235, 19)
        Me.txtSearch.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(241, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(742, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 18)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Search :"
        '
        'dgvmain
        '
        Me.dgvmain.AllowUserToAddRows = False
        Me.dgvmain.AllowUserToDeleteRows = False
        Me.dgvmain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvmain.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvmain.Location = New System.Drawing.Point(37, 128)
        Me.dgvmain.Name = "dgvmain"
        Me.dgvmain.ReadOnly = True
        Me.dgvmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvmain.Size = New System.Drawing.Size(1041, 387)
        Me.dgvmain.TabIndex = 35
        '
        'lblshowing
        '
        Me.lblshowing.AutoSize = True
        Me.lblshowing.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblshowing.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblshowing.Location = New System.Drawing.Point(34, 518)
        Me.lblshowing.Name = "lblshowing"
        Me.lblshowing.Size = New System.Drawing.Size(146, 16)
        Me.lblshowing.TabIndex = 36
        Me.lblshowing.Text = "Showing top 100 rows"
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Peru
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Image)
        Me.btnView.Location = New System.Drawing.Point(983, 12)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(97, 41)
        Me.btnView.TabIndex = 37
        Me.btnView.Text = " View"
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(777, 12)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(97, 41)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = " Add New"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(880, 12)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(97, 41)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "  Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnMenuLots
        '
        Me.btnMenuLots.BackColor = System.Drawing.Color.White
        Me.btnMenuLots.FlatAppearance.BorderSize = 0
        Me.btnMenuLots.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnMenuLots.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnMenuLots.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnMenuLots.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuLots.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenuLots.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnMenuLots.Location = New System.Drawing.Point(37, 12)
        Me.btnMenuLots.Name = "btnMenuLots"
        Me.btnMenuLots.Size = New System.Drawing.Size(104, 31)
        Me.btnMenuLots.TabIndex = 38
        Me.btnMenuLots.Text = "Lots"
        Me.btnMenuLots.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMenuLots.UseVisualStyleBackColor = False
        '
        'btnMenuProperties
        '
        Me.btnMenuProperties.BackColor = System.Drawing.Color.White
        Me.btnMenuProperties.FlatAppearance.BorderSize = 0
        Me.btnMenuProperties.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnMenuProperties.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnMenuProperties.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnMenuProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuProperties.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenuProperties.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnMenuProperties.Location = New System.Drawing.Point(153, 12)
        Me.btnMenuProperties.Name = "btnMenuProperties"
        Me.btnMenuProperties.Size = New System.Drawing.Size(104, 31)
        Me.btnMenuProperties.TabIndex = 39
        Me.btnMenuProperties.Text = "Properties"
        Me.btnMenuProperties.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMenuProperties.UseVisualStyleBackColor = False
        '
        'panelproperty
        '
        Me.panelproperty.BackColor = System.Drawing.Color.SteelBlue
        Me.panelproperty.Location = New System.Drawing.Point(148, 6)
        Me.panelproperty.Name = "panelproperty"
        Me.panelproperty.Size = New System.Drawing.Size(114, 4)
        Me.panelproperty.TabIndex = 40
        Me.panelproperty.Visible = False
        '
        'panellots
        '
        Me.panellots.BackColor = System.Drawing.Color.SteelBlue
        Me.panellots.Location = New System.Drawing.Point(32, 6)
        Me.panellots.Name = "panellots"
        Me.panellots.Size = New System.Drawing.Size(114, 4)
        Me.panellots.TabIndex = 41
        Me.panellots.Visible = False
        '
        'lblproperty
        '
        Me.lblproperty.AutoSize = True
        Me.lblproperty.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblproperty.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblproperty.Location = New System.Drawing.Point(30, 100)
        Me.lblproperty.Name = "lblproperty"
        Me.lblproperty.Size = New System.Drawing.Size(136, 19)
        Me.lblproperty.TabIndex = 42
        Me.lblproperty.Text = "Select Property :"
        '
        'panelpropertycmb
        '
        Me.panelpropertycmb.BackColor = System.Drawing.Color.White
        Me.panelpropertycmb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelpropertycmb.Controls.Add(Me.cmbproperties)
        Me.panelpropertycmb.Location = New System.Drawing.Point(168, 95)
        Me.panelpropertycmb.Name = "panelpropertycmb"
        Me.panelpropertycmb.Size = New System.Drawing.Size(227, 27)
        Me.panelpropertycmb.TabIndex = 43
        '
        'cmbproperties
        '
        Me.cmbproperties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbproperties.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.cmbproperties.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.cmbproperties.FormattingEnabled = True
        Me.cmbproperties.Location = New System.Drawing.Point(-1, 0)
        Me.cmbproperties.Name = "cmbproperties"
        Me.cmbproperties.Size = New System.Drawing.Size(227, 25)
        Me.cmbproperties.TabIndex = 0
        '
        'btnMenuType
        '
        Me.btnMenuType.BackColor = System.Drawing.Color.White
        Me.btnMenuType.FlatAppearance.BorderSize = 0
        Me.btnMenuType.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnMenuType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnMenuType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnMenuType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuType.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenuType.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnMenuType.Location = New System.Drawing.Point(269, 12)
        Me.btnMenuType.Name = "btnMenuType"
        Me.btnMenuType.Size = New System.Drawing.Size(104, 31)
        Me.btnMenuType.TabIndex = 44
        Me.btnMenuType.Text = "Type/Model"
        Me.btnMenuType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMenuType.UseVisualStyleBackColor = False
        '
        'paneltype
        '
        Me.paneltype.BackColor = System.Drawing.Color.SteelBlue
        Me.paneltype.Location = New System.Drawing.Point(264, 6)
        Me.paneltype.Name = "paneltype"
        Me.paneltype.Size = New System.Drawing.Size(114, 4)
        Me.paneltype.TabIndex = 45
        Me.paneltype.Visible = False
        '
        'frmProperties
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1114, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnMenuType)
        Me.Controls.Add(Me.paneltype)
        Me.Controls.Add(Me.panelpropertycmb)
        Me.Controls.Add(Me.lblproperty)
        Me.Controls.Add(Me.panellots)
        Me.Controls.Add(Me.btnMenuProperties)
        Me.Controls.Add(Me.btnMenuLots)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.lblshowing)
        Me.Controls.Add(Me.dgvmain)
        Me.Controls.Add(Me.panelpassword)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.panelproperty)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProperties"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmReservations"
        Me.panelpassword.ResumeLayout(False)
        Me.panelpassword.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvmain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelpropertycmb.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents panelpassword As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dgvmain As System.Windows.Forms.DataGridView
    Friend WithEvents lblshowing As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnMenuLots As System.Windows.Forms.Button
    Friend WithEvents btnMenuProperties As System.Windows.Forms.Button
    Friend WithEvents panelproperty As System.Windows.Forms.Panel
    Friend WithEvents panellots As System.Windows.Forms.Panel
    Friend WithEvents lblproperty As System.Windows.Forms.Label
    Friend WithEvents panelpropertycmb As System.Windows.Forms.Panel
    Friend WithEvents cmbproperties As System.Windows.Forms.ComboBox
    Friend WithEvents btnMenuType As System.Windows.Forms.Button
    Friend WithEvents paneltype As System.Windows.Forms.Panel
End Class
