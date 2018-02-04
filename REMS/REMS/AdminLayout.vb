Public Class AdminLayout
    Private Sub AdminLayout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadUserModules()
        Call ImplementPrivileges()
        Call InitializeForms()
        Call SubLoad()
        Call LoadHeader()
    End Sub
#Region "Variables"
    Public mycurrentpage As currentpage
    Private nxtlocation As Integer = 174
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
    Private fReservations As New frmReservations
    Private fEmployees As New frmEmployees
    Private fCustomers As New frmCustomers
    Private fProperty As New frmProperties
    Private fAgents As New frmAllAgents
    Private fPayments As New frmPayments
    Private fcheckregister As New frmCheckRegister
    Private fExpenses As New frmExpenses
    Private fCommisions As New frmCommisions
    Private fSales As New frmSales
    Private fProfile As New frmProfile
    Private fReports As New frmReports

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
        fReservations.TopLevel = False
        fEmployees.TopLevel = False
        fCustomers.TopLevel = False
        fProperty.TopLevel = False
        fAgents.TopLevel = False
        fPayments.TopLevel = False
        fcheckregister.TopLevel = False
        fExpenses.TopLevel = False
        fCommisions.TopLevel = False
        fSales.TopLevel = False
        fProfile.TopLevel = False
        fReports.TopLevel = False
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
        Me.MainPanel.Controls.Add(fReservations)
        fReservations.Show()
    End Sub
    Private Sub ImplementPrivileges()
        If Not Isadmin Then
            GlobalModule.GetUserModules(applicationmodule.modReservation)
            If canAdd Or canEdit Or canView Then
                SideReservation.Location = New Point(0, nxtlocation)
                MenuReservation.Location = New Point(6, nxtlocation)
                nxtlocation += interval
            Else
                SideReservation.Visible = False
                MenuReservation.Visible = False
            End If
            GlobalModule.GetUserModules(applicationmodule.modSales)
            If canAdd Or canEdit Or canView Then
                SideInvoices.Location = New Point(0, nxtlocation)
                MenuInvoices.Location = New Point(6, nxtlocation)
                nxtlocation += interval
            Else
                SideInvoices.Visible = False
                MenuInvoices.Visible = False
            End If
            GlobalModule.GetUserModules(applicationmodule.modPayment)
            If canAdd Or canEdit Or canView Then
                SidePayments.Location = New Point(0, nxtlocation)
                MenuPayments.Location = New Point(6, nxtlocation)
                nxtlocation += interval
            Else
                SidePayments.Visible = False
                MenuPayments.Visible = False
            End If
            GlobalModule.GetUserModules(applicationmodule.modCommissions)
            If canAdd Or canEdit Or canView Then
                SideCommissions.Location = New Point(0, nxtlocation)
                MenuCommissions.Location = New Point(6, nxtlocation)
                nxtlocation += interval
            Else
                SideCommissions.Visible = False
                MenuCommissions.Visible = False
            End If
            GlobalModule.GetUserModules(applicationmodule.modAgents)
            If canAdd Or canEdit Or canView Then
                SideAgents.Location = New Point(0, nxtlocation)
                MenuAgents.Location = New Point(6, nxtlocation)
                nxtlocation += interval
            Else
                SideAgents.Visible = False
                MenuAgents.Visible = False
            End If
            GlobalModule.GetUserModules(applicationmodule.modProperties)
            If canAdd Or canEdit Or canView Then
                SideProperties.Location = New Point(0, nxtlocation)
                MenuProperties.Location = New Point(6, nxtlocation)
                nxtlocation += interval
            Else
                SideProperties.Visible = False
                MenuProperties.Visible = False
            End If
            GlobalModule.GetUserModules(applicationmodule.modCustomers)
            If canAdd Or canEdit Or canView Then
                SideCustomers.Location = New Point(0, nxtlocation)
                MenuCustomers.Location = New Point(6, nxtlocation)
                nxtlocation += interval
            Else
                SideCustomers.Visible = False
                MenuCustomers.Visible = False
            End If
            GlobalModule.GetUserModules(applicationmodule.modEmployees)
            If canAdd Or canEdit Or canView Then
                SideEmployees.Location = New Point(0, nxtlocation)
                MenuEmployees.Location = New Point(6, nxtlocation)
                nxtlocation += interval
            Else
                SideEmployees.Visible = False
                MenuEmployees.Visible = False
            End If
            GlobalModule.GetUserModules(applicationmodule.modReports)
            If canAdd Or canEdit Or canView Then
                SideReports.Location = New Point(0, nxtlocation)
                MenuReports.Location = New Point(6, nxtlocation)
                nxtlocation += interval
            Else
                SideReports.Visible = False
                MenuReports.Visible = False
            End If
            GlobalModule.GetUserModules(applicationmodule.modCheckRegister)
            If canAdd Or canEdit Or canView Then
                SideCheckRegister.Location = New Point(0, nxtlocation)
                MenuCheckRegister.Location = New Point(6, nxtlocation)
                nxtlocation += interval
            Else
                SideCheckRegister.Visible = False
                MenuCheckRegister.Visible = False
            End If
            GlobalModule.GetUserModules(applicationmodule.modExpenses)
            If (canAdd Or canEdit Or canView) And IsModuleActive(applicationmodule.modExpenses) Then
                SideExpenses.Location = New Point(0, nxtlocation)
                MenuExpenses.Location = New Point(6, nxtlocation)
                nxtlocation += interval
            Else
                SideExpenses.Visible = False
                MenuExpenses.Visible = False
            End If
        Else
            nxtlocation = 624
            If IsModuleActive(applicationmodule.modExpenses) Then
                SideExpenses.Location = New Point(0, nxtlocation)
                MenuExpenses.Location = New Point(6, nxtlocation)
                nxtlocation += interval
            Else
                SideExpenses.Visible = False
                MenuExpenses.Visible = False
            End If
        End If

        panelmenulast.Location = New Point(0, nxtlocation)


    End Sub
    Private Sub setCurrentPage(ByRef page As currentpage)
        If page <> mycurrentpage Then
            Select Case mycurrentpage
                Case currentpage.pageReservation
                    Me.MenuReservation.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.SideReservation.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.MainPanel.Controls.Remove(fReservations)
                Case currentpage.pageInvoices
                    Me.MenuInvoices.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.SideInvoices.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.MainPanel.Controls.Remove(fSales)
                Case currentpage.pagePayments
                    Me.MenuPayments.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.SidePayments.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.MainPanel.Controls.Remove(fPayments)
                Case currentpage.pageCommissions
                    Me.MenuCommissions.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.SideCommissions.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.MainPanel.Controls.Remove(fCommisions)
                Case currentpage.pageAgents
                    Me.MenuAgents.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.SideAgents.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.MainPanel.Controls.Remove(fAgents)
                Case currentpage.pageProperties
                    Me.MenuProperties.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.SideProperties.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.MainPanel.Controls.Remove(fProperty)
                Case currentpage.pageCustomers
                    Me.MenuCustomers.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.SideCustomers.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.MainPanel.Controls.Remove(fCustomers)
                Case currentpage.pageEmployees
                    Me.MenuEmployees.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.SideEmployees.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.MainPanel.Controls.Remove(fEmployees)
                Case currentpage.pageReports
                    Me.MenuReports.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.SideReports.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.MainPanel.Controls.Remove(fReports)
                Case currentpage.pageProfile
                    Me.panelheaderprofile.BackColor = Color.MediumSeaGreen
                    Me.MainPanel.Controls.Remove(fProfile)
                Case currentpage.pageCheckRegister
                    Me.MenuCheckRegister.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.SideCheckRegister.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.MainPanel.Controls.Remove(fcheckregister)
                Case currentpage.pageExpenses
                    Me.MenuExpenses.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.SideExpenses.BackColor = System.Drawing.SystemColors.WindowFrame
                    Me.MainPanel.Controls.Remove(fExpenses)
            End Select
            mycurrentpage = page
            Select Case mycurrentpage
                Case currentpage.pageReservation
                    Me.MenuReservation.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
                    Me.SideReservation.BackColor = Color.SeaGreen
                    Me.lblModule.Text = "Reservations"
                    Me.MainPanel.Controls.Add(fReservations)
                Case currentpage.pageInvoices
                    Me.MenuInvoices.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
                    Me.SideInvoices.BackColor = Color.SeaGreen
                    Me.lblModule.Text = "Sales"
                    Me.MainPanel.Controls.Add(fSales)
                    If Not isshownsales Then
                        fSales.Show()
                        isshownsales = True
                    End If
                Case currentpage.pagePayments
                    Me.MenuPayments.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
                    Me.SidePayments.BackColor = Color.SeaGreen
                    Me.lblModule.Text = "Payments"
                    Me.MainPanel.Controls.Add(fPayments)
                    If Not isshownpayments Then
                        fPayments.Show()
                        isshownpayments = True
                    End If
                Case currentpage.pageCommissions
                    Me.MenuCommissions.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
                    Me.SideCommissions.BackColor = Color.SeaGreen
                    Me.lblModule.Text = "Commissions"
                    Me.MainPanel.Controls.Add(fCommisions)
                    If Not isshowncommisions Then
                        fCommisions.Show()
                        isshowncommisions = True
                    End If
                Case currentpage.pageAgents
                    Me.MenuAgents.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
                    Me.SideAgents.BackColor = Color.SeaGreen
                    Me.lblModule.Text = "Agents"
                    Me.MainPanel.Controls.Add(fAgents)
                    If Not isshownagents Then
                        fAgents.Show()
                        isshownagents = True
                    End If
                Case currentpage.pageProperties
                    Me.MenuProperties.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
                    Me.SideProperties.BackColor = Color.SeaGreen
                    Me.lblModule.Text = "Properties"
                    Me.MainPanel.Controls.Add(fProperty)
                    If Not isshownproperties Then
                        fProperty.Show()
                        isshownproperties = True
                    End If
                Case currentpage.pageCustomers
                    Me.MenuCustomers.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
                    Me.SideCustomers.BackColor = Color.SeaGreen
                    Me.lblModule.Text = "Customers"
                    Me.MainPanel.Controls.Add(fCustomers)
                    If Not isshowncustomers Then
                        fCustomers.Show()
                        isshowncustomers = True
                    End If
                Case currentpage.pageEmployees
                    Me.MenuEmployees.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
                    Me.SideEmployees.BackColor = Color.SeaGreen
                    Me.lblModule.Text = "Employees"
                    Me.MainPanel.Controls.Add(fEmployees)
                    If Not isshownemployees Then
                        fEmployees.Show()
                        isshownemployees = True
                    End If
                Case currentpage.pageReports
                    Me.MenuReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
                    Me.SideReports.BackColor = Color.SeaGreen
                    Me.lblModule.Text = "Reports"
                    Me.MainPanel.Controls.Add(fReports)
                    If Not isshownreports Then
                        fReports.Show()
                        isshownreports = True
                    End If
                Case currentpage.pageProfile
                    Me.panelheaderprofile.BackColor = Color.SeaGreen
                    Me.lblModule.Text = "User Profile"
                    Me.MainPanel.Controls.Add(fProfile)
                    If Not isshownprofile Then
                        fProfile.Show()
                        isshownprofile = True
                    End If
                Case currentpage.pageCheckRegister
                    Me.MenuCheckRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
                    Me.SideCheckRegister.BackColor = Color.SeaGreen
                    Me.lblModule.Text = "Check Register"
                    Me.MainPanel.Controls.Add(fcheckregister)
                    If Not isshowncheckregister Then
                        fcheckregister.Show()
                        isshowncheckregister = True
                    End If
                Case currentpage.pageExpenses
                    Me.MenuExpenses.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
                    Me.SideExpenses.BackColor = Color.SeaGreen
                    Me.lblModule.Text = "Expenses"
                    Me.MainPanel.Controls.Add(fExpenses)
                    If Not isshownexpenses Then
                        fExpenses.Show()
                        isshownexpenses = True
                    End If
            End Select
        End If
    End Sub
    Private Sub Signout()
        If CustommsgBox(msgstyle.warning, msgtype.yesno, "Confirm Signout?", "Are you sure you want to signout?") Then
            AdminSignin.Show()
            Me.Dispose()
        Else
            Me.MenuExpenses.BackColor = System.Drawing.SystemColors.WindowFrame
            Me.SideExpenses.BackColor = System.Drawing.SystemColors.WindowFrame
        End If
    End Sub
#End Region

#Region "MouseEnterLeave"
    Private Sub MenuReservation_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReservation.MouseEnter
        Me.MenuReservation.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SideReservation.BackColor = Color.SeaGreen
    End Sub

    Private Sub MenuInvoices_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuInvoices.MouseEnter
        Me.MenuInvoices.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SideInvoices.BackColor = Color.SeaGreen
    End Sub

    Private Sub MenuPayments_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPayments.MouseEnter
        Me.MenuPayments.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SidePayments.BackColor = Color.SeaGreen
    End Sub

    Private Sub MenuCommissions_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCommissions.MouseEnter
        Me.MenuCommissions.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SideCommissions.BackColor = Color.SeaGreen
    End Sub

    Private Sub MenuAgents_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAgents.MouseEnter
        Me.MenuAgents.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SideAgents.BackColor = Color.SeaGreen
    End Sub

    Private Sub MenuProperties_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuProperties.MouseEnter
        Me.MenuProperties.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SideProperties.BackColor = Color.SeaGreen
    End Sub

    Private Sub MenuCustomers_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCustomers.MouseEnter
        Me.MenuCustomers.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SideCustomers.BackColor = Color.SeaGreen
    End Sub

    Private Sub MenuEmployees_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEmployees.MouseEnter
        Me.MenuEmployees.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SideEmployees.BackColor = Color.SeaGreen
    End Sub


    Private Sub MenuReports_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReports.MouseEnter
        Me.MenuReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SideReports.BackColor = Color.SeaGreen
    End Sub

    Private Sub MenuLogout_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuExpenses.MouseEnter
        Me.MenuExpenses.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SideExpenses.BackColor = Color.SeaGreen
    End Sub

    Private Sub MenuCheckRegister_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCheckRegister.MouseEnter
        Me.MenuCheckRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SideCheckRegister.BackColor = Color.SeaGreen
    End Sub

#End Region

    Private Sub MenuReservation_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReservation.MouseLeave
        If Not MenuReservation.ClientRectangle.Contains(MenuReservation.PointToClient(Control.MousePosition)) Then
            If mycurrentpage <> currentpage.pageReservation Then
                Me.MenuReservation.BackColor = System.Drawing.SystemColors.WindowFrame
                Me.SideReservation.BackColor = System.Drawing.SystemColors.WindowFrame
            End If
        End If
    End Sub

    Private Sub MenuInvoices_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuInvoices.MouseLeave
        If Not MenuInvoices.ClientRectangle.Contains(MenuInvoices.PointToClient(Control.MousePosition)) Then
            If mycurrentpage <> currentpage.pageInvoices Then
                Me.MenuInvoices.BackColor = System.Drawing.SystemColors.WindowFrame
                Me.SideInvoices.BackColor = System.Drawing.SystemColors.WindowFrame
            End If
        End If

    End Sub

    Private Sub MenuPayments_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPayments.MouseLeave
        If Not MenuPayments.ClientRectangle.Contains(MenuPayments.PointToClient(Control.MousePosition)) Then
            If mycurrentpage <> currentpage.pagePayments Then
                Me.MenuPayments.BackColor = System.Drawing.SystemColors.WindowFrame
                Me.SidePayments.BackColor = System.Drawing.SystemColors.WindowFrame
            End If
        End If

    End Sub

    Private Sub MenuCommissions_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCommissions.MouseLeave
        If Not MenuCommissions.ClientRectangle.Contains(MenuCommissions.PointToClient(Control.MousePosition)) Then
            If mycurrentpage <> currentpage.pageCommissions Then
                Me.MenuCommissions.BackColor = System.Drawing.SystemColors.WindowFrame
                Me.SideCommissions.BackColor = System.Drawing.SystemColors.WindowFrame
            End If
        End If

    End Sub

    Private Sub MenuAgents_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAgents.MouseLeave
        If Not MenuAgents.ClientRectangle.Contains(MenuAgents.PointToClient(Control.MousePosition)) Then
            If mycurrentpage <> currentpage.pageAgents Then
                Me.MenuAgents.BackColor = System.Drawing.SystemColors.WindowFrame
                Me.SideAgents.BackColor = System.Drawing.SystemColors.WindowFrame
            End If
        End If

    End Sub

    Private Sub MenuProperties_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuProperties.MouseLeave
        If Not MenuProperties.ClientRectangle.Contains(MenuProperties.PointToClient(Control.MousePosition)) Then
            If mycurrentpage <> currentpage.pageProperties Then
                Me.MenuProperties.BackColor = System.Drawing.SystemColors.WindowFrame
                Me.SideProperties.BackColor = System.Drawing.SystemColors.WindowFrame
            End If
        End If

    End Sub

    Private Sub MenuCustomers_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCustomers.MouseLeave
        If Not MenuCustomers.ClientRectangle.Contains(MenuCustomers.PointToClient(Control.MousePosition)) Then
            If mycurrentpage <> currentpage.pageCustomers Then
                Me.MenuCustomers.BackColor = System.Drawing.SystemColors.WindowFrame
                Me.SideCustomers.BackColor = System.Drawing.SystemColors.WindowFrame
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

    Private Sub MenuExpenses_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuExpenses.MouseLeave
        If Not MenuExpenses.ClientRectangle.Contains(MenuExpenses.PointToClient(Control.MousePosition)) Then
            If mycurrentpage <> currentpage.pageExpenses Then
                Me.MenuExpenses.BackColor = System.Drawing.SystemColors.WindowFrame
                Me.SideExpenses.BackColor = System.Drawing.SystemColors.WindowFrame
            End If
        End If
    End Sub

    Private Sub MenuCheckRegister_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCheckRegister.MouseLeave
        If Not MenuCheckRegister.ClientRectangle.Contains(MenuCheckRegister.PointToClient(Control.MousePosition)) Then
            Me.MenuCheckRegister.BackColor = System.Drawing.SystemColors.WindowFrame
            Me.SideCheckRegister.BackColor = System.Drawing.SystemColors.WindowFrame
        End If
    End Sub

    Private Sub lblReservations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReservation.Click, lblReservations.Click
        Call setCurrentPage(currentpage.pageReservation)
    End Sub

    Private Sub lblInvoices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuInvoices.Click, lblInvoices.Click
        Call setCurrentPage(currentpage.pageInvoices)
    End Sub

    Private Sub lblPayments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPayments.Click, lblPayments.Click
        Call setCurrentPage(currentpage.pagePayments)
    End Sub

    Private Sub lblCommissions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCommissions.Click, lblCommissions.Click
        Call setCurrentPage(currentpage.pageCommissions)
    End Sub

    Private Sub lblAgents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAgents.Click, lblAgents.Click
        Call setCurrentPage(currentpage.pageAgents)
    End Sub

    Private Sub lblProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuProperties.Click, lblProperties.Click
        Call setCurrentPage(currentpage.pageProperties)
    End Sub

    Private Sub lblCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCustomers.Click, lblCustomers.Click
        Call setCurrentPage(currentpage.pageCustomers)
    End Sub

    Private Sub lblEmployees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEmployees.Click, lblEmployees.Click
        Call setCurrentPage(currentpage.pageEmployees)
    End Sub

    Private Sub lblReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReports.Click, lblReports.Click
        Call setCurrentPage(currentpage.pageReports)
    End Sub

    Private Sub lblcheckregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCheckRegister.Click, lblcheckregister.Click, Label9.Click
        Call setCurrentPage(currentpage.pageCheckRegister)
    End Sub

    Private Sub lblLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuExpenses.Click, lblExpenses.Click
        Call setCurrentPage(currentpage.pageExpenses)
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
        Call setCurrentPage(currentpage.pageProfile)
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

End Class