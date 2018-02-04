Public Class clsReports

    Public Shared Function Fetch(ByVal sop As Integer, ByVal search As String, Optional ByVal invoiceno As Long = 0, Optional ByVal lotid As Long = 0) As DataTable
        Dim StrPar As String() = {"operation", "soperation", "search", "invoiceno", "agentid"}
        Dim StrVal As String() = {0, sop, search, invoiceno, lotid}
        Dim s As New sqlbridge : Return s.Fetchdata("spReports", StrPar, StrVal)
    End Function
    Public Shared Sub PrintAgentslist()
        Try
            Dim dtRecord As DataTable = clsAgents.Fetch(4, "")
            Dim crV As New cr_ShowAllAgents
            Dim fcontainer As New Report_Viewer
            SetCompanyName(crV)
            crV.SetDataSource(dtRecord)
            fcontainer.CrystalReportViewer1.ReportSource = crV
            fcontainer.Show()
        Catch ex As Exception
            CustommsgBox(msgstyle.critical, msgtype.okonly, "Something went wrong!", "Could not create report. Please try again.")
        End Try
    End Sub
    Public Shared Sub PrintDownlines(ByRef AGENTID As Long)
        Try
            Dim dtRecord As DataTable = clsAgents.Fetch(5, AGENTID)
            Dim crV As New cr_showDownlines
            Dim fcontainer As New Report_Viewer
            SetCompanyName(crV)
            crV.SetDataSource(dtRecord)
            fcontainer.CrystalReportViewer1.ReportSource = crV
            fcontainer.Show()
        Catch ex As Exception
            CustommsgBox(msgstyle.critical, msgtype.okonly, "Something went wrong!", "Could not create report. Please try again.")
        End Try
    End Sub

    Public Shared Sub PrintDueCollectables(ByRef Nmonth As Integer, ByRef agentid As Long)
        Try
            Dim dtRecord As DataTable = clsReports.Fetch(2, "", Nmonth, agentid)

            Dim crV As New crDueCollectables
            Dim fcontainer As New Report_Viewer
            SetCompanyName(crV)


            Dim txtsdate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtMonthsDue")
            txtsdate.Text = Nmonth & " Month(s) and above"

            crV.SetDataSource(dtRecord)
            fcontainer.CrystalReportViewer1.ReportSource = crV
            fcontainer.Show()
        Catch ex As Exception
            CustommsgBox(msgstyle.critical, msgtype.okonly, "Something went wrong!", "Could not create report. Please try again.")
        End Try
    End Sub
End Class
