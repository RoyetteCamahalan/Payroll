<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesOptions))
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancelwithRefund = New System.Windows.Forms.Button()
        Me.btnRefreshHistory = New System.Windows.Forms.Button()
        Me.btnViewPayables = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(304, 10)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(24, 20)
        Me.btnclose.TabIndex = 10
        Me.btnclose.Text = "X"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(32, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(271, 22)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "OPTIONS"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.btnCancelwithRefund)
        Me.Panel2.Controls.Add(Me.btnRefreshHistory)
        Me.Panel2.Controls.Add(Me.btnViewPayables)
        Me.Panel2.Location = New System.Drawing.Point(4, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(323, 124)
        Me.Panel2.TabIndex = 18
        '
        'btnCancelwithRefund
        '
        Me.btnCancelwithRefund.BackColor = System.Drawing.Color.Teal
        Me.btnCancelwithRefund.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCancelwithRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelwithRefund.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancelwithRefund.ForeColor = System.Drawing.Color.White
        Me.btnCancelwithRefund.Image = Global.IRES.My.Resources.Resources.ic_cancel
        Me.btnCancelwithRefund.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelwithRefund.Location = New System.Drawing.Point(0, 82)
        Me.btnCancelwithRefund.Name = "btnCancelwithRefund"
        Me.btnCancelwithRefund.Size = New System.Drawing.Size(323, 41)
        Me.btnCancelwithRefund.TabIndex = 191
        Me.btnCancelwithRefund.Text = "Forfeit Lot"
        Me.btnCancelwithRefund.UseVisualStyleBackColor = False
        '
        'btnRefreshHistory
        '
        Me.btnRefreshHistory.BackColor = System.Drawing.Color.Teal
        Me.btnRefreshHistory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRefreshHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshHistory.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnRefreshHistory.ForeColor = System.Drawing.Color.White
        Me.btnRefreshHistory.Image = Global.IRES.My.Resources.Resources.refresh
        Me.btnRefreshHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefreshHistory.Location = New System.Drawing.Point(0, 41)
        Me.btnRefreshHistory.Name = "btnRefreshHistory"
        Me.btnRefreshHistory.Size = New System.Drawing.Size(323, 41)
        Me.btnRefreshHistory.TabIndex = 190
        Me.btnRefreshHistory.Text = "Reload Payment History"
        Me.btnRefreshHistory.UseVisualStyleBackColor = False
        '
        'btnViewPayables
        '
        Me.btnViewPayables.BackColor = System.Drawing.Color.Teal
        Me.btnViewPayables.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnViewPayables.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewPayables.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnViewPayables.ForeColor = System.Drawing.Color.White
        Me.btnViewPayables.Image = CType(resources.GetObject("btnViewPayables.Image"), System.Drawing.Image)
        Me.btnViewPayables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewPayables.Location = New System.Drawing.Point(0, 0)
        Me.btnViewPayables.Name = "btnViewPayables"
        Me.btnViewPayables.Size = New System.Drawing.Size(323, 41)
        Me.btnViewPayables.TabIndex = 192
        Me.btnViewPayables.Text = "View Payment History"
        Me.btnViewPayables.UseVisualStyleBackColor = False
        '
        'frmSalesOptions
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(332, 172)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSalesOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmployeeLibrary"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnRefreshHistory As System.Windows.Forms.Button
    Friend WithEvents btnCancelwithRefund As System.Windows.Forms.Button
    Friend WithEvents btnViewPayables As System.Windows.Forms.Button
End Class
