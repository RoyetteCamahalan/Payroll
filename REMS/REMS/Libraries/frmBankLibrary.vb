Public Class frmBankLibrary

    Private Sub frmBankLibrary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call PaintForm()
        Call EnableFields()
        If myformstatus <> formstatus.add Then
            Call LoadRecord()
        End If
    End Sub

#Region "Variables"
    Dim erp As New ErrorProvider
    Public issave As Boolean
    Public bankid As Integer
    Public bankname As String
    Public myformstatus As formstatus
    Enum formstatus
        add = 0
        edit = 1
        view = 2
    End Enum
#End Region

#Region "Methods"
    Private Sub LoadRecord()
        Me.txtbankname.Text = bankname
    End Sub
    Public Sub EnableFields()
        If Me.myformstatus = formstatus.view Then
            Me.txtbankname.Enabled = False
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
        If Trim(Me.txtbankname.Text) = "" Then
            isvalid = False
            seterror(panelbank, "This field is required!")
        Else
            seterror(panelbank)
            If Me.bankname <> Me.txtbankname.Text Then
                If clsPayment.Fetch(3, Me.txtbankname.Text).Rows.Count > 0 Then
                    isvalid = False
                    seterror(panelbank, "Bank Name already exist")
                Else
                    seterror(panelbank)
                End If
            End If

        End If
        Return isvalid
    End Function
    Private Sub Save()
        If isallfieldvalid() Then
            If CustommsgBox(msgstyle.info, msgtype.yesno, "Bank", "Are you sure you want to save this information?") Then
                Dim x As New clsPayment
                x.bankid = Me.bankid
                x.bankname = Me.txtbankname.Text
                If Me.myformstatus = formstatus.add Then
                    Me.bankid = x.SaveBankandAccount(True, 0)
                Else
                    Me.bankid = x.SaveBankandAccount(False, 0)
                End If
                If bankid > 0 Then
                    If Me.myformstatus = formstatus.add Then
                        Call SaveLogs(applicationmodule.modPayment, "Bank", "Added New Bank : " & Me.txtbankname.Text)
                    Else
                        Call SaveLogs(applicationmodule.modPayment, "Bank", "Updated Bank : " & Me.txtbankname.Text)
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