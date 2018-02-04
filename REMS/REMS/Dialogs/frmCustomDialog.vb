Public Class frmCustomDialog
    Private Sub frmCustomDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call InitForm()
    End Sub

#Region "Variables"
    Dim erp As New ErrorProvider
    Private dtLotType As DataTable
    Private magentid As Long = 0
    Public myformstatus As formstatus
    Enum formstatus
        MonthsDue = 0
    End Enum
#End Region

#Region "Methods"
    Public Sub setTitle(ByRef mtitle As String)
        Me.lblTitle.Text = mtitle
    End Sub
    Sub InitForm()
        Select Case myformstatus
            Case formstatus.MonthsDue
                Me.cmbMonthsDue.SelectedIndex = 0
        End Select
    End Sub
#End Region

    Private Sub btnpositive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpositive.Click
        Select Case myformstatus
            Case formstatus.MonthsDue
                clsReports.PrintDueCollectables(Me.cmbMonthsDue.SelectedIndex + 1, magentid)
                Me.Dispose()
        End Select
    End Sub

    Private Sub pctrSearchAgent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrSearchAgent.Click
        Dim f As New frmSearchEngine
        f.searchstatus = frmSearchEngine.searchmodule.searchagentwithall
        f.ShowDialog()
        If f.issave Then
            Me.magentid = f.mkey
            Me.txtAgent.Text = f.mvalue
        End If
        f.Dispose()
    End Sub
End Class