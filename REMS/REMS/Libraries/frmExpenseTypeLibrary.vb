Public Class frmExpenseTypeLibrary

    Private Sub frmExpenseTypeLibrary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call PaintForm()
        Call EnableFields()
        If myformstatus <> formstatus.add Then
            Call LoadRecord()
        End If
    End Sub

#Region "Variables"
    Dim erp As New ErrorProvider
    Public issave As Boolean
    Public expensetypeid As Integer
    Public expensetypename As String
    Public myformstatus As formstatus
    Enum formstatus
        add = 0
        edit = 1
        view = 2
    End Enum
#End Region

#Region "Methods"
    Private Sub LoadRecord()
        Me.txtexpensetype.Text = expensetypename
    End Sub
    Public Sub EnableFields()
        If Me.myformstatus = formstatus.view Then
            Me.txtexpensetype.Enabled = False
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
            Me.lblTitle.Text = "Edit Expense Type"
        Else
            Me.BackColor = viewcolor
            Me.btnpositive.BackColor = viewcolor
            Me.lblTitle.Text = "View Expense Type"
        End If
    End Sub
    Private Sub seterror(ByRef ctr As Control, Optional ByRef msg As String = "")
        erp.SetError(ctr, msg)
    End Sub
    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True
        If Trim(Me.txtexpensetype.Text) = "" Then
            isvalid = False
            seterror(panelexpensetype, "This field is required!")
        Else
            seterror(panelexpensetype)
            If Me.expensetypename <> Me.txtexpensetype.Text Then
                If clsExpenses.Fetch(4, Me.txtexpensetype.Text).Rows.Count > 0 Then
                    isvalid = False
                    seterror(panelexpensetype, "Expense Type already exist")
                Else
                    seterror(panelexpensetype)
                End If
            End If

        End If
        Return isvalid
    End Function
    Private Sub Save()
        If isallfieldvalid() Then
            If CustommsgBox(msgstyle.info, msgtype.yesno, "Expense Type", "Are you sure you want to save this information?") Then
                Dim x As New clsExpenses
                x.expensetypeid = Me.expensetypeid
                x.expensetypedesc = Me.txtexpensetype.Text
                If Me.myformstatus = formstatus.add Then
                    Me.expensetypeid = x.SaveExpenseType(True)
                Else
                    Me.expensetypeid = x.SaveExpenseType(False)
                End If
                If expensetypeid > 0 Then
                    Me.expensetypename = Me.txtexpensetype.Text
                    Me.issave = True
                    If Me.myformstatus = formstatus.add Then
                        Call SaveLogs(applicationmodule.modExpenses, "Expense Type", "Added New Expense Type :" & Me.expensetypename)
                    Else
                        Call SaveLogs(applicationmodule.modExpenses, "Expense Type", "Updated Expense Type :" & Me.expensetypename)
                    End If
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