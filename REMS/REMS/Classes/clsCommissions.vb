Public Class clsCommissions
    Public voucherno,
           compaymentid,
           agentid,
           chargeid,
           encodedby As Long

    Public amount, taxpercentage As Double
    Public voucherdate As Date


    Public Shared Function fetch(ByVal sop As Integer, ByVal search As String, Optional ByVal agentid As Long = 0) As DataTable
        Dim strPar As String() = {"operation", "soperation", "search", "agentid"}
        Dim strVal As String() = {0, sop, search, agentid}
        Dim s As New sqlbridge : Return s.Fetchdata("spCommission", strPar, strVal)
    End Function
    Public Function GetVouchers(ByVal sop As Integer, Optional ByVal search As String = "", Optional ByVal agentid As Long = 0, Optional ByVal voucherdate As Date = Nothing) As DataTable
        Dim strPar As String() = {"action_type", "sub_action", "search", "agentid", "voucherdate"}
        Dim strVal As String() = {2, sop, search, agentid, voucherdate}
        Dim s As New Public_Modules : Return s.CUSTOM_RETRIEVE("SP_Commission", strPar, strVal)
    End Function

    Public Function SaveVoucher(ByRef isnew As Boolean, ByVal sop As Integer) As Long
        Dim operation As Integer = 2
        If isnew Then
            operation = 1
        End If
        Dim strPar As String() = {"operation", "soperation", "voucherno", "agentid", "voucherdate",
                                  "encodedby", "chargeid", "amount"}
        Dim strVal As String() = {operation, sop, voucherno, agentid, voucherdate,
                                  encodedby, chargeid, amount}
        Dim s As New sqlbridge : Return s.ReturnNewPK("spCommission", strPar, strVal)
    End Function

    Public Shared Sub GenerateCommissions(ByRef paymentid As Long)
        Dim strPar As String() = {"paymentid"}
        Dim strVal As String() = {paymentid}
        Dim s As New sqlbridge : s.Transact("spGenerateCommissionPerPayment", strPar, strVal)
    End Sub
    Public Shared Sub setPrinted(ByRef voucherno As Long)
        Dim strPar As String() = {"operation", "soperation", "voucherno"}
        Dim strVal As String() = {2, 0, voucherno}
        Dim s As New sqlbridge : s.Transact("spCommission", strPar, strVal)
    End Sub

    Public Shared Function PrintVoucher(ByRef voucherno As Long) As Boolean
        Try
            Dim dtRecord As DataTable = fetch(3, voucherno)
            Dim dtInfo As DataTable = fetch(4, voucherno)

            Dim crV As New crvoucher
            SetCompanyName(crV)

            Dim txtagentid As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section1").ReportObjects.Item("txtagentid")
            Dim txtagentname As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section1").ReportObjects.Item("txtagentname")
            Dim txtaddress As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section1").ReportObjects.Item("txtaddress")
            Dim txtcontactno As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section1").ReportObjects.Item("txtcontact")


            Dim txtvoucherno As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtvoucherno")
            Dim txtvoucherdate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtvoucherdate")

            Dim txtpreparedby As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtpreparedby")
            Dim txtnotedby As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtnotedby")
            Dim txtreceivedby As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtreceivedby")

            txtagentid.Text = dtInfo.Rows(0).Item("agentid")
            txtagentname.Text = dtInfo.Rows(0).Item("agent")
            txtaddress.Text = dtInfo.Rows(0).Item("address")
            txtcontactno.Text = dtInfo.Rows(0).Item("contactno")

            txtvoucherno.Text = voucherno.ToString
            txtvoucherdate.Text = dtInfo.Rows(0).Item("COMPAYMENTDATE")

            txtpreparedby.Text = dtInfo.Rows(0).Item("encodedby")
            txtnotedby.Text = mNotedBy
            txtreceivedby.Text = dtInfo.Rows(0).Item("agent")

            crV.SetDataSource(dtRecord)
            Dim f As New CustomReportViewer
            f.setReport(crV)
            f.setIsPrinted(dtInfo.Rows(0).Item("isprinted"))
            f.ShowDialog()
            If f.IsPrinted() = True Then
                setPrinted(voucherno)
                Return True
            End If
        Catch ex As Exception
            CustommsgBox(msgstyle.critical, msgtype.okonly, "Something went wrong!", "Could not create report. Please try again.")
        End Try
        Return False
    End Function

End Class
