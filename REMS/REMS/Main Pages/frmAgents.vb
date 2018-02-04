Public Class frmAllAgents


    Private Sub frmAgents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgvmain.RowTemplate.Height = Default_Row_Height
        Call DisplayList()
    End Sub

#Region "Variables"
    Private btncol As Integer = 8
#End Region
#Region "Methods"
    Private Sub DisplayList()
        With dgvmain
            .DataSource = clsAgents.Fetch(0, Me.txtSearch.Text)
            .Columns(0).HeaderText = "Agent #"
            .Columns(0).Width = 108
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).HeaderText = "Last Name"
            .Columns(1).Width = 120
            .Columns(2).HeaderText = "First Name"
            .Columns(2).Width = 120
            .Columns(3).HeaderText = "MI"
            .Columns(3).Width = 60
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).HeaderText = "Contact #"
            .Columns(4).Width = 120
            .Columns(5).HeaderText = "Position"
            .Columns(5).Width = 180
            .Columns(6).HeaderText = "Upline"
            .Columns(6).Width = 160
            .Columns(7).Visible = False
            .Columns(8).HeaderText = "Action"
            .Columns(8).Width = 130
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(9).Visible = False
            .Columns(10).Visible = False
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
        Dim f As New frmAgentLibrary
        f.myformstatus = frmAgentLibrary.formstatus.add
        f.ShowDialog()
        If f.issave Then
            Call DisplayList()
            Call ShowDefaultCommission(f.agentid)
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
                Dim f As New frmAgentLibrary
                f.agentid = Me.dgvmain.CurrentRow.Cells("AGENTID").Value
                f.myformstatus = frmAgentLibrary.formstatus.view
                f.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvmain_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgvmain.DataBindingComplete
        For i As Integer = 0 To dgvmain.Rows.Count - 1
            If (dgvmain.Rows(i).Cells("totalcomset").Value > 0) Then
                dgvmain.Rows(i).Cells(btncol).Style.BackColor = Color.MediumSeaGreen
            Else
                dgvmain.Rows(i).Cells(btncol).Style.BackColor = Color.YellowGreen
            End If
        Next
    End Sub

    Private Sub dgvmain_CellMouseEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvmain.CellMouseEnter
        Try
            Dim myRow As Integer = e.RowIndex
            Dim myCol As Integer = e.ColumnIndex
            If myCol = btncol And myRow <> -1 Then
                dgvmain.Rows(myRow).Cells(myCol).Style.ForeColor = Color.Red
                Dim f = New Font("Arial", 10, FontStyle.Underline)
                dgvmain.Rows(myRow).Cells(myCol).Style.Font = f
                dgvmain.Cursor = Cursors.Hand
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvmain_CellMouseLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvmain.CellMouseLeave
        Try
            Dim myRow As Integer = e.RowIndex
            Dim myCol As Integer = e.ColumnIndex
            If myCol = btncol And myRow <> -1 Then
                dgvmain.Rows(myRow).Cells(myCol).Style.ForeColor = Color.Black
                Dim f = New Font("Arial", 9, FontStyle.Regular)
                dgvmain.Rows(myRow).Cells(myCol).Style.Font = f
                dgvmain.Cursor = Cursors.Arrow
                'MsgBox("underline")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvmain_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvmain.CellContentClick
        Try
            Dim myRow As Integer = dgvmain.CurrentRow.Index
            Dim myCol As Integer = dgvmain.CurrentCell.ColumnIndex
            If myCol = btncol And myRow <> -1 Then
                Dim f As New frmDefaultCommissionLibrary
                f.agentid = dgvmain.Rows(myRow).Cells("AGENTID").Value
                f.myformstatus = frmDefaultCommissionLibrary.formstatus.edit
                f.ShowDialog()
                If f.issave Then
                    Call DisplayList()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class