Public Class clsEmployees

    Public employeeid As Long
    Public lastname As String
    Public firstname As String
    Public middlename As String
    Public gender As String
    Public address As String
    Public mobileno As String
    Public email As String
    Public photo As Object
    Public isactive As Boolean

    Public username As String
    Public password As String
    Public isadmin As Boolean
    Public changePassword As Boolean

    Public userprivid As Long
    Public moduleid As Integer
    Public modulename As String
    Public canadd, canedit, canview As Boolean

    Public createdbyid As Long
    Public datecreated As Date
    Public Shared Function GetUsers(ByVal sop As Integer, ByVal search As String, Optional ByRef username As String = "", Optional ByRef password As String = "", Optional ByRef isactive As Boolean = False) As DataTable
        Dim StrPar As String() = {"operation", "soperation", "search", "username", "password", "isactive"}
        Dim StrVal As String() = {0, sop, search, username, password, isactive}
        Dim s As New sqlbridge : Return s.Fetchdata("spEmployees", StrPar, StrVal)
    End Function

    Public Function SaveEmployee(ByRef isnew As Boolean) As Integer
        Dim operation As Integer = 2
        If isnew Then
            operation = 1
        End If

        Dim StrPar As String() = {"operation", "soperation", "employeeid", "lastname", "firstname", "middlename", "gender", "address",
                                  "mobileno", "email", "isactive", "photo", "username", "password", "isadmin",
                                  "createdbyid", "datecreated", "ischangepassword"}
        Dim StrVal As Object() = {operation, 0, employeeid, lastname, firstname, middlename, gender, address,
                                  mobileno, email, isactive, photo, username, password, isadmin,
                                  createdbyid, datecreated, changePassword}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spEmployees", StrPar, StrVal)
    End Function
    Public Function SavePrivileges(ByRef isnew As Boolean) As Long
        Dim operation As Integer = 2
        If isnew Then
            operation = 1
        End If
        Dim StrPar As String() = {"operation", "soperation", "userprivid", "employeeid", "moduleid",
                                  "canadd", "canedit", "canview"}
        Dim StrVal As Object = {operation, 1, userprivid, employeeid, moduleid,
                                canadd, canedit, canview}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spEmployees", StrPar, StrVal)
    End Function

    Public Function UpdateProfile(ByRef sop As Integer) As Boolean
        Dim StrPar As String() = {"operation", "soperation", "employeeid", "lastname", "firstname", "middlename",
                                  "gender", "username", "photo", "password"}
        Dim StrVal As Object = {2, sop, employeeid, lastname, firstname, middlename,
                                  gender, username, photo, password}
        Dim s As New sqlbridge : Return s.Transact("spEmployees", StrPar, StrVal)
    End Function

End Class
