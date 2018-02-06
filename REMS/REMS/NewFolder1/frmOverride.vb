Public Class frmOverride

#Region "Variables"
    Private fontcolor As Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
    Private hintcolor As Color = Color.DarkGray
    Dim erp As New ErrorProvider
    ''hints
    Private unamehint As String = "Username"
    Private pwordhint As String = "Password"
    Public isoverride As Boolean = False
    Public mmoduleid As Integer
    Public moverrideby As Long
#End Region
#Region "Methods"
    Private Sub seterror(ByRef ctr As Control, Optional ByRef msg As String = "")
        erp.SetError(ctr, msg)
    End Sub
    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True
        If txtUsername.Text = unamehint Then
            isvalid = False
            seterror(panelusername, "This field is required!")
        Else
            seterror(panelusername)
        End If
        If txtpassword.Text = pwordhint Then
            isvalid = False
            seterror(panelpassword, "This field is required!")
        Else
            seterror(panelpassword)
        End If
        Return isvalid
    End Function

#End Region

    Private Sub txtUsername_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.Enter
        With Me.txtUsername
            If .Text = unamehint Then
                .Text = ""
                .ForeColor = Me.fontcolor
            End If
        End With
    End Sub

    Private Sub txtUsername_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.Leave
        With Me.txtUsername
            If Trim(.Text) = "" Then
                .Text = unamehint
                .ForeColor = Me.hintcolor
            End If
        End With
    End Sub

    Private Sub txtpassword_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.Enter
        Me.txtpassword.UseSystemPasswordChar = True
        With Me.txtpassword
            If .Text = pwordhint Then
                .Text = ""
                .ForeColor = Me.fontcolor
            End If
        End With
    End Sub

    Private Sub txtpassword_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.Leave
        With Me.txtpassword
            If .Text = "" Then
                .Text = pwordhint
                .ForeColor = Me.hintcolor
                Me.txtpassword.UseSystemPasswordChar = False
            End If
        End With
    End Sub

    Private Sub btnSignin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignin.Click

    End Sub

End Class