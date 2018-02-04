Public Class frmSearchEngine

    Private Sub frmReservations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgvmain.RowTemplate.Height = Default_Row_Height
        Call InitializeForm()
        Call DisplayList()
    End Sub
#Region "Variables"
    Public searchstatus As searchmodule
    Public issave As Boolean
    Public mkey As Long
    Public mvalue, mformonth, mvalue1 As String
    Public mprice, mcommissionable, mcompercentage, mreservationfee, mcomatdown As Double
    Public mamount, minterest, mbalance As Double
    Public mchargedate As Date
    Public position As Integer
    Enum searchmodule
        searchagent = 0
        searchcustomer = 1
        searchlots = 2
        searchexpenseaccount = 3
        searchexpensetype = 4
        searchpayables = 5
        searchcommissionpayable = 6
        searchagentwithall = 7
    End Enum
#End Region
#Region "Methods"
    Private Sub InitializeForm()
        If Me.searchstatus = searchmodule.searchagent Or Me.searchstatus = searchmodule.searchcommissionpayable Or Me.searchstatus = searchmodule.searchagentwithall Then
            Me.btnAddNew.Visible = False
        ElseIf Me.searchstatus = searchmodule.searchpayables Then
            Me.btnAddNew.Visible = False
            Me.lblsearch.Visible = False
            Me.panelsearch.Visible = False
        End If
    End Sub
    Private Sub DisplayList()
        Select Case Me.searchstatus
            Case searchmodule.searchagent
                Me.lblModule.Text = "List Of Agents"
                dgvmain.DataSource = clsAgents.Fetch(0, Me.txtSearch.Text)
            Case searchmodule.searchcustomer
                Me.lblModule.Text = "List Of Customers"
                dgvmain.DataSource = clsCustomers.Fetch(0, Me.txtSearch.Text)
            Case searchmodule.searchlots
                Me.lblModule.Text = "List Of Available Lots"
                dgvmain.DataSource = clsProperty.Fetch(7, Me.txtSearch.Text)
            Case searchmodule.searchexpenseaccount
                Me.lblModule.Text = "List Of Accounts"
                dgvmain.DataSource = clsExpenses.Fetch(9, Me.txtSearch.Text)
            Case searchmodule.searchexpensetype
                Me.lblModule.Text = "List Of Expense Type"
                dgvmain.DataSource = clsExpenses.Fetch(1, Me.txtSearch.Text)
            Case searchmodule.searchpayables
                Me.lblModule.Text = "List Of Payables of " & mvalue
                dgvmain.DataSource = clsPayment.Fetch(8, Me.mkey)
            Case searchmodule.searchcommissionpayable
                Me.lblModule.Text = "List Of Payables of Commission"
                dgvmain.DataSource = clsCommissions.fetch(0, Me.txtSearch.Text, Me.mkey)
            Case searchmodule.searchagentwithall
                Me.lblModule.Text = "List Of Agents"
                dgvmain.DataSource = clsAgents.Fetch(6, Me.txtSearch.Text)
        End Select
        Call FormatGrid()
    End Sub
    Private Sub FormatGrid()
        With dgvmain
            Select Case Me.searchstatus
                Case searchmodule.searchagent, searchmodule.searchagentwithall
                    .Columns(0).HeaderText = "Agent #"
                    .Columns(0).Width = 108
                    .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(1).HeaderText = "Last Name"
                    .Columns(1).Width = 145
                    .Columns(2).HeaderText = "First Name"
                    .Columns(2).Width = 145
                    .Columns(3).HeaderText = "MI"
                    .Columns(3).Width = 80
                    .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(4).HeaderText = "Contact #"
                    .Columns(4).Width = 120
                    .Columns(5).HeaderText = "Position"
                    .Columns(5).Width = 200
                    .Columns(6).HeaderText = "Upline"
                    .Columns(6).Width = 200
                    .Columns(7).Visible = False
                    .Columns(8).Visible = False
                    .Columns(9).Visible = False
                    .Columns(10).Visible = False
                Case searchmodule.searchcustomer
                    .Columns(0).HeaderText = "Customer #"
                    .Columns(0).Width = 108
                    .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(1).HeaderText = "Last Name"
                    .Columns(1).Width = 145
                    .Columns(2).HeaderText = "First Name"
                    .Columns(2).Width = 145
                    .Columns(3).HeaderText = "MI"
                    .Columns(3).Width = 80
                    .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(4).HeaderText = "Birthdate"
                    .Columns(4).Width = 120
                    .Columns(5).HeaderText = "Address"
                    .Columns(5).Width = 150
                    .Columns(6).HeaderText = "Contact #"
                    .Columns(6).Width = 150
                    .Columns(7).HeaderText = "Tin #"
                    .Columns(7).Width = 100
                Case searchmodule.searchlots
                    .Columns(0).HeaderText = "Lot ID"
                    .Columns(0).Width = 108
                    .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(1).HeaderText = "Lot Name"
                    .Columns(1).Width = 220
                    .Columns(2).HeaderText = "Area"
                    .Columns(2).Width = 220
                    .Columns(3).HeaderText = "Price"
                    .Columns(3).Width = 110
                    .Columns(4).HeaderText = "Down"
                    .Columns(4).Width = 120
                    .Columns(5).HeaderText = "Type/Model"
                    .Columns(5).Width = 120
                    .Columns(6).Visible = False
                    .Columns(7).HeaderText = "Status"
                    .Columns(5).Width = 120
                    .Columns(8).Visible = False
                    .Columns(9).Visible = False
                    .Columns(10).Visible = False
                    .Columns(11).Visible = False
                Case searchmodule.searchexpenseaccount
                    .Columns(0).HeaderText = "Account #"
                    .Columns(0).Width = 108
                    .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(1).HeaderText = "Account Name"
                    .Columns(1).Width = 420
                    .Columns(2).HeaderText = "Memo"
                    .Columns(2).Width = 380
                    .Columns(3).HeaderText = "Is Active"
                    .Columns(3).Width = 110
                Case searchmodule.searchexpensetype
                    .Columns(0).HeaderText = "Expense Type #"
                    .Columns(0).Width = 218
                    .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(1).HeaderText = "Expense Type"
                    .Columns(1).Width = 780
                Case searchmodule.searchpayables
                    .Columns(0).HeaderText = "Lot Name"
                    .Columns(0).Width = 278
                    .Columns(1).HeaderText = "Date"
                    .Columns(1).Width = 110
                    .Columns(2).HeaderText = "For The Month"
                    .Columns(2).Width = 150
                    .Columns(3).HeaderText = "Amount"
                    .Columns(3).Width = 150
                    .Columns(4).HeaderText = "Interest"
                    .Columns(4).Width = 140
                    .Columns(5).HeaderText = "Balance"
                    .Columns(5).Width = 150
                    .Columns(6).Visible = False
                Case searchmodule.searchcommissionpayable
                    .Columns(0).HeaderText = "Customer Name"
                    .Columns(0).Width = 278
                    .Columns(1).HeaderText = "Lot Name"
                    .Columns(1).Width = 250
                    .Columns(2).HeaderText = "Date"
                    .Columns(2).Width = 150
                    .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(3).HeaderText = "For the Month of"
                    .Columns(3).Width = 150
                    .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(4).HeaderText = "Amount"
                    .Columns(4).Width = 150
                    .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(5).Visible = False
            End Select
        End With
        Me.lblshowing.Text = "Showing top " & dgvmain.RowCount & " result(s)"
    End Sub
    Private Sub SelectRecord()
        Select Case Me.searchstatus
            Case searchmodule.searchagent, searchmodule.searchagentwithall
                Me.mkey = dgvmain.CurrentRow.Cells("AGENTID").Value
                Me.mvalue = dgvmain.CurrentRow.Cells("LNAME").Value.ToString & ", " & dgvmain.CurrentRow.Cells("FNAME").Value.ToString
                Me.position = dgvmain.CurrentRow.Cells("level").Value
                Me.issave = True
                Me.Close()
            Case searchmodule.searchcustomer
                Me.mkey = dgvmain.CurrentRow.Cells("CUSTID").Value
                Me.mvalue = dgvmain.CurrentRow.Cells("LNAME").Value.ToString & ", " & dgvmain.CurrentRow.Cells("FNAME").Value.ToString
                Me.issave = True
                Me.Close()
            Case searchmodule.searchlots
                If Me.dgvmain.CurrentRow.Cells("Status").Value <> "Available" Then
                    CustommsgBox(msgstyle.critical, msgtype.okonly, "Universal search engine", "This lot is not available, Please select other lot.")
                Else
                    Me.mkey = dgvmain.CurrentRow.Cells("LOT_ID").Value
                    Me.mvalue = dgvmain.CurrentRow.Cells("NAME").Value.ToString
                    Me.mprice = dgvmain.CurrentRow.Cells("DEFAULT_PRICE").Value
                    Me.mcommissionable = dgvmain.CurrentRow.Cells("commissionableamount").Value
                    Me.mcompercentage = dgvmain.CurrentRow.Cells("compercentage").Value
                    Me.mreservationfee = dgvmain.CurrentRow.Cells("MIN_DOWN").Value
                    Me.mcomatdown = dgvmain.CurrentRow.Cells("comatdown").Value
                    Me.issave = True
                    Me.Close()
                End If
            Case searchmodule.searchexpenseaccount
                Me.mkey = dgvmain.CurrentRow.Cells("accountid").Value
                Me.mvalue = dgvmain.CurrentRow.Cells("accountname").Value.ToString
                Me.issave = True
                Me.Close()
            Case searchmodule.searchexpensetype
                Me.mkey = dgvmain.CurrentRow.Cells("expensetypeid").Value
                Me.mvalue = dgvmain.CurrentRow.Cells("expensetypedesc").Value.ToString
                Me.issave = True
                Me.Close()
            Case searchmodule.searchpayables
                Me.mkey = dgvmain.CurrentRow.Cells("chargeid").Value
                Me.mvalue = dgvmain.CurrentRow.Cells("property").Value
                Me.mamount = dgvmain.CurrentRow.Cells("chargeamount").Value
                Me.mchargedate = dgvmain.CurrentRow.Cells("chargedate").Value
                Me.minterest = dgvmain.CurrentRow.Cells("interestamount").Value
                Me.mbalance = dgvmain.CurrentRow.Cells("balance").Value
                Me.mformonth = dgvmain.CurrentRow.Cells("formonth").Value
                Me.issave = True
                Me.Close()
            Case searchmodule.searchcommissionpayable
                Me.mkey = dgvmain.CurrentRow.Cells("chargeid").Value
                Me.mvalue = dgvmain.CurrentRow.Cells("customer").Value
                Me.mvalue1 = dgvmain.CurrentRow.Cells("property").Value
                Me.mchargedate = dgvmain.CurrentRow.Cells("chargedate").Value
                Me.mamount = dgvmain.CurrentRow.Cells("amount").Value
                Me.mformonth = dgvmain.CurrentRow.Cells("formonth").Value
                Me.issave = True
                Me.Close()
        End Select
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

    Private Sub txtSearch_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If Trim(Me.txtSearch.Text) = "" Then
            Call DisplayList()
        End If
    End Sub

    Private Sub dgvmain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvmain.DoubleClick
        Me.btnSelect.PerformClick()
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Try
            Call SelectRecord()
        Catch ex As Exception
            CustommsgBox(msgstyle.warning, msgtype.okonly, "Universal search engine", "No record selected. Please select from the list or search again.")
        End Try
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Select Case searchstatus
            Case searchmodule.searchcustomer
                Dim f As New frmCustomerLibrary
                f.myformstatus = frmCustomerLibrary.formstatus.add
                f.ShowDialog()
                If f.issave Then
                    Me.mkey = f.customerid
                    Me.mvalue = f.customername
                    Me.issave = True
                    Me.Close()
                End If
                f.Dispose()
            Case searchmodule.searchexpenseaccount
                Dim f As New frmAccountLibrary
                f.myformstatus = frmAccountLibrary.formstatus.add
                f.ShowDialog()
                If f.issave Then
                    Me.mkey = f.accountid
                    Me.mvalue = f.accountname
                    Me.issave = True
                    Me.Close()
                End If
            Case searchmodule.searchexpensetype
                Dim f As New frmExpenseTypeLibrary
                f.myformstatus = frmExpenseTypeLibrary.formstatus.add
                f.ShowDialog()
                If f.issave Then
                    Me.mkey = f.expensetypeid
                    Me.mvalue = f.expensetypename
                    Me.issave = True
                    Me.Close()
                End If
        End Select
    End Sub

End Class