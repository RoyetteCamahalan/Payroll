Public Class frmEmployeeLibrary

    Private Sub frmEmployeeLibrary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call PaintForm()
        Call EnableFields()
        If myformstatus <> formstatus.add Then
            Call LoadRecord()
        Else
            Me.Label1.Visible = True
        End If
    End Sub

#Region "Variables"
    Dim erp As New ErrorProvider
    Public issave As Boolean
    Public employeeid As Integer
    Private oldpword As String
    Public myformstatus As formstatus
    Enum formstatus
        add = 0
        edit = 1
        view = 2
    End Enum
#End Region

#Region "Methods"
    Private Sub LoadRecord()
        Dim dtRecord As DataTable = clsEmployees.GetUsers(2, Me.employeeid)
        Me.txtfname.Text = dtRecord.Rows(0).Item("firstname")
        Me.txtmname.Text = dtRecord.Rows(0).Item("middlename")
        Me.txtlname.Text = dtRecord.Rows(0).Item("lastname")

        If dtRecord.Rows(0).Item("gender") = "M" Then
            Me.rdmale.Checked = True
        Else
            Me.rdfemale.Checked = True
        End If
        Me.chkisactive.Checked = dtRecord.Rows(0).Item("isactive")
        Me.chkisadmin.Checked = dtRecord.Rows(0).Item("isappsysadmin")

        Me.txtuname.Text = dtRecord.Rows(0).Item("username")
        Me.oldpword = dtRecord.Rows(0).Item("userpass")
        Me.txtpword.Text = oldpword
        Me.txtconfirmpword.Text = oldpword
    End Sub
    Public Sub EnableFields()
        If Me.myformstatus = formstatus.view Then
            Me.txtfname.Enabled = False
            Me.txtlname.Enabled = False
            Me.txtmname.Enabled = False
            Me.groupgender.Enabled = False
            Me.chkisactive.Enabled = False
            Me.chkisadmin.Enabled = False
            Me.txtuname.Enabled = False
            Me.txtpword.Enabled = False
            Me.lblconfirm.Visible = False
            Me.panelconfirm.Visible = False
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
            Me.lblTitle.Text = "Edit Employee"
        Else
            Me.BackColor = viewcolor
            Me.btnpositive.BackColor = viewcolor
            Me.lblTitle.Text = "View Employee"
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


        If Trim(Me.txtuname.Text) = "" Then
            isvalid = False
            seterror(paneluname, "This field is required!")
        Else
            seterror(paneluname)
        End If
        If Trim(Me.txtpword.Text) = "" Then
            isvalid = False
            seterror(panelpword, "This field is required!")
        Else
            seterror(panelpword)
        End If
        If Trim(Me.txtconfirmpword.Text) = "" Then
            isvalid = False
            seterror(panelconfirm, "This field is required!")
        Else
            seterror(panelconfirm)
        End If
        If isvalid Then
            If Me.txtpword.Text <> Me.txtconfirmpword.Text Then
                isvalid = False
                seterror(panelconfirm, "Password does not match")
            Else
                seterror(panelconfirm)
            End If
        End If
        Return isvalid
    End Function
    Private Sub Save()
        If isallfieldvalid() Then
            If CustommsgBox(msgstyle.info, msgtype.yesno, "Employee", "Are you sure you want to save this information?") Then
                Dim x As New clsEmployees
                x.employeeid = Me.employeeid
                x.firstname = Me.txtfname.Text
                x.middlename = Me.txtmname.Text
                x.lastname = Me.txtlname.Text
                x.gender = IIf(rdmale.Checked, "M", "F")
                x.isactive = chkisactive.Checked
                x.isadmin = chkisadmin.Checked
                x.username = Me.txtuname.Text
                x.password = Utility.GetHash(Me.txtpword.Text)
                x.createdbyid = Current_UserID
                x.datecreated = Utility.GetServerDate
                If Me.myformstatus = formstatus.add Then
                    Me.employeeid = x.SaveEmployee(True)
                Else
                    If oldpword <> Me.txtpword.Text Then
                        x.changePassword = True
                    End If
                    Me.employeeid = x.SaveEmployee(False)
                End If
                If employeeid > 0 Then
                    If Me.myformstatus = formstatus.add Then
                        Call SaveLogs(applicationmodule.modEmployees, "Employee", "Added New Employee : " & Me.txtlname.Text & " " & Me.txtfname.Text & " " & Me.txtmname.Text)
                    Else
                        Call SaveLogs(applicationmodule.modEmployees, "Employee", "Updated Employee : " & Me.txtlname.Text & " " & Me.txtfname.Text & " " & Me.txtmname.Text)
                    End If
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