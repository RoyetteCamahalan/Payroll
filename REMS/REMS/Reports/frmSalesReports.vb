Public Class frmSalesReports

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Dispose()
    End Sub

    Private Sub frmSalesReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call initfilters()
        Call LoadReports()
        Call ShowReport()
    End Sub


#Region "Variables"
    Public reporttype As report
    Public mstartdate As Date = Date.Now
    Public menddate As Date = Date.Now
    Enum report
        collection = 0
        forfeited = 1
        banktobank = 2
        salesperproperty = 3
        saleswithloans = 4
        saleswithoutloans = 5
        incomestatement = 6

        'add report here -with index
    End Enum
#End Region
#Region "Methods"

    Sub initfilters()
        Select Case reporttype
            Case report.collection, report.forfeited, report.banktobank, report.salesperproperty, report.saleswithloans, report.saleswithoutloans, report.incomestatement
                Me.paneldaterange.Visible = True
                Me.cmbPeriod.SelectedIndex = 5
                Me.dtpinitialdate.Value = mstartdate
                Me.dtpendingdate.Value = menddate
        End Select
    End Sub
    Sub LoadReports()
        cmbReport.Items.Clear()
        cmbReport.Items.Add("Collection Report")
        cmbReport.Items.Add("Forfeited Invoice")
        cmbReport.Items.Add("Bank To Bank")
        cmbReport.Items.Add("Sales Per Property")
        cmbReport.Items.Add("Sales With Loans")
        cmbReport.Items.Add("Sales Without Loans")
        cmbReport.Items.Add("Income Statement")
        cmbReport.SelectedIndex = reporttype
    End Sub
    Sub ShowReport()
        Select Case Me.cmbReport.SelectedIndex
            Case report.collection
                Try
                    Dim dtRecord As DataTable = clsPayment.FetchDateRange(10, "", Me.dtpinitialdate.Value, Me.dtpendingdate.Value)

                    Dim crV As New crCollectionReport
                    SetCompanyName(crV)


                    Dim txtsdate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtstartdate")
                    Dim txtedate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtenddate")

                    txtsdate.Text = Me.dtpinitialdate.Value.ToShortDateString
                    txtedate.Text = Me.dtpendingdate.Value.ToShortDateString

                    crV.SetDataSource(dtRecord)
                    Me.crptviewer.ReportSource = crV
                Catch ex As Exception
                    CustommsgBox(msgstyle.critical, msgtype.okonly, "Something went wrong!", "Could not create report. Please try again.")
                End Try
            Case report.forfeited
                Try
                    Dim dtRecord As DataTable = clsPayment.FetchDateRange(19, "", Me.dtpinitialdate.Value, Me.dtpendingdate.Value)

                    Dim crV As New crForfeited
                    SetCompanyName(crV)


                    Dim txtsdate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtstartdate")
                    Dim txtedate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtenddate")

                    txtsdate.Text = Me.dtpinitialdate.Value.ToShortDateString
                    txtedate.Text = Me.dtpendingdate.Value.ToShortDateString

                    crV.SetDataSource(dtRecord)
                    Me.crptviewer.ReportSource = crV
                Catch ex As Exception
                    CustommsgBox(msgstyle.critical, msgtype.okonly, "Something went wrong!", "Could not create report. Please try again.")
                End Try

            Case report.banktobank
                Try
                    Dim dtRecord As DataTable = clsPayment.FetchDateRange(20, "", Me.dtpinitialdate.Value, Me.dtpendingdate.Value)

                    Dim crV As New cr_banktobank
                    SetCompanyName(crV)


                    Dim txtsdate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtstartdate")
                    Dim txtedate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtenddate")

                    txtsdate.Text = Me.dtpinitialdate.Value.ToShortDateString
                    txtedate.Text = Me.dtpendingdate.Value.ToShortDateString

                    crV.SetDataSource(dtRecord)
                    Me.crptviewer.ReportSource = crV
                Catch ex As Exception
                    CustommsgBox(msgstyle.critical, msgtype.okonly, "Something went wrong!", "Could not create report. Please try again.")
                End Try
            Case report.salesperproperty
                Try
                    Dim dtRecord As DataTable = clsPayment.FetchDateRange(21, "", Me.dtpinitialdate.Value, Me.dtpendingdate.Value)


                    Dim crV As New cr_SalesPerProperty
                    SetCompanyName(crV)


                    Dim txtsdate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtstartdate")
                    Dim txtedate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtenddate")

                    txtsdate.Text = Me.dtpinitialdate.Value.ToShortDateString
                    txtedate.Text = Me.dtpendingdate.Value.ToShortDateString

                    crV.SetDataSource(dtRecord)
                    Me.crptviewer.ReportSource = crV
                Catch ex As Exception
                    CustommsgBox(msgstyle.critical, msgtype.okonly, "Something went wrong!", "Could not create report. Please try again.")
                End Try
            Case report.saleswithloans
                Try
                    Dim dtRecord As DataTable = clsPayment.FetchDateRange(22, "", Me.dtpinitialdate.Value, Me.dtpendingdate.Value)

                    Dim crV As New cr_withloans
                    SetCompanyName(crV)


                    Dim txtsdate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtstartdate")
                    Dim txtedate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtenddate")

                    txtsdate.Text = Me.dtpinitialdate.Value.ToShortDateString
                    txtedate.Text = Me.dtpendingdate.Value.ToShortDateString

                    crV.SetDataSource(dtRecord)
                    Me.crptviewer.ReportSource = crV
                Catch ex As Exception
                    CustommsgBox(msgstyle.critical, msgtype.okonly, "Something went wrong!", "Could not create report. Please try again.")
                End Try
            Case report.saleswithoutloans
                Try
                    Dim dtRecord As DataTable = clsPayment.FetchDateRange(23, "", Me.dtpinitialdate.Value, Me.dtpendingdate.Value)

                    Dim crV As New cr_withoutloans
                    SetCompanyName(crV)


                    Dim txtsdate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtstartdate")
                    Dim txtedate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtenddate")

                    txtsdate.Text = Me.dtpinitialdate.Value.ToShortDateString
                    txtedate.Text = Me.dtpendingdate.Value.ToShortDateString

                    crV.SetDataSource(dtRecord)
                    Me.crptviewer.ReportSource = crV
                Catch ex As Exception
                    CustommsgBox(msgstyle.critical, msgtype.okonly, "Something went wrong!", "Could not create report. Please try again.")
                End Try

            Case report.incomestatement
                Try
                    Dim dtRecord As DataTable = clsPayment.FetchDateRange(7, "", Me.dtpinitialdate.Value, Me.dtpendingdate.Value)
                    Dim dtRecord1 As DataTable = clsPayment.FetchDateRange(6, "", Me.dtpinitialdate.Value, Me.dtpendingdate.Value)
                    Dim crV As New cr_IncomeStatement
                    SetCompanyName(crV)


                    Dim txtsdate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtstartdate")
                    Dim txtedate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtenddate")

                    txtsdate.Text = Me.dtpinitialdate.Value.ToShortDateString
                    txtedate.Text = Me.dtpendingdate.Value.ToShortDateString

                    crV.SetDataSource(dtRecord)
                    crV.Subreports(0).SetDataSource(dtRecord1)
                    crV.SetDataSource(dtRecord1)
                    Me.crptviewer.ReportSource = crV
                Catch ex As Exception
                    CustommsgBox(msgstyle.critical, msgtype.okonly, "Something went wrong!", "Could not create report. Please try again.")
                End Try

                'Try
                '    Dim dtRecord1 As DataTable = clsjunix.FetchDateRange(7, "", Me.dtpinitialdate.Value, Me.dtpendingdate.Value, "")
                '    Dim crV As New cr_IncomeStatement
                '    SetCompanyName(crV)


                '    Dim txtsdate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtstartdate")
                '    Dim txtedate As CrystalDecisions.CrystalReports.Engine.TextObject = crV.ReportDefinition.Sections("Section2").ReportObjects.Item("txtenddate")

                '    txtsdate.Text = Me.dtpinitialdate.Value.ToShortDateString
                '    txtedate.Text = Me.dtpendingdate.Value.ToShortDateString

                '    crV.SetDataSource(dtRecord1)
                '    Me.crptviewer.ReportSource = crV
                'Catch ex As Exception
                '    CustommsgBox(msgstyle.critical, msgtype.okonly, "Something went wrong!", "Could not create report. Please try again.")
                'End Try
        End Select

    End Sub
    Private Sub LoadDateRange(ByRef idx As Integer)
        Me.dtpinitialdate.Enabled = False
        Me.dtpendingdate.Enabled = False
        Select Case idx
            Case 0
                Me.dtpinitialdate.Value = Date.Now
                Me.dtpendingdate.Value = Date.Now
            Case 1
                Me.dtpendingdate.Value = Date.Now
                Dim today As Date = Date.Today
                Me.dtpinitialdate.Value = today.AddDays(-(today.DayOfWeek - DayOfWeek.Sunday))
            Case 2
                Me.dtpendingdate.Value = Date.Now
                Dim today As Date = Date.Today
                Me.dtpinitialdate.Value = New DateTime(today.Year, today.Month, 1)
            Case 3
                Me.dtpendingdate.Value = Date.Now
                Dim today As Date = Date.Today
                Me.dtpinitialdate.Value = New DateTime(today.Year, Int((today.Month - 1) / 3) * 3 + 1, 1)
            Case 4
                Me.dtpendingdate.Value = Date.Now
                Dim today As Date = Date.Today
                Me.dtpinitialdate.Value = New DateTime(today.Year, 1, 1)
            Case 5
                Me.dtpinitialdate.Value = Date.Now
                Me.dtpendingdate.Value = Date.Now
                Me.dtpinitialdate.Enabled = True
                Me.dtpendingdate.Enabled = True
        End Select
    End Sub
#End Region



    Private Sub btnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReload.Click
        Call ShowReport()
    End Sub

    Private Sub cmbPeriod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPeriod.SelectedIndexChanged
        LoadDateRange(cmbPeriod.SelectedIndex)
        Call ShowReport()
    End Sub

    Private Sub cmbReport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReport.SelectedIndexChanged
        Call ShowReport()
    End Sub

    Private Sub dtpendingdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpendingdate.ValueChanged

    End Sub

End Class