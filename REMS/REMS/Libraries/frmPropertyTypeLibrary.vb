Public Class frmPropertyTypeLibrary

    Private Sub frmCustomerLibrary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call PaintForm()
        Call EnableFields()
        Me.cmbCategory.SelectedIndex = 0
        If myformstatus <> formstatus.add Then
            Call LoadRecord()
        End If
    End Sub

#Region "Variables"
    Dim erp As New ErrorProvider
    Public issave As Boolean
    Public propertyid As Integer
    Public typeid As Integer
    Public typename As String = ""
    Public typecategory As Integer = 0
    Public myformstatus As formstatus
    Enum formstatus
        add = 0
        edit = 1
        view = 2
    End Enum
#End Region

#Region "Methods"
    Private Sub LoadRecord()
        Me.txttypename.Text = typename
        Me.cmbCategory.SelectedIndex = Me.typecategory
    End Sub
    Public Sub EnableFields()
        If Me.myformstatus = formstatus.view Then
            Me.txttypename.Enabled = False
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
            Me.lblTitle.Text = "Edit Lot Type"
        Else
            Me.BackColor = viewcolor
            Me.btnpositive.BackColor = viewcolor
            Me.lblTitle.Text = "View Lot Type"
        End If
    End Sub
    Private Sub seterror(ByRef ctr As Control, Optional ByRef msg As String = "")
        erp.SetError(ctr, msg)
    End Sub
    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True
        If Trim(Me.txttypename.Text) = "" Then
            isvalid = False
            seterror(paneltypename, "This field is required!")
        Else
            seterror(paneltypename)
            If typename.ToLower <> Me.txttypename.Text.ToLower Then
                If clsProperty.Fetch(6, Me.txttypename.Text, propertyid).Rows.Count > 0 Then
                    isvalid = False
                    seterror(paneltypename, "Type/Model already exist!")
                Else
                    seterror(paneltypename)
                End If
            End If

        End If
        Return isvalid
    End Function
    Private Sub Save()
        If isallfieldvalid() Then
            If CustommsgBox(msgstyle.info, msgtype.yesno, "Lot Type", "Are you sure you want to save this information?") Then
                Dim x As New clsProperty
                x.lottypeid = Me.typeid
                x.propertyid = Me.propertyid
                x.lotypename = Me.txttypename.Text
                x.lotcategory = Me.cmbCategory.SelectedIndex
                If Me.myformstatus = formstatus.add Then
                    Me.typeid = x.SaveLotType(True)
                Else
                    Me.typeid = x.SaveLotType(False)
                End If
                If typeid > 0 Then
                    If Me.myformstatus = formstatus.add Then
                        Call SaveLogs(applicationmodule.modProperties, "Lot Types", "Added New Lot Type : " & Me.txttypename.Text)
                    Else
                        Call SaveLogs(applicationmodule.modProperties, "Lot Type", "Updated Lot Type : " & Me.txttypename.Text)
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