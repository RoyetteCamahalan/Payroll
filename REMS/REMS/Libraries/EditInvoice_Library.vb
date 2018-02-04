Public Class EditInvoice_Library
#Region "Variables"
    Public InvoiceNo As Integer
    Public SelectedCustomer As Integer = 0
    Public SelectedAgent As Integer = 0
#End Region
#Region "Methods"
    Private Sub LoadRecord()
        Try
            Dim DT As New DataTable
            Dim s As New Public_Modules
            Dim Param_Name As String() = {"@action_type", "@sub_action", "@invoice_no"}
            Dim Param_Value As String() = {2, 3, InvoiceNo}
            DT = s.CUSTOM_RETRIEVE("SP_Invoices", Param_Name, Param_Value)
            SelectedCustomer = DT.Rows(0).Item("CUSTID")
            txt_Customer.Text = DT.Rows(0).Item("Customer")
            txt_interest.Text = DT.Rows(0).Item("INTEREST")
            txt_terms_payment.Text = DT.Rows(0).Item("TERM_PAYMENT")
            dtp_invoiceDate.Value = CDate(DT.Rows(0).Item("INVOICEDATE")).Date
            dtp_payment_schedule.Value = CDate(DT.Rows(0).Item("PAYMENTSCHED")).Date
            txt_com_percentage.Text = DT.Rows(0).Item("COMPERCENTAGE")
            txt_com_at_down.Text = DT.Rows(0).Item("COMATDOWN")
            txt_term_commission.Text = DT.Rows(0).Item("TERM_COMMISSION")
            SelectedAgent = DT.Rows(0).Item("AGENTID")
            txt_agent.Text = DT.Rows(0).Item("AGENTNAME")
            txt_commission.Text = DT.Rows(0).Item("AGENTCOM")

            Param_Name = {"@action_type", "@sub_action", "@invoice_no"}
            Param_Value = {2, 4, InvoiceNo}
            DT = s.CUSTOM_RETRIEVE("SP_Invoices", Param_Name, Param_Value)
            With DT
                For i As Integer = 0 To .Rows.Count - 1
                    dtgv_InvoiceDetails.Rows.Add(.Rows(0).Item("PROPERTYNAME"), .Rows(0).Item("LOTTYPE"), .Rows(0).Item("AREA"),
                                                 .Rows(0).Item("PRICE"), .Rows(0).Item("TOTALPRICE"), .Rows(0).Item("LOT_ID"), "0", "0")
                Next
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadUplines()
        Try
            Dim DT As New DataTable
            Dim s As New Public_Modules
            Dim Param_Name As String() = {"@action_type", "@sub_action", "@invoiceno"}
            Dim Param_Value As String() = {2, 5, InvoiceNo}
            With dtgv_Uplines
                .DataSource = s.CUSTOM_RETRIEVE("SP_AgentTree", Param_Name, Param_Value)
                .Columns(0).Visible = False
                .Columns(1).ReadOnly = True
                .Columns(2).ReadOnly = True
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub MoveLot(ByRef newlotid As Integer, ByRef newparcel As String,
                       ByRef newtype As String, ByRef newarea As Double, ByRef newprice As Double,
                       ByRef newreserveid As Integer)
        Try
            With dtgv_InvoiceDetails.CurrentRow
                .Cells("Parcel_Name").Value = newparcel
                .Cells("Type").Value = newtype
                .Cells("Area").Value = newarea
                .Cells("Price").Value = newprice
                .Cells("Total").Value = newarea * newprice
                .Cells("new_lotid").Value = newlotid
                .Cells("reserve_id").Value = newreserveid
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub DisplayTree()
        Dim Param_Name As String() = {"@action_type", "@sub_action", "@bottom_id"}
        Dim Param_Value As String() = {2, 3, SelectedAgent}
        Dim MyBridge As New Public_Modules
        Dim MyBridge2 As New Public_Modules
        Dim DT As New DataTable
        With dtgv_Uplines
            .DataSource = MyBridge.CUSTOM_RETRIEVE("SP_AgentTree", Param_Name, Param_Value)
            .Columns(0).Visible = False
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
        End With
        Param_Name = {"@action_type", "@sub_action", "@bottom_id"}
        Param_Value = {2, 2, SelectedAgent}
        DT = MyBridge2.CUSTOM_RETRIEVE("SP_AgentTree", Param_Name, Param_Value)
        txt_commission.Text = DT.Rows(0).Item(0)
    End Sub

    Private Function ValidateData() As Boolean
        If dtgv_InvoiceDetails.Rows.Count = 0 Then
            CustommsgBox(msgstyle.critical, msgtype.okonly, "Something went wrong!", "Could not create report. Please try again.")
            CustommsgBox(msgstyle.warning, msgtype.okonly, "Edit Invoice", "Please add lot.")
            Return False
        End If
        If SelectedCustomer = 0 Then
            CustommsgBox(msgstyle.warning, msgtype.okonly, "Edit Invoice", "Please select customer!")
            Return False
        End If
        If SelectedAgent = 0 Then
            CustommsgBox(msgstyle.warning, msgtype.okonly, "Edit Invoice", "Please select agent!")
            Return False
        End If
        If txt_terms_payment.Text = "" Then
            CustommsgBox(msgstyle.warning, msgtype.okonly, "Edit Invoice", "Please fill terms of payment!")
            Return False
        End If
        If txt_com_percentage.Text = "" Then
            CustommsgBox(msgstyle.warning, msgtype.okonly, "Edit Invoice", "Please fill commission percentage!")
            Return False
        End If
        If txt_com_at_down.Text = "" Then
            CustommsgBox(msgstyle.warning, msgtype.okonly, "Edit Invoice", "Please fill commission percentage at downpayment!")
            Return False
        End If
        If txt_term_commission.Text = "" Then
            CustommsgBox(msgstyle.warning, msgtype.okonly, "Edit Invoice", "Please fill terms of commission!")
            Return False
        End If
        If txt_commission.Text = "" Then
            CustommsgBox(msgstyle.warning, msgtype.okonly, "Edit Invoice", "Please fill agent commission!")
            Return False
        End If
        
        Dim Com_Total As Decimal = Val(txt_commission.Text)
        For i As Integer = 0 To dtgv_Uplines.Rows.Count - 1
            Com_Total = Com_Total + Val(dtgv_Uplines.Rows(i).Cells(3).Value)
        Next
        If Com_Total > Val(txt_com_percentage.Text) Then
            CustommsgBox(msgstyle.warning, msgtype.okonly, "Edit Invoice", "Total Commission for all agents exceeds the maximum commission limit of " + Val(txt_com_percentage.Text).ToString + "!")
            Return False
        End If
        Return True
    End Function
    Private Sub SaveInvoice()
        Try
            Dim Param_Name As String() = {"@action_type", "@sub_action", "@cust_id", "@invoice_date",
                                          "@com_percentage", "@com_at_down", "@interest", "@term_payment",
                                          "@term_commission", "@payment_schedule", "@invoice_no"}
            Dim Param_Value As String() = {1, 0, SelectedCustomer, dtp_invoiceDate.Value.ToShortDateString,
                                           txt_com_percentage.Text, txt_com_at_down.Text,
                                           txt_interest.Text, Val(txt_terms_payment.Text),
                                          Val(txt_term_commission.Text), dtp_payment_schedule.Value.ToShortDateString, InvoiceNo}
            Dim MyBridge As New Public_Modules

            If MyBridge.CUSTOM_TRANSACT("SP_Invoices", Param_Name, Param_Value) Then
                For i As Integer = 0 To dtgv_InvoiceDetails.Rows.Count - 1
                    'Insert to Invoice Details
                    If Not dtgv_InvoiceDetails.Rows(i).Cells("new_lotid").Value = 0 Then
                        Param_Name = {"@action_type", "@sub_action", "@invoice_no", "@lot_id",
                                                                                      "@price"}
                        Param_Value = {0, 1, InvoiceNo, dtgv_InvoiceDetails.Rows(i).Cells("lot_id").Value,
                                        dtgv_InvoiceDetails.Rows(i).Cells("Price").Value}
                        MyBridge.CUSTOM_TRANSACT("SP_Invoices", Param_Name, Param_Value)
                    End If


                    If dtgv_InvoiceDetails.Rows(i).Cells("reserve_id").Value > 0 Then
                        Param_Name = {"@action_type", "@sub_action", "@status", "@id"}
                        Param_Value = {1, 1, 1, dtgv_InvoiceDetails.Rows(i).Cells(8).Value}
                        MyBridge.CUSTOM_TRANSACT("SP_Reservation", Param_Name, Param_Value)
                    End If
                Next

                Param_Name = {"@action_type", "@sub_action", "@invoice_no"}
                Param_Value = {3, 0, InvoiceNo}
                MyBridge.CUSTOM_TRANSACT("SP_Invoices", Param_Name, Param_Value)

                Param_Name = {"@action_type", "@sub_action", "@invoice_no",
                              "@agent_id", "@agent_com_percentage", "@is_agent"}
                Param_Value = {0, 2, InvoiceNo,
                               SelectedAgent, txt_commission.Text, 1}
                MyBridge.CUSTOM_TRANSACT("SP_Invoices", Param_Name, Param_Value)
                For i As Integer = 0 To dtgv_Uplines.Rows.Count - 1
                    Param_Name = {"@action_type", "@sub_action", "@invoice_no",
                              "@agent_id", "@agent_com_percentage", "@is_agent"}
                    Param_Value = {0, 2, InvoiceNo,
                                   dtgv_Uplines.Rows(i).Cells(0).Value, dtgv_Uplines.Rows(i).Cells(3).Value, 0}
                    MyBridge.CUSTOM_TRANSACT("SP_Invoices", Param_Name, Param_Value)
                Next

                CustommsgBox(msgstyle.info, msgtype.okonly, "Edit Invoice", "Invoice has been edited!")
                Invoices.DisplayInvoices()
                Me.Dispose()
            Else
                CustommsgBox(msgstyle.critical, msgtype.okonly, "Edit Invoice", "Updating Invoice Failed.")
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
    Private Sub EditInvoice_Library_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_invoiceDate.MaxDate = GetServerDate().Date
        dtp_payment_schedule.MaxDate = DateAdd(DateInterval.Month, 1, GetServerDate().Date)
        LoadRecord()
        LoadUplines()
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Dispose()
    End Sub

    Private Sub btn_choose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_choose.Click
        'Select_Customer.requestCode = 3
        'Select_Customer.ShowDialog()
    End Sub

    Private Sub btn_choose_agent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_choose_agent.Click
        'Selection_Agent.Agent_ID = 0
        'Selection_Agent.requestCode = 3
        'Selection_Agent.ShowDialog()
    End Sub

    Private Sub ts_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_add.Click
        'Select_Parcel.requestCode = 2
        'Select_Parcel.Selected_Customer = Me.SelectedCustomer
        'Select_Parcel.ShowDialog()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If ValidateData() Then
            SaveInvoice()
        End If
    End Sub
End Class