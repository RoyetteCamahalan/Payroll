Public Class frmCustomerLibrary

    Private Sub frmCustomerLibrary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call PaintForm()
        Call EnableFields()
        If myformstatus <> formstatus.add Then
            Call LoadRecord()
        End If
    End Sub

#Region "Variables"
    Dim erp As New ErrorProvider
    Public issave As Boolean
    Public customerid As Integer
    Public customername As String
    Public myformstatus As formstatus
    Enum formstatus
        add = 0
        edit = 1
        view = 2
    End Enum
#End Region

#Region "Methods"
    Private Sub LoadRecord()
        Dim dtRecord As DataTable = clsCustomers.Fetch(1, Me.customerid)
        Me.txtfname.Text = dtRecord.Rows(0).Item("FNAME")
        Me.txtmi.Text = dtRecord.Rows(0).Item("MI")
        Me.txtlname.Text = dtRecord.Rows(0).Item("LNAME")
        Me.dtpbirthdate.Value = dtRecord.Rows(0).Item("BIRTHDATE")
        Me.txtaddress.Text = dtRecord.Rows(0).Item("ADDRESS")
        Me.txtcontact.Text = dtRecord.Rows(0).Item("CONTACTNO")
        Me.txttin.Text = dtRecord.Rows(0).Item("TINNUMBER")
    End Sub
    Public Sub EnableFields()
        If Me.myformstatus = formstatus.view Then
            Me.txtfname.Enabled = False
            Me.txtlname.Enabled = False
            Me.txtmi.Enabled = False
            Me.dtpbirthdate.Enabled = False
            Me.txtaddress.Enabled = False
            Me.txtcontact.Enabled = False
            Me.txttin.Enabled = False
            Me.btnpositive.Visible = False
        End If
    End Sub
    Private Sub PaintForm()
        Me.dtpbirthdate.MaxDate = Utility.GetServerDate
        If Me.myformstatus = formstatus.add Then
            Me.BackColor = newcolor
            Me.btnpositive.BackColor = newcolor
        ElseIf myformstatus = formstatus.edit Then
            Me.BackColor = editcolor
            Me.btnpositive.BackColor = editcolor
            Me.lblTitle.Text = "Edit Customer"
        Else
            Me.BackColor = viewcolor
            Me.btnpositive.BackColor = viewcolor
            Me.lblTitle.Text = "View Customer"
        End If
    End Sub
    Private Sub seterror(ByRef ctr As Control, Optional ByRef msg As String = "")
        erp.SetError(ctr, msg)
    End Sub
    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True
        If Trim(Me.txtfname.Text) = "" Then
            isvalid = False
            seterror(panelfname, "This field is required!")
        Else
            seterror(panelfname)
        End If
        If Trim(Me.txtlname.Text) = "" Then
            isvalid = False
            seterror(panellname, "This field is required!")
        Else
            seterror(panellname)
        End If

        If Trim(Me.txtaddress.Text) = "" Then
            isvalid = False
            seterror(paneladdress, "This field is required!")
        Else
            seterror(paneladdress)
        End If
        Return isvalid
    End Function
    Private Sub Save()
        If isallfieldvalid() Then
            If CustommsgBox(msgstyle.info, msgtype.yesno, "Customer", "Are you sure you want to save this information?") Then
                Dim x As New clsCustomers
                x.customerid = Me.customerid
                x.firstname = Me.txtfname.Text
                x.middlename = Me.txtmi.Text
                x.lastname = Me.txtlname.Text
                x.bdate = Me.dtpbirthdate.Value
                x.address = Me.txtaddress.Text
                x.contact = Me.txtcontact.Text
                x.tin = Me.txttin.Text
                x.createdbyid = Current_UserID
                x.datecreated = Utility.GetServerDate
                If Me.myformstatus = formstatus.add Then
                    Me.customerid = x.SaveCustomer(True)
                Else
                    Me.customerid = x.SaveCustomer(False)
                End If
                If customerid > 0 Then
                    If Me.myformstatus = formstatus.add Then
                        Call SaveLogs(applicationmodule.modCustomers, "Customers", "Added New Customer : " & Me.txtlname.Text & " " & Me.txtfname.Text & " " & Me.txtmi.Text)
                    Else
                        Call SaveLogs(applicationmodule.modCustomers, "Customers", "Updated Customer : " & Me.txtlname.Text & " " & Me.txtfname.Text & " " & Me.txtmi.Text)
                    End If
                  
                    Me.myformstatus = formstatus.view
                    Me.issave = True
                    Me.customername = Me.txtlname.Text & ", " & Me.txtfname.Text & " " & Me.txtmi.Text
                    Me.Close()
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