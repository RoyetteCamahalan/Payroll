Public Class clsProperty

    Public propertyid As Integer
    Public propertyname As String
    Public address As String
    Public area As Double

    Public lottypeid As Long
    Public lotypename As String
    Public lotcategory As Integer

    Public lotid As Long
    Public lotname As String
    Public price As Double
    Public down As Double
    Public compercentage As Double
    Public commissionableamount As Double
    Public housearea As Double
    Public parkingarea As Double

    Public Shared Function Fetch(ByVal sop As Integer, ByVal search As String, Optional ByVal id As Long = 0) As DataTable
        Dim StrPar As String() = {"operation", "soperation", "search", "propertyid"}
        Dim StrVal As String() = {0, sop, search, id}
        Dim s As New sqlbridge : Return s.Fetchdata("spProperty", StrPar, StrVal)
    End Function

    Public Function SaveProperty(ByRef isnew As Boolean) As Integer
        Dim operation As Integer = 2
        If isnew Then
            operation = 1
        End If

        Dim StrPar As String() = {"operation", "soperation", "propertyid", "propertyname", "address", "area"}
        Dim StrVal As Object() = {operation, 0, propertyid, propertyname, address, area}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spProperty", StrPar, StrVal)
    End Function
    Public Function SaveLotType(ByRef isnew As Boolean) As Integer
        Dim operation As Integer = 2
        If isnew Then
            operation = 1
        End If
        Dim StrPar As String() = {"operation", "soperation", "propertyid", "lottypeid", "lottypename", "lotcategory"}
        Dim StrVal As Object() = {operation, 1, propertyid, lottypeid, lotypename, lotcategory}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spProperty", StrPar, StrVal)
    End Function
    Public Function SaveLot(ByRef isnew As Boolean) As Integer
        Dim operation As Integer = 2
        If isnew Then
            operation = 1
        End If
        Dim StrPar As String() = {"operation", "soperation", "lotid", "propertyid", "lotname",
                                  "area", "price", "down", "compercentage", "commissionableamount", "lottypeid",
                                  "housearea", "parkingarea"}
        Dim StrVal As Object() = {operation, 2, lotid, propertyid, lotname,
                                  area, price, down, compercentage, commissionableamount, lottypeid, housearea, parkingarea}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spProperty", StrPar, StrVal)
    End Function
End Class
