Public Class AdminLayout
    Private Sub AdminLayout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call LoadUserModules()
        Call ImplementPrivileges()
        Call InitializeForms()
        Call SubLoad()
        Call LoadHeader()
    End Sub
#Region "Variables"
    Public mycurrentpage As currentpage
    'Private nxtlocation As Integer = 174
    Private interval As Integer = 45
    Public isprofileheaderfocused As Boolean
    Enum currentpage
        pageReservation = 0
        pageInvoices = 1
        pagePayments = 2
        pageCommissions = 3
        pageAgents = 4
        pageProperties = 5
        pageCustomers = 6
        pageEmployees = 7
        pageReports = 9
        pageProfile = 10
        pageCheckRegister = 11
        pageExpenses = 12
    End Enum

    ''forms
    Private fSettings As New frmSettings

    Private isshownemployees As Boolean
    Private isshowncustomers As Boolean
    Private isshownproperties As Boolean
    Private isshownagents As Boolean
    Private isshownpayments As Boolean
    Private isshowncheckregister As Boolean
    Private isshownexpenses As Boolean
    Private isshowncommisions As Boolean
    Private isshownsales As Boolean
    Private isshownprofile As Boolean
    Private isshownreports As Boolean

#End Region
#Region "Methods"
    Private Sub InitializeForms()
        fSettings.TopLevel = False
    End Sub
    Public Sub LoadHeader()
        Me.lblModule.Text = "Reservations"
        Me.ovalprofilepicDrop.BackgroundImage = ProfilePic
        Me.ovalprofilepicHead.BackgroundImage = ProfilePic
        Me.ovalprofilepicSidebar.BackgroundImage = ProfilePic

        Me.lblUsernameheader.Text = Current_UserFname & " " & Current_UserLname
        Me.lblUsernameSidebar.Text = Current_UserFname & " " & Current_UserLname
        Me.lblUsernamedrop.Text = IIf(Isadmin, Current_UserFname & " " & Current_UserLname & " - Admin", Current_UserFname & " " & Current_UserLname)

        Me.pctrCompanyLogo.Image = CompanyLogo
        Me.lblCompanyName.Text = Company_Name
        Me.lblAddress.Text = CompanyAddress
        Me.lblContactno.Text = CompanyContact
    End Sub

    Private Sub SubLoad()
        Me.mycurrentpage = currentpage.pageReservation
        Me.panelsettingheader.Visible = Isadmin

        Me.panelsettingdrop.Controls.Add(fSettings)
        fSettings.Show()
    End Sub
    Private Sub ImplementPrivileges()
        If Not Isadmin Then
            GlobalModule.GetUserModules(applicationmodule.modReservation)
            If canAdd Or canEdit Or canView Then
                'SideReservation.Location = New Point(0, nxtlocation)
                'MenuTimeLogs.Location = New Point(6, nxtlocation)
                'nxtlocation += interval
            Else
                SideReservation.Visible = False
                MenuTimeLogs.Visible = False
            End If
            GlobalModule.GetUserModules(applicationmodule.modSales)
            If canAdd Or canEdit Or canView Then
                'SideInvoices.Location = New Point(0, nxtlocation)
                'MenuShifting.Location = New Point(6, nxtlocation)
                'nxtlocation += interval
            Else
                SideInvoices.Visible = False
                MenuShifting.Visible = False
            End If
            GlobalModule.GetUserModules(applicationmodule.modPayment)
            If canAdd Or canEdit Or canView Then
                'SidePayments.Location = New Point(0, nxtlocation)
                'MenuLeave.Location = New Point(6, nxtlocation)
                'nxtlocation += interval
            Else
                SidePayments.Visible = False
                MenuLeave.Visible = False
            End If

            GlobalModule.GetUserModules(applicationmodule.modEmployees)

            If canAdd Or canEdit Or canView Then
                'SideEmployees.Location = New Point(0, nxtlocation)
                'MenuEmployees.Location = New Point(6, nxtlocation)
                'nxtlocation += interval
            Else
                SideEmployees.Visible = False
                MenuEmployees.Visible = False
            End If
            GlobalModule.GetUserModules(applicationmodule.modReports)
            If canAdd Or canEdit Or canView Then
                'SideReports.Location = New Point(0, nxtlocation)
                'MenuReports.Location = New Point(6, nxtlocation)
                'nxtlocation += interval
            Else
                SideReports.Visible = False
                MenuReports.Visible = False
            End If
            GlobalModule.GetUserModules(applicationmodule.modCheckRegister)
            If canAdd Or canEdit Or canView Then
                'SideCheckRegister.Location = New Point(0, nxtlocation)
                'MenuDepartments.Location = New Point(6, nxtlocation)
                'nxtlocation += interval
            Else
                SideCheckRegister.Visible = False
                MenuDepartments.Visible = False
            End If
            GlobalModule.GetUserModules(applicationmodule.modExpenses)
            If (canAdd Or canEdit Or canView) And IsModuleActive(applicationmodule.modExpenses) Then
                'SideExpenses.Location = New Point(0, nxtlocation)
                'MenuUsers.Location = New Point(6, nxtlocation)
                'nxtlocation += interval
            Else
                SideExpenses.Visible = False
                MenuUsers.Visible = False
            End If
        Else
            'nxtlocation = 624
            If IsModuleActive(applicationmodule.modExpenses) Then
                'SideExpenses.Location = New Point(0, nxtlocation)
                'MenuUsers.Location = New Point(6, nxtlocation)
                'nxtlocation += interval
            Else
                SideExpenses.Visible = False
                MenuUsers.Visible = False
            End If
        End If

        'panelmenulast.Location = New Point(0, nxtlocation)


    End Sub
    Private Sub Signout()
        If CustommsgBox(msgstyle.warning, msgtype.yesno, "Confirm Signout?", "Are you sure you want to signout?") Then
            AdminSignin.Show()
            Me.Dispose()
        Else
            Me.MenuUsers.BackColor = System.Drawing.SystemColors.WindowFrame
            Me.SideExpenses.BackColor = System.Drawing.SystemColors.WindowFrame
        End If
    End Sub
#End Region

#Region "MouseEnterLeave"
    Private Sub MenuReservation_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTimeLogs.MouseEnter
        Me.MenuTimeLogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SideReservation.BackColor = Color.SeaGreen
    End Sub

    Private Sub MenuInvoices_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuShifting.MouseEnter
        Me.MenuShifting.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SideInvoices.BackColor = Color.SeaGreen
    End Sub

    Private Sub MenuPayments_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLeave.MouseEnter
        Me.MenuLeave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SidePayments.BackColor = Color.SeaGreen
    End Sub

    Private Sub MenuEmployees_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEmployees.MouseEnter
        Me.MenuEmployees.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SideEmployees.BackColor = Color.SeaGreen
    End Sub


    Private Sub MenuReports_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReports.MouseEnter
        Me.MenuReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SideReports.BackColor = Color.SeaGreen
    End Sub

    Private Sub MenuLogout_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUsers.MouseEnter
        Me.MenuUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SideExpenses.BackColor = Color.SeaGreen
    End Sub

    Private Sub MenuCheckRegister_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDepartments.MouseEnter
        Me.MenuDepartments.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SideCheckRegister.BackColor = Color.SeaGreen
    End Sub

#End Region

    Private Sub MenuReservation_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTimeLogs.MouseLeave
        If Not MenuTimeLogs.ClientRectangle.Contains(MenuTimeLogs.PointToClient(Control.MousePosition)) Then
            If mycurrentpage <> currentpage.pageReservation Then
                Me.MenuTimeLogs.BackColor = System.Drawing.SystemColors.WindowFrame
                Me.SideReservation.BackColor = System.Drawing.SystemColors.WindowFrame
            End If
        End If
    End Sub

    Private Sub MenuInvoices_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuShifting.MouseLeave
        If Not MenuShifting.ClientRectangle.Contains(MenuShifting.PointToClient(Control.MousePosition)) Then
            If mycurrentpage <> currentpage.pageInvoices Then
                Me.MenuShifting.BackColor = System.Drawing.SystemColors.WindowFrame
                Me.SideInvoices.BackColor = System.Drawing.SystemColors.WindowFrame
            End If
        End If

    End Sub

    Private Sub MenuPayments_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLeave.MouseLeave
        If Not MenuLeave.ClientRectangle.Contains(MenuLeave.PointToClient(Control.MousePosition)) Then
            If mycurrentpage <> currentpage.pagePayments Then
                Me.MenuLeave.BackColor = System.Drawing.SystemColors.WindowFrame
                Me.SidePayments.BackColor = System.Drawing.SystemColors.WindowFrame
            End If
        End If

    End Sub

    
    Private Sub MenuEmployees_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEmployees.MouseLeave
        If Not MenuEmployees.ClientRectangle.Contains(MenuEmployees.PointToClient(Control.MousePosition)) Then
            If mycurrentpage <> currentpage.pageEmployees Then
                Me.MenuEmployees.BackColor = System.Drawing.SystemColors.WindowFrame
                Me.SideEmployees.BackColor = System.Drawing.SystemColors.WindowFrame
            End If
        End If

    End Sub

    Private Sub MenuReports_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReports.MouseLeave
        If Not MenuReports.ClientRectangle.Contains(MenuReports.PointToClient(Control.MousePosition)) Then
            If mycurrentpage <> currentpage.pageReports Then
                Me.MenuReports.BackColor = System.Drawing.SystemColors.WindowFrame
                Me.SideReports.BackColor = System.Drawing.SystemColors.WindowFrame
            End If
        End If
    End Sub

    Private Sub MenuExpenses_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUsers.MouseLeave
        If Not MenuUsers.ClientRectangle.Contains(MenuUsers.PointToClient(Control.MousePosition)) Then
            If mycurrentpage <> currentpage.pageExpenses Then
                Me.MenuUsers.BackColor = System.Drawing.SystemColors.WindowFrame
                Me.SideExpenses.BackColor = System.Drawing.SystemColors.WindowFrame
            End If
        End If
    End Sub

    Private Sub MenuCheckRegister_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDepartments.MouseLeave
        If Not MenuDepartments.ClientRectangle.Contains(MenuDepartments.PointToClient(Control.MousePosition)) Then
            Me.MenuDepartments.BackColor = System.Drawing.SystemColors.WindowFrame
            Me.SideCheckRegister.BackColor = System.Drawing.SystemColors.WindowFrame
        End If
    End Sub



    Private Sub lblInvoices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuShifting.Click, lblInvoices.Click
        'Call setCurrentPage(currentpage.pageInvoices)
    End Sub

    Private Sub lblPayments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLeave.Click, lblPayments.Click
        'Call setCurrentPage(currentpage.pagePayments)
    End Sub

    Private Sub lblCommissions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Call setCurrentPage(currentpage.pageCommissions)
    End Sub

    Private Sub lblAgents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Call setCurrentPage(currentpage.pageAgents)
    End Sub

    Private Sub lblProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Call setCurrentPage(currentpage.pageProperties)
    End Sub

    Private Sub lblCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Call setCurrentPage(currentpage.pageCustomers)
    End Sub

    Private Sub lblEmployees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEmployees.Click, lblEmployees.Click
        'Call setCurrentPage(currentpage.pageEmployees)
    End Sub

    Private Sub lblReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReports.Click, lblReports.Click
        'Call setCurrentPage(currentpage.pageReports)
    End Sub

    Private Sub lblcheckregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDepartments.Click, lblcheckregister.Click, Label9.Click
        'Call setCurrentPage(currentpage.pageCheckRegister)
    End Sub

    Private Sub lblLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUsers.Click, lblExpenses.Click
        'Call setCurrentPage(currentpage.pageExpenses)
    End Sub

    Private Sub panelheaderprofile_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelheaderprofile.MouseEnter
        Me.panelheaderprofile.BackColor = Color.SeaGreen
    End Sub

    Private Sub panelheaderprofile_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelheaderprofile.MouseLeave
        If Not panelheaderprofile.ClientRectangle.Contains(panelheaderprofile.PointToClient(Control.MousePosition)) Then
            If Not isprofileheaderfocused Then
                Me.panelheaderprofile.BackColor = Color.MediumSeaGreen
                paneldropprofile.Visible = False
            End If
        End If
    End Sub

    Private Sub ovalprofilepicHead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ovalprofilepicHead.Click, panelheaderprofile.Click, lblUsernameheader.Click
        If Me.isprofileheaderfocused Then
            Me.isprofileheaderfocused = False
            paneldropprofile.Visible = False
        Else
            Me.isprofileheaderfocused = True
            paneldropprofile.Visible = True

            If panelsettingdrop.Visible Then
                Me.panelsettingheader.BackColor = Color.MediumSeaGreen
                panelsettingdrop.Visible = False
            End If
        End If
    End Sub

    Private Sub btnDropProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDropProfile.Click
        Me.paneldropprofile.Visible = False
        'Call setCurrentPage(currentpage.pageProfile)
    End Sub

    Private Sub panelsettingheader_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelsettingheader.MouseEnter
        Me.panelsettingheader.BackColor = Color.SeaGreen
    End Sub
    Private Sub panelsettingheader_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelsettingheader.MouseLeave
        If Not panelsettingheader.ClientRectangle.Contains(panelsettingheader.PointToClient(Control.MousePosition)) Then
            If Not panelsettingdrop.Visible Then
                Me.panelsettingheader.BackColor = Color.MediumSeaGreen
            End If
        End If
    End Sub

    Private Sub pctrheadersetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrheadersetting.Click, panelsettingheader.Click
        panelsettingdrop.Visible = Not panelsettingdrop.Visible
        If paneldropprofile.Visible Then
            Me.panelheaderprofile.BackColor = Color.MediumSeaGreen
            paneldropprofile.Visible = False
            Me.isprofileheaderfocused = False
        End If
        If panelsettingdrop.Visible Then
            fSettings.LoadSystemDefaults()
        End If
    End Sub

    Private Sub btnSignoutdrop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignoutdrop.Click
        Call Signout()
    End Sub


    Private Sub AdminLayout_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If CType(sender, Control).Name = "AdminLayout" Then
            If CustommsgBox(msgstyle.critical, msgtype.yesno, "Confirm Exit?", "Are you sure you want to close the application?") Then
                AdminSignin.Dispose()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub MenuReservation_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MenuTimeLogs.Paint

    End Sub
End Class