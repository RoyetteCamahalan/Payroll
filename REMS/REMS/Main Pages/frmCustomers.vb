Public Class frmCustomers

    Private Sub frmCustomers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgvmain.RowTemplate.Height = Default_Row_Height
        Call DisplayList()
    End Sub


#Region "Methods"
    Private Sub DisplayList()
        If Trim(Me.txtSearch.Text) = "" Then
            Me.lblshowing.Text = "Showing top 100 results"
        Else
            Me.lblshowing.Text = "Showing top 100 results for '" & Me.txtSearch.Text & "'"
        End If
        With dgvmain
            .DataSource = clsCustomers.Fetch(0, Me.txtSearch.Text)
            .Columns(0).HeaderText = "Customer #"
            .Columns(0).Width = 108
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).HeaderText = "Last Name"
            .Columns(1).Width = 120
            .Columns(2).HeaderText = "First Name"
            .Columns(2).Width = 120
            .Columns(3).HeaderText = "MI"
            .Columns(3).Width = 110
            .Columns(4).HeaderText = "Birth Date"
            .Columns(4).Width = 120
            .Columns(5).HeaderText = "Address"
            .Columns(5).Width = 220
            .Columns(6).HeaderText = "Contact #"
            .Columns(6).Width = 100
            .Columns(7).HeaderText = "Tin #."
            .Columns(7).Width = 100
        End With
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
        Dim f As New frmCustomerLibrary
        f.myformstatus = frmCustomerLibrary.formstatus.add
        f.ShowDialog()
        If f.issave Then
            Call DisplayList()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If dgvmain.CurrentRow.Index >= 0 Then
            Dim f As New frmCustomerLibrary
            f.customerid = Me.dgvmain.CurrentRow.Cells("custid").Value
            f.myformstatus = frmCustomerLibrary.formstatus.edit
            f.ShowDialog()
            If f.issave Then
                Call DisplayList()
            End If
        End If

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If dgvmain.CurrentRow.Index >= 0 Then
            Dim f As New frmCustomerLibrary
            f.customerid = Me.dgvmain.CurrentRow.Cells("custid").Value
            f.myformstatus = frmCustomerLibrary.formstatus.view
            f.ShowDialog()
        End If

    End Sub
End Class