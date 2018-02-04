Public Class clsCustomers
    Public customerid As Long
    Public lastname As String
    Public firstname As String
    Public middlename As String
    Public contact As String
    Public address As String
    Public bdate As Date
    Public tin As String

    Public createdbyid As Long
    Public datecreated As Date
    Public Shared Function Fetch(ByVal sop As Integer, ByVal search As String) As DataTable
        Dim StrPar As String() = {"operation", "soperation", "search"}
        Dim StrVal As String() = {0, sop, search}
        Dim s As New sqlbridge : Return s.Fetchdata("spCustomer", StrPar, StrVal)
    End Function

    Public Function SaveCustomer(ByRef isnew As Boolean) As Long
        Dim operation As Integer = 2
        If isnew Then
            operation = 1
        End If

        Dim StrPar As String() = {"operation", "soperation", "cust_id", "fname", "lname", "mi",
                                  "address", "contactno", "tin", "bdate"}
        Dim StrVal As Object() = {operation, 0, customerid, firstname, lastname, middlename,
                                  address, contact, tin, bdate}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spCustomer", StrPar, StrVal)
    End Function
End Class
