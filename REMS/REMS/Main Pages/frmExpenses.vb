Public Class frmExpenses
    Private Sub frmExpenses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myactivepage = activepage.pageexpenses
        Me.dgvmain.RowTemplate.Height = Default_Row_Height
        Me.cmbPeriod.SelectedIndex = 0
        Call InitializePage()
    End Sub
#Region "Variables"
    Private myactivepage As activepage
    Enum activepage
        pageexpenses = 0
        pageexpensetypes = 1
        pagevendors = 2
        pageaccounts = 3
    End Enum
#End Region

#Region "Methods"
    Private Sub InitializePage()
        Me.txtSearch.Text = ""
        If myactivepage = activepage.pageexpenses Then
            panelexpenses.Visible = True
            panelaccounts.Visible = False
            panelexpensetype.Visible = False
            panelvendors.Visible = False
            panelperiod.Visible = True
        ElseIf myactivepage = activepage.pageexpensetypes Then
            panelexpenses.Visible = False
            panelaccounts.Visible = False
            panelexpensetype.Visible = True
            panelvendors.Visible = False
            panelperiod.Visible = False
        ElseIf myactivepage = activepage.pagevendors Then
            panelexpenses.Visible = False
            panelaccounts.Visible = False
            panelexpensetype.Visible = False
            panelvendors.Visible = True
            panelperiod.Visible = False
        Else
            panelexpenses.Visible = False
            panelaccounts.Visible = True
            panelexpensetype.Visible = False
            panelvendors.Visible = False
            panelperiod.Visible = False
        End If
        Call DisplayList()
    End Sub
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
    Private Sub DisplayList()
        If myactivepage = activepage.pageexpenses Then
            If Trim(Me.txtSearch.Text) = "" Then
                Me.lblshowing.Text = "Showing top 100 results"
            Else
                Me.lblshowing.Text = "Showing top 100 results for '" & Me.txtSearch.Text & "'"
            End If
            With dgvmain
                .DataSource = Nothing
                .DataSource = clsExpenses.FetchDateRange(7, Me.txtSearch.Text, Me.dtpinitialdate.Value, Me.dtpendingdate.Value)
                .Columns(0).HeaderText = "Trans #"
                .Columns(0).Width = 108
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).HeaderText = "Trans Date"
                .Columns(1).Width = 100
                .Columns(2).HeaderText = "Actual Date"
                .Columns(2).Width = 120
                .Columns(3).HeaderText = "Reference #"
                .Columns(3).Width = 110
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).HeaderText = "Account Name"
                .Columns(4).Width = 220
                .Columns(5).HeaderText = "Expense Type"
                .Columns(5).Width = 120
                .Columns(6).HeaderText = "Amount"
                .Columns(6).Width = 110
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(7).HeaderText = "Memo"
                .Columns(7).Width = 110

            End With
        ElseIf myactivepage = activepage.pageexpensetypes Then
            If Trim(Me.txtSearch.Text) = "" Then
                Me.lblshowing.Text = "Showing all results"
            Else
                Me.lblshowing.Text = "Showing results for '" & Me.txtSearch.Text & "'"
            End If
            With dgvmain
                .DataSource = Nothing
                .DataSource = clsExpenses.Fetch(1, Me.txtSearch.Text)
                .Columns(0).HeaderText = "Expense Type #"
                .Columns(0).Width = 208
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).HeaderText = "Expense Name"
                .Columns(1).Width = 790
            End With
        ElseIf myactivepage = activepage.pagevendors Then
            If Trim(Me.txtSearch.Text) = "" Then
                Me.lblshowing.Text = "Showing all results"
            Else
                Me.lblshowing.Text = "Showing results for '" & Me.txtSearch.Text & "'"
            End If
            With dgvmain
                .DataSource = Nothing
                .DataSource = clsExpenses.Fetch(0, Me.txtSearch.Text)
                .Columns(0).HeaderText = "Vendor #"
                .Columns(0).Width = 120
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).HeaderText = "Vendor Name"
                .Columns(1).Width = 400
                .Columns(2).HeaderText = "Address"
                .Columns(2).Width = 328
                .Columns(3).HeaderText = "Contact #"
                .Columns(3).Width = 150
            End With
        Else
            If Trim(Me.txtSearch.Text) = "" Then
                Me.lblshowing.Text = "Showing all results"
            Else
                Me.lblshowing.Text = "Showing results for '" & Me.txtSearch.Text & "'"
            End If
            With dgvmain
                .DataSource = Nothing
                .DataSource = clsExpenses.Fetch(2, Me.txtSearch.Text)
                .Columns(0).HeaderText = "Account #"
                .Columns(0).Width = 150
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).HeaderText = "Account Name"
                .Columns(1).Width = 385
                .Columns(2).HeaderText = "Memo"
                .Columns(2).Width = 343
                .Columns(3).HeaderText = "Is Active"
                .Columns(3).Width = 120
            End With
        End If

    End Sub
#End Region

    Private Sub txtSearch_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyData = Keys.Enter Then
            DisplayList()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Call DisplayList()
    End Sub

    Private Sub txtSearch_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.Leave
        If Trim(Me.txtSearch.Text) = "" Then
            DisplayList()
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If Me.myactivepage = activepage.pageexpenses Then
            Dim f As New frmExpenseLibrary
            f.myformstatus = frmExpenseLibrary.formstatus.add
            f.ShowDialog()
            If f.issave Then
                Call DisplayList()
            End If
        ElseIf Me.myactivepage = activepage.pageexpensetypes Then
            Dim f As New frmExpenseTypeLibrary
            f.myformstatus = frmExpenseTypeLibrary.formstatus.add
            f.ShowDialog()
            If f.issave Then
                Call DisplayList()
            End If
        ElseIf Me.myactivepage = activepage.pagevendors Then
            Dim f As New frmVendorLibrary
            f.myformstatus = frmVendorLibrary.formstatus.add
            f.ShowDialog()
            If f.issave Then
                Call DisplayList()
            End If
            f.Dispose()
        Else
            Dim f As New frmAccountLibrary
            f.myformstatus = frmAccountLibrary.formstatus.add
            f.ShowDialog()
            If f.issave Then
                Call DisplayList()
            End If
            f.Dispose()
        End If

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If dgvmain.CurrentRow.Index >= 0 Then
                If Me.myactivepage = activepage.pageexpenses Then
                    Dim f As New frmExpenseLibrary
                    f.expenseid = Me.dgvmain.CurrentRow.Cells("expenseid").Value
                    f.myformstatus = frmExpenseLibrary.formstatus.edit
                    f.ShowDialog()
                    If f.issave Then
                        Call DisplayList()
                    End If
                ElseIf Me.myactivepage = activepage.pageexpensetypes Then
                    Dim f As New frmExpenseTypeLibrary
                    f.expensetypeid = Me.dgvmain.CurrentRow.Cells("expensetypeid").Value
                    f.expensetypename = Me.dgvmain.CurrentRow.Cells("expensetypedesc").Value
                    f.myformstatus = frmBankLibrary.formstatus.edit
                    f.ShowDialog()
                    If f.issave Then
                        Call DisplayList()
                    End If
                ElseIf Me.myactivepage = activepage.pagevendors Then
                    Dim f As New frmVendorLibrary
                    f.vendorid = Me.dgvmain.CurrentRow.Cells("vendorid").Value
                    f.myformstatus = frmVendorLibrary.formstatus.edit
                    f.ShowDialog()
                    If f.issave Then
                        Call DisplayList()
                    End If
                    f.Dispose()
                Else
                    Dim f As New frmAccountLibrary
                    f.accountid = Me.dgvmain.CurrentRow.Cells("accountid").Value
                    f.myformstatus = frmAccountLibrary.formstatus.edit
                    f.ShowDialog()
                    If f.issave Then
                        Call DisplayList()
                    End If
                    f.Dispose()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try
            If dgvmain.CurrentRow.Index >= 0 Then
                If Me.myactivepage = activepage.pageexpenses Then
                    Dim f As New frmExpenseLibrary
                    f.expenseid = Me.dgvmain.CurrentRow.Cells("expenseid").Value
                    f.myformstatus = frmExpenseLibrary.formstatus.view
                    f.ShowDialog()
                ElseIf Me.myactivepage = activepage.pageexpensetypes Then
                    Dim f As New frmExpenseTypeLibrary
                    f.expensetypeid = Me.dgvmain.CurrentRow.Cells("expensetypeid").Value
                    f.expensetypename = Me.dgvmain.CurrentRow.Cells("expensetypedesc").Value
                    f.myformstatus = frmBankLibrary.formstatus.view
                    f.ShowDialog()
                ElseIf Me.myactivepage = activepage.pagevendors Then
                    Dim f As New frmVendorLibrary
                    f.vendorid = Me.dgvmain.CurrentRow.Cells("vendorid").Value
                    f.myformstatus = frmVendorLibrary.formstatus.view
                    f.ShowDialog()
                    f.Dispose()
                Else
                    Dim f As New frmAccountLibrary
                    f.accountid = Me.dgvmain.CurrentRow.Cells("accountid").Value
                    f.myformstatus = frmAccountLibrary.formstatus.view
                    f.ShowDialog()
                    f.Dispose()
                End If
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnMenuLots_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpenses.MouseEnter
        If myactivepage <> activepage.pageexpenses Then
            Me.btnExpenses.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btnMenuLots_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpenses.MouseLeave
        Me.btnExpenses.ForeColor = System.Drawing.SystemColors.WindowFrame
    End Sub

    Private Sub btnMenuProperties_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpensesTypes.MouseEnter
        If myactivepage <> activepage.pageexpensetypes Then
            Me.btnExpensesTypes.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btnMenuProperties_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpensesTypes.MouseLeave
        Me.btnExpensesTypes.ForeColor = System.Drawing.SystemColors.WindowFrame
    End Sub
    Private Sub btnAccounts_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccounts.MouseEnter
        If myactivepage <> activepage.pageaccounts Then
            Me.btnAccounts.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btnAccounts_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccounts.MouseLeave
        Me.btnAccounts.ForeColor = System.Drawing.SystemColors.WindowFrame
    End Sub

    Private Sub btnMenuLots_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpenses.Click
        If myactivepage <> activepage.pageexpenses Then
            myactivepage = activepage.pageexpenses
            Call InitializePage()
        End If
    End Sub

    Private Sub btnMenuProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpensesTypes.Click
        If myactivepage <> activepage.pageexpensetypes Then
            myactivepage = activepage.pageexpensetypes
            Call InitializePage()
        End If
    End Sub

    Private Sub btntype_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVendors.MouseEnter
        If myactivepage <> activepage.pagevendors Then
            Me.btnVendors.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btntype_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVendors.MouseLeave
        Me.btnVendors.ForeColor = System.Drawing.SystemColors.WindowFrame
    End Sub

    Private Sub btntype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVendors.Click
        If myactivepage <> activepage.pagevendors Then
            myactivepage = activepage.pagevendors
            Call InitializePage()
        End If
    End Sub

    
    Private Sub btnAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccounts.Click
        If myactivepage <> activepage.pageaccounts Then
            myactivepage = activepage.pageaccounts
            Call InitializePage()
        End If
    End Sub

    Private Sub cmbPeriod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPeriod.SelectedIndexChanged
        LoadDateRange(cmbPeriod.SelectedIndex)
    End Sub

    Private Sub dtpinitialdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpinitialdate.ValueChanged, dtpendingdate.ValueChanged
        Call DisplayList()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If myactivepage = activepage.pageexpenses Then
            clsExpenses.PrintExpense(Me.dtpinitialdate.Value, Me.dtpendingdate.Value)
        End If
    End Sub
End Class