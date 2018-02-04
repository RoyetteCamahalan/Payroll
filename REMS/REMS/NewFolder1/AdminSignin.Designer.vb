<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminSignin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminSignin))
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.panelusername = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panelcontainer = New System.Windows.Forms.Panel()
        Me.btnmoreoptions = New System.Windows.Forms.Button()
        Me.btnSignin = New System.Windows.Forms.Button()
        Me.panelpassword = New System.Windows.Forms.Panel()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.paneldatabaseaddress = New System.Windows.Forms.Panel()
        Me.txtdbaddress = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.paneldbuname = New System.Windows.Forms.Panel()
        Me.txtdbuname = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.paneldbpword = New System.Windows.Forms.Panel()
        Me.txtdbpword = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelusername.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelcontainer.SuspendLayout()
        Me.panelpassword.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paneldatabaseaddress.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paneldbuname.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paneldbpword.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.DarkGray
        Me.txtUsername.Location = New System.Drawing.Point(3, 8)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(232, 19)
        Me.txtUsername.TabIndex = 4
        Me.txtUsername.Text = "Username"
        '
        'panelusername
        '
        Me.panelusername.BackColor = System.Drawing.Color.White
        Me.panelusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelusername.Controls.Add(Me.txtUsername)
        Me.panelusername.Controls.Add(Me.PictureBox1)
        Me.panelusername.Location = New System.Drawing.Point(47, 64)
        Me.panelusername.Name = "panelusername"
        Me.panelusername.Size = New System.Drawing.Size(274, 36)
        Me.panelusername.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(235, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panelcontainer
        '
        Me.Panelcontainer.BackColor = System.Drawing.Color.White
        Me.Panelcontainer.Controls.Add(Me.btnmoreoptions)
        Me.Panelcontainer.Controls.Add(Me.btnSignin)
        Me.Panelcontainer.Controls.Add(Me.panelpassword)
        Me.Panelcontainer.Controls.Add(Me.panelusername)
        Me.Panelcontainer.Controls.Add(Me.paneldatabaseaddress)
        Me.Panelcontainer.Controls.Add(Me.paneldbuname)
        Me.Panelcontainer.Controls.Add(Me.paneldbpword)
        Me.Panelcontainer.Controls.Add(Me.Label1)
        Me.Panelcontainer.Location = New System.Drawing.Point(25, 82)
        Me.Panelcontainer.Name = "Panelcontainer"
        Me.Panelcontainer.Size = New System.Drawing.Size(369, 250)
        Me.Panelcontainer.TabIndex = 8
        '
        'btnmoreoptions
        '
        Me.btnmoreoptions.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnmoreoptions.FlatAppearance.BorderSize = 0
        Me.btnmoreoptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnmoreoptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmoreoptions.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnmoreoptions.ForeColor = System.Drawing.Color.White
        Me.btnmoreoptions.Location = New System.Drawing.Point(187, 165)
        Me.btnmoreoptions.Name = "btnmoreoptions"
        Me.btnmoreoptions.Size = New System.Drawing.Size(134, 35)
        Me.btnmoreoptions.TabIndex = 11
        Me.btnmoreoptions.Text = "More Options >>"
        Me.btnmoreoptions.UseVisualStyleBackColor = False
        '
        'btnSignin
        '
        Me.btnSignin.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSignin.FlatAppearance.BorderSize = 0
        Me.btnSignin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignin.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSignin.ForeColor = System.Drawing.Color.White
        Me.btnSignin.Location = New System.Drawing.Point(47, 165)
        Me.btnSignin.Name = "btnSignin"
        Me.btnSignin.Size = New System.Drawing.Size(134, 35)
        Me.btnSignin.TabIndex = 10
        Me.btnSignin.Text = "Sign in"
        Me.btnSignin.UseVisualStyleBackColor = False
        '
        'panelpassword
        '
        Me.panelpassword.BackColor = System.Drawing.Color.White
        Me.panelpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelpassword.Controls.Add(Me.txtpassword)
        Me.panelpassword.Controls.Add(Me.PictureBox2)
        Me.panelpassword.Location = New System.Drawing.Point(47, 114)
        Me.panelpassword.Name = "panelpassword"
        Me.panelpassword.Size = New System.Drawing.Size(274, 36)
        Me.panelpassword.TabIndex = 8
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpassword.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtpassword.ForeColor = System.Drawing.Color.DarkGray
        Me.txtpassword.Location = New System.Drawing.Point(3, 8)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(232, 19)
        Me.txtpassword.TabIndex = 4
        Me.txtpassword.Text = "Password"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(241, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'paneldatabaseaddress
        '
        Me.paneldatabaseaddress.BackColor = System.Drawing.Color.White
        Me.paneldatabaseaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneldatabaseaddress.Controls.Add(Me.txtdbaddress)
        Me.paneldatabaseaddress.Controls.Add(Me.PictureBox5)
        Me.paneldatabaseaddress.Location = New System.Drawing.Point(47, 51)
        Me.paneldatabaseaddress.Name = "paneldatabaseaddress"
        Me.paneldatabaseaddress.Size = New System.Drawing.Size(274, 36)
        Me.paneldatabaseaddress.TabIndex = 14
        Me.paneldatabaseaddress.Visible = False
        '
        'txtdbaddress
        '
        Me.txtdbaddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdbaddress.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtdbaddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtdbaddress.Location = New System.Drawing.Point(3, 8)
        Me.txtdbaddress.Name = "txtdbaddress"
        Me.txtdbaddress.Size = New System.Drawing.Size(232, 19)
        Me.txtdbaddress.TabIndex = 4
        Me.txtdbaddress.Text = "Database Location"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(238, 1)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'paneldbuname
        '
        Me.paneldbuname.BackColor = System.Drawing.Color.White
        Me.paneldbuname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneldbuname.Controls.Add(Me.txtdbuname)
        Me.paneldbuname.Controls.Add(Me.PictureBox4)
        Me.paneldbuname.Location = New System.Drawing.Point(47, 93)
        Me.paneldbuname.Name = "paneldbuname"
        Me.paneldbuname.Size = New System.Drawing.Size(274, 36)
        Me.paneldbuname.TabIndex = 13
        Me.paneldbuname.Visible = False
        '
        'txtdbuname
        '
        Me.txtdbuname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdbuname.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtdbuname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtdbuname.Location = New System.Drawing.Point(3, 8)
        Me.txtdbuname.Name = "txtdbuname"
        Me.txtdbuname.Size = New System.Drawing.Size(232, 19)
        Me.txtdbuname.TabIndex = 4
        Me.txtdbuname.Text = "Database Username"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(238, 1)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'paneldbpword
        '
        Me.paneldbpword.BackColor = System.Drawing.Color.White
        Me.paneldbpword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneldbpword.Controls.Add(Me.txtdbpword)
        Me.paneldbpword.Controls.Add(Me.PictureBox3)
        Me.paneldbpword.Location = New System.Drawing.Point(47, 135)
        Me.paneldbpword.Name = "paneldbpword"
        Me.paneldbpword.Size = New System.Drawing.Size(274, 36)
        Me.paneldbpword.TabIndex = 12
        Me.paneldbpword.Visible = False
        '
        'txtdbpword
        '
        Me.txtdbpword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdbpword.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtdbpword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtdbpword.Location = New System.Drawing.Point(3, 8)
        Me.txtdbpword.Name = "txtdbpword"
        Me.txtdbpword.Size = New System.Drawing.Size(232, 19)
        Me.txtdbpword.TabIndex = 4
        Me.txtdbpword.Text = "Database Password"
        Me.txtdbpword.UseSystemPasswordChar = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(238, 1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(100, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Sign in to start your session"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(9, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(402, 32)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Integrated Real Estate Software"
        '
        'AdminSignin
        '
        Me.AcceptButton = Me.btnSignin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(420, 381)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panelcontainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminSignin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelusername.ResumeLayout(False)
        Me.panelusername.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelcontainer.ResumeLayout(False)
        Me.Panelcontainer.PerformLayout()
        Me.panelpassword.ResumeLayout(False)
        Me.panelpassword.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paneldatabaseaddress.ResumeLayout(False)
        Me.paneldatabaseaddress.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paneldbuname.ResumeLayout(False)
        Me.paneldbuname.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paneldbpword.ResumeLayout(False)
        Me.paneldbpword.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents panelusername As System.Windows.Forms.Panel
    Friend WithEvents Panelcontainer As System.Windows.Forms.Panel
    Friend WithEvents panelpassword As System.Windows.Forms.Panel
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnmoreoptions As System.Windows.Forms.Button
    Friend WithEvents btnSignin As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents paneldatabaseaddress As System.Windows.Forms.Panel
    Friend WithEvents txtdbaddress As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents paneldbuname As System.Windows.Forms.Panel
    Friend WithEvents txtdbuname As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents paneldbpword As System.Windows.Forms.Panel
    Friend WithEvents txtdbpword As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
