Public Class frmForfeitLot
    Private Sub frmForfeitLot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call PaintForm()
        Me.dtpdateforfeited.MaxDate = Utility.GetServerDate
    End Sub

#Region "Variables"
    Dim erp As New ErrorProvider
    Public issave As Boolean
    Public invoiceno As Long
    Public lotid, overrideby As Long
#End Region

#Region "Methods"
    Private Sub PaintForm()
        Me.BackColor = editcolor
        Me.btnpositive.BackColor = editcolor
    End Sub
    Private Sub seterror(ByRef ctr As Control, Optional ByRef msg As String = "")
        erp.SetError(ctr, msg)
    End Sub
    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True
        If Trim(Me.txtreason.Text) = "" Then
            isvalid = False
            seterror(panelReason, "This field is required!")
        Else
            seterror(panelReason)
        End If

        If chkrefund.Checked Then
            If Trim(Me.txtrefundamount.Text) = "" Then
                isvalid = False
                seterror(panelrefundamount, "This field is required!")
            Else
                seterror(panelrefundamount)
            End If
            If Trim(Me.txtreceivedby.Text) = "" Then
                isvalid = False
                seterror(panelreceivedby, "This field is required!")
            Else
                seterror(panelreceivedby)
            End If
        End If
        Return isvalid
    End Function
    Private Sub Save()
        If isallfieldvalid() Then
            If CustommsgBox(msgstyle.critical, msgtype.yesno, "Forfeit Lot", "Are you sure you want to forfeit this lot?") Then
                Dim x As New clsMain
                x.invoiceno = Me.invoiceno
                x.lotid = Me.lotid
                x.reason = Me.txtreason.Text
                x.dateforfeited = Me.dtpdateforfeited.Value.ToShortDateString
                x.overrideby = Me.overrideby
                x.refundamount = CDbl(Me.txtrefundamount.Text)
                x.receivedby = Me.txtreceivedby.Text
                x.isrefund = Me.chkrefund.Checked
                x.ForfeitLot()
                Me.issave = True
                Me.Close()
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

    Private Sub txtcom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrefundamount.KeyPress
        If IsNumeric(sender.Text + e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtarea_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrefundamount.Leave
        Try
            CType(sender, TextBox).Text = CDbl(sender.Text).ToString("N2")
        Catch ex As Exception
            sender.Text = "0"
        End Try
    End Sub

    Private Sub chkrefund_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkrefund.CheckedChanged
        If Me.chkrefund.Checked Then
            Me.panelreceivedby.Enabled = True
            Me.panelrefundamount.Enabled = True
        Else
            Me.panelreceivedby.Enabled = False
            Me.panelrefundamount.Enabled = False
            Me.txtreceivedby.Text = ""
            Me.txtrefundamount.Text = ""
        End If
    End Sub
End Class