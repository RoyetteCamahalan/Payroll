Public Class frmSalesOptions
    Private Sub frmSalesOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

#Region "Variables"
    Dim erp As New ErrorProvider
    Public invoiceno, lotid As Long
    Public lotname As String
    Public issave As Boolean
    Public mmoduleid As Integer
#End Region

#Region "Methods"
    Public Sub setTitle(ByRef mtitle As String)
        Me.lblTitle.Text = mtitle
    End Sub
#End Region

    

    Private Sub btnVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshHistory.Click
        clsMain.RefreshHistory(invoiceno, lotid)
        Me.Dispose()
    End Sub

    Private Sub btnCancelwithRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelwithRefund.Click
        Dim f As New frmOverride
        f.mmoduleid = Me.mmoduleid
        f.ShowDialog()
        If f.isoverride Then
            Dim frm As New frmForfeitLot
            frm.lotid = Me.lotid
            frm.invoiceno = Me.invoiceno
            frm.overrideby = f.moverrideby
            frm.ShowDialog()
            Me.issave = frm.issave
            frm.Dispose()
        Else
            CustommsgBox(msgstyle.critical, msgtype.okonly, "Forfeit Lot", "Forfeit Override Failed")
        End If
        f.Dispose()
        If Me.issave Then
            Me.Close()
        End If
    End Sub

    Private Sub btnViewPayables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewPayables.Click
        Dim f As New frmViewPaymentHistory
        f.mInvoiceno = Me.invoiceno
        f.mLotID = Me.lotid
        f.mLotName = Me.lotname
        f.ShowDialog()
        f.Dispose()
        Me.Close()
    End Sub
End Class