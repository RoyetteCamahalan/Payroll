<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLotLibrary
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
        Me.panelparking = New System.Windows.Forms.Panel()
        Me.txtparking = New System.Windows.Forms.TextBox()
        Me.lblParking = New System.Windows.Forms.Label()
        Me.panelhousearea = New System.Windows.Forms.Panel()
        Me.txthousearea = New System.Windows.Forms.TextBox()
        Me.lblhousearea = New System.Windows.Forms.Label()
        Me.panelcommissionable = New System.Windows.Forms.Panel()
        Me.txtcommissionableamount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panelcom = New System.Windows.Forms.Panel()
        Me.txtcom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.paneltype = New System.Windows.Forms.Panel()
        Me.cmbtype = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.paneldown = New System.Windows.Forms.Panel()
        Me.txtdown = New System.Windows.Forms.TextBox()
        Me.lblcontact = New System.Windows.Forms.Label()
        Me.panelarea = New System.Windows.Forms.Panel()
        Me.txtarea = New System.Windows.Forms.TextBox()
        Me.panelprice = New System.Windows.Forms.Panel()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.panellotname = New System.Windows.Forms.Panel()
        Me.txtlotname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.panelparking.SuspendLayout()
        Me.panelhousearea.SuspendLayout()
        Me.panelcommissionable.SuspendLayout()
        Me.panelcom.SuspendLayout()
        Me.paneltype.SuspendLayout()
        Me.paneldown.SuspendLayout()
        Me.panelarea.SuspendLayout()
        Me.panelprice.SuspendLayout()
        Me.panellotname.SuspendLayout()
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
        Me.btnpositive.Location = New System.Drawing.Point(306, 499)
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
        Me.lblTitle.Size = New System.Drawing.Size(126, 22)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "Add New Lot"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.panelparking)
        Me.Panel2.Controls.Add(Me.lblParking)
        Me.Panel2.Controls.Add(Me.panelhousearea)
        Me.Panel2.Controls.Add(Me.lblhousearea)
        Me.Panel2.Controls.Add(Me.panelcommissionable)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.panelcom)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.paneltype)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.paneldown)
        Me.Panel2.Controls.Add(Me.lblcontact)
        Me.Panel2.Controls.Add(Me.panelarea)
        Me.Panel2.Controls.Add(Me.panelprice)
        Me.Panel2.Controls.Add(Me.panellotname)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnpositive)
        Me.Panel2.Location = New System.Drawing.Point(4, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(394, 542)
        Me.Panel2.TabIndex = 18
        '
        'panelparking
        '
        Me.panelparking.BackColor = System.Drawing.Color.White
        Me.panelparking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelparking.Controls.Add(Me.txtparking)
        Me.panelparking.Location = New System.Drawing.Point(36, 460)
        Me.panelparking.Name = "panelparking"
        Me.panelparking.Size = New System.Drawing.Size(320, 29)
        Me.panelparking.TabIndex = 40
        '
        'txtparking
        '
        Me.txtparking.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtparking.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtparking.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtparking.Location = New System.Drawing.Point(3, 4)
        Me.txtparking.Name = "txtparking"
        Me.txtparking.Size = New System.Drawing.Size(312, 19)
        Me.txtparking.TabIndex = 9
        Me.txtparking.Text = "0"
        '
        'lblParking
        '
        Me.lblParking.AutoSize = True
        Me.lblParking.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParking.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblParking.Location = New System.Drawing.Point(33, 445)
        Me.lblParking.Name = "lblParking"
        Me.lblParking.Size = New System.Drawing.Size(139, 16)
        Me.lblParking.TabIndex = 41
        Me.lblParking.Text = "Parking Area in SqM"
        '
        'panelhousearea
        '
        Me.panelhousearea.BackColor = System.Drawing.Color.White
        Me.panelhousearea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelhousearea.Controls.Add(Me.txthousearea)
        Me.panelhousearea.Location = New System.Drawing.Point(35, 410)
        Me.panelhousearea.Name = "panelhousearea"
        Me.panelhousearea.Size = New System.Drawing.Size(320, 29)
        Me.panelhousearea.TabIndex = 38
        '
        'txthousearea
        '
        Me.txthousearea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txthousearea.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txthousearea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txthousearea.Location = New System.Drawing.Point(3, 4)
        Me.txthousearea.Name = "txthousearea"
        Me.txthousearea.Size = New System.Drawing.Size(312, 19)
        Me.txthousearea.TabIndex = 9
        Me.txthousearea.Text = "0"
        '
        'lblhousearea
        '
        Me.lblhousearea.AutoSize = True
        Me.lblhousearea.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhousearea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblhousearea.Location = New System.Drawing.Point(32, 395)
        Me.lblhousearea.Name = "lblhousearea"
        Me.lblhousearea.Size = New System.Drawing.Size(129, 16)
        Me.lblhousearea.TabIndex = 39
        Me.lblhousearea.Text = "House Area in SqM"
        '
        'panelcommissionable
        '
        Me.panelcommissionable.BackColor = System.Drawing.Color.White
        Me.panelcommissionable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelcommissionable.Controls.Add(Me.txtcommissionableamount)
        Me.panelcommissionable.Location = New System.Drawing.Point(35, 311)
        Me.panelcommissionable.Name = "panelcommissionable"
        Me.panelcommissionable.Size = New System.Drawing.Size(320, 29)
        Me.panelcommissionable.TabIndex = 36
        '
        'txtcommissionableamount
        '
        Me.txtcommissionableamount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcommissionableamount.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtcommissionableamount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtcommissionableamount.Location = New System.Drawing.Point(3, 4)
        Me.txtcommissionableamount.Name = "txtcommissionableamount"
        Me.txtcommissionableamount.Size = New System.Drawing.Size(312, 19)
        Me.txtcommissionableamount.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(32, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Commissionable Amount"
        '
        'panelcom
        '
        Me.panelcom.BackColor = System.Drawing.Color.White
        Me.panelcom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelcom.Controls.Add(Me.txtcom)
        Me.panelcom.Location = New System.Drawing.Point(35, 262)
        Me.panelcom.Name = "panelcom"
        Me.panelcom.Size = New System.Drawing.Size(320, 29)
        Me.panelcom.TabIndex = 34
        '
        'txtcom
        '
        Me.txtcom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcom.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtcom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtcom.Location = New System.Drawing.Point(3, 4)
        Me.txtcom.Name = "txtcom"
        Me.txtcom.Size = New System.Drawing.Size(312, 19)
        Me.txtcom.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(32, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 16)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Commission Percentage"
        '
        'paneltype
        '
        Me.paneltype.BackColor = System.Drawing.Color.White
        Me.paneltype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneltype.Controls.Add(Me.cmbtype)
        Me.paneltype.Location = New System.Drawing.Point(35, 361)
        Me.paneltype.Name = "paneltype"
        Me.paneltype.Size = New System.Drawing.Size(320, 27)
        Me.paneltype.TabIndex = 32
        '
        'cmbtype
        '
        Me.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtype.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.cmbtype.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Location = New System.Drawing.Point(0, 0)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(320, 25)
        Me.cmbtype.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(32, 346)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Type/Model"
        '
        'paneldown
        '
        Me.paneldown.BackColor = System.Drawing.Color.White
        Me.paneldown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneldown.Controls.Add(Me.txtdown)
        Me.paneldown.Location = New System.Drawing.Point(35, 212)
        Me.paneldown.Name = "paneldown"
        Me.paneldown.Size = New System.Drawing.Size(320, 29)
        Me.paneldown.TabIndex = 8
        '
        'txtdown
        '
        Me.txtdown.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdown.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtdown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtdown.Location = New System.Drawing.Point(3, 4)
        Me.txtdown.Name = "txtdown"
        Me.txtdown.Size = New System.Drawing.Size(312, 19)
        Me.txtdown.TabIndex = 9
        '
        'lblcontact
        '
        Me.lblcontact.AutoSize = True
        Me.lblcontact.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblcontact.Location = New System.Drawing.Point(32, 197)
        Me.lblcontact.Name = "lblcontact"
        Me.lblcontact.Size = New System.Drawing.Size(111, 16)
        Me.lblcontact.TabIndex = 31
        Me.lblcontact.Text = "Reservation Fee"
        '
        'panelarea
        '
        Me.panelarea.BackColor = System.Drawing.Color.White
        Me.panelarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelarea.Controls.Add(Me.txtarea)
        Me.panelarea.Location = New System.Drawing.Point(35, 107)
        Me.panelarea.Name = "panelarea"
        Me.panelarea.Size = New System.Drawing.Size(320, 29)
        Me.panelarea.TabIndex = 1
        '
        'txtarea
        '
        Me.txtarea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtarea.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtarea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtarea.Location = New System.Drawing.Point(3, 4)
        Me.txtarea.MaxLength = 255
        Me.txtarea.Name = "txtarea"
        Me.txtarea.Size = New System.Drawing.Size(312, 19)
        Me.txtarea.TabIndex = 2
        '
        'panelprice
        '
        Me.panelprice.BackColor = System.Drawing.Color.White
        Me.panelprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelprice.Controls.Add(Me.txtprice)
        Me.panelprice.Location = New System.Drawing.Point(36, 159)
        Me.panelprice.Name = "panelprice"
        Me.panelprice.Size = New System.Drawing.Size(320, 29)
        Me.panelprice.TabIndex = 2
        '
        'txtprice
        '
        Me.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtprice.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtprice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtprice.Location = New System.Drawing.Point(3, 4)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(312, 19)
        Me.txtprice.TabIndex = 3
        '
        'panellotname
        '
        Me.panellotname.BackColor = System.Drawing.Color.White
        Me.panellotname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panellotname.Controls.Add(Me.txtlotname)
        Me.panellotname.Location = New System.Drawing.Point(36, 50)
        Me.panellotname.Name = "panellotname"
        Me.panellotname.Size = New System.Drawing.Size(320, 29)
        Me.panellotname.TabIndex = 0
        '
        'txtlotname
        '
        Me.txtlotname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtlotname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtlotname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtlotname.Location = New System.Drawing.Point(3, 4)
        Me.txtlotname.Name = "txtlotname"
        Me.txtlotname.Size = New System.Drawing.Size(312, 19)
        Me.txtlotname.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(32, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Area in SqM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(32, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Selling Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Lot Name"
        '
        'frmLotLibrary
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(402, 589)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLotLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmployeeLibrary"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelparking.ResumeLayout(False)
        Me.panelparking.PerformLayout()
        Me.panelhousearea.ResumeLayout(False)
        Me.panelhousearea.PerformLayout()
        Me.panelcommissionable.ResumeLayout(False)
        Me.panelcommissionable.PerformLayout()
        Me.panelcom.ResumeLayout(False)
        Me.panelcom.PerformLayout()
        Me.paneltype.ResumeLayout(False)
        Me.paneldown.ResumeLayout(False)
        Me.paneldown.PerformLayout()
        Me.panelarea.ResumeLayout(False)
        Me.panelarea.PerformLayout()
        Me.panelprice.ResumeLayout(False)
        Me.panelprice.PerformLayout()
        Me.panellotname.ResumeLayout(False)
        Me.panellotname.PerformLayout()
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
    Friend WithEvents panellotname As System.Windows.Forms.Panel
    Friend WithEvents txtlotname As System.Windows.Forms.TextBox
    Friend WithEvents panelarea As System.Windows.Forms.Panel
    Friend WithEvents txtarea As System.Windows.Forms.TextBox
    Friend WithEvents panelprice As System.Windows.Forms.Panel
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents paneldown As System.Windows.Forms.Panel
    Friend WithEvents txtdown As System.Windows.Forms.TextBox
    Friend WithEvents lblcontact As System.Windows.Forms.Label
    Friend WithEvents paneltype As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbtype As System.Windows.Forms.ComboBox
    Friend WithEvents panelcom As System.Windows.Forms.Panel
    Friend WithEvents txtcom As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents panelcommissionable As System.Windows.Forms.Panel
    Friend WithEvents txtcommissionableamount As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents panelparking As System.Windows.Forms.Panel
    Friend WithEvents txtparking As System.Windows.Forms.TextBox
    Friend WithEvents lblParking As System.Windows.Forms.Label
    Friend WithEvents panelhousearea As System.Windows.Forms.Panel
    Friend WithEvents txthousearea As System.Windows.Forms.TextBox
    Friend WithEvents lblhousearea As System.Windows.Forms.Label
End Class
