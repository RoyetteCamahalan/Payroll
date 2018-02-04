Public Class frmEditInvoice

    Private Sub frmEditInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgvItems.RowTemplate.Height = Default_Row_Height
        Me.dgvmain.RowTemplate.Height = Default_Row_Height
        Call LoadLoanSource()
        Call LoadRecord()
        Call InitFields()
        Call setTags()
    End Sub
#Region "Variables"
    Public myCurrentFormStatus As enFormStatus
    Public mInvoiceno, mLoanSource As Long
    Public issave As Boolean = False

    Private mInterest, mComovertime As Double
    Private mPaymentTerm, mCommissionTerm As Integer
    Private mPaymentSchedule, mInvoiceDate As Date
    Private mCustID, mPaymentID, mAgentID As Long
    Dim erp As New ErrorProvider

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
    Private Sub setTags()
        Me.btnEditPaymentSche.Tag = "0"
        Me.btnEditInterest.Tag = "0"
    End Sub
    Private Sub InitFields()
        If myCurrentFormStatus = enFormStatus.view Then
            Me.btnAddItem.Visible = False
            Me.btnVoidItem.Visible = False
            Me.dgvItems.ReadOnly = True
        ElseIf myCurrentFormStatus = enFormStatus.edit Then
            Me.btnAddItem.Visible = False
            Me.btnVoidItem.Visible = False
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
        Dim dtInvoice As DataTable = clsPayment.Fetch(17, "", mInvoiceno)

        Me.mInterest = dtInvoice.Rows(0).Item("interest")
        Me.mCustID = dtInvoice.Rows(0).Item("CUSTID")
        Me.mPaymentTerm = dtInvoice.Rows(0).Item("paymentterm")
        Me.mLoanSource = dtInvoice.Rows(0).Item("loansource")
        Me.mPaymentSchedule = dtInvoice.Rows(0).Item("paymentschedule")
        Me.mInvoiceDate = dtInvoice.Rows(0).Item("INVOICEDATE")
        Me.mCommissionTerm = dtInvoice.Rows(0).Item("commissionterm")
        Me.mComovertime = dtInvoice.Rows(0).Item("compercentageovertime")
        Me.mAgentID = dtInvoice.Rows(0).Item("AGENTID")

        Me.txtCustomer.Text = dtInvoice.Rows(0).Item("customer")
        Me.txtAgent.Text = dtInvoice.Rows(0).Item("agent")
        Me.txtinterest.Text = mInterest
        Me.txtpaymentterm.Text = mPaymentTerm
        Me.cmbloansource.SelectedValue = mLoanSource
        Me.dtppaymentsched.Value = mPaymentSchedule
        Me.dtpinvoicedate.Value = mInvoiceDate
        Me.txt_term_commission.Text = mCommissionTerm
        Me.txtpercentageoverterm.Text = mComovertime

    End Sub
    Private Sub SetErrorProvider(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        erp.SetError(ctl, strErrorMessage)
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

    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True
        If dgvItems.Rows.Count = 0 Then
            CustommsgBox(msgstyle.warning, msgtype.okonly, "Sales and Reservation", "No lots added! Please add lot.")
            isvalid = False
        Else

            If Not Me.mAgentID > 0 Then
                isvalid = False
                SetErrorProvider(Me.panelagent, "Agent required!")
            Else
                SetErrorProvider(Me.panelagent)
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

    Private Sub LoadAgent()
        With dgvmain
            .DataSource = clsAgents.Fetch(3, Me.mAgentID)
            .Columns(0).Visible = False
            .Columns(1).ReadOnly = True
            .Columns(1).Width = 231
            .Columns(2).Visible = False
            .Columns(3).Width = 140
        End With
    End Sub

#End Region

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
            End If
        End If
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

    Private Sub pctrSearchAgent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmSearchEngine
        f.searchstatus = frmSearchEngine.searchmodule.searchagent
        f.ShowDialog()
        If f.issave Then
            Me.mAgentID = f.mkey
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

    Private Sub btnpositive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Call PrepareSave()
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

    Private Sub txtOrNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub btnEditCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditCustomer.Click
        Dim f As New frmSearchEngine
        f.searchstatus = frmSearchEngine.searchmodule.searchcustomer
        f.ShowDialog()
        If f.issave Then
            If mCustID <> f.mkey Then
                If CustommsgBox(msgstyle.critical, msgtype.yesno, "Edit Invoice", "Are you sure you want to change customer?") Then
                    Call SaveLogs(applicationmodule.modSales, "Change Customer", "Changed Customer from " & txtCustomer.Text & " to " & f.mvalue)
                    Me.mCustID = f.mkey
                    Me.txtCustomer.Text = f.mvalue
                    Call clsPayment.EditInvoice(3, "customerid", mCustID, mInvoiceno)
                    Me.issave = True
                End If
            End If
        End If
        f.Dispose()
    End Sub

    Private Sub btnEditAgent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditAgent.Click

    End Sub

    Private Sub btnEditPaymentSche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPaymentSche.Click
        If btnEditPaymentSche.Tag = "0" Then
            Me.btnEditPaymentSche.Image = My.Resources.ic_save16
            Me.dtppaymentsched.Enabled = True
            btnEditPaymentSche.Tag = "1"
        Else
            'Update Payment Schedule
            If (Me.dtppaymentsched.Value.Date <> Me.mPaymentSchedule) Then
                If CustommsgBox(msgstyle.critical, msgtype.yesno, "Edit Invoice", "Are you sure you want to change payment schedule?") Then
                    Call clsPayment.EditInvoice(4, "paymentschedule", dtppaymentsched.Value, mInvoiceno)
                    Me.mPaymentSchedule = dtppaymentsched.Value.Date
                End If
            End If
            Me.btnEditPaymentSche.Image = My.Resources.ic_edit
            Me.dtppaymentsched.Enabled = False
            btnEditPaymentSche.Tag = "0"
        End If
    End Sub

    Private Sub btnEditInterest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditInterest.Click
        If btnEditInterest.Tag = "0" Then
            Me.btnEditInterest.Image = My.Resources.ic_save16
            Me.txtinterest.Enabled = True
            btnEditInterest.Tag = "1"
        Else
            'Update Interest
            If (CDbl(Me.txtinterest.Text) <> Me.mInterest) Then
                If CustommsgBox(msgstyle.critical, msgtype.yesno, "Edit Invoice", "Are you sure you want to change interest? Note: Changing interest won't affect previous interest.") Then
                    Call clsPayment.EditInvoice(5, "interest", CDbl(Me.txtinterest.Text), mInvoiceno)
                    Me.mInterest = CDbl(Me.txtinterest.Text)
                End If
            End If
            Me.btnEditInterest.Image = My.Resources.ic_edit
            Me.txtinterest.Enabled = False
            btnEditInterest.Tag = "0"
        End If
    End Sub
End Class