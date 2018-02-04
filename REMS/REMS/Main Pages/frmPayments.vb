Public Class frmPayments
    Private Sub frmPayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myactivepage = activepage.pagepayment
        Me.cmbPeriod.SelectedIndex = 0
        Me.dgvmain.RowTemplate.Height = Default_Row_Height
        Call InitializePage()
    End Sub
#Region "Variables"
    Private myactivepage As activepage
    Enum activepage
        pagepayment = 0
        pagebanks = 1
        pageaccounts = 2
        pageloans = 3
    End Enum
#End Region

#Region "Methods"
    Private Sub InitializePage()
        Me.txtSearch.Text = ""
        If myactivepage = activepage.pagepayment Then
            panelpayments.Visible = True
            panelbanks.Visible = False
            panelaccounts.Visible = False
            panelLoans.Visible = False
            lblperiod.Visible = True
            Me.panelperiod.Visible = True
            lblcustomdate.Visible = True
            Me.panelfrom.Visible = True
            lblto.Visible = True
            Me.panelto.Visible = True

            Me.btnNew.Location = New Point(674, 12)
            Me.btnEdit.Location = New Point(777, 12)
            Me.btnView.Location = New Point(880, 12)
            Me.btnPrint.Visible = True
        ElseIf myactivepage = activepage.pagebanks Then
            panelpayments.Visible = False
            panelbanks.Visible = True
            panelaccounts.Visible = False
            panelLoans.Visible = False
            lblperiod.Visible = False
            Me.panelperiod.Visible = False
            lblcustomdate.Visible = False
            Me.panelfrom.Visible = False
            lblto.Visible = False
            Me.panelto.Visible = False

            Me.btnNew.Location = New Point(777, 12)
            Me.btnEdit.Location = New Point(880, 12)
            Me.btnView.Location = New Point(983, 12)
            Me.btnPrint.Visible = False
        ElseIf myactivepage = activepage.pageaccounts Then
            panelpayments.Visible = False
            panelbanks.Visible = False
            panelaccounts.Visible = True
            panelLoans.Visible = False
            lblperiod.Visible = False
            Me.panelperiod.Visible = False
            lblcustomdate.Visible = False
            Me.panelfrom.Visible = False
            lblto.Visible = False
            Me.panelto.Visible = False

            Me.btnNew.Location = New Point(777, 12)
            Me.btnEdit.Location = New Point(880, 12)
            Me.btnView.Location = New Point(983, 12)
            Me.btnPrint.Visible = False
        Else
            panelpayments.Visible = False
            panelbanks.Visible = False
            panelaccounts.Visible = False
            panelLoans.Visible = True
            lblperiod.Visible = False
            Me.panelperiod.Visible = False
            lblcustomdate.Visible = False
            Me.panelfrom.Visible = False
            lblto.Visible = False
            Me.panelto.Visible = False

            Me.btnNew.Location = New Point(777, 12)
            Me.btnEdit.Location = New Point(880, 12)
            Me.btnView.Location = New Point(983, 12)
            Me.btnPrint.Visible = False
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
        If myactivepage = activepage.pagepayment Then
            If Trim(Me.txtSearch.Text) = "" Then
                Me.lblshowing.Text = "Showing top 100 results"
            Else
                Me.lblshowing.Text = "Showing top 100 results for '" & Me.txtSearch.Text & "'"
            End If
            With dgvmain
                .DataSource = Nothing
                .DataSource = clsPayment.FetchDateRange(9, Me.txtSearch.Text, Me.dtpinitialdate.Value, Me.dtpendingdate.Value)
                .Columns(0).HeaderText = "Trans. No."
                .Columns(0).Width = 103
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).HeaderText = "OR #"
                .Columns(1).Width = 105
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).HeaderText = "OR Date"
                .Columns(2).Width = 110
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(3).HeaderText = "Customer"
                .Columns(3).Width = 190
                .Columns(4).HeaderText = "Cash"
                .Columns(4).Width = 130
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).HeaderText = "Check"
                .Columns(5).Width = 130
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(6).HeaderText = "Bank to Bank"
                .Columns(6).Width = 130
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(7).HeaderText = "Encoder"
                .Columns(7).Width = 100

            End With
        ElseIf myactivepage = activepage.pagebanks Then
            If Trim(Me.txtSearch.Text) = "" Then
                Me.lblshowing.Text = "Showing all results"
            Else
                Me.lblshowing.Text = "Showing results for '" & Me.txtSearch.Text & "'"
            End If
            With dgvmain
                .DataSource = Nothing
                .DataSource = clsPayment.Fetch(1, Me.txtSearch.Text)
                .Columns(0).HeaderText = "Bank #"
                .Columns(0).Width = 208
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).HeaderText = "Bank Name"
                .Columns(1).Width = 790
            End With
        ElseIf myactivepage = activepage.pageaccounts Then
            If Trim(Me.txtSearch.Text) = "" Then
                Me.lblshowing.Text = "Showing all results"
            Else
                Me.lblshowing.Text = "Showing results for '" & Me.txtSearch.Text & "'"
            End If
            With dgvmain
                .DataSource = Nothing
                .DataSource = clsPayment.Fetch(2, Me.txtSearch.Text)
                .Columns(1).HeaderText = "Account ID"
                .Columns(1).Width = 120
                .Columns(1).HeaderText = "Account Name"
                .Columns(1).Width = 270
                .Columns(2).HeaderText = "Account #"
                .Columns(2).Width = 208
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(3).HeaderText = "Bank Name"
                .Columns(3).Width = 150
                .Columns(4).HeaderText = "Preffered Branch"
                .Columns(4).Width = 150
                .Columns(5).HeaderText = "Is Active"
                .Columns(5).Width = 120
            End With
        Else
            If Trim(Me.txtSearch.Text) = "" Then
                Me.lblshowing.Text = "Showing all results"
            Else
                Me.lblshowing.Text = "Showing results for '" & Me.txtSearch.Text & "'"
            End If
            With dgvmain
                .DataSource = Nothing
                .DataSource = clsPayment.Fetch(15, Me.txtSearch.Text)
                .Columns(0).HeaderText = "Institution #"
                .Columns(0).Width = 208
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).HeaderText = "Institution Name"
                .Columns(1).Width = 690
                .Columns(2).HeaderText = "Is Active?"
                .Columns(2).Width = 100
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
        DisplayList()
    End Sub

    Private Sub txtSearch_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.Leave
        If Trim(Me.txtSearch.Text) = "" Then
            DisplayList()
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If Me.myactivepage = activepage.pagepayment Then
            Dim f As New frmPaymentLibrary
            f.myCurrentFormStatus = frmPaymentLibrary.enFormStatus.add
            f.ShowDialog()
            If f.issave Then
                Call DisplayList()
            End If
        ElseIf Me.myactivepage = activepage.pagebanks Then
            Dim f As New frmBankLibrary
            f.myformstatus = frmBankLibrary.formstatus.add
            f.ShowDialog()
            If f.issave Then
                Call DisplayList()
            End If
        ElseIf Me.myactivepage = activepage.pageaccounts Then
            Dim f As New frmBankAccountLibrary
            f.myformstatus = frmBankAccountLibrary.formstatus.add
            f.ShowDialog()
            If f.issave Then
                Call DisplayList()
            End If
            f.Dispose()
        Else
            Dim f As New frmLoanLibrary
            f.myformstatus = frmLoanLibrary.formstatus.add
            f.ShowDialog()
            If f.issave Then
                Call Me.DisplayList()
            End If
        End If

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If dgvmain.CurrentRow.Index >= 0 Then
                If Me.myactivepage = activepage.pagepayment Then
                    'Dim f As New frmLotLibrary
                    'f.propertyid = cmbpaymenttype.SelectedValue
                    'f.lotid = Me.dgvmain.CurrentRow.Cells("LOT_ID").Value
                    'f.myformstatus = frmLotLibrary.formstatus.edit
                    'f.ShowDialog()
                    'If f.issave Then
                    '    Call DisplayList()
                    'End If
                ElseIf Me.myactivepage = activepage.pagebanks Then
                    Dim f As New frmBankLibrary
                    f.bankid = Me.dgvmain.CurrentRow.Cells("BANKID").Value
                    f.bankname = Me.dgvmain.CurrentRow.Cells("NAME").Value
                    f.myformstatus = frmBankLibrary.formstatus.edit
                    f.ShowDialog()
                    If f.issave Then
                        Call DisplayList()
                    End If
                ElseIf Me.myactivepage = activepage.pageaccounts Then
                    Dim f As New frmBankAccountLibrary
                    f.myformstatus = frmBankAccountLibrary.formstatus.edit
                    f.accountid = Me.dgvmain.CurrentRow.Cells("accountid").Value
                    f.ShowDialog()
                    If f.issave Then
                        Call DisplayList()
                    End If
                Else
                    Dim f As New frmLoanLibrary
                    f.intitutionid = Me.dgvmain.CurrentRow.Cells("institutionid").Value
                    f.institutionname = Me.dgvmain.CurrentRow.Cells("NAME").Value
                    f.isactive = Me.dgvmain.CurrentRow.Cells("isactive").Value
                    f.myformstatus = frmBankLibrary.formstatus.edit
                    f.ShowDialog()
                    If f.issave Then
                        Call DisplayList()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try
            If dgvmain.CurrentRow.Index >= 0 Then
                If Me.myactivepage = activepage.pagepayment Then
                    'Dim f As New frmLotLibrary
                    'f.propertyid = cmbpaymenttype.SelectedValue
                    'f.lotid = Me.dgvmain.CurrentRow.Cells("LOT_ID").Value
                    'f.myformstatus = frmLotLibrary.formstatus.view
                    'f.ShowDialog()
                ElseIf Me.myactivepage = activepage.pagebanks Then
                    Dim f As New frmBankLibrary
                    f.bankid = Me.dgvmain.CurrentRow.Cells("BANKID").Value
                    f.bankname = Me.dgvmain.CurrentRow.Cells("NAME").Value
                    f.myformstatus = frmBankLibrary.formstatus.view
                    f.ShowDialog()
                ElseIf Me.myactivepage = activepage.pageaccounts Then
                    Dim f As New frmBankAccountLibrary
                    f.myformstatus = frmBankAccountLibrary.formstatus.view
                    f.accountid = Me.dgvmain.CurrentRow.Cells("accountid").Value
                    f.ShowDialog()
                Else
                    Dim f As New frmLoanLibrary
                    f.intitutionid = Me.dgvmain.CurrentRow.Cells("institutionid").Value
                    f.institutionname = Me.dgvmain.CurrentRow.Cells("NAME").Value
                    f.isactive = Me.dgvmain.CurrentRow.Cells("isactive").Value
                    f.myformstatus = frmBankLibrary.formstatus.view
                    f.ShowDialog()
                End If
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnMenuLots_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayments.MouseEnter
        If myactivepage <> activepage.pagepayment Then
            Me.btnPayments.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btnMenuLots_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayments.MouseLeave
        Me.btnPayments.ForeColor = System.Drawing.SystemColors.WindowFrame
    End Sub

    Private Sub btnMenuProperties_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBanks.MouseEnter
        If myactivepage <> activepage.pagebanks Then
            Me.btnBanks.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btnMenuProperties_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBanks.MouseLeave
        Me.btnBanks.ForeColor = System.Drawing.SystemColors.WindowFrame
    End Sub

    Private Sub btnMenuLots_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayments.Click
        If myactivepage <> activepage.pagepayment Then
            myactivepage = activepage.pagepayment
            Call InitializePage()
        End If
    End Sub

    Private Sub btnMenuProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBanks.Click
        If myactivepage <> activepage.pagebanks Then
            myactivepage = activepage.pagebanks
            Call InitializePage()
        End If
    End Sub


    Private Sub btntype_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccount.MouseEnter
        If myactivepage <> activepage.pageaccounts Then
            Me.btnAccount.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btntype_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccount.MouseLeave
        Me.btnAccount.ForeColor = System.Drawing.SystemColors.WindowFrame
    End Sub

    Private Sub btnLoan_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoan.MouseEnter
        If myactivepage <> activepage.pageloans Then
            Me.btnLoan.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btnLoan_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoan.MouseLeave
        Me.btnLoan.ForeColor = System.Drawing.SystemColors.WindowFrame
    End Sub

    Private Sub btntype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccount.Click
        If myactivepage <> activepage.pageaccounts Then
            myactivepage = activepage.pageaccounts
            Call InitializePage()
        End If
    End Sub

    Private Sub cmbpaymenttype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Call DisplayList()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbPeriod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPeriod.SelectedIndexChanged
        Call LoadDateRange(Me.cmbPeriod.SelectedIndex)
    End Sub

    Private Sub dtpinitialdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpinitialdate.ValueChanged, dtpendingdate.ValueChanged
        Call DisplayList()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Call clsPayment.PrintCollection(Me.dtpinitialdate.Value, Me.dtpendingdate.Value)
    End Sub

    Private Sub btnLoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoan.Click
        If myactivepage <> activepage.pageloans Then
            myactivepage = activepage.pageloans
            Call InitializePage()
        End If
    End Sub
End Class