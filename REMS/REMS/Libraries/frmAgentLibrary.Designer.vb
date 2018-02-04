<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgentLibrary
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtaccno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtaccname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkisbroker = New System.Windows.Forms.CheckBox()
        Me.panelposition = New System.Windows.Forms.Panel()
        Me.txtposition = New System.Windows.Forms.TextBox()
        Me.lblposition = New System.Windows.Forms.Label()
        Me.panelupline = New System.Windows.Forms.Panel()
        Me.pctrSearchUpline = New System.Windows.Forms.PictureBox()
        Me.txtuplinename = New System.Windows.Forms.TextBox()
        Me.lblupline = New System.Windows.Forms.Label()
        Me.panelcontact = New System.Windows.Forms.Panel()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.paneladdress = New System.Windows.Forms.Panel()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.panelbirthdate = New System.Windows.Forms.Panel()
        Me.dtpbirthdate = New System.Windows.Forms.DateTimePicker()
        Me.lblcontact = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.panelmi = New System.Windows.Forms.Panel()
        Me.txtmi = New System.Windows.Forms.TextBox()
        Me.panellname = New System.Windows.Forms.Panel()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.panelfname = New System.Windows.Forms.Panel()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelposition.SuspendLayout()
        Me.panelupline.SuspendLayout()
        CType(Me.pctrSearchUpline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelcontact.SuspendLayout()
        Me.paneladdress.SuspendLayout()
        Me.panelbirthdate.SuspendLayout()
        Me.panelmi.SuspendLayout()
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
        Me.btnpositive.Location = New System.Drawing.Point(346, 643)
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
        Me.lblTitle.Size = New System.Drawing.Size(149, 22)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "Add New Agent"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.chkisbroker)
        Me.Panel2.Controls.Add(Me.panelposition)
        Me.Panel2.Controls.Add(Me.lblposition)
        Me.Panel2.Controls.Add(Me.panelupline)
        Me.Panel2.Controls.Add(Me.lblupline)
        Me.Panel2.Controls.Add(Me.panelcontact)
        Me.Panel2.Controls.Add(Me.paneladdress)
        Me.Panel2.Controls.Add(Me.panelbirthdate)
        Me.Panel2.Controls.Add(Me.lblcontact)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.panelmi)
        Me.Panel2.Controls.Add(Me.panellname)
        Me.Panel2.Controls.Add(Me.panelfname)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnpositive)
        Me.Panel2.Location = New System.Drawing.Point(4, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(434, 686)
        Me.Panel2.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtaccno)
        Me.Panel3.Location = New System.Drawing.Point(58, 460)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(320, 29)
        Me.Panel3.TabIndex = 39
        '
        'txtaccno
        '
        Me.txtaccno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtaccno.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtaccno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtaccno.Location = New System.Drawing.Point(3, 4)
        Me.txtaccno.Name = "txtaccno"
        Me.txtaccno.Size = New System.Drawing.Size(312, 19)
        Me.txtaccno.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(56, 445)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 16)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Account Number"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtaccname)
        Me.Panel1.Location = New System.Drawing.Point(58, 410)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 29)
        Me.Panel1.TabIndex = 37
        '
        'txtaccname
        '
        Me.txtaccname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtaccname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtaccname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtaccname.Location = New System.Drawing.Point(3, 4)
        Me.txtaccname.Name = "txtaccname"
        Me.txtaccname.Size = New System.Drawing.Size(312, 19)
        Me.txtaccname.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(56, 395)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Account Name"
        '
        'chkisbroker
        '
        Me.chkisbroker.AutoSize = True
        Me.chkisbroker.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chkisbroker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkisbroker.Location = New System.Drawing.Point(57, 504)
        Me.chkisbroker.Name = "chkisbroker"
        Me.chkisbroker.Size = New System.Drawing.Size(166, 20)
        Me.chkisbroker.TabIndex = 36
        Me.chkisbroker.Text = "Is Real Estate Broker?"
        Me.chkisbroker.UseVisualStyleBackColor = True
        '
        'panelposition
        '
        Me.panelposition.BackColor = System.Drawing.Color.White
        Me.panelposition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelposition.Controls.Add(Me.txtposition)
        Me.panelposition.Location = New System.Drawing.Point(58, 600)
        Me.panelposition.Name = "panelposition"
        Me.panelposition.Size = New System.Drawing.Size(320, 29)
        Me.panelposition.TabIndex = 34
        '
        'txtposition
        '
        Me.txtposition.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtposition.Enabled = False
        Me.txtposition.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtposition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtposition.Location = New System.Drawing.Point(3, 4)
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(312, 19)
        Me.txtposition.TabIndex = 9
        '
        'lblposition
        '
        Me.lblposition.AutoSize = True
        Me.lblposition.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblposition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblposition.Location = New System.Drawing.Point(56, 581)
        Me.lblposition.Name = "lblposition"
        Me.lblposition.Size = New System.Drawing.Size(59, 16)
        Me.lblposition.TabIndex = 35
        Me.lblposition.Text = "Position"
        '
        'panelupline
        '
        Me.panelupline.BackColor = System.Drawing.Color.White
        Me.panelupline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelupline.Controls.Add(Me.pctrSearchUpline)
        Me.panelupline.Controls.Add(Me.txtuplinename)
        Me.panelupline.Location = New System.Drawing.Point(58, 545)
        Me.panelupline.Name = "panelupline"
        Me.panelupline.Size = New System.Drawing.Size(320, 29)
        Me.panelupline.TabIndex = 32
        '
        'pctrSearchUpline
        '
        Me.pctrSearchUpline.BackgroundImage = Global.IRES.My.Resources.Resources.search_glyph
        Me.pctrSearchUpline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctrSearchUpline.Location = New System.Drawing.Point(293, 2)
        Me.pctrSearchUpline.Name = "pctrSearchUpline"
        Me.pctrSearchUpline.Size = New System.Drawing.Size(24, 24)
        Me.pctrSearchUpline.TabIndex = 10
        Me.pctrSearchUpline.TabStop = False
        '
        'txtuplinename
        '
        Me.txtuplinename.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtuplinename.Enabled = False
        Me.txtuplinename.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtuplinename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtuplinename.Location = New System.Drawing.Point(3, 4)
        Me.txtuplinename.Name = "txtuplinename"
        Me.txtuplinename.Size = New System.Drawing.Size(289, 19)
        Me.txtuplinename.TabIndex = 9
        '
        'lblupline
        '
        Me.lblupline.AutoSize = True
        Me.lblupline.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblupline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblupline.Location = New System.Drawing.Point(56, 530)
        Me.lblupline.Name = "lblupline"
        Me.lblupline.Size = New System.Drawing.Size(90, 16)
        Me.lblupline.TabIndex = 33
        Me.lblupline.Text = "Upline Agent"
        '
        'panelcontact
        '
        Me.panelcontact.BackColor = System.Drawing.Color.White
        Me.panelcontact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelcontact.Controls.Add(Me.txtcontact)
        Me.panelcontact.Location = New System.Drawing.Point(58, 358)
        Me.panelcontact.Name = "panelcontact"
        Me.panelcontact.Size = New System.Drawing.Size(320, 29)
        Me.panelcontact.TabIndex = 8
        '
        'txtcontact
        '
        Me.txtcontact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcontact.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtcontact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtcontact.Location = New System.Drawing.Point(3, 4)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(312, 19)
        Me.txtcontact.TabIndex = 9
        '
        'paneladdress
        '
        Me.paneladdress.BackColor = System.Drawing.Color.White
        Me.paneladdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneladdress.Controls.Add(Me.txtaddress)
        Me.paneladdress.Location = New System.Drawing.Point(58, 270)
        Me.paneladdress.Name = "paneladdress"
        Me.paneladdress.Size = New System.Drawing.Size(320, 64)
        Me.paneladdress.TabIndex = 7
        '
        'txtaddress
        '
        Me.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtaddress.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtaddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtaddress.Location = New System.Drawing.Point(3, 4)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(312, 55)
        Me.txtaddress.TabIndex = 8
        Me.txtaddress.WordWrap = False
        '
        'panelbirthdate
        '
        Me.panelbirthdate.BackColor = System.Drawing.Color.White
        Me.panelbirthdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelbirthdate.Controls.Add(Me.dtpbirthdate)
        Me.panelbirthdate.Location = New System.Drawing.Point(58, 216)
        Me.panelbirthdate.Name = "panelbirthdate"
        Me.panelbirthdate.Size = New System.Drawing.Size(320, 29)
        Me.panelbirthdate.TabIndex = 6
        '
        'dtpbirthdate
        '
        Me.dtpbirthdate.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpbirthdate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpbirthdate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpbirthdate.Font = New System.Drawing.Font("Arial", 12.5!)
        Me.dtpbirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpbirthdate.Location = New System.Drawing.Point(-1, 0)
        Me.dtpbirthdate.Name = "dtpbirthdate"
        Me.dtpbirthdate.Size = New System.Drawing.Size(319, 27)
        Me.dtpbirthdate.TabIndex = 0
        '
        'lblcontact
        '
        Me.lblcontact.AutoSize = True
        Me.lblcontact.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblcontact.Location = New System.Drawing.Point(55, 343)
        Me.lblcontact.Name = "lblcontact"
        Me.lblcontact.Size = New System.Drawing.Size(87, 16)
        Me.lblcontact.TabIndex = 31
        Me.lblcontact.Text = "Contact Nos."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(54, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(54, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Birth Date"
        '
        'panelmi
        '
        Me.panelmi.BackColor = System.Drawing.Color.White
        Me.panelmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelmi.Controls.Add(Me.txtmi)
        Me.panelmi.Location = New System.Drawing.Point(56, 107)
        Me.panelmi.Name = "panelmi"
        Me.panelmi.Size = New System.Drawing.Size(320, 29)
        Me.panelmi.TabIndex = 1
        '
        'txtmi
        '
        Me.txtmi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmi.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtmi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtmi.Location = New System.Drawing.Point(3, 4)
        Me.txtmi.MaxLength = 1
        Me.txtmi.Name = "txtmi"
        Me.txtmi.Size = New System.Drawing.Size(312, 19)
        Me.txtmi.TabIndex = 2
        '
        'panellname
        '
        Me.panellname.BackColor = System.Drawing.Color.White
        Me.panellname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panellname.Controls.Add(Me.txtlname)
        Me.panellname.Location = New System.Drawing.Point(57, 159)
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
        Me.panelfname.Location = New System.Drawing.Point(57, 50)
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
        Me.Label4.Location = New System.Drawing.Point(53, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Middle Initial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(53, 144)
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
        Me.Label2.Location = New System.Drawing.Point(53, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "First Name"
        '
        'frmAgentLibrary
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(442, 733)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAgentLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmployeeLibrary"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelposition.ResumeLayout(False)
        Me.panelposition.PerformLayout()
        Me.panelupline.ResumeLayout(False)
        Me.panelupline.PerformLayout()
        CType(Me.pctrSearchUpline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelcontact.ResumeLayout(False)
        Me.panelcontact.PerformLayout()
        Me.paneladdress.ResumeLayout(False)
        Me.paneladdress.PerformLayout()
        Me.panelbirthdate.ResumeLayout(False)
        Me.panelmi.ResumeLayout(False)
        Me.panelmi.PerformLayout()
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
    Friend WithEvents panelfname As System.Windows.Forms.Panel
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents panelmi As System.Windows.Forms.Panel
    Friend WithEvents txtmi As System.Windows.Forms.TextBox
    Friend WithEvents panellname As System.Windows.Forms.Panel
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents panelcontact As System.Windows.Forms.Panel
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents paneladdress As System.Windows.Forms.Panel
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents panelbirthdate As System.Windows.Forms.Panel
    Friend WithEvents lblcontact As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpbirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents panelupline As System.Windows.Forms.Panel
    Friend WithEvents txtuplinename As System.Windows.Forms.TextBox
    Friend WithEvents lblupline As System.Windows.Forms.Label
    Friend WithEvents panelposition As System.Windows.Forms.Panel
    Friend WithEvents txtposition As System.Windows.Forms.TextBox
    Friend WithEvents lblposition As System.Windows.Forms.Label
    Friend WithEvents pctrSearchUpline As System.Windows.Forms.PictureBox
    Friend WithEvents chkisbroker As System.Windows.Forms.CheckBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtaccno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtaccname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
