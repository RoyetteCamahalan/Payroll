<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpenseLibrary
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
        Me.panelmemo = New System.Windows.Forms.Panel()
        Me.txtmemo = New System.Windows.Forms.TextBox()
        Me.panelamount = New System.Windows.Forms.Panel()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.panelrefdate = New System.Windows.Forms.Panel()
        Me.dtprefdate = New System.Windows.Forms.DateTimePicker()
        Me.lblconfirm = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.panelexpensetype = New System.Windows.Forms.Panel()
        Me.pctrExpensetype = New System.Windows.Forms.PictureBox()
        Me.txtexpensetype = New System.Windows.Forms.TextBox()
        Me.panelrefno = New System.Windows.Forms.Panel()
        Me.txtrefno = New System.Windows.Forms.TextBox()
        Me.panelaccount = New System.Windows.Forms.Panel()
        Me.pctrSearchAccount = New System.Windows.Forms.PictureBox()
        Me.txtaccoutname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.panelmemo.SuspendLayout()
        Me.panelamount.SuspendLayout()
        Me.panelrefdate.SuspendLayout()
        Me.panelexpensetype.SuspendLayout()
        CType(Me.pctrExpensetype, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelrefno.SuspendLayout()
        Me.panelaccount.SuspendLayout()
        CType(Me.pctrSearchAccount, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnpositive.Location = New System.Drawing.Point(346, 372)
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
        Me.lblTitle.Size = New System.Drawing.Size(177, 22)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "Add New Expense"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.panelmemo)
        Me.Panel2.Controls.Add(Me.panelamount)
        Me.Panel2.Controls.Add(Me.panelrefdate)
        Me.Panel2.Controls.Add(Me.lblconfirm)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.panelexpensetype)
        Me.Panel2.Controls.Add(Me.panelrefno)
        Me.Panel2.Controls.Add(Me.panelaccount)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnpositive)
        Me.Panel2.Location = New System.Drawing.Point(4, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(434, 417)
        Me.Panel2.TabIndex = 18
        '
        'panelmemo
        '
        Me.panelmemo.BackColor = System.Drawing.Color.White
        Me.panelmemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelmemo.Controls.Add(Me.txtmemo)
        Me.panelmemo.Location = New System.Drawing.Point(52, 319)
        Me.panelmemo.Name = "panelmemo"
        Me.panelmemo.Size = New System.Drawing.Size(320, 29)
        Me.panelmemo.TabIndex = 8
        '
        'txtmemo
        '
        Me.txtmemo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmemo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtmemo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtmemo.Location = New System.Drawing.Point(3, 4)
        Me.txtmemo.Name = "txtmemo"
        Me.txtmemo.Size = New System.Drawing.Size(312, 19)
        Me.txtmemo.TabIndex = 9
        '
        'panelamount
        '
        Me.panelamount.BackColor = System.Drawing.Color.White
        Me.panelamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelamount.Controls.Add(Me.txtAmount)
        Me.panelamount.Location = New System.Drawing.Point(52, 270)
        Me.panelamount.Name = "panelamount"
        Me.panelamount.Size = New System.Drawing.Size(320, 29)
        Me.panelamount.TabIndex = 7
        '
        'txtAmount
        '
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAmount.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAmount.Location = New System.Drawing.Point(3, 4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(312, 19)
        Me.txtAmount.TabIndex = 5
        Me.txtAmount.Text = "0.00"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'panelrefdate
        '
        Me.panelrefdate.BackColor = System.Drawing.Color.White
        Me.panelrefdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelrefdate.Controls.Add(Me.dtprefdate)
        Me.panelrefdate.Location = New System.Drawing.Point(52, 216)
        Me.panelrefdate.Name = "panelrefdate"
        Me.panelrefdate.Size = New System.Drawing.Size(320, 29)
        Me.panelrefdate.TabIndex = 6
        '
        'dtprefdate
        '
        Me.dtprefdate.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtprefdate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtprefdate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtprefdate.Font = New System.Drawing.Font("Arial", 12.5!)
        Me.dtprefdate.Location = New System.Drawing.Point(-1, 0)
        Me.dtprefdate.Name = "dtprefdate"
        Me.dtprefdate.Size = New System.Drawing.Size(321, 27)
        Me.dtprefdate.TabIndex = 1
        '
        'lblconfirm
        '
        Me.lblconfirm.AutoSize = True
        Me.lblconfirm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblconfirm.Location = New System.Drawing.Point(49, 304)
        Me.lblconfirm.Name = "lblconfirm"
        Me.lblconfirm.Size = New System.Drawing.Size(47, 16)
        Me.lblconfirm.TabIndex = 31
        Me.lblconfirm.Text = "Memo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(48, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Amount"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(49, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Ref Date"
        '
        'panelexpensetype
        '
        Me.panelexpensetype.BackColor = System.Drawing.Color.White
        Me.panelexpensetype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelexpensetype.Controls.Add(Me.pctrExpensetype)
        Me.panelexpensetype.Controls.Add(Me.txtexpensetype)
        Me.panelexpensetype.Location = New System.Drawing.Point(53, 109)
        Me.panelexpensetype.Name = "panelexpensetype"
        Me.panelexpensetype.Size = New System.Drawing.Size(320, 29)
        Me.panelexpensetype.TabIndex = 1
        '
        'pctrExpensetype
        '
        Me.pctrExpensetype.BackgroundImage = Global.IRES.My.Resources.Resources.search_glyph
        Me.pctrExpensetype.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctrExpensetype.Location = New System.Drawing.Point(293, 2)
        Me.pctrExpensetype.Name = "pctrExpensetype"
        Me.pctrExpensetype.Size = New System.Drawing.Size(24, 24)
        Me.pctrExpensetype.TabIndex = 12
        Me.pctrExpensetype.TabStop = False
        '
        'txtexpensetype
        '
        Me.txtexpensetype.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtexpensetype.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtexpensetype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtexpensetype.Location = New System.Drawing.Point(3, 4)
        Me.txtexpensetype.Name = "txtexpensetype"
        Me.txtexpensetype.ReadOnly = True
        Me.txtexpensetype.Size = New System.Drawing.Size(285, 19)
        Me.txtexpensetype.TabIndex = 2
        '
        'panelrefno
        '
        Me.panelrefno.BackColor = System.Drawing.Color.White
        Me.panelrefno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelrefno.Controls.Add(Me.txtrefno)
        Me.panelrefno.Location = New System.Drawing.Point(54, 161)
        Me.panelrefno.Name = "panelrefno"
        Me.panelrefno.Size = New System.Drawing.Size(320, 29)
        Me.panelrefno.TabIndex = 2
        '
        'txtrefno
        '
        Me.txtrefno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtrefno.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtrefno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtrefno.Location = New System.Drawing.Point(3, 4)
        Me.txtrefno.Name = "txtrefno"
        Me.txtrefno.Size = New System.Drawing.Size(312, 19)
        Me.txtrefno.TabIndex = 3
        '
        'panelaccount
        '
        Me.panelaccount.BackColor = System.Drawing.Color.White
        Me.panelaccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelaccount.Controls.Add(Me.pctrSearchAccount)
        Me.panelaccount.Controls.Add(Me.txtaccoutname)
        Me.panelaccount.Location = New System.Drawing.Point(54, 52)
        Me.panelaccount.Name = "panelaccount"
        Me.panelaccount.Size = New System.Drawing.Size(320, 29)
        Me.panelaccount.TabIndex = 0
        '
        'pctrSearchAccount
        '
        Me.pctrSearchAccount.BackgroundImage = Global.IRES.My.Resources.Resources.search_glyph
        Me.pctrSearchAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctrSearchAccount.Location = New System.Drawing.Point(293, 2)
        Me.pctrSearchAccount.Name = "pctrSearchAccount"
        Me.pctrSearchAccount.Size = New System.Drawing.Size(24, 24)
        Me.pctrSearchAccount.TabIndex = 11
        Me.pctrSearchAccount.TabStop = False
        '
        'txtaccoutname
        '
        Me.txtaccoutname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtaccoutname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtaccoutname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtaccoutname.Location = New System.Drawing.Point(3, 4)
        Me.txtaccoutname.Name = "txtaccoutname"
        Me.txtaccoutname.ReadOnly = True
        Me.txtaccoutname.Size = New System.Drawing.Size(284, 19)
        Me.txtaccoutname.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(50, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Expense Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(50, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Ref No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(52, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Account"
        '
        'frmExpenseLibrary
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(442, 464)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmExpenseLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmployeeLibrary"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelmemo.ResumeLayout(False)
        Me.panelmemo.PerformLayout()
        Me.panelamount.ResumeLayout(False)
        Me.panelamount.PerformLayout()
        Me.panelrefdate.ResumeLayout(False)
        Me.panelexpensetype.ResumeLayout(False)
        Me.panelexpensetype.PerformLayout()
        CType(Me.pctrExpensetype, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelrefno.ResumeLayout(False)
        Me.panelrefno.PerformLayout()
        Me.panelaccount.ResumeLayout(False)
        Me.panelaccount.PerformLayout()
        CType(Me.pctrSearchAccount, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents panelaccount As System.Windows.Forms.Panel
    Friend WithEvents panelexpensetype As System.Windows.Forms.Panel
    Friend WithEvents panelrefno As System.Windows.Forms.Panel
    Friend WithEvents txtrefno As System.Windows.Forms.TextBox
    Friend WithEvents panelmemo As System.Windows.Forms.Panel
    Friend WithEvents txtmemo As System.Windows.Forms.TextBox
    Friend WithEvents panelamount As System.Windows.Forms.Panel
    Friend WithEvents panelrefdate As System.Windows.Forms.Panel
    Friend WithEvents lblconfirm As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtexpensetype As System.Windows.Forms.TextBox
    Friend WithEvents txtaccoutname As System.Windows.Forms.TextBox
    Friend WithEvents pctrSearchAccount As System.Windows.Forms.PictureBox
    Friend WithEvents pctrExpensetype As System.Windows.Forms.PictureBox
    Friend WithEvents dtprefdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
End Class
