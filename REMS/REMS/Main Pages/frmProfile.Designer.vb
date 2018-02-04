<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfile
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
        Me.btnbrowse = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pctrProfile = New System.Windows.Forms.PictureBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.paneluname = New System.Windows.Forms.Panel()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.panelmname = New System.Windows.Forms.Panel()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.panellname = New System.Windows.Forms.Panel()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.panelfname = New System.Windows.Forms.Panel()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnupdateinfo = New System.Windows.Forms.Button()
        Me.btnchangepass = New System.Windows.Forms.Button()
        Me.rdmale = New System.Windows.Forms.RadioButton()
        Me.rdfemale = New System.Windows.Forms.RadioButton()
        Me.groupgender = New System.Windows.Forms.GroupBox()
        CType(Me.pctrProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paneluname.SuspendLayout()
        Me.panelmname.SuspendLayout()
        Me.panellname.SuspendLayout()
        Me.panelfname.SuspendLayout()
        Me.groupgender.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnbrowse
        '
        Me.btnbrowse.BackColor = System.Drawing.Color.SteelBlue
        Me.btnbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbrowse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnbrowse.ForeColor = System.Drawing.Color.White
        Me.btnbrowse.Location = New System.Drawing.Point(79, 418)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(81, 33)
        Me.btnbrowse.TabIndex = 7
        Me.btnbrowse.Text = "Browse"
        Me.btnbrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnbrowse.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(51, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 27)
        Me.Label4.TabIndex = 173
        Me.Label4.Text = "Profile"
        '
        'pctrProfile
        '
        Me.pctrProfile.Image = Global.IRES.My.Resources.Resources.no_image
        Me.pctrProfile.Location = New System.Drawing.Point(79, 112)
        Me.pctrProfile.Name = "pctrProfile"
        Me.pctrProfile.Size = New System.Drawing.Size(330, 300)
        Me.pctrProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrProfile.TabIndex = 174
        Me.pctrProfile.TabStop = False
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.Goldenrod
        Me.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsubmit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnsubmit.ForeColor = System.Drawing.Color.White
        Me.btnsubmit.Location = New System.Drawing.Point(166, 418)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(81, 33)
        Me.btnsubmit.TabIndex = 175
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsubmit.UseVisualStyleBackColor = False
        '
        'paneluname
        '
        Me.paneluname.BackColor = System.Drawing.Color.White
        Me.paneluname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneluname.Controls.Add(Me.txtuname)
        Me.paneluname.Location = New System.Drawing.Point(500, 384)
        Me.paneluname.Name = "paneluname"
        Me.paneluname.Size = New System.Drawing.Size(320, 29)
        Me.paneluname.TabIndex = 180
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(496, 369)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 16)
        Me.Label9.TabIndex = 184
        Me.Label9.Text = "User Name"
        '
        'panelmname
        '
        Me.panelmname.BackColor = System.Drawing.Color.White
        Me.panelmname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelmname.Controls.Add(Me.txtmname)
        Me.panelmname.Location = New System.Drawing.Point(498, 190)
        Me.panelmname.Name = "panelmname"
        Me.panelmname.Size = New System.Drawing.Size(320, 29)
        Me.panelmname.TabIndex = 177
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
        Me.panellname.Location = New System.Drawing.Point(499, 248)
        Me.panellname.Name = "panellname"
        Me.panellname.Size = New System.Drawing.Size(320, 29)
        Me.panellname.TabIndex = 178
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
        Me.panelfname.Location = New System.Drawing.Point(499, 127)
        Me.panelfname.Name = "panelfname"
        Me.panelfname.Size = New System.Drawing.Size(320, 29)
        Me.panelfname.TabIndex = 176
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(495, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 183
        Me.Label1.Text = "Middle Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(495, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 182
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(495, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "First Name"
        '
        'btnupdateinfo
        '
        Me.btnupdateinfo.BackColor = System.Drawing.Color.SteelBlue
        Me.btnupdateinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdateinfo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnupdateinfo.ForeColor = System.Drawing.Color.White
        Me.btnupdateinfo.Location = New System.Drawing.Point(500, 418)
        Me.btnupdateinfo.Name = "btnupdateinfo"
        Me.btnupdateinfo.Size = New System.Drawing.Size(320, 33)
        Me.btnupdateinfo.TabIndex = 185
        Me.btnupdateinfo.Text = "Update Info"
        Me.btnupdateinfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnupdateinfo.UseVisualStyleBackColor = False
        '
        'btnchangepass
        '
        Me.btnchangepass.BackColor = System.Drawing.Color.Goldenrod
        Me.btnchangepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnchangepass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnchangepass.ForeColor = System.Drawing.Color.White
        Me.btnchangepass.Location = New System.Drawing.Point(500, 452)
        Me.btnchangepass.Name = "btnchangepass"
        Me.btnchangepass.Size = New System.Drawing.Size(320, 33)
        Me.btnchangepass.TabIndex = 186
        Me.btnchangepass.Text = "Change Password"
        Me.btnchangepass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnchangepass.UseVisualStyleBackColor = False
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
        'groupgender
        '
        Me.groupgender.Controls.Add(Me.rdfemale)
        Me.groupgender.Controls.Add(Me.rdmale)
        Me.groupgender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupgender.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.groupgender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.groupgender.Location = New System.Drawing.Point(499, 295)
        Me.groupgender.Name = "groupgender"
        Me.groupgender.Size = New System.Drawing.Size(320, 56)
        Me.groupgender.TabIndex = 179
        Me.groupgender.TabStop = False
        Me.groupgender.Text = "Gender"
        '
        'frmProfile
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1114, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnchangepass)
        Me.Controls.Add(Me.btnupdateinfo)
        Me.Controls.Add(Me.paneluname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.groupgender)
        Me.Controls.Add(Me.panelmname)
        Me.Controls.Add(Me.panellname)
        Me.Controls.Add(Me.panelfname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.pctrProfile)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnbrowse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmReservations"
        CType(Me.pctrProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paneluname.ResumeLayout(False)
        Me.paneluname.PerformLayout()
        Me.panelmname.ResumeLayout(False)
        Me.panelmname.PerformLayout()
        Me.panellname.ResumeLayout(False)
        Me.panellname.PerformLayout()
        Me.panelfname.ResumeLayout(False)
        Me.panelfname.PerformLayout()
        Me.groupgender.ResumeLayout(False)
        Me.groupgender.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnbrowse As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pctrProfile As System.Windows.Forms.PictureBox
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents paneluname As System.Windows.Forms.Panel
    Friend WithEvents txtuname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents panelmname As System.Windows.Forms.Panel
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents panellname As System.Windows.Forms.Panel
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents panelfname As System.Windows.Forms.Panel
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnupdateinfo As System.Windows.Forms.Button
    Friend WithEvents btnchangepass As System.Windows.Forms.Button
    Friend WithEvents rdmale As System.Windows.Forms.RadioButton
    Friend WithEvents rdfemale As System.Windows.Forms.RadioButton
    Friend WithEvents groupgender As System.Windows.Forms.GroupBox
End Class
