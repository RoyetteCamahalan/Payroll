Public Class frmEmployees


    Private Sub frmEmployees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgvmain.RowTemplate.Height = Default_Row_Height
        Call EnableFields()
        Call DisplayList()
    End Sub
#Region "Variables"
    Private btncol As Integer = 6
#End Region
#Region "Methods"
    Private Sub EnableFields()
        If Not Isadmin Then
            Me.btnNew.Visible = False
            Me.btnEdit.Visible = False
        End If
    End Sub
    Private Sub DisplayList()
        If Trim(Me.txtSearch.Text) = "" Then
            Me.lblshowing.Text = "Showing all results"
        Else
            Me.lblshowing.Text = "Showing results for '" & Me.txtSearch.Text & "'"
        End If
        With dgvmain
            .DataSource = clsEmployees.GetUsers(1, Me.txtSearch.Text)
            .Columns(0).HeaderText = "Employee #"
            .Columns(0).Width = 108
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).HeaderText = "Employee Name"
            .Columns(1).Width = 250
            .Columns(2).HeaderText = "Gender"
            .Columns(2).Width = 80
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).HeaderText = "Email"
            .Columns(3).Width = 180
            .Columns(4).HeaderText = "User Name"
            .Columns(4).Width = 180
            .Columns(5).HeaderText = "Is Active?"
            .Columns(5).Width = 100
            .Columns(6).HeaderText = ""
            .Columns(6).Width = 100
            .Columns(7).Visible = False
        End With
    End Sub
   
#End Region
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim femp As New frmEmployeeLibrary
        femp.myformstatus = frmEmployeeLibrary.formstatus.add
        femp.ShowDialog()
        If femp.issave Then
            Call DisplayList()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Call DisplayList()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Call DisplayList()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If dgvmain.CurrentRow.Index >= 0 Then
            Dim femp As New frmEmployeeLibrary
            femp.myformstatus = frmEmployeeLibrary.formstatus.edit
            femp.employeeid = Me.dgvmain.CurrentRow.Cells("employeeid").Value
            femp.ShowDialog()
            If femp.issave Then
                Call DisplayList()
            End If
        End If

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If dgvmain.CurrentRow.Index >= 0 Then
            Dim femp As New frmEmployeeLibrary
            femp.myformstatus = frmEmployeeLibrary.formstatus.view
            femp.employeeid = Me.dgvmain.CurrentRow.Cells("employeeid").Value
            femp.ShowDialog()
        End If

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
                Dim f As New frmModuleLibrary
                f.employeeid = dgvmain.Rows(myRow).Cells("employeeid").Value
                f.employeename = dgvmain.Rows(myRow).Cells(1).Value
                f.isemployeeadmin = dgvmain.Rows(myRow).Cells("isappsysadmin").Value
                f.myformstatus = frmModuleLibrary.formstatus.edit
                f.ShowDialog()
                If f.issave Then
                    Call DisplayList()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class