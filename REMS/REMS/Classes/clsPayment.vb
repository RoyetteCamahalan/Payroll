Public Class clsPayment

    Public bankid,
           accountid,
           customerid,
           paymentid,
           invoiceno,
           encodedbyid,
           lotid,
           chargeid,
           paymentcheckid,
           paymentbtbid,
           agentid,
           paymentdetailid,
           institutionid As Long
    Public bankname,
        accountname,
        accountno,
        checkno,
        replacedcheckno,
        prefferedbranch,
        orno,
        memo,
        institutionname As String
    Public invoicedate,
           paymentschedule,
           paymentdate,
           chargedate,
           checkdate,
           replacedcheckdate As Date
    Public interest,
           compercentageovertime,
           price,
           discount,
           excess,
           loanamount,
           compercentage,
           commissionableprice,
           adcom,
           cashamount,
           checkamount,
           btbamount,
           commissionable,
           amortization,
           chargeamount,
           interestamount,
           balance,
           amount As Double
    Public paymentterm,
           commissionterm,
           paymentextension,
           reserveduration,
           status,
           chargetype As Integer
    Public isactive, isagent As Boolean
    Public photo As Object

    Public Shared Function Fetch(ByVal sop As Integer, ByVal search As String, Optional ByVal invoiceno As Long = 0, Optional ByVal lotid As Long = 0) As DataTable
        Dim StrPar As String() = {"operation", "soperation", "search", "invoiceno", "lotid"}
        Dim StrVal As String() = {0, sop, search, invoiceno, lotid}
        Dim s As New sqlbridge : Return s.Fetchdata("spPayment", StrPar, StrVal)
    End Function
    Public Shared Function getChecks(ByRef search As String, ByRef dateinitial As Date, ByRef dateending As Date, ByRef status As Integer) As DataTable
        Dim sop As Integer = 5
        Select Case status
            Case 0
                sop = 6
            Case 1
                status = 0
        End Select
        Dim StrPar As String() = {"operation", "soperation", "search", "startdate", "enddate", "status"}
        Dim StrVal As String() = {0, sop, search, dateinitial, dateending, status}
        Dim s As New sqlbridge : Return s.Fetchdata("spPayment", StrPar, StrVal)
    End Function
    Public Shared Function FetchDateRange(ByRef sop As Integer, ByRef search As String, ByRef dateinitial As Date, ByRef dateending As Date) As DataTable
        Dim StrPar As String() = {"operation", "soperation", "search", "startdate", "enddate"}
        Dim StrVal As String() = {0, sop, search, dateinitial, dateending}
        Dim s As New sqlbridge : Return s.Fetchdata("spPayment", StrPar, StrVal)
    End Function

    Public Function SaveBankandAccount(ByRef isnew As Boolean, ByRef sop As Integer) As Long
        Dim operation As Integer = 2
        If isnew Then
            operation = 1
        End If
        Dim StrPar As String() = {"operation", "soperation", "bankid", "bankname", "accountid",
                                  "accountname", "accountno", "prefferedbranch", "isactive"}
        Dim StrVal As Object() = {operation, sop, bankid, bankname, accountid,
                                  accountname, accountno, prefferedbranch, isactive}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spPayment", StrPar, StrVal)
    End Function
    Public Function SaveLoanProvider(ByRef isnew As Boolean, ByRef sop As Integer) As Long
        Dim operation As Integer = 2
        If isnew Then
            operation = 1
        End If
        Dim StrPar As String() = {"operation", "soperation", "institutionid", "institutionname", "isactive"}
        Dim StrVal As Object() = {operation, sop, institutionid, institutionname, isactive}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spPayment", StrPar, StrVal)
    End Function
    Public Function SaveInvoice(ByRef isnew As Boolean) As Long
        Dim operation As Integer = 2
        If isnew Then
            operation = 1
        End If
        Dim StrPar As String() = {"operation", "soperation", "invoiceno", "customerid", "invoicedate",
                                  "paymentschedule", "interest", "paymentterm", "commissionterm",
                                  "paymentextension", "compercentageovertime", "encodedby", "reserveduration", "institutionid"}
        Dim StrVal As Object() = {operation, 2, invoiceno, customerid, invoicedate,
                                  paymentschedule, interest, paymentterm, commissionterm,
                                  paymentextension, compercentageovertime, encodedbyid, reserveduration, institutionid}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spPayment", StrPar, StrVal)
    End Function
    Public Function SavePayment(ByRef isnew As Boolean) As Long
        Dim operation As Integer = 2
        If isnew Then
            operation = 1
        End If
        Dim StrPar As String() = {"operation", "soperation", "paymentid", "paymentdate", "customerid", "encodedby",
                                  "orno", "cashamount", "checkamount", "btbamount"}
        Dim StrVal As Object() = {operation, 3, paymentid, paymentdate, customerid, encodedbyid,
                                   orno, cashamount, checkamount, btbamount}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spPayment", StrPar, StrVal)
    End Function
    Public Function SaveDetails(ByRef isnew As Boolean) As Long
        Dim operation As Integer = 2
        If isnew Then
            operation = 1
        End If
        Dim StrPar As String() = {"operation", "soperation", "paymentid", "invoiceno", "lotid", "price", "discount", "excess",
                                  "loanamount", "compercentage", "commissionable", "amortization", "adcom", "status",
                                  "chargedate", "chargeamount", "paymentterm", "paymentschedule"}
        Dim StrVal As Object() = {operation, 4, paymentid, invoiceno, lotid, price, discount, excess,
                                  loanamount, compercentage, commissionable, amortization, adcom, status,
                                  invoicedate, chargeamount, paymentterm, paymentschedule}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spPayment", StrPar, StrVal)
    End Function
    Public Function SavePaymentDetail(ByRef isnew As Boolean, ByRef sop As Integer) As Long
        Dim operation As Integer = 2
        If isnew Then
            operation = 1
        End If
        Dim StrPar As String() = {"operation", "soperation", "paymentid", "chargeid", "balance", "amount"}
        Dim StrVal As Object() = {operation, sop, paymentid, chargeid, balance, amount}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spPayment", StrPar, StrVal)
    End Function

    Public Function SavePaymentDetails(ByRef isnew As Boolean, ByRef sop As Integer) As Long
        Dim operation As Integer = 2
        If isnew Then
            operation = 1
        End If
        Dim StrPar As String() = {"operation", "soperation", "paymentid", "checkno", "bankid", "checkdate", "accountno", "amount",
                                  "status", "memo", "paymentdate", "photo"}
        Dim StrVal As Object() = {operation, sop, paymentid, checkno, bankid, checkdate, accountno, amount,
                                  status, memo, paymentdate, photo}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spPayment", StrPar, StrVal)
    End Function

    Public Function SaveCommission() As Long
        Dim StrPar As String() = {"operation", "soperation", "invoiceno", "agentid", "compercentage", "isagent"}
        Dim StrVal As Object() = {1, 7, invoiceno, agentid, compercentage, isagent}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spPayment", StrPar, StrVal)
    End Function
    Public Sub DeleteCommission()
        Dim StrPar As String() = {"operation", "soperation", "invoiceno"}
        Dim StrVal As Object() = {3, 0, invoiceno}
        Dim s As New sqlbridge : s.Transact("spPayment", StrPar, StrVal)
    End Sub
    Public Shared Function EditInvoice(ByRef sop As Integer, ByRef key As String, ByRef value As Object, ByRef invoiceno As Long) As Boolean
        Dim StrPar As String() = {"operation", "soperation", key, "invoiceno"}
        Dim StrVal As Object() = {2, sop, value, invoiceno}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spPayment", StrPar, StrVal)
    End Function
   

    Public Shared Sub PrintCollection(ByRef sdate As Date, ByRef edate As Date)
        Try
            Dim dtRecord As DataTable = clsPayment.FetchDateRange(10, "", sdate, edate)

            Dim crV As New crCollectionReport
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
    Public Shared Sub PrintPaymentHistory(ByRef invoiceno As Long, ByRef lotid As Long, ByRef lotname As String)
        Try
            Dim dtRecord As DataTable = clsPayment.Fetch(11, "", invoiceno, lotid)
            Dim dtInfo As DataTable = clsCustomers.Fetch(2, invoiceno)

            Dim crV As New crPaymentHistory
            Dim fcontainer As New Report_Viewer
            SetCompanyName(crV)


            Dim txtcustid As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtcustid")
            Dim txtcustomer As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtcustomer")
            Dim txtaddress As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtaddress")
            Dim txtphone As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtphone")
            Dim txtinvoiceno As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtinvoiceno")
            Dim txtinvoicedate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtinvoicedate")
            Dim txtlotname As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtlotname")


            txtcustid.Text = dtInfo.Rows(0).Item("CUSTID")
            txtcustomer.Text = dtInfo.Rows(0).Item("customer")
            txtaddress.Text = dtInfo.Rows(0).Item("ADDRESS")
            txtphone.Text = dtInfo.Rows(0).Item("CONTACTNO")
            txtinvoiceno.Text = invoiceno
            txtinvoicedate.Text = dtInfo.Rows(0).Item("INVOICEDATE")
            txtlotname.Text = lotname

            crV.SetDataSource(dtRecord)
            fcontainer.CrystalReportViewer1.ReportSource = crV
            fcontainer.Show()
        Catch ex As Exception
            CustommsgBox(msgstyle.critical, msgtype.okonly, "Something went wrong!", "Could not create report. Please try again.")
        End Try
    End Sub

    
End Class
