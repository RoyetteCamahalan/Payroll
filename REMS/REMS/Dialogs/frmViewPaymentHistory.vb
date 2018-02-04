Public Class frmViewPaymentHistory

    Private Sub frmViewPaymentHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

#Region "Variables"
    Dim erp As New ErrorProvider
    Public issave As Boolean
    Public mInvoiceno, mLotID As Long
    Public mLotName As String
#End Region

#Region "Methods"
    Private Sub DisplayList()

    End Sub
    Private Sub PerformAction(Optional ByRef iswaive As Boolean = False)
        Dim f As New frmOverride
        f.mmoduleid = applicationmodule.modPayment
        f.ShowDialog()
        If f.isoverride Then

        Else
            CustommsgBox(msgstyle.critical, msgtype.okonly, "Payments", "Waiving/Unwaiving Interest Failed")
        End If
    End Sub
#End Region

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub


    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Call clsPayment.PrintPaymentHistory(mInvoiceno, mLotID, mLotName)
    End Sub

    Private Sub btnWaive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWaive.Click
        If Me.btnWaive.Text = "Waive Interest" Then

            Me.btnWaive.Text = "Unwaive Interest"
        ElseIf Me.btnWaive.Text = "Unwaive Interest" Then

            Me.btnWaive.Text = "Waive Interest"
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Call clsMain.RefreshHistory(mInvoiceno, mLotID)
        Call DisplayList()
    End Sub
End Class