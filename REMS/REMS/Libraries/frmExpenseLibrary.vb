Public Class frmExpenseLibrary

    Private Sub frmExpenseLibrary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call PaintForm()
        Call EnableFields()
        If myformstatus <> formstatus.add Then
            Call LoadRecord()
        End If
    End Sub

#Region "Variables"
    Dim erp As New ErrorProvider
    Public issave As Boolean
    Public expenseid As Integer
    Private expensetype, accountid As Long
    Public myformstatus As formstatus
    Enum formstatus
        add = 0
        edit = 1
        view = 2
    End Enum
#End Region

#Region "Methods"
    Private Sub LoadRecord()
        Dim dtRecord As DataTable = clsExpenses.Fetch(8, Me.expenseid)
        Me.accountid = dtRecord.Rows(0).Item("accountid")
        Me.expensetype = dtRecord.Rows(0).Item("expensetypeid")
        Me.txtaccoutname.Text = dtRecord.Rows(0).Item("accountname")
        Me.txtexpensetype.Text = dtRecord.Rows(0).Item("expensetypedesc")
        Me.txtrefno.Text = dtRecord.Rows(0).Item("refno")
        Me.dtprefdate.Value = dtRecord.Rows(0).Item("refdate")
        Me.txtAmount.Text = dtRecord.Rows(0).Item("amount")
        Me.txtmemo.Text = dtRecord.Rows(0).Item("memo")

       
    End Sub
    Public Sub EnableFields()
        If Me.myformstatus = formstatus.view Then
            Me.pctrSearchAccount.Enabled = False
            Me.pctrExpensetype.Enabled = False
            Me.txtaccoutname.Enabled = False
            Me.txtexpensetype.Enabled = False
            Me.txtrefno.Enabled = False
            Me.dtprefdate.Enabled = False
            Me.txtAmount.Enabled = False
            Me.txtmemo.Enabled = True
            Me.btnpositive.Visible = False
        End If
    End Sub
    Private Sub PaintForm()
        Me.dtprefdate.MaxDate = Utility.GetServerDate
        If Me.myformstatus = formstatus.add Then
            Me.BackColor = newcolor
            Me.btnpositive.BackColor = newcolor
        ElseIf myformstatus = formstatus.edit Then
            Me.BackColor = editcolor
            Me.btnpositive.BackColor = editcolor
            Me.lblTitle.Text = "Edit Expense"
        Else
            Me.BackColor = viewcolor
            Me.btnpositive.BackColor = viewcolor
            Me.lblTitle.Text = "View Expense"
        End If
    End Sub
    Private Sub seterror(ByRef ctr As Control, Optional ByRef msg As String = "")
        erp.SetError(ctr, msg)
    End Sub
    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True
        If Not Me.accountid > 0 Then
            isvalid = False
            seterror(panelaccount, "This field is required!")
        Else
            seterror(panelaccount)
        End If
        If Not Me.expensetype > 0 Then
            isvalid = False
            seterror(panelexpensetype, "This field is required!")
        Else
            seterror(panelexpensetype)
        End If
        If Trim(Me.txtrefno.Text) = "" Then
            isvalid = False
            seterror(panelrefno, "This field is required!")
        Else
            seterror(panelrefno)
        End If

        If Trim(Me.txtAmount.Text) = "" Or Val(Me.txtAmount.Text) <= 0 Then
            isvalid = False
            seterror(panelamount, "This field is required!")
        Else
            seterror(panelamount)
        End If
        Return isvalid
    End Function
    Private Sub Save()
        If isallfieldvalid() Then
            If CustommsgBox(msgstyle.info, msgtype.yesno, "Expense", "Are you sure you want to save this information?") Then
                Dim x As New clsExpenses
                x.expenseid = Me.expenseid
                x.accountid = Me.accountid
                x.expensetypeid = Me.expensetype
                x.refno = Me.txtrefno.Text
                x.refdate = Me.dtprefdate.Value
                x.amount = CDbl(Me.txtAmount.Text)
                x.memo = Me.txtmemo.Text
                If Me.myformstatus = formstatus.add Then
                    Me.expenseid = x.SaveExpense(True)
                Else
                    Me.expenseid = x.SaveExpense(False)
                End If
                If expenseid > 0 Then

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

    Private Sub txtAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If IsNumeric(sender.Text + e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub pctrSearchAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrSearchAccount.Click
        Dim f As New frmSearchEngine
        f.searchstatus = frmSearchEngine.searchmodule.searchexpenseaccount
        f.ShowDialog()
        If f.issave Then
            Me.accountid = f.mkey
            Me.txtaccoutname.Text = f.mvalue
        End If
    End Sub

    Private Sub pctrExpensetype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrExpensetype.Click
        Dim f As New frmSearchEngine
        f.searchstatus = frmSearchEngine.searchmodule.searchexpensetype
        f.ShowDialog()
        If f.issave Then
            Me.expensetype = f.mkey
            Me.txtexpensetype.Text = f.mvalue
        End If
    End Sub
End Class