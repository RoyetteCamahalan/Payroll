<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdatePassword
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
        Me.panelconfirm = New System.Windows.Forms.Panel()
        Me.txtconfirmpword = New System.Windows.Forms.TextBox()
        Me.panelnewpword = New System.Windows.Forms.Panel()
        Me.txtnewpword = New System.Windows.Forms.TextBox()
        Me.paneloldpassword = New System.Windows.Forms.Panel()
        Me.txtoldpassword = New System.Windows.Forms.TextBox()
        Me.lblconfirm = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.panelconfirm.SuspendLayout()
        Me.panelnewpword.SuspendLayout()
        Me.paneloldpassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(413, 10)
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
        Me.btnpositive.Location = New System.Drawing.Point(294, 194)
        Me.btnpositive.Name = "btnpositive"
        Me.btnpositive.Size = New System.Drawing.Size(132, 35)
        Me.btnpositive.TabIndex = 9
        Me.btnpositive.Text = "Update Password"
        Me.btnpositive.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(2, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(180, 22)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "Change Password"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.panelconfirm)
        Me.Panel2.Controls.Add(Me.panelnewpword)
        Me.Panel2.Controls.Add(Me.paneloldpassword)
        Me.Panel2.Controls.Add(Me.lblconfirm)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.btnpositive)
        Me.Panel2.Location = New System.Drawing.Point(4, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(434, 237)
        Me.Panel2.TabIndex = 18
        '
        'panelconfirm
        '
        Me.panelconfirm.BackColor = System.Drawing.Color.White
        Me.panelconfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelconfirm.Controls.Add(Me.txtconfirmpword)
        Me.panelconfirm.Location = New System.Drawing.Point(64, 141)
        Me.panelconfirm.Name = "panelconfirm"
        Me.panelconfirm.Size = New System.Drawing.Size(320, 29)
        Me.panelconfirm.TabIndex = 8
        '
        'txtconfirmpword
        '
        Me.txtconfirmpword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtconfirmpword.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtconfirmpword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtconfirmpword.Location = New System.Drawing.Point(3, 4)
        Me.txtconfirmpword.Name = "txtconfirmpword"
        Me.txtconfirmpword.Size = New System.Drawing.Size(312, 19)
        Me.txtconfirmpword.TabIndex = 9
        Me.txtconfirmpword.UseSystemPasswordChar = True
        '
        'panelnewpword
        '
        Me.panelnewpword.BackColor = System.Drawing.Color.White
        Me.panelnewpword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelnewpword.Controls.Add(Me.txtnewpword)
        Me.panelnewpword.Location = New System.Drawing.Point(64, 92)
        Me.panelnewpword.Name = "panelnewpword"
        Me.panelnewpword.Size = New System.Drawing.Size(320, 29)
        Me.panelnewpword.TabIndex = 7
        '
        'txtnewpword
        '
        Me.txtnewpword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnewpword.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtnewpword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtnewpword.Location = New System.Drawing.Point(3, 4)
        Me.txtnewpword.Name = "txtnewpword"
        Me.txtnewpword.Size = New System.Drawing.Size(312, 19)
        Me.txtnewpword.TabIndex = 8
        Me.txtnewpword.UseSystemPasswordChar = True
        '
        'paneloldpassword
        '
        Me.paneloldpassword.BackColor = System.Drawing.Color.White
        Me.paneloldpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneloldpassword.Controls.Add(Me.txtoldpassword)
        Me.paneloldpassword.Location = New System.Drawing.Point(64, 38)
        Me.paneloldpassword.Name = "paneloldpassword"
        Me.paneloldpassword.Size = New System.Drawing.Size(320, 29)
        Me.paneloldpassword.TabIndex = 6
        '
        'txtoldpassword
        '
        Me.txtoldpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtoldpassword.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtoldpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtoldpassword.Location = New System.Drawing.Point(3, 4)
        Me.txtoldpassword.Name = "txtoldpassword"
        Me.txtoldpassword.Size = New System.Drawing.Size(312, 19)
        Me.txtoldpassword.TabIndex = 7
        Me.txtoldpassword.UseSystemPasswordChar = True
        '
        'lblconfirm
        '
        Me.lblconfirm.AutoSize = True
        Me.lblconfirm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblconfirm.Location = New System.Drawing.Point(61, 126)
        Me.lblconfirm.Name = "lblconfirm"
        Me.lblconfirm.Size = New System.Drawing.Size(155, 16)
        Me.lblconfirm.TabIndex = 31
        Me.lblconfirm.Text = "Confirm New Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(60, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "New Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(60, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Old Password"
        '
        'frmUpdatePassword
        '
        Me.AcceptButton = Me.btnpositive
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(442, 284)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmUpdatePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmployeeLibrary"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelconfirm.ResumeLayout(False)
        Me.panelconfirm.PerformLayout()
        Me.panelnewpword.ResumeLayout(False)
        Me.panelnewpword.PerformLayout()
        Me.paneloldpassword.ResumeLayout(False)
        Me.paneloldpassword.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnpositive As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents panelconfirm As System.Windows.Forms.Panel
    Friend WithEvents txtconfirmpword As System.Windows.Forms.TextBox
    Friend WithEvents panelnewpword As System.Windows.Forms.Panel
    Friend WithEvents txtnewpword As System.Windows.Forms.TextBox
    Friend WithEvents paneloldpassword As System.Windows.Forms.Panel
    Friend WithEvents txtoldpassword As System.Windows.Forms.TextBox
    Friend WithEvents lblconfirm As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
