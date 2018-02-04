Public Class frmCommissionLibrary

    Private Sub frmCommissionLibrary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgvItems.RowTemplate.Height = Default_Row_Height
        Dim d As Date = Utility.GetServerDate().ToShortDateString
        Me.dtpbirthdate.MaxDate = d
        If myCurrentFormStatus = enFormStatus.add Then
            Me.dtpbirthdate.Value = d
            Me.dtpbirthdate.Enabled = False
            Me.txtVoucherNo.Text = clsCommissions.fetch(1, "").Rows(0).Item(0)
        Else
            Call LoadRecord()
        End If
        Call EnableFields()
    End Sub
#Region "Variables"
    Public myCurrentFormStatus As enFormStatus
    Public issave As Boolean = False
    Private AgentID, VoucherNo As Long
    Dim erp As New ErrorProvider
    Private colAmount As Integer = 6
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
            pctrAgent.Visible = False
        ElseIf myCurrentFormStatus = enFormStatus.edit Then
            Me.btnAddItem.Visible = False
            Me.btnRemoveItem.Visible = False
        End If
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
    Private Sub SetErrorProvider(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        erp.SetError(ctl, strErrorMessage)
    End Sub
    Private Sub AddNewItem()
        If AgentID = 0 Then
            SetErrorProvider(Me.panelagent, "This field is required!")
        Else
            Dim fsearch As New frmSearchEngine
            fsearch.mkey = Me.AgentID
            fsearch.searchstatus = frmSearchEngine.searchmodule.searchcommissionpayable
            fsearch.ShowDialog()
            If fsearch.issave Then
                Dim isexist As Boolean = False
                For j As Integer = 0 To dgvItems.Rows.Count - 1
                    If dgvItems.Rows(j).Cells("chargeid").Value = fsearch.mkey Then
                        isexist = True
                        Exit For
                    End If
                Next
                If Not isexist Then
                    Me.dgvItems.Rows.Add(1)
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells("compaymentid").Value = "0"
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells("customer").Value = fsearch.mvalue
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells("lotname").Value = fsearch.mvalue1
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells("chargedate").Value = fsearch.mchargedate.ToString
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells("formonth").Value = fsearch.mformonth
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells("amount").Value = fsearch.mamount
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells("cashout").Value = fsearch.mamount
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells("chargeid").Value = fsearch.mkey
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
            total = total + CDbl(dgvItems.Rows(i).Cells("cashout").Value)
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
            If CustommsgBox(msgstyle.warning, msgtype.yesno, "Commission", "Are you sure you want to close this form?") Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True
        If dgvItems.Rows.Count = 0 Then
            CustommsgBox(msgstyle.warning, msgtype.okonly, "Commission", "No payables! Please add.")
            isvalid = False
        End If
        For i As Integer = 0 To dgvItems.RowCount - 1
            If Not dgvItems.Rows(i).Cells("cashout").Value > 0 Then
                CustommsgBox(msgstyle.critical, msgtype.okonly, "Commission", "Invalid cashout for " & dgvItems.Rows(i).Cells("lotname").Value.ToString)
                isvalid = False
                Exit For
            End If
        Next
        Return isvalid
    End Function
    Private Sub PrepareSave()
        If isallfieldvalid() Then
            If CustommsgBox(msgstyle.info, msgtype.yesno, "Commission", "Are you sure you want to save this information?") Then
                Call Save()
            End If
            Me.issave = True
            Me.Close()
        End If
    End Sub
    Private Sub Save()
        Dim isnew As Boolean = IIf(myCurrentFormStatus = enFormStatus.add, True, False)
        Dim x As New clsCommissions
        x.voucherno = Me.VoucherNo
        x.agentid = Me.AgentID
        x.voucherdate = dtpbirthdate.Value
        x.encodedby = Current_UserID
        x.taxpercentage = CDbl(Me.txttaxpercentage.Text)
        Me.VoucherNo = x.SaveVoucher(isnew, 0)
        x.voucherno = Me.VoucherNo
        If Me.VoucherNo > 0 Then
            For i As Integer = 0 To dgvItems.RowCount - 1
                x.compaymentid = dgvItems.Rows(i).Cells("compaymentid").Value
                x.chargeid = dgvItems.Rows(i).Cells("chargeid").Value
                x.amount = dgvItems.Rows(i).Cells("cashout").Value
                x.SaveVoucher(isnew, 1)
            Next
        End If
        If isnew Then
            Call clsCommissions.PrintVoucher(Me.VoucherNo)
        End If
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
            If e.ColumnIndex = colAmount Then
                Try
                    dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDbl(dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString)
                Catch ex As Exception
                    dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Val(dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString)
                End Try
                If CDbl(dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) > CDbl(dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value) Then
                    dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDbl(dgvItems.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                End If
                Call GetTotal()
            End If
        End If
    End Sub



    Private Sub dgvItems_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvItems.EditingControlShowing
        Try
            If dgvItems.CurrentCellAddress.X = colAmount Then
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

    Private Sub pctrSearchCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrAgent.Click
        Dim f As New frmSearchEngine
        f.searchstatus = frmSearchEngine.searchmodule.searchagent
        f.ShowDialog()
        If f.issave Then
            Me.AgentID = f.mkey
            Me.txtAgent.Text = f.mvalue
            SetErrorProvider(Me.panelagent)
        End If
        f.Dispose()
    End Sub

    Private Sub btnpositive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpositive.Click
        Call PrepareSave()
    End Sub

End Class