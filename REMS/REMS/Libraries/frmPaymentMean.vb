Public Class frmPaymentMean
    Private Sub frmPaymentMean_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call EnableFields()
        LoadRecord()
    End Sub
#Region "Variables"
    Public issave As Boolean
    Public NetTotal, Cash, TotalPayment, Change As Double
    Public dtOtherPayment As New DataTable
    Public myCurrentFormStatus As enFormStatus
    Enum enFormStatus
        add = 0
        edit = 1
        view = 2
    End Enum
#End Region
#Region "Methods"
    Private Sub EnableFields()
        If myCurrentFormStatus = enFormStatus.view Then
            Me.btnEdit.Text = "View" & Environment.NewLine & Environment.NewLine & "F2"
            Me.btnCancel.Text = "Close" & Environment.NewLine & Environment.NewLine & "ESC"
            Me.txtCash.Enabled = False
            Me.btnCheck.Enabled = False
            Me.btnBTB.Enabled = False
            Me.btnPay.Enabled = False
        Else
            Me.btnEdit.Text = "Edit" & Environment.NewLine & Environment.NewLine & "F2"
            Me.btnCancel.Text = "Cancel" & Environment.NewLine & Environment.NewLine & "ESC"
            Me.txtCash.Enabled = True
            Me.btnCheck.Enabled = True
            Me.btnBTB.Enabled = True
            Me.btnPay.Enabled = True
        End If
    End Sub
    Private Sub LoadRecord()
        Me.txtDue.Text = NetTotal.ToString("N2")
        Me.txtCash.Text = Cash.ToString("N2")
        Me.txtTotalPayment.Text = TotalPayment.ToString("N2")
        Me.txtChange.Text = Change.ToString("N2")
        For idx As Integer = 0 To dtOtherPayment.Rows.Count - 1
            With dgvmeans
                .Rows.Add(1)
                .Rows(idx).Cells("tender").Value = dtOtherPayment.Rows(idx).Item("tender")
                .Rows(idx).Cells("amount").Value = dtOtherPayment.Rows(idx).Item("amount")
                .Rows(idx).Cells("type").Value = dtOtherPayment.Rows(idx).Item("type")
                .Rows(idx).Cells("id").Value = dtOtherPayment.Rows(idx).Item("id")
                .Rows(idx).Cells("checkno").Value = dtOtherPayment.Rows(idx).Item("checkno")
                .Rows(idx).Cells("checkdate").Value = dtOtherPayment.Rows(idx).Item("checkdate")
                .Rows(idx).Cells("bankno").Value = dtOtherPayment.Rows(idx).Item("bankno")
                .Rows(idx).Cells("accno").Value = dtOtherPayment.Rows(idx).Item("accno")
                .Rows(idx).Cells("paymentdate").Value = dtOtherPayment.Rows(idx).Item("paymentdate")
                .Rows(idx).Cells("img").Value = dtOtherPayment.Rows(idx).Item("img")
                .Rows(idx).Cells("memo").Value = dtOtherPayment.Rows(idx).Item("memo")
            End With
        Next
    End Sub
    Private Sub ComputeTotal()
        Try
            Dim cashtemp As Double
            If Trim(Me.txtCash.Text) = "" Then
                cashtemp = 0
            Else
                cashtemp = CDbl(Me.txtCash.Text)
            End If
            Dim total As Double = cashtemp
            For i As Integer = 0 To dgvmeans.Rows.Count - 1
                total += CDbl(dgvmeans.Rows(i).Cells("amount").Value)
            Next
            Me.txtTotalPayment.Text = total.ToString("N2")
            Me.txtChange.Text = (CDbl(Me.txtTotalPayment.Text) - CDbl(Me.txtDue.Text)).ToString("N2")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ShowNewCheckEntry()
        If myCurrentFormStatus <> enFormStatus.view Then
            Dim fcheck As New frmCheck
            fcheck.myCurrentFormStatus = frmCheck.enFormStatus.add
            fcheck.ShowDialog()
            If fcheck.issave Then
                dgvmeans.Rows.Add(1)
                Dim idx As Integer = dgvmeans.Rows.Count - 1
                With dgvmeans
                    .Rows(idx).Cells("tender").Value = "Check # " & fcheck.checkno
                    .Rows(idx).Cells("amount").Value = fcheck.checkamount.ToString("N2")
                    .Rows(idx).Cells("type").Value = "check"
                    .Rows(idx).Cells("id").Value = "0"
                    .Rows(idx).Cells("checkno").Value = fcheck.checkno
                    .Rows(idx).Cells("checkdate").Value = fcheck.checkdate
                    .Rows(idx).Cells("bankno").Value = fcheck.bankno
                    .Rows(idx).Cells("accno").Value = fcheck.accno
                    .Rows(idx).Cells("memo").Value = fcheck.memo
                End With
                Call ComputeTotal()
            End If
            fcheck.Dispose()
        End If

    End Sub
    Private Sub ShowEditEntry()
        Try
            If dgvmeans.CurrentRow.Index >= 0 Then
                Dim idx As Integer = dgvmeans.CurrentRow.Index
                If dgvmeans.Rows(idx).Cells("type").Value = "check" Then
                    Dim fcheck As New frmCheck
                    fcheck.myCurrentFormStatus = myCurrentFormStatus
                    fcheck.checkno = dgvmeans.Rows(idx).Cells("checkno").Value
                    fcheck.checkdate = dgvmeans.Rows(idx).Cells("checkdate").Value
                    fcheck.bankno = dgvmeans.Rows(idx).Cells("bankno").Value
                    fcheck.accno = dgvmeans.Rows(idx).Cells("accno").Value
                    fcheck.checkamount = dgvmeans.Rows(idx).Cells("amount").Value
                    fcheck.memo = dgvmeans.Rows(idx).Cells("memo").Value.ToString
                    fcheck.ShowDialog()
                    If fcheck.issave Then
                        With dgvmeans
                            .Rows(idx).Cells("tender").Value = "Check # " & fcheck.checkno
                            .Rows(idx).Cells("amount").Value = fcheck.checkamount.ToString("N2")
                            .Rows(idx).Cells("checkno").Value = fcheck.checkno
                            .Rows(idx).Cells("checkdate").Value = fcheck.checkdate
                            .Rows(idx).Cells("bankno").Value = fcheck.bankno
                            .Rows(idx).Cells("accno").Value = fcheck.accno
                            .Rows(idx).Cells("memo").Value = fcheck.memo
                        End With
                    End If
                ElseIf dgvmeans.Rows(idx).Cells("type").Value = "btb" Then
                    Dim fbtb As New frmBTB
                    If myCurrentFormStatus = enFormStatus.add Then
                        fbtb.myCurrentFormStatus = frmBTB.enFormStatus.edit
                    Else
                        fbtb.myCurrentFormStatus = myCurrentFormStatus
                    End If
                    fbtb.bankaccountid = dgvmeans.Rows(idx).Cells("bankno").Value
                    fbtb.paymentdate = dgvmeans.Rows(idx).Cells("paymentdate").Value
                    fbtb.img = dgvmeans.Rows(idx).Cells("img").Value
                    fbtb.amount = dgvmeans.Rows(idx).Cells("amount").Value
                    fbtb.memo = dgvmeans.Rows(idx).Cells("memo").Value.ToString
                    fbtb.ShowDialog()
                    If fbtb.issave Then
                        With dgvmeans
                            .Rows(idx).Cells("tender").Value = "Bank to Bank"
                            .Rows(idx).Cells("amount").Value = fbtb.amount.ToString("N2")
                            .Rows(idx).Cells("bankno").Value = fbtb.bankaccountid
                            .Rows(idx).Cells("paymentdate").Value = fbtb.paymentdate
                            .Rows(idx).Cells("img").Value = fbtb.img
                            .Rows(idx).Cells("memo").Value = fbtb.memo
                        End With
                    End If
                End If
                Call ComputeTotal()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub ShowBTBEntry()
        If myCurrentFormStatus <> enFormStatus.view Then
            Dim fbtb As New frmBTB
            fbtb.myCurrentFormStatus = frmBTB.enFormStatus.add
            fbtb.ShowDialog()
            If fbtb.issave Then
                dgvmeans.Rows.Add(1)
                Dim idx As Integer = dgvmeans.Rows.Count - 1
                With dgvmeans
                    .Rows(idx).Cells("tender").Value = "Bank to Bank"
                    .Rows(idx).Cells("amount").Value = fbtb.amount.ToString("N2")
                    .Rows(idx).Cells("type").Value = "btb"
                    .Rows(idx).Cells("id").Value = "0"
                    .Rows(idx).Cells("bankno").Value = fbtb.bankaccountid
                    .Rows(idx).Cells("paymentdate").Value = fbtb.paymentdate
                    .Rows(idx).Cells("img").Value = fbtb.img
                    .Rows(idx).Cells("memo").Value = fbtb.memo
                End With
                Call ComputeTotal()
            End If
        End If

    End Sub
#End Region
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.issave = False
        Me.Close()
    End Sub

    Private Sub frmPaymentMean_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyData
            Case Keys.Escape
                Me.issave = False
                Me.Close()
            Case Keys.Enter
                Me.issave = True
                Me.Close()
            Case Keys.F5
                Call ShowBTBEntry()
            Case Keys.F3
                Call ShowNewCheckEntry()
            Case Keys.F2
                Call ShowEditEntry()
        End Select
    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        Me.issave = True
        Me.Close()
    End Sub

    Private Sub frmPaymentMean_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.issave Then
            Cash = CDbl(Me.txtCash.Text)
            TotalPayment = CDbl(Me.txtTotalPayment.Text)
            Change = CDbl(Me.txtChange.Text)
            dtOtherPayment.Rows.Clear()
            For idx As Integer = 0 To dgvmeans.Rows.Count - 1
                With dgvmeans
                    dtOtherPayment.Rows.Add(.Rows(idx).Cells("tender").Value,
                                        .Rows(idx).Cells("amount").Value,
                                        .Rows(idx).Cells("type").Value,
                                        .Rows(idx).Cells("id").Value,
                                        .Rows(idx).Cells("checkno").Value,
                                        .Rows(idx).Cells("checkdate").Value,
                                        .Rows(idx).Cells("bankno").Value,
                                        .Rows(idx).Cells("accno").Value,
                                        .Rows(idx).Cells("paymentdate").Value,
                                        .Rows(idx).Cells("img").Value,
                                        .Rows(idx).Cells("memo").Value)
                End With
            Next
        End If
    End Sub

    Private Sub txtCash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCash.TextChanged
        Call ComputeTotal()
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Call ShowNewCheckEntry()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Call ShowEditEntry()
    End Sub

    Private Sub txtCash_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCash.Leave
        If Trim(Me.txtCash.Text) = "" Then
            Me.txtCash.Text = "0.00"
        End If
    End Sub

    Private Sub txtCash_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCash.KeyPress
        If IsNumeric(sender.Text + e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnDebit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBTB.Click
        Call ShowBTBEntry()
    End Sub
End Class