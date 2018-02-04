Public Class clsExpenses
    Public accountid,
           expensetypeid,
           vendorid,
           expenseid As Long

    Public accountname,
           expensetypedesc,
           vendorname,
           address,
           contactno,
           memo,
           refno As String

    Public refdate As Date
    Public amount As Double
    Public isactive As Boolean


    Public Shared Function Fetch(ByVal sop As Integer, ByVal search As String) As DataTable
        Dim StrPar As String() = {"operation", "soperation", "search"}
        Dim StrVal As String() = {0, sop, search}
        Dim s As New sqlbridge : Return s.Fetchdata("spExpenses", StrPar, StrVal)
    End Function
    Public Shared Function FetchDateRange(ByRef sop As Integer, ByRef search As String, ByRef dateinitial As Date, ByRef dateending As Date) As DataTable
        Dim StrPar As String() = {"operation", "soperation", "search", "startdate", "enddate"}
        Dim StrVal As String() = {0, sop, search, dateinitial, dateending}
        Dim s As New sqlbridge : Return s.Fetchdata("spExpenses", StrPar, StrVal)
    End Function
    Public Function SaveExpenseAccount(ByRef isnew As Boolean) As Long
        Dim operation As Integer = 2
        If isnew Then
            operation = 1
        End If
        Dim StrPar As String() = {"operation", "soperation", "accountid", "accountname", "memo", "isactive"}
        Dim StrVal As Object() = {operation, 2, accountid, accountname, memo, isactive}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spExpenses", StrPar, StrVal)
    End Function
    Public Function SaveExpenseType(ByRef isnew As Boolean) As Long
        Dim operation As Integer = 2
        If isnew Then
            operation = 1
        End If
        Dim StrPar As String() = {"operation", "soperation", "expensetypeid", "expensetypedesc"}
        Dim StrVal As Object() = {operation, 1, expensetypeid, expensetypedesc}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spExpenses", StrPar, StrVal)
    End Function
    Public Function SaveVendor(ByRef isnew As Boolean) As Long
        Dim operation As Integer = 2
        If isnew Then
            operation = 1
        End If
        Dim StrPar As String() = {"operation", "soperation", "vendorid", "vendorname", "address", "contactno"}
        Dim StrVal As Object() = {operation, 0, vendorid, vendorname, address, contactno}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spExpenses", StrPar, StrVal)
    End Function
    Public Function SaveExpense(ByRef isnew As Boolean) As Long
        Dim operation As Integer = 2
        If isnew Then
            operation = 1
        End If
        Dim StrPar As String() = {"operation", "soperation", "expenseid", "accountid", "expensetypeid", "refno",
                                  "refdate", "amount", "memo"}
        Dim StrVal As Object() = {operation, 3, expenseid, accountid, expensetypeid, refno,
                                  refdate, amount, memo}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spExpenses", StrPar, StrVal)
    End Function

    Public Shared Sub PrintExpense(ByRef sdate As Date, ByRef edate As Date)
        Try
            Dim dtRecord As DataTable = clsExpenses.FetchDateRange(7, "", sdate, edate)

            Dim crV As New crExpenses
            Dim fcontainer As New Report_Viewer
            SetCompanyName(crV)


            Dim txtsdate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtstartdate")
            Dim txtedate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtenddate")

            txtsdate.Text = sdate.ToShortDateString
            txtedate.Text = edate.ToShortDateString

            crV.SetDataSource(dtRecord)
            fcontainer.CrystalReportViewer1.ReportSource = crV
            fcontainer.Show()
        Catch ex As Exception
            CustommsgBox(msgstyle.critical, msgtype.okonly, "Something went wrong!", "Could not create report. Please try again.")
        End Try
    End Sub
End Class
