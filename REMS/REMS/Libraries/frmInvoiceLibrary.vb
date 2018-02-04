Public Class frmInvoiceLibrary

    Private Sub frmCashier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgvItems.RowTemplate.Height = Default_Row_Height
        Me.dgvmain.RowTemplate.Height = Default_Row_Height
        Call SetupDatatable()
        Call LoadLoanSource()
        If myCurrentFormStatus = enFormStatus.add Then
            Dim d As Date = Utility.GetServerDate().ToShortDateString
            Me.txtOrDate.Text = d.ToShortDateString
            Me.dtpinvoicedate.Value = d
            Me.dtppaymentsched.Value = d
            Me.dtpexpiration.Value = DateAdd(DateInterval.Month, Utility.SystemSetting(Utility.systemsettings.ReservationDuration), d)
            Me.txtinterest.Text = Utility.SystemSetting(Utility.systemsettings.Interest)
            Me.txtpaymentterm.Text = Utility.SystemSetting(Utility.systemsettings.PaymentTerm)
            Me.txt_term_commission.Text = Utility.SystemSetting(Utility.systemsettings.CommissionTerm)
            Me.txtpercentageoverterm.Text = Utility.SystemSetting(Utility.systemsettings.CommissionOverTerm)
            If Not IsModuleActive(applicationmodule.modloans) Then
                Me.panelloansouce.Visible = False
                Me.lblloansource.Visible = False
                Me.dgvItems.Columns("loan").Visible = False
            End If
        Else
            Call LoadRecord()
        End If
       
        Call EnableFields()
    End Sub
#Region "Variables"
    Public myCurrentFormStatus As enFormStatus
    Public InvoiceNo As Long
    Public issave As Boolean = False
    Private CustID, PaymentID, AgentID As Long
    Dim erp As New ErrorProvider
    Public Cash, TotalPayment, Change, banktobank, check As Double
    Public dtOtherPayment As New DataTable
    Private dtforRemove As New DataTable

    Private coldiscount As Integer = 3
    Private colloan As Integer = 5
    Private colcommissionable As Integer = 6
    Private coladcom As Integer = 7
    Private colcompercentage As Integer = 8
    Private colreservefee As Integer = 9

    Enum enFormStatus
        add = 0
        edit = 1
        view = 2
    End Enum
#End Region
#Region "Methods"
    Private Sub EnableFields()
        If myCurrentFormStatus = enFormStatus.view Then
            Me.btnAddItem.Visible = False
            Me.btnRemoveItem.Visible = False
            Me.dgvItems.ReadOnly = True
            pctrSearchCustomer.Visible = False
            Me.pctrPayment.Image = My.Resources.ic_view
        ElseIf myCurrentFormStatus = enFormStatus.edit Then
            Me.btnAddItem.Visible = False
            Me.btnRemoveItem.Visible = False
        End If
    End Sub
    Private Sub LoadLoanSource()
        With cmbloansource
            .DataSource = clsPayment.Fetch(16, "")
            .DisplayMember = "NAME"
            .ValueMember = "institutionid"
            .SelectedValue = 0
        End With
    End Sub
    Private Sub LoadRecord()
        'Dim dtRecord As DataTable = clsCashier.getGeneric(9, ChargeID)
        'Me.txtOrNo.Text = dtRecord.Rows(0).Item("orno")
        'Me.txtOrDate.Text = dtRecord.Rows(0).Item("ordate")
        'Me.CustID = dtRecord.Rows(0).Item("patientid")
        'Me.PaymentID = dtRecord.Rows(0).Item("paymentid")
        'Me.txtRemarks.Text = dtRecord.Rows(0).Item("remarks")
        'Call loadPatient(Me.CustID)
        'Me.Cash = dtRecord.Rows(0).Item("cash")
        'Me.TotalPayment = dtRecord.Rows(0).Item("totalpayment")
        'dtRecord.Clear() : dtRecord = clsCashier.getGeneric(10, ChargeID)
        'Dim subdiscount As Double = 0
        'For i As Integer = 0 To dtRecord.Rows.Count - 1
        '    Dim tmpdt As New DataTable
        '    Me.dgvItems.Rows.Add(1)
        '    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = dtRecord.Rows(i).Item("chargedetailsid")
        '    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = False
        '    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = Utility.FormatMultupleIDs(dtRecord.Rows(i).Item("itemcode"), "Item")
        '    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = dtRecord.Rows(i).Item("retailitemcode")
        '    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = dtRecord.Rows(i).Item("actualquantity")
        '    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = dtRecord.Rows(i).Item("linediscount")
        '    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(8).Value = dtRecord.Rows(i).Item("unitcost")
        '    Dim dtPrices As DataTable = clsCashier.getGeneric(2, dtRecord.Rows(i).Item("itemcode"))
        '    Dim dgvcc As DataGridViewComboBoxCell
        '    Dim tempdt As New DataTable : tempdt.Columns.Add("Prices")
        '    dgvcc = Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5)
        '    tempdt.Rows.Add(dtPrices.Rows(0).Item("price1"))
        '    tempdt.Rows.Add(dtPrices.Rows(0).Item("price2"))
        '    tempdt.Rows.Add(dtPrices.Rows(0).Item("price3"))
        '    dgvcc.DataSource = tempdt
        '    dgvcc.DisplayMember = "Prices"
        '    dgvcc.Value = dtRecord.Rows(i).Item("price")
        '    subdiscount = subdiscount + dtRecord.Rows(i).Item("subtotaldiscount")
        'Next
        'dtOtherPayment = clsCashier.getGeneric(11, Me.PaymentID)
        'Me.txtActualDiscount.Text = subdiscount.ToString("N2")
        'Me.txtPayment.Text = Me.TotalPayment.ToString("N2")
    End Sub
    Private Sub SetupDatatable()
        dtOtherPayment.Columns.Add("tender")
        dtOtherPayment.Columns.Add("amount")
        dtOtherPayment.Columns.Add("type")
        dtOtherPayment.Columns.Add("id")
        dtOtherPayment.Columns.Add("checkno")
        dtOtherPayment.Columns.Add("checkdate")
        dtOtherPayment.Columns.Add("bankno")
        dtOtherPayment.Columns.Add("accno")
        dtOtherPayment.Columns.Add("paymentdate")
        Dim colByteArray As DataColumn = New DataColumn("img")
        colByteArray.DataType = System.Type.GetType("System.Byte[]")
        dtOtherPayment.Columns.Add(colByteArray)
        dtOtherPayment.Columns.Add("memo")
    End Sub
    Private Sub SetErrorProvider(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        erp.SetError(ctl, strErrorMessage)
    End Sub
    Private Sub AddNewItem()
        If CustID = 0 Then
            SetErrorProvider(Me.panelcustomer, "This field is required!")
        Else
            Dim fsearch As New frmSearchEngine
            fsearch.searchstatus = frmSearchEngine.searchmodule.searchlots
            fsearch.ShowDialog()
            If fsearch.issave Then
                Dim isexist As Boolean = False
                For j As Integer = 0 To dgvItems.Rows.Count - 1
                    If dgvItems.Rows(j).Cells("lotid").Value = fsearch.mkey Then
                        isexist = True
                        Exit For
                    End If
                Next
                If Not isexist Then
                    Me.dgvItems.Rows.Add(1)
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells("lotid").Value = fsearch.mkey
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells("lotname").Value = fsearch.mvalue
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells("Price").Value = fsearch.mprice
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells("discount").Value = "0.00"
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells("totalprice").Value = fsearch.mprice
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells("loan").Value = "0.00"
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells("netcommissionable").Value = fsearch.mcommissionable
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells("adcom").Value = fsearch.mcomatdown
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells("compercentage").Value = fsearch.mcompercentage
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells("reservationfee").Value = fsearch.mreservationfee
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells("tempreservefee").Value = fsearch.mreservationfee
                End If
            End If
            fsearch.Dispose()
        End If
    End Sub
    Private Sub RemoveItem()
        Try
            If dgvItems.CurrentRow.Index >= 0 Then
                dgvItems.Rows.RemoveAt(dgvItems.CurrentRow.Index)
            End If
            Call GetTotal()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub GetTotal()
        Dim total As Double = 0
        For i As Integer = 0 To dgvItems.Rows.Count - 1
            total = total + CDbl(dgvItems.Rows(i).Cells("reservationfee").Value)
        Next
        Me.txtNet.Text = total.ToString("N2")
    End Sub
    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then 'backspace .
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub frmClose()
        If myCurrentFormStatus <> enFormStatus.view Then
            If CustommsgBox(msgstyle.warning, msgtype.yesno, "Sales and Reservation", "Are you sure you want to close this form?") Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub
    Private Function IsValidOR() As Boolean
        If Trim(Me.txtOrNo.Text.Replace("0", "")) = "" Then
            SetErrorProvider(Me.panelor, "Invalid OR Number!")
            Return False
        Else
            SetErrorProvider(Me.panelor)
            Return True
        End If
    End Function

    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True
        If dgvItems.Rows.Count = 0 Then
            CustommsgBox(msgstyle.warning, msgtype.okonly, "Sales and Reservation", "No lots added! Please add lot.")
            isvalid = False
        Else
            If Not IsValidOR() Then
                isvalid = False
            End If
            If Not Me.AgentID > 0 Then
                isvalid = False
                SetErrorProvider(Me.panelagent, "Agent required!")
            Else
                SetErrorProvider(Me.panelagent)
            End If
            If Me.txtPayment.Text = "0.00" Then
                Call ShowPayment()
            End If
            If CDbl(Me.txtChange.Text) < 0 Then
                isvalid = False
                SetErrorProvider(Me.txtPayment, "Insufficient Payment!")
            Else
                SetErrorProvider(Me.txtPayment)
            End If
            Dim temptotalloan As Double = 0
            For i As Integer = 0 To dgvItems.RowCount - 1
                temptotalloan = CDbl(dgvItems.Rows(i).Cells("loan").Value) + temptotalloan
            Next
            If temptotalloan > 0 And cmbloansource.SelectedValue = 0 Then
                isvalid = False
                SetErrorProvider(Me.panelloansouce, "Loan Source Required!")
            Else
                SetErrorProvider(Me.panelloansouce)
            End If
        End If
        Return isvalid
    End Function
    Private Sub PrepareSave()
        If isallfieldvalid() Then
            If CustommsgBox(msgstyle.info, msgtype.yesno, "Sales and Reservation", "Are you sure you want to save this information?") Then
                Call Save()
            End If
            myCurrentFormStatus = enFormStatus.view
            Call EnableFields()
            Me.issave = True
        End If
    End Sub
    Private Sub LoadAgent()
        With dgvmain
            .DataSource = clsAgents.Fetch(3, Me.AgentID)
            .Columns(0).Visible = False
            .Columns(1).ReadOnly = True
            .Columns(1).Width = 231
            .Columns(2).Visible = False
            .Columns(3).Width = 140
        End With
    End Sub
    Private Sub ShowPayment()
        Dim fPayment As New frmPaymentMean
        fPayment.myCurrentFormStatus = myCurrentFormStatus
        fPayment.NetTotal = CDbl(Me.txtNet.Text)
        fPayment.Cash = Me.Cash
        fPayment.TotalPayment = Me.TotalPayment
        fPayment.Change = CDbl(Me.txtChange.Text)
        fPayment.dtOtherPayment = Me.dtOtherPayment
        fPayment.ShowDialog()
        If fPayment.issave Then
            Me.Cash = fPayment.Cash
            Me.TotalPayment = fPayment.TotalPayment
            Me.Change = fPayment.Change
            Me.dtOtherPayment = fPayment.dtOtherPayment
            Me.txtPayment.Text = Me.TotalPayment.ToString("N2")
        End If
        fPayment.Dispose()
    End Sub
    Private Sub Save()
        Dim isnew As Boolean = IIf(myCurrentFormStatus = enFormStatus.add, True, False)
        check = 0 : banktobank = 0
        For i As Integer = 0 To dtOtherPayment.Rows.Count - 1
            Select Case dtOtherPayment.Rows(i).Item("type")
                Case "check"
                    check = check + dtOtherPayment.Rows(i).Item("amount")
                Case "btb"
                    banktobank = banktobank + dtOtherPayment.Rows(i).Item("amount")
            End Select
        Next
        Dim x As New clsPayment
        x.institutionid = Me.cmbloansource.SelectedValue
        x.invoiceno = Me.InvoiceNo
        x.customerid = Me.CustID
        x.invoicedate = Me.dtpinvoicedate.Value
        x.paymentschedule = Me.dtppaymentsched.Value
        x.interest = CDbl(Me.txtinterest.Text)
        x.paymentterm = Val(Me.txtpaymentterm.Text)
        x.commissionterm = Val(Me.txt_term_commission.Text)
        x.paymentextension = Utility.SystemSetting(Utility.systemsettings.PaymentExtension)
        x.compercentageovertime = CDbl(Me.txtpercentageoverterm.Text)
        x.encodedbyid = Current_UserID
        x.reserveduration = Utility.SystemSetting(Utility.systemsettings.ReservationDuration)
        Me.InvoiceNo = x.SaveInvoice(isnew)
        x.invoiceno = Me.InvoiceNo
        If Me.InvoiceNo > 0 Then
            x.paymentid = Me.PaymentID
            x.paymentdate = Me.dtpinvoicedate.Value
            x.orno = Me.txtOrNo.Text
            x.cashamount = Me.Cash
            x.checkamount = Me.check
            x.btbamount = Me.banktobank
            Me.PaymentID = x.SavePayment(isnew)
            x.paymentid = Me.PaymentID
            If Me.PaymentID > 0 Then
                For i As Integer = 0 To dgvItems.RowCount - 1
                    x.lotid = dgvItems.Rows(i).Cells("lotid").Value
                    x.price = dgvItems.Rows(i).Cells("Price").Value
                    x.discount = dgvItems.Rows(i).Cells("discount").Value
                    x.excess = dgvItems.Rows(i).Cells("totalprice").Value
                    x.loanamount = dgvItems.Rows(i).Cells("loan").Value
                    x.compercentage = dgvItems.Rows(i).Cells("compercentage").Value
                    x.commissionable = dgvItems.Rows(i).Cells("netcommissionable").Value
                    x.chargeamount = dgvItems.Rows(i).Cells("reservationfee").Value
                    x.amortization = (x.excess - x.loanamount - x.chargeamount) / x.paymentterm
                    x.adcom = dgvItems.Rows(i).Cells("adcom").Value
                    x.status = 3
                    x.SaveDetails(True)
                Next
                For i As Integer = 0 To dgvmain.RowCount - 1
                    x.agentid = dgvmain.Rows(i).Cells(0).Value
                    x.compercentage = dgvmain.Rows(i).Cells(3).Value
                    x.isagent = dgvmain.Rows(i).Cells(0).Value = Me.AgentID
                    If myCurrentFormStatus = enFormStatus.edit Then
                        x.DeleteCommission()
                    End If
                    x.SaveCommission()
                Next
                For i As Integer = 0 To dtOtherPayment.Rows.Count - 1
                    x.amount = dtOtherPayment.Rows(i).Item("amount")
                    x.memo = dtOtherPayment.Rows(i).Item("memo")
                    x.bankid = dtOtherPayment.Rows(i).Item("bankno")
                    If dtOtherPayment.Rows(i).Item("type") = "check" Then
                        x.paymentcheckid = dtOtherPayment.Rows(i).Item("id")
                        x.accountno = dtOtherPayment.Rows(i).Item("accno")
                        x.checkno = dtOtherPayment.Rows(i).Item("checkno")
                        x.checkdate = dtOtherPayment.Rows(i).Item("checkdate")
                        x.status = 0
                        x.SavePaymentDetails(x.paymentcheckid = 0, 5)
                    ElseIf dtOtherPayment.Rows(i).Item("type") = "btb" Then
                        x.paymentbtbid = dtOtherPayment.Rows(i).Item("id")
                        x.paymentdate = dtOtherPayment.Rows(i).Item("paymentdate")
                        If Not IsDBNull(dtOtherPayment.Rows(i).Item("img")) Then
                            Dim img As Byte() = dtOtherPayment.Rows(i).Item("img")
                            x.photo = img
                        Else
                            x.photo = Nothing
                        End If
                        x.checkdate = Date.Now
                        x.SavePaymentDetails(x.paymentbtbid = 0, 6)
                    End If
                Next
                clsCommissions.GenerateCommissions(Me.PaymentID)
            End If
        End If


        'x.paidamount = IIf(CDbl(Me.txtPayment.Text) > CDbl(Me.txtNet.Text), CDbl(Me.txtNet.Text), CDbl(Me.txtPayment.Text))
        'x.chargeamount = x.excess
        'x.chargebalance = x.chargeamount - x.paidamount
        'x.discount = IIf(Me.totaldiscount > 0, True, False)
        'x.SavePaymentDetails(isnew, 4)
    End Sub
#End Region

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        Call AddNewItem()
    End Sub

    Private Sub btnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveItem.Click
        Call RemoveItem()
    End Sub


    Private Sub dgvItems_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvItems.CurrentCellDirtyStateChanged
        If (dgvItems.IsCurrentCellDirty) Then
            dgvItems.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvItems_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItems.CellValueChanged
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = coldiscount Then
                Try
                    If dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString <> "" Then
                        dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDbl(dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString)
                    End If
                    Me.dgvItems.Rows(e.RowIndex).Cells("totalprice").Value = CDbl(CDbl(dgvItems.Rows(e.RowIndex).Cells("Price").Value) - CDbl(dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)).ToString("N2")
                Catch ex As Exception
                    dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Val(dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString)
                End Try
            ElseIf e.ColumnIndex = colloan Or e.ColumnIndex = colcommissionable Or e.ColumnIndex = colcompercentage Or e.ColumnIndex = coladcom Then
                Try
                    If dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> Nothing Then
                        If dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString <> "" Then
                            dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDbl(dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString)
                        End If
                    End If

                Catch ex As Exception
                    dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Val(dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString)
                End Try
            ElseIf e.ColumnIndex = colreservefee Then
                Try
                    dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDbl(dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString)
                Catch ex As Exception
                    dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Val(dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString)
                End Try
                Call GetTotal()
            End If
        End If
    End Sub

    Private Sub txtNet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNet.TextChanged
        Try
            Me.txtChange.Text = (CDbl(Me.txtPayment.Text) - CDbl(Me.txtNet.Text)).ToString("N2")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtPayment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPayment.TextChanged
        Try
            Me.txtChange.Text = (CDbl(Me.txtPayment.Text) - CDbl(Me.txtNet.Text)).ToString("N2")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pctrPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrPayment.Click
        Call ShowPayment()
    End Sub

    Private Sub dgvItems_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvItems.EditingControlShowing
        Try
            If dgvItems.CurrentCellAddress.X = coldiscount Or dgvItems.CurrentCellAddress.X >= colloan Then
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvItems_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvItems.DataError
        If TypeOf (e.Exception) Is ConstraintException Then
            Dim view As DataGridView = DirectCast(sender, DataGridView)
            view.Rows(e.RowIndex).ErrorText = "an error"
            view.Rows(e.RowIndex).Cells(e.ColumnIndex).ErrorText = "an error"
            e.ThrowException = False
        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub pctrSearchCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrSearchCustomer.Click
        Dim f As New frmSearchEngine
        f.searchstatus = frmSearchEngine.searchmodule.searchcustomer
        f.ShowDialog()
        If f.issave Then
            Me.CustID = f.mkey
            Me.txtCustomer.Text = f.mvalue
            SetErrorProvider(panelcustomer)
        End If
        f.Dispose()
    End Sub

    Private Sub pctrSearchAgent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrSearchAgent.Click
        Dim f As New frmSearchEngine
        f.searchstatus = frmSearchEngine.searchmodule.searchagent
        f.ShowDialog()
        If f.issave Then
            Me.AgentID = f.mkey
            Me.txtAgent.Text = f.mvalue
            Call LoadAgent()
        End If
        f.Dispose()
    End Sub

    Private Sub dgvmain_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvmain.EditingControlShowing
        Try
            If dgvmain.CurrentCellAddress.X = 3 Then
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvmain_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvmain.DataError, dgvItems.DataError
        If Not TypeOf (e.Exception) Is ConstraintException Then
            CustommsgBox(msgstyle.critical, msgtype.okonly, "Sales and Reservation", "Input is not valid")
        End If
    End Sub

    Private Sub btnpositive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpositive.Click
        Call PrepareSave()
    End Sub

    Private Sub txtinterest_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpercentageoverterm.KeyPress, txtinterest.KeyPress

    End Sub

    Private Sub txtpaymentterm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpaymentterm.KeyPress, txt_term_commission.KeyPress
        If Asc(e.KeyChar) <> 8 Then 'backspace
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtpaymentterm_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpaymentterm.Leave
        If Me.txtpaymentterm.Text = "" Then
            Me.txtpaymentterm.Text = Utility.SystemSetting(Utility.systemsettings.PaymentTerm)
        End If
    End Sub

    Private Sub txt_term_commission_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_term_commission.Leave
        If Me.txt_term_commission.Text = "" Then
            Me.txt_term_commission.Text = Utility.SystemSetting(Utility.systemsettings.CommissionTerm)
        End If
    End Sub

    Private Sub txtinterest_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinterest.Leave
        If Me.txtinterest.Text = "" Then
            Me.txtinterest.Text = Utility.SystemSetting(Utility.systemsettings.Interest)
        End If
    End Sub

    Private Sub txtpercentageoverterm_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpercentageoverterm.Leave
        If Me.txtpercentageoverterm.Text = "" Then
            Me.txtpercentageoverterm.Text = Utility.SystemSetting(Utility.systemsettings.CommissionOverTerm)
        End If
    End Sub

    Private Sub txtOrNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOrNo.KeyPress
        If Asc(e.KeyChar) <> 8 Then 'backspace
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmbloansource_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbloansource.SelectedValueChanged
        Try
            If Me.cmbloansource.SelectedValue > 0 Then
                Me.dgvItems.Columns("loan").Visible = True
            Else
                Me.dgvItems.Columns("loan").Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class