Public Class frmModuleLibrary

    Private Sub frmModuleLibraryy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call PaintForm()
        If myformstatus <> formstatus.add Then
            Call LoadRecord()
        End If
    End Sub

#Region "Variables"
    Dim erp As New ErrorProvider
    Public issave As Boolean
    Public employeeid As Integer
    Public employeename As String
    Public isemployeeadmin As Boolean
    Private oldpword As String
    Public myformstatus As formstatus
    Enum formstatus
        add = 0
        edit = 1
        view = 2
    End Enum
#End Region

#Region "Methods"
    Private Sub LoadRecord()
        dtgv_header.Rows.Add(0, "User Main Modules", 0, 0, 0)
        If Me.isemployeeadmin Then
            dtgvModules.Enabled = False
            dtgv_header.Enabled = False
            Me.dtgvModules.DataSource = clsEmployees.GetUsers(4, Me.employeeid)
        Else
            Me.dtgvModules.DataSource = clsEmployees.GetUsers(3, Me.employeeid)
        End If
        With dtgvModules
            .Columns("moduleid").Visible = False
            .Columns("selectall").Width = 100
            .Columns("modulename").Width = 237
            .Columns("canadd").Width = 100
            .Columns("canedit").Width = 100
            .Columns("canview").Width = 100
            .Columns("userprivid").Visible = False
        End With
    End Sub
    Private Sub PaintForm()
        Me.lblTitle.Text = Me.employeename & " - User Privileges"
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
    Private Sub seterror(ByRef ctr As Control, Optional ByRef msg As String = "")
        erp.SetError(ctr, msg)
    End Sub
    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True
        
        Return isvalid
    End Function
    Private Sub Save()
        If isallfieldvalid() Then
            If CustommsgBox(msgstyle.info, msgtype.yesno, "Employee", "Are you sure you want to save this information?") Then
                Dim x As New clsEmployees
                x.employeeid = employeeid
                For i As Integer = 0 To dtgvModules.RowCount - 1
                    x.userprivid = dtgvModules.Rows(i).Cells("userprivid").Value
                    x.moduleid = dtgvModules.Rows(i).Cells("moduleid").Value
                    x.canadd = dtgvModules.Rows(i).Cells("canadd").Value
                    x.canedit = dtgvModules.Rows(i).Cells("canedit").Value
                    x.canview = dtgvModules.Rows(i).Cells("canview").Value
                    If x.userprivid = 0 Then
                        x.SavePrivileges(True)
                    Else
                        x.SavePrivileges(False)
                    End If
                Next
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

    Private Sub dtgv_header_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgv_header.CellContentClick
        If e.RowIndex = 0 And e.ColumnIndex <> 1 And e.ColumnIndex >= 0 Then
            dtgv_header.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dtgv_header_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgv_header.CellValueChanged
        If e.RowIndex = 0 Then
            If e.ColumnIndex = dtgvModules.Columns("selectall").Index - 1 Then
                If dtgv_header.Rows(0).Cells(0).Value = True Then
                    For i As Integer = 0 To dtgvModules.Rows.Count - 1
                        dtgvModules.Rows(i).Cells("selectall").Value = True
                    Next
                End If
            ElseIf e.ColumnIndex <> dtgvModules.Columns("modulename").Index - 1 And dtgv_header.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True Then
                For i As Integer = 0 To dtgvModules.Rows.Count - 1
                    If dtgvModules.Rows(i).Cells("selectall").Value = True Then
                        dtgvModules.Rows(i).Cells(e.ColumnIndex + 1).Value = True
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub dtgvModules_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvModules.CellContentClick
        If e.RowIndex >= 0 And e.ColumnIndex <> 2 And e.ColumnIndex >= 0 Then
            dtgvModules.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dtgvModules_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvModules.CellValueChanged
        If e.ColumnIndex = 1 Then
            If dtgvModules.Rows(e.RowIndex).Cells("selectall").Value = False Then
                For i As Integer = 3 To dtgvModules.Columns.Count - 2
                    dtgvModules.Rows(e.RowIndex).Cells(i).Value = False
                    dtgvModules.Rows(e.RowIndex).Cells(i).ReadOnly = True
                Next
                dtgv_header.Rows(0).Cells(0).Value = False
            Else
                For i As Integer = 3 To dtgvModules.Columns.Count - 2
                    dtgvModules.Rows(e.RowIndex).Cells(i).ReadOnly = False
                Next
            End If
        End If
    End Sub

    Private Sub dtgvModules_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dtgvModules.RowsAdded
        For j As Integer = 3 To dtgvModules.Columns.Count - 2
            dtgvModules.Rows(e.RowIndex).Cells(j).ReadOnly = Not dtgvModules.Rows(e.RowIndex).Cells("selectall").Value
        Next
    End Sub
End Class