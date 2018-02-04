Public Class frmCheckRegister
    Private Cash, TotalPayment, Change, banktobank, check As Double
    Private paymentid, checkid As Long
    Public dtOtherPayment As New DataTable

    Private Sub frmCheckRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbPeriod.SelectedIndex = 0
        Me.cmbStatus.SelectedIndex = 0
    End Sub

#Region "Methods"
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
    Private Sub DisplayChecks()
        Me.dgvChecks.DataSource = clsPayment.getChecks(Me.txtSearch.Text, Me.dtpinitialdate.Value, Me.dtpendingdate.Value, Me.cmbStatus.SelectedIndex)
        With dgvChecks
            .Columns(0).Visible = False
            .Columns("ischecked").HeaderText = ""
            .Columns("ischecked").Width = 40
            .Columns("ischecked").ReadOnly = False
            .Columns("checkdate").HeaderText = "Check Date"
            .Columns("checkdate").Width = 97
            .Columns("checkdate").ReadOnly = True
            .Columns("checkno").HeaderText = "Check #"
            .Columns("checkno").Width = 150
            .Columns("checkno").ReadOnly = True
            .Columns("bankname").HeaderText = "Bank"
            .Columns("bankname").Width = 150
            .Columns("bankname").ReadOnly = True
            .Columns("customer").HeaderText = "Patient"
            .Columns("customer").Width = 200
            .Columns("customer").ReadOnly = True
            .Columns("Status").HeaderText = "Status"
            .Columns("Status").Width = 100
            .Columns("Status").ReadOnly = True
            .Columns("orno").HeaderText = "O.R #"
            .Columns("orno").Width = 100
            .Columns("orno").ReadOnly = True
            .Columns("amount").HeaderText = "Amount"
            .Columns("amount").Width = 160
            .Columns("amount").ReadOnly = True
            .Columns("amount").DefaultCellStyle.Format = "N2"
            .Columns("amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .Columns("dateposted").Visible = False
            .Columns("replacedcheckno").Visible = False
            .Columns("replacedcheckdate").Visible = False
            .Columns("accountnumber").Visible = False
            .Columns("paymentid").Visible = False
            .Columns("memo").Visible = False
            .Columns("BANKID").Visible = False

        End With
        If dgvChecks.RowCount = 0 Then
            Me.pctrViewDeposit.Visible = False
            Me.pctrviewpayment.Visible = False
            Me.lbldepositno.Text = ""
            Me.lbldepositdate.Text = ""
            Me.lblaccountno.Text = ""
            Me.lblbank.Text = ""
            Me.lblOrno.Text = ""
            Me.lblOrdate.Text = ""
            Me.lblreplacementno.Text = ""
            Me.lblreplacementdate.Text = ""
            Me.btnDeposit.Enabled = False
            Me.btnHold.Enabled = False
            Me.btnReplace.Enabled = False
        End If
        Me.lblcheckcount.Text = Me.dgvChecks.RowCount.ToString
    End Sub
    Private Sub DepositChecks()
        If CustommsgBox(msgstyle.info, msgtype.yesno, "Lot", "Are you sure you want to deposit this information?") Then
            'Dim x As New clsCashier
            'x.status = 2 'deposit
            'For i As Integer = 0 To dgvChecks.RowCount - 1
            '    If dgvChecks.Rows(i).Cells(1).Value = True Then
            '        x.paymentcheckid = dgvChecks.Rows(i).Cells(0).Value
            '        If x.SavePaymentDetails(False, 9) > 0 Then
            '            dgvChecks.Rows(i).Cells("Status").Value = "Deposited"
            '        End If
            '    End If
            'Next
            Me.btnDeposit.Enabled = False
            Me.btnReplace.Enabled = False
            Me.btnHold.Enabled = False
        End If
    End Sub
    Private Function ShowPayment() As Boolean
        Dim issave As Boolean
        Dim fPayment As New frmPaymentMean
        fPayment.myCurrentFormStatus = frmPaymentMean.enFormStatus.add
        fPayment.NetTotal = Me.TotalPayment
        fPayment.Cash = Me.Cash
        fPayment.TotalPayment = Me.TotalPayment
        fPayment.dtOtherPayment = Me.dtOtherPayment
        fPayment.ShowDialog()
        issave = fPayment.issave
        If issave Then
            Me.Cash = fPayment.Cash
            Me.TotalPayment = fPayment.TotalPayment
            Me.dtOtherPayment = fPayment.dtOtherPayment
        End If
        fPayment.Dispose()
        Return issave
    End Function
    'Private Sub ReplaceCheck()
    '    For i As Integer = 0 To dgvChecks.RowCount - 1
    '        If dgvChecks.Rows(i).Cells(1).Value = True Then
    '            Me.TotalPayment = CDbl(Me.dgvChecks.Rows(i).Cells("amount").Value)
    '            Me.paymentid = Me.dgvChecks.Rows(i).Cells("paymentid").Value
    '            Me.checkid = Me.dgvChecks.Rows(i).Cells("CHECKID").Value
    '            If (ShowPayment()) Then
    '                check = 0 : banktobank = 0
    '                For i As Integer = 0 To dtOtherPayment.Rows.Count - 1
    '                    Select Case dtOtherPayment.Rows(i).Item("type")
    '                        Case "check"
    '                            check = check + dtOtherPayment.Rows(i).Item("amount")
    '                        Case "btb"
    '                            banktobank = banktobank + dtOtherPayment.Rows(i).Item("amount")
    '                    End Select
    '                Next
    '                Dim x As New clsPayment
    '                x.paymentid = Me.paymentid
    '                x.paymentdate = Utility.GetServerDate
    '                x.orno = Me.txtOrNo.Text
    '                x.cashamount = Me.Cash
    '                x.checkamount = Me.check
    '                x.btbamount = Me.banktobank
    '                x.encodedbyid = Current_UserID
    '                Me.paymentid = x.SavePayment(isnew)
    '                x.paymentid = Me.paymentid
    '                If Me.paymentid > 0 Then
    '                    For i As Integer = 0 To dgvItems.RowCount - 1
    '                        x.paymentdetailid = dgvItems.Rows(i).Cells("paymentdetailid").Value
    '                        x.chargeid = dgvItems.Rows(i).Cells("chargeid").Value
    '                        x.balance = CDbl(dgvItems.Rows(i).Cells("balance").Value)
    '                        x.amount = dgvItems.Rows(i).Cells("tender").Value
    '                        x.SavePaymentDetail(isnew, 8)
    '                    Next
    '                    For i As Integer = 0 To dtOtherPayment.Rows.Count - 1
    '                        x.amount = dtOtherPayment.Rows(i).Item("amount")
    '                        x.memo = dtOtherPayment.Rows(i).Item("memo")
    '                        x.bankid = dtOtherPayment.Rows(i).Item("bankno")
    '                        If dtOtherPayment.Rows(i).Item("type") = "check" Then
    '                            x.paymentcheckid = dtOtherPayment.Rows(i).Item("id")
    '                            x.accountno = dtOtherPayment.Rows(i).Item("accno")
    '                            x.checkno = dtOtherPayment.Rows(i).Item("checkno")
    '                            x.checkdate = dtOtherPayment.Rows(i).Item("checkdate")
    '                            x.status = 0
    '                            x.SavePaymentDetails(x.paymentcheckid = 0, 5)
    '                        ElseIf dtOtherPayment.Rows(i).Item("type") = "btb" Then
    '                            x.paymentbtbid = dtOtherPayment.Rows(i).Item("id")
    '                            x.paymentdate = dtOtherPayment.Rows(i).Item("paymentdate")
    '                            If Not IsDBNull(dtOtherPayment.Rows(i).Item("img")) Then
    '                                Dim img As Byte() = dtOtherPayment.Rows(i).Item("img")
    '                                x.photo = img
    '                            Else
    '                                x.photo = Nothing
    '                            End If
    '                            x.checkdate = Date.Now
    '                            x.SavePaymentDetails(x.paymentbtbid = 0, 6)
    '                        End If
    '                    Next
    '                    Call clsCommissions.GenerateCommissions(Me.paymentid)
    '                    Me.Close()
    '                End If
    '            End If
    '        End If
    '    Next
    'End Sub
    Private Sub HoldChecks()
        If CustommsgBox(msgstyle.info, msgtype.yesno, "Checks", "Are you sure you want to " & Me.btnHold.Text & " this check?") Then
            Dim x As New clsPayment
            x.status = IIf(Me.btnHold.Text = "Unhold", 0, 3)
            For i As Integer = 0 To dgvChecks.RowCount - 1
                If dgvChecks.Rows(i).Cells(1).Value = True Then
                    x.paymentcheckid = dgvChecks.Rows(i).Cells(0).Value
                    If x.SavePaymentDetails(False, 9) > 0 Then
                        dgvChecks.Rows(i).Cells("Status").Value = IIf(Me.btnHold.Text = "Unhold", "Floating", "Hold")
                        Call SaveLogs(applicationmodule.modCheckRegister, "Checks ", IIf(Me.btnHold.Text = "Unhold", "Hold", "Unhold") & " check from " & dgvChecks.Rows(i).Cells("patient").Value & " with check #" & dgvChecks.Rows(i).Cells("checkno").Value)
                    End If
                End If
            Next
            Me.btnDeposit.Enabled = False
            Me.btnReplace.Enabled = False
            Me.btnHold.Text = IIf(Me.btnHold.Text = "Unhold", "Hold", "Unhold")
        End If
    End Sub
#End Region
    Private Sub cmbPeriod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPeriod.SelectedIndexChanged
        LoadDateRange(cmbPeriod.SelectedIndex)
    End Sub

    Private Sub tsClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub dtpendingdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpinitialdate.ValueChanged, dtpendingdate.ValueChanged, DateTimePicker2.ValueChanged, DateTimePicker1.ValueChanged
        Call DisplayChecks()
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStatus.SelectedIndexChanged
        Call DisplayChecks()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged, TextBox1.TextChanged
        Call DisplayChecks()
    End Sub
    Private Sub dgvChecks_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvChecks.CurrentCellDirtyStateChanged
        If (dgvChecks.IsCurrentCellDirty) Then
            dgvChecks.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Private Sub dgvChecks_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvChecks.CellValueChanged
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 1 Then
                Dim selectedcount As Integer = 0
                Dim isdeposit, isreplace, ishold, isunhold As Boolean
                isdeposit = True : isreplace = True : ishold = True : isunhold = True
                For i As Integer = 0 To dgvChecks.RowCount - 1
                    If dgvChecks.Rows(i).Cells(1).Value = True Then
                        selectedcount += 1
                        If dgvChecks.Rows(i).Cells("Status").Value = "Replaced" Then
                            isreplace = False
                            isunhold = False
                        ElseIf dgvChecks.Rows(i).Cells("Status").Value = "Deposited" Then
                            isdeposit = False
                            isreplace = False
                            ishold = False
                            isunhold = False
                        ElseIf dgvChecks.Rows(i).Cells("Status").Value = "Hold" Then
                            isdeposit = False
                            ishold = False
                        ElseIf dgvChecks.Rows(i).Cells("Status").Value = "Cancelled" Then
                            isdeposit = False
                            ishold = False
                            isunhold = False
                        ElseIf dgvChecks.Rows(i).Cells("Status").Value = "Floating" Then
                            isunhold = False
                        ElseIf dgvChecks.Rows(i).Cells("Status").Value = "Endorced" Then
                            isunhold = False
                        End If
                    End If
                Next
                Me.btnDeposit.Enabled = isdeposit
                Me.btnHold.Enabled = ishold
                Me.btnReplace.Enabled = isreplace
                If isunhold And selectedcount > 0 Then
                    Me.btnHold.Text = "Unhold"
                    Me.btnHold.Enabled = True
                Else
                    Me.btnHold.Text = "Hold"
                End If
                If selectedcount > 1 Then
                    Me.btnReplace.Enabled = False
                    Me.lblselectedcount.Text = selectedcount & " items selected"
                ElseIf selectedcount > 0 Then
                    Me.lblselectedcount.Text = selectedcount & " item selected"
                Else
                    Me.lblselectedcount.Text = "No item selected"
                    Me.btnDeposit.Enabled = False
                    Me.btnHold.Enabled = False
                    Me.btnReplace.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub dgvChecks_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvChecks.SelectionChanged
        If dgvChecks.CurrentRow.Index >= 0 Then
            Me.pctrViewDeposit.Visible = True
            Me.pctrviewpayment.Visible = True
            With dgvChecks.CurrentRow
                Me.lbldepositno.Text = .Cells("checkno").Value
                Me.lbldepositdate.Text = .Cells("checkdate").Value
                Me.lblaccountno.Text = Utility.NullToEmptyString(.Cells("accountnumber").Value)
                Me.lblbank.Text = .Cells("bankname").Value
                Me.lblOrno.Text = .Cells("orno").Value
                Me.lblOrdate.Text = .Cells("dateposted").Value
                If .Cells("Status").Value = "Replaced" Then
                    Me.lblreplacementno.Text = .Cells("replacedchecknumber").Value
                    Me.lblreplacementdate.Text = .Cells("replacedcheckdate").Value
                Else
                    Me.lblreplacementno.Text = ""
                    Me.lblreplacementdate.Text = ""
                End If
            End With
        End If
    End Sub

    Private Sub pctrviewpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrviewpayment.Click
        If dgvChecks.CurrentRow.Index >= 0 Then
            Dim fCashier As New frmInvoiceLibrary
            fCashier.myCurrentFormStatus = frmInvoiceLibrary.enFormStatus.view
            'fCashier.ChargeID = dgvChecks.CurrentRow.Cells("chargeid").Value
            fCashier.ShowDialog()
            fCashier.Dispose()
        End If
    End Sub

    Private Sub pctrViewDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrViewDeposit.Click
        If dgvChecks.CurrentRow.Index >= 0 Then
            Dim fcheck As New frmCheck
            fcheck.myCurrentFormStatus = frmCheck.enFormStatus.view
            fcheck.checkno = dgvChecks.CurrentRow.Cells("checkno").Value
            fcheck.checkdate = dgvChecks.CurrentRow.Cells("checkdate").Value
            fcheck.bankno = dgvChecks.CurrentRow.Cells("bankid").Value
            fcheck.accno = dgvChecks.CurrentRow.Cells("accountnumber").Value
            fcheck.checkamount = dgvChecks.CurrentRow.Cells("amount").Value
            fcheck.memo = dgvChecks.CurrentRow.Cells("memo").Value.ToString
            fcheck.ShowDialog()
            fcheck.Dispose()
        End If
    End Sub

    Private Sub frmCheckRegister_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyData = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub tsDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call DepositChecks()
    End Sub

    Private Sub tsHold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call HoldChecks()
    End Sub

    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        Call DepositChecks()
    End Sub

    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        'Call ReplaceCheck()
    End Sub
End Class