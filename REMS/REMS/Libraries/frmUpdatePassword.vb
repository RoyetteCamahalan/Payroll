Public Class frmUpdatePassword

    Private Sub frmUpdatePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

#Region "Variables"
    Dim erp As New ErrorProvider
    Public issave As Boolean
#End Region

#Region "Methods"
    Private Sub seterror(ByRef ctr As Control, Optional ByRef msg As String = "")
        erp.SetError(ctr, msg)
    End Sub
    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True
        If Utility.GetHash(Me.txtoldpassword.Text) <> CurrentPassword Then
            isvalid = False
            seterror(paneloldpassword, "Incorrect Password")

        Else
            seterror(paneloldpassword)
        End If
        If Trim(Me.txtnewpword.Text = "") Then
            isvalid = False
            seterror(panelnewpword, "This field is required.")
        Else
            seterror(panelnewpword)
        End If
        If Trim(Me.txtconfirmpword.Text = "") Then
            isvalid = False
            seterror(panelconfirm, "This field is required.")
        Else
            seterror(panelconfirm)
        End If

        If txtconfirmpword.Text <> txtnewpword.Text Then
            isvalid = False
            seterror(Me.panelconfirm, "Password does not match!")
        End If
        Return isvalid
    End Function
    Private Sub Save()
        If isallfieldvalid() Then
            Dim x As New clsEmployees
            x.employeeid = Current_UserID
            x.password = Utility.GetHash(Me.txtnewpword.Text)
            If x.UpdateProfile(4) Then
                CurrentPassword = x.password
                CustommsgBox(msgstyle.info, msgtype.yesno, "Change Password", "Your password has been changed successfully.")
            End If
            Me.Dispose()
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