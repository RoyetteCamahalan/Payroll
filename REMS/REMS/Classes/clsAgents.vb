Public Class clsAgents

    Public agentid As Long
    Public uplineid As Long
    Public lastname As String
    Public firstname As String
    Public middleinitial As String
    Public contact As String
    Public address As String
    Public bdate As Date

    Public accname As String
    Public accno As String

    Public compercentage As Double

    Public position As Integer

    Public Shared Function Fetch(ByVal sop As Integer, ByVal search As String) As DataTable
        Dim StrPar As String() = {"operation", "soperation", "search"}
        Dim StrVal As String() = {0, sop, search}
        Dim s As New sqlbridge : Return s.Fetchdata("spAgent", StrPar, StrVal)
    End Function


    Public Shared Function GetDownlines(ByRef agentid As Long, Optional ByRef ret As String = "count") As Object
        Dim StrPar As String() = {"operation", "soperation", "agentid"}
        Dim StrVal As String() = {0, 1, agentid}
        Dim s As New sqlbridge
        If ret = "count" Then
            Return s.Fetchdata("spAgent", StrPar, StrVal).Rows.Count
        Else
            Return s.Fetchdata("spAgent", StrPar, StrVal)
        End If
    End Function

    Public Function SaveAgent(ByRef isnew As Boolean) As Long
        Dim operation As Integer = 2
        If isnew Then
            operation = 1
        End If

        Dim StrPar As String() = {"operation", "soperation", "agentid", "fname", "lname", "mi",
                                  "address", "contactno", "bdate", "position", "superiorid", "accname", "accno"}
        Dim StrVal As Object() = {operation, 0, agentid, firstname, lastname, middleinitial,
                                  address, contact, bdate, position, uplineid, accname, accno}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spAgent", StrPar, StrVal)
    End Function
    Public Sub SaveDefaultCommission()
        Dim StrPar As String() = {"operation", "soperation", "agentid", "superiorid", "compercentage"}
        Dim StrVal As Object() = {1, 1, agentid, uplineid, compercentage}
        Dim s As New sqlbridge : s.Transact("spAgent", StrPar, StrVal)
    End Sub
    Public Shared Sub DeleteTree(ByRef agentid As Long)
        Dim StrPar As String() = {"operation", "soperation", "agentid"}
        Dim StrVal As Object() = {3, 0, agentid}
        Dim s As New sqlbridge : s.Transact("spAgent", StrPar, StrVal)
    End Sub
End Class
