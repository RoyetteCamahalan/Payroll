Public Class frmCommissionOptions
    Private Sub frmCommissionOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetInfo()
        Call InitForm()
    End Sub

#Region "Variables"
    Dim erp As New ErrorProvider
    Private dtLotType As DataTable
    Private magentid As Long = 0
    Public misprinted, mstatus As Boolean
    Public mvoucherno As Long
    Public issave As Boolean
#End Region

#Region "Methods"
    Public Sub setTitle(ByRef mtitle As String)
        Me.lblTitle.Text = mtitle
    End Sub
    Sub InitForm()
        If misprinted Then
            Me.btnMarkPrinted.Enabled = False
        End If
    End Sub
    Sub GetInfo()
        Dim dt As DataTable = clsCommissions.fetch(4, mvoucherno)
        misprinted = dt.Rows(0).Item("isprinted")
    End Sub
#End Region

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If clsCommissions.PrintVoucher(mvoucherno) Then
            Me.btnMarkPrinted.Enabled = False
            Me.issave = True
        End If
        Me.Close()
    End Sub

    Private Sub btnMarkPrinted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkPrinted.Click
        If CustommsgBox(msgstyle.warning, msgtype.yesno, "Mark as Printed", "Are you sure youwant to mark this as printed?") Then
            Call clsCommissions.setPrinted(mvoucherno)
            Me.btnMarkPrinted.Enabled = True
            Me.issave = True
            Me.Close()
        End If
    End Sub

    Private Sub btnVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoid.Click
        Me.Close()
    End Sub
End Class