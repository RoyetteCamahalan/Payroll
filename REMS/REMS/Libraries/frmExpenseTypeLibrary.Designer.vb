﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpenseTypeLibrary
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
        Me.panelexpensetype = New System.Windows.Forms.Panel()
        Me.txtexpensetype = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.panelexpensetype.SuspendLayout()
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
        Me.btnpositive.Location = New System.Drawing.Point(346, 85)
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
        Me.lblTitle.Size = New System.Drawing.Size(228, 22)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "Add New Expense Type"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.panelexpensetype)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnpositive)
        Me.Panel2.Location = New System.Drawing.Point(4, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(434, 128)
        Me.Panel2.TabIndex = 18
        '
        'panelexpensetype
        '
        Me.panelexpensetype.BackColor = System.Drawing.Color.White
        Me.panelexpensetype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelexpensetype.Controls.Add(Me.txtexpensetype)
        Me.panelexpensetype.Location = New System.Drawing.Point(54, 50)
        Me.panelexpensetype.Name = "panelexpensetype"
        Me.panelexpensetype.Size = New System.Drawing.Size(320, 29)
        Me.panelexpensetype.TabIndex = 0
        '
        'txtexpensetype
        '
        Me.txtexpensetype.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtexpensetype.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtexpensetype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtexpensetype.Location = New System.Drawing.Point(3, 4)
        Me.txtexpensetype.Name = "txtexpensetype"
        Me.txtexpensetype.Size = New System.Drawing.Size(312, 19)
        Me.txtexpensetype.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(50, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Expense Type"
        '
        'frmExpenseTypeLibrary
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(442, 175)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmExpenseTypeLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmployeeLibrary"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelexpensetype.ResumeLayout(False)
        Me.panelexpensetype.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnpositive As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panelexpensetype As System.Windows.Forms.Panel
    Friend WithEvents txtexpensetype As System.Windows.Forms.TextBox
End Class