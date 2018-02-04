Public Class frmPropertyLibrary

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
    Public propertyid As Integer
    Public myformstatus As formstatus
    Enum formstatus
        add = 0
        edit = 1
        view = 2
    End Enum
#End Region

#Region "Methods"
    Private Sub LoadRecord()
        Dim dtRecord As DataTable = clsProperty.Fetch(3, Me.propertyid)
        Me.txtpropertyname.Text = dtRecord.Rows(0).Item("PROPERTYNAME")
        Me.txtaddress.Text = dtRecord.Rows(0).Item("ADDRESS")
        Me.txtarea.Text = dtRecord.Rows(0).Item("AREA")
    End Sub
    Public Sub EnableFields()
        If Me.myformstatus = formstatus.view Then
            Me.txtpropertyname.Enabled = False
            Me.txtarea.Enabled = False
            Me.txtaddress.Enabled = False
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
            Me.lblTitle.Text = "Edit Property"
        Else
            Me.BackColor = viewcolor
            Me.btnpositive.BackColor = viewcolor
            Me.lblTitle.Text = "View Property"
        End If
    End Sub
    Private Sub seterror(ByRef ctr As Control, Optional ByRef msg As String = "")
        erp.SetError(ctr, msg)
    End Sub
    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True
        If Trim(Me.txtpropertyname.Text) = "" Then
            isvalid = False
            seterror(panelproperty, "This field is required!")
        Else
            seterror(panelproperty)
        End If
        Return isvalid
    End Function
    Private Sub Save()
        If isallfieldvalid() Then
            If CustommsgBox(msgstyle.info, msgtype.yesno, "Property", "Are you sure you want to save this information?") Then
                Dim x As New clsProperty
                x.propertyid = Me.propertyid
                x.propertyname = Me.txtpropertyname.Text
                x.address = Me.txtaddress.Text
                x.area = CDbl(IIf(Trim(Me.txtarea.Text) = "", 0, Me.txtarea.Text))
                If Me.myformstatus = formstatus.add Then
                    Me.propertyid = x.SaveProperty(True)
                Else
                    Me.propertyid = x.SaveProperty(False)
                End If
                If propertyid > 0 Then
                    If Me.myformstatus = formstatus.add Then
                        Call SaveLogs(applicationmodule.modProperties, "Property", "Added New Property : " & Me.txtpropertyname.Text)
                    Else
                        Call SaveLogs(applicationmodule.modProperties, "Property", "Updated Property : " & Me.txtpropertyname.Text)
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

    Private Sub txtarea_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtarea.KeyPress
        If IsNumeric(txtarea.Text + e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class