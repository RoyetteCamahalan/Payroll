Public Class frmmsgbox

    Private Sub frmmsgbox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblTitle.Text = mtitle
        Me.lblmsg.Text = mdescription
        Call PaintBox()
    End Sub
#Region "Variables"
    Public mtitle, mdescription As String
    Public response As Boolean
    
#End Region
#Region "Methods"
    Private Sub PaintBox()
        If mymsgstyle = msgstyle.warning Then
            Me.btnnegative.BackColor = Color.Goldenrod
            Me.btnpositive.BackColor = Color.Goldenrod
            Me.BackColor = Color.Goldenrod
        ElseIf mymsgstyle = msgstyle.critical Then
            Me.btnnegative.BackColor = Color.Firebrick
            Me.btnpositive.BackColor = Color.Firebrick
            Me.BackColor = Color.Firebrick
        Else
            Me.btnnegative.BackColor = Color.SteelBlue
            Me.btnpositive.BackColor = Color.SteelBlue
            Me.BackColor = Color.SteelBlue
        End If
        If mymsgtype = msgtype.okcancel Then
            Me.btnnegative.Text = "Cancel"
            Me.btnpositive.Text = "OK"
        ElseIf mymsgtype = msgtype.yesno Then
            Me.btnnegative.Text = "No"
            Me.btnpositive.Text = "Yes"
        Else
            Me.btnnegative.Visible = False
            Me.btnpositive.Text = "OK"
        End If
    End Sub
#End Region

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnpositive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpositive.Click
        response = True
        Me.Close()
    End Sub

    Private Sub btnnegative_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnegative.Click
        Me.Close()
    End Sub
End Class