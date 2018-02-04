<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPropertyLibrary
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
        Me.paneladdress = New System.Windows.Forms.Panel()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.panelarea = New System.Windows.Forms.Panel()
        Me.txtarea = New System.Windows.Forms.TextBox()
        Me.panelproperty = New System.Windows.Forms.Panel()
        Me.txtpropertyname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.paneladdress.SuspendLayout()
        Me.panelarea.SuspendLayout()
        Me.panelproperty.SuspendLayout()
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
        Me.btnpositive.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnpositive.FlatAppearance.BorderSize = 0
        Me.btnpositive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnpositive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpositive.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnpositive.ForeColor = System.Drawing.Color.White
        Me.btnpositive.Location = New System.Drawing.Point(336, 216)
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
        Me.lblTitle.Text = "Add New Property"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.paneladdress)
        Me.Panel2.Controls.Add(Me.panelarea)
        Me.Panel2.Controls.Add(Me.panelproperty)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnpositive)
        Me.Panel2.Location = New System.Drawing.Point(4, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(434, 264)
        Me.Panel2.TabIndex = 18
        '
        'paneladdress
        '
        Me.paneladdress.BackColor = System.Drawing.Color.White
        Me.paneladdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneladdress.Controls.Add(Me.txtaddress)
        Me.paneladdress.Location = New System.Drawing.Point(53, 107)
        Me.paneladdress.Name = "paneladdress"
        Me.paneladdress.Size = New System.Drawing.Size(320, 29)
        Me.paneladdress.TabIndex = 1
        '
        'txtaddress
        '
        Me.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtaddress.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtaddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtaddress.Location = New System.Drawing.Point(3, 4)
        Me.txtaddress.MaxLength = 255
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(312, 19)
        Me.txtaddress.TabIndex = 2
        '
        'panelarea
        '
        Me.panelarea.BackColor = System.Drawing.Color.White
        Me.panelarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelarea.Controls.Add(Me.txtarea)
        Me.panelarea.Location = New System.Drawing.Point(54, 159)
        Me.panelarea.Name = "panelarea"
        Me.panelarea.Size = New System.Drawing.Size(320, 29)
        Me.panelarea.TabIndex = 2
        '
        'txtarea
        '
        Me.txtarea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtarea.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtarea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtarea.Location = New System.Drawing.Point(3, 4)
        Me.txtarea.Name = "txtarea"
        Me.txtarea.Size = New System.Drawing.Size(312, 19)
        Me.txtarea.TabIndex = 3
        '
        'panelproperty
        '
        Me.panelproperty.BackColor = System.Drawing.Color.White
        Me.panelproperty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelproperty.Controls.Add(Me.txtpropertyname)
        Me.panelproperty.Location = New System.Drawing.Point(54, 50)
        Me.panelproperty.Name = "panelproperty"
        Me.panelproperty.Size = New System.Drawing.Size(320, 29)
        Me.panelproperty.TabIndex = 0
        '
        'txtpropertyname
        '
        Me.txtpropertyname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpropertyname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtpropertyname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpropertyname.Location = New System.Drawing.Point(3, 4)
        Me.txtpropertyname.Name = "txtpropertyname"
        Me.txtpropertyname.Size = New System.Drawing.Size(312, 19)
        Me.txtpropertyname.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(50, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(50, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Area(sqm)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(50, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Property Name"
        '
        'frmPropertyLibrary
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(442, 311)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPropertyLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmployeeLibrary"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.paneladdress.ResumeLayout(False)
        Me.paneladdress.PerformLayout()
        Me.panelarea.ResumeLayout(False)
        Me.panelarea.PerformLayout()
        Me.panelproperty.ResumeLayout(False)
        Me.panelproperty.PerformLayout()
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
    Friend WithEvents panelproperty As System.Windows.Forms.Panel
    Friend WithEvents txtpropertyname As System.Windows.Forms.TextBox
    Friend WithEvents paneladdress As System.Windows.Forms.Panel
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents panelarea As System.Windows.Forms.Panel
    Friend WithEvents txtarea As System.Windows.Forms.TextBox
End Class
