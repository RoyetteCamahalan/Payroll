Public Class frmAccountLibrary

    Private Sub frmAccountLibrary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call PaintForm()
        Call EnableFields()
        If myformstatus <> formstatus.add Then
            Call LoadRecord()
        End If
    End Sub

#Region "Variables"
    Dim erp As New ErrorProvider
    Public issave As Boolean
    Public accountid As Integer
    Public accountname As String
    Public myformstatus As formstatus
    Enum formstatus
        add = 0
        edit = 1
        view = 2
    End Enum
#End Region

#Region "Methods"
    Private Sub LoadRecord()
        Dim dtRecord As DataTable = clsExpenses.Fetch(3, Me.accountid)
        Me.txtaccountname.Text = dtRecord.Rows(0).Item("accountname")
        Me.txtmemo.Text = dtRecord.Rows(0).Item("memo")
        Me.chkisactive.Checked = dtRecord.Rows(0).Item("isactive")
    End Sub
    Public Sub EnableFields()
        If Me.myformstatus = formstatus.view Then
            Me.txtaccountname.Enabled = False
            Me.txtmemo.Enabled = False
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
            Me.lblTitle.Text = "Edit Expense Account"
        Else
            Me.BackColor = viewcolor
            Me.btnpositive.BackColor = viewcolor
            Me.lblTitle.Text = "View Expense Account"
        End If
    End Sub
    Private Sub seterror(ByRef ctr As Control, Optional ByRef msg As String = "")
        erp.SetError(ctr, msg)
    End Sub
    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True
        If Trim(Me.txtaccountname.Text) = "" Then
            isvalid = False
            seterror(panelaccountname, "This field is required!")
        Else
            seterror(panelaccountname)
        End If

        Return isvalid
    End Function
    Private Sub Save()
        If isallfieldvalid() Then
            If CustommsgBox(msgstyle.info, msgtype.yesno, "Expense Account", "Are you sure you want to save this information?") Then
                Dim x As New clsExpenses
                x.accountid = Me.accountid
                x.accountname = Me.txtaccountname.Text
                x.memo = Me.txtmemo.Text
                x.isactive = Me.chkisactive.Checked
                If Me.myformstatus = formstatus.add Then
                    Me.accountid = x.SaveExpenseAccount(True)
                Else
                    Me.accountid = x.SaveExpenseAccount(False)
                End If
                If accountid > 0 Then
                    If Me.myformstatus = formstatus.add Then
                        Call SaveLogs(applicationmodule.modExpenses, "Accounts", "Added New Account : " & Me.txtaccountname.Text)
                    Else
                        Call SaveLogs(applicationmodule.modExpenses, "Accounts", "Updated Account : " & Me.txtaccountname.Text)
                    End If
                    If Me.myformstatus = formstatus.add Then
                        Call SaveLogs(applicationmodule.modExpenses, "Accounts", "Added New Account : " & Me.txtmemo.Text)
                    Else
                        Call SaveLogs(applicationmodule.modExpenses, "Accounts", "Updated Account : " & Me.txtmemo.Text)
                    End If
                    Me.myformstatus = formstatus.view
                    Me.accountname = Me.txtaccountname.Text
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