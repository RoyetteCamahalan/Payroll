Public Class frmCheck

    Private Sub frmCheck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadBanks()
        Call EnableFields()
        If myCurrentFormStatus <> enFormStatus.add Then
            Call LoadRecord()
        End If
    End Sub
#Region "Variable"
    Public myCurrentFormStatus As enFormStatus
    Dim erp As New ErrorProvider
    Public issave As Boolean = False
    Public paymentcheckid, paymentid, bankno As Long
    Public accno, checkno, replacedcheckno, memo As String
    Public checkamount As Double
    Public checkdate, replacedcheckdate As Date
    Enum enFormStatus
        add = 0
        edit = 1
        view = 2
    End Enum
#End Region
#Region "Methods"
    Private Sub EnableFields()
        If myCurrentFormStatus = enFormStatus.view Then
            Me.txtCheckNo.Enabled = False
            Me.dtpCheckDate.Enabled = False
            Me.cmbBanks.Enabled = False
            Me.btnAddBank.Enabled = False
            Me.txtAccountNo.Enabled = False
            Me.txtAmount.Enabled = False
            Me.txtMemo.Enabled = False
            Me.btnOK.Enabled = False
        ElseIf myCurrentFormStatus = enFormStatus.add Or myCurrentFormStatus = enFormStatus.edit Then
            Me.txtCheckNo.Enabled = True
            Me.dtpCheckDate.Enabled = True
            Me.cmbBanks.Enabled = True
            Me.btnAddBank.Enabled = True
            Me.txtAccountNo.Enabled = True
            Me.txtAmount.Enabled = True
            Me.txtMemo.Enabled = True
            Me.btnOK.Enabled = True
        End If
    End Sub
    Private Sub LoadRecord()
        Me.txtCheckNo.Text = Me.checkno
        Me.dtpCheckDate.Value = checkdate
        Me.cmbBanks.SelectedValue = Me.bankno
        Me.txtAccountNo.Text = Me.accno
        Me.txtAmount.Text = CDbl(Me.checkamount).ToString("N2")
        Me.txtMemo.Text = Me.memo
    End Sub
    Private Sub LoadBanks()
        With cmbBanks
            .DataSource = clsPayment.Fetch(1, "")
            .DisplayMember = "NAME"
            .ValueMember = "BANKID"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub ShowBankEntry()
        Dim fBank As New frmBankLibrary
        fBank.myformstatus = frmBankLibrary.formstatus.add
        fBank.ShowDialog()
        If fBank.isSave Then
            LoadBanks()
            cmbBanks.SelectedValue = fBank.bankid
        End If
        fBank.Dispose()
    End Sub
    Private Sub SetErrorProvider(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        erp.SetError(ctl, strErrorMessage)
    End Sub
    Private Function isfieldvalid(ByRef ctr As Control) As Boolean
        If ctr.Text = "" Then
            SetErrorProvider(ctr, "This field is required!")
            Return False
        Else
            SetErrorProvider(ctr)
            Return True
        End If
    End Function
    Private Function isAllFieldValid() As Boolean
        Dim isvalid As Boolean = True
        Try
            If isfieldvalid(Me.txtCheckNo) And isfieldvalid(Me.txtAccountNo) And isfieldvalid(Me.txtAmount) Then
                If cmbBanks.SelectedValue <= 0 Then
                    SetErrorProvider(btnAddBank, "This field is required!")
                    isvalid = False
                Else
                    SetErrorProvider(btnAddBank)
                End If
                If CDbl(Me.txtAmount.Text) <= 0 Then
                    SetErrorProvider(Me.txtAmount, "Invalid Amount")
                    isvalid = False
                Else
                    SetErrorProvider(Me.txtAmount)
                End If
            Else
                isvalid = False
            End If
        Catch ex As Exception
            isvalid = False
        End Try

        Return isvalid
    End Function
    Private Sub Save()
        If myCurrentFormStatus <> enFormStatus.view Then
            If isAllFieldValid() Then
                Me.issave = True
                Me.checkno = Me.txtCheckNo.Text
                Me.checkdate = Me.dtpCheckDate.Value
                Me.bankno = Me.cmbBanks.SelectedValue
                Me.accno = Me.txtAccountNo.Text
                Me.checkamount = CDbl(Me.txtAmount.Text)
                Me.memo = Me.txtMemo.Text
                Me.Close()
            End If
        End If

    End Sub
#End Region
    Private Sub btnAddBank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBank.Click
        Call ShowBankEntry()
    End Sub

    Private Sub frmCheck_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyData = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyData = Keys.Enter Then
            Call Save()
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Call Save()
    End Sub

    Private Sub txtAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If IsNumeric(sender.Text + e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class