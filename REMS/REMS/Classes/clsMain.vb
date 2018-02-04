Public Class clsMain
    Public moduleid As Integer
    Public employeeid, lotid, invoiceno, overrideby As Long
    Public photo As Object
    Public logtitle,
           logaction,
           companyname,
           address,
           contact, reason, receivedby As String
    Public dateforfeited As Date
    Public refundamount As Double
    Public isrefund As Boolean

    Public Shared Function Fetch(ByVal sop As Integer, ByVal search As String) As DataTable
        Dim StrPar As String() = {"operation", "soperation", "search"}
        Dim StrVal As String() = {0, sop, search}
        Dim s As New sqlbridge : Return s.Fetchdata("spMain", StrPar, StrVal)
    End Function

    Public Shared Function Save(ByRef sop As Integer, ByRef value As Object) As Boolean
        Dim StrPar As String() = {"operation", "soperation", "value"}
        Dim StrVal As Object() = {2, sop, value}
        Dim s As New sqlbridge : Return s.Transact("spMain", StrPar, StrVal)
    End Function
    Public Sub SaveLog()
        Dim StrPar As String() = {"operation", "soperation", "moduleid", "logtitle", "logaction","employeeid"}
        Dim StrVal As Object() = {1, 0, moduleid, logtitle, logaction, employeeid}
        Dim s As New sqlbridge : s.Transact("spMain", StrPar, StrVal)
    End Sub
    Public Function SaveCompanyInfo(ByRef sop As Integer) As Boolean
        Dim StrPar As String() = {"operation", "soperation", "companyname", "companyaddress", "companycontact", "companylogo"}
        Dim StrVal As Object() = {2, sop, companyname, address, contact, photo}
        Dim s As New sqlbridge : Return s.Transact("spMain", StrPar, StrVal)
    End Function
    Public Shared Sub RefreshHistory(ByRef invoiceno As Long, ByRef lotid As Long)
        Dim StrPar As String() = {"operation", "soperation", "invoiceno", "lotid"}
        Dim StrVal As Object() = {3, 0, invoiceno, lotid}
        Dim s As New sqlbridge : s.Transact("spMain", StrPar, StrVal)
    End Sub
    Public Sub ForfeitLot()
        Dim StrPar As String() = {"operation", "soperation", "invoiceno", "lotid", "overrideby", "reason",
                                  "dateforfeited", "refundamount", "recevideby", "employeeid", "isrefund"}
        Dim StrVal As Object() = {3, 1, invoiceno, lotid, overrideby, reason,
                                  dateforfeited, refundamount, receivedby, Current_UserID, isrefund}
        Dim s As New sqlbridge : s.Transact("spMain", StrPar, StrVal)
    End Sub
End Class
