Public Class frmDefaultCommissionLibrary

    Private Sub frmDefaultCommissionLibrary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call PaintForm()
        Call EnableFields()
        Call LoadRecord()
    End Sub

#Region "Variables"
    Dim erp As New ErrorProvider
    Public issave As Boolean
    Public agentid As Integer
    Public myformstatus As formstatus
    Enum formstatus
        add = 0
        edit = 1
        view = 2
    End Enum
#End Region

#Region "Methods"
    Private Sub LoadRecord()
        With dgvmain
            .DataSource = clsAgents.Fetch(3, Me.agentid)
            .Columns(0).Visible = False
            .Columns(1).ReadOnly = True
            .Columns(1).Width = 170
            .Columns(2).ReadOnly = True
            .Columns(2).Width = 175
            .Columns(3).Width = 120
        End With
    End Sub
    Public Sub EnableFields()
        If Me.myformstatus = formstatus.view Then
            Me.btnpositive.Visible = False
        End If
    End Sub
    Private Sub PaintForm()
        If Me.myformstatus = formstatus.add Then
            Me.BackColor = newcolor
            Me.btnpositive.BackColor = newcolor
        ElseIf myformstatus = formstatus.edit Then
            Me.BackColor = editcolor
            Me.btnpositive.BackColor = editcolor
        Else
            Me.BackColor = viewcolor
            Me.btnpositive.BackColor = viewcolor
        End If
    End Sub
    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then 'backspace
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub Save()
        If CustommsgBox(msgstyle.info, msgtype.yesno, "Commissions", "Are you sure you want to save this information?") Then
            clsAgents.DeleteTree(agentid)
            Dim x As New clsAgents
            For i As Integer = 0 To dgvmain.RowCount - 1
                x.agentid = Me.agentid
                x.uplineid = dgvmain.Rows(i).Cells(0).Value
                x.compercentage = CDbl(dgvmain.Rows(i).Cells(3).Value)
                x.SaveDefaultCommission()
            Next

            Call SaveLogs(applicationmodule.modAgents, "Agents", "Updated Default Commission for  " & Me.dgvmain.Rows(0).Cells(1).Value.ToString)
            Me.issave = True
            Me.Dispose()
        End If
    End Sub
#End Region

    Private Sub btnpositive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpositive.Click
        Call Save()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub dgvmain_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvmain.EditingControlShowing
        Try
            If dgvmain.CurrentCellAddress.X = 3 Then
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvmain_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvmain.CellValueChanged
        If e.RowIndex >= 0 And e.ColumnIndex = 3 Then
            If Me.dgvmain.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString = "" Then
                Me.dgvmain.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
            End If

            Dim total As Double = 0
            For i As Integer = 0 To dgvmain.RowCount - 1
                total += dgvmain.Rows(i).Cells(3).Value
            Next
            If total > 100 Then
                Me.dgvmain.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 100 - (total - Me.dgvmain.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            End If
        End If
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub dgvmain_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvmain.DataError
        If Not TypeOf (e.Exception) Is ConstraintException Then
            CustommsgBox(msgstyle.critical, msgtype.okonly, "Default Commission", "Input is not valid")
        End If

    End Sub
End Class