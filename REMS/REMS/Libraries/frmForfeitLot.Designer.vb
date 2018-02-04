<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForfeitLot
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpdateforfeited = New System.Windows.Forms.DateTimePicker()
        Me.chkrefund = New System.Windows.Forms.CheckBox()
        Me.panelreceivedby = New System.Windows.Forms.Panel()
        Me.txtreceivedby = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panelrefundamount = New System.Windows.Forms.Panel()
        Me.txtrefundamount = New System.Windows.Forms.TextBox()
        Me.panelReason = New System.Windows.Forms.Panel()
        Me.txtreason = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.panelreceivedby.SuspendLayout()
        Me.panelrefundamount.SuspendLayout()
        Me.panelReason.SuspendLayout()
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
        Me.btnpositive.Location = New System.Drawing.Point(306, 294)
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
        Me.lblTitle.Size = New System.Drawing.Size(105, 22)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "Forfeit Lot"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.dtpdateforfeited)
        Me.Panel2.Controls.Add(Me.chkrefund)
        Me.Panel2.Controls.Add(Me.panelreceivedby)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.panelrefundamount)
        Me.Panel2.Controls.Add(Me.panelReason)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnpositive)
        Me.Panel2.Location = New System.Drawing.Point(4, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(394, 337)
        Me.Panel2.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(36, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Date Forfeited"
        '
        'dtpdateforfeited
        '
        Me.dtpdateforfeited.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpdateforfeited.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpdateforfeited.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpdateforfeited.Font = New System.Drawing.Font("Arial", 12.5!)
        Me.dtpdateforfeited.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdateforfeited.Location = New System.Drawing.Point(40, 50)
        Me.dtpdateforfeited.Name = "dtpdateforfeited"
        Me.dtpdateforfeited.Size = New System.Drawing.Size(320, 27)
        Me.dtpdateforfeited.TabIndex = 38
        '
        'chkrefund
        '
        Me.chkrefund.AutoSize = True
        Me.chkrefund.Checked = True
        Me.chkrefund.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkrefund.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chkrefund.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkrefund.Location = New System.Drawing.Point(40, 154)
        Me.chkrefund.Name = "chkrefund"
        Me.chkrefund.Size = New System.Drawing.Size(94, 20)
        Me.chkrefund.TabIndex = 19
        Me.chkrefund.Text = "Is Refund?"
        Me.chkrefund.UseVisualStyleBackColor = True
        '
        'panelreceivedby
        '
        Me.panelreceivedby.BackColor = System.Drawing.Color.White
        Me.panelreceivedby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelreceivedby.Controls.Add(Me.txtreceivedby)
        Me.panelreceivedby.Location = New System.Drawing.Point(55, 245)
        Me.panelreceivedby.Name = "panelreceivedby"
        Me.panelreceivedby.Size = New System.Drawing.Size(305, 29)
        Me.panelreceivedby.TabIndex = 36
        '
        'txtreceivedby
        '
        Me.txtreceivedby.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtreceivedby.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtreceivedby.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtreceivedby.Location = New System.Drawing.Point(3, 4)
        Me.txtreceivedby.Name = "txtreceivedby"
        Me.txtreceivedby.Size = New System.Drawing.Size(297, 19)
        Me.txtreceivedby.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(52, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Received By"
        '
        'panelrefundamount
        '
        Me.panelrefundamount.BackColor = System.Drawing.Color.White
        Me.panelrefundamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelrefundamount.Controls.Add(Me.txtrefundamount)
        Me.panelrefundamount.Location = New System.Drawing.Point(55, 193)
        Me.panelrefundamount.Name = "panelrefundamount"
        Me.panelrefundamount.Size = New System.Drawing.Size(305, 29)
        Me.panelrefundamount.TabIndex = 2
        '
        'txtrefundamount
        '
        Me.txtrefundamount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtrefundamount.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtrefundamount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtrefundamount.Location = New System.Drawing.Point(3, 3)
        Me.txtrefundamount.Name = "txtrefundamount"
        Me.txtrefundamount.Size = New System.Drawing.Size(297, 19)
        Me.txtrefundamount.TabIndex = 3
        '
        'panelReason
        '
        Me.panelReason.BackColor = System.Drawing.Color.White
        Me.panelReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelReason.Controls.Add(Me.txtreason)
        Me.panelReason.Location = New System.Drawing.Point(40, 100)
        Me.panelReason.Name = "panelReason"
        Me.panelReason.Size = New System.Drawing.Size(320, 48)
        Me.panelReason.TabIndex = 0
        '
        'txtreason
        '
        Me.txtreason.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtreason.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtreason.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtreason.Location = New System.Drawing.Point(3, 4)
        Me.txtreason.Multiline = True
        Me.txtreason.Name = "txtreason"
        Me.txtreason.Size = New System.Drawing.Size(312, 39)
        Me.txtreason.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(52, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Refund Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(36, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Reason"
        '
        'frmForfeitLot
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(402, 384)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmForfeitLot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmployeeLibrary"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelreceivedby.ResumeLayout(False)
        Me.panelreceivedby.PerformLayout()
        Me.panelrefundamount.ResumeLayout(False)
        Me.panelrefundamount.PerformLayout()
        Me.panelReason.ResumeLayout(False)
        Me.panelReason.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnpositive As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panelReason As System.Windows.Forms.Panel
    Friend WithEvents txtreason As System.Windows.Forms.TextBox
    Friend WithEvents panelrefundamount As System.Windows.Forms.Panel
    Friend WithEvents txtrefundamount As System.Windows.Forms.TextBox
    Friend WithEvents panelreceivedby As System.Windows.Forms.Panel
    Friend WithEvents txtreceivedby As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkrefund As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpdateforfeited As System.Windows.Forms.DateTimePicker
End Class
