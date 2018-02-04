<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompanyProfile
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
        Me.pctrCompanyLogo = New System.Windows.Forms.PictureBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.panelcaddress = New System.Windows.Forms.Panel()
        Me.txtcaddress = New System.Windows.Forms.TextBox()
        Me.panelccontact = New System.Windows.Forms.Panel()
        Me.txtccontact = New System.Windows.Forms.TextBox()
        Me.panelcname = New System.Windows.Forms.Panel()
        Me.txtcname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnupdateinfo = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnclose = New System.Windows.Forms.Button()
        CType(Me.pctrCompanyLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelcaddress.SuspendLayout()
        Me.panelccontact.SuspendLayout()
        Me.panelcname.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Label4.Location = New System.Drawing.Point(74, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 27)
        Me.Label4.TabIndex = 173
        Me.Label4.Text = "Company Profile"
        '
        'pctrCompanyLogo
        '
        Me.pctrCompanyLogo.Image = Global.IRES.My.Resources.Resources.no_image
        Me.pctrCompanyLogo.Location = New System.Drawing.Point(79, 112)
        Me.pctrCompanyLogo.Name = "pctrCompanyLogo"
        Me.pctrCompanyLogo.Size = New System.Drawing.Size(330, 300)
        Me.pctrCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrCompanyLogo.TabIndex = 174
        Me.pctrCompanyLogo.TabStop = False
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
        'panelcaddress
        '
        Me.panelcaddress.BackColor = System.Drawing.Color.White
        Me.panelcaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelcaddress.Controls.Add(Me.txtcaddress)
        Me.panelcaddress.Location = New System.Drawing.Point(498, 190)
        Me.panelcaddress.Name = "panelcaddress"
        Me.panelcaddress.Size = New System.Drawing.Size(320, 29)
        Me.panelcaddress.TabIndex = 177
        '
        'txtcaddress
        '
        Me.txtcaddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcaddress.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtcaddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtcaddress.Location = New System.Drawing.Point(3, 4)
        Me.txtcaddress.Name = "txtcaddress"
        Me.txtcaddress.Size = New System.Drawing.Size(312, 19)
        Me.txtcaddress.TabIndex = 2
        '
        'panelccontact
        '
        Me.panelccontact.BackColor = System.Drawing.Color.White
        Me.panelccontact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelccontact.Controls.Add(Me.txtccontact)
        Me.panelccontact.Location = New System.Drawing.Point(499, 248)
        Me.panelccontact.Name = "panelccontact"
        Me.panelccontact.Size = New System.Drawing.Size(320, 29)
        Me.panelccontact.TabIndex = 178
        '
        'txtccontact
        '
        Me.txtccontact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtccontact.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtccontact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtccontact.Location = New System.Drawing.Point(3, 4)
        Me.txtccontact.Name = "txtccontact"
        Me.txtccontact.Size = New System.Drawing.Size(312, 19)
        Me.txtccontact.TabIndex = 3
        '
        'panelcname
        '
        Me.panelcname.BackColor = System.Drawing.Color.White
        Me.panelcname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelcname.Controls.Add(Me.txtcname)
        Me.panelcname.Location = New System.Drawing.Point(499, 127)
        Me.panelcname.Name = "panelcname"
        Me.panelcname.Size = New System.Drawing.Size(320, 29)
        Me.panelcname.TabIndex = 176
        '
        'txtcname
        '
        Me.txtcname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtcname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtcname.Location = New System.Drawing.Point(3, 4)
        Me.txtcname.Name = "txtcname"
        Me.txtcname.Size = New System.Drawing.Size(312, 19)
        Me.txtcname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(495, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 16)
        Me.Label1.TabIndex = 183
        Me.Label1.Text = "Company Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(495, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 182
        Me.Label3.Text = "Company Contact"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(495, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "Company Name"
        '
        'btnupdateinfo
        '
        Me.btnupdateinfo.BackColor = System.Drawing.Color.SteelBlue
        Me.btnupdateinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdateinfo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnupdateinfo.ForeColor = System.Drawing.Color.White
        Me.btnupdateinfo.Location = New System.Drawing.Point(500, 288)
        Me.btnupdateinfo.Name = "btnupdateinfo"
        Me.btnupdateinfo.Size = New System.Drawing.Size(320, 33)
        Me.btnupdateinfo.TabIndex = 185
        Me.btnupdateinfo.Text = "Update Info"
        Me.btnupdateinfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnupdateinfo.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.panelcname)
        Me.Panel2.Controls.Add(Me.panelccontact)
        Me.Panel2.Controls.Add(Me.panelcaddress)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.pctrCompanyLogo)
        Me.Panel2.Controls.Add(Me.btnbrowse)
        Me.Panel2.Controls.Add(Me.btnsubmit)
        Me.Panel2.Controls.Add(Me.btnupdateinfo)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(4, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(878, 489)
        Me.Panel2.TabIndex = 186
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(853, 12)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(24, 20)
        Me.btnclose.TabIndex = 186
        Me.btnclose.Text = "X"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'frmCompanyProfile
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(886, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCompanyProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pctrCompanyLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelcaddress.ResumeLayout(False)
        Me.panelcaddress.PerformLayout()
        Me.panelccontact.ResumeLayout(False)
        Me.panelccontact.PerformLayout()
        Me.panelcname.ResumeLayout(False)
        Me.panelcname.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnbrowse As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pctrCompanyLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents panelcaddress As System.Windows.Forms.Panel
    Friend WithEvents txtcaddress As System.Windows.Forms.TextBox
    Friend WithEvents panelccontact As System.Windows.Forms.Panel
    Friend WithEvents txtccontact As System.Windows.Forms.TextBox
    Friend WithEvents panelcname As System.Windows.Forms.Panel
    Friend WithEvents txtcname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnupdateinfo As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
End Class
