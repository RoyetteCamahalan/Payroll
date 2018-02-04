Public Class frmVendorLibrary

    Private Sub frmVendorLibrary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call PaintForm()
        Call EnableFields()
        If myformstatus <> formstatus.add Then
            Call LoadRecord()
        End If
    End Sub

#Region "Variables"
    Dim erp As New ErrorProvider
    Public issave As Boolean
    Public vendorid As Integer
    Public vendorname As String
    Public myformstatus As formstatus
    Enum formstatus
        add = 0
        edit = 1
        view = 2
    End Enum
#End Region

#Region "Methods"
    Private Sub LoadRecord()
        Dim dtRecord As DataTable = clsExpenses.Fetch(6, Me.vendorid)
        Me.vendorname = dtRecord.Rows(0).Item("vendorname")
        Me.txtvendorname.Text = Me.vendorname
        Me.txtaddress.Text = dtRecord.Rows(0).Item("address")
        Me.txtcontact.Text = dtRecord.Rows(0).Item("contactno")
    End Sub
    Public Sub EnableFields()
        If Me.myformstatus = formstatus.view Then
            Me.txtvendorname.Enabled = False
            Me.txtaddress.Enabled = False
            Me.txtcontact.Enabled = False
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
            Me.lblTitle.Text = "Edit Vendor"
        Else
            Me.BackColor = viewcolor
            Me.btnpositive.BackColor = viewcolor
            Me.lblTitle.Text = "View Vendor"
        End If
    End Sub
    Private Sub seterror(ByRef ctr As Control, Optional ByRef msg As String = "")
        erp.SetError(ctr, msg)
    End Sub
    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True
        If Trim(Me.txtvendorname.Text) = "" Then
            isvalid = False
            seterror(panelvendorname, "This field is required!")
        Else
            seterror(panelvendorname)
            If Me.txtvendorname.Text <> Me.vendorname Then
                If clsExpenses.Fetch(4, Me.txtvendorname.Text).Rows.Count > 0 Then
                    isvalid = False
                    seterror(panelvendorname, "Vendor Name already exist!")
                Else
                    seterror(panelvendorname)
                End If
            End If
        End If
        Return isvalid
    End Function
    Private Sub Save()
        If isallfieldvalid() Then
            If CustommsgBox(msgstyle.info, msgtype.yesno, "Vendor", "Are you sure you want to save this information?") Then
                Dim x As New clsExpenses
                x.vendorid = Me.vendorid
                x.vendorname = Me.txtvendorname.Text
                x.address = Me.txtaddress.Text
                x.contactno = Me.txtcontact.Text
                If Me.myformstatus = formstatus.add Then
                    Me.vendorid = x.SaveVendor(True)
                Else
                    Me.vendorid = x.SaveVendor(False)
                End If
                If vendorid > 0 Then
                    If Me.myformstatus = formstatus.add Then
                        Call SaveLogs(applicationmodule.modExpenses, "Vendor", "Added New Vendor : " & Me.txtvendorname.Text)
                    Else
                        Call SaveLogs(applicationmodule.modExpenses, "Vendor", "Updated Vendor : " & Me.txtvendorname.Text)
                    End If
                    Me.myformstatus = formstatus.view
                    Me.issave = True
                    Me.vendorname = Me.txtvendorname.Text
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