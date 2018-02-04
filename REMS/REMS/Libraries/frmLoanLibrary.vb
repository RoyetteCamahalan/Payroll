Public Class frmLoanLibrary

    Private Sub frmLoanLibrary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call PaintForm()
        Call EnableFields()
        If myformstatus <> formstatus.add Then
            Call LoadRecord()
        End If
    End Sub

#Region "Variables"
    Dim erp As New ErrorProvider
    Public issave As Boolean
    Public intitutionid As Integer
    Public institutionname As String
    Public isactive As Boolean
    Public myformstatus As formstatus
    Enum formstatus
        add = 0
        edit = 1
        view = 2
    End Enum
#End Region

#Region "Methods"
    Private Sub LoadRecord()
        Me.txtinstitutionname.Text = institutionname
        Me.chkisactive.Checked = isactive
    End Sub
    Public Sub EnableFields()
        If Me.myformstatus = formstatus.view Then
            Me.txtinstitutionname.Enabled = False
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
            Me.lblTitle.Text = "Edit Bank"
        Else
            Me.BackColor = viewcolor
            Me.btnpositive.BackColor = viewcolor
            Me.lblTitle.Text = "View Bank"
        End If
    End Sub
    Private Sub seterror(ByRef ctr As Control, Optional ByRef msg As String = "")
        erp.SetError(ctr, msg)
    End Sub
    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True
        If Trim(Me.txtinstitutionname.Text) = "" Then
            isvalid = False
            seterror(panelinstitution, "This field is required!")
        Else
            seterror(panelinstitution)
            If Me.institutionname <> Me.txtinstitutionname.Text Then
                If clsPayment.Fetch(14, Me.txtinstitutionname.Text).Rows.Count > 0 Then
                    isvalid = False
                    seterror(panelinstitution, "Institution Name already exist")
                Else
                    seterror(panelinstitution)
                End If
            End If

        End If
        Return isvalid
    End Function
    Private Sub Save()
        If isallfieldvalid() Then
            If CustommsgBox(msgstyle.info, msgtype.yesno, "Bank", "Are you sure you want to save this information?") Then
                Dim x As New clsPayment
                x.institutionid = Me.intitutionid
                x.institutionname = Me.txtinstitutionname.Text
                x.isactive = Me.chkisactive.Checked
                If Me.myformstatus = formstatus.add Then
                    Me.intitutionid = x.SaveLoanProvider(True, 9)
                Else
                    Me.intitutionid = x.SaveLoanProvider(False, 2)
                End If
                If intitutionid > 0 Then
                    If Me.myformstatus = formstatus.add Then
                        Call SaveLogs(applicationmodule.modPayment, "Loan Provider", "Added New Loan Provider : " & Me.txtinstitutionname.Text)
                    Else
                        Call SaveLogs(applicationmodule.modPayment, "Loan Provider", "Updated Loan Provider : " & Me.txtinstitutionname.Text)
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