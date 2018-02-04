Imports System.Data
Imports System.Data.SqlClient
Public Class reportsform

    Private Sub reportsform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Text = Date.Now()
        displayagents()
        displayproperty()
    End Sub

    Dim ds, dsprop As New DataSet
    Dim da As New SqlDataAdapter
    Private howtosort As String = "Agent"
   
    Public Sub displayagents()
        Try
            'openconnection()
            ds.Clear()
            da = New SqlDataAdapter("select AGENTID,coalesce(LNAME,'')+' '+coalesce(FNAME,'')+' '+coalesce(MI,'')as agentname,lname,fname,mi,CONTACTNO,BIRTHDATE,ADDRESS,position,SUPERIORID from AGENT order by agentname", conn)
            da.Fill(ds, "agent")
            With cmbagent
                .DataSource = ds.Tables("agent")
                .DisplayMember = "agentname"
                .ValueMember = "AGENTID"
            End With
            Dim ds1 As New DataSet
            da = New SqlDataAdapter("select 0 AS AGENTID,'  All Agents' as agentname union all select AGENTID,coalesce(LNAME,'')+' '+coalesce(FNAME,'')+' '+coalesce(MI,'')as agentname from AGENT order by agentname", conn)
            da.Fill(ds1, "agent")
            With cmb_agent2
                .DataSource = ds1.Tables("agent")
                .DisplayMember = "agentname"
                .ValueMember = "AGENTID"
                .SelectedIndex = 0
            End With
        Catch ex As Exception

        End Try
        'closeconnection()
    End Sub

    Private Sub cmbagent_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbagent.SelectedValueChanged
        displayvoucher(cmbagent.SelectedValue.ToString, "")
    End Sub
    Private Sub displayvoucher(ByRef id As String, ByRef search As String)
        Try
            'openconnection()
            Dim ds As New DataSet
            da = New SqlDataAdapter("select cp.VOUCHERNO as [Voucher No.],cp.COMPAYMENTDATE as [Payment Date],SUM(cpd.AMOUNT )as Amount,COALESCE (U.lname, '') + ' ' + COALESCE (U.fname, '') + ' ' + COALESCE (U.mi, '') AS Encoder " &
                                    ",U.lname,U.fname,U.mi from  COMPAYMENT cp inner join COMMISIONPAYMENT cpd on cp.VOUCHERNO =cpd.VOUCHERNO inner join USERS u on u.USERID=cp.ENCODEDBY " &
                                    " where cp.AGENTID=" + id + search + "  group by cp.VOUCHERNO,cp.COMPAYMENTDATE ,COALESCE (U.lname, '') + ' ' + COALESCE (U.fname, '') + ' ' + COALESCE (U.mi, ''),U.lname,U.fname,U.mi" &
                                    " order by cp.VOUCHERNO desc", conn)
            da.Fill(ds, "vouchers")
            With dtgvvouchers
                .DataSource = ds.Tables("vouchers")
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
            End With
        Catch ex As Exception

        End Try
        'closeconnection()

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Try
            displayvoucher(cmbagent.SelectedValue.ToString, " and cp.voucherno like '%" + TextBox2.Text + "%'")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            displayvoucher(cmbagent.SelectedValue.ToString, " and cp.COMPAYMENTDATE='" + DateTimePicker1.Text + "'")
        Catch ex As Exception

        End Try
    End Sub

    
#Region "property"
    Public Sub displayproperty()
        'openconnection()
        dsprop.Clear()
        da = New SqlDataAdapter("select 0 PROPERTYID,'All Property' PROPERTYNAME,'' ADDRESS,0 AREA union all Select * from property", conn)
        da.Fill(dsprop)
        With cmbproperty
            .DataSource = dsprop.Tables(0)
            .DisplayMember = "PROPERTYNAME"
            .ValueMember = "PROPERTYID"
            .SelectedIndex = 0
        End With
        'closeconnection()
    End Sub
    Private Sub cmbproperty_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbproperty.SelectedValueChanged
        Try
            If cmbproperty.SelectedIndex <> 0 Then
                cmb_agent2.SelectedIndex = 0
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

    Private Sub rdbtn_agent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtn_agent.CheckedChanged
        If rdbtn_agent.Checked = True Then
            howtosort = "Agent"
        End If
    End Sub

    Private Sub rdbtn_customer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtn_customer.CheckedChanged
        If rdbtn_customer.Checked = True Then
            howtosort = "Customer"
        End If
    End Sub

    Private Sub rdbtn_property_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtn_property.CheckedChanged
        If rdbtn_property.Checked = True Then
            howtosort = "Property"
        End If
    End Sub

    Private Sub cmb_agent2_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_agent2.SelectedValueChanged
        Try
            If cmb_agent2.SelectedIndex <> 0 Then
                cmbproperty.SelectedIndex = 0
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbagent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbagent.SelectedIndexChanged

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_details.Click
        Try
            'Dim report1 As New crvoucher
            'Dim reportcontainer As New comreports
            'report1.SetDatabaseLogon(databaseuserid, databasepword)
            'report1.SetParameterValue(0, dtgvvouchers.CurrentRow.Cells(0).Value)
            'Dim preparedby As CrystalDecisions.CrystalReports.Engine.TextObject
            'preparedby = report1.ReportDefinition.Sections("Section2").ReportObjects.Item("txt_preparedby")
            'If dtgvvouchers.CurrentRow.Cells(6).Value.ToString = "" Then
            '    preparedby.Text = dtgvvouchers.CurrentRow.Cells(5).Value.ToString + " " + dtgvvouchers.CurrentRow.Cells(4).Value.ToString
            'Else
            '    preparedby.Text = dtgvvouchers.CurrentRow.Cells(5).Value.ToString + " " + dtgvvouchers.CurrentRow.Cells(6).Value.ToString + ". " + dtgvvouchers.CurrentRow.Cells(4).Value.ToString
            'End If
            'Dim agentid As CrystalDecisions.CrystalReports.Engine.TextObject
            'agentid = report1.ReportDefinition.Sections("Section2").ReportObjects.Item("text26")
            'agentid.Text = cmbagent.SelectedValue
            'Dim name As CrystalDecisions.CrystalReports.Engine.TextObject
            'name = report1.ReportDefinition.Sections("Section2").ReportObjects.Item("text27")
            'name.Text = ds.Tables("agent").Rows(cmbagent.SelectedIndex).Item("agentname").ToString
            'Dim ADDRESS As CrystalDecisions.CrystalReports.Engine.TextObject
            'ADDRESS = report1.ReportDefinition.Sections("Section2").ReportObjects.Item("text30")
            'ADDRESS.Text = ds.Tables("agent").Rows(cmbagent.SelectedIndex).Item("ADDRESS").ToString
            'Dim contactno As CrystalDecisions.CrystalReports.Engine.TextObject
            'contactno = report1.ReportDefinition.Sections("Section2").ReportObjects.Item("text31")
            'contactno.Text = ds.Tables("agent").Rows(cmbagent.SelectedIndex).Item("contactno").ToString
            'Dim voucherno As CrystalDecisions.CrystalReports.Engine.TextObject
            'voucherno = report1.ReportDefinition.Sections("Section1").ReportObjects.Item("text10")
            'voucherno.Text = dtgvvouchers.CurrentRow.Cells(0).Value.ToString
            'Dim voucherdate As CrystalDecisions.CrystalReports.Engine.TextObject
            'voucherdate = report1.ReportDefinition.Sections("Section1").ReportObjects.Item("text13")
            'voucherdate.Text = dtgvvouchers.CurrentRow.Cells(1).Value.ToString
            'Dim agentname1 As CrystalDecisions.CrystalReports.Engine.TextObject
            'agentname1 = report1.ReportDefinition.Sections("Section2").ReportObjects.Item("text19")
            'agentname1.Text = ds.Tables("agent").Rows(cmbagent.SelectedIndex).Item("agentname").ToString
            'reportcontainer.CrystalReportViewer1.ReportSource = report1
            'reportcontainer.CrystalReportViewer1.Refresh()
            'reportcontainer.Show()
        Catch ex As Exception
            MsgBox("Could not create report, please check connection")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DirectCustomersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectCustomersToolStripMenuItem.Click
        Try
            If cmbagent.SelectedIndex = -1 Then
                MsgBox("Please Select Agent")
            Else
                'Dim report As New direct_customers
                'Dim reportcontainer As New comreports
                'report.SetDatabaseLogon(databaseuserid, databasepword)
                'Dim agentid As CrystalDecisions.CrystalReports.Engine.TextObject
                'agentid = report.ReportDefinition.Sections("Section2").ReportObjects.Item("text26")
                'agentid.Text = cmbagent.SelectedValue
                'Dim name As CrystalDecisions.CrystalReports.Engine.TextObject
                'name = report.ReportDefinition.Sections("Section2").ReportObjects.Item("text27")
                'name.Text = ds.Tables("agent").Rows(cmbagent.SelectedIndex).Item("agentname").ToString
                'Dim ADDRESS As CrystalDecisions.CrystalReports.Engine.TextObject
                'ADDRESS = report.ReportDefinition.Sections("Section2").ReportObjects.Item("text30")
                'ADDRESS.Text = ds.Tables("agent").Rows(cmbagent.SelectedIndex).Item("ADDRESS").ToString
                'Dim contactno As CrystalDecisions.CrystalReports.Engine.TextObject
                'contactno = report.ReportDefinition.Sections("Section2").ReportObjects.Item("text31")
                'contactno.Text = ds.Tables("agent").Rows(cmbagent.SelectedIndex).Item("contactno").ToString
                'report.Refresh()
                'report.SetParameterValue(0, cmbagent.SelectedValue)
                'reportcontainer.CrystalReportViewer1.ReportSource = report
                'reportcontainer.CrystalReportViewer1.Refresh()
                'reportcontainer.Show()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_view_available.Click
        Try

            If cmbproperty.SelectedIndex < 0 Then
                MsgBox("Please Select Property", MsgBoxStyle.OkOnly, "GCG Realty")
            Else
                Dim strquery As String = ""
                If cmbproperty.SelectedValue = 0 Then
                    'Dim report1 As New allavailable_lots
                    'Dim reportcontainer As New comreports
                    'report1.SetDatabaseLogon(databaseuserid, databasepword)
                    'report1.Refresh()
                    'reportcontainer.CrystalReportViewer1.ReportSource = report1
                    'reportcontainer.CrystalReportViewer1.Refresh()
                    'reportcontainer.Show()
                Else
                    'strquery = "select l.LOT_ID  [Lot ID], COALESCE (LOTNO, '')+ ' ' + COALESCE (STREET, '') + ' ' + COALESCE (BLOCKNO, '') + ' ' + COALESCE (PHASE, '') as [Lot Name], convert(char(6),l.AREA)+ ' sqr meter' as Area,lc.DESCRIPTION,lc.PRICE ,lc.DOWNPAYMENT AS [Minimum Downpayment],lc.PRICE*L.AREA AS [Total Price]  from PROPERTY P  INNER JOIN LOTCATEGORY lc on lc.PROPERTYID=p.PROPERTYID inner join LOT l on l.CATEGORYID=lc.CATEGORYID   WHERE p.PROPERTYID=" + cmbproperty.SelectedValue.ToString + " AND L.AVAILABILITY='y' "
                    'Dim report1 As New available_lots
                    'Dim reportcontainer As New comreports
                    'report1.SetDatabaseLogon(databaseuserid, databasepword)
                    'Dim propid As CrystalDecisions.CrystalReports.Engine.TextObject
                    'propid = report1.ReportDefinition.Sections("Section2").ReportObjects.Item("text26")
                    'propid.Text = cmbproperty.SelectedValue.ToString
                    'Dim propname As CrystalDecisions.CrystalReports.Engine.TextObject
                    'propname = report1.ReportDefinition.Sections("Section2").ReportObjects.Item("text27")
                    'propname.Text = dsprop.Tables(0).Rows(cmbproperty.SelectedIndex.ToString).Item(1).ToString
                    'Dim propaddress As CrystalDecisions.CrystalReports.Engine.TextObject
                    'propaddress = report1.ReportDefinition.Sections("Section2").ReportObjects.Item("text30")
                    'propaddress.Text = dsprop.Tables(0).Rows(cmbproperty.SelectedIndex.ToString).Item(2).ToString
                    'Dim proparea As CrystalDecisions.CrystalReports.Engine.TextObject
                    'proparea = report1.ReportDefinition.Sections("Section2").ReportObjects.Item("text31")
                    'proparea.Text = dsprop.Tables(0).Rows(cmbproperty.SelectedIndex.ToString).Item(3).ToString
                    'report1.Refresh()
                    'report1.SetParameterValue(0, strquery)
                    'reportcontainer.CrystalReportViewer1.ReportSource = report1
                    'reportcontainer.CrystalReportViewer1.Refresh()
                    'reportcontainer.Show()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_forfeit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_forfeit.Click
        Try
            'Dim reportcontainer As New comreports
            Dim sortparam As String = "[Agent Name]"
            Select Case howtosort
                Case "Customer"
                    sortparam = "[Customer Name]"
                Case "Property"
                    sortparam = "[Property Name]"
            End Select
            If cmbproperty.SelectedIndex = 0 Then
                'Dim report1 As New forfeiting_candidate
                'If cmb_agent2.SelectedIndex = 0 Then
                '    report1.SetDatabaseLogon(databaseuserid, databasepword)
                '    Dim propid As CrystalDecisions.CrystalReports.Engine.TextObject
                '    propid = report1.ReportDefinition.Sections("Section1").ReportObjects.Item("text9")
                '    propid.Text = "As of " + Date.Now.ToString
                '    report1.Refresh()
                '    report1.SetParameterValue(0, sortparam)
                '    report1.SetParameterValue(1, "")
                '    reportcontainer.CrystalReportViewer1.ReportSource = report1
                '    reportcontainer.CrystalReportViewer1.Refresh()
                '    reportcontainer.Show()
                'Else
                '    report1.SetDatabaseLogon(databaseuserid, databasepword)
                '    Dim propid As CrystalDecisions.CrystalReports.Engine.TextObject
                '    propid = report1.ReportDefinition.Sections("Section1").ReportObjects.Item("text9")
                '    propid.Text = "As of " + Date.Now.ToString
                '    report1.Refresh()
                '    report1.SetParameterValue(0, sortparam)
                '    report1.SetParameterValue(1, " and agentid=" + cmb_agent2.SelectedValue.ToString)
                '    reportcontainer.CrystalReportViewer1.ReportSource = report1
                '    reportcontainer.CrystalReportViewer1.Refresh()
                '    reportcontainer.Show()
                'End If

            Else
                'Dim report1 As New forfeiting_per_property
                'report1.SetDatabaseLogon(databaseuserid, databasepword)
                'Dim asof As CrystalDecisions.CrystalReports.Engine.TextObject
                'asof = report1.ReportDefinition.Sections("Section1").ReportObjects.Item("text16")
                'asof.Text = "As of " + Date.Now.ToString
                'Dim propid As CrystalDecisions.CrystalReports.Engine.TextObject
                'propid = report1.ReportDefinition.Sections("Section2").ReportObjects.Item("text26")
                'propid.Text = cmbproperty.SelectedValue.ToString
                'Dim propname As CrystalDecisions.CrystalReports.Engine.TextObject
                'propname = report1.ReportDefinition.Sections("Section2").ReportObjects.Item("text27")
                'propname.Text = dsprop.Tables(0).Rows(cmbproperty.SelectedIndex.ToString).Item(1).ToString
                'Dim propaddress As CrystalDecisions.CrystalReports.Engine.TextObject
                'propaddress = report1.ReportDefinition.Sections("Section2").ReportObjects.Item("text30")
                'propaddress.Text = dsprop.Tables(0).Rows(cmbproperty.SelectedIndex.ToString).Item(2).ToString
                'Dim proparea As CrystalDecisions.CrystalReports.Engine.TextObject
                'proparea = report1.ReportDefinition.Sections("Section2").ReportObjects.Item("text31")
                'proparea.Text = dsprop.Tables(0).Rows(cmbproperty.SelectedIndex.ToString).Item(3).ToString
                'report1.Refresh()
                'report1.SetParameterValue(0, cmbproperty.SelectedValue)
                'report1.SetParameterValue(1, sortparam)
                'reportcontainer.CrystalReportViewer1.ReportSource = report1
                'reportcontainer.CrystalReportViewer1.Refresh()
                'reportcontainer.Show()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Try
            Dim msg As String = ""
            If howtosort = "Agent" Then
                msg = " order by [Agent Name]"
            ElseIf howtosort = "Customer" Then
                msg = " order by [Cutomer Name]"
            ElseIf howtosort = "Property" Then
                msg = " order by [propertyname]"
            End If
            'If cmbproperty.SelectedIndex = 0 Then
            '    If cmb_agent2.SelectedIndex = 0 Then
            '        Dim report As New crcollectables
            '        Dim reportcontainer As New comreports
            '        report.SetDatabaseLogon(databaseuserid, databasepword)
            '        report.Refresh()
            '        report.SetParameterValue(0, " " + msg)
            '        reportcontainer.CrystalReportViewer1.ReportSource = report
            '        reportcontainer.CrystalReportViewer1.Refresh()
            '        reportcontainer.Show()
            '    Else
            '        Dim report As New crcollectables
            '        Dim reportcontainer As New comreports
            '        report.SetDatabaseLogon(databaseuserid, databasepword)
            '        report.Refresh()
            '        report.SetParameterValue(0, "and agentid=" + cmb_agent2.SelectedValue.ToString + msg)
            '        reportcontainer.CrystalReportViewer1.ReportSource = report
            '        reportcontainer.CrystalReportViewer1.Refresh()
            '        reportcontainer.Show()
            '    End If

            'Else
            '    Dim report As New crcollectables

            '    report.SetDatabaseLogon(databaseuserid, databasepword)
            '    Dim reportcontainer As New comreports
            '    report.Refresh()
            '    report.SetParameterValue(0, " and where propertyid=" + cmbproperty.SelectedValue.ToString + msg)
            '    reportcontainer.CrystalReportViewer1.ReportSource = report
            '    reportcontainer.CrystalReportViewer1.Refresh()
            '    reportcontainer.Show()
            'End If
        Catch ex As Exception
            MsgBox("Could Not Display Collectables")
        End Try
    End Sub
End Class