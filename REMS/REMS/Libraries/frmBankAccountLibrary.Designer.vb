<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankAccountLibrary
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
        Me.paneltin = New System.Windows.Forms.Panel()
        Me.txtpreffered = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelaccountname = New System.Windows.Forms.Panel()
        Me.txtaccountname = New System.Windows.Forms.TextBox()
        Me.panelaccoutno = New System.Windows.Forms.Panel()
        Me.txtaccoutno = New System.Windows.Forms.TextBox()
        Me.panelbank = New System.Windows.Forms.Panel()
        Me.cmbBank = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkisactive = New System.Windows.Forms.CheckBox()
        Me.Panel2.SuspendLayout()
        Me.paneltin.SuspendLayout()
        Me.panelaccountname.SuspendLayout()
        Me.panelaccoutno.SuspendLayout()
        Me.panelbank.SuspendLayout()
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
        Me.btnpositive.Location = New System.Drawing.Point(346, 258)
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
        Me.lblTitle.Size = New System.Drawing.Size(225, 22)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "Add New Bank Account"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.paneltin)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.panelaccountname)
        Me.Panel2.Controls.Add(Me.panelaccoutno)
        Me.Panel2.Controls.Add(Me.panelbank)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnpositive)
        Me.Panel2.Controls.Add(Me.chkisactive)
        Me.Panel2.Location = New System.Drawing.Point(4, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(434, 301)
        Me.Panel2.TabIndex = 18
        '
        'paneltin
        '
        Me.paneltin.BackColor = System.Drawing.Color.White
        Me.paneltin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneltin.Controls.Add(Me.txtpreffered)
        Me.paneltin.Location = New System.Drawing.Point(54, 212)
        Me.paneltin.Name = "paneltin"
        Me.paneltin.Size = New System.Drawing.Size(320, 29)
        Me.paneltin.TabIndex = 32
        '
        'txtpreffered
        '
        Me.txtpreffered.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpreffered.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtpreffered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpreffered.Location = New System.Drawing.Point(3, 4)
        Me.txtpreffered.Name = "txtpreffered"
        Me.txtpreffered.Size = New System.Drawing.Size(312, 19)
        Me.txtpreffered.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(51, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 16)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Preffered Bank Branch"
        '
        'panelaccountname
        '
        Me.panelaccountname.BackColor = System.Drawing.Color.White
        Me.panelaccountname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelaccountname.Controls.Add(Me.txtaccountname)
        Me.panelaccountname.Location = New System.Drawing.Point(53, 108)
        Me.panelaccountname.Name = "panelaccountname"
        Me.panelaccountname.Size = New System.Drawing.Size(320, 29)
        Me.panelaccountname.TabIndex = 1
        '
        'txtaccountname
        '
        Me.txtaccountname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtaccountname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtaccountname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtaccountname.Location = New System.Drawing.Point(3, 4)
        Me.txtaccountname.MaxLength = 50
        Me.txtaccountname.Name = "txtaccountname"
        Me.txtaccountname.Size = New System.Drawing.Size(312, 19)
        Me.txtaccountname.TabIndex = 2
        '
        'panelaccoutno
        '
        Me.panelaccoutno.BackColor = System.Drawing.Color.White
        Me.panelaccoutno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelaccoutno.Controls.Add(Me.txtaccoutno)
        Me.panelaccoutno.Location = New System.Drawing.Point(54, 160)
        Me.panelaccoutno.Name = "panelaccoutno"
        Me.panelaccoutno.Size = New System.Drawing.Size(320, 29)
        Me.panelaccoutno.TabIndex = 2
        '
        'txtaccoutno
        '
        Me.txtaccoutno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtaccoutno.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtaccoutno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtaccoutno.Location = New System.Drawing.Point(3, 4)
        Me.txtaccoutno.MaxLength = 30
        Me.txtaccoutno.Name = "txtaccoutno"
        Me.txtaccoutno.Size = New System.Drawing.Size(312, 19)
        Me.txtaccoutno.TabIndex = 3
        '
        'panelbank
        '
        Me.panelbank.BackColor = System.Drawing.Color.White
        Me.panelbank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelbank.Controls.Add(Me.cmbBank)
        Me.panelbank.Location = New System.Drawing.Point(54, 51)
        Me.panelbank.Name = "panelbank"
        Me.panelbank.Size = New System.Drawing.Size(320, 27)
        Me.panelbank.TabIndex = 0
        '
        'cmbBank
        '
        Me.cmbBank.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.cmbBank.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.cmbBank.FormattingEnabled = True
        Me.cmbBank.Location = New System.Drawing.Point(-1, 0)
        Me.cmbBank.Name = "cmbBank"
        Me.cmbBank.Size = New System.Drawing.Size(320, 25)
        Me.cmbBank.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(50, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Account Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(50, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Accout Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(50, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Bank Name"
        '
        'chkisactive
        '
        Me.chkisactive.AutoSize = True
        Me.chkisactive.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chkisactive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkisactive.Location = New System.Drawing.Point(295, 33)
        Me.chkisactive.Name = "chkisactive"
        Me.chkisactive.Size = New System.Drawing.Size(88, 20)
        Me.chkisactive.TabIndex = 34
        Me.chkisactive.Text = "Is Active?"
        Me.chkisactive.UseVisualStyleBackColor = True
        '
        'frmAccountLibrary
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(442, 348)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAccountLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmployeeLibrary"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.paneltin.ResumeLayout(False)
        Me.paneltin.PerformLayout()
        Me.panelaccountname.ResumeLayout(False)
        Me.panelaccountname.PerformLayout()
        Me.panelaccoutno.ResumeLayout(False)
        Me.panelaccoutno.PerformLayout()
        Me.panelbank.ResumeLayout(False)
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
    Friend WithEvents panelbank As System.Windows.Forms.Panel
    Friend WithEvents panelaccountname As System.Windows.Forms.Panel
    Friend WithEvents txtaccountname As System.Windows.Forms.TextBox
    Friend WithEvents panelaccoutno As System.Windows.Forms.Panel
    Friend WithEvents txtaccoutno As System.Windows.Forms.TextBox
    Friend WithEvents paneltin As System.Windows.Forms.Panel
    Friend WithEvents txtpreffered As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbBank As System.Windows.Forms.ComboBox
    Friend WithEvents chkisactive As System.Windows.Forms.CheckBox
End Class
