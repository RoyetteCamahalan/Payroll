Public Class frmAgentLibrary

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
    Public agentid As Long
    Public uplineid As Long
    Public position As Integer
    Public myformstatus As formstatus
    Enum formstatus
        add = 0
        edit = 1
        view = 2
    End Enum
#End Region

#Region "Methods"
    Private Sub LoadRecord()
        Dim dtRecord As DataTable = clsAgents.Fetch(2, Me.agentid)
        Me.txtfname.Text = dtRecord.Rows(0).Item("FNAME")
        Me.txtmi.Text = dtRecord.Rows(0).Item("MI")
        Me.txtlname.Text = dtRecord.Rows(0).Item("LNAME")
        Me.dtpbirthdate.Value = dtRecord.Rows(0).Item("BIRTHDATE")
        Me.txtaddress.Text = dtRecord.Rows(0).Item("ADDRESS")
        Me.txtcontact.Text = dtRecord.Rows(0).Item("CONTACTNO")
        Me.position = dtRecord.Rows(0).Item("POSITION")
        Me.uplineid = dtRecord.Rows(0).Item("SUPERIORID")
        Me.txtuplinename.Text = dtRecord.Rows(0).Item("Upline")
        Me.chkisbroker.Checked = uplineid = 0
        Me.txtaccname.Text = Utility.NullToEmptyString(dtRecord.Rows(0).Item("accname"))
        Me.txtaccno.Text = Utility.NullToEmptyString(dtRecord.Rows(0).Item("accno"))


        Call LoadPosition()
    End Sub
    Public Sub EnableFields()
        If Me.myformstatus = formstatus.view Then
            Me.txtfname.Enabled = False
            Me.txtlname.Enabled = False
            Me.txtmi.Enabled = False
            Me.dtpbirthdate.Enabled = False
            Me.txtaddress.Enabled = False
            Me.txtcontact.Enabled = False
            Me.chkisbroker.Enabled = False
            Me.pctrSearchUpline.Enabled = False
            Me.btnpositive.Visible = False
            Me.txtaccname.Enabled = False
            Me.txtaccno.Enabled = False
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
            Me.lblTitle.Text = "Edit Agent"
        Else
            Me.BackColor = viewcolor
            Me.btnpositive.BackColor = viewcolor
            Me.lblTitle.Text = "View Agent"
        End If
    End Sub
    Private Sub LoadPosition()
        Select Case Me.position
            Case 0
                Me.txtposition.Text = ""
            Case 2
                Me.txtposition.Text = "Sales Director (Agent Level 2)"
            Case 3
                Me.txtposition.Text = "Sales Manager (Agent Level 3)"
            Case Else
                Me.txtposition.Text = "Property Consultant (Agent Level " & Me.position.ToString & ")"
        End Select
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
        If position = 0 And chkisbroker.Checked = False Then
            isvalid = False
            seterror(panelupline, "Upline required")
        Else
            If Me.myformstatus = formstatus.add Then
                If Me.position > Utility.SystemSetting(Utility.systemsettings.MaxAgentLevel) Then
                    isvalid = False
                    CustommsgBox(msgstyle.critical, msgtype.okonly, "Agent Library", "Cannot add agent at level " & position.ToString & " as it exceeds the maximum of " & Utility.SystemSetting(Utility.systemsettings.MaxAgentLevel).ToString & " levels. Please check current system setting.")
                Else
                    If clsAgents.GetDownlines(Me.uplineid) >= Utility.SystemSetting(position) Then
                        isvalid = False
                        CustommsgBox(msgstyle.critical, msgtype.okonly, "Agent Library", "Cannot add agent because upline agent already reach the maximum downline agent count of " & Utility.SystemSetting(position).ToString & ". Please check current system setting.")
                    End If
                End If
            End If

        End If


        Return isvalid
    End Function
    Private Sub Save()
        If isallfieldvalid() Then
            If CustommsgBox(msgstyle.info, msgtype.yesno, "Agent Library", "Are you sure you want to save this information?") Then
                Dim x As New clsAgents
                x.agentid = Me.agentid
                x.firstname = Me.txtfname.Text
                x.middleinitial = Me.txtmi.Text
                x.lastname = Me.txtlname.Text
                x.bdate = Me.dtpbirthdate.Value
                x.address = Me.txtaddress.Text
                x.contact = Me.txtcontact.Text
                x.accname = Me.txtaccname.Text
                x.accno = Me.txtaccno.Text
                If chkisbroker.Checked Then
                    x.position = 1
                    x.uplineid = 0
                Else
                    x.position = Me.position
                    x.uplineid = Me.uplineid
                End If
                If Me.myformstatus = formstatus.add Then
                    Me.agentid = x.SaveAgent(True)
                Else
                    Me.agentid = x.SaveAgent(False)
                End If
                If agentid > 0 Then
                    If Me.myformstatus = formstatus.add Then
                        Call SaveLogs(applicationmodule.modAgents, "Agents", "Added New Agent : " & Me.txtlname.Text & " " & Me.txtfname.Text & " " & Me.txtmi.Text)
                    Else
                        Call SaveLogs(applicationmodule.modAgents, "Agents", "Updated Agent : " & Me.txtlname.Text & " " & Me.txtfname.Text & " " & Me.txtmi.Text)
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

    Private Sub pctrSearchUpline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrSearchUpline.Click
        Dim f As New frmSearchEngine
        f.searchstatus = frmSearchEngine.searchmodule.searchagent
        f.ShowDialog()
        If f.issave Then
            If f.mkey = Me.agentid Then
                CustommsgBox(msgstyle.warning, msgtype.okonly, "Agent Library", "Cannot set upline to itself. Please select other agent.")
            Else
                Me.position = f.position + 1
                Me.uplineid = f.mkey
                Me.txtuplinename.Text = f.mvalue
                Call LoadPosition()
                seterror(panelupline)
            End If
        End If
        f.Dispose()
    End Sub

    Private Sub chkisbroker_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkisbroker.CheckedChanged
        If Me.chkisbroker.Checked Then
            Me.lblupline.Visible = False
            Me.panelupline.Visible = False
            Me.lblposition.Location = New Point(56, 530)
            Me.panelposition.Location = New Point(58, 545)
            Me.btnpositive.Location = New Point(346, 581)
            Me.Panel2.Size = New Size(434, 624)
            Me.Size = New Size(442, 671)
            Me.txtposition.Text = "Real Estate Broker (Top Level)"
        Else
            Me.lblupline.Visible = True
            Me.panelupline.Visible = True
            Me.lblposition.Location = New Point(56, 581)
            Me.panelposition.Location = New Point(58, 600)
            Me.btnpositive.Location = New Point(346, 643)
            Me.Panel2.Size = New Size(434, 686)
            Me.Size = New Size(442, 733)
            Call LoadPosition()
        End If
    End Sub
End Class