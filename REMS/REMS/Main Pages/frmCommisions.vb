Public Class frmCommisions


    Private Sub frmCommisions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgvmain.RowTemplate.Height = Default_Row_Height
        Call DisplayList()
    End Sub

#Region "Variables"
    Private btncol As Integer = 8
#End Region
#Region "Methods"
    Private Sub DisplayList()
        With dgvmain
            .DataSource = clsCommissions.fetch(2, Me.txtSearch.Text)
            .Columns(0).HeaderText = "Voucher #"
            .Columns(0).Width = 138
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).HeaderText = "Voucher Date"
            .Columns(1).Width = 140
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).HeaderText = "Agent Name"
            .Columns(2).Width = 210
            .Columns(3).HeaderText = "Encoded By"
            .Columns(3).Width = 220
            .Columns(4).HeaderText = "Amount"
            .Columns(4).Width = 200
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).HeaderText = "Is Printed"
            .Columns(5).Width = 70
        End With
        Me.lblshowing.Text = "Showing top " & dgvmain.RowCount & " result(s)"
    End Sub
    Private Sub ShowDefaultCommission(ByRef id As Long)

    End Sub
#End Region

    Private Sub txtSearch_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyData = Keys.Enter Then
            DisplayList()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        DisplayList()
    End Sub

    Private Sub txtSearch_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.Leave
        If Trim(Me.txtSearch.Text) = "" Then
            DisplayList()
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim f As New frmCommissionLibrary
        f.myCurrentFormStatus = frmCommissionLibrary.enFormStatus.add
        f.ShowDialog()
        If f.issave Then
            Call DisplayList()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If dgvmain.CurrentRow.Index >= 0 Then
                Dim f As New frmAgentLibrary
                f.agentid = Me.dgvmain.CurrentRow.Cells("AGENTID").Value
                f.myformstatus = frmAgentLibrary.formstatus.edit
                f.ShowDialog()
                If f.issave Then
                    Call DisplayList()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try
            If dgvmain.CurrentRow.Index >= 0 Then
                If clsCommissions.PrintVoucher(Me.dgvmain.CurrentRow.Cells("VOUCHERNO").Value) Then
                    Call DisplayList()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click
        Try
            If dgvmain.CurrentRow.Index >= 0 Then
                Dim f As New frmCommissionOptions
                f.mvoucherno = Me.dgvmain.CurrentRow.Cells("VOUCHERNO").Value
                f.ShowDialog()
                If f.issave Then
                    Call DisplayList()
                End If

            End If
        Catch ex As Exception

        End Try

    End Sub
End Class