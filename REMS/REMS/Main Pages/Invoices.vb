Public Class Invoices
#Region "Methods"
    Public Sub DisplayInvoices()
        Dim Param_Name As String() = {"@action_type", "@sub_action", "@search"}
        Dim Param_Value As String() = {2, 1, GetSearchString(txt_search.Text, Search_Hint_Invoices)}
        Dim MyBridge As New Public_Modules
        With dtgv_Invoices
            .DataSource = MyBridge.CUSTOM_RETRIEVE("SP_Invoices", Param_Name, Param_Value)
            .Columns(0).Width = 100
            .Columns(1).Width = 360
            .Columns(2).Width = 121
            .Columns(3).Width = 121
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
        End With
    End Sub

    Public Sub DisplayAgents(ByRef invoiceno As Integer)
        Dim Param_Name As String() = {"@action_type", "@sub_action", "@invoiceno"}
        Dim Param_Value As String() = {2, 4, invoiceno}
        Dim MyBridge As New Public_Modules
        With dtgv_Uplines
            .DataSource = MyBridge.CUSTOM_RETRIEVE("SP_AgentTree", Param_Name, Param_Value)
            .Columns(0).Visible = False
            .Columns(1).Width = 115
            .Columns(2).Width = 60
            .Columns(3).Width = 75
        End With
    End Sub
    Public Sub DisplayInvoiceDetails(ByRef invoiceno As Integer)
        Dim Param_Name As String() = {"@action_type", "@sub_action", "@invoice_no"}
        Dim Param_Value As String() = {2, 2, invoiceno}
        Dim MyBridge As New Public_Modules
        With dtgv_InvoiceDetails
            .DataSource = MyBridge.CUSTOM_RETRIEVE("SP_Invoices", Param_Name, Param_Value)
            .Columns(0).Visible = False
            .Columns(1).Width = 260
            .Columns(2).Width = 100
            .Columns(3).Width = 121
            .Columns(2).Width = 100
            .Columns(3).Width = 121
        End With
    End Sub
#End Region
    Private Sub Invoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_search.Text = Search_Hint_Invoices
    End Sub
    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        dtgv_Invoices.RowTemplate.Height = Default_Row_Height
        dtgv_InvoiceDetails.RowTemplate.Height = Default_Row_Height
        DisplayInvoices()
    End Sub
    Private Sub txt_search_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.Enter
        If txt_search.Text = Search_Hint_Invoices Then
            txt_search.Text = ""
        End If
    End Sub
    Private Sub txt_search_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.Leave
        If txt_search.Text.Length = 0 Then
            txt_search.Text = Search_Hint_Invoices
        End If
    End Sub
    Private Sub ts_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_add.Click
    End Sub

    Private Sub dtgv_Invoices_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgv_Invoices.SelectionChanged
        Try
            Dim invoiceno As Integer = dtgv_Invoices.CurrentRow.Cells(0).Value
            If invoiceno > 0 Then
                DisplayInvoiceDetails(invoiceno)
                DisplayAgents(invoiceno)
                txt_terms_payment.Text = dtgv_Invoices.CurrentRow.Cells(7).Value.ToString
                txt_interest.Text = dtgv_Invoices.CurrentRow.Cells(6).Value.ToString
                txt_encodedBy.Text = dtgv_Invoices.CurrentRow.Cells(9).Value.ToString

                txt_term_commission.Text = dtgv_Invoices.CurrentRow.Cells(8).Value.ToString
                txt_com_at_down.Text = dtgv_Invoices.CurrentRow.Cells(5).Value.ToString
                txt_com_percentage.Text = dtgv_Invoices.CurrentRow.Cells(4).Value.ToString
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ts_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_edit.Click
        Try
            EditInvoice_Library.InvoiceNo = dtgv_Invoices.CurrentRow.Cells(0).Value
            EditInvoice_Library.ShowDialog()
        Catch ex As Exception

        End Try
        
    End Sub
End Class