Public Class Report

#Region "Variables"
    Private agentcomid As Long

#End Region
#Region "Methods"
    Private Sub DisplayVouchers()
    End Sub
#End Region
    Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_choose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim fselectagent As New Selection_Agent
        'fselectagent.requestCode = 2
        'fselectagent.ShowDialog()
        'If agentcomid > 0 Then
        '    DisplayVouchers()
        'End If
        'fselectagent.Dispose()
    End Sub

    Private Sub pctr_searchagent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctr_searchagent.Click
        'Dim fsearch As New Selection_Agent
        'fsearch.ShowDialog()
        'If fsearch.issave Then
        '    Me.agentcomid = fsearch.Agent_ID
        '    Me.txt_agent.Text = fsearch.agentName
        'End If
        'fsearch.Dispose()
    End Sub
End Class