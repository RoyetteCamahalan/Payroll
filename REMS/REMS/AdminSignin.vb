Public Class AdminSignin

#Region "Variables"
    Private isoptionshown As Boolean
    Private fontcolor As Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
    Private hintcolor As Color = Color.DarkGray
    Dim erp As New ErrorProvider
    ''hints
    Private unamehint As String = "Username"
    Private pwordhint As String = "Password"
    Private dblocationhint As String = "Database Location"
    Private dbunamehint As String = "Database Username"
    Private dbpwordhint As String = "Database Password"
#End Region
#Region "Methods"
    Private Sub LoadData()
        Me.txtdbaddress.Text = My.Settings.ServerName
        Me.txtdbuname.Text = My.Settings.DatabaseUserID
        Me.txtdbpword.Text = My.Settings.DatabasePassword
    End Sub
    Private Sub ShowOptions()
        LoadData()
        Me.btnmoreoptions.Text = "<< Hide Options"
        Me.isoptionshown = True
        paneldatabaseaddress.Visible = True
        paneldbuname.Visible = True
        paneldbpword.Visible = True
        Me.Size = New Size(436, 447)
        Me.panelusername.Location = New Point(47, 177)
        Me.panelpassword.Location = New Point(47, 220)
        Me.btnSignin.Location = New Point(47, 262)
        Me.btnmoreoptions.Location = New Point(187, 262)
        Me.Panelcontainer.Size = New Size(369, 314)
    End Sub
    Private Sub HideOptions()
        Me.btnmoreoptions.Text = "Show Options >>"
        Me.isoptionshown = False
        paneldatabaseaddress.Visible = False
        paneldbuname.Visible = False
        paneldbpword.Visible = False
        Me.Size = New Size(436, 420)
        Me.panelusername.Location = New Point(47, 64)
        Me.panelpassword.Location = New Point(47, 114)
        Me.btnSignin.Location = New Point(47, 165)
        Me.btnmoreoptions.Location = New Point(187, 165)
        Me.Panelcontainer.Size = New Size(369, 250)
    End Sub
    Private Sub seterror(ByRef ctr As Control, Optional ByRef msg As String = "")
        erp.SetError(ctr, msg)
    End Sub
    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True
        If isoptionshown Then
            If txtdbaddress.Text = dblocationhint Then
                isvalid = False
                seterror(paneldatabaseaddress, "This field is required!")
            Else
                seterror(paneldatabaseaddress)
            End If
            If txtdbuname.Text = dbunamehint Then
                isvalid = False
                seterror(paneldbuname, "This field is required!")
            Else
                seterror(paneldbuname)
            End If
            If txtdbpword.Text = dbpwordhint Then
                isvalid = False
                seterror(paneldbpword, "This field is required!")
            Else
                seterror(paneldbpword)
            End If
        End If
        If txtUsername.Text = unamehint Then
            isvalid = False
            seterror(panelusername, "This field is required!")
        Else
            seterror(panelusername)
        End If
        If txtpassword.Text = pwordhint Then
            isvalid = False
            seterror(panelpassword, "This field is required!")
        Else
            seterror(panelpassword)
        End If
        Return isvalid
    End Function
    Private Function CheckConnection() As Boolean
        Dim isconnected As Boolean
        If isoptionshown Then
            isconnected = connect(Me.txtdbaddress.Text, Me.txtdbuname.Text, Me.txtdbpword.Text)
            My.Settings.ServerName = txtdbaddress.Text
            My.Settings.DatabaseUserID = txtdbuname.Text
            My.Settings.DatabasePassword = txtdbpword.Text
            My.Settings.Save()
        Else
            isconnected = connect(My.Settings.ServerName, My.Settings.DatabaseUserID, My.Settings.DatabasePassword)
        End If
        Return isconnected
    End Function
    Private Sub ProceedLogin()
        If isallfieldvalid() Then
            If CheckConnection() Then
                Try
                    Dim DT As DataTable = clsEmployees.GetUsers(0, "", Me.txtUsername.Text, Utility.GetHash(Me.txtpassword.Text))
                    If DT.Rows.Count > 0 Then
                        seterror(Me.panelusername)
                        seterror(Me.panelpassword)
                        Isadmin = DT.Rows(0).Item("isappsysadmin")
                        Current_UserID = DT.Rows(0).Item("employeeid")
                        CurrentUsername = DT.Rows(0).Item("username")
                        CurrentPassword = DT.Rows(0).Item("userpass")
                        Current_UserFname = DT.Rows(0).Item("firstname")
                        Current_UserLname = DT.Rows(0).Item("lastname")
                        Current_UserMname = DT.Rows(0).Item("middlename")
                        Current_UserGender = DT.Rows(0).Item("gender")
                        Try
                            If Not IsDBNull(DT.Rows(0).Item("photo")) Then
                                Dim tempphoto As Byte() = DT.Rows(0).Item("photo")
                                If tempphoto.Length > 0 Then
                                    ProfilePic = Utility.convertImage(DT.Rows(0).Item("photo")) 'image here
                                End If
                            Else
                                ProfilePic = My.Resources.no_image
                            End If
                        Catch ex As Exception
                            ProfilePic = My.Resources.no_image
                        End Try

                        GetCompanyInfo()
                        AdminLayout.Show()
                        Me.Hide()
                        txtpassword.Text = ""
                    Else
                        seterror(Me.panelusername, "Username and Password does not exist")
                        seterror(Me.panelpassword, "Username and Password does not exist")
                        txtUsername.Text = ""
                        txtUsername.Text = ""
                    End If
                Catch ex As Exception

                End Try
            Else
                CustommsgBox(msgstyle.critical, msgtype.okonly, "Failed Connection", "Unable to establish connection to the server, Please check connection configurations.")
            End If
        End If
    End Sub
#End Region


    Private Sub btnmoreoptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmoreoptions.Click
        If isoptionshown Then
            HideOptions()
        Else
            ShowOptions()
        End If
    End Sub

    Private Sub txtUsername_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.Enter
        With Me.txtUsername
            If .Text = unamehint Then
                .Text = ""
                .ForeColor = Me.fontcolor
            End If
        End With
    End Sub

    Private Sub txtUsername_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.Leave
        With Me.txtUsername
            If Trim(.Text) = "" Then
                .Text = unamehint
                .ForeColor = Me.hintcolor
            End If
        End With
    End Sub

    Private Sub txtpassword_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.Enter
        Me.txtpassword.UseSystemPasswordChar = True
        With Me.txtpassword
            If .Text = pwordhint Then
                .Text = ""
                .ForeColor = Me.fontcolor
            End If
        End With
    End Sub

    Private Sub txtpassword_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.Leave
        With Me.txtpassword
            If .Text = "" Then
                .Text = pwordhint
                .ForeColor = Me.hintcolor
                Me.txtpassword.UseSystemPasswordChar = False
            End If
        End With
    End Sub

    Private Sub txtdbaddress_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdbaddress.Enter
        With Me.txtdbaddress
            If .Text = dblocationhint Then
                .Text = ""
                .ForeColor = Me.fontcolor
            End If
        End With
    End Sub

    Private Sub txtdbaddress_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdbaddress.Leave
        With Me.txtdbaddress
            If Trim(.Text) = "" Then
                .Text = dblocationhint
                .ForeColor = Me.hintcolor
            End If
        End With
    End Sub

    Private Sub txtdbuname_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdbuname.Enter
        With Me.txtdbuname
            If .Text = dbunamehint Then
                .Text = ""
                .ForeColor = Me.fontcolor
            End If
        End With
    End Sub

    Private Sub txtdbuname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdbuname.Leave
        With Me.txtdbuname
            If Trim(.Text) = "" Then
                .Text = dbunamehint
                .ForeColor = Me.hintcolor
            End If
        End With
    End Sub

    Private Sub txtdbpword_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdbpword.Enter
        Me.txtdbpword.UseSystemPasswordChar = True
        With Me.txtdbpword
            If .Text = dbpwordhint Then
                .Text = ""
                .ForeColor = Me.fontcolor
            End If
        End With
    End Sub

    Private Sub txtdbpword_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdbpword.Leave
        With Me.txtdbpword
            If .Text = "" Then
                .Text = dbpwordhint
                .ForeColor = Me.hintcolor
                Me.txtdbpword.UseSystemPasswordChar = False
            End If
        End With
    End Sub

    Private Sub btnSignin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignin.Click
        Call ProceedLogin()
    End Sub
End Class