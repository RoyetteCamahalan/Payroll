<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeLibrary
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
        Me.panelpword = New System.Windows.Forms.Panel()
        Me.txtpword = New System.Windows.Forms.TextBox()
        Me.paneluname = New System.Windows.Forms.Panel()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.lblconfirm = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.groupgender = New System.Windows.Forms.GroupBox()
        Me.rdfemale = New System.Windows.Forms.RadioButton()
        Me.rdmale = New System.Windows.Forms.RadioButton()
        Me.chkisadmin = New System.Windows.Forms.CheckBox()
        Me.chkisactive = New System.Windows.Forms.CheckBox()
        Me.panelmname = New System.Windows.Forms.Panel()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.panellname = New System.Windows.Forms.Panel()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.panelfname = New System.Windows.Forms.Panel()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.panelconfirm.SuspendLayout()
        Me.panelpword.SuspendLayout()
        Me.paneluname.SuspendLayout()
        Me.groupgender.SuspendLayout()
        Me.panelmname.SuspendLayout()
        Me.panellname.SuspendLayout()
        Me.panelfname.SuspendLayout()
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
        Me.btnpositive.Location = New System.Drawing.Point(346, 492)
        Me.btnpositive.Name = "btnpositive"
        Me.btnpositive.Size = New System.Drawing.Size(80, 35)
        Me.btnpositive.TabIndex = 9
        Me.btnpositive.Text = "Done"
        Me.btnpositive.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(2, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(188, 22)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "Add New Employee"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.panelconfirm)
        Me.Panel2.Controls.Add(Me.panelpword)
        Me.Panel2.Controls.Add(Me.paneluname)
        Me.Panel2.Controls.Add(Me.lblconfirm)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.groupgender)
        Me.Panel2.Controls.Add(Me.chkisadmin)
        Me.Panel2.Controls.Add(Me.chkisactive)
        Me.Panel2.Controls.Add(Me.panelmname)
        Me.Panel2.Controls.Add(Me.panellname)
        Me.Panel2.Controls.Add(Me.panelfname)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnpositive)
        Me.Panel2.Location = New System.Drawing.Point(4, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(434, 535)
        Me.Panel2.TabIndex = 18
        '
        'panelconfirm
        '
        Me.panelconfirm.BackColor = System.Drawing.Color.White
        Me.panelconfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelconfirm.Controls.Add(Me.txtconfirmpword)
        Me.panelconfirm.Location = New System.Drawing.Point(54, 438)
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
        'panelpword
        '
        Me.panelpword.BackColor = System.Drawing.Color.White
        Me.panelpword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelpword.Controls.Add(Me.txtpword)
        Me.panelpword.Location = New System.Drawing.Point(54, 389)
        Me.panelpword.Name = "panelpword"
        Me.panelpword.Size = New System.Drawing.Size(320, 29)
        Me.panelpword.TabIndex = 7
        '
        'txtpword
        '
        Me.txtpword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpword.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtpword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpword.Location = New System.Drawing.Point(3, 4)
        Me.txtpword.Name = "txtpword"
        Me.txtpword.Size = New System.Drawing.Size(312, 19)
        Me.txtpword.TabIndex = 8
        Me.txtpword.UseSystemPasswordChar = True
        '
        'paneluname
        '
        Me.paneluname.BackColor = System.Drawing.Color.White
        Me.paneluname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneluname.Controls.Add(Me.txtuname)
        Me.paneluname.Location = New System.Drawing.Point(54, 335)
        Me.paneluname.Name = "paneluname"
        Me.paneluname.Size = New System.Drawing.Size(320, 29)
        Me.paneluname.TabIndex = 6
        '
        'txtuname
        '
        Me.txtuname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtuname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtuname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtuname.Location = New System.Drawing.Point(3, 4)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(312, 19)
        Me.txtuname.TabIndex = 7
        '
        'lblconfirm
        '
        Me.lblconfirm.AutoSize = True
        Me.lblconfirm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblconfirm.Location = New System.Drawing.Point(51, 423)
        Me.lblconfirm.Name = "lblconfirm"
        Me.lblconfirm.Size = New System.Drawing.Size(123, 16)
        Me.lblconfirm.TabIndex = 31
        Me.lblconfirm.Text = "Confirm Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(50, 374)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(50, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "User Name"
        '
        'groupgender
        '
        Me.groupgender.Controls.Add(Me.rdfemale)
        Me.groupgender.Controls.Add(Me.rdmale)
        Me.groupgender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupgender.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.groupgender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.groupgender.Location = New System.Drawing.Point(54, 216)
        Me.groupgender.Name = "groupgender"
        Me.groupgender.Size = New System.Drawing.Size(320, 56)
        Me.groupgender.TabIndex = 3
        Me.groupgender.TabStop = False
        Me.groupgender.Text = "Gender"
        '
        'rdfemale
        '
        Me.rdfemale.AutoSize = True
        Me.rdfemale.Location = New System.Drawing.Point(167, 24)
        Me.rdfemale.Name = "rdfemale"
        Me.rdfemale.Size = New System.Drawing.Size(74, 20)
        Me.rdfemale.TabIndex = 1
        Me.rdfemale.Text = "Female"
        Me.rdfemale.UseVisualStyleBackColor = True
        '
        'rdmale
        '
        Me.rdmale.AutoSize = True
        Me.rdmale.Checked = True
        Me.rdmale.Location = New System.Drawing.Point(52, 24)
        Me.rdmale.Name = "rdmale"
        Me.rdmale.Size = New System.Drawing.Size(57, 20)
        Me.rdmale.TabIndex = 0
        Me.rdmale.TabStop = True
        Me.rdmale.Text = "Male"
        Me.rdmale.UseVisualStyleBackColor = True
        '
        'chkisadmin
        '
        Me.chkisadmin.AutoSize = True
        Me.chkisadmin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chkisadmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkisadmin.Location = New System.Drawing.Point(171, 289)
        Me.chkisadmin.Name = "chkisadmin"
        Me.chkisadmin.Size = New System.Drawing.Size(90, 20)
        Me.chkisadmin.TabIndex = 5
        Me.chkisadmin.Text = "Is Admin?"
        Me.chkisadmin.UseVisualStyleBackColor = True
        '
        'chkisactive
        '
        Me.chkisactive.AutoSize = True
        Me.chkisactive.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chkisactive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkisactive.Location = New System.Drawing.Point(54, 289)
        Me.chkisactive.Name = "chkisactive"
        Me.chkisactive.Size = New System.Drawing.Size(88, 20)
        Me.chkisactive.TabIndex = 4
        Me.chkisactive.Text = "Is Active?"
        Me.chkisactive.UseVisualStyleBackColor = True
        '
        'panelmname
        '
        Me.panelmname.BackColor = System.Drawing.Color.White
        Me.panelmname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelmname.Controls.Add(Me.txtmname)
        Me.panelmname.Location = New System.Drawing.Point(53, 129)
        Me.panelmname.Name = "panelmname"
        Me.panelmname.Size = New System.Drawing.Size(320, 29)
        Me.panelmname.TabIndex = 1
        '
        'txtmname
        '
        Me.txtmname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtmname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtmname.Location = New System.Drawing.Point(3, 4)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(312, 19)
        Me.txtmname.TabIndex = 2
        '
        'panellname
        '
        Me.panellname.BackColor = System.Drawing.Color.White
        Me.panellname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panellname.Controls.Add(Me.txtlname)
        Me.panellname.Location = New System.Drawing.Point(54, 181)
        Me.panellname.Name = "panellname"
        Me.panellname.Size = New System.Drawing.Size(320, 29)
        Me.panellname.TabIndex = 2
        '
        'txtlname
        '
        Me.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtlname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtlname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtlname.Location = New System.Drawing.Point(3, 4)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(312, 19)
        Me.txtlname.TabIndex = 3
        '
        'panelfname
        '
        Me.panelfname.BackColor = System.Drawing.Color.White
        Me.panelfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelfname.Controls.Add(Me.txtfname)
        Me.panelfname.Location = New System.Drawing.Point(54, 72)
        Me.panelfname.Name = "panelfname"
        Me.panelfname.Size = New System.Drawing.Size(320, 29)
        Me.panelfname.TabIndex = 0
        '
        'txtfname
        '
        Me.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtfname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtfname.Location = New System.Drawing.Point(3, 4)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(312, 19)
        Me.txtfname.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(50, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Middle Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(50, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(50, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(117, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Say ""Hi"" to your new colleague"
        Me.Label1.Visible = False
        '
        'frmEmployeeLibrary
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(442, 582)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmployeeLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmployeeLibrary"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelconfirm.ResumeLayout(False)
        Me.panelconfirm.PerformLayout()
        Me.panelpword.ResumeLayout(False)
        Me.panelpword.PerformLayout()
        Me.paneluname.ResumeLayout(False)
        Me.paneluname.PerformLayout()
        Me.groupgender.ResumeLayout(False)
        Me.groupgender.PerformLayout()
        Me.panelmname.ResumeLayout(False)
        Me.panelmname.PerformLayout()
        Me.panellname.ResumeLayout(False)
        Me.panellname.PerformLayout()
        Me.panelfname.ResumeLayout(False)
        Me.panelfname.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnpositive As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panelfname As System.Windows.Forms.Panel
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents groupgender As System.Windows.Forms.GroupBox
    Friend WithEvents rdfemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdmale As System.Windows.Forms.RadioButton
    Friend WithEvents chkisadmin As System.Windows.Forms.CheckBox
    Friend WithEvents chkisactive As System.Windows.Forms.CheckBox
    Friend WithEvents panelmname As System.Windows.Forms.Panel
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents panellname As System.Windows.Forms.Panel
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents panelconfirm As System.Windows.Forms.Panel
    Friend WithEvents txtconfirmpword As System.Windows.Forms.TextBox
    Friend WithEvents panelpword As System.Windows.Forms.Panel
    Friend WithEvents txtpword As System.Windows.Forms.TextBox
    Friend WithEvents paneluname As System.Windows.Forms.Panel
    Friend WithEvents txtuname As System.Windows.Forms.TextBox
    Friend WithEvents lblconfirm As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
