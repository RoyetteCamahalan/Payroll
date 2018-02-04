Public Class frmBankAccountLibrary

    Private Sub frmCustomerLibrary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call PaintForm()
        Call EnableFields()
        Call LoadBanks()
        If myformstatus <> formstatus.add Then
            Call LoadRecord()
        End If
    End Sub

#Region "Variables"
    Dim erp As New ErrorProvider
    Public issave As Boolean
    Public accountid As Integer
    Public myformstatus As formstatus
    Enum formstatus
        add = 0
        edit = 1
        view = 2
    End Enum
#End Region

#Region "Methods"
    Private Sub LoadRecord()
        Dim dtRecord As DataTable = clsPayment.Fetch(4, Me.accountid)
        Me.txtaccountname.Text = dtRecord.Rows(0).Item("accountname")
        Me.txtaccoutno.Text = dtRecord.Rows(0).Item("accountno")
        Me.txtpreffered.Text = dtRecord.Rows(0).Item("bankpreferredbranch")
        Me.cmbBank.SelectedValue = dtRecord.Rows(0).Item("bankid")
        Me.chkisactive.Checked = dtRecord.Rows(0).Item("isactive")
    End Sub
    Private Sub LoadBanks()
        With cmbBank
            .DataSource = clsPayment.Fetch(1, "")
            .DisplayMember = "NAME"
            .ValueMember = "BANKID"
            .SelectedIndex = -1
        End With
    End Sub
    Public Sub EnableFields()
        If Me.myformstatus = formstatus.view Then
            Me.txtaccoutno.Enabled = False
            Me.txtaccountname.Enabled = False
            Me.txtpreffered.Enabled = False
            Me.chkisactive.Enabled = False
            Me.btnpositive.Visible = False
        End If
    End Sub
    Private Sub PaintForm()
        If Me.myformstatus = formstatus.add Then
            Me.BackColor = newcolor
            Me.btnpositive.BackColor = newcolor
        ElseIf myformstatus = formstatus.edit Then
            Me.BackColor = editcolor
            Me.btnpositive.BackColor = editcolor
            Me.lblTitle.Text = "Edit Bank Account"
        Else
            Me.BackColor = viewcolor
            Me.btnpositive.BackColor = viewcolor
            Me.lblTitle.Text = "View Bank Account"
        End If
    End Sub
    Private Sub seterror(ByRef ctr As Control, Optional ByRef msg As String = "")
        erp.SetError(ctr, msg)
    End Sub
    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True
        If cmbBank.SelectedValue <= 0 Then
            isvalid = False
            seterror(panelbank, "This field is required!")
        Else
            seterror(panelbank)
        End If
        If Trim(Me.txtaccoutno.Text) = "" Then
            isvalid = False
            seterror(panelaccoutno, "This field is required!")
        Else
            seterror(panelaccoutno)
        End If

        Return isvalid
    End Function
    Private Sub Save()
        If isallfieldvalid() Then
            If CustommsgBox(msgstyle.info, msgtype.yesno, "Bank Account", "Are you sure you want to save this information?") Then
                Dim x As New clsPayment
                x.accountid = Me.accountid
                x.accountname = Me.txtaccountname.Text
                x.accountno = Me.txtaccoutno.Text
                x.prefferedbranch = Me.txtpreffered.Text
                x.bankid = Me.cmbBank.SelectedValue
                x.isactive = Me.chkisactive.Checked
                If Me.myformstatus = formstatus.add Then
                    Me.accountid = x.SaveBankandAccount(True, 1)
                Else
                    Me.accountid = x.SaveBankandAccount(False, 1)
                End If
                If accountid > 0 Then
                    Me.myformstatus = formstatus.view
                    Me.issave = True
                    Me.Dispose()
                End If
            End If
        End If
    End Sub
#End Region

    Private Sub btnpositive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpositive.Click
        Call Save()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class