<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomDialog
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
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnpositive = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbMonthsDue = New System.Windows.Forms.ComboBox()
        Me.panelMonthsDue = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelagent = New System.Windows.Forms.Panel()
        Me.txtAgent = New System.Windows.Forms.TextBox()
        Me.pctrSearchAgent = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.panelagent.SuspendLayout()
        CType(Me.pctrSearchAgent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(374, 10)
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
        Me.btnpositive.Location = New System.Drawing.Point(306, 155)
        Me.btnpositive.Name = "btnpositive"
        Me.btnpositive.Size = New System.Drawing.Size(80, 35)
        Me.btnpositive.TabIndex = 9
        Me.btnpositive.Text = "Done"
        Me.btnpositive.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(24, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(351, 22)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "Title"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.panelagent)
        Me.Panel2.Controls.Add(Me.cmbMonthsDue)
        Me.Panel2.Controls.Add(Me.panelMonthsDue)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnpositive)
        Me.Panel2.Location = New System.Drawing.Point(4, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(394, 198)
        Me.Panel2.TabIndex = 18
        '
        'cmbMonthsDue
        '
        Me.cmbMonthsDue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonthsDue.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.cmbMonthsDue.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.cmbMonthsDue.FormattingEnabled = True
        Me.cmbMonthsDue.Items.AddRange(New Object() {"One(1) Month and Up", "Two(2) Months and Up", "Three(3) Months and Up", "Four(4) Months and Up", "Five(5) Months and Up"})
        Me.cmbMonthsDue.Location = New System.Drawing.Point(37, 51)
        Me.cmbMonthsDue.Name = "cmbMonthsDue"
        Me.cmbMonthsDue.Size = New System.Drawing.Size(318, 25)
        Me.cmbMonthsDue.TabIndex = 17
        '
        'panelMonthsDue
        '
        Me.panelMonthsDue.BackColor = System.Drawing.Color.White
        Me.panelMonthsDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelMonthsDue.Location = New System.Drawing.Point(36, 50)
        Me.panelMonthsDue.Name = "panelMonthsDue"
        Me.panelMonthsDue.Size = New System.Drawing.Size(320, 27)
        Me.panelMonthsDue.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Select No. of Months Due"
        '
        'panelagent
        '
        Me.panelagent.BackColor = System.Drawing.Color.White
        Me.panelagent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelagent.Controls.Add(Me.txtAgent)
        Me.panelagent.Controls.Add(Me.pctrSearchAgent)
        Me.panelagent.Location = New System.Drawing.Point(37, 111)
        Me.panelagent.Name = "panelagent"
        Me.panelagent.Size = New System.Drawing.Size(318, 29)
        Me.panelagent.TabIndex = 221
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
        Me.txtAgent.Size = New System.Drawing.Size(281, 19)
        Me.txtAgent.TabIndex = 179
        Me.txtAgent.Text = "All"
        '
        'pctrSearchAgent
        '
        Me.pctrSearchAgent.BackColor = System.Drawing.Color.White
        Me.pctrSearchAgent.Image = Global.IRES.My.Resources.Resources.search_glyph
        Me.pctrSearchAgent.Location = New System.Drawing.Point(292, 1)
        Me.pctrSearchAgent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pctrSearchAgent.Name = "pctrSearchAgent"
        Me.pctrSearchAgent.Size = New System.Drawing.Size(24, 24)
        Me.pctrSearchAgent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrSearchAgent.TabIndex = 184
        Me.pctrSearchAgent.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(34, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 222
        Me.Label1.Text = "Select Agent"
        '
        'frmCustomDialog
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(402, 245)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCustomDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmployeeLibrary"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelagent.ResumeLayout(False)
        Me.panelagent.PerformLayout()
        CType(Me.pctrSearchAgent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnpositive As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panelMonthsDue As System.Windows.Forms.Panel
    Friend WithEvents cmbMonthsDue As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panelagent As System.Windows.Forms.Panel
    Friend WithEvents txtAgent As System.Windows.Forms.TextBox
    Friend WithEvents pctrSearchAgent As System.Windows.Forms.PictureBox
End Class
