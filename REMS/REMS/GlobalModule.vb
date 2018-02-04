Imports System.Data
Imports System.Data.SqlClient

Module GlobalModule
#Region "Constants"
    Public DatabaseName As String = "RealEstate"

    Public connection_established As Boolean = False
    Public readytoclose As Boolean = True
    Public Default_Row_Height As Integer = 28
    Public Search_Hint_Customer As String = "Search Customer here"
    Public Search_Hint_Payment As String = "Search Payment here"
    Public Search_Hint_Agent As String = "Search Agent here"
    Public Search_Hint_Parcel As String = "Search Parcel here"
    Public Search_Hint_Property As String = "Search Property here"
    Public Search_Hint_Reservations As String = "Search Reservations here"
    Public Search_Hint_Invoices As String = "Search Invoices here"
    Public Search_Hint_Commissions As String = "Search Commissions here"
    Public Header As String = "Real Estate Monitoring System"
    Public Search_Hint_Voucher As String = "Search VoucherNo"

    Public ProfilePic As Image
    Public CompanyLogo As Image
    Public CurrentUsername As String
    Public CurrentPassword As String
    Public Isadmin As Boolean
    Public Current_UserID As Integer = 1
    Public Current_UserFname As String = ""
    Public Current_UserLname As String = ""
    Public Current_UserMname As String = ""
    Public Current_UserGender As String = ""
    Public Company_Name As String = ""
    Public CompanyAddress As String = ""
    Public CompanyContact As String = ""
    Public mNotedBy As String = ""
    Public msgTitle As String = "Southdev Development Corp."

    Public canAdd As Boolean
    Public canEdit As Boolean
    Public canView As Boolean
    Public canDelete As Boolean

    Public newcolor As Color = Color.SteelBlue
    Public editcolor As Color = Color.MediumSeaGreen
    Public viewcolor As Color = Color.Peru

    Public mymsgstyle As msgstyle
    Public mymsgtype As msgtype
    Private dtModule As New DataTable
    Enum msgstyle
        info = 0
        warning = 1
        critical = 2
    End Enum
    Enum msgtype
        yesno = 0
        okcancel = 1
        okonly = 2
    End Enum

    Enum applicationmodule
        modReservation = 1
        modSales = 2
        modPayment = 3
        modCommissions = 4
        modAgents = 5
        modProperties = 6
        modCustomers = 7
        modEmployees = 8
        modCheckRegister = 9
        modExpenses = 10
        modReports = 11
        modloans = 12
    End Enum

#End Region
    Public conn As New SqlConnection
    Public sqlCommand As New SqlCommand
    Private dt As New DataTable
    Private sqladapter As New SqlDataAdapter
    Public Function connect(ByVal servername As String, ByRef dbuserid As String, ByVal dbpassword As String) As Boolean
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.ConnectionString = "Data Source=" + servername + ";Initial Catalog=SouthDev;Integrated Security=no;User ID=" + dbuserid + ";Password=" + dbpassword
            conn.Open()
            connection_established = True
            Return True
        Catch ex As Exception
        End Try
        Return False
    End Function
    Public Sub InitializeReport(ByRef reportname As String)


    End Sub
    Public Function GetSearchString(ByRef searchtext As String, ByRef searchhint As String)
        If searchtext = searchhint Or searchtext.Length = 0 Then
            Return ""
        End If
        Return searchtext
    End Function
    Public Sub GetCompanyInfo()
        Try
            Dim DT As DataTable = clsMain.Fetch(0, "")
            Company_Name = DT.Rows(0).Item("COMPANYNAME").ToString
            CompanyAddress = DT.Rows(0).Item("COMPANYADDRESS").ToString
            CompanyContact = DT.Rows(0).Item("COMPANYCONTACT").ToString
            mNotedBy = DT.Rows(0).Item("NOTEDBY").ToString
            Try
                If Not IsDBNull(DT.Rows(0).Item("COMPANYLOGO")) Then
                    Dim tempphoto As Byte() = DT.Rows(0).Item("COMPANYLOGO")
                    If tempphoto.Length > 0 Then
                        CompanyLogo = Utility.convertImage(DT.Rows(0).Item("COMPANYLOGO")) 'image here
                    End If
                Else
                    CompanyLogo = My.Resources.no_image
                End If
            Catch ex As Exception
                CompanyLogo = My.Resources.no_image
            End Try
        Catch ex As Exception

        End Try
    End Sub
    Public Sub SetCompanyName(ByRef crrep As Object)
        Dim companyname As CrystalDecisions.CrystalReports.Engine.TextObject
        companyname = crrep.ReportDefinition.Sections("Section1").ReportObjects.Item("txtcompanyname")
        companyname.Text = Company_Name
        Dim comaddress As CrystalDecisions.CrystalReports.Engine.TextObject
        comaddress = crrep.ReportDefinition.Sections("Section1").ReportObjects.Item("txtcompanyaddress")
        comaddress.Text = CompanyAddress
    End Sub
    Public Function IsSpecifyDate() As Boolean
        Try
            Dim MyBridge As New Public_Modules
            Dim Param_Name As String() = {"@action_type", "@sub_action"}
            Dim Param_Value As String() = {2, 0}
            Dim DT As New DataTable
            DT = MyBridge.CUSTOM_RETRIEVE("SP_GetDefaults", Param_Name, Param_Value)
            Return DT.Rows(0).Item("SPECIFYDATE") > 0
        Catch ex As Exception

        End Try
        Return False
    End Function
    Public Function GetServerDate() As Date
        Try
            Dim MyBridge As New Public_Modules
            Dim Param_Name As String() = {"@action_type", "@sub_action"}
            Dim Param_Value As String() = {3, 0}
            Dim DT As New DataTable
            DT = MyBridge.CUSTOM_RETRIEVE("SP_Miscellaneous", Param_Name, Param_Value)
            Return DT.Rows(0).Item("SERVERDATE")
        Catch ex As Exception

        End Try
        Return Date.Now
    End Function
    Public Function CustommsgBox(ByRef style As msgstyle, ByRef type As msgtype, ByRef title As String, ByRef msgdesc As String) As Boolean
        mymsgstyle = style
        mymsgtype = type
        Dim frm As New frmmsgbox
        frm.mtitle = title
        frm.mdescription = msgdesc
        frm.ShowDialog()
        Return frm.response
    End Function
    Sub LoadUserModules()
        Dim dpk(1) As DataColumn
        dtModule = clsEmployees.GetUsers(3, Current_UserID)
        dpk(0) = dtModule.Columns("moduleid")
        dtModule.PrimaryKey = dpk
    End Sub
    Sub GetUserModules(ByVal appMod As Integer)
        'Dim idx As Integer
        'Dim dtModule As New DataTable

        'dtModule = clsAuthentication.getUsersModules(authId)

        If dtModule.Rows.Count > 0 Then
            Dim row As DataRow = dtModule.Rows.Find(appMod)
            If Not (row Is Nothing) Then
                canAdd = row("canadd")
                canEdit = row("canedit")
                canView = row("canview")
            Else
                canAdd = False
                canEdit = False
                canView = False
            End If
        End If
    End Sub
    Function IsModuleActive(ByVal appMod As Integer) As Boolean
        Dim dt As DataTable = clsMain.Fetch(2, appMod)
        Return dt.Rows(0).Item("isactive")
    End Function
    Sub SaveLogs(ByRef appmod As Integer, ByRef title As String, ByRef action As String)
        Dim x As New clsMain
        x.employeeid = Current_UserID
        x.moduleid = appmod
        x.logtitle = title
        x.logaction = action
        x.SaveLog()
    End Sub
End Module
