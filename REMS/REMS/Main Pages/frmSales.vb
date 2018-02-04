Public Class frmSales

    Private Sub frmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgvmain.RowTemplate.Height = Default_Row_Height
        Call DisplayList()
    End Sub
#Region "Variables"
    Private btncol As Integer = 0
#End Region

#Region "Methods"
    Private Sub DisplayList()
        If Trim(Me.txtSearch.Text) = "" Then
            Me.lblshowing.Text = "Showing top 100 results"
        Else
            Me.lblshowing.Text = "Showing top 100 results for '" & Me.txtSearch.Text & "'"
        End If
        With dgvmain
            .DataSource = clsPayment.Fetch(13, Me.txtSearch.Text)
            .Columns(0).HeaderText = "Sales #"
            .Columns(0).Width = 108
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).HeaderText = "Date"
            .Columns(1).Width = 100
            .Columns(2).HeaderText = "Customer"
            .Columns(2).Width = 250
            .Columns(3).HeaderText = "Property"
            .Columns(3).Width = 200
            .Columns(4).HeaderText = "Model/Type"
            .Columns(4).Width = 120
            .Columns(5).HeaderText = "Reservation Fee"
            .Columns(5).Width = 120
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).HeaderText = "Status"
            .Columns(6).Width = 100
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).Visible = False
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
        Dim f As New frmInvoiceLibrary
        f.myCurrentFormStatus = frmInvoiceLibrary.enFormStatus.add
        f.ShowDialog()
        If f.issave Then
            Call DisplayList()
        End If
        f.Dispose()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

    End Sub
    Private Sub dgvmain_CellMouseEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvmain.CellMouseEnter
        Try
            Dim myRow As Integer = e.RowIndex
            Dim myCol As Integer = e.ColumnIndex
            If myCol = btncol And myRow <> -1 Then
                dgvmain.Rows(myRow).Cells(myCol).Style.ForeColor = Color.DeepSkyBlue
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
            Dim myRow As Integer = e.RowIndex
            Dim myCol As Integer = e.ColumnIndex
            If myCol = btncol And myRow <> -1 Then
                Dim invoiceno As Long = Me.dgvmain.Rows(myRow).Cells("INVOICENO").Value
                Dim lotid As Long = Me.dgvmain.Rows(myRow).Cells("lotid").Value
                Dim lotname As String = Me.dgvmain.Rows(myRow).Cells("property").Value
                Call clsPayment.PrintPaymentHistory(invoiceno, lotid, lotname)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click
        Try
            If dgvmain.CurrentRow.Index >= 0 Then
                Dim f As New frmSalesOptions
                f.mmoduleid = applicationmodule.modSales
                f.invoiceno = Me.dgvmain.CurrentRow.Cells("INVOICENO").Value
                f.lotid = Me.dgvmain.CurrentRow.Cells("lotid").Value
                f.lotname = Me.dgvmain.CurrentRow.Cells("property").Value
                f.ShowDialog()
                f.Dispose()
                Call DisplayList()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class